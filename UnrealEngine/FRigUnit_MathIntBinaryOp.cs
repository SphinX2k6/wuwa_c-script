using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200061A RID: 1562
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntBinaryOp")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathIntBinaryOp : FRigUnit_MathIntBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005399 RID: 21401 RVA: 0x00079F81 File Offset: 0x00078181
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntBinaryOp._ScriptStructPtr != 0) ? FRigUnit_MathIntBinaryOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntBinaryOp", ref FRigUnit_MathIntBinaryOp._ScriptStructPtr);
		}

		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x0600539A RID: 21402 RVA: 0x00079FA5 File Offset: 0x000781A5
		// (set) Token: 0x0600539B RID: 21403 RVA: 0x00079FB5 File Offset: 0x000781B5
		public unsafe int A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntBinaryOp.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntBinaryOp.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x1700143F RID: 5183
		// (get) Token: 0x0600539C RID: 21404 RVA: 0x00079FC6 File Offset: 0x000781C6
		// (set) Token: 0x0600539D RID: 21405 RVA: 0x00079FD6 File Offset: 0x000781D6
		public unsafe int B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntBinaryOp.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntBinaryOp.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001440 RID: 5184
		// (get) Token: 0x0600539E RID: 21406 RVA: 0x00079FE7 File Offset: 0x000781E7
		// (set) Token: 0x0600539F RID: 21407 RVA: 0x00079FF7 File Offset: 0x000781F7
		public unsafe int Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntBinaryOp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntBinaryOp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060053A0 RID: 21408 RVA: 0x0007A008 File Offset: 0x00078208
		public FRigUnit_MathIntBinaryOp()
		{
		}

		// Token: 0x060053A1 RID: 21409 RVA: 0x0007A010 File Offset: 0x00078210
		public FRigUnit_MathIntBinaryOp(int A, int B, int Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x060053A2 RID: 21410 RVA: 0x0007A02D File Offset: 0x0007822D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntBinaryOp.StaticStruct();
		}

		// Token: 0x060053A3 RID: 21411 RVA: 0x0007A039 File Offset: 0x00078239
		[NullableContext(2)]
		public FRigUnit_MathIntBinaryOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060053A4 RID: 21412 RVA: 0x0007A043 File Offset: 0x00078243
		public FRigUnit_MathIntBinaryOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060053A5 RID: 21413 RVA: 0x0007A04E File Offset: 0x0007824E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntBinaryOp(Pointer, false, true);
		}

		// Token: 0x060053A6 RID: 21414 RVA: 0x0007A058 File Offset: 0x00078258
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntBinaryOp(Pointer, MemoryOwner);
		}

		// Token: 0x040027DA RID: 10202
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntBinaryOp";

		// Token: 0x040027DB RID: 10203
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040027DC RID: 10204
		internal static int __PropertyOffset_A;

		// Token: 0x040027DD RID: 10205
		internal static int __PropertyOffset_B;

		// Token: 0x040027DE RID: 10206
		internal static int __PropertyOffset_Result;
	}
}
