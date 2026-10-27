using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008CB RID: 2251
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BlueprintPathsLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UBlueprintPathsLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007AE6 RID: 31462 RVA: 0x000B00A7 File Offset: 0x000AE2A7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlueprintPathsLibrary._ClassPtr;
		}

		// Token: 0x06007AE7 RID: 31463 RVA: 0x000B00B4 File Offset: 0x000AE2B4
		public UBlueprintPathsLibrary() : this(BuiltinUtils.AllocNativeUObject(UBlueprintPathsLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007AE8 RID: 31464 RVA: 0x000B00DC File Offset: 0x000AE2DC
		public UBlueprintPathsLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlueprintPathsLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007AE9 RID: 31465 RVA: 0x000B010F File Offset: 0x000AE30F
		public static string VideoCaptureDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__VideoCaptureDir_Internal());
		}

		// Token: 0x06007AEA RID: 31466 RVA: 0x000B011C File Offset: 0x000AE31C
		public unsafe static void ValidatePath(string InPath, ref bool bDidSucceed, ref FText OutReason)
		{
			FString fstring = FString.AllocTemp(InPath);
			fixed (bool* ptr = &bDidSucceed)
			{
				void* ptr2 = (void*)ptr;
				FText ftext = OutReason;
				UBlueprintPathsLibrary.__ValidatePath_Internal(fstring, ref bDidSucceed, (ftext != null) ? ftext.NativePtr : IntPtr.Zero);
				FString.NativeDestruct(&fstring, 1);
			}
		}

		// Token: 0x06007AEB RID: 31467 RVA: 0x000B015C File Offset: 0x000AE35C
		public unsafe static void Split(string InPath, ref string PathPart, ref string FilenamePart, ref string ExtensionPart)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(PathPart);
			FString fstring3 = FString.AllocTemp(FilenamePart);
			FString fstring4 = FString.AllocTemp(ExtensionPart);
			UBlueprintPathsLibrary.__Split_Internal(fstring, ref fstring2, ref fstring3, ref fstring4);
			FString.NativeDestruct(&fstring, 1);
			PathPart = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
			FilenamePart = FString.ToString(fstring3);
			FString.NativeDestruct(&fstring3, 1);
			ExtensionPart = FString.ToString(fstring4);
			FString.NativeDestruct(&fstring4, 1);
		}

		// Token: 0x06007AEC RID: 31468 RVA: 0x000B01D4 File Offset: 0x000AE3D4
		public static string SourceConfigDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__SourceConfigDir_Internal());
		}

		// Token: 0x06007AED RID: 31469
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool ShouldSaveToUserDir();

		// Token: 0x06007AEE RID: 31470 RVA: 0x000B01E0 File Offset: 0x000AE3E0
		public static string ShaderWorkingDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ShaderWorkingDir_Internal());
		}

		// Token: 0x06007AEF RID: 31471 RVA: 0x000B01EC File Offset: 0x000AE3EC
		public unsafe static void SetProjectFilePath(string NewGameProjectFilePath)
		{
			FString fstring = FString.AllocTemp(NewGameProjectFilePath);
			UBlueprintPathsLibrary.__SetProjectFilePath_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06007AF0 RID: 31472 RVA: 0x000B0210 File Offset: 0x000AE410
		public unsafe static string SetExtension(string InPath, string InNewExtension)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(InNewExtension);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__SetExtension_Internal(fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06007AF1 RID: 31473 RVA: 0x000B024B File Offset: 0x000AE44B
		public static string ScreenShotDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ScreenShotDir_Internal());
		}

		// Token: 0x06007AF2 RID: 31474 RVA: 0x000B0257 File Offset: 0x000AE457
		public static string SandboxesDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__SandboxesDir_Internal());
		}

		// Token: 0x06007AF3 RID: 31475 RVA: 0x000B0263 File Offset: 0x000AE463
		public static string RootDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__RootDir_Internal());
		}

		// Token: 0x06007AF4 RID: 31476 RVA: 0x000B0270 File Offset: 0x000AE470
		public unsafe static void RemoveDuplicateSlashes(string InPath, ref string OutPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(OutPath);
			UBlueprintPathsLibrary.__RemoveDuplicateSlashes_Internal(fstring, ref fstring2);
			FString.NativeDestruct(&fstring, 1);
			OutPath = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06007AF5 RID: 31477 RVA: 0x000B02B0 File Offset: 0x000AE4B0
		public static string ProjectUserDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectUserDir_Internal());
		}

		// Token: 0x06007AF6 RID: 31478 RVA: 0x000B02BC File Offset: 0x000AE4BC
		public static string ProjectSavedDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectSavedDir_Internal());
		}

		// Token: 0x06007AF7 RID: 31479 RVA: 0x000B02C8 File Offset: 0x000AE4C8
		public static string ProjectPluginsDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectPluginsDir_Internal());
		}

		// Token: 0x06007AF8 RID: 31480 RVA: 0x000B02D4 File Offset: 0x000AE4D4
		public static string ProjectPersistentDownloadDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectPersistentDownloadDir_Internal());
		}

		// Token: 0x06007AF9 RID: 31481 RVA: 0x000B02E0 File Offset: 0x000AE4E0
		public static string ProjectModsDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectModsDir_Internal());
		}

		// Token: 0x06007AFA RID: 31482 RVA: 0x000B02EC File Offset: 0x000AE4EC
		public static string ProjectLogDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectLogDir_Internal());
		}

		// Token: 0x06007AFB RID: 31483 RVA: 0x000B02F8 File Offset: 0x000AE4F8
		public static string ProjectIntermediateDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectIntermediateDir_Internal());
		}

		// Token: 0x06007AFC RID: 31484 RVA: 0x000B0304 File Offset: 0x000AE504
		public static string ProjectDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectDir_Internal());
		}

		// Token: 0x06007AFD RID: 31485 RVA: 0x000B0310 File Offset: 0x000AE510
		public static string ProjectContentDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectContentDir_Internal());
		}

		// Token: 0x06007AFE RID: 31486 RVA: 0x000B031C File Offset: 0x000AE51C
		public static string ProjectConfigDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectConfigDir_Internal());
		}

		// Token: 0x06007AFF RID: 31487 RVA: 0x000B0328 File Offset: 0x000AE528
		public static string ProfilingDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProfilingDir_Internal());
		}

		// Token: 0x06007B00 RID: 31488 RVA: 0x000B0334 File Offset: 0x000AE534
		public unsafe static void NormalizeFilename(string InPath, ref string OutPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(OutPath);
			UBlueprintPathsLibrary.__NormalizeFilename_Internal(fstring, ref fstring2);
			FString.NativeDestruct(&fstring, 1);
			OutPath = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06007B01 RID: 31489 RVA: 0x000B0374 File Offset: 0x000AE574
		public unsafe static void NormalizeDirectoryName(string InPath, ref string OutPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(OutPath);
			UBlueprintPathsLibrary.__NormalizeDirectoryName_Internal(fstring, ref fstring2);
			FString.NativeDestruct(&fstring, 1);
			OutPath = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06007B02 RID: 31490 RVA: 0x000B03B4 File Offset: 0x000AE5B4
		public unsafe static string MakeValidFileName(string InString, string InReplacementChar = "")
		{
			FString fstring = FString.AllocTemp(InString);
			FString fstring2 = FString.AllocTemp(InReplacementChar);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__MakeValidFileName_Internal(fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06007B03 RID: 31491 RVA: 0x000B03F0 File Offset: 0x000AE5F0
		public unsafe static void MakeStandardFilename(string InPath, ref string OutPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(OutPath);
			UBlueprintPathsLibrary.__MakeStandardFilename_Internal(fstring, ref fstring2);
			FString.NativeDestruct(&fstring, 1);
			OutPath = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06007B04 RID: 31492 RVA: 0x000B0430 File Offset: 0x000AE630
		public unsafe static void MakePlatformFilename(string InPath, ref string OutPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(OutPath);
			UBlueprintPathsLibrary.__MakePlatformFilename_Internal(fstring, ref fstring2);
			FString.NativeDestruct(&fstring, 1);
			OutPath = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06007B05 RID: 31493 RVA: 0x000B0470 File Offset: 0x000AE670
		public unsafe static bool MakePathRelativeTo(string InPath, string InRelativeTo, ref string OutPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(InRelativeTo);
			FString fstring3 = FString.AllocTemp(OutPath);
			bool result = UBlueprintPathsLibrary.__MakePathRelativeTo_Internal(fstring, fstring2, ref fstring3);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			OutPath = FString.ToString(fstring3);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x06007B06 RID: 31494 RVA: 0x000B04C2 File Offset: 0x000AE6C2
		public static string LaunchDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__LaunchDir_Internal());
		}

		// Token: 0x06007B07 RID: 31495 RVA: 0x000B04D0 File Offset: 0x000AE6D0
		public unsafe static bool IsSamePath(string PathA, string PathB)
		{
			FString fstring = FString.AllocTemp(PathA);
			FString fstring2 = FString.AllocTemp(PathB);
			bool result = UBlueprintPathsLibrary.__IsSamePath_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06007B08 RID: 31496 RVA: 0x000B0508 File Offset: 0x000AE708
		public unsafe static bool IsRestrictedPath(string InPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			bool result = UBlueprintPathsLibrary.__IsRestrictedPath_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06007B09 RID: 31497 RVA: 0x000B052C File Offset: 0x000AE72C
		public unsafe static bool IsRelative(string InPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			bool result = UBlueprintPathsLibrary.__IsRelative_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06007B0A RID: 31498
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsProjectFilePathSet();

		// Token: 0x06007B0B RID: 31499 RVA: 0x000B0550 File Offset: 0x000AE750
		public unsafe static bool IsDrive(string InPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			bool result = UBlueprintPathsLibrary.__IsDrive_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06007B0C RID: 31500
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasProjectPersistentDownloadDir();

		// Token: 0x06007B0D RID: 31501 RVA: 0x000B0574 File Offset: 0x000AE774
		public static TArray<string> GetToolTipLocalizationPaths()
		{
			return new TArray<string>(UBlueprintPathsLibrary.__GetToolTipLocalizationPaths_Internal(), null);
		}

		// Token: 0x06007B0E RID: 31502 RVA: 0x000B0581 File Offset: 0x000AE781
		public static TArray<string> GetRestrictedFolderNames()
		{
			return new TArray<string>(UBlueprintPathsLibrary.__GetRestrictedFolderNames_Internal(), null);
		}

		// Token: 0x06007B0F RID: 31503 RVA: 0x000B058E File Offset: 0x000AE78E
		public static string GetRelativePathToRoot()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GetRelativePathToRoot_Internal());
		}

		// Token: 0x06007B10 RID: 31504 RVA: 0x000B059A File Offset: 0x000AE79A
		public static TArray<string> GetPropertyNameLocalizationPaths()
		{
			return new TArray<string>(UBlueprintPathsLibrary.__GetPropertyNameLocalizationPaths_Internal(), null);
		}

		// Token: 0x06007B11 RID: 31505 RVA: 0x000B05A7 File Offset: 0x000AE7A7
		public static string GetProjectFilePath()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GetProjectFilePath_Internal());
		}

		// Token: 0x06007B12 RID: 31506 RVA: 0x000B05B4 File Offset: 0x000AE7B4
		public unsafe static string GetPath(string InPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GetPath_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06007B13 RID: 31507 RVA: 0x000B05DD File Offset: 0x000AE7DD
		public static string GetInvalidFileSystemChars()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GetInvalidFileSystemChars_Internal());
		}

		// Token: 0x06007B14 RID: 31508 RVA: 0x000B05E9 File Offset: 0x000AE7E9
		public static TArray<string> GetGameLocalizationPaths()
		{
			return new TArray<string>(UBlueprintPathsLibrary.__GetGameLocalizationPaths_Internal(), null);
		}

		// Token: 0x06007B15 RID: 31509 RVA: 0x000B05F8 File Offset: 0x000AE7F8
		public unsafe static string GetExtension(string InPath, bool bIncludeDot = false)
		{
			FString fstring = FString.AllocTemp(InPath);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GetExtension_Internal(fstring, bIncludeDot));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06007B16 RID: 31510 RVA: 0x000B0622 File Offset: 0x000AE822
		public static TArray<string> GetEngineLocalizationPaths()
		{
			return new TArray<string>(UBlueprintPathsLibrary.__GetEngineLocalizationPaths_Internal(), null);
		}

		// Token: 0x06007B17 RID: 31511 RVA: 0x000B062F File Offset: 0x000AE82F
		public static TArray<string> GetEditorLocalizationPaths()
		{
			return new TArray<string>(UBlueprintPathsLibrary.__GetEditorLocalizationPaths_Internal(), null);
		}

		// Token: 0x06007B18 RID: 31512 RVA: 0x000B063C File Offset: 0x000AE83C
		public unsafe static string GetCleanFilename(string InPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GetCleanFilename_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06007B19 RID: 31513 RVA: 0x000B0668 File Offset: 0x000AE868
		public unsafe static string GetBaseFilename(string InPath, bool bRemovePath = true)
		{
			FString fstring = FString.AllocTemp(InPath);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GetBaseFilename_Internal(fstring, bRemovePath));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06007B1A RID: 31514 RVA: 0x000B0692 File Offset: 0x000AE892
		public static string GeneratedConfigDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GeneratedConfigDir_Internal());
		}

		// Token: 0x06007B1B RID: 31515 RVA: 0x000B069E File Offset: 0x000AE89E
		public static string GameUserDeveloperDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GameUserDeveloperDir_Internal());
		}

		// Token: 0x06007B1C RID: 31516 RVA: 0x000B06AA File Offset: 0x000AE8AA
		public static string GameSourceDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GameSourceDir_Internal());
		}

		// Token: 0x06007B1D RID: 31517 RVA: 0x000B06B6 File Offset: 0x000AE8B6
		public static string GameDevelopersDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GameDevelopersDir_Internal());
		}

		// Token: 0x06007B1E RID: 31518 RVA: 0x000B06C2 File Offset: 0x000AE8C2
		public static string GameAgnosticSavedDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GameAgnosticSavedDir_Internal());
		}

		// Token: 0x06007B1F RID: 31519 RVA: 0x000B06D0 File Offset: 0x000AE8D0
		public unsafe static bool FileExists(string InPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			bool result = UBlueprintPathsLibrary.__FileExists_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06007B20 RID: 31520 RVA: 0x000B06F4 File Offset: 0x000AE8F4
		public static string FeaturePackDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__FeaturePackDir_Internal());
		}

		// Token: 0x06007B21 RID: 31521 RVA: 0x000B0700 File Offset: 0x000AE900
		public static string EnterprisePluginsDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EnterprisePluginsDir_Internal());
		}

		// Token: 0x06007B22 RID: 31522 RVA: 0x000B070C File Offset: 0x000AE90C
		public static string EnterpriseFeaturePackDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EnterpriseFeaturePackDir_Internal());
		}

		// Token: 0x06007B23 RID: 31523 RVA: 0x000B0718 File Offset: 0x000AE918
		public static string EnterpriseDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EnterpriseDir_Internal());
		}

		// Token: 0x06007B24 RID: 31524 RVA: 0x000B0724 File Offset: 0x000AE924
		public static string EngineVersionAgnosticUserDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EngineVersionAgnosticUserDir_Internal());
		}

		// Token: 0x06007B25 RID: 31525 RVA: 0x000B0730 File Offset: 0x000AE930
		public static string EngineUserDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EngineUserDir_Internal());
		}

		// Token: 0x06007B26 RID: 31526 RVA: 0x000B073C File Offset: 0x000AE93C
		public static string EngineSourceDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EngineSourceDir_Internal());
		}

		// Token: 0x06007B27 RID: 31527 RVA: 0x000B0748 File Offset: 0x000AE948
		public static string EngineSavedDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EngineSavedDir_Internal());
		}

		// Token: 0x06007B28 RID: 31528 RVA: 0x000B0754 File Offset: 0x000AE954
		public static string EnginePluginsDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EnginePluginsDir_Internal());
		}

		// Token: 0x06007B29 RID: 31529 RVA: 0x000B0760 File Offset: 0x000AE960
		public static string EngineIntermediateDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EngineIntermediateDir_Internal());
		}

		// Token: 0x06007B2A RID: 31530 RVA: 0x000B076C File Offset: 0x000AE96C
		public static string EngineDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EngineDir_Internal());
		}

		// Token: 0x06007B2B RID: 31531 RVA: 0x000B0778 File Offset: 0x000AE978
		public static string EngineContentDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EngineContentDir_Internal());
		}

		// Token: 0x06007B2C RID: 31532 RVA: 0x000B0784 File Offset: 0x000AE984
		public static string EngineConfigDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EngineConfigDir_Internal());
		}

		// Token: 0x06007B2D RID: 31533 RVA: 0x000B0790 File Offset: 0x000AE990
		public unsafe static bool DirectoryExists(string InPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			bool result = UBlueprintPathsLibrary.__DirectoryExists_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06007B2E RID: 31534 RVA: 0x000B07B4 File Offset: 0x000AE9B4
		public static string DiffDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__DiffDir_Internal());
		}

		// Token: 0x06007B2F RID: 31535 RVA: 0x000B07C0 File Offset: 0x000AE9C0
		public unsafe static string CreateTempFilename(string Path, string Prefix = "", string Extension = ".tmp")
		{
			FString fstring = FString.AllocTemp(Path);
			FString fstring2 = FString.AllocTemp(Prefix);
			FString fstring3 = FString.AllocTemp(Extension);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__CreateTempFilename_Internal(fstring, fstring2, fstring3));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x06007B30 RID: 31536 RVA: 0x000B0810 File Offset: 0x000AEA10
		public unsafe static string ConvertToSandboxPath(string InPath, string InSandboxName)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(InSandboxName);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ConvertToSandboxPath_Internal(fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06007B31 RID: 31537 RVA: 0x000B084C File Offset: 0x000AEA4C
		public unsafe static string ConvertRelativePathToFull(string InPath, string InBasePath = "")
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(InBasePath);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ConvertRelativePathToFull_Internal(fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06007B32 RID: 31538 RVA: 0x000B0888 File Offset: 0x000AEA88
		public unsafe static string ConvertFromSandboxPath(string InPath, string InSandboxName)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(InSandboxName);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ConvertFromSandboxPath_Internal(fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06007B33 RID: 31539 RVA: 0x000B08C3 File Offset: 0x000AEAC3
		public static string Combine([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> InPaths)
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__Combine_Internal((InPaths ?? new TArray<string>()).NativePtr));
		}

		// Token: 0x06007B34 RID: 31540 RVA: 0x000B08E0 File Offset: 0x000AEAE0
		public unsafe static bool CollapseRelativeDirectories(string InPath, ref string OutPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(OutPath);
			bool result = UBlueprintPathsLibrary.__CollapseRelativeDirectories_Internal(fstring, ref fstring2);
			FString.NativeDestruct(&fstring, 1);
			OutPath = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06007B35 RID: 31541 RVA: 0x000B0920 File Offset: 0x000AEB20
		public static string CloudDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__CloudDir_Internal());
		}

		// Token: 0x06007B36 RID: 31542 RVA: 0x000B092C File Offset: 0x000AEB2C
		public unsafe static string ChangeExtension(string InPath, string InNewExtension)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(InNewExtension);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ChangeExtension_Internal(fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06007B37 RID: 31543 RVA: 0x000B0967 File Offset: 0x000AEB67
		public static string BugItDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__BugItDir_Internal());
		}

		// Token: 0x06007B38 RID: 31544 RVA: 0x000B0973 File Offset: 0x000AEB73
		public static string AutomationTransientDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__AutomationTransientDir_Internal());
		}

		// Token: 0x06007B39 RID: 31545 RVA: 0x000B097F File Offset: 0x000AEB7F
		public static string AutomationLogDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__AutomationLogDir_Internal());
		}

		// Token: 0x06007B3A RID: 31546 RVA: 0x000B098B File Offset: 0x000AEB8B
		public static string AutomationDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__AutomationDir_Internal());
		}

		// Token: 0x06007B3B RID: 31547
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __VideoCaptureDir_Internal();

		// Token: 0x06007B3C RID: 31548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ValidatePath_Internal(in FString InPath, ref bool bDidSucceed, IntPtr OutReason);

		// Token: 0x06007B3D RID: 31549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Split_Internal(in FString InPath, ref FString PathPart, ref FString FilenamePart, ref FString ExtensionPart);

		// Token: 0x06007B3E RID: 31550
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __SourceConfigDir_Internal();

		// Token: 0x06007B3F RID: 31551
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ShaderWorkingDir_Internal();

		// Token: 0x06007B40 RID: 31552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetProjectFilePath_Internal(in FString NewGameProjectFilePath);

		// Token: 0x06007B41 RID: 31553
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __SetExtension_Internal(in FString InPath, in FString InNewExtension);

		// Token: 0x06007B42 RID: 31554
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ScreenShotDir_Internal();

		// Token: 0x06007B43 RID: 31555
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __SandboxesDir_Internal();

		// Token: 0x06007B44 RID: 31556
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __RootDir_Internal();

		// Token: 0x06007B45 RID: 31557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveDuplicateSlashes_Internal(in FString InPath, ref FString OutPath);

		// Token: 0x06007B46 RID: 31558
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectUserDir_Internal();

		// Token: 0x06007B47 RID: 31559
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectSavedDir_Internal();

		// Token: 0x06007B48 RID: 31560
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectPluginsDir_Internal();

		// Token: 0x06007B49 RID: 31561
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectPersistentDownloadDir_Internal();

		// Token: 0x06007B4A RID: 31562
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectModsDir_Internal();

		// Token: 0x06007B4B RID: 31563
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectLogDir_Internal();

		// Token: 0x06007B4C RID: 31564
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectIntermediateDir_Internal();

		// Token: 0x06007B4D RID: 31565
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectDir_Internal();

		// Token: 0x06007B4E RID: 31566
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectContentDir_Internal();

		// Token: 0x06007B4F RID: 31567
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectConfigDir_Internal();

		// Token: 0x06007B50 RID: 31568
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProfilingDir_Internal();

		// Token: 0x06007B51 RID: 31569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NormalizeFilename_Internal(in FString InPath, ref FString OutPath);

		// Token: 0x06007B52 RID: 31570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NormalizeDirectoryName_Internal(in FString InPath, ref FString OutPath);

		// Token: 0x06007B53 RID: 31571
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __MakeValidFileName_Internal(in FString InString, in FString InReplacementChar);

		// Token: 0x06007B54 RID: 31572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MakeStandardFilename_Internal(in FString InPath, ref FString OutPath);

		// Token: 0x06007B55 RID: 31573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MakePlatformFilename_Internal(in FString InPath, ref FString OutPath);

		// Token: 0x06007B56 RID: 31574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MakePathRelativeTo_Internal(in FString InPath, in FString InRelativeTo, ref FString OutPath);

		// Token: 0x06007B57 RID: 31575
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __LaunchDir_Internal();

		// Token: 0x06007B58 RID: 31576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSamePath_Internal(in FString PathA, in FString PathB);

		// Token: 0x06007B59 RID: 31577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRestrictedPath_Internal(in FString InPath);

		// Token: 0x06007B5A RID: 31578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRelative_Internal(in FString InPath);

		// Token: 0x06007B5B RID: 31579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDrive_Internal(in FString InPath);

		// Token: 0x06007B5C RID: 31580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetToolTipLocalizationPaths_Internal();

		// Token: 0x06007B5D RID: 31581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRestrictedFolderNames_Internal();

		// Token: 0x06007B5E RID: 31582
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetRelativePathToRoot_Internal();

		// Token: 0x06007B5F RID: 31583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPropertyNameLocalizationPaths_Internal();

		// Token: 0x06007B60 RID: 31584
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetProjectFilePath_Internal();

		// Token: 0x06007B61 RID: 31585
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetPath_Internal(in FString InPath);

		// Token: 0x06007B62 RID: 31586
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetInvalidFileSystemChars_Internal();

		// Token: 0x06007B63 RID: 31587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGameLocalizationPaths_Internal();

		// Token: 0x06007B64 RID: 31588
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetExtension_Internal(in FString InPath, bool bIncludeDot);

		// Token: 0x06007B65 RID: 31589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEngineLocalizationPaths_Internal();

		// Token: 0x06007B66 RID: 31590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEditorLocalizationPaths_Internal();

		// Token: 0x06007B67 RID: 31591
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCleanFilename_Internal(in FString InPath);

		// Token: 0x06007B68 RID: 31592
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetBaseFilename_Internal(in FString InPath, bool bRemovePath);

		// Token: 0x06007B69 RID: 31593
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GeneratedConfigDir_Internal();

		// Token: 0x06007B6A RID: 31594
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GameUserDeveloperDir_Internal();

		// Token: 0x06007B6B RID: 31595
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GameSourceDir_Internal();

		// Token: 0x06007B6C RID: 31596
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GameDevelopersDir_Internal();

		// Token: 0x06007B6D RID: 31597
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GameAgnosticSavedDir_Internal();

		// Token: 0x06007B6E RID: 31598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FileExists_Internal(in FString InPath);

		// Token: 0x06007B6F RID: 31599
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __FeaturePackDir_Internal();

		// Token: 0x06007B70 RID: 31600
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EnterprisePluginsDir_Internal();

		// Token: 0x06007B71 RID: 31601
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EnterpriseFeaturePackDir_Internal();

		// Token: 0x06007B72 RID: 31602
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EnterpriseDir_Internal();

		// Token: 0x06007B73 RID: 31603
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EngineVersionAgnosticUserDir_Internal();

		// Token: 0x06007B74 RID: 31604
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EngineUserDir_Internal();

		// Token: 0x06007B75 RID: 31605
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EngineSourceDir_Internal();

		// Token: 0x06007B76 RID: 31606
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EngineSavedDir_Internal();

		// Token: 0x06007B77 RID: 31607
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EnginePluginsDir_Internal();

		// Token: 0x06007B78 RID: 31608
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EngineIntermediateDir_Internal();

		// Token: 0x06007B79 RID: 31609
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EngineDir_Internal();

		// Token: 0x06007B7A RID: 31610
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EngineContentDir_Internal();

		// Token: 0x06007B7B RID: 31611
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EngineConfigDir_Internal();

		// Token: 0x06007B7C RID: 31612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DirectoryExists_Internal(in FString InPath);

		// Token: 0x06007B7D RID: 31613
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __DiffDir_Internal();

		// Token: 0x06007B7E RID: 31614
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __CreateTempFilename_Internal(in FString Path, in FString Prefix, in FString Extension);

		// Token: 0x06007B7F RID: 31615
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ConvertToSandboxPath_Internal(in FString InPath, in FString InSandboxName);

		// Token: 0x06007B80 RID: 31616
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ConvertRelativePathToFull_Internal(in FString InPath, in FString InBasePath);

		// Token: 0x06007B81 RID: 31617
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ConvertFromSandboxPath_Internal(in FString InPath, in FString InSandboxName);

		// Token: 0x06007B82 RID: 31618
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Combine_Internal(IntPtr InPaths);

		// Token: 0x06007B83 RID: 31619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CollapseRelativeDirectories_Internal(in FString InPath, ref FString OutPath);

		// Token: 0x06007B84 RID: 31620
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __CloudDir_Internal();

		// Token: 0x06007B85 RID: 31621
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ChangeExtension_Internal(in FString InPath, in FString InNewExtension);

		// Token: 0x06007B86 RID: 31622
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BugItDir_Internal();

		// Token: 0x06007B87 RID: 31623
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __AutomationTransientDir_Internal();

		// Token: 0x06007B88 RID: 31624
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __AutomationLogDir_Internal();

		// Token: 0x06007B89 RID: 31625
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __AutomationDir_Internal();

		// Token: 0x06007B8A RID: 31626 RVA: 0x000B0997 File Offset: 0x000AEB97
		static UBlueprintPathsLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlueprintPathsLibrary");
		}

		// Token: 0x06007B8B RID: 31627 RVA: 0x000B09A5 File Offset: 0x000AEBA5
		protected UBlueprintPathsLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003B1E RID: 15134
		public new const string __ObjectPath = "/Script/Engine.BlueprintPathsLibrary";

		// Token: 0x04003B1F RID: 15135
		private static IntPtr _ClassPtr;

		// Token: 0x04003B20 RID: 15136
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
