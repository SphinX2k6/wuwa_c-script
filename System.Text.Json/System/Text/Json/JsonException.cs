using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Text.Json
{
	// Token: 0x0200002E RID: 46
	[NullableContext(2)]
	[Nullable(0)]
	[Serializable]
	public class JsonException : Exception
	{
		// Token: 0x06000306 RID: 774 RVA: 0x0000A7B4 File Offset: 0x000089B4
		public JsonException(string message, string path, long? lineNumber, long? bytePositionInLine, Exception innerException) : base(message, innerException)
		{
			this._message = message;
			this.LineNumber = lineNumber;
			this.BytePositionInLine = bytePositionInLine;
			this.Path = path;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000A7DC File Offset: 0x000089DC
		public JsonException(string message, string path, long? lineNumber, long? bytePositionInLine) : base(message)
		{
			this._message = message;
			this.LineNumber = lineNumber;
			this.BytePositionInLine = bytePositionInLine;
			this.Path = path;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000A802 File Offset: 0x00008A02
		public JsonException(string message, Exception innerException) : base(message, innerException)
		{
			this._message = message;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000A813 File Offset: 0x00008A13
		public JsonException(string message) : base(message)
		{
			this._message = message;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000A823 File Offset: 0x00008A23
		public JsonException()
		{
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000A82C File Offset: 0x00008A2C
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected JsonException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.LineNumber = (long?)info.GetValue("LineNumber", typeof(long?));
			this.BytePositionInLine = (long?)info.GetValue("BytePositionInLine", typeof(long?));
			this.Path = info.GetString("Path");
			this.SetMessage(info.GetString("ActualMessage"));
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0000A8A3 File Offset: 0x00008AA3
		// (set) Token: 0x0600030D RID: 781 RVA: 0x0000A8AB File Offset: 0x00008AAB
		internal bool AppendPathInformation { get; set; }

		// Token: 0x0600030E RID: 782 RVA: 0x0000A8B4 File Offset: 0x00008AB4
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("LineNumber", this.LineNumber, typeof(long?));
			info.AddValue("BytePositionInLine", this.BytePositionInLine, typeof(long?));
			info.AddValue("Path", this.Path, typeof(string));
			info.AddValue("ActualMessage", this.Message, typeof(string));
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600030F RID: 783 RVA: 0x0000A93F File Offset: 0x00008B3F
		// (set) Token: 0x06000310 RID: 784 RVA: 0x0000A947 File Offset: 0x00008B47
		public long? LineNumber { get; internal set; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000311 RID: 785 RVA: 0x0000A950 File Offset: 0x00008B50
		// (set) Token: 0x06000312 RID: 786 RVA: 0x0000A958 File Offset: 0x00008B58
		public long? BytePositionInLine { get; internal set; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000313 RID: 787 RVA: 0x0000A961 File Offset: 0x00008B61
		// (set) Token: 0x06000314 RID: 788 RVA: 0x0000A969 File Offset: 0x00008B69
		public string Path { get; internal set; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000315 RID: 789 RVA: 0x0000A972 File Offset: 0x00008B72
		[Nullable(1)]
		public override string Message
		{
			[NullableContext(1)]
			get
			{
				return this._message ?? base.Message;
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000A984 File Offset: 0x00008B84
		internal void SetMessage(string message)
		{
			this._message = message;
		}

		// Token: 0x04000078 RID: 120
		internal string _message;
	}
}
