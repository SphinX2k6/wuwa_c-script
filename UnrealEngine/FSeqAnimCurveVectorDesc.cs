using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200270C RID: 9996
	[UnrealObjectPath("/Script/SequenceDialogue.SeqAnimCurveVectorDesc")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FSeqAnimCurveVectorDesc : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025101 RID: 151809 RVA: 0x0036DB84 File Offset: 0x0036BD84
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSeqAnimCurveVectorDesc._ScriptStructPtr != 0) ? FSeqAnimCurveVectorDesc._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.SeqAnimCurveVectorDesc", ref FSeqAnimCurveVectorDesc._ScriptStructPtr);
		}

		// Token: 0x17008F01 RID: 36609
		// (get) Token: 0x06025102 RID: 151810 RVA: 0x0036DBA8 File Offset: 0x0036BDA8
		// (set) Token: 0x06025103 RID: 151811 RVA: 0x0036DBBC File Offset: 0x0036BDBC
		public unsafe FName Group
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSeqAnimCurveVectorDesc.__PropertyOffset_Group);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSeqAnimCurveVectorDesc.__PropertyOffset_Group) = value;
			}
		}

		// Token: 0x17008F02 RID: 36610
		// (get) Token: 0x06025104 RID: 151812 RVA: 0x0036DBD1 File Offset: 0x0036BDD1
		// (set) Token: 0x06025105 RID: 151813 RVA: 0x0036DBE5 File Offset: 0x0036BDE5
		public unsafe FName DisplayName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSeqAnimCurveVectorDesc.__PropertyOffset_DisplayName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSeqAnimCurveVectorDesc.__PropertyOffset_DisplayName) = value;
			}
		}

		// Token: 0x17008F03 RID: 36611
		// (get) Token: 0x06025106 RID: 151814 RVA: 0x0036DBFA File Offset: 0x0036BDFA
		// (set) Token: 0x06025107 RID: 151815 RVA: 0x0036DC0E File Offset: 0x0036BE0E
		public unsafe FName CurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSeqAnimCurveVectorDesc.__PropertyOffset_CurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSeqAnimCurveVectorDesc.__PropertyOffset_CurveName) = value;
			}
		}

		// Token: 0x17008F04 RID: 36612
		// (get) Token: 0x06025108 RID: 151816 RVA: 0x0036DC23 File Offset: 0x0036BE23
		// (set) Token: 0x06025109 RID: 151817 RVA: 0x0036DC37 File Offset: 0x0036BE37
		public unsafe FName GizmoBaseBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSeqAnimCurveVectorDesc.__PropertyOffset_GizmoBaseBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSeqAnimCurveVectorDesc.__PropertyOffset_GizmoBaseBone) = value;
			}
		}

		// Token: 0x17008F05 RID: 36613
		// (get) Token: 0x0602510A RID: 151818 RVA: 0x0036DC4C File Offset: 0x0036BE4C
		// (set) Token: 0x0602510B RID: 151819 RVA: 0x0036DC60 File Offset: 0x0036BE60
		public unsafe FVector GizmoOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSeqAnimCurveVectorDesc.__PropertyOffset_GizmoOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSeqAnimCurveVectorDesc.__PropertyOffset_GizmoOffset) = value;
			}
		}

		// Token: 0x17008F06 RID: 36614
		// (get) Token: 0x0602510C RID: 151820 RVA: 0x0036DC75 File Offset: 0x0036BE75
		// (set) Token: 0x0602510D RID: 151821 RVA: 0x0036DC85 File Offset: 0x0036BE85
		public unsafe bool EnableVirtualBoneRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSeqAnimCurveVectorDesc.__PropertyOffset_EnableVirtualBoneRot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSeqAnimCurveVectorDesc.__PropertyOffset_EnableVirtualBoneRot) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602510E RID: 151822 RVA: 0x0036DC96 File Offset: 0x0036BE96
		public FSeqAnimCurveVectorDesc()
		{
		}

		// Token: 0x0602510F RID: 151823 RVA: 0x0036DC9E File Offset: 0x0036BE9E
		public FSeqAnimCurveVectorDesc(FName Group, FName DisplayName, FName CurveName, FName GizmoBaseBone, FVector GizmoOffset, bool EnableVirtualBoneRot)
		{
			this.Group = Group;
			this.DisplayName = DisplayName;
			this.CurveName = CurveName;
			this.GizmoBaseBone = GizmoBaseBone;
			this.GizmoOffset = GizmoOffset;
			this.EnableVirtualBoneRot = EnableVirtualBoneRot;
		}

		// Token: 0x06025110 RID: 151824 RVA: 0x0036DCD3 File Offset: 0x0036BED3
		protected override IntPtr GetUStructPtr()
		{
			return FSeqAnimCurveVectorDesc.StaticStruct();
		}

		// Token: 0x06025111 RID: 151825 RVA: 0x0036DCDF File Offset: 0x0036BEDF
		[NullableContext(2)]
		public FSeqAnimCurveVectorDesc(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025112 RID: 151826 RVA: 0x0036DCE9 File Offset: 0x0036BEE9
		public FSeqAnimCurveVectorDesc(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025113 RID: 151827 RVA: 0x0036DCF4 File Offset: 0x0036BEF4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSeqAnimCurveVectorDesc(Pointer, false, true);
		}

		// Token: 0x06025114 RID: 151828 RVA: 0x0036DCFE File Offset: 0x0036BEFE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSeqAnimCurveVectorDesc(Pointer, MemoryOwner);
		}

		// Token: 0x04013F73 RID: 81779
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SequenceDialogue.SeqAnimCurveVectorDesc";

		// Token: 0x04013F74 RID: 81780
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013F75 RID: 81781
		internal static int __PropertyOffset_Group;

		// Token: 0x04013F76 RID: 81782
		internal static int __PropertyOffset_DisplayName;

		// Token: 0x04013F77 RID: 81783
		internal static int __PropertyOffset_CurveName;

		// Token: 0x04013F78 RID: 81784
		internal static int __PropertyOffset_GizmoBaseBone;

		// Token: 0x04013F79 RID: 81785
		internal static int __PropertyOffset_GizmoOffset;

		// Token: 0x04013F7A RID: 81786
		internal static int __PropertyOffset_EnableVirtualBoneRot;
	}
}
