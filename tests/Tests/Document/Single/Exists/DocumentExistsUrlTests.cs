﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Domain;
using Tests.Framework.EndpointTests;
using static Tests.Framework.EndpointTests.UrlTester;

namespace Tests.Document.Single.Exists
{
	public class DocumentExistsUrlTests
	{
		[U] public async Task Urls() => await HEAD("/project/_doc/1")
			.Fluent(c => c.DocumentExists<Project>(1))
			.Request(c => c.DocumentExists(new DocumentExistsRequest<Project>(1)))
			.FluentAsync(c => c.DocumentExistsAsync<Project>(1))
			.RequestAsync(c => c.DocumentExistsAsync(new DocumentExistsRequest<Project>(1)));
	}
}
