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

    public partial class bao_hanhs : XPLiteObject
    {
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        CT_phieu_xuats fid_ct_phieu_xuat;
        [Association(@"bao_hanhsReferencesCT_phieu_xuats")]
        public CT_phieu_xuats id_ct_phieu_xuat
        {
            get { return fid_ct_phieu_xuat; }
            set { SetPropertyValue<CT_phieu_xuats>(nameof(id_ct_phieu_xuat), ref fid_ct_phieu_xuat, value); }
        }
        DateTime fngay_bao_hanh;
        public DateTime ngay_bao_hanh
        {
            get { return fngay_bao_hanh; }
            set { SetPropertyValue<DateTime>(nameof(ngay_bao_hanh), ref fngay_bao_hanh, value); }
        }
        string fnoi_dung_bh;
        [Size(255)]
        public string noi_dung_bh
        {
            get { return fnoi_dung_bh; }
            set { SetPropertyValue<string>(nameof(noi_dung_bh), ref fnoi_dung_bh, value); }
        }
        int ftinh_trang;
        [ColumnDbDefaultValue("((1))")]
        public int tinh_trang
        {
            get { return ftinh_trang; }
            set { SetPropertyValue<int>(nameof(tinh_trang), ref ftinh_trang, value); }
        }
    }

}
