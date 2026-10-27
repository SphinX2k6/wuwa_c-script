using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200050D RID: 1293
	[UnrealObjectPath("/Script/ControlRig.MathRBFInterpolateVectorFloat_Target")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMathRBFInterpolateVectorFloat_Target : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600437F RID: 17279 RVA: 0x00064906 File Offset: 0x00062B06
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMathRBFInterpolateVectorFloat_Target._ScriptStructPtr != 0) ? FMathRBFInterpolateVectorFloat_Target._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.MathRBFInterpolateVectorFloat_Target", ref FMathRBFInterpolateVectorFloat_Target._ScriptStructPtr);
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x06004380 RID: 17280 RVA: 0x0006492A File Offset: 0x00062B2A
		// (set) Token: 0x06004381 RID: 17281 RVA: 0x0006493E File Offset: 0x00062B3E
		public unsafe FVector Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorFloat_Target.__PropertyOffset_Target);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorFloat_Target.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x06004382 RID: 17282 RVA: 0x00064953 File Offset: 0x00062B53
		// (set) Token: 0x06004383 RID: 17283 RVA: 0x00064963 File Offset: 0x00062B63
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorFloat_Target.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorFloat_Target.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x00064974 File Offset: 0x00062B74
		public FMathRBFInterpolateVectorFloat_Target()
		{
		}

		// Token: 0x06004385 RID: 17285 RVA: 0x0006497C File Offset: 0x00062B7C
		public FMathRBFInterpolateVectorFloat_Target(FVector Target, float Value)
		{
			this.Target = Target;
			this.Value = Value;
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x00064992 File Offset: 0x00062B92
		protected override IntPtr GetUStructPtr()
		{
			return FMathRBFInterpolateVectorFloat_Target.StaticStruct();
		}

		// Token: 0x06004387 RID: 17287 RVA: 0x0006499E File Offset: 0x00062B9E
		[NullableContext(2)]
		public FMathRBFInterpolateVectorFloat_Target(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004388 RID: 17288 RVA: 0x000649A8 File Offset: 0x00062BA8
		public FMathRBFInterpolateVectorFloat_Target(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x000649B3 File Offset: 0x00062BB3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMathRBFInterpolateVectorFloat_Target(Pointer, false, true);
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x000649BD File Offset: 0x00062BBD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMathRBFInterpolateVectorFloat_Target(Pointer, MemoryOwner);
		}

		// Token: 0x040020DF RID: 8415
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.MathRBFInterpolateVectorFloat_Target";

		// Token: 0x040020E0 RID: 8416
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040020E1 RID: 8417
		internal static int __PropertyOffset_Target;

		// Token: 0x040020E2 RID: 8418
		internal static int __PropertyOffset_Value;
	}
}
