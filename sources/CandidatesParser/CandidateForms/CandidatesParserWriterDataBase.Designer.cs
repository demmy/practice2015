namespace CandidatesParser.CandidateForms
{
        partial class CandidatesParserWriterDataBase
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
            /// 

            internal CandidatesParserViewModel manager = new CandidatesParserViewModel();
            private void InitManager(CandidatesParserViewModel inputManager)
            {
                manager = inputManager;
            }
            private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidatesParserWriterDataBase));
            this.gridControl_CandidatesGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView_CandidatesGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button_Close = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.button_SaveContacts = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControl_Grid = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl_Button_SaveContacts = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl_Button_Close = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_CandidatesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CandidatesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Button_SaveContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Button_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_CandidatesGrid
            // 
            this.gridControl_CandidatesGrid.Location = new System.Drawing.Point(12, 12);
            this.gridControl_CandidatesGrid.MainView = this.gridView_CandidatesGrid;
            this.gridControl_CandidatesGrid.Name = "gridControl_CandidatesGrid";
            this.gridControl_CandidatesGrid.Size = new System.Drawing.Size(734, 221);
            this.gridControl_CandidatesGrid.TabIndex = 0;
            this.gridControl_CandidatesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_CandidatesGrid});
            // 
            // gridView_CandidatesGrid
            // 
            this.gridView_CandidatesGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.gridView_CandidatesGrid.GridControl = this.gridControl_CandidatesGrid;
            this.gridView_CandidatesGrid.Name = "gridView_CandidatesGrid";
            this.gridView_CandidatesGrid.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Фамилия";
            this.gridColumn1.FieldName = "LastName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Имя";
            this.gridColumn2.FieldName = "FirstName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Отчество";
            this.gridColumn3.FieldName = "MiddleName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Дата рождения";
            this.gridColumn4.FieldName = "DOB";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Пол";
            this.gridColumn5.FieldName = "Gender";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Страна";
            this.gridColumn6.FieldName = "Country";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "RelocationAgreement";
            this.gridColumn7.FieldName = "RelocationAgreement";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Email";
            this.gridColumn8.FieldName = "Email";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Skype";
            this.gridColumn9.FieldName = "Skype";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "SiteURL";
            this.gridColumn10.FieldName = "SiteURL";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "EnglishLevel";
            this.gridColumn11.FieldName = "EnglishLevel";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 10;
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(381, 237);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(365, 38);
            this.button_Close.StyleController = this.layoutControl;
            this.button_Close.TabIndex = 4;
            this.button_Close.Text = "Отмена";
            this.button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.button_Close);
            this.layoutControl.Controls.Add(this.gridControl_CandidatesGrid);
            this.layoutControl.Controls.Add(this.button_SaveContacts);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(977, 87, 250, 350);
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
            this.layoutControl.Size = new System.Drawing.Size(758, 287);
            this.layoutControl.TabIndex = 5;
            this.layoutControl.Text = "layoutControl1";
            // 
            // button_SaveContacts
            // 
            this.button_SaveContacts.Location = new System.Drawing.Point(12, 237);
            this.button_SaveContacts.Name = "button_SaveContacts";
            this.button_SaveContacts.Size = new System.Drawing.Size(365, 38);
            this.button_SaveContacts.StyleController = this.layoutControl;
            this.button_SaveContacts.TabIndex = 3;
            this.button_SaveContacts.Text = "Сохранить контакты";
            this.button_SaveContacts.Click += new System.EventHandler(this.Button_SaveContacts_Click);
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControl_Grid,
            this.layoutControl_Button_SaveContacts,
            this.layoutControl_Button_Close});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(758, 287);
            this.Root.Text = "Root";
            this.Root.TextVisible = false;
            // 
            // layoutControl_Grid
            // 
            this.layoutControl_Grid.Control = this.gridControl_CandidatesGrid;
            this.layoutControl_Grid.CustomizationFormText = "layoutControl_Grid";
            this.layoutControl_Grid.Location = new System.Drawing.Point(0, 0);
            this.layoutControl_Grid.Name = "layoutControl_Grid";
            this.layoutControl_Grid.Size = new System.Drawing.Size(738, 225);
            this.layoutControl_Grid.Text = "layoutControl_Grid";
            this.layoutControl_Grid.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControl_Grid.TextVisible = false;
            // 
            // layoutControl_Button_SaveContacts
            // 
            this.layoutControl_Button_SaveContacts.Control = this.button_SaveContacts;
            this.layoutControl_Button_SaveContacts.CustomizationFormText = "layoutControl_Button_SaveContacts";
            this.layoutControl_Button_SaveContacts.Location = new System.Drawing.Point(0, 225);
            this.layoutControl_Button_SaveContacts.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutControl_Button_SaveContacts.MinSize = new System.Drawing.Size(76, 42);
            this.layoutControl_Button_SaveContacts.Name = "layoutControl_Button_SaveContacts";
            this.layoutControl_Button_SaveContacts.Size = new System.Drawing.Size(369, 42);
            this.layoutControl_Button_SaveContacts.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControl_Button_SaveContacts.Text = "layoutControl_Button_SaveContacts";
            this.layoutControl_Button_SaveContacts.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControl_Button_SaveContacts.TextVisible = false;
            // 
            // layoutControl_Button_Close
            // 
            this.layoutControl_Button_Close.Control = this.button_Close;
            this.layoutControl_Button_Close.CustomizationFormText = "layoutControl_Button_Close";
            this.layoutControl_Button_Close.Location = new System.Drawing.Point(369, 225);
            this.layoutControl_Button_Close.MaxSize = new System.Drawing.Size(0, 42);
            this.layoutControl_Button_Close.MinSize = new System.Drawing.Size(123, 42);
            this.layoutControl_Button_Close.Name = "layoutControl_Button_Close";
            this.layoutControl_Button_Close.Size = new System.Drawing.Size(369, 42);
            this.layoutControl_Button_Close.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControl_Button_Close.Text = "layoutControl_Button_Close";
            this.layoutControl_Button_Close.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControl_Button_Close.TextVisible = false;
            // 
            // CandidatesParserWriterDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 287);
            this.Controls.Add(this.layoutControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CandidatesParserWriterDataBase";
            this.Text = "Adding Contacts v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_CandidatesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CandidatesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Button_SaveContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl_Button_Close)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            private DevExpress.XtraGrid.GridControl gridControl_CandidatesGrid;
            private DevExpress.XtraGrid.Views.Grid.GridView gridView_CandidatesGrid;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
            private DevExpress.XtraEditors.SimpleButton button_Close;
            private DevExpress.XtraEditors.SimpleButton button_SaveContacts;
            private DevExpress.XtraLayout.LayoutControl layoutControl;
            private DevExpress.XtraLayout.LayoutControlGroup Root;
            private DevExpress.XtraLayout.LayoutControlItem layoutControl_Grid;
            private DevExpress.XtraLayout.LayoutControlItem layoutControl_Button_SaveContacts;
            private DevExpress.XtraLayout.LayoutControlItem layoutControl_Button_Close;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
            private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        }
    }