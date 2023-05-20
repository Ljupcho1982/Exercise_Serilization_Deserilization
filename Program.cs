using Exercise_Serilization_Deserilization;
using System.Xml.Serialization;



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

XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));

using (TextWriter writer = new StreamWriter(@"C:\Vezhbi_Full_Stack - Boban\Vezhbi C#\20.05.2023\primer.xml"))
{

    serializer.Serialize(writer, One);





}

using (FileStream fileStream = new FileStream(@"C:\Vezhbi_Full_Stack - Boban\Vezhbi C#\20.05.2023\primer.xml", FileMode.Open))
{

    List<Employee>? emp = serializer.Deserialize(fileStream) as List<Employee>;

    if (emp != null)
    {
        foreach (Employee employee in emp)
        {

            var under = employee.Suordinared;

            foreach (Employee employee1 in under)
            {

                Console.WriteLine($"{employee.Name} has under  {employee1.Name} employee");

            }

        }



    }








}




