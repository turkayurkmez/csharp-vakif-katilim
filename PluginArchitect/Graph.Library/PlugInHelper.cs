using System.Reflection;

namespace Graph.Library
{
    public class PlugInHelper
    {
        public static List<Plug> GetPlugins(string selectedPath)
        {


            ArgumentException.ThrowIfNullOrEmpty(nameof(selectedPath));

            if (!Directory.Exists(selectedPath))
            {
                throw new FileNotFoundException($"{selectedPath} klasörü bulunamadı");
            }

            var plugins = getPluginsFromPath(selectedPath);
            return plugins;
        }

        private static List<Plug> getPluginsFromPath(string selectedPath)
        {
            //1. O klasör içerisindeki .dll dosyaları al ve referans ekle
            var dllFiles = Directory.GetFiles(selectedPath, "*.dll");
            var plugins = new List<Plug>();
            dllFiles?.ToList().ForEach(file => addReference(file, plugins));
            return plugins;
        }

        private static void addReference(string file, List<Plug> plugins)
        {
            var assembly = Assembly.LoadFile(file);
            var types = assembly.GetTypes();
            types?.ToList().ForEach(type =>
            {
                Plug plug = handShakeForApp(type, file);
                if (plug is not null)
                {
                    plugins.Add(plug);
                }
            });
        }

        private static Plug handShakeForApp(Type type, string file)
        {
            Plug plug = null;
            if (type.GetInterface("IPlug") is not null)
            {
                plug = new Plug();
                plug.Path = file;
                plug.FullName = type.FullName;

                var instance = Activator.CreateInstance(type);
                plug.Name = instance.GetType().GetProperty("Name").GetValue(instance).ToString();

            }

            return plug;

        }
    }
}