using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {

            Citizen a = new Citizen("father", 0);
            Citizen b = new Citizen("levi1", a._id);
            Console.WriteLine($"status reach maximum ? : {Citizen.ReachedHakfOfMaximumSize()}  max {Citizen._maximumNumberOfCitizens} currect {Citizen._numberOfCurrentCitizens}");
            Citizen c = new Citizen("levi2", a._id);
            Console.WriteLine($"status reach maximum ? : {Citizen.ReachedHakfOfMaximumSize()}  max {Citizen._maximumNumberOfCitizens} currect {Citizen._numberOfCurrentCitizens}");
            Citizen d = new Citizen("levi3", a._id);
            Citizen e = new Citizen("levi Worng", 1);
            Console.WriteLine($"status reach maximum ? : {Citizen.ReachedHakfOfMaximumSize()}  max {Citizen._maximumNumberOfCitizens} currect {Citizen._numberOfCurrentCitizens}");

            Console.WriteLine();
            Citizen[] citizensArray = { b, c, d };
            Console.WriteLine($"{a._name}  has children: {HasChilldren(a)}");

            Console.WriteLine();
            Console.WriteLine(a.ToString());

            Console.WriteLine();
            a.SetChildren(citizensArray);
            Console.WriteLine($"set children to {a._name}");
            Console.WriteLine(a.ToString());
            Console.WriteLine($"{a._name}  has children: {HasChilldren(a)}");

            Console.WriteLine();
            Console.WriteLine($"now check validity of child to citizen {a._name}  is valid: {CheckValidity(a)}");

            Console.WriteLine();
            Console.WriteLine("set worng child to father id ");
            Citizen[] citizensArray1 = { b, c, d,e };
            a.SetChildren(citizensArray1);

            Console.WriteLine();
            Console.WriteLine($"now check validity of child to citizen {a._name}  is valid: {CheckValidity(a)}");

            Console.WriteLine();
            Citizen.PrintNumberOfCitizens();
            Citizen.ReachedHakfOfMaximumSize();
            a.PrintID();
            c.PrintGapBetweenMyIDAndFather();
            c.ToString();


        }
        static bool HasChilldren(Citizen citizen)
        {
            return citizen._children != null;
        }

        static bool CheckValidity(Citizen citizen)
        {
            if (HasChilldren(citizen))
            {
                for (int i = 0; i < citizen._children.Length; i++)
                {
                    if(citizen._children[i]._fatherID!=citizen._id)
                    {
                        return false;
                    }
                }
            }
            return true ;
        }
    }
}
