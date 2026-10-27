using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000670 RID: 1648
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorDiv")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_MathVectorDiv : FRigUnit_MathVectorBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060057CF RID: 22479 RVA: 0x0007EC5F File Offset: 0x0007CE5F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorDiv._ScriptStructPtr != 0) ? FRigUnit_MathVectorDiv._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorDiv", ref FRigUnit_MathVectorDiv._ScriptStructPtr);
		}

		// Token: 0x060057D0 RID: 22480 RVA: 0x0007EC83 File Offset: 0x0007CE83
		public FRigUnit_MathVectorDiv()
		{
		}

		// Token: 0x060057D1 RID: 22481 RVA: 0x0007EC8B File Offset: 0x0007CE8B
		public FRigUnit_MathVectorDiv(FVector A, FVector B, FVector Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x060057D2 RID: 22482 RVA: 0x0007ECA8 File Offset: 0x0007CEA8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorDiv.StaticStruct();
		}

		// Token: 0x060057D3 RID: 22483 RVA: 0x0007ECB4 File Offset: 0x0007CEB4
		[NullableContext(2)]
		public FRigUnit_MathVectorDiv(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060057D4 RID: 22484 RVA: 0x0007ECBE File Offset: 0x0007CEBE
		public FRigUnit_MathVectorDiv(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060057D5 RID: 22485 RVA: 0x0007ECC9 File Offset: 0x0007CEC9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorDiv(Pointer, false, true);
		}

		// Token: 0x060057D6 RID: 22486 RVA: 0x0007ECD3 File Offset: 0x0007CED3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorDiv(Pointer, MemoryOwner);
		}

		// Token: 0x0400295C RID: 10588
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorDiv";

		// Token: 0x0400295D RID: 10589
		private static IntPtr _ScriptStructPtr;
	}
}
