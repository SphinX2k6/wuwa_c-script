using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000549 RID: 1353
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AnimBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigUnit_AnimBase : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600477E RID: 18302 RVA: 0x0006A36C File Offset: 0x0006856C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AnimBase._ScriptStructPtr != 0) ? FRigUnit_AnimBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AnimBase", ref FRigUnit_AnimBase._ScriptStructPtr);
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x0006A390 File Offset: 0x00068590
		public FRigUnit_AnimBase()
		{
		}

		// Token: 0x06004780 RID: 18304 RVA: 0x0006A398 File Offset: 0x00068598
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AnimBase.StaticStruct();
		}

		// Token: 0x06004781 RID: 18305 RVA: 0x0006A3A4 File Offset: 0x000685A4
		[NullableContext(2)]
		public FRigUnit_AnimBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x0006A3AE File Offset: 0x000685AE
		public FRigUnit_AnimBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x0006A3B9 File Offset: 0x000685B9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AnimBase(Pointer, false, true);
		}

		// Token: 0x06004784 RID: 18308 RVA: 0x0006A3C3 File Offset: 0x000685C3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AnimBase(Pointer, MemoryOwner);
		}

		// Token: 0x040022C0 RID: 8896
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AnimBase";

		// Token: 0x040022C1 RID: 8897
		private static IntPtr _ScriptStructPtr;
	}
}
