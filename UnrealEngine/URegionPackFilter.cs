using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200107C RID: 4220
	[UnrealObjectPath("/Script/Engine.RegionPackFilter")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class URegionPackFilter : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F028 RID: 61480 RVA: 0x00163FC2 File Offset: 0x001621C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URegionPackFilter._ClassPtr;
		}

		// Token: 0x0600F029 RID: 61481 RVA: 0x00163FCE File Offset: 0x001621CE
		static URegionPackFilter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RegionPackFilter");
		}

		// Token: 0x0600F02A RID: 61482 RVA: 0x00163FDC File Offset: 0x001621DC
		protected URegionPackFilter() : this(BuiltinUtils.AllocNativeUObject(URegionPackFilter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F02B RID: 61483 RVA: 0x00164004 File Offset: 0x00162204
		protected URegionPackFilter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040081E6 RID: 33254
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RegionPackFilter";

		// Token: 0x040081E7 RID: 33255
		private static IntPtr _ClassPtr;

		// Token: 0x040081E8 RID: 33256
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
