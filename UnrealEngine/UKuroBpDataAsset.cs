using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EAF RID: 7855
	[UnrealObjectPath("/Script/KuroUtility.KuroBpDataAsset")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class UKuroBpDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DD23 RID: 122147 RVA: 0x002C1D91 File Offset: 0x002BFF91
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBpDataAsset._ClassPtr;
		}

		// Token: 0x0601DD24 RID: 122148 RVA: 0x002C1D9D File Offset: 0x002BFF9D
		static UKuroBpDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroBpDataAsset");
		}

		// Token: 0x0601DD25 RID: 122149 RVA: 0x002C1DAC File Offset: 0x002BFFAC
		protected UKuroBpDataAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroBpDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DD26 RID: 122150 RVA: 0x002C1DD4 File Offset: 0x002BFFD4
		protected UKuroBpDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010298 RID: 66200
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroBpDataAsset";

		// Token: 0x04010299 RID: 66201
		private static IntPtr _ClassPtr;

		// Token: 0x0401029A RID: 66202
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
