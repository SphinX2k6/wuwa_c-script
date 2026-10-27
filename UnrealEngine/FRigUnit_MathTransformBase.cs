using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000654 RID: 1620
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathTransformBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigUnit_MathTransformBase : FRigUnit_MathBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005659 RID: 22105 RVA: 0x0007D1B8 File Offset: 0x0007B3B8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathTransformBase._ScriptStructPtr != 0) ? FRigUnit_MathTransformBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathTransformBase", ref FRigUnit_MathTransformBase._ScriptStructPtr);
		}

		// Token: 0x0600565A RID: 22106 RVA: 0x0007D1DC File Offset: 0x0007B3DC
		public FRigUnit_MathTransformBase()
		{
		}

		// Token: 0x0600565B RID: 22107 RVA: 0x0007D1E4 File Offset: 0x0007B3E4
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathTransformBase.StaticStruct();
		}

		// Token: 0x0600565C RID: 22108 RVA: 0x0007D1F0 File Offset: 0x0007B3F0
		[NullableContext(2)]
		public FRigUnit_MathTransformBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600565D RID: 22109 RVA: 0x0007D1FA File Offset: 0x0007B3FA
		public FRigUnit_MathTransformBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600565E RID: 22110 RVA: 0x0007D205 File Offset: 0x0007B405
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathTransformBase(Pointer, false, true);
		}

		// Token: 0x0600565F RID: 22111 RVA: 0x0007D20F File Offset: 0x0007B40F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathTransformBase(Pointer, MemoryOwner);
		}

		// Token: 0x040028D4 RID: 10452
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathTransformBase";

		// Token: 0x040028D5 RID: 10453
		private static IntPtr _ScriptStructPtr;
	}
}
