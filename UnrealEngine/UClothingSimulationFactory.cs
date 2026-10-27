using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000490 RID: 1168
	[UnrealObjectPath("/Script/ClothingSystemRuntimeInterface.ClothingSimulationFactory")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UClothingSimulationFactory : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003EB6 RID: 16054 RVA: 0x0005E4B1 File Offset: 0x0005C6B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClothingSimulationFactory._ClassPtr;
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x0005E4BD File Offset: 0x0005C6BD
		static UClothingSimulationFactory()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ClothingSystemRuntimeInterface.ClothingSimulationFactory");
		}

		// Token: 0x06003EB8 RID: 16056 RVA: 0x0005E4CC File Offset: 0x0005C6CC
		protected UClothingSimulationFactory() : this(BuiltinUtils.AllocNativeUObject(UClothingSimulationFactory.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003EB9 RID: 16057 RVA: 0x0005E4F4 File Offset: 0x0005C6F4
		protected UClothingSimulationFactory(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D93 RID: 7571
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ClothingSystemRuntimeInterface.ClothingSimulationFactory";

		// Token: 0x04001D94 RID: 7572
		private static IntPtr _ClassPtr;

		// Token: 0x04001D95 RID: 7573
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
