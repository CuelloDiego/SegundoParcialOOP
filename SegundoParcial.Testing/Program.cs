using SegundoParcial.DataMock;
using SegundoParcial.Core;
using SegundoParcial;

IDataSource dataSource = new DataSource();

PlanillaNotas planilla = new PlanillaNotas(dataSource);



foreach (var item in planilla.GetAll())
{
    Console.WriteLine("Legajo: "+item.Legajo);
    Console.WriteLine("Calificacion: " + item.Calificacion);
    Console.WriteLine("Curso: " + item.Curso);
    Console.WriteLine("Division: " + item.Division);
}