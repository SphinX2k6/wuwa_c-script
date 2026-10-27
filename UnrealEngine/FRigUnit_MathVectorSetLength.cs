using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000689 RID: 1673
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorSetLength")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_MathVectorSetLength : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060058FB RID: 22779 RVA: 0x0008004A File Offset: 0x0007E24A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorSetLength._ScriptStructPtr != 0) ? FRigUnit_MathVectorSetLength._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorSetLength", ref FRigUnit_MathVectorSetLength._ScriptStructPtr);
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x060058FC RID: 22780 RVA: 0x0008006E File Offset: 0x0007E26E
		// (set) Token: 0x060058FD RID: 22781 RVA: 0x00080082 File Offset: 0x0007E282
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorSetLength.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorSetLength.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x060058FE RID: 22782 RVA: 0x00080097 File Offset: 0x0007E297
		// (set) Token: 0x060058FF RID: 22783 RVA: 0x000800A7 File Offset: 0x0007E2A7
		public unsafe float Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorSetLength.__PropertyOffset_Length);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorSetLength.__PropertyOffset_Length) = value;
			}
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x06005900 RID: 22784 RVA: 0x000800B8 File Offset: 0x0007E2B8
		// (set) Token: 0x06005901 RID: 22785 RVA: 0x000800CC File Offset: 0x0007E2CC
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorSetLength.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorSetLength.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06005902 RID: 22786 RVA: 0x000800E1 File Offset: 0x0007E2E1
		public FRigUnit_MathVectorSetLength()
		{
		}

		// Token: 0x06005903 RID: 22787 RVA: 0x000800E9 File Offset: 0x0007E2E9
		public FRigUnit_MathVectorSetLength(FVector Value, float Length, FVector Result)
		{
			this.Value = Value;
			this.Length = Length;
			this.Result = Result;
		}

		// Token: 0x06005904 RID: 22788 RVA: 0x00080106 File Offset: 0x0007E306
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorSetLength.StaticStruct();
		}

		// Token: 0x06005905 RID: 22789 RVA: 0x00080112 File Offset: 0x0007E312
		[NullableContext(2)]
		public FRigUnit_MathVectorSetLength(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005906 RID: 22790 RVA: 0x0008011C File Offset: 0x0007E31C
		public FRigUnit_MathVectorSetLength(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005907 RID: 22791 RVA: 0x00080127 File Offset: 0x0007E327
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorSetLength(Pointer, false, true);
		}

		// Token: 0x06005908 RID: 22792 RVA: 0x00080131 File Offset: 0x0007E331
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorSetLength(Pointer, MemoryOwner);
		}

		// Token: 0x040029C1 RID: 10689
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorSetLength";

		// Token: 0x040029C2 RID: 10690
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040029C3 RID: 10691
		internal static int __PropertyOffset_Value;

		// Token: 0x040029C4 RID: 10692
		internal static int __PropertyOffset_Length;

		// Token: 0x040029C5 RID: 10693
		internal static int __PropertyOffset_Result;
	}
}
