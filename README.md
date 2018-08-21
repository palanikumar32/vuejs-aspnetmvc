# Installation
Nuget Package ->  Install-Package VueHelper
# TextBox
@Html.Vue().TextBoxFor(x => x.Name)
# TextArea
@Html.Vue().TextAreaFor(x => x.Address)
# Radio Button
@Html.Vue().RadioButtonFor(x => x.Gender).Items("Male", "Female")
# Checkbox
@Html.Vue().CheckBoxFor(x => x.IsActive).Label("Active")
# Combox with fixed items
@Html.Vue().ComboBoxFor(x => x.Level).Items("Level 1", "Level 2")
# Combox with Dynamic/Complex Object
@Html.Vue().ComboBoxFor(x => x.Country).DataMember("CountryList").ValueMember("CountryID").TextField("Country").ValueField("ID")
