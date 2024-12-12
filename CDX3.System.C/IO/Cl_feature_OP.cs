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
            Output = $"{ip.user_id} {ip.tenant_code} {ip.system_code} {ip.name}";
        }
    }
}
