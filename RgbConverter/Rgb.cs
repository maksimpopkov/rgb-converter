using System;
using System.IO;

namespace RgbConverter
{
    public static class Rgb
    {
#pragma warning disable SA1625 // Element documentation should not be copied and pasted
        /// <summary>
        /// Gets hexadecimal representation source RGB decimal values.
        /// </summary>
        /// <param name="red">The valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="green">The valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="blue">The valid decimal value for RGB is in the range 0-255.</param>
        /// <returns>Returns hexadecimal representation source RGB decimal values.</returns>
        public static string GetHexRepresentation(int red, int green, int blue)
#pragma warning restore SA1625 // Element documentation should not be copied and pasted
        {
            if (red > 255)
            {
                red = 255;
            }

            if (red < 0)
            {
                red = 0;
            }

            if (green > 255)
            {
                green = 255;
            }

            if (green < 0)
            {
                green = 0;
            }

            if (blue > 255)
            {
                blue = 255;
            }

            if (blue < 0)
            {
                blue = 0;
            }

            string theHexColor = $"{red:X2}{green:X2}{blue:X2}";
            return theHexColor;   
        }
    }
}
