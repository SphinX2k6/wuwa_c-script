using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006FA RID: 1786
	[UnrealObjectPath("/Script/ControlRig.RigUnit_VisualDebugQuat")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_VisualDebugQuat : FRigUnit_DebugBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600609A RID: 24730 RVA: 0x0008A968 File Offset: 0x00088B68
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_VisualDebugQuat._ScriptStructPtr != 0) ? FRigUnit_VisualDebugQuat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_VisualDebugQuat", ref FRigUnit_VisualDebugQuat._ScriptStructPtr);
		}

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x0600609B RID: 24731 RVA: 0x0008A98C File Offset: 0x00088B8C
		// (set) Token: 0x0600609C RID: 24732 RVA: 0x0008A9A0 File Offset: 0x00088BA0
		public unsafe FQuat Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuat.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuat.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x0600609D RID: 24733 RVA: 0x0008A9B5 File Offset: 0x00088BB5
		// (set) Token: 0x0600609E RID: 24734 RVA: 0x0008A9C5 File Offset: 0x00088BC5
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuat.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuat.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x0600609F RID: 24735 RVA: 0x0008A9D6 File Offset: 0x00088BD6
		// (set) Token: 0x060060A0 RID: 24736 RVA: 0x0008A9E6 File Offset: 0x00088BE6
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuat.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuat.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x060060A1 RID: 24737 RVA: 0x0008A9F7 File Offset: 0x00088BF7
		// (set) Token: 0x060060A2 RID: 24738 RVA: 0x0008AA07 File Offset: 0x00088C07
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuat.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuat.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x060060A3 RID: 24739 RVA: 0x0008AA18 File Offset: 0x00088C18
		// (set) Token: 0x060060A4 RID: 24740 RVA: 0x0008AA2C File Offset: 0x00088C2C
		public unsafe FName BoneSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuat.__PropertyOffset_BoneSpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuat.__PropertyOffset_BoneSpace) = value;
			}
		}

		// Token: 0x060060A5 RID: 24741 RVA: 0x0008AA41 File Offset: 0x00088C41
		public FRigUnit_VisualDebugQuat()
		{
		}

		// Token: 0x060060A6 RID: 24742 RVA: 0x0008AA49 File Offset: 0x00088C49
		public FRigUnit_VisualDebugQuat(FQuat Value, bool bEnabled, float Thickness, float Scale, FName BoneSpace)
		{
			this.Value = Value;
			this.bEnabled = bEnabled;
			this.Thickness = Thickness;
			this.Scale = Scale;
			this.BoneSpace = BoneSpace;
		}

		// Token: 0x060060A7 RID: 24743 RVA: 0x0008AA76 File Offset: 0x00088C76
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_VisualDebugQuat.StaticStruct();
		}

		// Token: 0x060060A8 RID: 24744 RVA: 0x0008AA82 File Offset: 0x00088C82
		[NullableContext(2)]
		public FRigUnit_VisualDebugQuat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060060A9 RID: 24745 RVA: 0x0008AA8C File Offset: 0x00088C8C
		public FRigUnit_VisualDebugQuat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060060AA RID: 24746 RVA: 0x0008AA97 File Offset: 0x00088C97
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_VisualDebugQuat(Pointer, false, true);
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x0008AAA1 File Offset: 0x00088CA1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_VisualDebugQuat(Pointer, MemoryOwner);
		}

		// Token: 0x04002D31 RID: 11569
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_VisualDebugQuat";

		// Token: 0x04002D32 RID: 11570
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D33 RID: 11571
		internal static int __PropertyOffset_Value;

		// Token: 0x04002D34 RID: 11572
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04002D35 RID: 11573
		internal static int __PropertyOffset_Thickness;

		// Token: 0x04002D36 RID: 11574
		internal static int __PropertyOffset_Scale;

		// Token: 0x04002D37 RID: 11575
		internal static int __PropertyOffset_BoneSpace;
	}
}
