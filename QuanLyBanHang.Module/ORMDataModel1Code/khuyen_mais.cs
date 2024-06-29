using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
namespace QuanLyBanHang.Module.QuanLyBanHang
{
    [NavigationItem(true)]
    public partial class khuyen_mais
    {
        public khuyen_mais(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
