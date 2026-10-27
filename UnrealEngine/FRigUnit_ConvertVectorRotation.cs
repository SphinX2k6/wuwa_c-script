using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200057D RID: 1405
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ConvertVectorRotation")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_ConvertVectorRotation : FRigUnit_ConvertRotation, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004AC8 RID: 19144 RVA: 0x0006EF3A File Offset: 0x0006D13A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ConvertVectorRotation._ScriptStructPtr != 0) ? FRigUnit_ConvertVectorRotation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ConvertVectorRotation", ref FRigUnit_ConvertVectorRotation._ScriptStructPtr);
		}

		// Token: 0x06004AC9 RID: 19145 RVA: 0x0006EF5E File Offset: 0x0006D15E
		public FRigUnit_ConvertVectorRotation()
		{
		}

		// Token: 0x06004ACA RID: 19146 RVA: 0x0006EF66 File Offset: 0x0006D166
		public FRigUnit_ConvertVectorRotation(FRotator Input, FQuat Result)
		{
			base.Input = Input;
			base.Result = Result;
		}

		// Token: 0x06004ACB RID: 19147 RVA: 0x0006EF7C File Offset: 0x0006D17C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ConvertVectorRotation.StaticStruct();
		}

		// Token: 0x06004ACC RID: 19148 RVA: 0x0006EF88 File Offset: 0x0006D188
		[NullableContext(2)]
		public FRigUnit_ConvertVectorRotation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004ACD RID: 19149 RVA: 0x0006EF92 File Offset: 0x0006D192
		public FRigUnit_ConvertVectorRotation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004ACE RID: 19150 RVA: 0x0006EF9D File Offset: 0x0006D19D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ConvertVectorRotation(Pointer, false, true);
		}

		// Token: 0x06004ACF RID: 19151 RVA: 0x0006EFA7 File Offset: 0x0006D1A7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ConvertVectorRotation(Pointer, MemoryOwner);
		}

		// Token: 0x04002447 RID: 9287
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ConvertVectorRotation";

		// Token: 0x04002448 RID: 9288
		private static IntPtr _ScriptStructPtr;
	}
}
