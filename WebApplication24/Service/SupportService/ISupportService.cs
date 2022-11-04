using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Model;
using WebApplication24.ViewModels;
using static WebApplication24.Service.SupportService.SupportService;

namespace WebApplication24.Service.SupportService
{
   public interface ISupportService
    {
        List<SupporList> GetSupportbyclinetid(int ClinetId);
        Support GetSupportById(int SupportId);
        ResponseModel DeleteSuppor(int SupportId);
        ResponseModel SaveSupport(SupporList SupporListModel);
      
        List<SupporList> GetticketByClinetid(int Id);






    }
}
