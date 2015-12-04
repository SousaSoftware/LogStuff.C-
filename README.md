# SousaSoft.LogStuff.CSharp
C# AutoIncremental LogReader/LogWritter (Net.FrameWork 4.5.1)

Usage:

Add the DLL to your project References

Add using SousaSoft.LogStuff; on beginnig of your file

Use

string path;

path = Application.StartupPath + "\\Log.txt";

SousaSoft.LogStuff.Log.LogFile = path; //in order to save in LaunchPath with name Log (Just an example)

Use SousaSoft.LogStuff.Log.Header = Environment.NewLine & " MYAPP LOG .... "; //in order to add an header to the start of log (this will only add on first time the file is created)

Use SousaSoft.LogStuff.Log.Add("Text"); // order to add text in your log. Edit Text for your Text :D

Use

string path;

path = Application.StartupPath + "\\Log.txt";

SousaSoft.LogStuff.LogViewer.LogFile = path; //in order to load from LaunchPath with name Log (Just an example)

Use SousaSoft.LogStuff.LogViewer.CurrentLog; // in order to get current log in some richtextbox or some data stream

Check ExampleApp to have a simple overview

Any questions you can send me an email to sousasoftware2010@gmail.com
