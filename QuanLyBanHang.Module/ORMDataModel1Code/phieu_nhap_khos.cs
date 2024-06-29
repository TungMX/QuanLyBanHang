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
    public partial class phieu_nhap_khos
    {
        public phieu_nhap_khos(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
