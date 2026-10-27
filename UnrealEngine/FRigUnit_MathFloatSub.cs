using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000613 RID: 1555
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatSub")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatSub : FRigUnit_MathFloatBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600535A RID: 21338 RVA: 0x00079BCB File Offset: 0x00077DCB
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatSub._ScriptStructPtr != 0) ? FRigUnit_MathFloatSub._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatSub", ref FRigUnit_MathFloatSub._ScriptStructPtr);
		}

		// Token: 0x0600535B RID: 21339 RVA: 0x00079BEF File Offset: 0x00077DEF
		public FRigUnit_MathFloatSub()
		{
		}

		// Token: 0x0600535C RID: 21340 RVA: 0x00079BF7 File Offset: 0x00077DF7
		public FRigUnit_MathFloatSub(float A, float B, float Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x0600535D RID: 21341 RVA: 0x00079C14 File Offset: 0x00077E14
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatSub.StaticStruct();
		}

		// Token: 0x0600535E RID: 21342 RVA: 0x00079C20 File Offset: 0x00077E20
		[NullableContext(2)]
		public FRigUnit_MathFloatSub(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600535F RID: 21343 RVA: 0x00079C2A File Offset: 0x00077E2A
		public FRigUnit_MathFloatSub(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005360 RID: 21344 RVA: 0x00079C35 File Offset: 0x00077E35
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatSub(Pointer, false, true);
		}

		// Token: 0x06005361 RID: 21345 RVA: 0x00079C3F File Offset: 0x00077E3F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatSub(Pointer, MemoryOwner);
		}

		// Token: 0x040027C8 RID: 10184
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatSub";

		// Token: 0x040027C9 RID: 10185
		private static IntPtr _ScriptStructPtr;
	}
}
