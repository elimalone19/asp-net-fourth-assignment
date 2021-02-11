using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_net_fourth_assignment.Models
{
    public class Restaurant
    {
        public int Rank { get; set; }
        public string Name { get; set; }
        public string Dish { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Link { get; set; }


        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant
            {
                Rank = 1,
                Name = "Bombay House",
                Dish = null ?? "It’s all tasty!",
                Address = "463 N University Ave",
                Phone = "801-373-6677" ?? "Not available",
                Link = "http://www.bombayhouse.com/" ?? "Coming soon."
            };

            Restaurant r2 = new Restaurant
            {
                Rank = 2,
                Name = "180 Tacos",
                Dish = "Taco Bowls" ?? "It’s all tasty!",
                Address = "3368 N University Ave",
                Phone = "801-356-8226" ?? "Not available",
                Link = "https://www.180tacos.com/" ?? "Coming soon."
            };

            Restaurant r3 = new Restaurant
            {
                Rank = 3,
                Name = "Bowls Superfoods",
                Dish = "Acai Bowl" ?? "It’s all tasty!",
                Address = "1161 N Canyon Rd",
                Phone = null ?? "Not available",
                Link = "http://bowlssuperfoods.com/" ?? "Coming soon."
            };

            Restaurant r4 = new Restaurant
            {
                Rank = 4,
                Name = "Two Jacks Pizza",
                Dish = "Two Jacks Special" ?? "It’s all tasty!",
                Address = "80 W Center St",
                Phone = "801-377-4747" ?? "Not available",
                Link = "http://www.twojackspizza.com/" ?? "Coming soon."
            };

            Restaurant r5 = new Restaurant
            {
                Rank = 5,
                Name = "Brooker's Founding Flavors",
                Dish = null ?? "It’s all tasty!",
                Address = "748 E 820 N",
                Phone = "801-919-4635" ?? "Not available",
                Link = null ?? "Coming soon."
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }

    }
}
