namespace ArduinoController
{
    partial class CarNumberChecker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonConnect = new Button();
            buttonUpdatePorts = new Button();
            comboBoxPorts = new ComboBox();
            textBox = new TextBox();
            SuspendLayout();
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(606, 28);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(182, 38);
            buttonConnect.TabIndex = 0;
            buttonConnect.Text = "Подключиться";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // buttonUpdatePorts
            // 
            buttonUpdatePorts.Location = new Point(606, 72);
            buttonUpdatePorts.Name = "buttonUpdatePorts";
            buttonUpdatePorts.Size = new Size(182, 56);
            buttonUpdatePorts.TabIndex = 1;
            buttonUpdatePorts.Text = "Обновить список доступных портов";
            buttonUpdatePorts.UseVisualStyleBackColor = true;
            buttonUpdatePorts.Click += buttonUpdatePorts_Click;
            // 
            // comboBoxPorts
            // 
            comboBoxPorts.FormattingEnabled = true;
            comboBoxPorts.Location = new Point(437, 28);
            comboBoxPorts.Name = "comboBoxPorts";
            comboBoxPorts.Size = new Size(163, 28);
            comboBoxPorts.TabIndex = 2;
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 28);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(419, 410);
            textBox.TabIndex = 3;
            // 
            // CarNumberChecker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox);
            Controls.Add(comboBoxPorts);
            Controls.Add(buttonUpdatePorts);
            Controls.Add(buttonConnect);
            Name = "CarNumberChecker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConnect;
        private Button buttonUpdatePorts;
        private ComboBox comboBoxPorts;
        private TextBox textBox;
    }
}