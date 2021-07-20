# **Laboratory Management System**

Software Engineering's Final Project - Class SOEN330679E_20_2_02CLC

-----------------------------------------------


# **Members**
| Full name  | ID|
| ------------- | ------------- |
| Huỳnh Quang Duy   | 18110007  |
| Trần Đức Long    | 18110029  |
| Tôn Trí Thiện    | 18110050  |
-----------------------------------------------

# **Setup**

**Step 1:** Open SSMS and restore the **```lab-new.bak```**, the file is in the folder **```database```**.

**Step 2:** Open the **```Laboratory```** project, go to ```Tools``` → ```Connect to Database```.

**Step 3:** Choose a server name of your local instance and select the **```Laboratory```** database.

**Step 4:** Click the ```Laboratory.dbo``` on **Server Explorer**, copy the ```Connection String```.

For example, in my case:
> Data Source=.;Initial Catalog=Laboratory;Integrated Security=True

**Step 5:** Paste the string to SqlConnection in **```SQLConfig.cs```**

**→ With that, the setup is done. You can start working with the project.**
