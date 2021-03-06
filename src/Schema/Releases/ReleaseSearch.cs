﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using SevenDigital.Api.Schema.Attributes;
using SevenDigital.Api.Schema.ParameterDefinitions.Get;

namespace SevenDigital.Api.Schema.Releases
{
	[Serializable]
	[ApiEndpoint("release/search")]
	[XmlRoot("searchResults")]
	public class ReleaseSearch : HasPaging, HasSearchParameter, HasUsageTypesParameter
	{
		public ReleaseSearch()
		{
			Results = new List<ReleaseSearchResult>();
		}

		[XmlElement("searchResult")]
		public List<ReleaseSearchResult> Results { get; set; }
	}
}