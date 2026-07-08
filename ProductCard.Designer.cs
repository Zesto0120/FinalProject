namespace FinalProject
{
    partial class ProductCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lblPrice = new Label();
            lblName = new Label();
            btnAddToCart = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 219);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(27, 225);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(57, 21);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "label1";
            lblPrice.Click += label1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(31, 266);
            lblName.Name = "lblName";
            lblName.Size = new Size(53, 19);
            lblName.TabIndex = 2;
            lblName.Text = "label2";
            // 
            // btnAddToCart
            // 
            btnAddToCart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddToCart.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddToCart.Depth = 0;
            btnAddToCart.HighEmphasis = true;
            btnAddToCart.Icon = null;
            btnAddToCart.Location = new Point(54, 308);
            btnAddToCart.Margin = new Padding(4, 6, 4, 6);
            btnAddToCart.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.NoAccentTextColor = Color.Empty;
            btnAddToCart.Size = new Size(158, 36);
            btnAddToCart.TabIndex = 3;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddToCart.UseAccentColor = false;
            btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // ProductCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddToCart);
            Controls.Add(lblName);
            Controls.Add(lblPrice);
            Controls.Add(pictureBox1);
            Name = "ProductCard";
            Size = new Size(278, 383);
            Load += ProductCard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblPrice;
        private Label lblName;
        private MaterialSkin.Controls.MaterialButton btnAddToCart;
    }
}
