﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGeneration.LowLevelClient.Overrides.Descriptors
{
	public class SearchDescriptorOverrides : DescriptorOverridesBase
	{
		public override IEnumerable<string> SkipQueryStringParams
		{
			get
			{
				return new string[]
				{
					"size", 
					"from",
					"timeout",
					"explain",
					"version",
					"q", //we dont support GET searches
					"fields",
					"indices_boost",
					"source",
					"sort",
					"_source",
					"_source_include",
					"_source_exclude",
					"track_scores",
					"terminate_after",
					"fielddata_fields"
				};
			}
		}
	}
}
