using System;
using PropertyChanged;
namespace ExamenFinalTDMPW.MVVM.MODEL
{
    [AddINotifyPropertyChangedInterface]

    public class Semestre
	{
        public string NombreMateria { get; set; }
        public int ValorUno { get; set; }
        public int ValorDos{ get; set; }
        public int ValorTres { get; set; }
        public double CalificacionUno { get; set; }
        public double CalificacionDos { get; set; }



        public Semestre()
		{
		}

        
	}
}

