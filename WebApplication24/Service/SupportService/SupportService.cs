using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Model;
using WebApplication24.ViewModels;

namespace WebApplication24.Service.SupportService
{
    public class SupportService : ISupportService
    {
        private masterContext _context;
        public SupportService(masterContext context)
        {
            _context = context;
        }

        public class SupporList
        {
            public int SupportId { get; set; }
            public int Serial { get; set; }
            public int? Parent { get; set; }
            public string Subject { get; set; }
            public string Message { get; set; }
            public byte Status { get; set; }
            public int ClinetId { get; set; }
            public DateTime PostDate { get; set; }
           


        }
     
        public List<SupporList> GetSupportbyclinetid(int ClinetId)
        {

            try
            {

                List<SupporList> _list = new List<SupporList>();

                var items =
                (from x in _context.Supports
                 where x.ClinetId == ClinetId
                 select new

                 {

                     x.SupportId,
                     x.Parent,
                     x.Serial,
                     x.Subject,
                     x.Status,
                     x.Message,
                     x.PostDate




                 }).ToList();
                foreach (var itm in items)
                {
                    SupporList _li = new SupporList();
                    _li.SupportId = itm.SupportId;
                    _li.Serial = itm.Serial;
                    _li.Status = itm.Status;
                    _li.Subject = itm.Subject;
                    _li.Message = itm.Message;
                    _li.PostDate = itm.PostDate;
                    _li.Parent = itm.Parent;



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
        
        public Support GetSupportById(int SupportId)
        {
            Support _Support;
            try
            {
                _Support = _context.Find<Support>(SupportId);
            }
            catch (Exception)
            {
                throw;
            }

            return _Support;
        }
        public ResponseModel SaveSupport(SupporList SupporListModel )
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Support _Support = new Support();
             
                _Support.Message = SupporListModel.Message;
                _Support.Parent = SupporListModel.Parent;
                _Support.PostDate = SupporListModel.PostDate;
                _Support.Status = SupporListModel.Status;
                _Support.Subject = SupporListModel.Subject;
                _Support.ClinetId = SupporListModel.ClinetId;



                      var item = (from x in _context.Supports where x.ClinetId == SupporListModel.ClinetId select new { x.Serial }).ToList();


                int maxserial = 0;
                if (item.Count > 0)
                {


                    maxserial = item.Max(a => a.Serial) + 1;
                   

                }
                else
                {
                    maxserial = +1;


                }
                _Support.Serial = maxserial;

                //int maxserial = 0;
                //if (item.Count > 0
                //)
                //{
                //    maxserial = item.Max(a => a.Serial) + 1;
                //}
                //else
                //{
                //    maxserial = 1;
                //}

                //_Support.Serial = maxserial;


                //int maxserial = 0;
                //if (item.Count == _Support.ClinetId)
                //{
                //    maxserial = item.Max(a=>a.Serial);
                //}
                //_Support.Serial = maxserial;




                _context.Add<Support>(_Support);


                _context.SaveChanges();
                model.Messsage = "Support Inserted Successfully";
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

        public ResponseModel DeleteSuppor(int SupportId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Support _Support = GetSupportById(SupportId);
                if (_Support != null)
                {
                    _context.Remove<Support>(_Support);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Messsage = "_Support Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Messsage = "_Support Not Found";
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }



      
        public List<SupporList> GetticketByClinetid(int Id)
        {

            try
            {

                List<SupporList> _list = new List<SupporList>();

                var items =
                (from x in _context.Supports
                 where x.ClinetId == Id
                 select new

                 {
                     x.Serial

                    




                 }).ToList();
                foreach (var itm in items)
                {
                    SupporList _li = new SupporList();
                    _li.Serial = itm.Serial;
                    
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







    }
}
