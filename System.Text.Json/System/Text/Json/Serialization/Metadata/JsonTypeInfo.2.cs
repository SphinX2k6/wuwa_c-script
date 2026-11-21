using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.IO.Pipelines;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text.Json.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000DB RID: 219
	[NullableContext(2)]
	[Nullable(0)]
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public abstract class JsonTypeInfo
	{
		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x0002F91F File Offset: 0x0002DB1F
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x0002F927 File Offset: 0x0002DB27
		protected internal int ParameterCount { internal get; private protected set; }

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x0002F930 File Offset: 0x0002DB30
		[Nullable(new byte[]
		{
			0,
			1
		})]
		internal ReadOnlySpan<JsonParameterInfo> ParameterCache
		{
			get
			{
				return this._parameterCache;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x0002F93D File Offset: 0x0002DB3D
		internal bool UsesParameterizedConstructor
		{
			get
			{
				return this._parameterCache != null;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x0002F948 File Offset: 0x0002DB48
		[Nullable(new byte[]
		{
			0,
			1
		})]
		internal ReadOnlySpan<JsonPropertyInfo> PropertyCache
		{
			get
			{
				return this._propertyCache;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x0002F955 File Offset: 0x0002DB55
		[Nullable(1)]
		internal Dictionary<string, JsonPropertyInfo> PropertyIndex
		{
			get
			{
				return this._propertyIndex;
			}
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0002F960 File Offset: 0x0002DB60
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe JsonPropertyInfo GetProperty(ReadOnlySpan<byte> propertyName, ref ReadStackFrame frame, out byte[] utf8PropertyName)
		{
			PropertyRef[] utf8PropertyCache = this._utf8PropertyCache;
			ReadOnlySpan<PropertyRef> readOnlySpan = utf8PropertyCache;
			ulong key = PropertyRef.GetKey(propertyName);
			if (!readOnlySpan.IsEmpty)
			{
				int propertyIndex = frame.PropertyIndex;
				int length = readOnlySpan.Length;
				int num = Math.Min(propertyIndex, length);
				int num2 = num - 1;
				PropertyRef propertyRef;
				for (;;)
				{
					if (num < length)
					{
						propertyRef = *readOnlySpan[num];
						if (propertyRef.Equals(propertyName, key))
						{
							break;
						}
						num++;
						if (num2 >= 0)
						{
							propertyRef = *readOnlySpan[num2];
							if (propertyRef.Equals(propertyName, key))
							{
								goto Block_5;
							}
							num2--;
						}
					}
					else
					{
						if (num2 < 0)
						{
							goto IL_EC;
						}
						propertyRef = *readOnlySpan[num2];
						if (propertyRef.Equals(propertyName, key))
						{
							goto Block_7;
						}
						num2--;
					}
				}
				utf8PropertyName = propertyRef.Utf8PropertyName;
				return propertyRef.Info;
				Block_5:
				utf8PropertyName = propertyRef.Utf8PropertyName;
				return propertyRef.Info;
				Block_7:
				utf8PropertyName = propertyRef.Utf8PropertyName;
				return propertyRef.Info;
			}
			IL_EC:
			JsonPropertyInfo jsonPropertyInfo;
			if (this.PropertyIndex.TryLookupUtf8Key(propertyName, out jsonPropertyInfo) && (!this.Options.PropertyNameCaseInsensitive || propertyName.SequenceEqual(jsonPropertyInfo.NameAsUtf8Bytes)))
			{
				utf8PropertyName = jsonPropertyInfo.NameAsUtf8Bytes;
			}
			else
			{
				utf8PropertyName = propertyName.ToArray();
			}
			ref PropertyRefCacheBuilder ptr = ref frame.PropertyRefCacheBuilder;
			PropertyRefCacheBuilder propertyRefCacheBuilder = ptr;
			if (((propertyRefCacheBuilder != null) ? propertyRefCacheBuilder.TotalCount : utf8PropertyCache.Length) < 64)
			{
				PropertyRefCacheBuilder propertyRefCacheBuilder2;
				if ((propertyRefCacheBuilder2 = ptr) == null)
				{
					PropertyRefCacheBuilder propertyRefCacheBuilder3;
					ptr = (propertyRefCacheBuilder3 = new PropertyRefCacheBuilder(utf8PropertyCache));
					propertyRefCacheBuilder2 = propertyRefCacheBuilder3;
				}
				propertyRefCacheBuilder2.TryAdd(new PropertyRef(key, jsonPropertyInfo, utf8PropertyName));
			}
			return jsonPropertyInfo;
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0002FAE0 File Offset: 0x0002DCE0
		internal void UpdateUtf8PropertyCache(ref ReadStackFrame frame)
		{
			PropertyRef[] utf8PropertyCache = this._utf8PropertyCache;
			PropertyRefCacheBuilder propertyRefCacheBuilder = frame.PropertyRefCacheBuilder;
			if (utf8PropertyCache == propertyRefCacheBuilder.OriginalCache)
			{
				propertyRefCacheBuilder.ToArray();
				this._utf8PropertyCache = propertyRefCacheBuilder.ToArray();
			}
			frame.PropertyRefCacheBuilder = null;
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x0002FB1C File Offset: 0x0002DD1C
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x0002FB24 File Offset: 0x0002DD24
		internal int NumberOfRequiredProperties { get; private set; }

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0002FB30 File Offset: 0x0002DD30
		internal JsonTypeInfo(Type type, JsonConverter converter, JsonSerializerOptions options)
		{
			this.Type = type;
			this.Options = options;
			this.Converter = converter;
			this.Kind = JsonTypeInfo.GetTypeInfoKind(type, converter);
			this.PropertyInfoForTypeInfo = this.CreatePropertyInfoForTypeInfo();
			this.ElementType = converter.ElementType;
			this.KeyType = converter.KeyType;
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x0002FBA2 File Offset: 0x0002DDA2
		public Type ElementType { get; }

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x0002FBAA File Offset: 0x0002DDAA
		public Type KeyType { get; }

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x0002FBB2 File Offset: 0x0002DDB2
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x0002C01C File Offset: 0x0002A21C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<object> CreateObject
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return this._createObject;
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

		// Token: 0x06000BCC RID: 3020
		private protected abstract void SetCreateObject(Delegate createObject);

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x0002FBBA File Offset: 0x0002DDBA
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x0002FBC2 File Offset: 0x0002DDC2
		[Nullable(new byte[]
		{
			2,
			1
		})]
		internal Func<object> CreateObjectForExtensionDataProperty { get; set; }

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x0002FBCB File Offset: 0x0002DDCB
		// (set) Token: 0x06000BD0 RID: 3024 RVA: 0x0002FBD4 File Offset: 0x0002DDD4
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<object> OnSerializing
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return this._onSerializing;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.VerifyMutable();
				JsonTypeInfoKind kind = this.Kind;
				if (kind - JsonTypeInfoKind.Object > 2)
				{
					ThrowHelper.ThrowInvalidOperationException_JsonTypeInfoOperationNotPossibleForKind(this.Kind);
				}
				this._onSerializing = value;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x0002FC0F File Offset: 0x0002DE0F
		// (set) Token: 0x06000BD2 RID: 3026 RVA: 0x0002FC18 File Offset: 0x0002DE18
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<object> OnSerialized
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return this._onSerialized;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.VerifyMutable();
				JsonTypeInfoKind kind = this.Kind;
				if (kind - JsonTypeInfoKind.Object > 2)
				{
					ThrowHelper.ThrowInvalidOperationException_JsonTypeInfoOperationNotPossibleForKind(this.Kind);
				}
				this._onSerialized = value;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x0002FC53 File Offset: 0x0002DE53
		// (set) Token: 0x06000BD4 RID: 3028 RVA: 0x0002FC5C File Offset: 0x0002DE5C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<object> OnDeserializing
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return this._onDeserializing;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.VerifyMutable();
				JsonTypeInfoKind kind = this.Kind;
				if (kind - JsonTypeInfoKind.Object > 2)
				{
					ThrowHelper.ThrowInvalidOperationException_JsonTypeInfoOperationNotPossibleForKind(this.Kind);
				}
				if (this.Converter.IsConvertibleCollection)
				{
					ThrowHelper.ThrowInvalidOperationException_JsonTypeInfoOnDeserializingCallbacksNotSupported(this.Type);
				}
				this._onDeserializing = value;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x0002FCAF File Offset: 0x0002DEAF
		// (set) Token: 0x06000BD6 RID: 3030 RVA: 0x0002FCB8 File Offset: 0x0002DEB8
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<object> OnDeserialized
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return this._onDeserialized;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.VerifyMutable();
				JsonTypeInfoKind kind = this.Kind;
				if (kind - JsonTypeInfoKind.Object > 2)
				{
					ThrowHelper.ThrowInvalidOperationException_JsonTypeInfoOperationNotPossibleForKind(this.Kind);
				}
				this._onDeserialized = value;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x0002FCF3 File Offset: 0x0002DEF3
		[Nullable(1)]
		public IList<JsonPropertyInfo> Properties
		{
			[NullableContext(1)]
			get
			{
				return this.PropertyList;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x0002FCFB File Offset: 0x0002DEFB
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal JsonTypeInfo.JsonPropertyInfoList PropertyList
		{
			get
			{
				return this._properties ?? this.<get_PropertyList>g__CreatePropertyList|61_0();
			}
		}

		// Token: 0x170002B3 RID: 691
		// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x0002FD0D File Offset: 0x0002DF0D
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		internal Func<JsonSerializerContext, JsonPropertyInfo[]> SourceGenDelayedPropertyInitializer
		{
			set
			{
				this._sourceGenDelayedPropertyInitializer = value;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x0002FD16 File Offset: 0x0002DF16
		// (set) Token: 0x06000BDB RID: 3035 RVA: 0x0002FD20 File Offset: 0x0002DF20
		public JsonPolymorphismOptions PolymorphismOptions
		{
			get
			{
				return this._polymorphismOptions;
			}
			set
			{
				this.VerifyMutable();
				if (value != null)
				{
					if (this.Kind == JsonTypeInfoKind.None)
					{
						ThrowHelper.ThrowInvalidOperationException_JsonTypeInfoOperationNotPossibleForKind(this.Kind);
					}
					if (value.DeclaringTypeInfo != null && value.DeclaringTypeInfo != this)
					{
						ThrowHelper.ThrowArgumentException_JsonPolymorphismOptionsAssociatedWithDifferentJsonTypeInfo("value");
					}
					value.DeclaringTypeInfo = this;
				}
				this._polymorphismOptions = value;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x0002FD72 File Offset: 0x0002DF72
		// (set) Token: 0x06000BDD RID: 3037 RVA: 0x0002FD7A File Offset: 0x0002DF7A
		public bool IsReadOnly { get; private set; }

		// Token: 0x06000BDE RID: 3038 RVA: 0x0002FD83 File Offset: 0x0002DF83
		public void MakeReadOnly()
		{
			this.IsReadOnly = true;
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x0002FD8C File Offset: 0x0002DF8C
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x0002FD94 File Offset: 0x0002DF94
		internal object CreateObjectWithArgs { get; set; }

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x0002FD9D File Offset: 0x0002DF9D
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x0002FDA5 File Offset: 0x0002DFA5
		internal object AddMethodDelegate { get; set; }

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x0002FDAE File Offset: 0x0002DFAE
		// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x0002FDB6 File Offset: 0x0002DFB6
		internal JsonPropertyInfo ExtensionDataProperty { get; private set; }

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x0002FDBF File Offset: 0x0002DFBF
		// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x0002FDC7 File Offset: 0x0002DFC7
		internal PolymorphicTypeResolver PolymorphicTypeResolver { get; private set; }

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x0002FDD0 File Offset: 0x0002DFD0
		// (set) Token: 0x06000BE8 RID: 3048 RVA: 0x0002FDD8 File Offset: 0x0002DFD8
		protected internal bool HasSerializeHandler { internal get; private protected set; }

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x0002FDE1 File Offset: 0x0002DFE1
		// (set) Token: 0x06000BEA RID: 3050 RVA: 0x0002FDE9 File Offset: 0x0002DFE9
		internal bool CanUseSerializeHandler { get; private set; }

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x0002FDF2 File Offset: 0x0002DFF2
		// (set) Token: 0x06000BEC RID: 3052 RVA: 0x0002FDFA File Offset: 0x0002DFFA
		internal bool PropertyMetadataSerializationNotSupported { get; set; }

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x0002FE03 File Offset: 0x0002E003
		internal bool IsNullable
		{
			get
			{
				return this.Converter.NullableElementConverter != null;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x0002FE16 File Offset: 0x0002E016
		internal bool CanBeNull
		{
			get
			{
				return this.PropertyInfoForTypeInfo.PropertyTypeCanBeNull;
			}
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x0002FE23 File Offset: 0x0002E023
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ValidateCanBeUsedForPropertyMetadataSerialization()
		{
			if (this.PropertyMetadataSerializationNotSupported)
			{
				ThrowHelper.ThrowInvalidOperationException_NoMetadataForTypeProperties(this.Options.TypeInfoResolver, this.Type);
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x0002FE43 File Offset: 0x0002E043
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x0002FE56 File Offset: 0x0002E056
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal JsonTypeInfo ElementTypeInfo
		{
			get
			{
				JsonTypeInfo elementTypeInfo = this._elementTypeInfo;
				if (elementTypeInfo == null)
				{
					return elementTypeInfo;
				}
				elementTypeInfo.EnsureConfigured();
				return elementTypeInfo;
			}
			set
			{
				this._elementTypeInfo = value;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x0002FE5F File Offset: 0x0002E05F
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x0002FE72 File Offset: 0x0002E072
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal JsonTypeInfo KeyTypeInfo
		{
			get
			{
				JsonTypeInfo keyTypeInfo = this._keyTypeInfo;
				if (keyTypeInfo == null)
				{
					return keyTypeInfo;
				}
				keyTypeInfo.EnsureConfigured();
				return keyTypeInfo;
			}
			set
			{
				this._keyTypeInfo = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x0002FE7B File Offset: 0x0002E07B
		[Nullable(1)]
		public JsonSerializerOptions Options { [NullableContext(1)] get; }

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x0002FE83 File Offset: 0x0002E083
		[Nullable(1)]
		public Type Type { [NullableContext(1)] get; }

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x0002FE8B File Offset: 0x0002E08B
		[Nullable(1)]
		public JsonConverter Converter { [NullableContext(1)] get; }

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x0002FE93 File Offset: 0x0002E093
		public JsonTypeInfoKind Kind { get; }

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x0002FE9B File Offset: 0x0002E09B
		[Nullable(1)]
		internal JsonPropertyInfo PropertyInfoForTypeInfo { get; }

		// Token: 0x06000BF9 RID: 3065
		private protected abstract JsonPropertyInfo CreatePropertyInfoForTypeInfo();

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x0002FEA3 File Offset: 0x0002E0A3
		// (set) Token: 0x06000BFB RID: 3067 RVA: 0x0002FEAB File Offset: 0x0002E0AB
		public JsonNumberHandling? NumberHandling
		{
			get
			{
				return this._numberHandling;
			}
			set
			{
				this.VerifyMutable();
				if (value != null && !JsonSerializer.IsValidNumberHandlingValue(value.Value))
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._numberHandling = value;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x0002FEDC File Offset: 0x0002E0DC
		internal JsonNumberHandling EffectiveNumberHandling
		{
			get
			{
				JsonNumberHandling? numberHandling = this._numberHandling;
				if (numberHandling == null)
				{
					return this.Options.NumberHandling;
				}
				return numberHandling.GetValueOrDefault();
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x0002FF0C File Offset: 0x0002E10C
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x0002FF14 File Offset: 0x0002E114
		public JsonUnmappedMemberHandling? UnmappedMemberHandling
		{
			get
			{
				return this._unmappedMemberHandling;
			}
			set
			{
				this.VerifyMutable();
				if (this.Kind != JsonTypeInfoKind.Object)
				{
					ThrowHelper.ThrowInvalidOperationException_JsonTypeInfoOperationNotPossibleForKind(this.Kind);
				}
				if (value != null && !JsonSerializer.IsValidUnmappedMemberHandlingValue(value.Value))
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._unmappedMemberHandling = value;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x0002FF64 File Offset: 0x0002E164
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x0002FF6C File Offset: 0x0002E16C
		internal JsonUnmappedMemberHandling EffectiveUnmappedMemberHandling { get; private set; }

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x0002FF75 File Offset: 0x0002E175
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x0002FF80 File Offset: 0x0002E180
		public JsonObjectCreationHandling? PreferredPropertyObjectCreationHandling
		{
			get
			{
				return this._preferredPropertyObjectCreationHandling;
			}
			set
			{
				this.VerifyMutable();
				if (this.Kind != JsonTypeInfoKind.Object)
				{
					ThrowHelper.ThrowInvalidOperationException_JsonTypeInfoOperationNotPossibleForKind(this.Kind);
				}
				if (value != null && !JsonSerializer.IsValidCreationHandlingValue(value.Value))
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._preferredPropertyObjectCreationHandling = value;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x0002FFD0 File Offset: 0x0002E1D0
		// (set) Token: 0x06000C04 RID: 3076 RVA: 0x0002FFD8 File Offset: 0x0002E1D8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public IJsonTypeInfoResolver OriginatingResolver
		{
			get
			{
				return this._originatingResolver;
			}
			set
			{
				this.VerifyMutable();
				if (value is JsonSerializerContext)
				{
					this.IsCustomized = false;
				}
				this._originatingResolver = value;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x0002FFF8 File Offset: 0x0002E1F8
		// (set) Token: 0x06000C06 RID: 3078 RVA: 0x00030039 File Offset: 0x0002E239
		public ICustomAttributeProvider ConstructorAttributeProvider
		{
			get
			{
				Func<ICustomAttributeProvider> func = Volatile.Read<Func<ICustomAttributeProvider>>(ref this.ConstructorAttributeProviderFactory);
				ICustomAttributeProvider customAttributeProvider = this._constructorAttributeProvider;
				if (customAttributeProvider == null && func != null)
				{
					customAttributeProvider = (this._constructorAttributeProvider = func());
					Volatile.Write<Func<ICustomAttributeProvider>>(ref this.ConstructorAttributeProviderFactory, null);
				}
				return customAttributeProvider;
			}
			internal set
			{
				this._constructorAttributeProvider = value;
				Volatile.Write<Func<ICustomAttributeProvider>>(ref this.ConstructorAttributeProviderFactory, null);
			}
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x0003004E File Offset: 0x0002E24E
		internal void VerifyMutable()
		{
			if (this.IsReadOnly)
			{
				ThrowHelper.ThrowInvalidOperationException_TypeInfoImmutable();
			}
			this.IsCustomized = true;
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x00030064 File Offset: 0x0002E264
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x0003006C File Offset: 0x0002E26C
		internal bool IsCustomized { get; set; } = true;

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x00030075 File Offset: 0x0002E275
		internal bool IsConfigured
		{
			get
			{
				return this._configurationState == JsonTypeInfo.ConfigurationState.Configured;
			}
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x00030082 File Offset: 0x0002E282
		internal void EnsureConfigured()
		{
			if (!this.IsConfigured)
			{
				this.<EnsureConfigured>g__ConfigureSynchronized|172_0();
			}
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00030094 File Offset: 0x0002E294
		private void Configure()
		{
			this.PropertyInfoForTypeInfo.Configure();
			if (this.PolymorphismOptions != null)
			{
				this.PolymorphicTypeResolver = new PolymorphicTypeResolver(this.Options, this.PolymorphismOptions, this.Type, this.Converter.CanHaveMetadata);
			}
			if (this.Kind == JsonTypeInfoKind.Object)
			{
				this.ConfigureProperties();
				if (this.DetermineUsesParameterizedConstructor())
				{
					this.ConfigureConstructorParameters();
				}
			}
			if (this.ElementType != null)
			{
				if (this._elementTypeInfo == null)
				{
					this._elementTypeInfo = this.Options.GetTypeInfoInternal(this.ElementType, true, new bool?(true), false, false);
				}
				this._elementTypeInfo.EnsureConfigured();
			}
			if (this.KeyType != null)
			{
				if (this._keyTypeInfo == null)
				{
					this._keyTypeInfo = this.Options.GetTypeInfoInternal(this.KeyType, true, new bool?(true), false, false);
				}
				this._keyTypeInfo.EnsureConfigured();
			}
			this.DetermineIsCompatibleWithCurrentOptions();
			this.CanUseSerializeHandler = (this.HasSerializeHandler && this.IsCompatibleWithCurrentOptions);
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x00030198 File Offset: 0x0002E398
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal JsonTypeInfo AncestorPolymorphicType
		{
			get
			{
				if (!this._isAncestorPolymorphicTypeResolved)
				{
					this._ancestorPolymorhicType = PolymorphicTypeResolver.FindNearestPolymorphicBaseType(this);
					this._isAncestorPolymorphicTypeResolved = true;
				}
				return this._ancestorPolymorhicType;
			}
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x000301C0 File Offset: 0x0002E3C0
		private void DetermineIsCompatibleWithCurrentOptions()
		{
			if (!this.<DetermineIsCompatibleWithCurrentOptions>g__IsCurrentNodeCompatible|178_0())
			{
				this.IsCompatibleWithCurrentOptions = false;
				return;
			}
			if (this._properties != null)
			{
				foreach (JsonPropertyInfo jsonPropertyInfo in this._properties)
				{
					if (jsonPropertyInfo.IsPropertyTypeInfoConfigured && !jsonPropertyInfo.JsonTypeInfo.IsCompatibleWithCurrentOptions)
					{
						this.IsCompatibleWithCurrentOptions = false;
						return;
					}
				}
			}
			JsonTypeInfo elementTypeInfo = this._elementTypeInfo;
			if (elementTypeInfo == null || elementTypeInfo.IsCompatibleWithCurrentOptions)
			{
				JsonTypeInfo keyTypeInfo = this._keyTypeInfo;
				if (keyTypeInfo == null || keyTypeInfo.IsCompatibleWithCurrentOptions)
				{
					return;
				}
			}
			this.IsCompatibleWithCurrentOptions = false;
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00030278 File Offset: 0x0002E478
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x00030280 File Offset: 0x0002E480
		private bool IsCompatibleWithCurrentOptions { get; set; } = true;

		// Token: 0x06000C11 RID: 3089 RVA: 0x00030289 File Offset: 0x0002E489
		internal bool DetermineUsesParameterizedConstructor()
		{
			return this.Converter.ConstructorIsParameterized && this.CreateObject == null;
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x000302A3 File Offset: 0x0002E4A3
		[NullableContext(1)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static JsonTypeInfo<T> CreateJsonTypeInfo<[Nullable(2)] T>(JsonSerializerOptions options)
		{
			if (options == null)
			{
				ThrowHelper.ThrowArgumentNullException("options");
			}
			return new JsonTypeInfo<T>(DefaultJsonTypeInfoResolver.GetConverterForType(typeof(T), options, false), options);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x000302CC File Offset: 0x0002E4CC
		[NullableContext(1)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public static JsonTypeInfo CreateJsonTypeInfo(Type type, JsonSerializerOptions options)
		{
			if (type == null)
			{
				ThrowHelper.ThrowArgumentNullException("type");
			}
			if (options == null)
			{
				ThrowHelper.ThrowArgumentNullException("options");
			}
			if (JsonTypeInfo.IsInvalidForSerialization(type))
			{
				ThrowHelper.ThrowArgumentException_CannotSerializeInvalidType("type", type, null, null);
			}
			JsonConverter converterForType = DefaultJsonTypeInfoResolver.GetConverterForType(type, options, false);
			return JsonTypeInfo.CreateJsonTypeInfo(type, converterForType, options);
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00030320 File Offset: 0x0002E520
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		internal static JsonTypeInfo CreateJsonTypeInfo(Type type, JsonConverter converter, JsonSerializerOptions options)
		{
			JsonTypeInfo result;
			if (converter.Type == type)
			{
				result = converter.CreateJsonTypeInfo(options);
			}
			else
			{
				result = (JsonTypeInfo)typeof(JsonTypeInfo<>).MakeGenericType(new Type[]
				{
					type
				}).CreateInstanceNoWrapExceptions(new Type[]
				{
					typeof(JsonConverter),
					typeof(JsonSerializerOptions)
				}, new object[]
				{
					converter,
					options
				});
			}
			return result;
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00030398 File Offset: 0x0002E598
		[NullableContext(1)]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public JsonPropertyInfo CreateJsonPropertyInfo(Type propertyType, string name)
		{
			if (propertyType == null)
			{
				ThrowHelper.ThrowArgumentNullException("propertyType");
			}
			if (name == null)
			{
				ThrowHelper.ThrowArgumentNullException("name");
			}
			if (JsonTypeInfo.IsInvalidForSerialization(propertyType))
			{
				ThrowHelper.ThrowArgumentException_CannotSerializeInvalidType("propertyType", propertyType, this.Type, name);
			}
			this.VerifyMutable();
			JsonPropertyInfo jsonPropertyInfo = this.CreatePropertyUsingReflection(propertyType, null);
			jsonPropertyInfo.Name = name;
			return jsonPropertyInfo;
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x000303F4 File Offset: 0x0002E5F4
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		internal JsonPropertyInfo CreatePropertyUsingReflection(Type propertyType, Type declaringType)
		{
			JsonTypeInfo jsonTypeInfo;
			JsonPropertyInfo result;
			if (this.Options.TryGetTypeInfoCached(propertyType, out jsonTypeInfo))
			{
				result = jsonTypeInfo.CreateJsonPropertyInfo(this, declaringType, this.Options);
			}
			else
			{
				result = (JsonPropertyInfo)typeof(JsonPropertyInfo<>).MakeGenericType(new Type[]
				{
					propertyType
				}).CreateInstanceNoWrapExceptions(new Type[]
				{
					typeof(Type),
					typeof(JsonTypeInfo),
					typeof(JsonSerializerOptions)
				}, new object[]
				{
					declaringType ?? this.Type,
					this,
					this.Options
				});
			}
			return result;
		}

		// Token: 0x06000C17 RID: 3095
		private protected abstract JsonPropertyInfo CreateJsonPropertyInfo(JsonTypeInfo declaringTypeInfo, Type declaringType, JsonSerializerOptions options);

		// Token: 0x06000C18 RID: 3096
		internal abstract void SerializeAsObject(Utf8JsonWriter writer, object rootValue);

		// Token: 0x06000C19 RID: 3097
		internal abstract Task SerializeAsObjectAsync(PipeWriter pipeWriter, object rootValue, int flushThreshold, CancellationToken cancellationToken);

		// Token: 0x06000C1A RID: 3098
		internal abstract Task SerializeAsObjectAsync(Stream utf8Json, object rootValue, CancellationToken cancellationToken);

		// Token: 0x06000C1B RID: 3099
		internal abstract Task SerializeAsObjectAsync(PipeWriter utf8Json, object rootValue, CancellationToken cancellationToken);

		// Token: 0x06000C1C RID: 3100
		internal abstract void SerializeAsObject(Stream utf8Json, object rootValue);

		// Token: 0x06000C1D RID: 3101
		internal abstract object DeserializeAsObject(ref Utf8JsonReader reader, ref ReadStack state);

		// Token: 0x06000C1E RID: 3102
		internal abstract ValueTask<object> DeserializeAsObjectAsync(Stream utf8Json, CancellationToken cancellationToken);

		// Token: 0x06000C1F RID: 3103
		internal abstract object DeserializeAsObject(Stream utf8Json);

		// Token: 0x06000C20 RID: 3104 RVA: 0x00030498 File Offset: 0x0002E698
		internal void ConfigureProperties()
		{
			JsonTypeInfo.JsonPropertyInfoList propertyList = this.PropertyList;
			StringComparer comparer = this.Options.PropertyNameCaseInsensitive ? StringComparer.OrdinalIgnoreCase : StringComparer.Ordinal;
			Dictionary<string, JsonPropertyInfo> dictionary = new Dictionary<string, JsonPropertyInfo>(propertyList.Count, comparer);
			List<JsonPropertyInfo> list = new List<JsonPropertyInfo>(propertyList.Count);
			int numberOfRequiredProperties = 0;
			bool flag = true;
			int num = int.MinValue;
			foreach (JsonPropertyInfo jsonPropertyInfo in propertyList)
			{
				if (jsonPropertyInfo.IsExtensionData)
				{
					if (!(this.UnmappedMemberHandling != JsonUnmappedMemberHandling.Disallow))
					{
						ThrowHelper.ThrowInvalidOperationException_ExtensionDataConflictsWithUnmappedMemberHandling(this.Type, jsonPropertyInfo);
					}
					if (this.ExtensionDataProperty != null)
					{
						ThrowHelper.ThrowInvalidOperationException_SerializationDuplicateTypeAttribute(this.Type, typeof(JsonExtensionDataAttribute));
					}
					this.ExtensionDataProperty = jsonPropertyInfo;
				}
				else
				{
					if (jsonPropertyInfo.IsRequired)
					{
						jsonPropertyInfo.RequiredPropertyIndex = numberOfRequiredProperties++;
					}
					if (flag)
					{
						flag = (num <= jsonPropertyInfo.Order);
						num = jsonPropertyInfo.Order;
					}
					if (!dictionary.TryAdd(jsonPropertyInfo.Name, jsonPropertyInfo))
					{
						ThrowHelper.ThrowInvalidOperationException_SerializerPropertyNameConflict(this.Type, jsonPropertyInfo.Name);
					}
					list.Add(jsonPropertyInfo);
				}
				jsonPropertyInfo.Configure();
			}
			if (!flag)
			{
				propertyList.SortProperties();
				list.StableSortByKey((JsonPropertyInfo propInfo) => propInfo.Order);
			}
			this.NumberOfRequiredProperties = numberOfRequiredProperties;
			this._propertyCache = list.ToArray();
			this._propertyIndex = dictionary;
			this.EffectiveUnmappedMemberHandling = (this.UnmappedMemberHandling ?? ((this.ExtensionDataProperty == null) ? this.Options.UnmappedMemberHandling : JsonUnmappedMemberHandling.Skip));
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0003066C File Offset: 0x0002E86C
		internal void PopulateParameterInfoValues(JsonParameterInfoValues[] parameterInfoValues)
		{
			if (parameterInfoValues.Length == 0)
			{
				return;
			}
			Dictionary<JsonTypeInfo.ParameterLookupKey, JsonParameterInfoValues> dictionary = new Dictionary<JsonTypeInfo.ParameterLookupKey, JsonParameterInfoValues>(parameterInfoValues.Length);
			foreach (JsonParameterInfoValues jsonParameterInfoValues in parameterInfoValues)
			{
				JsonTypeInfo.ParameterLookupKey key = new JsonTypeInfo.ParameterLookupKey(jsonParameterInfoValues.ParameterType, jsonParameterInfoValues.Name);
				dictionary.TryAdd(key, jsonParameterInfoValues);
			}
			this.ParameterCount = parameterInfoValues.Length;
			this._parameterInfoValuesIndex = dictionary;
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x000306C8 File Offset: 0x0002E8C8
		internal void ResolveMatchingParameterInfo(JsonPropertyInfo propertyInfo)
		{
			Dictionary<JsonTypeInfo.ParameterLookupKey, JsonParameterInfoValues> parameterInfoValuesIndex = this._parameterInfoValuesIndex;
			if (parameterInfoValuesIndex == null)
			{
				return;
			}
			string name = propertyInfo.MemberName ?? propertyInfo.Name;
			JsonTypeInfo.ParameterLookupKey key = new JsonTypeInfo.ParameterLookupKey(propertyInfo.PropertyType, name);
			JsonParameterInfoValues parameterInfoValues;
			if (parameterInfoValuesIndex.TryGetValue(key, out parameterInfoValues))
			{
				propertyInfo.AddJsonParameterInfo(parameterInfoValues);
			}
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00030714 File Offset: 0x0002E914
		internal void ConfigureConstructorParameters()
		{
			List<JsonParameterInfo> list = new List<JsonParameterInfo>(this.ParameterCount);
			Dictionary<JsonTypeInfo.ParameterLookupKey, JsonParameterInfo> dictionary = new Dictionary<JsonTypeInfo.ParameterLookupKey, JsonParameterInfo>(this.ParameterCount);
			foreach (JsonPropertyInfo jsonPropertyInfo in this._propertyCache)
			{
				JsonParameterInfo associatedParameter = jsonPropertyInfo.AssociatedParameter;
				if (associatedParameter != null)
				{
					string name = jsonPropertyInfo.MemberName ?? jsonPropertyInfo.Name;
					JsonTypeInfo.ParameterLookupKey key = new JsonTypeInfo.ParameterLookupKey(jsonPropertyInfo.PropertyType, name);
					if (!dictionary.TryAdd(key, associatedParameter))
					{
						ThrowHelper.ThrowInvalidOperationException_MultiplePropertiesBindToConstructorParameters(this.Type, associatedParameter.Name, jsonPropertyInfo.Name, dictionary[key].MatchingProperty.Name);
					}
					list.Add(associatedParameter);
				}
			}
			JsonPropertyInfo extensionDataProperty = this.ExtensionDataProperty;
			if (extensionDataProperty != null && extensionDataProperty.AssociatedParameter != null)
			{
				ThrowHelper.ThrowInvalidOperationException_ExtensionDataCannotBindToCtorParam(this.ExtensionDataProperty.MemberName, this.ExtensionDataProperty);
			}
			this._parameterCache = list.ToArray();
			this._parameterInfoValuesIndex = null;
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00030801 File Offset: 0x0002EA01
		internal static void ValidateType(Type type)
		{
			if (JsonTypeInfo.IsInvalidForSerialization(type))
			{
				ThrowHelper.ThrowInvalidOperationException_CannotSerializeInvalidType(type, null, null);
			}
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00030813 File Offset: 0x0002EA13
		internal static bool IsInvalidForSerialization(Type type)
		{
			return type == typeof(void) || type.IsPointer || type.IsByRef || JsonTypeInfo.IsByRefLike(type) || type.ContainsGenericParameters;
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00030848 File Offset: 0x0002EA48
		internal void PopulatePolymorphismMetadata()
		{
			JsonPolymorphismOptions jsonPolymorphismOptions = JsonPolymorphismOptions.CreateFromAttributeDeclarations(this.Type);
			if (jsonPolymorphismOptions != null)
			{
				jsonPolymorphismOptions.DeclaringTypeInfo = this;
				this._polymorphismOptions = jsonPolymorphismOptions;
			}
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00030874 File Offset: 0x0002EA74
		internal void MapInterfaceTypesToCallbacks()
		{
			JsonTypeInfoKind kind = this.Kind;
			bool flag = kind - JsonTypeInfoKind.Object <= 2;
			if (flag)
			{
				if (typeof(IJsonOnSerializing).IsAssignableFrom(this.Type))
				{
					this.OnSerializing = delegate(object obj)
					{
						((IJsonOnSerializing)obj).OnSerializing();
					};
				}
				if (typeof(IJsonOnSerialized).IsAssignableFrom(this.Type))
				{
					this.OnSerialized = delegate(object obj)
					{
						((IJsonOnSerialized)obj).OnSerialized();
					};
				}
				if (typeof(IJsonOnDeserializing).IsAssignableFrom(this.Type))
				{
					this.OnDeserializing = delegate(object obj)
					{
						((IJsonOnDeserializing)obj).OnDeserializing();
					};
				}
				if (typeof(IJsonOnDeserialized).IsAssignableFrom(this.Type))
				{
					this.OnDeserialized = delegate(object obj)
					{
						((IJsonOnDeserialized)obj).OnDeserialized();
					};
				}
			}
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x0003098A File Offset: 0x0002EB8A
		internal void SetCreateObjectIfCompatible(Delegate createObject)
		{
			if (this.Converter.SupportsCreateObjectDelegate && !this.Converter.ConstructorIsParameterized)
			{
				this.SetCreateObject(createObject);
			}
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x000309AD File Offset: 0x0002EBAD
		private static bool IsByRefLike(Type type)
		{
			return type.IsByRefLike;
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x000309B5 File Offset: 0x0002EBB5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal bool SupportsPolymorphicDeserialization
		{
			get
			{
				PolymorphicTypeResolver polymorphicTypeResolver = this.PolymorphicTypeResolver;
				return polymorphicTypeResolver != null && polymorphicTypeResolver.UsesTypeDiscriminators;
			}
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x000309C8 File Offset: 0x0002EBC8
		internal static bool IsValidExtensionDataProperty(Type propertyType)
		{
			return typeof(IDictionary<string, object>).IsAssignableFrom(propertyType) || typeof(IDictionary<string, JsonElement>).IsAssignableFrom(propertyType) || (propertyType.FullName == "System.Text.Json.Nodes.JsonObject" && propertyType.Assembly == typeof(JsonTypeInfo).Assembly);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00030A28 File Offset: 0x0002EC28
		private static JsonTypeInfoKind GetTypeInfoKind(Type type, JsonConverter converter)
		{
			if (type == typeof(object) && converter.CanBePolymorphic)
			{
				return JsonTypeInfoKind.None;
			}
			ConverterStrategy converterStrategy = converter.ConverterStrategy;
			switch (converterStrategy)
			{
			case ConverterStrategy.None:
				ThrowHelper.ThrowNotSupportedException_SerializationNotSupported(type);
				return JsonTypeInfoKind.None;
			case ConverterStrategy.Object:
				return JsonTypeInfoKind.Object;
			case ConverterStrategy.Value:
				return JsonTypeInfoKind.None;
			default:
				if (converterStrategy == ConverterStrategy.Enumerable)
				{
					return JsonTypeInfoKind.Enumerable;
				}
				if (converterStrategy != ConverterStrategy.Dictionary)
				{
					throw new InvalidOperationException();
				}
				return JsonTypeInfoKind.Dictionary;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00030A8C File Offset: 0x0002EC8C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string DebuggerDisplay
		{
			get
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Type = ");
				defaultInterpolatedStringHandler.AppendFormatted(this.Type.Name);
				defaultInterpolatedStringHandler.AppendLiteral(", Kind = ");
				defaultInterpolatedStringHandler.AppendFormatted<JsonTypeInfoKind>(this.Kind);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00030AF4 File Offset: 0x0002ECF4
		[CompilerGenerated]
		private JsonTypeInfo.JsonPropertyInfoList <get_PropertyList>g__CreatePropertyList|61_0()
		{
			JsonTypeInfo.JsonPropertyInfoList jsonPropertyInfoList = new JsonTypeInfo.JsonPropertyInfoList(this);
			Func<JsonSerializerContext, JsonPropertyInfo[]> sourceGenDelayedPropertyInitializer = this._sourceGenDelayedPropertyInitializer;
			if (sourceGenDelayedPropertyInitializer != null)
			{
				JsonMetadataServices.PopulateProperties(this, jsonPropertyInfoList, sourceGenDelayedPropertyInitializer);
			}
			JsonTypeInfo.JsonPropertyInfoList jsonPropertyInfoList2 = Interlocked.CompareExchange<JsonTypeInfo.JsonPropertyInfoList>(ref this._properties, jsonPropertyInfoList, null);
			this._sourceGenDelayedPropertyInitializer = null;
			return jsonPropertyInfoList2 ?? jsonPropertyInfoList;
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00030B34 File Offset: 0x0002ED34
		[CompilerGenerated]
		private void <EnsureConfigured>g__ConfigureSynchronized|172_0()
		{
			this.Options.MakeReadOnly();
			this.MakeReadOnly();
			ExceptionDispatchInfo cachedConfigureError = this._cachedConfigureError;
			if (cachedConfigureError != null)
			{
				cachedConfigureError.Throw();
			}
			JsonSerializerOptions.CachingContext cacheContext = this.Options.CacheContext;
			lock (cacheContext)
			{
				if (this._configurationState == JsonTypeInfo.ConfigurationState.NotConfigured)
				{
					ExceptionDispatchInfo cachedConfigureError2 = this._cachedConfigureError;
					if (cachedConfigureError2 != null)
					{
						cachedConfigureError2.Throw();
					}
					try
					{
						this._configurationState = JsonTypeInfo.ConfigurationState.Configuring;
						this.Configure();
						this._configurationState = JsonTypeInfo.ConfigurationState.Configured;
					}
					catch (Exception source)
					{
						this._cachedConfigureError = ExceptionDispatchInfo.Capture(source);
						this._configurationState = JsonTypeInfo.ConfigurationState.NotConfigured;
						throw;
					}
				}
			}
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00030BF0 File Offset: 0x0002EDF0
		[CompilerGenerated]
		private bool <DetermineIsCompatibleWithCurrentOptions>g__IsCurrentNodeCompatible|178_0()
		{
			return !this.IsCustomized && (this.Options.CanUseFastPathSerializationLogic || this.OriginatingResolver.IsCompatibleWithOptions(this.Options));
		}

		// Token: 0x040003BB RID: 955
		internal static readonly Type ObjectType = typeof(object);

		// Token: 0x040003BD RID: 957
		private JsonParameterInfo[] _parameterCache;

		// Token: 0x040003BE RID: 958
		private JsonPropertyInfo[] _propertyCache;

		// Token: 0x040003BF RID: 959
		private Dictionary<string, JsonPropertyInfo> _propertyIndex;

		// Token: 0x040003C0 RID: 960
		private PropertyRef[] _utf8PropertyCache = Array.Empty<PropertyRef>();

		// Token: 0x040003C2 RID: 962
		private Action<object> _onSerializing;

		// Token: 0x040003C3 RID: 963
		private Action<object> _onSerialized;

		// Token: 0x040003C4 RID: 964
		private Action<object> _onDeserializing;

		// Token: 0x040003C5 RID: 965
		private Action<object> _onDeserialized;

		// Token: 0x040003C8 RID: 968
		private protected Func<object> _createObject;

		// Token: 0x040003CA RID: 970
		private Func<JsonSerializerContext, JsonPropertyInfo[]> _sourceGenDelayedPropertyInitializer;

		// Token: 0x040003CB RID: 971
		private JsonTypeInfo.JsonPropertyInfoList _properties;

		// Token: 0x040003CD RID: 973
		private protected JsonPolymorphismOptions _polymorphismOptions;

		// Token: 0x040003D5 RID: 981
		private JsonTypeInfo _elementTypeInfo;

		// Token: 0x040003D6 RID: 982
		private JsonTypeInfo _keyTypeInfo;

		// Token: 0x040003DC RID: 988
		private JsonNumberHandling? _numberHandling;

		// Token: 0x040003DD RID: 989
		private JsonUnmappedMemberHandling? _unmappedMemberHandling;

		// Token: 0x040003DF RID: 991
		private JsonObjectCreationHandling? _preferredPropertyObjectCreationHandling;

		// Token: 0x040003E0 RID: 992
		private IJsonTypeInfoResolver _originatingResolver;

		// Token: 0x040003E1 RID: 993
		internal Func<ICustomAttributeProvider> ConstructorAttributeProviderFactory;

		// Token: 0x040003E2 RID: 994
		private ICustomAttributeProvider _constructorAttributeProvider;

		// Token: 0x040003E4 RID: 996
		private volatile JsonTypeInfo.ConfigurationState _configurationState;

		// Token: 0x040003E5 RID: 997
		private ExceptionDispatchInfo _cachedConfigureError;

		// Token: 0x040003E6 RID: 998
		private JsonTypeInfo _ancestorPolymorhicType;

		// Token: 0x040003E7 RID: 999
		private volatile bool _isAncestorPolymorphicTypeResolved;

		// Token: 0x040003E9 RID: 1001
		private protected Dictionary<JsonTypeInfo.ParameterLookupKey, JsonParameterInfoValues> _parameterInfoValuesIndex;

		// Token: 0x020000DC RID: 220
		// (Invoke) Token: 0x06000C33 RID: 3123
		internal delegate T ParameterizedConstructorDelegate<T, TArg0, TArg1, TArg2, TArg3>(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3);

		// Token: 0x020000DD RID: 221
		private enum ConfigurationState : byte
		{
			// Token: 0x040003EB RID: 1003
			NotConfigured,
			// Token: 0x040003EC RID: 1004
			Configuring,
			// Token: 0x040003ED RID: 1005
			Configured
		}

		// Token: 0x020000DE RID: 222
		[CompilerFeatureRequired("RefStructs")]
		internal ref struct PropertyHierarchyResolutionState
		{
			// Token: 0x06000C34 RID: 3124 RVA: 0x00030C1C File Offset: 0x0002EE1C
			public PropertyHierarchyResolutionState(JsonSerializerOptions options)
			{
				this.IgnoredProperties = null;
				this.IsPropertyOrderSpecified = false;
				this.AddedProperties = new Dictionary<string, ValueTuple<JsonPropertyInfo, int>>(options.PropertyNameCaseInsensitive ? StringComparer.OrdinalIgnoreCase : StringComparer.Ordinal);
			}

			// Token: 0x040003EE RID: 1006
			[TupleElementNames(new string[]
			{
				null,
				"index"
			})]
			public Dictionary<string, ValueTuple<JsonPropertyInfo, int>> AddedProperties;

			// Token: 0x040003EF RID: 1007
			public Dictionary<string, JsonPropertyInfo> IgnoredProperties;

			// Token: 0x040003F0 RID: 1008
			public bool IsPropertyOrderSpecified;
		}

		// Token: 0x020000DF RID: 223
		internal readonly struct ParameterLookupKey : IEquatable<JsonTypeInfo.ParameterLookupKey>
		{
			// Token: 0x06000C35 RID: 3125 RVA: 0x00030C4B File Offset: 0x0002EE4B
			public ParameterLookupKey(Type type, string name)
			{
				this.Type = type;
				this.Name = name;
			}

			// Token: 0x170002D3 RID: 723
			// (get) Token: 0x06000C36 RID: 3126 RVA: 0x00030C5B File Offset: 0x0002EE5B
			public Type Type { get; }

			// Token: 0x170002D4 RID: 724
			// (get) Token: 0x06000C37 RID: 3127 RVA: 0x00030C63 File Offset: 0x0002EE63
			public string Name { get; }

			// Token: 0x06000C38 RID: 3128 RVA: 0x00030C6B File Offset: 0x0002EE6B
			public override int GetHashCode()
			{
				return StringComparer.OrdinalIgnoreCase.GetHashCode(this.Name);
			}

			// Token: 0x06000C39 RID: 3129 RVA: 0x00030C7D File Offset: 0x0002EE7D
			public bool Equals(JsonTypeInfo.ParameterLookupKey other)
			{
				return this.Type == other.Type && string.Equals(this.Name, other.Name, StringComparison.OrdinalIgnoreCase);
			}

			// Token: 0x06000C3A RID: 3130 RVA: 0x00030CA8 File Offset: 0x0002EEA8
			public override bool Equals([NotNullWhen(true)] object obj)
			{
				if (obj is JsonTypeInfo.ParameterLookupKey)
				{
					JsonTypeInfo.ParameterLookupKey other = (JsonTypeInfo.ParameterLookupKey)obj;
					return this.Equals(other);
				}
				return false;
			}
		}

		// Token: 0x020000E0 RID: 224
		internal sealed class JsonPropertyInfoList : ConfigurationList<JsonPropertyInfo>
		{
			// Token: 0x06000C3B RID: 3131 RVA: 0x00030CCD File Offset: 0x0002EECD
			public JsonPropertyInfoList(JsonTypeInfo jsonTypeInfo) : base(null)
			{
				this._jsonTypeInfo = jsonTypeInfo;
			}

			// Token: 0x170002D5 RID: 725
			// (get) Token: 0x06000C3C RID: 3132 RVA: 0x00030CDD File Offset: 0x0002EEDD
			public override bool IsReadOnly
			{
				get
				{
					return (this._jsonTypeInfo._properties == this && this._jsonTypeInfo.IsReadOnly) || this._jsonTypeInfo.Kind != JsonTypeInfoKind.Object;
				}
			}

			// Token: 0x06000C3D RID: 3133 RVA: 0x00030D0D File Offset: 0x0002EF0D
			protected override void OnCollectionModifying()
			{
				if (this._jsonTypeInfo._properties == this)
				{
					this._jsonTypeInfo.VerifyMutable();
				}
				if (this._jsonTypeInfo.Kind != JsonTypeInfoKind.Object)
				{
					ThrowHelper.ThrowInvalidOperationException_JsonTypeInfoOperationNotPossibleForKind(this._jsonTypeInfo.Kind);
				}
			}

			// Token: 0x06000C3E RID: 3134 RVA: 0x00030D46 File Offset: 0x0002EF46
			protected override void ValidateAddedValue(JsonPropertyInfo item)
			{
				item.EnsureChildOf(this._jsonTypeInfo);
			}

			// Token: 0x06000C3F RID: 3135 RVA: 0x00030D54 File Offset: 0x0002EF54
			public void SortProperties()
			{
				this._list.StableSortByKey((JsonPropertyInfo propInfo) => propInfo.Order);
			}

			// Token: 0x06000C40 RID: 3136 RVA: 0x00030D80 File Offset: 0x0002EF80
			public void AddPropertyWithConflictResolution(JsonPropertyInfo jsonPropertyInfo, ref JsonTypeInfo.PropertyHierarchyResolutionState state)
			{
				string memberName = jsonPropertyInfo.MemberName;
				if (state.AddedProperties.TryAdd(jsonPropertyInfo.Name, new ValueTuple<JsonPropertyInfo, int>(jsonPropertyInfo, base.Count)))
				{
					base.Add(jsonPropertyInfo);
					state.IsPropertyOrderSpecified |= (jsonPropertyInfo.Order != 0);
				}
				else
				{
					ValueTuple<JsonPropertyInfo, int> valueTuple = state.AddedProperties[jsonPropertyInfo.Name];
					JsonPropertyInfo item = valueTuple.Item1;
					int item2 = valueTuple.Item2;
					if (item.IsIgnored)
					{
						state.AddedProperties[jsonPropertyInfo.Name] = new ValueTuple<JsonPropertyInfo, int>(jsonPropertyInfo, item2);
						base[item2] = jsonPropertyInfo;
						state.IsPropertyOrderSpecified |= (jsonPropertyInfo.Order != 0);
					}
					else
					{
						bool flag;
						if (!jsonPropertyInfo.IsIgnored && !jsonPropertyInfo.IsOverriddenOrShadowedBy(item))
						{
							Dictionary<string, JsonPropertyInfo> ignoredProperties = state.IgnoredProperties;
							JsonPropertyInfo other;
							flag = (ignoredProperties != null && ignoredProperties.TryGetValue(memberName, out other) && jsonPropertyInfo.IsOverriddenOrShadowedBy(other));
						}
						else
						{
							flag = true;
						}
						if (!flag)
						{
							ThrowHelper.ThrowInvalidOperationException_SerializerPropertyNameConflict(this._jsonTypeInfo.Type, jsonPropertyInfo.Name);
						}
					}
				}
				if (jsonPropertyInfo.IsIgnored)
				{
					ref Dictionary<string, JsonPropertyInfo> ptr = ref state.IgnoredProperties;
					Dictionary<string, JsonPropertyInfo> dictionary;
					if ((dictionary = ptr) == null)
					{
						Dictionary<string, JsonPropertyInfo> dictionary2;
						ptr = (dictionary2 = new Dictionary<string, JsonPropertyInfo>());
						dictionary = dictionary2;
					}
					dictionary[memberName] = jsonPropertyInfo;
				}
			}

			// Token: 0x040003F3 RID: 1011
			private readonly JsonTypeInfo _jsonTypeInfo;
		}
	}
}
