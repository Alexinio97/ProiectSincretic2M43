using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TcpClientServer;

namespace UserApp
{
    public partial class Form1 : Form
    {
        private int commandIndex = 0;
        private static Client client;
        private byte[] command = new byte[1];

        private int drainLevel = 0;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0; //being sure that a value is selected
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //deactivating all pumps
            PrintCommand("Deactivating all pumps");
            ClearWaterLevel();
            byte[] reset = new byte[1];
            reset[0] = 0;
            sendCommandAsync(reset);
        }

        private void btnDeactivate_ClickAsync(object sender, EventArgs e)
        {
            int pumpNumber = int.Parse(comboBox1.SelectedItem.ToString());

            PrintCommand("Deactivating pump " + pumpNumber);
            command[0] = (byte)pumpNumber;
            sendCommandAsync(command);
        }

        private async Task sendCommandAsync(byte[] commandGiven)
        {
            await client.SendAsync(commandGiven);
        }

        private void PrintCommand(string message)
        {
            lstCommands.Items.Add("Command " + ++commandIndex + " - " + message);
        }

        private async Task GetStatusAsync()
        {
            byte[] getStatusByte = new byte[1];
            getStatusByte[0] = 5;
            while (true)
            {
                await client.SendAsync(getStatusByte);
                var statusReceived = await client.ReceiveAsync(4);
                foreach (var data in statusReceived)
                {
                    string pumpStatus = data.ToString(); // first number represents the pump and the second the state of it                   
                    if (pumpStatus[1].Equals('0')) // if pump is off
                        lstStatus.Items.Add("Pump number " + pumpStatus[0] + " is deactivated.");    // tha state cand be either 0 or 1 - off or on
                    else if (pumpStatus[1].Equals('1'))
                        lstStatus.Items.Add("Pump number " + pumpStatus[0] + " is activated.");
                }
                await Task.Delay(2000);
                lstStatus.Items.Clear();
            }
        }

        public async Task RefreshWaterLevelAsync()
        {
            byte[] commandLevel = new byte[1];
            commandLevel[0] = 6;
           
            while (true)
            {
                //var debitFlow = trackBar1.Value;
                await client.SendAsync(commandLevel);
                var pressureLevel = await client.ReceiveAsync(1);
                
                flowLayout_waterLevel.Controls.Clear();
                for (int i = 0; i < pressureLevel[0]; i++)
                {
                    Label wave = new Label();
                    wave.Text = "~~~~~~~~~~~~~~~~~~~~~~~~~~";
                    wave.AutoSize = true;
                    flowLayout_waterLevel.Controls.Add(wave);
                    Console.WriteLine(pressureLevel[0]);
                }
                await Task.Delay(500);
            }
            
        }

        private void ClearWaterLevel()
        {
            flowLayout_waterLevel.Controls.Clear();
        }

        private async void btnStart_ClickAsync(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnDeactivate.Visible = true; // show the first two buttons
            btnReset.Visible = true;
            


            //start connection 
            await Run();
            RefreshWaterLevelAsync();
            GetStatusAsync();
        }

        
        private static async Task Run()
        {
            client = new Client("127.0.0.1", 30000);
            try
            {
                await client.ConnectAsync();
                //MessageBox.Show("Client connected.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Client couldn't connect...");
            }
        }

        private async void BtnRaiseDrainLevel_ClickAsync(object sender, EventArgs e)
        {
             //raise drainLevel and send a command to server
            byte[] raiseDrain = new byte[1] { 7 };
            await client.SendAsync(raiseDrain);
            var received = await client.ReceiveAsync(1);
            drainLevel = received[0];
            lblDrainLevel.Text = drainLevel.ToString();
            
        }

        private async void BtnDownDrainLevel_Click(object sender, EventArgs e)
        {
            //lower drainLevel and send a command to server
            byte[] lowerDrain = new byte[1] { 8 };
            await client.SendAsync(lowerDrain);
            var received = await client.ReceiveAsync(1);
            drainLevel = received[0];
            lblDrainLevel.Text = drainLevel.ToString();
        }
    }
}
    

