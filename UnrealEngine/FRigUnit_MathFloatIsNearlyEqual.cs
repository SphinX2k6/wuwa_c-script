using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005FF RID: 1535
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatIsNearlyEqual")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatIsNearlyEqual : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005268 RID: 21096 RVA: 0x00078C89 File Offset: 0x00076E89
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatIsNearlyEqual._ScriptStructPtr != 0) ? FRigUnit_MathFloatIsNearlyEqual._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatIsNearlyEqual", ref FRigUnit_MathFloatIsNearlyEqual._ScriptStructPtr);
		}

		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x06005269 RID: 21097 RVA: 0x00078CAD File Offset: 0x00076EAD
		// (set) Token: 0x0600526A RID: 21098 RVA: 0x00078CBD File Offset: 0x00076EBD
		public unsafe float A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatIsNearlyEqual.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatIsNearlyEqual.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x0600526B RID: 21099 RVA: 0x00078CCE File Offset: 0x00076ECE
		// (set) Token: 0x0600526C RID: 21100 RVA: 0x00078CDE File Offset: 0x00076EDE
		public unsafe float B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatIsNearlyEqual.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatIsNearlyEqual.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x0600526D RID: 21101 RVA: 0x00078CEF File Offset: 0x00076EEF
		// (set) Token: 0x0600526E RID: 21102 RVA: 0x00078CFF File Offset: 0x00076EFF
		public unsafe float Tolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatIsNearlyEqual.__PropertyOffset_Tolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatIsNearlyEqual.__PropertyOffset_Tolerance) = value;
			}
		}

		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x0600526F RID: 21103 RVA: 0x00078D10 File Offset: 0x00076F10
		// (set) Token: 0x06005270 RID: 21104 RVA: 0x00078D20 File Offset: 0x00076F20
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatIsNearlyEqual.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatIsNearlyEqual.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x06005271 RID: 21105 RVA: 0x00078D31 File Offset: 0x00076F31
		public FRigUnit_MathFloatIsNearlyEqual()
		{
		}

		// Token: 0x06005272 RID: 21106 RVA: 0x00078D39 File Offset: 0x00076F39
		public FRigUnit_MathFloatIsNearlyEqual(float A, float B, float Tolerance, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Tolerance = Tolerance;
			this.Result = Result;
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x00078D5E File Offset: 0x00076F5E
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatIsNearlyEqual.StaticStruct();
		}

		// Token: 0x06005274 RID: 21108 RVA: 0x00078D6A File Offset: 0x00076F6A
		[NullableContext(2)]
		public FRigUnit_MathFloatIsNearlyEqual(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005275 RID: 21109 RVA: 0x00078D74 File Offset: 0x00076F74
		public FRigUnit_MathFloatIsNearlyEqual(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005276 RID: 21110 RVA: 0x00078D7F File Offset: 0x00076F7F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatIsNearlyEqual(Pointer, false, true);
		}

		// Token: 0x06005277 RID: 21111 RVA: 0x00078D89 File Offset: 0x00076F89
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatIsNearlyEqual(Pointer, MemoryOwner);
		}

		// Token: 0x04002777 RID: 10103
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatIsNearlyEqual";

		// Token: 0x04002778 RID: 10104
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002779 RID: 10105
		internal static int __PropertyOffset_A;

		// Token: 0x0400277A RID: 10106
		internal static int __PropertyOffset_B;

		// Token: 0x0400277B RID: 10107
		internal static int __PropertyOffset_Tolerance;

		// Token: 0x0400277C RID: 10108
		internal static int __PropertyOffset_Result;
	}
}
