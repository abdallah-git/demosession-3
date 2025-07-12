


using System.Xml;

namespace demosession_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region fractions and discard 

            // float myfloat = 10.123456789f;
            // Console.WriteLine(myfloat);


            // double mydouble = 10.123456789;
            //Console.WriteLine(mydouble);


            // decimal mydesimal = 10.123456789123145647899m;
            // Console.WriteLine(mydesimal); 




            //long number = 10_000_000_000;
            //Console.WriteLine($"{number:c} ");


            //Var caltureinfo = new cultureinfo();
            //Console.WriteLine(number.ToString("c,caltureinfo") ;

            #endregion


            #region casting 
            #region impilicit and explicit casting 
            #region example01 


            //int X = 1000;// 4 bytes 
            //long y = X; // 8 bytes 
            //Console.Write(y); // implicit casting 




            //long A = 10000000;
            //int B = (int)A; // explicit casting 
            //Console.WriteLine(B); 


            //checked
            //{
            //  //  long A = 10000000;
            //    //int B = (int)A; // explicit casting
            //    unchecked
            //    {
            //        //Console.WriteLine(B); 

            //    }
            //}



            //long A = 10000000;
            //if (A > int.MaxValue or A<int.minvalue )
            //    {
            //        Console.WriteLine (" Exception is not throw" ) ; 
            //    }

            //// else 
            //{
            //    / int B = (int)A; // explicit casting 
            //                      //Console.WriteLine(B); 

            //}
            #endregion
            #endregion
            #endregion


            #region example02 

            //int x = 10;
            //decimal y = x;
            //Console.WriteLine(y);


            //decimal k = 10.100m;
            //int m = (int)k;
            //Console.WriteLine(m);

            #endregion





            //#region convert 
            //Console.WriteLine("please enter your data ");


            //Console.Write("name : ");
            //String name = Console.ReadLine();


            //Console.Write("age : ");
            //int age = Convert.ToInt32(Console.ReadLine());


            //Console.Write("salary : ");
            //decimal salary = Convert.ToDecimal(Console.ReadLine());


            //Console.Clear();


            //Console.WriteLine("data : ");
            //Console.WriteLine("age is " + age);
            //Console.WriteLine("name is " + name);
            //Console.WriteLine("salary  is " + salary );

            //#endregion 




            //#region parse 

            //Console.WriteLine("please enter your data ");


            //Console.Write("name : ");
            //String name = Console.ReadLine();


            //Console.Write("age : ");
            //int age = int.Parse(Console.ReadLine());


            //Console.Write("salary : ");
            //decimal salary = decimal.Parse(Console.ReadLine());


            //Console.Clear();


            //Console.WriteLine("data : ");
            //Console.WriteLine("age is " + age);
            //Console.WriteLine("name is " + name);
            //Console.WriteLine("salary  is " + salary);


            //#endregion




            //#region tryparse 




            //Console.WriteLine("please enter your data ");


            //Console.Write("name : ");
            //String name = Console.ReadLine();


            //Console.Write("age : ");
            //int age = int.TryParse(Console.ReadLine() , out age );


            //Console.Write("salary : ");
            //decimal salary = decimal.TryParse(Console.ReadLine(), out salary);


            //Console.Clear();


            //Console.WriteLine("data : ");
            //Console.WriteLine("age is " + age);
            //Console.WriteLine("name is " + name);
            //Console.WriteLine("salary  is " + salary);


            //#endregion 





            #region operators 
            #region unary operators 

            //int x = 10  ; 
            //1.++
            //1.1 prefix [ increment then print ] 
            //console.writeline ( ++x) ; //11
            //console.writeline ( x) ; //11


            //1.2 postfix [ print then increment]
            //console.writeline ( x++) ; //10
            //console.writeline ( x) ; //11


            //2.1-- prfix [ decrement then print ] 

            //console.writeline (-- x) ; //9
            //console.writeline ( x) ; //9


            //2.2 postfix [ print then decrement ] 
            //console.writeline ( x--) ; //10
            //console.writeline ( x) ; //9

            #endregion


            #region binary operators [ +,-,/,*,% ] 
            //int sumresult , subresult, mulresult , divresult , modresult ; 

            //int number01 = 13 , number 02 = 10 ; 

            // sumresult  = number01 + number 02 //8 
            //subresult = number01 - number 02 // 4
            //mulresult = number01 * number 02 // 12
            //divresult= number01 / number 02 // 3
            //modresult= number01 % number 02 // 3

            #endregion



            #region assignment operators 
            //int x; 
            //    x+=2//x+2
            //    x-=2//x-2
            //    x/=2//x/2
            //    x*=2//x*2
            //    x%=2//x%2

            #endregion



            #region relational operators 

            //int x = 10 , y = 5 ; 
            // console.writeline ( x==y ) ; // true 
            // console.writeline ( x!=y ) ; // false
            //  console.writeline ( x<=y ) ; // false 
            // console.writeline ( x>=y ) ; // false 
            // console.writeline ( x<y ) ; // true 
            // console.writeline ( x>y ) ; // true 

            #endregion





            #region logical operators 
            //// short circuit 
            //Console.WriteLine(!true); // false 
            //Console.WriteLine(false&&true); // false 
            //// true && true = true
            //// true &&false = false 
            ////false && true =false 
            ////false && false =false 




            //// short circuit 
            //Console.WriteLine(!true); // false 
            //Console.WriteLine(false||true); // true 
            //// true || true = true
            //// true ||false = true 
            ////false || true =true 
            ////false || false =false 
            ///

            #endregion





            #region bitwise operator 
            // long circuit 
            //console.writeline ( false | true ) = true 
            //console.writeline ( false & true ) = false 
            //console.writeline ( false ^true ) = true 


            ///int x = 5 ,y=3 ; // 1010 , 0011 
            ///(x&y) ; // 1 ( 1010 & 0011 ) = 0001 
            //  (x|y) ; // 7 ( 1010 | 0011 ) = 0111
            //  (x^y) ; // 6 ( 1010 ^ 0011 ) = 0110
            //  (x) ; // -6 ( 1010 | 0011 ) = 1010
            //  (x<<1) ; // 10 ( 1010 <<  1 ) = 0111 
            //  (x>> 1 ) ; // 2  ( 1010 >> 1  ) = 0010 

            #endregion






            #region ternary operators 
            //  int x = 10, y = 5;
            //  string message = x > y ? "x>y " : "x<y ";
            //  Console.WriteLine(message
            //);
            //  #endregion



            #region operators priorty 
            //  int a = 20;
            //  int b = 30;
            //  int c = 10;
            //  int d = 5;
            //  int result;

            //  result = (a + b) * c / d; // 35*10/5 
            //  result = ((a + b) * c)  / d; // 35*10/5 
            //  result = (a + b) * c / d++ ; // 35*10/5 


            #endregion
            #endregion



            #region string formatting 


            ////Equation : 12 + 5 = 17 
            //int z = 12, y = 5;
            //int result = z + y; 

            //string message = $" Equation : {z} + { y} = { result } ";
            //Console.WriteLine(  message ); 


            //int z = 12, y = 5;
            //int result = z + y; 
            //string message = string .Format ("Equation: { 0}
            //+ { 1} = { 2 }" , z , y , result  ) ; 




            //int z = 12, y = 5;
            //int result = z + y;
            //Console.WriteLine("Equation : {0} + {1}  = {result}  ", z, y, result); 
               


            #endregion 

































        }
    }
}
