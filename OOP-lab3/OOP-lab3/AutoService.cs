using System;
using System.Collections.Generic;
using System.Text;

namespace OOPlaba3
{
    class AutoService
    {
        public string Name { get; set; }
        public Station[] stations;

        public AutoService()
        {
            Name = "NonameAutoService";
            stations = new Station[1];
            stations[0] = new Station("base1");
        }

        public AutoService(string name) : this(name, "base2")
        {
        }

        /*public AutoService(string name, Station[] stations) //: this(name)
        {
            Name = "Noname";
            this.stations = stations;
        }*/

        public AutoService(/*string name, */params string[] stationNames)
        {
            Name = "Noname";
            stations = new Station[stationNames.Length];
            for (int i = 0; i < stationNames.Length; i++)
            {
                stations[i] = new Station(stationNames[i], 1);
            }
        }
        public AutoService(string name, Station[] arr_stations)
        {
            Name = name;

            stations = new Station[arr_stations.Length];
            for (int i = 0; i < arr_stations.Length; i++)
            {
                this.stations[i] = arr_stations[i];
            }
        }

        public AutoService(string name, int stationCount)
        {
            Name = name;
            stations = new Station[stationCount];
            for (int i = 0; i < stationCount; i++)
            {
                stations[i] = new Station();
            }
        }

        public AutoService(string name, int stationCount, int carCapasity)
        {
            Name = name;
            stations = new Station[stationCount];
            for (int i = 0; i < stationCount; i++)
            {
                stations[i] = new Station(carCapasity);
            }
        }


        /// <summary>
        /// Регистрирует авто на станции. Перед этим проверяет загруженность станции - Если загружена авто отправляется на следующую станцию
        /// </summary>
        /// <returns>
        /// Возвращает станцию, на которую авто зарегистрировано.
        /// </returns>
        public Station registration(Car car)
        {
            Station reg_station = new Station();
            for (int i = 0; i < this.stations.Length; i++)
            {
                int workload_station = 0;
                int free_place = 0;
                for (int j = 0; j < stations[i].cars.Length; j++)
                {
                    if (stations[i].cars[j] != null)
                    {
                        workload_station++;
                    }
                    else
                    {
                        free_place = j;
                        break;
                    }
                }
                if (workload_station < stations[i].Capasity)
                {
                    reg_station = stations[i];
                    stations[i].cars[free_place] = car;
                    break;   //как только нашлось свободное место на какой-либо станции
                }

            }
            return reg_station;
        }


        /// <summary>
        /// Проверяет авто - выводится ли сообщение Check engine
        /// </summary>
        /// <returns>
        /// Возвращает список неисправных авто.
        /// </returns>
        public static List<Car> CheckFaults(Car[] cars)
        {
            var list = new List<Car>(cars);
            // String str = "";
            for (int i = 0; i < list.Count; i++)
            {

                if (list[i].engine.is_varning)
                {
                    Console.WriteLine($"Авто {list[i].Number} требуестя диагностика двигателя {list[i].engine.Vin}.\n");

                }
                else
                {
                    Console.WriteLine($"Авто {list[i].Number} диагностика не требуестя.\n");
                    list.Remove(list[i]);
                }

            }
            return list;
        }

        public override string ToString()
        {

            string str = $"\nАвтосервис {Name}. Станций {stations.Length}\n";
            foreach (Station station in stations) //Здесь можем воспользоваться foreach - данные только считываем
            {
                str += $"{station}\n";
            }
            return str;

        }
    }
}
