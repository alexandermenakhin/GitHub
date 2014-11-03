namespace GreenICT3
{
    partial class ShoppingList
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
            this.lbxCollection = new System.Windows.Forms.ListBox();
            this.tabAll = new System.Windows.Forms.TabControl();
            this.tabpMain = new System.Windows.Forms.TabPage();
            this.tabpCart = new System.Windows.Forms.TabPage();
            this.lbxTitle = new System.Windows.Forms.Label();
            this.lbxIngr = new System.Windows.Forms.ListBox();
            this.tabAll.SuspendLayout();
            this.tabpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxCollection
            // 
            this.lbxCollection.FormattingEnabled = true;
            this.lbxCollection.Location = new System.Drawing.Point(7, 59);
            this.lbxCollection.Name = "lbxCollection";
            this.lbxCollection.Size = new System.Drawing.Size(141, 342);
            this.lbxCollection.TabIndex = 0;
            this.lbxCollection.SelectedIndexChanged += new System.EventHandler(this.lbxCollection_SelectedIndexChanged);
            // 
            // tabAll
            // 
            this.tabAll.Controls.Add(this.tabpMain);
            this.tabAll.Controls.Add(this.tabpCart);
            this.tabAll.Location = new System.Drawing.Point(1, 2);
            this.tabAll.Name = "tabAll";
            this.tabAll.SelectedIndex = 0;
            this.tabAll.Size = new System.Drawing.Size(773, 722);
            this.tabAll.TabIndex = 1;
            // 
            // tabpMain
            // 
            this.tabpMain.Controls.Add(this.lbxIngr);
            this.tabpMain.Controls.Add(this.lbxTitle);
            this.tabpMain.Controls.Add(this.lbxCollection);
            this.tabpMain.Location = new System.Drawing.Point(4, 22);
            this.tabpMain.Name = "tabpMain";
            this.tabpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabpMain.Size = new System.Drawing.Size(765, 696);
            this.tabpMain.TabIndex = 0;
            this.tabpMain.Text = "Main";
            this.tabpMain.UseVisualStyleBackColor = true;
            // 
            // tabpCart
            // 
            this.tabpCart.Location = new System.Drawing.Point(4, 22);
            this.tabpCart.Name = "tabpCart";
            this.tabpCart.Padding = new System.Windows.Forms.Padding(3);
            this.tabpCart.Size = new System.Drawing.Size(765, 696);
            this.tabpCart.TabIndex = 1;
            this.tabpCart.Text = "Cart";
            this.tabpCart.UseVisualStyleBackColor = true;
            // 
            // lbxTitle
            // 
            this.lbxTitle.AutoSize = true;
            this.lbxTitle.Location = new System.Drawing.Point(7, 40);
            this.lbxTitle.Name = "lbxTitle";
            this.lbxTitle.Size = new System.Drawing.Size(93, 13);
            this.lbxTitle.TabIndex = 1;
            this.lbxTitle.Text = "Choose the recipe";
            // 
            // lbxIngr
            // 
            this.lbxIngr.FormattingEnabled = true;
            this.lbxIngr.Location = new System.Drawing.Point(199, 59);
            this.lbxIngr.Name = "lbxIngr";
            this.lbxIngr.Size = new System.Drawing.Size(141, 342);
            this.lbxIngr.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 727);
            this.Controls.Add(this.tabAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabAll.ResumeLayout(false);
            this.tabpMain.ResumeLayout(false);
            this.tabpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCollection;
        private System.Windows.Forms.TabControl tabAll;
        private System.Windows.Forms.TabPage tabpMain;
        private System.Windows.Forms.Label lbxTitle;
        private System.Windows.Forms.TabPage tabpCart;
        private System.Windows.Forms.ListBox lbxIngr;
    }
}

