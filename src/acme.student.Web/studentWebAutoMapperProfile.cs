using acme.student.Entities.Commons;
using acme.student.Models.LopHoc;
using acme.student.Models.SinhVien;
using AutoMapper;

namespace acme.student.Web;

public class studentWebAutoMapperProfile : Profile
{
    public studentWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        //Sinh vien
        CreateMap<SinhVien, SinhVienResponse>();
        CreateMap<SinhVienRequest, SinhVien>();
        CreateMap<SinhVienResponse, SinhVienRequest>();

        //LopHoc
        CreateMap<LopHoc, LopHocResponse>();
        CreateMap<LopHocRequest, LopHoc>();
        CreateMap<LopHocResponse, LopHocRequest>();
    }
}
