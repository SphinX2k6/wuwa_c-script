using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000698 RID: 1688
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MultiplyTransform")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRigUnit_MultiplyTransform : FRigUnit_BinaryTransformOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060059AE RID: 22958 RVA: 0x00080DA2 File Offset: 0x0007EFA2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MultiplyTransform._ScriptStructPtr != 0) ? FRigUnit_MultiplyTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MultiplyTransform", ref FRigUnit_MultiplyTransform._ScriptStructPtr);
		}

		// Token: 0x060059AF RID: 22959 RVA: 0x00080DC6 File Offset: 0x0007EFC6
		public FRigUnit_MultiplyTransform()
		{
		}

		// Token: 0x060059B0 RID: 22960 RVA: 0x00080DCE File Offset: 0x0007EFCE
		public FRigUnit_MultiplyTransform(FTransform Argument0, FTransform Argument1, FTransform Result)
		{
			base.Argument0 = Argument0;
			base.Argument1 = Argument1;
			base.Result = Result;
		}

		// Token: 0x060059B1 RID: 22961 RVA: 0x00080DEB File Offset: 0x0007EFEB
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MultiplyTransform.StaticStruct();
		}

		// Token: 0x060059B2 RID: 22962 RVA: 0x00080DF7 File Offset: 0x0007EFF7
		[NullableContext(2)]
		public FRigUnit_MultiplyTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060059B3 RID: 22963 RVA: 0x00080E01 File Offset: 0x0007F001
		public FRigUnit_MultiplyTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060059B4 RID: 22964 RVA: 0x00080E0C File Offset: 0x0007F00C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MultiplyTransform(Pointer, false, true);
		}

		// Token: 0x060059B5 RID: 22965 RVA: 0x00080E16 File Offset: 0x0007F016
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MultiplyTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04002A05 RID: 10757
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MultiplyTransform";

		// Token: 0x04002A06 RID: 10758
		private static IntPtr _ScriptStructPtr;
	}
}
