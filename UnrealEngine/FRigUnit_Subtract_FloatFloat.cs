using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006DF RID: 1759
	[UnrealObjectPath("/Script/ControlRig.RigUnit_Subtract_FloatFloat")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_Subtract_FloatFloat : FRigUnit_BinaryFloatOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005E60 RID: 24160 RVA: 0x000876D8 File Offset: 0x000858D8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_Subtract_FloatFloat._ScriptStructPtr != 0) ? FRigUnit_Subtract_FloatFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_Subtract_FloatFloat", ref FRigUnit_Subtract_FloatFloat._ScriptStructPtr);
		}

		// Token: 0x06005E61 RID: 24161 RVA: 0x000876FC File Offset: 0x000858FC
		public FRigUnit_Subtract_FloatFloat()
		{
		}

		// Token: 0x06005E62 RID: 24162 RVA: 0x00087704 File Offset: 0x00085904
		public FRigUnit_Subtract_FloatFloat(float Argument0, float Argument1, float Result)
		{
			base.Argument0 = Argument0;
			base.Argument1 = Argument1;
			base.Result = Result;
		}

		// Token: 0x06005E63 RID: 24163 RVA: 0x00087721 File Offset: 0x00085921
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_Subtract_FloatFloat.StaticStruct();
		}

		// Token: 0x06005E64 RID: 24164 RVA: 0x0008772D File Offset: 0x0008592D
		[NullableContext(2)]
		public FRigUnit_Subtract_FloatFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005E65 RID: 24165 RVA: 0x00087737 File Offset: 0x00085937
		public FRigUnit_Subtract_FloatFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005E66 RID: 24166 RVA: 0x00087742 File Offset: 0x00085942
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_Subtract_FloatFloat(Pointer, false, true);
		}

		// Token: 0x06005E67 RID: 24167 RVA: 0x0008774C File Offset: 0x0008594C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_Subtract_FloatFloat(Pointer, MemoryOwner);
		}

		// Token: 0x04002C27 RID: 11303
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_Subtract_FloatFloat";

		// Token: 0x04002C28 RID: 11304
		private static IntPtr _ScriptStructPtr;
	}
}
