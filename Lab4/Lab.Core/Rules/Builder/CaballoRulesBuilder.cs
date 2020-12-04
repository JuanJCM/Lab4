using System;
using System.Collections.Generic;
using System.Text;
using Lab.Core.Models.Rules;
namespace Lab.Core.Rules.Builder
{
    public partial class RulesBuilder
    {
        public RulesBuilder WithKnightRules()
        {
            _rules.Add(new ReglaMovimientoCaballo());
            return this;
        }
    }
}
