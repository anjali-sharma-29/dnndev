﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UmbracoHelios
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RegisterEntities : DbContext
    {
        public RegisterEntities()
            : base("name=RegisterEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<RegisterUser> RegisterUsers { get; set; }
        public virtual DbSet<cmsContent> cmsContents { get; set; }
        public virtual DbSet<cmsContentType> cmsContentTypes { get; set; }
        public virtual DbSet<cmsContentTypeAllowedContentType> cmsContentTypeAllowedContentTypes { get; set; }
        public virtual DbSet<cmsContentVersion> cmsContentVersions { get; set; }
        public virtual DbSet<cmsContentXml> cmsContentXmls { get; set; }
        public virtual DbSet<cmsDataType> cmsDataTypes { get; set; }
        public virtual DbSet<cmsDataTypePreValue> cmsDataTypePreValues { get; set; }
        public virtual DbSet<cmsDictionary> cmsDictionaries { get; set; }
        public virtual DbSet<cmsDocument> cmsDocuments { get; set; }
        public virtual DbSet<cmsDocumentType> cmsDocumentTypes { get; set; }
        public virtual DbSet<cmsLanguageText> cmsLanguageTexts { get; set; }
        public virtual DbSet<cmsMacro> cmsMacroes { get; set; }
        public virtual DbSet<cmsMacroProperty> cmsMacroProperties { get; set; }
        public virtual DbSet<cmsMember> cmsMembers { get; set; }
        public virtual DbSet<cmsMemberType> cmsMemberTypes { get; set; }
        public virtual DbSet<cmsPreviewXml> cmsPreviewXmls { get; set; }
        public virtual DbSet<cmsPropertyData> cmsPropertyDatas { get; set; }
        public virtual DbSet<cmsPropertyType> cmsPropertyTypes { get; set; }
        public virtual DbSet<cmsPropertyTypeGroup> cmsPropertyTypeGroups { get; set; }
        public virtual DbSet<cmsTagRelationship> cmsTagRelationships { get; set; }
        public virtual DbSet<cmsTag> cmsTags { get; set; }
        public virtual DbSet<cmsTask> cmsTasks { get; set; }
        public virtual DbSet<cmsTaskType> cmsTaskTypes { get; set; }
        public virtual DbSet<cmsTemplate> cmsTemplates { get; set; }
        public virtual DbSet<Signup> Signups { get; set; }
        public virtual DbSet<umbracoAccess> umbracoAccesses { get; set; }
        public virtual DbSet<umbracoAccessRule> umbracoAccessRules { get; set; }
        public virtual DbSet<umbracoCacheInstruction> umbracoCacheInstructions { get; set; }
        public virtual DbSet<umbracoDomain> umbracoDomains { get; set; }
        public virtual DbSet<umbracoExternalLogin> umbracoExternalLogins { get; set; }
        public virtual DbSet<umbracoLanguage> umbracoLanguages { get; set; }
        public virtual DbSet<umbracoLock> umbracoLocks { get; set; }
        public virtual DbSet<umbracoLog> umbracoLogs { get; set; }
        public virtual DbSet<umbracoMigration> umbracoMigrations { get; set; }
        public virtual DbSet<umbracoNode> umbracoNodes { get; set; }
        public virtual DbSet<umbracoRedirectUrl> umbracoRedirectUrls { get; set; }
        public virtual DbSet<umbracoRelation> umbracoRelations { get; set; }
        public virtual DbSet<umbracoRelationType> umbracoRelationTypes { get; set; }
        public virtual DbSet<umbracoServer> umbracoServers { get; set; }
        public virtual DbSet<umbracoUser> umbracoUsers { get; set; }
        public virtual DbSet<umbracoUser2NodeNotify> umbracoUser2NodeNotify { get; set; }
        public virtual DbSet<umbracoUserGroup> umbracoUserGroups { get; set; }
        public virtual DbSet<umbracoUserGroup2App> umbracoUserGroup2App { get; set; }
        public virtual DbSet<umbracoUserGroup2NodePermission> umbracoUserGroup2NodePermission { get; set; }
        public virtual DbSet<umbracoUserStartNode> umbracoUserStartNodes { get; set; }
    }
}
