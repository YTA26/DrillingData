using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTA.DrillingData.NTier.Entities.Concrete;

namespace YTA.DrillingData.NTier.Business.Abstract
{
    public interface IDrillCollarService
    {
        List<DrillCollar> GetAll();

        DrillCollar GetByID(string HoleID);

        DrillCollar Add(DrillCollar drillCollar);

        DrillCollar Update(DrillCollar drillCollar);

        void Delete(DrillCollar drillCollar);
    }
}
