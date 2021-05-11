using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemplateNameSpace.Models;

namespace TemplateNameSpace.Test
{
  [TestClass]
  public class ParcelTests
  {
    [TestMethod]
    public void ParcelConstructor_CreatesInstanceOfParcel_Parcel()
    {
      Parcel newParcel = new Parcel();
      Assert.AreEqual(typeof(Parcel), newParcel.GetType());
    }
    // Tests
  }
}