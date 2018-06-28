using System;
using System.Collections.Generic;
using System.Text;
using Agenda.Models.Interfaces;

namespace Agenda.DAL
{
    public class AgendaRepository
    {
        private string _ConnectionString
        {
            set;
            get;
        }


        public AgendaRepository()
        {
            _ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Agenda;Trusted_Connection=True;";
        }
       
    }
}
