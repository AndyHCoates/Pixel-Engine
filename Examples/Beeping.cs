using System;
using PixelEngine;

namespace Examples
{
	public class Beeping : Game
	{
		// Precalculate Two Pi or Tau
		private const float Tau = (float)Math.PI * 2;

		static void Main(string[] args)
		{
			Tester t = new Tester(); // Create an instance
			t.Construct(); // Construct the app
			t.Start(); // Start the app
		}

		// Enable the sound system
		public override void OnCreate() => EnableSound = true;

		// Override to generate sound in real time
		// This is generating a sin wave
		public override float OnSoundCreate(int channels, float globalTime, float timeStep) => Sin(globalTime * 440 * Tau) / 2;

		// Override to filter sound output
		// This is zeroing sound at periodic times to make it sound like beeping
		public override float OnSoundFilter(int channels, float globalTime, float sample) => sample * Sin(globalTime * Tau);
	}
}