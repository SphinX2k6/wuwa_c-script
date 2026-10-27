using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E26 RID: 7718
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Responder_SwitchMoveStage")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Responder_SwitchMoveStage : UKSC_EventResponder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D6B7 RID: 120503 RVA: 0x002B74FA File Offset: 0x002B56FA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Responder_SwitchMoveStage._ClassPtr;
		}

		// Token: 0x0601D6B8 RID: 120504 RVA: 0x002B7508 File Offset: 0x002B5708
		public UKSC_Responder_SwitchMoveStage() : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_SwitchMoveStage.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D6B9 RID: 120505 RVA: 0x002B7530 File Offset: 0x002B5730
		[NullableContext(1)]
		public UKSC_Responder_SwitchMoveStage(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_SwitchMoveStage.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007699 RID: 30361
		// (get) Token: 0x0601D6BA RID: 120506 RVA: 0x002B7563 File Offset: 0x002B5763
		// (set) Token: 0x0601D6BB RID: 120507 RVA: 0x002B7573 File Offset: 0x002B5773
		public unsafe int StageIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Responder_SwitchMoveStage.__PropertyOffset_StageIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Responder_SwitchMoveStage.__PropertyOffset_StageIndex) = value;
			}
		}

		// Token: 0x0601D6BC RID: 120508 RVA: 0x002B7584 File Offset: 0x002B5784
		static UKSC_Responder_SwitchMoveStage()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Responder_SwitchMoveStage");
		}

		// Token: 0x0601D6BD RID: 120509 RVA: 0x002B7592 File Offset: 0x002B5792
		protected UKSC_Responder_SwitchMoveStage(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF40 RID: 65344
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Responder_SwitchMoveStage";

		// Token: 0x0400FF41 RID: 65345
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF42 RID: 65346
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF43 RID: 65347
		internal static int __PropertyOffset_StageIndex;
	}
}
