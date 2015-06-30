﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_telefoonboek
{
    public interface ITelephoneBook
    {
        IList<IPerson> People {get; set; }

        int Count { get; }

        List<IPerson> SortByLastName();

        List<IPerson> FirstNameStartWith(char firstChar);

        List<IPerson> LastNameLongerThen(int length);

        List<IPerson> SortByLastNameLength();
    }
}
