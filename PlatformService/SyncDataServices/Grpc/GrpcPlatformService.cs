using System.Threading.Tasks;
using AutoMapper;
using Grpc.Core;
using PlatformService.Data;

namespace PlatformService.SyncDataServices.Grpc
{
    public class GrpcPlatformService : GrpcPlatform.GrpcPlatformBase
    {
        private readonly IMapper _mapper;
        private readonly IPlatformRepo _repo;

        public GrpcPlatformService(IPlatformRepo platformRepo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = platformRepo;
        }

        public override Task<PlatformResponse> GetAllPlatforms(GetAllRequest request, ServerCallContext serverCallContext)
        {
            var response = new PlatformResponse();
            var platforms = _repo.GetAllPlatforms();

            foreach (var plat in platforms)
            {
                response.Platform.Add(_mapper.Map<GrpcPlatformModel>(plat));
            }

            return Task.FromResult(response);
        }
    }
}