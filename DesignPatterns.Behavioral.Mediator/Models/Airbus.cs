﻿using DesignPatterns.Behavioral.MediatorDemo.Interfaces;

namespace DesignPatterns.Behavioral.MediatorDemo.Models
{
    internal class Airbus : Aircraft
    {
        public Airbus(string callSign, IAirTrafficControl mediator)
            : base(callSign, mediator)
        {

        }

        public override int Ceiling => 40000;
    }
}
