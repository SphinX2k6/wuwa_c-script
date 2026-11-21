using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004D4 RID: 1236
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroNpcDataAsset")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroNpcDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007385 RID: 29573 RVA: 0x000A9657 File Offset: 0x000A7857
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroNpcDataAsset._ClassPtr;
		}

		// Token: 0x06007386 RID: 29574 RVA: 0x000A9664 File Offset: 0x000A7864
		public UKuroNpcDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroNpcDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007387 RID: 29575 RVA: 0x000A968C File Offset: 0x000A788C
		[NullableContext(1)]
		public UKuroNpcDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroNpcDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007388 RID: 29576 RVA: 0x000A96BF File Offset: 0x000A78BF
		static UKuroNpcDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroNpcDataAsset");
		}

		// Token: 0x06007389 RID: 29577 RVA: 0x000A96CD File Offset: 0x000A78CD
		protected UKuroNpcDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003180 RID: 12672
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroNpcDataAsset";

		// Token: 0x04003181 RID: 12673
		private static IntPtr _ClassPtr;

		// Token: 0x04003182 RID: 12674
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
