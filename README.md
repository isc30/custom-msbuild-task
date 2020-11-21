# custom-msbuild-task
 Test Repository to test custom MsBuild tasks in .net5.
 
### Following the tutorial from:
https://docs.microsoft.com/en-us/visualstudio/msbuild/task-writing?view=vs-2019#tasks

### Error:
```
Severity	Code	Description	Project	File	Line	Suppression State
Error	MSB4018	The "TestTask" task failed unexpectedly.
System.IO.FileNotFoundException: Could not load file or assembly 'System.Runtime, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The system cannot find the file specified.
File name: 'System.Runtime, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
   at CustomTask.TestTask.Execute()
   at Microsoft.Build.BackEnd.TaskExecutionHost.Microsoft.Build.BackEnd.ITaskExecutionHost.Execute()
   at Microsoft.Build.BackEnd.TaskBuilder.<ExecuteInstantiatedTask>d__26.MoveNext()

WRN: Assembly binding logging is turned OFF.
To enable assembly bind failure logging, set the registry value [HKLM\Software\Microsoft\Fusion!EnableLog] (DWORD) to 1.
Note: There is some performance penalty associated with assembly bind failure logging.
To turn this feature off, remove the registry value [HKLM\Software\Microsoft\Fusion!EnableLog].
	TaskConsumer	E:\projects\custom-msbuild-task\TaskConsumer\TaskConsumer.csproj	13	
```
