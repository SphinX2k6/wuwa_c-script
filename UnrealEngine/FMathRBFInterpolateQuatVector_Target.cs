using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200050A RID: 1290
	[UnrealObjectPath("/Script/ControlRig.MathRBFInterpolateQuatVector_Target")]
	[UnrealStructLayout(32, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMathRBFInterpolateQuatVector_Target : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600435B RID: 17243 RVA: 0x000646AE File Offset: 0x000628AE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMathRBFInterpolateQuatVector_Target._ScriptStructPtr != 0) ? FMathRBFInterpolateQuatVector_Target._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.MathRBFInterpolateQuatVector_Target", ref FMathRBFInterpolateQuatVector_Target._ScriptStructPtr);
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x0600435C RID: 17244 RVA: 0x000646D2 File Offset: 0x000628D2
		// (set) Token: 0x0600435D RID: 17245 RVA: 0x000646E6 File Offset: 0x000628E6
		public unsafe FQuat Target
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatVector_Target.__PropertyOffset_Target);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatVector_Target.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x17001055 RID: 4181
		// (get) Token: 0x0600435E RID: 17246 RVA: 0x000646FB File Offset: 0x000628FB
		// (set) Token: 0x0600435F RID: 17247 RVA: 0x0006470F File Offset: 0x0006290F
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatVector_Target.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMathRBFInterpolateQuatVector_Target.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x00064724 File Offset: 0x00062924
		public FMathRBFInterpolateQuatVector_Target()
		{
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x0006472C File Offset: 0x0006292C
		public FMathRBFInterpolateQuatVector_Target(FQuat Target, FVector Value)
		{
			this.Target = Target;
			this.Value = Value;
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x00064742 File Offset: 0x00062942
		protected override IntPtr GetUStructPtr()
		{
			return FMathRBFInterpolateQuatVector_Target.StaticStruct();
		}

		// Token: 0x06004363 RID: 17251 RVA: 0x0006474E File Offset: 0x0006294E
		[NullableContext(2)]
		public FMathRBFInterpolateQuatVector_Target(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004364 RID: 17252 RVA: 0x00064758 File Offset: 0x00062958
		public FMathRBFInterpolateQuatVector_Target(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004365 RID: 17253 RVA: 0x00064763 File Offset: 0x00062963
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMathRBFInterpolateQuatVector_Target(Pointer, false, true);
		}

		// Token: 0x06004366 RID: 17254 RVA: 0x0006476D File Offset: 0x0006296D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMathRBFInterpolateQuatVector_Target(Pointer, MemoryOwner);
		}

		// Token: 0x040020D3 RID: 8403
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.MathRBFInterpolateQuatVector_Target";

		// Token: 0x040020D4 RID: 8404
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040020D5 RID: 8405
		internal static int __PropertyOffset_Target;

		// Token: 0x040020D6 RID: 8406
		internal static int __PropertyOffset_Value;
	}
}
