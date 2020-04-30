using System.Collections.Generic;

namespace MenuSemanal.Models
{
    public class Week
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<string> ThingsToBuy { get; set; }
        public Dictionary<EnumDays, Dictionary<EnumMeals, ThisngsToMeal>> DaysToMeal { get; set; }
    }
}
