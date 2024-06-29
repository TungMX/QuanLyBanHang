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

    public partial class phieu_xuat_khos : XPLiteObject
    {
        int fid;
        [Key(true)]
        public int id
        {
            get { return fid; }
            set { SetPropertyValue<int>(nameof(id), ref fid, value); }
        }
        string fma_phieu_xuat;
        public string ma_phieu_xuat
        {
            get { return fma_phieu_xuat; }
            set { SetPropertyValue<string>(nameof(ma_phieu_xuat), ref fma_phieu_xuat, value); }
        }
        khach_hangs fid_khach_hang;
        [Association(@"phieu_xuat_khosReferenceskhach_hangs")]
        public khach_hangs id_khach_hang
        {
            get { return fid_khach_hang; }
            set { SetPropertyValue<khach_hangs>(nameof(id_khach_hang), ref fid_khach_hang, value); }
        }
        nhan_viens fid_nhan_vien;
        [Association(@"phieu_xuat_khosReferencesnhan_viens")]
        public nhan_viens id_nhan_vien
        {
            get { return fid_nhan_vien; }
            set { SetPropertyValue<nhan_viens>(nameof(id_nhan_vien), ref fid_nhan_vien, value); }
        }
        string fghi_chu;
        [Size(255)]
        public string ghi_chu
        {
            get { return fghi_chu; }
            set { SetPropertyValue<string>(nameof(ghi_chu), ref fghi_chu, value); }
        }
        decimal ftong_tien;
        [ColumnDbDefaultValue("((1))")]
        public decimal tong_tien
        {
            get { return ftong_tien; }
            set { SetPropertyValue<decimal>(nameof(tong_tien), ref ftong_tien, value); }
        }
        int ftinh_trang;
        [ColumnDbDefaultValue("((1))")]
        public int tinh_trang
        {
            get { return ftinh_trang; }
            set { SetPropertyValue<int>(nameof(tinh_trang), ref ftinh_trang, value); }
        }
        [Association(@"CT_phieu_xuatsReferencesphieu_xuat_khos")]
        public XPCollection<CT_phieu_xuats> CT_phieu_xuatss { get { return GetCollection<CT_phieu_xuats>(nameof(CT_phieu_xuatss)); } }
    }

}