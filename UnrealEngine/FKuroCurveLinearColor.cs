using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000360 RID: 864
	[UnrealObjectPath("/Script/KuroCurve.KuroCurveLinearColor")]
	[UnrealStructLayout(544, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 544)]
	public class FKuroCurveLinearColor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005864 RID: 22628 RVA: 0x0007C951 File Offset: 0x0007AB51
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCurveLinearColor._ScriptStructPtr != 0) ? FKuroCurveLinearColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCurve.KuroCurveLinearColor", ref FKuroCurveLinearColor._ScriptStructPtr);
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x06005865 RID: 22629 RVA: 0x0007C975 File Offset: 0x0007AB75
		// (set) Token: 0x06005866 RID: 22630 RVA: 0x0007C98E File Offset: 0x0007AB8E
		public unsafe bool bUseCurve
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCurveLinearColor.__PropertyOffset_bUseCurve) & FKuroCurveLinearColor.__PropertyMask_bUseCurve) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCurveLinearColor.__PropertyOffset_bUseCurve) = ((*(base.NativePtr + (IntPtr)FKuroCurveLinearColor.__PropertyOffset_bUseCurve) & ~FKuroCurveLinearColor.__PropertyMask_bUseCurve) | (value ? FKuroCurveLinearColor.__PropertyMask_bUseCurve : 0));
			}
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x06005867 RID: 22631 RVA: 0x0007C9BE File Offset: 0x0007ABBE
		// (set) Token: 0x06005868 RID: 22632 RVA: 0x0007C9D2 File Offset: 0x0007ABD2
		public unsafe FLinearColor Constant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCurveLinearColor.__PropertyOffset_Constant);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCurveLinearColor.__PropertyOffset_Constant) = value;
			}
		}

		// Token: 0x06005869 RID: 22633 RVA: 0x0007C9E7 File Offset: 0x0007ABE7
		public FKuroCurveLinearColor()
		{
		}

		// Token: 0x0600586A RID: 22634 RVA: 0x0007C9EF File Offset: 0x0007ABEF
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCurveLinearColor.StaticStruct();
		}

		// Token: 0x0600586B RID: 22635 RVA: 0x0007C9FB File Offset: 0x0007ABFB
		[NullableContext(2)]
		public FKuroCurveLinearColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600586C RID: 22636 RVA: 0x0007CA05 File Offset: 0x0007AC05
		public FKuroCurveLinearColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600586D RID: 22637 RVA: 0x0007CA10 File Offset: 0x0007AC10
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCurveLinearColor(Pointer, false, true);
		}

		// Token: 0x0600586E RID: 22638 RVA: 0x0007CA1A File Offset: 0x0007AC1A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCurveLinearColor(Pointer, MemoryOwner);
		}

		// Token: 0x04002481 RID: 9345
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroCurve.KuroCurveLinearColor";

		// Token: 0x04002482 RID: 9346
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002483 RID: 9347
		internal static int __PropertyOffset_bUseCurve;

		// Token: 0x04002484 RID: 9348
		internal static byte __PropertyMask_bUseCurve;

		// Token: 0x04002485 RID: 9349
		internal static int __PropertyOffset_Constant;
	}
}
