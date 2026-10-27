using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200048E RID: 1166
	[UnrealObjectPath("/Script/ClothingSystemRuntimeInterface.ClothConfigBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UClothConfigBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003EAA RID: 16042 RVA: 0x0005E3C5 File Offset: 0x0005C5C5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClothConfigBase._ClassPtr;
		}

		// Token: 0x06003EAB RID: 16043 RVA: 0x0005E3D1 File Offset: 0x0005C5D1
		static UClothConfigBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ClothingSystemRuntimeInterface.ClothConfigBase");
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x0005E3E0 File Offset: 0x0005C5E0
		protected UClothConfigBase() : this(BuiltinUtils.AllocNativeUObject(UClothConfigBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003EAD RID: 16045 RVA: 0x0005E408 File Offset: 0x0005C608
		protected UClothConfigBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D8B RID: 7563
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ClothingSystemRuntimeInterface.ClothConfigBase";

		// Token: 0x04001D8C RID: 7564
		private static IntPtr _ClassPtr;

		// Token: 0x04001D8D RID: 7565
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
