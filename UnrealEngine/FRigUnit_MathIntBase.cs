using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000619 RID: 1561
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigUnit_MathIntBase : FRigUnit_MathBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005392 RID: 21394 RVA: 0x00079F21 File Offset: 0x00078121
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntBase._ScriptStructPtr != 0) ? FRigUnit_MathIntBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntBase", ref FRigUnit_MathIntBase._ScriptStructPtr);
		}

		// Token: 0x06005393 RID: 21395 RVA: 0x00079F45 File Offset: 0x00078145
		public FRigUnit_MathIntBase()
		{
		}

		// Token: 0x06005394 RID: 21396 RVA: 0x00079F4D File Offset: 0x0007814D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntBase.StaticStruct();
		}

		// Token: 0x06005395 RID: 21397 RVA: 0x00079F59 File Offset: 0x00078159
		[NullableContext(2)]
		public FRigUnit_MathIntBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005396 RID: 21398 RVA: 0x00079F63 File Offset: 0x00078163
		public FRigUnit_MathIntBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005397 RID: 21399 RVA: 0x00079F6E File Offset: 0x0007816E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntBase(Pointer, false, true);
		}

		// Token: 0x06005398 RID: 21400 RVA: 0x00079F78 File Offset: 0x00078178
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntBase(Pointer, MemoryOwner);
		}

		// Token: 0x040027D8 RID: 10200
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntBase";

		// Token: 0x040027D9 RID: 10201
		private static IntPtr _ScriptStructPtr;
	}
}
