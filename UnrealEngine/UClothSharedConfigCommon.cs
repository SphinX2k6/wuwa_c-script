using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000485 RID: 1157
	[UnrealObjectPath("/Script/ClothingSystemRuntimeCommon.ClothSharedConfigCommon")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UClothSharedConfigCommon : UClothConfigCommon, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003E56 RID: 15958 RVA: 0x0005DCD5 File Offset: 0x0005BED5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClothSharedConfigCommon._ClassPtr;
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x0005DCE1 File Offset: 0x0005BEE1
		static UClothSharedConfigCommon()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ClothingSystemRuntimeCommon.ClothSharedConfigCommon");
		}

		// Token: 0x06003E58 RID: 15960 RVA: 0x0005DCF0 File Offset: 0x0005BEF0
		protected UClothSharedConfigCommon() : this(BuiltinUtils.AllocNativeUObject(UClothSharedConfigCommon.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003E59 RID: 15961 RVA: 0x0005DD18 File Offset: 0x0005BF18
		protected UClothSharedConfigCommon(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D59 RID: 7513
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ClothingSystemRuntimeCommon.ClothSharedConfigCommon";

		// Token: 0x04001D5A RID: 7514
		private static IntPtr _ClassPtr;

		// Token: 0x04001D5B RID: 7515
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
