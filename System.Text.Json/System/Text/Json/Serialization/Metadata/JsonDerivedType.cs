using System;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000B7 RID: 183
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct JsonDerivedType
	{
		// Token: 0x06000A1A RID: 2586 RVA: 0x0002B846 File Offset: 0x00029A46
		public JsonDerivedType(Type derivedType)
		{
			this.DerivedType = derivedType;
			this.TypeDiscriminator = null;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0002B856 File Offset: 0x00029A56
		public JsonDerivedType(Type derivedType, int typeDiscriminator)
		{
			this.DerivedType = derivedType;
			this.TypeDiscriminator = typeDiscriminator;
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0002B86B File Offset: 0x00029A6B
		public JsonDerivedType(Type derivedType, string typeDiscriminator)
		{
			this.DerivedType = derivedType;
			this.TypeDiscriminator = typeDiscriminator;
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0002B86B File Offset: 0x00029A6B
		internal JsonDerivedType(Type derivedType, object typeDiscriminator)
		{
			this.DerivedType = derivedType;
			this.TypeDiscriminator = typeDiscriminator;
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0002B87B File Offset: 0x00029A7B
		public Type DerivedType { get; }

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x0002B883 File Offset: 0x00029A83
		[Nullable(2)]
		public object TypeDiscriminator { [NullableContext(2)] get; }

		// Token: 0x06000A20 RID: 2592 RVA: 0x0002B88B File Offset: 0x00029A8B
		internal void Deconstruct(out Type derivedType, out object typeDiscriminator)
		{
			derivedType = this.DerivedType;
			typeDiscriminator = this.TypeDiscriminator;
		}
	}
}
