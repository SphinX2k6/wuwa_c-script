using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DA6 RID: 7590
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Move_Stage")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_DA_Move_Stage : UKSC_DA_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D05B RID: 118875 RVA: 0x002AE4C3 File Offset: 0x002AC6C3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Move_Stage._ClassPtr;
		}

		// Token: 0x0601D05C RID: 118876 RVA: 0x002AE4D0 File Offset: 0x002AC6D0
		public UKSC_DA_Move_Stage() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Move_Stage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D05D RID: 118877 RVA: 0x002AE4F8 File Offset: 0x002AC6F8
		[NullableContext(1)]
		public UKSC_DA_Move_Stage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Move_Stage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007514 RID: 29972
		// (get) Token: 0x0601D05E RID: 118878 RVA: 0x002AE52B File Offset: 0x002AC72B
		// (set) Token: 0x0601D05F RID: 118879 RVA: 0x002AE53B File Offset: 0x002AC73B
		public unsafe bool IsSendStageEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move_Stage.__PropertyOffset_IsSendStageEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move_Stage.__PropertyOffset_IsSendStageEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007515 RID: 29973
		// (get) Token: 0x0601D060 RID: 118880 RVA: 0x002AE54C File Offset: 0x002AC74C
		// (set) Token: 0x0601D061 RID: 118881 RVA: 0x002AE55C File Offset: 0x002AC75C
		public unsafe bool FinishOnBattleEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Move_Stage.__PropertyOffset_FinishOnBattleEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Move_Stage.__PropertyOffset_FinishOnBattleEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D062 RID: 118882 RVA: 0x002AE56D File Offset: 0x002AC76D
		static UKSC_DA_Move_Stage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Move_Stage");
		}

		// Token: 0x0601D063 RID: 118883 RVA: 0x002AE57B File Offset: 0x002AC77B
		protected UKSC_DA_Move_Stage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC10 RID: 64528
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Move_Stage";

		// Token: 0x0400FC11 RID: 64529
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC12 RID: 64530
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC13 RID: 64531
		internal static int __PropertyOffset_IsSendStageEnd;

		// Token: 0x0400FC14 RID: 64532
		internal static int __PropertyOffset_FinishOnBattleEnd;
	}
}
