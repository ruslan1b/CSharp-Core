using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCore
{
    class Task2
    {
        enum TestCaseStatus 
        { 
            Pass,
            Fail,
            Blocked,
            Wp,
            Unexecuted
        };

        struct RGB
        {
            public byte red;
            public byte green;
            public byte blue;

            public RGB(byte a, byte b, byte c)
            {
                red = a;
                green = b;
                blue = c;
            }

            public void Info()
            {
                Console.WriteLine($"RGB: red: {red}, green {green}, blue {blue}.");
            }
        }

        enum HTTPError 
        {
            Success = 200, 
            Permanentredirect = 301,
            TemporaryRedirect = 302,
            NotModified = 304,
            UnauthorizedErrror = 401,
            Forbidden = 403,
            NotFound = 404,
            MethodNotAllowed = 405,
            NotImplemented = 501,
            BadGatewey = 502,
            ServiceUnavailable = 503,
            GatewayTimeout = 504
        };

        public void DemoTask2()
        {
            try
            {
                /*
                Identify enum TestCaseStatus (Pass, Fail, Blocked, WP, Unexecuted).
                Assign status “Pass” for the variable  test1Status and print the value of the variable console.
                 */
                var test1Status = TestCaseStatus.Pass;
                Console.WriteLine(test1Status);
                Console.WriteLine("****************\n");

                /*
                 Determine RGB structure that represents the color with fields red, green, blue (type byte).
                Identify two variables of this type and enter their fields for white and black colors.
 
                 */
                RGB white = new RGB(255, 255, 255);
                RGB black = new RGB(0, 0, 0);

                white.Info();
                black.Info();
                Console.WriteLine("****************\n");

                /*                 
                In method Main() write code for solving next task:
                read number of HTTP Error (400, 401,402, ...)
                and write the name of this error (Declare enum HTTPError)
                 */
                Console.WriteLine(" Enter HTTPError");
                
                int error = Convert.ToInt32(Console.ReadLine());

                switch(error)
                {
                    case 200:
                        Console.WriteLine($"HTTP Error {error}: Succes/OK");
                        break;
                    case 301:
                        Console.WriteLine($"HTTP Error {error}: Permanent Redirect");
                        break;
                    case 302:
                        Console.WriteLine($"HTTP Error {error}: Temporary Redirect");
                        break;
                    case 304:
                        Console.WriteLine($"HTTP Error {error}: Not Modified");
                        break;
                    case 401:
                        Console.WriteLine($"HTTP Error {error}: Unauthorized Error");
                        break;
                    case 403:
                        Console.WriteLine($"HTTP Error {error}: Forbidden");
                        break;
                    case 404:
                        Console.WriteLine($"HTTP Error {error}: Not Found");
                        break;
                    case 405:
                        Console.WriteLine($"HTTP Error {error}: Method Not Allowed");
                        break;
                    case 501:
                        Console.WriteLine($"HTTP Error {error}: Not Implemented");
                        break;
                    case 502:
                        Console.WriteLine($"HTTP Error {error}: Bad Gateway");
                        break;
                    case 503:
                        Console.WriteLine($"HTTP Error {error}: Service Unavailable");
                        break;
                    case 504:
                        Console.WriteLine($"HTTP Error {error}: Gateway Timeout");
                        break;
                }

                /*
                 declare struct Dog with fields Name, Mark, Age.
                Declare variable myDog of Dog type and read values for it.
                Output myDos into console.
                (Declare method ToString in struct)
                */

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
