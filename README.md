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
![Http cat](https://scontent-xsp1-2.xx.fbcdn.net/v/t1.15752-9/190605521_219084263116515_247758605410253571_n.png?_nc_cat=101&ccb=1-3&_nc_sid=ae9488&_nc_ohc=ghZfKnt31soAX811jzd&_nc_ht=scontent-xsp1-2.xx&oh=6948951fde129fdb7df949f7b5543d46&oe=60D2C4DC)

**Step 2:** Open the **```Laboratory```** project, go to ```Tools``` → ```Connect to Database```.
![Http cat](https://scontent-xsp1-3.xx.fbcdn.net/v/t1.15752-9/187635333_1693327750855604_5161718467879266641_n.png?_nc_cat=100&ccb=1-3&_nc_sid=ae9488&_nc_ohc=gfbu1XzrwIYAX-AMG2K&_nc_ht=scontent-xsp1-3.xx&oh=11e84dfeee3a635370510c4108a8b6c5&oe=60D09315)

**Step 3:** Choose a server name of your local instance and select the **```Laboratory```** database.
![Http cat](https://scontent.fsgn5-5.fna.fbcdn.net/v/t1.15752-9/190636000_202792191558765_4623895213463520466_n.png?_nc_cat=100&ccb=1-3&_nc_sid=ae9488&_nc_ohc=Jm-EN-LSbpQAX9Nq6AE&_nc_ht=scontent.fsgn5-5.fna&oh=ed4d67c8bb28253ec14c22961c7863c2&oe=60CFC46A)

**Step 4:** Click the ```Laboratory.dbo``` on **Server Explorer**, copy the ```Connection String```.

For example, in my case:
> Data Source=.;Initial Catalog=Laboratory;Integrated Security=True

![Http cat](https://scontent.fsgn5-5.fna.fbcdn.net/v/t1.15752-9/189994595_2014555598695681_2638022249219715512_n.png?_nc_cat=102&ccb=1-3&_nc_sid=ae9488&_nc_ohc=GKvnFAIuHRIAX9U65WL&_nc_ht=scontent.fsgn5-5.fna&oh=ee77b23dc79c7d66b534d5a95f7213ae&oe=60D0A2E3)

**Step 5:** Paste the string to SqlConnection in **```SQLConfig.cs```**
![Http cat](https://scontent.fsgn5-7.fna.fbcdn.net/v/t1.15752-9/189569194_1010962196392095_8878782335602267585_n.png?_nc_cat=103&ccb=1-3&_nc_sid=ae9488&_nc_ohc=lMx9chMYLvAAX-IGdxV&_nc_ht=scontent.fsgn5-7.fna&oh=a37bed1afde72d206c71be48b66130de&oe=60CF8978)

**→ With that, the setup is done. You can start working with the project.**
