using SearchPath.Classes;

namespace SearchPath
{
    class Program
    {
        static void Main(string[] args)
        {
            Place[] places = 
            [
                new("Исаакиевский собор", 10, 5),
                new("Эрмитаж", 11, 8),
                new("Кунсткамера", 4, 3.5 ),
                new("Петроправловская крепость", 7, 10 ),
                new("Ленинградский зоопарк", 15, 9),
                new("Медный всадник", 17, 1),
                new("Казанский собор", 3, 4),
                new("Спас на Крови", 9, 2),
                new("Зимний дворец Петра I", 12, 7),
                new("Зоологический музей", 6, 5.5),
                new("Музей обороны и блокады Ленинграда", 19, 2),
                new("Русский музей", 8, 5),
                new("Навестить друзей", 20, 12),
                new("Музей восковых фигур", 13, 2 ),
                new("Литературно-мемориальный музей Ф.М. Достоевского", 2, 4),
                new("Екатерининский дворец", 5, 1.5),
                new("Петербургский музей кукол", 14, 1),
                new("Музей микроминиатюры \"Русский левша\"", 18, 3),
                new("Всероссийский музей А.С. Пушкина и филиалы", 1, 6 ), 
                new("Музей современного искусства Эрарта", 16, 7 )
            ];

            double hours = 32.0;

            var pathOfVisits = new List<Place>();

            //Сортировка массива достопримечательностей вставками (по убыванию важности)
            for (int i = 1; i < places.Length; i++)
            {
                Place temp = places[i];
                int j = i - 1;
                while (j >= 0 && places[j].Importance < temp.Importance)
                {
                    places[j + 1] = places[j];
                    j -= 1;
                }
                places[j + 1] = temp;
            }


            for (int i = 0; i < places.Length; i++)
            {
                if (hours - places[i].Time > 0)
                {
                    pathOfVisits.Add(places[i]);
                    hours -= places[i].Time;
                }
            }

            foreach (Place place in pathOfVisits)
            {
                Console.WriteLine(place.Name);
            }
        }
    }
}

