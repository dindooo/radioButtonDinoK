namespace radioButtonDinoK
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoAvion = new System.Windows.Forms.RadioButton();
            this.rdoAutobus = new System.Windows.Forms.RadioButton();
            this.rdoVlastiti = new System.Windows.Forms.RadioButton();
            this.btnRezerviraj = new System.Windows.Forms.Button();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoVlastiti);
            this.groupBox1.Controls.Add(this.rdoAutobus);
            this.groupBox1.Controls.Add(this.rdoAvion);
            this.groupBox1.Location = new System.Drawing.Point(267, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odaberite vrstu prijevoza";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoAvion
            // 
            this.rdoAvion.AutoSize = true;
            this.rdoAvion.Location = new System.Drawing.Point(7, 20);
            this.rdoAvion.Name = "rdoAvion";
            this.rdoAvion.Size = new System.Drawing.Size(52, 17);
            this.rdoAvion.TabIndex = 0;
            this.rdoAvion.TabStop = true;
            this.rdoAvion.Text = "Avion";
            this.rdoAvion.UseVisualStyleBackColor = true;
            // 
            // rdoAutobus
            // 
            this.rdoAutobus.AutoSize = true;
            this.rdoAutobus.Location = new System.Drawing.Point(7, 44);
            this.rdoAutobus.Name = "rdoAutobus";
            this.rdoAutobus.Size = new System.Drawing.Size(64, 17);
            this.rdoAutobus.TabIndex = 1;
            this.rdoAutobus.TabStop = true;
            this.rdoAutobus.Text = "Autobus";
            this.rdoAutobus.UseVisualStyleBackColor = true;
            // 
            // rdoVlastiti
            // 
            this.rdoVlastiti.AutoSize = true;
            this.rdoVlastiti.Location = new System.Drawing.Point(7, 68);
            this.rdoVlastiti.Name = "rdoVlastiti";
            this.rdoVlastiti.Size = new System.Drawing.Size(94, 17);
            this.rdoVlastiti.TabIndex = 2;
            this.rdoVlastiti.TabStop = true;
            this.rdoVlastiti.Text = "Vlastiti prijevoz";
            this.rdoVlastiti.UseVisualStyleBackColor = true;
            // 
            // btnRezerviraj
            // 
            this.btnRezerviraj.Location = new System.Drawing.Point(330, 162);
            this.btnRezerviraj.Name = "btnRezerviraj";
            this.btnRezerviraj.Size = new System.Drawing.Size(75, 23);
            this.btnRezerviraj.TabIndex = 1;
            this.btnRezerviraj.Text = "Rezerviraj";
            this.btnRezerviraj.UseVisualStyleBackColor = true;
            this.btnRezerviraj.Click += new System.EventHandler(this.btnRezerviraj_Click);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(267, 217);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(200, 83);
            this.txtIspis.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.btnRezerviraj);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoVlastiti;
        private System.Windows.Forms.RadioButton rdoAutobus;
        private System.Windows.Forms.RadioButton rdoAvion;
        private System.Windows.Forms.Button btnRezerviraj;
        private System.Windows.Forms.TextBox txtIspis;
    }
}

