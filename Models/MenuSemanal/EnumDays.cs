using System.ComponentModel;

namespace MenuSemanal.Models
{
    public enum EnumDays
    {
        [Description("Lunes")]
        Lunes = 1,

        [Description("Martes")]
        Martes = 2,

        [Description("Miercoles")]
        Miercoles = 3,

        [Description("Jueves")]
        Jueves = 4,

        [Description("Viernes")]
        Viernes = 5,

        [Description("Sabado")]
        Sabado = 6,

        [Description("Domingo")]
        Domingo = 7
    }
}
