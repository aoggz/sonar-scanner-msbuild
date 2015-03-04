﻿//-----------------------------------------------------------------------
// <copyright file="RulesetWriter.cs" company="SonarSource SA and Microsoft Corporation">
//   (c) SonarSource SA and Microsoft Corporation.  All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sonar.FxCopRuleset
{
    public static class RulesetWriter
    {
        public static string ToString(IEnumerable<string> ids)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sb.AppendLine("<RuleSet Name=\"SonarQube\" Description=\"Rule set generated by SonarQube\" ToolsVersion=\"12.0\">");

            sb.AppendLine("  <Rules AnalyzerId=\"Microsoft.Analyzers.ManagedCodeAnalysis\" RuleNamespace=\"Microsoft.Rules.Managed\">");
            foreach (string id in ids)
            {
                sb.AppendLine("    <Rule Id=\"" + id + "\" Action=\"Error\" />");
            }
            sb.AppendLine("  </Rules>");

            sb.AppendLine("</RuleSet>");

            return sb.ToString();
        }
    }
}
