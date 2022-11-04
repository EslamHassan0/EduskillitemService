using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication24.Models;
using WebApplication24.ViewModels;

namespace WebApplication24.Service.EduFieldService
{
    public class EduFieldService : IEduFieldService
    {
        public class EduSkillList
        {
            public int Eduskillid { get; set; }

            public string skillname { get; set; }
           
        
            public string Edufieldname { get; set; }
        }
        public class broplemsList
        {
            public int ProblemGroupId { get; set; }

            public string ProblemName { get; set; }
          
        public string ProbGroupName { get; set; }





        }

        private erpContext _context;
        public EduFieldService(erpContext context)
        {
            _context = context;
        }
        public List<EduField> GetEduFieldList()
        {
            List<EduField> EduFieldList;
            try
            {
                EduFieldList = _context.Set<EduField>().ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return EduFieldList;
        }
        public EduField GetEduFieldDetailsById(int EduField)
        {
            EduField Edu;
            try
            {
                Edu = _context.Find<EduField>(EduField);
            }
            catch (Exception)
            {
                throw;
            }
            return Edu;
        }
        public ResponseModel SaveEduField(EduField EduFieldModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                EduField _eduField = new EduField();
                if (_eduField != null)
                {
                    _eduField.FieldName = EduFieldModel.FieldName;

                    model.Messsage = "EduField add Successfully";
                }
                else
                {
                    _context.Add<EduField>(EduFieldModel);
                    model.Messsage = "EduField Inserted Successfully";
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
        public ResponseModel DeleteEduField(int EduFieldId)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                EduField _opject = GetEduFieldDetailsById(EduFieldId);
                if (_opject != null)
                {
                    _context.Remove<EduField>(_opject);
                    _context.SaveChanges();
                    model.IsSuccess = true;
                    model.Messsage = "EduField Deleted Successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Messsage = "EduField Not Found";
                }
            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }

        public ResponseModel SaveEduSkill(EduSkillList EduSkillListModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                if(EduSkillListModel.Eduskillid == 0)

                {
                    EduField _Edu = new EduField();
                    EduFieldSkill _skill = new EduFieldSkill();
                    _Edu.FieldName = EduSkillListModel.Edufieldname;
                    _skill.SkillName = EduSkillListModel.skillname;


             
                    _skill.Field= _Edu;
                   //_Edu.EduFieldSkills = (ICollection<EduFieldSkill>)_skill;

                  


                    _context.Add<EduField>(_Edu);
                    _context.Add<EduFieldSkill>(_skill);
                   
                    model.Messsage = "EduSkill add Successfully";
                }
                try
                {
                    _context.SaveChanges();

                    model.Messsage = "EduSkill add Successfully";
                    model.IsSuccess = true;
                }
                catch (Exception Ex)
                {
                    model.Messsage = "EduSkill failed ";
                    model.IsSuccess = false;

                }




            }
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }
        public ResponseModel SavePsyProblem(broplemsList broplemsListModel)
        {
            ResponseModel model = new ResponseModel();
            try
            {
                if (broplemsListModel.ProblemGroupId == 0)

                {
                    PsyProblem _PsyProblem = new PsyProblem();
                    PsyProblemGroup _PsyProblemGroup = new PsyProblemGroup();
                    _PsyProblem.ProblemName = broplemsListModel.ProblemName;
                    _PsyProblemGroup.ProbGroupName = broplemsListModel.ProbGroupName;



                    _PsyProblem.ProblemGroup = _PsyProblemGroup;





                    _context.Add<PsyProblem>(_PsyProblem);
                    _context.Add<PsyProblemGroup>(_PsyProblemGroup);

                    model.Messsage = "PsyProblemGroup add Successfully";
                }
               else if (broplemsListModel.ProblemGroupId != 0)
                {
                    PsyProblem _PsyProblem = new PsyProblem();
                    PsyProblemGroup _PsyProblemGroup = GetPsyProblemGroupById(broplemsListModel.ProblemGroupId);
                    _PsyProblem.ProblemName = broplemsListModel.ProblemName;
                    _PsyProblemGroup.ProbGroupName = broplemsListModel.ProbGroupName;
                    _PsyProblem.ProblemGroupId = broplemsListModel.ProblemGroupId;
                    _context.Add<PsyProblem>(_PsyProblem);
                  //  _context.Update<PsyProblemGroup>(_PsyProblemGroup);
                    _context.SaveChanges();

                }

                try
                    {
                        _context.SaveChanges();

                        model.Messsage = "PsyProblemGroup add Successfully";
                        model.IsSuccess = true;
                    }
                    catch (Exception Ex)
                    {
                        model.Messsage = "PsyProblemGroup failed ";
                        model.IsSuccess = false;

                    }




                } 
            catch (Exception ex)
            {
                model.IsSuccess = false;
                model.Messsage = "Error : " + ex.Message;
            }
            return model;
        }
        public PsyProblemGroup GetPsyProblemGroupById(int PsyProblemGroupID)
        {
            PsyProblemGroup PPG;
            try
            {
                PPG = _context.Find<PsyProblemGroup>(PsyProblemGroupID);
            }
            catch (Exception)
            {
                throw;
            }
            return PPG;
        }




    }
}

