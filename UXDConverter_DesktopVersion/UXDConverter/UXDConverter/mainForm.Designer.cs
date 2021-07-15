
namespace UXDConverter
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.mainRibbon = new System.Windows.Forms.Ribbon();
            this.ribbonButtonClose = new System.Windows.Forms.RibbonButton();
            this.ribbonTabFile = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelFile = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonOpen = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonSave = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 214);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1033, 324);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(897, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open UXD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mainRibbon
            // 
            this.mainRibbon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainRibbon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainRibbon.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainRibbon.Minimized = false;
            this.mainRibbon.Name = "mainRibbon";
            // 
            // 
            // 
            this.mainRibbon.OrbDropDown.BorderRoundness = 8;
            this.mainRibbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.OrbDropDown.Name = "";
            this.mainRibbon.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.mainRibbon.OrbDropDown.TabIndex = 0;
            this.mainRibbon.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010_Extended;
            this.mainRibbon.OrbVisible = false;
            // 
            // 
            // 
            this.mainRibbon.QuickAccessToolbar.Items.Add(this.ribbonButtonClose);
            this.mainRibbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.mainRibbon.Size = new System.Drawing.Size(1067, 200);
            this.mainRibbon.TabIndex = 3;
            this.mainRibbon.Tabs.Add(this.ribbonTabFile);
            this.mainRibbon.TabSpacing = 3;
            this.mainRibbon.Text = "ribbon1";
            this.mainRibbon.ThemeColor = System.Windows.Forms.RibbonTheme.Blue_2010;
            this.mainRibbon.Click += new System.EventHandler(this.mainRibbon_Click);
            // 
            // ribbonButtonClose
            // 
            this.ribbonButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonClose.Image")));
            this.ribbonButtonClose.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonClose.LargeImage")));
            this.ribbonButtonClose.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonClose.Name = "ribbonButtonClose";
            this.ribbonButtonClose.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonClose.SmallImage")));
            this.ribbonButtonClose.Text = "ribbonButton5";
            this.ribbonButtonClose.Click += new System.EventHandler(this.ribbonButtonClose_Click);
            // 
            // ribbonTabFile
            // 
            this.ribbonTabFile.Name = "ribbonTabFile";
            this.ribbonTabFile.Panels.Add(this.ribbonPanelFile);
            this.ribbonTabFile.Text = "File";
            // 
            // ribbonPanelFile
            // 
            this.ribbonPanelFile.ButtonMoreEnabled = false;
            this.ribbonPanelFile.ButtonMoreVisible = false;
            this.ribbonPanelFile.Items.Add(this.ribbonButtonOpen);
            this.ribbonPanelFile.Items.Add(this.ribbonButtonSave);
            this.ribbonPanelFile.Name = "ribbonPanelFile";
            this.ribbonPanelFile.Text = "";
            // 
            // ribbonButtonOpen
            // 
            this.ribbonButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonOpen.Image")));
            this.ribbonButtonOpen.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonOpen.LargeImage")));
            this.ribbonButtonOpen.Name = "ribbonButtonOpen";
            this.ribbonButtonOpen.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonOpen.SmallImage")));
            this.ribbonButtonOpen.Text = "Open UXD";
            this.ribbonButtonOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // ribbonButtonSave
            // 
            this.ribbonButtonSave.Enabled = false;
            this.ribbonButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSave.Image")));
            this.ribbonButtonSave.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSave.LargeImage")));
            this.ribbonButtonSave.Name = "ribbonButtonSave";
            this.ribbonButtonSave.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSave.SmallImage")));
            this.ribbonButtonSave.Text = "Save JDX";
            this.ribbonButtonSave.Click += new System.EventHandler(this.ribbonButtonSave_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.mainRibbon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainForm";
            this.Text = "UXD Converter";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Ribbon mainRibbon;
        private System.Windows.Forms.RibbonTab ribbonTabFile;
        private System.Windows.Forms.RibbonPanel ribbonPanelFile;
        private System.Windows.Forms.RibbonButton ribbonButtonOpen;
        private System.Windows.Forms.RibbonButton ribbonButtonSave;
        private System.Windows.Forms.RibbonButton ribbonButtonClose;
    }
}