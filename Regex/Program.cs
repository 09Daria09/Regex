using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_
{
    internal class Program
    {
        public static bool IsPhoneNumber(string phoneNumber)
        {
            Regex phoneRegex = new Regex(@"^(\+?\d{1,3}-)?\d{2,3}-\d{2}-\d{2,3}$");
            return phoneRegex.IsMatch(phoneNumber);
        }
        public static bool IsEmail(string email)
        {
            Regex emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@gmail\.com$");
            return emailRegex.IsMatch(email);
        }
        public static bool IsIpAddress(string ipAddress)
        {
            string numberRange = @"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)";
            Regex ipAddressRegex = new Regex($"^{numberRange}\\.{numberRange}\\.{numberRange}\\.{numberRange}$");
            return ipAddressRegex.IsMatch(ipAddress);
        }
        public static int CountVowels(string vowels)
        {
            Regex regex = new Regex("[аеиоуыэюяАЕИОУЫЭЮЯ]");
            return regex.Matches(vowels).Count;
        }
        public static bool IsURL(string url) 
        {
            Regex urlRegex = new Regex(@"^(https?://)?([A-Za-z0-9-]+\.){1,2}[A-Za-z]{2,}(\/[A-Za-z0-9-._~:/?#[\]@!$&'()*+,;=%]*)?$");
            return urlRegex.IsMatch(url);
        }
        public static bool IsAlphanumeric(string alphanumeric)
        {
            Regex regex = new Regex("^[а-яА-Я0-9]+$");
            return regex.IsMatch(alphanumeric);
        }
        public static bool IsTime(string time)
        {
            Regex regex = new Regex(@"^(([01][0-9])|([2][0-3]))(:|\.)[0-5][0-9]((:|\.)[0-5][0-9])?$");
            return regex.IsMatch(time);
        }
        public static bool IsIndexUSA(string index)
        {
            Regex regex = new Regex(@"^\d{5}(?:-\d{4})?$");
            return regex.IsMatch(index);
        }
        static void Main(string[] args)
        {            
            Console.WriteLine($"IsPhoneNumber -> {IsPhoneNumber("+123-45-67-890")}");
            Console.WriteLine($"IsEmail -> {IsEmail("kristest@gmail.com")}");
            Console.WriteLine($"IsIpAddress -> {IsIpAddress("119.110.90.114")}");
            Console.WriteLine($"CountVowels -> {CountVowels("Я не знаю, что писать. Сегодня хороший день, солнышко светит, я люблю, когда светит солнышко, прям настроение поднимается")}");
            Console.WriteLine($"IsURL -> {IsURL(@"https://www.google.com")}");
            Console.WriteLine($"IsAlphanumeric -> {IsAlphanumeric("Гусь1232")}");
            Console.WriteLine($"IsTime -> {IsTime(@"12:33:22")}");
            Console.WriteLine($"IsIndexUSA -> {IsIndexUSA("12333")}");

        }
    }
}
