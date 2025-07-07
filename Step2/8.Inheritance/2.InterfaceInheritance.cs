using InterfaceInheticanceBasics;

namespace InterfaceInheticanceBasics
{
    interface Interface1
    {
        int Property1 { get; set; }

        int int_method1();

        string str_Method1();

        string str_Method1(int a, int b);

    }

    interface Interface3
    {
        string str_method3();
    }


    interface interface2 : Interface1 , Interface3
    {
        string str_method4();   //rules
    }
}




//interface2// 