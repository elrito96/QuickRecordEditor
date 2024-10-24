﻿using McTools.Xrm.Connection;
using Microsoft.Rest;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xrmtb.XrmToolBox.Controls;
using XrmToolBox.Extensibility;
using AttributeMetadata = Microsoft.Xrm.Sdk.Metadata.AttributeMetadata;

namespace QuickRecordEditor
{
    public partial class MyPluginControl : PluginControlBase
    {
        // Global variables
        private Settings mySettings;
        public static string recordGUID;
        public static List<AttributeMetadata> multiSelectOptionSetMetadata;

        // Buttons states variables
        private bool isEmptyOptionSetButtonClicked = false;
        private bool isEmptyDateTimePickerButtonClicked = false;
        private bool isEmptyBooleanButtonClicked = false;

        public MyPluginControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            ShowInfoNotification(@"
This tool is Open Source, click on ""learn more"" for a link to git repository:", new Uri("https://github.com/elrito96/QuickRecordEditor"));

            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }

            entitiesDropdownControl1.Service = newService;
            attributesDropdown.Service = newService;
            attributesDropdown.SelectedItemChanged += AttributeTypeComboBox_SelectedIndexChanged;

            //TODOv2: try to add multiselect attributes to attribute dropdown
            
            List<AttributeMetadata> attributeList = attributesDropdown.AllAttributes;
            foreach(AttributeMetadata attribute in attributeList)
            {
                if (attribute.AttributeTypeName.Value.Contains("Microsoft.Xrm.Sdk.Metadata.MultiSelectPicklistAttributeMetadata"))
                {
                    multiSelectOptionSetMetadata.Add(attribute);
                }
            }

        }
        private void AttributeTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(attributesDropdown.SelectedAttribute != null)
            {
                AttributeMetadata selectedAttributeMetadata = attributesDropdown.SelectedAttribute;
                DisplayInputsAndSetValues(selectedAttributeMetadata);
            }
        }

        private void DisplayInputsAndSetValues(AttributeMetadata selectedAttributeMetadata)
        {
            string attributeType = selectedAttributeMetadata.AttributeTypeName.Value;
            // Hide all controls first

            // Text region
            textBox.Visible = false;
            textBox.Location = new System.Drawing.Point(0, 0);
            textBoxLabel.Visible = false;
            textBoxLabel.Location = new System.Drawing.Point(0, 0);

            // Checkbox region
            checkBox.Visible = false;
            checkBox.Location = new System.Drawing.Point(0, 0);
            checkBoxLabel.Visible = false;
            checkBoxLabel.Location = new System.Drawing.Point(0, 0);
            emptyBooleanButton.Visible = false;

            // Date region
            dateTimePicker.Visible = false;
            dateTimePicker.Location = new System.Drawing.Point(0, 0);
            datetimePickerLabel.Visible = false;
            datetimePickerLabel.Location = new System.Drawing.Point(0, 0);
            emptyDateButton.Visible = false;

            // Combo region
            comboBox.Visible = false;
            comboBox.Location = new System.Drawing.Point(0, 0);
            comboBoxLabel.Visible = false;
            comboBoxLabel.Location = new System.Drawing.Point(0, 0);
            emptyOptionSetButton.Visible = false;

            // CheckedList region
            checkedListBox.Visible = false;
            checkedListBox.Location = new System.Drawing.Point(0, 0);
            checkedListBoxLabel.Visible = false;
            checkedListBoxLabel.Location = new System.Drawing.Point(0, 0);

            //Buttons
            emptyOptionSetButton.Location = new System.Drawing.Point(0, 0);
            emptyDateButton.Location = new System.Drawing.Point(0, 0);
            emptyBooleanButton.Location = new System.Drawing.Point(0, 0);

            //TODOv2 UniqueidentifierType
            //TODOv2 Statetype
            //TODOv2 ownertype? owner field can be user or team, currently doesnt work
            //TODOv2 MemoType ?????? what is this

            // Show the relevant control based on the attribute type
            switch (attributeType)
            {
                case "StringType": 
                case "IntegerType":
                case "DecimalType":
                case "DoubleType":
                case "MoneyType":
                case "LookupType":
                    textBox.Visible = true;
                    textBoxLabel.Visible = true;
                    break;

                case "BooleanType":
                    checkBox.Visible = true;
                    checkBoxLabel.Visible= true;
                    emptyBooleanButton.Visible = true;
                    break;

                case "DateTimeType":
                    dateTimePicker.Visible = true;
                    datetimePickerLabel.Visible = true;
                    emptyDateButton.Visible = true;
                    break;

                case "PicklistType":
                    comboBox.Visible = true;
                    comboBoxLabel.Visible = true;
                    emptyOptionSetButton.Visible = true;

                    //populate combobox
                    var optionList = new List<KeyValuePair<int, string>>();
                    // Iterate through each option in the OptionSet
                    foreach (var option in ((EnumAttributeMetadata)selectedAttributeMetadata).OptionSet.Options)
                    {
                        optionList.Add(new KeyValuePair<int, string>(option.Value.Value, option.Label.UserLocalizedLabel.Label));
                    }
                    // add empty value
                    optionList.Insert(0, new KeyValuePair<int, string>(-1, "*** Select this option to empty field ***"));

                    // Set the ComboBox DataSource
                    comboBox.DataSource = new BindingSource(optionList, null);
                    comboBox.DisplayMember = "Value";
                    comboBox.ValueMember = "Key";

                    
                    break;
                default:
                    setLabel(updateResultLabel, attributeType + " Is an unsupported attribute type", Color.Red);
                    break;
            }
        }


        private void searchRecordButton_Click(object sender, EventArgs e)
        {
            // Example: account guid: 82ade658-41bc-ee11-a569-6045bd90b824

            // When clicked search entity selected in entitiesDropdownControl1_Load, with GUID in textBox1_TextChanged: 
            var entitySelectedMetadata = entitiesDropdownControl1.SelectedEntity;
            string entityLogicalName = entitySelectedMetadata.LogicalName;
            recordGUID = recordGuidBox.Text;

            bool isValid = IsValidGuid(recordGUID);

            if (isValid)
            {
                // Search
                try
                {
                    Entity resultEntity = Service.Retrieve(entityLogicalName, new Guid(recordGUID), new ColumnSet(true));
                    if (resultEntity != null)
                    {
                        // found
                        setLabel(searchResultLabel, "Record found", Color.Green);
                        
                        var fullmetadata = entitySelectedMetadata;

                        attributesDropdown.ParentEntity = fullmetadata;

                        updateButton.Enabled = true;
                        attributesDropdown.Visible = true;
                        label3.Visible = true;

                        attributesDropdown.LoadData();

                        // Have to repeat this code as I couldn't find an option to force the attribute dropdown to refresh and reload a value to recheck visibility
                        /*System.Threading.Thread.Sleep(1000);
                        string attributeType = attributesDropdown.SelectedAttribute.AttributeTypeName.Value;
                        switch (attributeType)
                        {
                            case "StringType":
                            case "IntegerType":
                            case "DecimalType":
                            case "DoubleType":
                            case "MoneyType":
                            case "LookupType":
                                textBox.Visible = true;
                                textBoxLabel.Visible = true;
                                break;

                            case "BooleanType":
                                checkBox.Visible = true;
                                checkBoxLabel.Visible = true;
                                emptyBooleanButton.Visible = true;
                                break;

                            case "DateTimeType":
                                dateTimePicker.Visible = true;
                                datetimePickerLabel.Visible = true;
                                emptyDateButton.Visible = true;
                                break;

                            case "PicklistType":
                                comboBox.Visible = true;
                                comboBoxLabel.Visible = true;
                                emptyOptionSetButton.Visible = true;

                                break;
                            default:
                                break;
                        }*/

                    }
                    else
                    {
                        // not found
                        setLabel(searchResultLabel, "Couldn't find record of entity " + entityLogicalName + " with GUID: " + recordGUID, Color.Red);
                        
                    }
                }
                catch (Exception ex)
                {
                    string message = "Error retrieving entity: " + ex.Message;
                    setLabel(searchResultLabel, message, Color.Red);
                }
            }
            else
            {
                setLabel(searchResultLabel, recordGUID + " is not a valid GUID", Color.Red);
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var entitySelected = entitiesDropdownControl1.SelectedEntity;
            string entityLogicalName = entitySelected.LogicalName;
            recordGUID = recordGuidBox.Text;
            AttributeMetadata attributeToUpdateMetadata = attributesDropdown.SelectedAttribute;
            string attributeToUpdateName = attributeToUpdateMetadata.LogicalName;
            Entity entityToUpdate = new Entity(entityLogicalName, new Guid(recordGUID));

            /*
            // test
            Entity contact = new Entity("contact", new Guid("3ffb5702-8446-ef11-bfe2-000d3a221385"));
            contact.Attributes["sis_dateofbirth"] = null;
            Service.Update(contact);
            */


            var attributeTypeName = attributeToUpdateMetadata.AttributeTypeName;

            bool validUpdate = true;

            switch (attributeTypeName.Value)
            {
                case "StringType":
                    entityToUpdate.Attributes[attributeToUpdateName] = textBox.Text;
                    break;

                case "IntegerType":
                    if (int.TryParse(textBox.Text, out int intValue))
                    {
                        entityToUpdate.Attributes[attributeToUpdateName] = intValue;
                    }
                    else
                    {
                        setLabel(updateResultLabel, "Invalid integer value.", Color.Red);
                    }
                    break;

                case "DecimalType":
                    if (decimal.TryParse(textBox.Text, out decimal decimalValue))
                    {
                        entityToUpdate.Attributes[attributeToUpdateName] = decimalValue;
                    }
                    else
                    {
                        setLabel(updateResultLabel, "Invalid decimal value.", Color.Red);
                    }
                    break;

                case "DoubleType":
                    if (double.TryParse(textBox.Text, out double doubleValue))
                    {
                        entityToUpdate.Attributes[attributeToUpdateName] = doubleValue;
                    }
                    else
                    {
                        setLabel(updateResultLabel, "Invalid double value.", Color.Red);
                    }
                    break;
                case "MoneyType":
                    if (decimal.TryParse(textBox.Text, out decimal moneyValue))
                    {
                        entityToUpdate.Attributes[attributeToUpdateName] = new Money(moneyValue);
                    }
                    else
                    {
                        setLabel(updateResultLabel, "Invalid money value.", Color.Red);
                    }
                    break;

                case "LookupType":
                    if (Guid.TryParse(textBox.Text, out Guid lookupId))
                    {
                        entityToUpdate.Attributes[attributeToUpdateName] = new EntityReference("entityLogicalName", lookupId); // Replace "entityLogicalName" with the logical name of the lookup entity
                    }
                    else
                    {
                        setLabel(updateResultLabel, "Invalid GUID for lookup.", Color.Red);
                    }
                    break;

                case "BooleanType":
                    if (isEmptyBooleanButtonClicked)
                    {
                        entityToUpdate.Attributes[attributeToUpdateName] = null;
                    }
                    else{
                        bool boolValue = checkBox.Checked;
                        entityToUpdate.Attributes[attributeToUpdateName] = boolValue;
                    }
                    
                    break;

                case "DateTimeType":
                    if (isEmptyDateTimePickerButtonClicked)
                    {
                        entityToUpdate.Attributes[attributeToUpdateName] = null;
                    }
                    else
                    {
                        DateTime dateTimeValue = dateTimePicker.Value;
                        entityToUpdate.Attributes[attributeToUpdateName] = dateTimeValue;
                    }
                    break;

                case "OptionSetType":
                    //deprecated
                    break;
                case "PicklistType":
                    if (comboBox.SelectedItem != null)
                    {
                        // Assuming the ComboBox is bound to a list of KeyValuePair<int, string>
                        var selectedOption = (KeyValuePair<int, string>)comboBox.SelectedItem;
                        int optionSetValue = selectedOption.Key;

                        if(optionSetValue != -1)
                        {
                            entityToUpdate.Attributes[attributeToUpdateName] = new OptionSetValue(optionSetValue);
                        }
                        else
                        {
                            entityToUpdate.Attributes[attributeToUpdateName] = null;
                        }
                        
                    }
                    else
                    {
                        setLabel(updateResultLabel, "Please select a valid option.", Color.Red);
                    }
                    break;

                default:
                    setLabel(updateResultLabel, "Unsupported attribute type.", Color.Red);
                    validUpdate = false;
                    break;
            }

            if (validUpdate)
            {
                try
                {
                    Service.Update(entityToUpdate);
                    setLabel(updateResultLabel, "Update successful", Color.Green);

                }
                catch (Exception ex)
                {
                    // Errror updating
                    Service.Update(entityToUpdate);
                    setLabel(updateResultLabel, "Error updating record: " + ex.Message, Color.Red);
                }
            }
            
        }

        private void setLabel(System.Windows.Forms.Label label, string text, Color color)
        {
            label.Text = text;
            label.ForeColor = color;
            label.Visible = true;
        }
        private static bool IsValidGuid(string input)
        {
            return Guid.TryParse(input, out _);
        }
        private void emptyOptionSetButton_Click(object sender, EventArgs e)
        {
            isEmptyOptionSetButtonClicked = !isEmptyOptionSetButtonClicked;

            if (isEmptyOptionSetButtonClicked)
            {
                emptyOptionSetButton.Text = "Click to enable Optionset";
                // Disable the picklist
                comboBox.Enabled = false;
                comboBox.SelectedIndex = -1;
                comboBox.Text = "*** Select this option to empty field ***";
            }
            else
            {
                emptyOptionSetButton.Text = "Click to empty Optionset";
                comboBox.Enabled = true;
            }
        }
        private void emptyDateButton_Click(object sender, EventArgs e)
        {
            isEmptyDateTimePickerButtonClicked = !isEmptyDateTimePickerButtonClicked;

            if (isEmptyDateTimePickerButtonClicked)
            {
                emptyDateButton.Text = "Click to enable DateTimePicker";
                // Disable the DateTimePicker
                dateTimePicker.Enabled = false;
                // Set Checked to false to "clear" the selection (simulates null behavior)
                dateTimePicker.Checked = false;
            } else
            {
                emptyDateButton.Text = "Click to empty DateTimePicker";
                dateTimePicker.Enabled = true;
            }
        }

        private void emptyBooleanButton_Click(object sender, EventArgs e)
        {
            isEmptyBooleanButtonClicked = !isEmptyBooleanButtonClicked;

            if (isEmptyBooleanButtonClicked)
            {
                emptyBooleanButton.Text = "Click to enable Checkbox";
                // Disable the checkbox
                checkBox.Enabled = false;
                
            }
            else
            {
                emptyBooleanButton.Text = "Click to empty Checkbox";
                checkBox.Enabled = true;
            }
        }

        private void attributeDropdownControl1_Load(object sender, EventArgs e)
        {
            attributesDropdown.SelectedItemChanged += new EventHandler(attributeDropdownBaseControl1_SelectedIndexChanged);
        }

        private void attributeDropdownBaseControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear button states
            isEmptyOptionSetButtonClicked = false;
            emptyOptionSetButton.Text = "Click to empty Optionset";
            comboBox.Enabled = true;

            isEmptyDateTimePickerButtonClicked = false;
            emptyDateButton.Text = "Click to empty Date";
            dateTimePicker.Enabled = true;

            isEmptyBooleanButtonClicked = false;
            emptyBooleanButton.Text = "Click to empty Optionset";
            checkBox.Enabled = true;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                checkBox.Text = "True";
            }
            else
            {
                checkBox.Text = "False";
            }
        }

        private void updateResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void attributeTypeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void entitiesDropdownControl1_Load(object sender, EventArgs e)
        {
            entitiesDropdownControl1.SelectedItemChanged += new EventHandler(entitiesDropdownControl11_SelectedIndexChanged);
        }

        private void entitiesDropdownControl11_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hide everything

            textBox.Visible = false;
            textBoxLabel.Visible = false;

            checkBox.Visible = false;
            checkBoxLabel.Visible = false;
            emptyBooleanButton.Visible = false;

            dateTimePicker.Visible = false;
            datetimePickerLabel.Visible = false;
            emptyDateButton.Visible = false;

            comboBox.Visible = false;
            comboBoxLabel.Visible = false;
            emptyOptionSetButton.Visible = false;
            
            attributesDropdown.Visible = false;
            label3.Visible = false;

            updateResultLabel.Visible = false;
            searchResultLabel.Visible = false;

            // Clear GUID field
            recordGuidBox.Text = string.Empty;

            // Disable update
            updateButton.Enabled = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}