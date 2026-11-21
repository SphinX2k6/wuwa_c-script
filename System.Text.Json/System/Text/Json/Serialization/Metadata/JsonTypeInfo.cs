using System;
using System.ComponentModel;
using System.IO;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000BA RID: 186
	public sealed class JsonTypeInfo<[Nullable(2)] T> : JsonTypeInfo
	{
		// Token: 0x06000A30 RID: 2608 RVA: 0x0002BA20 File Offset: 0x00029C20
		internal T Deserialize(ref Utf8JsonReader reader, ref ReadStack state)
		{
			T result;
			this.EffectiveConverter.ReadCore(ref reader, out result, base.Options, ref state);
			return result;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0002BA44 File Offset: 0x00029C44
		internal ValueTask<T> DeserializeAsync(Stream utf8Json, CancellationToken cancellationToken)
		{
			JsonTypeInfo<T>.<DeserializeAsync>d__1 <DeserializeAsync>d__;
			<DeserializeAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder<T>.Create();
			<DeserializeAsync>d__.<>4__this = this;
			<DeserializeAsync>d__.utf8Json = utf8Json;
			<DeserializeAsync>d__.cancellationToken = cancellationToken;
			<DeserializeAsync>d__.<>1__state = -1;
			<DeserializeAsync>d__.<>t__builder.Start<JsonTypeInfo<T>.<DeserializeAsync>d__1>(ref <DeserializeAsync>d__);
			return <DeserializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0002BA98 File Offset: 0x00029C98
		internal T Deserialize(Stream utf8Json)
		{
			JsonSerializerOptions options = base.Options;
			ReadBufferState readBufferState = new ReadBufferState(options.DefaultBufferSize);
			ReadStack readStack = default(ReadStack);
			readStack.Initialize(this, true);
			JsonReaderState jsonReaderState = new JsonReaderState(options.GetReaderOptions());
			T result;
			try
			{
				T t;
				do
				{
					readBufferState.ReadFromStream(utf8Json);
				}
				while (!this.ContinueDeserialize(ref readBufferState, ref jsonReaderState, ref readStack, out t));
				result = t;
			}
			finally
			{
				readBufferState.Dispose();
			}
			return result;
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0002BB10 File Offset: 0x00029D10
		internal sealed override object DeserializeAsObject(ref Utf8JsonReader reader, ref ReadStack state)
		{
			return this.Deserialize(ref reader, ref state);
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0002BB20 File Offset: 0x00029D20
		internal sealed override ValueTask<object> DeserializeAsObjectAsync(Stream utf8Json, CancellationToken cancellationToken)
		{
			JsonTypeInfo<T>.<DeserializeAsObjectAsync>d__6 <DeserializeAsObjectAsync>d__;
			<DeserializeAsObjectAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder<object>.Create();
			<DeserializeAsObjectAsync>d__.<>4__this = this;
			<DeserializeAsObjectAsync>d__.utf8Json = utf8Json;
			<DeserializeAsObjectAsync>d__.cancellationToken = cancellationToken;
			<DeserializeAsObjectAsync>d__.<>1__state = -1;
			<DeserializeAsObjectAsync>d__.<>t__builder.Start<JsonTypeInfo<T>.<DeserializeAsObjectAsync>d__6>(ref <DeserializeAsObjectAsync>d__);
			return <DeserializeAsObjectAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0002BB73 File Offset: 0x00029D73
		internal sealed override object DeserializeAsObject(Stream utf8Json)
		{
			return this.Deserialize(utf8Json);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x0002BB84 File Offset: 0x00029D84
		internal bool ContinueDeserialize(ref ReadBufferState bufferState, ref JsonReaderState jsonReaderState, ref ReadStack readStack, out T value)
		{
			Utf8JsonReader utf8JsonReader = new Utf8JsonReader(bufferState.Bytes, bufferState.IsFinalBlock, jsonReaderState);
			bool result = this.EffectiveConverter.ReadCore(ref utf8JsonReader, out value, base.Options, ref readStack);
			bufferState.AdvanceBuffer((int)utf8JsonReader.BytesConsumed);
			jsonReaderState = utf8JsonReader.CurrentState;
			return result;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0002BBDC File Offset: 0x00029DDC
		internal void Serialize(Utf8JsonWriter writer, in T rootValue, object rootValueBoxed = null)
		{
			if (base.CanUseSerializeHandler)
			{
				this.SerializeHandler(writer, rootValue);
				writer.Flush();
				return;
			}
			JsonTypeInfo jsonTypeInfo;
			if (!typeof(T).IsValueType && base.Converter.CanBePolymorphic && rootValue != null && base.Options.TryGetPolymorphicTypeInfoForRootType(rootValue, out jsonTypeInfo))
			{
				jsonTypeInfo.SerializeAsObject(writer, rootValue);
				return;
			}
			WriteStack writeStack = default(WriteStack);
			writeStack.Initialize(this, rootValueBoxed, false, false);
			this.EffectiveConverter.WriteCore(writer, rootValue, base.Options, ref writeStack);
			writer.Flush();
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0002BC94 File Offset: 0x00029E94
		internal Task SerializeAsync(Stream utf8Json, T rootValue, CancellationToken cancellationToken, object rootValueBoxed = null)
		{
			int flushThreshold = (int)((float)base.Options.DefaultBufferSize * 0.9f);
			return this.SerializeAsync(new PooledByteBufferWriter(base.Options.DefaultBufferSize, utf8Json), rootValue, flushThreshold, cancellationToken, rootValueBoxed);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0002BCD4 File Offset: 0x00029ED4
		internal Task SerializeAsync(PipeWriter utf8Json, T rootValue, CancellationToken cancellationToken, object rootValueBoxed = null)
		{
			int flushThreshold = (int)((float)(4 * PipeOptions.Default.MinimumSegmentSize) * 0.9f);
			return this.SerializeAsync(utf8Json, rootValue, flushThreshold, cancellationToken, rootValueBoxed);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0002BD04 File Offset: 0x00029F04
		private Task SerializeAsync(PipeWriter pipeWriter, T rootValue, int flushThreshold, CancellationToken cancellationToken, object rootValueBoxed = null)
		{
			JsonTypeInfo<T>.<SerializeAsync>d__12 <SerializeAsync>d__;
			<SerializeAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SerializeAsync>d__.<>4__this = this;
			<SerializeAsync>d__.pipeWriter = pipeWriter;
			<SerializeAsync>d__.rootValue = rootValue;
			<SerializeAsync>d__.flushThreshold = flushThreshold;
			<SerializeAsync>d__.cancellationToken = cancellationToken;
			<SerializeAsync>d__.rootValueBoxed = rootValueBoxed;
			<SerializeAsync>d__.<>1__state = -1;
			<SerializeAsync>d__.<>t__builder.Start<JsonTypeInfo<T>.<SerializeAsync>d__12>(ref <SerializeAsync>d__);
			return <SerializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0002BD74 File Offset: 0x00029F74
		internal void Serialize(Stream utf8Json, in T rootValue, object rootValueBoxed = null)
		{
			if (this.CanUseSerializeHandlerInStreaming)
			{
				PooledByteBufferWriter pooledByteBufferWriter;
				Utf8JsonWriter utf8JsonWriter = Utf8JsonWriterCache.RentWriterAndBuffer(base.Options, out pooledByteBufferWriter);
				try
				{
					this.SerializeHandler(utf8JsonWriter, rootValue);
					utf8JsonWriter.Flush();
					pooledByteBufferWriter.WriteToStream(utf8Json);
					return;
				}
				finally
				{
					this.OnRootLevelAsyncSerializationCompleted(utf8JsonWriter.BytesCommitted + (long)utf8JsonWriter.BytesPending);
					Utf8JsonWriterCache.ReturnWriterAndBuffer(utf8JsonWriter, pooledByteBufferWriter);
				}
			}
			JsonTypeInfo jsonTypeInfo;
			if (!typeof(T).IsValueType && base.Converter.CanBePolymorphic && rootValue != null && base.Options.TryGetPolymorphicTypeInfoForRootType(rootValue, out jsonTypeInfo))
			{
				jsonTypeInfo.SerializeAsObject(utf8Json, rootValue);
				return;
			}
			WriteStack writeStack = default(WriteStack);
			writeStack.Initialize(this, rootValueBoxed, true, false);
			using (PooledByteBufferWriter pooledByteBufferWriter2 = new PooledByteBufferWriter(base.Options.DefaultBufferSize))
			{
				using (Utf8JsonWriter utf8JsonWriter2 = new Utf8JsonWriter(pooledByteBufferWriter2, base.Options.GetWriterOptions()))
				{
					writeStack.PipeWriter = pooledByteBufferWriter2;
					writeStack.FlushThreshold = (int)((float)pooledByteBufferWriter2.Capacity * 0.9f);
					bool flag;
					do
					{
						flag = this.EffectiveConverter.WriteCore(utf8JsonWriter2, rootValue, base.Options, ref writeStack);
						utf8JsonWriter2.Flush();
						pooledByteBufferWriter2.WriteToStream(utf8Json);
						pooledByteBufferWriter2.Clear();
					}
					while (!flag);
					if (base.CanUseSerializeHandler)
					{
						this.OnRootLevelAsyncSerializationCompleted(utf8JsonWriter2.BytesCommitted);
					}
				}
			}
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0002BF10 File Offset: 0x0002A110
		internal sealed override void SerializeAsObject(Utf8JsonWriter writer, object rootValue)
		{
			T t = JsonSerializer.UnboxOnWrite<T>(rootValue);
			this.Serialize(writer, t, rootValue);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0002BF2E File Offset: 0x0002A12E
		internal sealed override Task SerializeAsObjectAsync(PipeWriter pipeWriter, object rootValue, int flushThreshold, CancellationToken cancellationToken)
		{
			return this.SerializeAsync(pipeWriter, JsonSerializer.UnboxOnWrite<T>(rootValue), flushThreshold, cancellationToken, rootValue);
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0002BF41 File Offset: 0x0002A141
		internal sealed override Task SerializeAsObjectAsync(Stream utf8Json, object rootValue, CancellationToken cancellationToken)
		{
			return this.SerializeAsync(utf8Json, JsonSerializer.UnboxOnWrite<T>(rootValue), cancellationToken, rootValue);
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0002BF52 File Offset: 0x0002A152
		internal sealed override Task SerializeAsObjectAsync(PipeWriter utf8Json, object rootValue, CancellationToken cancellationToken)
		{
			return this.SerializeAsync(utf8Json, JsonSerializer.UnboxOnWrite<T>(rootValue), cancellationToken, rootValue);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0002BF64 File Offset: 0x0002A164
		internal sealed override void SerializeAsObject(Stream utf8Json, object rootValue)
		{
			T t = JsonSerializer.UnboxOnWrite<T>(rootValue);
			this.Serialize(utf8Json, t, rootValue);
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0002BF82 File Offset: 0x0002A182
		private bool CanUseSerializeHandlerInStreaming
		{
			get
			{
				return this._canUseSerializeHandlerInStreamingState == 1;
			}
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0002BF90 File Offset: 0x0002A190
		private void OnRootLevelAsyncSerializationCompleted(long serializationSize)
		{
			if (this._canUseSerializeHandlerInStreamingState != 2)
			{
				if (serializationSize > (long)(base.Options.DefaultBufferSize / 2))
				{
					this._canUseSerializeHandlerInStreamingState = 2;
					return;
				}
				if (this._serializationCount < 10 && Interlocked.Increment(ref this._serializationCount) == 10)
				{
					Interlocked.CompareExchange(ref this._canUseSerializeHandlerInStreamingState, 1, 0);
				}
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0002BFEC File Offset: 0x0002A1EC
		internal JsonTypeInfo(JsonConverter converter, JsonSerializerOptions options) : base(typeof(T), converter, options)
		{
			this.EffectiveConverter = converter.CreateCastingConverter<T>();
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x0002C00C File Offset: 0x0002A20C
		[Nullable(1)]
		internal JsonConverter<T> EffectiveConverter { get; }

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x0002C014 File Offset: 0x0002A214
		// (set) Token: 0x06000A46 RID: 2630 RVA: 0x0002C01C File Offset: 0x0002A21C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public new Func<T> CreateObject
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return this._typedCreateObject;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.SetCreateObject(value);
			}
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0002C028 File Offset: 0x0002A228
		private protected override void SetCreateObject(Delegate createObject)
		{
			JsonTypeInfo<T>.<>c__DisplayClass34_0 CS$<>8__locals1 = new JsonTypeInfo<T>.<>c__DisplayClass34_0();
			base.VerifyMutable();
			if (base.Kind == JsonTypeInfoKind.None)
			{
				ThrowHelper.ThrowInvalidOperationException_JsonTypeInfoOperationNotPossibleForKind(base.Kind);
			}
			if (!base.Converter.SupportsCreateObjectDelegate)
			{
				ThrowHelper.ThrowInvalidOperationException_CreateObjectConverterNotCompatible(base.Type);
			}
			Func<T> typedCreateObject;
			if (createObject == null)
			{
				CS$<>8__locals1.untypedCreateObject = null;
				typedCreateObject = null;
			}
			else
			{
				Func<T> typedDelegate = createObject as Func<T>;
				if (typedDelegate != null)
				{
					typedCreateObject = typedDelegate;
					JsonTypeInfo<T>.<>c__DisplayClass34_0 CS$<>8__locals3 = CS$<>8__locals1;
					Func<object> func = createObject as Func<object>;
					CS$<>8__locals3.untypedCreateObject = ((func != null) ? func : (() => typedDelegate()));
				}
				else
				{
					CS$<>8__locals1.untypedCreateObject = (Func<object>)createObject;
					typedCreateObject = (() => (T)((object)CS$<>8__locals1.untypedCreateObject()));
				}
			}
			this._createObject = CS$<>8__locals1.untypedCreateObject;
			this._typedCreateObject = typedCreateObject;
			this.ConstructorAttributeProviderFactory = null;
			base.ConstructorAttributeProvider = null;
			if (base.CreateObjectWithArgs != null)
			{
				this._parameterInfoValuesIndex = null;
				base.CreateObjectWithArgs = null;
				base.ParameterCount = 0;
				foreach (JsonPropertyInfo jsonPropertyInfo in base.PropertyList)
				{
					jsonPropertyInfo.AssociatedParameter = null;
				}
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x0002C158 File Offset: 0x0002A358
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x0002C160 File Offset: 0x0002A360
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Action<Utf8JsonWriter, T> SerializeHandler
		{
			[return: Nullable(new byte[]
			{
				2,
				1,
				1
			})]
			get
			{
				return this._serialize;
			}
			internal set
			{
				this._serialize = value;
				base.HasSerializeHandler = (value != null);
			}
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0002C173 File Offset: 0x0002A373
		private protected override JsonPropertyInfo CreatePropertyInfoForTypeInfo()
		{
			return new JsonPropertyInfo<T>(typeof(T), this, base.Options)
			{
				JsonTypeInfo = this,
				IsForTypeInfo = true
			};
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0002C199 File Offset: 0x0002A399
		private protected override JsonPropertyInfo CreateJsonPropertyInfo(JsonTypeInfo declaringTypeInfo, Type declaringType, JsonSerializerOptions options)
		{
			return new JsonPropertyInfo<T>(declaringType ?? declaringTypeInfo.Type, declaringTypeInfo, options)
			{
				JsonTypeInfo = this
			};
		}

		// Token: 0x040002DF RID: 735
		internal JsonTypeInfo _asyncEnumerableArrayTypeInfo;

		// Token: 0x040002E0 RID: 736
		internal JsonTypeInfo _asyncEnumerableRootLevelValueTypeInfo;

		// Token: 0x040002E1 RID: 737
		private volatile int _canUseSerializeHandlerInStreamingState;

		// Token: 0x040002E2 RID: 738
		private volatile int _serializationCount;

		// Token: 0x040002E3 RID: 739
		private Action<Utf8JsonWriter, T> _serialize;

		// Token: 0x040002E4 RID: 740
		private Func<T> _typedCreateObject;
	}
}
