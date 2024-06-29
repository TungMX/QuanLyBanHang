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

    public partial class CT_phieu_xuats : XPLiteObject
    {
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        phieu_xuat_khos fid_phieu_xuat;
        [Association(@"CT_phieu_xuatsReferencesphieu_xuat_khos")]
        public phieu_xuat_khos id_phieu_xuat
        {
            get { return fid_phieu_xuat; }
            set { SetPropertyValue<phieu_xuat_khos>(nameof(id_phieu_xuat), ref fid_phieu_xuat, value); }
        }
        san_phams fid_san_pham;
        [Association(@"CT_phieu_xuatsReferencessan_phams")]
        public san_phams id_san_pham
        {
            get { return fid_san_pham; }
            set { SetPropertyValue<san_phams>(nameof(id_san_pham), ref fid_san_pham, value); }
        }
        string fso_seri;
        [Size(20)]
        public string so_seri
        {
            get { return fso_seri; }
            set { SetPropertyValue<string>(nameof(so_seri), ref fso_seri, value); }
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
        [Association(@"bao_hanhsReferencesCT_phieu_xuats")]
        public XPCollection<bao_hanhs> bao_hanhss { get { return GetCollection<bao_hanhs>(nameof(bao_hanhss)); } }
    }

}