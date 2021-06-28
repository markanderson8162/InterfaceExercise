using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
		public double BedSize { get; set; }
		public bool IsDesiel { get; set; }
		public string Name { get; set; }
		public int NumberOfDealerships { get; set; }

		public int HeadLights { get; set; }
		public bool SeatBelts { get; set; }
		public bool SteeringWheel { get; set; }
		public int Wheels { get; set; }
	}
}
