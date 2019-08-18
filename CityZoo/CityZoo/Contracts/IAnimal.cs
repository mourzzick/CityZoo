// Ruslan Georgiev
// Canvas id: aj0701

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    interface IAnimal
    {
        int Id { get; }
        string Name { get; set; }
        double Age { get; set; }
        Sex Sex { get; set; }

        EaterType GetEaterType();
        FoodSchedule GetFoodSchedule();
        string GetSpecies();

    }
}
