using System;
using System.Globalization;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //  Pega uma data com início em 01/01 e hr 00:00 quando não especificado
            // var data = new DateTime(2020, 10, 12, 8, 32, 14);
            // var data = DateTime.Now;
            //  Pega a data e hora atual ^^

            // var data = DateTime.Now;
            // Formata a hora e data da forma que escolher
            // var formatada = String.Format("{0:dd/MM/yyyy hh:mm:ss}", data);
            // var formatada = String.Format("{0:d}", data);
            // var formatada = String.Format("{0:D}", data);
            // var formatada = String.Format("{0:f}", data);
            // var formatada = String.Format("{0:g}", data);
            // var formatada = String.Format("{0:r}", data);
            // var formatada = String.Format("{0:s}", data);
            // var formatada = String.Format("{0:u}", data);

            // Console.WriteLine(data);

            // Globalizar a data: Formatar para local desejado
            // var br = new CultureInfo("pt-BR");
            // var pt = new CultureInfo("pt-PT");
            // var en = new CultureInfo("en-UK");
            // var atual = CultureInfo.CurrentCulture;
            // Console.WriteLine(DateTime.Now.ToString("d", br));
            // Console.WriteLine(DateTime.Now.ToString("D", atual));
            // Console.WriteLine(string.Format("{0:D}", DateTime.Now));

            // Colocar o Timezone
            // var utcDate = DateTime.UtcNow;

            // Console.WriteLine(DateTime.Now);
            // Console.WriteLine(utcDate);

            // Console.WriteLine(utcDate.ToLocalTime());

            // var timezoneAustralia =
            //     TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            // Console.WriteLine(timezoneAustralia);

            // var timezones = TimeZoneInfo.GetSystemTimeZones();
            // foreach (var timezone in timezones)
            // {
            //     Console.WriteLine(timezone.Id);
            //     Console.WriteLine(timezone);
            //     Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
            //     Console.WriteLine("_____________");
            // }

            // Colocar timespan

            // var timeSpan = new TimeSpan();
            // Console.WriteLine(timeSpan);

            // var timeSpanNanosegundos = new TimeSpan(1);
            // Console.WriteLine(timeSpanNanosegundos);

            // var timeSpanHoraMinutoSegundos = new TimeSpan(5, 12, 8);
            // Console.WriteLine(timeSpanHoraMinutoSegundos);


            //  Adicionar dias, mês, anos a mais ou a menos
            // Console.WriteLine(data.AddDays(12));
            // Console.WriteLine(data.AddYears(1));
            // Console.WriteLine(data.AddMonths(1));


            // Adiciona a formatação específica da data
            // Console.WriteLine(data.Year);
            // Console.WriteLine(data.Month);
            // Console.WriteLine(data.Day);
            // Console.WriteLine(data.Hour);
            // Console.WriteLine(data.Minute);
            // Console.WriteLine(data.Second);
            // Console.WriteLine(data.DayOfYear);
            // Console.WriteLine((int)data.DayOfWeek);

            // Console.WriteLine(formatada);

            Console.WriteLine(DateTime.DaysInMonth(2020, 2));
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());

        }

        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }

    }
}