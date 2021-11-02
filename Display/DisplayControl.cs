using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RaspberryPiNetCore.LCD;
using RaspberryPiNetCore.TWIST;

namespace Display
{
	public class DisplayControl
	{
		SerLCD lcd1 = new SerLCD();
		TWIST twist1 = new TWIST();
		private BatteryStatus _batteryStatus = new BatteryStatus();

		public void BeginMainMenu() 
		{
			lcd1.lcdDisplay();
			lcd1.lcdPrint("Hovedmenu:");
			lcd1.lcdGotoXY(0, 1);
			lcd1.lcdPrint(" Nulpunktsjustering");
			lcd1.lcdGotoXY(3, 0);
			lcd1.lcdPrint("Batteristatus: " + "85" + "%");
			lcd1.lcdGotoXY(1, 0);
			lcd1.lcdBlink();
			while (twist1.isPressed() == false) 
			{
				
			}

		}

		public void ZeroAdjustment()
		{

			lcd1.lcdClear();
			lcd1.lcdGotoXY(0, 0);
			lcd1.lcdPrint("Nulpunktsjustering:");
			lcd1.lcdGotoXY(0, 1);
			lcd1.lcdPrint("1.Drej transducerens");
			lcd1.lcdGotoXY(2, 2);
			lcd1.lcdPrint("hane");
			lcd1.lcdGotoXY(3, 0);
			lcd1.lcdPrint("2.Tryk Enter");
			while (twist1.isPressed() == false)
			{

			}
			//Start nulpunktsjustering.
			lcd1.lcdClear();
			lcd1.lcdGotoXY(0, 0);
			lcd1.lcdPrint("Nulpunktsjustering:");
			lcd1.lcdGotoXY(0, 2);
			lcd1.lcdPrint("Nulpunktsjustering  foretaget!");
			//Nedenstående for loop sørger for blink.
			for (int i = 0; i < 3; i++)
			{
				lcd1.lcdSetBackLight(100, 30, 30);
				Thread.Sleep(500);
				lcd1.lcdSetBackLight(0, 100, 0);
				Thread.Sleep(500);
			}

			//Skal retur til hovedmenu herefter.

		}
		
		//Vi skal have en tråd der hele tiden opdaterer batteristatus. 
		// Tænker nulpunktjustering - det tryk vi får ind skal gemmes i en attribut, som atmoPressure


		


	}
}
