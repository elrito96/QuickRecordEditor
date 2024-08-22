XRMToolBox tool to quickly update a record from the tool itself.
This idea came from many times where I needed to change a field but it wasn't in the form so I had to manually add it to the form, then manually change it, save, and then again remove the field from the form.
Sometimes I wasn't even able to modify the form because of permissions or other reasons.

Main goal for v1:
- Tool connects to a CRM instance.
- Tool has an optionset that loads that CRM instance entities so you can choose which are you going to modify.
- Tool has a text field for GUID, where you can manually write which record you are going to modify.
- Tool has an optionset that loads all fields for that entity so you choose which are you going to update.
- Tool detects which type is the selected field, so it formats correctly when sending the update.
- Tool has a text field to inform new value you want to update.
- Tool succesfully updates the desired field.

Possible future upgrades:
- If optionset field is selected, tool directly loads shows you all possible values.
- After selecting an entity, all fields are loaded in the tool so you can even update more than 1 at a time.
