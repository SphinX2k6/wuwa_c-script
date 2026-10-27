using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005EA RID: 1514
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathColorSub")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FRigUnit_MathColorSub : FRigUnit_MathColorBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005193 RID: 20883 RVA: 0x00077FC8 File Offset: 0x000761C8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathColorSub._ScriptStructPtr != 0) ? FRigUnit_MathColorSub._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathColorSub", ref FRigUnit_MathColorSub._ScriptStructPtr);
		}

		// Token: 0x06005194 RID: 20884 RVA: 0x00077FEC File Offset: 0x000761EC
		public FRigUnit_MathColorSub()
		{
		}

		// Token: 0x06005195 RID: 20885 RVA: 0x00077FF4 File Offset: 0x000761F4
		public FRigUnit_MathColorSub(FLinearColor A, FLinearColor B, FLinearColor Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x06005196 RID: 20886 RVA: 0x00078011 File Offset: 0x00076211
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathColorSub.StaticStruct();
		}

		// Token: 0x06005197 RID: 20887 RVA: 0x0007801D File Offset: 0x0007621D
		[NullableContext(2)]
		public FRigUnit_MathColorSub(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005198 RID: 20888 RVA: 0x00078027 File Offset: 0x00076227
		public FRigUnit_MathColorSub(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005199 RID: 20889 RVA: 0x00078032 File Offset: 0x00076232
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathColorSub(Pointer, false, true);
		}

		// Token: 0x0600519A RID: 20890 RVA: 0x0007803C File Offset: 0x0007623C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathColorSub(Pointer, MemoryOwner);
		}

		// Token: 0x04002736 RID: 10038
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathColorSub";

		// Token: 0x04002737 RID: 10039
		private static IntPtr _ScriptStructPtr;
	}
}
