using System;
using System.Collections.Generic;
using System.Text;
using Lab.Core.Interfaces;
using Lab.Core.Models;
using Lab.Core.Models.Pieces;
using Lab.Core.Models.Rules;


namespace Lab.Core.Rules
{
    public class MovementRuleEngine
    {
        private readonly IEnumerable<ReglasBase> _rules;
        public MovementRuleEngine(IEnumerable<ReglasBase> reglas)
        {
            _rules = reglas;
        }


    }


}
