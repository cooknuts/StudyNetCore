﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace StudyNetCore.Model.Models
{
    public partial class AuthorizationPermission
    {
        public string Guid { get; set; }
        public string ParentId { get; set; }
        public string PermissionName { get; set; }
        public string PermissionNote { get; set; }
        public DateOnly? GenerateTime { get; set; }
    }
}