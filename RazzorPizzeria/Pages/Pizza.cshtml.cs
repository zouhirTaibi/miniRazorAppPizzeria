using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazzorPizzeria.Models;

namespace RazzorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDb = new List<PizzasModel>()
        {
            new PizzasModel(){
                ImageTitle="france",
                PizzaName="france",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4},
            new PizzasModel(){
                ImageTitle="American",
                PizzaName="American",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4},
            new PizzasModel(){
                ImageTitle="Hawaiin",
                PizzaName="Hawaiin",
                BasePrice=3,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=22},
            new PizzasModel(){
                ImageTitle="morocco",
                PizzaName="morocco",
                BasePrice=5,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=14},
            new PizzasModel(){
                ImageTitle="MeatFeast",
                PizzaName="MeatFeast",
                BasePrice=6,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=124},
            new PizzasModel(){
                ImageTitle="Mushroom",
                PizzaName="Mushroom",
                BasePrice=22,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=422},
            new PizzasModel(){
                ImageTitle="Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=22,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=422},
            new PizzasModel(){
                ImageTitle="SeaFood",
                PizzaName="Seafood",
                BasePrice=24,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4222},
            new PizzasModel(){
                ImageTitle="Vegetarian",
                PizzaName="Vegetarian",
                BasePrice=222,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4223}


        };
        public void OnGet()
        {
        }
    }
}
