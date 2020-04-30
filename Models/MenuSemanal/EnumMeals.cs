using System.ComponentModel;

namespace MenuSemanal.Models
{
    public enum EnumMeals
    {
        [Description("Desayuno")]
        Desayuno = 1,

        [Description("Merienda Mañana")]
        Merienda_1 = 2,

        [Description("Almuerzo")]
        Almuerzo = 3,

        [Description("Merienda Tarde")]
        Merienda_2 = 4,

        [Description("Cena")]
        Cena = 5,

        [Description("Snaks")]
        Snak = 6
    }
}
