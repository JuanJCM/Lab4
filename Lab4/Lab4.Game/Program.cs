using System;
using Lab.Core;
using Lab.Core.Models.Pieces;
using Lab.Core.Models.Rules;
using Lab4.Infrastructure.Serializers;
using Lab4.Infrastructure.Sources;
using Newtonsoft.Json.Linq;
using RulesBuilder = Lab.Core.Rules.Builder.RulesBuilder;
namespace Lab4.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileContent = new JsonFileGameSource().GetData();
            var arrayOfMovements = JArray.Parse(fileContent);
            var gameSerializer = new JsonFileGameSerializer();
            var ruleEngine = new RulesBuilder().WithKnightRules().WithRookRules().Build();
            var gameEngine = new GameEngine( new PieceFactory(), ruleEngine);
            foreach (var movementData in arrayOfMovements)
            {
                var movement = gameSerializer.SerializeMovement(movementData.ToString());
                gameEngine.ExecuteMovement(movement);
            }
        }
    }
}
