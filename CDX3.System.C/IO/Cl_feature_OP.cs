using System.Runtime.Serialization;

namespace CDX3.System.C.IO
{
    public class Cl_feature_OP
    {
        [DataMember]
        public string Output { get; set; }

        public Cl_feature_OP()
        {
            Output = string.Empty;
        }
        public void ConcatenateInputData(Cl_feature_IP ip)
        {
            Output = $"user: {ip.user_id}, tenant: {ip.tenant_code}, system: {ip.system_code}, name: {ip.name}";
        }
    }
}
