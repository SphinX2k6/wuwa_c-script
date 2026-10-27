using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200068D RID: 1677
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorUnit")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_MathVectorUnit : FRigUnit_MathVectorUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005925 RID: 22821 RVA: 0x000802F5 File Offset: 0x0007E4F5
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorUnit._ScriptStructPtr != 0) ? FRigUnit_MathVectorUnit._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorUnit", ref FRigUnit_MathVectorUnit._ScriptStructPtr);
		}

		// Token: 0x06005926 RID: 22822 RVA: 0x00080319 File Offset: 0x0007E519
		public FRigUnit_MathVectorUnit()
		{
		}

		// Token: 0x06005927 RID: 22823 RVA: 0x00080321 File Offset: 0x0007E521
		public FRigUnit_MathVectorUnit(FVector Value, FVector Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x06005928 RID: 22824 RVA: 0x00080337 File Offset: 0x0007E537
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorUnit.StaticStruct();
		}

		// Token: 0x06005929 RID: 22825 RVA: 0x00080343 File Offset: 0x0007E543
		[NullableContext(2)]
		public FRigUnit_MathVectorUnit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600592A RID: 22826 RVA: 0x0008034D File Offset: 0x0007E54D
		public FRigUnit_MathVectorUnit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600592B RID: 22827 RVA: 0x00080358 File Offset: 0x0007E558
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorUnit(Pointer, false, true);
		}

		// Token: 0x0600592C RID: 22828 RVA: 0x00080362 File Offset: 0x0007E562
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorUnit(Pointer, MemoryOwner);
		}

		// Token: 0x040029CE RID: 10702
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorUnit";

		// Token: 0x040029CF RID: 10703
		private static IntPtr _ScriptStructPtr;
	}
}
