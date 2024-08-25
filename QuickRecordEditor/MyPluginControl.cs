using McTools.Xrm.Connection;
using Microsoft.Rest;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xrmtb.XrmToolBox.Controls;
using XrmToolBox.Extensibility;

namespace QuickRecordEditor
{
    public partial class MyPluginControl : PluginControlBase
    {
        private Settings mySettings;

        public MyPluginControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));

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

        private void tsbSample_Click(object sender, EventArgs e)
        {
            // The ExecuteMethod method handles connecting to an
            // organization if XrmToolBox is not yet connected
            ExecuteMethod(GetAccounts);
        }

        private void GetAccounts()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting accounts",
                Work = (worker, args) =>
                {
                    args.Result = Service.RetrieveMultiple(new QueryExpression("account")
                    {
                        TopCount = 50
                    });
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as EntityCollection;
                    if (result != null)
                    {
                        MessageBox.Show($"Found {result.Entities.Count} accounts");
                    }
                }
            });
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Example: account guid: 82ade658-41bc-ee11-a569-6045bd90b824

            // When clicked search entity selected in entitiesDropdownControl1_Load, with GUID in textBox1_TextChanged: 
            var entitySelected = entitiesDropdownControl1.SelectedEntity;
            string entityLogicalName = entitySelected.LogicalName;
            string recordGuid = recordGuidBox.Text;

            bool isValid = IsValidGuid(recordGuid);

            if (isValid)
            {
                // Search
                try
                {
                    Entity resultEntity = Service.Retrieve(entityLogicalName, new Guid(recordGuid), new ColumnSet(true));
                    if (resultEntity != null)
                    {
                        // found
                        setLabel(searchResultLabel, "Found record", Color.Green);
                        // Create the request
                        var request = new RetrieveEntityRequest
                        {
                            EntityFilters = EntityFilters.All, // Specify what parts of the metadata you want
                            LogicalName = entityLogicalName,   // The logical name of the entity
                            RetrieveAsIfPublished = true       // If true, retrieves metadata that includes any unpublished changes
                        };

                        // Execute the request
                        var response = (RetrieveEntityResponse)Service.Execute(request);

                        var fullmetadata = response.EntityMetadata;

                        attributesDropdown.ParentEntity = fullmetadata;
                        attributesDropdown.ParentEntityLogicalName = "account";

                        attributesDropdown.Refresh();
                    }
                    else
                    {
                        // not found
                        setLabel(searchResultLabel, "Couldn't find record of entity " + entityLogicalName + " with GUID: " + recordGuid, Color.Red);
                        
                    }
                }
                catch (Exception ex)
                {
                    string message = "Error retrieving entity: " + ex.Message;
                }
            }
            else
            {
                setLabel(searchResultLabel, recordGuid + " is not a valid GUID", Color.Red);
            }

        }

        private void entitiesDropdownControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        public static bool IsValidGuid(string input)
        {
            return Guid.TryParse(input, out _);
        }

        private void attributeDropdownControl1_Load(object sender, EventArgs e)
        {

        }

        private void attributeDropdownBaseControl1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            var entitySelected = entitiesDropdownControl1.SelectedEntity;
            string entityLogicalName = entitySelected.LogicalName;
            string recordGuid = recordGuidBox.Text;
            AttributeMetadata attributeToUpdateMetadata = attributesDropdown.SelectedAttribute;
            string attributeToUpdateName = attributeToUpdateMetadata.LogicalName;

            bool isValid = IsValidGuid(recordGuid);
            if (isValid)
            {
                Entity entityToUpdate = new Entity(entityLogicalName, new Guid(recordGuid));
                entityToUpdate.Attributes[attributeToUpdateName] = newValueTextBox.Text;

                try
                {
                    Service.Update(entityToUpdate);
                    setLabel(updateResultLabel, "Update Successful", Color.Green);

                } catch (Exception ex)
                {
                    // Errror updating
                    Service.Update(entityToUpdate);
                    setLabel(updateResultLabel, "Error updating record: "+ex.Message, Color.Red);
                }


            } else
            {
                // Error not valid guid
                setLabel(updateResultLabel, "Error GUID not valid", Color.Red);
            }
        }

        private void setLabel(System.Windows.Forms.Label label, string text, Color color)
        {
            label.Text = text;
            label.ForeColor = color;
            label.Visible = true;
        }

        private void updateResultLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}