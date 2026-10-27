using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006E0 RID: 1760
	[UnrealObjectPath("/Script/ControlRig.RigUnit_Subtract_VectorVector")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_Subtract_VectorVector : FRigUnit_BinaryVectorOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005E68 RID: 24168 RVA: 0x00087755 File Offset: 0x00085955
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_Subtract_VectorVector._ScriptStructPtr != 0) ? FRigUnit_Subtract_VectorVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_Subtract_VectorVector", ref FRigUnit_Subtract_VectorVector._ScriptStructPtr);
		}

		// Token: 0x06005E69 RID: 24169 RVA: 0x00087779 File Offset: 0x00085979
		public FRigUnit_Subtract_VectorVector()
		{
		}

		// Token: 0x06005E6A RID: 24170 RVA: 0x00087781 File Offset: 0x00085981
		public FRigUnit_Subtract_VectorVector(FVector Argument0, FVector Argument1, FVector Result)
		{
			base.Argument0 = Argument0;
			base.Argument1 = Argument1;
			base.Result = Result;
		}

		// Token: 0x06005E6B RID: 24171 RVA: 0x0008779E File Offset: 0x0008599E
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_Subtract_VectorVector.StaticStruct();
		}

		// Token: 0x06005E6C RID: 24172 RVA: 0x000877AA File Offset: 0x000859AA
		[NullableContext(2)]
		public FRigUnit_Subtract_VectorVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005E6D RID: 24173 RVA: 0x000877B4 File Offset: 0x000859B4
		public FRigUnit_Subtract_VectorVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005E6E RID: 24174 RVA: 0x000877BF File Offset: 0x000859BF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_Subtract_VectorVector(Pointer, false, true);
		}

		// Token: 0x06005E6F RID: 24175 RVA: 0x000877C9 File Offset: 0x000859C9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_Subtract_VectorVector(Pointer, MemoryOwner);
		}

		// Token: 0x04002C29 RID: 11305
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_Subtract_VectorVector";

		// Token: 0x04002C2A RID: 11306
		private static IntPtr _ScriptStructPtr;
	}
}
