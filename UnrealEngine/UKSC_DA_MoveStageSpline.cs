using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D9E RID: 7582
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_MoveStageSpline")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_DA_MoveStageSpline : UKSC_DA_Move_Stage, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D015 RID: 118805 RVA: 0x002ADEB1 File Offset: 0x002AC0B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_MoveStageSpline._ClassPtr;
		}

		// Token: 0x0601D016 RID: 118806 RVA: 0x002ADEC0 File Offset: 0x002AC0C0
		public UKSC_DA_MoveStageSpline() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_MoveStageSpline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D017 RID: 118807 RVA: 0x002ADEE8 File Offset: 0x002AC0E8
		[NullableContext(1)]
		public UKSC_DA_MoveStageSpline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_MoveStageSpline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D018 RID: 118808 RVA: 0x002ADF1B File Offset: 0x002AC11B
		static UKSC_DA_MoveStageSpline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_MoveStageSpline");
		}

		// Token: 0x0601D019 RID: 118809 RVA: 0x002ADF29 File Offset: 0x002AC129
		protected UKSC_DA_MoveStageSpline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBE8 RID: 64488
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_MoveStageSpline";

		// Token: 0x0400FBE9 RID: 64489
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBEA RID: 64490
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
