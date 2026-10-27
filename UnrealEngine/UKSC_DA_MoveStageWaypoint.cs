using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D9F RID: 7583
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_MoveStageWaypoint")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_DA_MoveStageWaypoint : UKSC_DA_Move_Stage, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D01A RID: 118810 RVA: 0x002ADF32 File Offset: 0x002AC132
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_MoveStageWaypoint._ClassPtr;
		}

		// Token: 0x0601D01B RID: 118811 RVA: 0x002ADF40 File Offset: 0x002AC140
		public UKSC_DA_MoveStageWaypoint() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_MoveStageWaypoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D01C RID: 118812 RVA: 0x002ADF68 File Offset: 0x002AC168
		[NullableContext(1)]
		public UKSC_DA_MoveStageWaypoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_MoveStageWaypoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D01D RID: 118813 RVA: 0x002ADF9B File Offset: 0x002AC19B
		static UKSC_DA_MoveStageWaypoint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_MoveStageWaypoint");
		}

		// Token: 0x0601D01E RID: 118814 RVA: 0x002ADFA9 File Offset: 0x002AC1A9
		protected UKSC_DA_MoveStageWaypoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBEB RID: 64491
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_MoveStageWaypoint";

		// Token: 0x0400FBEC RID: 64492
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBED RID: 64493
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
