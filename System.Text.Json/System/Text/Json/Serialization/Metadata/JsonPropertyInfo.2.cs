using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000D2 RID: 210
	internal sealed class JsonPropertyInfo<T> : JsonPropertyInfo
	{
		// Token: 0x06000B79 RID: 2937 RVA: 0x0002EE45 File Offset: 0x0002D045
		internal JsonPropertyInfo(Type declaringType, JsonTypeInfo declaringTypeInfo, JsonSerializerOptions options) : base(declaringType, typeof(T), declaringTypeInfo, options)
		{
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x0002EE5A File Offset: 0x0002D05A
		// (set) Token: 0x06000B7B RID: 2939 RVA: 0x0002EE62 File Offset: 0x0002D062
		internal new Func<object, T> Get
		{
			get
			{
				return this._typedGet;
			}
			set
			{
				this.SetGetter(value);
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x0002EE6B File Offset: 0x0002D06B
		// (set) Token: 0x06000B7D RID: 2941 RVA: 0x0002EE73 File Offset: 0x0002D073
		internal new Action<object, T> Set
		{
			get
			{
				return this._typedSet;
			}
			set
			{
				this.SetSetter(value);
			}
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0002EE7C File Offset: 0x0002D07C
		private protected override void SetGetter(Delegate getter)
		{
			if (getter == null)
			{
				this._typedGet = null;
				this._untypedGet = null;
				return;
			}
			Func<object, T> typedGetter = getter as Func<object, T>;
			if (typedGetter != null)
			{
				this._typedGet = typedGetter;
				Func<object, object> func = getter as Func<object, object>;
				this._untypedGet = ((func != null) ? func : ((object obj) => typedGetter(obj)));
				return;
			}
			Func<object, object> untypedGet = (Func<object, object>)getter;
			this._typedGet = ((object obj) => (T)((object)untypedGet(obj)));
			this._untypedGet = untypedGet;
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0002EF14 File Offset: 0x0002D114
		private protected override void SetSetter(Delegate setter)
		{
			if (setter == null)
			{
				this._typedSet = null;
				this._untypedSet = null;
				return;
			}
			Action<object, T> typedSetter = setter as Action<object, T>;
			if (typedSetter != null)
			{
				this._typedSet = typedSetter;
				Action<object, object> action = setter as Action<object, object>;
				this._untypedSet = ((action != null) ? action : delegate(object obj, object value)
				{
					typedSetter(obj, (T)((object)value));
				});
				return;
			}
			Action<object, object> untypedSet = (Action<object, object>)setter;
			this._typedSet = delegate(object obj, T value)
			{
				untypedSet(obj, value);
			};
			this._untypedSet = untypedSet;
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x0002EFA9 File Offset: 0x0002D1A9
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x0002EFB1 File Offset: 0x0002D1B1
		internal new Func<object, T, bool> ShouldSerialize
		{
			get
			{
				return this._shouldSerializeTyped;
			}
			set
			{
				this.SetShouldSerialize(value);
			}
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0002EFBC File Offset: 0x0002D1BC
		private protected override void SetShouldSerialize(Delegate predicate)
		{
			if (predicate == null)
			{
				this._shouldSerializeTyped = null;
				this._shouldSerialize = null;
				return;
			}
			Func<object, T, bool> typedPredicate = predicate as Func<object, T, bool>;
			if (typedPredicate != null)
			{
				this._shouldSerializeTyped = typedPredicate;
				Func<object, object, bool> func = typedPredicate as Func<object, object, bool>;
				this._shouldSerialize = ((func != null) ? func : ((object obj, object value) => typedPredicate(obj, (T)((object)value))));
				return;
			}
			Func<object, object, bool> untypedPredicate = (Func<object, object, bool>)predicate;
			this._shouldSerializeTyped = ((object obj, T value) => untypedPredicate(obj, value));
			this._shouldSerialize = untypedPredicate;
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x0002F058 File Offset: 0x0002D258
		internal override bool PropertyTypeCanBeNull
		{
			get
			{
				return default(T) == null;
			}
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0002F076 File Offset: 0x0002D276
		internal override void AddJsonParameterInfo(JsonParameterInfoValues parameterInfoValues)
		{
			base.AssociatedParameter = new JsonParameterInfo<T>(parameterInfoValues, this);
			this._isSetNullable = parameterInfoValues.IsNullable;
			if (base.Options.RespectRequiredConstructorParameters)
			{
				this._isRequired |= base.AssociatedParameter.IsRequiredParameter;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x0002F0B6 File Offset: 0x0002D2B6
		internal new JsonConverter<T> EffectiveConverter
		{
			get
			{
				return this._typedEffectiveConverter;
			}
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0002F0BE File Offset: 0x0002D2BE
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		internal override void DetermineReflectionPropertyAccessors(MemberInfo memberInfo, bool useNonPublicAccessors)
		{
			DefaultJsonTypeInfoResolver.DeterminePropertyAccessors<T>(this, memberInfo, useNonPublicAccessors);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0002F0C8 File Offset: 0x0002D2C8
		private protected override void DetermineEffectiveConverter(JsonTypeInfo jsonTypeInfo)
		{
			JsonConverter jsonConverter = base.Options.ExpandConverterFactory(base.CustomConverter, base.PropertyType);
			JsonConverter<T> jsonConverter2 = ((jsonConverter != null) ? jsonConverter.CreateCastingConverter<T>() : null) ?? ((JsonTypeInfo<T>)jsonTypeInfo).EffectiveConverter;
			this._effectiveConverter = jsonConverter2;
			this._typedEffectiveConverter = jsonConverter2;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0002F116 File Offset: 0x0002D316
		internal override object GetValueAsObject(object obj)
		{
			if (base.IsForTypeInfo)
			{
				return obj;
			}
			return this.Get(obj);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0002F134 File Offset: 0x0002D334
		internal override bool GetMemberAndWriteJson(object obj, ref WriteStack state, Utf8JsonWriter writer)
		{
			T t = this.Get(obj);
			if (!typeof(T).IsValueType && base.Options.ReferenceHandlingStrategy == ReferenceHandlingStrategy.IgnoreCycles && t != null && !state.IsContinuation && this.EffectiveConverter.ConverterStrategy != ConverterStrategy.Value && state.ReferenceResolver.ContainsReferenceForCycleDetection(t))
			{
				t = default(T);
			}
			if (base.IgnoreDefaultValuesOnWrite)
			{
				if (JsonPropertyInfo<T>.IsDefaultValue(t))
				{
					return true;
				}
			}
			else
			{
				Func<object, T, bool> shouldSerialize = this.ShouldSerialize;
				if (shouldSerialize != null && !shouldSerialize(obj, t))
				{
					return true;
				}
			}
			if (t == null)
			{
				if (!base.IsGetNullable && base.Options.RespectNullableAnnotations)
				{
					ThrowHelper.ThrowJsonException_PropertyGetterDisallowNull(base.Name, state.Current.JsonTypeInfo.Type);
				}
				if (this.EffectiveConverter.HandleNullOnWrite)
				{
					if (state.Current.PropertyState < StackFramePropertyState.Name)
					{
						state.Current.PropertyState = StackFramePropertyState.Name;
						writer.WritePropertyNameSection(base.EscapedNameSection);
					}
					int currentDepth = writer.CurrentDepth;
					this.EffectiveConverter.Write(writer, t, base.Options);
					if (currentDepth != writer.CurrentDepth)
					{
						ThrowHelper.ThrowJsonException_SerializationConverterWrite(this.EffectiveConverter);
					}
				}
				else
				{
					writer.WriteNullSection(base.EscapedNameSection);
				}
				return true;
			}
			if (state.Current.PropertyState < StackFramePropertyState.Name)
			{
				state.Current.PropertyState = StackFramePropertyState.Name;
				writer.WritePropertyNameSection(base.EscapedNameSection);
			}
			return this.EffectiveConverter.TryWrite(writer, t, base.Options, ref state);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0002F2C8 File Offset: 0x0002D4C8
		internal override bool GetMemberAndWriteJsonExtensionData(object obj, ref WriteStack state, Utf8JsonWriter writer)
		{
			T t = this.Get(obj);
			Func<object, T, bool> shouldSerialize = this.ShouldSerialize;
			return (shouldSerialize != null && !shouldSerialize(obj, t)) || t == null || this.EffectiveConverter.TryWriteDataExtensionProperty(writer, t, base.Options, ref state);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0002F320 File Offset: 0x0002D520
		internal override bool ReadJsonAndSetMember(object obj, [ScopedRef] ref ReadStack state, ref Utf8JsonReader reader)
		{
			bool flag = reader.TokenType == JsonTokenType.Null;
			bool flag2;
			if (flag && !this.EffectiveConverter.HandleNullOnRead && !state.IsContinuation)
			{
				if (default(T) != null || !base.CanDeserialize)
				{
					if (default(T) == null)
					{
						ThrowHelper.ThrowInvalidOperationException_DeserializeUnableToAssignNull(this.EffectiveConverter.Type);
					}
					ThrowHelper.ThrowJsonException_DeserializeUnableToConvertValue(this.EffectiveConverter.Type);
				}
				if (!base.IgnoreNullTokensOnRead)
				{
					if (!base.IsSetNullable && base.Options.RespectNullableAnnotations)
					{
						ThrowHelper.ThrowJsonException_PropertySetterDisallowNull(base.Name, state.Current.JsonTypeInfo.Type);
					}
					T arg = default(T);
					this.Set(obj, arg);
				}
				flag2 = true;
				state.Current.MarkRequiredPropertyAsRead(this);
			}
			else if (this.EffectiveConverter.CanUseDirectReadOrWrite && state.Current.NumberHandling == null)
			{
				if (!flag || !base.IgnoreNullTokensOnRead || default(T) != null)
				{
					T t = this.EffectiveConverter.Read(ref reader, base.PropertyType, base.Options);
					if (t == null && !base.IsSetNullable && base.Options.RespectNullableAnnotations)
					{
						ThrowHelper.ThrowJsonException_PropertySetterDisallowNull(base.Name, state.Current.JsonTypeInfo.Type);
					}
					this.Set(obj, t);
				}
				flag2 = true;
				state.Current.MarkRequiredPropertyAsRead(this);
			}
			else
			{
				flag2 = true;
				if (!flag || !base.IgnoreNullTokensOnRead || default(T) != null || state.IsContinuation)
				{
					state.Current.ReturnValue = obj;
					T t2;
					bool flag3;
					flag2 = this.EffectiveConverter.TryRead(ref reader, base.PropertyType, base.Options, ref state, out t2, out flag3);
					if (flag2)
					{
						if ((typeof(T).IsValueType || !flag3) && base.CanDeserialize)
						{
							if (t2 == null && !base.IsSetNullable && base.Options.RespectNullableAnnotations)
							{
								ThrowHelper.ThrowJsonException_PropertySetterDisallowNull(base.Name, state.Current.JsonTypeInfo.Type);
							}
							this.Set(obj, t2);
						}
						state.Current.MarkRequiredPropertyAsRead(this);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0002F57C File Offset: 0x0002D77C
		internal override bool ReadJsonAsObject([ScopedRef] ref ReadStack state, ref Utf8JsonReader reader, out object value)
		{
			bool result;
			if (reader.TokenType == JsonTokenType.Null && !this.EffectiveConverter.HandleNullOnRead && !state.IsContinuation)
			{
				if (default(T) != null)
				{
					ThrowHelper.ThrowJsonException_DeserializeUnableToConvertValue(this.EffectiveConverter.Type);
				}
				value = default(T);
				result = true;
			}
			else if (this.EffectiveConverter.CanUseDirectReadOrWrite && state.Current.NumberHandling == null)
			{
				value = this.EffectiveConverter.Read(ref reader, base.PropertyType, base.Options);
				result = true;
			}
			else
			{
				T t;
				bool flag;
				result = this.EffectiveConverter.TryRead(ref reader, base.PropertyType, base.Options, ref state, out t, out flag);
				value = t;
			}
			return result;
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0002F648 File Offset: 0x0002D848
		private protected override void ConfigureIgnoreCondition(JsonIgnoreCondition? ignoreCondition)
		{
			if (ignoreCondition != null)
			{
				switch (ignoreCondition.GetValueOrDefault())
				{
				case JsonIgnoreCondition.Never:
				{
					Func<object, T, bool> shouldSerialize;
					if ((shouldSerialize = JsonPropertyInfo<T>.<>O.<0>__ShouldSerializeIgnoreConditionNever) == null)
					{
						shouldSerialize = (JsonPropertyInfo<T>.<>O.<0>__ShouldSerializeIgnoreConditionNever = new Func<object, T, bool>(JsonPropertyInfo<T>.<ConfigureIgnoreCondition>g__ShouldSerializeIgnoreConditionNever|31_0));
					}
					this.ShouldSerialize = shouldSerialize;
					return;
				}
				case JsonIgnoreCondition.Always:
				{
					Func<object, T, bool> shouldSerialize2;
					if ((shouldSerialize2 = JsonPropertyInfo<T>.<>O.<1>__ShouldSerializeIgnoreConditionAlways) == null)
					{
						shouldSerialize2 = (JsonPropertyInfo<T>.<>O.<1>__ShouldSerializeIgnoreConditionAlways = new Func<object, T, bool>(JsonPropertyInfo<T>.<ConfigureIgnoreCondition>g__ShouldSerializeIgnoreConditionAlways|31_1));
					}
					this.ShouldSerialize = shouldSerialize2;
					return;
				}
				case JsonIgnoreCondition.WhenWritingDefault:
				{
					Func<object, T, bool> shouldSerialize3;
					if ((shouldSerialize3 = JsonPropertyInfo<T>.<>O.<2>__ShouldSerializeIgnoreWhenWritingDefault) == null)
					{
						shouldSerialize3 = (JsonPropertyInfo<T>.<>O.<2>__ShouldSerializeIgnoreWhenWritingDefault = new Func<object, T, bool>(JsonPropertyInfo<T>.<ConfigureIgnoreCondition>g__ShouldSerializeIgnoreWhenWritingDefault|31_2));
					}
					this.ShouldSerialize = shouldSerialize3;
					base.IgnoreDefaultValuesOnWrite = true;
					break;
				}
				case JsonIgnoreCondition.WhenWritingNull:
					if (this.PropertyTypeCanBeNull)
					{
						Func<object, T, bool> shouldSerialize4;
						if ((shouldSerialize4 = JsonPropertyInfo<T>.<>O.<2>__ShouldSerializeIgnoreWhenWritingDefault) == null)
						{
							shouldSerialize4 = (JsonPropertyInfo<T>.<>O.<2>__ShouldSerializeIgnoreWhenWritingDefault = new Func<object, T, bool>(JsonPropertyInfo<T>.<ConfigureIgnoreCondition>g__ShouldSerializeIgnoreWhenWritingDefault|31_2));
						}
						this.ShouldSerialize = shouldSerialize4;
						base.IgnoreDefaultValuesOnWrite = true;
						return;
					}
					ThrowHelper.ThrowInvalidOperationException_IgnoreConditionOnValueTypeInvalid(base.MemberName, base.DeclaringType);
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0002F730 File Offset: 0x0002D930
		private static bool IsDefaultValue(T value)
		{
			if (default(T) != null)
			{
				return EqualityComparer<T>.Default.Equals(default(T), value);
			}
			return value == null;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00003363 File Offset: 0x00001563
		[CompilerGenerated]
		internal static bool <ConfigureIgnoreCondition>g__ShouldSerializeIgnoreConditionNever|31_0(object _, T value)
		{
			return true;
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000249D0 File Offset: 0x00022BD0
		[CompilerGenerated]
		internal static bool <ConfigureIgnoreCondition>g__ShouldSerializeIgnoreConditionAlways|31_1(object _, T value)
		{
			return false;
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0002F76C File Offset: 0x0002D96C
		[CompilerGenerated]
		internal static bool <ConfigureIgnoreCondition>g__ShouldSerializeIgnoreWhenWritingDefault|31_2(object _, T value)
		{
			if (default(T) != null)
			{
				return !EqualityComparer<T>.Default.Equals(default(T), value);
			}
			return value != null;
		}

		// Token: 0x0400039F RID: 927
		private Func<object, T> _typedGet;

		// Token: 0x040003A0 RID: 928
		private Action<object, T> _typedSet;

		// Token: 0x040003A1 RID: 929
		private Func<object, T, bool> _shouldSerializeTyped;

		// Token: 0x040003A2 RID: 930
		private JsonConverter<T> _typedEffectiveConverter;

		// Token: 0x020000D3 RID: 211
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040003A3 RID: 931
			public static Func<object, T, bool> <0>__ShouldSerializeIgnoreConditionNever;

			// Token: 0x040003A4 RID: 932
			public static Func<object, T, bool> <1>__ShouldSerializeIgnoreConditionAlways;

			// Token: 0x040003A5 RID: 933
			public static Func<object, T, bool> <2>__ShouldSerializeIgnoreWhenWritingDefault;
		}
	}
}
