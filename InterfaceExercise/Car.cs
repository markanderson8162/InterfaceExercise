using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
	public class Car : IVehicle, ICompany
	{
		public bool IsElectric { get; set; }
		public bool IsSportsCar { get; set; }
		public string Name { get; set; }
		public int NumberOfDealerships { get; set; }

		public int HeadLights { get; set; }
		public bool SeatBelts { get; set; }
		public bool SteeringWheel { get; set; }
		public int Wheels { get; set; }
	}
}
