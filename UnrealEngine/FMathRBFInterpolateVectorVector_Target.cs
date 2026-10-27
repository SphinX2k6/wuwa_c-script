using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200050F RID: 1295
	[UnrealObjectPath("/Script/ControlRig.MathRBFInterpolateVectorVector_Target")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMathRBFInterpolateVectorVector_Target : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004397 RID: 17303 RVA: 0x00064A8E File Offset: 0x00062C8E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMathRBFInterpolateVectorVector_Target._ScriptStructPtr != 0) ? FMathRBFInterpolateVectorVector_Target._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.MathRBFInterpolateVectorVector_Target", ref FMathRBFInterpolateVectorVector_Target._ScriptStructPtr);
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06004398 RID: 17304 RVA: 0x00064AB2 File Offset: 0x00062CB2
		// (set) Token: 0x06004399 RID: 17305 RVA: 0x00064AC6 File Offset: 0x00062CC6
		public unsafe FVector Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorVector_Target.__PropertyOffset_Target);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorVector_Target.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x0600439A RID: 17306 RVA: 0x00064ADB File Offset: 0x00062CDB
		// (set) Token: 0x0600439B RID: 17307 RVA: 0x00064AEF File Offset: 0x00062CEF
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorVector_Target.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateVectorVector_Target.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x00064B04 File Offset: 0x00062D04
		public FMathRBFInterpolateVectorVector_Target()
		{
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x00064B0C File Offset: 0x00062D0C
		public FMathRBFInterpolateVectorVector_Target(FVector Target, FVector Value)
		{
			this.Target = Target;
			this.Value = Value;
		}

		// Token: 0x0600439E RID: 17310 RVA: 0x00064B22 File Offset: 0x00062D22
		protected override IntPtr GetUStructPtr()
		{
			return FMathRBFInterpolateVectorVector_Target.StaticStruct();
		}

		// Token: 0x0600439F RID: 17311 RVA: 0x00064B2E File Offset: 0x00062D2E
		[NullableContext(2)]
		public FMathRBFInterpolateVectorVector_Target(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x00064B38 File Offset: 0x00062D38
		public FMathRBFInterpolateVectorVector_Target(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x00064B43 File Offset: 0x00062D43
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMathRBFInterpolateVectorVector_Target(Pointer, false, true);
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x00064B4D File Offset: 0x00062D4D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMathRBFInterpolateVectorVector_Target(Pointer, MemoryOwner);
		}

		// Token: 0x040020E7 RID: 8423
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.MathRBFInterpolateVectorVector_Target";

		// Token: 0x040020E8 RID: 8424
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040020E9 RID: 8425
		internal static int __PropertyOffset_Target;

		// Token: 0x040020EA RID: 8426
		internal static int __PropertyOffset_Value;
	}
}
