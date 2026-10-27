using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200069A RID: 1690
	[UnrealObjectPath("/Script/ControlRig.RigUnit_Multiply_VectorVector")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_Multiply_VectorVector : FRigUnit_BinaryVectorOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060059BE RID: 22974 RVA: 0x00080E9C File Offset: 0x0007F09C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_Multiply_VectorVector._ScriptStructPtr != 0) ? FRigUnit_Multiply_VectorVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_Multiply_VectorVector", ref FRigUnit_Multiply_VectorVector._ScriptStructPtr);
		}

		// Token: 0x060059BF RID: 22975 RVA: 0x00080EC0 File Offset: 0x0007F0C0
		public FRigUnit_Multiply_VectorVector()
		{
		}

		// Token: 0x060059C0 RID: 22976 RVA: 0x00080EC8 File Offset: 0x0007F0C8
		public FRigUnit_Multiply_VectorVector(FVector Argument0, FVector Argument1, FVector Result)
		{
			base.Argument0 = Argument0;
			base.Argument1 = Argument1;
			base.Result = Result;
		}

		// Token: 0x060059C1 RID: 22977 RVA: 0x00080EE5 File Offset: 0x0007F0E5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_Multiply_VectorVector.StaticStruct();
		}

		// Token: 0x060059C2 RID: 22978 RVA: 0x00080EF1 File Offset: 0x0007F0F1
		[NullableContext(2)]
		public FRigUnit_Multiply_VectorVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060059C3 RID: 22979 RVA: 0x00080EFB File Offset: 0x0007F0FB
		public FRigUnit_Multiply_VectorVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060059C4 RID: 22980 RVA: 0x00080F06 File Offset: 0x0007F106
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_Multiply_VectorVector(Pointer, false, true);
		}

		// Token: 0x060059C5 RID: 22981 RVA: 0x00080F10 File Offset: 0x0007F110
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_Multiply_VectorVector(Pointer, MemoryOwner);
		}

		// Token: 0x04002A09 RID: 10761
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_Multiply_VectorVector";

		// Token: 0x04002A0A RID: 10762
		private static IntPtr _ScriptStructPtr;
	}
}
