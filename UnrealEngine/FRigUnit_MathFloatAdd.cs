using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005ED RID: 1517
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatAdd")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatAdd : FRigUnit_MathFloatBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060051AB RID: 20907 RVA: 0x00078131 File Offset: 0x00076331
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatAdd._ScriptStructPtr != 0) ? FRigUnit_MathFloatAdd._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatAdd", ref FRigUnit_MathFloatAdd._ScriptStructPtr);
		}

		// Token: 0x060051AC RID: 20908 RVA: 0x00078155 File Offset: 0x00076355
		public FRigUnit_MathFloatAdd()
		{
		}

		// Token: 0x060051AD RID: 20909 RVA: 0x0007815D File Offset: 0x0007635D
		public FRigUnit_MathFloatAdd(float A, float B, float Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x060051AE RID: 20910 RVA: 0x0007817A File Offset: 0x0007637A
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatAdd.StaticStruct();
		}

		// Token: 0x060051AF RID: 20911 RVA: 0x00078186 File Offset: 0x00076386
		[NullableContext(2)]
		public FRigUnit_MathFloatAdd(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060051B0 RID: 20912 RVA: 0x00078190 File Offset: 0x00076390
		public FRigUnit_MathFloatAdd(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060051B1 RID: 20913 RVA: 0x0007819B File Offset: 0x0007639B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatAdd(Pointer, false, true);
		}

		// Token: 0x060051B2 RID: 20914 RVA: 0x000781A5 File Offset: 0x000763A5
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatAdd(Pointer, MemoryOwner);
		}

		// Token: 0x0400273C RID: 10044
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatAdd";

		// Token: 0x0400273D RID: 10045
		private static IntPtr _ScriptStructPtr;
	}
}
