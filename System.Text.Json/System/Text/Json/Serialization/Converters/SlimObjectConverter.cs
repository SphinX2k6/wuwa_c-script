using System;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200012E RID: 302
	internal sealed class SlimObjectConverter : ObjectConverter
	{
		// Token: 0x06000DEB RID: 3563 RVA: 0x000353CF File Offset: 0x000335CF
		public SlimObjectConverter(IJsonTypeInfoResolver originatingResolver)
		{
			this._originatingResolver = originatingResolver;
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x000353DE File Offset: 0x000335DE
		public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			ThrowHelper.ThrowNotSupportedException_NoMetadataForType(typeToConvert, this._originatingResolver);
			return null;
		}

		// Token: 0x0400044F RID: 1103
		private readonly IJsonTypeInfoResolver _originatingResolver;
	}
}
