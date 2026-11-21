using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200035F RID: 863
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCurve.KuroCurveLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroCurveLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005851 RID: 22609 RVA: 0x0007C827 File Offset: 0x0007AA27
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCurveLibrary._ClassPtr;
		}

		// Token: 0x06005852 RID: 22610 RVA: 0x0007C834 File Offset: 0x0007AA34
		public UKuroCurveLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroCurveLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005853 RID: 22611 RVA: 0x0007C85C File Offset: 0x0007AA5C
		[NullableContext(1)]
		public UKuroCurveLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCurveLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06005854 RID: 22612 RVA: 0x0007C88F File Offset: 0x0007AA8F
		public static bool UseCurve_Vector(in FKuroCurveVector CurveVector)
		{
			return UKuroCurveLibrary.__UseCurve_Vector_Internal((CurveVector ?? new FKuroCurveVector()).NativePtr);
		}

		// Token: 0x06005855 RID: 22613 RVA: 0x0007C8A6 File Offset: 0x0007AAA6
		public static bool UseCurve_LinearColor(in FKuroCurveLinearColor CurveLinearColor)
		{
			return UKuroCurveLibrary.__UseCurve_LinearColor_Internal((CurveLinearColor ?? new FKuroCurveLinearColor()).NativePtr);
		}

		// Token: 0x06005856 RID: 22614 RVA: 0x0007C8BD File Offset: 0x0007AABD
		public static bool UseCurve_Float(in FKuroCurveFloat CurveFloat)
		{
			return UKuroCurveLibrary.__UseCurve_Float_Internal((CurveFloat ?? new FKuroCurveFloat()).NativePtr);
		}

		// Token: 0x06005857 RID: 22615 RVA: 0x0007C8D4 File Offset: 0x0007AAD4
		public static FVector GetValue_Vector(in FKuroCurveVector CurveVector, float Time)
		{
			return UKuroCurveLibrary.__GetValue_Vector_Internal((CurveVector ?? new FKuroCurveVector()).NativePtr, Time);
		}

		// Token: 0x06005858 RID: 22616 RVA: 0x0007C8EC File Offset: 0x0007AAEC
		public static FLinearColor GetValue_LinearColor(in FKuroCurveLinearColor CurveLinearColor, float Time)
		{
			return UKuroCurveLibrary.__GetValue_LinearColor_Internal((CurveLinearColor ?? new FKuroCurveLinearColor()).NativePtr, Time);
		}

		// Token: 0x06005859 RID: 22617 RVA: 0x0007C904 File Offset: 0x0007AB04
		public static float GetValue_Float(in FKuroCurveFloat CurveFloat, float Time)
		{
			return UKuroCurveLibrary.__GetValue_Float_Internal((CurveFloat ?? new FKuroCurveFloat()).NativePtr, Time);
		}

		// Token: 0x0600585A RID: 22618 RVA: 0x0007C91C File Offset: 0x0007AB1C
		[NullableContext(1)]
		public static FKuroCurveFloat CreateCurveFloat(bool bUseCurve, float Constant, [Nullable(2)] TArray<FVector2D> KeyValues)
		{
			return new FKuroCurveFloat(UKuroCurveLibrary.__CreateCurveFloat_Internal(bUseCurve, Constant, (KeyValues ?? new TArray<FVector2D>()).NativePtr), null);
		}

		// Token: 0x0600585B RID: 22619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __UseCurve_Vector_Internal(IntPtr CurveVector);

		// Token: 0x0600585C RID: 22620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __UseCurve_LinearColor_Internal(IntPtr CurveLinearColor);

		// Token: 0x0600585D RID: 22621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __UseCurve_Float_Internal(IntPtr CurveFloat);

		// Token: 0x0600585E RID: 22622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetValue_Vector_Internal(IntPtr CurveVector, float Time);

		// Token: 0x0600585F RID: 22623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetValue_LinearColor_Internal(IntPtr CurveLinearColor, float Time);

		// Token: 0x06005860 RID: 22624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetValue_Float_Internal(IntPtr CurveFloat, float Time);

		// Token: 0x06005861 RID: 22625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateCurveFloat_Internal(bool bUseCurve, float Constant, IntPtr KeyValues);

		// Token: 0x06005862 RID: 22626 RVA: 0x0007C93A File Offset: 0x0007AB3A
		static UKuroCurveLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCurve.KuroCurveLibrary");
		}

		// Token: 0x06005863 RID: 22627 RVA: 0x0007C948 File Offset: 0x0007AB48
		protected UKuroCurveLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400247E RID: 9342
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCurve.KuroCurveLibrary";

		// Token: 0x0400247F RID: 9343
		private static IntPtr _ClassPtr;

		// Token: 0x04002480 RID: 9344
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
