using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200063A RID: 1594
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionRotateVector")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_MathQuaternionRotateVector : FRigUnit_MathQuaternionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005512 RID: 21778 RVA: 0x0007B7A7 File Offset: 0x000799A7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionRotateVector._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionRotateVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionRotateVector", ref FRigUnit_MathQuaternionRotateVector._ScriptStructPtr);
		}

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x06005513 RID: 21779 RVA: 0x0007B7CB File Offset: 0x000799CB
		// (set) Token: 0x06005514 RID: 21780 RVA: 0x0007B7DF File Offset: 0x000799DF
		public unsafe FQuat Quaternion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionRotateVector.__PropertyOffset_Quaternion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionRotateVector.__PropertyOffset_Quaternion) = value;
			}
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x06005515 RID: 21781 RVA: 0x0007B7F4 File Offset: 0x000799F4
		// (set) Token: 0x06005516 RID: 21782 RVA: 0x0007B808 File Offset: 0x00079A08
		public unsafe FVector Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionRotateVector.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionRotateVector.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x06005517 RID: 21783 RVA: 0x0007B81D File Offset: 0x00079A1D
		// (set) Token: 0x06005518 RID: 21784 RVA: 0x0007B831 File Offset: 0x00079A31
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionRotateVector.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionRotateVector.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06005519 RID: 21785 RVA: 0x0007B846 File Offset: 0x00079A46
		public FRigUnit_MathQuaternionRotateVector()
		{
		}

		// Token: 0x0600551A RID: 21786 RVA: 0x0007B84E File Offset: 0x00079A4E
		public FRigUnit_MathQuaternionRotateVector(FQuat Quaternion, FVector Vector, FVector Result)
		{
			this.Quaternion = Quaternion;
			this.Vector = Vector;
			this.Result = Result;
		}

		// Token: 0x0600551B RID: 21787 RVA: 0x0007B86B File Offset: 0x00079A6B
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionRotateVector.StaticStruct();
		}

		// Token: 0x0600551C RID: 21788 RVA: 0x0007B877 File Offset: 0x00079A77
		[NullableContext(2)]
		public FRigUnit_MathQuaternionRotateVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600551D RID: 21789 RVA: 0x0007B881 File Offset: 0x00079A81
		public FRigUnit_MathQuaternionRotateVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600551E RID: 21790 RVA: 0x0007B88C File Offset: 0x00079A8C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionRotateVector(Pointer, false, true);
		}

		// Token: 0x0600551F RID: 21791 RVA: 0x0007B896 File Offset: 0x00079A96
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionRotateVector(Pointer, MemoryOwner);
		}

		// Token: 0x04002857 RID: 10327
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionRotateVector";

		// Token: 0x04002858 RID: 10328
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002859 RID: 10329
		internal static int __PropertyOffset_Quaternion;

		// Token: 0x0400285A RID: 10330
		internal static int __PropertyOffset_Vector;

		// Token: 0x0400285B RID: 10331
		internal static int __PropertyOffset_Result;
	}
}
