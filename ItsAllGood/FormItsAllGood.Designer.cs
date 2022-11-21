namespace ItsAllGood
{
    partial class FormItsAllGood
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
            this.BtnCheck = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(53, 66);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(175, 59);
            this.BtnCheck.TabIndex = 0;
            this.BtnCheck.Text = "Check";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(295, 66);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(428, 320);
            this.TxtResult.TabIndex = 1;
            // 
            // FormItsAllGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnCheck);
            this.Name = "FormItsAllGood";
            this.Text = "Its All Good";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

