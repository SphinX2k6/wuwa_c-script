using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017F1 RID: 6129
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCurve.KuroCurveFloat")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FKuroCurveFloat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016A9F RID: 92831 RVA: 0x002113D6 File Offset: 0x0020F5D6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCurveFloat._ScriptStructPtr != 0) ? FKuroCurveFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCurve.KuroCurveFloat", ref FKuroCurveFloat._ScriptStructPtr);
		}

		// Token: 0x17005BA6 RID: 23462
		// (get) Token: 0x06016AA0 RID: 92832 RVA: 0x002113FA File Offset: 0x0020F5FA
		// (set) Token: 0x06016AA1 RID: 92833 RVA: 0x00211413 File Offset: 0x0020F613
		public unsafe bool bUseCurve
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCurveFloat.__PropertyOffset_bUseCurve) & FKuroCurveFloat.__PropertyMask_bUseCurve) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCurveFloat.__PropertyOffset_bUseCurve) = ((*(base.NativePtr + (IntPtr)FKuroCurveFloat.__PropertyOffset_bUseCurve) & ~FKuroCurveFloat.__PropertyMask_bUseCurve) | (value ? FKuroCurveFloat.__PropertyMask_bUseCurve : 0));
			}
		}

		// Token: 0x17005BA7 RID: 23463
		// (get) Token: 0x06016AA2 RID: 92834 RVA: 0x00211443 File Offset: 0x0020F643
		// (set) Token: 0x06016AA3 RID: 92835 RVA: 0x00211453 File Offset: 0x0020F653
		public unsafe float Constant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCurveFloat.__PropertyOffset_Constant);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCurveFloat.__PropertyOffset_Constant) = value;
			}
		}

		// Token: 0x17005BA8 RID: 23464
		// (get) Token: 0x06016AA4 RID: 92836 RVA: 0x00211464 File Offset: 0x0020F664
		// (set) Token: 0x06016AA5 RID: 92837 RVA: 0x002114A7 File Offset: 0x0020F6A7
		public FRuntimeFloatCurve Curve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._Curve) == null)
				{
					result = (this._Curve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FKuroCurveFloat.__PropertyOffset_Curve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FKuroCurveFloat.__PropertyOffset_Curve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06016AA6 RID: 92838 RVA: 0x002114C8 File Offset: 0x0020F6C8
		public FKuroCurveFloat()
		{
		}

		// Token: 0x06016AA7 RID: 92839 RVA: 0x002114D0 File Offset: 0x0020F6D0
		public FKuroCurveFloat(bool bUseCurve, float Constant, FRuntimeFloatCurve Curve)
		{
			this.bUseCurve = bUseCurve;
			this.Constant = Constant;
			this.Curve = Curve;
		}

		// Token: 0x06016AA8 RID: 92840 RVA: 0x002114ED File Offset: 0x0020F6ED
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCurveFloat.StaticStruct();
		}

		// Token: 0x06016AA9 RID: 92841 RVA: 0x002114F9 File Offset: 0x0020F6F9
		[NullableContext(2)]
		public FKuroCurveFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016AAA RID: 92842 RVA: 0x00211503 File Offset: 0x0020F703
		public FKuroCurveFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016AAB RID: 92843 RVA: 0x0021150E File Offset: 0x0020F70E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCurveFloat(Pointer, false, true);
		}

		// Token: 0x06016AAC RID: 92844 RVA: 0x00211518 File Offset: 0x0020F718
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCurveFloat(Pointer, MemoryOwner);
		}

		// Token: 0x0400C4ED RID: 50413
		public const string __ObjectPath = "/Script/KuroCurve.KuroCurveFloat";

		// Token: 0x0400C4EE RID: 50414
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C4EF RID: 50415
		internal static int __PropertyOffset_bUseCurve;

		// Token: 0x0400C4F0 RID: 50416
		internal static byte __PropertyMask_bUseCurve;

		// Token: 0x0400C4F1 RID: 50417
		internal static int __PropertyOffset_Constant;

		// Token: 0x0400C4F2 RID: 50418
		internal static int __PropertyOffset_Curve;

		// Token: 0x0400C4F3 RID: 50419
		[Nullable(2)]
		private FRuntimeFloatCurve _Curve;
	}
}
