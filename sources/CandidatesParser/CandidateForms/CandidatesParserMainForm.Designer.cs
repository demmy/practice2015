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
            this.button_FilePath = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.textField_FilePath = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox_FacesImage = new System.Windows.Forms.PictureBox();
            this.button_OK = new DevExpress.XtraEditors.SimpleButton();
            this.button_UnUsed = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControl_Image = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl_EmptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControl_Button_OK = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl_TextField = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl_Button_FilePath = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl_Button_Unused = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textField_FilePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FacesImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_EmptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Button_OK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_TextField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Button_FilePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Button_Unused)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Foggy";
            // 
            // button_FilePath
            // 
            this.button_FilePath.Location = new System.Drawing.Point(347, 12);
            this.button_FilePath.Name = "button_FilePath";
            this.button_FilePath.Size = new System.Drawing.Size(55, 52);
            this.button_FilePath.StyleController = this.layoutControl;
            this.button_FilePath.TabIndex = 11;
            this.button_FilePath.Text = "...";
            this.button_FilePath.Click += new System.EventHandler(this.Button_FilePath_Click);
            // 
            // layoutControl
            // 
            this.layoutControl.BackColor = System.Drawing.Color.Transparent;
            this.layoutControl.Controls.Add(this.textField_FilePath);
            this.layoutControl.Controls.Add(this.button_FilePath);
            this.layoutControl.Controls.Add(this.pictureBox_FacesImage);
            this.layoutControl.Controls.Add(this.button_OK);
            this.layoutControl.Controls.Add(this.button_UnUsed);
            this.layoutControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(875, 290, 250, 386);
            this.layoutControl.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControl.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.layoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControl.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControl.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControl.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(414, 152);
            this.layoutControl.TabIndex = 15;
            this.layoutControl.Text = "layoutControl";
            // 
            // textField_FilePath
            // 
            this.textField_FilePath.EditValue = "Путь к файлу...";
            this.textField_FilePath.Location = new System.Drawing.Point(162, 27);
            this.textField_FilePath.Name = "textField_FilePath";
            this.textField_FilePath.Size = new System.Drawing.Size(179, 20);
            this.textField_FilePath.StyleController = this.layoutControl;
            this.textField_FilePath.TabIndex = 12;
            this.textField_FilePath.Click += new System.EventHandler(this.TextField_FilePath_MouseClick);
            this.textField_FilePath.Leave += new System.EventHandler(this.TextField_FilePath_Leave);
            // 
            // pictureBox_FacesImage
            // 
            this.pictureBox_FacesImage.Image = global::CandidatesParser.Properties.Resources.Main_Ima;
            this.pictureBox_FacesImage.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_FacesImage.Name = "pictureBox_FacesImage";
            this.pictureBox_FacesImage.Size = new System.Drawing.Size(144, 128);
            this.pictureBox_FacesImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_FacesImage.TabIndex = 10;
            this.pictureBox_FacesImage.TabStop = false;
            // 
            // button_OK
            // 
            this.button_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_OK.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button_OK.Appearance.Options.UseFont = true;
            this.button_OK.Location = new System.Drawing.Point(162, 92);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(240, 48);
            this.button_OK.StyleController = this.layoutControl;
            this.button_OK.TabIndex = 13;
            this.button_OK.Text = "OK";
            this.button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // button_UnUsed
            // 
            this.button_UnUsed.Enabled = false;
            this.button_UnUsed.Location = new System.Drawing.Point(160, 12);
            this.button_UnUsed.Name = "button_UnUsed";
            this.button_UnUsed.Size = new System.Drawing.Size(183, 50);
            this.button_UnUsed.StyleController = this.layoutControl;
            this.button_UnUsed.TabIndex = 15;
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControl_Image,
            this.layoutControl_EmptySpaceItem1,
            this.layoutControl_Button_OK,
            this.layoutControl_TextField,
            this.layoutControl_Button_FilePath,
            this.layoutControl_Button_Unused});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(414, 152);
            this.Root.Text = "Root";
            this.Root.TextVisible = false;
            // 
            // layoutControl_Image
            // 
            this.layoutControl_Image.Control = this.pictureBox_FacesImage;
            this.layoutControl_Image.CustomizationFormText = "layoutControl_Image";
            this.layoutControl_Image.Location = new System.Drawing.Point(0, 0);
            this.layoutControl_Image.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControl_Image.Name = "layoutControl_Image";
            this.layoutControl_Image.Size = new System.Drawing.Size(148, 132);
            this.layoutControl_Image.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControl_Image.Text = "layoutControl_Image";
            this.layoutControl_Image.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControl_Image.TextVisible = false;
            // 
            // layoutControl_EmptySpaceItem1
            // 
            this.layoutControl_EmptySpaceItem1.AllowHotTrack = false;
            this.layoutControl_EmptySpaceItem1.CustomizationFormText = "layoutControl_EmptySpaceItem1";
            this.layoutControl_EmptySpaceItem1.Location = new System.Drawing.Point(148, 56);
            this.layoutControl_EmptySpaceItem1.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControl_EmptySpaceItem1.Name = "layoutControl_EmptySpaceItem1";
            this.layoutControl_EmptySpaceItem1.Size = new System.Drawing.Size(246, 24);
            this.layoutControl_EmptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControl_EmptySpaceItem1.Text = "layoutControl_EmptySpaceItem1";
            this.layoutControl_EmptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControl_Button_OK
            // 
            this.layoutControl_Button_OK.Control = this.button_OK;
            this.layoutControl_Button_OK.CustomizationFormText = "layoutControl_Button_OK";
            this.layoutControl_Button_OK.Location = new System.Drawing.Point(148, 80);
            this.layoutControl_Button_OK.MinSize = new System.Drawing.Size(37, 30);
            this.layoutControl_Button_OK.Name = "layoutControl_Button_OK";
            this.layoutControl_Button_OK.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 2, 2, 2);
            this.layoutControl_Button_OK.Size = new System.Drawing.Size(246, 52);
            this.layoutControl_Button_OK.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControl_Button_OK.Text = "layoutControl_Button_OK";
            this.layoutControl_Button_OK.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControl_Button_OK.TextVisible = false;
            // 
            // layoutControl_TextField
            // 
            this.layoutControl_TextField.Control = this.textField_FilePath;
            this.layoutControl_TextField.CustomizationFormText = "layoutControl_TextField";
            this.layoutControl_TextField.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControl_TextField.Location = new System.Drawing.Point(148, 15);
            this.layoutControl_TextField.MinSize = new System.Drawing.Size(58, 20);
            this.layoutControl_TextField.Name = "layoutControl_TextField";
            this.layoutControl_TextField.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 2, 2);
            this.layoutControl_TextField.Size = new System.Drawing.Size(187, 41);
            this.layoutControl_TextField.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControl_TextField.Text = "layoutControl_TextField";
            this.layoutControl_TextField.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControl_TextField.TextVisible = false;
            // 
            // layoutControl_Button_FilePath
            // 
            this.layoutControl_Button_FilePath.Control = this.button_FilePath;
            this.layoutControl_Button_FilePath.CustomizationFormText = "layoutControl_Button_FilePath";
            this.layoutControl_Button_FilePath.Location = new System.Drawing.Point(335, 0);
            this.layoutControl_Button_FilePath.MinSize = new System.Drawing.Size(27, 26);
            this.layoutControl_Button_FilePath.Name = "layoutControl_Button_FilePath";
            this.layoutControl_Button_FilePath.Size = new System.Drawing.Size(59, 56);
            this.layoutControl_Button_FilePath.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControl_Button_FilePath.Text = "layoutControl_Button_FilePath";
            this.layoutControl_Button_FilePath.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControl_Button_FilePath.TextVisible = false;
            // 
            // layoutControl_Button_Unused
            // 
            this.layoutControl_Button_Unused.Control = this.button_UnUsed;
            this.layoutControl_Button_Unused.CustomizationFormText = "layoutControl_Button_Unused";
            this.layoutControl_Button_Unused.Location = new System.Drawing.Point(148, 0);
            this.layoutControl_Button_Unused.MinSize = new System.Drawing.Size(20, 15);
            this.layoutControl_Button_Unused.Name = "layoutControl_Button_Unused";
            this.layoutControl_Button_Unused.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, -37);
            this.layoutControl_Button_Unused.Size = new System.Drawing.Size(187, 15);
            this.layoutControl_Button_Unused.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControl_Button_Unused.Text = "layoutControl_Button_Unused";
            this.layoutControl_Button_Unused.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControl_Button_Unused.TextVisible = false;
            // 
            // CandidatesParserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 152);
            this.Controls.Add(this.layoutControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CandidatesParserMainForm";
            this.Text = "Adding Contacts v1.0";
            this.ResizeEnd += new System.EventHandler(this.ResizeFormEnd);
            this.SizeChanged += new System.EventHandler(this.ResizeFormInside);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textField_FilePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FacesImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_EmptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Button_OK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_TextField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Button_FilePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Button_Unused)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        internal System.Windows.Forms.PictureBox pictureBox_FacesImage;
        internal DevExpress.XtraEditors.SimpleButton button_FilePath;
        internal DevExpress.XtraEditors.TextEdit textField_FilePath;
        internal DevExpress.XtraEditors.SimpleButton button_OK;
        private DevExpress.XtraEditors.SimpleButton button_UnUsed;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControl_Image;
        private DevExpress.XtraLayout.EmptySpaceItem layoutControl_EmptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControl_Button_OK;
        private DevExpress.XtraLayout.LayoutControlItem layoutControl_Button_FilePath;
        private DevExpress.XtraLayout.LayoutControlItem layoutControl_TextField;
        private DevExpress.XtraLayout.LayoutControlItem layoutControl_Button_Unused;

        internal int origHeight = 0;
        internal int origWidth = 0;
        internal int mainLayoutOrigHeight = 0;
        internal int mainLayoutOrigWidth = 0;
        internal string emptyFilePathString = "Путь к файлу...";
        internal string fileFormatFilter = "txt files (*.txt)|*.txt";
        internal string msgErrorIncorrectStruct = "Ошибка: Неверная структура файла!!!";
        internal string msgErrorEmptyFilePath = "Ошибка: Вы не ввели путь к файлу!!!";
        internal string msgErrorIncorrectFilePath = "Ошибка: Невозможно считать файл с диска!!!\n(Путь задано неверно или файла не существует)";
        public CandidatesParserViewModel manager = new CandidatesParserViewModel();
    }
}