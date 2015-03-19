namespace CandidatesParser.CandidateForms
{
        partial class CandidatesParserSelectData
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
            
            //////////////////////////////////////////////////////////////////////////////// 
            internal CandidatesParserViewModel manager = new CandidatesParserViewModel();
            private void InitManager(CandidatesParserViewModel inputManager)
            {
                manager = inputManager;
            }
            ////////////////////////////////////////////////////////////////////////////////
            
            private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidatesParserSelectData));
            this.gridControl_PhoneNumber = new DevExpress.XtraGrid.GridControl();
            this.gridView_PhoneNumber = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn_Phones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_PhonesSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button_CopySelectedToBuffer = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.pictureBox_WebSite = new System.Windows.Forms.PictureBox();
            this.pictureBox_Email = new System.Windows.Forms.PictureBox();
            this.pictureBox_Skype = new System.Windows.Forms.PictureBox();
            this.button_SaveContactsToBD = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit_Skypes = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit_Emails = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit_WebSites = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControl_gridControl_PhoneNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl_ComboBoxEdit_Skype = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl_ComboBoxEdit_Emails = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl_ComboBoxEdit_WebSite = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl_Button_SaveContactsToBD = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl_Button_CopySelectedToBuffer = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl_EmptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControl_ImageSkype = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl_ImageEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl_ImageSite = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl_SplitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControl_EmptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WebSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Skype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_Skypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_Emails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_WebSites.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_gridControl_PhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_ComboBoxEdit_Skype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_ComboBoxEdit_Emails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_ComboBoxEdit_WebSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Button_SaveContactsToBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Button_CopySelectedToBuffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_EmptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_ImageSkype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_ImageEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_ImageSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_SplitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_EmptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_PhoneNumber
            // 
            this.gridControl_PhoneNumber.Location = new System.Drawing.Point(280, 12);
            this.gridControl_PhoneNumber.MainView = this.gridView_PhoneNumber;
            this.gridControl_PhoneNumber.Name = "gridControl_PhoneNumber";
            this.gridControl_PhoneNumber.Size = new System.Drawing.Size(256, 211);
            this.gridControl_PhoneNumber.TabIndex = 0;
            this.gridControl_PhoneNumber.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_PhoneNumber});
            // 
            // gridView_PhoneNumber
            // 
            this.gridView_PhoneNumber.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn_Phones,
            this.gridColumn_PhonesSelected});
            this.gridView_PhoneNumber.GridControl = this.gridControl_PhoneNumber;
            this.gridView_PhoneNumber.Name = "gridView_PhoneNumber";
            this.gridView_PhoneNumber.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn_Phones
            // 
            this.gridColumn_Phones.Caption = "Телефон";
            this.gridColumn_Phones.FieldName = "Value";
            this.gridColumn_Phones.Name = "gridColumn_Phones";
            this.gridColumn_Phones.Visible = true;
            this.gridColumn_Phones.VisibleIndex = 0;
            this.gridColumn_Phones.Width = 166;
            // 
            // gridColumn_PhonesSelected
            // 
            this.gridColumn_PhonesSelected.Caption = "Выбранные";
            this.gridColumn_PhonesSelected.FieldName = "IsChosen";
            this.gridColumn_PhonesSelected.Name = "gridColumn_PhonesSelected";
            this.gridColumn_PhonesSelected.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn_PhonesSelected.Visible = true;
            this.gridColumn_PhonesSelected.VisibleIndex = 1;
            this.gridColumn_PhonesSelected.Width = 76;
            // 
            // button_CopySelectedToBuffer
            // 
            this.button_CopySelectedToBuffer.Location = new System.Drawing.Point(12, 232);
            this.button_CopySelectedToBuffer.Name = "button_CopySelectedToBuffer";
            this.button_CopySelectedToBuffer.Size = new System.Drawing.Size(260, 39);
            this.button_CopySelectedToBuffer.StyleController = this.layoutControl;
            this.button_CopySelectedToBuffer.TabIndex = 1;
            this.button_CopySelectedToBuffer.Text = "Копировать выбранное";
            this.button_CopySelectedToBuffer.Click += new System.EventHandler(this.Button_CopySelectedToBuffer_Click);
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.pictureBox_WebSite);
            this.layoutControl.Controls.Add(this.pictureBox_Email);
            this.layoutControl.Controls.Add(this.pictureBox_Skype);
            this.layoutControl.Controls.Add(this.button_SaveContactsToBD);
            this.layoutControl.Controls.Add(this.button_CopySelectedToBuffer);
            this.layoutControl.Controls.Add(this.gridControl_PhoneNumber);
            this.layoutControl.Controls.Add(this.comboBoxEdit_Skypes);
            this.layoutControl.Controls.Add(this.comboBoxEdit_Emails);
            this.layoutControl.Controls.Add(this.comboBoxEdit_WebSites);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(723, 235, 459, 342);
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
            this.layoutControl.Size = new System.Drawing.Size(548, 283);
            this.layoutControl.TabIndex = 11;
            this.layoutControl.Text = "layoutControl1";
            // 
            // pictureBox_WebSite
            // 
            this.pictureBox_WebSite.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_WebSite.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_WebSite.Image")));
            this.pictureBox_WebSite.Location = new System.Drawing.Point(12, 60);
            this.pictureBox_WebSite.Name = "pictureBox_WebSite";
            this.pictureBox_WebSite.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_WebSite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_WebSite.TabIndex = 10;
            this.pictureBox_WebSite.TabStop = false;
            // 
            // pictureBox_Email
            // 
            this.pictureBox_Email.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Email.Image = global::CandidatesParser.Properties.Resources.gmailEmails_Icon;
            this.pictureBox_Email.Location = new System.Drawing.Point(12, 36);
            this.pictureBox_Email.Name = "pictureBox_Email";
            this.pictureBox_Email.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Email.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Email.TabIndex = 8;
            this.pictureBox_Email.TabStop = false;
            // 
            // pictureBox_Skype
            // 
            this.pictureBox_Skype.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Skype.Image = global::CandidatesParser.Properties.Resources.SkypeGreen_Icon;
            this.pictureBox_Skype.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Skype.Name = "pictureBox_Skype";
            this.pictureBox_Skype.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_Skype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Skype.TabIndex = 6;
            this.pictureBox_Skype.TabStop = false;
            // 
            // button_SaveContactsToBD
            // 
            this.button_SaveContactsToBD.Location = new System.Drawing.Point(276, 232);
            this.button_SaveContactsToBD.Name = "button_SaveContactsToBD";
            this.button_SaveContactsToBD.Size = new System.Drawing.Size(260, 39);
            this.button_SaveContactsToBD.StyleController = this.layoutControl;
            this.button_SaveContactsToBD.TabIndex = 2;
            this.button_SaveContactsToBD.Text = "Сохранить контакты";
            this.button_SaveContactsToBD.Click += new System.EventHandler(this.Button_SaveContactsToBD_Click);
            // 
            // comboBoxEdit_Skypes
            // 
            this.comboBoxEdit_Skypes.EditValue = "";
            this.comboBoxEdit_Skypes.Location = new System.Drawing.Point(36, 12);
            this.comboBoxEdit_Skypes.Name = "comboBoxEdit_Skypes";
            this.comboBoxEdit_Skypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_Skypes.Size = new System.Drawing.Size(233, 20);
            this.comboBoxEdit_Skypes.StyleController = this.layoutControl;
            this.comboBoxEdit_Skypes.TabIndex = 4;
            this.comboBoxEdit_Skypes.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEdit_Skypes_SelectedIndexChanged);
            // 
            // comboBoxEdit_Emails
            // 
            this.comboBoxEdit_Emails.EditValue = "";
            this.comboBoxEdit_Emails.Location = new System.Drawing.Point(36, 36);
            this.comboBoxEdit_Emails.Name = "comboBoxEdit_Emails";
            this.comboBoxEdit_Emails.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_Emails.Size = new System.Drawing.Size(233, 20);
            this.comboBoxEdit_Emails.StyleController = this.layoutControl;
            this.comboBoxEdit_Emails.TabIndex = 7;
            this.comboBoxEdit_Emails.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEdit_Emails_SelectedIndexChanged);
            // 
            // comboBoxEdit_WebSites
            // 
            this.comboBoxEdit_WebSites.EditValue = "";
            this.comboBoxEdit_WebSites.Location = new System.Drawing.Point(36, 60);
            this.comboBoxEdit_WebSites.Name = "comboBoxEdit_WebSites";
            this.comboBoxEdit_WebSites.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit_WebSites.Size = new System.Drawing.Size(233, 20);
            this.comboBoxEdit_WebSites.StyleController = this.layoutControl;
            this.comboBoxEdit_WebSites.TabIndex = 9;
            this.comboBoxEdit_WebSites.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEdit_WebSites_SelectedIndexChanged);
            // 
            // Root
            // 
            this.Root.BackgroundImageVisible = true;
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControl_gridControl_PhoneNumber,
            this.layoutControl_ComboBoxEdit_Skype,
            this.layoutControl_ComboBoxEdit_Emails,
            this.layoutControl_ComboBoxEdit_WebSite,
            this.layoutControl_Button_SaveContactsToBD,
            this.layoutControl_Button_CopySelectedToBuffer,
            this.layoutControl_EmptySpaceItem2,
            this.layoutControl_ImageSkype,
            this.layoutControl_ImageEmail,
            this.layoutControl_ImageSite,
            this.layoutControl_SplitterItem1,
            this.layoutControl_EmptySpaceItem3});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(548, 283);
            this.Root.Text = "Root";
            this.Root.TextVisible = false;
            // 
            // layoutControl_gridControl_PhoneNumber
            // 
            this.layoutControl_gridControl_PhoneNumber.Control = this.gridControl_PhoneNumber;
            this.layoutControl_gridControl_PhoneNumber.CustomizationFormText = "layoutControl_gridControl_PhoneNumber";
            this.layoutControl_gridControl_PhoneNumber.Location = new System.Drawing.Point(268, 0);
            this.layoutControl_gridControl_PhoneNumber.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControl_gridControl_PhoneNumber.Name = "layoutControl_gridControl_PhoneNumber";
            this.layoutControl_gridControl_PhoneNumber.Size = new System.Drawing.Size(260, 215);
            this.layoutControl_gridControl_PhoneNumber.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControl_gridControl_PhoneNumber.Text = "layoutControl_gridControl_PhoneNumber";
            this.layoutControl_gridControl_PhoneNumber.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControl_gridControl_PhoneNumber.TextVisible = false;
            // 
            // layoutControl_ComboBoxEdit_Skype
            // 
            this.layoutControl_ComboBoxEdit_Skype.Control = this.comboBoxEdit_Skypes;
            this.layoutControl_ComboBoxEdit_Skype.CustomizationFormText = "layoutControl_ComboBoxEdit_Skype";
            this.layoutControl_ComboBoxEdit_Skype.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControl_ComboBoxEdit_Skype.Location = new System.Drawing.Point(24, 0);
            this.layoutControl_ComboBoxEdit_Skype.Name = "layoutControl_ComboBoxEdit_Skype";
            this.layoutControl_ComboBoxEdit_Skype.Size = new System.Drawing.Size(237, 24);
            this.layoutControl_ComboBoxEdit_Skype.Text = "layoutControl_ComboBoxEdit_Skype";
            this.layoutControl_ComboBoxEdit_Skype.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControl_ComboBoxEdit_Skype.TextVisible = false;
            // 
            // layoutControl_ComboBoxEdit_Emails
            // 
            this.layoutControl_ComboBoxEdit_Emails.Control = this.comboBoxEdit_Emails;
            this.layoutControl_ComboBoxEdit_Emails.CustomizationFormText = "layoutControl_ComboBoxEdit_Emails";
            this.layoutControl_ComboBoxEdit_Emails.Location = new System.Drawing.Point(24, 24);
            this.layoutControl_ComboBoxEdit_Emails.Name = "layoutControl_ComboBoxEdit_Emails";
            this.layoutControl_ComboBoxEdit_Emails.Size = new System.Drawing.Size(237, 24);
            this.layoutControl_ComboBoxEdit_Emails.Text = "layoutControl_ComboBoxEdit_Emails";
            this.layoutControl_ComboBoxEdit_Emails.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControl_ComboBoxEdit_Emails.TextVisible = false;
            // 
            // layoutControl_ComboBoxEdit_WebSite
            // 
            this.layoutControl_ComboBoxEdit_WebSite.Control = this.comboBoxEdit_WebSites;
            this.layoutControl_ComboBoxEdit_WebSite.CustomizationFormText = "layoutControl_ComboBoxEdit_WebSite";
            this.layoutControl_ComboBoxEdit_WebSite.Location = new System.Drawing.Point(24, 48);
            this.layoutControl_ComboBoxEdit_WebSite.Name = "layoutControl_ComboBoxEdit_WebSite";
            this.layoutControl_ComboBoxEdit_WebSite.Size = new System.Drawing.Size(237, 24);
            this.layoutControl_ComboBoxEdit_WebSite.Text = "layoutControl_ComboBoxEdit_WebSite";
            this.layoutControl_ComboBoxEdit_WebSite.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControl_ComboBoxEdit_WebSite.TextVisible = false;
            // 
            // layoutControl_Button_SaveContactsToBD
            // 
            this.layoutControl_Button_SaveContactsToBD.Control = this.button_SaveContactsToBD;
            this.layoutControl_Button_SaveContactsToBD.CustomizationFormText = "layoutControl_Button_SaveContactsToBD";
            this.layoutControl_Button_SaveContactsToBD.Location = new System.Drawing.Point(264, 220);
            this.layoutControl_Button_SaveContactsToBD.MaxSize = new System.Drawing.Size(0, 43);
            this.layoutControl_Button_SaveContactsToBD.MinSize = new System.Drawing.Size(123, 43);
            this.layoutControl_Button_SaveContactsToBD.Name = "layoutControl_Button_SaveContactsToBD";
            this.layoutControl_Button_SaveContactsToBD.Size = new System.Drawing.Size(264, 43);
            this.layoutControl_Button_SaveContactsToBD.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControl_Button_SaveContactsToBD.Text = "layoutControl_Button_SaveContactsToBD";
            this.layoutControl_Button_SaveContactsToBD.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControl_Button_SaveContactsToBD.TextVisible = false;
            // 
            // layoutControl_Button_CopySelectedToBuffer
            // 
            this.layoutControl_Button_CopySelectedToBuffer.Control = this.button_CopySelectedToBuffer;
            this.layoutControl_Button_CopySelectedToBuffer.CustomizationFormText = "layoutControl_Button_CopySelectedToBuffer";
            this.layoutControl_Button_CopySelectedToBuffer.Location = new System.Drawing.Point(0, 220);
            this.layoutControl_Button_CopySelectedToBuffer.MaxSize = new System.Drawing.Size(0, 43);
            this.layoutControl_Button_CopySelectedToBuffer.MinSize = new System.Drawing.Size(135, 43);
            this.layoutControl_Button_CopySelectedToBuffer.Name = "layoutControl_Button_CopySelectedToBuffer";
            this.layoutControl_Button_CopySelectedToBuffer.Size = new System.Drawing.Size(264, 43);
            this.layoutControl_Button_CopySelectedToBuffer.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControl_Button_CopySelectedToBuffer.Text = "layoutControl_Button_CopySelectedToBuffer";
            this.layoutControl_Button_CopySelectedToBuffer.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControl_Button_CopySelectedToBuffer.TextVisible = false;
            // 
            // layoutControl_EmptySpaceItem2
            // 
            this.layoutControl_EmptySpaceItem2.AllowHotTrack = false;
            this.layoutControl_EmptySpaceItem2.CustomizationFormText = "layoutControl_EmptySpaceItem2";
            this.layoutControl_EmptySpaceItem2.Location = new System.Drawing.Point(0, 72);
            this.layoutControl_EmptySpaceItem2.Name = "layoutControl_EmptySpaceItem2";
            this.layoutControl_EmptySpaceItem2.Size = new System.Drawing.Size(261, 143);
            this.layoutControl_EmptySpaceItem2.Text = "layoutControl_EmptySpaceItem2";
            this.layoutControl_EmptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControl_ImageSkype
            // 
            this.layoutControl_ImageSkype.Control = this.pictureBox_Skype;
            this.layoutControl_ImageSkype.CustomizationFormText = "layoutControl_ImageSkype";
            this.layoutControl_ImageSkype.Location = new System.Drawing.Point(0, 0);
            this.layoutControl_ImageSkype.MinSize = new System.Drawing.Size(24, 24);
            this.layoutControl_ImageSkype.Name = "layoutControl_ImageSkype";
            this.layoutControl_ImageSkype.Size = new System.Drawing.Size(24, 24);
            this.layoutControl_ImageSkype.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControl_ImageSkype.Text = "layoutControl_ImageSkype";
            this.layoutControl_ImageSkype.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControl_ImageSkype.TextVisible = false;
            // 
            // layoutControl_ImageEmail
            // 
            this.layoutControl_ImageEmail.Control = this.pictureBox_Email;
            this.layoutControl_ImageEmail.CustomizationFormText = "layoutControl_ImageEmail";
            this.layoutControl_ImageEmail.Location = new System.Drawing.Point(0, 24);
            this.layoutControl_ImageEmail.MinSize = new System.Drawing.Size(24, 24);
            this.layoutControl_ImageEmail.Name = "layoutControl_ImageEmail";
            this.layoutControl_ImageEmail.Size = new System.Drawing.Size(24, 24);
            this.layoutControl_ImageEmail.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControl_ImageEmail.Text = "layoutControl_ImageEmail";
            this.layoutControl_ImageEmail.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControl_ImageEmail.TextVisible = false;
            // 
            // layoutControl_ImageSite
            // 
            this.layoutControl_ImageSite.Control = this.pictureBox_WebSite;
            this.layoutControl_ImageSite.CustomizationFormText = "layoutControl_ImageSite";
            this.layoutControl_ImageSite.Location = new System.Drawing.Point(0, 48);
            this.layoutControl_ImageSite.MinSize = new System.Drawing.Size(24, 24);
            this.layoutControl_ImageSite.Name = "layoutControl_ImageSite";
            this.layoutControl_ImageSite.Size = new System.Drawing.Size(24, 24);
            this.layoutControl_ImageSite.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControl_ImageSite.Text = "layoutControl_ImageSite";
            this.layoutControl_ImageSite.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControl_ImageSite.TextVisible = false;
            // 
            // layoutControl_SplitterItem1
            // 
            this.layoutControl_SplitterItem1.AllowHotTrack = true;
            this.layoutControl_SplitterItem1.CustomizationFormText = "layoutControl_SplitterItem1";
            this.layoutControl_SplitterItem1.Location = new System.Drawing.Point(261, 0);
            this.layoutControl_SplitterItem1.Name = "layoutControl_SplitterItem1";
            this.layoutControl_SplitterItem1.Size = new System.Drawing.Size(7, 215);
            // 
            // layoutControl_EmptySpaceItem3
            // 
            this.layoutControl_EmptySpaceItem3.AllowHotTrack = false;
            this.layoutControl_EmptySpaceItem3.CustomizationFormText = "layoutControl_EmptySpaceItem3";
            this.layoutControl_EmptySpaceItem3.Location = new System.Drawing.Point(0, 215);
            this.layoutControl_EmptySpaceItem3.MinSize = new System.Drawing.Size(104, 5);
            this.layoutControl_EmptySpaceItem3.Name = "layoutControl_EmptySpaceItem3";
            this.layoutControl_EmptySpaceItem3.Size = new System.Drawing.Size(528, 5);
            this.layoutControl_EmptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControl_EmptySpaceItem3.Text = "layoutControl_EmptySpaceItem3";
            this.layoutControl_EmptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // CandidatesParserSelectData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 283);
            this.Controls.Add(this.layoutControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Name = "CandidatesParserSelectData";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Adding Contacts v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_PhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_PhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_WebSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Skype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_Skypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_Emails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit_WebSites.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_gridControl_PhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_ComboBoxEdit_Skype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_ComboBoxEdit_Emails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_ComboBoxEdit_WebSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Button_SaveContactsToBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Button_CopySelectedToBuffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_EmptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_ImageSkype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_ImageEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_ImageSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_SplitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_EmptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            private DevExpress.XtraGrid.GridControl gridControl_PhoneNumber;
            private DevExpress.XtraGrid.Views.Grid.GridView gridView_PhoneNumber;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn_Phones;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn_PhonesSelected;
            private DevExpress.XtraEditors.SimpleButton button_CopySelectedToBuffer;
            private DevExpress.XtraEditors.SimpleButton button_SaveContactsToBD;
            private DevExpress.XtraLayout.LayoutControl layoutControl;
            private DevExpress.XtraLayout.LayoutControlGroup Root;
            private DevExpress.XtraLayout.LayoutControlItem layoutControl_gridControl_PhoneNumber;
            private DevExpress.XtraLayout.LayoutControlItem layoutControl_ComboBoxEdit_Skype;
            private DevExpress.XtraLayout.LayoutControlItem layoutControl_ComboBoxEdit_Emails;
            private DevExpress.XtraLayout.LayoutControlItem layoutControl_ComboBoxEdit_WebSite;
            private DevExpress.XtraLayout.LayoutControlItem layoutControl_Button_SaveContactsToBD;
            private DevExpress.XtraLayout.LayoutControlItem layoutControl_Button_CopySelectedToBuffer;
            private DevExpress.XtraLayout.EmptySpaceItem layoutControl_EmptySpaceItem2;
            private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_Skypes;
            internal System.Windows.Forms.PictureBox pictureBox_WebSite;
            internal System.Windows.Forms.PictureBox pictureBox_Email;
            internal System.Windows.Forms.PictureBox pictureBox_Skype;
            private DevExpress.XtraLayout.LayoutControlItem layoutControl_ImageSkype;
            private DevExpress.XtraLayout.LayoutControlItem layoutControl_ImageEmail;
            private DevExpress.XtraLayout.LayoutControlItem layoutControl_ImageSite;
            private DevExpress.XtraLayout.SplitterItem layoutControl_SplitterItem1;
            private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_Emails;
            private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit_WebSites;
            private DevExpress.XtraLayout.EmptySpaceItem layoutControl_EmptySpaceItem3;
        }
    }
