using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006F7 RID: 1783
	[UnrealObjectPath("/Script/ControlRig.RigUnit_TwoBoneIKSimple_DebugSettings")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_TwoBoneIKSimple_DebugSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006066 RID: 24678 RVA: 0x0008A570 File Offset: 0x00088770
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_TwoBoneIKSimple_DebugSettings._ScriptStructPtr != 0) ? FRigUnit_TwoBoneIKSimple_DebugSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_TwoBoneIKSimple_DebugSettings", ref FRigUnit_TwoBoneIKSimple_DebugSettings._ScriptStructPtr);
		}

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x06006067 RID: 24679 RVA: 0x0008A594 File Offset: 0x00088794
		// (set) Token: 0x06006068 RID: 24680 RVA: 0x0008A5A4 File Offset: 0x000887A4
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple_DebugSettings.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple_DebugSettings.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x06006069 RID: 24681 RVA: 0x0008A5B5 File Offset: 0x000887B5
		// (set) Token: 0x0600606A RID: 24682 RVA: 0x0008A5C5 File Offset: 0x000887C5
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple_DebugSettings.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple_DebugSettings.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x0600606B RID: 24683 RVA: 0x0008A5D6 File Offset: 0x000887D6
		// (set) Token: 0x0600606C RID: 24684 RVA: 0x0008A5EA File Offset: 0x000887EA
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple_DebugSettings.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimple_DebugSettings.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x0600606D RID: 24685 RVA: 0x0008A5FF File Offset: 0x000887FF
		public FRigUnit_TwoBoneIKSimple_DebugSettings()
		{
		}

		// Token: 0x0600606E RID: 24686 RVA: 0x0008A607 File Offset: 0x00088807
		public FRigUnit_TwoBoneIKSimple_DebugSettings(bool bEnabled, float Scale, FTransform WorldOffset)
		{
			this.bEnabled = bEnabled;
			this.Scale = Scale;
			this.WorldOffset = WorldOffset;
		}

		// Token: 0x0600606F RID: 24687 RVA: 0x0008A624 File Offset: 0x00088824
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_TwoBoneIKSimple_DebugSettings.StaticStruct();
		}

		// Token: 0x06006070 RID: 24688 RVA: 0x0008A630 File Offset: 0x00088830
		[NullableContext(2)]
		public FRigUnit_TwoBoneIKSimple_DebugSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006071 RID: 24689 RVA: 0x0008A63A File Offset: 0x0008883A
		public FRigUnit_TwoBoneIKSimple_DebugSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006072 RID: 24690 RVA: 0x0008A645 File Offset: 0x00088845
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_TwoBoneIKSimple_DebugSettings(Pointer, false, true);
		}

		// Token: 0x06006073 RID: 24691 RVA: 0x0008A64F File Offset: 0x0008884F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_TwoBoneIKSimple_DebugSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04002D1C RID: 11548
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_TwoBoneIKSimple_DebugSettings";

		// Token: 0x04002D1D RID: 11549
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D1E RID: 11550
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04002D1F RID: 11551
		internal static int __PropertyOffset_Scale;

		// Token: 0x04002D20 RID: 11552
		internal static int __PropertyOffset_WorldOffset;
	}
}
