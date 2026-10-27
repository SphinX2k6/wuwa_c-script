using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000565 RID: 1381
	[UnrealObjectPath("/Script/ControlRig.RigUnit_CollectionBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigUnit_CollectionBase : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004979 RID: 18809 RVA: 0x0006D011 File Offset: 0x0006B211
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_CollectionBase._ScriptStructPtr != 0) ? FRigUnit_CollectionBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_CollectionBase", ref FRigUnit_CollectionBase._ScriptStructPtr);
		}

		// Token: 0x0600497A RID: 18810 RVA: 0x0006D035 File Offset: 0x0006B235
		public FRigUnit_CollectionBase()
		{
		}

		// Token: 0x0600497B RID: 18811 RVA: 0x0006D03D File Offset: 0x0006B23D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_CollectionBase.StaticStruct();
		}

		// Token: 0x0600497C RID: 18812 RVA: 0x0006D049 File Offset: 0x0006B249
		[NullableContext(2)]
		public FRigUnit_CollectionBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x0006D053 File Offset: 0x0006B253
		public FRigUnit_CollectionBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600497E RID: 18814 RVA: 0x0006D05E File Offset: 0x0006B25E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_CollectionBase(Pointer, false, true);
		}

		// Token: 0x0600497F RID: 18815 RVA: 0x0006D068 File Offset: 0x0006B268
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_CollectionBase(Pointer, MemoryOwner);
		}

		// Token: 0x040023AC RID: 9132
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_CollectionBase";

		// Token: 0x040023AD RID: 9133
		private static IntPtr _ScriptStructPtr;
	}
}
