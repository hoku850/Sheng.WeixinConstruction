﻿/*
********************************************************************
*
*    曹旭升（sheng.c）
*    E-mail: cao.silhouette@msn.com
*    QQ: 279060597
*    https://github.com/iccb1013
*    http://shengxunwei.com
*
*    © Copyright 2016
*
********************************************************************/


using Linkup.DataRelationalMapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheng.WeixinConstruction.Infrastructure
{
    [Table("RoleUser")]
    public class RoleUserEntity
    {
        public Guid Domain
        {
            get;
            set;
        }

        public Guid Role
        {
            get;
            set;
        }

        public Guid User
        {
            get;
            set;
        }
    }
}
