using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000125 RID: 293
	internal sealed class FSharpOptionConverter<TOption, TElement> : JsonConverter<TOption> where TOption : class
	{
		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x0002876A File Offset: 0x0002696A
		internal override Type ElementType
		{
			get
			{
				return typeof(TElement);
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x00034CB5 File Offset: 0x00032EB5
		internal override JsonConverter NullableElementConverter
		{
			get
			{
				return this._elementConverter;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x00003363 File Offset: 0x00001563
		public override bool HandleNull
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00034CBD File Offset: 0x00032EBD
		[RequiresUnreferencedCode("Uses Reflection to access FSharp.Core components at runtime.")]
		[RequiresDynamicCode("Uses Reflection to access FSharp.Core components at runtime.")]
		public FSharpOptionConverter(JsonConverter<TElement> elementConverter)
		{
			this._elementConverter = elementConverter;
			this._optionValueGetter = FSharpCoreReflectionProxy.Instance.CreateFSharpOptionValueGetter<TOption, TElement>();
			this._optionConstructor = FSharpCoreReflectionProxy.Instance.CreateFSharpOptionSomeConstructor<TOption, TElement>();
			base.ConverterStrategy = elementConverter.ConverterStrategy;
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00034CF8 File Offset: 0x00032EF8
		internal override bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, out TOption value)
		{
			if (!state.IsContinuation && reader.TokenType == JsonTokenType.Null)
			{
				value = default(TOption);
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
			value = default(TOption);
			return false;
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00034D84 File Offset: 0x00032F84
		internal override bool OnTryWrite(Utf8JsonWriter writer, TOption value, JsonSerializerOptions options, ref WriteStack state)
		{
			if (value == null)
			{
				writer.WriteNullValue();
				return true;
			}
			TElement telement = this._optionValueGetter(value);
			state.Current.JsonPropertyInfo = state.Current.JsonTypeInfo.ElementTypeInfo.PropertyInfoForTypeInfo;
			return this._elementConverter.TryWrite(writer, telement, options, ref state);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00034DE4 File Offset: 0x00032FE4
		public override void Write(Utf8JsonWriter writer, TOption value, JsonSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNullValue();
				return;
			}
			TElement value2 = this._optionValueGetter(value);
			this._elementConverter.Write(writer, value2, options);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00034E1C File Offset: 0x0003301C
		public override TOption Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.Null)
			{
				return default(TOption);
			}
			TElement arg = this._elementConverter.Read(ref reader, typeToConvert, options);
			return this._optionConstructor(arg);
		}

		// Token: 0x04000444 RID: 1092
		private readonly JsonConverter<TElement> _elementConverter;

		// Token: 0x04000445 RID: 1093
		private readonly Func<TOption, TElement> _optionValueGetter;

		// Token: 0x04000446 RID: 1094
		private readonly Func<TElement, TOption> _optionConstructor;
	}
}
