using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Models.SetupViewModel;
using System.Data.Entity;
using SMS.Entities;


namespace SMS.Service.Providers.SetupProviders
{
    public interface ISetupBlockProvider
    {
        bool Save(SetupBlockViewModel model);
        SetupBlockViewModel GetBlockList();
        SetupBlockViewModel Edit(int blockId);
        bool Delete(int blockId);

    }
    public class SetupBlockProvider : ISetupBlockProvider
    {
        public readonly SMSEntities _ent;
        public SetupBlockProvider()
        {
            this._ent = new SMSEntities();
        }

        public bool Delete(int blockId)
        {
            var data = _ent.SetupBlocks.Where(x => x.BlockId == blockId).FirstOrDefault();
            if (data != null)
            {
                data.DeletedBy = 1;
                data.DeletedDate = DateTime.UtcNow;
                _ent.Entry(data).State = EntityState.Modified;
                _ent.SaveChanges();
            }
            return true;
        }

        public SetupBlockViewModel Edit(int blockId)
        {
            SetupBlockViewModel model = new SetupBlockViewModel();
            var data = _ent.SetupBlocks.Where(x => x.BlockId == blockId).FirstOrDefault();
            if (data != null)
            {
                model.BlockId = data.BlockId;
                model.BlockName = data.BlockName;
                model.Status = data.Status;
            }
            return model;
        }

        public SetupBlockViewModel GetBlockList()
        {
            SetupBlockViewModel model = new SetupBlockViewModel();
            model.SetupBlockViewModelList = (from s in _ent.SetupBlocks
                                             where s.DeletedDate == null
                                             select new SetupBlockViewModel
                                             {
                                                 BlockId = s.BlockId,
                                                 BlockName = s.BlockName,
                                                 Status = s.Status

                                             }).ToList();
            return model;
        }

        public bool Save(SetupBlockViewModel model)
        {
            SetupBlock entitySetupBlock = new SetupBlock();
            entitySetupBlock.BlockName = model.BlockName;
            entitySetupBlock.Status = true;
            if (model.BlockId > 0)
            {
                entitySetupBlock.UpdatedBy = 2;
                entitySetupBlock.UpdatedDate = DateTime.UtcNow;
                _ent.Entry(entitySetupBlock).State = EntityState.Modified;
                _ent.Entry(entitySetupBlock).Property(x => x.CreatedBy).IsModified = false;
                _ent.Entry(entitySetupBlock).Property(x => x.CreatedDate).IsModified = false;
            }
            else
            {
                entitySetupBlock.CreatedBy = 1;
                entitySetupBlock.CreatedDate = DateTime.UtcNow;
                _ent.Entry(entitySetupBlock).State = EntityState.Added;

            }
            _ent.SaveChanges();
            return true;

        }
    }
}
