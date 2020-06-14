using AutoMapper;

namespace ChillForum.Common.Infrastructure.AutoMapper
{
    public interface IMapFrom<T>
    {
        void Mapping(Profile mapper) => mapper.CreateMap(typeof(T), this.GetType());
    }
}
