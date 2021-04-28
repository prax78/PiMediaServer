# PiMediaServer

**This project is built on Microsoft Blazor Technology, I have used Blazor Server deployment template, built this app on Windows 10 PC, and published on Raspberry PI 4 B**
 Please clone this repository and change it as per your needs.
 ![alt text](https://github.com/prax78/PiMediaServer/blob/master/PI_server_1.png)
 
 Basically this Blazor App will pick all songfiles mentioned in your config.ini and list it on the page home page. Please make sure you also have Python3 available on your Raspberry PI 4B (Raspbian OS). I have shared the Python script that actually plays the audio file passed through Blazor app.
 When a user clicks a song button, it creates a process on the Raspberry PI  and that process calls python to run the script as mentioned the config.ini.
 
 Please find the config.ini. you can change as per your needs.
 
 ![alt text](https://github.com/prax78/PiMediaServer/blob/master/PI_server_configini.png)
 
 Please make sure you have DotNet 5 installed on your Raspberry PI 4 B.
 Use this below command
 ****"wget -O - https://raw.githubusercontent.com/pjgpetecodes/dotnet5pi/master/install.sh | sudo bash"****
 this will get DOtNet 5 installed (https://github.com/pjgpetecodes/dotnet5pi).
 
 I have made server to listen on static IP of my PI on port 5005, you can do as per your needs.
 
 ![alt text](https://github.com/prax78/PiMediaServer/blob/master/PI_server_kestrel.png)
 
 *** Thank you for Songs https://audiotrimmer.com/royalty-free-music/ ***
 *** Thank you for image files https://www.pexels.com/ ***
 
 
 https://prakash78blog.wordpress.com/2021/04/27/turn-your-raspberry-pi-4b-into-a-sound-box-and-control-using-blazor/
 
