using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200055D RID: 1373
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSCSkillTableRow")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FKSCSkillTableRow : FKSCTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007D54 RID: 32084 RVA: 0x000B9F27 File Offset: 0x000B8127
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSCSkillTableRow._ScriptStructPtr != 0) ? FKSCSkillTableRow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSCSkillTableRow", ref FKSCSkillTableRow._ScriptStructPtr);
		}

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x06007D55 RID: 32085 RVA: 0x000B9F4B File Offset: 0x000B814B
		// (set) Token: 0x06007D56 RID: 32086 RVA: 0x000B9F5B File Offset: 0x000B815B
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

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x06007D57 RID: 32087 RVA: 0x000B9F6C File Offset: 0x000B816C
		// (set) Token: 0x06007D58 RID: 32088 RVA: 0x000B9F7C File Offset: 0x000B817C
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

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x06007D59 RID: 32089 RVA: 0x000B9F8D File Offset: 0x000B818D
		// (set) Token: 0x06007D5A RID: 32090 RVA: 0x000B9FA1 File Offset: 0x000B81A1
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

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x06007D5B RID: 32091 RVA: 0x000B9FB6 File Offset: 0x000B81B6
		// (set) Token: 0x06007D5C RID: 32092 RVA: 0x000B9FC6 File Offset: 0x000B81C6
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

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x06007D5D RID: 32093 RVA: 0x000B9FD7 File Offset: 0x000B81D7
		// (set) Token: 0x06007D5E RID: 32094 RVA: 0x000B9FE7 File Offset: 0x000B81E7
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

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x06007D5F RID: 32095 RVA: 0x000B9FF8 File Offset: 0x000B81F8
		// (set) Token: 0x06007D60 RID: 32096 RVA: 0x000BA008 File Offset: 0x000B8208
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

		// Token: 0x06007D61 RID: 32097 RVA: 0x000BA019 File Offset: 0x000B8219
		public FKSCSkillTableRow()
		{
		}

		// Token: 0x06007D62 RID: 32098 RVA: 0x000BA021 File Offset: 0x000B8221
		protected override IntPtr GetUStructPtr()
		{
			return FKSCSkillTableRow.StaticStruct();
		}

		// Token: 0x06007D63 RID: 32099 RVA: 0x000BA02D File Offset: 0x000B822D
		[NullableContext(2)]
		public FKSCSkillTableRow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007D64 RID: 32100 RVA: 0x000BA037 File Offset: 0x000B8237
		public FKSCSkillTableRow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007D65 RID: 32101 RVA: 0x000BA042 File Offset: 0x000B8242
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSCSkillTableRow(Pointer, false, true);
		}

		// Token: 0x06007D66 RID: 32102 RVA: 0x000BA04C File Offset: 0x000B824C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSCSkillTableRow(Pointer, MemoryOwner);
		}

		// Token: 0x040036A0 RID: 13984
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSCSkillTableRow";

		// Token: 0x040036A1 RID: 13985
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040036A2 RID: 13986
		internal static int __PropertyOffset_OperateType;

		// Token: 0x040036A3 RID: 13987
		internal static int __PropertyOffset_PressTime;

		// Token: 0x040036A4 RID: 13988
		internal static int __PropertyOffset_PsFeedbackId;

		// Token: 0x040036A5 RID: 13989
		internal static int __PropertyOffset_ChargeCueId;

		// Token: 0x040036A6 RID: 13990
		internal static int __PropertyOffset_ChargeFullCueId;

		// Token: 0x040036A7 RID: 13991
		internal static int __PropertyOffset_SkillId;
	}
}
