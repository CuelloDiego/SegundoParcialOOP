using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.Core
{
    public class PlanillaNotas
    {

        private List<Nota> Notas { get; set; }


        public PlanillaNotas(IDataSource notas)
        {
            Notas = notas.GetNotas();
        }

        public IEnumerable<Nota> GetAll() 
        { 
            return Notas; 
        }


        public double SumNotas()
        {
            double sum = 0;
            foreach (Nota nota in Notas)
            {
                
                   sum += nota.Calificacion;
            }



            return sum;
        }


        public int CantNotas()
        {
            int q = 0;
            foreach (var item in Notas)
            {

                q +=1;
            }
            return q;
        }

        public double PromNotas()
        {
            
            int q = CantNotas();
            double sum=SumNotas();

            return sum/q;
        }

        public string GetNotaByLegajo(string legajo)
        {

            string? found = Notas.Where(x => x.Legajo == legajo).ToString();

            if (found is not null)
            {
                return found;
            }
            return "No encontrado";
            
        }





    }
}
