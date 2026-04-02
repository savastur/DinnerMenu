namespace DinnerMenu
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
            System.Windows.Forms.Label Menu;
            this.SaladButton = new System.Windows.Forms.Button();
            this.SoupButton = new System.Windows.Forms.Button();
            this.PastaButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MenuTextBox = new System.Windows.Forms.RichTextBox();
            this.ButtonBox = new System.Windows.Forms.GroupBox();
            Menu = new System.Windows.Forms.Label();
            this.ButtonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            Menu.AccessibleName = "Label";
            Menu.AutoSize = true;
            Menu.Enabled = false;
            Menu.Font = new System.Drawing.Font("Niagara Engraved", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Menu.Location = new System.Drawing.Point(334, 22);
            Menu.Name = "Menu";
            Menu.Size = new System.Drawing.Size(127, 40);
            Menu.TabIndex = 6;
            Menu.Text = "Savage Diner";
            // 
            // SaladButton
            // 
            this.SaladButton.AccessibleDescription = "Brings up Salad Menu";
            this.SaladButton.AccessibleName = "SaladButton";
            this.SaladButton.Location = new System.Drawing.Point(6, 21);
            this.SaladButton.Name = "SaladButton";
            this.SaladButton.Size = new System.Drawing.Size(75, 73);
            this.SaladButton.TabIndex = 0;
            this.SaladButton.Text = "Salad";
            this.SaladButton.UseVisualStyleBackColor = true;
            this.SaladButton.Click += new System.EventHandler(this.saladButton_Click);
            // 
            // SoupButton
            // 
            this.SoupButton.AccessibleDescription = "Brings Up Soup Menu";
            this.SoupButton.AccessibleName = "SoupButton";
            this.SoupButton.Location = new System.Drawing.Point(111, 21);
            this.SoupButton.Name = "SoupButton";
            this.SoupButton.Size = new System.Drawing.Size(75, 73);
            this.SoupButton.TabIndex = 1;
            this.SoupButton.Text = "Soup";
            this.SoupButton.UseVisualStyleBackColor = true;
            this.SoupButton.Click += new System.EventHandler(this.soupButton_Click);
            // 
            // PastaButton
            // 
            this.PastaButton.AccessibleDescription = "Brings up the Pasta menu";
            this.PastaButton.AccessibleName = "PastaButton";
            this.PastaButton.Location = new System.Drawing.Point(212, 21);
            this.PastaButton.Name = "PastaButton";
            this.PastaButton.Size = new System.Drawing.Size(75, 73);
            this.PastaButton.TabIndex = 2;
            this.PastaButton.Text = "Pasta";
            this.PastaButton.UseVisualStyleBackColor = true;
            this.PastaButton.Click += new System.EventHandler(this.pastaButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AccessibleDescription = "Closes the Program";
            this.ExitButton.AccessibleName = "ExitButton";
            this.ExitButton.Location = new System.Drawing.Point(578, 21);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(164, 73);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MenuTextBox
            // 
            this.MenuTextBox.AccessibleDescription = "Dispaly\'s ";
            this.MenuTextBox.AccessibleName = "Menu";
            this.MenuTextBox.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTextBox.Location = new System.Drawing.Point(22, 65);
            this.MenuTextBox.Name = "MenuTextBox";
            this.MenuTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.MenuTextBox.Size = new System.Drawing.Size(742, 267);
            this.MenuTextBox.TabIndex = 4;
            this.MenuTextBox.TabStop = false;
            this.MenuTextBox.Text = "";
            // 
            // ButtonBox
            // 
            this.ButtonBox.AccessibleName = "ButtonBox";
            this.ButtonBox.Controls.Add(this.SaladButton);
            this.ButtonBox.Controls.Add(this.SoupButton);
            this.ButtonBox.Controls.Add(this.ExitButton);
            this.ButtonBox.Controls.Add(this.PastaButton);
            this.ButtonBox.Location = new System.Drawing.Point(22, 338);
            this.ButtonBox.Name = "ButtonBox";
            this.ButtonBox.Size = new System.Drawing.Size(766, 100);
            this.ButtonBox.TabIndex = 5;
            this.ButtonBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(Menu);
            this.Controls.Add(this.ButtonBox);
            this.Controls.Add(this.MenuTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ButtonBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaladButton;
        private System.Windows.Forms.Button SoupButton;
        private System.Windows.Forms.Button PastaButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.RichTextBox MenuTextBox;
        private System.Windows.Forms.GroupBox ButtonBox;
    }
}

