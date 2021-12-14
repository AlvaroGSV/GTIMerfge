namespace gestor
{
    partial class NuevoReporte
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
            this.cmbEdificio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAula = new System.Windows.Forms.ComboBox();
            this.grpDispositivo = new System.Windows.Forms.GroupBox();
            this.rbComputadora = new System.Windows.Forms.RadioButton();
            this.rbDRed = new System.Windows.Forms.RadioButton();
            this.rbOtroDispositivo = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpDispositivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbEdificio
            // 
            this.cmbEdificio.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdificio.FormattingEnabled = true;
            this.cmbEdificio.Location = new System.Drawing.Point(15, 39);
            this.cmbEdificio.Name = "cmbEdificio";
            this.cmbEdificio.Size = new System.Drawing.Size(75, 21);
            this.cmbEdificio.TabIndex = 1;
            this.cmbEdificio.Text = "Edificio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "donde se encuentra la computadora";
            // 
            // cmbAula
            // 
            this.cmbAula.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAula.FormattingEnabled = true;
            this.cmbAula.Location = new System.Drawing.Point(115, 39);
            this.cmbAula.Name = "cmbAula";
            this.cmbAula.Size = new System.Drawing.Size(75, 21);
            this.cmbAula.TabIndex = 3;
            this.cmbAula.Text = "Aula";
            // 
            // grpDispositivo
            // 
            this.grpDispositivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpDispositivo.Controls.Add(this.rbOtroDispositivo);
            this.grpDispositivo.Controls.Add(this.rbDRed);
            this.grpDispositivo.Controls.Add(this.rbComputadora);
            this.grpDispositivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpDispositivo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDispositivo.Location = new System.Drawing.Point(250, 9);
            this.grpDispositivo.Name = "grpDispositivo";
            this.grpDispositivo.Size = new System.Drawing.Size(358, 51);
            this.grpDispositivo.TabIndex = 4;
            this.grpDispositivo.TabStop = false;
            this.grpDispositivo.Text = "¿QUE DISPOSITIVO ES?";
            // 
            // rbComputadora
            // 
            this.rbComputadora.AutoSize = true;
            this.rbComputadora.Location = new System.Drawing.Point(6, 28);
            this.rbComputadora.Name = "rbComputadora";
            this.rbComputadora.Size = new System.Drawing.Size(96, 17);
            this.rbComputadora.TabIndex = 0;
            this.rbComputadora.TabStop = true;
            this.rbComputadora.Text = "Computadora";
            this.rbComputadora.UseVisualStyleBackColor = true;
            // 
            // rbDRed
            // 
            this.rbDRed.AutoSize = true;
            this.rbDRed.Location = new System.Drawing.Point(125, 28);
            this.rbDRed.Name = "rbDRed";
            this.rbDRed.Size = new System.Drawing.Size(118, 17);
            this.rbDRed.TabIndex = 1;
            this.rbDRed.TabStop = true;
            this.rbDRed.Text = "Dispositivo de red";
            this.rbDRed.UseVisualStyleBackColor = true;
            // 
            // rbOtroDispositivo
            // 
            this.rbOtroDispositivo.AutoSize = true;
            this.rbOtroDispositivo.Location = new System.Drawing.Point(255, 28);
            this.rbOtroDispositivo.Name = "rbOtroDispositivo";
            this.rbOtroDispositivo.Size = new System.Drawing.Size(108, 17);
            this.rbOtroDispositivo.TabIndex = 2;
            this.rbOtroDispositivo.TabStop = true;
            this.rbOtroDispositivo.Text = "Otro dispositivo";
            this.rbOtroDispositivo.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(15, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 49);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(504, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 49);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "REPORTAR";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(212, 123);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(191, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(409, 123);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(191, 21);
            this.comboBox3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Escoga la computadora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Escoga el dispositivo de red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Escoga el otro dispositivo";
            // 
            // NuevoReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(620, 232);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpDispositivo);
            this.Controls.Add(this.cmbAula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEdificio);
            this.Name = "NuevoReporte";
            this.Text = "NUEVO REPORTE";
            this.grpDispositivo.ResumeLayout(false);
            this.grpDispositivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEdificio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAula;
        private System.Windows.Forms.GroupBox grpDispositivo;
        private System.Windows.Forms.RadioButton rbOtroDispositivo;
        private System.Windows.Forms.RadioButton rbDRed;
        private System.Windows.Forms.RadioButton rbComputadora;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}