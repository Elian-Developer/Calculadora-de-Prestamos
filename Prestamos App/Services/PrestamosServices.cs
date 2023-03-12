using Prestamos_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_App.Services
{
    public class PrestamosServices
    {
        public static double CalculoDeCuotas(PrestamosViewModel pmv)
        {
            double porcentaje = pmv.TasaPrestamo / 100f;
            double Interes = porcentaje * pmv.monto;
            double Total = Interes + pmv.monto;
            double TotalCuota = Total / pmv.Periodo;

            return Math.Round(TotalCuota, 2);

        }
    }
}
