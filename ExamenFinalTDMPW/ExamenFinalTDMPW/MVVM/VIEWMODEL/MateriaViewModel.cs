using System;
using PropertyChanged;
using ExamenFinalTDMPW.MVVM.MODEL;
using System.Windows.Input;
namespace ExamenFinalTDMPW.MVVM.VIEWMODEL
{
    [AddINotifyPropertyChangedInterface]
    public class MateriaViewModel
	{
		public Materia Materia { get; set; }

		public MateriaViewModel()
		{
		}
	}
}

