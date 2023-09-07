
namespace TLabBrowser
{
    // ----------------------------------------------------
    // partial class : クラスの中身を分割している
    //
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BrowserPanel = new System.Windows.Forms.Panel();
            this.GoBack = new System.Windows.Forms.Button();
            this.GoNext = new System.Windows.Forms.Button();
            this.GoHome = new System.Windows.Forms.Button();
            this.URLText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.BrowserPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.GoBack, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GoNext, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GoHome, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.URLText, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(816, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BrowserPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.BrowserPanel, 4);
            this.BrowserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserPanel.Location = new System.Drawing.Point(3, 53);
            this.BrowserPanel.Name = "BrowserPanel";
            this.BrowserPanel.Size = new System.Drawing.Size(810, 394);
            this.BrowserPanel.TabIndex = 0;
            this.BrowserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BrowserPanel_Paint);
            // 
            // GoBack
            // 
            this.GoBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoBack.Location = new System.Drawing.Point(3, 3);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(44, 44);
            this.GoBack.TabIndex = 1;
            this.GoBack.Text = "←";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // GoNext
            // 
            this.GoNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoNext.Location = new System.Drawing.Point(53, 3);
            this.GoNext.Name = "GoNext";
            this.GoNext.Size = new System.Drawing.Size(44, 44);
            this.GoNext.TabIndex = 2;
            this.GoNext.Text = "→";
            this.GoNext.UseVisualStyleBackColor = true;
            this.GoNext.Click += new System.EventHandler(this.GoNext_Click);
            // 
            // GoHome
            // 
            this.GoHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoHome.Location = new System.Drawing.Point(103, 3);
            this.GoHome.Name = "GoHome";
            this.GoHome.Size = new System.Drawing.Size(44, 44);
            this.GoHome.TabIndex = 3;
            this.GoHome.Text = "home";
            this.GoHome.UseVisualStyleBackColor = true;
            this.GoHome.Click += new System.EventHandler(this.GoHome_Click);
            // 
            // URLText
            // 
            this.URLText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.URLText.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.URLText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.URLText.Location = new System.Drawing.Point(160, 10);
            this.URLText.Margin = new System.Windows.Forms.Padding(10);
            this.URLText.Name = "URLText";
            this.URLText.Size = new System.Drawing.Size(646, 26);
            this.URLText.TabIndex = 4;
            this.URLText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.URLText_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "T_Lab_Browser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel BrowserPanel;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.Button GoNext;
        private System.Windows.Forms.Button GoHome;
        private System.Windows.Forms.TextBox URLText;
    }
}

