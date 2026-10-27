using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DDE RID: 7646
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Entity_Coin")]
	[UnrealStructLayout(1272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1272)]
	public class AKSC_Entity_Coin : AKSC_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D390 RID: 119696 RVA: 0x002B281D File Offset: 0x002B0A1D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Entity_Coin._ClassPtr;
		}

		// Token: 0x0601D391 RID: 119697 RVA: 0x002B282C File Offset: 0x002B0A2C
		public AKSC_Entity_Coin() : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity_Coin.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D392 RID: 119698 RVA: 0x002B2854 File Offset: 0x002B0A54
		[NullableContext(1)]
		public AKSC_Entity_Coin(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity_Coin.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D393 RID: 119699 RVA: 0x002B2887 File Offset: 0x002B0A87
		static AKSC_Entity_Coin()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Entity_Coin");
		}

		// Token: 0x0601D394 RID: 119700 RVA: 0x002B2895 File Offset: 0x002B0A95
		protected AKSC_Entity_Coin(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FDBA RID: 64954
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Entity_Coin";

		// Token: 0x0400FDBB RID: 64955
		private static IntPtr _ClassPtr;

		// Token: 0x0400FDBC RID: 64956
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
