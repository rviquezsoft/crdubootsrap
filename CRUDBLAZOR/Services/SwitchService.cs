using System;
namespace CRUDBLAZOR.Services
{
    public class SwitchService : ISwitchService
    {
        public void Switch(ref bool value)
        {
            value = !value;
        }
    }
}

