using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000D1 RID: 209
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public abstract class JsonPropertyInfo
	{
		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x0002E07A File Offset: 0x0002C27A
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x0002E082 File Offset: 0x0002C282
		[Nullable(2)]
		internal JsonTypeInfo DeclaringTypeInfo { get; private set; }

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x0002E08B File Offset: 0x0002C28B
		internal JsonConverter EffectiveConverter
		{
			get
			{
				return this._effectiveConverter;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0002E093 File Offset: 0x0002C293
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x0002E09B File Offset: 0x0002C29B
		[Nullable(2)]
		public JsonConverter CustomConverter
		{
			[NullableContext(2)]
			get
			{
				return this._customConverter;
			}
			[NullableContext(2)]
			set
			{
				this.VerifyMutable();
				this._customConverter = value;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0002E0AA File Offset: 0x0002C2AA
		// (set) Token: 0x06000B13 RID: 2835 RVA: 0x0002E0B2 File Offset: 0x0002C2B2
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		public Func<object, object> Get
		{
			[return: Nullable(new byte[]
			{
				2,
				1,
				2
			})]
			get
			{
				return this._untypedGet;
			}
			[param: Nullable(new byte[]
			{
				2,
				1,
				2
			})]
			set
			{
				this.VerifyMutable();
				this.SetGetter(value);
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x0002E0C1 File Offset: 0x0002C2C1
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x0002E0C9 File Offset: 0x0002C2C9
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		public Action<object, object> Set
		{
			[return: Nullable(new byte[]
			{
				2,
				1,
				2
			})]
			get
			{
				return this._untypedSet;
			}
			[param: Nullable(new byte[]
			{
				2,
				1,
				2
			})]
			set
			{
				this.VerifyMutable();
				this.SetSetter(value);
				this._isUserSpecifiedSetter = true;
			}
		}

		// Token: 0x06000B16 RID: 2838
		private protected abstract void SetGetter(Delegate getter);

		// Token: 0x06000B17 RID: 2839
		private protected abstract void SetSetter(Delegate setter);

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x0002E0DF File Offset: 0x0002C2DF
		// (set) Token: 0x06000B19 RID: 2841 RVA: 0x0002E0E7 File Offset: 0x0002C2E7
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		public Func<object, object, bool> ShouldSerialize
		{
			[return: Nullable(new byte[]
			{
				2,
				1,
				2
			})]
			get
			{
				return this._shouldSerialize;
			}
			[param: Nullable(new byte[]
			{
				2,
				1,
				2
			})]
			set
			{
				this.VerifyMutable();
				this.SetShouldSerialize(value);
				this._isUserSpecifiedShouldSerialize = true;
				this.IgnoreDefaultValuesOnWrite = false;
			}
		}

		// Token: 0x06000B1A RID: 2842
		private protected abstract void SetShouldSerialize(Delegate predicate);

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0002E104 File Offset: 0x0002C304
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x0002E10C File Offset: 0x0002C30C
		internal JsonIgnoreCondition? IgnoreCondition
		{
			get
			{
				return this._ignoreCondition;
			}
			set
			{
				this.ConfigureIgnoreCondition(value);
				this._ignoreCondition = value;
			}
		}

		// Token: 0x06000B1D RID: 2845
		private protected abstract void ConfigureIgnoreCondition(JsonIgnoreCondition? ignoreCondition);

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x0002E11C File Offset: 0x0002C31C
		// (set) Token: 0x06000B1F RID: 2847 RVA: 0x0002E15D File Offset: 0x0002C35D
		[Nullable(2)]
		public ICustomAttributeProvider AttributeProvider
		{
			[NullableContext(2)]
			get
			{
				Func<ICustomAttributeProvider> func = Volatile.Read<Func<ICustomAttributeProvider>>(ref this.AttributeProviderFactory);
				ICustomAttributeProvider customAttributeProvider = this._attributeProvider;
				if (customAttributeProvider == null && func != null)
				{
					customAttributeProvider = (this._attributeProvider = func());
					Volatile.Write<Func<ICustomAttributeProvider>>(ref this.AttributeProviderFactory, null);
				}
				return customAttributeProvider;
			}
			[NullableContext(2)]
			set
			{
				this.VerifyMutable();
				this._attributeProvider = value;
				Volatile.Write<Func<ICustomAttributeProvider>>(ref this.AttributeProviderFactory, null);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x0002E178 File Offset: 0x0002C378
		// (set) Token: 0x06000B21 RID: 2849 RVA: 0x0002E180 File Offset: 0x0002C380
		public JsonObjectCreationHandling? ObjectCreationHandling
		{
			get
			{
				return this._objectCreationHandling;
			}
			set
			{
				this.VerifyMutable();
				if (value != null && !JsonSerializer.IsValidCreationHandlingValue(value.Value))
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._objectCreationHandling = value;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x0002E1B1 File Offset: 0x0002C3B1
		// (set) Token: 0x06000B23 RID: 2851 RVA: 0x0002E1B9 File Offset: 0x0002C3B9
		internal JsonObjectCreationHandling EffectiveObjectCreationHandling { get; private set; }

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x0002E1C2 File Offset: 0x0002C3C2
		// (set) Token: 0x06000B25 RID: 2853 RVA: 0x0002E1CA File Offset: 0x0002C3CA
		[Nullable(2)]
		internal string MemberName { get; set; }

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000B26 RID: 2854 RVA: 0x0002E1D3 File Offset: 0x0002C3D3
		// (set) Token: 0x06000B27 RID: 2855 RVA: 0x0002E1DB File Offset: 0x0002C3DB
		internal MemberTypes MemberType { get; set; }

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x0002E1E4 File Offset: 0x0002C3E4
		// (set) Token: 0x06000B29 RID: 2857 RVA: 0x0002E1EC File Offset: 0x0002C3EC
		internal bool IsVirtual { get; set; }

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x0002E1F5 File Offset: 0x0002C3F5
		// (set) Token: 0x06000B2B RID: 2859 RVA: 0x0002E1FD File Offset: 0x0002C3FD
		public bool IsGetNullable
		{
			get
			{
				return this._isGetNullable;
			}
			set
			{
				this.VerifyMutable();
				if (value && !this.PropertyTypeCanBeNull)
				{
					ThrowHelper.ThrowInvalidOperationException_PropertyTypeNotNullable(this);
				}
				this._isGetNullable = value;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x0002E21D File Offset: 0x0002C41D
		// (set) Token: 0x06000B2D RID: 2861 RVA: 0x0002E225 File Offset: 0x0002C425
		public bool IsSetNullable
		{
			get
			{
				return this._isSetNullable;
			}
			set
			{
				this.VerifyMutable();
				if (value && !this.PropertyTypeCanBeNull)
				{
					ThrowHelper.ThrowInvalidOperationException_PropertyTypeNotNullable(this);
				}
				this._isSetNullable = value;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x0002E245 File Offset: 0x0002C445
		// (set) Token: 0x06000B2F RID: 2863 RVA: 0x0002E24D File Offset: 0x0002C44D
		public bool IsExtensionData
		{
			get
			{
				return this._isExtensionDataProperty;
			}
			set
			{
				this.VerifyMutable();
				if (value && !JsonTypeInfo.IsValidExtensionDataProperty(this.PropertyType))
				{
					ThrowHelper.ThrowInvalidOperationException_SerializationDataExtensionPropertyInvalid(this);
				}
				this._isExtensionDataProperty = value;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x0002E272 File Offset: 0x0002C472
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x0002E27A File Offset: 0x0002C47A
		public bool IsRequired
		{
			get
			{
				return this._isRequired;
			}
			set
			{
				this.VerifyMutable();
				this._isRequired = value;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x0002E289 File Offset: 0x0002C489
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x0002E291 File Offset: 0x0002C491
		[Nullable(2)]
		public JsonParameterInfo AssociatedParameter { [NullableContext(2)] get; internal set; }

		// Token: 0x06000B34 RID: 2868 RVA: 0x0002E29C File Offset: 0x0002C49C
		internal JsonPropertyInfo(Type declaringType, Type propertyType, JsonTypeInfo declaringTypeInfo, JsonSerializerOptions options)
		{
			this.DeclaringType = declaringType;
			this.PropertyType = propertyType;
			this.DeclaringTypeInfo = declaringTypeInfo;
			this.Options = options;
			this._isGetNullable = (this._isSetNullable = this.PropertyTypeCanBeNull);
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0002E2E1 File Offset: 0x0002C4E1
		internal static JsonPropertyInfo GetPropertyPlaceholder()
		{
			return new JsonPropertyInfo<object>(typeof(object), null, null)
			{
				Name = string.Empty
			};
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x0002E2FF File Offset: 0x0002C4FF
		public Type DeclaringType { get; }

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x0002E307 File Offset: 0x0002C507
		public Type PropertyType { get; }

		// Token: 0x06000B38 RID: 2872 RVA: 0x0002E30F File Offset: 0x0002C50F
		private protected void VerifyMutable()
		{
			JsonTypeInfo declaringTypeInfo = this.DeclaringTypeInfo;
			if (declaringTypeInfo == null)
			{
				return;
			}
			declaringTypeInfo.VerifyMutable();
		}

		// Token: 0x17000276 RID: 630
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x0002E321 File Offset: 0x0002C521
		private bool IsConfigured
		{
			[CompilerGenerated]
			set
			{
				this.<IsConfigured>k__BackingField = value;
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0002E32C File Offset: 0x0002C52C
		internal void Configure()
		{
			if (this.IsIgnored)
			{
				this.CanSerialize = false;
				this.CanDeserialize = false;
			}
			else
			{
				if (this._jsonTypeInfo == null)
				{
					this._jsonTypeInfo = this.Options.GetTypeInfoInternal(this.PropertyType, true, new bool?(true), false, false);
				}
				this._jsonTypeInfo.EnsureConfigured();
				this.DetermineEffectiveConverter(this._jsonTypeInfo);
				this.DetermineNumberHandlingForProperty();
				this.DetermineEffectiveObjectCreationHandlingForProperty();
				this.DetermineSerializationCapabilities();
				this.DetermineIgnoreCondition();
			}
			if (this.IsForTypeInfo)
			{
				this.DetermineNumberHandlingForTypeInfo();
			}
			else
			{
				this.CacheNameAsUtf8BytesAndEscapedNameSection();
			}
			if (this.IsRequired)
			{
				if (!this.CanDeserialize)
				{
					JsonParameterInfo associatedParameter = this.AssociatedParameter;
					if (!(((associatedParameter != null) ? new bool?(associatedParameter.IsRequiredParameter) : null) ?? false) || !this.Options.RespectRequiredConstructorParameters)
					{
						ThrowHelper.ThrowInvalidOperationException_JsonPropertyRequiredAndNotDeserializable(this);
					}
				}
				if (this.IsExtensionData)
				{
					ThrowHelper.ThrowInvalidOperationException_JsonPropertyRequiredAndExtensionData(this);
				}
			}
			this.IsConfigured = true;
		}

		// Token: 0x06000B3B RID: 2875
		private protected abstract void DetermineEffectiveConverter(JsonTypeInfo jsonTypeInfo);

		// Token: 0x06000B3C RID: 2876
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		internal abstract void DetermineReflectionPropertyAccessors(MemberInfo memberInfo, bool useNonPublicAccessors);

		// Token: 0x06000B3D RID: 2877 RVA: 0x0002E428 File Offset: 0x0002C628
		private void CacheNameAsUtf8BytesAndEscapedNameSection()
		{
			this.NameAsUtf8Bytes = Encoding.UTF8.GetBytes(this.Name);
			this.EscapedNameSection = JsonHelpers.GetEscapedPropertyNameSection(this.NameAsUtf8Bytes, this.Options.Encoder);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0002E464 File Offset: 0x0002C664
		private void DetermineIgnoreCondition()
		{
			if (this._ignoreCondition != null)
			{
				return;
			}
			if (this.Options.IgnoreNullValues)
			{
				if (this.PropertyTypeCanBeNull)
				{
					this.IgnoreNullTokensOnRead = (!this._isUserSpecifiedSetter && !this.IsRequired);
					this.IgnoreDefaultValuesOnWrite = (this.ShouldSerialize == null);
					return;
				}
			}
			else if (this.Options.DefaultIgnoreCondition == JsonIgnoreCondition.WhenWritingNull)
			{
				if (this.PropertyTypeCanBeNull)
				{
					this.IgnoreDefaultValuesOnWrite = (this.ShouldSerialize == null);
					return;
				}
			}
			else if (this.Options.DefaultIgnoreCondition == JsonIgnoreCondition.WhenWritingDefault)
			{
				this.IgnoreDefaultValuesOnWrite = (this.ShouldSerialize == null);
			}
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0002E504 File Offset: 0x0002C704
		private void DetermineSerializationCapabilities()
		{
			this.CanSerialize = this.HasGetter;
			this.CanDeserialize = this.HasSetter;
			if (this.MemberType == (MemberTypes)0 || this._ignoreCondition != null)
			{
				this.CanDeserializeOrPopulate = (this.CanDeserialize || this.EffectiveObjectCreationHandling == JsonObjectCreationHandling.Populate);
				return;
			}
			if ((this.EffectiveConverter.ConverterStrategy & (ConverterStrategy)24) != ConverterStrategy.None)
			{
				if (this.Get == null && this.Set != null && !this._isUserSpecifiedSetter)
				{
					this.CanDeserialize = false;
				}
			}
			else if (this.Get != null && this.Set == null && this.IgnoreReadOnlyMember && !this._isUserSpecifiedShouldSerialize)
			{
				this.CanSerialize = false;
			}
			this.CanDeserializeOrPopulate = (this.CanDeserialize || this.EffectiveObjectCreationHandling == JsonObjectCreationHandling.Populate);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0002E5CC File Offset: 0x0002C7CC
		private void DetermineNumberHandlingForTypeInfo()
		{
			JsonNumberHandling? numberHandling = this.DeclaringTypeInfo.NumberHandling;
			if (numberHandling != null)
			{
				JsonNumberHandling? jsonNumberHandling = numberHandling;
				JsonNumberHandling jsonNumberHandling2 = JsonNumberHandling.Strict;
				if (!(jsonNumberHandling.GetValueOrDefault() == jsonNumberHandling2 & jsonNumberHandling != null) && !this.EffectiveConverter.IsInternalConverter)
				{
					ThrowHelper.ThrowInvalidOperationException_NumberHandlingOnPropertyInvalid(this);
				}
			}
			if (this.NumberHandingIsApplicable())
			{
				this.EffectiveNumberHandling = numberHandling;
				if (this.EffectiveNumberHandling == null && this.Options.NumberHandling != JsonNumberHandling.Strict)
				{
					this.EffectiveNumberHandling = new JsonNumberHandling?(this.Options.NumberHandling);
				}
			}
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0002E65C File Offset: 0x0002C85C
		private void DetermineNumberHandlingForProperty()
		{
			if (this.NumberHandingIsApplicable())
			{
				JsonNumberHandling? numberHandling = this.NumberHandling;
				JsonNumberHandling? jsonNumberHandling;
				if (numberHandling == null)
				{
					JsonNumberHandling? numberHandling2 = this.DeclaringTypeInfo.NumberHandling;
					jsonNumberHandling = ((numberHandling2 != null) ? numberHandling2 : this._jsonTypeInfo.NumberHandling);
				}
				else
				{
					jsonNumberHandling = numberHandling;
				}
				JsonNumberHandling? effectiveNumberHandling = jsonNumberHandling;
				if (effectiveNumberHandling == null && this.Options.NumberHandling != JsonNumberHandling.Strict)
				{
					effectiveNumberHandling = new JsonNumberHandling?(this.Options.NumberHandling);
				}
				this.EffectiveNumberHandling = effectiveNumberHandling;
				return;
			}
			if (this.NumberHandling != null)
			{
				JsonNumberHandling? numberHandling = this.NumberHandling;
				JsonNumberHandling jsonNumberHandling2 = JsonNumberHandling.Strict;
				if (!(numberHandling.GetValueOrDefault() == jsonNumberHandling2 & numberHandling != null))
				{
					ThrowHelper.ThrowInvalidOperationException_NumberHandlingOnPropertyInvalid(this);
				}
			}
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0002E70C File Offset: 0x0002C90C
		private void DetermineEffectiveObjectCreationHandlingForProperty()
		{
			JsonObjectCreationHandling jsonObjectCreationHandling = JsonObjectCreationHandling.Replace;
			if (this.ObjectCreationHandling == null)
			{
				jsonObjectCreationHandling = (((this.DeclaringTypeInfo.PreferredPropertyObjectCreationHandling ?? (this.DeclaringTypeInfo.DetermineUsesParameterizedConstructor() ? JsonObjectCreationHandling.Replace : this.Options.PreferredObjectCreationHandling)) == JsonObjectCreationHandling.Populate && this.EffectiveConverter.CanPopulate && this.Get != null && (!this.PropertyType.IsValueType || this.Set != null) && !this.DeclaringTypeInfo.SupportsPolymorphicDeserialization && (this.Set != null || !this.IgnoreReadOnlyMember)) ? JsonObjectCreationHandling.Populate : JsonObjectCreationHandling.Replace);
			}
			else if (this.ObjectCreationHandling.GetValueOrDefault() == JsonObjectCreationHandling.Populate)
			{
				if (!this.EffectiveConverter.CanPopulate)
				{
					ThrowHelper.ThrowInvalidOperationException_ObjectCreationHandlingPopulateNotSupportedByConverter(this);
				}
				if (this.Get == null)
				{
					ThrowHelper.ThrowInvalidOperationException_ObjectCreationHandlingPropertyMustHaveAGetter(this);
				}
				if (this.PropertyType.IsValueType && this.Set == null)
				{
					ThrowHelper.ThrowInvalidOperationException_ObjectCreationHandlingPropertyValueTypeMustHaveASetter(this);
				}
				if (this.JsonTypeInfo.SupportsPolymorphicDeserialization)
				{
					ThrowHelper.ThrowInvalidOperationException_ObjectCreationHandlingPropertyCannotAllowPolymorphicDeserialization(this);
				}
				if (this.Set == null && this.IgnoreReadOnlyMember)
				{
					ThrowHelper.ThrowInvalidOperationException_ObjectCreationHandlingPropertyCannotAllowReadOnlyMember(this);
				}
				jsonObjectCreationHandling = JsonObjectCreationHandling.Populate;
			}
			if (jsonObjectCreationHandling == JsonObjectCreationHandling.Populate)
			{
				if (this.DeclaringTypeInfo.DetermineUsesParameterizedConstructor())
				{
					ThrowHelper.ThrowNotSupportedException_ObjectCreationHandlingPropertyDoesNotSupportParameterizedConstructors();
				}
				if (this.Options.ReferenceHandlingStrategy != ReferenceHandlingStrategy.None)
				{
					ThrowHelper.ThrowInvalidOperationException_ObjectCreationHandlingPropertyCannotAllowReferenceHandling();
				}
			}
			this.EffectiveObjectCreationHandling = jsonObjectCreationHandling;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0002E868 File Offset: 0x0002CA68
		private bool NumberHandingIsApplicable()
		{
			if (this.EffectiveConverter.IsInternalConverterForNumberType)
			{
				return true;
			}
			Type type;
			if (!this.EffectiveConverter.IsInternalConverter || ((ConverterStrategy)24 & this.EffectiveConverter.ConverterStrategy) == ConverterStrategy.None)
			{
				type = this.PropertyType;
			}
			else
			{
				type = this.EffectiveConverter.ElementType;
			}
			type = (Nullable.GetUnderlyingType(type) ?? type);
			return type == typeof(byte) || type == typeof(decimal) || type == typeof(double) || type == typeof(short) || type == typeof(int) || type == typeof(long) || type == typeof(sbyte) || type == typeof(float) || type == typeof(ushort) || type == typeof(uint) || type == typeof(ulong) || type == typeof(Half) || type == typeof(Int128) || type == typeof(UInt128) || type == JsonTypeInfo.ObjectType;
		}

		// Token: 0x06000B44 RID: 2884
		internal abstract void AddJsonParameterInfo(JsonParameterInfoValues parameterInfoValues);

		// Token: 0x06000B45 RID: 2885
		internal abstract bool GetMemberAndWriteJson(object obj, ref WriteStack state, Utf8JsonWriter writer);

		// Token: 0x06000B46 RID: 2886
		internal abstract bool GetMemberAndWriteJsonExtensionData(object obj, ref WriteStack state, Utf8JsonWriter writer);

		// Token: 0x06000B47 RID: 2887
		internal abstract object GetValueAsObject(object obj);

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x0002E9E0 File Offset: 0x0002CBE0
		internal bool HasGetter
		{
			get
			{
				return this._untypedGet != null;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x0002E9EE File Offset: 0x0002CBEE
		internal bool HasSetter
		{
			get
			{
				return this._untypedSet != null;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x0002E9FC File Offset: 0x0002CBFC
		// (set) Token: 0x06000B4B RID: 2891 RVA: 0x0002EA04 File Offset: 0x0002CC04
		protected internal bool IgnoreNullTokensOnRead { internal get; private protected set; }

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x0002EA0D File Offset: 0x0002CC0D
		// (set) Token: 0x06000B4D RID: 2893 RVA: 0x0002EA15 File Offset: 0x0002CC15
		protected internal bool IgnoreDefaultValuesOnWrite { internal get; private protected set; }

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x0002EA20 File Offset: 0x0002CC20
		internal bool IgnoreReadOnlyMember
		{
			get
			{
				MemberTypes memberType = this.MemberType;
				bool result;
				if (memberType != MemberTypes.Field)
				{
					result = (memberType == MemberTypes.Property && this.Options.IgnoreReadOnlyProperties);
				}
				else
				{
					result = this.Options.IgnoreReadOnlyFields;
				}
				return result;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x0002EA5C File Offset: 0x0002CC5C
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x0002EA64 File Offset: 0x0002CC64
		internal bool IsForTypeInfo { get; set; }

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x0002EA6D File Offset: 0x0002CC6D
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x0002EA75 File Offset: 0x0002CC75
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this.VerifyMutable();
				if (value == null)
				{
					ThrowHelper.ThrowArgumentNullException("value");
				}
				this._name = value;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x0002EA91 File Offset: 0x0002CC91
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x0002EA99 File Offset: 0x0002CC99
		internal byte[] NameAsUtf8Bytes { get; private set; }

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x0002EAA2 File Offset: 0x0002CCA2
		// (set) Token: 0x06000B56 RID: 2902 RVA: 0x0002EAAA File Offset: 0x0002CCAA
		internal byte[] EscapedNameSection { get; private set; }

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x0002EAB3 File Offset: 0x0002CCB3
		public JsonSerializerOptions Options { get; }

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x0002EABB File Offset: 0x0002CCBB
		// (set) Token: 0x06000B59 RID: 2905 RVA: 0x0002EAC3 File Offset: 0x0002CCC3
		public int Order
		{
			get
			{
				return this._order;
			}
			set
			{
				this.VerifyMutable();
				this._order = value;
			}
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0002EAD4 File Offset: 0x0002CCD4
		internal bool ReadJsonAndAddExtensionProperty(object obj, [ScopedRef] ref ReadStack state, ref Utf8JsonReader reader)
		{
			object valueAsObject = this.GetValueAsObject(obj);
			IDictionary<string, object> dictionary = valueAsObject as IDictionary<string, object>;
			if (dictionary != null)
			{
				if (reader.TokenType == JsonTokenType.Null)
				{
					dictionary[state.Current.JsonPropertyNameAsString] = null;
				}
				else
				{
					object value = this.<ReadJsonAndAddExtensionProperty>g__GetDictionaryValueConverter|143_0<object>().Read(ref reader, JsonTypeInfo.ObjectType, this.Options);
					dictionary[state.Current.JsonPropertyNameAsString] = value;
				}
			}
			else
			{
				IDictionary<string, JsonElement> dictionary2 = valueAsObject as IDictionary<string, JsonElement>;
				if (dictionary2 != null)
				{
					JsonElement value2 = this.<ReadJsonAndAddExtensionProperty>g__GetDictionaryValueConverter|143_0<JsonElement>().Read(ref reader, typeof(JsonElement), this.Options);
					dictionary2[state.Current.JsonPropertyNameAsString] = value2;
				}
				else
				{
					this.EffectiveConverter.ReadElementAndSetProperty(valueAsObject, state.Current.JsonPropertyNameAsString, ref reader, this.Options, ref state);
				}
			}
			return true;
		}

		// Token: 0x06000B5B RID: 2907
		internal abstract bool ReadJsonAndSetMember(object obj, [ScopedRef] ref ReadStack state, ref Utf8JsonReader reader);

		// Token: 0x06000B5C RID: 2908
		internal abstract bool ReadJsonAsObject([ScopedRef] ref ReadStack state, ref Utf8JsonReader reader, out object value);

		// Token: 0x06000B5D RID: 2909 RVA: 0x0002EBA0 File Offset: 0x0002CDA0
		internal bool ReadJsonExtensionDataValue([ScopedRef] ref ReadStack state, ref Utf8JsonReader reader, out object value)
		{
			if (this.JsonTypeInfo.ElementType == JsonTypeInfo.ObjectType && reader.TokenType == JsonTokenType.Null)
			{
				value = null;
				return true;
			}
			JsonElement jsonElement;
			bool flag;
			if (!((JsonConverter<JsonElement>)this.Options.GetConverterInternal(typeof(JsonElement))).TryRead(ref reader, typeof(JsonElement), this.Options, ref state, out jsonElement, out flag))
			{
				value = null;
				return false;
			}
			value = jsonElement;
			return true;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0002EC18 File Offset: 0x0002CE18
		internal void EnsureChildOf(JsonTypeInfo parent)
		{
			if (this.DeclaringTypeInfo == null)
			{
				this.DeclaringTypeInfo = parent;
			}
			else if (this.DeclaringTypeInfo != parent)
			{
				ThrowHelper.ThrowInvalidOperationException_JsonPropertyInfoIsBoundToDifferentJsonTypeInfo(this);
			}
			this.DeclaringTypeInfo.ResolveMatchingParameterInfo(this);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0002EC48 File Offset: 0x0002CE48
		internal bool TryGetPrePopulatedValue([ScopedRef] ref ReadStack state)
		{
			if (this.EffectiveObjectCreationHandling != JsonObjectCreationHandling.Populate)
			{
				return false;
			}
			object obj = this.Get(state.Parent.ReturnValue);
			state.Current.ReturnValue = obj;
			state.Current.IsPopulating = (obj != null);
			return obj != null;
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0002EC96 File Offset: 0x0002CE96
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x0002ECA4 File Offset: 0x0002CEA4
		internal JsonTypeInfo JsonTypeInfo
		{
			get
			{
				JsonTypeInfo jsonTypeInfo = this._jsonTypeInfo;
				jsonTypeInfo.EnsureConfigured();
				return jsonTypeInfo;
			}
			set
			{
				this._jsonTypeInfo = value;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0002ECAD File Offset: 0x0002CEAD
		internal bool IsPropertyTypeInfoConfigured
		{
			get
			{
				JsonTypeInfo jsonTypeInfo = this._jsonTypeInfo;
				return jsonTypeInfo != null && jsonTypeInfo.IsConfigured;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x0002ECC0 File Offset: 0x0002CEC0
		internal bool IsIgnored
		{
			get
			{
				return !(this._ignoreCondition != JsonIgnoreCondition.Always) && this.Get == null && this.Set == null;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0002ECFA File Offset: 0x0002CEFA
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x0002ED02 File Offset: 0x0002CF02
		internal bool CanSerialize { get; private set; }

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x0002ED0B File Offset: 0x0002CF0B
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x0002ED13 File Offset: 0x0002CF13
		internal bool CanDeserialize { get; private set; }

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x0002ED1C File Offset: 0x0002CF1C
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x0002ED24 File Offset: 0x0002CF24
		internal bool CanDeserializeOrPopulate { get; private set; }

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x0002ED2D File Offset: 0x0002CF2D
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x0002ED35 File Offset: 0x0002CF35
		internal bool SrcGen_HasJsonInclude { get; set; }

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x0002ED3E File Offset: 0x0002CF3E
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x0002ED46 File Offset: 0x0002CF46
		internal bool SrcGen_IsPublic { get; set; }

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x0002ED4F File Offset: 0x0002CF4F
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x0002ED57 File Offset: 0x0002CF57
		public JsonNumberHandling? NumberHandling
		{
			get
			{
				return this._numberHandling;
			}
			set
			{
				this.VerifyMutable();
				this._numberHandling = value;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x0002ED66 File Offset: 0x0002CF66
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x0002ED6E File Offset: 0x0002CF6E
		internal JsonNumberHandling? EffectiveNumberHandling { get; private set; }

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000B72 RID: 2930
		internal abstract bool PropertyTypeCanBeNull { get; }

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x0002ED77 File Offset: 0x0002CF77
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x0002ED7F File Offset: 0x0002CF7F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal int RequiredPropertyIndex
		{
			get
			{
				return this._index;
			}
			set
			{
				this._index = value;
			}
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0002ED88 File Offset: 0x0002CF88
		internal bool IsOverriddenOrShadowedBy(JsonPropertyInfo other)
		{
			return this.MemberName == other.MemberName && this.DeclaringType.IsAssignableFrom(other.DeclaringType);
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0002EDB0 File Offset: 0x0002CFB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string DebuggerDisplay
		{
			get
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
				defaultInterpolatedStringHandler.AppendLiteral("Name = ");
				defaultInterpolatedStringHandler.AppendFormatted(this.Name);
				defaultInterpolatedStringHandler.AppendLiteral(", PropertyType = ");
				defaultInterpolatedStringHandler.AppendFormatted<Type>(this.PropertyType);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0002EE0C File Offset: 0x0002D00C
		[CompilerGenerated]
		private JsonConverter<TValue> <ReadJsonAndAddExtensionProperty>g__GetDictionaryValueConverter|143_0<TValue>()
		{
			return ((JsonTypeInfo<TValue>)(this.JsonTypeInfo.ElementTypeInfo ?? this.Options.GetTypeInfoInternal(typeof(TValue), true, new bool?(true), false, false))).EffectiveConverter;
		}

		// Token: 0x04000375 RID: 885
		internal static readonly JsonPropertyInfo s_missingProperty = JsonPropertyInfo.GetPropertyPlaceholder();

		// Token: 0x04000377 RID: 887
		private protected JsonConverter _effectiveConverter;

		// Token: 0x04000378 RID: 888
		private JsonConverter _customConverter;

		// Token: 0x04000379 RID: 889
		private protected Func<object, object> _untypedGet;

		// Token: 0x0400037A RID: 890
		private protected Action<object, object> _untypedSet;

		// Token: 0x0400037B RID: 891
		private bool _isUserSpecifiedSetter;

		// Token: 0x0400037C RID: 892
		private protected Func<object, object, bool> _shouldSerialize;

		// Token: 0x0400037D RID: 893
		private bool _isUserSpecifiedShouldSerialize;

		// Token: 0x0400037E RID: 894
		private JsonIgnoreCondition? _ignoreCondition;

		// Token: 0x0400037F RID: 895
		internal Func<ICustomAttributeProvider> AttributeProviderFactory;

		// Token: 0x04000380 RID: 896
		private ICustomAttributeProvider _attributeProvider;

		// Token: 0x04000381 RID: 897
		private JsonObjectCreationHandling? _objectCreationHandling;

		// Token: 0x04000386 RID: 902
		private bool _isGetNullable;

		// Token: 0x04000387 RID: 903
		private protected bool _isSetNullable;

		// Token: 0x04000388 RID: 904
		private bool _isExtensionDataProperty;

		// Token: 0x04000389 RID: 905
		private protected bool _isRequired;

		// Token: 0x04000391 RID: 913
		private string _name;

		// Token: 0x04000395 RID: 917
		private int _order;

		// Token: 0x04000396 RID: 918
		private JsonTypeInfo _jsonTypeInfo;

		// Token: 0x0400039C RID: 924
		private JsonNumberHandling? _numberHandling;

		// Token: 0x0400039E RID: 926
		private int _index;
	}
}
