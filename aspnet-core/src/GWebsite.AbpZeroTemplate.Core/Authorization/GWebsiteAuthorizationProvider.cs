﻿using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Localization;
using GSoft.AbpZeroTemplate;

namespace GWebsite.AbpZeroTemplate.Core.Authorization
{
    /// <summary>
    /// Application's authorization provider.
    /// Defines permissions for the application.
    /// See <see cref="AppPermissions"/> for all permission names.
    /// </summary>
    public class GWebsiteAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

        public GWebsiteAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public GWebsiteAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //COMMON PERMISSIONS (FOR BOTH OF TENANTS AND HOST)

            var pages = context.GetPermissionOrNull(GWebsitePermissions.Pages) ?? context.CreatePermission(GWebsitePermissions.Pages, L("Pages"));
            var gwebsite = pages.CreateChildPermission(GWebsitePermissions.Pages_Administration_GWebsite, L("GWebsite"));

            var menuClient = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_MenuClient, L("MenuClient"));
            menuClient.CreateChildPermission(GWebsitePermissions.Pages_Administration_MenuClient_Create, L("CreatingNewMenuClient"));
            menuClient.CreateChildPermission(GWebsitePermissions.Pages_Administration_MenuClient_Edit, L("EditingMenuClient"));
            menuClient.CreateChildPermission(GWebsitePermissions.Pages_Administration_MenuClient_Delete, L("DeletingMenuClient"));

            var demoModel = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_DemoModel, L("DemoModel"));
            demoModel.CreateChildPermission(GWebsitePermissions.Pages_Administration_DemoModel_Create, L("CreatingNewDemoModel"));
            demoModel.CreateChildPermission(GWebsitePermissions.Pages_Administration_DemoModel_Edit, L("EditingDemoModel"));
            demoModel.CreateChildPermission(GWebsitePermissions.Pages_Administration_DemoModel_Delete, L("DeletingDemoModel"));

            var customer = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_Customer, L("Customer"));
            customer.CreateChildPermission(GWebsitePermissions.Pages_Administration_Customer_Create, L("CreatingNewCustomer"));
            customer.CreateChildPermission(GWebsitePermissions.Pages_Administration_Customer_Edit, L("EditingCustomer"));
            customer.CreateChildPermission(GWebsitePermissions.Pages_Administration_Customer_Delete, L("DeletingCustomer"));

            var speedster = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_Speedster, L("Speedster"));
            speedster = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_Speedster_Create, L("CreatingNewSpeedster"));
            speedster = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_Speedster_Edit, L("EditingSpeedster"));
            speedster = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_Speedster_Delete, L("DeletingSpeedster"));

            var donViCungCapTaiSan = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_DonViCungCapTaiSan, L("DonViCungCapTaiSan"));
            donViCungCapTaiSan = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_DonViCungCapTaiSan_Create, L("CreatingNewDonViCungCapTaiSan"));
            donViCungCapTaiSan = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_DonViCungCapTaiSan_Edit, L("EditingDonViCungCapTaiSan"));
            donViCungCapTaiSan = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_DonViCungCapTaiSan_Delete, L("DeletingDonViCungCapTaiSan"));

            var phongBan = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_PhongBan, L("PhongBan"));
            phongBan = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_PhongBan_Create, L("CreatingNewPhongBan"));
            phongBan = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_PhongBan_Edit, L("EditingPhongBan"));
            phongBan = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_PhongBan_Delete, L("DeletingPhongBan"));


            var hoaDonNhap = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_HoaDonNhap, L("HoaDonNhap"));
            hoaDonNhap = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_HoaDonNhap_Create, L("CreatingNewHoaDonNhap"));
            hoaDonNhap = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_HoaDonNhap_Edit, L("EditingHoaDonNhap"));
            hoaDonNhap = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_HoaDonNhap_Delete, L("DeletingHoaDonNhap"));

            var bangYeuCauCungCapTaiSan = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_BangYeuCauCungCapTaiSan, L("BangYeuCauCungCapTaiSan"));
            bangYeuCauCungCapTaiSan = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_BangYeuCauCungCapTaiSan_Create, L("CreatingNewBangYeuCauCungCapTaiSan"));
            bangYeuCauCungCapTaiSan = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_BangYeuCauCungCapTaiSan_Edit, L("EditingBangYeuCauCungCapTaiSan"));
            bangYeuCauCungCapTaiSan = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_BangYeuCauCungCapTaiSan_Delete, L("DeletingBangYeuCauCungCapTaiSan"));

            var loaiTaiSan = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_LoaiTaiSan, L("LoaiTaiSan"));
            loaiTaiSan = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_LoaiTaiSan_Create, L("CreatingNewLoaiTaiSan"));
            loaiTaiSan = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_LoaiTaiSan_Edit, L("EditingLoaiTaiSan"));
            loaiTaiSan = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_LoaiTaiSan_Delete, L("DeletingLoaiTaiSan"));

            var sanPham = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_SanPham, L("SanPham"));
            sanPham = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_SanPham_Create, L("CreatingNewSanPham"));
            sanPham = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_SanPham_Edit, L("EditingSanPham"));
            sanPham = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_SanPham_Delete, L("DeletingSanPham"));

            var capPhat = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_CapPhat, L("CapPhat"));
            capPhat = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_CapPhat_Create, L("CreatingNewCapPhat"));
            capPhat = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_CapPhat_Edit, L("EditingCapPhat"));
            capPhat = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_CapPhat_Delete, L("DeletingCapPhat"));

        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, AbpZeroTemplateConsts.LocalizationSourceName);
        }
    }
}
