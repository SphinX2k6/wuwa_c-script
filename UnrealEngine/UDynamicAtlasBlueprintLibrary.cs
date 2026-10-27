using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001802 RID: 6146
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroDynamicAtlas.DynamicAtlasBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UDynamicAtlasBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016C01 RID: 93185 RVA: 0x0021344A File Offset: 0x0021164A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDynamicAtlasBlueprintLibrary._ClassPtr;
		}

		// Token: 0x06016C02 RID: 93186 RVA: 0x00213458 File Offset: 0x00211658
		public UDynamicAtlasBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UDynamicAtlasBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016C03 RID: 93187 RVA: 0x00213480 File Offset: 0x00211680
		public UDynamicAtlasBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDynamicAtlasBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016C04 RID: 93188 RVA: 0x002134B4 File Offset: 0x002116B4
		public unsafe static void SetOverrideSetting(string InAtlasTag, [Nullable(2)] ref FDynamicTextureAtlasSetting InSetting)
		{
			FString fstring = FString.AllocTemp(InAtlasTag);
			UDynamicAtlasBlueprintLibrary.__SetOverrideSetting_Internal(fstring, (InSetting ?? new FDynamicTextureAtlasSetting()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06016C05 RID: 93189 RVA: 0x002134E8 File Offset: 0x002116E8
		public unsafe static void RebuildAllAtlas(string InAtlasTag)
		{
			FString fstring = FString.AllocTemp(InAtlasTag);
			UDynamicAtlasBlueprintLibrary.__RebuildAllAtlas_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06016C06 RID: 93190 RVA: 0x0021350C File Offset: 0x0021170C
		public unsafe static bool HasOverrideSetting(string InAtlasTag)
		{
			FString fstring = FString.AllocTemp(InAtlasTag);
			bool result = UDynamicAtlasBlueprintLibrary.__HasOverrideSetting_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06016C07 RID: 93191 RVA: 0x00213530 File Offset: 0x00211730
		public unsafe static void CleanAllAtlas(string InAtlasTag)
		{
			FString fstring = FString.AllocTemp(InAtlasTag);
			UDynamicAtlasBlueprintLibrary.__CleanAllAtlas_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06016C08 RID: 93192 RVA: 0x00213554 File Offset: 0x00211754
		public unsafe static bool AddTextureAsync(string InAtlasTag, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<FSoftObjectPath> InSoftObjectPath, [Nullable(2)] FOnDynamicAtlasSlotBuiltCallback CompleteCallback)
		{
			FString fstring = FString.AllocTemp(InAtlasTag);
			bool result = UDynamicAtlasBlueprintLibrary.__AddTextureAsync_Internal(fstring, (InSoftObjectPath ?? new TArray<FSoftObjectPath>()).NativePtr, (CompleteCallback != null) ? CompleteCallback.NativePtr : ((IntPtr)0));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06016C09 RID: 93193
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOverrideSetting_Internal(in FString InAtlasTag, IntPtr InSetting);

		// Token: 0x06016C0A RID: 93194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RebuildAllAtlas_Internal(in FString InAtlasTag);

		// Token: 0x06016C0B RID: 93195
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasOverrideSetting_Internal(in FString InAtlasTag);

		// Token: 0x06016C0C RID: 93196
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CleanAllAtlas_Internal(in FString InAtlasTag);

		// Token: 0x06016C0D RID: 93197
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddTextureAsync_Internal(in FString InAtlasTag, IntPtr InSoftObjectPath, IntPtr CompleteCallback);

		// Token: 0x06016C0E RID: 93198 RVA: 0x00213594 File Offset: 0x00211794
		static UDynamicAtlasBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroDynamicAtlas.DynamicAtlasBlueprintLibrary");
		}

		// Token: 0x06016C0F RID: 93199 RVA: 0x002135A2 File Offset: 0x002117A2
		protected UDynamicAtlasBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C591 RID: 50577
		public new const string __ObjectPath = "/Script/KuroDynamicAtlas.DynamicAtlasBlueprintLibrary";

		// Token: 0x0400C592 RID: 50578
		private static IntPtr _ClassPtr;

		// Token: 0x0400C593 RID: 50579
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
