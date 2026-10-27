using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000655 RID: 1621
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathTransformBinaryOp")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRigUnit_MathTransformBinaryOp : FRigUnit_MathTransformBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005660 RID: 22112 RVA: 0x0007D218 File Offset: 0x0007B418
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathTransformBinaryOp._ScriptStructPtr != 0) ? FRigUnit_MathTransformBinaryOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathTransformBinaryOp", ref FRigUnit_MathTransformBinaryOp._ScriptStructPtr);
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x06005661 RID: 22113 RVA: 0x0007D23C File Offset: 0x0007B43C
		// (set) Token: 0x06005662 RID: 22114 RVA: 0x0007D250 File Offset: 0x0007B450
		public unsafe FTransform A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformBinaryOp.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformBinaryOp.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x06005663 RID: 22115 RVA: 0x0007D265 File Offset: 0x0007B465
		// (set) Token: 0x06005664 RID: 22116 RVA: 0x0007D279 File Offset: 0x0007B479
		public unsafe FTransform B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformBinaryOp.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformBinaryOp.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x06005665 RID: 22117 RVA: 0x0007D28E File Offset: 0x0007B48E
		// (set) Token: 0x06005666 RID: 22118 RVA: 0x0007D2A2 File Offset: 0x0007B4A2
		public unsafe FTransform Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformBinaryOp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformBinaryOp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06005667 RID: 22119 RVA: 0x0007D2B7 File Offset: 0x0007B4B7
		public FRigUnit_MathTransformBinaryOp()
		{
		}

		// Token: 0x06005668 RID: 22120 RVA: 0x0007D2BF File Offset: 0x0007B4BF
		public FRigUnit_MathTransformBinaryOp(FTransform A, FTransform B, FTransform Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x06005669 RID: 22121 RVA: 0x0007D2DC File Offset: 0x0007B4DC
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathTransformBinaryOp.StaticStruct();
		}

		// Token: 0x0600566A RID: 22122 RVA: 0x0007D2E8 File Offset: 0x0007B4E8
		[NullableContext(2)]
		public FRigUnit_MathTransformBinaryOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600566B RID: 22123 RVA: 0x0007D2F2 File Offset: 0x0007B4F2
		public FRigUnit_MathTransformBinaryOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600566C RID: 22124 RVA: 0x0007D2FD File Offset: 0x0007B4FD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathTransformBinaryOp(Pointer, false, true);
		}

		// Token: 0x0600566D RID: 22125 RVA: 0x0007D307 File Offset: 0x0007B507
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathTransformBinaryOp(Pointer, MemoryOwner);
		}

		// Token: 0x040028D6 RID: 10454
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathTransformBinaryOp";

		// Token: 0x040028D7 RID: 10455
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040028D8 RID: 10456
		internal static int __PropertyOffset_A;

		// Token: 0x040028D9 RID: 10457
		internal static int __PropertyOffset_B;

		// Token: 0x040028DA RID: 10458
		internal static int __PropertyOffset_Result;
	}
}
