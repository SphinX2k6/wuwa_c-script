using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017F2 RID: 6130
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCurve.KuroCurveLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroCurveLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016AAD RID: 92845 RVA: 0x00211521 File Offset: 0x0020F721
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCurveLibrary._ClassPtr;
		}

		// Token: 0x06016AAE RID: 92846 RVA: 0x00211530 File Offset: 0x0020F730
		public UKuroCurveLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroCurveLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016AAF RID: 92847 RVA: 0x00211558 File Offset: 0x0020F758
		[NullableContext(1)]
		public UKuroCurveLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCurveLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016AB0 RID: 92848 RVA: 0x0021158B File Offset: 0x0020F78B
		public static bool UseCurve_Vector2D(in FKuroCurveVector2D CurveVector2D)
		{
			return UKuroCurveLibrary.__UseCurve_Vector2D_Internal((CurveVector2D ?? new FKuroCurveVector2D()).NativePtr);
		}

		// Token: 0x06016AB1 RID: 92849 RVA: 0x002115A2 File Offset: 0x0020F7A2
		public static bool UseCurve_Vector(in FKuroCurveVector CurveVector)
		{
			return UKuroCurveLibrary.__UseCurve_Vector_Internal((CurveVector ?? new FKuroCurveVector()).NativePtr);
		}

		// Token: 0x06016AB2 RID: 92850 RVA: 0x002115B9 File Offset: 0x0020F7B9
		public static bool UseCurve_LinearColor(in FKuroCurveLinearColor CurveLinearColor)
		{
			return UKuroCurveLibrary.__UseCurve_LinearColor_Internal((CurveLinearColor ?? new FKuroCurveLinearColor()).NativePtr);
		}

		// Token: 0x06016AB3 RID: 92851 RVA: 0x002115D0 File Offset: 0x0020F7D0
		public static bool UseCurve_Float(in FKuroCurveFloat CurveFloat)
		{
			return UKuroCurveLibrary.__UseCurve_Float_Internal((CurveFloat ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x06016AB4 RID: 92852 RVA: 0x002115E7 File Offset: 0x0020F7E7
		public static FVector2D GetValue_Vector2D(in FKuroCurveVector2D CurveVector2D, float Time)
		{
			return UKuroCurveLibrary.__GetValue_Vector2D_Internal((CurveVector2D ?? new FKuroCurveVector2D()).NativePtr, Time);
		}

		// Token: 0x06016AB5 RID: 92853 RVA: 0x002115FF File Offset: 0x0020F7FF
		public static FVector GetValue_Vector(in FKuroCurveVector CurveVector, float Time)
		{
			return UKuroCurveLibrary.__GetValue_Vector_Internal((CurveVector ?? new FKuroCurveVector()).NativePtr, Time);
		}

		// Token: 0x06016AB6 RID: 92854 RVA: 0x00211617 File Offset: 0x0020F817
		public static FLinearColor GetValue_LinearColor(in FKuroCurveLinearColor CurveLinearColor, float Time)
		{
			return UKuroCurveLibrary.__GetValue_LinearColor_Internal((CurveLinearColor ?? new FKuroCurveLinearColor()).NativePtr, Time);
		}

		// Token: 0x06016AB7 RID: 92855 RVA: 0x0021162F File Offset: 0x0020F82F
		public static float GetValue_Float(in FKuroCurveFloat CurveFloat, float Time)
		{
			return UKuroCurveLibrary.__GetValue_Float_Internal((CurveFloat ?? new FKuroCurveFloat()).NativePtr, Time);
		}

		// Token: 0x06016AB8 RID: 92856 RVA: 0x00211647 File Offset: 0x0020F847
		[NullableContext(1)]
		public static FKuroCurveFloat CreateCurveFloat(bool bUseCurve, float Constant, [Nullable(2)] TArray<FVector2D> KeyValues)
		{
			return new FKuroCurveFloat(UKuroCurveLibrary.__CreateCurveFloat_Internal(bUseCurve, Constant, (KeyValues ?? new TArray<FVector2D>()).NativePtr), null);
		}

		// Token: 0x06016AB9 RID: 92857
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __UseCurve_Vector2D_Internal(IntPtr CurveVector2D);

		// Token: 0x06016ABA RID: 92858
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __UseCurve_Vector_Internal(IntPtr CurveVector);

		// Token: 0x06016ABB RID: 92859
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __UseCurve_LinearColor_Internal(IntPtr CurveLinearColor);

		// Token: 0x06016ABC RID: 92860
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __UseCurve_Float_Internal(IntPtr CurveFloat);

		// Token: 0x06016ABD RID: 92861
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetValue_Vector2D_Internal(IntPtr CurveVector2D, float Time);

		// Token: 0x06016ABE RID: 92862
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetValue_Vector_Internal(IntPtr CurveVector, float Time);

		// Token: 0x06016ABF RID: 92863
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetValue_LinearColor_Internal(IntPtr CurveLinearColor, float Time);

		// Token: 0x06016AC0 RID: 92864
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetValue_Float_Internal(IntPtr CurveFloat, float Time);

		// Token: 0x06016AC1 RID: 92865
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateCurveFloat_Internal(bool bUseCurve, float Constant, IntPtr KeyValues);

		// Token: 0x06016AC2 RID: 92866 RVA: 0x00211665 File Offset: 0x0020F865
		static UKuroCurveLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCurve.KuroCurveLibrary");
		}

		// Token: 0x06016AC3 RID: 92867 RVA: 0x00211673 File Offset: 0x0020F873
		protected UKuroCurveLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C4F4 RID: 50420
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCurve.KuroCurveLibrary";

		// Token: 0x0400C4F5 RID: 50421
		private static IntPtr _ClassPtr;

		// Token: 0x0400C4F6 RID: 50422
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
