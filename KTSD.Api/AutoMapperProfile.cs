using AutoMapper;
using KTSD.Core.Models;

namespace KTSD.Api
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserCreateReq>();
            CreateMap<UserCreateReq, User>();

            CreateMap<User, UserListRes>();
            CreateMap<UserListRes, User>();

            CreateMap<User, UserInfoRes>();
            CreateMap<UserInfoRes, User>();

            CreateMap<Role, RoleRes>();
            CreateMap<RoleRes, Role>();

            CreateMap<NavMenu, NavMenuListRes>();
            CreateMap<NavMenuListRes, NavMenu>();

            CreateMap<Folder, FolderListRes>();
            CreateMap<FolderListRes, Folder>();
            
            CreateMap<Member, MemberResponse>();
            CreateMap<MemberResponse, Member>();
            
            CreateMap<Page, PageListRes>();
            CreateMap<PageListRes, Page>();


        }
    }
}