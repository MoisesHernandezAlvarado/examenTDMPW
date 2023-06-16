using System;
using ExamenFinalTDMPW.MVVM.MODEL;
using PropertyChanged;

namespace ExamenFinalTDMPW.MVVM.VIEWMODEL
{
    [AddINotifyPropertyChangedInterface]

    public class SemestreViewModel
	{
		public Semestre Semestre { get; set; }

		public SemestreViewModel()
		{
		}
	}
}

