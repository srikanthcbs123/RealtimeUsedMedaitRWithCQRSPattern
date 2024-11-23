using MediatR;
namespace RealtimeUsedMedaitRWithCQRSPattern
{
    public class GetStudentByIdQuery : IRequest<StudentDetails>
    {
        public int Id { get; set; }
    }
}
