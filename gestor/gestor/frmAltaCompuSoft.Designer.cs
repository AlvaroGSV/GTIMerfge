namespace gestor
{
    partial class frmAltaCompuSoft
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVerBios = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameBios = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInfraestructura = new System.Windows.Forms.Button();
            this.cmbNavegador = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSI = new System.Windows.Forms.RadioButton();
            this.rdbNO = new System.Windows.Forms.RadioButton();
            this.cmbSO = new System.Windows.Forms.ComboBox();
            this.cmbConfiguraciones = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "SELECCIONE EL SISTEMA OPERATIVO";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(15, 25);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(248, 20);
            this.txtID.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "INGRESE EL ID DEL SOFTWARE DE LA COMPUTADORA";
            // 
            // txtVerBios
            // 
            this.txtVerBios.Location = new System.Drawing.Point(332, 64);
            this.txtVerBios.Name = "txtVerBios";
            this.txtVerBios.Size = new System.Drawing.Size(248, 20);
            this.txtVerBios.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "INGRESE LA VERSION DE LA BIOS";
            // 
            // txtNameBios
            // 
            this.txtNameBios.Location = new System.Drawing.Point(15, 64);
            this.txtNameBios.Name = "txtNameBios";
            this.txtNameBios.Size = new System.Drawing.Size(248, 20);
            this.txtNameBios.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "INGRESE EL NOMBRE DE LA BIOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "¿TIENE EL DEEPFREZE?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "SELECCIONE EL NAVEGADOR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "ESCOGA LA CONFIGURACION";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(371, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 32);
            this.button1.TabIndex = 44;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInfraestructura
            // 
            this.btnInfraestructura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfraestructura.Location = new System.Drawing.Point(12, 180);
            this.btnInfraestructura.Name = "btnInfraestructura";
            this.btnInfraestructura.Size = new System.Drawing.Size(251, 32);
            this.btnInfraestructura.TabIndex = 43;
            this.btnInfraestructura.Text = "Guardar";
            this.btnInfraestructura.UseVisualStyleBackColor = true;
            this.btnInfraestructura.Click += new System.EventHandler(this.btnInfraestructura_Click);
            // 
            // cmbNavegador
            // 
            this.cmbNavegador.FormattingEnabled = true;
            this.cmbNavegador.Items.AddRange(new object[] {
            "EDGE",
            "CHROME",
            "FIREFOX",
            "SAFARI",
            "BRAVE",
            "OPERA",
            "VIBALDI"});
            this.cmbNavegador.Location = new System.Drawing.Point(15, 102);
            this.cmbNavegador.Name = "cmbNavegador";
            this.cmbNavegador.Size = new System.Drawing.Size(248, 21);
            this.cmbNavegador.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNO);
            this.groupBox1.Controls.Add(this.rdbSI);
            this.groupBox1.Location = new System.Drawing.Point(332, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 35);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // rdbSI
            // 
            this.rdbSI.AutoSize = true;
            this.rdbSI.Location = new System.Drawing.Point(6, 12);
            this.rdbSI.Name = "rdbSI";
            this.rdbSI.Size = new System.Drawing.Size(35, 17);
            this.rdbSI.TabIndex = 0;
            this.rdbSI.TabStop = true;
            this.rdbSI.Text = "SI";
            this.rdbSI.UseVisualStyleBackColor = true;
            // 
            // rdbNO
            // 
            this.rdbNO.AutoSize = true;
            this.rdbNO.Location = new System.Drawing.Point(96, 12);
            this.rdbNO.Name = "rdbNO";
            this.rdbNO.Size = new System.Drawing.Size(41, 17);
            this.rdbNO.TabIndex = 1;
            this.rdbNO.TabStop = true;
            this.rdbNO.Text = "NO";
            this.rdbNO.UseVisualStyleBackColor = true;
            // 
            // cmbSO
            // 
            this.cmbSO.FormattingEnabled = true;
            this.cmbSO.Items.AddRange(new object[] {
            "Windows",
            "MacOs",
            "Linux Debina",
            "Linux Gnome"});
            this.cmbSO.Location = new System.Drawing.Point(332, 25);
            this.cmbSO.Name = "cmbSO";
            this.cmbSO.Size = new System.Drawing.Size(248, 21);
            this.cmbSO.TabIndex = 24;
            // 
            // cmbConfiguraciones
            // 
            this.cmbConfiguraciones.FormattingEnabled = true;
            this.cmbConfiguraciones.Location = new System.Drawing.Point(15, 142);
            this.cmbConfiguraciones.Name = "cmbConfiguraciones";
            this.cmbConfiguraciones.Size = new System.Drawing.Size(248, 21);
            this.cmbConfiguraciones.TabIndex = 49;
            // 
            // frmAltaCompuSoft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 219);
            this.Controls.Add(this.cmbConfiguraciones);
            this.Controls.Add(this.cmbSO);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbNavegador);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInfraestructura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVerBios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameBios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaCompuSoft";
            this.Text = "Alta Software de Computadora";
            this.Load += new System.EventHandler(this.frmAltaCompuSoft_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVerBios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameBios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInfraestructura;
        private System.Windows.Forms.ComboBox cmbNavegador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNO;
        private System.Windows.Forms.RadioButton rdbSI;
        private System.Windows.Forms.ComboBox cmbSO;
        private System.Windows.Forms.ComboBox cmbConfiguraciones;
    }
}