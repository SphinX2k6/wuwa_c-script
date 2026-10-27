using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005F6 RID: 1526
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatConstPi")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathFloatConstPi : FRigUnit_MathFloatConstant, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005208 RID: 21000 RVA: 0x000786C2 File Offset: 0x000768C2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatConstPi._ScriptStructPtr != 0) ? FRigUnit_MathFloatConstPi._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatConstPi", ref FRigUnit_MathFloatConstPi._ScriptStructPtr);
		}

		// Token: 0x06005209 RID: 21001 RVA: 0x000786E6 File Offset: 0x000768E6
		public FRigUnit_MathFloatConstPi()
		{
		}

		// Token: 0x0600520A RID: 21002 RVA: 0x000786EE File Offset: 0x000768EE
		public FRigUnit_MathFloatConstPi(float Value)
		{
			base.Value = Value;
		}

		// Token: 0x0600520B RID: 21003 RVA: 0x000786FD File Offset: 0x000768FD
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatConstPi.StaticStruct();
		}

		// Token: 0x0600520C RID: 21004 RVA: 0x00078709 File Offset: 0x00076909
		[NullableContext(2)]
		public FRigUnit_MathFloatConstPi(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600520D RID: 21005 RVA: 0x00078713 File Offset: 0x00076913
		public FRigUnit_MathFloatConstPi(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600520E RID: 21006 RVA: 0x0007871E File Offset: 0x0007691E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatConstPi(Pointer, false, true);
		}

		// Token: 0x0600520F RID: 21007 RVA: 0x00078728 File Offset: 0x00076928
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatConstPi(Pointer, MemoryOwner);
		}

		// Token: 0x04002759 RID: 10073
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatConstPi";

		// Token: 0x0400275A RID: 10074
		private static IntPtr _ScriptStructPtr;
	}
}
