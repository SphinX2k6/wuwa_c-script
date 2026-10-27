using System;

namespace UnrealEngine
{
	// Token: 0x0200009E RID: 158
	[Flags]
	public enum UnrealReflectionPropertyTypeCode : ulong
	{
		// Token: 0x04000206 RID: 518
		Unusable = 0UL,
		// Token: 0x04000207 RID: 519
		Bool = 1UL,
		// Token: 0x04000208 RID: 520
		Sbyte = 2UL,
		// Token: 0x04000209 RID: 521
		Byte = 4UL,
		// Token: 0x0400020A RID: 522
		Short = 8UL,
		// Token: 0x0400020B RID: 523
		UShort = 16UL,
		// Token: 0x0400020C RID: 524
		Int = 32UL,
		// Token: 0x0400020D RID: 525
		UInt = 64UL,
		// Token: 0x0400020E RID: 526
		Long = 128UL,
		// Token: 0x0400020F RID: 527
		ULong = 256UL,
		// Token: 0x04000210 RID: 528
		Float = 512UL,
		// Token: 0x04000211 RID: 529
		Double = 1024UL,
		// Token: 0x04000212 RID: 530
		Numeric = 2046UL,
		// Token: 0x04000213 RID: 531
		String = 2048UL,
		// Token: 0x04000214 RID: 532
		Name = 4096UL,
		// Token: 0x04000215 RID: 533
		Text = 8192UL,
		// Token: 0x04000216 RID: 534
		Array = 16384UL,
		// Token: 0x04000217 RID: 535
		Set = 32768UL,
		// Token: 0x04000218 RID: 536
		Map = 65536UL,
		// Token: 0x04000219 RID: 537
		Container = 114688UL,
		// Token: 0x0400021A RID: 538
		Class = 131072UL,
		// Token: 0x0400021B RID: 539
		SoftClass = 262144UL,
		// Token: 0x0400021C RID: 540
		WeakObject = 524288UL,
		// Token: 0x0400021D RID: 541
		SoftObject = 1048576UL,
		// Token: 0x0400021E RID: 542
		LazyObject = 2097152UL,
		// Token: 0x0400021F RID: 543
		FieldPath = 4194304UL,
		// Token: 0x04000220 RID: 544
		Interface = 8388608UL,
		// Token: 0x04000221 RID: 545
		Delegate = 16777216UL,
		// Token: 0x04000222 RID: 546
		MulticastInlineDelegate = 33554432UL,
		// Token: 0x04000223 RID: 547
		MulticastSparseDelegate = 67108864UL,
		// Token: 0x04000224 RID: 548
		MulticastDelegate = 100663296UL,
		// Token: 0x04000225 RID: 549
		Delegates = 117440512UL,
		// Token: 0x04000226 RID: 550
		UnrealBlittableStruct = 134217728UL,
		// Token: 0x04000227 RID: 551
		UnrealScriptStructProxy = 268435456UL,
		// Token: 0x04000228 RID: 552
		UnrealProxyObject = 385884160UL,
		// Token: 0x04000229 RID: 553
		CSharpBlittableTypes = 2047UL,
		// Token: 0x0400022A RID: 554
		BlittableTypes = 134219775UL,
		// Token: 0x0400022B RID: 555
		UnrealObject = 536870912UL,
		// Token: 0x0400022C RID: 556
		EnumAsByte = 1073741824UL,
		// Token: 0x0400022D RID: 557
		Subclass = 2147483648UL
	}
}
