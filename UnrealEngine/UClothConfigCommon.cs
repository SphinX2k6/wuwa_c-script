using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200047C RID: 1148
	[UnrealObjectPath("/Script/ClothingSystemRuntimeCommon.ClothConfigCommon")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UClothConfigCommon : UClothConfigBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003D90 RID: 15760 RVA: 0x0005C872 File Offset: 0x0005AA72
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClothConfigCommon._ClassPtr;
		}

		// Token: 0x06003D91 RID: 15761 RVA: 0x0005C87E File Offset: 0x0005AA7E
		static UClothConfigCommon()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ClothingSystemRuntimeCommon.ClothConfigCommon");
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x0005C88C File Offset: 0x0005AA8C
		protected UClothConfigCommon() : this(BuiltinUtils.AllocNativeUObject(UClothConfigCommon.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x0005C8B4 File Offset: 0x0005AAB4
		protected UClothConfigCommon(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001CE2 RID: 7394
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ClothingSystemRuntimeCommon.ClothConfigCommon";

		// Token: 0x04001CE3 RID: 7395
		private static IntPtr _ClassPtr;

		// Token: 0x04001CE4 RID: 7396
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
