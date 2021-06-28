using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int Wheels { get; set; }
		public bool SteeringWheel { get; set; }
		public int HeadLights { get; set; }
		public bool SeatBelts { get; set; }

	}
}
