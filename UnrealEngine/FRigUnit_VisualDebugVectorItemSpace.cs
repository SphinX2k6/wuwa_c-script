using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006FF RID: 1791
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_VisualDebugVectorItemSpace")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_VisualDebugVectorItemSpace : FRigUnit_DebugBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060060F8 RID: 24824 RVA: 0x0008B085 File Offset: 0x00089285
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_VisualDebugVectorItemSpace._ScriptStructPtr != 0) ? FRigUnit_VisualDebugVectorItemSpace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_VisualDebugVectorItemSpace", ref FRigUnit_VisualDebugVectorItemSpace._ScriptStructPtr);
		}

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x060060F9 RID: 24825 RVA: 0x0008B0A9 File Offset: 0x000892A9
		// (set) Token: 0x060060FA RID: 24826 RVA: 0x0008B0BD File Offset: 0x000892BD
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVectorItemSpace.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVectorItemSpace.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x060060FB RID: 24827 RVA: 0x0008B0D2 File Offset: 0x000892D2
		// (set) Token: 0x060060FC RID: 24828 RVA: 0x0008B0E2 File Offset: 0x000892E2
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVectorItemSpace.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVectorItemSpace.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x060060FD RID: 24829 RVA: 0x0008B0F3 File Offset: 0x000892F3
		// (set) Token: 0x060060FE RID: 24830 RVA: 0x0008B103 File Offset: 0x00089303
		public unsafe ERigUnitVisualDebugPointMode Mode
		{
			get
			{
				return (ERigUnitVisualDebugPointMode)(*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVectorItemSpace.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVectorItemSpace.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x060060FF RID: 24831 RVA: 0x0008B114 File Offset: 0x00089314
		// (set) Token: 0x06006100 RID: 24832 RVA: 0x0008B128 File Offset: 0x00089328
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVectorItemSpace.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVectorItemSpace.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x06006101 RID: 24833 RVA: 0x0008B13D File Offset: 0x0008933D
		// (set) Token: 0x06006102 RID: 24834 RVA: 0x0008B14D File Offset: 0x0008934D
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVectorItemSpace.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVectorItemSpace.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x06006103 RID: 24835 RVA: 0x0008B15E File Offset: 0x0008935E
		// (set) Token: 0x06006104 RID: 24836 RVA: 0x0008B16E File Offset: 0x0008936E
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVectorItemSpace.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVectorItemSpace.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x06006105 RID: 24837 RVA: 0x0008B180 File Offset: 0x00089380
		// (set) Token: 0x06006106 RID: 24838 RVA: 0x0008B1C3 File Offset: 0x000893C3
		public FRigElementKey Space
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Space) == null)
				{
					result = (this._Space = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVectorItemSpace.__PropertyOffset_Space, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_VisualDebugVectorItemSpace.__PropertyOffset_Space, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06006107 RID: 24839 RVA: 0x0008B1E4 File Offset: 0x000893E4
		public FRigUnit_VisualDebugVectorItemSpace()
		{
		}

		// Token: 0x06006108 RID: 24840 RVA: 0x0008B1EC File Offset: 0x000893EC
		public FRigUnit_VisualDebugVectorItemSpace(FVector Value, bool bEnabled, ERigUnitVisualDebugPointMode Mode, FLinearColor Color, float Thickness, float Scale, FRigElementKey Space)
		{
			this.Value = Value;
			this.bEnabled = bEnabled;
			this.Mode = Mode;
			this.Color = Color;
			this.Thickness = Thickness;
			this.Scale = Scale;
			this.Space = Space;
		}

		// Token: 0x06006109 RID: 24841 RVA: 0x0008B229 File Offset: 0x00089429
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_VisualDebugVectorItemSpace.StaticStruct();
		}

		// Token: 0x0600610A RID: 24842 RVA: 0x0008B235 File Offset: 0x00089435
		[NullableContext(2)]
		public FRigUnit_VisualDebugVectorItemSpace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600610B RID: 24843 RVA: 0x0008B23F File Offset: 0x0008943F
		public FRigUnit_VisualDebugVectorItemSpace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600610C RID: 24844 RVA: 0x0008B24A File Offset: 0x0008944A
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_VisualDebugVectorItemSpace(Pointer, false, true);
		}

		// Token: 0x0600610D RID: 24845 RVA: 0x0008B254 File Offset: 0x00089454
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_VisualDebugVectorItemSpace(Pointer, MemoryOwner);
		}

		// Token: 0x04002D58 RID: 11608
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_VisualDebugVectorItemSpace";

		// Token: 0x04002D59 RID: 11609
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D5A RID: 11610
		internal static int __PropertyOffset_Value;

		// Token: 0x04002D5B RID: 11611
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04002D5C RID: 11612
		internal static int __PropertyOffset_Mode;

		// Token: 0x04002D5D RID: 11613
		internal static int __PropertyOffset_Color;

		// Token: 0x04002D5E RID: 11614
		internal static int __PropertyOffset_Thickness;

		// Token: 0x04002D5F RID: 11615
		internal static int __PropertyOffset_Scale;

		// Token: 0x04002D60 RID: 11616
		internal static int __PropertyOffset_Space;

		// Token: 0x04002D61 RID: 11617
		[Nullable(2)]
		private FRigElementKey _Space;
	}
}
