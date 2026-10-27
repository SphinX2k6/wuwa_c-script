using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017F3 RID: 6131
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCurve.KuroCurveLinearColor")]
	[UnrealStructLayout(544, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 544)]
	public class FKuroCurveLinearColor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016AC4 RID: 92868 RVA: 0x0021167C File Offset: 0x0020F87C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCurveLinearColor._ScriptStructPtr != 0) ? FKuroCurveLinearColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCurve.KuroCurveLinearColor", ref FKuroCurveLinearColor._ScriptStructPtr);
		}

		// Token: 0x17005BA9 RID: 23465
		// (get) Token: 0x06016AC5 RID: 92869 RVA: 0x002116A0 File Offset: 0x0020F8A0
		// (set) Token: 0x06016AC6 RID: 92870 RVA: 0x002116B9 File Offset: 0x0020F8B9
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

		// Token: 0x17005BAA RID: 23466
		// (get) Token: 0x06016AC7 RID: 92871 RVA: 0x002116E9 File Offset: 0x0020F8E9
		// (set) Token: 0x06016AC8 RID: 92872 RVA: 0x002116FD File Offset: 0x0020F8FD
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

		// Token: 0x17005BAB RID: 23467
		// (get) Token: 0x06016AC9 RID: 92873 RVA: 0x00211714 File Offset: 0x0020F914
		// (set) Token: 0x06016ACA RID: 92874 RVA: 0x00211757 File Offset: 0x0020F957
		public FRuntimeCurveLinearColor Curve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeCurveLinearColor result;
				if ((result = this._Curve) == null)
				{
					result = (this._Curve = new FRuntimeCurveLinearColor(base.NativePtr + (IntPtr)FKuroCurveLinearColor.__PropertyOffset_Curve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeCurveLinearColor.StaticStruct(), base.NativePtr + (IntPtr)FKuroCurveLinearColor.__PropertyOffset_Curve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06016ACB RID: 92875 RVA: 0x00211778 File Offset: 0x0020F978
		public FKuroCurveLinearColor()
		{
		}

		// Token: 0x06016ACC RID: 92876 RVA: 0x00211780 File Offset: 0x0020F980
		public FKuroCurveLinearColor(bool bUseCurve, FLinearColor Constant, FRuntimeCurveLinearColor Curve)
		{
			this.bUseCurve = bUseCurve;
			this.Constant = Constant;
			this.Curve = Curve;
		}

		// Token: 0x06016ACD RID: 92877 RVA: 0x0021179D File Offset: 0x0020F99D
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCurveLinearColor.StaticStruct();
		}

		// Token: 0x06016ACE RID: 92878 RVA: 0x002117A9 File Offset: 0x0020F9A9
		[NullableContext(2)]
		public FKuroCurveLinearColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016ACF RID: 92879 RVA: 0x002117B3 File Offset: 0x0020F9B3
		public FKuroCurveLinearColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016AD0 RID: 92880 RVA: 0x002117BE File Offset: 0x0020F9BE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCurveLinearColor(Pointer, false, true);
		}

		// Token: 0x06016AD1 RID: 92881 RVA: 0x002117C8 File Offset: 0x0020F9C8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCurveLinearColor(Pointer, MemoryOwner);
		}

		// Token: 0x0400C4F7 RID: 50423
		public const string __ObjectPath = "/Script/KuroCurve.KuroCurveLinearColor";

		// Token: 0x0400C4F8 RID: 50424
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C4F9 RID: 50425
		internal static int __PropertyOffset_bUseCurve;

		// Token: 0x0400C4FA RID: 50426
		internal static byte __PropertyMask_bUseCurve;

		// Token: 0x0400C4FB RID: 50427
		internal static int __PropertyOffset_Constant;

		// Token: 0x0400C4FC RID: 50428
		internal static int __PropertyOffset_Curve;

		// Token: 0x0400C4FD RID: 50429
		[Nullable(2)]
		private FRuntimeCurveLinearColor _Curve;
	}
}
