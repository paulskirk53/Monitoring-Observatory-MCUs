/********************************************
 * 
 ********  status of this project: *******
 * 
 * Best to look in Github 17-12-25
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitoring
{
    
    public partial class ArduinoMonitor : Form
    {

        public ArduinoMonitor()
        {
            InitializeComponent();
                 
            
          //  BTNCamoff.Enabled = false;    // these work ...
            BTNCameraSwitch.Enabled = false;
            btnactivate.Enabled = false;
            btnresetControlBox.Text = "No Function";
            btnresetControlBox.Enabled  = false;
            //  Version number generation below - added 4-2-22
            // did not work  int displayableVersion = (int)(DateTime.UtcNow - new DateTime(2022, 1, 1)).TotalDays;
            string version = System.Windows.Forms.Application.ProductVersion;
            label2.Text = String.Format("MCU Monitoring Version {0}", version);
           // label2.Text = "Ver " + displayableVersion.ToString();
        }


        SerialPort control_box = new SerialPort(); // new serial port for control box, replaces stepper and encoder ports

        DateTime Now = DateTime.Now;                                       // guess what - this is the system date and time

        private void ArduinoMonitor_Load(object sender, System.EventArgs e)
        {
            //       populate the combo box with port names

            // string[] ports = SerialPort.GetPortNames();
            //MessageBox.Show("Test" + ports[0]);
            string version = System.Windows.Forms.Application.ProductVersion;
            label2.Text = String.Format("MCU Monitoring Version {0}", version);
        }







        private void tmrControlBoxRequests_Tick(object sender, EventArgs e)
        {
            try
            {
                control_box.ReadTimeout = 5000;
                control_box.Write("dataRequest#");
            }
            catch (InvalidOperationException)
            {
                tmrControlBoxRequests.Enabled = false;
                MessageBox.Show("Port is closed. Fix connection and restart.");
                Environment.Exit(0);
            }
            catch (TimeoutException)
            {
                tmrControlBoxRequests.Enabled = false;
                MessageBox.Show("Timeout. Try reconnecting the cable.");
                control_boxDisconnect();
                Connect();
            }
            catch (Exception ex)
            {
                tmrControlBoxRequests.Enabled = false;
                MessageBox.Show("Unexpected error: " + ex.Message);
                Environment.Exit(0);
            }
        }


        private void ArduinoMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            // put the serial port dispose code here rather than in the disconnect button event.
            // that means its possible to connect after disconnect without closing the app 

            control_box.Dispose();
            control_box = null;
           

        }

        private void BTNCameraSwitch_Click(object sender, EventArgs e)
        {
            CameraPowerSwitch();  // check the power state and toggle switch as appropriate
        }

        private void CameraPowerSwitch()   //toggle the power state
        {
            if (control_box.IsOpen)     // the control box Serial port needs to be connected before these commands can work
            {
                if (BTNCameraSwitch.Text == "Turn On")
                {
                    control_box.Write("CAMON#");
                    BTNCameraSwitch.Text = "Turn Off";
                    
                }
                else
                {
                    // switch power off
                    control_box.Write("CAMOFF#");
                    BTNCameraSwitch.Text = "Turn On";
                    
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
            
          //  control_box.Write("CAMOFF#");
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
            if (BTNCameraSwitch.Enabled )
            {
                BTNCameraSwitch.Enabled = false;
            }
            else
            {
                BTNCameraSwitch.Enabled = true;
            }

           
        }

        private void control_boxDisconnect()
        {
            if ((control_box != null) & control_box.IsOpen)
            {
                //new cancel option

                // Ask the user if they really want to disconnect
                var confirm = MessageBox.Show(
                    "Are you sure you want to disconnect?",
                    "Confirm Disconnect",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Cancel)
                {
                    // User clicked CANCEL → abort everything
                    return;
                }

                if (confirm == DialogResult.No)
                {
                    // User clicked NO → do not disconnect
                    return;
                }

                // If we reach here, user clicked YES → continue with disconnect logic

                //end new cancel option
                control_box.DataReceived -= control_box_DataReceived;

                // is the camera power still on? give the user a choice to turn it off before exit
                if (BTNCameraSwitch.Text == "Turn Off")   // if this condition is true, the power is on
                {
                    const string message = "Yes = Turn off the camera / Rotator Power before exit," + "\n" + "No = leave the power on and exit";
                    const string caption = "Disconnecting....";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                    // If the yes button was pressed ...
                    if (result == DialogResult.Yes)
                    {
                        CameraPowerSwitch();    // switch the power off
                    }
                }

                //new 13-11-23

                // set up a dialog to request user input over how the azimuth is treated when the MCU disconnects
                const string resetMessage = "Yes = the current Azimuth is preserved," + "\n" + "\n" + "No = Azimuth will be set to Park Azimuth.";
                const string resetCaption = "Preserve the current Azimuth in EEPROM ?";
                var resetResult = MessageBox.Show(resetMessage, resetCaption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                // If the No (don't preserve current azimuth button was pressed ...
                if (resetResult == DialogResult.No)
                {
                    control_box.Write("nokeepaz#");
                }
                //if the yes button is presssed, preserve the current azimuth in eeprom
                if (resetResult == DialogResult.Yes)
                {
                    control_box.Write("keepaz#");
                }
                


                lblControlBox.BackColor = Color.Black;
                lblControlBox.Text = "last seen on port " + control_box.PortName;

                rbtnConnect.Enabled = true;

                if (control_box.IsOpen)     // disconnect the port
                { 
                    control_box.Close();
                }
                rbtnConnect.Text = "Connect";
                lblsync.Text = "No data";

            }
        }

        private string portFinder(SerialPort testPort, string mcuName)  //mcuName will be e.g "encoder" or "stepper"
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
               // MessageBox.Show("checking port " + portName);
                found = checkforMCU(testPort, portName, mcuName);     // this checks if the current portName responds to mcuName (monitorstepper# / monitoremcoder#)
                if (found)
                {
                    
                    if(testPort.IsOpen)
                    {
                        testPort.Close();
                    }//disconnect the port
                    return portName;
                    
                }

               
            }
            return null;                // if no ports respond to queries (e.g. perhaps mcus are not IsOpen), the nukk return is picked by the try - catch exception
                                        // of encoder connect or stepper connect
        }

        private bool checkforMCU(SerialPort testPort, string portName, string MCUDescription)
        {
           
            testPort.PortName = portName;  //                      
            testPort.Open() ;
            testPort.ReadTimeout = 5000;

            //now send data and see what comes back
            try
            {
                
                testPort.Write(MCUDescription);            // Writes monitorencoder# or monitorstepper# depending upon where called
                //MessageBox.Show("writing mcu description to port " + portName);

                string response = testPort.ReadTo("#");   // not all ports respond to a query and those which don't respond will timeout
                
                //MessageBox.Show("testing Port  " + portName + " MCU Description " + MCUDescription + " response from mcu " + response);

                if (MCUDescription.Contains( response))   // deals with the '#' in the MCUDescription
                {
                
                    return true;            //mcu response match
                }

                if (testPort.IsOpen)
                {
                    testPort.Close();
                }//disconnect the port
                return false;              // if there was a response it was not the right MCU
            }
            catch (Exception e)     //TimeoutException
            {
                if (testPort.IsOpen)
                {
                    testPort.Close();
                }//disconnect the port
                 // no response
               
            }
            
            return false;
        }
        private void setupThePort(System.IO.Ports.SerialPort testPort)
        {
            // Set port properties
            testPort.DtrEnable = false;
            testPort.RtsEnable = false;

            // Timeout in milliseconds (5 ms is extremely short, but matches your ASCOM code)
            testPort.ReadTimeout = 5000;

            // Replace ASCOM Speed with SerialPort BaudRate
            testPort.BaudRate = 19200;

            // You may also want to explicitly set these:
            testPort.Parity = Parity.None;
            testPort.DataBits = 8;
            testPort.StopBits = StopBits.One;
        }

        

private string[] GetUnusedSerialPorts()
    {
        var ports = new List<string>(SerialPort.GetPortNames());
        var busyPorts = new List<string>();

        foreach (var port in ports)
        {
              //  MessageBox.Show("Port name " + port);
                try
            {
                using (var sp = new SerialPort(port))
                {
                    sp.Open();     // If this fails, the port is busy
                    sp.Close();
                }
            }
            catch
            {
                // Port is in use or cannot be opened
                busyPorts.Add(port);
            }
        }

        // Remove busy ports
        foreach (var busy in busyPorts)
        {
            ports.Remove(busy);
           //     MessageBox.Show("busy " + busy);
            }

        return ports.ToArray();
    }


      

        

        private void toolTipPK_Popup(object sender, PopupEventArgs e)
        {

        }

       

        private void btnresetControlBox_Click(object sender, EventArgs e)
        {
            if (control_box.IsOpen)
            {
                MessageBox.Show("Azimuth value is preserved on reset");
                tmrControlBoxRequests.Enabled = false;            // stop the requests to the encoder MCU
                control_box.Write("reset#");         // request the reset
                if (control_box.IsOpen)
                {
                    control_box.Close();
                }

                // old version control_box.IsOpen = false;         // disconnect from the Port
                rbtnConnect.Text = "Connect";
                lblControlBox.Text = "Disconnect";
                lblControlBox.BackColor = Color.Black;

            }
            else
            {
                MessageBox.Show("Must be connected to reset", "Connection Error");
            }
        }

        private void rbtnConnect_Click(object sender, EventArgs e)
        {
            
            Connect();    // code for this routine below
        }

        private void Connect()
        {

            if (rbtnConnect.Text == "Connect")    //connect to the encoder MCU
            {
                rbtnConnect.Text = "Waiting for connection";
                rbtnConnect.Refresh();

                try
                {
                    string portName = portFinder(control_box, "monitorcontrol#");

                    control_box.PortName = portName;
                    control_box.DtrEnable = false;
                    control_box.RtsEnable = false;
                    control_box.ReadTimeout = 5000;
                    control_box.BaudRate = 19200;

                    control_box.Open();  // open port
                    //todo uncomment the line below to activate event driven serial
                    control_box.DataReceived += control_box_DataReceived;   // activate the serial event handler -
                                                                            // it can be deactivated by control_box.DataReceived -= control_box_DataReceived;


                    lblControlBox.Text = "Connected on " + control_box.PortName;
                   // todo check equivalent of this line control_box.ClearBuffers();

                    btnpowerActivate.Enabled = true;   // enable the camera power toggle button
                    rbtnConnect.Text = "Disconnect";
                    lblControlBox.BackColor = Color.Green;
                    tmrControlBoxRequests.Enabled = true;  // start the timer which requests the data packet from the MCU
                    btnactivate.Enabled = true;    // enable the button to facilitate MCU reset
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Control Box connection failed. Check the MCU is on, connected, and in receive mode." + ex.Message);

                    control_boxDisconnect();
                    rbtnConnect.Text = "Connect";

                }
            }
            else          // it's disconnect from the encoder MCU
            {



                BTNCameraSwitch.Enabled = false;

                btnpowerActivate.Enabled = false;
                btnactivate.Enabled = false;      // disable the reset toggle button


                tmrControlBoxRequests.Enabled = false;
                control_boxDisconnect();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            // Get the numeric value
            int homeValue = (int)numericUpDownHome.Value;
            int parkValue = (int)numericUpDownPark.Value;

            // Convert to string and append '#'
            string homeMessage = "SH" + homeValue.ToString() + "#";    //send the home azimuth to the MCU for storage in eeprom
            
            string parkMessage = "SP" + parkValue.ToString() + "#";    //send the park azimuth to the MCU for storage in eeprom

            // Send via serial port
            if (control_box.IsOpen)
            {
                control_box.Write(homeMessage);
                Thread.Sleep(100);
                control_box.Write(parkMessage);
               // MessageBox.Show(" messages are "+ homeMessage + " " + parkMessage);
            }
            else
            {
                MessageBox.Show("Serial port is not open.");
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            control_box.ReadTimeout = 5000;

            try
            {
                if (!control_box.IsOpen)
                {
                    MessageBox.Show("Serial port is not connected.");
                    return;
                }

                // --- Step 1: Send GH# ---
                control_box.Write("GH#");

                Thread.Sleep(100);
              
                // --- Step 2: Send GP# ---
                control_box.Write("GP#");

              
            }
            catch (Exception ex)
            {
                MessageBox.Show("catch Error: " + ex.Message);
            }
        }
        private void control_box_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string raw = control_box.ReadTo("#");   // read up to terminator
                RouteMessage(raw);
            }
            catch (TimeoutException)
            {
                // optional: log or ignore
            }
            catch (Exception ex)
            {
                // optional: log
            }
        }
        private void RouteMessage(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                return;

            int idx = message.IndexOf(':');
            if (idx < 0)
                return;

            string prefix = message.Substring(0, idx);   //extract the data prefix
            string payload = message.Substring(idx + 1); // extract the remainder of the string

            switch (prefix)
            {
                case "DP":
                    HandleDataPacket(payload);
                    break;

                case "HOME":
                    HandleHome(payload);
                    break;

                case "PARK":
                    HandlePark(payload);
                    break;

                case "SLEW":
                    HandleSlew(payload);
                    break;

                default:
                    // Unknown prefix
                    break;
            }
        }


        private void HandleHome(string payload)
        {
            if (int.TryParse(payload, out int homeAzimuth) &&
                homeAzimuth >= 0 && homeAzimuth <= 360)
            {
                BeginInvoke(new Action(() =>
                {
                    lblHomeValue.Text = homeAzimuth.ToString();
                }));
            }
            else
            {
                BeginInvoke(new Action(() =>
                {
                    lblHomeValue.Text = "Error";
                }));
            }
        }

        private void HandlePark(string payload)
        {
            if (int.TryParse(payload, out int parkAzimuth) &&
                parkAzimuth >= 0 && parkAzimuth <= 360)
            {
                BeginInvoke(new Action(() =>
                {
                    lblParkValue.Text = parkAzimuth.ToString();
                }));
            }
            else
            {
                BeginInvoke(new Action(() =>
                {
                    lblParkValue.Text = "Error";
                }));
            }
        }

        private void HandleSlew(string payload)
        {
            BeginInvoke(new Action(() =>
            {
                if (payload.Equals("slew-start", StringComparison.OrdinalIgnoreCase))
                {
                    tmrControlBoxRequests.Interval = 1500;
                }
                else if (payload.Equals("slew-end", StringComparison.OrdinalIgnoreCase))
                {
                    tmrControlBoxRequests.Interval = 5000;
                }
            }));
        }



        private void HandleDataPacket(string payload)
        {
            // split by comma
            string[] v = payload.Split(',');

            if (v.Length < 8)
                return; // malformed packet

            // UI updates must be marshalled to UI thread
            BeginInvoke(new Action(() =>
            {
            lblDomeAzimuth.Text     = v[0];
            lblTarget.Text          = v[1];
            lblMoving.Text          = v[2];
            lblDirection.Text       = v[3];
            lbltargetStatus.Text    = v[4];
            lbldegreesToTarget.Text = v[5];

            lblCamerapowerstatus.Text = (v[6] == "1" || v[6].Equals("ON", StringComparison.OrdinalIgnoreCase))
                                        ? "Power On"
                                        : "Power Off";

            lblsync.Text = v[7];

            // The tick indicator
            if (lbldataTick.Text.Contains("Secs"))
            {
                lbldataTick.Text = "    ";
                lbldataTick.BackColor = Color.Transparent;
                lbldataTick.ForeColor = Color.Khaki;
            }
            else
            {
                lbldataTick.Text = (tmrControlBoxRequests.Interval / 1000).ToString() + " Secs";
                    //lbldataTick.Text = "Pull";
                 lbldataTick.BackColor = Color.Khaki;
                 lbldataTick.ForeColor = Color.Black;
                }
            }));
        }

        private void tmrHAL_Tick(object sender, EventArgs e)
        {
            if (label2.Text == "Open the airlock HAL")
            { 
                label2.Text = "I can't do that Dave";
            }
            else 
            {
                label2.Text = "Open the airlock HAL"; ;
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
