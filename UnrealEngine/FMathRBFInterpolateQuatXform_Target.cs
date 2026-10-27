using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200050B RID: 1291
	[UnrealObjectPath("/Script/ControlRig.MathRBFInterpolateQuatXform_Target")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FMathRBFInterpolateQuatXform_Target : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004367 RID: 17255 RVA: 0x00064776 File Offset: 0x00062976
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMathRBFInterpolateQuatXform_Target._ScriptStructPtr != 0) ? FMathRBFInterpolateQuatXform_Target._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.MathRBFInterpolateQuatXform_Target", ref FMathRBFInterpolateQuatXform_Target._ScriptStructPtr);
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x06004368 RID: 17256 RVA: 0x0006479A File Offset: 0x0006299A
		// (set) Token: 0x06004369 RID: 17257 RVA: 0x000647AE File Offset: 0x000629AE
		public unsafe FQuat Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatXform_Target.__PropertyOffset_Target);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatXform_Target.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x0600436A RID: 17258 RVA: 0x000647C3 File Offset: 0x000629C3
		// (set) Token: 0x0600436B RID: 17259 RVA: 0x000647D7 File Offset: 0x000629D7
		public unsafe FTransform Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatXform_Target.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatXform_Target.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x000647EC File Offset: 0x000629EC
		public FMathRBFInterpolateQuatXform_Target()
		{
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x000647F4 File Offset: 0x000629F4
		public FMathRBFInterpolateQuatXform_Target(FQuat Target, FTransform Value)
		{
			this.Target = Target;
			this.Value = Value;
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x0006480A File Offset: 0x00062A0A
		protected override IntPtr GetUStructPtr()
		{
			return FMathRBFInterpolateQuatXform_Target.StaticStruct();
		}

		// Token: 0x0600436F RID: 17263 RVA: 0x00064816 File Offset: 0x00062A16
		[NullableContext(2)]
		public FMathRBFInterpolateQuatXform_Target(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x00064820 File Offset: 0x00062A20
		public FMathRBFInterpolateQuatXform_Target(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004371 RID: 17265 RVA: 0x0006482B File Offset: 0x00062A2B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMathRBFInterpolateQuatXform_Target(Pointer, false, true);
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x00064835 File Offset: 0x00062A35
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMathRBFInterpolateQuatXform_Target(Pointer, MemoryOwner);
		}

		// Token: 0x040020D7 RID: 8407
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.MathRBFInterpolateQuatXform_Target";

		// Token: 0x040020D8 RID: 8408
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040020D9 RID: 8409
		internal static int __PropertyOffset_Target;

		// Token: 0x040020DA RID: 8410
		internal static int __PropertyOffset_Value;
	}
}
