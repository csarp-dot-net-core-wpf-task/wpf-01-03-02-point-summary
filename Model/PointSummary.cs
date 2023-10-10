using System;
using System.Collections.Generic;
using System.Text;

namespace oop.Model
{
    /// <summary>
    /// Diák felvételi pontszámának meghatározása
    /// </summary>
    class PointSummary
    {
        /// <summary>
        /// Felvételiző diák neve;
        /// </summary>
        private string name;
        /// <summary>
        /// Matematika pontszám
        /// </summary>
        private int mathScore;
        /// <summary>
        /// Anyanyelvi pontszám
        /// </summary>
        private int nativeLanguageScore;
        /// <summary>
        /// Konstrktor
        /// </summary>
        /// <param name="mathScore">Matemtika pontszám</param>
        /// <param name="nativeLanguageScore">Anyanyelvi pontszám</param>
        public PointSummary(int mathScore, int nativeLanguageScore)
        {
            this.mathScore = mathScore;
            this.nativeLanguageScore = nativeLanguageScore;
        }
        
        /// <summary>
        /// Felvételiző neve tulajdonság
        /// </summary>
        public string Name
        {
        }

        /// <summary>
        /// Matematika pontszám tulajdonság
        /// </summary>
        public int MathScore
        {
        }
        /// <summary>
        /// Anyanyelvi pontszám tulajdonság
        /// </summary>
        public int NativeLanguageScore
        {

        }

        /// <summary>
        /// Matematikai és anyanyelvi pontok átlaga
        /// </summary>
        public double AverageScore
        {
            get
            {
                double averageScore = (mathScore + nativeLanguageScore) / 2;
                double roundedAvarageScore = Math.Round(averageScore, 2);
                return roundedAvarageScore;
            }
        }
        /// <summary>
        /// Matematikai és anyagelvi pontok összege
        /// </summary>
        public int TotalScore
        {

        }
        /// <summary>
        /// Matematikai, anyanyelvi, összpontszám és átlag pontszám szöveges formátumban
        /// </summary>
        /// <returns></returns>
        public string Score
        {
            get
            {
                string output = "Matematika pontszám : " + mathScore + '\n' + "Anyanyelv pontszám: " + nativeLanguageScore +
                                 '\n' + "Összpontszám: " + TotalScore + '\n' + "Átlag pontszám: " + AverageScore;
                return output;
            }
        }
    }

}
