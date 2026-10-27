using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017F5 RID: 6133
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCurve.KuroCurveVector2D")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 288)]
	public class FKuroCurveVector2D : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016AE0 RID: 92896 RVA: 0x00211913 File Offset: 0x0020FB13
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCurveVector2D._ScriptStructPtr != 0) ? FKuroCurveVector2D._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCurve.KuroCurveVector2D", ref FKuroCurveVector2D._ScriptStructPtr);
		}

		// Token: 0x17005BAF RID: 23471
		// (get) Token: 0x06016AE1 RID: 92897 RVA: 0x00211937 File Offset: 0x0020FB37
		// (set) Token: 0x06016AE2 RID: 92898 RVA: 0x00211950 File Offset: 0x0020FB50
		public unsafe bool bUseCurve
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCurveVector2D.__PropertyOffset_bUseCurve) & FKuroCurveVector2D.__PropertyMask_bUseCurve) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCurveVector2D.__PropertyOffset_bUseCurve) = ((*(base.NativePtr + (IntPtr)FKuroCurveVector2D.__PropertyOffset_bUseCurve) & ~FKuroCurveVector2D.__PropertyMask_bUseCurve) | (value ? FKuroCurveVector2D.__PropertyMask_bUseCurve : 0));
			}
		}

		// Token: 0x17005BB0 RID: 23472
		// (get) Token: 0x06016AE3 RID: 92899 RVA: 0x00211980 File Offset: 0x0020FB80
		// (set) Token: 0x06016AE4 RID: 92900 RVA: 0x00211994 File Offset: 0x0020FB94
		public unsafe FVector2D Constant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCurveVector2D.__PropertyOffset_Constant);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCurveVector2D.__PropertyOffset_Constant) = value;
			}
		}

		// Token: 0x17005BB1 RID: 23473
		// (get) Token: 0x06016AE5 RID: 92901 RVA: 0x002119AC File Offset: 0x0020FBAC
		// (set) Token: 0x06016AE6 RID: 92902 RVA: 0x002119F0 File Offset: 0x0020FBF0
		public TFixedArray<FRuntimeFloatCurve> Curve
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FRuntimeFloatCurve> result;
				if ((result = this._Curve) == null)
				{
					result = (this._Curve = new TFixedArray<FRuntimeFloatCurve>(base.NativePtr + (IntPtr)FKuroCurveVector2D.__PropertyOffset_Curve, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Curve.CopyAssign(value);
			}
		}

		// Token: 0x06016AE7 RID: 92903 RVA: 0x002119FE File Offset: 0x0020FBFE
		public FKuroCurveVector2D()
		{
		}

		// Token: 0x06016AE8 RID: 92904 RVA: 0x00211A06 File Offset: 0x0020FC06
		public FKuroCurveVector2D(bool bUseCurve, FVector2D Constant, TFixedArray<FRuntimeFloatCurve> Curve)
		{
			this.bUseCurve = bUseCurve;
			this.Constant = Constant;
			this.Curve = Curve;
		}

		// Token: 0x06016AE9 RID: 92905 RVA: 0x00211A23 File Offset: 0x0020FC23
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCurveVector2D.StaticStruct();
		}

		// Token: 0x06016AEA RID: 92906 RVA: 0x00211A2F File Offset: 0x0020FC2F
		[NullableContext(2)]
		public FKuroCurveVector2D(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016AEB RID: 92907 RVA: 0x00211A39 File Offset: 0x0020FC39
		public FKuroCurveVector2D(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016AEC RID: 92908 RVA: 0x00211A44 File Offset: 0x0020FC44
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCurveVector2D(Pointer, false, true);
		}

		// Token: 0x06016AED RID: 92909 RVA: 0x00211A4E File Offset: 0x0020FC4E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCurveVector2D(Pointer, MemoryOwner);
		}

		// Token: 0x0400C505 RID: 50437
		public const string __ObjectPath = "/Script/KuroCurve.KuroCurveVector2D";

		// Token: 0x0400C506 RID: 50438
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C507 RID: 50439
		internal static int __PropertyOffset_bUseCurve;

		// Token: 0x0400C508 RID: 50440
		internal static byte __PropertyMask_bUseCurve;

		// Token: 0x0400C509 RID: 50441
		internal static int __PropertyOffset_Constant;

		// Token: 0x0400C50A RID: 50442
		internal static int __PropertyOffset_Curve;

		// Token: 0x0400C50B RID: 50443
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FRuntimeFloatCurve> _Curve;
	}
}
