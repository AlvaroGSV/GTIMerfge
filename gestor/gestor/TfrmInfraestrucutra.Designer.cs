namespace gestor
{
    partial class TfrmInfraestrucutra
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
            this.btnInfraestructura = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInfraestructura
            // 
            this.btnInfraestructura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfraestructura.Location = new System.Drawing.Point(12, 70);
            this.btnInfraestructura.Name = "btnInfraestructura";
            this.btnInfraestructura.Size = new System.Drawing.Size(314, 52);
            this.btnInfraestructura.TabIndex = 4;
            this.btnInfraestructura.Text = "Nueva Aula";
            this.btnInfraestructura.UseVisualStyleBackColor = true;
            this.btnInfraestructura.Click += new System.EventHandler(this.btnInfraestructura_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Nuevo edificio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(314, 52);
            this.button2.TabIndex = 6;
            this.button2.Text = "cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TfrmInfraestrucutra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 194);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInfraestructura);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TfrmInfraestrucutra";
            this.Text = "INFRAESTRCUTURA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInfraestructura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}