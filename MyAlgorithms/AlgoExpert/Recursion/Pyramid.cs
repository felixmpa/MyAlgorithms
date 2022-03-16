using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithms.AlgoExpert.Recursion
{
    public class Pyramid
    {

        /*
         * NON-RECURSIVE
         * 
         *     *
         *    * *
         *   * * * 
         *  * * * * 
         */

        public void Method1(int n)
        {
            for(int i = 1; i <= n; i++)
            {

                for(int space = 0 ; space <= (n-i); space++)
                {
                    Console.Write(" ");
                }

                int asterisk = n - (n-i);
                while (asterisk != 0)
                {
                    Console.Write("* ");
                    asterisk--;
                }

                Console.WriteLine();
            }
        }


        public void Method2(int n, int aux = 1)
        {

            if (n > 0)
            {
                char space = ' ';
                char asterisk = '*';

                //repeat space left (n-1) position
                Console.Write(new string(space, (n-1)));

                if(aux==1)
                {
                    aux = n;
                    Console.Write(asterisk);
                }
                else
                {
                    Console.Write(new string(asterisk, (aux - n + 1)));
                }
                
                Console.WriteLine(); 
                
                Method2(n - 1, aux + 1);
            }
        }


        public void Method3(int n, int num = 0)
        {
            if (n > 0)
            {
                Console.Write(new string(' ', (n - 1)));
         
                if(n==num)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(new string('*', (num - n + 1)));
                }

                Console.WriteLine();
                Method3(n - 1, num + 1);
            }
        }



    }
}
