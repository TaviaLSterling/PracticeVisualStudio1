namespace SwappingElephants
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
            this.lloydButton = new System.Windows.Forms.Button();
            this.lucindaButton = new System.Windows.Forms.Button();
            this.swapButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lloydButton
            // 
            this.lloydButton.Location = new System.Drawing.Point(100, 55);
            this.lloydButton.Name = "lloydButton";
            this.lloydButton.Size = new System.Drawing.Size(75, 32);
            this.lloydButton.TabIndex = 0;
            this.lloydButton.Text = "Lloyd";
            this.lloydButton.UseVisualStyleBackColor = true;
            this.lloydButton.Click += new System.EventHandler(this.lloydButton_Click);
            // 
            // lucindaButton
            // 
            this.lucindaButton.Location = new System.Drawing.Point(100, 104);
            this.lucindaButton.Name = "lucindaButton";
            this.lucindaButton.Size = new System.Drawing.Size(75, 35);
            this.lucindaButton.TabIndex = 1;
            this.lucindaButton.Text = "Lucinda";
            this.lucindaButton.UseVisualStyleBackColor = true;
            this.lucindaButton.Click += new System.EventHandler(this.lucindaButton_Click);
            // 
            // swapButton
            // 
            this.swapButton.Location = new System.Drawing.Point(100, 161);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(75, 35);
            this.swapButton.TabIndex = 2;
            this.swapButton.Text = "Swap!";
            this.swapButton.UseVisualStyleBackColor = true;
            this.swapButton.Click += new System.EventHandler(this.swapButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.swapButton);
            this.Controls.Add(this.lucindaButton);
            this.Controls.Add(this.lloydButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lloydButton;
        private System.Windows.Forms.Button lucindaButton;
        private System.Windows.Forms.Button swapButton;
    }
}

