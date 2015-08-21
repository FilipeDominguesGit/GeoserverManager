using System;

namespace GeoserverManager.Entities.Base.Interface.BusinessModel
{
    public interface IBusinessModel : IEquatable<IBusinessModel>
    {
        bool IsNull();
    }
}