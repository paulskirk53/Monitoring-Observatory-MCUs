/********************************************
 * 
 ********  status of this project: *******
 * Connections to the MCUs are complete
 * The code requests to the mcus are complete 
 * Initial test with Stepper MCU returned data
 * Needs test with encoder simulator
 * 
 */

using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //   string[] ports = SerialPort.GetPortNames();
            //   MessageBox.Show("Test" + ports[0]);
            cmbPickStepperPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());   //todo this line also appears in arduinomonitor_load
            lblCommsEncoderValue.BackColor = Color.Black;    //
            lblStatus.BackColor = Color.Black;
          //  BTNCamoff.Enabled = false;    // these work ...
            BTNCamon.Enabled = false;

            //  Version number generation below - added 4-2-22
            int displayableVersion = (int)(DateTime.UtcNow - new DateTime(2022, 1, 1)).TotalDays;
            label2.Text = "Ver " + displayableVersion.ToString();
        }

        ASCOM.Utilities.Serial StepperPort = new ASCOM.Utilities.Serial();   // puting the fing thing here makes it available globally
        ASCOM.Utilities.Serial EncoderPort = new ASCOM.Utilities.Serial();

        DateTime Now = DateTime.Now;                                       // guess what - this is the system date and time

        private void ArduinoMonitor_Load(object sender, System.EventArgs e)
        {
            //       populate the combo box with port names
            
            // string[] ports = SerialPort.GetPortNames();
            //MessageBox.Show("Test" + ports[0]);
           
        }


        private void btnConnectToStepper_Click(object sender, EventArgs e)
        {
            if (btnConnectToStepper.Text == "Connect")
            { 
                try
                {
                    // MessageBox.Show("Test 1" + cmbPickStepperPort.SelectedItem);
                    //  MessageBox.Show("Test 2" + cmbPickStepperPort.SelectedText);
                    //  MessageBox.Show("Test 3" + cmbPickStepperPort.SelectedValue);
                    //  MessageBox.Show("Test 4" + cmbPickStepperPort.SelectedIndex);
                    //ASCOM.Utilities.Serial StepperPort = new ASCOM.Utilities.Serial();


                    StepperPort.PortName = (String)cmbPickStepperPort.SelectedItem;      

                    StepperPort.DTREnable = false;
                    StepperPort.RTSEnable = false;
                    StepperPort.ReceiveTimeout = 10000;

                    StepperPort.Speed = ASCOM.Utilities.SerialSpeed.ps19200;
                    StepperPort.Connected = true;
                    lblStepper.Text = "Connected on " + StepperPort.PortName;
                    StepperPort.ClearBuffers();
                    lblStepper.BackColor = Color.Green;
                    tmrStepperRequests.Enabled = true;
                    //btnConnectToStepper.Enabled = false;
                    
                    btnConnectToStepper.Text = "Disconnect";
                  //  throw new wrongPortException();
                }
                catch (Exception)              //substitute wrongPortException ex when we get to testing the data from the port
                {
                    // substitute this when you get to it MessageBox.Show(ex.Message + "Stepper connection failed. Check the MCUs are on, connected, and in receive mode.");
                    MessageBox.Show("Stepper connection failed. Check the MCUs are on, connected, and in receive mode.");
                }
          }
          else
          {
                //it's disconnect
                stepperDisconnect();
            }
        }

        private void btnConnectToEncoder_Click(object sender, EventArgs e)
        {

            if (btnConnectToEncoder.Text == "Connect")    //connect to the encoder MCU
            {
                try
                {

                    EncoderPort.PortName = (String)cmbPickStepperPort.SelectedItem;
                    EncoderPort.DTREnable = false;
                    EncoderPort.RTSEnable = false;
                    EncoderPort.ReceiveTimeout = 10000;

                    EncoderPort.Speed = ASCOM.Utilities.SerialSpeed.ps19200;
               //     MessageBox.Show("Encoder PORT name...." + EncoderPort.PortName + "  " + EncoderPort.Speed);
                    EncoderPort.Connected = true;
                    lblEncoder.Text = "Connected on " + EncoderPort.PortName;
                    EncoderPort.ClearBuffers();
                    lblEncoder.BackColor = Color.Green;
                    // lblEncoder.Text = "Active";
                    // ADD THE TIMER START HERE
                    tmrEncoderRequests.Enabled = true;
                    
                    btnConnectToEncoder.Text = "Disconnect";
                    btnpowerActivate.Enabled = true;
                    

                }
                catch (Exception)
                {
                    MessageBox.Show("Encoder connection failed. Check the MCUs are on, connected, and in receive mode.");
                }
            }
            else          // it's disconnect from the encoder MCU
            {
                tmrEncoderRequests.Enabled = false;
                EncoderPort.Connected = false;

                lblEncoder.BackColor = Color.Black;
                btnConnectToEncoder.Enabled = true;

                BTNCamon.Enabled = false;
                btnConnectToEncoder.Text = "Connect";
                lblStatus.Text = "unknown";
                lblStatus.BackColor = Color.Black;
                btnpowerActivate.Enabled = false;
                btnactivate.Enabled = false;      // disable the reset toggle button


            }
        }



        private void tmrStepperRequests_Tick(object sender, EventArgs e)
        {                                              //THE TIMER INTERVAL MIGHT BE INCREASED NOW THAT  the while loop is not used, note the previous value here though
            int misscount = 0;
            // send the interrogation protocol....there are six pices of data to be received from the stepper MCU, each terminated with #
            
            try
            {
               // MessageBox.Show("in stepper timer try ");
                string ReceivedItem = "";

                /* 
                 while (ReceivedItem != "START#")                         // wait until start sequence is received
                 {
                     ReceivedItem = StepperPort.ReceiveTerminated("#");
                    // MessageBox.Show("Received " + ReceivedItem);


                 }
                 */
                ReceivedItem = StepperPort.ReceiveTerminated("#");     //REMOVE THIS LINE IF THE CODE IS REVERTED to use the while loop
                if (ReceivedItem == "START#")                          //remove this if stmt and its braces if reverting back to the while loop
                {

                    string TargetAzimuth = StepperPort.ReceiveTerminated("#");
                    TargetAzimuth = TargetAzimuth.Replace("#", "");

                    string MovementState = StepperPort.ReceiveTerminated("#");
                    MovementState = MovementState.Replace("#", "");

                    string QueryDir = StepperPort.ReceiveTerminated("#");
                    QueryDir = QueryDir.Replace("#", "");

                    string TargetMessage = StepperPort.ReceiveTerminated("#");
                    TargetMessage = TargetMessage.Replace("#", "");           //the MCU creates a string which shows distance to target and then changes to Target Achieved

                    string AngleMod360 = StepperPort.ReceiveTerminated("#");
                    AngleMod360 = AngleMod360.Replace("#", "");               //This is the Azimuth the stepper receives from the encoder

                    string EncoderReplyCounter = StepperPort.ReceiveTerminated("#");
                    EncoderReplyCounter = EncoderReplyCounter.Replace("#", "");

                    // now set the form labels to the values received from the MCUs
                    lblTarget.Text = TargetAzimuth;
                    lblDirection.Text = QueryDir;
                    lblMoving.Text = MovementState;
                    lblDistance.Text = TargetMessage;
                    lblAzimuth.Text = AngleMod360;

                    //if the value of EncoderReplyCounter is changing, set the colour property of lblcommsencodervalue to green. If its not green, its red
                    // e.g. compare the strings and if equal then set colour to red (comms fail), if different set to green
                    bool equal = String.Equals(EncoderReplyCounter, lblCommsEncoderValue.Text, StringComparison.InvariantCulture);
                    if (equal)
                    {
                        lblCommsEncoderValue.BackColor = Color.DimGray;     // comms between Stepper MCU and Encoder MCU has failed
                    }
                    else
                    {
                        lblCommsEncoderValue.BackColor = Color.Green;

                    }

                    lblCommsEncoderValue.Text = EncoderReplyCounter;   // July '21 looks like this may not be needed as the if stmt above gives status

                }
            }
            catch (Exception)
            {

                misscount++;
                MessageBox.Show("Stepper data return failure");
            }
           
        }

        private void tmrEncoderRequests_Tick(object sender, EventArgs e)
        {
            
            String Azimuth             = "";
            String StepperReplyCounter = "";
            String cameraPowerStatus   = "";

            // send the interrogation protocol....there are two pieces of data to be received, each terminated with #
             EncoderPort .Transmit("EncoderRequest#");

             Azimuth = EncoderPort.ReceiveTerminated("#");
             Azimuth = Azimuth.Replace("#", "");

             StepperReplyCounter = EncoderPort.ReceiveTerminated("#");
             StepperReplyCounter = StepperReplyCounter.Replace("#", "");             // this is a simulated (in the MCU code) value

           cameraPowerStatus = EncoderPort.ReceiveTerminated("#");
           cameraPowerStatus = cameraPowerStatus.Replace("#", "");


            lblAzimuthValue.Text = Azimuth;                        //display the azimuth on the label

            // check if the last two counter values are the same, if they are comms between the encoder and stepper MCUs has failed.

            bool equal = String.Equals(StepperReplyCounter, lblStatus.Text, StringComparison.InvariantCulture);   

            if (equal)
            {
                lblStatus.BackColor = Color.Red;     // comms between Stepper MCU and Encoder MCU has failed....
            }
            else
            {
                lblStatus.BackColor = Color.Green;  //green?
            }

            lblStatus.Text = StepperReplyCounter;          //display the count on the label

            //now check the status of the camera power and set the labels accordinly

            if (cameraPowerStatus == "ON")
            {
                // set label text to on
                lblCamerapowerstatus.Text = "Power On";
            }
            else
            {
                //set the label text to OFF
                lblCamerapowerstatus.Text = "Power Off";
            }

        }

        private void ArduinoMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            // put the serial port dispose code here rather than in the disconnect button event.
            // that means its possible to connect after disconnect without closing the app 

            EncoderPort.Dispose();
            EncoderPort = null;
            StepperPort.Dispose();
            StepperPort = null;

        }

        private void BTNCamon_Click(object sender, EventArgs e)
        {
            if (BTNCamon.Text == "Turn On")
            {
                EncoderPort.Transmit("CAMON#");
                BTNCamon.Text = "Turn Off";
            }
            else
            {
                // switch power off
                EncoderPort.Transmit("CAMOFF#");
                BTNCamon.Text = "Turn On";
            }
        }

        private void BTNCamoff_Click(object sender, EventArgs e)
        {
            //perhaps a the best approcah here is to just send the action and then in the encoder mcu code monitor a status flag and return data into the encoder timer
            //section in this code
            
          //  EncoderPort.Transmit("CAMOFF#");
          //  BTNCamoff.Enabled = false;
          //  BTNCamon.Enabled = true;

        }

        private void btnactivate_Click(object sender, EventArgs e)
        {
            if (btnresetEncoder.Enabled)
            {
                btnresetEncoder.Enabled = false;
            }
            else
            {
                btnresetEncoder.Enabled = true;
            }

            if(btnresetStepper.Enabled)
            {
                btnresetStepper.Enabled = false;
            }
            else
            {
                btnresetStepper.Enabled = true;
            }

            
        }

        private void btnresetStepper_Click(object sender, EventArgs e)
        {
            if (StepperPort.Connected)
            {
                tmrStepperRequests.Enabled = false;     // stop the requests to the Stepper MCU
                StepperPort.Transmit("reset");          // request the reset
                StepperPort.Connected = false;          // disconnect from the Port
            }
        }

        private void btnresetEncoder_Click(object sender, EventArgs e)
        {
            if (EncoderPort.Connected)
            {
                tmrEncoderRequests.Enabled = false;    // stop the requests to the encoder MCU
                EncoderPort.Transmit("reset");         // request the reset
                EncoderPort.Connected = false;         // disconnect from the Port
                btnConnectToEncoder.Text = "Connect";
            }
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

        private void stepperDisconnect()
        {
            tmrStepperRequests.Enabled = false;
            StepperPort.Connected = false;

            lblStepper.BackColor = Color.Black;
            btnConnectToStepper.Enabled = true;

            btnConnectToStepper.Text = "Connect";
            lblCommsEncoderValue.Text = "unknown";
            lblCommsEncoderValue.BackColor = Color.Black;
        }
    }

    //new below for custom exception when connecting to the port send Query and await for reply Stepper
    // if (!Stepper i.e. wrong port) throw new wrongPortException();
    // in catch stmt put catch (wrongPortException one)
    // in catch block put:
    // MessageBox.Show(one.Message + "Stepper connection failed. Check the MCUs are on, connected, and in receive mode.");
    // disconnect - need MCU ports to respond to Query what happens if they timeout?
    public class wrongPortException : Exception
    {                                             //use like this throw new wrongPortException
        public override string Message
        {
            get
            {
                return "My error message here";
            }
        }
    }

    // end new custom exception




}
