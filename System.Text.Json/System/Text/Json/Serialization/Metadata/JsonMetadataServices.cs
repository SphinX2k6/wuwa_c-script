using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization.Converters;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000CC RID: 204
	[NullableContext(1)]
	[Nullable(0)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static class JsonMetadataServices
	{
		// Token: 0x06000A8B RID: 2699 RVA: 0x0002D3DD File Offset: 0x0002B5DD
		public static JsonTypeInfo<TElement[]> CreateArrayInfo<[Nullable(2)] TElement>(JsonSerializerOptions options, JsonCollectionInfoValues<TElement[]> collectionInfo)
		{
			return JsonMetadataServices.CreateCore<TElement[]>(options, collectionInfo, new ArrayConverter<TElement[], TElement>(), null, null);
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0002D3ED File Offset: 0x0002B5ED
		public static JsonTypeInfo<TCollection> CreateListInfo<[Nullable(0)] TCollection, [Nullable(2)] TElement>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo) where TCollection : List<TElement>
		{
			return JsonMetadataServices.CreateCore<TCollection>(options, collectionInfo, new ListOfTConverter<TCollection, TElement>(), null, null);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0002D3FD File Offset: 0x0002B5FD
		public static JsonTypeInfo<TCollection> CreateDictionaryInfo<[Nullable(0)] TCollection, TKey, [Nullable(2)] TValue>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo) where TCollection : Dictionary<TKey, TValue>
		{
			return JsonMetadataServices.CreateCore<TCollection>(options, collectionInfo, new DictionaryOfTKeyTValueConverter<TCollection, TKey, TValue>(), null, null);
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x0002D40D File Offset: 0x0002B60D
		public static JsonTypeInfo<TCollection> CreateImmutableDictionaryInfo<[Nullable(0)] TCollection, TKey, [Nullable(2)] TValue>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo, [Nullable(new byte[]
		{
			1,
			1,
			0,
			1,
			1,
			1
		})] Func<IEnumerable<KeyValuePair<TKey, TValue>>, TCollection> createRangeFunc) where TCollection : IReadOnlyDictionary<TKey, TValue>
		{
			if (createRangeFunc == null)
			{
				ThrowHelper.ThrowArgumentNullException("createRangeFunc");
			}
			return JsonMetadataServices.CreateCore<TCollection>(options, collectionInfo, new ImmutableDictionaryOfTKeyTValueConverter<TCollection, TKey, TValue>(), createRangeFunc, null);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0002D42A File Offset: 0x0002B62A
		public static JsonTypeInfo<TCollection> CreateIDictionaryInfo<[Nullable(0)] TCollection, TKey, [Nullable(2)] TValue>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo) where TCollection : IDictionary<TKey, TValue>
		{
			return JsonMetadataServices.CreateCore<TCollection>(options, collectionInfo, new IDictionaryOfTKeyTValueConverter<TCollection, TKey, TValue>(), null, null);
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0002D43A File Offset: 0x0002B63A
		public static JsonTypeInfo<TCollection> CreateIReadOnlyDictionaryInfo<[Nullable(0)] TCollection, TKey, [Nullable(2)] TValue>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo) where TCollection : IReadOnlyDictionary<TKey, TValue>
		{
			return JsonMetadataServices.CreateCore<TCollection>(options, collectionInfo, new IReadOnlyDictionaryOfTKeyTValueConverter<TCollection, TKey, TValue>(), null, null);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0002D44A File Offset: 0x0002B64A
		public static JsonTypeInfo<TCollection> CreateImmutableEnumerableInfo<[Nullable(0)] TCollection, [Nullable(2)] TElement>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo, Func<IEnumerable<TElement>, TCollection> createRangeFunc) where TCollection : IEnumerable<TElement>
		{
			if (createRangeFunc == null)
			{
				ThrowHelper.ThrowArgumentNullException("createRangeFunc");
			}
			return JsonMetadataServices.CreateCore<TCollection>(options, collectionInfo, new ImmutableEnumerableOfTConverter<TCollection, TElement>(), createRangeFunc, null);
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0002D467 File Offset: 0x0002B667
		public static JsonTypeInfo<TCollection> CreateIListInfo<[Nullable(0)] TCollection>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo) where TCollection : IList
		{
			return JsonMetadataServices.CreateCore<TCollection>(options, collectionInfo, new IListConverter<TCollection>(), null, null);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0002D477 File Offset: 0x0002B677
		public static JsonTypeInfo<TCollection> CreateIListInfo<[Nullable(0)] TCollection, [Nullable(2)] TElement>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo) where TCollection : IList<TElement>
		{
			return JsonMetadataServices.CreateCore<TCollection>(options, collectionInfo, new IListOfTConverter<TCollection, TElement>(), null, null);
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0002D487 File Offset: 0x0002B687
		public static JsonTypeInfo<TCollection> CreateISetInfo<[Nullable(0)] TCollection, [Nullable(2)] TElement>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo) where TCollection : ISet<TElement>
		{
			return JsonMetadataServices.CreateCore<TCollection>(options, collectionInfo, new ISetOfTConverter<TCollection, TElement>(), null, null);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0002D497 File Offset: 0x0002B697
		public static JsonTypeInfo<TCollection> CreateICollectionInfo<[Nullable(0)] TCollection, [Nullable(2)] TElement>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo) where TCollection : ICollection<TElement>
		{
			return JsonMetadataServices.CreateCore<TCollection>(options, collectionInfo, new ICollectionOfTConverter<TCollection, TElement>(), null, null);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0002D4A7 File Offset: 0x0002B6A7
		public static JsonTypeInfo<TCollection> CreateStackInfo<[Nullable(0)] TCollection, [Nullable(2)] TElement>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo) where TCollection : Stack<TElement>
		{
			return JsonMetadataServices.CreateCore<TCollection>(options, collectionInfo, new StackOfTConverter<TCollection, TElement>(), null, null);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0002D4B7 File Offset: 0x0002B6B7
		public static JsonTypeInfo<TCollection> CreateQueueInfo<[Nullable(0)] TCollection, [Nullable(2)] TElement>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo) where TCollection : Queue<TElement>
		{
			return JsonMetadataServices.CreateCore<TCollection>(options, collectionInfo, new QueueOfTConverter<TCollection, TElement>(), null, null);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0002D4C7 File Offset: 0x0002B6C7
		public static JsonTypeInfo<TCollection> CreateConcurrentStackInfo<[Nullable(0)] TCollection, [Nullable(2)] TElement>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo) where TCollection : ConcurrentStack<TElement>
		{
			return JsonMetadataServices.CreateCore<TCollection>(options, collectionInfo, new ConcurrentStackOfTConverter<TCollection, TElement>(), null, null);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0002D4D7 File Offset: 0x0002B6D7
		public static JsonTypeInfo<TCollection> CreateConcurrentQueueInfo<[Nullable(0)] TCollection, [Nullable(2)] TElement>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo) where TCollection : ConcurrentQueue<TElement>
		{
			return JsonMetadataServices.CreateCore<TCollection>(options, collectionInfo, new ConcurrentQueueOfTConverter<TCollection, TElement>(), null, null);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0002D4E7 File Offset: 0x0002B6E7
		public static JsonTypeInfo<TCollection> CreateIEnumerableInfo<[Nullable(0)] TCollection, [Nullable(2)] TElement>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo) where TCollection : IEnumerable<TElement>
		{
			return JsonMetadataServices.CreateCore<TCollection>(options, collectionInfo, new IEnumerableOfTConverter<TCollection, TElement>(), null, null);
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0002D4F7 File Offset: 0x0002B6F7
		public static JsonTypeInfo<TCollection> CreateIAsyncEnumerableInfo<[Nullable(0)] TCollection, [Nullable(2)] TElement>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo) where TCollection : IAsyncEnumerable<TElement>
		{
			return JsonMetadataServices.CreateCore<TCollection>(options, collectionInfo, new IAsyncEnumerableOfTConverter<TCollection, TElement>(), null, null);
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x0002D507 File Offset: 0x0002B707
		public static JsonTypeInfo<TCollection> CreateIDictionaryInfo<[Nullable(0)] TCollection>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo) where TCollection : IDictionary
		{
			return JsonMetadataServices.CreateCore<TCollection>(options, collectionInfo, new IDictionaryConverter<TCollection>(), null, null);
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0002D517 File Offset: 0x0002B717
		public static JsonTypeInfo<TCollection> CreateStackInfo<[Nullable(0)] TCollection>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo, [Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<TCollection, object> addFunc) where TCollection : IEnumerable
		{
			return JsonMetadataServices.CreateStackOrQueueInfo<TCollection>(options, collectionInfo, addFunc);
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0002D517 File Offset: 0x0002B717
		public static JsonTypeInfo<TCollection> CreateQueueInfo<[Nullable(0)] TCollection>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo, [Nullable(new byte[]
		{
			1,
			1,
			2
		})] Action<TCollection, object> addFunc) where TCollection : IEnumerable
		{
			return JsonMetadataServices.CreateStackOrQueueInfo<TCollection>(options, collectionInfo, addFunc);
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0002D521 File Offset: 0x0002B721
		private static JsonTypeInfo<TCollection> CreateStackOrQueueInfo<TCollection>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo, Action<TCollection, object> addFunc) where TCollection : IEnumerable
		{
			if (addFunc == null)
			{
				ThrowHelper.ThrowArgumentNullException("addFunc");
			}
			return JsonMetadataServices.CreateCore<TCollection>(options, collectionInfo, new StackOrQueueConverter<TCollection>(), null, addFunc);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0002D53E File Offset: 0x0002B73E
		public static JsonTypeInfo<TCollection> CreateIEnumerableInfo<[Nullable(0)] TCollection>(JsonSerializerOptions options, JsonCollectionInfoValues<TCollection> collectionInfo) where TCollection : IEnumerable
		{
			return JsonMetadataServices.CreateCore<TCollection>(options, collectionInfo, new IEnumerableConverter<TCollection>(), null, null);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0002D54E File Offset: 0x0002B74E
		[return: Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public static JsonTypeInfo<Memory<TElement>> CreateMemoryInfo<[Nullable(2)] TElement>(JsonSerializerOptions options, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] JsonCollectionInfoValues<Memory<TElement>> collectionInfo)
		{
			return JsonMetadataServices.CreateCore<Memory<TElement>>(options, collectionInfo, new MemoryConverter<TElement>(), null, null);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0002D55E File Offset: 0x0002B75E
		[return: Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public static JsonTypeInfo<ReadOnlyMemory<TElement>> CreateReadOnlyMemoryInfo<[Nullable(2)] TElement>(JsonSerializerOptions options, [Nullable(new byte[]
		{
			1,
			0,
			1
		})] JsonCollectionInfoValues<ReadOnlyMemory<TElement>> collectionInfo)
		{
			return JsonMetadataServices.CreateCore<ReadOnlyMemory<TElement>>(options, collectionInfo, new ReadOnlyMemoryConverter<TElement>(), null, null);
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x0002D56E File Offset: 0x0002B76E
		public static JsonConverter<bool> BooleanConverter
		{
			get
			{
				JsonConverter<bool> result;
				if ((result = JsonMetadataServices.s_booleanConverter) == null)
				{
					result = (JsonMetadataServices.s_booleanConverter = new BooleanConverter());
				}
				return result;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x0002D584 File Offset: 0x0002B784
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public static JsonConverter<byte[]> ByteArrayConverter
		{
			[return: Nullable(new byte[]
			{
				1,
				2
			})]
			get
			{
				JsonConverter<byte[]> result;
				if ((result = JsonMetadataServices.s_byteArrayConverter) == null)
				{
					result = (JsonMetadataServices.s_byteArrayConverter = new ByteArrayConverter());
				}
				return result;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x0002D59A File Offset: 0x0002B79A
		public static JsonConverter<byte> ByteConverter
		{
			get
			{
				JsonConverter<byte> result;
				if ((result = JsonMetadataServices.s_byteConverter) == null)
				{
					result = (JsonMetadataServices.s_byteConverter = new ByteConverter());
				}
				return result;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x0002D5B0 File Offset: 0x0002B7B0
		public static JsonConverter<char> CharConverter
		{
			get
			{
				JsonConverter<char> result;
				if ((result = JsonMetadataServices.s_charConverter) == null)
				{
					result = (JsonMetadataServices.s_charConverter = new CharConverter());
				}
				return result;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0002D5C6 File Offset: 0x0002B7C6
		public static JsonConverter<DateTime> DateTimeConverter
		{
			get
			{
				JsonConverter<DateTime> result;
				if ((result = JsonMetadataServices.s_dateTimeConverter) == null)
				{
					result = (JsonMetadataServices.s_dateTimeConverter = new DateTimeConverter());
				}
				return result;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x0002D5DC File Offset: 0x0002B7DC
		public static JsonConverter<DateTimeOffset> DateTimeOffsetConverter
		{
			get
			{
				JsonConverter<DateTimeOffset> result;
				if ((result = JsonMetadataServices.s_dateTimeOffsetConverter) == null)
				{
					result = (JsonMetadataServices.s_dateTimeOffsetConverter = new DateTimeOffsetConverter());
				}
				return result;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x0002D5F2 File Offset: 0x0002B7F2
		public static JsonConverter<DateOnly> DateOnlyConverter
		{
			get
			{
				JsonConverter<DateOnly> result;
				if ((result = JsonMetadataServices.s_dateOnlyConverter) == null)
				{
					result = (JsonMetadataServices.s_dateOnlyConverter = new DateOnlyConverter());
				}
				return result;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x0002D608 File Offset: 0x0002B808
		public static JsonConverter<TimeOnly> TimeOnlyConverter
		{
			get
			{
				JsonConverter<TimeOnly> result;
				if ((result = JsonMetadataServices.s_timeOnlyConverter) == null)
				{
					result = (JsonMetadataServices.s_timeOnlyConverter = new TimeOnlyConverter());
				}
				return result;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0002D61E File Offset: 0x0002B81E
		public static JsonConverter<decimal> DecimalConverter
		{
			get
			{
				JsonConverter<decimal> result;
				if ((result = JsonMetadataServices.s_decimalConverter) == null)
				{
					result = (JsonMetadataServices.s_decimalConverter = new DecimalConverter());
				}
				return result;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x0002D634 File Offset: 0x0002B834
		public static JsonConverter<double> DoubleConverter
		{
			get
			{
				JsonConverter<double> result;
				if ((result = JsonMetadataServices.s_doubleConverter) == null)
				{
					result = (JsonMetadataServices.s_doubleConverter = new DoubleConverter());
				}
				return result;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0002D64A File Offset: 0x0002B84A
		public static JsonConverter<Guid> GuidConverter
		{
			get
			{
				JsonConverter<Guid> result;
				if ((result = JsonMetadataServices.s_guidConverter) == null)
				{
					result = (JsonMetadataServices.s_guidConverter = new GuidConverter());
				}
				return result;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x0002D660 File Offset: 0x0002B860
		public static JsonConverter<short> Int16Converter
		{
			get
			{
				JsonConverter<short> result;
				if ((result = JsonMetadataServices.s_int16Converter) == null)
				{
					result = (JsonMetadataServices.s_int16Converter = new Int16Converter());
				}
				return result;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0002D676 File Offset: 0x0002B876
		public static JsonConverter<int> Int32Converter
		{
			get
			{
				JsonConverter<int> result;
				if ((result = JsonMetadataServices.s_int32Converter) == null)
				{
					result = (JsonMetadataServices.s_int32Converter = new Int32Converter());
				}
				return result;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x0002D68C File Offset: 0x0002B88C
		public static JsonConverter<long> Int64Converter
		{
			get
			{
				JsonConverter<long> result;
				if ((result = JsonMetadataServices.s_int64Converter) == null)
				{
					result = (JsonMetadataServices.s_int64Converter = new Int64Converter());
				}
				return result;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0002D6A2 File Offset: 0x0002B8A2
		public static JsonConverter<Int128> Int128Converter
		{
			get
			{
				JsonConverter<Int128> result;
				if ((result = JsonMetadataServices.s_int128Converter) == null)
				{
					result = (JsonMetadataServices.s_int128Converter = new Int128Converter());
				}
				return result;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x0002D6B8 File Offset: 0x0002B8B8
		[CLSCompliant(false)]
		public static JsonConverter<UInt128> UInt128Converter
		{
			get
			{
				JsonConverter<UInt128> result;
				if ((result = JsonMetadataServices.s_uint128Converter) == null)
				{
					result = (JsonMetadataServices.s_uint128Converter = new UInt128Converter());
				}
				return result;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0002D6CE File Offset: 0x0002B8CE
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public static JsonConverter<JsonArray> JsonArrayConverter
		{
			[return: Nullable(new byte[]
			{
				1,
				2
			})]
			get
			{
				JsonConverter<JsonArray> result;
				if ((result = JsonMetadataServices.s_jsonArrayConverter) == null)
				{
					result = (JsonMetadataServices.s_jsonArrayConverter = new JsonArrayConverter());
				}
				return result;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x0002D6E4 File Offset: 0x0002B8E4
		public static JsonConverter<JsonElement> JsonElementConverter
		{
			get
			{
				JsonConverter<JsonElement> result;
				if ((result = JsonMetadataServices.s_jsonElementConverter) == null)
				{
					result = (JsonMetadataServices.s_jsonElementConverter = new JsonElementConverter());
				}
				return result;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0002D6FA File Offset: 0x0002B8FA
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public static JsonConverter<JsonNode> JsonNodeConverter
		{
			[return: Nullable(new byte[]
			{
				1,
				2
			})]
			get
			{
				JsonConverter<JsonNode> result;
				if ((result = JsonMetadataServices.s_jsonNodeConverter) == null)
				{
					result = (JsonMetadataServices.s_jsonNodeConverter = new JsonNodeConverter());
				}
				return result;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x0002D710 File Offset: 0x0002B910
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public static JsonConverter<JsonObject> JsonObjectConverter
		{
			[return: Nullable(new byte[]
			{
				1,
				2
			})]
			get
			{
				JsonConverter<JsonObject> result;
				if ((result = JsonMetadataServices.s_jsonObjectConverter) == null)
				{
					result = (JsonMetadataServices.s_jsonObjectConverter = new JsonObjectConverter());
				}
				return result;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0002D726 File Offset: 0x0002B926
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public static JsonConverter<JsonValue> JsonValueConverter
		{
			[return: Nullable(new byte[]
			{
				1,
				2
			})]
			get
			{
				JsonConverter<JsonValue> result;
				if ((result = JsonMetadataServices.s_jsonValueConverter) == null)
				{
					result = (JsonMetadataServices.s_jsonValueConverter = new JsonValueConverter());
				}
				return result;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x0002D73C File Offset: 0x0002B93C
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public static JsonConverter<JsonDocument> JsonDocumentConverter
		{
			[return: Nullable(new byte[]
			{
				1,
				2
			})]
			get
			{
				JsonConverter<JsonDocument> result;
				if ((result = JsonMetadataServices.s_jsonDocumentConverter) == null)
				{
					result = (JsonMetadataServices.s_jsonDocumentConverter = new JsonDocumentConverter());
				}
				return result;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0002D752 File Offset: 0x0002B952
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public static JsonConverter<Memory<byte>> MemoryByteConverter
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				JsonConverter<Memory<byte>> result;
				if ((result = JsonMetadataServices.s_memoryByteConverter) == null)
				{
					result = (JsonMetadataServices.s_memoryByteConverter = new MemoryByteConverter());
				}
				return result;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x0002D768 File Offset: 0x0002B968
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public static JsonConverter<ReadOnlyMemory<byte>> ReadOnlyMemoryByteConverter
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				JsonConverter<ReadOnlyMemory<byte>> result;
				if ((result = JsonMetadataServices.s_readOnlyMemoryByteConverter) == null)
				{
					result = (JsonMetadataServices.s_readOnlyMemoryByteConverter = new ReadOnlyMemoryByteConverter());
				}
				return result;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0002D77E File Offset: 0x0002B97E
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public static JsonConverter<object> ObjectConverter
		{
			[return: Nullable(new byte[]
			{
				1,
				2
			})]
			get
			{
				JsonConverter<object> result;
				if ((result = JsonMetadataServices.s_objectConverter) == null)
				{
					result = (JsonMetadataServices.s_objectConverter = new DefaultObjectConverter());
				}
				return result;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0002D794 File Offset: 0x0002B994
		public static JsonConverter<Half> HalfConverter
		{
			get
			{
				JsonConverter<Half> result;
				if ((result = JsonMetadataServices.s_halfConverter) == null)
				{
					result = (JsonMetadataServices.s_halfConverter = new HalfConverter());
				}
				return result;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0002D7AA File Offset: 0x0002B9AA
		public static JsonConverter<float> SingleConverter
		{
			get
			{
				JsonConverter<float> result;
				if ((result = JsonMetadataServices.s_singleConverter) == null)
				{
					result = (JsonMetadataServices.s_singleConverter = new SingleConverter());
				}
				return result;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000ABE RID: 2750 RVA: 0x0002D7C0 File Offset: 0x0002B9C0
		[CLSCompliant(false)]
		public static JsonConverter<sbyte> SByteConverter
		{
			get
			{
				JsonConverter<sbyte> result;
				if ((result = JsonMetadataServices.s_sbyteConverter) == null)
				{
					result = (JsonMetadataServices.s_sbyteConverter = new SByteConverter());
				}
				return result;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x0002D7D6 File Offset: 0x0002B9D6
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public static JsonConverter<string> StringConverter
		{
			[return: Nullable(new byte[]
			{
				1,
				2
			})]
			get
			{
				JsonConverter<string> result;
				if ((result = JsonMetadataServices.s_stringConverter) == null)
				{
					result = (JsonMetadataServices.s_stringConverter = new StringConverter());
				}
				return result;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0002D7EC File Offset: 0x0002B9EC
		public static JsonConverter<TimeSpan> TimeSpanConverter
		{
			get
			{
				JsonConverter<TimeSpan> result;
				if ((result = JsonMetadataServices.s_timeSpanConverter) == null)
				{
					result = (JsonMetadataServices.s_timeSpanConverter = new TimeSpanConverter());
				}
				return result;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0002D802 File Offset: 0x0002BA02
		[CLSCompliant(false)]
		public static JsonConverter<ushort> UInt16Converter
		{
			get
			{
				JsonConverter<ushort> result;
				if ((result = JsonMetadataServices.s_uint16Converter) == null)
				{
					result = (JsonMetadataServices.s_uint16Converter = new UInt16Converter());
				}
				return result;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x0002D818 File Offset: 0x0002BA18
		[CLSCompliant(false)]
		public static JsonConverter<uint> UInt32Converter
		{
			get
			{
				JsonConverter<uint> result;
				if ((result = JsonMetadataServices.s_uint32Converter) == null)
				{
					result = (JsonMetadataServices.s_uint32Converter = new UInt32Converter());
				}
				return result;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0002D82E File Offset: 0x0002BA2E
		[CLSCompliant(false)]
		public static JsonConverter<ulong> UInt64Converter
		{
			get
			{
				JsonConverter<ulong> result;
				if ((result = JsonMetadataServices.s_uint64Converter) == null)
				{
					result = (JsonMetadataServices.s_uint64Converter = new UInt64Converter());
				}
				return result;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0002D844 File Offset: 0x0002BA44
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public static JsonConverter<Uri> UriConverter
		{
			[return: Nullable(new byte[]
			{
				1,
				2
			})]
			get
			{
				JsonConverter<Uri> result;
				if ((result = JsonMetadataServices.s_uriConverter) == null)
				{
					result = (JsonMetadataServices.s_uriConverter = new UriConverter());
				}
				return result;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0002D85A File Offset: 0x0002BA5A
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public static JsonConverter<Version> VersionConverter
		{
			[return: Nullable(new byte[]
			{
				1,
				2
			})]
			get
			{
				JsonConverter<Version> result;
				if ((result = JsonMetadataServices.s_versionConverter) == null)
				{
					result = (JsonMetadataServices.s_versionConverter = new VersionConverter());
				}
				return result;
			}
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0002D870 File Offset: 0x0002BA70
		public static JsonConverter<T> GetUnsupportedTypeConverter<[Nullable(2)] T>()
		{
			return new UnsupportedTypeConverter<T>(null);
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0002D878 File Offset: 0x0002BA78
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public static JsonConverter<T> GetEnumConverter<[Nullable(0)] T>(JsonSerializerOptions options) where T : struct, Enum
		{
			if (options == null)
			{
				ThrowHelper.ThrowArgumentNullException("options");
			}
			return EnumConverterFactory.Create<T>(EnumConverterOptions.AllowNumbers, options, null);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0002D88F File Offset: 0x0002BA8F
		[NullableContext(0)]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public static JsonConverter<T?> GetNullableConverter<T>([Nullable(new byte[]
		{
			1,
			0
		})] JsonTypeInfo<T> underlyingTypeInfo) where T : struct
		{
			if (underlyingTypeInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("underlyingTypeInfo");
			}
			return new NullableConverter<T>(JsonMetadataServices.GetTypedConverter<T>(underlyingTypeInfo.Converter));
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0002D8AE File Offset: 0x0002BAAE
		[NullableContext(0)]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public static JsonConverter<T?> GetNullableConverter<T>([Nullable(1)] JsonSerializerOptions options) where T : struct
		{
			if (options == null)
			{
				ThrowHelper.ThrowArgumentNullException("options");
			}
			return new NullableConverter<T>(JsonMetadataServices.GetTypedConverter<T>(options.GetConverterInternal(typeof(T))));
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0002D8D8 File Offset: 0x0002BAD8
		internal static JsonConverter<T> GetTypedConverter<T>(JsonConverter converter)
		{
			JsonConverter<T> jsonConverter = converter as JsonConverter<T>;
			if (jsonConverter == null)
			{
				throw new InvalidOperationException(SR.Format(SR.SerializationConverterNotCompatible, jsonConverter, typeof(T)));
			}
			return jsonConverter;
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0002D90C File Offset: 0x0002BB0C
		private static JsonTypeInfo<T> CreateCore<T>(JsonConverter converter, JsonSerializerOptions options)
		{
			JsonTypeInfo<T> jsonTypeInfo = new JsonTypeInfo<T>(converter, options);
			jsonTypeInfo.PopulatePolymorphismMetadata();
			jsonTypeInfo.MapInterfaceTypesToCallbacks();
			converter.ConfigureJsonTypeInfo(jsonTypeInfo, options);
			jsonTypeInfo.IsCustomized = false;
			return jsonTypeInfo;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0002D940 File Offset: 0x0002BB40
		private static JsonTypeInfo<T> CreateCore<T>(JsonSerializerOptions options, JsonObjectInfoValues<T> objectInfo)
		{
			JsonConverter<T> converter = JsonMetadataServices.GetConverter<T>(objectInfo);
			JsonTypeInfo<T> jsonTypeInfo = new JsonTypeInfo<T>(converter, options);
			if (objectInfo.ObjectWithParameterizedConstructorCreator != null)
			{
				jsonTypeInfo.CreateObjectWithArgs = objectInfo.ObjectWithParameterizedConstructorCreator;
				JsonMetadataServices.PopulateParameterInfoValues(jsonTypeInfo, objectInfo.ConstructorParameterMetadataInitializer);
			}
			else
			{
				jsonTypeInfo.SetCreateObjectIfCompatible(objectInfo.ObjectCreator);
				jsonTypeInfo.CreateObjectForExtensionDataProperty = jsonTypeInfo.CreateObject;
			}
			if (objectInfo.PropertyMetadataInitializer != null)
			{
				jsonTypeInfo.SourceGenDelayedPropertyInitializer = objectInfo.PropertyMetadataInitializer;
			}
			else
			{
				jsonTypeInfo.PropertyMetadataSerializationNotSupported = true;
			}
			jsonTypeInfo.ConstructorAttributeProviderFactory = objectInfo.ConstructorAttributeProviderFactory;
			jsonTypeInfo.SerializeHandler = objectInfo.SerializeHandler;
			jsonTypeInfo.NumberHandling = new JsonNumberHandling?(objectInfo.NumberHandling);
			jsonTypeInfo.PopulatePolymorphismMetadata();
			jsonTypeInfo.MapInterfaceTypesToCallbacks();
			converter.ConfigureJsonTypeInfo(jsonTypeInfo, options);
			jsonTypeInfo.IsCustomized = false;
			return jsonTypeInfo;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0002D9F8 File Offset: 0x0002BBF8
		private static JsonTypeInfo<T> CreateCore<T>(JsonSerializerOptions options, JsonCollectionInfoValues<T> collectionInfo, JsonConverter<T> converter, object createObjectWithArgs = null, object addFunc = null)
		{
			if (collectionInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("collectionInfo");
			}
			converter = ((collectionInfo.SerializeHandler != null) ? new JsonMetadataServicesConverter<T>(converter) : converter);
			JsonTypeInfo<T> jsonTypeInfo = new JsonTypeInfo<T>(converter, options);
			jsonTypeInfo.KeyTypeInfo = collectionInfo.KeyInfo;
			jsonTypeInfo.ElementTypeInfo = collectionInfo.ElementInfo;
			jsonTypeInfo.NumberHandling = new JsonNumberHandling?(collectionInfo.NumberHandling);
			jsonTypeInfo.SerializeHandler = collectionInfo.SerializeHandler;
			jsonTypeInfo.CreateObjectWithArgs = createObjectWithArgs;
			jsonTypeInfo.AddMethodDelegate = addFunc;
			jsonTypeInfo.SetCreateObjectIfCompatible(collectionInfo.ObjectCreator);
			jsonTypeInfo.PopulatePolymorphismMetadata();
			jsonTypeInfo.MapInterfaceTypesToCallbacks();
			converter.ConfigureJsonTypeInfo(jsonTypeInfo, options);
			jsonTypeInfo.IsCustomized = false;
			return jsonTypeInfo;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0002DA9C File Offset: 0x0002BC9C
		private static JsonConverter<T> GetConverter<T>(JsonObjectInfoValues<T> objectInfo)
		{
			JsonConverter<T> jsonConverter = (objectInfo.ObjectWithParameterizedConstructorCreator != null) ? new LargeObjectWithParameterizedConstructorConverter<T>() : new ObjectDefaultConverter<T>();
			if (objectInfo.SerializeHandler == null)
			{
				return jsonConverter;
			}
			return new JsonMetadataServicesConverter<T>(jsonConverter);
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0002DAD0 File Offset: 0x0002BCD0
		private static void PopulateParameterInfoValues(JsonTypeInfo typeInfo, Func<JsonParameterInfoValues[]> paramFactory)
		{
			JsonParameterInfoValues[] array = (paramFactory != null) ? paramFactory() : null;
			if (array != null)
			{
				typeInfo.PopulateParameterInfoValues(array);
				return;
			}
			typeInfo.PropertyMetadataSerializationNotSupported = true;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0002DAFC File Offset: 0x0002BCFC
		internal static void PopulateProperties(JsonTypeInfo typeInfo, JsonTypeInfo.JsonPropertyInfoList propertyList, Func<JsonSerializerContext, JsonPropertyInfo[]> propInitFunc)
		{
			JsonSerializerContext arg = typeInfo.Options.TypeInfoResolver as JsonSerializerContext;
			JsonPropertyInfo[] array = propInitFunc(arg);
			JsonTypeInfo.PropertyHierarchyResolutionState propertyHierarchyResolutionState = new JsonTypeInfo.PropertyHierarchyResolutionState(typeInfo.Options);
			foreach (JsonPropertyInfo jsonPropertyInfo in array)
			{
				if (!jsonPropertyInfo.SrcGen_IsPublic)
				{
					if (jsonPropertyInfo.SrcGen_HasJsonInclude)
					{
						ThrowHelper.ThrowInvalidOperationException_JsonIncludeOnInaccessibleProperty(jsonPropertyInfo.MemberName, jsonPropertyInfo.DeclaringType);
					}
				}
				else if (jsonPropertyInfo.MemberType != MemberTypes.Field || jsonPropertyInfo.SrcGen_HasJsonInclude || typeInfo.Options.IncludeFields)
				{
					propertyList.AddPropertyWithConflictResolution(jsonPropertyInfo, ref propertyHierarchyResolutionState);
				}
			}
			if (propertyHierarchyResolutionState.IsPropertyOrderSpecified)
			{
				propertyList.SortProperties();
			}
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0002DBA4 File Offset: 0x0002BDA4
		private static JsonPropertyInfo<T> CreatePropertyInfoCore<T>(JsonPropertyInfoValues<T> propertyInfoValues, JsonSerializerOptions options)
		{
			JsonPropertyInfo<T> jsonPropertyInfo = new JsonPropertyInfo<T>(propertyInfoValues.DeclaringType, null, options);
			JsonMetadataServices.DeterminePropertyName(jsonPropertyInfo, propertyInfoValues.PropertyName, propertyInfoValues.JsonPropertyName);
			jsonPropertyInfo.MemberName = propertyInfoValues.PropertyName;
			jsonPropertyInfo.MemberType = (propertyInfoValues.IsProperty ? MemberTypes.Property : MemberTypes.Field);
			jsonPropertyInfo.SrcGen_IsPublic = propertyInfoValues.IsPublic;
			jsonPropertyInfo.SrcGen_HasJsonInclude = propertyInfoValues.HasJsonInclude;
			jsonPropertyInfo.IsExtensionData = propertyInfoValues.IsExtensionData;
			jsonPropertyInfo.CustomConverter = propertyInfoValues.Converter;
			if (jsonPropertyInfo.IgnoreCondition.GetValueOrDefault() != JsonIgnoreCondition.Always)
			{
				jsonPropertyInfo.Get = propertyInfoValues.Getter;
				jsonPropertyInfo.Set = propertyInfoValues.Setter;
			}
			jsonPropertyInfo.IgnoreCondition = propertyInfoValues.IgnoreCondition;
			jsonPropertyInfo.JsonTypeInfo = propertyInfoValues.PropertyTypeInfo;
			jsonPropertyInfo.NumberHandling = propertyInfoValues.NumberHandling;
			jsonPropertyInfo.AttributeProviderFactory = propertyInfoValues.AttributeProviderFactory;
			return jsonPropertyInfo;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0002DC7C File Offset: 0x0002BE7C
		private static void DeterminePropertyName(JsonPropertyInfo propertyInfo, string declaredPropertyName, string declaredJsonPropertyName)
		{
			string text;
			if (declaredJsonPropertyName != null)
			{
				text = declaredJsonPropertyName;
			}
			else if (propertyInfo.Options.PropertyNamingPolicy == null)
			{
				text = declaredPropertyName;
			}
			else
			{
				text = propertyInfo.Options.PropertyNamingPolicy.ConvertName(declaredPropertyName);
			}
			if (text == null)
			{
				ThrowHelper.ThrowInvalidOperationException_SerializerPropertyNameNull(propertyInfo);
			}
			propertyInfo.Name = text;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0002DCC4 File Offset: 0x0002BEC4
		public static JsonPropertyInfo CreatePropertyInfo<[Nullable(2)] T>(JsonSerializerOptions options, JsonPropertyInfoValues<T> propertyInfo)
		{
			if (options == null)
			{
				ThrowHelper.ThrowArgumentNullException("options");
			}
			if (propertyInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyInfo");
			}
			if (propertyInfo.DeclaringType == null)
			{
				throw new ArgumentException("DeclaringType");
			}
			if (propertyInfo.PropertyName == null)
			{
				throw new ArgumentException("PropertyName");
			}
			if (!propertyInfo.IsProperty && propertyInfo.IsVirtual)
			{
				throw new InvalidOperationException(SR.Format(SR.FieldCannotBeVirtual, "IsProperty", "IsVirtual"));
			}
			return JsonMetadataServices.CreatePropertyInfoCore<T>(propertyInfo, options);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0002DD48 File Offset: 0x0002BF48
		public static JsonTypeInfo<T> CreateObjectInfo<T>(JsonSerializerOptions options, JsonObjectInfoValues<T> objectInfo)
		{
			if (options == null)
			{
				ThrowHelper.ThrowArgumentNullException("options");
			}
			if (objectInfo == null)
			{
				ThrowHelper.ThrowArgumentNullException("objectInfo");
			}
			return JsonMetadataServices.CreateCore<T>(options, objectInfo);
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0002DD6B File Offset: 0x0002BF6B
		public static JsonTypeInfo<T> CreateValueInfo<[Nullable(2)] T>(JsonSerializerOptions options, JsonConverter converter)
		{
			if (options == null)
			{
				ThrowHelper.ThrowArgumentNullException("options");
			}
			if (converter == null)
			{
				ThrowHelper.ThrowArgumentNullException("converter");
			}
			return JsonMetadataServices.CreateCore<T>(converter, options);
		}

		// Token: 0x0400033A RID: 826
		private static JsonConverter<bool> s_booleanConverter;

		// Token: 0x0400033B RID: 827
		private static JsonConverter<byte[]> s_byteArrayConverter;

		// Token: 0x0400033C RID: 828
		private static JsonConverter<byte> s_byteConverter;

		// Token: 0x0400033D RID: 829
		private static JsonConverter<char> s_charConverter;

		// Token: 0x0400033E RID: 830
		private static JsonConverter<DateTime> s_dateTimeConverter;

		// Token: 0x0400033F RID: 831
		private static JsonConverter<DateTimeOffset> s_dateTimeOffsetConverter;

		// Token: 0x04000340 RID: 832
		private static JsonConverter<DateOnly> s_dateOnlyConverter;

		// Token: 0x04000341 RID: 833
		private static JsonConverter<TimeOnly> s_timeOnlyConverter;

		// Token: 0x04000342 RID: 834
		private static JsonConverter<decimal> s_decimalConverter;

		// Token: 0x04000343 RID: 835
		private static JsonConverter<double> s_doubleConverter;

		// Token: 0x04000344 RID: 836
		private static JsonConverter<Guid> s_guidConverter;

		// Token: 0x04000345 RID: 837
		private static JsonConverter<short> s_int16Converter;

		// Token: 0x04000346 RID: 838
		private static JsonConverter<int> s_int32Converter;

		// Token: 0x04000347 RID: 839
		private static JsonConverter<long> s_int64Converter;

		// Token: 0x04000348 RID: 840
		private static JsonConverter<Int128> s_int128Converter;

		// Token: 0x04000349 RID: 841
		private static JsonConverter<UInt128> s_uint128Converter;

		// Token: 0x0400034A RID: 842
		private static JsonConverter<JsonArray> s_jsonArrayConverter;

		// Token: 0x0400034B RID: 843
		private static JsonConverter<JsonElement> s_jsonElementConverter;

		// Token: 0x0400034C RID: 844
		private static JsonConverter<JsonNode> s_jsonNodeConverter;

		// Token: 0x0400034D RID: 845
		private static JsonConverter<JsonObject> s_jsonObjectConverter;

		// Token: 0x0400034E RID: 846
		private static JsonConverter<JsonValue> s_jsonValueConverter;

		// Token: 0x0400034F RID: 847
		private static JsonConverter<JsonDocument> s_jsonDocumentConverter;

		// Token: 0x04000350 RID: 848
		private static JsonConverter<Memory<byte>> s_memoryByteConverter;

		// Token: 0x04000351 RID: 849
		private static JsonConverter<ReadOnlyMemory<byte>> s_readOnlyMemoryByteConverter;

		// Token: 0x04000352 RID: 850
		private static JsonConverter<object> s_objectConverter;

		// Token: 0x04000353 RID: 851
		private static JsonConverter<Half> s_halfConverter;

		// Token: 0x04000354 RID: 852
		private static JsonConverter<float> s_singleConverter;

		// Token: 0x04000355 RID: 853
		private static JsonConverter<sbyte> s_sbyteConverter;

		// Token: 0x04000356 RID: 854
		private static JsonConverter<string> s_stringConverter;

		// Token: 0x04000357 RID: 855
		private static JsonConverter<TimeSpan> s_timeSpanConverter;

		// Token: 0x04000358 RID: 856
		private static JsonConverter<ushort> s_uint16Converter;

		// Token: 0x04000359 RID: 857
		private static JsonConverter<uint> s_uint32Converter;

		// Token: 0x0400035A RID: 858
		private static JsonConverter<ulong> s_uint64Converter;

		// Token: 0x0400035B RID: 859
		private static JsonConverter<Uri> s_uriConverter;

		// Token: 0x0400035C RID: 860
		private static JsonConverter<Version> s_versionConverter;
	}
}
