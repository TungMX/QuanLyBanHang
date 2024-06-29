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
    public partial class CT_don_hangs
    {
        public CT_don_hangs(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
