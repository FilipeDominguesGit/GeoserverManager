﻿using System;
using System.Reflection;
using GeoserverManager.Entities.Base.Interface.BusinessModel;
using GeoserverManager.Entities.Interface.BussinessModel;
using GeoserverManager.Entities.Interface.BussinessModel.Enums;

namespace GeoserverManager.Entities.BussinessModel
{
    public class FeatureTypeInfo : IFeatureTypeInfo
    {
        public static readonly IFeatureTypeInfo NULL = new NullLayerInfo();
        public string Name { get; internal set; }
        public string Srs { get; internal set; }
        public string Sql { get; internal set; }
        public string Workspace { get; internal set; }
        public string Datastore { get; internal set; }
        public string Geometry { get; internal set; }
        public FeatureTypeInfoStatus LayerStatus { get; internal set; }

        public void ChangeLayerStatus(FeatureTypeInfoStatus layerStatus)
        {
            LayerStatus = layerStatus;
        }

        public bool IsNull()
        {
            return IsNull(this);
        }

        public bool Equals(IBusinessModel other)
        {
            try
            {
                var thisType = GetType();
                var otherType = other.GetType();
                var properties = thisType.GetProperties();
                foreach (var property in properties)
                {
                    if (IsMethodWithoutArgument(property))
                    {
                        var otherProperty = otherType.GetProperty(property.Name);
                        if (otherProperty == null)
                            return false;

                        var thisValue = property.GetValue(this, null);
                        var otherValue = otherProperty.GetValue(other, null);
                        if (!thisValue.Equals(otherValue))
                            return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        private static bool IsMethodWithoutArgument(PropertyInfo property)
        {
            return property.GetGetMethod().GetParameters().Length == 0;
        }

        private static bool IsNull(IFeatureTypeInfo neighbourCellsRelation)
        {
            return neighbourCellsRelation == NULL;
        }

        public class NullLayerInfo : IFeatureTypeInfo
        {
            public bool Equals(IBusinessModel other)
            {
                if (other == null)
                    return false;
                if (!(other is IFeatureTypeInfo))
                    return false;

                return IsNull();
            }

            public bool IsNull()
            {
                return true;
            }

            public string Name
            {
                get { throw new InvalidOperationException("Unable to get data from NULL object!"); }
            }

            public string Srs
            {
                get { throw new InvalidOperationException("Unable to get data from NULL object!"); }
            }

            public string Sql
            {
                get { throw new InvalidOperationException("Unable to get data from NULL object!"); }
            }

            public string Workspace
            {
                get { throw new InvalidOperationException("Unable to get data from NULL object!"); }
            }

            public string Datastore
            {
                get { throw new InvalidOperationException("Unable to get data from NULL object!"); }
            }
            public string Geometry
            {
                get { throw new InvalidOperationException("Unable to get data from NULL object!"); }
            }

            public FeatureTypeInfoStatus LayerStatus
            {
                get { throw new InvalidOperationException("Unable to get data from NULL object!"); }
            }

            public void ChangeLayerStatus(FeatureTypeInfoStatus layerStatus)
            {
                throw new InvalidOperationException();
            }
        }
    }
}