namespace GenericNameSpace
{

    using System.IO;

    public class GenericClass
    {
        public string MakeAgentVersionFolder(IJustAClass j, string path)
        {
            return Path.Combine(Path.GetDirectoryName(path), j.Version);
        }
    }

    public class JustAClass : IJustAClass
    {
        public string Version { get; set; }
    }
}
