namespace CDX3.System.C.IO
{
    public class Cl_feature_IP
    {
        public int user_id { get; set; }
        public int tenant_code { get; set; }
        public string system_code { get; set; }
        public string name { get; set; }
        public Cl_feature_IP()
        {
            user_id = 0;
            tenant_code = 0;
            system_code = "";
            name = "";
        }
    }
}
