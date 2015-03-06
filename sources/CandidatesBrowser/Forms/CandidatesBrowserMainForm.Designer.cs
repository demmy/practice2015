namespace CandidatesBrowser.Forms
{
    partial class CandidatesBrowserMainForm
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
            this.mainLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.mainGridControl = new DevExpress.XtraGrid.GridControl();
            this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coLastContactDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coLastContactComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.editButton = new DevExpress.XtraEditors.SimpleButton();
            this.addButton = new DevExpress.XtraEditors.SimpleButton();
            this.mainLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.addLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.editLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonsEmptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.gridLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).BeginInit();
            this.mainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsEmptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayoutControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutControl
            // 
            this.mainLayoutControl.Controls.Add(this.mainGridControl);
            this.mainLayoutControl.Controls.Add(this.editButton);
            this.mainLayoutControl.Controls.Add(this.addButton);
            this.mainLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutControl.Name = "mainLayoutControl";
            this.mainLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(582, 363, 250, 350);
            this.mainLayoutControl.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.mainLayoutControl.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.mainLayoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.mainLayoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.mainLayoutControl.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.mainLayoutControl.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.mainLayoutControl.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.mainLayoutControl.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.mainLayoutControl.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.mainLayoutControl.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.mainLayoutControl.Root = this.mainLayoutControlGroup;
            this.mainLayoutControl.Size = new System.Drawing.Size(784, 561);
            this.mainLayoutControl.TabIndex = 0;
            this.mainLayoutControl.Text = "mainLayoutControl";
            // 
            // mainGridControl
            // 
            this.mainGridControl.DataSource = this.mainBindingSource;
            this.mainGridControl.Location = new System.Drawing.Point(12, 38);
            this.mainGridControl.MainView = this.mainGridView;
            this.mainGridControl.Name = "mainGridControl";
            this.mainGridControl.Size = new System.Drawing.Size(760, 511);
            this.mainGridControl.TabIndex = 6;
            this.mainGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mainGridView});
            // 
            // mainBindingSource
            // 
            this.mainBindingSource.DataSource = typeof(HumanResourcesLibrary.DataClasses.Candidate);
            // 
            // mainGridView
            // 
            this.mainGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFirstName,
            this.colMiddleName,
            this.colLastName,
            this.coLastContactDate,
            this.coLastContactComment});
            this.mainGridView.GridControl = this.mainGridControl;
            this.mainGridView.Name = "mainGridView";
            this.mainGridView.OptionsBehavior.Editable = false;
            this.mainGridView.OptionsDetail.EnableMasterViewMode = false;
            this.mainGridView.OptionsView.ShowGroupPanel = false;
            this.mainGridView.DoubleClick += new System.EventHandler(this.mainGridView_DoubleClick);
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 0;
            // 
            // colMiddleName
            // 
            this.colMiddleName.FieldName = "MiddleName";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.Visible = true;
            this.colMiddleName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            // 
            // coLastContactDate
            // 
            this.coLastContactDate.Caption = "Last contact date";
            this.coLastContactDate.FieldName = "LastContact.Date";
            this.coLastContactDate.Name = "coLastContactDate";
            this.coLastContactDate.Visible = true;
            this.coLastContactDate.VisibleIndex = 3;
            // 
            // coLastContactComment
            // 
            this.coLastContactComment.Caption = "Comment";
            this.coLastContactComment.FieldName = "LastContact.Comment";
            this.coLastContactComment.Name = "coLastContactComment";
            this.coLastContactComment.Visible = true;
            this.coLastContactComment.VisibleIndex = 4;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(100, 12);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(82, 22);
            this.editButton.StyleController = this.mainLayoutControl;
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 22);
            this.addButton.StyleController = this.mainLayoutControl;
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // mainLayoutControlGroup
            // 
            this.mainLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.mainLayoutControlGroup.GroupBordersVisible = false;
            this.mainLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.addLayoutControlItem,
            this.editLayoutControlItem,
            this.buttonsEmptySpaceItem,
            this.gridLayoutControlItem});
            this.mainLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutControlGroup.Name = "Root";
            this.mainLayoutControlGroup.Size = new System.Drawing.Size(784, 561);
            this.mainLayoutControlGroup.TextVisible = false;
            // 
            // addLayoutControlItem
            // 
            this.addLayoutControlItem.Control = this.addButton;
            this.addLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.addLayoutControlItem.Name = "addLayoutControlItem";
            this.addLayoutControlItem.Size = new System.Drawing.Size(88, 26);
            this.addLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.addLayoutControlItem.TextVisible = false;
            // 
            // editLayoutControlItem
            // 
            this.editLayoutControlItem.Control = this.editButton;
            this.editLayoutControlItem.Location = new System.Drawing.Point(88, 0);
            this.editLayoutControlItem.Name = "editLayoutControlItem";
            this.editLayoutControlItem.Size = new System.Drawing.Size(86, 26);
            this.editLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.editLayoutControlItem.TextVisible = false;
            // 
            // buttonsEmptySpaceItem
            // 
            this.buttonsEmptySpaceItem.AllowHotTrack = false;
            this.buttonsEmptySpaceItem.Location = new System.Drawing.Point(174, 0);
            this.buttonsEmptySpaceItem.Name = "buttonsEmptySpaceItem";
            this.buttonsEmptySpaceItem.Size = new System.Drawing.Size(590, 26);
            this.buttonsEmptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // gridLayoutControlItem
            // 
            this.gridLayoutControlItem.Control = this.mainGridControl;
            this.gridLayoutControlItem.Location = new System.Drawing.Point(0, 26);
            this.gridLayoutControlItem.Name = "gridLayoutControlItem";
            this.gridLayoutControlItem.Size = new System.Drawing.Size(764, 515);
            this.gridLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.gridLayoutControlItem.TextVisible = false;
            // 
            // CandidatesBrowserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainLayoutControl);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CandidatesBrowserMainForm";
            this.Text = "Candidates Browser";
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).EndInit();
            this.mainLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsEmptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayoutControlItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl mainLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup mainLayoutControlGroup;
        private DevExpress.XtraGrid.GridControl mainGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView mainGridView;
        private DevExpress.XtraEditors.SimpleButton editButton;
        private DevExpress.XtraEditors.SimpleButton addButton;
        private DevExpress.XtraLayout.LayoutControlItem addLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem editLayoutControlItem;
        private DevExpress.XtraLayout.EmptySpaceItem buttonsEmptySpaceItem;
        private DevExpress.XtraLayout.LayoutControlItem gridLayoutControlItem;
        private System.Windows.Forms.BindingSource mainBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colMiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn coLastContactDate;
        private DevExpress.XtraGrid.Columns.GridColumn coLastContactComment;
    }
}