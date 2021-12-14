namespace gestor
{
    partial class frmNewDocumentacion
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.opManual = new System.Windows.Forms.GroupBox();
            this.rdbNoManual = new System.Windows.Forms.RadioButton();
            this.rdbSiManual = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.opGarantia = new System.Windows.Forms.GroupBox();
            this.rdbNoGarantia = new System.Windows.Forms.RadioButton();
            this.rdbSiGarantia = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInfraestructura = new System.Windows.Forms.Button();
            this.opManual.SuspendLayout();
            this.opGarantia.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 60);
            this.textBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(655, 38);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "INGRESE EL NUMERO DE DOCUMENTACION";
            // 
            // opManual
            // 
            this.opManual.Controls.Add(this.rdbNoManual);
            this.opManual.Controls.Add(this.rdbSiManual);
            this.opManual.Location = new System.Drawing.Point(40, 122);
            this.opManual.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.opManual.Name = "opManual";
            this.opManual.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.opManual.Size = new System.Drawing.Size(661, 103);
            this.opManual.TabIndex = 14;
            this.opManual.TabStop = false;
            this.opManual.Text = "¿Cuenta con el manual?";
            // 
            // rdbNoManual
            // 
            this.rdbNoManual.AutoSize = true;
            this.rdbNoManual.Checked = true;
            this.rdbNoManual.Location = new System.Drawing.Point(219, 45);
            this.rdbNoManual.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rdbNoManual.Name = "rdbNoManual";
            this.rdbNoManual.Size = new System.Drawing.Size(93, 36);
            this.rdbNoManual.TabIndex = 1;
            this.rdbNoManual.TabStop = true;
            this.rdbNoManual.Text = "NO";
            this.rdbNoManual.UseVisualStyleBackColor = true;
            // 
            // rdbSiManual
            // 
            this.rdbSiManual.AutoSize = true;
            this.rdbSiManual.Location = new System.Drawing.Point(16, 45);
            this.rdbSiManual.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rdbSiManual.Name = "rdbSiManual";
            this.rdbSiManual.Size = new System.Drawing.Size(77, 36);
            this.rdbSiManual.TabIndex = 0;
            this.rdbSiManual.Text = "SI";
            this.rdbSiManual.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 269);
            this.textBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(655, 38);
            this.textBox2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "ARCHIVO DEL MANUAL";
            // 
            // opGarantia
            // 
            this.opGarantia.Controls.Add(this.rdbNoGarantia);
            this.opGarantia.Controls.Add(this.rdbSiGarantia);
            this.opGarantia.Location = new System.Drawing.Point(32, 331);
            this.opGarantia.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.opGarantia.Name = "opGarantia";
            this.opGarantia.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.opGarantia.Size = new System.Drawing.Size(661, 103);
            this.opGarantia.TabIndex = 15;
            this.opGarantia.TabStop = false;
            this.opGarantia.Text = "¿Cuenta con la garantia?";
            // 
            // rdbNoGarantia
            // 
            this.rdbNoGarantia.AutoSize = true;
            this.rdbNoGarantia.Checked = true;
            this.rdbNoGarantia.Location = new System.Drawing.Point(219, 45);
            this.rdbNoGarantia.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rdbNoGarantia.Name = "rdbNoGarantia";
            this.rdbNoGarantia.Size = new System.Drawing.Size(93, 36);
            this.rdbNoGarantia.TabIndex = 1;
            this.rdbNoGarantia.TabStop = true;
            this.rdbNoGarantia.Text = "NO";
            this.rdbNoGarantia.UseVisualStyleBackColor = true;
            // 
            // rdbSiGarantia
            // 
            this.rdbSiGarantia.AutoSize = true;
            this.rdbSiGarantia.Location = new System.Drawing.Point(16, 45);
            this.rdbSiGarantia.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rdbSiGarantia.Name = "rdbSiGarantia";
            this.rdbSiGarantia.Size = new System.Drawing.Size(77, 36);
            this.rdbSiGarantia.TabIndex = 0;
            this.rdbSiGarantia.Text = "SI";
            this.rdbSiGarantia.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(40, 479);
            this.textBox3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(655, 38);
            this.textBox3.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 441);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(379, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "ARCHIVO DE LA GARANTIA";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 632);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(669, 76);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInfraestructura
            // 
            this.btnInfraestructura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfraestructura.Location = new System.Drawing.Point(40, 541);
            this.btnInfraestructura.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnInfraestructura.Name = "btnInfraestructura";
            this.btnInfraestructura.Size = new System.Drawing.Size(669, 76);
            this.btnInfraestructura.TabIndex = 20;
            this.btnInfraestructura.Text = "Guardar";
            this.btnInfraestructura.UseVisualStyleBackColor = true;
            this.btnInfraestructura.Click += new System.EventHandler(this.btnInfraestructura_Click);
            // 
            // frmNewDocumentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 746);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInfraestructura);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.opGarantia);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.opManual);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewDocumentacion";
            this.Text = "New Documentacion";
            this.Load += new System.EventHandler(this.frmNewDocumentacion_Load);
            this.opManual.ResumeLayout(false);
            this.opManual.PerformLayout();
            this.opGarantia.ResumeLayout(false);
            this.opGarantia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox opManual;
        private System.Windows.Forms.RadioButton rdbNoManual;
        private System.Windows.Forms.RadioButton rdbSiManual;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox opGarantia;
        private System.Windows.Forms.RadioButton rdbNoGarantia;
        private System.Windows.Forms.RadioButton rdbSiGarantia;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInfraestructura;
    }
}