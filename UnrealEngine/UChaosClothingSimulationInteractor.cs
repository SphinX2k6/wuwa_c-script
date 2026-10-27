using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200043A RID: 1082
	[UnrealObjectPath("/Script/ChaosCloth.ChaosClothingSimulationInteractor")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UChaosClothingSimulationInteractor : UClothingSimulationInteractor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003A89 RID: 14985 RVA: 0x000587F6 File Offset: 0x000569F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UChaosClothingSimulationInteractor._ClassPtr;
		}

		// Token: 0x06003A8A RID: 14986 RVA: 0x00058804 File Offset: 0x00056A04
		public UChaosClothingSimulationInteractor() : this(BuiltinUtils.AllocNativeUObject(UChaosClothingSimulationInteractor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x0005882C File Offset: 0x00056A2C
		[NullableContext(1)]
		public UChaosClothingSimulationInteractor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UChaosClothingSimulationInteractor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x0005885F File Offset: 0x00056A5F
		static UChaosClothingSimulationInteractor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ChaosCloth.ChaosClothingSimulationInteractor");
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x0005886D File Offset: 0x00056A6D
		protected UChaosClothingSimulationInteractor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001AB0 RID: 6832
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ChaosCloth.ChaosClothingSimulationInteractor";

		// Token: 0x04001AB1 RID: 6833
		private static IntPtr _ClassPtr;

		// Token: 0x04001AB2 RID: 6834
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
