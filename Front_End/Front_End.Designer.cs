namespace Front_End
{
    partial class Front_End
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
            this.btnButtons = new System.Windows.Forms.Button();
            this.btnBackground = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnButtons
            // 
            this.btnButtons.Location = new System.Drawing.Point(162, 271);
            this.btnButtons.Name = "btnButtons";
            this.btnButtons.Size = new System.Drawing.Size(127, 100);
            this.btnButtons.TabIndex = 0;
            this.btnButtons.Text = "Buttons";
            this.btnButtons.UseVisualStyleBackColor = true;
            this.btnButtons.Click += new System.EventHandler(this.BtnButtons_Click);
            // 
            // btnBackground
            // 
            this.btnBackground.Location = new System.Drawing.Point(14, 271);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(127, 100);
            this.btnBackground.TabIndex = 1;
            this.btnBackground.Text = "Background";
            this.btnBackground.UseVisualStyleBackColor = true;
            this.btnBackground.Click += new System.EventHandler(this.BtnBackground_Click);
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(310, 273);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(127, 100);
            this.btnText.TabIndex = 2;
            this.btnText.Text = "Text";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.BtnText_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(129, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(192, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Colour Changer";
            // 
            // Front_End
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 385);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.btnBackground);
            this.Controls.Add(this.btnButtons);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Front_End";
            this.Text = "Front_End";
            this.Load += new System.EventHandler(this.Front_End_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnButtons;
        private System.Windows.Forms.Button btnBackground;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Label lblTitle;
    }
}

