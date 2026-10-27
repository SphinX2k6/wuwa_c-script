using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006FD RID: 1789
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_VisualDebugTransformItemSpace")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FRigUnit_VisualDebugTransformItemSpace : FRigUnit_DebugBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060060D0 RID: 24784 RVA: 0x0008AD6B File Offset: 0x00088F6B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_VisualDebugTransformItemSpace._ScriptStructPtr != 0) ? FRigUnit_VisualDebugTransformItemSpace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_VisualDebugTransformItemSpace", ref FRigUnit_VisualDebugTransformItemSpace._ScriptStructPtr);
		}

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x060060D1 RID: 24785 RVA: 0x0008AD8F File Offset: 0x00088F8F
		// (set) Token: 0x060060D2 RID: 24786 RVA: 0x0008ADA3 File Offset: 0x00088FA3
		public unsafe FTransform Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransformItemSpace.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransformItemSpace.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x060060D3 RID: 24787 RVA: 0x0008ADB8 File Offset: 0x00088FB8
		// (set) Token: 0x060060D4 RID: 24788 RVA: 0x0008ADC8 File Offset: 0x00088FC8
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransformItemSpace.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransformItemSpace.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x060060D5 RID: 24789 RVA: 0x0008ADD9 File Offset: 0x00088FD9
		// (set) Token: 0x060060D6 RID: 24790 RVA: 0x0008ADE9 File Offset: 0x00088FE9
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransformItemSpace.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransformItemSpace.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x060060D7 RID: 24791 RVA: 0x0008ADFA File Offset: 0x00088FFA
		// (set) Token: 0x060060D8 RID: 24792 RVA: 0x0008AE0A File Offset: 0x0008900A
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransformItemSpace.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransformItemSpace.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x060060D9 RID: 24793 RVA: 0x0008AE1C File Offset: 0x0008901C
		// (set) Token: 0x060060DA RID: 24794 RVA: 0x0008AE5F File Offset: 0x0008905F
		public FRigElementKey Space
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Space) == null)
				{
					result = (this._Space = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransformItemSpace.__PropertyOffset_Space, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_VisualDebugTransformItemSpace.__PropertyOffset_Space, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060060DB RID: 24795 RVA: 0x0008AE80 File Offset: 0x00089080
		public FRigUnit_VisualDebugTransformItemSpace()
		{
		}

		// Token: 0x060060DC RID: 24796 RVA: 0x0008AE88 File Offset: 0x00089088
		public FRigUnit_VisualDebugTransformItemSpace(FTransform Value, bool bEnabled, float Thickness, float Scale, FRigElementKey Space)
		{
			this.Value = Value;
			this.bEnabled = bEnabled;
			this.Thickness = Thickness;
			this.Scale = Scale;
			this.Space = Space;
		}

		// Token: 0x060060DD RID: 24797 RVA: 0x0008AEB5 File Offset: 0x000890B5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_VisualDebugTransformItemSpace.StaticStruct();
		}

		// Token: 0x060060DE RID: 24798 RVA: 0x0008AEC1 File Offset: 0x000890C1
		[NullableContext(2)]
		public FRigUnit_VisualDebugTransformItemSpace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060060DF RID: 24799 RVA: 0x0008AECB File Offset: 0x000890CB
		public FRigUnit_VisualDebugTransformItemSpace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060060E0 RID: 24800 RVA: 0x0008AED6 File Offset: 0x000890D6
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_VisualDebugTransformItemSpace(Pointer, false, true);
		}

		// Token: 0x060060E1 RID: 24801 RVA: 0x0008AEE0 File Offset: 0x000890E0
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_VisualDebugTransformItemSpace(Pointer, MemoryOwner);
		}

		// Token: 0x04002D47 RID: 11591
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_VisualDebugTransformItemSpace";

		// Token: 0x04002D48 RID: 11592
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D49 RID: 11593
		internal static int __PropertyOffset_Value;

		// Token: 0x04002D4A RID: 11594
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04002D4B RID: 11595
		internal static int __PropertyOffset_Thickness;

		// Token: 0x04002D4C RID: 11596
		internal static int __PropertyOffset_Scale;

		// Token: 0x04002D4D RID: 11597
		internal static int __PropertyOffset_Space;

		// Token: 0x04002D4E RID: 11598
		[Nullable(2)]
		private FRigElementKey _Space;
	}
}
