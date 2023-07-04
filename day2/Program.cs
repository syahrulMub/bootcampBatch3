using System;
using RaketMaker;

namespace MainProgram;
class Program
{
    static void Main()
    {
        Raket Lining = new Raket("Lining");
        Lining.Smash(10, "precise");
        Raket Yonex = new Raket ("Yonex");
        Yonex.Smash(14, "good");
        Yonex.DropShot("good");
        Raket Hiqua = new Raket ("Hiqua");
        Hiqua.Smash(9, "bad");
        Hiqua.DropShot("enought");
    }
}