﻿// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Reading and Writing data from and to files

// Make sure the example file exists
const string filename = "TestFile.txt";

// TODO 1: WriteAllText overwrites a file with the given content
if (!File.Exists(filename)) {
    File.WriteAllText(filename, "This is application programming.\n");
}

// TODO 3: AppendAllText adds text to an existing file
File.AppendAllText(filename, "300 Level Second Semester Course.\n");


// TODO 4: A FileStream can be opened and written to until closed
using (StreamWriter sw = File.AppendText(filename)){
    sw.WriteLine("Ashley");
    sw.WriteLine("Amarikwa");
    sw.WriteLine("9400");
}


// TODO 2: ReadAllText reads all the content from a file
string content;
content = File.ReadAllText(filename);
Console.WriteLine(content);
