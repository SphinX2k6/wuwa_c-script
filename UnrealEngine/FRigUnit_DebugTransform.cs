using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200058F RID: 1423
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugTransform")]
	[UnrealStructLayout(176, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FRigUnit_DebugTransform : FRigUnit_DebugBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004C25 RID: 19493 RVA: 0x00070B7C File Offset: 0x0006ED7C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugTransform._ScriptStructPtr != 0) ? FRigUnit_DebugTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugTransform", ref FRigUnit_DebugTransform._ScriptStructPtr);
		}

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x06004C26 RID: 19494 RVA: 0x00070BA0 File Offset: 0x0006EDA0
		// (set) Token: 0x06004C27 RID: 19495 RVA: 0x00070BB4 File Offset: 0x0006EDB4
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransform.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransform.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x06004C28 RID: 19496 RVA: 0x00070BC9 File Offset: 0x0006EDC9
		// (set) Token: 0x06004C29 RID: 19497 RVA: 0x00070BD9 File Offset: 0x0006EDD9
		public unsafe ERigUnitDebugTransformMode Mode
		{
			get
			{
				return (ERigUnitDebugTransformMode)(*(base.NativePtr + (IntPtr)FRigUnit_DebugTransform.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransform.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x06004C2A RID: 19498 RVA: 0x00070BEA File Offset: 0x0006EDEA
		// (set) Token: 0x06004C2B RID: 19499 RVA: 0x00070BFE File Offset: 0x0006EDFE
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransform.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransform.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x06004C2C RID: 19500 RVA: 0x00070C13 File Offset: 0x0006EE13
		// (set) Token: 0x06004C2D RID: 19501 RVA: 0x00070C23 File Offset: 0x0006EE23
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransform.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransform.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x06004C2E RID: 19502 RVA: 0x00070C34 File Offset: 0x0006EE34
		// (set) Token: 0x06004C2F RID: 19503 RVA: 0x00070C44 File Offset: 0x0006EE44
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransform.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransform.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x06004C30 RID: 19504 RVA: 0x00070C55 File Offset: 0x0006EE55
		// (set) Token: 0x06004C31 RID: 19505 RVA: 0x00070C69 File Offset: 0x0006EE69
		public unsafe FName Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransform.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransform.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x06004C32 RID: 19506 RVA: 0x00070C7E File Offset: 0x0006EE7E
		// (set) Token: 0x06004C33 RID: 19507 RVA: 0x00070C92 File Offset: 0x0006EE92
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransform.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransform.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x06004C34 RID: 19508 RVA: 0x00070CA7 File Offset: 0x0006EEA7
		// (set) Token: 0x06004C35 RID: 19509 RVA: 0x00070CB7 File Offset: 0x0006EEB7
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransform.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransform.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004C36 RID: 19510 RVA: 0x00070CC8 File Offset: 0x0006EEC8
		public FRigUnit_DebugTransform()
		{
		}

		// Token: 0x06004C37 RID: 19511 RVA: 0x00070CD0 File Offset: 0x0006EED0
		public FRigUnit_DebugTransform(FTransform Transform, ERigUnitDebugTransformMode Mode, FLinearColor Color, float Thickness, float Scale, FName Space, FTransform WorldOffset, bool bEnabled)
		{
			this.Transform = Transform;
			this.Mode = Mode;
			this.Color = Color;
			this.Thickness = Thickness;
			this.Scale = Scale;
			this.Space = Space;
			this.WorldOffset = WorldOffset;
			this.bEnabled = bEnabled;
		}

		// Token: 0x06004C38 RID: 19512 RVA: 0x00070D20 File Offset: 0x0006EF20
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugTransform.StaticStruct();
		}

		// Token: 0x06004C39 RID: 19513 RVA: 0x00070D2C File Offset: 0x0006EF2C
		[NullableContext(2)]
		public FRigUnit_DebugTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004C3A RID: 19514 RVA: 0x00070D36 File Offset: 0x0006EF36
		public FRigUnit_DebugTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004C3B RID: 19515 RVA: 0x00070D41 File Offset: 0x0006EF41
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugTransform(Pointer, false, true);
		}

		// Token: 0x06004C3C RID: 19516 RVA: 0x00070D4B File Offset: 0x0006EF4B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugTransform(Pointer, MemoryOwner);
		}

		// Token: 0x040024DB RID: 9435
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugTransform";

		// Token: 0x040024DC RID: 9436
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040024DD RID: 9437
		internal static int __PropertyOffset_Transform;

		// Token: 0x040024DE RID: 9438
		internal static int __PropertyOffset_Mode;

		// Token: 0x040024DF RID: 9439
		internal static int __PropertyOffset_Color;

		// Token: 0x040024E0 RID: 9440
		internal static int __PropertyOffset_Thickness;

		// Token: 0x040024E1 RID: 9441
		internal static int __PropertyOffset_Scale;

		// Token: 0x040024E2 RID: 9442
		internal static int __PropertyOffset_Space;

		// Token: 0x040024E3 RID: 9443
		internal static int __PropertyOffset_WorldOffset;

		// Token: 0x040024E4 RID: 9444
		internal static int __PropertyOffset_bEnabled;
	}
}
