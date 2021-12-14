namespace gestor
{
    partial class frmNewSoftware
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSO = new System.Windows.Forms.ComboBox();
            this.txtMb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInfraestructura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 25);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(248, 20);
            this.txtId.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "INGRESE EL ID DEL SOFTWARE";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 20);
            this.txtName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "INGRESE EL NOMBRE DEL SOFTWARE";
            // 
            // txtVer
            // 
            this.txtVer.Location = new System.Drawing.Point(15, 142);
            this.txtVer.Name = "txtVer";
            this.txtVer.Size = new System.Drawing.Size(248, 20);
            this.txtVer.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "INGRESE LA VERSION DEL SOFTWARE";
            // 
            // txtDev
            // 
            this.txtDev.Location = new System.Drawing.Point(15, 103);
            this.txtDev.Name = "txtDev";
            this.txtDev.Size = new System.Drawing.Size(248, 20);
            this.txtDev.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "INGRESE EL NOMBRE DE DESARROLLADOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "SELECCION EL SISTEMA OPERATIVO";
            // 
            // cmbSO
            // 
            this.cmbSO.FormattingEnabled = true;
            this.cmbSO.Items.AddRange(new object[] {
            "Windows",
            "MacOs",
            "Linux Debina",
            "Linux Gnome"});
            this.cmbSO.Location = new System.Drawing.Point(15, 181);
            this.cmbSO.Name = "cmbSO";
            this.cmbSO.Size = new System.Drawing.Size(248, 21);
            this.cmbSO.TabIndex = 23;
            this.cmbSO.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtMb
            // 
            this.txtMb.Location = new System.Drawing.Point(15, 221);
            this.txtMb.Name = "txtMb";
            this.txtMb.Size = new System.Drawing.Size(248, 20);
            this.txtMb.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "INGRESE EL PESO DEL SOFTWARE EN MB";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 32);
            this.button1.TabIndex = 27;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInfraestructura
            // 
            this.btnInfraestructura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfraestructura.Location = new System.Drawing.Point(12, 247);
            this.btnInfraestructura.Name = "btnInfraestructura";
            this.btnInfraestructura.Size = new System.Drawing.Size(251, 32);
            this.btnInfraestructura.TabIndex = 26;
            this.btnInfraestructura.Text = "Guardar";
            this.btnInfraestructura.UseVisualStyleBackColor = true;
            this.btnInfraestructura.Click += new System.EventHandler(this.btnInfraestructura_Click);
            // 
            // frmNewSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInfraestructura);
            this.Controls.Add(this.txtMb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "frmNewSoftware";
            this.Load += new System.EventHandler(this.frmNewSoftware_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSO;
        private System.Windows.Forms.TextBox txtMb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInfraestructura;
    }
}