using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Models;
using WebApplication24.ViewModels;

namespace WebApplication24.Service.YearStudyService
{
    public class YearStudyService : IYearStudyService
    {
        private erpContext _context;
        public YearStudyService(erpContext context)
        {
            _context = context;
        }
        public List<YearStudy> GetYearStudyList()
        {
            List<YearStudy> YearStudyServiceList;
            try
            {
                YearStudyServiceList = _context.Set<YearStudy>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return YearStudyServiceList;
        }
        public YearStudy GetYearStudyById(int YearStudyId)
        {
            YearStudy _YearStudy;
            try
            {
                _YearStudy = _context.Find<YearStudy>(YearStudyId);
            }
            catch (Exception)
            {
                throw;
            }
        
            return _YearStudy;
        }
        public ResponseModel SaveYearStudy(SaveYearStudyItem SaveYearStudyItemModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                YearStudy _YearStudy = new YearStudy();
                _YearStudy.Year = SaveYearStudyItemModel.Year;
                _YearStudy.DateTo = SaveYearStudyItemModel.DateTo;
                _YearStudy.DateFrom = SaveYearStudyItemModel.DateFrom;
                _YearStudy.IsClosed = SaveYearStudyItemModel.IsClosed;
          
                _context.Add<YearStudy>(_YearStudy);


                _context.SaveChanges();
                model.Messsage = "YearStudy Inserted Successfully";
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }
        public ResponseModel updateYearStudy(SaveYearStudyItem SaveYearStudyItemModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                YearStudy _SaveYearStudyItem = GetYearStudyById(SaveYearStudyItemModel.YearStudyId);
                if (_SaveYearStudyItem != null)
                {
                    _SaveYearStudyItem.DateFrom = SaveYearStudyItemModel.DateFrom;
                    _SaveYearStudyItem.DateTo = SaveYearStudyItemModel.DateTo;
                    _SaveYearStudyItem.Year = SaveYearStudyItemModel.Year;
                    _SaveYearStudyItem.YearStudyId = SaveYearStudyItemModel.YearStudyId;
                    _context.Update<YearStudy>(_SaveYearStudyItem);

                    model.Messsage = "YearStudy Update Successfully";
                }
                else
                {
                    _context.Add<YearStudy>(_SaveYearStudyItem);
                    model.Messsage = "YearStudy Inserted Successfully";
                }
                _context.SaveChanges();
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }
        public ResponseModel DeleteYearStudy(int YearStudyId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                YearStudy _YearStudy = GetYearStudyById(YearStudyId);
                if (_YearStudy != null)
                {
                    _context.Remove<YearStudy>(_YearStudy);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Messsage = "YearStudy Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Messsage = "YearStudy Not Found";
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }


        public class SaveYearStudyItem
        {
            public int YearStudyId { get; set; }
            public int Year { get; set; }
            public DateTime DateFrom { get; set; }
            public DateTime DateTo { get; set; }
            public bool IsClosed { get; set; }
        }





    }
}
