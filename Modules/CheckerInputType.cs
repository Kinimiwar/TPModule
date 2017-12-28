using System;

namespace TPModule.Modules
{
    [Flags]
    public enum CheckerInputType : byte
    {
        User_Pass = 0x0,
        Mail_Pass = 0x1,
        UserOrMail_Pass = User_Pass | Mail_Pass,
    }
}