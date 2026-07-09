namespace FinalProject
{
    partial class Market
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
            mbtnMarket = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // mbtnMarket
            // 
            mbtnMarket.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnMarket.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnMarket.Depth = 0;
            mbtnMarket.HighEmphasis = true;
            mbtnMarket.Icon = null;
            mbtnMarket.Location = new Point(501, 551);
            mbtnMarket.Margin = new Padding(4, 6, 4, 6);
            mbtnMarket.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnMarket.Name = "mbtnMarket";
            mbtnMarket.NoAccentTextColor = Color.Empty;
            mbtnMarket.Size = new Size(158, 36);
            mbtnMarket.TabIndex = 0;
            mbtnMarket.Text = "Payment";
            mbtnMarket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnMarket.UseAccentColor = false;
            mbtnMarket.UseVisualStyleBackColor = true;
            // 
            // Market
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 602);
            Controls.Add(mbtnMarket);
            Name = "Market";
            Text = "Market";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton mbtnMarket;
    }
}