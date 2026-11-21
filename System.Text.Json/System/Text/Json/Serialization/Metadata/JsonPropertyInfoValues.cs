using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000DA RID: 218
	[NullableContext(1)]
	[Nullable(0)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class JsonPropertyInfoValues<[Nullable(2)] T>
	{
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x0002F820 File Offset: 0x0002DA20
		// (set) Token: 0x06000B9F RID: 2975 RVA: 0x0002F828 File Offset: 0x0002DA28
		public bool IsProperty { get; set; }

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x0002F831 File Offset: 0x0002DA31
		// (set) Token: 0x06000BA1 RID: 2977 RVA: 0x0002F839 File Offset: 0x0002DA39
		public bool IsPublic { get; set; }

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x0002F842 File Offset: 0x0002DA42
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x0002F84A File Offset: 0x0002DA4A
		public bool IsVirtual { get; set; }

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x0002F853 File Offset: 0x0002DA53
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x0002F85B File Offset: 0x0002DA5B
		public Type DeclaringType { get; set; }

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x0002F864 File Offset: 0x0002DA64
		// (set) Token: 0x06000BA7 RID: 2983 RVA: 0x0002F86C File Offset: 0x0002DA6C
		public JsonTypeInfo PropertyTypeInfo { get; set; }

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x0002F875 File Offset: 0x0002DA75
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x0002F87D File Offset: 0x0002DA7D
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public JsonConverter<T> Converter { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x0002F886 File Offset: 0x0002DA86
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x0002F88E File Offset: 0x0002DA8E
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		public Func<object, T> Getter { [return: Nullable(new byte[]
		{
			2,
			1,
			2
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			2
		})] set; }

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x0002F897 File Offset: 0x0002DA97
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x0002F89F File Offset: 0x0002DA9F
		[Nullable(new byte[]
		{
			2,
			1,
			2
		})]
		public Action<object, T> Setter { [return: Nullable(new byte[]
		{
			2,
			1,
			2
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			2
		})] set; }

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x0002F8A8 File Offset: 0x0002DAA8
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x0002F8B0 File Offset: 0x0002DAB0
		public JsonIgnoreCondition? IgnoreCondition { get; set; }

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x0002F8B9 File Offset: 0x0002DAB9
		// (set) Token: 0x06000BB1 RID: 2993 RVA: 0x0002F8C1 File Offset: 0x0002DAC1
		public bool HasJsonInclude { get; set; }

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x0002F8CA File Offset: 0x0002DACA
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x0002F8D2 File Offset: 0x0002DAD2
		public bool IsExtensionData { get; set; }

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x0002F8DB File Offset: 0x0002DADB
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x0002F8E3 File Offset: 0x0002DAE3
		public JsonNumberHandling? NumberHandling { get; set; }

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x0002F8EC File Offset: 0x0002DAEC
		// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x0002F8F4 File Offset: 0x0002DAF4
		public string PropertyName { get; set; }

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x0002F8FD File Offset: 0x0002DAFD
		// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x0002F905 File Offset: 0x0002DB05
		[Nullable(2)]
		public string JsonPropertyName { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x0002F90E File Offset: 0x0002DB0E
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x0002F916 File Offset: 0x0002DB16
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<ICustomAttributeProvider> AttributeProviderFactory { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
