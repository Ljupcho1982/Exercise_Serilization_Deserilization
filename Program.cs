using Exercise_Serilization_Deserilization;
using Newtonsoft.Json;

List<Employee> One = new List<Employee>()
{

    new Employee()
    {

    Id=1, Name="Ljupcho", Address="Zadrugarska br.10", Position="Head of Department", Suordinared=new List<Employee>(){
    new Employee()
    {

        Id=2,
        Position="Advisor",

        Address="Vostanichka",

        Name="Maja",



    }

    } },

 new Employee()
    {

    Id=2, Name="Petko", Address="Car Dushan br.10", Position="Head of Department", Suordinared=new List<Employee>(){
    new Employee()
    {

        Id=2,
        Position="Associate",

        Address="Vostanichka",

        Name="Trajche",



    }

    } }






};

string json = JsonConvert.SerializeObject(One);

Console.WriteLine(json);



// serialize JSON to a string and then write string to a file
File.WriteAllText(@"C:\Vezhbi_Full_Stack - Boban\Vezhbi C#\20.05.2023\proba2.json", JsonConvert.SerializeObject(One));

// serialize JSON directly to a file
using (StreamWriter file = File.CreateText(@"C:\Vezhbi_Full_Stack - Boban\Vezhbi C#\20.05.2023\proba2.json"))
{
    JsonSerializer serializer = new JsonSerializer();
    serializer.Serialize(file, One);
}







