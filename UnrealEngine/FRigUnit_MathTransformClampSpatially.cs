using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000656 RID: 1622
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathTransformClampSpatially")]
	[UnrealStructLayout(208, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FRigUnit_MathTransformClampSpatially : FRigUnit_MathTransformBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600566E RID: 22126 RVA: 0x0007D310 File Offset: 0x0007B510
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathTransformClampSpatially._ScriptStructPtr != 0) ? FRigUnit_MathTransformClampSpatially._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathTransformClampSpatially", ref FRigUnit_MathTransformClampSpatially._ScriptStructPtr);
		}

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x0600566F RID: 22127 RVA: 0x0007D334 File Offset: 0x0007B534
		// (set) Token: 0x06005670 RID: 22128 RVA: 0x0007D348 File Offset: 0x0007B548
		public unsafe FTransform Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x06005671 RID: 22129 RVA: 0x0007D35D File Offset: 0x0007B55D
		// (set) Token: 0x06005672 RID: 22130 RVA: 0x0007D371 File Offset: 0x0007B571
		public unsafe TEnumAsByte<EAxis> Axis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_Axis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_Axis) = value;
			}
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x06005673 RID: 22131 RVA: 0x0007D386 File Offset: 0x0007B586
		// (set) Token: 0x06005674 RID: 22132 RVA: 0x0007D39A File Offset: 0x0007B59A
		public unsafe TEnumAsByte<EControlRigClampSpatialMode> Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x06005675 RID: 22133 RVA: 0x0007D3AF File Offset: 0x0007B5AF
		// (set) Token: 0x06005676 RID: 22134 RVA: 0x0007D3BF File Offset: 0x0007B5BF
		public unsafe float Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x06005677 RID: 22135 RVA: 0x0007D3D0 File Offset: 0x0007B5D0
		// (set) Token: 0x06005678 RID: 22136 RVA: 0x0007D3E0 File Offset: 0x0007B5E0
		public unsafe float Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x06005679 RID: 22137 RVA: 0x0007D3F1 File Offset: 0x0007B5F1
		// (set) Token: 0x0600567A RID: 22138 RVA: 0x0007D405 File Offset: 0x0007B605
		public unsafe FTransform Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x0600567B RID: 22139 RVA: 0x0007D41A File Offset: 0x0007B61A
		// (set) Token: 0x0600567C RID: 22140 RVA: 0x0007D42A File Offset: 0x0007B62A
		public unsafe bool bDrawDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_bDrawDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_bDrawDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x0600567D RID: 22141 RVA: 0x0007D43B File Offset: 0x0007B63B
		// (set) Token: 0x0600567E RID: 22142 RVA: 0x0007D44F File Offset: 0x0007B64F
		public unsafe FLinearColor DebugColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_DebugColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_DebugColor) = value;
			}
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x0600567F RID: 22143 RVA: 0x0007D464 File Offset: 0x0007B664
		// (set) Token: 0x06005680 RID: 22144 RVA: 0x0007D474 File Offset: 0x0007B674
		public unsafe float DebugThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_DebugThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_DebugThickness) = value;
			}
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x06005681 RID: 22145 RVA: 0x0007D485 File Offset: 0x0007B685
		// (set) Token: 0x06005682 RID: 22146 RVA: 0x0007D499 File Offset: 0x0007B699
		public unsafe FTransform Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformClampSpatially.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06005683 RID: 22147 RVA: 0x0007D4AE File Offset: 0x0007B6AE
		public FRigUnit_MathTransformClampSpatially()
		{
		}

		// Token: 0x06005684 RID: 22148 RVA: 0x0007D4B8 File Offset: 0x0007B6B8
		public FRigUnit_MathTransformClampSpatially(FTransform Value, TEnumAsByte<EAxis> Axis, TEnumAsByte<EControlRigClampSpatialMode> Type, float Minimum, float Maximum, FTransform Space, bool bDrawDebug, FLinearColor DebugColor, float DebugThickness, FTransform Result)
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

		// Token: 0x06005685 RID: 22149 RVA: 0x0007D518 File Offset: 0x0007B718
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathTransformClampSpatially.StaticStruct();
		}

		// Token: 0x06005686 RID: 22150 RVA: 0x0007D524 File Offset: 0x0007B724
		[NullableContext(2)]
		public FRigUnit_MathTransformClampSpatially(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005687 RID: 22151 RVA: 0x0007D52E File Offset: 0x0007B72E
		public FRigUnit_MathTransformClampSpatially(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005688 RID: 22152 RVA: 0x0007D539 File Offset: 0x0007B739
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathTransformClampSpatially(Pointer, false, true);
		}

		// Token: 0x06005689 RID: 22153 RVA: 0x0007D543 File Offset: 0x0007B743
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathTransformClampSpatially(Pointer, MemoryOwner);
		}

		// Token: 0x040028DB RID: 10459
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathTransformClampSpatially";

		// Token: 0x040028DC RID: 10460
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040028DD RID: 10461
		internal static int __PropertyOffset_Value;

		// Token: 0x040028DE RID: 10462
		internal static int __PropertyOffset_Axis;

		// Token: 0x040028DF RID: 10463
		internal static int __PropertyOffset_Type;

		// Token: 0x040028E0 RID: 10464
		internal static int __PropertyOffset_Minimum;

		// Token: 0x040028E1 RID: 10465
		internal static int __PropertyOffset_Maximum;

		// Token: 0x040028E2 RID: 10466
		internal static int __PropertyOffset_Space;

		// Token: 0x040028E3 RID: 10467
		internal static int __PropertyOffset_bDrawDebug;

		// Token: 0x040028E4 RID: 10468
		internal static int __PropertyOffset_DebugColor;

		// Token: 0x040028E5 RID: 10469
		internal static int __PropertyOffset_DebugThickness;

		// Token: 0x040028E6 RID: 10470
		internal static int __PropertyOffset_Result;
	}
}
