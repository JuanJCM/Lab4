using System;
using System.Collections.Generic;
using System.Text;
using Lab.Core.Models.Rules;
using Lab.Core.Interfaces;

namespace Lab.Core.Rules.Builder
{
    public partial class RulesBuilder
    {
        private readonly List<ReglasBase> _rules = new List<ReglasBase>();
        
        public RulesBuilder()
        {
            
        }

        public IRuleEngine Build()
        {
            _rules.Add(new ReglaMovimientoPeon());
                return new MovementRuleEngine(_rules);
        }
    }
}
