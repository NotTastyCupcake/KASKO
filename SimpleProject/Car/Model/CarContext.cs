using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleProject.Car.Model
{
    class CarContext : ModelCar
    {

        public static List<ModelCar> listLada = new List<ModelCar>
        {
            new ModelCar {Id = 11, Name = "2107 CLASSIC", ModelCoef = 1.27 },
            new ModelCar {Id = 12, Name = "2106 CLASSIC", ModelCoef = 1.269 },
            new ModelCar {Id = 13, Name = "2114 SAMARA 2", ModelCoef = 1.269 },
            new ModelCar {Id = 14, Name = "2110 SEDAN", ModelCoef = 1.268 },
            new ModelCar {Id = 15, Name = "2109 SAMARA", ModelCoef = 1.267 }
        };

        public static List<ModelCar> listTayota = new List<ModelCar>
        {
            new ModelCar {Id = 21, Name = "Camry", ModelCoef = 1.125},
            new ModelCar {Id = 22, Name = "RAV4", ModelCoef = 1.124},
            new ModelCar {Id = 23, Name = "Land Cruiser 200", ModelCoef = 1.123},
            new ModelCar {Id = 24, Name = "Corolla", ModelCoef = 1.122},
            new ModelCar {Id = 25, Name = "Land Cr.Prodo 150", ModelCoef = 1.121}
        };
    }
}
