
namespace Browser
{
    partial class TheFirstForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.WebTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BookmarkComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.BackTSB = new System.Windows.Forms.ToolStripButton();
            this.ForwardTSB = new System.Windows.Forms.ToolStripButton();
            this.RebootTSB = new System.Windows.Forms.ToolStripButton();
            this.StopTSB = new System.Windows.Forms.ToolStripButton();
            this.PlusTSB = new System.Windows.Forms.ToolStripButton();
            this.HistoryTSB = new System.Windows.Forms.ToolStripButton();
            this.SaveTSB = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackTSB,
            this.ForwardTSB,
            this.RebootTSB,
            this.StopTSB,
            this.WebTextBox,
            this.toolStripLabel1,
            this.BookmarkComboBox,
            this.PlusTSB,
            this.HistoryTSB,
            this.SaveTSB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // WebTextBox
            // 
            this.WebTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WebTextBox.Name = "WebTextBox";
            this.WebTextBox.Size = new System.Drawing.Size(350, 25);
            this.WebTextBox.Text = "https://";
            this.WebTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WebTSB_KeyDown);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Закладки";
            // 
            // BookmarkComboBox
            // 
            this.BookmarkComboBox.Name = "BookmarkComboBox";
            this.BookmarkComboBox.Size = new System.Drawing.Size(121, 25);
            this.BookmarkComboBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookmarkComboBox_MouseDown);
            // 
            // WebBrowser
            // 
            this.WebBrowser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WebBrowser.Location = new System.Drawing.Point(0, 28);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(800, 422);
            this.WebBrowser.TabIndex = 1;
            // 
            // BackTSB
            // 
            this.BackTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackTSB.Image = global::Browser.Properties.Resources.Back;
            this.BackTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackTSB.Name = "BackTSB";
            this.BackTSB.Size = new System.Drawing.Size(23, 22);
            this.BackTSB.Text = "toolStripButton1";
            this.BackTSB.Click += new System.EventHandler(this.BackTSB_Click);
            // 
            // ForwardTSB
            // 
            this.ForwardTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ForwardTSB.Image = global::Browser.Properties.Resources.Forward;
            this.ForwardTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForwardTSB.Name = "ForwardTSB";
            this.ForwardTSB.Size = new System.Drawing.Size(23, 22);
            this.ForwardTSB.Text = "toolStripButton2";
            this.ForwardTSB.Click += new System.EventHandler(this.ForwardTSB_Click);
            // 
            // RebootTSB
            // 
            this.RebootTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RebootTSB.Image = global::Browser.Properties.Resources.Reboot;
            this.RebootTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RebootTSB.Name = "RebootTSB";
            this.RebootTSB.Size = new System.Drawing.Size(23, 22);
            this.RebootTSB.Text = "toolStripButton3";
            this.RebootTSB.Click += new System.EventHandler(this.RebootTSB_Click);
            // 
            // StopTSB
            // 
            this.StopTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StopTSB.Image = global::Browser.Properties.Resources.Stop;
            this.StopTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopTSB.Name = "StopTSB";
            this.StopTSB.Size = new System.Drawing.Size(23, 22);
            this.StopTSB.Text = "toolStripButton4";
            this.StopTSB.Click += new System.EventHandler(this.StopTSB_Click);
            // 
            // PlusTSB
            // 
            this.PlusTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PlusTSB.Image = global::Browser.Properties.Resources.Plus;
            this.PlusTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PlusTSB.Name = "PlusTSB";
            this.PlusTSB.Size = new System.Drawing.Size(23, 22);
            this.PlusTSB.Text = "toolStripButton1";
            this.PlusTSB.Click += new System.EventHandler(this.PlusTSB_Click);
            // 
            // HistoryTSB
            // 
            this.HistoryTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HistoryTSB.Image = global::Browser.Properties.Resources.History;
            this.HistoryTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HistoryTSB.Name = "HistoryTSB";
            this.HistoryTSB.Size = new System.Drawing.Size(23, 22);
            this.HistoryTSB.Text = "toolStripButton2";
            this.HistoryTSB.Click += new System.EventHandler(this.HistoryTSB_Click);
            // 
            // SaveTSB
            // 
            this.SaveTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveTSB.Image = global::Browser.Properties.Resources.Save;
            this.SaveTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveTSB.Name = "SaveTSB";
            this.SaveTSB.Size = new System.Drawing.Size(23, 22);
            this.SaveTSB.Text = "toolStripButton3";
            this.SaveTSB.Click += new System.EventHandler(this.SaveTSB_Click);
            // 
            // TheFirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WebBrowser);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TheFirstForm";
            this.Text = "My Browser";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BackTSB;
        private System.Windows.Forms.ToolStripButton ForwardTSB;
        private System.Windows.Forms.ToolStripButton RebootTSB;
        private System.Windows.Forms.ToolStripButton StopTSB;
        private System.Windows.Forms.ToolStripTextBox WebTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox BookmarkComboBox;
        private System.Windows.Forms.ToolStripButton PlusTSB;
        private System.Windows.Forms.ToolStripButton HistoryTSB;
        private System.Windows.Forms.ToolStripButton SaveTSB;
        private System.Windows.Forms.WebBrowser WebBrowser;
    }
}

