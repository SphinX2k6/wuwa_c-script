using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000618 RID: 1560
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntAdd")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathIntAdd : FRigUnit_MathIntBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600538A RID: 21386 RVA: 0x00079EA4 File Offset: 0x000780A4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntAdd._ScriptStructPtr != 0) ? FRigUnit_MathIntAdd._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntAdd", ref FRigUnit_MathIntAdd._ScriptStructPtr);
		}

		// Token: 0x0600538B RID: 21387 RVA: 0x00079EC8 File Offset: 0x000780C8
		public FRigUnit_MathIntAdd()
		{
		}

		// Token: 0x0600538C RID: 21388 RVA: 0x00079ED0 File Offset: 0x000780D0
		public FRigUnit_MathIntAdd(int A, int B, int Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x0600538D RID: 21389 RVA: 0x00079EED File Offset: 0x000780ED
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntAdd.StaticStruct();
		}

		// Token: 0x0600538E RID: 21390 RVA: 0x00079EF9 File Offset: 0x000780F9
		[NullableContext(2)]
		public FRigUnit_MathIntAdd(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600538F RID: 21391 RVA: 0x00079F03 File Offset: 0x00078103
		public FRigUnit_MathIntAdd(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005390 RID: 21392 RVA: 0x00079F0E File Offset: 0x0007810E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntAdd(Pointer, false, true);
		}

		// Token: 0x06005391 RID: 21393 RVA: 0x00079F18 File Offset: 0x00078118
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntAdd(Pointer, MemoryOwner);
		}

		// Token: 0x040027D6 RID: 10198
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntAdd";

		// Token: 0x040027D7 RID: 10199
		private static IntPtr _ScriptStructPtr;
	}
}
