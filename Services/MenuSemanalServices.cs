using MenuSemanal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenuSemanal.Services
{
    public class MenuSemanalServices : IMenuSemanalServices<Week>
    {
        readonly List<Week> weeks;

        public class test
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public MenuSemanalServices()
        {

            weeks = new List<Week>()
            {
                new Week {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Semana del 6 al 12",
                    DaysToMeal = new Dictionary<EnumDays, Dictionary<EnumMeals, ThisngsToMeal>>
                    {
                        {
                            EnumDays.Lunes,
                            new Dictionary<EnumMeals, ThisngsToMeal>
                            {
                                {
                                    EnumMeals.Desayuno,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { },
                                    By = "Miguel"
                                    }
                                },
                                {
                                    EnumMeals.Merienda_1,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() {}
                                    }
                                },
                                {
                                    EnumMeals.Almuerzo,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { "pruebaaaaa" }
                                    }
                                },
                                {
                                    EnumMeals.Merienda_2,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Cena,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Snak,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                }
                            }
                        },
                        {
                            EnumDays.Martes,
                            new Dictionary<EnumMeals, ThisngsToMeal>
                            {
                                {
                                    EnumMeals.Desayuno,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Merienda_1,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Almuerzo,
                                    new ThisngsToMeal() {
                                     Things = new List<string>() {  }
                                    }
                                },
                                {
                                    EnumMeals.Merienda_2,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Cena,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Snak,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                }
                            }
                        },
                        {
                            EnumDays.Miercoles,
                            new Dictionary<EnumMeals, ThisngsToMeal>
                            {
                                {
                                    EnumMeals.Desayuno,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() {  }
                                    }
                                },
                                {
                                    EnumMeals.Merienda_1,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Almuerzo,
                                    new ThisngsToMeal() {
                                     Things = new List<string>() {  }
                                    }
                                },
                                {
                                    EnumMeals.Merienda_2,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Cena,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Snak,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                }
                            }
                        },
                        {
                            EnumDays.Jueves,
                            new Dictionary<EnumMeals, ThisngsToMeal>
                            {
                                {
                                    EnumMeals.Desayuno,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Merienda_1,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Almuerzo,
                                    new ThisngsToMeal() {
                                     Things = new List<string>() {  }
                                    }
                                },
                                {
                                    EnumMeals.Merienda_2,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Cena,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Snak,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                }
                            }
                        },
                        {
                            EnumDays.Viernes,
                            new Dictionary<EnumMeals, ThisngsToMeal>
                            {
                                {
                                    EnumMeals.Desayuno,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() {  }
                                    }
                                },
                                {
                                    EnumMeals.Merienda_1,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() {  }
                                    }
                                },
                                {
                                    EnumMeals.Almuerzo,
                                    new ThisngsToMeal() {
                                     Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Merienda_2,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Cena,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Snak,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                }
                            }
                        },
                        {
                            EnumDays.Sabado,
                            new Dictionary<EnumMeals, ThisngsToMeal>
                            {
                                {
                                    EnumMeals.Desayuno,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() {  }
                                    }
                                },
                                {
                                    EnumMeals.Merienda_1,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() {  }
                                    }
                                },
                                {
                                    EnumMeals.Almuerzo,
                                    new ThisngsToMeal() {
                                     Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Merienda_2,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Cena,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Snak,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                }
                            }
                        },
                        {
                            EnumDays.Domingo,
                            new Dictionary<EnumMeals, ThisngsToMeal>
                            {
                                {
                                    EnumMeals.Desayuno,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() {  }
                                    }
                                },
                                {
                                    EnumMeals.Merienda_1,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() {  }
                                    }
                                },
                                {
                                    EnumMeals.Almuerzo,
                                    new ThisngsToMeal() {
                                     Things = new List<string>() {  }
                                    }
                                },
                                {
                                    EnumMeals.Merienda_2,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Cena,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                },
                                {
                                    EnumMeals.Snak,
                                    new ThisngsToMeal() {
                                    Things = new List<string>() { }
                                    }
                                }
                            }
                        }
                    },
                    ThingsToBuy = new List<string>() { "Leche", "Azucar", "Arroz" , "Frijoles"}
                },

                new Week { Id = Guid.NewGuid().ToString(), Name = "Semana del 13 al 19" },
                new Week { Id = Guid.NewGuid().ToString(), Name = "Semana del 20 al 26" },
                new Week { Id = Guid.NewGuid().ToString(), Name = "Semana del 27 al 3" },
                new Week { Id = Guid.NewGuid().ToString(), Name = "Semana del 4 al 10" },
                new Week { Id = Guid.NewGuid().ToString(), Name = "Semana del 11 al 17" }
             };


        }

        public async Task<bool> AddItemAsync(Week week)
        {
            weeks.Add(week);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldWeek= weeks.Where((Week arg) => arg.Id == id).FirstOrDefault();
            weeks.Remove(oldWeek);

            return await Task.FromResult(true);
        }

        public async Task<Week> GetItemAsync(string id)
        {
            return await Task.FromResult(weeks.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Week>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(weeks);
        }

        public async Task<bool> UpdateItemAsync(Week week)
        {
            var oldWeek = weeks.Where((Week arg) => arg.Id == week.Id).FirstOrDefault();
            weeks.Remove(oldWeek);
            weeks.Add(week);

            return await Task.FromResult(true);
        }
    }
}
