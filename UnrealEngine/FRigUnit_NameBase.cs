using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200069B RID: 1691
	[UnrealObjectPath("/Script/ControlRig.RigUnit_NameBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigUnit_NameBase : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060059C6 RID: 22982 RVA: 0x00080F19 File Offset: 0x0007F119
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_NameBase._ScriptStructPtr != 0) ? FRigUnit_NameBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_NameBase", ref FRigUnit_NameBase._ScriptStructPtr);
		}

		// Token: 0x060059C7 RID: 22983 RVA: 0x00080F3D File Offset: 0x0007F13D
		public FRigUnit_NameBase()
		{
		}

		// Token: 0x060059C8 RID: 22984 RVA: 0x00080F45 File Offset: 0x0007F145
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_NameBase.StaticStruct();
		}

		// Token: 0x060059C9 RID: 22985 RVA: 0x00080F51 File Offset: 0x0007F151
		[NullableContext(2)]
		public FRigUnit_NameBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060059CA RID: 22986 RVA: 0x00080F5B File Offset: 0x0007F15B
		public FRigUnit_NameBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060059CB RID: 22987 RVA: 0x00080F66 File Offset: 0x0007F166
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_NameBase(Pointer, false, true);
		}

		// Token: 0x060059CC RID: 22988 RVA: 0x00080F70 File Offset: 0x0007F170
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_NameBase(Pointer, MemoryOwner);
		}

		// Token: 0x04002A0B RID: 10763
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_NameBase";

		// Token: 0x04002A0C RID: 10764
		private static IntPtr _ScriptStructPtr;
	}
}
