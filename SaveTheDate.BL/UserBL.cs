using AutoMapper;
using SaveTheDate.DL;
using SaveTheDate.DL.Models;
using SaveTheDate.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveTheDate.BL
{
    public class UserBL : IUserBL
    {

        IUserDL _UserDL;
        IMapper mapper;

        public UserBL(IUserDL UserDL)
        {
            _UserDL = UserDL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }
        public int AddUser(UserDTO newUserDTO)
        {
            User myUser = mapper.Map<UserDTO, User>(newUserDTO);
            return _UserDL.AddUser(myUser);
        }

    }
}
