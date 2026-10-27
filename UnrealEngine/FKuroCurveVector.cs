using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017F4 RID: 6132
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCurve.KuroCurveVector")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 424)]
	public class FKuroCurveVector : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016AD2 RID: 92882 RVA: 0x002117D1 File Offset: 0x0020F9D1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCurveVector._ScriptStructPtr != 0) ? FKuroCurveVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCurve.KuroCurveVector", ref FKuroCurveVector._ScriptStructPtr);
		}

		// Token: 0x17005BAC RID: 23468
		// (get) Token: 0x06016AD3 RID: 92883 RVA: 0x002117F5 File Offset: 0x0020F9F5
		// (set) Token: 0x06016AD4 RID: 92884 RVA: 0x0021180E File Offset: 0x0020FA0E
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

		// Token: 0x17005BAD RID: 23469
		// (get) Token: 0x06016AD5 RID: 92885 RVA: 0x0021183E File Offset: 0x0020FA3E
		// (set) Token: 0x06016AD6 RID: 92886 RVA: 0x00211852 File Offset: 0x0020FA52
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

		// Token: 0x17005BAE RID: 23470
		// (get) Token: 0x06016AD7 RID: 92887 RVA: 0x00211868 File Offset: 0x0020FA68
		// (set) Token: 0x06016AD8 RID: 92888 RVA: 0x002118AC File Offset: 0x0020FAAC
		public TFixedArray<FRuntimeFloatCurve> Curve
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FRuntimeFloatCurve> result;
				if ((result = this._Curve) == null)
				{
					result = (this._Curve = new TFixedArray<FRuntimeFloatCurve>(base.NativePtr + (IntPtr)FKuroCurveVector.__PropertyOffset_Curve, 3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Curve.CopyAssign(value);
			}
		}

		// Token: 0x06016AD9 RID: 92889 RVA: 0x002118BA File Offset: 0x0020FABA
		public FKuroCurveVector()
		{
		}

		// Token: 0x06016ADA RID: 92890 RVA: 0x002118C2 File Offset: 0x0020FAC2
		public FKuroCurveVector(bool bUseCurve, FVector Constant, TFixedArray<FRuntimeFloatCurve> Curve)
		{
			this.bUseCurve = bUseCurve;
			this.Constant = Constant;
			this.Curve = Curve;
		}

		// Token: 0x06016ADB RID: 92891 RVA: 0x002118DF File Offset: 0x0020FADF
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCurveVector.StaticStruct();
		}

		// Token: 0x06016ADC RID: 92892 RVA: 0x002118EB File Offset: 0x0020FAEB
		[NullableContext(2)]
		public FKuroCurveVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016ADD RID: 92893 RVA: 0x002118F5 File Offset: 0x0020FAF5
		public FKuroCurveVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016ADE RID: 92894 RVA: 0x00211900 File Offset: 0x0020FB00
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCurveVector(Pointer, false, true);
		}

		// Token: 0x06016ADF RID: 92895 RVA: 0x0021190A File Offset: 0x0020FB0A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCurveVector(Pointer, MemoryOwner);
		}

		// Token: 0x0400C4FE RID: 50430
		public const string __ObjectPath = "/Script/KuroCurve.KuroCurveVector";

		// Token: 0x0400C4FF RID: 50431
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C500 RID: 50432
		internal static int __PropertyOffset_bUseCurve;

		// Token: 0x0400C501 RID: 50433
		internal static byte __PropertyMask_bUseCurve;

		// Token: 0x0400C502 RID: 50434
		internal static int __PropertyOffset_Constant;

		// Token: 0x0400C503 RID: 50435
		internal static int __PropertyOffset_Curve;

		// Token: 0x0400C504 RID: 50436
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FRuntimeFloatCurve> _Curve;
	}
}
