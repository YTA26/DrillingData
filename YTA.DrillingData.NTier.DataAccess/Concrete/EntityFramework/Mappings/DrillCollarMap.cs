using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTA.DrillingData.NTier.Entities.Concrete;

namespace YTA.DrillingData.NTier.DataAccess.Concrete.EntityFramework.Mappings
{
    public class DrillCollarMap : EntityTypeConfiguration<DrillCollar>
    {
        public DrillCollarMap()
        {
            ToTable(@"DrillCollar", @"dbo");
            HasKey(x => x.HoleID);

            Property(x => x.HoleID).HasColumnName("HoleID");
            Property(x => x.Easting).HasColumnName("Easting");
            Property(x => x.Northing).HasColumnName("Northing");
            Property(x => x.Elevation).HasColumnName("Elevation");
            Property(x => x.Projection).HasColumnName("Projection");
            Property(x => x.Zone).HasColumnName("Zone");
            Property(x => x.TotalDepth).HasColumnName("TotalDepth");
            Property(x => x.AzimuthMag).HasColumnName("AzimuthMag");
            Property(x => x.Dip).HasColumnName("Dip");
            Property(x => x.Permit).HasColumnName("Permit");
            Property(x => x.Prospect).HasColumnName("Prospect");
            Property(x => x.ProposedHoleID).HasColumnName("ProposedHoleID");
            Property(x => x.PlannedDepth).HasColumnName("PlannedDepth");
            Property(x => x.StartDate).HasColumnName("StartDate");
            Property(x => x.EndDate).HasColumnName("EndDate");
            Property(x => x.Geologist).HasColumnName("Geologist");
            Property(x => x.DrillingType).HasColumnName("DrillingType");
            Property(x => x.TypeCode).HasColumnName("TypeCode");
            Property(x => x.Phase).HasColumnName("Phase");
            Property(x => x.Contractor).HasColumnName("Contractor");
            Property(x => x.Rig).HasColumnName("Rig");
            Property(x => x.DhSurveyMethod).HasColumnName("DhSurveyMethod");
            Property(x => x.DhSurveyor).HasColumnName("DhSurveyor");
            Property(x => x.SurveyDate).HasColumnName("SurveyDate");
            Property(x => x.HoleStatus).HasColumnName("HoleStatus");
            Property(x => x.Comment).HasColumnName("Comment");
        }
    }
}
