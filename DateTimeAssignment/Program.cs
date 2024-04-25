using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                DateTime dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
                DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm:ss",null);
                TimeSpan span = date-dob;
                Console.WriteLine((int)span.TotalDays/365);
                Console.WriteLine(dob.DayOfWeek);
                Console.WriteLine(span.TotalDays);
                Console.WriteLine(span.TotalHours);
                Console.WriteLine(span.TotalMinutes);
            }
        }
            