
#region Stream

//zaposuvanje i cianje bolje 
//pogolema kontrola poefikasno e podobar performans i povekje opcii ima kako se cita kako da se podeli
//vo pincip rabota so file sstem e skapa operacija
// teski operacii

//primeri za strem



Console.WriteLine("========== Reading and Writing with Streams ==========");

//zapisuvame writer
//citame     reader

//prvo patekata na folder dali ima nema potoa fileot isto taka dali go ima nema

//SETUP
string folderPath = @"..\..\..\TestFiles";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
}

string fileName = "notes.txt";
string filePath = Path.Combine(folderPath, fileName);

Console.WriteLine("========== StreamWriter ==========");

try
{
    using (StreamWriter streamWriter = new StreamWriter(filePath))
    {
        streamWriter.WriteLine("This is a sample note.");
        streamWriter.WriteLine("StreamWriter lets us write text line by line efficiently");
        streamWriter.WriteLine("It also allows you to append OR overwrite");
    }
    
    using (StreamWriter streamWriter = new StreamWriter(filePath,true))//so true pravime append t.e. nema da gi prebrise prethodnite tuku kje si gi pise ovie pod prvite 3
    {
        streamWriter.WriteLine("NEW This is a sample note.");
        streamWriter.WriteLine("NEW StreamWriter lets us write text line by line efficiently");
        streamWriter.WriteLine("NEW It also allows you to append OR overwrite");
    }
    
    //ja prakjame patekata do file kade sto treba da zapise
    //istite mozeme da gi uoptrebime vo using odnostno
    //releases
    //koga kje wrapneme nekoj resurs vo string koga kje zavrsime so operacijata fileot avtomatski se zatvora konekcijata


}
catch (Exception ex)
{
    Console.WriteLine("Error writing in file. Error: "+ex.Message);
}


//fileWrite i streamWrite pogolema kontrola 
//podobro se menadzira i pooptimalno e so stream


Console.WriteLine("========== Strem Reader ==========");


try
{ 
    using(StreamReader streamReader = new StreamReader(filePath, true))
    {
        //si se deli delce po delce za da pobrzo da se procesira
        Console.WriteLine("Reading file content using StreamReader: \n");

        //string firstLine = streamReader.ReadLine();
        //Console.WriteLine("First Line: " + firstLine);
        //string secondLine = streamReader.ReadLine();
        //Console.WriteLine("Second Line: " + secondLine);

        string line = string.Empty;
        while ((line=streamReader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }

        string restContent = streamReader.ReadToEnd();
        Console.WriteLine("Rest of content " + restContent);
    
    }
}
catch (Exception ex)
{
    Console.WriteLine("Error reading in file. Error: " + ex.Message);
}


#endregion