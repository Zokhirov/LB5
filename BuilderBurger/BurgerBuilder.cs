﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DBCon;

namespace WindowsFormsApp1.BuilderBurger
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private Burgers _burger;

        public BurgerBuilder()
        {
            _burger = new Burgers();
        }
        public Burgers GetBurgers()
        {
            Burgers burger = _burger;
            _burger = new Burgers();
            return burger;
        }

        IBurgerBuilder IBurgerBuilder.AddBacon()
        {
            _burger.Bacon = true;
            return this;
        }

        IBurgerBuilder IBurgerBuilder.AddCheese()
        {
            _burger.Bacon = true;
            return this;
        }

        IBurgerBuilder IBurgerBuilder.AddLetuce()
        {
            _burger.Bacon = true;
            return this;
        }

        IBurgerBuilder IBurgerBuilder.AddPickles()
        {
            _burger.Bacon = true;
            return this;
        }

        IBurgerBuilder IBurgerBuilder.AddTomato()
        {
            _burger.Bacon = true;
            return this;
        }
    }
}
