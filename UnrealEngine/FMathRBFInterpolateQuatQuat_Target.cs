using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000509 RID: 1289
	[UnrealObjectPath("/Script/ControlRig.MathRBFInterpolateQuatQuat_Target")]
	[UnrealStructLayout(32, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMathRBFInterpolateQuatQuat_Target : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600434F RID: 17231 RVA: 0x000645E6 File Offset: 0x000627E6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMathRBFInterpolateQuatQuat_Target._ScriptStructPtr != 0) ? FMathRBFInterpolateQuatQuat_Target._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.MathRBFInterpolateQuatQuat_Target", ref FMathRBFInterpolateQuatQuat_Target._ScriptStructPtr);
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06004350 RID: 17232 RVA: 0x0006460A File Offset: 0x0006280A
		// (set) Token: 0x06004351 RID: 17233 RVA: 0x0006461E File Offset: 0x0006281E
		public unsafe FQuat Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatQuat_Target.__PropertyOffset_Target);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatQuat_Target.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06004352 RID: 17234 RVA: 0x00064633 File Offset: 0x00062833
		// (set) Token: 0x06004353 RID: 17235 RVA: 0x00064647 File Offset: 0x00062847
		public unsafe FQuat Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatQuat_Target.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatQuat_Target.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x0006465C File Offset: 0x0006285C
		public FMathRBFInterpolateQuatQuat_Target()
		{
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x00064664 File Offset: 0x00062864
		public FMathRBFInterpolateQuatQuat_Target(FQuat Target, FQuat Value)
		{
			this.Target = Target;
			this.Value = Value;
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x0006467A File Offset: 0x0006287A
		protected override IntPtr GetUStructPtr()
		{
			return FMathRBFInterpolateQuatQuat_Target.StaticStruct();
		}

		// Token: 0x06004357 RID: 17239 RVA: 0x00064686 File Offset: 0x00062886
		[NullableContext(2)]
		public FMathRBFInterpolateQuatQuat_Target(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004358 RID: 17240 RVA: 0x00064690 File Offset: 0x00062890
		public FMathRBFInterpolateQuatQuat_Target(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x0006469B File Offset: 0x0006289B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMathRBFInterpolateQuatQuat_Target(Pointer, false, true);
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x000646A5 File Offset: 0x000628A5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMathRBFInterpolateQuatQuat_Target(Pointer, MemoryOwner);
		}

		// Token: 0x040020CF RID: 8399
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.MathRBFInterpolateQuatQuat_Target";

		// Token: 0x040020D0 RID: 8400
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040020D1 RID: 8401
		internal static int __PropertyOffset_Target;

		// Token: 0x040020D2 RID: 8402
		internal static int __PropertyOffset_Value;
	}
}
