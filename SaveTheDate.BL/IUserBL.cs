using SaveTheDate.DTO;

namespace SaveTheDate.BL
{
    public interface IUserBL
    {
        int AddUser(UserDTO newUserDTO);
    }
}