using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Models.GuardianInfoViewModel;
using SMS.Entities;
using System.Data.Entity;

namespace SMS.Services.Providers
{
    public interface IGuardianInfoProvider
    {
        bool Save(GuardianInfoViewModel model);
        GuardianInfoViewModel Edit(int guardianId);
        bool Delete(int guardianId);

    }
    public class GuardianInfoProvider : IGuardianInfoProvider
    {
        private readonly _ent;
        public GuardianInfoProvider()
        {
            _ent = new SMSEntities();//sdf
        }
        public bool Delete(int guardianId)
        {
            throw new NotImplementedException();
        }

        public GuardianInfoViewModel Edit(int guardianId)
        {
            throw new NotImplementedException();
        }

        public bool Save(GuardianInfoViewModel model)
        {

            GuardianInfo entittyGuardianInfo = new GuardianInfo();
            entittyGuardianInfo.FirstName = model.FirstName;
            entittyGuardianInfo.MidName = model.MidName;
            entittyGuardianInfo.LastName = model.LastName;
            entittyGuardianInfo.PState = model.PState;
            entittyGuardianInfo.PDistrict = model.PDistrict;
            entittyGuardianInfo.PMetropolitan = model.PMetropolitan;
            entittyGuardianInfo.PSubMetropolitan = model.PSubMetropolitan;
            entittyGuardianInfo.PMunicipality = model.PMunicipality;
            entittyGuardianInfo.PGauPalika = model.PGauPalika;
            entittyGuardianInfo.PWardNo = model.PWardNo;
            entittyGuardianInfo.TState = model.TState;
            entittyGuardianInfo.TDistrict = model.TDistrict;
            entittyGuardianInfo.TMetropolitan = model.TMetropolitan;
            entittyGuardianInfo.TSubMetropolitan = model.TSubMetropolitan;
            entittyGuardianInfo.TMunicipality = model.TMunicipality;
            entittyGuardianInfo.TGauPalika = model.TGauPalika;
            entittyGuardianInfo.TWardNo = model.TWardNo;
            entittyGuardianInfo.BloodGroup = model.BloodGroup;
            entittyGuardianInfo.Occupation = model.Occupation;
            entittyGuardianInfo.Gender = "Male";
            entittyGuardianInfo.EmailId = model.EmailId;
            entittyGuardianInfo.CellNumber = model.CellNumber;
            entittyGuardianInfo.PhoneNumber = model.PhoneNumber;
            entittyGuardianInfo.CitizenNumber = model.CitizenNumber;
            entittyGuardianInfo.Status = true;
            if (model.GuardianId > 0)
            {
                entittyGuardianInfo.UpdatedBy = 1;
                entittyGuardianInfo.UpdatedDate = DateTime.UtcNow;
                _ent.Entry(entittyGuardianInfo).State = EntityState.Modified;
                _ent.Entry(entittyGuardianInfo).Property(x => x.CreatedBy).IsModified = false;
                _ent.Entry(entittyGuardianInfo).Property(x => x.CreatedDate).IsModified = false;

            }
            else
            {
                entittyGuardianInfo.CreatedBy = 1;
                entittyGuardianInfo.CreatedDate = DateTime.UtcNow;
                _ent.Entry(entittyGuardianInfo).State = EntityState.Added;
            }
            _ent.SaveChanges();
            return true;
        }
    
    }
}
