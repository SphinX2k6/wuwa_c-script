using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000498 RID: 1176
	[UnrealObjectPath("/Script/ClothingSystemRuntimeNv.ClothingSimulationInteractorNv")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UClothingSimulationInteractorNv : UClothingSimulationInteractor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003F55 RID: 16213 RVA: 0x0005F216 File Offset: 0x0005D416
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClothingSimulationInteractorNv._ClassPtr;
		}

		// Token: 0x06003F56 RID: 16214 RVA: 0x0005F224 File Offset: 0x0005D424
		public UClothingSimulationInteractorNv() : this(BuiltinUtils.AllocNativeUObject(UClothingSimulationInteractorNv.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003F57 RID: 16215 RVA: 0x0005F24C File Offset: 0x0005D44C
		[NullableContext(1)]
		public UClothingSimulationInteractorNv(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UClothingSimulationInteractorNv.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003F58 RID: 16216 RVA: 0x0005F27F File Offset: 0x0005D47F
		public void SetAnimDriveDamperStiffness(float InStiffness)
		{
			UClothingSimulationInteractorNv.__SetAnimDriveDamperStiffness_Internal(base.NativePtr, InStiffness);
		}

		// Token: 0x06003F59 RID: 16217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimDriveDamperStiffness_Internal(IntPtr @this, float InStiffness);

		// Token: 0x06003F5A RID: 16218 RVA: 0x0005F28D File Offset: 0x0005D48D
		static UClothingSimulationInteractorNv()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ClothingSystemRuntimeNv.ClothingSimulationInteractorNv");
		}

		// Token: 0x06003F5B RID: 16219 RVA: 0x0005F29B File Offset: 0x0005D49B
		protected UClothingSimulationInteractorNv(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001DE8 RID: 7656
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ClothingSystemRuntimeNv.ClothingSimulationInteractorNv";

		// Token: 0x04001DE9 RID: 7657
		private static IntPtr _ClassPtr;

		// Token: 0x04001DEA RID: 7658
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
