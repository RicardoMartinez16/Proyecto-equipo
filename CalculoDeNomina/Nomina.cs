using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculoDeNomina
{
    public class Nomina
    {
        private int diasLaborados;
        private int seguro_medico;
        private int horas_extra;
        private string fecha;

        public int DiasLaborados { get; set; }
        public int Seguro_medico { get; set; }
        public int Horas_extra { get; set; }
        public string Fecha { get; set; }


        //Metodo para calcular la nomina

        public decimal CalculoDeNomina(int diastrab, decimal pagoxdia, int horas_ex, int seguro)
        {
            horas_ex = horas_ex * 100;

            decimal TotalSalario = (diastrab * pagoxdia) + horas_ex;
            TotalSalario = TotalSalario - seguro;

            return TotalSalario;
        }
    }
}
