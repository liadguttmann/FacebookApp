namespace DP_301595856_304843824
{
    public partial class FormHoroscope
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
            this.listBoxHoroscope = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxHoroscope
            // 
            this.listBoxHoroscope.FormattingEnabled = true;
            this.listBoxHoroscope.ItemHeight = 20;
            this.listBoxHoroscope.Location = new System.Drawing.Point(12, 150);
            this.listBoxHoroscope.Name = "listBoxHoroscope";
            this.listBoxHoroscope.Size = new System.Drawing.Size(1198, 184);
            this.listBoxHoroscope.TabIndex = 0;
            // 
            // FormHoroscope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 484);
            this.Controls.Add(this.listBoxHoroscope);
            this.Name = "FormHoroscope";
            this.Text = "Horoscope";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHoroscope;
    }
}