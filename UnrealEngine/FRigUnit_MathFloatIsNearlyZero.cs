using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000600 RID: 1536
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatIsNearlyZero")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatIsNearlyZero : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005278 RID: 21112 RVA: 0x00078D92 File Offset: 0x00076F92
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatIsNearlyZero._ScriptStructPtr != 0) ? FRigUnit_MathFloatIsNearlyZero._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatIsNearlyZero", ref FRigUnit_MathFloatIsNearlyZero._ScriptStructPtr);
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x06005279 RID: 21113 RVA: 0x00078DB6 File Offset: 0x00076FB6
		// (set) Token: 0x0600527A RID: 21114 RVA: 0x00078DC6 File Offset: 0x00076FC6
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatIsNearlyZero.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatIsNearlyZero.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x0600527B RID: 21115 RVA: 0x00078DD7 File Offset: 0x00076FD7
		// (set) Token: 0x0600527C RID: 21116 RVA: 0x00078DE7 File Offset: 0x00076FE7
		public unsafe float Tolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatIsNearlyZero.__PropertyOffset_Tolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatIsNearlyZero.__PropertyOffset_Tolerance) = value;
			}
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x0600527D RID: 21117 RVA: 0x00078DF8 File Offset: 0x00076FF8
		// (set) Token: 0x0600527E RID: 21118 RVA: 0x00078E08 File Offset: 0x00077008
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatIsNearlyZero.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatIsNearlyZero.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600527F RID: 21119 RVA: 0x00078E19 File Offset: 0x00077019
		public FRigUnit_MathFloatIsNearlyZero()
		{
		}

		// Token: 0x06005280 RID: 21120 RVA: 0x00078E21 File Offset: 0x00077021
		public FRigUnit_MathFloatIsNearlyZero(float Value, float Tolerance, bool Result)
		{
			this.Value = Value;
			this.Tolerance = Tolerance;
			this.Result = Result;
		}

		// Token: 0x06005281 RID: 21121 RVA: 0x00078E3E File Offset: 0x0007703E
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatIsNearlyZero.StaticStruct();
		}

		// Token: 0x06005282 RID: 21122 RVA: 0x00078E4A File Offset: 0x0007704A
		[NullableContext(2)]
		public FRigUnit_MathFloatIsNearlyZero(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005283 RID: 21123 RVA: 0x00078E54 File Offset: 0x00077054
		public FRigUnit_MathFloatIsNearlyZero(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005284 RID: 21124 RVA: 0x00078E5F File Offset: 0x0007705F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatIsNearlyZero(Pointer, false, true);
		}

		// Token: 0x06005285 RID: 21125 RVA: 0x00078E69 File Offset: 0x00077069
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatIsNearlyZero(Pointer, MemoryOwner);
		}

		// Token: 0x0400277D RID: 10109
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatIsNearlyZero";

		// Token: 0x0400277E RID: 10110
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400277F RID: 10111
		internal static int __PropertyOffset_Value;

		// Token: 0x04002780 RID: 10112
		internal static int __PropertyOffset_Tolerance;

		// Token: 0x04002781 RID: 10113
		internal static int __PropertyOffset_Result;
	}
}
