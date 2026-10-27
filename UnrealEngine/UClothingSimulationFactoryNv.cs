using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000497 RID: 1175
	[UnrealObjectPath("/Script/ClothingSystemRuntimeNv.ClothingSimulationFactoryNv")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UClothingSimulationFactoryNv : UClothingSimulationFactory, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003F50 RID: 16208 RVA: 0x0005F196 File Offset: 0x0005D396
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClothingSimulationFactoryNv._ClassPtr;
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x0005F1A4 File Offset: 0x0005D3A4
		public UClothingSimulationFactoryNv() : this(BuiltinUtils.AllocNativeUObject(UClothingSimulationFactoryNv.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x0005F1CC File Offset: 0x0005D3CC
		[NullableContext(1)]
		public UClothingSimulationFactoryNv(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UClothingSimulationFactoryNv.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x0005F1FF File Offset: 0x0005D3FF
		static UClothingSimulationFactoryNv()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ClothingSystemRuntimeNv.ClothingSimulationFactoryNv");
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x0005F20D File Offset: 0x0005D40D
		protected UClothingSimulationFactoryNv(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001DE5 RID: 7653
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ClothingSystemRuntimeNv.ClothingSimulationFactoryNv";

		// Token: 0x04001DE6 RID: 7654
		private static IntPtr _ClassPtr;

		// Token: 0x04001DE7 RID: 7655
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
