
namespace BabyGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_baby = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_baby
            // 
            this.btn_baby.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_baby.Enabled = false;
            this.btn_baby.Location = new System.Drawing.Point(351, 83);
            this.btn_baby.Name = "btn_baby";
            this.btn_baby.Size = new System.Drawing.Size(126, 83);
            this.btn_baby.TabIndex = 1;
            this.btn_baby.Text = "da baby";
            this.btn_baby.UseVisualStyleBackColor = true;
            this.btn_baby.Click += new System.EventHandler(this.btn_baby_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(362, 317);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(93, 43);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_baby);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_baby;
        private System.Windows.Forms.Button btn_start;
    }
}

