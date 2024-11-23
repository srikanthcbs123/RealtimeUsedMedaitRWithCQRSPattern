using MediatR;

namespace RealtimeUsedMedaitRWithCQRSPattern
{
    public class DeleteStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}

