using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000361 RID: 865
	[UnrealObjectPath("/Script/KuroCurve.KuroCurveVector")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 424)]
	public class FKuroCurveVector : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600586F RID: 22639 RVA: 0x0007CA23 File Offset: 0x0007AC23
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCurveVector._ScriptStructPtr != 0) ? FKuroCurveVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCurve.KuroCurveVector", ref FKuroCurveVector._ScriptStructPtr);
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x06005870 RID: 22640 RVA: 0x0007CA47 File Offset: 0x0007AC47
		// (set) Token: 0x06005871 RID: 22641 RVA: 0x0007CA60 File Offset: 0x0007AC60
		public unsafe bool bUseCurve
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCurveVector.__PropertyOffset_bUseCurve) & FKuroCurveVector.__PropertyMask_bUseCurve) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCurveVector.__PropertyOffset_bUseCurve) = ((*(base.NativePtr + (IntPtr)FKuroCurveVector.__PropertyOffset_bUseCurve) & ~FKuroCurveVector.__PropertyMask_bUseCurve) | (value ? FKuroCurveVector.__PropertyMask_bUseCurve : 0));
			}
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x06005872 RID: 22642 RVA: 0x0007CA90 File Offset: 0x0007AC90
		// (set) Token: 0x06005873 RID: 22643 RVA: 0x0007CAA4 File Offset: 0x0007ACA4
		public unsafe FVector Constant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCurveVector.__PropertyOffset_Constant);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCurveVector.__PropertyOffset_Constant) = value;
			}
		}

		// Token: 0x06005874 RID: 22644 RVA: 0x0007CAB9 File Offset: 0x0007ACB9
		public FKuroCurveVector()
		{
		}

		// Token: 0x06005875 RID: 22645 RVA: 0x0007CAC1 File Offset: 0x0007ACC1
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCurveVector.StaticStruct();
		}

		// Token: 0x06005876 RID: 22646 RVA: 0x0007CACD File Offset: 0x0007ACCD
		[NullableContext(2)]
		public FKuroCurveVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005877 RID: 22647 RVA: 0x0007CAD7 File Offset: 0x0007ACD7
		public FKuroCurveVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005878 RID: 22648 RVA: 0x0007CAE2 File Offset: 0x0007ACE2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCurveVector(Pointer, false, true);
		}

		// Token: 0x06005879 RID: 22649 RVA: 0x0007CAEC File Offset: 0x0007ACEC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCurveVector(Pointer, MemoryOwner);
		}

		// Token: 0x04002486 RID: 9350
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroCurve.KuroCurveVector";

		// Token: 0x04002487 RID: 9351
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002488 RID: 9352
		internal static int __PropertyOffset_bUseCurve;

		// Token: 0x04002489 RID: 9353
		internal static byte __PropertyMask_bUseCurve;

		// Token: 0x0400248A RID: 9354
		internal static int __PropertyOffset_Constant;
	}
}
