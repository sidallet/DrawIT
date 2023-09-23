using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{

    public class RGB
    {
        public byte red { get; set; }
        public byte green { get; set; }
        public byte blue { get; set; }

        /// <summary>
        /// Classe qui simule une couleur RGB
        /// </summary>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        public RGB(Int32 red, Int32 green, Int32 blue)
        {
            this.red = (byte)red;
            this.green = (byte)green;
            this.blue = (byte)blue;
        }
    }
}
