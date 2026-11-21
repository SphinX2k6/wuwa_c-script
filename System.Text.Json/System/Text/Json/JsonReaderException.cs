using System;
using System.Runtime.Serialization;

namespace System.Text.Json
{
	// Token: 0x02000032 RID: 50
	[Serializable]
	internal sealed class JsonReaderException : JsonException
	{
		// Token: 0x06000317 RID: 791 RVA: 0x0000A98D File Offset: 0x00008B8D
		public JsonReaderException(string message, long lineNumber, long bytePositionInLine) : base(message, null, new long?(lineNumber), new long?(bytePositionInLine))
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000A9A3 File Offset: 0x00008BA3
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		private JsonReaderException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
