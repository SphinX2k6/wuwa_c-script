using System;
using System.Runtime.CompilerServices;

namespace System.Text.Json
{
	// Token: 0x0200000F RID: 15
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class JsonNamingPolicy
	{
		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00005292 File Offset: 0x00003492
		public static JsonNamingPolicy CamelCase { get; } = new JsonCamelCaseNamingPolicy();

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00005299 File Offset: 0x00003499
		public static JsonNamingPolicy SnakeCaseLower { get; } = new JsonSnakeCaseLowerNamingPolicy();

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001CA RID: 458 RVA: 0x000052A0 File Offset: 0x000034A0
		public static JsonNamingPolicy SnakeCaseUpper { get; } = new JsonSnakeCaseUpperNamingPolicy();

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001CB RID: 459 RVA: 0x000052A7 File Offset: 0x000034A7
		public static JsonNamingPolicy KebabCaseLower { get; } = new JsonKebabCaseLowerNamingPolicy();

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001CC RID: 460 RVA: 0x000052AE File Offset: 0x000034AE
		public static JsonNamingPolicy KebabCaseUpper { get; } = new JsonKebabCaseUpperNamingPolicy();

		// Token: 0x060001CD RID: 461
		public abstract string ConvertName(string name);
	}
}
