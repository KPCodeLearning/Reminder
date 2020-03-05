# Reminder

1. Download project and build this in Visual Studio. <br/>
2. It is developed in Visual Sudio 2019 with .NET Framework 4.7.2. 
3. Update nuget packages and Build the solution. 
4. If there is any error occurred in build you can set .Net Framework as per your availability.
4. After succesfull build of project it create a application type .exe file in Reminder\bin\Debug

### Reminder.txt <br/>
1. Create a <b>Reminder.txt</b> file at location <b>D:\ </b>
2. Please keep your reminder lines in a short way as per your priority. No need to keep any serial number or sorting order.
3. You can create a shortcut of Reminder.txt on your desktop.
4. Now, Perform double click on Reminder\bin\Debug\Reminder for testing. This will popuplate a desktop notification on right bottom screen with the reminder contents which you had written in reminder.txt.

## Set it for auto remind <br/>
1. Go to your taskbar, Search <b>Task Scheduler</b> and open the same.
2. Go to the left-pane menu, then select <b>Task Scheduler Library</b>.
3. Now, you need to go to the right-pane menu on the <b>Actions option</b> and click <b>Create Task</b>.
4. In popup, write <b>Reminder</b> or whatever you want in <b>General -> Name</b>.
5. Keep as it is remaining things.
6. Now, click on <b>Trigger</b> tab then <b>New</b> button and then tick <b>Daily</b>.
7. In <b>Advanve Settings</b> tick <b>Repeat Task every</b> and select 15 min or 30 min from dropdown as per your convenience. Also tick <b>Stop all running tasks at end of repetition duration</b>. Click on <b>OK</b>
8. Now, Click on <b>Action</b> tab, click on <b>Browse</b> and select Reminder file (.exe and Application type)  in Reminder\bin\Debug location. click OK
9. Now for testing your task schedular, Select <b>Reminder</b> (or whatever you have given) in tasks list. It should have status as Running. Go to the right-pane menu on the <b>Selected Item</b> and click on <b>Run</b>. This will popuplate a desktop notification on right bottom screen with the reminder contents which you had written in reminder.txt.
10. This will auto populate in specified time.
