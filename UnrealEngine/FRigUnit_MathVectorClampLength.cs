using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200066B RID: 1643
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorClampLength")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_MathVectorClampLength : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005785 RID: 22405 RVA: 0x0007E727 File Offset: 0x0007C927
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorClampLength._ScriptStructPtr != 0) ? FRigUnit_MathVectorClampLength._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorClampLength", ref FRigUnit_MathVectorClampLength._ScriptStructPtr);
		}

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x06005786 RID: 22406 RVA: 0x0007E74B File Offset: 0x0007C94B
		// (set) Token: 0x06005787 RID: 22407 RVA: 0x0007E75F File Offset: 0x0007C95F
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampLength.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampLength.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x06005788 RID: 22408 RVA: 0x0007E774 File Offset: 0x0007C974
		// (set) Token: 0x06005789 RID: 22409 RVA: 0x0007E784 File Offset: 0x0007C984
		public unsafe float MinimumLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampLength.__PropertyOffset_MinimumLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampLength.__PropertyOffset_MinimumLength) = value;
			}
		}

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x0600578A RID: 22410 RVA: 0x0007E795 File Offset: 0x0007C995
		// (set) Token: 0x0600578B RID: 22411 RVA: 0x0007E7A5 File Offset: 0x0007C9A5
		public unsafe float MaximumLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampLength.__PropertyOffset_MaximumLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampLength.__PropertyOffset_MaximumLength) = value;
			}
		}

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x0600578C RID: 22412 RVA: 0x0007E7B6 File Offset: 0x0007C9B6
		// (set) Token: 0x0600578D RID: 22413 RVA: 0x0007E7CA File Offset: 0x0007C9CA
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampLength.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathVectorClampLength.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x0600578E RID: 22414 RVA: 0x0007E7DF File Offset: 0x0007C9DF
		public FRigUnit_MathVectorClampLength()
		{
		}

		// Token: 0x0600578F RID: 22415 RVA: 0x0007E7E7 File Offset: 0x0007C9E7
		public FRigUnit_MathVectorClampLength(FVector Value, float MinimumLength, float MaximumLength, FVector Result)
		{
			this.Value = Value;
			this.MinimumLength = MinimumLength;
			this.MaximumLength = MaximumLength;
			this.Result = Result;
		}

		// Token: 0x06005790 RID: 22416 RVA: 0x0007E80C File Offset: 0x0007CA0C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorClampLength.StaticStruct();
		}

		// Token: 0x06005791 RID: 22417 RVA: 0x0007E818 File Offset: 0x0007CA18
		[NullableContext(2)]
		public FRigUnit_MathVectorClampLength(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005792 RID: 22418 RVA: 0x0007E822 File Offset: 0x0007CA22
		public FRigUnit_MathVectorClampLength(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005793 RID: 22419 RVA: 0x0007E82D File Offset: 0x0007CA2D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorClampLength(Pointer, false, true);
		}

		// Token: 0x06005794 RID: 22420 RVA: 0x0007E837 File Offset: 0x0007CA37
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorClampLength(Pointer, MemoryOwner);
		}

		// Token: 0x04002941 RID: 10561
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorClampLength";

		// Token: 0x04002942 RID: 10562
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002943 RID: 10563
		internal static int __PropertyOffset_Value;

		// Token: 0x04002944 RID: 10564
		internal static int __PropertyOffset_MinimumLength;

		// Token: 0x04002945 RID: 10565
		internal static int __PropertyOffset_MaximumLength;

		// Token: 0x04002946 RID: 10566
		internal static int __PropertyOffset_Result;
	}
}
