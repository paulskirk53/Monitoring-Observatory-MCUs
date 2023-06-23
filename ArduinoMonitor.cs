﻿/********************************************
 * 
 ********  status of this project: *******
 * 
 * Best to look in Github 4-2-22
 * 
 * now the connection strings are sent, for the stepper, on disconnect, must send a string to stop the monitor data flow
 *  as otherwise the port is flooded when a RECONNECTIOn is attempeted
 */

using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoring
{
    
    public partial class ArduinoMonitor : Form
    {

        public ArduinoMonitor()
        {
            InitializeComponent();
           
            cmbPickStepperPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());   //todo this line also appears in arduinomonitor_load
            
            
          //  BTNCamoff.Enabled = false;    // these work ...
            BTNCamon.Enabled = false;
            btnactivate.Enabled = false;
            btnresetControlBox.Text = "No Function";
            btnresetControlBox.Enabled  = false;
            //  Version number generation below - added 4-2-22
            // did not work  int displayableVersion = (int)(DateTime.UtcNow - new DateTime(2022, 1, 1)).TotalDays;
            string version = System.Windows.Forms.Application.ProductVersion;
            label2.Text = String.Format("MCU Monitoring Version {0}", version);
           // label2.Text = "Ver " + displayableVersion.ToString();
        }

       
        ASCOM.Utilities.Serial control_box = new ASCOM.Utilities.Serial();  // new serial port for control box, replaces stepper and encoder ports

        DateTime Now = DateTime.Now;                                       // guess what - this is the system date and time

        private void ArduinoMonitor_Load(object sender, System.EventArgs e)
        {
            //       populate the combo box with port names
            
            // string[] ports = SerialPort.GetPortNames();
            //MessageBox.Show("Test" + ports[0]);
           
        }

       

        private void btnConnectToControlBox_Click(object sender, EventArgs e)
        {
        
            
            if (btnConnectToControlBox.Text == "Connect")    //connect to the encoder MCU
            {
                btnConnectToControlBox.Text = "Waiting for connection";
                btnConnectToControlBox.Refresh();

                try
                {
                   string portName = portFinder(control_box, "monitorcontrol#");
                    
                    control_box.PortName = portName;
                    control_box.DTREnable = false;
                    control_box.RTSEnable = false;
                    control_box.ReceiveTimeout = 5;
                    control_box.Speed = ASCOM.Utilities.SerialSpeed.ps19200;
               
                    control_box.Connected = true;
                    
                    lblControlBox.Text = "Connected on " + control_box.PortName;
                    control_box.ClearBuffers();

                    btnpowerActivate.Enabled = true;   // enable the camera power toggle button
                    btnConnectToControlBox.Text = "Disconnect";
                    lblControlBox.BackColor = Color.Green;
                    tmrControloxRequests.Enabled = true;  // start the timer which requests the data packet from the MCU
                    btnactivate.Enabled = true;    // enable the button to facilitate MCU reset
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Control Box connection failed. Check the MCU is on, connected, and in receive mode." + ex.Message);
                    
                }
            }
            else          // it's disconnect from the encoder MCU
            {


                
                BTNCamon.Enabled = false;
               
                btnpowerActivate.Enabled = false;
                btnactivate.Enabled = false;      // disable the reset toggle button


                tmrControloxRequests.Enabled = false;
                control_boxDisconnect();
            }
        }



        private void tmrControlBoxRequests_Tick(object sender, EventArgs e)
        {                                             
            //THE TIMER INTERVAL is CRITICAL to the MCU performance.
            //If the interval is set lower than 2 seconds, the MCU gets choked and buggered - it slows down so much dealing with available() requests
            // that stepper.run() execution frequency is too low and stepping takes a long time (about 30 seconds to reach an ASCOM Target Azimuth

            // send the interrogation protocol....there are six pices of data to be received from the stepper MCU, each terminated with #
            
            String cameraPowerStatus = "";
            String dataPacket = "";

            // THE TIMEOUT IS IMPORTANT IF it's too short, the system throws an unhandled exception whilst waiting for the MCU to respond
            control_box.ReceiveTimeout = 10;
            //todo need a try - catch here
            control_box.Transmit("dataRequest"); //get the data packet from the MCU

            dataPacket = control_box.ReceiveTerminated("$"); // note new data terminator $
           // dataPacket = dataPacket.Remove('$');   // this line caused a problem with parsing the string
       //     MessageBox.Show(dataPacket );
            //note new string terminator $
            // todo now unpack the data packet - adjust and remove the lines below once tested
            // the operation of the code below is awkward as experimenting (new temp button on UI) shows that if the last item includes a final # one 'extra' array item is generated
            // the problem needs a fix at the time of testing - which may just be not to  process the last item 

            // example  dataPacket = "string1#string 2#end string#another string#$";
            // remember c# strings are 0 indexed so we can refer to the values array as values[0], values[1] etc

            string[] values = dataPacket.Split('#');   //# is the data item delimiter, $is the string terminator

            /* the string items are arranged in the following order when they arrive from the MCU
            dome azimuth,  target azimuth,  movementstate,  querydir,  targetmessage,  cdarray[currentazimut]  - not sure how this works - perhaps a countdown to target achieved?

            camerapowerstate
           */
            //todo setup the individual items below - I think they can all be text for the purposes of the monitor program
            // There are seven items in the string 0 to 6
            // etc
            lblDomeAzimuth.Text = values[0];   // current (dome az)
            lblTarget.Text = values[1];        // Target Az
            lblMoving.Text = values[2];        // movementstate
            lblDirection.Text = values[3];     // querydir - clock or anti clock
            lbltargetStatus.Text = values[4];  // target message
            
          

            lbldegreesToTarget.Text = values[5]; // degrees to target
            

        
            if (values[6] == "1")    //  values[6] is the imaging camera power status
            {
                // set label text to on
                lblCamerapowerstatus.Text = "Power On";
            }
            else
            {
                //set the label text to OFF
                lblCamerapowerstatus.Text = "Power Off";
            }
            if (lbldataTick.Text == "Tick")
            {
                lbldataTick.Text = "Tock";
                lbldataTick.BackColor = Color.DarkRed;
                lbldataTick.ForeColor = Color.Khaki;
            }
            else
            {

                lbldataTick.Text = "Tick";
                lbldataTick.BackColor = Color.Khaki;
                lbldataTick.ForeColor = Color.Black;

            }
        }
    

        private void ArduinoMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            // put the serial port dispose code here rather than in the disconnect button event.
            // that means its possible to connect after disconnect without closing the app 

            control_box.Dispose();
            control_box = null;
           

        }

        private void BTNCamon_Click(object sender, EventArgs e)
        {
            if (control_box.Connected )     // the control box needs to be connected before these commands can work
            {
                if (BTNCamon.Text == "Turn On")
                {
                    control_box.Transmit("CAMON#");
                    BTNCamon.Text = "Turn Off";
                    //  lblCamerapowerstatus.Text = "On";
                }
                else
                {
                    // switch power off
                    control_box.Transmit("CAMOFF#");
                    BTNCamon.Text = "Turn On";
                    // lblCamerapowerstatus.Text = "Off";
                }
            }
            else
            {
                MessageBox.Show("Connect first", "Not cennected error");
            }
        }

        private void BTNCamoff_Click(object sender, EventArgs e)
        {
            //perhaps a the best approcah here is to just send the action and then in the encoder mcu code monitor a status flag and return data into the encoder timer
            //section in this code
            
          //  control_box.Transmit("CAMOFF#");
          //  BTNCamoff.Enabled = false;
          //  BTNCamon.Enabled = true;

        }

        private void btnactivate_Click(object sender, EventArgs e)
        {
            if (btnresetControlBox.Enabled)  // error
            {
                btnresetControlBox.Enabled = false;
                btnresetControlBox.Text = "No function";
            }
            else
            {
                btnresetControlBox.Enabled = true;
                btnresetControlBox.Text = "Reset Control Box";
            }

          
            
        }

      

        private void btnresetEncoder_Click(object sender, EventArgs e)
        {
           
        }

        private void btnpowerActivate_Click(object sender, EventArgs e)
        {
            if (BTNCamon.Enabled )
            {
                BTNCamon.Enabled = false;
            }
            else
            {
                BTNCamon.Enabled = true;
            }

           
        }

        private void control_boxDisconnect()
        {

                      
            control_box.Connected = false;

            lblControlBox.BackColor = Color.Black;
            lblControlBox.Text = "Not connected " + control_box.PortName;
            btnConnectToControlBox.Enabled = true;

            btnConnectToControlBox.Text = "Connect";
            
            
        }

        private string portFinder(ASCOM.Utilities.Serial testPort, string mcuName)  //mcuName will be e.g "encoder" or "stepper"
        {
            /*
             * This routine uses a test port to cycle through the portnames (COM1, COM3 etc), checking each port 
             *  by sending a string recognised by a particular MCU e.g. monitorstepper# or monitorencoder#
             *  if the mcu is on the port, it responds with monitorstepper# or monitorencoder#
             *  the word monitor is a prefix, because the ASCOM driver also uses the same method to identify MCUs it communicates with.
             * */
            setupThePort(testPort);            //set the parameters for testport - baud etc
            bool found = false;
            foreach (string portName in GetUnusedSerialPorts())     // GetUnusedSerialPorts forms a list of COM ports which are available
            {                                      
                found = checkforMCU(testPort, portName, mcuName);     // this checks if the current portName responds to mcuName (monitorstepper# / monitoremcoder#)
                if (found)
                {
                    
                    testPort.Connected = false;                    //disconnect the port
                    return portName;
                    
                }

               
            }
            return null;                // if no ports respond to queries (e.g. perhaps mcus are not connected), the nukk return is picked by the try - catch exception
                                        // of encoder connect or stepper connect
        }

        private bool checkforMCU(ASCOM.Utilities.Serial testPort, string portName, string MCUDescription)
        {
           
            testPort.PortName = portName;  //                      
            testPort.Connected = true;

            //now send data and see what comes back
            try
            {
               
                testPort.Transmit(MCUDescription);            // transmits monitorencoder# or monitorstepper# depending upon where called
                string response = testPort.ReceiveTerminated("#");   // not all ports respond to a query and those which don't respond will timeout

                            
                if (response == MCUDescription)
                {
                
                    return true;            //mcu response match
                }

                testPort.Connected = false;
                return false;              // if there was a response it was not the right MCU
            }
            catch (Exception e)     //TimeoutException
            {
               
                testPort.Connected = false;    // no response
               
            }
            
            return false;
        }
        private void setupThePort(ASCOM.Utilities.Serial testPort)
        {
            //set all the port propereties

            testPort.DTREnable = false;
            testPort.RTSEnable = false;
            testPort.ReceiveTimeout = 5;

            testPort.Speed = ASCOM.Utilities.SerialSpeed.ps19200;



        }



        private string[] GetUnusedSerialPorts()                     //string[] is a string array
        {
            using (ASCOM.Utilities.Serial temp = new ASCOM.Utilities.Serial())
            {
                var ports = new List<string>(temp.AvailableCOMPorts); // List<T> class constructor is used to create a List object of type T. So in this case, available comports
                var busyPorts = new List<string>();

                foreach (var port in ports)
                {
                    try
                    {
                        temp.PortName = port;

                        temp.Connected = true;
                        temp.Connected = false;
                    }
                    catch (Exception)
                    {

                        // If we get here then the current port is currently in use so add it to the busy ports list.

                        busyPorts.Add(port);
                    }
                }

                // Remove the busy ports from the return list.

                foreach (var busyPort in busyPorts)
                {
                    ports.Remove(busyPort);
                }

                return ports.ToArray();               // I think this returns a clean sequential list - no gaps  
            }
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            foreach (string s in GetUnusedSerialPorts() )
            {
                MessageBox.Show("Port name " + s);
            }
        }

        private void toolTipPK_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dataPacket = "";

            control_box.Transmit("dataRequest"); //get the data packet from the MCU

            dataPacket = control_box.ReceiveTerminated("$"); // note new data terminator $
            dataPacket = dataPacket.Remove('$');
        

            string[] values = dataPacket.Split('#');   //# is the data item delimiter, $is the string terminator 

            foreach (string item in values)
            {
                
                MessageBox.Show(" string content is " + item);
            }

        }

        private void btnresetControlBox_Click(object sender, EventArgs e)
        {
            if (control_box.Connected)
            {
                tmrControloxRequests.Enabled = false;            // stop the requests to the encoder MCU
                control_box.Transmit("reset");         // request the reset
                control_box.Connected = false;         // disconnect from the Port
                btnConnectToControlBox.Text = "Connect";
                lblControlBox.Text = "Disconnected";
                lblControlBox.BackColor = Color.Black;

            }
            else
            {
                MessageBox.Show("Must be connected to reset", "Connection Error");
            }
        }
    }



    //roundbutton class - PK
    class RoundButton : Button
    {
        
        protected override void OnPaint(PaintEventArgs pevent)
        {
            
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);

            this.Region = new System.Drawing.Region(gp);

            base.OnPaint(pevent);
        }
    }


}
