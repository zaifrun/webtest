using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson02.Models {
    public class Dice {
        private int eyes;

        private int numRolls;
        public int NumRolls {
            get { return numRolls; }
        }

        private int outcome;
        public int Outcome {
            get { return outcome; }
        }

        private int totalSum;
        public int TotalSum {
            get { return totalSum; }
        }

        private int[] distribution;
        public int[] Distribution {
            get { return distribution; }
        }


        public Dice() {
            eyes = 6;
            numRolls = 0;
            totalSum = 0;
            distribution = new int[eyes];
        }

        public void Roll() {
            Random randNum = new Random();
            outcome = randNum.Next(1, eyes+1);
            numRolls++;
            totalSum += outcome;
            distribution[outcome-1]++;
        }
    }

}