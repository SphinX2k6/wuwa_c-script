using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000890 RID: 2192
	[UnrealObjectPath("/Script/Engine.BakedBoneSplitLogicGroupEditInstance")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FBakedBoneSplitLogicGroupEditInstance : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060077DE RID: 30686 RVA: 0x000ABAE8 File Offset: 0x000A9CE8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedBoneSplitLogicGroupEditInstance._ScriptStructPtr != 0) ? FBakedBoneSplitLogicGroupEditInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedBoneSplitLogicGroupEditInstance", ref FBakedBoneSplitLogicGroupEditInstance._ScriptStructPtr);
		}

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x060077DF RID: 30687 RVA: 0x000ABB0C File Offset: 0x000A9D0C
		// (set) Token: 0x060077E0 RID: 30688 RVA: 0x000ABB20 File Offset: 0x000A9D20
		public unsafe FTransform InstanceTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroupEditInstance.__PropertyOffset_InstanceTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroupEditInstance.__PropertyOffset_InstanceTransform) = value;
			}
		}

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x060077E1 RID: 30689 RVA: 0x000ABB35 File Offset: 0x000A9D35
		// (set) Token: 0x060077E2 RID: 30690 RVA: 0x000ABB45 File Offset: 0x000A9D45
		public unsafe int InstanceAnimIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroupEditInstance.__PropertyOffset_InstanceAnimIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroupEditInstance.__PropertyOffset_InstanceAnimIndex) = value;
			}
		}

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x060077E3 RID: 30691 RVA: 0x000ABB56 File Offset: 0x000A9D56
		// (set) Token: 0x060077E4 RID: 30692 RVA: 0x000ABB66 File Offset: 0x000A9D66
		public unsafe float CurPlayTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroupEditInstance.__PropertyOffset_CurPlayTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroupEditInstance.__PropertyOffset_CurPlayTime) = value;
			}
		}

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x060077E5 RID: 30693 RVA: 0x000ABB77 File Offset: 0x000A9D77
		// (set) Token: 0x060077E6 RID: 30694 RVA: 0x000ABB87 File Offset: 0x000A9D87
		public unsafe bool IsLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroupEditInstance.__PropertyOffset_IsLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroupEditInstance.__PropertyOffset_IsLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x060077E7 RID: 30695 RVA: 0x000ABB98 File Offset: 0x000A9D98
		// (set) Token: 0x060077E8 RID: 30696 RVA: 0x000ABBA8 File Offset: 0x000A9DA8
		public unsafe int GlobalFrameRow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroupEditInstance.__PropertyOffset_GlobalFrameRow);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedBoneSplitLogicGroupEditInstance.__PropertyOffset_GlobalFrameRow) = value;
			}
		}

		// Token: 0x060077E9 RID: 30697 RVA: 0x000ABBB9 File Offset: 0x000A9DB9
		public FBakedBoneSplitLogicGroupEditInstance()
		{
		}

		// Token: 0x060077EA RID: 30698 RVA: 0x000ABBC1 File Offset: 0x000A9DC1
		public FBakedBoneSplitLogicGroupEditInstance(FTransform InstanceTransform, int InstanceAnimIndex, float CurPlayTime, bool IsLoop, int GlobalFrameRow)
		{
			this.InstanceTransform = InstanceTransform;
			this.InstanceAnimIndex = InstanceAnimIndex;
			this.CurPlayTime = CurPlayTime;
			this.IsLoop = IsLoop;
			this.GlobalFrameRow = GlobalFrameRow;
		}

		// Token: 0x060077EB RID: 30699 RVA: 0x000ABBEE File Offset: 0x000A9DEE
		protected override IntPtr GetUStructPtr()
		{
			return FBakedBoneSplitLogicGroupEditInstance.StaticStruct();
		}

		// Token: 0x060077EC RID: 30700 RVA: 0x000ABBFA File Offset: 0x000A9DFA
		[NullableContext(2)]
		public FBakedBoneSplitLogicGroupEditInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060077ED RID: 30701 RVA: 0x000ABC04 File Offset: 0x000A9E04
		public FBakedBoneSplitLogicGroupEditInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060077EE RID: 30702 RVA: 0x000ABC0F File Offset: 0x000A9E0F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedBoneSplitLogicGroupEditInstance(Pointer, false, true);
		}

		// Token: 0x060077EF RID: 30703 RVA: 0x000ABC19 File Offset: 0x000A9E19
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedBoneSplitLogicGroupEditInstance(Pointer, MemoryOwner);
		}

		// Token: 0x04003992 RID: 14738
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BakedBoneSplitLogicGroupEditInstance";

		// Token: 0x04003993 RID: 14739
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003994 RID: 14740
		internal static int __PropertyOffset_InstanceTransform;

		// Token: 0x04003995 RID: 14741
		internal static int __PropertyOffset_InstanceAnimIndex;

		// Token: 0x04003996 RID: 14742
		internal static int __PropertyOffset_CurPlayTime;

		// Token: 0x04003997 RID: 14743
		internal static int __PropertyOffset_IsLoop;

		// Token: 0x04003998 RID: 14744
		internal static int __PropertyOffset_GlobalFrameRow;
	}
}
