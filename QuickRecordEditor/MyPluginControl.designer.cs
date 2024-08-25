namespace QuickRecordEditor
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPluginControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSample = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.entitiesDropdownControl1 = new xrmtb.XrmToolBox.Controls.EntitiesDropdownControl();
            this.attributesDropdown = new xrmtb.XrmToolBox.Controls.AttributeDropdownControl();
            this.label2 = new System.Windows.Forms.Label();
            this.recordGuidBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.newValueTextBox = new System.Windows.Forms.TextBox();
            this.updateResultLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.tsbSample});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1076, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            this.toolStripMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMenu_ItemClicked);
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(86, 22);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSample
            // 
            this.tsbSample.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSample.Name = "tsbSample";
            this.tsbSample.Size = new System.Drawing.Size(46, 22);
            this.tsbSample.Text = "Try me";
            this.tsbSample.Click += new System.EventHandler(this.tsbSample_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select an entity:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // entitiesDropdownControl1
            // 
            this.entitiesDropdownControl1.AutoLoadData = true;
            this.entitiesDropdownControl1.LanguageCode = 1033;
            this.entitiesDropdownControl1.Location = new System.Drawing.Point(55, 91);
            this.entitiesDropdownControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.entitiesDropdownControl1.Name = "entitiesDropdownControl1";
            this.entitiesDropdownControl1.Service = null;
            this.entitiesDropdownControl1.Size = new System.Drawing.Size(141, 231);
            this.entitiesDropdownControl1.SolutionFilter = null;
            this.entitiesDropdownControl1.TabIndex = 0;
            this.entitiesDropdownControl1.Load += new System.EventHandler(this.entitiesDropdownControl1_Load);
            // 
            // attributesDropdown
            // 
            this.attributesDropdown.AutoLoadData = true;
            this.attributesDropdown.LanguageCode = 1033;
            this.attributesDropdown.Location = new System.Drawing.Point(311, 175);
            this.attributesDropdown.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.attributesDropdown.Name = "attributesDropdown";
            this.attributesDropdown.ParentEntity = null;
            this.attributesDropdown.ParentEntityLogicalName = null;
            this.attributesDropdown.Service = null;
            this.attributesDropdown.Size = new System.Drawing.Size(268, 28);
            this.attributesDropdown.TabIndex = 5;
            this.attributesDropdown.Load += new System.EventHandler(this.attributeDropdownControl1_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Write the record GUID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // recordGuidBox
            // 
            this.recordGuidBox.Location = new System.Drawing.Point(311, 91);
            this.recordGuidBox.Name = "recordGuidBox";
            this.recordGuidBox.Size = new System.Drawing.Size(187, 20);
            this.recordGuidBox.TabIndex = 0;
            this.recordGuidBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select the attribute you want to edit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // searchResultLabel
            // 
            this.searchResultLabel.AutoSize = true;
            this.searchResultLabel.Location = new System.Drawing.Point(657, 100);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(35, 13);
            this.searchResultLabel.TabIndex = 7;
            this.searchResultLabel.Text = "label4";
            this.searchResultLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Write the new value";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // newValueTextBox
            // 
            this.newValueTextBox.Location = new System.Drawing.Point(311, 272);
            this.newValueTextBox.Name = "newValueTextBox";
            this.newValueTextBox.Size = new System.Drawing.Size(187, 20);
            this.newValueTextBox.TabIndex = 9;
            this.newValueTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // updateResultLabel
            // 
            this.updateResultLabel.AutoSize = true;
            this.updateResultLabel.Location = new System.Drawing.Point(657, 275);
            this.updateResultLabel.Name = "updateResultLabel";
            this.updateResultLabel.Size = new System.Drawing.Size(35, 13);
            this.updateResultLabel.TabIndex = 10;
            this.updateResultLabel.Text = "label5";
            this.updateResultLabel.Visible = false;
            this.updateResultLabel.Click += new System.EventHandler(this.updateResultLabel_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(504, 269);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.updateResultLabel);
            this.Controls.Add(this.newValueTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchResultLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attributesDropdown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.entitiesDropdownControl1);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.recordGuidBox);
            this.Controls.Add(this.label2);
            this.Name = "MyPluginControl";
            this.PluginIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PluginIcon")));
            this.Size = new System.Drawing.Size(1076, 472);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbSample;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.Label label1;
        private xrmtb.XrmToolBox.Controls.EntitiesDropdownControl entitiesDropdownControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recordGuidBox;
        private xrmtb.XrmToolBox.Controls.AttributeDropdownControl attributesDropdown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label searchResultLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newValueTextBox;
        private System.Windows.Forms.Label updateResultLabel;
        private System.Windows.Forms.Button updateButton;
    }
}
