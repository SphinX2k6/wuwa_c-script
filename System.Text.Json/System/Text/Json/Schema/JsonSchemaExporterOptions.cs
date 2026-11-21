using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;

namespace System.Text.Json.Schema
{
	// Token: 0x02000066 RID: 102
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class JsonSchemaExporterOptions
	{
		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00024350 File Offset: 0x00022550
		public static JsonSchemaExporterOptions Default { get; } = new JsonSchemaExporterOptions();

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00024357 File Offset: 0x00022557
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x0002435F File Offset: 0x0002255F
		public bool TreatNullObliviousAsNonNullable { get; set; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00024368 File Offset: 0x00022568
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x00024370 File Offset: 0x00022570
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Func<JsonSchemaExporterContext, JsonNode, JsonNode> TransformSchemaNode { [return: Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }
	}
}
