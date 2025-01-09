using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Projet_cours_1
{
    partial class FormAccueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            listBoxBooks = new ListBox();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            labelSearch = new Label();
            labelTitle = new Label();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(10, 105);
            listBoxBooks.Margin = new Padding(3, 2, 3, 2);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(680, 244);
            listBoxBooks.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 10F);
            textBoxSearch.Location = new Point(12, 64);
            textBoxSearch.Margin = new Padding(3, 2, 3, 2);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(592, 25);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.LightSteelBlue;
            buttonSearch.Font = new Font("Segoe UI", 10F);
            buttonSearch.Location = new Point(608, 64);
            buttonSearch.Margin = new Padding(3, 2, 3, 2);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(82, 22);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Rechercher";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 10F);
            labelSearch.Location = new Point(10, 360);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(0, 19);
            labelSearch.TabIndex = 3;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.Location = new Point(176, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(303, 30);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Bienvenue dans BiblioWorld";
            labelTitle.Click += labelTitle_Click;
            // 
            // FormAccueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 505);
            Controls.Add(labelTitle);
            Controls.Add(labelSearch);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(listBoxBooks);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAccueil";
            Text = "Accueil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelTitle;
    }
}