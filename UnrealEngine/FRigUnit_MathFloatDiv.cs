using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005FA RID: 1530
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatDiv")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatDiv : FRigUnit_MathFloatBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005228 RID: 21032 RVA: 0x0007888C File Offset: 0x00076A8C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatDiv._ScriptStructPtr != 0) ? FRigUnit_MathFloatDiv._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatDiv", ref FRigUnit_MathFloatDiv._ScriptStructPtr);
		}

		// Token: 0x06005229 RID: 21033 RVA: 0x000788B0 File Offset: 0x00076AB0
		public FRigUnit_MathFloatDiv()
		{
		}

		// Token: 0x0600522A RID: 21034 RVA: 0x000788B8 File Offset: 0x00076AB8
		public FRigUnit_MathFloatDiv(float A, float B, float Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x0600522B RID: 21035 RVA: 0x000788D5 File Offset: 0x00076AD5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatDiv.StaticStruct();
		}

		// Token: 0x0600522C RID: 21036 RVA: 0x000788E1 File Offset: 0x00076AE1
		[NullableContext(2)]
		public FRigUnit_MathFloatDiv(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600522D RID: 21037 RVA: 0x000788EB File Offset: 0x00076AEB
		public FRigUnit_MathFloatDiv(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600522E RID: 21038 RVA: 0x000788F6 File Offset: 0x00076AF6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatDiv(Pointer, false, true);
		}

		// Token: 0x0600522F RID: 21039 RVA: 0x00078900 File Offset: 0x00076B00
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatDiv(Pointer, MemoryOwner);
		}

		// Token: 0x04002761 RID: 10081
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatDiv";

		// Token: 0x04002762 RID: 10082
		private static IntPtr _ScriptStructPtr;
	}
}
