using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModel
{
    public class Session
    {
        /// 
        /// Properties
        /// 
        private static readonly Random _generator = new Random();

        public Colour CurrentColourGuess { get; set; }
        public Colour CurrentColourTarget { get; set; }


        /// 
        /// Constructor
        /// 
        public Session()
        {
            CurrentColourGuess = new Colour();
            CurrentColourTarget = GenerateRandomColour();
        }


        ///
        /// Methods
        ///
        public Colour GenerateRandomColour(int minRed = 0, int maxRed = 255,
                                           int minGreen = 0, int maxGreen = 255,
                                           int minBlue = 0, int maxBlue = 255)
        {
            return new Colour(_generator.Next(minRed, maxRed + 1),
                              _generator.Next(minGreen, maxGreen + 1),
                              _generator.Next(minBlue, maxBlue + 1));
        }
    }
}
