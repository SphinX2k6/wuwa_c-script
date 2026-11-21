using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Schema
{
	// Token: 0x02000067 RID: 103
	[NullableContext(2)]
	[Nullable(0)]
	public readonly struct JsonSchemaExporterContext
	{
		// Token: 0x06000765 RID: 1893 RVA: 0x00024385 File Offset: 0x00022585
		internal JsonSchemaExporterContext(JsonTypeInfo typeInfo, JsonPropertyInfo propertyInfo, JsonTypeInfo baseTypeInfo, string[] path)
		{
			this.TypeInfo = typeInfo;
			this.PropertyInfo = propertyInfo;
			this.BaseTypeInfo = baseTypeInfo;
			this._path = path;
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x000243A4 File Offset: 0x000225A4
		[Nullable(1)]
		public JsonTypeInfo TypeInfo { [NullableContext(1)] get; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x000243AC File Offset: 0x000225AC
		public JsonPropertyInfo PropertyInfo { get; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x000243B4 File Offset: 0x000225B4
		public JsonTypeInfo BaseTypeInfo { get; }

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x000243BC File Offset: 0x000225BC
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public ReadOnlySpan<string> Path
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return this._path;
			}
		}

		// Token: 0x0400021F RID: 543
		internal readonly string[] _path;
	}
}
