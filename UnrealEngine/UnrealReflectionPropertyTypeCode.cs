using System;

namespace UnrealEngine
{
	// Token: 0x02000083 RID: 131
	[Flags]
	public enum UnrealReflectionPropertyTypeCode : ulong
	{
		// Token: 0x040001BF RID: 447
		Unusable = 0UL,
		// Token: 0x040001C0 RID: 448
		Bool = 1UL,
		// Token: 0x040001C1 RID: 449
		Sbyte = 2UL,
		// Token: 0x040001C2 RID: 450
		Byte = 4UL,
		// Token: 0x040001C3 RID: 451
		Short = 8UL,
		// Token: 0x040001C4 RID: 452
		UShort = 16UL,
		// Token: 0x040001C5 RID: 453
		Int = 32UL,
		// Token: 0x040001C6 RID: 454
		UInt = 64UL,
		// Token: 0x040001C7 RID: 455
		Long = 128UL,
		// Token: 0x040001C8 RID: 456
		ULong = 256UL,
		// Token: 0x040001C9 RID: 457
		Float = 512UL,
		// Token: 0x040001CA RID: 458
		Double = 1024UL,
		// Token: 0x040001CB RID: 459
		Numeric = 2046UL,
		// Token: 0x040001CC RID: 460
		String = 2048UL,
		// Token: 0x040001CD RID: 461
		Name = 4096UL,
		// Token: 0x040001CE RID: 462
		Text = 8192UL,
		// Token: 0x040001CF RID: 463
		Array = 16384UL,
		// Token: 0x040001D0 RID: 464
		Set = 32768UL,
		// Token: 0x040001D1 RID: 465
		Map = 65536UL,
		// Token: 0x040001D2 RID: 466
		Container = 114688UL,
		// Token: 0x040001D3 RID: 467
		Class = 131072UL,
		// Token: 0x040001D4 RID: 468
		SoftClass = 262144UL,
		// Token: 0x040001D5 RID: 469
		WeakObject = 524288UL,
		// Token: 0x040001D6 RID: 470
		SoftObject = 1048576UL,
		// Token: 0x040001D7 RID: 471
		LazyObject = 2097152UL,
		// Token: 0x040001D8 RID: 472
		FieldPath = 4194304UL,
		// Token: 0x040001D9 RID: 473
		Interface = 8388608UL,
		// Token: 0x040001DA RID: 474
		Delegate = 16777216UL,
		// Token: 0x040001DB RID: 475
		MulticastInlineDelegate = 33554432UL,
		// Token: 0x040001DC RID: 476
		MulticastSparseDelegate = 67108864UL,
		// Token: 0x040001DD RID: 477
		MulticastDelegate = 100663296UL,
		// Token: 0x040001DE RID: 478
		Delegates = 117440512UL,
		// Token: 0x040001DF RID: 479
		UnrealBlittableStruct = 134217728UL,
		// Token: 0x040001E0 RID: 480
		UnrealScriptStructProxy = 268435456UL,
		// Token: 0x040001E1 RID: 481
		UnrealProxyObject = 385884160UL,
		// Token: 0x040001E2 RID: 482
		CSharpBlittableTypes = 2047UL,
		// Token: 0x040001E3 RID: 483
		BlittableTypes = 134219775UL,
		// Token: 0x040001E4 RID: 484
		UnrealObject = 536870912UL,
		// Token: 0x040001E5 RID: 485
		EnumAsByte = 1073741824UL,
		// Token: 0x040001E6 RID: 486
		Subclass = 2147483648UL
	}
}
