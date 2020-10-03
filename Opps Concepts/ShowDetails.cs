using System;
using System.Collections.Generic;
using System.Text;

namespace OppsConcept
{
    class ShowDetails
    {                                   
        public ShowDetails(IPerson I)               // Loosely coupled. 
        {
            I.Show();
        }
    }
}
