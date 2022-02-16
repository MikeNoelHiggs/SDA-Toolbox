using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NHS_Toolbox
{
    internal static class Generator
    {
        private static DateTime currentDateTime = DateTime.Now;
        private static string? codeAD;
        private static string? codeNHSMail;
        private static string? codePin;
        private static int counter = 0;
        private static BindingList<String> history = new BindingList<String>();
        

        public static void SetCurrentDateAndTime()
        {
            currentDateTime = DateTime.Now;
        }

        public static string GenerateADCode()
        {
            SetCurrentDateAndTime();
            codeAD = currentDateTime.Day.ToString("D2") + currentDateTime.Hour.ToString("D2") + currentDateTime.Minute.ToString("D2");
            codeAD = currentDateTime.ToString("MMM") + codeAD;
            return codeAD;
        }

        public static string GenerateNHSMailCode()
        {
            SetCurrentDateAndTime();
            codeAD = GenerateADCode();
            codeNHSMail = codeAD + "!";

            return codeNHSMail;
        }

        public static string GenerateTemporaryPin()
        {
            SetCurrentDateAndTime();
            codePin = currentDateTime.Month.ToString("D2") + currentDateTime.Hour.ToString("D2") + currentDateTime.Minute.ToString("D2");
            return codePin;
        }

        public static void IncCounter()
        {
            counter++;
        }

        public static void DecCounter()
        {
            counter--;

            if (counter < 0)
            {
                counter = 0;
            }
        }

        public static int GetCounter()
        {
            return counter;
        }

        public static void ResetCounter()
        {
            counter = 0;
        }

        public static void AddHistory(string historyItem)
        {
            history.Add(historyItem);
        }

        public static void ClearHistory()
        {
            history.Clear();
        }

        public static BindingList<String> GetHistory()
        {
            return history;
        }

        public static string PhoneticAlphabet(Button sender)
        {
            string phoneticWord;

            switch(sender.Text)
            {
                case "A": phoneticWord = "Alpha";
                    break;
                case "B":
                    phoneticWord = "Bravo";
                    break;
                case "C":
                    phoneticWord = "Charlie";
                    break;
                case "D":
                    phoneticWord = "Delta";
                        break;
                case "E":
                    phoneticWord = "Echo";
                    break;
                case "F":
                    phoneticWord = "Foxtrot";
                    break;
                case "G":
                    phoneticWord = "Golf";
                    break;
                case "H":
                    phoneticWord = "Hotel";
                    break;
                case "I":
                    phoneticWord = "India";
                    break;
                case "J":
                    phoneticWord = "Julliet";
                    break;
                case "K":
                    phoneticWord = "Kilo";
                    break;
                case "L":
                    phoneticWord = "Lima";
                    break;
                case "M":
                    phoneticWord = "Mike";
                    break;
                case "N":
                    phoneticWord = "November";
                    break;
                case "O":
                    phoneticWord = "Oscar";
                    break;
                case "P":
                    phoneticWord = "Papa";
                    break;
                case "Q":
                    phoneticWord = "Quebec";
                    break;
                case "R":
                    phoneticWord = "Romeo";
                    break;
                case "S":
                    phoneticWord = "Sierra";
                    break;
                case "T":
                    phoneticWord = "Tango";
                    break;
                case "U":
                    phoneticWord = "Uniform";
                    break;
                case "V":
                    phoneticWord = "Victor";
                    break;
                case "W":
                    phoneticWord = "Whiskey";
                    break;
                case "X":
                    phoneticWord = "X-Ray";
                    break;
                case "Y":
                    phoneticWord = "Yankee";
                    break;
                case "Z":
                    phoneticWord = "Zulu";
                    break;
                default: phoneticWord = ""; 
                    break;
            }

            return phoneticWord;

        }
        
    }
}
