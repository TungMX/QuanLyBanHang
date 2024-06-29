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

    public partial class khach_hangs : XPLiteObject
    {
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        string fho_ten;
        public string ho_ten
        {
            get { return fho_ten; }
            set { SetPropertyValue<string>(nameof(ho_ten), ref fho_ten, value); }
        }
        string fso_dien_thoai;
        [Size(15)]
        public string so_dien_thoai
        {
            get { return fso_dien_thoai; }
            set { SetPropertyValue<string>(nameof(so_dien_thoai), ref fso_dien_thoai, value); }
        }
        string fdia_chi;
        [Size(255)]
        public string dia_chi
        {
            get { return fdia_chi; }
            set { SetPropertyValue<string>(nameof(dia_chi), ref fdia_chi, value); }
        }
        DateTime fngay_sinh;
        public DateTime ngay_sinh
        {
            get { return fngay_sinh; }
            set { SetPropertyValue<DateTime>(nameof(ngay_sinh), ref fngay_sinh, value); }
        }
        int fgioi_tinh;
        public int gioi_tinh
        {
            get { return fgioi_tinh; }
            set { SetPropertyValue<int>(nameof(gioi_tinh), ref fgioi_tinh, value); }
        }
        string femail;
        [Size(255)]
        public string email
        {
            get { return femail; }
            set { SetPropertyValue<string>(nameof(email), ref femail, value); }
        }
        string fmat_khau;
        public string mat_khau
        {
            get { return fmat_khau; }
            set { SetPropertyValue<string>(nameof(mat_khau), ref fmat_khau, value); }
        }
        int ftinh_trang;
        [ColumnDbDefaultValue("((1))")]
        public int tinh_trang
        {
            get { return ftinh_trang; }
            set { SetPropertyValue<int>(nameof(tinh_trang), ref ftinh_trang, value); }
        }
        [Association(@"don_hangsReferenceskhach_hangs")]
        public XPCollection<don_hangs> don_hangss { get { return GetCollection<don_hangs>(nameof(don_hangss)); } }
        [Association(@"phieu_xuat_khosReferenceskhach_hangs")]
        public XPCollection<phieu_xuat_khos> phieu_xuat_khoss { get { return GetCollection<phieu_xuat_khos>(nameof(phieu_xuat_khoss)); } }
    }

}
