using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000652 RID: 1618
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorWorkData")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRigUnit_MathRBFInterpolateVectorWorkData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005646 RID: 22086 RVA: 0x0007D02C File Offset: 0x0007B22C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathRBFInterpolateVectorWorkData._ScriptStructPtr != 0) ? FRigUnit_MathRBFInterpolateVectorWorkData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateVectorWorkData", ref FRigUnit_MathRBFInterpolateVectorWorkData._ScriptStructPtr);
		}

		// Token: 0x06005647 RID: 22087 RVA: 0x0007D050 File Offset: 0x0007B250
		public FRigUnit_MathRBFInterpolateVectorWorkData()
		{
		}

		// Token: 0x06005648 RID: 22088 RVA: 0x0007D058 File Offset: 0x0007B258
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathRBFInterpolateVectorWorkData.StaticStruct();
		}

		// Token: 0x06005649 RID: 22089 RVA: 0x0007D064 File Offset: 0x0007B264
		[NullableContext(2)]
		public FRigUnit_MathRBFInterpolateVectorWorkData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600564A RID: 22090 RVA: 0x0007D06E File Offset: 0x0007B26E
		public FRigUnit_MathRBFInterpolateVectorWorkData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600564B RID: 22091 RVA: 0x0007D079 File Offset: 0x0007B279
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathRBFInterpolateVectorWorkData(Pointer, false, true);
		}

		// Token: 0x0600564C RID: 22092 RVA: 0x0007D083 File Offset: 0x0007B283
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathRBFInterpolateVectorWorkData(Pointer, MemoryOwner);
		}

		// Token: 0x040028CD RID: 10445
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_MathRBFInterpolateVectorWorkData";

		// Token: 0x040028CE RID: 10446
		private static IntPtr _ScriptStructPtr;
	}
}
