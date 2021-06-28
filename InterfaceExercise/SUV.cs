using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
		public int NumberOfSeats { get; set; }
		public string Name { get; set; }
		public int NumberOfDealerships { get; set; }

		public int HeadLights { get; set; }
		public bool SeatBelts { get; set; }
		public bool SteeringWheel { get; set; }
		public int Wheels { get; set; }
	}
}
