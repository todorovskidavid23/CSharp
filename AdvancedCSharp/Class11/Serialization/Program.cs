//Serialization
//pretvaranje na objekt vo json gile
//od json vo c#objekt desrialization


//imame json file
//fomat gereralno prifaten za primenuvanje na http JSON
//fomat text so strict fomat
//{
//"key": Value,
//"key": "String Value",
//}

//dva procesi
//serializacija od c3 objekt vo JSON file 
//preveduvanje 
//Deserializacija od JSON file vo C# obcet vo Student 

//biblioteka no postoi i popolularno Instalira nie da instalirame
//external library vo nasiot proekt
//node packet manager mendziranje na paketi vo js file
//istoto go imame vo C# vo .NET svet NuGet Package
//site biblioteki sto ni pomagaat vo .NET sVETOT
//Newtinsift.Json


using Serialization;

void WriteInFile(string path, string text)
{
    using (StringWriter sw = new StringWriter(path))
    {
        sw.WriteLine(text);
    }
}
string ReadFromFile(string path, string text)
{
    using (StringReader sr = new StringReader(path))
    {
        return sr.ReadToEnd();
    }
}

Student bob = new Student()
{
    FirstName = "Bob",
    LastName = "Bobsky",
    Age = 33,
    IsPartTime = false
};

WriteInFile


string directoryPath = @"..\..\..\OurData";
string filePath = Path.Combine(directoryPath, "myFirstJson.json");

#region Manual Serialization/Deserialization

if (!Directory.Exists(directoryPath)) 
{
    Directory.CreateDirectory(directoryPath);
}



#endregion