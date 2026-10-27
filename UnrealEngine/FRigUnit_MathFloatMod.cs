using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000607 RID: 1543
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatMod")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatMod : FRigUnit_MathFloatBinaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060052D8 RID: 21208 RVA: 0x000793B9 File Offset: 0x000775B9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatMod._ScriptStructPtr != 0) ? FRigUnit_MathFloatMod._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatMod", ref FRigUnit_MathFloatMod._ScriptStructPtr);
		}

		// Token: 0x060052D9 RID: 21209 RVA: 0x000793DD File Offset: 0x000775DD
		public FRigUnit_MathFloatMod()
		{
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x000793E5 File Offset: 0x000775E5
		public FRigUnit_MathFloatMod(float A, float B, float Result)
		{
			base.A = A;
			base.B = B;
			base.Result = Result;
		}

		// Token: 0x060052DB RID: 21211 RVA: 0x00079402 File Offset: 0x00077602
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatMod.StaticStruct();
		}

		// Token: 0x060052DC RID: 21212 RVA: 0x0007940E File Offset: 0x0007760E
		[NullableContext(2)]
		public FRigUnit_MathFloatMod(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060052DD RID: 21213 RVA: 0x00079418 File Offset: 0x00077618
		public FRigUnit_MathFloatMod(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x00079423 File Offset: 0x00077623
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatMod(Pointer, false, true);
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x0007942D File Offset: 0x0007762D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatMod(Pointer, MemoryOwner);
		}

		// Token: 0x0400279F RID: 10143
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatMod";

		// Token: 0x040027A0 RID: 10144
		private static IntPtr _ScriptStructPtr;
	}
}
