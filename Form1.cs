using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace USART
{
    public partial class Form1 : Form
    {
        //Deklaracja listy
        private string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private List<string> files = new List<string>();
        private List<String> lines = new List<String>();

        private bool ableToSendData = false;
        //konstruktor listy
        private void initializeList()
        {
            files.Add("One");
            files.Add("Two");
            files.Add("Three");
            files.Add("Four");
        }

        //deklaracja delegaty oraz obiektu typy zadeklarowanego
        delegate void Delegat1();
        Delegat1 moj_del1;

        //inicjalizacja zmiennej port z domyślnymi wartościami, w formsie

        //ustawienie timeoutów aby program się nie wieszał, w formsie 

        void Opcje_Enter(object sender, EventArgs e)
        {
            //aktualizacja list 
            this.cbName.Items.Clear(); //Czyszczenie combobxow
            this.cbEven.Items.Clear();
            this.cbStop.Items.Clear();
            foreach (String s in SerialPort.GetPortNames()) this.cbName.Items.Add(s);
            foreach (String s in Enum.GetNames(typeof(Parity))) this.cbEven.Items.Add(s);
            foreach (String s in Enum.GetNames(typeof(StopBits))) this.cbStop.Items.Add(s);

            //aktualizacja nazw 
            cbName.Text = port.PortName.ToString();
            cbSpeed.Text = port.BaudRate.ToString();
            cbData.Text = port.DataBits.ToString();
            cbEven.Text = port.Parity.ToString();
            cbStop.Text = port.StopBits.ToString();
        }

        private void DodajKolorowy(System.Windows.Forms.RichTextBox RichTextBox, string Text, System.Drawing.Color Color)
        {
            var StartIndex = RichTextBox.TextLength;
            RichTextBox.AppendText(Text);
            var EndIndex = RichTextBox.TextLength;
            RichTextBox.Select(StartIndex, EndIndex - StartIndex);
            RichTextBox.SelectionColor = Color;
        }

        private void WpiszOdebrane()
        {
            DodajKolorowy(rtbTerminal, port.ReadExisting(), System.Drawing.Color.Blue);
            ableToSendData = true;
           
        }

        private void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            rtbTerminal.Invoke(moj_del1);
        }

        public Form1()
        {
            InitializeComponent();
            initializeList();
            listBox1.DataSource = files;

            Opcje.Enter += new EventHandler(Opcje_Enter);
            this.butRefresh.Click += new System.EventHandler(this.Opcje_Enter);
            port.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler); //klasa eventu przychodzących danych od portu COM
            moj_del1 = new Delegat1(WpiszOdebrane); //inicjalizacja delegata
        }

        private void pbStatus_Click(object sender, EventArgs e)
        {
            //jeżeli połączenie jest aktywne to je kończymy, zmieniamy kolor na red i zmieniamy napis 
            if (port.IsOpen)
            {
                pbStatus.BackColor = System.Drawing.Color.Red;
                port.Close();
                lbStatus.Text = "Brak połączenia (teraz można zmieniać opcje połączenia)";
                DodajKolorowy(rtbTerminal, "\nZakończono połączenie z " + port.PortName + "\n", System.Drawing.Color.Orange);
            }
            //w przeciwnym wypadku włączamy połączenie, zmieniamy kolor na zielony i zmieniamy napis 
            else
            {
                //połączenie może nie być możliwe dlatego należy się zabezpieczyć na wypadek błędu 
                try
                {
                    //najpierw przepisujemy do portu parametry z opcji 
                    port.PortName = this.cbName.Text;
                    port.BaudRate = Int32.Parse(this.cbSpeed.Text);
                    port.DataBits = Int32.Parse(this.cbData.Text);
                    port.Parity = (Parity)Enum.Parse(typeof(Parity), this.cbEven.Text);
                    port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.cbStop.Text);
                    //a następnie uruchamiamy port 
                    port.Open();
                    //po uruchomieniu zmieniamy elementy graficzne interfejsu 
                    pbStatus.BackColor = System.Drawing.Color.Green;
                    lbStatus.Text = "Aktywne połączenie (port:" + port.PortName.ToString() + ", prędkość: " + port.BaudRate.ToString() + ", bity danych: " +
                    port.DataBits.ToString() + "\n bity stopu: " + port.StopBits.ToString() + ", parzystość: " + port.Parity.ToString() + ")";
                    DodajKolorowy(rtbTerminal, "Rozpoczęto połączenie z " + port.PortName + "\n", System.Drawing.Color.Orange);
                    System.Threading.Thread.Sleep(2000);
                }
                //jeżeli nastąpi błąd to go przechwycimy i wyświetlimy stosowny komunikat 
                catch (Exception exc)
                {
                    MessageBox.Show("Błąd połączenia:\n" + exc.Message);
                }
            }
        }

        private void button_Default_Click(object sender, EventArgs e)
        {
            //ustawienie domyslnych wartosci 
            this.cbName.Text = "COM3";
            this.cbSpeed.Text = "9600";
            this.cbData.Text = "8";
            this.cbEven.Text = "None";
            this.cbStop.Text = "One";
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            //anulowanie ustowionych wartosci 
            cbName.Text = port.PortName.ToString();
            cbSpeed.Text = port.BaudRate.ToString();
            cbData.Text = port.DataBits.ToString();
            cbEven.Text = port.Parity.ToString();
            cbStop.Text = port.StopBits.ToString();
        }

        private void butSend_Click(object sender, EventArgs e)
        {
            butSendClickClicked();
        }

        private void butSendClickClicked()
        {
            if (port.IsOpen)
            {
                //DodajKolorowy(rtbTerminal, ((Int32)numericSend.Value).ToString("X") + " ", System.Drawing.Color.Black);
                //Byte[] tosend = { (Byte)numericSend.Value };
                //port.Write(tosend, 0, 1);
                String line;
                line = tbSend.Text;
                line.Trim();
                DodajKolorowy(rtbTerminal, line + "\n", System.Drawing.Color.Black);
                port.Write(line + "\n");


            }
            else System.Windows.Forms.MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");
        }


        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            DataReceived();
        }

        private void DataReceived()
        {
            if (rtbTerminal.InvokeRequired)
            {
                //utworzenie delegata (wskaźnika do mikro funkcji) metody do wpisywania danych w komponencie z bufora odbioru danych
                // () => oznacza lambdę
                // string odebrane;
                Action act = () => DodajKolorowy(rtbTerminal, port.ReadExisting(), System.Drawing.Color.Blue);

                ableToSendData = false;

                //wykonanie delegata dla wątku głównego
                Invoke(act);   //wywołanie delegata
            }
            else
            {//jeżeli jest w tym samym wątku przepisz normalnie dane z bufora do komponentu
                rtbTerminal.Text += port.ReadExisting();
                ableToSendData = false;

            }
        }

        private void butAddFile_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            String line;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            int selectedFileIndex = listBox1.SelectedIndex + 1;
            StreamReader file = new StreamReader(desktopPath + "/file" + selectedFileIndex + ".txt");
            StringBuilder textInFile = new StringBuilder();
            while ((line = file.ReadLine()) != null)
            {
                richTextBox1.Text += line + "\n";
                lines.Add(line + "\n");
                textInFile.Append(line + "\r\n");
            }
            foreach (string aLine in lines)
            {
                listView1.Items.Add(aLine);
            }


        }

        private void butClear_Click(object sender, EventArgs e)
        {
            //Czyszczenie wszystkich okien oraz listy
            richTextBox1.Text = "";
            rtbTerminal.Text = "";
            lines.Clear();
            listView1.Clear();

        }

        private void butSendFile_Click(object sender, EventArgs e)
        {
            SendFile();
        }

        private void SendFile()
        {
            foreach (string aLine in lines)
            {
                aLine.Trim();
                DodajKolorowy(rtbTerminal, aLine, System.Drawing.Color.Black);
                port.Write(aLine);
            }
            // int linesLength = lines.Count();
            //int linesCount = 0;
            // while (linesCount < linesLength && !ableToSendData)
            //{
            // DodajKolorowy(rtbTerminal, lines.ElementAt(linesCount), System.Drawing.Color.Black);
            // lines.ElementAt(linesCount).Trim();
            //port.Write(lines.ElementAt(linesCount));
            //}

            //DodajKolorowy(rtbTerminal, "Liczba iteracji: " + linesCount + "\n" + "Dlugosc listy: " + linesLength + "\n", System.Drawing.Color.Black);
        }


        private void butAddFileFromFolder_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();


                    try
                    {
                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            StringBuilder textInFile = new StringBuilder();
                            String line;
                            while ((line = reader.ReadLine()) != null) //wczytywanie do akapitów – można bezpośrednio zwrócić do
                            {
                                //własności Lines komponentu TextBox, jeżeli całość pliku to np. ReadToEnd
                                richTextBox1.Text += line + "\n";
                                lines.Add(line + "\n");
                                textInFile.Append(line + "\r\n");

                            }


                            foreach (string aLine in lines)
                            {
                                listView1.Items.Add(aLine);
                            }


                        }

                    }
                    catch (Exception g)
                    {
                        MessageBox.Show("Bład" + filePath + "(" + g.Message + ")");

                    }

                }
            }
        }
    }
}