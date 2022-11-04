using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Models;
using WebApplication24.ViewModels;

namespace WebApplication24.Service.SemesterService
{
    public class SemesterService : ISemesterService
    {
        private erpContext _context;
        public SemesterService(erpContext context)
        {
            _context = context;
        }



        public class SemesterList
        {
            public int SemesterId { get; set; }
            public string Semester1 { get; set; }
            public int Year { get; set; }
            public DateTime DateFrom { get; set; }
            public DateTime DateTo { get; set; }
            public bool? IsClosed { get; set; }

        }





        public List<SemesterList> GetSemesterAndYearStudyList()
        {


            try
            {

                List<SemesterList> _list = new List<SemesterList>();
                var items =
         (from x in _context.Semesters
          select new
          {
              x.SemesterId,
              x.Semester1,
            
              x.DateFrom,
              x.DateTo,
              x.IsClosed,
              Year = x.YearNavigation.YearStudyId,
           

          }).ToList();
                foreach (var itm in items)
                {
                    SemesterList _li = new SemesterList();
                    _li.DateFrom = itm.DateFrom;
                    _li.DateTo = itm.DateTo;
                    _li.SemesterId = itm.SemesterId;
                    _li.Semester1 = itm.Semester1;
                  
                    _li.IsClosed = itm.IsClosed;
                    _list.Add(_li);

                }

                return _list;

            }
            catch (Exception ex)
            {
                throw;
                return null;
            }




        }
        public List<SemesterList> GetYearStudyByYear(int YearStudyId)
        {
           
            try
            {

                List<SemesterList> _list = new List<SemesterList>();

                var items =
                (from x in _context.Semesters
                 where x.Year== YearStudyId
                  select new 
                
        {

                x.SemesterId,
                x.Semester1,
                x.DateFrom,
                x.DateTo,
                x.IsClosed,




        }).ToList();
                foreach (var itm in items)
                {
                    SemesterList _li = new SemesterList();
                    _li.DateFrom = itm.DateFrom;
                    _li.DateTo = itm.DateTo;
                    _li.SemesterId = itm.SemesterId;
                    _li.Semester1 = itm.Semester1;

                    _li.IsClosed = itm.IsClosed;
                    _list.Add(_li);

                }


                return _list;



            }
            catch (Exception)
            {
                throw;
                return null;
            }

          
        }

        public Semester GetYearStudyById(int SemesterId)
        {
            Semester _Semester;
            try
            {
               _Semester = _context.Find<Semester>(SemesterId);
            }
            catch (Exception)
            {
                throw;
            }

            return _Semester;
        }
        public ResponseModel SaveSemester(SemesterList SemesterListModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Semester _Semester = new Semester();
                _Semester.Semester1 = SemesterListModel.Semester1;
              
                _Semester.DateFrom = SemesterListModel.DateFrom;
                _Semester.DateTo = SemesterListModel.DateTo;
                _Semester.IsClosed = SemesterListModel.IsClosed;
                _Semester.Year = SemesterListModel.Year;


                _context.Add<Semester>(_Semester);


                _context.SaveChanges();
                model.Messsage = "Semester Inserted Successfully";
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

        public ResponseModel updateSemester(SemesterList SemesterListModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Semester _Semester = GetYearStudyById(SemesterListModel.SemesterId);
                if (_Semester != null)
                {

                    _Semester.Semester1 = SemesterListModel.Semester1;
                  
                    _Semester.DateFrom = SemesterListModel.DateFrom;
                    _Semester.DateTo = SemesterListModel.DateTo;
                    _Semester.IsClosed = SemesterListModel.IsClosed;
                    _Semester.Year = SemesterListModel.Year;
                    _context.Update<Semester>(_Semester);

                    model.Messsage = "Semester Update Successfully";
                }
                else
                {
                    _context.Add<Semester>(_Semester);
                    model.Messsage = "Semester Inserted Successfully";
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
        public ResponseModel DeleteSemester(int SemesterId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Semester _Semester = GetYearStudyById(SemesterId);
                if (_Semester != null)
                {
                    _context.Remove<Semester>(_Semester);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Messsage = "Semester Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Messsage = "Semester Not Found";
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }






    }
}
