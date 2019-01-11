namespace USART
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.Opcje = new System.Windows.Forms.TabPage();
            this.butCancel = new System.Windows.Forms.Button();
            this.butRefresh = new System.Windows.Forms.Button();
            this.butDefault = new System.Windows.Forms.Button();
            this.cbStop = new System.Windows.Forms.ComboBox();
            this.cbEven = new System.Windows.Forms.ComboBox();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.cbSpeed = new System.Windows.Forms.ComboBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.lbStop = new System.Windows.Forms.Label();
            this.lbEven = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.lbPortName = new System.Windows.Forms.Label();
            this.Terminal = new System.Windows.Forms.TabPage();
            this.butAddFileFromFolder = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.butSendFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tbSend = new System.Windows.Forms.TextBox();
            this.rtbTerminal = new System.Windows.Forms.RichTextBox();
            this.butAddFile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbCommand = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.pbStatus = new System.Windows.Forms.PictureBox();
            this.butClear = new System.Windows.Forms.Button();
            this.butSend = new System.Windows.Forms.Button();
            this.lbLog = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Opcje.SuspendLayout();
            this.Terminal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // port
            // 
            this.port.ReadTimeout = 100;
            this.port.WriteTimeout = 100;
            this.port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Opcje
            // 
            this.Opcje.Controls.Add(this.butCancel);
            this.Opcje.Controls.Add(this.butRefresh);
            this.Opcje.Controls.Add(this.butDefault);
            this.Opcje.Controls.Add(this.cbStop);
            this.Opcje.Controls.Add(this.cbEven);
            this.Opcje.Controls.Add(this.cbData);
            this.Opcje.Controls.Add(this.cbSpeed);
            this.Opcje.Controls.Add(this.cbName);
            this.Opcje.Controls.Add(this.lbStop);
            this.Opcje.Controls.Add(this.lbEven);
            this.Opcje.Controls.Add(this.lbData);
            this.Opcje.Controls.Add(this.lbSpeed);
            this.Opcje.Controls.Add(this.lbPortName);
            this.Opcje.Location = new System.Drawing.Point(4, 22);
            this.Opcje.Name = "Opcje";
            this.Opcje.Padding = new System.Windows.Forms.Padding(3);
            this.Opcje.Size = new System.Drawing.Size(991, 533);
            this.Opcje.TabIndex = 0;
            this.Opcje.Text = "Opcje";
            this.Opcje.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(271, 328);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 12;
            this.butCancel.Text = "Anuluj";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butRefresh
            // 
            this.butRefresh.Location = new System.Drawing.Point(154, 328);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(75, 23);
            this.butRefresh.TabIndex = 11;
            this.butRefresh.Text = "Odśwież";
            this.butRefresh.UseVisualStyleBackColor = true;
          
            // 
            // butDefault
            // 
            this.butDefault.Location = new System.Drawing.Point(38, 328);
            this.butDefault.Name = "butDefault";
            this.butDefault.Size = new System.Drawing.Size(75, 23);
            this.butDefault.TabIndex = 10;
            this.butDefault.Text = "Domyślne";
            this.butDefault.UseVisualStyleBackColor = true;
            this.butDefault.Click += new System.EventHandler(this.button_Default_Click);
            // 
            // cbStop
            // 
            this.cbStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStop.FormattingEnabled = true;
            this.cbStop.Location = new System.Drawing.Point(154, 224);
            this.cbStop.Name = "cbStop";
            this.cbStop.Size = new System.Drawing.Size(121, 21);
            this.cbStop.TabIndex = 9;
            // 
            // cbEven
            // 
            this.cbEven.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEven.FormattingEnabled = true;
            this.cbEven.Location = new System.Drawing.Point(154, 183);
            this.cbEven.Name = "cbEven";
            this.cbEven.Size = new System.Drawing.Size(121, 21);
            this.cbEven.TabIndex = 8;
            // 
            // cbData
            // 
            this.cbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbData.FormattingEnabled = true;
            this.cbData.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbData.Location = new System.Drawing.Point(154, 135);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(121, 21);
            this.cbData.TabIndex = 7;
            // 
            // cbSpeed
            // 
            this.cbSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpeed.FormattingEnabled = true;
            this.cbSpeed.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "76800",
            "115200",
            "230400"});
            this.cbSpeed.Location = new System.Drawing.Point(154, 91);
            this.cbSpeed.Name = "cbSpeed";
            this.cbSpeed.Size = new System.Drawing.Size(121, 21);
            this.cbSpeed.TabIndex = 6;
       
            // 
            // cbName
            // 
            this.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(154, 45);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(121, 21);
            this.cbName.TabIndex = 5;
            // 
            // lbStop
            // 
            this.lbStop.AutoSize = true;
            this.lbStop.Location = new System.Drawing.Point(35, 224);
            this.lbStop.Name = "lbStop";
            this.lbStop.Size = new System.Drawing.Size(53, 13);
            this.lbStop.TabIndex = 4;
            this.lbStop.Text = "Bity stopu";
            // 
            // lbEven
            // 
            this.lbEven.AutoSize = true;
            this.lbEven.Location = new System.Drawing.Point(35, 183);
            this.lbEven.Name = "lbEven";
            this.lbEven.Size = new System.Drawing.Size(79, 13);
            this.lbEven.TabIndex = 3;
            this.lbEven.Text = "Bity parzystości";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(35, 135);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(62, 13);
            this.lbData.TabIndex = 2;
            this.lbData.Text = "Bity danych";
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Location = new System.Drawing.Point(35, 91);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(52, 13);
            this.lbSpeed.TabIndex = 1;
            this.lbSpeed.Text = "Prędkość";
            // 
            // lbPortName
            // 
            this.lbPortName.AutoSize = true;
            this.lbPortName.Location = new System.Drawing.Point(35, 45);
            this.lbPortName.Name = "lbPortName";
            this.lbPortName.Size = new System.Drawing.Size(67, 13);
            this.lbPortName.TabIndex = 0;
            this.lbPortName.Text = "Nazwa portu";
            // 
            // Terminal
            // 
            this.Terminal.Controls.Add(this.butAddFileFromFolder);
            this.Terminal.Controls.Add(this.listView1);
            this.Terminal.Controls.Add(this.butSendFile);
            this.Terminal.Controls.Add(this.richTextBox1);
            this.Terminal.Controls.Add(this.tbSend);
            this.Terminal.Controls.Add(this.rtbTerminal);
            this.Terminal.Controls.Add(this.butAddFile);
            this.Terminal.Controls.Add(this.listBox1);
            this.Terminal.Controls.Add(this.lbCommand);
            this.Terminal.Controls.Add(this.lbStatus);
            this.Terminal.Controls.Add(this.pbStatus);
            this.Terminal.Controls.Add(this.butClear);
            this.Terminal.Controls.Add(this.butSend);
            this.Terminal.Controls.Add(this.lbLog);
            this.Terminal.Location = new System.Drawing.Point(4, 22);
            this.Terminal.Name = "Terminal";
            this.Terminal.Size = new System.Drawing.Size(991, 533);
            this.Terminal.TabIndex = 2;
            this.Terminal.Text = " Terminal";
            this.Terminal.UseVisualStyleBackColor = true;
            // 
            // butAddFileFromFolder
            // 
            this.butAddFileFromFolder.Location = new System.Drawing.Point(212, 372);
            this.butAddFileFromFolder.Name = "butAddFileFromFolder";
            this.butAddFileFromFolder.Size = new System.Drawing.Size(113, 23);
            this.butAddFileFromFolder.TabIndex = 14;
            this.butAddFileFromFolder.Text = "Dodaj plik z folderu";
            this.butAddFileFromFolder.UseVisualStyleBackColor = true;
            this.butAddFileFromFolder.Click += new System.EventHandler(this.butAddFileFromFolder_Click);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(741, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(214, 175);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;

            // 
            // butSendFile
            // 
            this.butSendFile.Location = new System.Drawing.Point(356, 371);
            this.butSendFile.Name = "butSendFile";
            this.butSendFile.Size = new System.Drawing.Size(75, 23);
            this.butSendFile.TabIndex = 11;
            this.butSendFile.Text = "Wyślij plik";
            this.butSendFile.UseVisualStyleBackColor = true;
            this.butSendFile.Click += new System.EventHandler(this.butSendFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(335, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(332, 302);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // tbSend
            // 
            this.tbSend.Location = new System.Drawing.Point(335, 24);
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(399, 20);
            this.tbSend.TabIndex = 7;
            
            // 
            // rtbTerminal
            // 
            this.rtbTerminal.Location = new System.Drawing.Point(3, 24);
            this.rtbTerminal.Name = "rtbTerminal";
            this.rtbTerminal.ReadOnly = true;
            this.rtbTerminal.Size = new System.Drawing.Size(289, 341);
            this.rtbTerminal.TabIndex = 1;
            this.rtbTerminal.Text = "";

            // 
            // butAddFile
            // 
            this.butAddFile.Location = new System.Drawing.Point(455, 372);
            this.butAddFile.Name = "butAddFile";
            this.butAddFile.Size = new System.Drawing.Size(75, 23);
            this.butAddFile.TabIndex = 9;
            this.butAddFile.Text = "Dodaj plik";
            this.butAddFile.UseVisualStyleBackColor = true;
            this.butAddFile.Click += new System.EventHandler(this.butAddFile_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(700, 244);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(84, 121);
            this.listBox1.TabIndex = 1;
            // 
            // lbCommand
            // 
            this.lbCommand.AutoSize = true;
            this.lbCommand.Location = new System.Drawing.Point(332, 8);
            this.lbCommand.Name = "lbCommand";
            this.lbCommand.Size = new System.Drawing.Size(84, 13);
            this.lbCommand.TabIndex = 8;
            this.lbCommand.Text = "Podaj komendę:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(63, 398);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(85, 13);
            this.lbStatus.TabIndex = 6;
            this.lbStatus.Text = "Brak połączenia";
            // 
            // pbStatus
            // 
            this.pbStatus.BackColor = System.Drawing.Color.Red;
            this.pbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStatus.Location = new System.Drawing.Point(11, 398);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(22, 20);
            this.pbStatus.TabIndex = 5;
            this.pbStatus.TabStop = false;
            this.pbStatus.Click += new System.EventHandler(this.pbStatus_Click);
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(680, 372);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 23);
            this.butClear.TabIndex = 4;
            this.butClear.Text = "Wyczyść";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(563, 372);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(75, 23);
            this.butSend.TabIndex = 3;
            this.butSend.Text = "Wyślij";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // lbLog
            // 
            this.lbLog.AutoSize = true;
            this.lbLog.Location = new System.Drawing.Point(8, 8);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(28, 13);
            this.lbLog.TabIndex = 0;
            this.lbLog.Text = "Log:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Terminal);
            this.tabControl1.Controls.Add(this.Opcje);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(999, 559);
            this.tabControl1.TabIndex = 0;
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "fileDialog";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 559);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Ploter 2D Controller";
            this.Opcje.ResumeLayout(false);
            this.Opcje.PerformLayout();
            this.Terminal.ResumeLayout(false);
            this.Terminal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStatus)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.TabPage Opcje;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butRefresh;
        private System.Windows.Forms.Button butDefault;
        private System.Windows.Forms.ComboBox cbStop;
        private System.Windows.Forms.ComboBox cbEven;
        private System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.ComboBox cbSpeed;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label lbStop;
        private System.Windows.Forms.Label lbEven;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.Label lbPortName;
        private System.Windows.Forms.TabPage Terminal;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button butSendFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox tbSend;
        private System.Windows.Forms.RichTextBox rtbTerminal;
        private System.Windows.Forms.Button butAddFile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbCommand;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.PictureBox pbStatus;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.Label lbLog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button butAddFileFromFolder;
    }
}

