using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200082F RID: 2095
	[UnrealObjectPath("/Script/Engine.AnimNotify_PauseClothingSimulation")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UAnimNotify_PauseClothingSimulation : UAnimNotify, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060070D1 RID: 28881 RVA: 0x000A1BBE File Offset: 0x0009FDBE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimNotify_PauseClothingSimulation._ClassPtr;
		}

		// Token: 0x060070D2 RID: 28882 RVA: 0x000A1BCC File Offset: 0x0009FDCC
		public UAnimNotify_PauseClothingSimulation() : this(BuiltinUtils.AllocNativeUObject(UAnimNotify_PauseClothingSimulation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060070D3 RID: 28883 RVA: 0x000A1BF4 File Offset: 0x0009FDF4
		[NullableContext(1)]
		public UAnimNotify_PauseClothingSimulation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimNotify_PauseClothingSimulation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060070D4 RID: 28884 RVA: 0x000A1C27 File Offset: 0x0009FE27
		static UAnimNotify_PauseClothingSimulation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimNotify_PauseClothingSimulation");
		}

		// Token: 0x060070D5 RID: 28885 RVA: 0x000A1C35 File Offset: 0x0009FE35
		protected UAnimNotify_PauseClothingSimulation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003625 RID: 13861
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNotify_PauseClothingSimulation";

		// Token: 0x04003626 RID: 13862
		private static IntPtr _ClassPtr;

		// Token: 0x04003627 RID: 13863
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
