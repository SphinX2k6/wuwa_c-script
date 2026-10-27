using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001CF6 RID: 7414
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSCSkillTableRow")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FKSCSkillTableRow : FKSCTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C876 RID: 116854 RVA: 0x002A2E50 File Offset: 0x002A1050
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSCSkillTableRow._ScriptStructPtr != 0) ? FKSCSkillTableRow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSCSkillTableRow", ref FKSCSkillTableRow._ScriptStructPtr);
		}

		// Token: 0x170072F7 RID: 29431
		// (get) Token: 0x0601C877 RID: 116855 RVA: 0x002A2E74 File Offset: 0x002A1074
		// (set) Token: 0x0601C878 RID: 116856 RVA: 0x002A2E84 File Offset: 0x002A1084
		public unsafe EKSC_OperateType OperateType
		{
			get
			{
				return (EKSC_OperateType)(*(base.NativePtr + (IntPtr)FKSCSkillTableRow.__PropertyOffset_OperateType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCSkillTableRow.__PropertyOffset_OperateType) = (byte)value;
			}
		}

		// Token: 0x170072F8 RID: 29432
		// (get) Token: 0x0601C879 RID: 116857 RVA: 0x002A2E95 File Offset: 0x002A1095
		// (set) Token: 0x0601C87A RID: 116858 RVA: 0x002A2EA5 File Offset: 0x002A10A5
		public unsafe float PressTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCSkillTableRow.__PropertyOffset_PressTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCSkillTableRow.__PropertyOffset_PressTime) = value;
			}
		}

		// Token: 0x170072F9 RID: 29433
		// (get) Token: 0x0601C87B RID: 116859 RVA: 0x002A2EB6 File Offset: 0x002A10B6
		// (set) Token: 0x0601C87C RID: 116860 RVA: 0x002A2ECA File Offset: 0x002A10CA
		public unsafe string PsFeedbackId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKSCSkillTableRow.__PropertyOffset_PsFeedbackId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKSCSkillTableRow.__PropertyOffset_PsFeedbackId)), value);
			}
		}

		// Token: 0x170072FA RID: 29434
		// (get) Token: 0x0601C87D RID: 116861 RVA: 0x002A2EDF File Offset: 0x002A10DF
		// (set) Token: 0x0601C87E RID: 116862 RVA: 0x002A2EEF File Offset: 0x002A10EF
		public unsafe int ChargeCueId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCSkillTableRow.__PropertyOffset_ChargeCueId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCSkillTableRow.__PropertyOffset_ChargeCueId) = value;
			}
		}

		// Token: 0x170072FB RID: 29435
		// (get) Token: 0x0601C87F RID: 116863 RVA: 0x002A2F00 File Offset: 0x002A1100
		// (set) Token: 0x0601C880 RID: 116864 RVA: 0x002A2F10 File Offset: 0x002A1110
		public unsafe int ChargeFullCueId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCSkillTableRow.__PropertyOffset_ChargeFullCueId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCSkillTableRow.__PropertyOffset_ChargeFullCueId) = value;
			}
		}

		// Token: 0x170072FC RID: 29436
		// (get) Token: 0x0601C881 RID: 116865 RVA: 0x002A2F21 File Offset: 0x002A1121
		// (set) Token: 0x0601C882 RID: 116866 RVA: 0x002A2F31 File Offset: 0x002A1131
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCSkillTableRow.__PropertyOffset_SkillId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCSkillTableRow.__PropertyOffset_SkillId) = value;
			}
		}

		// Token: 0x0601C883 RID: 116867 RVA: 0x002A2F42 File Offset: 0x002A1142
		public FKSCSkillTableRow()
		{
		}

		// Token: 0x0601C884 RID: 116868 RVA: 0x002A2F4C File Offset: 0x002A114C
		public FKSCSkillTableRow(EKSC_OperateType OperateType, float PressTime, string PsFeedbackId, int ChargeCueId, int ChargeFullCueId, int SkillId, int Id, TSoftObjectPtr<UDataAsset> RuntimeDA)
		{
			this.OperateType = OperateType;
			this.PressTime = PressTime;
			this.PsFeedbackId = PsFeedbackId;
			this.ChargeCueId = ChargeCueId;
			this.ChargeFullCueId = ChargeFullCueId;
			this.SkillId = SkillId;
			base.Id = Id;
			base.RuntimeDA = RuntimeDA;
		}

		// Token: 0x0601C885 RID: 116869 RVA: 0x002A2F9C File Offset: 0x002A119C
		protected override IntPtr GetUStructPtr()
		{
			return FKSCSkillTableRow.StaticStruct();
		}

		// Token: 0x0601C886 RID: 116870 RVA: 0x002A2FA8 File Offset: 0x002A11A8
		[NullableContext(2)]
		public FKSCSkillTableRow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C887 RID: 116871 RVA: 0x002A2FB2 File Offset: 0x002A11B2
		public FKSCSkillTableRow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C888 RID: 116872 RVA: 0x002A2FBD File Offset: 0x002A11BD
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSCSkillTableRow(Pointer, false, true);
		}

		// Token: 0x0601C889 RID: 116873 RVA: 0x002A2FC7 File Offset: 0x002A11C7
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSCSkillTableRow(Pointer, MemoryOwner);
		}

		// Token: 0x0400F77A RID: 63354
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSCSkillTableRow";

		// Token: 0x0400F77B RID: 63355
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F77C RID: 63356
		internal static int __PropertyOffset_OperateType;

		// Token: 0x0400F77D RID: 63357
		internal static int __PropertyOffset_PressTime;

		// Token: 0x0400F77E RID: 63358
		internal static int __PropertyOffset_PsFeedbackId;

		// Token: 0x0400F77F RID: 63359
		internal static int __PropertyOffset_ChargeCueId;

		// Token: 0x0400F780 RID: 63360
		internal static int __PropertyOffset_ChargeFullCueId;

		// Token: 0x0400F781 RID: 63361
		internal static int __PropertyOffset_SkillId;
	}
}
