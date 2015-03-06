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
            private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidatesParserSelectData));
            this.form2_gridControl_PhoneNumber = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.form2_Button_CopySelectedToBuffer = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.form2_pictureBox_WebSite = new System.Windows.Forms.PictureBox();
            this.form2_pictureBox_Email = new System.Windows.Forms.PictureBox();
            this.form2_pictureBox_Skype = new System.Windows.Forms.PictureBox();
            this.form2_Button_SaveContactsToBD = new DevExpress.XtraEditors.SimpleButton();
            this.form2_ComboBoxEdit_Skypes = new DevExpress.XtraEditors.ComboBoxEdit();
            this.form2_ComboBoxEdit_Emails = new DevExpress.XtraEditors.ComboBoxEdit();
            this.form2_ComboBoxEdit_WebSites = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layout_gridControl_PhoneNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout_ComboBoxEdit_Skype = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout_ComboBoxEdit_Emails = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout_ComboBoxEdit_WebSite = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout_Button_SaveContactsToBD = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout_Button_CopySelectedToBuffer = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layout_ImageSkype = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout_ImageEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.layout_ImageSite = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.form2_gridControl_PhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form2_pictureBox_WebSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2_pictureBox_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2_pictureBox_Skype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2_ComboBoxEdit_Skypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2_ComboBoxEdit_Emails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2_ComboBoxEdit_WebSites.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_gridControl_PhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_ComboBoxEdit_Skype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_ComboBoxEdit_Emails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_ComboBoxEdit_WebSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_Button_SaveContactsToBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_Button_CopySelectedToBuffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_ImageSkype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_ImageEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_ImageSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // form2_gridControl_PhoneNumber
            // 
            this.form2_gridControl_PhoneNumber.Location = new System.Drawing.Point(280, 12);
            this.form2_gridControl_PhoneNumber.MainView = this.gridView1;
            this.form2_gridControl_PhoneNumber.Name = "form2_gridControl_PhoneNumber";
            this.form2_gridControl_PhoneNumber.Size = new System.Drawing.Size(256, 211);
            this.form2_gridControl_PhoneNumber.TabIndex = 0;
            this.form2_gridControl_PhoneNumber.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.form2_gridControl_PhoneNumber;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Телефон";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 166;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Выбранные";
            this.gridColumn4.FieldName = "gridColumn4";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 76;
            // 
            // form2_Button_CopySelectedToBuffer
            // 
            this.form2_Button_CopySelectedToBuffer.Location = new System.Drawing.Point(12, 232);
            this.form2_Button_CopySelectedToBuffer.Name = "form2_Button_CopySelectedToBuffer";
            this.form2_Button_CopySelectedToBuffer.Size = new System.Drawing.Size(260, 39);
            this.form2_Button_CopySelectedToBuffer.StyleController = this.layoutControl1;
            this.form2_Button_CopySelectedToBuffer.TabIndex = 1;
            this.form2_Button_CopySelectedToBuffer.Text = "Копировать выбранное";
            this.form2_Button_CopySelectedToBuffer.Click += new System.EventHandler(this.form2_Button_CopySelectedToBuffer_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.form2_pictureBox_WebSite);
            this.layoutControl1.Controls.Add(this.form2_pictureBox_Email);
            this.layoutControl1.Controls.Add(this.form2_pictureBox_Skype);
            this.layoutControl1.Controls.Add(this.form2_Button_SaveContactsToBD);
            this.layoutControl1.Controls.Add(this.form2_Button_CopySelectedToBuffer);
            this.layoutControl1.Controls.Add(this.form2_gridControl_PhoneNumber);
            this.layoutControl1.Controls.Add(this.form2_ComboBoxEdit_Skypes);
            this.layoutControl1.Controls.Add(this.form2_ComboBoxEdit_Emails);
            this.layoutControl1.Controls.Add(this.form2_ComboBoxEdit_WebSites);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(723, 235, 459, 342);
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
            this.layoutControl1.Size = new System.Drawing.Size(548, 283);
            this.layoutControl1.TabIndex = 11;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // form2_pictureBox_WebSite
            // 
            this.form2_pictureBox_WebSite.BackColor = System.Drawing.Color.Transparent;
            this.form2_pictureBox_WebSite.Image = ((System.Drawing.Image)(resources.GetObject("form2_pictureBox_WebSite.Image")));
            this.form2_pictureBox_WebSite.Location = new System.Drawing.Point(12, 60);
            this.form2_pictureBox_WebSite.Name = "form2_pictureBox_WebSite";
            this.form2_pictureBox_WebSite.Size = new System.Drawing.Size(20, 20);
            this.form2_pictureBox_WebSite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.form2_pictureBox_WebSite.TabIndex = 10;
            this.form2_pictureBox_WebSite.TabStop = false;
            // 
            // form2_pictureBox_Email
            // 
            this.form2_pictureBox_Email.BackColor = System.Drawing.Color.Transparent;
            this.form2_pictureBox_Email.Image = global::CandidatesParser.Properties.Resources.gmailEmails_Icon;
            this.form2_pictureBox_Email.Location = new System.Drawing.Point(12, 36);
            this.form2_pictureBox_Email.Name = "form2_pictureBox_Email";
            this.form2_pictureBox_Email.Size = new System.Drawing.Size(20, 20);
            this.form2_pictureBox_Email.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.form2_pictureBox_Email.TabIndex = 8;
            this.form2_pictureBox_Email.TabStop = false;
            // 
            // form2_pictureBox_Skype
            // 
            this.form2_pictureBox_Skype.BackColor = System.Drawing.Color.Transparent;
            this.form2_pictureBox_Skype.Image = global::CandidatesParser.Properties.Resources.SkypeGreen_Icon;
            this.form2_pictureBox_Skype.Location = new System.Drawing.Point(12, 12);
            this.form2_pictureBox_Skype.Name = "form2_pictureBox_Skype";
            this.form2_pictureBox_Skype.Size = new System.Drawing.Size(20, 20);
            this.form2_pictureBox_Skype.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.form2_pictureBox_Skype.TabIndex = 6;
            this.form2_pictureBox_Skype.TabStop = false;
            // 
            // form2_Button_SaveContactsToBD
            // 
            this.form2_Button_SaveContactsToBD.Location = new System.Drawing.Point(276, 232);
            this.form2_Button_SaveContactsToBD.Name = "form2_Button_SaveContactsToBD";
            this.form2_Button_SaveContactsToBD.Size = new System.Drawing.Size(260, 39);
            this.form2_Button_SaveContactsToBD.StyleController = this.layoutControl1;
            this.form2_Button_SaveContactsToBD.TabIndex = 2;
            this.form2_Button_SaveContactsToBD.Text = "Сохранить контакты";
            this.form2_Button_SaveContactsToBD.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // form2_ComboBoxEdit_Skypes
            // 
            this.form2_ComboBoxEdit_Skypes.EditValue = "";
            this.form2_ComboBoxEdit_Skypes.Location = new System.Drawing.Point(36, 12);
            this.form2_ComboBoxEdit_Skypes.Name = "form2_ComboBoxEdit_Skypes";
            this.form2_ComboBoxEdit_Skypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.form2_ComboBoxEdit_Skypes.Size = new System.Drawing.Size(233, 20);
            this.form2_ComboBoxEdit_Skypes.StyleController = this.layoutControl1;
            this.form2_ComboBoxEdit_Skypes.TabIndex = 4;
            this.form2_ComboBoxEdit_Skypes.SelectedIndexChanged += new System.EventHandler(this.form2_ComboBoxEdit_Skypes_SelectedIndexChanged);
            // 
            // form2_ComboBoxEdit_Emails
            // 
            this.form2_ComboBoxEdit_Emails.EditValue = "";
            this.form2_ComboBoxEdit_Emails.Location = new System.Drawing.Point(36, 36);
            this.form2_ComboBoxEdit_Emails.Name = "form2_ComboBoxEdit_Emails";
            this.form2_ComboBoxEdit_Emails.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.form2_ComboBoxEdit_Emails.Size = new System.Drawing.Size(233, 20);
            this.form2_ComboBoxEdit_Emails.StyleController = this.layoutControl1;
            this.form2_ComboBoxEdit_Emails.TabIndex = 7;
            // 
            // form2_ComboBoxEdit_WebSites
            // 
            this.form2_ComboBoxEdit_WebSites.EditValue = "";
            this.form2_ComboBoxEdit_WebSites.Location = new System.Drawing.Point(36, 60);
            this.form2_ComboBoxEdit_WebSites.Name = "form2_ComboBoxEdit_WebSites";
            this.form2_ComboBoxEdit_WebSites.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.form2_ComboBoxEdit_WebSites.Size = new System.Drawing.Size(233, 20);
            this.form2_ComboBoxEdit_WebSites.StyleController = this.layoutControl1;
            this.form2_ComboBoxEdit_WebSites.TabIndex = 9;
            // 
            // Root
            // 
            this.Root.BackgroundImageVisible = true;
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layout_gridControl_PhoneNumber,
            this.layout_ComboBoxEdit_Skype,
            this.layout_ComboBoxEdit_Emails,
            this.layout_ComboBoxEdit_WebSite,
            this.layout_Button_SaveContactsToBD,
            this.layout_Button_CopySelectedToBuffer,
            this.emptySpaceItem2,
            this.layout_ImageSkype,
            this.layout_ImageEmail,
            this.layout_ImageSite,
            this.splitterItem1,
            this.emptySpaceItem3});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(548, 283);
            this.Root.Text = "Root";
            this.Root.TextVisible = false;
            // 
            // layout_gridControl_PhoneNumber
            // 
            this.layout_gridControl_PhoneNumber.Control = this.form2_gridControl_PhoneNumber;
            this.layout_gridControl_PhoneNumber.CustomizationFormText = "layout_gridControl_PhoneNumber";
            this.layout_gridControl_PhoneNumber.Location = new System.Drawing.Point(268, 0);
            this.layout_gridControl_PhoneNumber.MinSize = new System.Drawing.Size(104, 24);
            this.layout_gridControl_PhoneNumber.Name = "layout_gridControl_PhoneNumber";
            this.layout_gridControl_PhoneNumber.Size = new System.Drawing.Size(260, 215);
            this.layout_gridControl_PhoneNumber.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layout_gridControl_PhoneNumber.Text = "layout_gridControl_PhoneNumber";
            this.layout_gridControl_PhoneNumber.TextSize = new System.Drawing.Size(0, 0);
            this.layout_gridControl_PhoneNumber.TextVisible = false;
            // 
            // layout_ComboBoxEdit_Skype
            // 
            this.layout_ComboBoxEdit_Skype.Control = this.form2_ComboBoxEdit_Skypes;
            this.layout_ComboBoxEdit_Skype.CustomizationFormText = "layout_ComboBoxEdit_Skype";
            this.layout_ComboBoxEdit_Skype.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layout_ComboBoxEdit_Skype.Location = new System.Drawing.Point(24, 0);
            this.layout_ComboBoxEdit_Skype.Name = "layout_ComboBoxEdit_Skype";
            this.layout_ComboBoxEdit_Skype.Size = new System.Drawing.Size(237, 24);
            this.layout_ComboBoxEdit_Skype.Text = "layout_ComboBoxEdit_Skype";
            this.layout_ComboBoxEdit_Skype.TextSize = new System.Drawing.Size(0, 0);
            this.layout_ComboBoxEdit_Skype.TextVisible = false;
            // 
            // layout_ComboBoxEdit_Emails
            // 
            this.layout_ComboBoxEdit_Emails.Control = this.form2_ComboBoxEdit_Emails;
            this.layout_ComboBoxEdit_Emails.CustomizationFormText = "layout_ComboBoxEdit_Emails";
            this.layout_ComboBoxEdit_Emails.Location = new System.Drawing.Point(24, 24);
            this.layout_ComboBoxEdit_Emails.Name = "layout_ComboBoxEdit_Emails";
            this.layout_ComboBoxEdit_Emails.Size = new System.Drawing.Size(237, 24);
            this.layout_ComboBoxEdit_Emails.Text = "layout_ComboBoxEdit_Emails";
            this.layout_ComboBoxEdit_Emails.TextSize = new System.Drawing.Size(0, 0);
            this.layout_ComboBoxEdit_Emails.TextVisible = false;
            // 
            // layout_ComboBoxEdit_WebSite
            // 
            this.layout_ComboBoxEdit_WebSite.Control = this.form2_ComboBoxEdit_WebSites;
            this.layout_ComboBoxEdit_WebSite.CustomizationFormText = "layout_ComboBoxEdit_WebSite";
            this.layout_ComboBoxEdit_WebSite.Location = new System.Drawing.Point(24, 48);
            this.layout_ComboBoxEdit_WebSite.Name = "layout_ComboBoxEdit_WebSite";
            this.layout_ComboBoxEdit_WebSite.Size = new System.Drawing.Size(237, 24);
            this.layout_ComboBoxEdit_WebSite.Text = "layout_ComboBoxEdit_WebSite";
            this.layout_ComboBoxEdit_WebSite.TextSize = new System.Drawing.Size(0, 0);
            this.layout_ComboBoxEdit_WebSite.TextVisible = false;
            // 
            // layout_Button_SaveContactsToBD
            // 
            this.layout_Button_SaveContactsToBD.Control = this.form2_Button_SaveContactsToBD;
            this.layout_Button_SaveContactsToBD.CustomizationFormText = "layout_Button_SaveContactsToBD";
            this.layout_Button_SaveContactsToBD.Location = new System.Drawing.Point(264, 220);
            this.layout_Button_SaveContactsToBD.MaxSize = new System.Drawing.Size(0, 43);
            this.layout_Button_SaveContactsToBD.MinSize = new System.Drawing.Size(123, 43);
            this.layout_Button_SaveContactsToBD.Name = "layout_Button_SaveContactsToBD";
            this.layout_Button_SaveContactsToBD.Size = new System.Drawing.Size(264, 43);
            this.layout_Button_SaveContactsToBD.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layout_Button_SaveContactsToBD.Text = "layout_Button_SaveContactsToBD";
            this.layout_Button_SaveContactsToBD.TextSize = new System.Drawing.Size(0, 0);
            this.layout_Button_SaveContactsToBD.TextVisible = false;
            // 
            // layout_Button_CopySelectedToBuffer
            // 
            this.layout_Button_CopySelectedToBuffer.Control = this.form2_Button_CopySelectedToBuffer;
            this.layout_Button_CopySelectedToBuffer.CustomizationFormText = "layout_Button_CopySelectedToBuffer";
            this.layout_Button_CopySelectedToBuffer.Location = new System.Drawing.Point(0, 220);
            this.layout_Button_CopySelectedToBuffer.MaxSize = new System.Drawing.Size(0, 43);
            this.layout_Button_CopySelectedToBuffer.MinSize = new System.Drawing.Size(135, 43);
            this.layout_Button_CopySelectedToBuffer.Name = "layout_Button_CopySelectedToBuffer";
            this.layout_Button_CopySelectedToBuffer.Size = new System.Drawing.Size(264, 43);
            this.layout_Button_CopySelectedToBuffer.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layout_Button_CopySelectedToBuffer.Text = "layout_Button_CopySelectedToBuffer";
            this.layout_Button_CopySelectedToBuffer.TextSize = new System.Drawing.Size(0, 0);
            this.layout_Button_CopySelectedToBuffer.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(261, 143);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layout_ImageSkype
            // 
            this.layout_ImageSkype.Control = this.form2_pictureBox_Skype;
            this.layout_ImageSkype.CustomizationFormText = "layout_ImageSkype";
            this.layout_ImageSkype.Location = new System.Drawing.Point(0, 0);
            this.layout_ImageSkype.MinSize = new System.Drawing.Size(24, 24);
            this.layout_ImageSkype.Name = "layout_ImageSkype";
            this.layout_ImageSkype.Size = new System.Drawing.Size(24, 24);
            this.layout_ImageSkype.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layout_ImageSkype.Text = "layout_ImageSkype";
            this.layout_ImageSkype.TextSize = new System.Drawing.Size(0, 0);
            this.layout_ImageSkype.TextVisible = false;
            // 
            // layout_ImageEmail
            // 
            this.layout_ImageEmail.Control = this.form2_pictureBox_Email;
            this.layout_ImageEmail.CustomizationFormText = "layout_ImageEmail";
            this.layout_ImageEmail.Location = new System.Drawing.Point(0, 24);
            this.layout_ImageEmail.MinSize = new System.Drawing.Size(24, 24);
            this.layout_ImageEmail.Name = "layout_ImageEmail";
            this.layout_ImageEmail.Size = new System.Drawing.Size(24, 24);
            this.layout_ImageEmail.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layout_ImageEmail.Text = "layout_ImageEmail";
            this.layout_ImageEmail.TextSize = new System.Drawing.Size(0, 0);
            this.layout_ImageEmail.TextVisible = false;
            // 
            // layout_ImageSite
            // 
            this.layout_ImageSite.Control = this.form2_pictureBox_WebSite;
            this.layout_ImageSite.CustomizationFormText = "layout_ImageSite";
            this.layout_ImageSite.Location = new System.Drawing.Point(0, 48);
            this.layout_ImageSite.MinSize = new System.Drawing.Size(24, 24);
            this.layout_ImageSite.Name = "layout_ImageSite";
            this.layout_ImageSite.Size = new System.Drawing.Size(24, 24);
            this.layout_ImageSite.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layout_ImageSite.Text = "layout_ImageSite";
            this.layout_ImageSite.TextSize = new System.Drawing.Size(0, 0);
            this.layout_ImageSite.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(261, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(7, 215);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 215);
            this.emptySpaceItem3.MinSize = new System.Drawing.Size(104, 5);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(528, 5);
            this.emptySpaceItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // XtraForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 283);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Name = "XtraForm2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Adding Contacts v1.0";
            this.Resize += new System.EventHandler(this.resizeFormInside);
            ((System.ComponentModel.ISupportInitialize)(this.form2_gridControl_PhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.form2_pictureBox_WebSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2_pictureBox_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2_pictureBox_Skype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2_ComboBoxEdit_Skypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2_ComboBoxEdit_Emails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2_ComboBoxEdit_WebSites.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_gridControl_PhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_ComboBoxEdit_Skype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_ComboBoxEdit_Emails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_ComboBoxEdit_WebSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_Button_SaveContactsToBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_Button_CopySelectedToBuffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_ImageSkype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_ImageEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layout_ImageSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            private DevExpress.XtraGrid.GridControl form2_gridControl_PhoneNumber;
            private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
            private DevExpress.XtraEditors.SimpleButton form2_Button_CopySelectedToBuffer;
            private DevExpress.XtraEditors.SimpleButton form2_Button_SaveContactsToBD;
            private DevExpress.XtraLayout.LayoutControl layoutControl1;
            private DevExpress.XtraLayout.LayoutControlGroup Root;
            private DevExpress.XtraLayout.LayoutControlItem layout_gridControl_PhoneNumber;
            private DevExpress.XtraLayout.LayoutControlItem layout_ComboBoxEdit_Skype;
            private DevExpress.XtraLayout.LayoutControlItem layout_ComboBoxEdit_Emails;
            private DevExpress.XtraLayout.LayoutControlItem layout_ComboBoxEdit_WebSite;
            private DevExpress.XtraLayout.LayoutControlItem layout_Button_SaveContactsToBD;
            private DevExpress.XtraLayout.LayoutControlItem layout_Button_CopySelectedToBuffer;

            internal int form2OrigHight = 0;
            internal int form2OrigWidth = 0;
            internal int form2MainLayoutOrigHeight = 0;
            internal int form2MainLayoutOrigWidth = 0;
            private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
            private DevExpress.XtraEditors.ComboBoxEdit form2_ComboBoxEdit_Skypes;
            internal System.Windows.Forms.PictureBox form2_pictureBox_WebSite;
            internal System.Windows.Forms.PictureBox form2_pictureBox_Email;
            internal System.Windows.Forms.PictureBox form2_pictureBox_Skype;
            private DevExpress.XtraLayout.LayoutControlItem layout_ImageSkype;
            private DevExpress.XtraLayout.LayoutControlItem layout_ImageEmail;
            private DevExpress.XtraLayout.LayoutControlItem layout_ImageSite;
            private DevExpress.XtraLayout.SplitterItem splitterItem1;
            private DevExpress.XtraEditors.ComboBoxEdit form2_ComboBoxEdit_Emails;
            private DevExpress.XtraEditors.ComboBoxEdit form2_ComboBoxEdit_WebSites;
            private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        }
    }
