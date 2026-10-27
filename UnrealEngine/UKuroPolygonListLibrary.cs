using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019C8 RID: 6600
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroMath.KuroPolygonListLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPolygonListLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601885D RID: 100445 RVA: 0x00241E37 File Offset: 0x00240037
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPolygonListLibrary._ClassPtr;
		}

		// Token: 0x0601885E RID: 100446 RVA: 0x00241E44 File Offset: 0x00240044
		public UKuroPolygonListLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroPolygonListLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601885F RID: 100447 RVA: 0x00241E6C File Offset: 0x0024006C
		[NullableContext(1)]
		public UKuroPolygonListLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPolygonListLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018860 RID: 100448 RVA: 0x00241E9F File Offset: 0x0024009F
		[NullableContext(1)]
		public static FKuroGeometryGeneralPolygonList PolygonsUnion([Nullable(2)] FKuroGeometryGeneralPolygonList PolygonList, bool bCopyInputOnFailure = true)
		{
			return new FKuroGeometryGeneralPolygonList(UKuroPolygonListLibrary.__PolygonsUnion_Internal((PolygonList ?? new FKuroGeometryGeneralPolygonList()).NativePtr, bCopyInputOnFailure), null);
		}

		// Token: 0x06018861 RID: 100449 RVA: 0x00241EBC File Offset: 0x002400BC
		[return: Nullable(1)]
		public static FKuroGeometryGeneralPolygonList PolygonsOpenPathsDifference(FKuroGeometryGeneralPolygonList PolygonList, FKuroGeometryGeneralPolygonList PolygonsToSubtract, double StrokeWidth, EJoinType JoinType, EEndType EndType)
		{
			return new FKuroGeometryGeneralPolygonList(UKuroPolygonListLibrary.__PolygonsOpenPathsDifference_Internal((PolygonList ?? new FKuroGeometryGeneralPolygonList()).NativePtr, (PolygonsToSubtract ?? new FKuroGeometryGeneralPolygonList()).NativePtr, StrokeWidth, JoinType, EndType), null);
		}

		// Token: 0x06018862 RID: 100450 RVA: 0x00241EEB File Offset: 0x002400EB
		[return: Nullable(1)]
		public static FKuroGeometryGeneralPolygonList PolygonsIntersection(FKuroGeometryGeneralPolygonList PolygonList, FKuroGeometryGeneralPolygonList PolygonsToIntersect)
		{
			return new FKuroGeometryGeneralPolygonList(UKuroPolygonListLibrary.__PolygonsIntersection_Internal((PolygonList ?? new FKuroGeometryGeneralPolygonList()).NativePtr, (PolygonsToIntersect ?? new FKuroGeometryGeneralPolygonList()).NativePtr), null);
		}

		// Token: 0x06018863 RID: 100451 RVA: 0x00241F16 File Offset: 0x00240116
		[return: Nullable(1)]
		public static FKuroGeometryGeneralPolygonList PolygonsExclusiveOr(FKuroGeometryGeneralPolygonList PolygonList, FKuroGeometryGeneralPolygonList PolygonsToExclusiveOr)
		{
			return new FKuroGeometryGeneralPolygonList(UKuroPolygonListLibrary.__PolygonsExclusiveOr_Internal((PolygonList ?? new FKuroGeometryGeneralPolygonList()).NativePtr, (PolygonsToExclusiveOr ?? new FKuroGeometryGeneralPolygonList()).NativePtr), null);
		}

		// Token: 0x06018864 RID: 100452 RVA: 0x00241F41 File Offset: 0x00240141
		[return: Nullable(1)]
		public static FKuroGeometryGeneralPolygonList PolygonsDifference(FKuroGeometryGeneralPolygonList PolygonList, FKuroGeometryGeneralPolygonList PolygonsToSubtract)
		{
			return new FKuroGeometryGeneralPolygonList(UKuroPolygonListLibrary.__PolygonsDifference_Internal((PolygonList ?? new FKuroGeometryGeneralPolygonList()).NativePtr, (PolygonsToSubtract ?? new FKuroGeometryGeneralPolygonList()).NativePtr), null);
		}

		// Token: 0x06018865 RID: 100453 RVA: 0x00241F6C File Offset: 0x0024016C
		[NullableContext(1)]
		public unsafe static FKuroGeometrySimplePolygon GetSimplePolygon([Nullable(2)] FKuroGeometryGeneralPolygonList PolygonList, ref bool bValidIndices, int PolygonIndex, int HoleIndex = -1)
		{
			fixed (bool* ptr = &bValidIndices)
			{
				void* ptr2 = (void*)ptr;
				return new FKuroGeometrySimplePolygon(UKuroPolygonListLibrary.__GetSimplePolygon_Internal((PolygonList ?? new FKuroGeometryGeneralPolygonList()).NativePtr, ref bValidIndices, PolygonIndex, HoleIndex), null);
			}
		}

		// Token: 0x06018866 RID: 100454 RVA: 0x00241F9B File Offset: 0x0024019B
		public static int GetPolygonCount(FKuroGeometryGeneralPolygonList PolygonList)
		{
			return UKuroPolygonListLibrary.__GetPolygonCount_Internal((PolygonList ?? new FKuroGeometryGeneralPolygonList()).NativePtr);
		}

		// Token: 0x06018867 RID: 100455 RVA: 0x00241FB1 File Offset: 0x002401B1
		[NullableContext(1)]
		public static FKuroGeometryGeneralPolygonList CreatePolygonListFromSinglePolygon([Nullable(2)] FKuroGeometrySimplePolygon OuterPolygon, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKuroGeometrySimplePolygon> HolePolygons, bool bFixHoleOrientations = true)
		{
			return new FKuroGeometryGeneralPolygonList(UKuroPolygonListLibrary.__CreatePolygonListFromSinglePolygon_Internal((OuterPolygon ?? new FKuroGeometrySimplePolygon()).NativePtr, (HolePolygons ?? new TArray<FKuroGeometrySimplePolygon>()).NativePtr, bFixHoleOrientations), null);
		}

		// Token: 0x06018868 RID: 100456 RVA: 0x00241FDE File Offset: 0x002401DE
		[NullableContext(1)]
		public static FKuroGeometryGeneralPolygonList CreatePolygonListFromSimplePolygons([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKuroGeometrySimplePolygon> OuterPolygons)
		{
			return new FKuroGeometryGeneralPolygonList(UKuroPolygonListLibrary.__CreatePolygonListFromSimplePolygons_Internal((OuterPolygons ?? new TArray<FKuroGeometrySimplePolygon>()).NativePtr), null);
		}

		// Token: 0x06018869 RID: 100457 RVA: 0x00241FFB File Offset: 0x002401FB
		public static void AppendPolygonList(ref FKuroGeometryGeneralPolygonList PolygonList, FKuroGeometryGeneralPolygonList PolygonsToAppend)
		{
			UKuroPolygonListLibrary.__AppendPolygonList_Internal((PolygonList ?? new FKuroGeometryGeneralPolygonList()).NativePtr, (PolygonsToAppend ?? new FKuroGeometryGeneralPolygonList()).NativePtr);
		}

		// Token: 0x0601886A RID: 100458 RVA: 0x00242021 File Offset: 0x00240221
		public static int AddPolygonToList(ref FKuroGeometryGeneralPolygonList PolygonList, FKuroGeometrySimplePolygon OuterPolygon, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKuroGeometrySimplePolygon> HolePolygons, bool bFixHoleOrientations = true)
		{
			return UKuroPolygonListLibrary.__AddPolygonToList_Internal((PolygonList ?? new FKuroGeometryGeneralPolygonList()).NativePtr, (OuterPolygon ?? new FKuroGeometrySimplePolygon()).NativePtr, (HolePolygons ?? new TArray<FKuroGeometrySimplePolygon>()).NativePtr, bFixHoleOrientations);
		}

		// Token: 0x0601886B RID: 100459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PolygonsUnion_Internal(IntPtr PolygonList, bool bCopyInputOnFailure);

		// Token: 0x0601886C RID: 100460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PolygonsOpenPathsDifference_Internal(IntPtr PolygonList, IntPtr PolygonsToSubtract, double StrokeWidth, EJoinType JoinType, EEndType EndType);

		// Token: 0x0601886D RID: 100461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PolygonsIntersection_Internal(IntPtr PolygonList, IntPtr PolygonsToIntersect);

		// Token: 0x0601886E RID: 100462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PolygonsExclusiveOr_Internal(IntPtr PolygonList, IntPtr PolygonsToExclusiveOr);

		// Token: 0x0601886F RID: 100463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PolygonsDifference_Internal(IntPtr PolygonList, IntPtr PolygonsToSubtract);

		// Token: 0x06018870 RID: 100464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSimplePolygon_Internal(IntPtr PolygonList, ref bool bValidIndices, int PolygonIndex, int HoleIndex);

		// Token: 0x06018871 RID: 100465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPolygonCount_Internal(IntPtr PolygonList);

		// Token: 0x06018872 RID: 100466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreatePolygonListFromSinglePolygon_Internal(IntPtr OuterPolygon, IntPtr HolePolygons, bool bFixHoleOrientations);

		// Token: 0x06018873 RID: 100467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreatePolygonListFromSimplePolygons_Internal(IntPtr OuterPolygons);

		// Token: 0x06018874 RID: 100468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AppendPolygonList_Internal(IntPtr PolygonList, IntPtr PolygonsToAppend);

		// Token: 0x06018875 RID: 100469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddPolygonToList_Internal(IntPtr PolygonList, IntPtr OuterPolygon, IntPtr HolePolygons, bool bFixHoleOrientations);

		// Token: 0x06018876 RID: 100470 RVA: 0x00242058 File Offset: 0x00240258
		static UKuroPolygonListLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMath.KuroPolygonListLibrary");
		}

		// Token: 0x06018877 RID: 100471 RVA: 0x00242066 File Offset: 0x00240266
		protected UKuroPolygonListLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D40D RID: 54285
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMath.KuroPolygonListLibrary";

		// Token: 0x0400D40E RID: 54286
		private static IntPtr _ClassPtr;

		// Token: 0x0400D40F RID: 54287
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
