using System;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HomeRobotHUD
{
    public class Serial
    {
        private SerialPort comPort = new SerialPort();
        private string PortName = "COM4";
        private string BaudRate = "115200";
        private string DataBit = "8";
        private string StopBit = "1";
        private string Parity = "0";

        private static Main_Form MainForm;

        public Serial(Main_Form form)
        {
            MainForm = form;
        }

        public SerialPort GetSerialPort()
        {
            return comPort;
        }

        public Serial(string PortName, string BaudRate, string DataBit, string StopBit, string Parity)
        {
            this.PortName = PortName;
            this.BaudRate = BaudRate;
            this.DataBit = DataBit;
            this.StopBit = StopBit;
            this.Parity = Parity;

            Connect(PortName, BaudRate, DataBit, StopBit, Parity);
        }

        public bool Connect(string PortName, string BaudRate, string DataBit, string StopBit, string Parity)
        {
            this.PortName = PortName;
            this.BaudRate = BaudRate;
            this.DataBit = DataBit;
            this.StopBit = StopBit;
            this.Parity = Parity;

            return Connect();
        }

        public bool Connect()
        {
            try
            {
                if (comPort.IsOpen == true)
                {
                    Console.WriteLine("Cannot connect! A connection is currently open.");
                    Disconnect();
                }

                comPort.PortName = PortName;
                comPort.BaudRate = int.Parse(BaudRate);
                comPort.DataBits = int.Parse(DataBit);
                comPort.StopBits = StopBits.One;
                comPort.Parity = 0;
                comPort.Open();


                Console.WriteLine();
                Console.WriteLine("Starting connection");
                Console.WriteLine("   Serial port:   " + PortName);
                Console.WriteLine("   Baud rate:  " + BaudRate);
                Console.WriteLine("   Data bits:  " + DataBit);
                Console.WriteLine("   Stop bits:  " + StopBit);
                Console.WriteLine("   Parity:     " + Parity);
                Console.WriteLine("Connected on port " + PortName + ".");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to connect on port " + PortName);
                Console.WriteLine(ex);
                return false;
            }
        }


        public bool Disconnect()
        {
            try
            {
                Console.Write("Closing connection on port " + PortName + "...");
                if (comPort.IsOpen == true)
                {
                    comPort.Close();
                    Console.WriteLine("Done");
                    return true;
                }
                else
                {
                    Console.WriteLine("Not connected");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
                Console.WriteLine(ex);
                return false;
            }
        }

        public bool AddEventHandler(SerialDataReceivedEventHandler e)
        {


            return true;
        }

        public bool SendCommand(String command)
        {
            if (!String.IsNullOrEmpty(command))
            {

                String[] commandArray = command.Split(' ');
                /*
                String str = "œ";
                var bytes = Encoding.GetEncoding("Windows-1252").GetBytes(str);
                string binStr = string.Join("", bytes.Select(b => Convert.ToString(b, 2)));
                int decimalEquivalent = Convert.ToInt32(binStr, 2);
                Console.WriteLine(decimalEquivalent);
                Convert.ToInt32((string.Join("", (Encoding.GetEncoding("Windows-1252").GetBytes("œ")).Select(b => Convert.ToString(b, 2)))), 2);
                */
                byte myByte = 255;
                // send the command
                GetSerialPort().Write(new byte[]{
                        (byte)Convert.ToInt32((string.Join("", (Encoding.GetEncoding("Windows-1252").GetBytes(commandArray[0].Replace("\n", ""))).Select(b => Convert.ToString(b, 2)))), 2),
                        (byte)Convert.ToInt32((string.Join("", (Encoding.GetEncoding("Windows-1252").GetBytes(commandArray[1].Replace("\n", ""))).Select(b => Convert.ToString(b, 2)))), 2),
                        (byte)Convert.ToInt32((string.Join("", (Encoding.GetEncoding("Windows-1252").GetBytes(commandArray[2].Replace("\n", ""))).Select(b => Convert.ToString(b, 2)))), 2),
                        (byte)Convert.ToInt32((string.Join("", (Encoding.GetEncoding("Windows-1252").GetBytes(commandArray[3].Replace("\n", ""))).Select(b => Convert.ToString(b, 2)))), 2),
                        (byte)Convert.ToInt32((string.Join("", (Encoding.GetEncoding("Windows-1252").GetBytes(commandArray[4].Replace("\n", ""))).Select(b => Convert.ToString(b, 2)))), 2),
                        (byte)Convert.ToInt32((string.Join("", (Encoding.GetEncoding("Windows-1252").GetBytes(commandArray[5].Replace("\n", ""))).Select(b => Convert.ToString(b, 2)))), 2),
                        (byte)Convert.ToInt32((string.Join("", (Encoding.GetEncoding("Windows-1252").GetBytes(commandArray[5].Replace("\n", ""))).Select(b => Convert.ToString(b, 2)))), 2),
                        (byte)Convert.ToInt32((string.Join("", (Encoding.GetEncoding("Windows-1252").GetBytes(commandArray[5].Replace("\n", ""))).Select(b => Convert.ToString(b, 2)))), 2),
                        (byte)Convert.ToInt32((string.Join("", (Encoding.GetEncoding("Windows-1252").GetBytes(commandArray[5].Replace("\n", ""))).Select(b => Convert.ToString(b, 2)))), 2)
                }, 0, 8);
            }
            return false;
        }

        public bool SendDecimalCommand(String command)
        {
            if (!String.IsNullOrEmpty(command))
            {

                String[] commandArray = command.Split(' ');
                /*
                String str = "œ";
                var bytes = Encoding.GetEncoding("Windows-1252").GetBytes(str);
                string binStr = string.Join("", bytes.Select(b => Convert.ToString(b, 2)));
                int decimalEquivalent = Convert.ToInt32(binStr, 2);
                Console.WriteLine(decimalEquivalent);
                Convert.ToInt32((string.Join("", (Encoding.GetEncoding("Windows-1252").GetBytes("œ")).Select(b => Convert.ToString(b, 2)))), 2);
                */
                // send the command


                GetSerialPort().Write(new byte[]{
                        (byte)Convert.ToInt16(commandArray[0]),
                        (byte)Convert.ToInt16(commandArray[1]),
                        (byte)Convert.ToInt16(commandArray[2]),
                        (byte)Convert.ToInt16(commandArray[3]),
                        (byte)Convert.ToInt16(commandArray[4]),
                        (byte)Convert.ToInt16(commandArray[5]),
                        (byte)Convert.ToInt16(commandArray[5]),
                        (byte)Convert.ToInt16(commandArray[5]),
                        (byte)Convert.ToInt16(commandArray[5])
                }, 0, 8);
            }
            return false;
        }

        public void ReceiveData(object sender, SerialDataReceivedEventArgs e)
        {
            if (!GetSerialPort().IsOpen) return;
            int bytes = GetSerialPort().BytesToRead;
            if (bytes > 8)
            {
                byte[] buffer = new byte[bytes];
                GetSerialPort().Read(buffer, 0, bytes);

                //StringBuilder sb = new StringBuilder(buffer.Length * 3);
                //foreach (byte b in buffer)
                //    sb.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
                //Console.WriteLine(sb.ToString().ToUpper());

                MainForm.Invoke((MethodInvoker)delegate {
                    var parts = (Encoding.Default.GetString(buffer)).Replace("\n", "").Split('\r');
                    foreach(var part in parts)
                    {
                        if (Regex.Replace(part, @"\s+", " ").Length != 0)
                        {
                            MainForm.Console_ListBox.Items.Add(part);
                            int itemsPerPage = (int)(MainForm.Console_ListBox.Height / MainForm.Console_ListBox.ItemHeight);
                            MainForm.Console_ListBox.TopIndex = MainForm.Console_ListBox.Items.Count - itemsPerPage;
                        }
                    }
                });
            }
        }
    }
}
