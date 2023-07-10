using System;

//ref link:https://www.youtube.com/watch?v=QnvdQgzives&list=PLRwVmtr-pp05brRDYXh-OTAIi-9kYcw3r&index=27
//

class MeBase { }
class MeMid : MeBase { }
class MeDerived : MeMid { }
class MeMoreDerived : MeDerived { }
class MeMegaDerived : MeMoreDerived { }

class Mainclass
{
    static void Main()
    {
        Type type = typeof(MeMegaDerived);
        while(type != null)
        {
            Console.WriteLine(type.Name);
            type = type.BaseType;
        }
    }
}