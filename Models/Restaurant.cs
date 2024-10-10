namespace BurgersData.Models
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string WebSite { get; set; }
        public string Phone { get; set; }
        public List<Burger> Burgers { get; set; }

        public List<Restaurant> getRestaurants()
        {
            List<Restaurant> restaurants = new()
            {
            new Restaurant
            {
                Name="MEAT", Street="Angel Kunchev 1", City="Sofia", Burgers=new List<Burger>
                {
                    new Burger
                    {
                        Id="MeatMeat", Name="MEAT", Rating=4.9, Price=19, Reviews=new List<Review> { new Review { Info = "Amazing" }, new Review { Info = "Totally recommend" }, new Review { Info = "best burger ever" } },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=false, Iceberg=true, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=true,
                        Cheddar=true, BlueCheese=false, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=true, Egg=false, Rocket=false,
                        Bbq=false, Pickels=false, VeggieBurger=false, Bacon=true, RedOnion=false, Coleslaw=false, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=true, Veggie=false, Cheesy=true, Smash=false, Spicy=false, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=false, Crispy=true, Bacon=true },
                        Image="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSDeKS55LwBdU0acy8ftaKZsikWRzOSGsC3zw&s"
                    },
                    new Burger
                    {
                        Id="MeatSmash", Name="Smash", Rating=4.7, Price=19, Reviews=new List<Review> { new Review { Info = "yummy" }, new Review { Info = "absolutely delicious" }, new Review { Info = "best burger ever" } },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=false, Iceberg=true, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=true,
                        Cheddar=true, BlueCheese=false, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=false, Egg=false, Rocket=false,
                        Bbq=false, Pickels=true, VeggieBurger=false, Bacon=false, RedOnion=true, Coleslaw=false, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=true, Veggie=false, Cheesy=true, Smash=true, Spicy=false, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=true, Crispy=true, Bacon=false },
                        Image="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTKig4kSRVVyk6-v5anYGPYkalIoVEytgu4TG2sezXRkORs1so48T_u5ZgnqzUX9QHQHW0&usqp=CAU"
                    },
                    new Burger
                    {
                        Id="MeatCheeseburger", Name="Cheeseburger", Rating=4.6, Price=18, Reviews=new List<Review> { new Review { Info = "awesome" }, new Review { Info="normal ingredients, but the flavour..." } },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=true, Iceberg=true, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=true,
                        Cheddar=true, BlueCheese=false, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=false, Egg=false, Rocket=false,
                        Bbq=false, Pickels=true, VeggieBurger=false, Bacon=false, RedOnion=true, Coleslaw=false, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=true, Veggie=false, Cheesy=true, Smash=false, Spicy=false, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=false, Crispy=true, Bacon=false },
                        Image="https://scontent.fsof11-1.fna.fbcdn.net/v/t31.18172-8/10873021_917604844939800_7109622558911317165_o.jpg?_nc_cat=102&ccb=1-7&_nc_sid=f798df&_nc_ohc=wZzaZK-soj8Q7kNvgHlo0U7&_nc_ht=scontent.fsof11-1.fna&_nc_gid=A9hWQnU6aWtOaFjctTR25Xd&oh=00_AYCsLIPNbgT_O9SFaDIbYcAaxWGMlEGxZDVvTZuQXWtROA&oe=6725412E"
                    },
                    new Burger
                    {
                        Id="MeatPulledPork", Name="Pulled Pork", Rating=4.5, Price=18, Reviews=new List<Review> { new Review { Info = "yummy" }, new Review { Info = "best burger ever" } },
                        Beef=false, PulledPork=true, Chicken=false, Tomato=false, Iceberg=true, Mayo=true, HotSause=false, Aioli=false, BurgerSauce=true,
                        Cheddar=false, BlueCheese=false, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=false, Egg=false, Rocket=false,
                        Bbq=false, Pickels=false, VeggieBurger=false, Bacon=false, RedOnion=true, Coleslaw=true, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=false, Veggie=false, Cheesy=false, Smash=false, Spicy=false, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=false, Crispy=false, Bacon=false },
                        Image="https://scontent.fsof8-1.fna.fbcdn.net/v/t39.30808-6/259132478_4928852323815012_2742950163077604460_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=127cfc&_nc_ohc=GB6avWR4MZ4Q7kNvgHT_BWr&_nc_ht=scontent.fsof8-1.fna&_nc_gid=A5GocHSNSqbJVgWiGCraGjx&oh=00_AYDmMt31q80Gje2Mash3gBoJgsgMKMcoetnozP4YKlMY9A&oe=670372DD"
                    },
                    new Burger
                    {
                        Id="MeatClassic", Name="Classic", Rating=4.2, Price=17, Reviews=new List<Review> {new Review { Info="plain" } },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=true, Iceberg=true, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=true,
                        Cheddar=false, BlueCheese=false, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=false, Egg=false, Rocket=false,
                        Bbq=false, Pickels=true, VeggieBurger=false, Bacon=false, RedOnion=true, Coleslaw=false, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=true, Veggie=false, Cheesy=false, Smash=false, Spicy=false, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=false, Crispy=false, Bacon=false },
                        Image="https://scontent.fsof8-1.fna.fbcdn.net/v/t31.18172-8/10987738_947901995243418_1409035512865775444_o.jpg?_nc_cat=104&ccb=1-7&_nc_sid=0327a3&_nc_ohc=kQJOhLzSH8AQ7kNvgFQJxjB&_nc_ht=scontent.fsof8-1.fna&_nc_gid=Abfd0dkFsyP9ANii5yzRYY5&oh=00_AYC0kGENHehI648U4XVMq77mxtOMgsDsXR7rzj2clJJ7Fw&oe=672544AB"
                    },
                }, Phone="0887078455", WebSite="https://www.facebook.com/MeatGourmetSandwichesAndBurgers/?ref=bookmarks"
            },
            new Restaurant
            {
                Name="BUTCHER GRILL BUS", Street="Cherni Vrah 69", City="Sofia", Burgers=new List<Burger>
                {
                    new Burger
                    {
                        Id="ButcherCheeseburger", Name="Cheeseburger", Rating=4.6, Price=20.90, Reviews=new List<Review> { new Review { Info = "amazing" }, new Review { Info = "too expensive" } },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=false, Iceberg=true, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=true,
                        Cheddar=true, BlueCheese=false, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=true, Egg=false, Rocket=false,
                        Bbq=false, Pickels=true, VeggieBurger=false, Bacon=false, RedOnion=false, Coleslaw=false, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=true, Veggie=false, Cheesy=true, Smash=false, Spicy=false, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=false, Crispy=false, Bacon=false },
                        Image=""
                    },
                    new Burger
                    {
                        Id="ButcherBeefBacon", Name="Beef Bacon Burger", Rating=4.7, Price=23.90, Reviews=new List<Review> { new Review { Info = "top of the top" }, new Review { Info = "the most amazing thing ever" }, new Review { Info = "nope" } },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=false, Iceberg=true, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=true,
                        Cheddar=false, BlueCheese=false, Bri=false, Jam=true, Jalapenos=true, Avocado=false, CaramelisedOnion=true, Egg=false, Rocket=false,
                        Bbq=false, Pickels=false, VeggieBurger=false, Bacon=true, RedOnion=true, Coleslaw=false, Ranch=false, Pesto=true,
                        Labels=new Label{ Classic=false, Veggie=false, Cheesy=false, Smash=false, Spicy=true, Loaded=true, Bbq=false, Gourmet=true, DoubleStack=false, Crispy=true, Bacon=true },
                        Image=""
                    },
                    new Burger
                    {
                        Id="ButcherDoubleDecker", Name="Double Decker", Rating=4.3, Price=31.90, Reviews=new List<Review> {new Review {Info="too much"} },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=true, Iceberg=true, Mayo=false, HotSause=true, Aioli=false, BurgerSauce=true,
                        Cheddar=true, BlueCheese=false, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=false, Egg=false, Rocket=false,
                        Bbq=false, Pickels=true, VeggieBurger=false, Bacon=false, RedOnion=true, Coleslaw=false, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=true, Veggie=false, Cheesy=true, Smash=false, Spicy=true, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=true, Crispy=false, Bacon=false },
                        Image=""
                    },
                    new Burger
                    {
                        Id="ButcherRooster", Name="Rooster Burger", Rating=4.0, Price=18.50, Reviews=new List<Review> {new Review {Info="yummy"} },
                        Beef=false, PulledPork=false, Chicken=true, Tomato=false, Iceberg=true, Mayo=true, HotSause=true, Aioli=false, BurgerSauce=true,
                        Cheddar=true, BlueCheese=false, Bri=false, Jam=false, Jalapenos=false, Avocado=true, CaramelisedOnion=false, Egg=false, Rocket=false,
                        Bbq=false, Pickels=false, VeggieBurger=false, Bacon=true, RedOnion=true, Coleslaw=true, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=false, Veggie=false, Cheesy=true, Smash=false, Spicy=true, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=false, Crispy=false, Bacon=false },
                        Image=""
                    },
                    new Burger
                    {
                        Id="ButcherPure", Name="Pure Burger", Rating=3.8, Price=17.50, Reviews=new List < Review > { new Review { Info = "plain" } },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=false, Iceberg=false, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=false,
                        Cheddar=true, BlueCheese=false, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=false, Egg=false, Rocket=false,
                        Bbq=false, Pickels=false, VeggieBurger=false, Bacon=false, RedOnion=false, Coleslaw=false, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=true, Veggie=false, Cheesy=false, Smash=false, Spicy=false, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=false, Crispy=false, Bacon=false },
                        Image="https://scontent.fsof8-1.fna.fbcdn.net/v/t31.18172-8/10987738_947901995243418_1409035512865775444_o.jpg?_nc_cat=104&ccb=1-7&_nc_sid=0327a3&_nc_ohc=kQJOhLzSH8AQ7kNvgFQJxjB&_nc_ht=scontent.fsof8-1.fna&_nc_gid=Abfd0dkFsyP9ANii5yzRYY5&oh=00_AYC0kGENHehI648U4XVMq77mxtOMgsDsXR7rzj2clJJ7Fw&oe=672544AB"
                    },
                }, Phone="0888892899", WebSite="https://www.butchergrillbus.bg"
            },
            new Restaurant
            {
                Name="Street Chefs", Street="Kozyak 2", City="Sofia", Burgers=new List<Burger>
                {
                    new Burger
                    {
                        Id="StreetChefsChefs", Name="Chefs Burger", Rating=4.1, Price=18.50, Reviews=new List < Review > { new Review { Info = "okay" }, new Review { Info = "mediocre" } },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=false, Iceberg=false, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=true,
                        Cheddar=true, BlueCheese=false, Bri=false, Jam=false, Jalapenos=true, Avocado=false, CaramelisedOnion=true, Egg=false, Rocket=false,
                        Bbq=false, Pickels=false, VeggieBurger=false, Bacon=true, RedOnion=false, Coleslaw=false, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=true, Veggie=false, Cheesy=true, Smash=false, Spicy=true, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=false, Crispy=true, Bacon=true },
                        Image="https://cms.topnovini.bg/attachments/FileManager/270676/uploads/1_fit-gallery_slider.jpg?v=1614728304"
                    },
                    new Burger
                    {
                        Id="StreetChefsGorgonzola", Name="Gorgonzola", Rating=3.3, Price=17.50, Reviews=new List<Review> { new Review { Info = "fine" }, new Review { Info = "awful" } },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=true, Iceberg=false, Mayo=true, HotSause=false, Aioli=false, BurgerSauce=false,
                        Cheddar=false, BlueCheese=true, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=false, Egg=false, Rocket=true,
                        Bbq=false, Pickels=true, VeggieBurger=false, Bacon=false, RedOnion=true, Coleslaw=false, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=false, Veggie=false, Cheesy=true, Smash=false, Spicy=false, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=false, Crispy=false, Bacon=false },
                        Image="https://media-cdn.tripadvisor.com/media/photo-s/1b/59/28/54/mmmm-gorgonzola.jpg"
                    },
                    new Burger
                    {
                        Id="StreeChefsCheeseburger", Name="Classic Cheeseburger", Rating=3.9, Price=17.50, Reviews=new List<Review> { new Review { Info = "normal ingredients, but the flavour was not that good" } },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=false, Iceberg=true, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=true,
                        Cheddar=true, BlueCheese=false, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=false, Egg=false, Rocket=false,
                        Bbq=false, Pickels=true, VeggieBurger=false, Bacon=false, RedOnion=false, Coleslaw=false, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=true, Veggie=false, Cheesy=true, Smash=false, Spicy=false, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=false, Crispy=false, Bacon=false },
                        Image="https://res.cloudinary.com/tkwy-prod-eu/image/upload/ar_1:1,c_thumb,h_120,w_120/f_auto/q_auto/dpr_1.0/v1727455897/static-takeaway-com/images/restaurants/bg/050O775N/products/classic-cheese-burger"
                    },
                    new Burger
                    {
                        Id="StreeChefsVeggie", Name="Veggie Burger", Rating=3.5, Price=14.50, Reviews=new List<Review> { new Review { Info = "it was fine" }, new Review {Info="do not recommend"} },
                        Beef=false, PulledPork=false, Chicken=false, Tomato=true, Iceberg=true, Mayo=true, HotSause=false, Aioli=false, BurgerSauce=false,
                        Cheddar=false, BlueCheese=false, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=false, Egg=false, Rocket=false,
                        Bbq=false, Pickels=false, VeggieBurger=true, Bacon=false, RedOnion=true, Coleslaw=false, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=false, Veggie=true, Cheesy=false, Smash=false, Spicy=false, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=false, Crispy=false, Bacon=false },
                        Image="https://res.cloudinary.com/tkwy-prod-eu/image/upload/ar_1:1,c_thumb,h_120,w_120/f_auto/q_auto/dpr_1.0/v1727455897/static-takeaway-com/images/restaurants/bg/050O775N/products/veggie-burger"
                    },
                    new Burger
                    {
                        Id="StreetChefsSmashed", Name="Smashed Burger", Rating=3.8, Price=10.50, Reviews=new List<Review> { new Review { Info = "not impressed" } },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=false, Iceberg=true, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=true,
                        Cheddar=true, BlueCheese=false, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=false, Egg=false, Rocket=false,
                        Bbq=false, Pickels=true, VeggieBurger=false, Bacon=false, RedOnion=false, Coleslaw=false, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=true, Veggie=false, Cheesy=false, Smash=true, Spicy=false, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=false, Crispy=false, Bacon=false },
                        Image="https://res.cloudinary.com/tkwy-prod-eu/image/upload/ar_1:1,c_thumb,h_120,w_120/f_auto/q_auto/dpr_1.0/v1727455897/static-takeaway-com/images/restaurants/bg/050O775N/products/smashed-burger"
                    },
                    new Burger
                    {
                        Id="StreetChefsDoubleChefs", Name="Double Chefs Burger", Rating=4.1, Price=23.50, Reviews=new List<Review> { new Review { Info = "okay" }, new Review {Info="mediocre"} },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=false, Iceberg=false, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=true,
                        Cheddar=true, BlueCheese=false, Bri=false, Jam=false, Jalapenos=true, Avocado=false, CaramelisedOnion=true, Egg=false, Rocket=false,
                        Bbq=false, Pickels=false, VeggieBurger=false, Bacon=true, RedOnion=false, Coleslaw=false, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=true, Veggie=false, Cheesy=true, Smash=true, Spicy=true, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=true, Crispy=true, Bacon=true },
                        Image="https://res.cloudinary.com/tkwy-prod-eu/image/upload/ar_1:1,c_thumb,h_120,w_120/f_auto/q_auto/dpr_1.0/v1727455897/static-takeaway-com/images/restaurants/bg/050O775N/products/double-chefs"
                    },
                    new Burger
                    {
                        Id="StreetChefsDoubleGorgonzola", Name="Double Gorgonzola Burger", Rating=3.8, Price=20.50, Reviews=new List<Review> { new Review { Info = "fine" }, new Review {Info="awful"} },
                         Beef=true, PulledPork=false, Chicken=false, Tomato=true, Iceberg=false, Mayo=true, HotSause=false, Aioli=false, BurgerSauce=false,
                        Cheddar=false, BlueCheese=true, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=false, Egg=false, Rocket=true,
                        Bbq=false, Pickels=true, VeggieBurger=false, Bacon=false, RedOnion=true, Coleslaw=false, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=false, Veggie=false, Cheesy=true, Smash=false, Spicy=false, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=true, Crispy=false, Bacon=false },
                        Image="https://media-cdn.tripadvisor.com/media/photo-s/1b/59/28/54/mmmm-gorgonzola.jpg"
                    },
                    new Burger
                    {
                        Id="StreeChefsDoubleCheeseburger", Name="Double Classic Cheeseburger", Rating=3.9, Price=22.50, Reviews=new List<Review> { new Review { Info = "normal ingredients, but the flavour was not that good" } },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=false, Iceberg=true, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=true,
                        Cheddar=true, BlueCheese=false, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=false, Egg=false, Rocket=false,
                        Bbq=false, Pickels=true, VeggieBurger=false, Bacon=false, RedOnion=false, Coleslaw=false, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=true, Veggie=false, Cheesy=true, Smash=false, Spicy=false, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=true, Crispy=false, Bacon=false },
                        Image="https://res.cloudinary.com/tkwy-prod-eu/image/upload/ar_1:1,c_thumb,h_120,w_120/f_auto/q_auto/dpr_1.0/v1727455897/static-takeaway-com/images/restaurants/bg/050O775N/products/double-cheese"
                    },
                }, Phone="0889052595", WebSite="https://www.facebook.com/street.chefs.bulgaria/"
            },
            new Restaurant
            {
                Name="Boom Burgers", Street="Tsar Osvoboditel 12", City="Sofia", Burgers=new List<Burger>
                {
                    new Burger
                    {
                        Id="BoomBoom", Name="Boom Burger", Rating=4.4, Price=18.99, Reviews=new List<Review> { new Review { Info = "Totally recommend" }, new Review { Info = "great burger" } },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=true, Iceberg=true, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=true,
                        Cheddar=true, BlueCheese=false, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=true, Egg=false, Rocket=false,
                        Bbq=false, Pickels=true, VeggieBurger=false, Bacon=true, RedOnion=false, Coleslaw=false, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=true, Veggie=false, Cheesy=true, Smash=false, Spicy=false, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=false, Crispy=true, Bacon=true },
                        Image="https://res.cloudinary.com/tkwy-prod-eu/image/upload/ar_1:1,c_thumb,h_120,w_120/f_auto/q_auto/dpr_1.0/v1727595233/static-takeaway-com/images/restaurants/bg/N1O3QQ7/products/boomburger"
                    },
                    new Burger
                    {
                        Id="BoomStoner", Name="Stoner's Delight Burger", Rating=4.6, Price=19.99, Reviews=new List<Review> { new Review { Info = "absolutely delicious" }, new Review { Info = "best burger ever" } },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=true, Iceberg=true, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=true,
                        Cheddar=true, BlueCheese=false, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=false, Egg=false, Rocket=false,
                        Bbq=false, Pickels=false, VeggieBurger=false, Bacon=false, RedOnion=false, Coleslaw=false, Ranch=true, Pesto=false, MozarellaSticks=true,
                        Labels=new Label{ Classic=false, Veggie=false, Cheesy=true, Smash=false, Spicy=false, Loaded=true, Bbq=false, Gourmet=false, DoubleStack=false, Crispy=true, Bacon=false },
                        Image="https://res.cloudinary.com/tkwy-prod-eu/image/upload/ar_1:1,c_thumb,h_120,w_120/f_auto/q_auto/dpr_1.0/v1727595233/static-takeaway-com/images/restaurants/bg/3RO0P57N/products/stoner_sdelightburger"
                    },
                    new Burger
                    {
                        Id="BoomCheeseburger", Name="Cheeseburger", Rating=4.3, Price=17.99, Reviews=new List<Review> { new Review { Info = "awesome" }, new Review { Info = "too small" } },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=true, Iceberg=true, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=true,
                        Cheddar=true, BlueCheese=true, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=false, Egg=false, Rocket=false,
                        Bbq=false, Pickels=false, VeggieBurger=false, Bacon=false, RedOnion=true, Coleslaw=false, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=true, Veggie=false, Cheesy=true, Smash=false, Spicy=false, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=false, Crispy=false, Bacon=false },
                        Image="https://res.cloudinary.com/tkwy-prod-eu/image/upload/ar_1:1,c_thumb,h_120,w_120/f_auto/q_auto/dpr_1.0/v1727595233/static-takeaway-com/images/restaurants/bg/N1O3QQ7/products/cheeseburger"
                    },
                    new Burger
                    {
                        Id="BoomBeyond", Name="Boom Beyond Burger", Rating=3.8, Price=19.99, Reviews=new List<Review> { new Review { Info = "yummy" }, new Review { Info = "best veggie burger" } },
                        Beef=false, PulledPork=false, Chicken=false, Tomato=false, Iceberg=false, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=true,
                        Cheddar=true, BlueCheese=false, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=true, Egg=false, Rocket=false,
                        Bbq=false, Pickels=true, VeggieBurger=true, Bacon=false, RedOnion=false, Coleslaw=false, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=false, Veggie=true, Cheesy=true, Smash=false, Spicy=false, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=false, Crispy=true, Bacon=false },
                        Image="https://res.cloudinary.com/tkwy-prod-eu/image/upload/ar_1:1,c_thumb,h_120,w_120/f_auto/q_auto/dpr_1.0/v1727595233/static-takeaway-com/images/restaurants/bg/3RO0P57N/products/boombeyondburger"
                    },
                    new Burger
                    {
                        Id="BoomPulled", Name="Pulled Pork Ribs Burger", Rating=4.2, Price=16.99, Reviews=new List<Review> { new Review { Info = "plain" }, new Review { Info = "it was good" } },
                        Beef=false, PulledPork=true, Chicken=false, Tomato=false, Iceberg=false, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=false,
                        Cheddar=true, BlueCheese=false, Bri=false, Jam=false, Jalapenos=true, Avocado=false, CaramelisedOnion=false, Egg=false, Rocket=false,
                        Bbq=true, Pickels=false, VeggieBurger=false, Bacon=false, RedOnion=false, Coleslaw=true, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=false, Veggie=false, Cheesy=false, Smash=false, Spicy=true, Loaded=false, Bbq=true, Gourmet=false, DoubleStack=false, Crispy=false, Bacon=false },
                        Image="https://res.cloudinary.com/tkwy-prod-eu/image/upload/ar_1:1,c_thumb,h_120,w_120/f_auto/q_auto/dpr_1.0/v1727595233/static-takeaway-com/images/restaurants/bg/3RO0P57N/products/pulled_pork"
                    },
                }, Phone="0895678011", WebSite="https://www.boomburgers.com/menu"
            },
            new Restaurant
            {
                Name="The Rusty Grill Burgers and More", Street="Shipka Street 12", City="Sofia", Burgers=new List<Burger>
                {
                    new Burger
                    {
                        Id="RustyJuicy", Name="The Juicy Lucy", Rating=4.4, Price=21.90, Reviews=new List<Review> { new Review { Info = "Amazing" }, new Review { Info = "Totally recommend" }, new Review { Info = "best burger ever" } },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=false, Iceberg=false, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=true,
                        Cheddar=true, BlueCheese=false, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=true, Egg=false, Rocket=false,
                        Bbq=false, Pickels=true, VeggieBurger=false, Bacon=true, RedOnion=false, Coleslaw=false, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=true, Veggie=false, Cheesy=true, Smash=false, Spicy=false, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=false, Crispy=true, Bacon=true },
                        Image="https://glovo.dhmedia.io/image/menus-glovo/products/72f95088b2b76c598d418c34d1622b086becb2f310896b02de28d2c051c5cc28?t=W3siYXZpZiI6eyJxIjoibG93In19LHsicmVzaXplIjp7IndpZHRoIjoyNjAsImhlaWdodCI6MjYwfX1d"
                    },
                    new Burger
                    {
                        Id="RustyBacon", Name="Bacon Jam Burger", Rating=4.1, Price=24.60, Reviews=new List < Review > { new Review { Info = "yummy" }, new Review { Info = "absolutely delicious" }, new Review { Info = "not so good" } },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=true, Iceberg=true, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=true,
                        Cheddar=true, BlueCheese=false, Bri=false, Jam=true, Jalapenos=false, Avocado=false, CaramelisedOnion=false, Egg=false, Rocket=false,
                        Bbq=true, Pickels=false, VeggieBurger=false, Bacon=true, RedOnion=false, Coleslaw=false, Ranch=false, Pesto=false, MozarellaSticks=false,
                        Labels=new Label{ Classic=true, Veggie=false, Cheesy=true, Smash=false, Spicy=false, Loaded=false, Bbq=true, Gourmet=false, DoubleStack=false, Crispy=false, Bacon=true },
                        Image="https://glovo.dhmedia.io/image/menus-glovo/products/de175453ba57bf73269e9e7481875fae3b74c0ee232c0c4ca39842df8ced0258?t=W3siYXZpZiI6eyJxIjoibG93In19LHsicmVzaXplIjp7IndpZHRoIjoyNjAsImhlaWdodCI6MjYwfX1d"
                    },
                    new Burger
                    {
                        Id="RustySavage", Name="Rusty Savage Burger", Rating=3.9, Price=30.19, Reviews=new List<Review> { new Review { Info = "awesome" }, new Review {Info="too expensive, although it is big"} },
                        Beef=true, PulledPork=false, Chicken=false, Tomato=false, Iceberg=false, Mayo=false, HotSause=false, Aioli=false, BurgerSauce=true,
                        Cheddar=true, BlueCheese=true, Bri=false, Jam=false, Jalapenos=false, Avocado=false, CaramelisedOnion=true, Egg=false, Rocket=false,
                        Bbq=false, Pickels=true, VeggieBurger=false, Bacon=true, RedOnion=false, Coleslaw=true, Ranch=false, Pesto=false,
                        Labels=new Label{ Classic=true, Veggie=false, Cheesy=true, Smash=false, Spicy=false, Loaded=false, Bbq=false, Gourmet=false, DoubleStack=true, Crispy=true, Bacon=true },
                        Image="https://glovo.dhmedia.io/image/menus-glovo/products/2b09011a83afd74c1e013a00af99c0216f68ad3f04800f2839b8011a88907ec8?t=W3siYXZpZiI6eyJxIjoibG93In19LHsicmVzaXplIjp7IndpZHRoIjoyNjAsImhlaWdodCI6MjYwfX1d"
                    },
                }, Phone="0887782525", WebSite="https://rusty.bg/"
            },
            };
            return restaurants;
        }
    }
}
