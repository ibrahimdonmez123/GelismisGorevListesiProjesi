namespace GelismisGorevListesiProjesi
{
    partial class MainMenu
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btn_save_click = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(141, 143);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(195, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // btn_save_click
            // 
            this.btn_save_click.Location = new System.Drawing.Point(131, 268);
            this.btn_save_click.Name = "btn_save_click";
            this.btn_save_click.Size = new System.Drawing.Size(205, 68);
            this.btn_save_click.TabIndex = 2;
            this.btn_save_click.Text = "NOTLARA EKLE";
            this.btn_save_click.UseVisualStyleBackColor = true;
            this.btn_save_click.Click += new System.EventHandler(this.btn_save_click_Click);
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(364, 268);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(205, 68);
            this.btn_list.TabIndex = 2;
            this.btn_list.Text = "NOTLARI GÖSTER";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(364, 143);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(368, 20);
            this.txtContent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(145, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Başlığı Gir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(369, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "İçeriği Gir";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.btn_save_click);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btn_save_click;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}