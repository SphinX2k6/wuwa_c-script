using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006FE RID: 1790
	[UnrealObjectPath("/Script/ControlRig.RigUnit_VisualDebugVector")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_VisualDebugVector : FRigUnit_DebugBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060060E2 RID: 24802 RVA: 0x0008AEE9 File Offset: 0x000890E9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_VisualDebugVector._ScriptStructPtr != 0) ? FRigUnit_VisualDebugVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_VisualDebugVector", ref FRigUnit_VisualDebugVector._ScriptStructPtr);
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x060060E3 RID: 24803 RVA: 0x0008AF0D File Offset: 0x0008910D
		// (set) Token: 0x060060E4 RID: 24804 RVA: 0x0008AF21 File Offset: 0x00089121
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVector.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVector.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x060060E5 RID: 24805 RVA: 0x0008AF36 File Offset: 0x00089136
		// (set) Token: 0x060060E6 RID: 24806 RVA: 0x0008AF46 File Offset: 0x00089146
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVector.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVector.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x060060E7 RID: 24807 RVA: 0x0008AF57 File Offset: 0x00089157
		// (set) Token: 0x060060E8 RID: 24808 RVA: 0x0008AF67 File Offset: 0x00089167
		public unsafe ERigUnitVisualDebugPointMode Mode
		{
			get
			{
				return (ERigUnitVisualDebugPointMode)(*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVector.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVector.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x060060E9 RID: 24809 RVA: 0x0008AF78 File Offset: 0x00089178
		// (set) Token: 0x060060EA RID: 24810 RVA: 0x0008AF8C File Offset: 0x0008918C
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVector.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVector.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x060060EB RID: 24811 RVA: 0x0008AFA1 File Offset: 0x000891A1
		// (set) Token: 0x060060EC RID: 24812 RVA: 0x0008AFB1 File Offset: 0x000891B1
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVector.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVector.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x060060ED RID: 24813 RVA: 0x0008AFC2 File Offset: 0x000891C2
		// (set) Token: 0x060060EE RID: 24814 RVA: 0x0008AFD2 File Offset: 0x000891D2
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVector.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVector.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x060060EF RID: 24815 RVA: 0x0008AFE3 File Offset: 0x000891E3
		// (set) Token: 0x060060F0 RID: 24816 RVA: 0x0008AFF7 File Offset: 0x000891F7
		public unsafe FName BoneSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVector.__PropertyOffset_BoneSpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_VisualDebugVector.__PropertyOffset_BoneSpace) = value;
			}
		}

		// Token: 0x060060F1 RID: 24817 RVA: 0x0008B00C File Offset: 0x0008920C
		public FRigUnit_VisualDebugVector()
		{
		}

		// Token: 0x060060F2 RID: 24818 RVA: 0x0008B014 File Offset: 0x00089214
		public FRigUnit_VisualDebugVector(FVector Value, bool bEnabled, ERigUnitVisualDebugPointMode Mode, FLinearColor Color, float Thickness, float Scale, FName BoneSpace)
		{
			this.Value = Value;
			this.bEnabled = bEnabled;
			this.Mode = Mode;
			this.Color = Color;
			this.Thickness = Thickness;
			this.Scale = Scale;
			this.BoneSpace = BoneSpace;
		}

		// Token: 0x060060F3 RID: 24819 RVA: 0x0008B051 File Offset: 0x00089251
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_VisualDebugVector.StaticStruct();
		}

		// Token: 0x060060F4 RID: 24820 RVA: 0x0008B05D File Offset: 0x0008925D
		[NullableContext(2)]
		public FRigUnit_VisualDebugVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060060F5 RID: 24821 RVA: 0x0008B067 File Offset: 0x00089267
		public FRigUnit_VisualDebugVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060060F6 RID: 24822 RVA: 0x0008B072 File Offset: 0x00089272
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_VisualDebugVector(Pointer, false, true);
		}

		// Token: 0x060060F7 RID: 24823 RVA: 0x0008B07C File Offset: 0x0008927C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_VisualDebugVector(Pointer, MemoryOwner);
		}

		// Token: 0x04002D4F RID: 11599
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_VisualDebugVector";

		// Token: 0x04002D50 RID: 11600
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D51 RID: 11601
		internal static int __PropertyOffset_Value;

		// Token: 0x04002D52 RID: 11602
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04002D53 RID: 11603
		internal static int __PropertyOffset_Mode;

		// Token: 0x04002D54 RID: 11604
		internal static int __PropertyOffset_Color;

		// Token: 0x04002D55 RID: 11605
		internal static int __PropertyOffset_Thickness;

		// Token: 0x04002D56 RID: 11606
		internal static int __PropertyOffset_Scale;

		// Token: 0x04002D57 RID: 11607
		internal static int __PropertyOffset_BoneSpace;
	}
}
