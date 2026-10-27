using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200050E RID: 1294
	[UnrealObjectPath("/Script/ControlRig.MathRBFInterpolateVectorQuat_Target")]
	[UnrealStructLayout(32, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMathRBFInterpolateVectorQuat_Target : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600438B RID: 17291 RVA: 0x000649C6 File Offset: 0x00062BC6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMathRBFInterpolateVectorQuat_Target._ScriptStructPtr != 0) ? FMathRBFInterpolateVectorQuat_Target._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.MathRBFInterpolateVectorQuat_Target", ref FMathRBFInterpolateVectorQuat_Target._ScriptStructPtr);
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x0600438C RID: 17292 RVA: 0x000649EA File Offset: 0x00062BEA
		// (set) Token: 0x0600438D RID: 17293 RVA: 0x000649FE File Offset: 0x00062BFE
		public unsafe FVector Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorQuat_Target.__PropertyOffset_Target);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorQuat_Target.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x0600438E RID: 17294 RVA: 0x00064A13 File Offset: 0x00062C13
		// (set) Token: 0x0600438F RID: 17295 RVA: 0x00064A27 File Offset: 0x00062C27
		public unsafe FQuat Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorQuat_Target.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorQuat_Target.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x00064A3C File Offset: 0x00062C3C
		public FMathRBFInterpolateVectorQuat_Target()
		{
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x00064A44 File Offset: 0x00062C44
		public FMathRBFInterpolateVectorQuat_Target(FVector Target, FQuat Value)
		{
			this.Target = Target;
			this.Value = Value;
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x00064A5A File Offset: 0x00062C5A
		protected override IntPtr GetUStructPtr()
		{
			return FMathRBFInterpolateVectorQuat_Target.StaticStruct();
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x00064A66 File Offset: 0x00062C66
		[NullableContext(2)]
		public FMathRBFInterpolateVectorQuat_Target(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x00064A70 File Offset: 0x00062C70
		public FMathRBFInterpolateVectorQuat_Target(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x00064A7B File Offset: 0x00062C7B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMathRBFInterpolateVectorQuat_Target(Pointer, false, true);
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x00064A85 File Offset: 0x00062C85
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMathRBFInterpolateVectorQuat_Target(Pointer, MemoryOwner);
		}

		// Token: 0x040020E3 RID: 8419
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.MathRBFInterpolateVectorQuat_Target";

		// Token: 0x040020E4 RID: 8420
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040020E5 RID: 8421
		internal static int __PropertyOffset_Target;

		// Token: 0x040020E6 RID: 8422
		internal static int __PropertyOffset_Value;
	}
}
