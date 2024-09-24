namespace AltV.Net
{
    public partial class Alt
    {
        public static void StartResource(string name) => CoreImpl.StartResource(name);

        public static void StopResource(string name) => CoreImpl.StopResource(name);

        public static void RestartResource(string name) => CoreImpl.RestartResource(name);

        public static INativeResource GetResource(string name) => CoreImpl.GetResource(name);
        public static INativeResource[] GetAllResources() => CoreImpl.GetAllResources();

        public static INativeResource Resource => CoreImpl.Resource;
    }
}