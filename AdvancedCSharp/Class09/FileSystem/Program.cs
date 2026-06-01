//File System
#region Intro
//kako ni se organizirani nasite folderi

//File system nacin naorganizira cuva manipulira data na storaged lokacii ssd usb
// file system nacin nakoj e orgaiziran podatocite na nekoi storage device
//definira kako se imenuva pateki iminja koj kako moze da gi pristapi seto toa spagja vo file system
//zs e koristen zapisuvanje citanje na fileovi, sekage se // zacuvuvanje na data
//dopolnuvanje na data log, configuraciski constraints parametri tie si se cuvaat vo nekoj file
//generiranje reports koj i da e domain kako rabori biznisot, da si vidat kako tece biznis REPORTS ima file system
//Za procesiranje na Data Import podatoci i da si sezacuvaat vo bazi
// Upload input input type typrot e File constraints kakvi extentions se koristat
// se cuva i procesira pak si se koristi read and write za privemeno zacuvuvanje na podatoci

//znacen del e FileSystem
//System IO input/ouput
//directory info file info ,path CLASSI sto ima staticki metodi za da rabotime so file system

#endregion

#region Paths
//sto se pateki
//kade moze da se locira vo toj file system
//zavisi kakva e patekata

//absolute Path celostna pateka 
using System.Net;
using System.Xml;

string studentRepoClassFullPath = @"C:\Users\code\Desktop\David\CSharpAvenga\AdvancedCSharp\Class09";

//a do file treba da go piseme imeto na fileot
string studentRepoHomeworkClassFullPath = @"C:\Users\code\Desktop\David\CSharpAvenga\AdvancedCSharp\Class09\Homework.md";
//ako imame extenstion toa e file ako nemame toa e folder

//osnovata na driver C: pa taka nataka

//Relative Paths pocnuva spored onamu kade sto se izvrsuva palikacijata tamu kade sto se naogja kodot
string classReadmeRelativePath = @"..\..\..\..\..\..\README.md";
//mestoto kade sot se runnuva aplikacijata e vo BIN kako sto kazavme vo RECAPOT
//vo bin se naogja .exe fileot

#endregion



#region Directory
string currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine($"Current Directory: {currentDirectory}");//ja dava do .exe fileot

string testFolderPath = @"..\..\..\TestFolder";

bool testFoderExists = Directory.Exists(testFolderPath);
Console.WriteLine("The folder 'Test Fololder' exists: {0}",testFoderExists);


if (!testFoderExists)
{
    Directory.CreateDirectory(testFolderPath);
    Console.WriteLine("Succesfully created folder TestFolder");
}
else
{
    Console.WriteLine("TestFolder already exists!");
}


//Delete a folder
if (Directory.Exists(testFolderPath))
{
    //Directory.Delete(testFolderPath);//ako ne e empty kje frli exeption
    Directory.Delete(testFolderPath, recursive: true);//stavame rekurcija za da izbrise se sto ima bnatre
}

#endregion

#region File
Console.WriteLine("========== File ==========");
// check if a file exists

testFolderPath = @"..\..\..\TestFolder";
string fileName = "example.txt";

//string filePath = $@"{testFolderPath}\{fileName}";
string filePath = Path.Combine(testFolderPath, fileName);//namesto + concat concatanacija
//samo si pravi \ vo zavisnot od operativniot system

bool fileExists = File.Exists(filePath);

if (!Directory.Exists(testFolderPath))//mora da go imam ova deka gore mi se brise folderot
{
    Directory.CreateDirectory(testFolderPath);
}


if (!fileExists)
{
    File.Create(filePath).Close();
    //Se zatvara konekcijata i posle Create mozam da pristapam do fileot
    //SAMO EDEN PROCES MORA DA SE IZVRSUVA MORA DA SE KORISTI SAMO EDEN PROCES KOGA PRAVIME CREATE SE PRAVI KONEKCIJA DO TOJ FILE AKO NE SE ZATVORI NE MOZE DA SE PRITAPI OD DUGO MESTO
    //FileStream stream = File.Create(filePath);
    //stream.Close();
}
else
{
    Console.WriteLine("File aready exists!");
}


//======> Delete a file <=======

//if (File.Exists(filePath))
//{
//    File.Delete(filePath);
//}
//else
//{
//    Console.WriteLine("Succesfully deleted file 'example.tst' .");
//}



//Write in File

//kade zapisuvame,sto zapisuvame;
File.WriteAllText(filePath, "Hello from SEDC :)"); //ova kje se izbrise ako ima neso pod nego OVERWRITTEN
File.WriteAllText(filePath, "Hello from SEDC again :)\n");
//AKO NE SAKAME DA GO PREBRISEME PRETHODNOTO
File.AppendAllText(filePath, "Hello From Avenga Academy");



//Read from a File
string fileContent = File.ReadAllText(filePath);
Console.WriteLine("File content:\n");
Console.WriteLine(fileContent);


//Get File Info
//kolkav e fileot kako se vika fileot extenstion itn
FileInfo fileInfo = new FileInfo(filePath);

Console.WriteLine("\nThe file's info :");

Console.WriteLine("Full name : "+ fileInfo.FullName);
Console.WriteLine("File name : "+ fileInfo.Name);
Console.WriteLine("File extension : "+ fileInfo.Extension);
Console.WriteLine("File size in bytes : "+ fileInfo.Length +" bytes");//vo bytes
Console.WriteLine("Last modified : "+ fileInfo.LastWriteTime);


Console.WriteLine(fileInfo);



#endregion