
namespace ShutdownTimer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radShutdown = new System.Windows.Forms.RadioButton();
            this.radRestart = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSekund = new System.Windows.Forms.ComboBox();
            this.cboMinut = new System.Windows.Forms.ComboBox();
            this.cboSat = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSec = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHr = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radShutdown
            // 
            this.radShutdown.AutoSize = true;
            this.radShutdown.Checked = true;
            this.radShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radShutdown.Location = new System.Drawing.Point(31, 86);
            this.radShutdown.Name = "radShutdown";
            this.radShutdown.Size = new System.Drawing.Size(92, 20);
            this.radShutdown.TabIndex = 0;
            this.radShutdown.TabStop = true;
            this.radShutdown.Text = "Shutdown";
            this.radShutdown.UseVisualStyleBackColor = true;
            this.radShutdown.Click += new System.EventHandler(this.radShutdown_Click_1);
            // 
            // radRestart
            // 
            this.radRestart.AutoSize = true;
            this.radRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radRestart.Location = new System.Drawing.Point(31, 132);
            this.radRestart.Name = "radRestart";
            this.radRestart.Size = new System.Drawing.Size(76, 20);
            this.radRestart.TabIndex = 1;
            this.radRestart.Text = "Restart";
            this.radRestart.UseVisualStyleBackColor = true;
            this.radRestart.Click += new System.EventHandler(this.radRestart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(180, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(415, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sekund";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(304, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minut";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(243, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Shut Down";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.cboSekund);
            this.groupBox1.Controls.Add(this.cboMinut);
            this.groupBox1.Controls.Add(this.cboSat);
            this.groupBox1.Controls.Add(this.radShutdown);
            this.groupBox1.Controls.Add(this.radRestart);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(4, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 170);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shutdown";
            // 
            // cboSekund
            // 
            this.cboSekund.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboSekund.FormattingEnabled = true;
            this.cboSekund.Location = new System.Drawing.Point(407, 97);
            this.cboSekund.Name = "cboSekund";
            this.cboSekund.Size = new System.Drawing.Size(100, 24);
            this.cboSekund.TabIndex = 11;
            this.cboSekund.Text = "0";
            this.cboSekund.SelectedIndexChanged += new System.EventHandler(this.cboSat_SelectedIndexChanged_1);
            // 
            // cboMinut
            // 
            this.cboMinut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboMinut.FormattingEnabled = true;
            this.cboMinut.Location = new System.Drawing.Point(287, 97);
            this.cboMinut.Name = "cboMinut";
            this.cboMinut.Size = new System.Drawing.Size(100, 24);
            this.cboMinut.TabIndex = 10;
            this.cboMinut.Text = "0";
            this.cboMinut.SelectedIndexChanged += new System.EventHandler(this.cboSat_SelectedIndexChanged_1);
            // 
            // cboSat
            // 
            this.cboSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboSat.FormattingEnabled = true;
            this.cboSat.Location = new System.Drawing.Point(163, 97);
            this.cboSat.Name = "cboSat";
            this.cboSat.Size = new System.Drawing.Size(100, 24);
            this.cboSat.TabIndex = 9;
            this.cboSat.Text = "0";
            this.cboSat.SelectedIndexChanged += new System.EventHandler(this.cboSat_SelectedIndexChanged_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.Location = new System.Drawing.Point(368, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 33);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(487, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.ForeColor = System.Drawing.Color.White;
            this.lblSec.Location = new System.Drawing.Point(434, 16);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(49, 33);
            this.lblSec.TabIndex = 33;
            this.lblSec.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(397, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 33);
            this.label10.TabIndex = 32;
            this.label10.Text = ":";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(342, 16);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(49, 33);
            this.lblMin.TabIndex = 31;
            this.lblMin.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(312, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 33);
            this.label8.TabIndex = 30;
            this.label8.Text = ":";
            // 
            // lblHr
            // 
            this.lblHr.AutoSize = true;
            this.lblHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr.ForeColor = System.Drawing.Color.White;
            this.lblHr.Location = new System.Drawing.Point(263, 16);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(49, 33);
            this.lblHr.TabIndex = 29;
            this.lblHr.Text = "00";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.ForeColor = System.Drawing.Color.White;
            this.lblOpis.Location = new System.Drawing.Point(22, 16);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(91, 35);
            this.lblOpis.TabIndex = 34;
            this.lblOpis.Text = "Opis:";
            this.lblOpis.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(568, 279);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblHr);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shutdown Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radShutdown;
        private System.Windows.Forms.RadioButton radRestart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboSekund;
        private System.Windows.Forms.ComboBox cboMinut;
        private System.Windows.Forms.ComboBox cboSat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblHr;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Timer timer1;
    }
}

