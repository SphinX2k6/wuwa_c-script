using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005FE RID: 1534
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatGreaterEqual")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatGreaterEqual : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600525A RID: 21082 RVA: 0x00078BA9 File Offset: 0x00076DA9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatGreaterEqual._ScriptStructPtr != 0) ? FRigUnit_MathFloatGreaterEqual._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatGreaterEqual", ref FRigUnit_MathFloatGreaterEqual._ScriptStructPtr);
		}

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x0600525B RID: 21083 RVA: 0x00078BCD File Offset: 0x00076DCD
		// (set) Token: 0x0600525C RID: 21084 RVA: 0x00078BDD File Offset: 0x00076DDD
		public unsafe float A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatGreaterEqual.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatGreaterEqual.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x0600525D RID: 21085 RVA: 0x00078BEE File Offset: 0x00076DEE
		// (set) Token: 0x0600525E RID: 21086 RVA: 0x00078BFE File Offset: 0x00076DFE
		public unsafe float B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatGreaterEqual.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatGreaterEqual.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x0600525F RID: 21087 RVA: 0x00078C0F File Offset: 0x00076E0F
		// (set) Token: 0x06005260 RID: 21088 RVA: 0x00078C1F File Offset: 0x00076E1F
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatGreaterEqual.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatGreaterEqual.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x06005261 RID: 21089 RVA: 0x00078C30 File Offset: 0x00076E30
		public FRigUnit_MathFloatGreaterEqual()
		{
		}

		// Token: 0x06005262 RID: 21090 RVA: 0x00078C38 File Offset: 0x00076E38
		public FRigUnit_MathFloatGreaterEqual(float A, float B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x06005263 RID: 21091 RVA: 0x00078C55 File Offset: 0x00076E55
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatGreaterEqual.StaticStruct();
		}

		// Token: 0x06005264 RID: 21092 RVA: 0x00078C61 File Offset: 0x00076E61
		[NullableContext(2)]
		public FRigUnit_MathFloatGreaterEqual(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005265 RID: 21093 RVA: 0x00078C6B File Offset: 0x00076E6B
		public FRigUnit_MathFloatGreaterEqual(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005266 RID: 21094 RVA: 0x00078C76 File Offset: 0x00076E76
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatGreaterEqual(Pointer, false, true);
		}

		// Token: 0x06005267 RID: 21095 RVA: 0x00078C80 File Offset: 0x00076E80
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatGreaterEqual(Pointer, MemoryOwner);
		}

		// Token: 0x04002772 RID: 10098
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatGreaterEqual";

		// Token: 0x04002773 RID: 10099
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002774 RID: 10100
		internal static int __PropertyOffset_A;

		// Token: 0x04002775 RID: 10101
		internal static int __PropertyOffset_B;

		// Token: 0x04002776 RID: 10102
		internal static int __PropertyOffset_Result;
	}
}
