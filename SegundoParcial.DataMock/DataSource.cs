using SegundoParcial.Core;

namespace SegundoParcial.DataMock
{
    public class DataSource : IDataSource
    {
       
        public List<Nota> GetNotas()
        {
            List<Nota> notas = new List<Nota>()
            {
                new Nota(){Legajo="1",Curso=2, Division=1, Calificacion=10},
                 new Nota(){Legajo="2",Curso=2, Division=2, Calificacion=2},
                  new Nota(){Legajo="3",Curso=3, Division=5, Calificacion=6},
                   new Nota(){Legajo="4",Curso=3, Division=4, Calificacion=9},
                    new Nota(){Legajo="5",Curso=4, Division=3, Calificacion=8},
                     new Nota(){Legajo="6",Curso=42, Division=2, Calificacion=2},
                      new Nota(){Legajo="7",Curso=5, Division=1, Calificacion=9}

            };




            return notas;
        }
    }
}