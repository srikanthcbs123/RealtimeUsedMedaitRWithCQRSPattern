using MediatR;
namespace RealtimeUsedMedaitRWithCQRSPattern
{
    public class GetStudentListQuery :  IRequest<List<StudentDetails>>
    {
    }
}
