using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200045D RID: 1117
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroMath.KuroPolygonListLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPolygonListLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006B34 RID: 27444 RVA: 0x0009C189 File Offset: 0x0009A389
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPolygonListLibrary._ClassPtr;
		}

		// Token: 0x06006B35 RID: 27445 RVA: 0x0009C198 File Offset: 0x0009A398
		public UKuroPolygonListLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroPolygonListLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006B36 RID: 27446 RVA: 0x0009C1C0 File Offset: 0x0009A3C0
		[NullableContext(1)]
		public UKuroPolygonListLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPolygonListLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006B37 RID: 27447 RVA: 0x0009C1F3 File Offset: 0x0009A3F3
		[NullableContext(1)]
		public static FKuroGeometryGeneralPolygonList PolygonsUnion([Nullable(2)] FKuroGeometryGeneralPolygonList PolygonList, bool bCopyInputOnFailure = true)
		{
			return new FKuroGeometryGeneralPolygonList(UKuroPolygonListLibrary.__PolygonsUnion_Internal((PolygonList ?? new FKuroGeometryGeneralPolygonList()).NativePtr, bCopyInputOnFailure), null);
		}

		// Token: 0x06006B38 RID: 27448 RVA: 0x0009C210 File Offset: 0x0009A410
		[return: Nullable(1)]
		public static FKuroGeometryGeneralPolygonList PolygonsOpenPathsDifference(FKuroGeometryGeneralPolygonList PolygonList, FKuroGeometryGeneralPolygonList PolygonsToSubtract, double StrokeWidth, EJoinType JoinType, EEndType EndType)
		{
			return new FKuroGeometryGeneralPolygonList(UKuroPolygonListLibrary.__PolygonsOpenPathsDifference_Internal((PolygonList ?? new FKuroGeometryGeneralPolygonList()).NativePtr, (PolygonsToSubtract ?? new FKuroGeometryGeneralPolygonList()).NativePtr, StrokeWidth, JoinType, EndType), null);
		}

		// Token: 0x06006B39 RID: 27449 RVA: 0x0009C23F File Offset: 0x0009A43F
		[return: Nullable(1)]
		public static FKuroGeometryGeneralPolygonList PolygonsIntersection(FKuroGeometryGeneralPolygonList PolygonList, FKuroGeometryGeneralPolygonList PolygonsToIntersect)
		{
			return new FKuroGeometryGeneralPolygonList(UKuroPolygonListLibrary.__PolygonsIntersection_Internal((PolygonList ?? new FKuroGeometryGeneralPolygonList()).NativePtr, (PolygonsToIntersect ?? new FKuroGeometryGeneralPolygonList()).NativePtr), null);
		}

		// Token: 0x06006B3A RID: 27450 RVA: 0x0009C26A File Offset: 0x0009A46A
		[return: Nullable(1)]
		public static FKuroGeometryGeneralPolygonList PolygonsExclusiveOr(FKuroGeometryGeneralPolygonList PolygonList, FKuroGeometryGeneralPolygonList PolygonsToExclusiveOr)
		{
			return new FKuroGeometryGeneralPolygonList(UKuroPolygonListLibrary.__PolygonsExclusiveOr_Internal((PolygonList ?? new FKuroGeometryGeneralPolygonList()).NativePtr, (PolygonsToExclusiveOr ?? new FKuroGeometryGeneralPolygonList()).NativePtr), null);
		}

		// Token: 0x06006B3B RID: 27451 RVA: 0x0009C295 File Offset: 0x0009A495
		[return: Nullable(1)]
		public static FKuroGeometryGeneralPolygonList PolygonsDifference(FKuroGeometryGeneralPolygonList PolygonList, FKuroGeometryGeneralPolygonList PolygonsToSubtract)
		{
			return new FKuroGeometryGeneralPolygonList(UKuroPolygonListLibrary.__PolygonsDifference_Internal((PolygonList ?? new FKuroGeometryGeneralPolygonList()).NativePtr, (PolygonsToSubtract ?? new FKuroGeometryGeneralPolygonList()).NativePtr), null);
		}

		// Token: 0x06006B3C RID: 27452 RVA: 0x0009C2C0 File Offset: 0x0009A4C0
		[NullableContext(1)]
		public unsafe static FKuroGeometrySimplePolygon GetSimplePolygon([Nullable(2)] FKuroGeometryGeneralPolygonList PolygonList, ref bool bValidIndices, int PolygonIndex, int HoleIndex = -1)
		{
			fixed (bool* ptr = &bValidIndices)
			{
				void* ptr2 = (void*)ptr;
				return new FKuroGeometrySimplePolygon(UKuroPolygonListLibrary.__GetSimplePolygon_Internal((PolygonList ?? new FKuroGeometryGeneralPolygonList()).NativePtr, ref bValidIndices, PolygonIndex, HoleIndex), null);
			}
		}

		// Token: 0x06006B3D RID: 27453 RVA: 0x0009C2EF File Offset: 0x0009A4EF
		public static int GetPolygonCount(FKuroGeometryGeneralPolygonList PolygonList)
		{
			return UKuroPolygonListLibrary.__GetPolygonCount_Internal((PolygonList ?? new FKuroGeometryGeneralPolygonList()).NativePtr);
		}

		// Token: 0x06006B3E RID: 27454 RVA: 0x0009C305 File Offset: 0x0009A505
		[NullableContext(1)]
		public static FKuroGeometryGeneralPolygonList CreatePolygonListFromSinglePolygon([Nullable(2)] FKuroGeometrySimplePolygon OuterPolygon, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKuroGeometrySimplePolygon> HolePolygons, bool bFixHoleOrientations = true)
		{
			return new FKuroGeometryGeneralPolygonList(UKuroPolygonListLibrary.__CreatePolygonListFromSinglePolygon_Internal((OuterPolygon ?? new FKuroGeometrySimplePolygon()).NativePtr, (HolePolygons ?? new TArray<FKuroGeometrySimplePolygon>()).NativePtr, bFixHoleOrientations), null);
		}

		// Token: 0x06006B3F RID: 27455 RVA: 0x0009C332 File Offset: 0x0009A532
		[NullableContext(1)]
		public static FKuroGeometryGeneralPolygonList CreatePolygonListFromSimplePolygons([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKuroGeometrySimplePolygon> OuterPolygons)
		{
			return new FKuroGeometryGeneralPolygonList(UKuroPolygonListLibrary.__CreatePolygonListFromSimplePolygons_Internal((OuterPolygons ?? new TArray<FKuroGeometrySimplePolygon>()).NativePtr), null);
		}

		// Token: 0x06006B40 RID: 27456 RVA: 0x0009C34F File Offset: 0x0009A54F
		public static void AppendPolygonList(ref FKuroGeometryGeneralPolygonList PolygonList, FKuroGeometryGeneralPolygonList PolygonsToAppend)
		{
			UKuroPolygonListLibrary.__AppendPolygonList_Internal((PolygonList ?? new FKuroGeometryGeneralPolygonList()).NativePtr, (PolygonsToAppend ?? new FKuroGeometryGeneralPolygonList()).NativePtr);
		}

		// Token: 0x06006B41 RID: 27457 RVA: 0x0009C375 File Offset: 0x0009A575
		public static int AddPolygonToList(ref FKuroGeometryGeneralPolygonList PolygonList, FKuroGeometrySimplePolygon OuterPolygon, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKuroGeometrySimplePolygon> HolePolygons, bool bFixHoleOrientations = true)
		{
			return UKuroPolygonListLibrary.__AddPolygonToList_Internal((PolygonList ?? new FKuroGeometryGeneralPolygonList()).NativePtr, (OuterPolygon ?? new FKuroGeometrySimplePolygon()).NativePtr, (HolePolygons ?? new TArray<FKuroGeometrySimplePolygon>()).NativePtr, bFixHoleOrientations);
		}

		// Token: 0x06006B42 RID: 27458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PolygonsUnion_Internal(IntPtr PolygonList, bool bCopyInputOnFailure);

		// Token: 0x06006B43 RID: 27459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PolygonsOpenPathsDifference_Internal(IntPtr PolygonList, IntPtr PolygonsToSubtract, double StrokeWidth, EJoinType JoinType, EEndType EndType);

		// Token: 0x06006B44 RID: 27460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PolygonsIntersection_Internal(IntPtr PolygonList, IntPtr PolygonsToIntersect);

		// Token: 0x06006B45 RID: 27461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PolygonsExclusiveOr_Internal(IntPtr PolygonList, IntPtr PolygonsToExclusiveOr);

		// Token: 0x06006B46 RID: 27462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PolygonsDifference_Internal(IntPtr PolygonList, IntPtr PolygonsToSubtract);

		// Token: 0x06006B47 RID: 27463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSimplePolygon_Internal(IntPtr PolygonList, ref bool bValidIndices, int PolygonIndex, int HoleIndex);

		// Token: 0x06006B48 RID: 27464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPolygonCount_Internal(IntPtr PolygonList);

		// Token: 0x06006B49 RID: 27465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreatePolygonListFromSinglePolygon_Internal(IntPtr OuterPolygon, IntPtr HolePolygons, bool bFixHoleOrientations);

		// Token: 0x06006B4A RID: 27466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreatePolygonListFromSimplePolygons_Internal(IntPtr OuterPolygons);

		// Token: 0x06006B4B RID: 27467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AppendPolygonList_Internal(IntPtr PolygonList, IntPtr PolygonsToAppend);

		// Token: 0x06006B4C RID: 27468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddPolygonToList_Internal(IntPtr PolygonList, IntPtr OuterPolygon, IntPtr HolePolygons, bool bFixHoleOrientations);

		// Token: 0x06006B4D RID: 27469 RVA: 0x0009C3AC File Offset: 0x0009A5AC
		static UKuroPolygonListLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMath.KuroPolygonListLibrary");
		}

		// Token: 0x06006B4E RID: 27470 RVA: 0x0009C3BA File Offset: 0x0009A5BA
		protected UKuroPolygonListLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002DA6 RID: 11686
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMath.KuroPolygonListLibrary";

		// Token: 0x04002DA7 RID: 11687
		private static IntPtr _ClassPtr;

		// Token: 0x04002DA8 RID: 11688
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
