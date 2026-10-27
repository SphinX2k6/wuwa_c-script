using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000582 RID: 1410
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DebugBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigUnit_DebugBase : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004B20 RID: 19232 RVA: 0x0006F5E4 File Offset: 0x0006D7E4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DebugBase._ScriptStructPtr != 0) ? FRigUnit_DebugBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DebugBase", ref FRigUnit_DebugBase._ScriptStructPtr);
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x0006F608 File Offset: 0x0006D808
		public FRigUnit_DebugBase()
		{
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x0006F610 File Offset: 0x0006D810
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DebugBase.StaticStruct();
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x0006F61C File Offset: 0x0006D81C
		[NullableContext(2)]
		public FRigUnit_DebugBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004B24 RID: 19236 RVA: 0x0006F626 File Offset: 0x0006D826
		public FRigUnit_DebugBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004B25 RID: 19237 RVA: 0x0006F631 File Offset: 0x0006D831
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DebugBase(Pointer, false, true);
		}

		// Token: 0x06004B26 RID: 19238 RVA: 0x0006F63B File Offset: 0x0006D83B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DebugBase(Pointer, MemoryOwner);
		}

		// Token: 0x0400246A RID: 9322
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_DebugBase";

		// Token: 0x0400246B RID: 9323
		private static IntPtr _ScriptStructPtr;
	}
}
