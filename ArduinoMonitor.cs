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
            cmbPickStepperPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            lblCommsEncoderValue.BackColor = Color.Red;
           // lblStatus.BackColor = Color.Red;

        }

        ASCOM.Utilities.Serial StepperPort = new ASCOM.Utilities.Serial();   // puting the fing thing here makes it available globally
        ASCOM.Utilities.Serial EncoderPort = new ASCOM.Utilities.Serial();

        DateTime Now = DateTime.Now;                                       // guess what - this is the system date and time

        private void ArduinoMonitor_Load(object sender, System.EventArgs e)
        {
            //       populate the combo box with port names
            cmbPickStepperPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
           // string[] ports = SerialPort.GetPortNames();
            //MessageBox.Show("Test" + ports[0]);
        }


        private void btnConnectToStepper_Click(object sender, EventArgs e)
        {
            try
            {
                // MessageBox.Show("Test 1" + cmbPickStepperPort.SelectedItem);
                //  MessageBox.Show("Test 2" + cmbPickStepperPort.SelectedText);
                //  MessageBox.Show("Test 3" + cmbPickStepperPort.SelectedValue);
                //  MessageBox.Show("Test 4" + cmbPickStepperPort.SelectedIndex);
                //ASCOM.Utilities.Serial StepperPort = new ASCOM.Utilities.Serial();

               
                StepperPort.PortName = (String)cmbPickStepperPort.SelectedItem;            //"COM6";
           
                StepperPort.DTREnable = false;
                StepperPort.RTSEnable = false;
                StepperPort.ReceiveTimeout = 10000;

                StepperPort.Speed = ASCOM.Utilities.SerialSpeed.ps19200;
                StepperPort.Connected = true;
                StepperPort.ClearBuffers();
                lblStepper.BackColor = Color.Green ;
                tmrStepperRequests.Enabled = true;
                btnConnectToStepper.Enabled = false;
                btnDisconnectStepper.Enabled = true;
            }
            catch (Exception )
            {
                MessageBox.Show("Stepper connection didn't work...Pick a port first....");      //+ Stepper.ToString());
            }
        }

        private void btnConnectToEncoder_Click(object sender, EventArgs e)
        {
    

            try
            {
                
                EncoderPort.PortName = (String)cmbPickStepperPort.SelectedItem;
                EncoderPort.DTREnable = false;
                EncoderPort.RTSEnable = false;
                EncoderPort.ReceiveTimeout = 10000;

                EncoderPort.Speed = ASCOM.Utilities.SerialSpeed.ps19200;
                EncoderPort.Connected = true;
                EncoderPort.ClearBuffers();
                lblEncoder.BackColor = Color.Green;
                lblEncoder.Text = "Active";
                // ADD THE TIMER START HERE
                tmrEncoderRequests.Enabled = true;
                btnConnectToEncoder.Enabled = false;   // once connected disable this button
                btnDisconnectEncoder.Enabled = true;   // once connected enable the disconnect button
            }
            catch (Exception )
            {
                MessageBox.Show("Encoder connection didn't work...Pick a port first....");      
            }
        }

        private void btnDisconnectStepper_Click(object sender, EventArgs e)
        {
            tmrStepperRequests.Enabled = false;
            StepperPort.Connected = false;
          
            lblStepper.BackColor = Color.Black;
            btnConnectToStepper.Enabled = true;
            btnDisconnectStepper.Enabled = false;
        }

        private void btnDisconnectEncoder_Click(object sender, EventArgs e)
        {
            tmrEncoderRequests.Enabled = false;
            EncoderPort.Connected = false;
           // EncoderPort.Dispose();
        //    EncoderPort = null;
            lblEncoder.BackColor = Color.Black;
            btnConnectToEncoder.Enabled = true;
            btnDisconnectEncoder.Enabled = false;
        }

        private void tmrStepperRequests_Tick(object sender, EventArgs e)
        {
            int misscount = 0;
            // send the interrogation protocol....there are six pices of data to be received from the stepper MCU, each terminated with #
            //StepperPort.Transmit("Ping#");
            try
            {
                //read individual items, check each one and assign to the correct label
                // or read items until 'START' item is reached, then read six and assign
                // this approach needs the MCU to send 'START#'
                string ReceivedItem = "";
                
                
                while (ReceivedItem != "START#")
                {
                    ReceivedItem = StepperPort.ReceiveTerminated("#");
                }
               
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
                bool equal = String.Equals(EncoderReplyCounter, lblStatusValue.Text, StringComparison.InvariantCulture);
                if (equal)
                {
                    lblCommsEncoderValue.BackColor = Color.DimGray;     // comms between Stepper MCU and Encoder MCU has failed
                }
                else
                {
                    lblCommsEncoderValue.BackColor = Color.Green;

                }

                lblStatusValue.Text = EncoderReplyCounter;   // July '21 looks like this may not be needed as the if stmt above gives status

            }
            catch (Exception)
            {

                misscount++;
            }
           
        }

        private void tmrEncoderRequests_Tick(object sender, EventArgs e)
        {
            string Azimuth = "";
            String StepperReplyCounter = "";

            // send the interrogation protocol....there are two pieces of data to be received, each terminated with #
            EncoderPort .Transmit("EncoderRequest#");

             Azimuth = EncoderPort.ReceiveTerminated("#");
            Azimuth = Azimuth.Replace("#", "");

             StepperReplyCounter = EncoderPort.ReceiveTerminated("#");
            StepperReplyCounter = StepperReplyCounter.Replace("#", "");             // this is a simulated (in the MCU code) value

            
            lblAzimuthValue.Text = Azimuth;

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

            lblStatus.Text = StepperReplyCounter;

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
    }
}
