using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Engine.Models
{
    public class Colour
    {
        /// 
        /// Properties
        ///

        // private
        private int _red;
        private int _green;
        private int _blue;

        // public getters and setters
        public int Red 
        {
            get { return _red; }
            set
            {
                assertValueInBounds(value, GlobalConstants.RValue);
                
                _red = value;
            }
        }
        public int Green 
        {
            get { return _green; }
            set
            {
                assertValueInBounds(value, GlobalConstants.GValue);

                _green = value;
            }
        }
        public int Blue 
        {
            get { return _blue; }
            set
            {
                assertValueInBounds(value, GlobalConstants.BValue);

                _blue = value;
            }
        }


        /// 
        /// Constructor
        /// 
        public Colour(int red = 0, int green = 0, int blue = 0)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }


        ///
        /// Methods
        ///

        // Assertions
        private static void assertValueInBounds(int value, string valueName)
        {
            Assertions.Assert(value >= GlobalConstants.LowerBound, $"{valueName} is less than {GlobalConstants.LowerBound}");
            Assertions.Assert(value <= GlobalConstants.UpperBound, $"{valueName} is greater than {GlobalConstants.UpperBound}");
        }

        // Equivalence operators
        public static bool operator ==(Colour c1, Colour c2)
        {
            return c1.Red == c2.Red && c1.Green == c2.Green && c1.Blue == c2.Blue;
        }
        public static bool operator !=(Colour c1, Colour c2)
        {
            return !(c1 == c2);
        }

        // Accuracy calculators
        public static float CheckColourGuessAccuracy(Colour guess, Colour target)
        {
            return (CheckRGBValueGuessAccuracy(guess._red, target._red)
                  + CheckRGBValueGuessAccuracy(guess._green, target._green)
                  + CheckRGBValueGuessAccuracy(guess._blue, target._blue)) 
                  / 3;
        }
        public static float CheckRGBValueGuessAccuracy(int guess, int target)
        {
            float guessf = (float) guess;
            float targetf = (float) target;
            float upperBoundf = (float) GlobalConstants.UpperBound;

            // returns accuracy as a decimal number, not a percentage
            return (upperBoundf - Math.Abs(guessf - targetf)) / upperBoundf;
        }
    }
}
