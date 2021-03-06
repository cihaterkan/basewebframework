﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Legendigital.Framework.Common.Data.Interfaces;

namespace Legendigital.Framework.Common.Bussiness.Interfaces
{
    [ServiceContract]
    public interface IBaseSpringNHibernateEntityServiceProxy<DomainType> : IBaseSpringNHibernateEntityViewServiceProxy<DomainType>
    {
        [OperationContract]
        void Save(DomainType obj);

        [OperationContract]
        void Update(DomainType obj);

        [OperationContract]
        void SaveOrUpdate(DomainType obj);

        [OperationContract]
        void DeleteAll();

        [OperationContract]
        void DeleteByID(object id);

        [OperationContract]
        void PatchDeleteByIDs(object[] ids);

        [OperationContract]
        void Delete(DomainType instance);
    }
}
