using System;
using System.Collections.Generic;
using System.Text;

namespace Agenda.Models.Interfaces
{
    public interface IAgenda
    {

        int Id
        {
            get;
            set;
        }

        string Name
        {
            get;
            set;
        }

        string Number
        {
            get;
            set;
        }

        string Address
        {
            get;
            set;
        }




    }
}
