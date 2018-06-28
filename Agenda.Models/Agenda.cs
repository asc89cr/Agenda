using Agenda.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Models
{
    public class Agenda : IAgenda
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public string Number { get; set;}
        public string Address { get; set;}

    }
}
