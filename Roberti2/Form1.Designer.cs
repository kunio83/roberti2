namespace Roberti2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nudGiro = new System.Windows.Forms.NumericUpDown();
            this.nudArriba = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArriba)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 76);
            this.button2.TabIndex = 4;
            this.button2.Text = "ARRIBA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudGiro);
            this.panel1.Controls.Add(this.nudArriba);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(109, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 288);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // nudGiro
            // 
            this.nudGiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGiro.Location = new System.Drawing.Point(157, 158);
            this.nudGiro.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudGiro.Name = "nudGiro";
            this.nudGiro.Size = new System.Drawing.Size(77, 31);
            this.nudGiro.TabIndex = 6;
            // 
            // nudArriba
            // 
            this.nudArriba.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudArriba.Location = new System.Drawing.Point(222, 25);
            this.nudArriba.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudArriba.Name = "nudArriba";
            this.nudArriba.Size = new System.Drawing.Size(77, 31);
            this.nudArriba.TabIndex = 5;
            this.nudArriba.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 383);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArriba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudGiro;
        private System.Windows.Forms.NumericUpDown nudArriba;
        private System.Windows.Forms.Label label1;
    }
}

