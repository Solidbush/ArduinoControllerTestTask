using ArduinoController.Models;
using ArduinoController.Services;
using System.IO.Ports;
using System.Timers;


namespace ArduinoController
{
    public partial class CarNumberChecker : Form
    {
        private const string Connect = "������������";
        private const string Disconnect = "�����������";
        private const string ConnectError = "������ �����������";
        private const string OpenBarrier = "o";
        private const string CloseBarrier = "c";
        private const string GreenLight = "g";
        private const string RedLight = "r";
        private ProcessMananger processMananger;
        public SerialPort MySerialPort = new();

        public CarNumberChecker()
        {
            InitializeComponent();
            processMananger = new ProcessMananger();
        }

        public void SendMessage(string message)
        {
            textBox.Text += message.ToString() + Environment.NewLine;
        }

        private void listBoxChat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdatePorts_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxPorts.Text = "";
            comboBoxPorts.Items.Clear();
            if (ports.Length != 0)
            {
                comboBoxPorts.Items.AddRange(ports);
                comboBoxPorts.SelectedIndex = 0;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text == Connect)
            {
                try
                {
                    MySerialPort.PortName = comboBoxPorts.SelectedItem.ToString();
                    MySerialPort.Open();
                    comboBoxPorts.Enabled = false;
                    buttonConnect.Text = Disconnect;
                    SendMessage($"���������� �������! ����: {comboBoxPorts.SelectedItem.ToString()}");
                }
                catch
                {
                    SendMessage(ConnectError);
                }
            }
            else if (buttonConnect.Text == Disconnect)
            {
                MySerialPort.Close();
                comboBoxPorts.Enabled = true;
                buttonConnect.Text = Connect;
            }
        }

        private void MySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            CarNumber tempCarNumber = new(MySerialPort.ReadLine());
            SendMessage($"����� �����: {tempCarNumber.ToString()}");
            processMananger.AddNumberInQueue(tempCarNumber);
            if(processMananger.GetAllCarNumbersInQueue().Count() > 0) 
            {
                processMananger.DeleteNumberInQueue(tempCarNumber);
                SendMessage($"����� {tempCarNumber.ToString()} �������� � ���������");
                new Thread(() => 
                {
                    Action action = () =>
                    {
                        MySerialPort.Write(OpenBarrier);
                        Thread.Sleep(15000);
                        MySerialPort.Write(CloseBarrier);
                        Thread.Sleep(2000);
                        MySerialPort.Write(GreenLight);
                        Thread.Sleep(2000);
                        MySerialPort.Write(RedLight);
                    };
                    if (InvokeRequired)
                    {
                        Invoke(action);
                    }
                    else
                        action();
                }).Start();
            }   
        }
    }
}