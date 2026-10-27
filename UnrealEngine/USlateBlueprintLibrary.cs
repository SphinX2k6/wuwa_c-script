using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029D9 RID: 10713
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.SlateBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class USlateBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027A2B RID: 162347 RVA: 0x003C72D5 File Offset: 0x003C54D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USlateBlueprintLibrary._ClassPtr;
		}

		// Token: 0x06027A2C RID: 162348 RVA: 0x003C72E4 File Offset: 0x003C54E4
		public USlateBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(USlateBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027A2D RID: 162349 RVA: 0x003C730C File Offset: 0x003C550C
		[NullableContext(1)]
		public USlateBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USlateBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027A2E RID: 162350 RVA: 0x003C733F File Offset: 0x003C553F
		public static FVector2D TransformVectorLocalToAbsolute(in FGeometry Geometry, FVector2D LocalVector)
		{
			return USlateBlueprintLibrary.__TransformVectorLocalToAbsolute_Internal((Geometry ?? new FGeometry()).NativePtr, LocalVector);
		}

		// Token: 0x06027A2F RID: 162351 RVA: 0x003C7357 File Offset: 0x003C5557
		public static FVector2D TransformVectorAbsoluteToLocal(in FGeometry Geometry, FVector2D AbsoluteVector)
		{
			return USlateBlueprintLibrary.__TransformVectorAbsoluteToLocal_Internal((Geometry ?? new FGeometry()).NativePtr, AbsoluteVector);
		}

		// Token: 0x06027A30 RID: 162352 RVA: 0x003C736F File Offset: 0x003C556F
		public static float TransformScalarLocalToAbsolute(in FGeometry Geometry, float LocalScalar)
		{
			return USlateBlueprintLibrary.__TransformScalarLocalToAbsolute_Internal((Geometry ?? new FGeometry()).NativePtr, LocalScalar);
		}

		// Token: 0x06027A31 RID: 162353 RVA: 0x003C7387 File Offset: 0x003C5587
		public static float TransformScalarAbsoluteToLocal(in FGeometry Geometry, float AbsoluteScalar)
		{
			return USlateBlueprintLibrary.__TransformScalarAbsoluteToLocal_Internal((Geometry ?? new FGeometry()).NativePtr, AbsoluteScalar);
		}

		// Token: 0x06027A32 RID: 162354 RVA: 0x003C73A0 File Offset: 0x003C55A0
		public unsafe static void ScreenToWidgetLocal(UObject WorldContextObject, in FGeometry Geometry, FVector2D ScreenPosition, ref FVector2D LocalCoordinate, bool bIncludeWindowPosition)
		{
			fixed (FVector2D* ptr = &LocalCoordinate)
			{
				void* ptr2 = (void*)ptr;
				USlateBlueprintLibrary.__ScreenToWidgetLocal_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Geometry ?? new FGeometry()).NativePtr, ScreenPosition, ref LocalCoordinate, bIncludeWindowPosition);
			}
		}

		// Token: 0x06027A33 RID: 162355 RVA: 0x003C73E0 File Offset: 0x003C55E0
		public unsafe static void ScreenToWidgetAbsolute(UObject WorldContextObject, FVector2D ScreenPosition, ref FVector2D AbsoluteCoordinate, bool bIncludeWindowPosition)
		{
			fixed (FVector2D* ptr = &AbsoluteCoordinate)
			{
				void* ptr2 = (void*)ptr;
				USlateBlueprintLibrary.__ScreenToWidgetAbsolute_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ScreenPosition, ref AbsoluteCoordinate, bIncludeWindowPosition);
			}
		}

		// Token: 0x06027A34 RID: 162356 RVA: 0x003C7410 File Offset: 0x003C5610
		public unsafe static void ScreenToViewport(UObject WorldContextObject, FVector2D ScreenPosition, ref FVector2D ViewportPosition)
		{
			fixed (FVector2D* ptr = &ViewportPosition)
			{
				void* ptr2 = (void*)ptr;
				USlateBlueprintLibrary.__ScreenToViewport_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ScreenPosition, ref ViewportPosition);
			}
		}

		// Token: 0x06027A35 RID: 162357 RVA: 0x003C743C File Offset: 0x003C563C
		public unsafe static void LocalToViewport(UObject WorldContextObject, in FGeometry Geometry, FVector2D LocalCoordinate, ref FVector2D PixelPosition, ref FVector2D ViewportPosition)
		{
			fixed (FVector2D* ptr = &PixelPosition)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector2D* ptr3 = &ViewportPosition)
				{
					void* ptr4 = (void*)ptr3;
					USlateBlueprintLibrary.__LocalToViewport_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Geometry ?? new FGeometry()).NativePtr, LocalCoordinate, ref PixelPosition, ref ViewportPosition);
					ptr = null;
				}
			}
		}

		// Token: 0x06027A36 RID: 162358 RVA: 0x003C7483 File Offset: 0x003C5683
		public static FVector2D LocalToAbsolute(in FGeometry Geometry, FVector2D LocalCoordinate)
		{
			return USlateBlueprintLibrary.__LocalToAbsolute_Internal((Geometry ?? new FGeometry()).NativePtr, LocalCoordinate);
		}

		// Token: 0x06027A37 RID: 162359 RVA: 0x003C749B File Offset: 0x003C569B
		public static bool IsUnderLocation(in FGeometry Geometry, in FVector2D AbsoluteCoordinate)
		{
			return USlateBlueprintLibrary.__IsUnderLocation_Internal((Geometry ?? new FGeometry()).NativePtr, AbsoluteCoordinate);
		}

		// Token: 0x06027A38 RID: 162360 RVA: 0x003C74B3 File Offset: 0x003C56B3
		public static FVector2D GetLocalTopLeft(in FGeometry Geometry)
		{
			return USlateBlueprintLibrary.__GetLocalTopLeft_Internal((Geometry ?? new FGeometry()).NativePtr);
		}

		// Token: 0x06027A39 RID: 162361 RVA: 0x003C74CA File Offset: 0x003C56CA
		public static FVector2D GetLocalSize(in FGeometry Geometry)
		{
			return USlateBlueprintLibrary.__GetLocalSize_Internal((Geometry ?? new FGeometry()).NativePtr);
		}

		// Token: 0x06027A3A RID: 162362 RVA: 0x003C74E1 File Offset: 0x003C56E1
		public static FVector2D GetAbsoluteSize(in FGeometry Geometry)
		{
			return USlateBlueprintLibrary.__GetAbsoluteSize_Internal((Geometry ?? new FGeometry()).NativePtr);
		}

		// Token: 0x06027A3B RID: 162363 RVA: 0x003C74F8 File Offset: 0x003C56F8
		public static bool EqualEqual_SlateBrush(in FSlateBrush A, in FSlateBrush B)
		{
			return USlateBlueprintLibrary.__EqualEqual_SlateBrush_Internal((A ?? new FSlateBrush()).NativePtr, (B ?? new FSlateBrush()).NativePtr);
		}

		// Token: 0x06027A3C RID: 162364 RVA: 0x003C7520 File Offset: 0x003C5720
		public unsafe static void AbsoluteToViewport(UObject WorldContextObject, FVector2D AbsoluteDesktopCoordinate, ref FVector2D PixelPosition, ref FVector2D ViewportPosition)
		{
			fixed (FVector2D* ptr = &PixelPosition)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector2D* ptr3 = &ViewportPosition)
				{
					void* ptr4 = (void*)ptr3;
					USlateBlueprintLibrary.__AbsoluteToViewport_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, AbsoluteDesktopCoordinate, ref PixelPosition, ref ViewportPosition);
					ptr = null;
				}
			}
		}

		// Token: 0x06027A3D RID: 162365 RVA: 0x003C7555 File Offset: 0x003C5755
		public static FVector2D AbsoluteToLocal(in FGeometry Geometry, FVector2D AbsoluteCoordinate)
		{
			return USlateBlueprintLibrary.__AbsoluteToLocal_Internal((Geometry ?? new FGeometry()).NativePtr, AbsoluteCoordinate);
		}

		// Token: 0x06027A3E RID: 162366
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __TransformVectorLocalToAbsolute_Internal(IntPtr Geometry, FVector2D LocalVector);

		// Token: 0x06027A3F RID: 162367
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __TransformVectorAbsoluteToLocal_Internal(IntPtr Geometry, FVector2D AbsoluteVector);

		// Token: 0x06027A40 RID: 162368
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __TransformScalarLocalToAbsolute_Internal(IntPtr Geometry, float LocalScalar);

		// Token: 0x06027A41 RID: 162369
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __TransformScalarAbsoluteToLocal_Internal(IntPtr Geometry, float AbsoluteScalar);

		// Token: 0x06027A42 RID: 162370
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScreenToWidgetLocal_Internal(IntPtr WorldContextObject, IntPtr Geometry, FVector2D ScreenPosition, ref FVector2D LocalCoordinate, bool bIncludeWindowPosition);

		// Token: 0x06027A43 RID: 162371
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScreenToWidgetAbsolute_Internal(IntPtr WorldContextObject, FVector2D ScreenPosition, ref FVector2D AbsoluteCoordinate, bool bIncludeWindowPosition);

		// Token: 0x06027A44 RID: 162372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScreenToViewport_Internal(IntPtr WorldContextObject, FVector2D ScreenPosition, ref FVector2D ViewportPosition);

		// Token: 0x06027A45 RID: 162373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LocalToViewport_Internal(IntPtr WorldContextObject, IntPtr Geometry, FVector2D LocalCoordinate, ref FVector2D PixelPosition, ref FVector2D ViewportPosition);

		// Token: 0x06027A46 RID: 162374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __LocalToAbsolute_Internal(IntPtr Geometry, FVector2D LocalCoordinate);

		// Token: 0x06027A47 RID: 162375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUnderLocation_Internal(IntPtr Geometry, in FVector2D AbsoluteCoordinate);

		// Token: 0x06027A48 RID: 162376
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetLocalTopLeft_Internal(IntPtr Geometry);

		// Token: 0x06027A49 RID: 162377
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetLocalSize_Internal(IntPtr Geometry);

		// Token: 0x06027A4A RID: 162378
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetAbsoluteSize_Internal(IntPtr Geometry);

		// Token: 0x06027A4B RID: 162379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_SlateBrush_Internal(IntPtr A, IntPtr B);

		// Token: 0x06027A4C RID: 162380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AbsoluteToViewport_Internal(IntPtr WorldContextObject, FVector2D AbsoluteDesktopCoordinate, ref FVector2D PixelPosition, ref FVector2D ViewportPosition);

		// Token: 0x06027A4D RID: 162381
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __AbsoluteToLocal_Internal(IntPtr Geometry, FVector2D AbsoluteCoordinate);

		// Token: 0x06027A4E RID: 162382 RVA: 0x003C756D File Offset: 0x003C576D
		static USlateBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.SlateBlueprintLibrary");
		}

		// Token: 0x06027A4F RID: 162383 RVA: 0x003C757B File Offset: 0x003C577B
		protected USlateBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015B70 RID: 88944
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.SlateBlueprintLibrary";

		// Token: 0x04015B71 RID: 88945
		private static IntPtr _ClassPtr;

		// Token: 0x04015B72 RID: 88946
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
