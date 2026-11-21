using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005CE RID: 1486
	[UnrealObjectPath("/Script/KuroUtility.KuroBpDataAsset")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class UKuroBpDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060083F7 RID: 33783 RVA: 0x000C4061 File Offset: 0x000C2261
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBpDataAsset._ClassPtr;
		}

		// Token: 0x060083F8 RID: 33784 RVA: 0x000C406D File Offset: 0x000C226D
		static UKuroBpDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroBpDataAsset");
		}

		// Token: 0x060083F9 RID: 33785 RVA: 0x000C407C File Offset: 0x000C227C
		protected UKuroBpDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroBpDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060083FA RID: 33786 RVA: 0x000C40A4 File Offset: 0x000C22A4
		protected UKuroBpDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040039B3 RID: 14771
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroBpDataAsset";

		// Token: 0x040039B4 RID: 14772
		private static IntPtr _ClassPtr;

		// Token: 0x040039B5 RID: 14773
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
