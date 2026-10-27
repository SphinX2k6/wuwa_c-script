using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000480 RID: 1152
	[UnrealObjectPath("/Script/ClothingSystemRuntimeCommon.ClothingAssetCustomData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UClothingAssetCustomData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003E01 RID: 15873 RVA: 0x0005D34D File Offset: 0x0005B54D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClothingAssetCustomData._ClassPtr;
		}

		// Token: 0x06003E02 RID: 15874 RVA: 0x0005D359 File Offset: 0x0005B559
		static UClothingAssetCustomData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ClothingSystemRuntimeCommon.ClothingAssetCustomData");
		}

		// Token: 0x06003E03 RID: 15875 RVA: 0x0005D368 File Offset: 0x0005B568
		protected UClothingAssetCustomData() : this(BuiltinUtils.AllocNativeUObject(UClothingAssetCustomData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003E04 RID: 15876 RVA: 0x0005D390 File Offset: 0x0005B590
		protected UClothingAssetCustomData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D23 RID: 7459
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ClothingSystemRuntimeCommon.ClothingAssetCustomData";

		// Token: 0x04001D24 RID: 7460
		private static IntPtr _ClassPtr;

		// Token: 0x04001D25 RID: 7461
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
