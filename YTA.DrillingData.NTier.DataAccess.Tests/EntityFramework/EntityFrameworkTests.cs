using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using YTA.DrillingData.NTier.DataAccess.Concrete.EntityFramework;

namespace YTA.DrillingData.NTier.DataAccess.Tests.EntityFramework
{
    [TestClass]
    public class EntityFrameworkTests
    {
        [TestMethod]
        public void Get_all_result_DrillCollar()
        {
            EfDrillCollarDal dal = new EfDrillCollarDal();

            var result = dal.GetList();

            Assert.AreEqual(1, result.Count);
        }
    }
}
