using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YTA.DrillingData.NTier.Core;
using YTA.DrillingData.NTier.DataAccess.Abstract;
using YTA.DrillingData.NTier.Entities.Concrete;

namespace YTA.DrillingData.NTier.DataAccess.Concrete.EntityFramework
{
    public class EfDrillCollarDal : EfEntityRepositoryBase<DrillCollar, DrillingDataContext>, IDrillCollarDal
    {
       
    }
}

