using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200054A RID: 1354
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AnimEasing")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_AnimEasing : FRigUnit_AnimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004785 RID: 18309 RVA: 0x0006A3CC File Offset: 0x000685CC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AnimEasing._ScriptStructPtr != 0) ? FRigUnit_AnimEasing._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AnimEasing", ref FRigUnit_AnimEasing._ScriptStructPtr);
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x06004786 RID: 18310 RVA: 0x0006A3F0 File Offset: 0x000685F0
		// (set) Token: 0x06004787 RID: 18311 RVA: 0x0006A400 File Offset: 0x00068600
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AnimEasing.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AnimEasing.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x06004788 RID: 18312 RVA: 0x0006A411 File Offset: 0x00068611
		// (set) Token: 0x06004789 RID: 18313 RVA: 0x0006A421 File Offset: 0x00068621
		public unsafe EControlRigAnimEasingType Type
		{
			get
			{
				return (EControlRigAnimEasingType)(*(base.NativePtr + (IntPtr)FRigUnit_AnimEasing.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AnimEasing.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x0600478A RID: 18314 RVA: 0x0006A432 File Offset: 0x00068632
		// (set) Token: 0x0600478B RID: 18315 RVA: 0x0006A442 File Offset: 0x00068642
		public unsafe float SourceMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AnimEasing.__PropertyOffset_SourceMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AnimEasing.__PropertyOffset_SourceMinimum) = value;
			}
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x0600478C RID: 18316 RVA: 0x0006A453 File Offset: 0x00068653
		// (set) Token: 0x0600478D RID: 18317 RVA: 0x0006A463 File Offset: 0x00068663
		public unsafe float SourceMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AnimEasing.__PropertyOffset_SourceMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AnimEasing.__PropertyOffset_SourceMaximum) = value;
			}
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x0600478E RID: 18318 RVA: 0x0006A474 File Offset: 0x00068674
		// (set) Token: 0x0600478F RID: 18319 RVA: 0x0006A484 File Offset: 0x00068684
		public unsafe float TargetMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AnimEasing.__PropertyOffset_TargetMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AnimEasing.__PropertyOffset_TargetMinimum) = value;
			}
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x06004790 RID: 18320 RVA: 0x0006A495 File Offset: 0x00068695
		// (set) Token: 0x06004791 RID: 18321 RVA: 0x0006A4A5 File Offset: 0x000686A5
		public unsafe float TargetMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AnimEasing.__PropertyOffset_TargetMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AnimEasing.__PropertyOffset_TargetMaximum) = value;
			}
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x06004792 RID: 18322 RVA: 0x0006A4B6 File Offset: 0x000686B6
		// (set) Token: 0x06004793 RID: 18323 RVA: 0x0006A4C6 File Offset: 0x000686C6
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AnimEasing.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AnimEasing.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06004794 RID: 18324 RVA: 0x0006A4D7 File Offset: 0x000686D7
		public FRigUnit_AnimEasing()
		{
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x0006A4DF File Offset: 0x000686DF
		public FRigUnit_AnimEasing(float Value, EControlRigAnimEasingType Type, float SourceMinimum, float SourceMaximum, float TargetMinimum, float TargetMaximum, float Result)
		{
			this.Value = Value;
			this.Type = Type;
			this.SourceMinimum = SourceMinimum;
			this.SourceMaximum = SourceMaximum;
			this.TargetMinimum = TargetMinimum;
			this.TargetMaximum = TargetMaximum;
			this.Result = Result;
		}

		// Token: 0x06004796 RID: 18326 RVA: 0x0006A51C File Offset: 0x0006871C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AnimEasing.StaticStruct();
		}

		// Token: 0x06004797 RID: 18327 RVA: 0x0006A528 File Offset: 0x00068728
		[NullableContext(2)]
		public FRigUnit_AnimEasing(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004798 RID: 18328 RVA: 0x0006A532 File Offset: 0x00068732
		public FRigUnit_AnimEasing(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004799 RID: 18329 RVA: 0x0006A53D File Offset: 0x0006873D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AnimEasing(Pointer, false, true);
		}

		// Token: 0x0600479A RID: 18330 RVA: 0x0006A547 File Offset: 0x00068747
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AnimEasing(Pointer, MemoryOwner);
		}

		// Token: 0x040022C2 RID: 8898
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AnimEasing";

		// Token: 0x040022C3 RID: 8899
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040022C4 RID: 8900
		internal static int __PropertyOffset_Value;

		// Token: 0x040022C5 RID: 8901
		internal static int __PropertyOffset_Type;

		// Token: 0x040022C6 RID: 8902
		internal static int __PropertyOffset_SourceMinimum;

		// Token: 0x040022C7 RID: 8903
		internal static int __PropertyOffset_SourceMaximum;

		// Token: 0x040022C8 RID: 8904
		internal static int __PropertyOffset_TargetMinimum;

		// Token: 0x040022C9 RID: 8905
		internal static int __PropertyOffset_TargetMaximum;

		// Token: 0x040022CA RID: 8906
		internal static int __PropertyOffset_Result;
	}
}
