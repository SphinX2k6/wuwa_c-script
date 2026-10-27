using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026BF RID: 9919
	[UnrealObjectPath("/Script/RigVM.RigVMComparisonOp")]
	[UnrealStructLayout(20, 2, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FRigVMComparisonOp : FRigVMBaseOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024D63 RID: 150883 RVA: 0x0036803C File Offset: 0x0036623C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMComparisonOp._ScriptStructPtr != 0) ? FRigVMComparisonOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMComparisonOp", ref FRigVMComparisonOp._ScriptStructPtr);
		}

		// Token: 0x06024D64 RID: 150884 RVA: 0x00368060 File Offset: 0x00366260
		public FRigVMComparisonOp()
		{
		}

		// Token: 0x06024D65 RID: 150885 RVA: 0x00368068 File Offset: 0x00366268
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMComparisonOp.StaticStruct();
		}

		// Token: 0x06024D66 RID: 150886 RVA: 0x00368074 File Offset: 0x00366274
		[NullableContext(2)]
		public FRigVMComparisonOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024D67 RID: 150887 RVA: 0x0036807E File Offset: 0x0036627E
		public FRigVMComparisonOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024D68 RID: 150888 RVA: 0x00368089 File Offset: 0x00366289
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMComparisonOp(Pointer, false, true);
		}

		// Token: 0x06024D69 RID: 150889 RVA: 0x00368093 File Offset: 0x00366293
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMComparisonOp(Pointer, MemoryOwner);
		}

		// Token: 0x04013D96 RID: 81302
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/RigVM.RigVMComparisonOp";

		// Token: 0x04013D97 RID: 81303
		private static IntPtr _ScriptStructPtr;
	}
}
