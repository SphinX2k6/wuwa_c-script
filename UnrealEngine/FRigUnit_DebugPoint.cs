using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200058B RID: 1419
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugPoint")]
	[UnrealStructLayout(128, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FRigUnit_DebugPoint : FRigUnit_DebugBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004BC9 RID: 19401 RVA: 0x00070417 File Offset: 0x0006E617
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugPoint._ScriptStructPtr != 0) ? FRigUnit_DebugPoint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugPoint", ref FRigUnit_DebugPoint._ScriptStructPtr);
		}

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x06004BCA RID: 19402 RVA: 0x0007043B File Offset: 0x0006E63B
		// (set) Token: 0x06004BCB RID: 19403 RVA: 0x0007044F File Offset: 0x0006E64F
		public unsafe FVector Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugPoint.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugPoint.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x06004BCC RID: 19404 RVA: 0x00070464 File Offset: 0x0006E664
		// (set) Token: 0x06004BCD RID: 19405 RVA: 0x00070474 File Offset: 0x0006E674
		public unsafe ERigUnitDebugPointMode Mode
		{
			get
			{
				return (ERigUnitDebugPointMode)(*(base.NativePtr + (IntPtr)FRigUnit_DebugPoint.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugPoint.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x06004BCE RID: 19406 RVA: 0x00070485 File Offset: 0x0006E685
		// (set) Token: 0x06004BCF RID: 19407 RVA: 0x00070499 File Offset: 0x0006E699
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugPoint.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugPoint.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x06004BD0 RID: 19408 RVA: 0x000704AE File Offset: 0x0006E6AE
		// (set) Token: 0x06004BD1 RID: 19409 RVA: 0x000704BE File Offset: 0x0006E6BE
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugPoint.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugPoint.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x06004BD2 RID: 19410 RVA: 0x000704CF File Offset: 0x0006E6CF
		// (set) Token: 0x06004BD3 RID: 19411 RVA: 0x000704DF File Offset: 0x0006E6DF
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugPoint.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugPoint.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x06004BD4 RID: 19412 RVA: 0x000704F0 File Offset: 0x0006E6F0
		// (set) Token: 0x06004BD5 RID: 19413 RVA: 0x00070504 File Offset: 0x0006E704
		public unsafe FName Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugPoint.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugPoint.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x06004BD6 RID: 19414 RVA: 0x00070519 File Offset: 0x0006E719
		// (set) Token: 0x06004BD7 RID: 19415 RVA: 0x0007052D File Offset: 0x0006E72D
		public unsafe FTransform WorldOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugPoint.__PropertyOffset_WorldOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugPoint.__PropertyOffset_WorldOffset) = value;
			}
		}

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x06004BD8 RID: 19416 RVA: 0x00070542 File Offset: 0x0006E742
		// (set) Token: 0x06004BD9 RID: 19417 RVA: 0x00070552 File Offset: 0x0006E752
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DebugPoint.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DebugPoint.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004BDA RID: 19418 RVA: 0x00070563 File Offset: 0x0006E763
		public FRigUnit_DebugPoint()
		{
		}

		// Token: 0x06004BDB RID: 19419 RVA: 0x0007056C File Offset: 0x0006E76C
		public FRigUnit_DebugPoint(FVector Vector, ERigUnitDebugPointMode Mode, FLinearColor Color, float Scale, float Thickness, FName Space, FTransform WorldOffset, bool bEnabled)
		{
			this.Vector = Vector;
			this.Mode = Mode;
			this.Color = Color;
			this.Scale = Scale;
			this.Thickness = Thickness;
			this.Space = Space;
			this.WorldOffset = WorldOffset;
			this.bEnabled = bEnabled;
		}

		// Token: 0x06004BDC RID: 19420 RVA: 0x000705BC File Offset: 0x0006E7BC
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugPoint.StaticStruct();
		}

		// Token: 0x06004BDD RID: 19421 RVA: 0x000705C8 File Offset: 0x0006E7C8
		[NullableContext(2)]
		public FRigUnit_DebugPoint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004BDE RID: 19422 RVA: 0x000705D2 File Offset: 0x0006E7D2
		public FRigUnit_DebugPoint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004BDF RID: 19423 RVA: 0x000705DD File Offset: 0x0006E7DD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugPoint(Pointer, false, true);
		}

		// Token: 0x06004BE0 RID: 19424 RVA: 0x000705E7 File Offset: 0x0006E7E7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugPoint(Pointer, MemoryOwner);
		}

		// Token: 0x040024B4 RID: 9396
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugPoint";

		// Token: 0x040024B5 RID: 9397
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040024B6 RID: 9398
		internal static int __PropertyOffset_Vector;

		// Token: 0x040024B7 RID: 9399
		internal static int __PropertyOffset_Mode;

		// Token: 0x040024B8 RID: 9400
		internal static int __PropertyOffset_Color;

		// Token: 0x040024B9 RID: 9401
		internal static int __PropertyOffset_Scale;

		// Token: 0x040024BA RID: 9402
		internal static int __PropertyOffset_Thickness;

		// Token: 0x040024BB RID: 9403
		internal static int __PropertyOffset_Space;

		// Token: 0x040024BC RID: 9404
		internal static int __PropertyOffset_WorldOffset;

		// Token: 0x040024BD RID: 9405
		internal static int __PropertyOffset_bEnabled;
	}
}
