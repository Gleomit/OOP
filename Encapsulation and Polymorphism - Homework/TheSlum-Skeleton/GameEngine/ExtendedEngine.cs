using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.GameEngine
{
    using Interfaces;

    public class ExtendedEngine : Engine
    {
        public ExtendedEngine()
        {
            timeoutItems = new List<Bonus>();
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            if (GetCharacterById(inputParams[2]) == null)
            {
                Team team = (inputParams[5] == "Red" ? Team.Red : Team.Blue);
                switch (inputParams[1])
                {
                    case "mage":
                        this.characterList.Add(new Mage(inputParams[2], Int32.Parse(inputParams[3]),
                            Int32.Parse(inputParams[4]), team));
                        break;
                    case "warrior":
                        this.characterList.Add(new Warrior(inputParams[2], Int32.Parse(inputParams[3]),
                            Int32.Parse(inputParams[4]), team));
                        break;
                    case "healer":
                        this.characterList.Add(new Healer(inputParams[2], Int32.Parse(inputParams[3]),
                            Int32.Parse(inputParams[4]), team));
                        break;
                    default:
                        Console.WriteLine("The character class you specified does not exists!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Another character already exists with this ID!");
            }
        }

        public new void AddItem(string[] inputParams)
        {
            Character thePlayer = GetCharacterById(inputParams[1]);
            if (thePlayer != null)
            {
                switch (inputParams[2])
                {
                    case "pill":
                        Pill pill = new Pill(inputParams[3]);
                        thePlayer.AddToInventory(pill);
                        timeoutItems.Add(pill);
                        break;
                    case "injection":
                        Injection injection = new Injection(inputParams[3]);
                        thePlayer.AddToInventory(injection);
                        timeoutItems.Add(injection);
                        break;
                    case "axe":
                        thePlayer.AddToInventory(new Axe(inputParams[3]));
                        break;
                    case "shield":
                        thePlayer.AddToInventory(new Shield(inputParams[3]));
                        break;
                    default:
                        Console.WriteLine("The item you specified does not exists!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Player with this id does not exists!");
            }
        }

        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "status":
                    PrintCharactersStatus(characterList);
                    break;
                case "add":
                    if (inputParams.Length != 4)
                    {
                        Console.WriteLine("Not enought or too much parameters for this command!");
                    }
                    else
                    {
                        AddItem(inputParams);
                    }
                    break;
                case "create":
                    if (inputParams.Length != 6)
                    {
                        Console.WriteLine("Not enought or too much parameters for this command!");
                    }
                    else
                    {
                        CreateCharacter(inputParams);
                    }
                    break;
                default:
                    Console.WriteLine("The command you specified does not exists");
                    break;
            }
        }
    }
}
