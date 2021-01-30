using Bootcamp.Attributes_Reflection.Enums;
using System;

namespace Bootcamp.Attributes_Reflection.CustomAttribute
{
    [AttributeUsage(AttributeTargets.Class | 
        AttributeTargets.Constructor | 
        AttributeTargets.Method, AllowMultiple = true)]
    public class RoleAccessAttribute : Attribute
    {
        public UserRole UserRole { get; set; }

        public RoleAccessAttribute(UserRole role)
        {
            UserRole = role;
        }

    }
}
