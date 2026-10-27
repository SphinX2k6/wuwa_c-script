using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200050C RID: 1292
	[UnrealObjectPath("/Script/ControlRig.MathRBFInterpolateVectorColor_Target")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FMathRBFInterpolateVectorColor_Target : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004373 RID: 17267 RVA: 0x0006483E File Offset: 0x00062A3E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMathRBFInterpolateVectorColor_Target._ScriptStructPtr != 0) ? FMathRBFInterpolateVectorColor_Target._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.MathRBFInterpolateVectorColor_Target", ref FMathRBFInterpolateVectorColor_Target._ScriptStructPtr);
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x06004374 RID: 17268 RVA: 0x00064862 File Offset: 0x00062A62
		// (set) Token: 0x06004375 RID: 17269 RVA: 0x00064876 File Offset: 0x00062A76
		public unsafe FVector Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorColor_Target.__PropertyOffset_Target);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorColor_Target.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x06004376 RID: 17270 RVA: 0x0006488B File Offset: 0x00062A8B
		// (set) Token: 0x06004377 RID: 17271 RVA: 0x0006489F File Offset: 0x00062A9F
		public unsafe FLinearColor Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorColor_Target.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorColor_Target.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06004378 RID: 17272 RVA: 0x000648B4 File Offset: 0x00062AB4
		public FMathRBFInterpolateVectorColor_Target()
		{
		}

		// Token: 0x06004379 RID: 17273 RVA: 0x000648BC File Offset: 0x00062ABC
		public FMathRBFInterpolateVectorColor_Target(FVector Target, FLinearColor Value)
		{
			this.Target = Target;
			this.Value = Value;
		}

		// Token: 0x0600437A RID: 17274 RVA: 0x000648D2 File Offset: 0x00062AD2
		protected override IntPtr GetUStructPtr()
		{
			return FMathRBFInterpolateVectorColor_Target.StaticStruct();
		}

		// Token: 0x0600437B RID: 17275 RVA: 0x000648DE File Offset: 0x00062ADE
		[NullableContext(2)]
		public FMathRBFInterpolateVectorColor_Target(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600437C RID: 17276 RVA: 0x000648E8 File Offset: 0x00062AE8
		public FMathRBFInterpolateVectorColor_Target(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600437D RID: 17277 RVA: 0x000648F3 File Offset: 0x00062AF3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMathRBFInterpolateVectorColor_Target(Pointer, false, true);
		}

		// Token: 0x0600437E RID: 17278 RVA: 0x000648FD File Offset: 0x00062AFD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMathRBFInterpolateVectorColor_Target(Pointer, MemoryOwner);
		}

		// Token: 0x040020DB RID: 8411
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.MathRBFInterpolateVectorColor_Target";

		// Token: 0x040020DC RID: 8412
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040020DD RID: 8413
		internal static int __PropertyOffset_Target;

		// Token: 0x040020DE RID: 8414
		internal static int __PropertyOffset_Value;
	}
}
