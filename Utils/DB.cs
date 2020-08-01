using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem.Utils
{
    class DB
    {
        public static String dbString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "FitnessCenter.mdf;Integrated Security=True;Connect Timeout=30";
    }
}
