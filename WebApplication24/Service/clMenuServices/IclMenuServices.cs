using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.ViewModels;
using static WebApplication24.Service.clMenuServices.clMenuServices;

namespace WebApplication24.Service.clMenuServices
{
   public interface IclMenuServices
    {
        List<clMenuitem> SaveclMenu( clMenuitem clMenuitemListModel, float Discountvalue);
        List<clMenuitem> GetmaxSalaryandmin();
    }
}
