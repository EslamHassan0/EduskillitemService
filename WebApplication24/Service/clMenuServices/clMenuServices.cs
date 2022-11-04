using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.ViewModels;

namespace WebApplication24.Service.clMenuServices
{

    public class clMenuServices : IclMenuServices
    {
        private ServiceContext _context;
        public clMenuServices(ServiceContext context)
        {
            _context = context;
        }
        public class clMenuitem
        {
            public int MenuId { get; set; }
            public float ServicePrice { get; set; }
            public bool IsDelete { get; set; }
            public int ServiceId { get; set; }
            public bool? IsSyndicate { get; set; }

        }





        public List<clMenuitem> SaveclMenu(clMenuitem clMenuitemListModel, float Discountvalue)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                //    ClMenu _clMenu = new ClMenu();

                //    _clMenu.MenuName = clMenu.MenuName;
                //    _clMenu.DiscountRatio = clMenu.DiscountRatio;
                //    _clMenu.DiscountRelationRatio = 0;
                //    _clMenu.Notes = clMenu.Notes;
                //    _context.Add<ClMenu>(_clMenu);




                var item = (from x in _context.ClServices select new { x.ServicePrice, x.ServiceId }).ToList();

                foreach (var itm in item)
                {
                    //clMenuitem _li = new clMenuitem();
                    ClMenuService _observice = new ClMenuService();
                    _observice.ServicePrice = (float)(Discountvalue * itm.ServicePrice * 0.01);
                    _observice.ServicePrice = (float)(itm.ServicePrice - _observice.ServicePrice);
                    _observice.ServiceId = itm.ServiceId;
                    _observice.MenuId = clMenuitemListModel.MenuId;
                    _observice.IsDelete = false;
                    _observice.IsSyndicate = false;




                    _context.Add<ClMenuService>(_observice);

                    // _list.Add(_li);


                }
                //return _list;










                _context.SaveChanges();
                model.Messsage = "Support Inserted Successfully";
                model.IsSuccess = true;
                return null;
            }

            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
                return null;
            }


        }


        public List<clMenuitem>  GetmaxSalaryandmin()
        {

        

            try
            {
                List<clMenuitem> _list = new List<clMenuitem>();

                var item =  new
                                   {
                                          min = _context.ClMenuServices.Max(s => s.ServicePrice),
                                          max = _context.ClMenuServices.Min(s => s.ServicePrice),
                                          sum=_context.ClMenuServices.Sum(s=>s.ServicePrice)
                                          
                                      };
                clMenuitem _li = new clMenuitem();


                _li.ServicePrice = item.max


                _list.Add(_li);

                return _list;


            }
            catch (Exception ex)
            {
                throw;
                return null;
            }
         
















        }
    }
}
