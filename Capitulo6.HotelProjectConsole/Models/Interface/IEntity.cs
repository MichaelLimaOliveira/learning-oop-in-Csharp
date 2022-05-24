namespace Capitulo6.HotelProjectConsole.Models.Interface
{
    public static class Entity
    {
        public static void UpdateObject(this object obj, object updatedObj)
        {
            if (obj.GetType() != updatedObj.GetType())
                throw new Exception("Different types!");

            var properties = obj.GetType().GetProperties();

            foreach(var property in properties)
            {
                var updatedValue = property.GetValue(updatedObj);
                property.SetValue(obj, updatedValue);
            }
        }
    }
}
