﻿using MISA.WEB09.QLTS.Common.Entities;
using MISA.WEB09.QLTS.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WEB09.QLTS.BL
{
    public interface IVoucherBL : IBaseBL<Voucher>
    {
        /// <summary>
        /// Lấy danh sách các chứng từ có chọn lọc
        /// </summary>
        /// <param name="keyword">Từ để tìm kiếm theo số chứng từ và nội dung</param>
        /// <param name="limit">Số chứng từ muốn lấy</param>
        /// <param name="page">Số trang bắt đầu lấy</param>
        /// <returns>Danh sách các chứng từ sau khi chọn lọc và các giá trị khác</returns>
        /// Created by: NNNINH (27/12/2022)
        public PagingData<Voucher> FilterVouchers(string? keyword, int limit, int page);

        /// <summary>
        /// Lấy chi tiết chứng từ
        /// </summary>
        /// <param name="voucherId">Số chứng từ</param>
        /// <param name="limit">Số bản ghi muốn lấy</param>
        /// <param name="page">Số trang bắt đầu lấy</param>
        /// <returns>Danh sách các tài sản theo chứng từ</returns>
        /// Created by: NNNINH (01/01/2023)
        public PagingData<Asset> GetVoucherDetail(string? keyword, Guid voucherId, int limit, int page);

        /// <summary>
        /// Thêm nhiều tài sản trong chứng từ
        /// </summary>
        /// <param name="voucherId">ID chứng từ đang sửa</param>
        /// <param name="assetIdList">Danh sách ID các tài sản cần thêm</param>
        /// <returns>Danh sách ID các tài sản đã thêm</returns>
        /// Cretaed by: NNNINH (06/01/2023)
        public int AddVoucherDetail(Guid voucherId, List<VoucherDetail> voucherDetails);

        /// <summary>
        /// Cập nhật nhiều tài sản trong chứng từ
        /// </summary>
        /// <param name="voucherId">ID chứng từ đang sửa</param>
        /// <param name="assetIdList">Danh sách ID các tài sản cần thêm</param>
        /// <returns>Danh sách ID các tài sản đã thêm</returns>
        /// Cretaed by: NNNINH (06/01/2023)
        public int UpadateVoucherDetail(Guid voucherId, List<Asset> assetDataill);


        /// <summary>
        /// Lấy 1 bản ghi theo id
        /// </summary>
        /// <param name="recordId">ID của bản ghi cần lấy</param>
        /// <returns>Bản ghi có ID được truyền vào</returns>
        /// Created by: NNINH (09/11/2022)
        public VoucherDetail GetVoucherDetailById(Guid voucherId,Guid assetId);

        public ServiceResponse backAddVoucherDetail(BackAddVoucherDetaill backAddVoucherDetaill);
    }
}