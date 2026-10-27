using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005D9 RID: 1497
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathBoolBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigUnit_MathBoolBase : FRigUnit_MathBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060050E3 RID: 20707 RVA: 0x000774FF File Offset: 0x000756FF
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathBoolBase._ScriptStructPtr != 0) ? FRigUnit_MathBoolBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathBoolBase", ref FRigUnit_MathBoolBase._ScriptStructPtr);
		}

		// Token: 0x060050E4 RID: 20708 RVA: 0x00077523 File Offset: 0x00075723
		public FRigUnit_MathBoolBase()
		{
		}

		// Token: 0x060050E5 RID: 20709 RVA: 0x0007752B File Offset: 0x0007572B
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathBoolBase.StaticStruct();
		}

		// Token: 0x060050E6 RID: 20710 RVA: 0x00077537 File Offset: 0x00075737
		[NullableContext(2)]
		public FRigUnit_MathBoolBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060050E7 RID: 20711 RVA: 0x00077541 File Offset: 0x00075741
		public FRigUnit_MathBoolBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060050E8 RID: 20712 RVA: 0x0007754C File Offset: 0x0007574C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathBoolBase(Pointer, false, true);
		}

		// Token: 0x060050E9 RID: 20713 RVA: 0x00077556 File Offset: 0x00075756
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathBoolBase(Pointer, MemoryOwner);
		}

		// Token: 0x040026FF RID: 9983
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathBoolBase";

		// Token: 0x04002700 RID: 9984
		private static IntPtr _ScriptStructPtr;
	}
}
