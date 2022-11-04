using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Models;
using WebApplication24.ViewModels;
using static WebApplication24.Service.SemesterService.SemesterService;

namespace WebApplication24.Service.SemesterService
{
   public interface ISemesterService
    {
        List<SemesterList> GetSemesterAndYearStudyList();
        Semester GetYearStudyById(int SemesterId);
        List<SemesterList> GetYearStudyByYear(int YearStudyId);
        ResponseModel SaveSemester(SemesterList SemesterListModel);
        ResponseModel updateSemester(SemesterList SemesterListModel);
        ResponseModel DeleteSemester(int SemesterId);







    }
}
