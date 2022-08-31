using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bezao_TestApp_Anyanwaokoro
{
    internal class Number2WordConverter
    {
        string[] Units = new string[9] {"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        string[] DoubleUnits = new string[10] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        string[] Tens = new string[8] {  "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
       // string[] Hundreds = new string[9] { "One Hudred", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };


        public string Convert2Words(int number)
        {
            string convertedWord = "";

            if(number.ToString().Length == 1)
            {
                convertedWord = Units[number - 1];
            }

            if (number.ToString().Length == 2)
            {
              //  convertedWord = " Double ";
                int firstDigit = int.Parse(number.ToString().Substring(0,1));
                int lastDigit = int.Parse(number.ToString().Substring(1,1));


                if (firstDigit == 1)
                {
                    if (lastDigit == 0)
                    {
                        convertedWord = DoubleUnits[firstDigit - 1].ToString();
                    }
                    else
                    {
                        convertedWord = DoubleUnits[lastDigit].ToString();
                    }
                }
                else {
                    if (lastDigit == 0)
                    {
                        convertedWord = Tens[firstDigit - 2];
                    }
                    else
                    {
                    convertedWord = Tens[firstDigit - 2] + " " + Units[lastDigit - 1].ToString();
                    }

                   
                }
            
            }


            if (number.ToString().Length == 3)
            {
               
                int firstDigit = int.Parse(number.ToString().Substring(0, 1));
                int secondDigit = int.Parse(number.ToString().Substring(1, 1));
                int lastDigit = int.Parse(number.ToString().Substring(2, 1));

                convertedWord = Units[firstDigit - 1] + " hundred and ";
                
                if (secondDigit == 1)
                {
                    convertedWord = convertedWord +  DoubleUnits[lastDigit - 1].ToString();
                }
                else
                {
                    if(lastDigit == 0)
                    {
                        convertedWord = convertedWord + Tens[secondDigit - 2];
                    }
                    else
                    {
                        convertedWord = convertedWord + Tens[secondDigit - 2] + " " + Units[lastDigit - 1].ToString();
                    }

                   
                }

            }


            if (number.ToString().Length == 4)
            {

                int firstDigit = int.Parse(number.ToString().Substring(0, 1));
                int secondDigit = int.Parse(number.ToString().Substring(1, 1));
                int thirdDigit = int.Parse(number.ToString().Substring(2, 1));
                int lastDigit = int.Parse(number.ToString().Substring(3, 1));

                convertedWord = Units[firstDigit - 1] + " thousand, " +  Units[secondDigit - 1] + " hundred and ";

                if (thirdDigit == 1)
                {
                    convertedWord = convertedWord + DoubleUnits[lastDigit - 1].ToString();
                }
                else
                {
                    if (lastDigit == 0)
                    {
                        convertedWord = convertedWord + Tens[thirdDigit - 2];
                    }
                    else
                    {
                        convertedWord = convertedWord + Tens[thirdDigit - 2] + " " + Units[lastDigit - 1].ToString();
                    }

                    
                }

            }
            if (number.ToString().Length == 5)
            {

                int firstDigit = int.Parse(number.ToString().Substring(0, 1));
                int secondDigit = int.Parse(number.ToString().Substring(1, 1));
                int thirdDigit = int.Parse(number.ToString().Substring(2, 1));
                int fourthDigit = int.Parse(number.ToString().Substring(3, 1));
                int lastDigit = int.Parse(number.ToString().Substring(4, 1));

           
                if (firstDigit == 1)
                {
                    if (secondDigit == 0)
                    {
                        convertedWord = DoubleUnits[0] + " thousand, " + Units[secondDigit - 1] + " hundred and ";

                    }
                    else
                    {
                        convertedWord = DoubleUnits[secondDigit - 1] + " thousand, " + Units[secondDigit - 1] + " hundred and ";

                    }

                                    
                }
                else
                {
                    convertedWord = Tens[firstDigit - 1] + " " + Units[secondDigit - 1] + " hundred and ";

                }


                if (thirdDigit == 1)
                {
                    convertedWord = convertedWord + DoubleUnits[lastDigit - 1].ToString();
                }
                else
                {
                    if (lastDigit == 0)
                    {
                        convertedWord = convertedWord + Tens[thirdDigit - 2];
                    }
                    else
                    {
                        convertedWord = convertedWord + Tens[thirdDigit - 2] + " " + Units[lastDigit - 1].ToString();
                    }


                }

            }



            return convertedWord;
        }

    }
}
