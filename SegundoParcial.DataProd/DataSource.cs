using SegundoParcial.Core;

namespace SegundoParcial.DataProd
{

    public class DataSource : IDataSource
    {

        public List<Nota> GetNotas()
        {
            List<Nota> notas = new List<Nota>()
            {
                new Nota(){Legajo="10",Curso=2, Division=1, Calificacion=10},
                 new Nota(){Legajo="20",Curso=2, Division=2, Calificacion=2},
                  new Nota(){Legajo="30",Curso=3, Division=5, Calificacion=6},
                   new Nota(){Legajo="40",Curso=3, Division=4, Calificacion=9},
                    new Nota(){Legajo="50",Curso=4, Division=3, Calificacion=3},
                   new Nota(){Legajo="60",Curso=6, Division=2, Calificacion=8},
                    new Nota(){Legajo="70",Curso=7, Division=1, Calificacion=2},
                    new Nota(){Legajo="80",Curso=8, Division=4, Calificacion=5},
                    new Nota(){Legajo="90",Curso=9, Division=3, Calificacion=9},
                     new Nota(){Legajo="100",Curso=10, Division=2, Calificacion=1},
                      new Nota(){Legajo="110",Curso=35, Division=1, Calificacion=7}

            };




            return notas;
        }


    }
}