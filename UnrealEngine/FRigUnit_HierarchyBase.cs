using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005C3 RID: 1475
	[UnrealObjectPath("/Script/ControlRig.RigUnit_HierarchyBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigUnit_HierarchyBase : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004FB9 RID: 20409 RVA: 0x00075AB7 File Offset: 0x00073CB7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_HierarchyBase._ScriptStructPtr != 0) ? FRigUnit_HierarchyBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_HierarchyBase", ref FRigUnit_HierarchyBase._ScriptStructPtr);
		}

		// Token: 0x06004FBA RID: 20410 RVA: 0x00075ADB File Offset: 0x00073CDB
		public FRigUnit_HierarchyBase()
		{
		}

		// Token: 0x06004FBB RID: 20411 RVA: 0x00075AE3 File Offset: 0x00073CE3
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_HierarchyBase.StaticStruct();
		}

		// Token: 0x06004FBC RID: 20412 RVA: 0x00075AEF File Offset: 0x00073CEF
		[NullableContext(2)]
		public FRigUnit_HierarchyBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004FBD RID: 20413 RVA: 0x00075AF9 File Offset: 0x00073CF9
		public FRigUnit_HierarchyBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004FBE RID: 20414 RVA: 0x00075B04 File Offset: 0x00073D04
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_HierarchyBase(Pointer, false, true);
		}

		// Token: 0x06004FBF RID: 20415 RVA: 0x00075B0E File Offset: 0x00073D0E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_HierarchyBase(Pointer, MemoryOwner);
		}

		// Token: 0x04002679 RID: 9849
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_HierarchyBase";

		// Token: 0x0400267A RID: 9850
		private static IntPtr _ScriptStructPtr;
	}
}
