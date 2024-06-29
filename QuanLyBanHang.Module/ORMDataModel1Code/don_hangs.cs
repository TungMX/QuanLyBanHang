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
    public partial class don_hangs
    {
        public don_hangs(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
