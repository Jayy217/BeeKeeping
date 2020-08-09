using System;
using System.Collections.Generic;

namespace Bee_Keeping {
    class Program {
        static void Main (string[] args) {

            List<int> BeeHives = new List<int> ();
            BeeHives.Add (4);
            BeeHives.Add (3);
            int beeHiveCount = 2;

            Bee b1 = new Bee ("John", 3.2);
            Bee b2 = new Bee ("Paul", 2.7);
            Bee b3 = new Bee ("George", 1.1);
            Bee b4 = new Bee ("Ringo", 2.0);
            Bee b5 = new Bee ("Kurt", 2.3);
            Bee b6 = new Bee ("Dave", 7.4);
            Bee b7 = new Bee ("Krist", 1.5);

            Menu ();
            int userChoice = int.Parse (Console.ReadLine ());

            while (userChoice != 4) {
                
                if (userChoice == 1) {
                    int addBees = 0;
                    beeHiveCount++;

                    System.Console.WriteLine ("===============================");
                    System.Console.WriteLine ("Beehive #" + beeHiveCount + " has been created!");

                    for (int i = 0; addBees != 2; i++) {
                        System.Console.WriteLine ("===============================");
                        System.Console.WriteLine ("Would you like to add a bee?");
                        System.Console.WriteLine ("1. Yes");
                        System.Console.WriteLine ("2. No, I'm finished with this hive");
                        addBees = int.Parse (Console.ReadLine ());

                        if (i == 5) {
                            System.Console.WriteLine ("Sorry, this hive has reached its maximum number of bees at 5 bees.");
                            BeeHives.Add (5);
                            break;
                        } else if (addBees == 1) {
                            System.Console.WriteLine ("===============================");
                            System.Console.WriteLine ("A bee has been added, this hive now has " + (i+1) + " bee(s).");
                        } else if (addBees == 2) {
                            BeeHives.Add (i);
                        }
                    }
                }
                if (userChoice == 2) {
                    
                    System.Console.WriteLine ("In which beehive?");
                  
                    int hiveCollecting = int.Parse (Console.ReadLine ());
                   
                    System.Console.WriteLine ("How many days is beehive #" + hiveCollecting + " collecting honey for?");
                 
                    int daysCollecting = int.Parse (Console.ReadLine ());
                    CollectHoney (hiveCollecting, daysCollecting);
                }
                if (userChoice == 3) {
                    System.Console.WriteLine ("Which beehive # are we checking?");
                    int hive = int.Parse (Console.ReadLine ());
                    
                    System.Console.WriteLine ("===============================");
                    System.Console.WriteLine ("Beehive #" + hive + " has " + BeeHives[hive - 1] + " bees.");
                    
                }
                Menu ();
                userChoice = int.Parse (Console.ReadLine ());
            }

        }
        class Bee {
            public string Name;
            public double Size;

            public Bee (string name, double size) {
                this.Name = name;
                this.Size = size;
            }
        }
        static void Menu () {
            System.Console.WriteLine ("===============================");
            System.Console.WriteLine ("What would you like to do?");
            System.Console.WriteLine ("===============================");
            System.Console.WriteLine ("1. Create a beehive");
            System.Console.WriteLine ("2. Collect honey");
            System.Console.WriteLine ("3. Check how many bees there are");
            System.Console.WriteLine ("4. Exit");
            System.Console.WriteLine ("===============================");
        }
        static void CollectHoney (int i, int x) {
            System.Console.WriteLine ("===============================");
            System.Console.WriteLine ("Beehive #" + i + " is collecting honey for " + x + " day(s).");
        }
    }
}
