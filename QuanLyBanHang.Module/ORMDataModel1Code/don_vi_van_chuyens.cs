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
    [DefaultClassOptions]
    public partial class don_vi_van_chuyens
    {
        public don_vi_van_chuyens(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
