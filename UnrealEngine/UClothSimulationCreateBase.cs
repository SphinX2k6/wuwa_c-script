using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200093B RID: 2363
	[UnrealObjectPath("/Script/Engine.ClothSimulationCreateBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UClothSimulationCreateBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060085A2 RID: 34210 RVA: 0x000BE898 File Offset: 0x000BCA98
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClothSimulationCreateBase._ClassPtr;
		}

		// Token: 0x060085A3 RID: 34211 RVA: 0x000BE8A4 File Offset: 0x000BCAA4
		static UClothSimulationCreateBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ClothSimulationCreateBase");
		}

		// Token: 0x060085A4 RID: 34212 RVA: 0x000BE8B4 File Offset: 0x000BCAB4
		protected UClothSimulationCreateBase() : this(BuiltinUtils.AllocNativeUObject(UClothSimulationCreateBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060085A5 RID: 34213 RVA: 0x000BE8DC File Offset: 0x000BCADC
		protected UClothSimulationCreateBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003F96 RID: 16278
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ClothSimulationCreateBase";

		// Token: 0x04003F97 RID: 16279
		private static IntPtr _ClassPtr;

		// Token: 0x04003F98 RID: 16280
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
