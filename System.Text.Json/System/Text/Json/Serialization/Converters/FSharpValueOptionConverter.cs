using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000126 RID: 294
	internal sealed class FSharpValueOptionConverter<TValueOption, TElement> : JsonConverter<TValueOption> where TValueOption : struct, IEquatable<TValueOption>
	{
		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000DBE RID: 3518 RVA: 0x0002876A File Offset: 0x0002696A
		internal override Type ElementType
		{
			get
			{
				return typeof(TElement);
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x00034E58 File Offset: 0x00033058
		internal override JsonConverter NullableElementConverter
		{
			get
			{
				return this._elementConverter;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x00003363 File Offset: 0x00001563
		public override bool HandleNull
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00034E60 File Offset: 0x00033060
		[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
		[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
		public FSharpValueOptionConverter(JsonConverter<TElement> elementConverter)
		{
			this._elementConverter = elementConverter;
			this._optionValueGetter = FSharpCoreReflectionProxy.Instance.CreateFSharpValueOptionValueGetter<TValueOption, TElement>();
			this._optionConstructor = FSharpCoreReflectionProxy.Instance.CreateFSharpValueOptionSomeConstructor<TValueOption, TElement>();
			base.ConverterStrategy = elementConverter.ConverterStrategy;
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00034E9C File Offset: 0x0003309C
		internal override bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, out TValueOption value)
		{
			if (!state.IsContinuation && reader.TokenType == JsonTokenType.Null)
			{
				value = default(TValueOption);
				return true;
			}
			state.Current.JsonPropertyInfo = state.Current.JsonTypeInfo.ElementTypeInfo.PropertyInfoForTypeInfo;
			TElement arg;
			bool flag;
			if (this._elementConverter.TryRead(ref reader, typeof(TElement), options, ref state, out arg, out flag))
			{
				value = this._optionConstructor(arg);
				return true;
			}
			value = default(TValueOption);
			return false;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00034F28 File Offset: 0x00033128
		internal override bool OnTryWrite(Utf8JsonWriter writer, TValueOption value, JsonSerializerOptions options, ref WriteStack state)
		{
			if (value.Equals(default(TValueOption)))
			{
				writer.WriteNullValue();
				return true;
			}
			TElement telement = this._optionValueGetter(ref value);
			state.Current.JsonPropertyInfo = state.Current.JsonTypeInfo.ElementTypeInfo.PropertyInfoForTypeInfo;
			return this._elementConverter.TryWrite(writer, telement, options, ref state);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00034F98 File Offset: 0x00033198
		public override void Write(Utf8JsonWriter writer, TValueOption value, JsonSerializerOptions options)
		{
			if (value.Equals(default(TValueOption)))
			{
				writer.WriteNullValue();
				return;
			}
			TElement value2 = this._optionValueGetter(ref value);
			this._elementConverter.Write(writer, value2, options);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00034FE0 File Offset: 0x000331E0
		public override TValueOption Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.Null)
			{
				return default(TValueOption);
			}
			TElement arg = this._elementConverter.Read(ref reader, typeToConvert, options);
			return this._optionConstructor(arg);
		}

		// Token: 0x04000447 RID: 1095
		private readonly JsonConverter<TElement> _elementConverter;

		// Token: 0x04000448 RID: 1096
		private readonly FSharpCoreReflectionProxy.StructGetter<TValueOption, TElement> _optionValueGetter;

		// Token: 0x04000449 RID: 1097
		private readonly Func<TElement, TValueOption> _optionConstructor;
	}
}
