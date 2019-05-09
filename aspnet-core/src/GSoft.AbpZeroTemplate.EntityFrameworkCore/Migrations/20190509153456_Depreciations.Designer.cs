﻿using System;
using GSoft.AbpZeroTemplate.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GSoft.AbpZeroTemplate.Migrations
{
    [DbContext(typeof(AbpZeroTemplateDbContext))]
    [Migration("20190509130844_Depreciations")]
    partial class Depreciations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Abp.Application.Editions.Edition", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<long?>("DeleterUserId");

                b.Property<DateTime?>("DeletionTime");

                b.Property<string>("Discriminator")
                    .IsRequired();

                b.Property<string>("DisplayName")
                    .IsRequired()
                    .HasMaxLength(64);

                b.Property<bool>("IsDeleted");

                b.Property<DateTime?>("LastModificationTime");

                b.Property<long?>("LastModifierUserId");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(32);

                b.HasKey("Id");

                b.ToTable("AbpEditions");

                b.HasDiscriminator<string>("Discriminator").HasValue("Edition");
            });

            modelBuilder.Entity("Abp.Application.Features.FeatureSetting", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<string>("Discriminator")
                    .IsRequired();

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(128);

                b.Property<int?>("TenantId");

                b.Property<string>("Value")
                    .IsRequired()
                    .HasMaxLength(2000);

                b.HasKey("Id");

                b.ToTable("AbpFeatures");

                b.HasDiscriminator<string>("Discriminator").HasValue("FeatureSetting");
            });

            modelBuilder.Entity("Abp.Auditing.AuditLog", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("BrowserInfo")
                    .HasMaxLength(512);

                b.Property<string>("ClientIpAddress")
                    .HasMaxLength(64);

                b.Property<string>("ClientName")
                    .HasMaxLength(128);

                b.Property<string>("CustomData")
                    .HasMaxLength(2000);

                b.Property<string>("Exception")
                    .HasMaxLength(2000);

                b.Property<int>("ExecutionDuration");

                b.Property<DateTime>("ExecutionTime");

                b.Property<int?>("ImpersonatorTenantId");

                b.Property<long?>("ImpersonatorUserId");

                b.Property<string>("MethodName")
                    .HasMaxLength(256);

                b.Property<string>("Parameters")
                    .HasMaxLength(1024);

                b.Property<string>("ServiceName")
                    .HasMaxLength(256);

                b.Property<int?>("TenantId");

                b.Property<long?>("UserId");

                b.HasKey("Id");

                b.HasIndex("TenantId", "ExecutionDuration");

                b.HasIndex("TenantId", "ExecutionTime");

                b.HasIndex("TenantId", "UserId");

                b.ToTable("AbpAuditLogs");
            });

            modelBuilder.Entity("Abp.Authorization.PermissionSetting", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<string>("Discriminator")
                    .IsRequired();

                b.Property<bool>("IsGranted");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(128);

                b.Property<int?>("TenantId");

                b.HasKey("Id");

                b.HasIndex("TenantId", "Name");

                b.ToTable("AbpPermissions");

                b.HasDiscriminator<string>("Discriminator").HasValue("PermissionSetting");
            });

            modelBuilder.Entity("Abp.Authorization.Roles.RoleClaim", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("ClaimType")
                    .HasMaxLength(256);

                b.Property<string>("ClaimValue");

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<int>("RoleId");

                b.Property<int?>("TenantId");

                b.HasKey("Id");

                b.HasIndex("RoleId");

                b.HasIndex("TenantId", "ClaimType");

                b.ToTable("AbpRoleClaims");
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserAccount", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<long?>("DeleterUserId");

                b.Property<DateTime?>("DeletionTime");

                b.Property<string>("EmailAddress")
                    .HasMaxLength(256);

                b.Property<bool>("IsDeleted");

                b.Property<DateTime?>("LastLoginTime");

                b.Property<DateTime?>("LastModificationTime");

                b.Property<long?>("LastModifierUserId");

                b.Property<int?>("TenantId");

                b.Property<long>("UserId");

                b.Property<long?>("UserLinkId");

                b.Property<string>("UserName")
                    .HasMaxLength(32);

                b.HasKey("Id");

                b.HasIndex("EmailAddress");

                b.HasIndex("UserName");

                b.HasIndex("TenantId", "EmailAddress");

                b.HasIndex("TenantId", "UserId");

                b.HasIndex("TenantId", "UserName");

                b.ToTable("AbpUserAccounts");
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserClaim", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("ClaimType")
                    .HasMaxLength(256);

                b.Property<string>("ClaimValue");

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<int?>("TenantId");

                b.Property<long>("UserId");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.HasIndex("TenantId", "ClaimType");

                b.ToTable("AbpUserClaims");
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserLogin", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("LoginProvider")
                    .IsRequired()
                    .HasMaxLength(128);

                b.Property<string>("ProviderKey")
                    .IsRequired()
                    .HasMaxLength(256);

                b.Property<int?>("TenantId");

                b.Property<long>("UserId");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.HasIndex("TenantId", "UserId");

                b.HasIndex("TenantId", "LoginProvider", "ProviderKey");

                b.ToTable("AbpUserLogins");
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserLoginAttempt", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("BrowserInfo")
                    .HasMaxLength(512);

                b.Property<string>("ClientIpAddress")
                    .HasMaxLength(64);

                b.Property<string>("ClientName")
                    .HasMaxLength(128);

                b.Property<DateTime>("CreationTime");

                b.Property<byte>("Result");

                b.Property<string>("TenancyName")
                    .HasMaxLength(64);

                b.Property<int?>("TenantId");

                b.Property<long?>("UserId");

                b.Property<string>("UserNameOrEmailAddress")
                    .HasMaxLength(255);

                b.HasKey("Id");

                b.HasIndex("UserId", "TenantId");

                b.HasIndex("TenancyName", "UserNameOrEmailAddress", "Result");

                b.ToTable("AbpUserLoginAttempts");
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserOrganizationUnit", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<bool>("IsDeleted");

                b.Property<long>("OrganizationUnitId");

                b.Property<int?>("TenantId");

                b.Property<long>("UserId");

                b.HasKey("Id");

                b.HasIndex("TenantId", "OrganizationUnitId");

                b.HasIndex("TenantId", "UserId");

                b.ToTable("AbpUserOrganizationUnits");
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserRole", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<int>("RoleId");

                b.Property<int?>("TenantId");

                b.Property<long>("UserId");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.HasIndex("TenantId", "RoleId");

                b.HasIndex("TenantId", "UserId");

                b.ToTable("AbpUserRoles");
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserToken", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("LoginProvider")
                    .HasMaxLength(64);

                b.Property<string>("Name")
                    .HasMaxLength(128);

                b.Property<int?>("TenantId");

                b.Property<long>("UserId");

                b.Property<string>("Value")
                    .HasMaxLength(512);

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.HasIndex("TenantId", "UserId");

                b.ToTable("AbpUserTokens");
            });

            modelBuilder.Entity("Abp.BackgroundJobs.BackgroundJobInfo", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<bool>("IsAbandoned");

                b.Property<string>("JobArgs")
                    .IsRequired()
                    .HasMaxLength(1048576);

                b.Property<string>("JobType")
                    .IsRequired()
                    .HasMaxLength(512);

                b.Property<DateTime?>("LastTryTime");

                b.Property<DateTime>("NextTryTime");

                b.Property<byte>("Priority");

                b.Property<short>("TryCount");

                b.HasKey("Id");

                b.HasIndex("IsAbandoned", "NextTryTime");

                b.ToTable("AbpBackgroundJobs");
            });

            modelBuilder.Entity("Abp.Configuration.Setting", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<DateTime?>("LastModificationTime");

                b.Property<long?>("LastModifierUserId");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(256);

                b.Property<int?>("TenantId");

                b.Property<long?>("UserId");

                b.Property<string>("Value")
                    .HasMaxLength(2000);

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.HasIndex("TenantId", "Name");

                b.ToTable("AbpSettings");
            });

            modelBuilder.Entity("Abp.EntityHistory.EntityChange", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("ChangeTime");

                b.Property<byte>("ChangeType");

                b.Property<long>("EntityChangeSetId");

                b.Property<string>("EntityId")
                    .HasMaxLength(48);

                b.Property<string>("EntityTypeFullName")
                    .HasMaxLength(192);

                b.Property<int?>("TenantId");

                b.HasKey("Id");

                b.HasIndex("EntityChangeSetId");

                b.HasIndex("EntityTypeFullName", "EntityId");

                b.ToTable("AbpEntityChanges");
            });

            modelBuilder.Entity("Abp.EntityHistory.EntityChangeSet", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("BrowserInfo")
                    .HasMaxLength(512);

                b.Property<string>("ClientIpAddress")
                    .HasMaxLength(64);

                b.Property<string>("ClientName")
                    .HasMaxLength(128);

                b.Property<DateTime>("CreationTime");

                b.Property<string>("ExtensionData");

                b.Property<int?>("ImpersonatorTenantId");

                b.Property<long?>("ImpersonatorUserId");

                b.Property<string>("Reason")
                    .HasMaxLength(256);

                b.Property<int?>("TenantId");

                b.Property<long?>("UserId");

                b.HasKey("Id");

                b.HasIndex("TenantId", "CreationTime");

                b.HasIndex("TenantId", "Reason");

                b.HasIndex("TenantId", "UserId");

                b.ToTable("AbpEntityChangeSets");
            });

            modelBuilder.Entity("Abp.EntityHistory.EntityPropertyChange", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<long>("EntityChangeId");

                b.Property<string>("NewValue")
                    .HasMaxLength(512);

                b.Property<string>("OriginalValue")
                    .HasMaxLength(512);

                b.Property<string>("PropertyName")
                    .HasMaxLength(96);

                b.Property<string>("PropertyTypeFullName")
                    .HasMaxLength(192);

                b.Property<int?>("TenantId");

                b.HasKey("Id");

                b.HasIndex("EntityChangeId");

                b.ToTable("AbpEntityPropertyChanges");
            });

            modelBuilder.Entity("Abp.IdentityServer4.PersistedGrantEntity", b =>
            {
                b.Property<string>("Id")
                    .HasMaxLength(200);

                b.Property<string>("ClientId")
                    .IsRequired()
                    .HasMaxLength(200);

                b.Property<DateTime>("CreationTime");

                b.Property<string>("Data")
                    .IsRequired()
                    .HasMaxLength(50000);

                b.Property<DateTime?>("Expiration");

                b.Property<string>("SubjectId")
                    .HasMaxLength(200);

                b.Property<string>("Type")
                    .IsRequired()
                    .HasMaxLength(50);

                b.HasKey("Id");

                b.HasIndex("SubjectId", "ClientId", "Type");

                b.ToTable("AbpPersistedGrants");
            });

            modelBuilder.Entity("Abp.Localization.ApplicationLanguage", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<long?>("DeleterUserId");

                b.Property<DateTime?>("DeletionTime");

                b.Property<string>("DisplayName")
                    .IsRequired()
                    .HasMaxLength(64);

                b.Property<string>("Icon")
                    .HasMaxLength(128);

                b.Property<bool>("IsDeleted");

                b.Property<bool>("IsDisabled");

                b.Property<DateTime?>("LastModificationTime");

                b.Property<long?>("LastModifierUserId");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(10);

                b.Property<int?>("TenantId");

                b.HasKey("Id");

                b.HasIndex("TenantId", "Name");

                b.ToTable("AbpLanguages");
            });

            modelBuilder.Entity("Abp.Localization.ApplicationLanguageText", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<string>("Key")
                    .IsRequired()
                    .HasMaxLength(256);

                b.Property<string>("LanguageName")
                    .IsRequired()
                    .HasMaxLength(10);

                b.Property<DateTime?>("LastModificationTime");

                b.Property<long?>("LastModifierUserId");

                b.Property<string>("Source")
                    .IsRequired()
                    .HasMaxLength(128);

                b.Property<int?>("TenantId");

                b.Property<string>("Value")
                    .IsRequired()
                    .HasMaxLength(67108864);

                b.HasKey("Id");

                b.HasIndex("TenantId", "Source", "LanguageName", "Key");

                b.ToTable("AbpLanguageTexts");
            });

            modelBuilder.Entity("Abp.Notifications.NotificationInfo", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<string>("Data")
                    .HasMaxLength(1048576);

                b.Property<string>("DataTypeName")
                    .HasMaxLength(512);

                b.Property<string>("EntityId")
                    .HasMaxLength(96);

                b.Property<string>("EntityTypeAssemblyQualifiedName")
                    .HasMaxLength(512);

                b.Property<string>("EntityTypeName")
                    .HasMaxLength(250);

                b.Property<string>("ExcludedUserIds")
                    .HasMaxLength(131072);

                b.Property<string>("NotificationName")
                    .IsRequired()
                    .HasMaxLength(96);

                b.Property<byte>("Severity");

                b.Property<string>("TenantIds")
                    .HasMaxLength(131072);

                b.Property<string>("UserIds")
                    .HasMaxLength(131072);

                b.HasKey("Id");

                b.ToTable("AbpNotifications");
            });

            modelBuilder.Entity("Abp.Notifications.NotificationSubscriptionInfo", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<string>("EntityId")
                    .HasMaxLength(96);

                b.Property<string>("EntityTypeAssemblyQualifiedName")
                    .HasMaxLength(512);

                b.Property<string>("EntityTypeName")
                    .HasMaxLength(250);

                b.Property<string>("NotificationName")
                    .HasMaxLength(96);

                b.Property<int?>("TenantId");

                b.Property<long>("UserId");

                b.HasKey("Id");

                b.HasIndex("NotificationName", "EntityTypeName", "EntityId", "UserId");

                b.HasIndex("TenantId", "NotificationName", "EntityTypeName", "EntityId", "UserId");

                b.ToTable("AbpNotificationSubscriptions");
            });

            modelBuilder.Entity("Abp.Notifications.TenantNotificationInfo", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<string>("Data")
                    .HasMaxLength(1048576);

                b.Property<string>("DataTypeName")
                    .HasMaxLength(512);

                b.Property<string>("EntityId")
                    .HasMaxLength(96);

                b.Property<string>("EntityTypeAssemblyQualifiedName")
                    .HasMaxLength(512);

                b.Property<string>("EntityTypeName")
                    .HasMaxLength(250);

                b.Property<string>("NotificationName")
                    .IsRequired()
                    .HasMaxLength(96);

                b.Property<byte>("Severity");

                b.Property<int?>("TenantId");

                b.HasKey("Id");

                b.HasIndex("TenantId");

                b.ToTable("AbpTenantNotifications");
            });

            modelBuilder.Entity("Abp.Notifications.UserNotificationInfo", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("CreationTime");

                b.Property<int>("State");

                b.Property<int?>("TenantId");

                b.Property<Guid>("TenantNotificationId");

                b.Property<long>("UserId");

                b.HasKey("Id");

                b.HasIndex("UserId", "State", "CreationTime");

                b.ToTable("AbpUserNotifications");
            });

            modelBuilder.Entity("Abp.Organizations.OrganizationUnit", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Code")
                    .IsRequired()
                    .HasMaxLength(95);

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<long?>("DeleterUserId");

                b.Property<DateTime?>("DeletionTime");

                b.Property<string>("DisplayName")
                    .IsRequired()
                    .HasMaxLength(128);

                b.Property<bool>("IsDeleted");

                b.Property<DateTime?>("LastModificationTime");

                b.Property<long?>("LastModifierUserId");

                b.Property<long?>("ParentId");

                b.Property<int?>("TenantId");

                b.HasKey("Id");

                b.HasIndex("ParentId");

                b.HasIndex("TenantId", "Code");

                b.ToTable("AbpOrganizationUnits");
            });

            modelBuilder.Entity("GSoft.AbpZeroTemplate.Authorization.Roles.Role", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasMaxLength(128);

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<long?>("DeleterUserId");

                b.Property<DateTime?>("DeletionTime");

                b.Property<string>("DisplayName")
                    .IsRequired()
                    .HasMaxLength(64);

                b.Property<bool>("IsDefault");

                b.Property<bool>("IsDeleted");

                b.Property<bool>("IsStatic");

                b.Property<DateTime?>("LastModificationTime");

                b.Property<long?>("LastModifierUserId");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(32);

                b.Property<string>("NormalizedName")
                    .IsRequired()
                    .HasMaxLength(32);

                b.Property<int?>("TenantId");

                b.HasKey("Id");

                b.HasIndex("CreatorUserId");

                b.HasIndex("DeleterUserId");

                b.HasIndex("LastModifierUserId");

                b.HasIndex("TenantId", "NormalizedName");

                b.ToTable("AbpRoles");
            });

            modelBuilder.Entity("GSoft.AbpZeroTemplate.Authorization.Users.User", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int>("AccessFailedCount");

                b.Property<string>("AuthenticationSource")
                    .HasMaxLength(64);

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasMaxLength(128);

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<long?>("DeleterUserId");

                b.Property<DateTime?>("DeletionTime");

                b.Property<string>("EmailAddress")
                    .IsRequired()
                    .HasMaxLength(256);

                b.Property<string>("EmailConfirmationCode")
                    .HasMaxLength(328);

                b.Property<string>("GoogleAuthenticatorKey");

                b.Property<bool>("IsActive");

                b.Property<bool>("IsDeleted");

                b.Property<bool>("IsEmailConfirmed");

                b.Property<bool>("IsLockoutEnabled");

                b.Property<bool>("IsPhoneNumberConfirmed");

                b.Property<bool>("IsTwoFactorEnabled");

                b.Property<DateTime?>("LastLoginTime");

                b.Property<DateTime?>("LastModificationTime");

                b.Property<long?>("LastModifierUserId");

                b.Property<DateTime?>("LockoutEndDateUtc");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(32);

                b.Property<string>("NormalizedEmailAddress")
                    .IsRequired()
                    .HasMaxLength(256);

                b.Property<string>("NormalizedUserName")
                    .IsRequired()
                    .HasMaxLength(32);

                b.Property<string>("Password")
                    .IsRequired()
                    .HasMaxLength(128);

                b.Property<string>("PasswordResetCode")
                    .HasMaxLength(328);

                b.Property<string>("PhoneNumber")
                    .HasMaxLength(32);

                b.Property<Guid?>("ProfilePictureId");

                b.Property<string>("SecurityStamp")
                    .HasMaxLength(128);

                b.Property<bool>("ShouldChangePasswordOnNextLogin");

                b.Property<string>("SignInToken");

                b.Property<DateTime?>("SignInTokenExpireTimeUtc");

                b.Property<string>("Surname")
                    .IsRequired()
                    .HasMaxLength(32);

                b.Property<int?>("TenantId");

                b.Property<string>("UserName")
                    .IsRequired()
                    .HasMaxLength(32);

                b.HasKey("Id");

                b.HasIndex("CreatorUserId");

                b.HasIndex("DeleterUserId");

                b.HasIndex("LastModifierUserId");

                b.HasIndex("TenantId", "NormalizedEmailAddress");

                b.HasIndex("TenantId", "NormalizedUserName");

                b.ToTable("AbpUsers");
            });

            modelBuilder.Entity("GSoft.AbpZeroTemplate.Chat.ChatMessage", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationTime");

                b.Property<string>("Message")
                    .IsRequired()
                    .HasMaxLength(4096);

                b.Property<int>("ReadState");

                b.Property<int>("ReceiverReadState");

                b.Property<Guid?>("SharedMessageId");

                b.Property<int>("Side");

                b.Property<int?>("TargetTenantId");

                b.Property<long>("TargetUserId");

                b.Property<int?>("TenantId");

                b.Property<long>("UserId");

                b.HasKey("Id");

                b.HasIndex("TargetTenantId", "TargetUserId", "ReadState");

                b.HasIndex("TargetTenantId", "UserId", "ReadState");

                b.HasIndex("TenantId", "TargetUserId", "ReadState");

                b.HasIndex("TenantId", "UserId", "ReadState");

                b.ToTable("AppChatMessages");
            });

            modelBuilder.Entity("GSoft.AbpZeroTemplate.Friendships.Friendship", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("CreationTime");

                b.Property<Guid?>("FriendProfilePictureId");

                b.Property<string>("FriendTenancyName");

                b.Property<int?>("FriendTenantId");

                b.Property<long>("FriendUserId");

                b.Property<string>("FriendUserName")
                    .IsRequired()
                    .HasMaxLength(32);

                b.Property<int>("State");

                b.Property<int?>("TenantId");

                b.Property<long>("UserId");

                b.HasKey("Id");

                b.HasIndex("FriendTenantId", "FriendUserId");

                b.HasIndex("FriendTenantId", "UserId");

                b.HasIndex("TenantId", "FriendUserId");

                b.HasIndex("TenantId", "UserId");

                b.ToTable("AppFriendships");
            });

            modelBuilder.Entity("GSoft.AbpZeroTemplate.MultiTenancy.Accounting.Invoice", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime>("InvoiceDate");

                b.Property<string>("InvoiceNo");

                b.Property<string>("TenantAddress");

                b.Property<string>("TenantLegalName");

                b.Property<string>("TenantTaxNo");

                b.HasKey("Id");

                b.ToTable("AppInvoices");
            });

            modelBuilder.Entity("GSoft.AbpZeroTemplate.MultiTenancy.Payments.SubscriptionPayment", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<decimal>("Amount");

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<int>("DayCount");

                b.Property<long?>("DeleterUserId");

                b.Property<DateTime?>("DeletionTime");

                b.Property<int>("EditionId");

                b.Property<int>("Gateway");

                b.Property<string>("InvoiceNo");

                b.Property<bool>("IsDeleted");

                b.Property<DateTime?>("LastModificationTime");

                b.Property<long?>("LastModifierUserId");

                b.Property<string>("PaymentId");

                b.Property<int?>("PaymentPeriodType");

                b.Property<int>("Status");

                b.Property<int>("TenantId");

                b.HasKey("Id");

                b.HasIndex("EditionId");

                b.HasIndex("PaymentId", "Gateway");

                b.HasIndex("Status", "CreationTime");

                b.ToTable("AppSubscriptionPayments");
            });

            modelBuilder.Entity("GSoft.AbpZeroTemplate.MultiTenancy.Tenant", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("ConnectionString")
                    .HasMaxLength(1024);

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<Guid?>("CustomCssId");

                b.Property<long?>("DeleterUserId");

                b.Property<DateTime?>("DeletionTime");

                b.Property<int?>("EditionId");

                b.Property<bool>("IsActive");

                b.Property<bool>("IsDeleted");

                b.Property<bool>("IsInTrialPeriod");

                b.Property<DateTime?>("LastModificationTime");

                b.Property<long?>("LastModifierUserId");

                b.Property<string>("LogoFileType")
                    .HasMaxLength(64);

                b.Property<Guid?>("LogoId");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(128);

                b.Property<DateTime?>("SubscriptionEndDateUtc");

                b.Property<string>("TenancyName")
                    .IsRequired()
                    .HasMaxLength(64);

                b.HasKey("Id");

                b.HasIndex("CreationTime");

                b.HasIndex("CreatorUserId");

                b.HasIndex("DeleterUserId");

                b.HasIndex("EditionId");

                b.HasIndex("LastModifierUserId");

                b.HasIndex("SubscriptionEndDateUtc");

                b.HasIndex("TenancyName");

                b.ToTable("AbpTenants");
            });

            modelBuilder.Entity("GSoft.AbpZeroTemplate.Storage.BinaryObject", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<byte[]>("Bytes")
                    .IsRequired();

                b.Property<int?>("TenantId");

                b.HasKey("Id");

                b.HasIndex("TenantId");

                b.ToTable("AppBinaryObjects");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.Announcement", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Content");

                b.Property<DateTime>("CreatedDate")
                    .HasColumnType("datetime");

                b.Property<bool>("Status");

                b.Property<string>("Title")
                    .IsRequired()
                    .HasMaxLength(250);

                b.Property<string>("UserId")
                    .HasMaxLength(128);

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("Announcements");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.AnnouncementUser", b =>
            {
                b.Property<int>("AnnouncementId");

                b.Property<string>("UserId")
                    .HasMaxLength(128);

                b.Property<bool>("HasRead");

                b.HasKey("AnnouncementId", "UserId");

                b.HasIndex("UserId");

                b.ToTable("AnnouncementUsers");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.AppRole", b =>
            {
                b.Property<string>("Id")
                    .HasMaxLength(128);

                b.Property<string>("Description");

                b.Property<string>("Discriminator")
                    .IsRequired()
                    .HasMaxLength(128);

                b.Property<string>("Name");

                b.HasKey("Id");

                b.ToTable("AppRoles");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.AppUser", b =>
            {
                b.Property<string>("Id")
                    .HasMaxLength(128);

                b.Property<int>("AccessFailedCount");

                b.Property<DateTime?>("ActiveDt")
                    .HasColumnName("ActiveDT")
                    .HasColumnType("datetime");

                b.Property<string>("Address")
                    .HasMaxLength(256);

                b.Property<DateTime?>("ApproveDt")
                    .HasColumnName("ApproveDT")
                    .HasColumnType("datetime");

                b.Property<string>("AuthStatus");

                b.Property<string>("Avatar");

                b.Property<DateTime?>("BirthDay")
                    .HasColumnType("datetime");

                b.Property<DateTime?>("ChargeDt")
                    .HasColumnName("ChargeDT")
                    .HasColumnType("datetime");

                b.Property<string>("CheckId")
                    .HasColumnName("CheckID");

                b.Property<string>("CompanyName");

                b.Property<string>("ContractId")
                    .HasColumnName("ContractID");

                b.Property<DateTime?>("CreateDt")
                    .HasColumnName("CreateDT")
                    .HasColumnType("datetime");

                b.Property<string>("CustomerName");

                b.Property<string>("DataTemp");

                b.Property<string>("DepId")
                    .HasColumnName("DepID");

                b.Property<string>("DxcontactPerson")
                    .HasColumnName("DXContactPerson");

                b.Property<string>("Dxsurrogate")
                    .HasColumnName("DXSurrogate");

                b.Property<DateTime?>("EditorDt")
                    .HasColumnName("EditorDT")
                    .HasColumnType("datetime");

                b.Property<string>("EditorId")
                    .HasColumnName("EditorID");

                b.Property<string>("Email");

                b.Property<bool>("EmailConfirmed");

                b.Property<int?>("ExpContract");

                b.Property<DateTime?>("ExpireDt")
                    .HasColumnName("ExpireDT")
                    .HasColumnType("datetime");

                b.Property<string>("FtpPassword");

                b.Property<string>("FtpUser");

                b.Property<string>("FullName")
                    .HasMaxLength(256);

                b.Property<bool?>("Gender");

                b.Property<string>("LinkAzure");

                b.Property<bool>("LockoutEnabled");

                b.Property<DateTime?>("LockoutEndDateUtc")
                    .HasColumnType("datetime");

                b.Property<string>("MakerId")
                    .HasColumnName("MakerID");

                b.Property<string>("Notes");

                b.Property<string>("PasswordHash");

                b.Property<string>("PhoneNumber");

                b.Property<bool>("PhoneNumberConfirmed");

                b.Property<string>("PriceCode");

                b.Property<string>("RecordStatus");

                b.Property<string>("SecurityStamp");

                b.Property<DateTime?>("SignContractDt")
                    .HasColumnName("SignContractDT")
                    .HasColumnType("datetime");

                b.Property<string>("SqlPass");

                b.Property<string>("SqlUser");

                b.Property<string>("Status");

                b.Property<bool?>("StatusFramework");

                b.Property<string>("Surrogate");

                b.Property<string>("TaxCode");

                b.Property<bool>("TwoFactorEnabled");

                b.Property<string>("UserName");

                b.Property<decimal?>("Value");

                b.Property<string>("ValueString1");

                b.Property<string>("ValueString2");

                b.Property<string>("Website");

                b.Property<string>("XmlTemp");

                b.HasKey("Id");

                b.ToTable("AppUsers");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.AppUserClaim", b =>
            {
                b.Property<string>("UserId")
                    .HasMaxLength(128);

                b.Property<string>("AppUserId")
                    .HasColumnName("AppUser_Id")
                    .HasMaxLength(128);

                b.Property<string>("ClaimType");

                b.Property<string>("ClaimValue");

                b.Property<string>("Id");

                b.HasKey("UserId");

                b.HasIndex("AppUserId");

                b.ToTable("AppUserClaims");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.AppUserLogin", b =>
            {
                b.Property<string>("UserId")
                    .HasMaxLength(128);

                b.Property<string>("AppUserId")
                    .HasColumnName("AppUser_Id")
                    .HasMaxLength(128);

                b.Property<string>("LoginProvider");

                b.Property<string>("ProviderKey");

                b.HasKey("UserId");

                b.HasIndex("AppUserId");

                b.ToTable("AppUserLogins");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.AppUserRole", b =>
            {
                b.Property<string>("UserId")
                    .HasMaxLength(128);

                b.Property<string>("RoleId")
                    .HasMaxLength(128);

                b.Property<string>("AppUserId")
                    .HasColumnName("AppUser_Id")
                    .HasMaxLength(128);

                b.Property<int>("Id");

                b.Property<string>("IdentityRoleId")
                    .HasColumnName("IdentityRole_Id")
                    .HasMaxLength(128);

                b.HasKey("UserId", "RoleId");

                b.HasIndex("AppUserId");

                b.HasIndex("IdentityRoleId");

                b.ToTable("AppUserRoles");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.Asset", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("AssetCode");

                b.Property<string>("AssetName");

                b.Property<DateTime>("DayImport");

                b.Property<int>("DepreciationMonths");

                b.Property<float>("DepreciationRateByYear");

                b.Property<string>("GroupAssetCode");

                b.Property<bool>("IsDeleted");

                b.Property<int>("OriginalPrice");

                b.Property<string>("Provider");

                b.Property<string>("SeriCode");

                b.Property<DateTime>("WarrantyPeriod");

                b.HasKey("Id");

                b.ToTable("Assets");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.AssetType", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("AssetTypeCode");

                b.Property<string>("AssetTypeName");

                b.Property<bool>("IsDeleted");

                b.HasKey("Id");

                b.ToTable("AssetTypes");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.Customer", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Address");

                b.Property<string>("CreatedBy");

                b.Property<DateTime?>("CreatedDate");

                b.Property<string>("Info");

                b.Property<bool>("IsDelete");

                b.Property<string>("Name");

                b.Property<string>("UpdatedBy");

                b.Property<DateTime?>("UpdatedDate");

                b.HasKey("Id");

                b.ToTable("Customers");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.DemoModel", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("CreatedBy");

                b.Property<DateTime?>("CreatedDate");

                b.Property<DateTime?>("Date");

                b.Property<string>("Info");

                b.Property<bool>("IsDelete");

                b.Property<string>("UpdatedBy");

                b.Property<DateTime?>("UpdatedDate");

                b.Property<int?>("Value");

                b.HasKey("Id");

                b.ToTable("DemoModels");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.Depreciation", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("AssetCode");

                b.Property<DateTime>("DayBeginCalculateDepreciation");

                b.Property<float>("DepreciatedValue");

                b.Property<string>("DepreciationCode");

                b.Property<int>("DepreciationMonths");

                b.Property<float>("DepreciationRateByYear");

                b.Property<bool>("IsDeleted");

                b.Property<string>("Name");

                b.Property<int?>("ParentId");

                b.Property<float>("RemainingValue");

                b.Property<bool>("Status");

                b.HasKey("Id");

                b.ToTable("Depreciations");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.Function", b =>
            {
                b.Property<string>("Id")
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                b.Property<int>("DisplayOrder");

                b.Property<string>("IconCss");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(50);

                b.Property<string>("ParentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                b.Property<bool>("Status");

                b.Property<string>("Url")
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(256);

                b.HasKey("Id");

                b.HasIndex("ParentId");

                b.ToTable("Functions");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.GroupAsset", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("AssetAcount");

                b.Property<string>("AssetTypeCode");

                b.Property<string>("CostsAccount");

                b.Property<string>("DepreciationAccount");

                b.Property<int>("DepreciationMonths");

                b.Property<float>("DepreciationRateByYear");

                b.Property<string>("GroupAssetCode");

                b.Property<string>("GroupAssetName");

                b.Property<string>("IncomeAccount");

                b.Property<bool>("IsDeleted");

                b.Property<string>("LiquidationCostAccount");

                b.Property<string>("ParentGroupAssetCode");

                b.HasKey("Id");

                b.ToTable("GroupAssets");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.MenuClient", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Alias")
                    .IsRequired()
                    .HasMaxLength(256);

                b.Property<string>("CreatedBy")
                    .HasMaxLength(256);

                b.Property<DateTime?>("CreatedDate")
                    .HasColumnType("datetime");

                b.Property<string>("Description")
                    .HasMaxLength(500);

                b.Property<int?>("DisplayOrder");

                b.Property<bool?>("HomeFlag");

                b.Property<int?>("HomeOrder");

                b.Property<string>("Image")
                    .HasMaxLength(256);

                b.Property<string>("MetaDescription")
                    .HasMaxLength(256);

                b.Property<string>("MetaKeyword")
                    .HasMaxLength(256);

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(256);

                b.Property<int?>("ParentId")
                    .HasColumnName("ParentID");

                b.Property<bool>("Status");

                b.Property<string>("UpdatedBy")
                    .HasMaxLength(256);

                b.Property<DateTime?>("UpdatedDate")
                    .HasColumnType("datetime");

                b.HasKey("Id");

                b.ToTable("MenuClients");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.Permission", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<bool>("CanCreate");

                b.Property<bool>("CanDelete");

                b.Property<bool>("CanRead");

                b.Property<bool>("CanUpdate");

                b.Property<string>("FunctionId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                b.Property<string>("RoleId")
                    .HasMaxLength(128);

                b.HasKey("Id");

                b.HasIndex("FunctionId");

                b.HasIndex("RoleId");

                b.ToTable("GPermissions");
            });

            modelBuilder.Entity("GSoft.AbpZeroTemplate.Editions.SubscribableEdition", b =>
            {
                b.HasBaseType("Abp.Application.Editions.Edition");

                b.Property<decimal?>("AnnualPrice");

                b.Property<int?>("ExpiringEditionId");

                b.Property<decimal?>("MonthlyPrice");

                b.Property<int?>("TrialDayCount");

                b.Property<int?>("WaitingDayAfterExpire");

                b.ToTable("AbpEditions");

                b.HasDiscriminator().HasValue("SubscribableEdition");
            });

            modelBuilder.Entity("Abp.Application.Features.EditionFeatureSetting", b =>
            {
                b.HasBaseType("Abp.Application.Features.FeatureSetting");

                b.Property<int>("EditionId");

                b.HasIndex("EditionId", "Name");

                b.ToTable("AbpFeatures");

                b.HasDiscriminator().HasValue("EditionFeatureSetting");
            });

            modelBuilder.Entity("Abp.MultiTenancy.TenantFeatureSetting", b =>
            {
                b.HasBaseType("Abp.Application.Features.FeatureSetting");


                b.HasIndex("TenantId", "Name");

                b.ToTable("AbpFeatures");

                b.HasDiscriminator().HasValue("TenantFeatureSetting");
            });

            modelBuilder.Entity("Abp.Authorization.Roles.RolePermissionSetting", b =>
            {
                b.HasBaseType("Abp.Authorization.PermissionSetting");

                b.Property<int>("RoleId");

                b.HasIndex("RoleId");

                b.ToTable("AbpPermissions");

                b.HasDiscriminator().HasValue("RolePermissionSetting");
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserPermissionSetting", b =>
            {
                b.HasBaseType("Abp.Authorization.PermissionSetting");

                b.Property<long>("UserId");

                b.HasIndex("UserId");

                b.ToTable("AbpPermissions");

                b.HasDiscriminator().HasValue("UserPermissionSetting");
            });

            modelBuilder.Entity("Abp.Authorization.Roles.RoleClaim", b =>
            {
                b.HasOne("GSoft.AbpZeroTemplate.Authorization.Roles.Role")
                    .WithMany("Claims")
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserClaim", b =>
            {
                b.HasOne("GSoft.AbpZeroTemplate.Authorization.Users.User")
                    .WithMany("Claims")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserLogin", b =>
            {
                b.HasOne("GSoft.AbpZeroTemplate.Authorization.Users.User")
                    .WithMany("Logins")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserRole", b =>
            {
                b.HasOne("GSoft.AbpZeroTemplate.Authorization.Users.User")
                    .WithMany("Roles")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserToken", b =>
            {
                b.HasOne("GSoft.AbpZeroTemplate.Authorization.Users.User")
                    .WithMany("Tokens")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Abp.Configuration.Setting", b =>
            {
                b.HasOne("GSoft.AbpZeroTemplate.Authorization.Users.User")
                    .WithMany("Settings")
                    .HasForeignKey("UserId");
            });

            modelBuilder.Entity("Abp.EntityHistory.EntityChange", b =>
            {
                b.HasOne("Abp.EntityHistory.EntityChangeSet")
                    .WithMany("EntityChanges")
                    .HasForeignKey("EntityChangeSetId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Abp.EntityHistory.EntityPropertyChange", b =>
            {
                b.HasOne("Abp.EntityHistory.EntityChange")
                    .WithMany("PropertyChanges")
                    .HasForeignKey("EntityChangeId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Abp.Organizations.OrganizationUnit", b =>
            {
                b.HasOne("Abp.Organizations.OrganizationUnit", "Parent")
                    .WithMany("Children")
                    .HasForeignKey("ParentId");
            });

            modelBuilder.Entity("GSoft.AbpZeroTemplate.Authorization.Roles.Role", b =>
            {
                b.HasOne("GSoft.AbpZeroTemplate.Authorization.Users.User", "CreatorUser")
                    .WithMany()
                    .HasForeignKey("CreatorUserId");

                b.HasOne("GSoft.AbpZeroTemplate.Authorization.Users.User", "DeleterUser")
                    .WithMany()
                    .HasForeignKey("DeleterUserId");

                b.HasOne("GSoft.AbpZeroTemplate.Authorization.Users.User", "LastModifierUser")
                    .WithMany()
                    .HasForeignKey("LastModifierUserId");
            });

            modelBuilder.Entity("GSoft.AbpZeroTemplate.Authorization.Users.User", b =>
            {
                b.HasOne("GSoft.AbpZeroTemplate.Authorization.Users.User", "CreatorUser")
                    .WithMany()
                    .HasForeignKey("CreatorUserId");

                b.HasOne("GSoft.AbpZeroTemplate.Authorization.Users.User", "DeleterUser")
                    .WithMany()
                    .HasForeignKey("DeleterUserId");

                b.HasOne("GSoft.AbpZeroTemplate.Authorization.Users.User", "LastModifierUser")
                    .WithMany()
                    .HasForeignKey("LastModifierUserId");
            });

            modelBuilder.Entity("GSoft.AbpZeroTemplate.MultiTenancy.Payments.SubscriptionPayment", b =>
            {
                b.HasOne("Abp.Application.Editions.Edition", "Edition")
                    .WithMany()
                    .HasForeignKey("EditionId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("GSoft.AbpZeroTemplate.MultiTenancy.Tenant", b =>
            {
                b.HasOne("GSoft.AbpZeroTemplate.Authorization.Users.User", "CreatorUser")
                    .WithMany()
                    .HasForeignKey("CreatorUserId");

                b.HasOne("GSoft.AbpZeroTemplate.Authorization.Users.User", "DeleterUser")
                    .WithMany()
                    .HasForeignKey("DeleterUserId");

                b.HasOne("Abp.Application.Editions.Edition", "Edition")
                    .WithMany()
                    .HasForeignKey("EditionId");

                b.HasOne("GSoft.AbpZeroTemplate.Authorization.Users.User", "LastModifierUser")
                    .WithMany()
                    .HasForeignKey("LastModifierUserId");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.Announcement", b =>
            {
                b.HasOne("GWebsite.AbpZeroTemplate.Core.Models.AppUser", "User")
                    .WithMany("Announcements")
                    .HasForeignKey("UserId")
                    .HasConstraintName("FK_dbo.Announcements_dbo.AppUsers_AppUser_Id");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.AnnouncementUser", b =>
            {
                b.HasOne("GWebsite.AbpZeroTemplate.Core.Models.Announcement", "Announcement")
                    .WithMany("AnnouncementUsers")
                    .HasForeignKey("AnnouncementId")
                    .HasConstraintName("FK_dbo.AnnouncementUsers_dbo.Announcements_AnnouncementId")
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("GWebsite.AbpZeroTemplate.Core.Models.AppUser", "User")
                    .WithMany("AnnouncementUsers")
                    .HasForeignKey("UserId")
                    .HasConstraintName("FK_dbo.AnnouncementUsers_dbo.AppUsers_UserId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.AppUserClaim", b =>
            {
                b.HasOne("GWebsite.AbpZeroTemplate.Core.Models.AppUser", "AppUser")
                    .WithMany("AppUserClaims")
                    .HasForeignKey("AppUserId")
                    .HasConstraintName("FK_dbo.AppUserClaims_dbo.AppUsers_AppUser_Id");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.AppUserLogin", b =>
            {
                b.HasOne("GWebsite.AbpZeroTemplate.Core.Models.AppUser", "AppUser")
                    .WithMany("AppUserLogins")
                    .HasForeignKey("AppUserId")
                    .HasConstraintName("FK_dbo.AppUserLogins_dbo.AppUsers_AppUser_Id");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.AppUserRole", b =>
            {
                b.HasOne("GWebsite.AbpZeroTemplate.Core.Models.AppUser", "AppUser")
                    .WithMany("AppUserRoles")
                    .HasForeignKey("AppUserId")
                    .HasConstraintName("FK_dbo.AppUserRoles_dbo.AppUsers_AppUser_Id");

                b.HasOne("GWebsite.AbpZeroTemplate.Core.Models.AppRole", "IdentityRole")
                    .WithMany("AppUserRoles")
                    .HasForeignKey("IdentityRoleId")
                    .HasConstraintName("FK_dbo.AppUserRoles_dbo.AppRoles_IdentityRole_Id");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.Function", b =>
            {
                b.HasOne("GWebsite.AbpZeroTemplate.Core.Models.Function", "Parent")
                    .WithMany("InverseParent")
                    .HasForeignKey("ParentId")
                    .HasConstraintName("FK_dbo.Functions_dbo.Functions_ParentId");
            });

            modelBuilder.Entity("GWebsite.AbpZeroTemplate.Core.Models.Permission", b =>
            {
                b.HasOne("GWebsite.AbpZeroTemplate.Core.Models.Function", "Function")
                    .WithMany("Permissions")
                    .HasForeignKey("FunctionId")
                    .HasConstraintName("FK_dbo.Permissions_dbo.Functions_FunctionId");

                b.HasOne("GWebsite.AbpZeroTemplate.Core.Models.AppRole", "Role")
                    .WithMany("Permissions")
                    .HasForeignKey("RoleId")
                    .HasConstraintName("FK_dbo.Permissions_dbo.AppRoles_RoleId");
            });

            modelBuilder.Entity("Abp.Application.Features.EditionFeatureSetting", b =>
            {
                b.HasOne("Abp.Application.Editions.Edition", "Edition")
                    .WithMany()
                    .HasForeignKey("EditionId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Abp.Authorization.Roles.RolePermissionSetting", b =>
            {
                b.HasOne("GSoft.AbpZeroTemplate.Authorization.Roles.Role")
                    .WithMany("Permissions")
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserPermissionSetting", b =>
            {
                b.HasOne("GSoft.AbpZeroTemplate.Authorization.Users.User")
                    .WithMany("Permissions")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade);
            });
#pragma warning restore 612, 618
        }
    }
}