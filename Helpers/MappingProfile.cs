using AutoMapper;
using md_notes.DTOs.Auth;
using md_notes.Models;

namespace md_notes.Helpers
{
    public class MappingProfile: Profile
    {
        public MappingProfile() {
            // User
            CreateMap<User, UserInfoResponse>();
            
        }
    }
}
