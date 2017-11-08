using System;

namespace AssemblyCSharp
{
	public interface PowerUpController
	{
		void SpeedUp();
		void SlowDown();
		void Inverse();
		void resetInverse();
		void resetSpeed();
	}
}

