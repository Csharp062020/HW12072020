using System;

namespace HomeWorks
{
    class Citizen
    {
        public static int _lastIDWeHave=0;
        public string _name;
        public Citizen[] _children;
        public readonly int _fatherID;
        public readonly int _id= IDCreatorAndCitizenCounter();
        public static int _numberOfCurrentCitizens=0;
        public const int _maximumNumberOfCitizens=3;

        public static int IDCreatorAndCitizenCounter()
        {
            _lastIDWeHave += 8;
            _numberOfCurrentCitizens++;
            return _lastIDWeHave;

        }
        public Citizen(string _name, int _fatherID)
        {
            this._name = _name;
            this._fatherID = _fatherID;
        }

        public static void PrintNumberOfCitizens()
        {
            Console.WriteLine($"number of citizen : {_numberOfCurrentCitizens}");
        }

        public static bool ReachedHakfOfMaximumSize()
        {
            return (_numberOfCurrentCitizens >= _maximumNumberOfCitizens);
        }

        public void PrintID()
        {
            Console.WriteLine($"ID : {_id}");
        }

        public void PrintGapBetweenMyIDAndFather()
        {
            Console.WriteLine($"Gap Between My ID ({_id}) And Father ID ({_fatherID}) is: {_id-_fatherID}");
        }
        
        public void SetChildren(Citizen[] citizensArray)
        {
            _children = citizensArray;
        }

        public override string ToString()
        {
            string children="";
            if (_children != null)
            {
                for (int i = 0; i < _children.Length; i++)
                {
                    children = $"{children} {_children[i]._id}";
                }
            }
            else
            {
                children = "No Children";
            }

            return $"{base.ToString()} Name: {_name} , Children IDs: {children} , Father ID {_fatherID} , ID {_id} , Number of current citizens {_numberOfCurrentCitizens} , Max Citizens : {_maximumNumberOfCitizens}";
        }
    }
}
