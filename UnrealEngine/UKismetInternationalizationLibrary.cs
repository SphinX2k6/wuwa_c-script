using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CCF RID: 3279
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KismetInternationalizationLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetInternationalizationLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A61B RID: 42523 RVA: 0x000ECAD5 File Offset: 0x000EACD5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetInternationalizationLibrary._ClassPtr;
		}

		// Token: 0x0600A61C RID: 42524 RVA: 0x000ECAE4 File Offset: 0x000EACE4
		public UKismetInternationalizationLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetInternationalizationLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A61D RID: 42525 RVA: 0x000ECB0C File Offset: 0x000EAD0C
		public UKismetInternationalizationLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetInternationalizationLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A61E RID: 42526 RVA: 0x000ECB40 File Offset: 0x000EAD40
		public unsafe static bool SetCurrentLocale(string Culture, bool SaveToConfig = false)
		{
			FString fstring = FString.AllocTemp(Culture);
			bool result = UKismetInternationalizationLibrary.__SetCurrentLocale_Internal(fstring, SaveToConfig);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600A61F RID: 42527 RVA: 0x000ECB68 File Offset: 0x000EAD68
		public unsafe static bool SetCurrentLanguageAndLocale(string Culture, bool SaveToConfig = false)
		{
			FString fstring = FString.AllocTemp(Culture);
			bool result = UKismetInternationalizationLibrary.__SetCurrentLanguageAndLocale_Internal(fstring, SaveToConfig);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600A620 RID: 42528 RVA: 0x000ECB90 File Offset: 0x000EAD90
		public unsafe static bool SetCurrentLanguage(string Culture, bool SaveToConfig = false)
		{
			FString fstring = FString.AllocTemp(Culture);
			bool result = UKismetInternationalizationLibrary.__SetCurrentLanguage_Internal(fstring, SaveToConfig);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600A621 RID: 42529 RVA: 0x000ECBB8 File Offset: 0x000EADB8
		public unsafe static bool SetCurrentCulture(string Culture, bool SaveToConfig = false)
		{
			FString fstring = FString.AllocTemp(Culture);
			bool result = UKismetInternationalizationLibrary.__SetCurrentCulture_Internal(fstring, SaveToConfig);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600A622 RID: 42530 RVA: 0x000ECBE0 File Offset: 0x000EADE0
		public unsafe static bool SetCurrentAssetGroupCulture(FName AssetGroup, string Culture, bool SaveToConfig = false)
		{
			FString fstring = FString.AllocTemp(Culture);
			bool result = UKismetInternationalizationLibrary.__SetCurrentAssetGroupCulture_Internal(AssetGroup, fstring, SaveToConfig);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600A623 RID: 42531 RVA: 0x000ECC08 File Offset: 0x000EAE08
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

		// Token: 0x0600A624 RID: 42532 RVA: 0x000ECC53 File Offset: 0x000EAE53
		public static string GetNativeCulture(ELocalizedTextSourceCategory TextCategory)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetInternationalizationLibrary.__GetNativeCulture_Internal(TextCategory));
		}

		// Token: 0x0600A625 RID: 42533 RVA: 0x000ECC60 File Offset: 0x000EAE60
		public static TArray<string> GetLocalizedCultures(bool IncludeGame = true, bool IncludeEngine = false, bool IncludeEditor = false, bool IncludeAdditional = false)
		{
			return new TArray<string>(UKismetInternationalizationLibrary.__GetLocalizedCultures_Internal(IncludeGame, IncludeEngine, IncludeEditor, IncludeAdditional), null);
		}

		// Token: 0x0600A626 RID: 42534 RVA: 0x000ECC71 File Offset: 0x000EAE71
		public static string GetCurrentLocale()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetInternationalizationLibrary.__GetCurrentLocale_Internal());
		}

		// Token: 0x0600A627 RID: 42535 RVA: 0x000ECC7D File Offset: 0x000EAE7D
		public static string GetCurrentLanguage()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetInternationalizationLibrary.__GetCurrentLanguage_Internal());
		}

		// Token: 0x0600A628 RID: 42536 RVA: 0x000ECC89 File Offset: 0x000EAE89
		public static string GetCurrentCulture()
		{
			return FString.ToStringAndDeleteNativePtr(UKismetInternationalizationLibrary.__GetCurrentCulture_Internal());
		}

		// Token: 0x0600A629 RID: 42537 RVA: 0x000ECC95 File Offset: 0x000EAE95
		public static string GetCurrentAssetGroupCulture(FName AssetGroup)
		{
			return FString.ToStringAndDeleteNativePtr(UKismetInternationalizationLibrary.__GetCurrentAssetGroupCulture_Internal(AssetGroup));
		}

		// Token: 0x0600A62A RID: 42538 RVA: 0x000ECCA4 File Offset: 0x000EAEA4
		public unsafe static string GetCultureDisplayName(string Culture, bool Localized = true)
		{
			FString fstring = FString.AllocTemp(Culture);
			string result = FString.ToStringAndDeleteNativePtr(UKismetInternationalizationLibrary.__GetCultureDisplayName_Internal(fstring, Localized));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600A62B RID: 42539
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearCurrentAssetGroupCulture(FName AssetGroup, bool SaveToConfig = false);

		// Token: 0x0600A62C RID: 42540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetCurrentLocale_Internal(in FString Culture, bool SaveToConfig);

		// Token: 0x0600A62D RID: 42541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetCurrentLanguageAndLocale_Internal(in FString Culture, bool SaveToConfig);

		// Token: 0x0600A62E RID: 42542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetCurrentLanguage_Internal(in FString Culture, bool SaveToConfig);

		// Token: 0x0600A62F RID: 42543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetCurrentCulture_Internal(in FString Culture, bool SaveToConfig);

		// Token: 0x0600A630 RID: 42544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetCurrentAssetGroupCulture_Internal(FName AssetGroup, in FString Culture, bool SaveToConfig);

		// Token: 0x0600A631 RID: 42545
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetSuitableCulture_Internal(IntPtr AvailableCultures, in FString CultureToMatch, in FString FallbackCulture);

		// Token: 0x0600A632 RID: 42546
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetNativeCulture_Internal(ELocalizedTextSourceCategory TextCategory);

		// Token: 0x0600A633 RID: 42547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLocalizedCultures_Internal(bool IncludeGame, bool IncludeEngine, bool IncludeEditor, bool IncludeAdditional);

		// Token: 0x0600A634 RID: 42548
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurrentLocale_Internal();

		// Token: 0x0600A635 RID: 42549
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurrentLanguage_Internal();

		// Token: 0x0600A636 RID: 42550
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurrentCulture_Internal();

		// Token: 0x0600A637 RID: 42551
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurrentAssetGroupCulture_Internal(FName AssetGroup);

		// Token: 0x0600A638 RID: 42552
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCultureDisplayName_Internal(in FString Culture, bool Localized);

		// Token: 0x0600A639 RID: 42553 RVA: 0x000ECCCE File Offset: 0x000EAECE
		static UKismetInternationalizationLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetInternationalizationLibrary");
		}

		// Token: 0x0600A63A RID: 42554 RVA: 0x000ECCDC File Offset: 0x000EAEDC
		protected UKismetInternationalizationLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005B30 RID: 23344
		public new const string __ObjectPath = "/Script/Engine.KismetInternationalizationLibrary";

		// Token: 0x04005B31 RID: 23345
		private static IntPtr _ClassPtr;

		// Token: 0x04005B32 RID: 23346
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
