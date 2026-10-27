using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000593 RID: 1427
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugTransformMutableItemSpace")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FRigUnit_DebugTransformMutableItemSpace : FRigUnit_DebugBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004C79 RID: 19577 RVA: 0x00071268 File Offset: 0x0006F468
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugTransformMutableItemSpace._ScriptStructPtr != 0) ? FRigUnit_DebugTransformMutableItemSpace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugTransformMutableItemSpace", ref FRigUnit_DebugTransformMutableItemSpace._ScriptStructPtr);
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x06004C7A RID: 19578 RVA: 0x0007128C File Offset: 0x0006F48C
		// (set) Token: 0x06004C7B RID: 19579 RVA: 0x000712A0 File Offset: 0x0006F4A0
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutableItemSpace.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutableItemSpace.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06004C7C RID: 19580 RVA: 0x000712B5 File Offset: 0x0006F4B5
		// (set) Token: 0x06004C7D RID: 19581 RVA: 0x000712C5 File Offset: 0x0006F4C5
		public unsafe ERigUnitDebugTransformMode Mode
		{
			get
			{
				return (ERigUnitDebugTransformMode)(*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutableItemSpace.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutableItemSpace.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x06004C7E RID: 19582 RVA: 0x000712D6 File Offset: 0x0006F4D6
		// (set) Token: 0x06004C7F RID: 19583 RVA: 0x000712EA File Offset: 0x0006F4EA
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutableItemSpace.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutableItemSpace.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x06004C80 RID: 19584 RVA: 0x000712FF File Offset: 0x0006F4FF
		// (set) Token: 0x06004C81 RID: 19585 RVA: 0x0007130F File Offset: 0x0006F50F
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutableItemSpace.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutableItemSpace.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06004C82 RID: 19586 RVA: 0x00071320 File Offset: 0x0006F520
		// (set) Token: 0x06004C83 RID: 19587 RVA: 0x00071330 File Offset: 0x0006F530
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutableItemSpace.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutableItemSpace.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x06004C84 RID: 19588 RVA: 0x00071344 File Offset: 0x0006F544
		// (set) Token: 0x06004C85 RID: 19589 RVA: 0x00071387 File Offset: 0x0006F587
		public FRigElementKey Space
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._Space) == null)
				{
					result = (this._Space = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutableItemSpace.__PropertyOffset_Space, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutableItemSpace.__PropertyOffset_Space, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x06004C86 RID: 19590 RVA: 0x000713A8 File Offset: 0x0006F5A8
		// (set) Token: 0x06004C87 RID: 19591 RVA: 0x000713BC File Offset: 0x0006F5BC
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutableItemSpace.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutableItemSpace.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x06004C88 RID: 19592 RVA: 0x000713D1 File Offset: 0x0006F5D1
		// (set) Token: 0x06004C89 RID: 19593 RVA: 0x000713E1 File Offset: 0x0006F5E1
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutableItemSpace.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugTransformMutableItemSpace.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004C8A RID: 19594 RVA: 0x000713F2 File Offset: 0x0006F5F2
		public FRigUnit_DebugTransformMutableItemSpace()
		{
		}

		// Token: 0x06004C8B RID: 19595 RVA: 0x000713FC File Offset: 0x0006F5FC
		public FRigUnit_DebugTransformMutableItemSpace(FTransform Transform, ERigUnitDebugTransformMode Mode, FLinearColor Color, float Thickness, float Scale, FRigElementKey Space, FTransform WorldOffset, bool bEnabled, FControlRigExecuteContext ExecuteContext)
		{
			this.Transform = Transform;
			this.Mode = Mode;
			this.Color = Color;
			this.Thickness = Thickness;
			this.Scale = Scale;
			this.Space = Space;
			this.WorldOffset = WorldOffset;
			this.bEnabled = bEnabled;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004C8C RID: 19596 RVA: 0x00071454 File Offset: 0x0006F654
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugTransformMutableItemSpace.StaticStruct();
		}

		// Token: 0x06004C8D RID: 19597 RVA: 0x00071460 File Offset: 0x0006F660
		[NullableContext(2)]
		public FRigUnit_DebugTransformMutableItemSpace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004C8E RID: 19598 RVA: 0x0007146A File Offset: 0x0006F66A
		public FRigUnit_DebugTransformMutableItemSpace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004C8F RID: 19599 RVA: 0x00071475 File Offset: 0x0006F675
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugTransformMutableItemSpace(Pointer, false, true);
		}

		// Token: 0x06004C90 RID: 19600 RVA: 0x0007147F File Offset: 0x0006F67F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugTransformMutableItemSpace(Pointer, MemoryOwner);
		}

		// Token: 0x04002500 RID: 9472
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugTransformMutableItemSpace";

		// Token: 0x04002501 RID: 9473
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002502 RID: 9474
		internal static int __PropertyOffset_Transform;

		// Token: 0x04002503 RID: 9475
		internal static int __PropertyOffset_Mode;

		// Token: 0x04002504 RID: 9476
		internal static int __PropertyOffset_Color;

		// Token: 0x04002505 RID: 9477
		internal static int __PropertyOffset_Thickness;

		// Token: 0x04002506 RID: 9478
		internal static int __PropertyOffset_Scale;

		// Token: 0x04002507 RID: 9479
		internal static int __PropertyOffset_Space;

		// Token: 0x04002508 RID: 9480
		[Nullable(2)]
		private FRigElementKey _Space;

		// Token: 0x04002509 RID: 9481
		internal static int __PropertyOffset_WorldOffset;

		// Token: 0x0400250A RID: 9482
		internal static int __PropertyOffset_bEnabled;
	}
}
