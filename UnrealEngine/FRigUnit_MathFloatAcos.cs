using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005EC RID: 1516
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatAcos")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathFloatAcos : FRigUnit_MathFloatUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060051A3 RID: 20899 RVA: 0x000780BB File Offset: 0x000762BB
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatAcos._ScriptStructPtr != 0) ? FRigUnit_MathFloatAcos._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatAcos", ref FRigUnit_MathFloatAcos._ScriptStructPtr);
		}

		// Token: 0x060051A4 RID: 20900 RVA: 0x000780DF File Offset: 0x000762DF
		public FRigUnit_MathFloatAcos()
		{
		}

		// Token: 0x060051A5 RID: 20901 RVA: 0x000780E7 File Offset: 0x000762E7
		public FRigUnit_MathFloatAcos(float Value, float Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x060051A6 RID: 20902 RVA: 0x000780FD File Offset: 0x000762FD
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatAcos.StaticStruct();
		}

		// Token: 0x060051A7 RID: 20903 RVA: 0x00078109 File Offset: 0x00076309
		[NullableContext(2)]
		public FRigUnit_MathFloatAcos(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060051A8 RID: 20904 RVA: 0x00078113 File Offset: 0x00076313
		public FRigUnit_MathFloatAcos(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060051A9 RID: 20905 RVA: 0x0007811E File Offset: 0x0007631E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatAcos(Pointer, false, true);
		}

		// Token: 0x060051AA RID: 20906 RVA: 0x00078128 File Offset: 0x00076328
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatAcos(Pointer, MemoryOwner);
		}

		// Token: 0x0400273A RID: 10042
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatAcos";

		// Token: 0x0400273B RID: 10043
		private static IntPtr _ScriptStructPtr;
	}
}
