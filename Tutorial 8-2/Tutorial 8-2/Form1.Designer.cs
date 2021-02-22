namespace Tutorial_8_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.formatButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(112, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a 10-digit number and I will format it as a telephone number.";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(262, 115);
            this.numberTextBox.Multiline = true;
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(198, 43);
            this.numberTextBox.TabIndex = 1;
            // 
            // formatButton
            // 
            this.formatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.formatButton.Location = new System.Drawing.Point(210, 194);
            this.formatButton.Name = "formatButton";
            this.formatButton.Size = new System.Drawing.Size(122, 40);
            this.formatButton.TabIndex = 2;
            this.formatButton.Text = "Format";
            this.formatButton.UseVisualStyleBackColor = true;
            this.formatButton.Click += new System.EventHandler(this.formatButton_Click_1);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.exitButton.Location = new System.Drawing.Point(385, 194);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(122, 40);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 320);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.formatButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Telephone Format";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button formatButton;
        private System.Windows.Forms.Button exitButton;
    }
}

