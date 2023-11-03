using System.Dynamic;

namespace FormBagSample
{
    public class FormBag : DynamicObject
    {
        //ViewBag.UserName = "turkayurkmez"
        //Expa
        private Dictionary<string, object> properties = new Dictionary<string, object>();
        public override bool TrySetMember(SetMemberBinder binder, object? value)
        {
            return properties.TryAdd(binder.Name, value);
        }

        public override bool TryGetMember(GetMemberBinder binder, out object? result)
        {
            return properties.TryGetValue(binder.Name, out result);
        }
        //ExpandoObject <-> DynamicObject
    }
}
