namespace Authentication
{
    partial class Form3
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
            this.messegelabel = new System.Windows.Forms.Label();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messegelabel
            // 
            this.messegelabel.AutoSize = true;
            this.messegelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messegelabel.Location = new System.Drawing.Point(353, 143);
            this.messegelabel.Name = "messegelabel";
            this.messegelabel.Size = new System.Drawing.Size(84, 20);
            this.messegelabel.TabIndex = 0;
            this.messegelabel.Text = "Messege";
            // 
            // logoutbutton
            // 
            this.logoutbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbutton.Location = new System.Drawing.Point(319, 176);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(144, 42);
            this.logoutbutton.TabIndex = 1;
            this.logoutbutton.Text = "Log Out";
            this.logoutbutton.UseVisualStyleBackColor = true;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutbutton);
            this.Controls.Add(this.messegelabel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label messegelabel;
        private System.Windows.Forms.Button logoutbutton;
    }
}