using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Models.SetupViewModel;
using SMS.Entities;
using System.Data.Entity;

namespace SMS.Services.Providers
{
    public interface ISetupSubjectProvider
    {
        SetupSubjectViewModel GetList();
        bool Save(SetupSubjectViewModel model);
        SetupSubjectViewModel GetSubjectInfoById(int subjectId);
        bool Delete(int subjectId);

    }
    public class SetupSubjectProvider : ISetupSubjectProvider
    {
        private readonly SMSEntities _ent;
        public SetupSubjectProvider()
        {
            _ent = new SMSEntities();
        }
        public SetupSubjectViewModel GetList()
        {

            SetupSubjectViewModel model = new SetupSubjectViewModel();
            model.SetupSubjectViewModelList = (from s in _ent.SetupSubjects
                                               where s.DeletedDate == null
                                               select new SetupSubjectViewModel
                                               {
                                                   SubjectId = s.SubjectId,
                                                   SubjectName = s.SubjectName

                                               }
                                               ).ToList();
            return model;
        }
        public bool Save(SetupSubjectViewModel model)
        {
            var setupSubjectEntity = new SetupSubject();
            setupSubjectEntity.SubjectName = model.SubjectName;
            setupSubjectEntity.IsOptional = model.IsOptional;

            if (model.SubjectId > 0)
            {
                setupSubjectEntity.UpdatedDate = DateTime.UtcNow;
                setupSubjectEntity.UpdatedBy = 1;
                _ent.Entry(setupSubjectEntity).State = EntityState.Modified;
                _ent.Entry(setupSubjectEntity).Property(x => x.CreatedBy).IsModified = false;
                _ent.Entry(setupSubjectEntity).Property(x => x.CreatedDate).IsModified = false;
            }
            else
            {
                setupSubjectEntity.CreatedDate = DateTime.UtcNow;
                setupSubjectEntity.CreatedBy = 1;
                _ent.Entry(setupSubjectEntity).State = System.Data.Entity.EntityState.Added;
            }
            _ent.SaveChanges();
            return true;
        }

        public SetupSubjectViewModel GetSubjectInfoById(int subjectId)
        {
            SetupSubjectViewModel model = new SetupSubjectViewModel();
            var data = _ent.SetupSubjects.Where(x => x.SubjectId == subjectId).FirstOrDefault();
            if (data != null)
            {
                model.SubjectId = data.SubjectId;
                model.SubjectName = data.SubjectName;
                model.IsOptional = data.IsOptional??false;
            }
            return model;
        }
        
        public bool Delete(int subjectId)
        {
            throw new NotImplementedException();
        }
    }
}
