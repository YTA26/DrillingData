using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTA.DrillingData.NTier.Core.Entities;

namespace YTA.DrillingData.NTier.Entities.Concrete
{
    public class DrillCollar:IEntity
    {                     
              
        public string HoleID { get; set; }

        public decimal Easting { get; set; }

        public decimal Northing { get; set; }

        public decimal Elevation { get; set; }
        
        public string Projection { get; set; }
        
        public string Zone { get; set; }

        public decimal TotalDepth { get; set; }

        public decimal AzimuthMag { get; set; }

        public decimal Dip { get; set; }
        
        public string Permit { get; set; }
        
        public string Prospect { get; set; }
        
        public string ProposedHoleID { get; set; }

        public decimal PlannedDepth { get; set; }
        
        public string StartDate { get; set; }
        
        public string EndDate { get; set; }
        
        public string Geologist { get; set; }
        
        public string DrillingType { get; set; }
        
        public string TypeCode { get; set; }
        
        public string Phase { get; set; }
        
        public string Contractor { get; set; }
        
        public string Rig { get; set; }
        
        public string DhSurveyMethod { get; set; }
        
        public string DhSurveyor { get; set; }
        
        public string SurveyDate { get; set; }
        
        public string HoleStatus { get; set; }
        
        public string Comment { get; set; }
    }
}
