using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200066C RID: 1644
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorClampSpatially")]
	[UnrealStructLayout(128, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FRigUnit_MathVectorClampSpatially : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005795 RID: 22421 RVA: 0x0007E840 File Offset: 0x0007CA40
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorClampSpatially._ScriptStructPtr != 0) ? FRigUnit_MathVectorClampSpatially._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorClampSpatially", ref FRigUnit_MathVectorClampSpatially._ScriptStructPtr);
		}

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x06005796 RID: 22422 RVA: 0x0007E864 File Offset: 0x0007CA64
		// (set) Token: 0x06005797 RID: 22423 RVA: 0x0007E878 File Offset: 0x0007CA78
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x06005798 RID: 22424 RVA: 0x0007E88D File Offset: 0x0007CA8D
		// (set) Token: 0x06005799 RID: 22425 RVA: 0x0007E8A1 File Offset: 0x0007CAA1
		public unsafe TEnumAsByte<EAxis> Axis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_Axis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_Axis) = value;
			}
		}

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x0600579A RID: 22426 RVA: 0x0007E8B6 File Offset: 0x0007CAB6
		// (set) Token: 0x0600579B RID: 22427 RVA: 0x0007E8CA File Offset: 0x0007CACA
		public unsafe TEnumAsByte<EControlRigClampSpatialMode> Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x0600579C RID: 22428 RVA: 0x0007E8DF File Offset: 0x0007CADF
		// (set) Token: 0x0600579D RID: 22429 RVA: 0x0007E8EF File Offset: 0x0007CAEF
		public unsafe float Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x0600579E RID: 22430 RVA: 0x0007E900 File Offset: 0x0007CB00
		// (set) Token: 0x0600579F RID: 22431 RVA: 0x0007E910 File Offset: 0x0007CB10
		public unsafe float Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x060057A0 RID: 22432 RVA: 0x0007E921 File Offset: 0x0007CB21
		// (set) Token: 0x060057A1 RID: 22433 RVA: 0x0007E935 File Offset: 0x0007CB35
		public unsafe FTransform Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x060057A2 RID: 22434 RVA: 0x0007E94A File Offset: 0x0007CB4A
		// (set) Token: 0x060057A3 RID: 22435 RVA: 0x0007E95A File Offset: 0x0007CB5A
		public unsafe bool bDrawDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_bDrawDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_bDrawDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x060057A4 RID: 22436 RVA: 0x0007E96B File Offset: 0x0007CB6B
		// (set) Token: 0x060057A5 RID: 22437 RVA: 0x0007E97F File Offset: 0x0007CB7F
		public unsafe FLinearColor DebugColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_DebugColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_DebugColor) = value;
			}
		}

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x060057A6 RID: 22438 RVA: 0x0007E994 File Offset: 0x0007CB94
		// (set) Token: 0x060057A7 RID: 22439 RVA: 0x0007E9A4 File Offset: 0x0007CBA4
		public unsafe float DebugThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_DebugThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_DebugThickness) = value;
			}
		}

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x060057A8 RID: 22440 RVA: 0x0007E9B5 File Offset: 0x0007CBB5
		// (set) Token: 0x060057A9 RID: 22441 RVA: 0x0007E9C9 File Offset: 0x0007CBC9
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampSpatially.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060057AA RID: 22442 RVA: 0x0007E9DE File Offset: 0x0007CBDE
		public FRigUnit_MathVectorClampSpatially()
		{
		}

		// Token: 0x060057AB RID: 22443 RVA: 0x0007E9E8 File Offset: 0x0007CBE8
		public FRigUnit_MathVectorClampSpatially(FVector Value, TEnumAsByte<EAxis> Axis, TEnumAsByte<EControlRigClampSpatialMode> Type, float Minimum, float Maximum, FTransform Space, bool bDrawDebug, FLinearColor DebugColor, float DebugThickness, FVector Result)
		{
			this.Value = Value;
			this.Axis = Axis;
			this.Type = Type;
			this.Minimum = Minimum;
			this.Maximum = Maximum;
			this.Space = Space;
			this.bDrawDebug = bDrawDebug;
			this.DebugColor = DebugColor;
			this.DebugThickness = DebugThickness;
			this.Result = Result;
		}

		// Token: 0x060057AC RID: 22444 RVA: 0x0007EA48 File Offset: 0x0007CC48
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorClampSpatially.StaticStruct();
		}

		// Token: 0x060057AD RID: 22445 RVA: 0x0007EA54 File Offset: 0x0007CC54
		[NullableContext(2)]
		public FRigUnit_MathVectorClampSpatially(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060057AE RID: 22446 RVA: 0x0007EA5E File Offset: 0x0007CC5E
		public FRigUnit_MathVectorClampSpatially(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x0007EA69 File Offset: 0x0007CC69
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorClampSpatially(Pointer, false, true);
		}

		// Token: 0x060057B0 RID: 22448 RVA: 0x0007EA73 File Offset: 0x0007CC73
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorClampSpatially(Pointer, MemoryOwner);
		}

		// Token: 0x04002947 RID: 10567
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorClampSpatially";

		// Token: 0x04002948 RID: 10568
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002949 RID: 10569
		internal static int __PropertyOffset_Value;

		// Token: 0x0400294A RID: 10570
		internal static int __PropertyOffset_Axis;

		// Token: 0x0400294B RID: 10571
		internal static int __PropertyOffset_Type;

		// Token: 0x0400294C RID: 10572
		internal static int __PropertyOffset_Minimum;

		// Token: 0x0400294D RID: 10573
		internal static int __PropertyOffset_Maximum;

		// Token: 0x0400294E RID: 10574
		internal static int __PropertyOffset_Space;

		// Token: 0x0400294F RID: 10575
		internal static int __PropertyOffset_bDrawDebug;

		// Token: 0x04002950 RID: 10576
		internal static int __PropertyOffset_DebugColor;

		// Token: 0x04002951 RID: 10577
		internal static int __PropertyOffset_DebugThickness;

		// Token: 0x04002952 RID: 10578
		internal static int __PropertyOffset_Result;
	}
}
