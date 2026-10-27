using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000685 RID: 1669
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorRemap")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FRigUnit_MathVectorRemap : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060058BF RID: 22719 RVA: 0x0007FC0F File Offset: 0x0007DE0F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorRemap._ScriptStructPtr != 0) ? FRigUnit_MathVectorRemap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorRemap", ref FRigUnit_MathVectorRemap._ScriptStructPtr);
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x060058C0 RID: 22720 RVA: 0x0007FC33 File Offset: 0x0007DE33
		// (set) Token: 0x060058C1 RID: 22721 RVA: 0x0007FC47 File Offset: 0x0007DE47
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorRemap.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorRemap.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x060058C2 RID: 22722 RVA: 0x0007FC5C File Offset: 0x0007DE5C
		// (set) Token: 0x060058C3 RID: 22723 RVA: 0x0007FC70 File Offset: 0x0007DE70
		public unsafe FVector SourceMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorRemap.__PropertyOffset_SourceMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorRemap.__PropertyOffset_SourceMinimum) = value;
			}
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x060058C4 RID: 22724 RVA: 0x0007FC85 File Offset: 0x0007DE85
		// (set) Token: 0x060058C5 RID: 22725 RVA: 0x0007FC99 File Offset: 0x0007DE99
		public unsafe FVector SourceMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorRemap.__PropertyOffset_SourceMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorRemap.__PropertyOffset_SourceMaximum) = value;
			}
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x060058C6 RID: 22726 RVA: 0x0007FCAE File Offset: 0x0007DEAE
		// (set) Token: 0x060058C7 RID: 22727 RVA: 0x0007FCC2 File Offset: 0x0007DEC2
		public unsafe FVector TargetMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorRemap.__PropertyOffset_TargetMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorRemap.__PropertyOffset_TargetMinimum) = value;
			}
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x060058C8 RID: 22728 RVA: 0x0007FCD7 File Offset: 0x0007DED7
		// (set) Token: 0x060058C9 RID: 22729 RVA: 0x0007FCEB File Offset: 0x0007DEEB
		public unsafe FVector TargetMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorRemap.__PropertyOffset_TargetMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorRemap.__PropertyOffset_TargetMaximum) = value;
			}
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x060058CA RID: 22730 RVA: 0x0007FD00 File Offset: 0x0007DF00
		// (set) Token: 0x060058CB RID: 22731 RVA: 0x0007FD10 File Offset: 0x0007DF10
		public unsafe bool bClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorRemap.__PropertyOffset_bClamp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorRemap.__PropertyOffset_bClamp) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x060058CC RID: 22732 RVA: 0x0007FD21 File Offset: 0x0007DF21
		// (set) Token: 0x060058CD RID: 22733 RVA: 0x0007FD35 File Offset: 0x0007DF35
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorRemap.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorRemap.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060058CE RID: 22734 RVA: 0x0007FD4A File Offset: 0x0007DF4A
		public FRigUnit_MathVectorRemap()
		{
		}

		// Token: 0x060058CF RID: 22735 RVA: 0x0007FD52 File Offset: 0x0007DF52
		public FRigUnit_MathVectorRemap(FVector Value, FVector SourceMinimum, FVector SourceMaximum, FVector TargetMinimum, FVector TargetMaximum, bool bClamp, FVector Result)
		{
			this.Value = Value;
			this.SourceMinimum = SourceMinimum;
			this.SourceMaximum = SourceMaximum;
			this.TargetMinimum = TargetMinimum;
			this.TargetMaximum = TargetMaximum;
			this.bClamp = bClamp;
			this.Result = Result;
		}

		// Token: 0x060058D0 RID: 22736 RVA: 0x0007FD8F File Offset: 0x0007DF8F
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorRemap.StaticStruct();
		}

		// Token: 0x060058D1 RID: 22737 RVA: 0x0007FD9B File Offset: 0x0007DF9B
		[NullableContext(2)]
		public FRigUnit_MathVectorRemap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060058D2 RID: 22738 RVA: 0x0007FDA5 File Offset: 0x0007DFA5
		public FRigUnit_MathVectorRemap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060058D3 RID: 22739 RVA: 0x0007FDB0 File Offset: 0x0007DFB0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorRemap(Pointer, false, true);
		}

		// Token: 0x060058D4 RID: 22740 RVA: 0x0007FDBA File Offset: 0x0007DFBA
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorRemap(Pointer, MemoryOwner);
		}

		// Token: 0x040029AB RID: 10667
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorRemap";

		// Token: 0x040029AC RID: 10668
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040029AD RID: 10669
		internal static int __PropertyOffset_Value;

		// Token: 0x040029AE RID: 10670
		internal static int __PropertyOffset_SourceMinimum;

		// Token: 0x040029AF RID: 10671
		internal static int __PropertyOffset_SourceMaximum;

		// Token: 0x040029B0 RID: 10672
		internal static int __PropertyOffset_TargetMinimum;

		// Token: 0x040029B1 RID: 10673
		internal static int __PropertyOffset_TargetMaximum;

		// Token: 0x040029B2 RID: 10674
		internal static int __PropertyOffset_bClamp;

		// Token: 0x040029B3 RID: 10675
		internal static int __PropertyOffset_Result;
	}
}
