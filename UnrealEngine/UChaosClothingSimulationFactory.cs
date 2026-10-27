using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000439 RID: 1081
	[UnrealObjectPath("/Script/ChaosCloth.ChaosClothingSimulationFactory")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UChaosClothingSimulationFactory : UClothingSimulationFactory, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003A84 RID: 14980 RVA: 0x00058777 File Offset: 0x00056977
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UChaosClothingSimulationFactory._ClassPtr;
		}

		// Token: 0x06003A85 RID: 14981 RVA: 0x00058784 File Offset: 0x00056984
		public UChaosClothingSimulationFactory() : this(BuiltinUtils.AllocNativeUObject(UChaosClothingSimulationFactory.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003A86 RID: 14982 RVA: 0x000587AC File Offset: 0x000569AC
		[NullableContext(1)]
		public UChaosClothingSimulationFactory(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UChaosClothingSimulationFactory.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003A87 RID: 14983 RVA: 0x000587DF File Offset: 0x000569DF
		static UChaosClothingSimulationFactory()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ChaosCloth.ChaosClothingSimulationFactory");
		}

		// Token: 0x06003A88 RID: 14984 RVA: 0x000587ED File Offset: 0x000569ED
		protected UChaosClothingSimulationFactory(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001AAD RID: 6829
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ChaosCloth.ChaosClothingSimulationFactory";

		// Token: 0x04001AAE RID: 6830
		private static IntPtr _ClassPtr;

		// Token: 0x04001AAF RID: 6831
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
