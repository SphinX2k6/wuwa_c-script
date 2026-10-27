using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019C9 RID: 6601
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroMath.KuroSimplePolygonLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroSimplePolygonLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018878 RID: 100472 RVA: 0x0024206F File Offset: 0x0024026F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSimplePolygonLibrary._ClassPtr;
		}

		// Token: 0x06018879 RID: 100473 RVA: 0x0024207C File Offset: 0x0024027C
		public UKuroSimplePolygonLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroSimplePolygonLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601887A RID: 100474 RVA: 0x002420A4 File Offset: 0x002402A4
		public UKuroSimplePolygonLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSimplePolygonLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601887B RID: 100475 RVA: 0x002420D7 File Offset: 0x002402D7
		[NullableContext(2)]
		public static void SampleSplineToPolygon(USplineComponent Spline, ref FKuroGeometrySimplePolygon Polygon, FKuroSplineSamplingOptions SamplingOptions)
		{
			UKuroSimplePolygonLibrary.__SampleSplineToPolygon_Internal((Spline != null) ? Spline.NativePtr : IntPtr.Zero, (Polygon ?? new FKuroGeometrySimplePolygon()).NativePtr, (SamplingOptions ?? new FKuroSplineSamplingOptions()).NativePtr);
		}

		// Token: 0x0601887C RID: 100476 RVA: 0x0024210D File Offset: 0x0024030D
		public static TArray<FVectorDouble> Conv_KuroGeometrySimplePolygonToArray([Nullable(2)] in FKuroGeometrySimplePolygon Polygon)
		{
			return new TArray<FVectorDouble>(UKuroSimplePolygonLibrary.__Conv_KuroGeometrySimplePolygonToArray_Internal((Polygon ?? new FKuroGeometrySimplePolygon()).NativePtr), null);
		}

		// Token: 0x0601887D RID: 100477 RVA: 0x0024212A File Offset: 0x0024032A
		public static FKuroGeometrySimplePolygon Conv_ArrayToKuroGeometrySimplePolygon([Nullable(2)] in TArray<FVectorDouble> PathVertices)
		{
			return new FKuroGeometrySimplePolygon(UKuroSimplePolygonLibrary.__Conv_ArrayToKuroGeometrySimplePolygon_Internal((PathVertices ?? new TArray<FVectorDouble>()).NativePtr), null);
		}

		// Token: 0x0601887E RID: 100478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SampleSplineToPolygon_Internal(IntPtr Spline, IntPtr Polygon, IntPtr SamplingOptions);

		// Token: 0x0601887F RID: 100479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_KuroGeometrySimplePolygonToArray_Internal(IntPtr Polygon);

		// Token: 0x06018880 RID: 100480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_ArrayToKuroGeometrySimplePolygon_Internal(IntPtr PathVertices);

		// Token: 0x06018881 RID: 100481 RVA: 0x00242147 File Offset: 0x00240347
		static UKuroSimplePolygonLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMath.KuroSimplePolygonLibrary");
		}

		// Token: 0x06018882 RID: 100482 RVA: 0x00242155 File Offset: 0x00240355
		protected UKuroSimplePolygonLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D410 RID: 54288
		public new const string __ObjectPath = "/Script/KuroMath.KuroSimplePolygonLibrary";

		// Token: 0x0400D411 RID: 54289
		private static IntPtr _ClassPtr;

		// Token: 0x0400D412 RID: 54290
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
