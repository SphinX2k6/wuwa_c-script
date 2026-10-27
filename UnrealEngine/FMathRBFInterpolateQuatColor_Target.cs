using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000507 RID: 1287
	[UnrealObjectPath("/Script/ControlRig.MathRBFInterpolateQuatColor_Target")]
	[UnrealStructLayout(32, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMathRBFInterpolateQuatColor_Target : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004337 RID: 17207 RVA: 0x0006445E File Offset: 0x0006265E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMathRBFInterpolateQuatColor_Target._ScriptStructPtr != 0) ? FMathRBFInterpolateQuatColor_Target._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.MathRBFInterpolateQuatColor_Target", ref FMathRBFInterpolateQuatColor_Target._ScriptStructPtr);
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x06004338 RID: 17208 RVA: 0x00064482 File Offset: 0x00062682
		// (set) Token: 0x06004339 RID: 17209 RVA: 0x00064496 File Offset: 0x00062696
		public unsafe FQuat Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatColor_Target.__PropertyOffset_Target);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatColor_Target.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x0600433A RID: 17210 RVA: 0x000644AB File Offset: 0x000626AB
		// (set) Token: 0x0600433B RID: 17211 RVA: 0x000644BF File Offset: 0x000626BF
		public unsafe FLinearColor Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatColor_Target.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatColor_Target.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x000644D4 File Offset: 0x000626D4
		public FMathRBFInterpolateQuatColor_Target()
		{
		}

		// Token: 0x0600433D RID: 17213 RVA: 0x000644DC File Offset: 0x000626DC
		public FMathRBFInterpolateQuatColor_Target(FQuat Target, FLinearColor Value)
		{
			this.Target = Target;
			this.Value = Value;
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x000644F2 File Offset: 0x000626F2
		protected override IntPtr GetUStructPtr()
		{
			return FMathRBFInterpolateQuatColor_Target.StaticStruct();
		}

		// Token: 0x0600433F RID: 17215 RVA: 0x000644FE File Offset: 0x000626FE
		[NullableContext(2)]
		public FMathRBFInterpolateQuatColor_Target(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004340 RID: 17216 RVA: 0x00064508 File Offset: 0x00062708
		public FMathRBFInterpolateQuatColor_Target(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x00064513 File Offset: 0x00062713
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMathRBFInterpolateQuatColor_Target(Pointer, false, true);
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x0006451D File Offset: 0x0006271D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMathRBFInterpolateQuatColor_Target(Pointer, MemoryOwner);
		}

		// Token: 0x040020C7 RID: 8391
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.MathRBFInterpolateQuatColor_Target";

		// Token: 0x040020C8 RID: 8392
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040020C9 RID: 8393
		internal static int __PropertyOffset_Target;

		// Token: 0x040020CA RID: 8394
		internal static int __PropertyOffset_Value;
	}
}
