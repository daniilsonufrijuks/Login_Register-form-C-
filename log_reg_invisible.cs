/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
// using Regex;
// using Match;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Sandbox

{
    class Program
    {
        public static List<string> names = new List<string>();
        public static List<string> paroles = new List<string>();
        
        // public static ArrayList names = new ArrayList();
        // public static ArrayList paroles = new ArrayList(); 

        public static int name_ex = 0;
        public static int parole_ex = 0;
        public static int count = 0;
        // --------------------------------
        static void Login()
        {
            //Console.Write(names);
            Console.Write("name - ");
            string user_input_name = "";
        
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                
                if (key.Key != ConsoleKey.Enter)
                {
                    user_input_name += key.KeyChar;
                    Console.Write("*");
                }
            } while (key.Key != ConsoleKey.Enter);
            
            
            Console.WriteLine();
            
            
            Console.Write("parole - ");
            string user_input_parole = "";
            
            do
            {
                key = Console.ReadKey(true);
                
                if (key.Key != ConsoleKey.Enter)
                {
                    user_input_parole += key.KeyChar;
                    Console.Write("*");
                }
            } while (key.Key != ConsoleKey.Enter);
            
            
            bool nameExists = names.Contains(user_input_name);
            bool paroleExists = paroles.Contains(user_input_parole);
            
            
            Console.WriteLine();
            
            if (names.Count == 0)
            {
                Console.WriteLine("Invalid");
            } else {
                // foreach (var i in names)
                // {
                //      if (user_input_name != i)
                //     {
                //         Console.WriteLine("Invalid name");
                //         flag_log = 0;
                //     }
                //     else
                //     {
                //         Console.WriteLine("yes");
                //     }
                // }
                
                // foreach (var i in paroles)
                // {
                //      if (user_input_parole != i)
                //     {
                //         Console.WriteLine("Invalid parole");
                //         flag_log = 0;
                //     }
                //     else
                //     {
                //         Console.WriteLine("yes");
                //     }
                // }
                
                if (nameExists)
                {
                    Console.WriteLine("yes");
                    name_ex = 1;
                }
                else
                {
                    Console.WriteLine("Invalid name");
                    name_ex = 0;
                }
            
                if (paroleExists)
                {
                    Console.WriteLine("yes");
                    parole_ex = 1;
                }
                else
                {
                    Console.WriteLine("Invalid parole");
                    parole_ex = 0;
                }
                
                if (nameExists)
                {
                    if (!paroleExists)
                    {
                        count++;
                    }
                }
                
                // if (name_ex != 0)
                // {
                //     if (parole_ex == 1)
                //     {
                //         if (count == 3)
                //         {
                //             Console.WriteLine("Your akk was banned, please write message to admin");
                //         }
                //     }
                // }
                
                if (count == 4)
                {
                    Console.WriteLine("Your akk was banned, please write message to admin");
                }
            }
            
            // for (int i = 0; i < names.Count; i++)
            // {
            //     if (user_input_name == names[i])
            //     {
            //         Console.WriteLine("Invalid name");
            //         flag_log = 0;
            //     }
            //     else
            //     {
            //         Console.WriteLine("yes");
            //     }
            // }

            // for (int i = 0; i < paroles.Count; i++)
            // {
            //     if (user_input_parole != paroles[i])
            //     {
            //         Console.WriteLine("Invalid parole");
            //         flag_log = 0;
            //     }
            //     else
            //     {
            //         Console.WriteLine("yes");
            //     }
            // }
        }
        // --------------------------------
        static void Register()
        {
            Console.Write("name - ");
            string user_input_name = Console.ReadLine();
            Console.Write("parole - ");
            string user_input_parole = Console.ReadLine();
            
            bool nameExists = names.Contains(user_input_name);
            bool paroleExists = paroles.Contains(user_input_parole);
            

            // names.Add(user_input_name);
            // paroles.Add(user_input_parole);
            
            if (names.Count == 0)
            {
                names.Add(user_input_name);
                if (user_input_parole.Length < 6)
                    {
                        Console.WriteLine("Invalid parole, we can not save your parole because of the len < ");
                    }
                    else if (user_input_parole.Length > 20)
                    {
                        Console.WriteLine("Invalid parole, we can not save your parole because of the len > ");
                    } else {
                        //string regexPattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).{8,14}$";
                        string regexPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$";
                        Regex regex = new Regex(regexPattern);
                        string inputString = user_input_parole;
                        Match match = regex.Match(inputString);
        
                        if (match.Success)
                        {
                            paroles.Add(user_input_parole);
                        } else
                        {
                            Console.WriteLine("Invalid parole syntax");
                        }
                    }
                //names.Add(user_input_name);
                //paroles.Add(user_input_parole);
            } else
            {
            
                if (nameExists)
                {
                    Console.WriteLine("Name has already been registered");
                }
                else
                {
                    names.Add(user_input_name);
                }
            
                if (paroleExists)
                {
                    Console.WriteLine("Parole has already been registered");
                }
                else
                {
                    //paroles.Add(user_input_parole);
                    if (user_input_parole.Length < 6)
                    {
                        Console.WriteLine("Invalid parole, we can not save your parole because of the len < ");
                    }
                    else if (user_input_parole.Length > 20)
                    {
                        Console.WriteLine("Invalid parole, we can not save your parole because of the len > ");
                    } else {
                        string regexPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$";
                        Regex regex = new Regex(regexPattern);
                        string inputString = user_input_parole;
                        Match match = regex.Match(inputString);
        
                        if (match.Success)
                        {
                            paroles.Add(user_input_parole);
                        } else
                        {
                            Console.WriteLine("Invalid parole syntax");
                        }
                    }
                }
                
                // foreach (var i in names)
                //     {
                //         if (user_input_name == i)
                //         {
                //             Console.WriteLine("Name have registered");
                //             flag_log = 0;
                //         }
                //         else
                //         {
                //             Console.WriteLine("yes");
                //             names.Add(user_input_name);
                //         }
                //     }
                    
                //     foreach (var i in paroles)
                //     {
                //         if (user_input_parole == i)
                //         {
                //             Console.WriteLine("Parole have registered");
                //             flag_log = 0;
                //         }
                //         else
                //         {
                //             Console.WriteLine("yes");
                //         }
                //     }
    
            }
        }
        
        static void Clear()
        {
            names.Clear();
            paroles.Clear();
        }
        
        static void Show()
        {
            foreach (var i in names)
            {
                Console.WriteLine(i);
            }
            
            foreach (var i in paroles)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            // -------------------------------- 
            Console.WriteLine("Login/Register algorithm");
            Console.WriteLine("Enter name, parole; Register if have no form, log in if have...");
    
            string user_choice = Console.ReadLine();

            while (user_choice != "0")
            {
                user_choice = Console.ReadLine();
                switch (user_choice)
                {
                    case "login":
                        Login();
                        break;
                    case "register":
                        Register();
                        break;
                    case "clear":
                        Clear();
                        break;
                    case "show":
                        Show();
                        break;
                }
            
            }
        }
    }
}