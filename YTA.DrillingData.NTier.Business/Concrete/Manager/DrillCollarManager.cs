using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTA.DrillingData.NTier.Business.Abstract;
using YTA.DrillingData.NTier.DataAccess.Abstract;
using YTA.DrillingData.NTier.Entities.Concrete;
using FluentValidation;

namespace YTA.DrillingData.NTier.Business.Concrete.Manager
{
    public class DrillCollarManager : IDrillCollarService
    {
        private IDrillCollarDal _DrillCollarDal;

        public DrillCollarManager(IDrillCollarDal drillCollarDal)
        {
            _DrillCollarDal = drillCollarDal;
        }
        [FluentValidate(typeof(DrillCollarValidation))]
        public DrillCollar Add(DrillCollar drillCollar)
        {
            return _DrillCollarDal.Add(drillCollar);
        }

        public void Delete(DrillCollar drillCollar)
        {
            _DrillCollarDal.Delete(drillCollar);
        }

        public List<DrillCollar> GetAll()
        {
            return _DrillCollarDal.GetList();
        }

        public DrillCollar GetByID(string HoleID)
        {
            return _DrillCollarDal.Get(p => p.HoleID == HoleID);
        }
        [FluentValidate(typeof(DrillCollarValidation))]
        public DrillCollar Update(DrillCollar drillCollar)
        {
            return _DrillCollarDal.Update(drillCollar);
        }
    }
}
