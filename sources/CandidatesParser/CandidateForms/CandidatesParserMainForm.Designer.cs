namespace CandidatesParser.CandidateForms
{
    partial class CandidatesParserMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidatesParserMainForm));
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.Form1_Button_FilePath = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Form1_TextField_FilePath = new DevExpress.XtraEditors.TextEdit();
            this.Form1_Button_OK = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout_TextField = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Form1_PictureBox = new System.Windows.Forms.PictureBox();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Form1_TextField_FilePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_TextField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form1_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Foggy";
            // 
            // Form1_Button_FilePath
            // 
            this.Form1_Button_FilePath.Location = new System.Drawing.Point(347, 12);
            this.Form1_Button_FilePath.Name = "Form1_Button_FilePath";
            this.Form1_Button_FilePath.Size = new System.Drawing.Size(55, 52);
            this.Form1_Button_FilePath.StyleController = this.layoutControl1;
            this.Form1_Button_FilePath.TabIndex = 11;
            this.Form1_Button_FilePath.Text = "...";
            this.Form1_Button_FilePath.Click += new System.EventHandler(this.Form1_Button_FilePath_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.Transparent;
            this.layoutControl1.Controls.Add(this.Form1_TextField_FilePath);
            this.layoutControl1.Controls.Add(this.Form1_Button_FilePath);
            this.layoutControl1.Controls.Add(this.Form1_PictureBox);
            this.layoutControl1.Controls.Add(this.Form1_Button_OK);
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(875, 290, 250, 386);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(414, 152);
            this.layoutControl1.TabIndex = 15;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Form1_TextField_FilePath
            // 
            this.Form1_TextField_FilePath.EditValue = "Путь к файлу...";
            this.Form1_TextField_FilePath.Location = new System.Drawing.Point(162, 27);
            this.Form1_TextField_FilePath.Name = "Form1_TextField_FilePath";
            this.Form1_TextField_FilePath.Size = new System.Drawing.Size(179, 20);
            this.Form1_TextField_FilePath.StyleController = this.layoutControl1;
            this.Form1_TextField_FilePath.TabIndex = 12;
            // 
            // Form1_Button_OK
            // 
            this.Form1_Button_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Form1_Button_OK.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Form1_Button_OK.Appearance.Options.UseFont = true;
            this.Form1_Button_OK.Location = new System.Drawing.Point(162, 92);
            this.Form1_Button_OK.Name = "Form1_Button_OK";
            this.Form1_Button_OK.Size = new System.Drawing.Size(240, 48);
            this.Form1_Button_OK.StyleController = this.layoutControl1;
            this.Form1_Button_OK.TabIndex = 13;
            this.Form1_Button_OK.Text = "OK";
            this.Form1_Button_OK.Click += new System.EventHandler(this.Form1_Button_OK_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Enabled = false;
            this.simpleButton1.Location = new System.Drawing.Point(160, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(183, 50);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 15;
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layout_TextField,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(414, 152);
            this.Root.Text = "Root";
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(148, 56);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(246, 24);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.Form1_Button_OK;
            this.layoutControlItem2.CustomizationFormText = "layout_Button_OK";
            this.layoutControlItem2.Location = new System.Drawing.Point(148, 80);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(37, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 2, 2, 2);
            this.layoutControlItem2.Size = new System.Drawing.Size(246, 52);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layout_TextField
            // 
            this.layout_TextField.Control = this.Form1_TextField_FilePath;
            this.layout_TextField.CustomizationFormText = "layout_TextField";
            this.layout_TextField.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layout_TextField.Location = new System.Drawing.Point(148, 15);
            this.layout_TextField.MinSize = new System.Drawing.Size(58, 20);
            this.layout_TextField.Name = "layout_TextField";
            this.layout_TextField.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 2, 2);
            this.layout_TextField.Size = new System.Drawing.Size(187, 41);
            this.layout_TextField.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layout_TextField.Text = "layout_TextField";
            this.layout_TextField.TextSize = new System.Drawing.Size(0, 0);
            this.layout_TextField.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Form1_Button_FilePath;
            this.layoutControlItem4.CustomizationFormText = "layout_Button_FilePath";
            this.layoutControlItem4.Location = new System.Drawing.Point(335, 0);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(27, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(59, 56);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton1;
            this.layoutControlItem5.CustomizationFormText = "layout_UnusedButton";
            this.layoutControlItem5.Location = new System.Drawing.Point(148, 0);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(20, 15);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, -37);
            this.layoutControlItem5.Size = new System.Drawing.Size(187, 15);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // Form1_PictureBox
            // 
            this.Form1_PictureBox.Image = global::CandidatesParser.Properties.Resources.Main_Ima;
            this.Form1_PictureBox.Location = new System.Drawing.Point(12, 12);
            this.Form1_PictureBox.Name = "Form1_PictureBox";
            this.Form1_PictureBox.Size = new System.Drawing.Size(144, 128);
            this.Form1_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Form1_PictureBox.TabIndex = 10;
            this.Form1_PictureBox.TabStop = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.Form1_PictureBox;
            this.layoutControlItem1.CustomizationFormText = "layout_Image";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(148, 132);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 152);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XtraForm1";
            this.Text = "Adding Contacts v1.0";
            this.ResizeEnd += new System.EventHandler(this.XtraForm1_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.resizeFormInside);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Form1_TextField_FilePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_TextField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form1_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        internal System.Windows.Forms.PictureBox Form1_PictureBox;
        internal DevExpress.XtraEditors.SimpleButton Form1_Button_FilePath;
        internal DevExpress.XtraEditors.TextEdit Form1_TextField_FilePath;
        internal DevExpress.XtraEditors.SimpleButton Form1_Button_OK;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layout_TextField;

        internal int form1OrigHight = 0;
        internal int form1OrigWidth = 0;
        internal int form1MainLayoutOrigHeight = 0;
        internal int form1MainLayoutOrigWidth = 0;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}