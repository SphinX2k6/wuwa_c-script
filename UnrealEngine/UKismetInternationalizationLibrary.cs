using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000222 RID: 546
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KismetInternationalizationLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetInternationalizationLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002551 RID: 9553 RVA: 0x00035A96 File Offset: 0x00033C96
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetInternationalizationLibrary._ClassPtr;
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x00035AA4 File Offset: 0x00033CA4
		public UKismetInternationalizationLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetInternationalizationLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x00035ACC File Offset: 0x00033CCC
		public UKismetInternationalizationLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetInternationalizationLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x00035B00 File Offset: 0x00033D00
		public unsafe static bool SetCurrentLocale(string Culture, bool SaveToConfig = false)
		{
			FString fstring = FString.AllocTemp(Culture);
			bool result = UKismetInternationalizationLibrary.__SetCurrentLocale_Internal(fstring, SaveToConfig);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x00035B28 File Offset: 0x00033D28
		public unsafe static bool SetCurrentLanguageAndLocale(string Culture, bool SaveToConfig = false)
		{
			FString fstring = FString.AllocTemp(Culture);
			bool result = UKismetInternationalizationLibrary.__SetCurrentLanguageAndLocale_Internal(fstring, SaveToConfig);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x00035B50 File Offset: 0x00033D50
		public unsafe static bool SetCurrentLanguage(string Culture, bool SaveToConfig = false)
		{
			FString fstring = FString.AllocTemp(Culture);
			bool result = UKismetInternationalizationLibrary.__SetCurrentLanguage_Internal(fstring, SaveToConfig);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x00035B78 File Offset: 0x00033D78
		public unsafe static bool SetCurrentCulture(string Culture, bool SaveToConfig = false)
		{
			FString fstring = FString.AllocTemp(Culture);
			bool result = UKismetInternationalizationLibrary.__SetCurrentCulture_Internal(fstring, SaveToConfig);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x00035BA0 File Offset: 0x00033DA0
		public unsafe static bool SetCurrentAssetGroupCulture(FName AssetGroup, string Culture, bool SaveToConfig = false)
		{
			FString fstring = FString.AllocTemp(Culture);
			bool result = UKismetInternationalizationLibrary.__SetCurrentAssetGroupCulture_Internal(AssetGroup, fstring, SaveToConfig);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x00035BC8 File Offset: 0x00033DC8
		public unsafe static string GetSuitableCulture([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> AvailableCultures, string CultureToMatch, string FallbackCulture = "en")
		{
			FString fstring = FString.AllocTemp(CultureToMatch);
			FString fstring2 = FString.AllocTemp(FallbackCulture);
			string result = FString.ToStringAndDeleteNativePtr(UKismetInternationalizationLibrary.__GetSuitableCulture_Internal((AvailableCultures ?? new TArray<string>()).NativePtr, fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x00035C13 File Offset: 0x00033E13
		public static string GetNativeCulture(ELocalizedTextSourceCategory TextCategory)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetInternationalizationLibrary.__GetNativeCulture_Internal(TextCategory));
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x00035C20 File Offset: 0x00033E20
		public static TArray<string> GetLocalizedCultures(bool IncludeGame = true, bool IncludeEngine = false, bool IncludeEditor = false, bool IncludeAdditional = false)
		{
			return new TArray<string>(UKismetInternationalizationLibrary.__GetLocalizedCultures_Internal(IncludeGame, IncludeEngine, IncludeEditor, IncludeAdditional), null);
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x00035C31 File Offset: 0x00033E31
		public static string GetCurrentLocale()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetInternationalizationLibrary.__GetCurrentLocale_Internal());
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x00035C3D File Offset: 0x00033E3D
		public static string GetCurrentLanguage()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetInternationalizationLibrary.__GetCurrentLanguage_Internal());
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x00035C49 File Offset: 0x00033E49
		public static string GetCurrentCulture()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetInternationalizationLibrary.__GetCurrentCulture_Internal());
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x00035C55 File Offset: 0x00033E55
		public static string GetCurrentAssetGroupCulture(FName AssetGroup)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetInternationalizationLibrary.__GetCurrentAssetGroupCulture_Internal(AssetGroup));
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x00035C64 File Offset: 0x00033E64
		public unsafe static string GetCultureDisplayName(string Culture, bool Localized = true)
		{
			FString fstring = FString.AllocTemp(Culture);
			string result = FString.ToStringAndDeleteNativePtr(UKismetInternationalizationLibrary.__GetCultureDisplayName_Internal(fstring, Localized));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002561 RID: 9569
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearCurrentAssetGroupCulture(FName AssetGroup, bool SaveToConfig = false);

		// Token: 0x06002562 RID: 9570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetCurrentLocale_Internal(in FString Culture, bool SaveToConfig);

		// Token: 0x06002563 RID: 9571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetCurrentLanguageAndLocale_Internal(in FString Culture, bool SaveToConfig);

		// Token: 0x06002564 RID: 9572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetCurrentLanguage_Internal(in FString Culture, bool SaveToConfig);

		// Token: 0x06002565 RID: 9573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetCurrentCulture_Internal(in FString Culture, bool SaveToConfig);

		// Token: 0x06002566 RID: 9574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetCurrentAssetGroupCulture_Internal(FName AssetGroup, in FString Culture, bool SaveToConfig);

		// Token: 0x06002567 RID: 9575
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSuitableCulture_Internal(IntPtr AvailableCultures, in FString CultureToMatch, in FString FallbackCulture);

		// Token: 0x06002568 RID: 9576
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetNativeCulture_Internal(ELocalizedTextSourceCategory TextCategory);

		// Token: 0x06002569 RID: 9577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLocalizedCultures_Internal(bool IncludeGame, bool IncludeEngine, bool IncludeEditor, bool IncludeAdditional);

		// Token: 0x0600256A RID: 9578
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurrentLocale_Internal();

		// Token: 0x0600256B RID: 9579
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurrentLanguage_Internal();

		// Token: 0x0600256C RID: 9580
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurrentCulture_Internal();

		// Token: 0x0600256D RID: 9581
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurrentAssetGroupCulture_Internal(FName AssetGroup);

		// Token: 0x0600256E RID: 9582
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCultureDisplayName_Internal(in FString Culture, bool Localized);

		// Token: 0x0600256F RID: 9583 RVA: 0x00035C8E File Offset: 0x00033E8E
		static UKismetInternationalizationLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetInternationalizationLibrary");
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00035C9C File Offset: 0x00033E9C
		protected UKismetInternationalizationLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E0A RID: 3594
		public new const string __ObjectPath = "/Script/Engine.KismetInternationalizationLibrary";

		// Token: 0x04000E0B RID: 3595
		private static IntPtr _ClassPtr;

		// Token: 0x04000E0C RID: 3596
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
