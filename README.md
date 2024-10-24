XRMToolBox tool to quickly update a record from the tool itself.
This idea came from many times where I needed to change a field but it wasn't in the form so I had to manually add it to the form, then manually change it, save, and then again remove the field from the form.
Sometimes I wasn't even able to modify the form because of permissions or other reasons.

An image of the tool:
![image](https://github.com/user-attachments/assets/e21454cd-59be-458b-a7f4-f723f777c4b1)

MANUAL:
When opening it will automatically load all your CRM instance entities.
1- You must choose the record's entity you desire to update.
2- You must inform the record's GUID in the second field, then press Search. If a record with that GUID is found, the next section will be made visible.
3- You must choose the field you want to update. Depending on the type, a corresponding input will be shown. For example for datetime you have a datetime picker with a calendar. For a string field you get a text field. For an optionset field you get a dropdown with all possible options loaded from CRM, etc. Some attributes might not be implemented, and they will be added in future versions.
4- After informing the desired value for the field, click button Update. If everything goes correctly you should get a "Update successful" message like in the image.

Features of current v1, which is published in main branch:
- Tool connects to a CRM instance.
- Tool has an optionset that loads that CRM instance entities so you can choose which are you going to modify.
- Tool has a text field for GUID, where you can manually write which record you are going to modify.
- Tool has an optionset that loads all fields for that entity so you choose which are you going to update.
- Tool detects which type is the selected field, so it formats correctly when sending the update.
- Tool has a text field to inform new value you want to update.
- Tool succesfully updates the desired field.
- If optionset field is selected, tool directly loads shows you all possible values.

Possible upgrades for v2:

- Add Hour to Datetime fields, currently can only choose day/month/year- After selecting an entity, all fields are loaded in the tool so you can even update more than 1 at a time. Maybe add an option for dynamically add fields. For example start with 1 as of current version 1, but add a + button to create a second, third... fields, and a - button to delete these new fields.
- Add multiselect attributes to attribute dropdown. For some reason multiselect attributes are not loaded in the attribute list, as this type of attribute is "not bindable". This typically means that the attribute cannot be used in some standard ways that you might expect from simpler field types like text fields or single-select option sets. As a possible workaround I might be able to implement a new and different dropdown object in the tool that will only load MultiSelectOptionSet attributes. This might not be the best visually pleasing solution, and the other would be to customize the attributes component, which might take too much effort for the gain. Yet this workaround would give the capacity to update this type of field.
- Add control to update correctly Ownertype attributes, for example, owner. For the same reason as previous point, this would take an extra effort to control yet I wanted to get a good version 1 and not focus on perfecting everything and end up not getting a full version. This type is not trivial to implement, as you have to control if the owner of the record is user, team, business unit, organization, etc...
- Add control to update correctly UniqueidentifierType attributes. Not sure if this should be even implemented, needs more analysis. This attribute type is associated to the record guid field. For example, in Account entity, this would be the AccountId field. As this guid can't be changed once the record is created, maybe I should control the error to say you can't update this field, or try to filter the dropdown to never show this attribute type. This would be the easiest next step for version 2.
- Add control to update correctly MemoType attributes. Not really sure what is this type, it was just one of the possible Attribute Types in the documentation, needs more analysis.
