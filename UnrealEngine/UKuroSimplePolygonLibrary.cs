using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200045E RID: 1118
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroMath.KuroSimplePolygonLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroSimplePolygonLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006B4F RID: 27471 RVA: 0x0009C3C3 File Offset: 0x0009A5C3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSimplePolygonLibrary._ClassPtr;
		}

		// Token: 0x06006B50 RID: 27472 RVA: 0x0009C3D0 File Offset: 0x0009A5D0
		public UKuroSimplePolygonLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroSimplePolygonLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006B51 RID: 27473 RVA: 0x0009C3F8 File Offset: 0x0009A5F8
		public UKuroSimplePolygonLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSimplePolygonLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006B52 RID: 27474 RVA: 0x0009C42B File Offset: 0x0009A62B
		[NullableContext(2)]
		public static void SampleSplineToPolygon(USplineComponent Spline, ref FKuroGeometrySimplePolygon Polygon, FKuroSplineSamplingOptions SamplingOptions)
		{
			UKuroSimplePolygonLibrary.__SampleSplineToPolygon_Internal((Spline != null) ? Spline.NativePtr : IntPtr.Zero, (Polygon ?? new FKuroGeometrySimplePolygon()).NativePtr, (SamplingOptions ?? new FKuroSplineSamplingOptions()).NativePtr);
		}

		// Token: 0x06006B53 RID: 27475 RVA: 0x0009C461 File Offset: 0x0009A661
		public static TArray<FVectorDouble> Conv_KuroGeometrySimplePolygonToArray([Nullable(2)] in FKuroGeometrySimplePolygon Polygon)
		{
			return new TArray<FVectorDouble>(UKuroSimplePolygonLibrary.__Conv_KuroGeometrySimplePolygonToArray_Internal((Polygon ?? new FKuroGeometrySimplePolygon()).NativePtr), null);
		}

		// Token: 0x06006B54 RID: 27476 RVA: 0x0009C47E File Offset: 0x0009A67E
		public static FKuroGeometrySimplePolygon Conv_ArrayToKuroGeometrySimplePolygon([Nullable(2)] in TArray<FVectorDouble> PathVertices)
		{
			return new FKuroGeometrySimplePolygon(UKuroSimplePolygonLibrary.__Conv_ArrayToKuroGeometrySimplePolygon_Internal((PathVertices ?? new TArray<FVectorDouble>()).NativePtr), null);
		}

		// Token: 0x06006B55 RID: 27477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SampleSplineToPolygon_Internal(IntPtr Spline, IntPtr Polygon, IntPtr SamplingOptions);

		// Token: 0x06006B56 RID: 27478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_KuroGeometrySimplePolygonToArray_Internal(IntPtr Polygon);

		// Token: 0x06006B57 RID: 27479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_ArrayToKuroGeometrySimplePolygon_Internal(IntPtr PathVertices);

		// Token: 0x06006B58 RID: 27480 RVA: 0x0009C49B File Offset: 0x0009A69B
		static UKuroSimplePolygonLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMath.KuroSimplePolygonLibrary");
		}

		// Token: 0x06006B59 RID: 27481 RVA: 0x0009C4A9 File Offset: 0x0009A6A9
		protected UKuroSimplePolygonLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002DA9 RID: 11689
		public new const string __ObjectPath = "/Script/KuroMath.KuroSimplePolygonLibrary";

		// Token: 0x04002DAA RID: 11690
		private static IntPtr _ClassPtr;

		// Token: 0x04002DAB RID: 11691
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
