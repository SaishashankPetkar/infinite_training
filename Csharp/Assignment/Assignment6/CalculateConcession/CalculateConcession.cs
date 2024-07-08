using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateConcession
{
    public class CalculateConcession
    {
        public string Calculateconcession(int age,double fare)
        {
            if(age <= 5)
            {
                return "Little Champ - Free Ticket";
            }
            else if(age > 60)
            {
                double concessionfare = fare-(fare*0.30);
                return $"Senior Citizen - Calculated Fare is : {concessionfare}";
            }
            else
            {
                return $"Ticket Booked - Fare: {fare}";
            }
        }
    }
}
