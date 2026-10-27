using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005F0 RID: 1520
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FRigUnit_MathFloatBase : FRigUnit_MathBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060051C3 RID: 20931 RVA: 0x0007829A File Offset: 0x0007649A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatBase._ScriptStructPtr != 0) ? FRigUnit_MathFloatBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatBase", ref FRigUnit_MathFloatBase._ScriptStructPtr);
		}

		// Token: 0x060051C4 RID: 20932 RVA: 0x000782BE File Offset: 0x000764BE
		public FRigUnit_MathFloatBase()
		{
		}

		// Token: 0x060051C5 RID: 20933 RVA: 0x000782C6 File Offset: 0x000764C6
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatBase.StaticStruct();
		}

		// Token: 0x060051C6 RID: 20934 RVA: 0x000782D2 File Offset: 0x000764D2
		[NullableContext(2)]
		public FRigUnit_MathFloatBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060051C7 RID: 20935 RVA: 0x000782DC File Offset: 0x000764DC
		public FRigUnit_MathFloatBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060051C8 RID: 20936 RVA: 0x000782E7 File Offset: 0x000764E7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatBase(Pointer, false, true);
		}

		// Token: 0x060051C9 RID: 20937 RVA: 0x000782F1 File Offset: 0x000764F1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatBase(Pointer, MemoryOwner);
		}

		// Token: 0x04002742 RID: 10050
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatBase";

		// Token: 0x04002743 RID: 10051
		private static IntPtr _ScriptStructPtr;
	}
}
