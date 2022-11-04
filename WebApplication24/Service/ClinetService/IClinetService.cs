using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Model;
using WebApplication24.ViewModels;
using static WebApplication24.Service.ClinetService.ClinetService;

namespace WebApplication24.Service.ClinetService
{
   public interface IClinetService
    {
        List<Clinet> GetClinetList();
        Clinet GetClinetById(int Clinetid);
        ResponseModel SaveClinet(Clinetlist ClinetListModel);
        
        ResponseModel updateClinet(Clinetlist ClinetlistModel);
        ResponseModel DeleteClinet(int Clinetid);
    }
}
