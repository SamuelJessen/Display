using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display
{
	class BatteryStatus
	{
		private ADCInput _adc = new ADCInput();



		public int getBatteryPercentage()
		{
			//double voltage = _adc.getVoltage();


			return 85;
		}


		//Batteristatus funktionalitet:
		//Mål batterispænding (batteri-klasse) 
		// if (batteri < 20%)
		// rød farve 
		//else grøn farve 
		

	}
}
