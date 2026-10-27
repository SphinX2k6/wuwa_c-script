using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200063E RID: 1598
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionSlerp")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FRigUnit_MathQuaternionSlerp : FRigUnit_MathQuaternionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005546 RID: 21830 RVA: 0x0007BB10 File Offset: 0x00079D10
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionSlerp._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionSlerp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionSlerp", ref FRigUnit_MathQuaternionSlerp._ScriptStructPtr);
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x06005547 RID: 21831 RVA: 0x0007BB34 File Offset: 0x00079D34
		// (set) Token: 0x06005548 RID: 21832 RVA: 0x0007BB48 File Offset: 0x00079D48
		public unsafe FQuat A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSlerp.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSlerp.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x06005549 RID: 21833 RVA: 0x0007BB5D File Offset: 0x00079D5D
		// (set) Token: 0x0600554A RID: 21834 RVA: 0x0007BB71 File Offset: 0x00079D71
		public unsafe FQuat B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSlerp.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSlerp.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x0600554B RID: 21835 RVA: 0x0007BB86 File Offset: 0x00079D86
		// (set) Token: 0x0600554C RID: 21836 RVA: 0x0007BB96 File Offset: 0x00079D96
		public unsafe float T
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSlerp.__PropertyOffset_T);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSlerp.__PropertyOffset_T) = value;
			}
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x0600554D RID: 21837 RVA: 0x0007BBA7 File Offset: 0x00079DA7
		// (set) Token: 0x0600554E RID: 21838 RVA: 0x0007BBBB File Offset: 0x00079DBB
		public unsafe FQuat Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSlerp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSlerp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x0600554F RID: 21839 RVA: 0x0007BBD0 File Offset: 0x00079DD0
		public FRigUnit_MathQuaternionSlerp()
		{
		}

		// Token: 0x06005550 RID: 21840 RVA: 0x0007BBD8 File Offset: 0x00079DD8
		public FRigUnit_MathQuaternionSlerp(FQuat A, FQuat B, float T, FQuat Result)
		{
			this.A = A;
			this.B = B;
			this.T = T;
			this.Result = Result;
		}

		// Token: 0x06005551 RID: 21841 RVA: 0x0007BBFD File Offset: 0x00079DFD
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionSlerp.StaticStruct();
		}

		// Token: 0x06005552 RID: 21842 RVA: 0x0007BC09 File Offset: 0x00079E09
		[NullableContext(2)]
		public FRigUnit_MathQuaternionSlerp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005553 RID: 21843 RVA: 0x0007BC13 File Offset: 0x00079E13
		public FRigUnit_MathQuaternionSlerp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005554 RID: 21844 RVA: 0x0007BC1E File Offset: 0x00079E1E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionSlerp(Pointer, false, true);
		}

		// Token: 0x06005555 RID: 21845 RVA: 0x0007BC28 File Offset: 0x00079E28
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionSlerp(Pointer, MemoryOwner);
		}

		// Token: 0x04002869 RID: 10345
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionSlerp";

		// Token: 0x0400286A RID: 10346
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400286B RID: 10347
		internal static int __PropertyOffset_A;

		// Token: 0x0400286C RID: 10348
		internal static int __PropertyOffset_B;

		// Token: 0x0400286D RID: 10349
		internal static int __PropertyOffset_T;

		// Token: 0x0400286E RID: 10350
		internal static int __PropertyOffset_Result;
	}
}
