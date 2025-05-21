namespace ProductManager
{
    partial class product_Form
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
            name_lbl = new Label();
            product_txtbox = new TextBox();
            add_bttn = new Button();
            exit_bttn = new Button();
            SuspendLayout();
            // 
            // name_lbl
            // 
            name_lbl.AutoSize = true;
            name_lbl.Location = new Point(30, 185);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(172, 32);
            name_lbl.TabIndex = 0;
            name_lbl.Text = "Product Name:";
            // 
            // product_txtbox
            // 
            product_txtbox.Location = new Point(221, 182);
            product_txtbox.Name = "product_txtbox";
            product_txtbox.Size = new Size(200, 39);
            product_txtbox.TabIndex = 1;
            // 
            // add_bttn
            // 
            add_bttn.Location = new Point(38, 343);
            add_bttn.Name = "add_bttn";
            add_bttn.Size = new Size(164, 78);
            add_bttn.TabIndex = 2;
            add_bttn.Text = "Add Product ";
            add_bttn.UseVisualStyleBackColor = true;
            add_bttn.Click += add_bttn_Click;
            // 
            // exit_bttn
            // 
            exit_bttn.Location = new Point(248, 343);
            exit_bttn.Name = "exit_bttn";
            exit_bttn.Size = new Size(164, 78);
            exit_bttn.TabIndex = 3;
            exit_bttn.Text = "Exit";
            exit_bttn.UseVisualStyleBackColor = true;
            exit_bttn.Click += exit_bttn_Click;
            // 
            // product_Form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 515);
            Controls.Add(exit_bttn);
            Controls.Add(add_bttn);
            Controls.Add(product_txtbox);
            Controls.Add(name_lbl);
            Name = "product_Form";
            Text = "Product Manager";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_lbl;
        private TextBox product_txtbox;
        private Button add_bttn;
        private Button exit_bttn;
    }
}
