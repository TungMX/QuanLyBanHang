﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace QuanLyBanHang.Module.QuanLyBanHang
{

    public partial class CT_don_hangs : XPLiteObject
    {
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        don_hangs fid_don_hang;
        [Association(@"CT_don_hangsReferencesdon_hangs")]
        public don_hangs id_don_hang
        {
            get { return fid_don_hang; }
            set { SetPropertyValue<don_hangs>(nameof(id_don_hang), ref fid_don_hang, value); }
        }
        string fso_seri;
        [Size(20)]
        public string so_seri
        {
            get { return fso_seri; }
            set { SetPropertyValue<string>(nameof(so_seri), ref fso_seri, value); }
        }
        san_phams fid_san_pham;
        [Association(@"CT_don_hangsReferencessan_phams")]
        public san_phams id_san_pham
        {
            get { return fid_san_pham; }
            set { SetPropertyValue<san_phams>(nameof(id_san_pham), ref fid_san_pham, value); }
        }
        DateTime fngay_bd_bh;
        public DateTime ngay_bd_bh
        {
            get { return fngay_bd_bh; }
            set { SetPropertyValue<DateTime>(nameof(ngay_bd_bh), ref fngay_bd_bh, value); }
        }
        DateTime fngay_het_bh;
        public DateTime ngay_het_bh
        {
            get { return fngay_het_bh; }
            set { SetPropertyValue<DateTime>(nameof(ngay_het_bh), ref fngay_het_bh, value); }
        }
        decimal fthanh_tien;
        [ColumnDbDefaultValue("((1))")]
        public decimal thanh_tien
        {
            get { return fthanh_tien; }
            set { SetPropertyValue<decimal>(nameof(thanh_tien), ref fthanh_tien, value); }
        }
    }

}
