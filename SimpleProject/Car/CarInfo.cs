using System;
using System.Collections.Generic;
using System.Text;
using SimpleProject.Car.Model;

namespace SimpleProject.Car
{
    class CarInfo : ICarInfo
    {
    #region Расчет коэффициента от даты начала эксплуатации
        public static double CoeffBeginWork(DateTime dateTime)
        {
            //Расчет лет эксплуатации
            int ageWork = DateTime.Now.Year - dateTime.Year;
            if (DateTime.Now.DayOfYear < dateTime.DayOfYear)
            {
                ageWork--;
            }

            //Подсчет коэффициента
            double yearCoeff;
            switch (ageWork)
            {
                case 0:
                    yearCoeff = 1.20;
                    break;
                case 1:
                    yearCoeff = 1.18;
                    break;
                case 2:
                    yearCoeff = 1.15;
                    break;
                case 3:
                    yearCoeff = 1.10;
                    break;
                case 4:
                    yearCoeff = 1.05;
                    break;
                default:
                    yearCoeff = 1;
                    break;
            }
            //Вывод коэффицента
            return yearCoeff;
        }
        #endregion

    #region Расчет коэффициента в зависимости от наличия сигнализации
        public static double CarSignalCoeff (bool check)
        {
            if (check) { return 1; }
            else { return 1.5; }
        }
        #endregion

    #region Реализация списка моделей марок автомобиля с возможностью использовать коэффициента
        public static List<ModelCar> ModelsCars(int index)
        {
            switch (index)
            {
                case 0:
                    return CarContext.listLada;
                case 1:
                    return CarContext.listTayota;
                default:
                    return CarContext.listLada;
            };
        }
    #endregion
    }
}
