﻿using System.Runtime.Serialization;
using Elasticsearch.Net.Utf8Json;

namespace Nest
{
	[InterfaceDataContract]
	[ReadAs(typeof(ExtendedStatsAggregation))]
	public interface IExtendedStatsAggregation : IFormattableMetricAggregation
	{
		[DataMember(Name ="sigma")]
		double? Sigma { get; set; }
	}

	public class ExtendedStatsAggregation : FormattableMetricAggregationBase, IExtendedStatsAggregation
	{
		internal ExtendedStatsAggregation() { }

		public ExtendedStatsAggregation(string name, Field field) : base(name, field) { }

		public double? Sigma { get; set; }

		internal override void WrapInContainer(AggregationContainer c) => c.ExtendedStats = this;
	}

	public class ExtendedStatsAggregationDescriptor<T>
		: FormattableMetricAggregationDescriptorBase<ExtendedStatsAggregationDescriptor<T>, IExtendedStatsAggregation, T>
			, IExtendedStatsAggregation
		where T : class
	{
		double? IExtendedStatsAggregation.Sigma { get; set; }

		public ExtendedStatsAggregationDescriptor<T> Sigma(double? sigma) =>
			Assign(sigma, (a, v) => a.Sigma = v);
	}
}
