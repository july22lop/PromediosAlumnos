using PromediosAlumnos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromediosAlumnos.Negocios
{
    class NClsDatos
    {
        public string Calculo(ClsAlumno datos)
        {
            datos.Periodo1 = datos.Lab1 * 0.40 + datos.Parcial1 * 0.60;
            datos.Periodo2 = datos.Lab2 * 0.40 + datos.Parcial2 * 0.60;
            datos.Periodo3 = datos.Lab3 * 0.40 + datos.Parcial3 * 0.60;
            datos.Notafinal = (datos.Periodo1 + datos.Periodo1 + datos.Periodo1)/3;
            datos.Notafinal = Convert.ToDouble(datos.Notafinal);

            return "\nPeriodo 1: " + datos.Periodo1 + "\nPeriodo 2: " + datos.Periodo2 + "\nPeriodo 3: " + datos.Periodo3;

             
        }
    }
}
