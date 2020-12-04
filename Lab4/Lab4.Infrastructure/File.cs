
using System.IO;
using Lab.Core.Interfaces;

namespace Lab4.Infrastructure.Sources
{
    public class JsonFileGameSource : IGameSource
    {
        public string GetData()
        {
            return File.ReadAllText("game.json");
        }
    }
}