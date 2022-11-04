using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Models;
using WebApplication24.ViewModels;

namespace WebApplication24.Service.Edu_skillitemService
{
    public class EduSkillitemService : IEduSkillitemService
    {

        private erpContext _context;
        public EduSkillitemService(erpContext context)
        {
            _context = context;
        }
        public class EduSkillItemList1
        {
            public string ItemName { get; set; }
            public int SkillItemId { get; set; }
            public int SkillD { get; set; }
            public string SkillName { get; set; }
            public string FieldName { get; set; }

        }
        public List<EduSkillItemList1> GetEduFieldSkillItemlList()
        {
          
         
            try
            {
        
                List<EduSkillItemList1> _list = new List<EduSkillItemList1>();
          var   items =
   (from x in _context.EduFieldSkillItems
                            select new
                            {
                                 x.ItemName,
                                 x.SkillItemId,
                                 x.SkillD,
                                SkillName= x.SkillDNavigation.SkillName,
                                FieldName=   x.SkillDNavigation.Field.FieldName
                              
                            }).ToList()  ;
                foreach(var itm in items)
                {
                    EduSkillItemList1 _li = new EduSkillItemList1();
                    _li.FieldName = itm.FieldName;
                    _li.SkillName = itm.SkillName;
                    _li.SkillD = itm.SkillD;
                    _li.SkillItemId = itm.SkillItemId;
                    _li.ItemName= itm.ItemName;
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
        public EduFieldSkillItem GetEduFieldSkillItemDetailsById(int SkillId)
        {
            EduFieldSkillItem SkillD , SkillName;
            try
            {
                SkillD = _context.Find<EduFieldSkillItem>(SkillId);
            }
            catch (Exception)
            {
                throw;
            }
            return SkillD ;
            return SkillName;
        }

        public ResponseModel SaveEduFieldSkillItem(EduSkillItem EduFieldSkillItemModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                EduFieldSkillItem _eduFieldSkill = new EduFieldSkillItem();
                    _eduFieldSkill.ItemName = EduFieldSkillItemModel.ItemName;
                    _eduFieldSkill.SkillD = EduFieldSkillItemModel.SkillD;
                    _context.Add<EduFieldSkillItem>(_eduFieldSkill);

               
                _context.SaveChanges();
                model.Messsage = "EduField Inserted Successfully";
                model.IsSuccess = true;
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

        public ResponseModel UpdateEduFieldSkillItem(EduSkillItem EduFieldSkillItemModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                EduFieldSkillItem _EduFieldSkillItem = GetEduFieldSkillItemDetailsById(EduFieldSkillItemModel.SkillItemId);
                if (_EduFieldSkillItem != null)
                {
                    _EduFieldSkillItem.ItemName = EduFieldSkillItemModel.ItemName;
                    _EduFieldSkillItem.SkillD = EduFieldSkillItemModel.SkillD;
                    _context.Update<EduFieldSkillItem>(_EduFieldSkillItem);

                    model.Messsage = "EduFieldSkillItem Update Successfully";
                }
                else
                {
                    _context.Add<EduFieldSkillItem>(_EduFieldSkillItem);
                    model.Messsage = "EduFieldSkillItem Inserted Successfully";
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


        public ResponseModel DeleteEduFieldSkillItem(int SkillItemId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                EduFieldSkillItem _EduSkillItem = GetEduFieldSkillItemDetailsById(SkillItemId);
                if (_EduSkillItem != null)
                {
                    _context.Remove<EduFieldSkillItem>(_EduSkillItem);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Messsage = "EduSkillItem Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Messsage = "EduSkillItem Not Found";
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

       
















        public class EduSkillItem
        {
            public int SkillItemId { get; set; }
            public int SkillD { get; set; }
            public string ItemName { get; set; }
        }
        









    }
}
