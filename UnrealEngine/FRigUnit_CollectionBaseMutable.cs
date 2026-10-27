using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000566 RID: 1382
	[UnrealObjectPath("/Script/ControlRig.RigUnit_CollectionBaseMutable")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRigUnit_CollectionBaseMutable : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004980 RID: 18816 RVA: 0x0006D071 File Offset: 0x0006B271
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_CollectionBaseMutable._ScriptStructPtr != 0) ? FRigUnit_CollectionBaseMutable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_CollectionBaseMutable", ref FRigUnit_CollectionBaseMutable._ScriptStructPtr);
		}

		// Token: 0x06004981 RID: 18817 RVA: 0x0006D095 File Offset: 0x0006B295
		public FRigUnit_CollectionBaseMutable()
		{
		}

		// Token: 0x06004982 RID: 18818 RVA: 0x0006D09D File Offset: 0x0006B29D
		[NullableContext(1)]
		public FRigUnit_CollectionBaseMutable(FControlRigExecuteContext ExecuteContext)
		{
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004983 RID: 18819 RVA: 0x0006D0AC File Offset: 0x0006B2AC
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_CollectionBaseMutable.StaticStruct();
		}

		// Token: 0x06004984 RID: 18820 RVA: 0x0006D0B8 File Offset: 0x0006B2B8
		[NullableContext(2)]
		public FRigUnit_CollectionBaseMutable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004985 RID: 18821 RVA: 0x0006D0C2 File Offset: 0x0006B2C2
		public FRigUnit_CollectionBaseMutable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004986 RID: 18822 RVA: 0x0006D0CD File Offset: 0x0006B2CD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_CollectionBaseMutable(Pointer, false, true);
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x0006D0D7 File Offset: 0x0006B2D7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_CollectionBaseMutable(Pointer, MemoryOwner);
		}

		// Token: 0x040023AE RID: 9134
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_CollectionBaseMutable";

		// Token: 0x040023AF RID: 9135
		private static IntPtr _ScriptStructPtr;
	}
}
