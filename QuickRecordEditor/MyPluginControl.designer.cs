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
            this.label1 = new System.Windows.Forms.Label();
            this.entitiesDropdownControl1 = new xrmtb.XrmToolBox.Controls.EntitiesDropdownControl();
            this.attributesDropdown = new xrmtb.XrmToolBox.Controls.AttributeDropdownControl();
            this.label2 = new System.Windows.Forms.Label();
            this.recordGuidBox = new System.Windows.Forms.TextBox();
            this.searchRecordButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.searchResultLabel = new System.Windows.Forms.Label();
            this.textBoxLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.updateResultLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.datetimePickerLabel = new System.Windows.Forms.Label();
            this.comboBoxLabel = new System.Windows.Forms.Label();
            this.checkBoxLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emptyOptionSetButton = new System.Windows.Forms.Button();
            this.emptyDateButton = new System.Windows.Forms.Button();
            this.emptyBooleanButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 75);
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
            this.entitiesDropdownControl1.Location = new System.Drawing.Point(30, 90);
            this.entitiesDropdownControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.entitiesDropdownControl1.Name = "entitiesDropdownControl1";
            this.entitiesDropdownControl1.Service = null;
            this.entitiesDropdownControl1.Size = new System.Drawing.Size(327, 283);
            this.entitiesDropdownControl1.SolutionFilter = null;
            this.entitiesDropdownControl1.TabIndex = 0;
            this.entitiesDropdownControl1.Load += new System.EventHandler(this.entitiesDropdownControl1_Load);
            // 
            // attributesDropdown
            // 
            this.attributesDropdown.AutoLoadData = true;
            this.attributesDropdown.LanguageCode = 1033;
            this.attributesDropdown.Location = new System.Drawing.Point(466, 89);
            this.attributesDropdown.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.attributesDropdown.Name = "attributesDropdown";
            this.attributesDropdown.ParentEntity = null;
            this.attributesDropdown.ParentEntityLogicalName = null;
            this.attributesDropdown.Service = null;
            this.attributesDropdown.Size = new System.Drawing.Size(424, 28);
            this.attributesDropdown.TabIndex = 5;
            this.attributesDropdown.Load += new System.EventHandler(this.attributeDropdownControl1_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Write the record GUID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // recordGuidBox
            // 
            this.recordGuidBox.Location = new System.Drawing.Point(30, 153);
            this.recordGuidBox.Name = "recordGuidBox";
            this.recordGuidBox.Size = new System.Drawing.Size(312, 20);
            this.recordGuidBox.TabIndex = 0;
            this.recordGuidBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchRecordButton
            // 
            this.searchRecordButton.Location = new System.Drawing.Point(348, 151);
            this.searchRecordButton.Name = "searchRecordButton";
            this.searchRecordButton.Size = new System.Drawing.Size(75, 23);
            this.searchRecordButton.TabIndex = 3;
            this.searchRecordButton.Text = "Search";
            this.searchRecordButton.UseVisualStyleBackColor = true;
            this.searchRecordButton.Click += new System.EventHandler(this.searchRecordButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select the attribute you want to edit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // searchResultLabel
            // 
            this.searchResultLabel.AutoSize = true;
            this.searchResultLabel.Location = new System.Drawing.Point(27, 186);
            this.searchResultLabel.Name = "searchResultLabel";
            this.searchResultLabel.Size = new System.Drawing.Size(35, 13);
            this.searchResultLabel.TabIndex = 7;
            this.searchResultLabel.Text = "label4";
            this.searchResultLabel.Visible = false;
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.AutoSize = true;
            this.textBoxLabel.Location = new System.Drawing.Point(289, 0);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(212, 13);
            this.textBoxLabel.TabIndex = 8;
            this.textBoxLabel.Text = "Write the new value (string, number or guid)";
            this.textBoxLabel.Visible = false;
            this.textBoxLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(6, 6);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(291, 20);
            this.textBox.TabIndex = 9;
            this.textBox.Visible = false;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // updateResultLabel
            // 
            this.updateResultLabel.AutoSize = true;
            this.updateResultLabel.Location = new System.Drawing.Point(520, 428);
            this.updateResultLabel.Name = "updateResultLabel";
            this.updateResultLabel.Size = new System.Drawing.Size(35, 13);
            this.updateResultLabel.TabIndex = 10;
            this.updateResultLabel.Text = "label5";
            this.updateResultLabel.Visible = false;
            this.updateResultLabel.Click += new System.EventHandler(this.updateResultLabel_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(507, 364);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(76, 52);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkedListBox);
            this.panel1.Controls.Add(this.checkBox);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.comboBox);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Location = new System.Drawing.Point(0, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 116);
            this.panel1.TabIndex = 12;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(6, 72);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(51, 17);
            this.checkBox.TabIndex = 14;
            this.checkBox.Text = "False";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.Visible = false;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(6, 49);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(291, 20);
            this.dateTimePicker.TabIndex = 12;
            this.dateTimePicker.Visible = false;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(6, 28);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(291, 21);
            this.comboBox.TabIndex = 10;
            this.comboBox.Visible = false;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.attributeTypeComboBox_SelectedIndexChanged_1);
            // 
            // datetimePickerLabel
            // 
            this.datetimePickerLabel.AutoSize = true;
            this.datetimePickerLabel.Location = new System.Drawing.Point(389, 40);
            this.datetimePickerLabel.Name = "datetimePickerLabel";
            this.datetimePickerLabel.Size = new System.Drawing.Size(102, 13);
            this.datetimePickerLabel.TabIndex = 13;
            this.datetimePickerLabel.Text = "Select the new date";
            this.datetimePickerLabel.Visible = false;
            // 
            // comboBoxLabel
            // 
            this.comboBoxLabel.AutoSize = true;
            this.comboBoxLabel.Location = new System.Drawing.Point(378, 27);
            this.comboBoxLabel.Name = "comboBoxLabel";
            this.comboBoxLabel.Size = new System.Drawing.Size(124, 13);
            this.comboBoxLabel.TabIndex = 11;
            this.comboBoxLabel.Text = "Select the desired option";
            this.comboBoxLabel.Visible = false;
            this.comboBoxLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // checkBoxLabel
            // 
            this.checkBoxLabel.AutoSize = true;
            this.checkBoxLabel.Location = new System.Drawing.Point(303, 59);
            this.checkBoxLabel.Name = "checkBoxLabel";
            this.checkBoxLabel.Size = new System.Drawing.Size(238, 13);
            this.checkBoxLabel.TabIndex = 15;
            this.checkBoxLabel.Text = "Boolean field, select for true, don\'t select for false";
            this.checkBoxLabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkedListBoxLabel);
            this.panel2.Controls.Add(this.checkBoxLabel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.datetimePickerLabel);
            this.panel2.Controls.Add(this.comboBoxLabel);
            this.panel2.Controls.Add(this.textBoxLabel);
            this.panel2.Location = new System.Drawing.Point(466, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 136);
            this.panel2.TabIndex = 13;
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1});
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
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(6, 94);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(154, 19);
            this.checkedListBox.TabIndex = 14;
            this.checkedListBox.Visible = false;
            // 
            // checkedListBoxLabel
            // 
            this.checkedListBoxLabel.AutoSize = true;
            this.checkedListBoxLabel.Location = new System.Drawing.Point(348, 72);
            this.checkedListBoxLabel.Name = "checkedListBoxLabel";
            this.checkedListBoxLabel.Size = new System.Drawing.Size(111, 13);
            this.checkedListBoxLabel.TabIndex = 16;
            this.checkedListBoxLabel.Text = "Select desired options";
            this.checkedListBoxLabel.Visible = false;
            this.checkedListBoxLabel.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 395);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "473965b4-f119-ec11-b6e6-6045bd8aa398";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 437);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(286, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "3ffb5702-8446-ef11-bfe2-000d3a221385";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "acc id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "contact id";
            // 
            // emptyOptionSetButton
            // 
            this.emptyOptionSetButton.Location = new System.Drawing.Point(466, 280);
            this.emptyOptionSetButton.Name = "emptyOptionSetButton";
            this.emptyOptionSetButton.Size = new System.Drawing.Size(116, 23);
            this.emptyOptionSetButton.TabIndex = 18;
            this.emptyOptionSetButton.Text = "Empty Optionset";
            this.emptyOptionSetButton.UseVisualStyleBackColor = true;
            this.emptyOptionSetButton.Visible = false;
            this.emptyOptionSetButton.Click += new System.EventHandler(this.emptyOptionSetButton_Click);
            // 
            // emptyDateButton
            // 
            this.emptyDateButton.Location = new System.Drawing.Point(588, 280);
            this.emptyDateButton.Name = "emptyDateButton";
            this.emptyDateButton.Size = new System.Drawing.Size(129, 23);
            this.emptyDateButton.TabIndex = 19;
            this.emptyDateButton.Text = "Empty Date";
            this.emptyDateButton.UseVisualStyleBackColor = true;
            this.emptyDateButton.Visible = false;
            this.emptyDateButton.Click += new System.EventHandler(this.emptyDateButton_Click);
            // 
            // emptyBooleanButton
            // 
            this.emptyBooleanButton.Location = new System.Drawing.Point(723, 280);
            this.emptyBooleanButton.Name = "emptyBooleanButton";
            this.emptyBooleanButton.Size = new System.Drawing.Size(138, 23);
            this.emptyBooleanButton.TabIndex = 20;
            this.emptyBooleanButton.Text = "Empty Boolean";
            this.emptyBooleanButton.UseVisualStyleBackColor = true;
            this.emptyBooleanButton.Visible = false;
            this.emptyBooleanButton.Click += new System.EventHandler(this.emptyBooleanButton_Click);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.emptyBooleanButton);
            this.Controls.Add(this.emptyDateButton);
            this.Controls.Add(this.emptyOptionSetButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.recordGuidBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.updateResultLabel);
            this.Controls.Add(this.searchResultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchRecordButton);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.attributesDropdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.entitiesDropdownControl1);
            this.Controls.Add(this.panel2);
            this.Name = "MyPluginControl";
            this.PluginIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PluginIcon")));
            this.Size = new System.Drawing.Size(1076, 472);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private xrmtb.XrmToolBox.Controls.EntitiesDropdownControl entitiesDropdownControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recordGuidBox;
        private xrmtb.XrmToolBox.Controls.AttributeDropdownControl attributesDropdown;
        private System.Windows.Forms.Button searchRecordButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label searchResultLabel;
        private System.Windows.Forms.Label textBoxLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label updateResultLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label datetimePickerLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label comboBoxLabel;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label checkBoxLabel;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Label checkedListBoxLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button emptyOptionSetButton;
        private System.Windows.Forms.Button emptyDateButton;
        private System.Windows.Forms.Button emptyBooleanButton;
    }
}
