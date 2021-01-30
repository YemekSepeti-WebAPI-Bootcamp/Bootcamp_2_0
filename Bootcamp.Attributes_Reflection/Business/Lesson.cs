using Bootcamp.Attributes_Reflection.Abstract;
using Bootcamp.Attributes_Reflection.CustomAttribute;
using Bootcamp.Attributes_Reflection.Enums;
using System;
using System.Linq;

namespace Bootcamp.Attributes_Reflection.Business
{
    [RoleAccess(UserRole.Admin)]
    [RoleAccess(UserRole.Master)]
    public class Lesson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private User User;

        public Lesson(int id, string name, User user)
        {
            var typeInfo = typeof(Lesson);
            RoleAccessAttribute[] roleAttributes = 
                typeInfo.GetCustomAttributes(typeof(RoleAccessAttribute), true) 
                as RoleAccessAttribute[];

            if (roleAttributes != null)
            {
                if (roleAttributes.All(ra => ra.UserRole.ToString() != 
                   user.GetType().Name))
                {
                    throw new ArgumentException("Kullanıcı yeterli yetkiye sahip değil");
                }
            }

            this.Id = id;
            this.Name = name;
            this.User = user;

        }
    }
}
