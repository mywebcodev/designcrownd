using System;
using System.Collections.Generic;

namespace DesignCrowd.Services
{
    public interface IGetAllHolidays
    {
        IEnumerable<DateTime> GetAll(int year);
    }
}