using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000639 RID: 1593
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionNotEquals")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_MathQuaternionNotEquals : FRigUnit_MathQuaternionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005504 RID: 21764 RVA: 0x0007B6B7 File Offset: 0x000798B7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionNotEquals._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionNotEquals._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionNotEquals", ref FRigUnit_MathQuaternionNotEquals._ScriptStructPtr);
		}

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x06005505 RID: 21765 RVA: 0x0007B6DB File Offset: 0x000798DB
		// (set) Token: 0x06005506 RID: 21766 RVA: 0x0007B6EF File Offset: 0x000798EF
		public unsafe FQuat A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionNotEquals.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionNotEquals.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x06005507 RID: 21767 RVA: 0x0007B704 File Offset: 0x00079904
		// (set) Token: 0x06005508 RID: 21768 RVA: 0x0007B718 File Offset: 0x00079918
		public unsafe FQuat B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionNotEquals.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionNotEquals.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x06005509 RID: 21769 RVA: 0x0007B72D File Offset: 0x0007992D
		// (set) Token: 0x0600550A RID: 21770 RVA: 0x0007B73D File Offset: 0x0007993D
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionNotEquals.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionNotEquals.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600550B RID: 21771 RVA: 0x0007B74E File Offset: 0x0007994E
		public FRigUnit_MathQuaternionNotEquals()
		{
		}

		// Token: 0x0600550C RID: 21772 RVA: 0x0007B756 File Offset: 0x00079956
		public FRigUnit_MathQuaternionNotEquals(FQuat A, FQuat B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x0600550D RID: 21773 RVA: 0x0007B773 File Offset: 0x00079973
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionNotEquals.StaticStruct();
		}

		// Token: 0x0600550E RID: 21774 RVA: 0x0007B77F File Offset: 0x0007997F
		[NullableContext(2)]
		public FRigUnit_MathQuaternionNotEquals(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600550F RID: 21775 RVA: 0x0007B789 File Offset: 0x00079989
		public FRigUnit_MathQuaternionNotEquals(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005510 RID: 21776 RVA: 0x0007B794 File Offset: 0x00079994
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionNotEquals(Pointer, false, true);
		}

		// Token: 0x06005511 RID: 21777 RVA: 0x0007B79E File Offset: 0x0007999E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionNotEquals(Pointer, MemoryOwner);
		}

		// Token: 0x04002852 RID: 10322
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionNotEquals";

		// Token: 0x04002853 RID: 10323
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002854 RID: 10324
		internal static int __PropertyOffset_A;

		// Token: 0x04002855 RID: 10325
		internal static int __PropertyOffset_B;

		// Token: 0x04002856 RID: 10326
		internal static int __PropertyOffset_Result;
	}
}
