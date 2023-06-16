using System;
using PropertyChanged;
namespace ExamenFinalTDMPW.MVVM.MODEL
{
	[AddINotifyPropertyChangedInterface]
	public class Materia
	{
        //Poner nombre de la materia
        public string NombreMateria { get; set; }
        public string NombrePrimerRubro { get; set; }
        public string NombreSegundoRubro { get; set; }
        public string NombreTercerRubro { get; set; }
		public int PorcentajePrimerRubro { get; set; }
        public int PorcentajeSegundoRubro { get; set; }
        public int PorcentajeTercerRubro { get; set; }
		public double PrimerCalificacion { get; set; }
		public double SegundaCalificacion { get; set; }
		public double TercerCalificacion { get; set; }

        public Materia()
		{
		}

        public double CalcularCalificacionFinal()
        {
            double calificacion = 0;
            if (string.IsNullOrEmpty(NombreMateria) || string.IsNullOrEmpty(NombrePrimerRubro) || string.IsNullOrEmpty(NombreSegundoRubro)
                || string.IsNullOrEmpty(NombreTercerRubro))
            {

                App.Current.MainPage.DisplayAlert("Campos vacíos.", "Revisa los campos de nombre de la materia o rubros, pueden que esten vacíos.", "OK");
                return calificacion = 0;
            }
            else
            {

                if ((PorcentajePrimerRubro + PorcentajeSegundoRubro + PorcentajeTercerRubro == 100) && (PrimerCalificacion >= 0 && SegundaCalificacion <= 10 && SegundaCalificacion >= 0 && SegundaCalificacion <= 10 && TercerCalificacion >= 0 && TercerCalificacion <= 10))
                {
                    double calificacionPrimerRubro = (PorcentajePrimerRubro / 100) * PrimerCalificacion;
                    double calificacionSegundoRubro = (PorcentajeSegundoRubro / 100) * SegundaCalificacion;
                    double calificacionTercerRubro = (PorcentajeTercerRubro / 100) * TercerCalificacion;

                    calificacion = calificacionPrimerRubro + calificacionSegundoRubro + calificacionTercerRubro;
                    return Math.Round(calificacion, 2);
                }
                else
                {
                    App.Current.MainPage.DisplayAlert("BE CAREFUL.", "🔴 ", "OK");
                    return calificacion = 0;
                }
            }

        }
    }
}

