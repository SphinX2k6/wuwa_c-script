using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005F7 RID: 1527
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatConstTwoPi")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathFloatConstTwoPi : FRigUnit_MathFloatConstant, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005210 RID: 21008 RVA: 0x00078731 File Offset: 0x00076931
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatConstTwoPi._ScriptStructPtr != 0) ? FRigUnit_MathFloatConstTwoPi._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatConstTwoPi", ref FRigUnit_MathFloatConstTwoPi._ScriptStructPtr);
		}

		// Token: 0x06005211 RID: 21009 RVA: 0x00078755 File Offset: 0x00076955
		public FRigUnit_MathFloatConstTwoPi()
		{
		}

		// Token: 0x06005212 RID: 21010 RVA: 0x0007875D File Offset: 0x0007695D
		public FRigUnit_MathFloatConstTwoPi(float Value)
		{
			base.Value = Value;
		}

		// Token: 0x06005213 RID: 21011 RVA: 0x0007876C File Offset: 0x0007696C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatConstTwoPi.StaticStruct();
		}

		// Token: 0x06005214 RID: 21012 RVA: 0x00078778 File Offset: 0x00076978
		[NullableContext(2)]
		public FRigUnit_MathFloatConstTwoPi(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005215 RID: 21013 RVA: 0x00078782 File Offset: 0x00076982
		public FRigUnit_MathFloatConstTwoPi(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005216 RID: 21014 RVA: 0x0007878D File Offset: 0x0007698D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatConstTwoPi(Pointer, false, true);
		}

		// Token: 0x06005217 RID: 21015 RVA: 0x00078797 File Offset: 0x00076997
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatConstTwoPi(Pointer, MemoryOwner);
		}

		// Token: 0x0400275B RID: 10075
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatConstTwoPi";

		// Token: 0x0400275C RID: 10076
		private static IntPtr _ScriptStructPtr;
	}
}
