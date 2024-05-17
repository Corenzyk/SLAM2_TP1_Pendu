namespace SLAM2_TP1_Pendu
{
    partial class Donnees
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
            this.btn_close = new System.Windows.Forms.Button();
            this.dgv_Mots = new System.Windows.Forms.DataGridView();
            this.cb_RechercheDiff = new System.Windows.Forms.ComboBox();
            this.txt_RechercheMots = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mots)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.btn_close.ForeColor = System.Drawing.Color.Red;
            this.btn_close.Location = new System.Drawing.Point(794, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 36;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_1);
            // 
            // dgv_Mots
            // 
            this.dgv_Mots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mots.Location = new System.Drawing.Point(15, 90);
            this.dgv_Mots.Name = "dgv_Mots";
            this.dgv_Mots.Size = new System.Drawing.Size(408, 371);
            this.dgv_Mots.TabIndex = 0;
            // 
            // cb_RechercheDiff
            // 
            this.cb_RechercheDiff.FormattingEnabled = true;
            this.cb_RechercheDiff.Location = new System.Drawing.Point(150, 53);
            this.cb_RechercheDiff.Name = "cb_RechercheDiff";
            this.cb_RechercheDiff.Size = new System.Drawing.Size(270, 21);
            this.cb_RechercheDiff.TabIndex = 37;
            this.cb_RechercheDiff.SelectionChangeCommitted += new System.EventHandler(this.cb_RechercheDiff_SelectionChangeCommitted);
            // 
            // txt_RechercheMots
            // 
            this.txt_RechercheMots.Location = new System.Drawing.Point(150, 27);
            this.txt_RechercheMots.Name = "txt_RechercheMots";
            this.txt_RechercheMots.Size = new System.Drawing.Size(270, 20);
            this.txt_RechercheMots.TabIndex = 38;
            this.txt_RechercheMots.TextChanged += new System.EventHandler(this.txt_RechercheMots_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Recherche un mot :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Rechercher une difficulté :";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(546, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 413);
            this.panel1.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(447, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(447, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 44;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Donnees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(836, 473);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_RechercheMots);
            this.Controls.Add(this.cb_RechercheDiff);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dgv_Mots);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Donnees";
            this.Text = "Donnes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridView dgv_Mots;
        private System.Windows.Forms.ComboBox cb_RechercheDiff;
        private System.Windows.Forms.TextBox txt_RechercheMots;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}