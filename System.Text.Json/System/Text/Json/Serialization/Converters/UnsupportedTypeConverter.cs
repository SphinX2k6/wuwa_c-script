using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000151 RID: 337
	internal sealed class UnsupportedTypeConverter<T> : JsonConverter<T>
	{
		// Token: 0x06000ED2 RID: 3794 RVA: 0x0003851F File Offset: 0x0003671F
		public UnsupportedTypeConverter(string errorMessage = null)
		{
			this._errorMessage = errorMessage;
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x0003852E File Offset: 0x0003672E
		public string ErrorMessage
		{
			get
			{
				return this._errorMessage ?? SR.Format(SR.SerializeTypeInstanceNotSupported, typeof(T).FullName);
			}
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00038554 File Offset: 0x00036754
		public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			throw new NotSupportedException(this.ErrorMessage);
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x0003856C File Offset: 0x0003676C
		public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
		{
			throw new NotSupportedException(this.ErrorMessage);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00038579 File Offset: 0x00036779
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return new JsonSchema
			{
				Comment = "Unsupported .NET type",
				Not = JsonSchema.CreateTrueSchema()
			};
		}

		// Token: 0x04000467 RID: 1127
		private readonly string _errorMessage;
	}
}
