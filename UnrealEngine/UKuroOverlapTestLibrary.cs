using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200036A RID: 874
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroData.KuroOverlapTestLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroOverlapTestLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005912 RID: 22802 RVA: 0x0007D97C File Offset: 0x0007BB7C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroOverlapTestLibrary._ClassPtr;
		}

		// Token: 0x06005913 RID: 22803 RVA: 0x0007D988 File Offset: 0x0007BB88
		public UKuroOverlapTestLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroOverlapTestLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005914 RID: 22804 RVA: 0x0007D9B0 File Offset: 0x0007BBB0
		public UKuroOverlapTestLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroOverlapTestLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06005915 RID: 22805 RVA: 0x0007D9E4 File Offset: 0x0007BBE4
		public unsafe static bool BoxOverlapBlockingTestByProfile([Nullable(2)] UObject WorldContextObject, double BoxPositionX, double BoxPositionY, double BoxPositionZ, FVector BoxHalfExtent, FRotator BoxOrientation, FName ProfileName, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, string ProfileKey)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			bool result = UKuroOverlapTestLibrary.__BoxOverlapBlockingTestByProfile_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, BoxPositionX, BoxPositionY, BoxPositionZ, BoxHalfExtent, BoxOrientation, ProfileName, bTraceComplex, (ActorsToIgnore ?? new TArray<AActor>()).NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06005916 RID: 22806 RVA: 0x0007DA38 File Offset: 0x0007BC38
		public unsafe static bool BoxOverlapBlockingTestByChannel([Nullable(2)] UObject WorldContextObject, double BoxPositionX, double BoxPositionY, double BoxPositionZ, FVector BoxHalfExtent, FRotator BoxOrientation, ETraceTypeQuery TraceType, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, string ProfileKey)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			bool result = UKuroOverlapTestLibrary.__BoxOverlapBlockingTestByChannel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, BoxPositionX, BoxPositionY, BoxPositionZ, BoxHalfExtent, BoxOrientation, TraceType, bTraceComplex, (ActorsToIgnore ?? new TArray<AActor>()).NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06005917 RID: 22807 RVA: 0x0007DA90 File Offset: 0x0007BC90
		public unsafe static bool BoxOverlapAnyTestByProfile([Nullable(2)] UObject WorldContextObject, double BoxPositionX, double BoxPositionY, double BoxPositionZ, FVector BoxHalfExtent, FRotator BoxOrientation, FName ProfileName, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, string ProfileKey)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			bool result = UKuroOverlapTestLibrary.__BoxOverlapAnyTestByProfile_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, BoxPositionX, BoxPositionY, BoxPositionZ, BoxHalfExtent, BoxOrientation, ProfileName, bTraceComplex, (ActorsToIgnore ?? new TArray<AActor>()).NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06005918 RID: 22808 RVA: 0x0007DAE4 File Offset: 0x0007BCE4
		public unsafe static bool BoxOverlapAnyTestByObjectType([Nullable(2)] UObject WorldContextObject, double BoxPositionX, double BoxPositionY, double BoxPositionZ, FVector BoxHalfExtent, FRotator BoxOrientation, [Nullable(new byte[]
		{
			2,
			0
		})] in TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, string ProfileKey)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			bool result = UKuroOverlapTestLibrary.__BoxOverlapAnyTestByObjectType_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, BoxPositionX, BoxPositionY, BoxPositionZ, BoxHalfExtent, BoxOrientation, (ObjectTypes ?? new TArray<TEnumAsByte<EObjectTypeQuery>>()).NativePtr, bTraceComplex, (ActorsToIgnore ?? new TArray<AActor>()).NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x0007DB44 File Offset: 0x0007BD44
		public unsafe static bool BoxOverlapAnyTestByChannel([Nullable(2)] UObject WorldContextObject, double BoxPositionX, double BoxPositionY, double BoxPositionZ, FVector BoxHalfExtent, FRotator BoxOrientation, ETraceTypeQuery TraceType, bool bTraceComplex, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorsToIgnore, string ProfileKey)
		{
			FString fstring = FString.AllocTemp(ProfileKey);
			bool result = UKuroOverlapTestLibrary.__BoxOverlapAnyTestByChannel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, BoxPositionX, BoxPositionY, BoxPositionZ, BoxHalfExtent, BoxOrientation, TraceType, bTraceComplex, (ActorsToIgnore ?? new TArray<AActor>()).NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600591A RID: 22810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxOverlapBlockingTestByProfile_Internal(IntPtr WorldContextObject, double BoxPositionX, double BoxPositionY, double BoxPositionZ, FVector BoxHalfExtent, FRotator BoxOrientation, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, in FString ProfileKey);

		// Token: 0x0600591B RID: 22811
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxOverlapBlockingTestByChannel_Internal(IntPtr WorldContextObject, double BoxPositionX, double BoxPositionY, double BoxPositionZ, FVector BoxHalfExtent, FRotator BoxOrientation, TEnumAsByte<ETraceTypeQuery> TraceType, bool bTraceComplex, IntPtr ActorsToIgnore, in FString ProfileKey);

		// Token: 0x0600591C RID: 22812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxOverlapAnyTestByProfile_Internal(IntPtr WorldContextObject, double BoxPositionX, double BoxPositionY, double BoxPositionZ, FVector BoxHalfExtent, FRotator BoxOrientation, FName ProfileName, bool bTraceComplex, IntPtr ActorsToIgnore, in FString ProfileKey);

		// Token: 0x0600591D RID: 22813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxOverlapAnyTestByObjectType_Internal(IntPtr WorldContextObject, double BoxPositionX, double BoxPositionY, double BoxPositionZ, FVector BoxHalfExtent, FRotator BoxOrientation, IntPtr ObjectTypes, bool bTraceComplex, IntPtr ActorsToIgnore, in FString ProfileKey);

		// Token: 0x0600591E RID: 22814
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BoxOverlapAnyTestByChannel_Internal(IntPtr WorldContextObject, double BoxPositionX, double BoxPositionY, double BoxPositionZ, FVector BoxHalfExtent, FRotator BoxOrientation, TEnumAsByte<ETraceTypeQuery> TraceType, bool bTraceComplex, IntPtr ActorsToIgnore, in FString ProfileKey);

		// Token: 0x0600591F RID: 22815 RVA: 0x0007DB9A File Offset: 0x0007BD9A
		static UKuroOverlapTestLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroData.KuroOverlapTestLibrary");
		}

		// Token: 0x06005920 RID: 22816 RVA: 0x0007DBA8 File Offset: 0x0007BDA8
		protected UKuroOverlapTestLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040024DD RID: 9437
		public new const string __ObjectPath = "/Script/KuroData.KuroOverlapTestLibrary";

		// Token: 0x040024DE RID: 9438
		private static IntPtr _ClassPtr;

		// Token: 0x040024DF RID: 9439
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
