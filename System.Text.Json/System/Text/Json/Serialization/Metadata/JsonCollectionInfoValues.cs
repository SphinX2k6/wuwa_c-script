using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000CB RID: 203
	[NullableContext(2)]
	[Nullable(0)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class JsonCollectionInfoValues<TCollection>
	{
		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0002D388 File Offset: 0x0002B588
		// (set) Token: 0x06000A81 RID: 2689 RVA: 0x0002D390 File Offset: 0x0002B590
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<TCollection> ObjectCreator { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x0002D399 File Offset: 0x0002B599
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x0002D3A1 File Offset: 0x0002B5A1
		public JsonTypeInfo KeyInfo { get; set; }

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x0002D3AA File Offset: 0x0002B5AA
		// (set) Token: 0x06000A85 RID: 2693 RVA: 0x0002D3B2 File Offset: 0x0002B5B2
		[Nullable(1)]
		public JsonTypeInfo ElementInfo { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0002D3BB File Offset: 0x0002B5BB
		// (set) Token: 0x06000A87 RID: 2695 RVA: 0x0002D3C3 File Offset: 0x0002B5C3
		public JsonNumberHandling NumberHandling { get; set; }

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x0002D3CC File Offset: 0x0002B5CC
		// (set) Token: 0x06000A89 RID: 2697 RVA: 0x0002D3D4 File Offset: 0x0002B5D4
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<Utf8JsonWriter, TCollection> SerializeHandler { [return: Nullable(new byte[]
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
