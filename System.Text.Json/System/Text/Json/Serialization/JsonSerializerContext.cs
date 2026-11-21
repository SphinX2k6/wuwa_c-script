using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization
{
	// Token: 0x02000098 RID: 152
	public abstract class JsonSerializerContext : IJsonTypeInfoResolver, IBuiltInJsonTypeInfoResolver
	{
		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x00028214 File Offset: 0x00026414
		[Nullable(1)]
		public JsonSerializerOptions Options
		{
			[NullableContext(1)]
			get
			{
				JsonSerializerOptions jsonSerializerOptions = this._options;
				if (jsonSerializerOptions == null)
				{
					jsonSerializerOptions = new JsonSerializerOptions
					{
						TypeInfoResolver = this
					};
					jsonSerializerOptions.MakeReadOnly();
					this._options = jsonSerializerOptions;
				}
				return jsonSerializerOptions;
			}
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00028246 File Offset: 0x00026446
		internal void AssociateWithOptions(JsonSerializerOptions options)
		{
			options.TypeInfoResolver = this;
			options.MakeReadOnly();
			this._options = options;
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0002825C File Offset: 0x0002645C
		bool IBuiltInJsonTypeInfoResolver.IsCompatibleWithOptions(JsonSerializerOptions options)
		{
			JsonSerializerOptions generatedSerializerOptions = this.GeneratedSerializerOptions;
			return generatedSerializerOptions != null && options.Converters.Count == 0 && options.Encoder == null && !JsonHelpers.RequiresSpecialNumberHandlingOnWrite(new JsonNumberHandling?(options.NumberHandling)) && options.ReferenceHandlingStrategy == ReferenceHandlingStrategy.None && !options.IgnoreNullValues && options.DefaultIgnoreCondition == generatedSerializerOptions.DefaultIgnoreCondition && options.RespectNullableAnnotations == generatedSerializerOptions.RespectNullableAnnotations && options.IgnoreReadOnlyFields == generatedSerializerOptions.IgnoreReadOnlyFields && options.IgnoreReadOnlyProperties == generatedSerializerOptions.IgnoreReadOnlyProperties && options.IncludeFields == generatedSerializerOptions.IncludeFields && options.PropertyNamingPolicy == generatedSerializerOptions.PropertyNamingPolicy && options.DictionaryKeyPolicy == null;
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600090C RID: 2316
		[Nullable(2)]
		protected abstract JsonSerializerOptions GeneratedSerializerOptions { [NullableContext(2)] get; }

		// Token: 0x0600090D RID: 2317 RVA: 0x00028312 File Offset: 0x00026512
		[NullableContext(2)]
		protected JsonSerializerContext(JsonSerializerOptions options)
		{
			if (options != null)
			{
				options.VerifyMutable();
				this.AssociateWithOptions(options);
			}
		}

		// Token: 0x0600090E RID: 2318
		[NullableContext(1)]
		[return: Nullable(2)]
		public abstract JsonTypeInfo GetTypeInfo(Type type);

		// Token: 0x0600090F RID: 2319 RVA: 0x0002832A File Offset: 0x0002652A
		JsonTypeInfo IJsonTypeInfoResolver.GetTypeInfo(Type type, JsonSerializerOptions options)
		{
			if (options != null && options != this._options)
			{
				ThrowHelper.ThrowInvalidOperationException_ResolverTypeInfoOptionsNotCompatible();
			}
			return this.GetTypeInfo(type);
		}

		// Token: 0x04000297 RID: 663
		private JsonSerializerOptions _options;
	}
}
