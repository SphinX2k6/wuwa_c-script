using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000CD RID: 205
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class JsonObjectInfoValues<[Nullable(2)] T>
	{
		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x0002DD8E File Offset: 0x0002BF8E
		// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x0002DD96 File Offset: 0x0002BF96
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<T> ObjectCreator { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0002DD9F File Offset: 0x0002BF9F
		// (set) Token: 0x06000AD9 RID: 2777 RVA: 0x0002DDA7 File Offset: 0x0002BFA7
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public Func<object[], T> ObjectWithParameterizedConstructorCreator { [return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] set; }

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0002DDB0 File Offset: 0x0002BFB0
		// (set) Token: 0x06000ADB RID: 2779 RVA: 0x0002DDB8 File Offset: 0x0002BFB8
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public Func<JsonSerializerContext, JsonPropertyInfo[]> PropertyMetadataInitializer { [return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] set; }

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x0002DDC1 File Offset: 0x0002BFC1
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x0002DDC9 File Offset: 0x0002BFC9
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Func<JsonParameterInfoValues[]> ConstructorParameterMetadataInitializer { [return: Nullable(new byte[]
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

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x0002DDD2 File Offset: 0x0002BFD2
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x0002DDDA File Offset: 0x0002BFDA
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<ICustomAttributeProvider> ConstructorAttributeProviderFactory { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0002DDE3 File Offset: 0x0002BFE3
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x0002DDEB File Offset: 0x0002BFEB
		public JsonNumberHandling NumberHandling { get; set; }

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0002DDF4 File Offset: 0x0002BFF4
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x0002DDFC File Offset: 0x0002BFFC
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<Utf8JsonWriter, T> SerializeHandler { [return: Nullable(new byte[]
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
