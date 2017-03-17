using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Models.GuardianInfoViewModel;
using SMS.Entities;
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
            throw new NotImplementedException();
        }
    }
}
