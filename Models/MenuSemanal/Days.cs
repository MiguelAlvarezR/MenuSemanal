using System.Collections.Generic;

namespace MenuSemanal.Models
{
    public class Days
    {
        public EnumDays Day { get; set; }

        public List<ThisngsToMeal> Meals { get; set; }
    }
}
