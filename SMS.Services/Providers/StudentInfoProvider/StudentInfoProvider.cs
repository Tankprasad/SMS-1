using SMS.Entities;
using SMS.Models.StudentInfoViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Services.Providers
{
    public interface IStudentInfoProvider
    {
        bool Save(StudentInfoViewModel model);
        StudentInfoViewModel Edit(int studentId);
        StudentInfoViewModel Delete(int studentId);
    }
    public class StudentInfoProvider : IStudentInfoProvider
    {
        private readonly SMSEntities _ent;
        public StudentInfoProvider()
        {
            this._ent = new SMSEntities();
        }

        public StudentInfoViewModel Edit(int studentId)
        {
            StudentInfoViewModel model = new StudentInfoViewModel();
            var data = _ent.StudentInfoes.Where(x => x.StudentId == studentId).FirstOrDefault();
            if (data != null)
            {
                model.StudentId = data.StudentId;
                model.FirstName = data.FirstName;
                model.MidName = data.MidName;
                model.LastName = data.LastName;
                model.PState = data.PState;
                model.PDistrict = data.PDistrict;
                model.PMetropolitan = data.PMetropolitan;
                model.PSubMetropolitan = data.PSubMetropolitan;
                model.PMunicipality = data.PMunicipality;
                model.PGauPalika = data.PGauPalika;
                model.PWardNo = data.PWardNo;
                model.TState = data.TState;
                model.TDistrict = data.TDistrict;
                model.TMetropolitan = data.TMetropolitan;
                model.TSubMetropolitan = data.TSubMetropolitan;
                model.TMunicipality = data.TMunicipality;
                model.TGauPalika = data.TGauPalika;
                model.TWardNo = data.TWardNo;
                model.BloodGroup = data.BloodGroup;
                model.DateOfBirth = data.DateOfBirth;
                model.EmailId = data.EmailId;
                model.CellNumber = data.CellNumber;
                model.Gender = data.Gender;
                model.ImageName = data.ImageName;
                model.ImagePath = data.ImagePath;
                model.Status = data.Status ?? false;
            }
            return model;
        }

        public bool Save(StudentInfoViewModel model)
        {

            var studentInfoEntity = new StudentInfo();
            studentInfoEntity.FirstName = model.FirstName;
            studentInfoEntity.MidName = model.MidName;
            studentInfoEntity.LastName = model.LastName;
            studentInfoEntity.PState = model.PState;
            studentInfoEntity.PDistrict = model.PDistrict;
            studentInfoEntity.PMetropolitan = model.PMetropolitan;
            studentInfoEntity.PSubMetropolitan = model.PSubMetropolitan;
            studentInfoEntity.PMunicipality = model.PMunicipality;
            studentInfoEntity.PGauPalika = model.PGauPalika;
            studentInfoEntity.PWardNo = model.PWardNo;
            studentInfoEntity.TState = model.TState;
            studentInfoEntity.TDistrict = model.TDistrict;
            studentInfoEntity.TMetropolitan = model.TMetropolitan;
            studentInfoEntity.TSubMetropolitan = model.TSubMetropolitan;
            studentInfoEntity.TMunicipality = model.TMunicipality;
            studentInfoEntity.TGauPalika = model.TGauPalika;
            studentInfoEntity.TWardNo = model.TWardNo;
            studentInfoEntity.BloodGroup = model.BloodGroup;
            studentInfoEntity.DateOfBirth = model.DateOfBirth;
            studentInfoEntity.EmailId = model.EmailId;
            studentInfoEntity.CellNumber = model.CellNumber;
            studentInfoEntity.Gender = model.Gender;
            studentInfoEntity.ImageName = model.ImageName;
            studentInfoEntity.ImagePath = model.ImagePath;
            studentInfoEntity.Status = model.Status;

            if (model.StudentId > 0)
            {
                studentInfoEntity.UpdatedDate = DateTime.UtcNow;
                studentInfoEntity.UpdatedBy = 1;
                _ent.Entry(studentInfoEntity).State = EntityState.Modified;
                _ent.Entry(studentInfoEntity).Property(x => x.CreatedBy).IsModified = false;
                _ent.Entry(studentInfoEntity).Property(x => x.CreatedDate).IsModified = false;
            }
            else
            {
                studentInfoEntity.CreatedDate = DateTime.UtcNow;
                studentInfoEntity.CreatedBy = 1;
                _ent.Entry(studentInfoEntity).State = EntityState.Added;
            }
            _ent.SaveChanges();


            return true;
        }

        public StudentInfoViewModel Delete(int studentId)
        {
            StudentInfoViewModel model = new StudentInfoViewModel();
            var data = _ent.StudentInfoes.Where(x => x.StudentId == studentId).FirstOrDefault();
            data.DeletedBy = 1;
            data.DeletedDate = DateTime.Now;
            _ent.Entry(data).State = EntityState.Modified;
            _ent.SaveChanges();
            return model;
        }


    }
}

