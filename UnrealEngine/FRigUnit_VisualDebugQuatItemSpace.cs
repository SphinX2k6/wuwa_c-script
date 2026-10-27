using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006FB RID: 1787
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_VisualDebugQuatItemSpace")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_VisualDebugQuatItemSpace : FRigUnit_DebugBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060060AC RID: 24748 RVA: 0x0008AAAA File Offset: 0x00088CAA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_VisualDebugQuatItemSpace._ScriptStructPtr != 0) ? FRigUnit_VisualDebugQuatItemSpace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_VisualDebugQuatItemSpace", ref FRigUnit_VisualDebugQuatItemSpace._ScriptStructPtr);
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x060060AD RID: 24749 RVA: 0x0008AACE File Offset: 0x00088CCE
		// (set) Token: 0x060060AE RID: 24750 RVA: 0x0008AAE2 File Offset: 0x00088CE2
		public unsafe FQuat Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuatItemSpace.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuatItemSpace.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x060060AF RID: 24751 RVA: 0x0008AAF7 File Offset: 0x00088CF7
		// (set) Token: 0x060060B0 RID: 24752 RVA: 0x0008AB07 File Offset: 0x00088D07
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuatItemSpace.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuatItemSpace.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x060060B1 RID: 24753 RVA: 0x0008AB18 File Offset: 0x00088D18
		// (set) Token: 0x060060B2 RID: 24754 RVA: 0x0008AB28 File Offset: 0x00088D28
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuatItemSpace.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuatItemSpace.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x060060B3 RID: 24755 RVA: 0x0008AB39 File Offset: 0x00088D39
		// (set) Token: 0x060060B4 RID: 24756 RVA: 0x0008AB49 File Offset: 0x00088D49
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuatItemSpace.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuatItemSpace.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x060060B5 RID: 24757 RVA: 0x0008AB5C File Offset: 0x00088D5C
		// (set) Token: 0x060060B6 RID: 24758 RVA: 0x0008AB9F File Offset: 0x00088D9F
		public FRigElementKey Space
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Space) == null)
				{
					result = (this._Space = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuatItemSpace.__PropertyOffset_Space, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_VisualDebugQuatItemSpace.__PropertyOffset_Space, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060060B7 RID: 24759 RVA: 0x0008ABC0 File Offset: 0x00088DC0
		public FRigUnit_VisualDebugQuatItemSpace()
		{
		}

		// Token: 0x060060B8 RID: 24760 RVA: 0x0008ABC8 File Offset: 0x00088DC8
		public FRigUnit_VisualDebugQuatItemSpace(FQuat Value, bool bEnabled, float Thickness, float Scale, FRigElementKey Space)
		{
			this.Value = Value;
			this.bEnabled = bEnabled;
			this.Thickness = Thickness;
			this.Scale = Scale;
			this.Space = Space;
		}

		// Token: 0x060060B9 RID: 24761 RVA: 0x0008ABF5 File Offset: 0x00088DF5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_VisualDebugQuatItemSpace.StaticStruct();
		}

		// Token: 0x060060BA RID: 24762 RVA: 0x0008AC01 File Offset: 0x00088E01
		[NullableContext(2)]
		public FRigUnit_VisualDebugQuatItemSpace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060060BB RID: 24763 RVA: 0x0008AC0B File Offset: 0x00088E0B
		public FRigUnit_VisualDebugQuatItemSpace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060060BC RID: 24764 RVA: 0x0008AC16 File Offset: 0x00088E16
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_VisualDebugQuatItemSpace(Pointer, false, true);
		}

		// Token: 0x060060BD RID: 24765 RVA: 0x0008AC20 File Offset: 0x00088E20
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_VisualDebugQuatItemSpace(Pointer, MemoryOwner);
		}

		// Token: 0x04002D38 RID: 11576
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_VisualDebugQuatItemSpace";

		// Token: 0x04002D39 RID: 11577
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D3A RID: 11578
		internal static int __PropertyOffset_Value;

		// Token: 0x04002D3B RID: 11579
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04002D3C RID: 11580
		internal static int __PropertyOffset_Thickness;

		// Token: 0x04002D3D RID: 11581
		internal static int __PropertyOffset_Scale;

		// Token: 0x04002D3E RID: 11582
		internal static int __PropertyOffset_Space;

		// Token: 0x04002D3F RID: 11583
		[Nullable(2)]
		private FRigElementKey _Space;
	}
}
