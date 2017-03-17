using SMS.Entities;
using SMS.Models.ParentInfoViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SMS.Services.Providers
{
    public interface IParentInfoProvider
    {
        bool Save(ParentInfoViewModel model);
        ParentInfoViewModel Edit(int parentId);
        bool Delete(int parentId);

    }
    public class ParentInfoProvider : IParentInfoProvider
    {
        private readonly SMSEntities _ent;
        public ParentInfoProvider()
        {
            this._ent = new SMSEntities();

        }

        public bool Delete(int parentId)
        {
            var data = _ent.ParentInfoes.Where(model => model.ParentId == parentId).FirstOrDefault();
            if (data != null)
            {
                data.DeletedBy = 2;
                data.DeletedDate = DateTime.UtcNow;
                _ent.Entry(data).State = EntityState.Modified;
                _ent.SaveChanges();
            }
            return true;
        }

        public ParentInfoViewModel Edit(int parentId)
        {
            ParentInfoViewModel model = new ParentInfoViewModel();
            var data = _ent.ParentInfoes.Where(x => x.ParentId == parentId).FirstOrDefault();
            if (data != null)
            {
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
                model.Occupation = data.Occupation;
                model.Gender = data.Gender;
                model.EmailId = data.EmailId;
                model.CellNumber = data.CellNumber;
                model.PhoneNumber = data.PhoneNumber;
                model.CitizenNumber = data.CitizenNumber;
                model.Status = data.Status;

            }
            return model;
        }

        public bool Save(ParentInfoViewModel model)
        {
            ParentInfo entittyParentInfo = new ParentInfo();
            entittyParentInfo.FirstName = model.FirstName;
            entittyParentInfo.MidName = model.MidName;
            entittyParentInfo.LastName = model.LastName;
            entittyParentInfo.PState = model.PState;
            entittyParentInfo.PDistrict = model.PDistrict;
            entittyParentInfo.PMetropolitan = model.PMetropolitan;
            entittyParentInfo.PSubMetropolitan = model.PSubMetropolitan;
            entittyParentInfo.PMunicipality = model.PMunicipality;
            entittyParentInfo.PGauPalika = model.PGauPalika;
            entittyParentInfo.PWardNo = model.PWardNo;
            entittyParentInfo.TState = model.TState;
            entittyParentInfo.TDistrict = model.TDistrict;
            entittyParentInfo.TMetropolitan = model.TMetropolitan;
            entittyParentInfo.TSubMetropolitan = model.TSubMetropolitan;
            entittyParentInfo.TMunicipality = model.TMunicipality;
            entittyParentInfo.TGauPalika = model.TGauPalika;
            entittyParentInfo.TWardNo = model.TWardNo;
            entittyParentInfo.BloodGroup = model.BloodGroup;
            entittyParentInfo.Occupation = model.Occupation;
            entittyParentInfo.Gender = "Male";
            entittyParentInfo.EmailId = model.EmailId;
            entittyParentInfo.CellNumber = model.CellNumber;
            entittyParentInfo.PhoneNumber = model.PhoneNumber;
            entittyParentInfo.CitizenNumber = model.CitizenNumber;
            entittyParentInfo.Status = true;
            if (model.ParentId > 0)
            {
                entittyParentInfo.UpdatedBy = 1;
                entittyParentInfo.UpdatedDate = DateTime.UtcNow;
                _ent.Entry(entittyParentInfo).State = EntityState.Modified;
                _ent.Entry(entittyParentInfo).Property(x => x.CreatedBy).IsModified = false;
                _ent.Entry(entittyParentInfo).Property(x => x.CreatedDate).IsModified = false;

            }
            else
            {
                entittyParentInfo.CreatedBy = 1;
                entittyParentInfo.CreatedDate = DateTime.UtcNow;
                _ent.Entry(entittyParentInfo).State = EntityState.Added;
            }
            _ent.SaveChanges();
            return true;
        }
    }
}
