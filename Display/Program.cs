using RaspberryPiNetCore.ADC;
using RaspberryPiNetCore.JoySticks;
using RaspberryPiNetCore.LCD;
using RaspberryPiNetCore.TWIST;
using System;
using Display;


namespace Raspberry_Pi_Dot_Net_Core_Console_Application3
{
	class Program
	{
		

		static void Main(string[] args)
		{
			DisplayControl display1 = new DisplayControl();

			display1.BeginMainMenu();



		}
	}
}
