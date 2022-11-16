using System;
using System.Collections.Generic;

namespace KTSD.Core.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public bool FirstLogin { get; set; }
        public int RoleId { get; set; }


        public Role Role { get; set; }

        // public int? WorkGroupId { get; set; }
        // public virtual WorkGroup WorkGroup { get; set; }
        public ICollection<UserFile> UserFiles { get; set; }
        public ICollection<UserFolder> UserFolders { get; set; }
        public ICollection<UserWorkGroup> UserWorkGroups { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
    }

    public class UserCreateReq : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public int MemberId { get; set; }

    }

    public class UserUpdateReq : User
    {
        public List<int> WorkgroupIds { get; set; }
    }

    public class UserListRes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public RoleRes Role { get; set; }
        public MemberResponse Member { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public bool FirstLogin { get; set; }
    }

    public class UserInfoRes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public RoleRes Role { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public bool FirstLogin { get; set; }
    }

    public class ChangePasswordRequestModel
    {
        public string Email { get; set; }
        // public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }

    public class ChangePasswordResponseModel
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }

}