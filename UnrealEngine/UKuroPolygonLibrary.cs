using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019C7 RID: 6599
	[UnrealObjectPath("/Script/KuroMath.KuroPolygonLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPolygonLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018854 RID: 100436 RVA: 0x00241D72 File Offset: 0x0023FF72
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPolygonLibrary._ClassPtr;
		}

		// Token: 0x06018855 RID: 100437 RVA: 0x00241D80 File Offset: 0x0023FF80
		public UKuroPolygonLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroPolygonLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018856 RID: 100438 RVA: 0x00241DA8 File Offset: 0x0023FFA8
		[NullableContext(1)]
		public UKuroPolygonLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPolygonLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018857 RID: 100439 RVA: 0x00241DDB File Offset: 0x0023FFDB
		public static void EliminateSplineGaps([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<USplineComponent> Splines, float Tolerance = 1f)
		{
			UKuroPolygonLibrary.__EliminateSplineGaps_Internal((Splines ?? new TArray<USplineComponent>()).NativePtr, Tolerance);
		}

		// Token: 0x06018858 RID: 100440 RVA: 0x00241DF3 File Offset: 0x0023FFF3
		[NullableContext(2)]
		[return: Nullable(1)]
		public static TArray<FVector2D> ClipPolygonByWeilerAtherton(ref TArray<FVector2D> Polygon, ref TArray<FVector2D> Window)
		{
			return new TArray<FVector2D>(UKuroPolygonLibrary.__ClipPolygonByWeilerAtherton_Internal((Polygon ?? new TArray<FVector2D>()).NativePtr, (Window ?? new TArray<FVector2D>()).NativePtr), null);
		}

		// Token: 0x06018859 RID: 100441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EliminateSplineGaps_Internal(IntPtr Splines, float Tolerance);

		// Token: 0x0601885A RID: 100442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ClipPolygonByWeilerAtherton_Internal(IntPtr Polygon, IntPtr Window);

		// Token: 0x0601885B RID: 100443 RVA: 0x00241E20 File Offset: 0x00240020
		static UKuroPolygonLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMath.KuroPolygonLibrary");
		}

		// Token: 0x0601885C RID: 100444 RVA: 0x00241E2E File Offset: 0x0024002E
		protected UKuroPolygonLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D40A RID: 54282
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMath.KuroPolygonLibrary";

		// Token: 0x0400D40B RID: 54283
		private static IntPtr _ClassPtr;

		// Token: 0x0400D40C RID: 54284
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
