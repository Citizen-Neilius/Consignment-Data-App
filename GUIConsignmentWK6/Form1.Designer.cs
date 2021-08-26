namespace GUIConsignmentWK6
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
            this.radioVideoG = new System.Windows.Forms.RadioButton();
            this.radioMusic = new System.Windows.Forms.RadioButton();
            this.radioComic = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxListviewer = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textDelete = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioVideoG
            // 
            this.radioVideoG.AutoSize = true;
            this.radioVideoG.Checked = true;
            this.radioVideoG.Location = new System.Drawing.Point(50, 75);
            this.radioVideoG.Margin = new System.Windows.Forms.Padding(6);
            this.radioVideoG.Name = "radioVideoG";
            this.radioVideoG.Size = new System.Drawing.Size(172, 29);
            this.radioVideoG.TabIndex = 0;
            this.radioVideoG.TabStop = true;
            this.radioVideoG.Text = "Video Games";
            this.radioVideoG.UseVisualStyleBackColor = true;
            this.radioVideoG.Click += new System.EventHandler(this.radioVideoG_Click);
            // 
            // radioMusic
            // 
            this.radioMusic.AutoSize = true;
            this.radioMusic.Location = new System.Drawing.Point(50, 106);
            this.radioMusic.Margin = new System.Windows.Forms.Padding(6);
            this.radioMusic.Name = "radioMusic";
            this.radioMusic.Size = new System.Drawing.Size(106, 29);
            this.radioMusic.TabIndex = 1;
            this.radioMusic.Text = "Music ";
            this.radioMusic.UseVisualStyleBackColor = true;
            this.radioMusic.Click += new System.EventHandler(this.radioMusic_Click);
            // 
            // radioComic
            // 
            this.radioComic.AutoSize = true;
            this.radioComic.Location = new System.Drawing.Point(50, 136);
            this.radioComic.Margin = new System.Windows.Forms.Padding(6);
            this.radioComic.Name = "radioComic";
            this.radioComic.Size = new System.Drawing.Size(169, 29);
            this.radioComic.TabIndex = 2;
            this.radioComic.Text = "Comic Books";
            this.radioComic.UseVisualStyleBackColor = true;
            this.radioComic.Click += new System.EventHandler(this.radioComic_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(511, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(458, 31);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(511, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(458, 31);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(511, 197);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(458, 31);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(511, 256);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(458, 31);
            this.textBox4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 197);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // textBoxListviewer
            // 
            this.textBoxListviewer.Location = new System.Drawing.Point(12, 308);
            this.textBoxListviewer.MinimumSize = new System.Drawing.Size(900, 300);
            this.textBoxListviewer.Multiline = true;
            this.textBoxListviewer.Name = "textBoxListviewer";
            this.textBoxListviewer.ReadOnly = true;
            this.textBoxListviewer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxListviewer.Size = new System.Drawing.Size(1879, 300);
            this.textBoxListviewer.TabIndex = 11;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(50, 197);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(207, 46);
            this.ButtonAdd.TabIndex = 12;
            this.ButtonAdd.Text = "Add Item";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(1114, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(226, 53);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(1114, 94);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(226, 53);
            this.buttonLoad.TabIndex = 14;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textDelete
            // 
            this.textDelete.Location = new System.Drawing.Point(1240, 236);
            this.textDelete.Name = "textDelete";
            this.textDelete.Size = new System.Drawing.Size(137, 31);
            this.textDelete.TabIndex = 15;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1040, 236);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(194, 66);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete Item #";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textDelete);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.textBoxListviewer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioComic);
            this.Controls.Add(this.radioMusic);
            this.Controls.Add(this.radioVideoG);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Consignment Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioVideoG;
        private System.Windows.Forms.RadioButton radioMusic;
        private System.Windows.Forms.RadioButton radioComic;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxListviewer;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textDelete;
        private System.Windows.Forms.Button buttonDelete;
    }
}

