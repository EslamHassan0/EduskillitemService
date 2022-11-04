using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Model;
using WebApplication24.ViewModels;

namespace WebApplication24.Service.ClinetService
{
    public class ClinetService :IClinetService
    {
        private masterContext _context;
        public ClinetService(masterContext context)
        {
            _context = context;
        }
        public class Clinetlist
        {
            public int Clinetid { get; set; }
            public string Name { get; set; }
            public string Mobile { get; set; }
           
            public DateTime? PostDate { get; set; }
        }
        public List<Clinet> GetClinetList()
        {
            List<Clinet> ClinetList;
            try
            {
                ClinetList = _context.Set<Clinet>().ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
            return ClinetList;
        }


        public Clinet GetClinetById(int Clinetid)
        {
            Clinet _Clinet;
            try
            {
                _Clinet = _context.Find <Clinet > (Clinetid);
            }
            catch (Exception ex)
            {
                throw;
            }

            return _Clinet;
        }






        public ResponseModel SaveClinet(Clinetlist ClinetListModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Clinet _Clinet = new Clinet();
               
                _Clinet.Name = ClinetListModel.Name;
                _Clinet.Mobile = ClinetListModel.Mobile;
                _Clinet.PostDate = ClinetListModel.PostDate;




                _context.Add<Clinet>(_Clinet);



                _context.SaveChanges();
                model.Messsage = "Clinet Inserted Successfully";
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }
        public ResponseModel updateClinet(Clinetlist ClinetlistModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Clinet _Clinet = GetClinetById(ClinetlistModel.Clinetid);
                if (_Clinet != null)
                {

                    _Clinet.Name = ClinetlistModel.Name;

                    _Clinet.Mobile = ClinetlistModel.Mobile;
                    _Clinet.PostDate = ClinetlistModel.PostDate;
              
                   
                    _context.Update<Clinet>(_Clinet);

                    model.Messsage = "Clinet Update Successfully";
                }
                else
                {
                    _context.Add<Clinet>(_Clinet);
                    model.Messsage = "Clinet Inserted Successfully";
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
        public ResponseModel  DeleteClinet(int Clinetid)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                Clinet _Clinet = GetClinetById(Clinetid);
                if (_Clinet != null)
                {
                    _context.Remove<Clinet>(_Clinet);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Messsage = "Employee Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Messsage = "Employee Not Found";
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
