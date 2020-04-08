using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz032
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DrakeEquation(bornStarNum: 10, hasPlanetProb: 5, habitablePlanetNum: 2, bornLivesProb: 100, 
                                acquireIntelligenceProb: 0.01, communicateInterstellarProb: 0.01, communicatableYears: 10000));
        }

        static double DrakeEquation(int bornStarNum, double hasPlanetProb, double habitablePlanetNum, double bornLivesProb,
                                    double acquireIntelligenceProb, double communicateInterstellarProb, int communicatableYears)
        {
            return bornStarNum * hasPlanetProb * habitablePlanetNum * bornLivesProb * acquireIntelligenceProb 
                    * communicateInterstellarProb * communicatableYears;
        }
    }
}
