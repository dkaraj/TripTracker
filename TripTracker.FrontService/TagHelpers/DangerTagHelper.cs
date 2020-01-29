﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TripTracker.FrontService.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement(Attributes="danger")]
    public class DangerTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var ccsDanger = "text-danger";
            if (context.AllAttributes.ContainsName("class"))
            {
                output.Attributes.SetAttribute("class", string.Concat(output.Attributes["class"].Value, ccsDanger));
            }
            else
            {
                output.Attributes.SetAttribute("class", ccsDanger);
            }
            output.Attributes.Remove(output.Attributes["danger"]);
        }
    }
}
