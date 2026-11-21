using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000192 RID: 402
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BlueprintPathsLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UBlueprintPathsLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001A1D RID: 6685 RVA: 0x00027344 File Offset: 0x00025544
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlueprintPathsLibrary._ClassPtr;
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x00027350 File Offset: 0x00025550
		public UBlueprintPathsLibrary() : this(BuiltinUtils.AllocNativeUObject(UBlueprintPathsLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x00027378 File Offset: 0x00025578
		public UBlueprintPathsLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlueprintPathsLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x000273AB File Offset: 0x000255AB
		public static string VideoCaptureDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__VideoCaptureDir_Internal());
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x000273B8 File Offset: 0x000255B8
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

		// Token: 0x06001A22 RID: 6690 RVA: 0x000273F8 File Offset: 0x000255F8
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

		// Token: 0x06001A23 RID: 6691 RVA: 0x00027470 File Offset: 0x00025670
		public static string SourceConfigDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__SourceConfigDir_Internal());
		}

		// Token: 0x06001A24 RID: 6692
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool ShouldSaveToUserDir();

		// Token: 0x06001A25 RID: 6693 RVA: 0x0002747C File Offset: 0x0002567C
		public static string ShaderWorkingDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ShaderWorkingDir_Internal());
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x00027488 File Offset: 0x00025688
		public unsafe static void SetProjectFilePath(string NewGameProjectFilePath)
		{
			FString fstring = FString.AllocTemp(NewGameProjectFilePath);
			UBlueprintPathsLibrary.__SetProjectFilePath_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x000274AC File Offset: 0x000256AC
		public unsafe static string SetExtension(string InPath, string InNewExtension)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(InNewExtension);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__SetExtension_Internal(fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x000274E7 File Offset: 0x000256E7
		public static string ScreenShotDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ScreenShotDir_Internal());
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x000274F3 File Offset: 0x000256F3
		public static string SandboxesDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__SandboxesDir_Internal());
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x000274FF File Offset: 0x000256FF
		public static string RootDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__RootDir_Internal());
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x0002750C File Offset: 0x0002570C
		public unsafe static void RemoveDuplicateSlashes(string InPath, ref string OutPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(OutPath);
			UBlueprintPathsLibrary.__RemoveDuplicateSlashes_Internal(fstring, ref fstring2);
			FString.NativeDestruct(&fstring, 1);
			OutPath = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x0002754C File Offset: 0x0002574C
		public static string ProjectUserDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectUserDir_Internal());
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x00027558 File Offset: 0x00025758
		public static string ProjectSavedDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectSavedDir_Internal());
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x00027564 File Offset: 0x00025764
		public static string ProjectPluginsDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectPluginsDir_Internal());
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00027570 File Offset: 0x00025770
		public static string ProjectPersistentDownloadDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectPersistentDownloadDir_Internal());
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x0002757C File Offset: 0x0002577C
		public static string ProjectModsDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectModsDir_Internal());
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x00027588 File Offset: 0x00025788
		public static string ProjectLogDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectLogDir_Internal());
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00027594 File Offset: 0x00025794
		public static string ProjectIntermediateDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectIntermediateDir_Internal());
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x000275A0 File Offset: 0x000257A0
		public static string ProjectDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectDir_Internal());
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x000275AC File Offset: 0x000257AC
		public static string ProjectContentDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectContentDir_Internal());
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x000275B8 File Offset: 0x000257B8
		public static string ProjectConfigDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProjectConfigDir_Internal());
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x000275C4 File Offset: 0x000257C4
		public static string ProfilingDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ProfilingDir_Internal());
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x000275D0 File Offset: 0x000257D0
		public unsafe static void NormalizeFilename(string InPath, ref string OutPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(OutPath);
			UBlueprintPathsLibrary.__NormalizeFilename_Internal(fstring, ref fstring2);
			FString.NativeDestruct(&fstring, 1);
			OutPath = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00027610 File Offset: 0x00025810
		public unsafe static void NormalizeDirectoryName(string InPath, ref string OutPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(OutPath);
			UBlueprintPathsLibrary.__NormalizeDirectoryName_Internal(fstring, ref fstring2);
			FString.NativeDestruct(&fstring, 1);
			OutPath = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x00027650 File Offset: 0x00025850
		public unsafe static string MakeValidFileName(string InString, string InReplacementChar = "")
		{
			FString fstring = FString.AllocTemp(InString);
			FString fstring2 = FString.AllocTemp(InReplacementChar);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__MakeValidFileName_Internal(fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x0002768C File Offset: 0x0002588C
		public unsafe static void MakeStandardFilename(string InPath, ref string OutPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(OutPath);
			UBlueprintPathsLibrary.__MakeStandardFilename_Internal(fstring, ref fstring2);
			FString.NativeDestruct(&fstring, 1);
			OutPath = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x000276CC File Offset: 0x000258CC
		public unsafe static void MakePlatformFilename(string InPath, ref string OutPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(OutPath);
			UBlueprintPathsLibrary.__MakePlatformFilename_Internal(fstring, ref fstring2);
			FString.NativeDestruct(&fstring, 1);
			OutPath = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0002770C File Offset: 0x0002590C
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

		// Token: 0x06001A3D RID: 6717 RVA: 0x0002775E File Offset: 0x0002595E
		public static string LaunchDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__LaunchDir_Internal());
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x0002776C File Offset: 0x0002596C
		public unsafe static bool IsSamePath(string PathA, string PathB)
		{
			FString fstring = FString.AllocTemp(PathA);
			FString fstring2 = FString.AllocTemp(PathB);
			bool result = UBlueprintPathsLibrary.__IsSamePath_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x000277A4 File Offset: 0x000259A4
		public unsafe static bool IsRestrictedPath(string InPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			bool result = UBlueprintPathsLibrary.__IsRestrictedPath_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x000277C8 File Offset: 0x000259C8
		public unsafe static bool IsRelative(string InPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			bool result = UBlueprintPathsLibrary.__IsRelative_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06001A41 RID: 6721
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsProjectFilePathSet();

		// Token: 0x06001A42 RID: 6722 RVA: 0x000277EC File Offset: 0x000259EC
		public unsafe static bool IsDrive(string InPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			bool result = UBlueprintPathsLibrary.__IsDrive_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06001A43 RID: 6723
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasProjectPersistentDownloadDir();

		// Token: 0x06001A44 RID: 6724 RVA: 0x00027810 File Offset: 0x00025A10
		public static TArray<string> GetToolTipLocalizationPaths()
		{
			return new TArray<string>(UBlueprintPathsLibrary.__GetToolTipLocalizationPaths_Internal(), null);
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0002781D File Offset: 0x00025A1D
		public static TArray<string> GetRestrictedFolderNames()
		{
			return new TArray<string>(UBlueprintPathsLibrary.__GetRestrictedFolderNames_Internal(), null);
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0002782A File Offset: 0x00025A2A
		public static string GetRelativePathToRoot()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GetRelativePathToRoot_Internal());
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x00027836 File Offset: 0x00025A36
		public static TArray<string> GetPropertyNameLocalizationPaths()
		{
			return new TArray<string>(UBlueprintPathsLibrary.__GetPropertyNameLocalizationPaths_Internal(), null);
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x00027843 File Offset: 0x00025A43
		public static string GetProjectFilePath()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GetProjectFilePath_Internal());
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x00027850 File Offset: 0x00025A50
		public unsafe static string GetPath(string InPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GetPath_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00027879 File Offset: 0x00025A79
		public static string GetInvalidFileSystemChars()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GetInvalidFileSystemChars_Internal());
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00027885 File Offset: 0x00025A85
		public static TArray<string> GetGameLocalizationPaths()
		{
			return new TArray<string>(UBlueprintPathsLibrary.__GetGameLocalizationPaths_Internal(), null);
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x00027894 File Offset: 0x00025A94
		public unsafe static string GetExtension(string InPath, bool bIncludeDot = false)
		{
			FString fstring = FString.AllocTemp(InPath);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GetExtension_Internal(fstring, bIncludeDot));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x000278BE File Offset: 0x00025ABE
		public static TArray<string> GetEngineLocalizationPaths()
		{
			return new TArray<string>(UBlueprintPathsLibrary.__GetEngineLocalizationPaths_Internal(), null);
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x000278CB File Offset: 0x00025ACB
		public static TArray<string> GetEditorLocalizationPaths()
		{
			return new TArray<string>(UBlueprintPathsLibrary.__GetEditorLocalizationPaths_Internal(), null);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x000278D8 File Offset: 0x00025AD8
		public unsafe static string GetCleanFilename(string InPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GetCleanFilename_Internal(fstring));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x00027904 File Offset: 0x00025B04
		public unsafe static string GetBaseFilename(string InPath, bool bRemovePath = true)
		{
			FString fstring = FString.AllocTemp(InPath);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GetBaseFilename_Internal(fstring, bRemovePath));
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x0002792E File Offset: 0x00025B2E
		public static string GeneratedConfigDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GeneratedConfigDir_Internal());
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x0002793A File Offset: 0x00025B3A
		public static string GameUserDeveloperDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GameUserDeveloperDir_Internal());
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x00027946 File Offset: 0x00025B46
		public static string GameSourceDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GameSourceDir_Internal());
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00027952 File Offset: 0x00025B52
		public static string GameDevelopersDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GameDevelopersDir_Internal());
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x0002795E File Offset: 0x00025B5E
		public static string GameAgnosticSavedDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__GameAgnosticSavedDir_Internal());
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x0002796C File Offset: 0x00025B6C
		public unsafe static bool FileExists(string InPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			bool result = UBlueprintPathsLibrary.__FileExists_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x00027990 File Offset: 0x00025B90
		public static string FeaturePackDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__FeaturePackDir_Internal());
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x0002799C File Offset: 0x00025B9C
		public static string EnterprisePluginsDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EnterprisePluginsDir_Internal());
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x000279A8 File Offset: 0x00025BA8
		public static string EnterpriseFeaturePackDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EnterpriseFeaturePackDir_Internal());
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x000279B4 File Offset: 0x00025BB4
		public static string EnterpriseDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EnterpriseDir_Internal());
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x000279C0 File Offset: 0x00025BC0
		public static string EngineVersionAgnosticUserDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EngineVersionAgnosticUserDir_Internal());
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x000279CC File Offset: 0x00025BCC
		public static string EngineUserDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EngineUserDir_Internal());
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x000279D8 File Offset: 0x00025BD8
		public static string EngineSourceDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EngineSourceDir_Internal());
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x000279E4 File Offset: 0x00025BE4
		public static string EngineSavedDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EngineSavedDir_Internal());
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x000279F0 File Offset: 0x00025BF0
		public static string EnginePluginsDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EnginePluginsDir_Internal());
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x000279FC File Offset: 0x00025BFC
		public static string EngineIntermediateDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EngineIntermediateDir_Internal());
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x00027A08 File Offset: 0x00025C08
		public static string EngineDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EngineDir_Internal());
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00027A14 File Offset: 0x00025C14
		public static string EngineContentDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EngineContentDir_Internal());
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x00027A20 File Offset: 0x00025C20
		public static string EngineConfigDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__EngineConfigDir_Internal());
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00027A2C File Offset: 0x00025C2C
		public unsafe static bool DirectoryExists(string InPath)
		{
			FString fstring = FString.AllocTemp(InPath);
			bool result = UBlueprintPathsLibrary.__DirectoryExists_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x00027A50 File Offset: 0x00025C50
		public static string DiffDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__DiffDir_Internal());
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x00027A5C File Offset: 0x00025C5C
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

		// Token: 0x06001A67 RID: 6759 RVA: 0x00027AAC File Offset: 0x00025CAC
		public unsafe static string ConvertToSandboxPath(string InPath, string InSandboxName)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(InSandboxName);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ConvertToSandboxPath_Internal(fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00027AE8 File Offset: 0x00025CE8
		public unsafe static string ConvertRelativePathToFull(string InPath, string InBasePath = "")
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(InBasePath);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ConvertRelativePathToFull_Internal(fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00027B24 File Offset: 0x00025D24
		public unsafe static string ConvertFromSandboxPath(string InPath, string InSandboxName)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(InSandboxName);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ConvertFromSandboxPath_Internal(fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00027B5F File Offset: 0x00025D5F
		public static string Combine([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<string> InPaths)
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__Combine_Internal((InPaths ?? new TArray<string>()).NativePtr));
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x00027B7C File Offset: 0x00025D7C
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

		// Token: 0x06001A6C RID: 6764 RVA: 0x00027BBC File Offset: 0x00025DBC
		public static string CloudDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__CloudDir_Internal());
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x00027BC8 File Offset: 0x00025DC8
		public unsafe static string ChangeExtension(string InPath, string InNewExtension)
		{
			FString fstring = FString.AllocTemp(InPath);
			FString fstring2 = FString.AllocTemp(InNewExtension);
			string result = FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__ChangeExtension_Internal(fstring, fstring2));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x00027C03 File Offset: 0x00025E03
		public static string BugItDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__BugItDir_Internal());
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x00027C0F File Offset: 0x00025E0F
		public static string AutomationTransientDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__AutomationTransientDir_Internal());
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x00027C1B File Offset: 0x00025E1B
		public static string AutomationLogDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__AutomationLogDir_Internal());
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x00027C27 File Offset: 0x00025E27
		public static string AutomationDir()
		{
			return FString.ToStringAndDeleteNativePtr(UBlueprintPathsLibrary.__AutomationDir_Internal());
		}

		// Token: 0x06001A72 RID: 6770
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __VideoCaptureDir_Internal();

		// Token: 0x06001A73 RID: 6771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ValidatePath_Internal(in FString InPath, ref bool bDidSucceed, IntPtr OutReason);

		// Token: 0x06001A74 RID: 6772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Split_Internal(in FString InPath, ref FString PathPart, ref FString FilenamePart, ref FString ExtensionPart);

		// Token: 0x06001A75 RID: 6773
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __SourceConfigDir_Internal();

		// Token: 0x06001A76 RID: 6774
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ShaderWorkingDir_Internal();

		// Token: 0x06001A77 RID: 6775
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetProjectFilePath_Internal(in FString NewGameProjectFilePath);

		// Token: 0x06001A78 RID: 6776
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __SetExtension_Internal(in FString InPath, in FString InNewExtension);

		// Token: 0x06001A79 RID: 6777
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ScreenShotDir_Internal();

		// Token: 0x06001A7A RID: 6778
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __SandboxesDir_Internal();

		// Token: 0x06001A7B RID: 6779
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __RootDir_Internal();

		// Token: 0x06001A7C RID: 6780
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveDuplicateSlashes_Internal(in FString InPath, ref FString OutPath);

		// Token: 0x06001A7D RID: 6781
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectUserDir_Internal();

		// Token: 0x06001A7E RID: 6782
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectSavedDir_Internal();

		// Token: 0x06001A7F RID: 6783
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectPluginsDir_Internal();

		// Token: 0x06001A80 RID: 6784
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectPersistentDownloadDir_Internal();

		// Token: 0x06001A81 RID: 6785
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectModsDir_Internal();

		// Token: 0x06001A82 RID: 6786
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectLogDir_Internal();

		// Token: 0x06001A83 RID: 6787
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectIntermediateDir_Internal();

		// Token: 0x06001A84 RID: 6788
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectDir_Internal();

		// Token: 0x06001A85 RID: 6789
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectContentDir_Internal();

		// Token: 0x06001A86 RID: 6790
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProjectConfigDir_Internal();

		// Token: 0x06001A87 RID: 6791
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ProfilingDir_Internal();

		// Token: 0x06001A88 RID: 6792
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NormalizeFilename_Internal(in FString InPath, ref FString OutPath);

		// Token: 0x06001A89 RID: 6793
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NormalizeDirectoryName_Internal(in FString InPath, ref FString OutPath);

		// Token: 0x06001A8A RID: 6794
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __MakeValidFileName_Internal(in FString InString, in FString InReplacementChar);

		// Token: 0x06001A8B RID: 6795
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MakeStandardFilename_Internal(in FString InPath, ref FString OutPath);

		// Token: 0x06001A8C RID: 6796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MakePlatformFilename_Internal(in FString InPath, ref FString OutPath);

		// Token: 0x06001A8D RID: 6797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MakePathRelativeTo_Internal(in FString InPath, in FString InRelativeTo, ref FString OutPath);

		// Token: 0x06001A8E RID: 6798
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __LaunchDir_Internal();

		// Token: 0x06001A8F RID: 6799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSamePath_Internal(in FString PathA, in FString PathB);

		// Token: 0x06001A90 RID: 6800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRestrictedPath_Internal(in FString InPath);

		// Token: 0x06001A91 RID: 6801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRelative_Internal(in FString InPath);

		// Token: 0x06001A92 RID: 6802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDrive_Internal(in FString InPath);

		// Token: 0x06001A93 RID: 6803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetToolTipLocalizationPaths_Internal();

		// Token: 0x06001A94 RID: 6804
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRestrictedFolderNames_Internal();

		// Token: 0x06001A95 RID: 6805
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetRelativePathToRoot_Internal();

		// Token: 0x06001A96 RID: 6806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPropertyNameLocalizationPaths_Internal();

		// Token: 0x06001A97 RID: 6807
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetProjectFilePath_Internal();

		// Token: 0x06001A98 RID: 6808
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetPath_Internal(in FString InPath);

		// Token: 0x06001A99 RID: 6809
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetInvalidFileSystemChars_Internal();

		// Token: 0x06001A9A RID: 6810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGameLocalizationPaths_Internal();

		// Token: 0x06001A9B RID: 6811
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetExtension_Internal(in FString InPath, bool bIncludeDot);

		// Token: 0x06001A9C RID: 6812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEngineLocalizationPaths_Internal();

		// Token: 0x06001A9D RID: 6813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEditorLocalizationPaths_Internal();

		// Token: 0x06001A9E RID: 6814
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCleanFilename_Internal(in FString InPath);

		// Token: 0x06001A9F RID: 6815
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetBaseFilename_Internal(in FString InPath, bool bRemovePath);

		// Token: 0x06001AA0 RID: 6816
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GeneratedConfigDir_Internal();

		// Token: 0x06001AA1 RID: 6817
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GameUserDeveloperDir_Internal();

		// Token: 0x06001AA2 RID: 6818
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GameSourceDir_Internal();

		// Token: 0x06001AA3 RID: 6819
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GameDevelopersDir_Internal();

		// Token: 0x06001AA4 RID: 6820
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GameAgnosticSavedDir_Internal();

		// Token: 0x06001AA5 RID: 6821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FileExists_Internal(in FString InPath);

		// Token: 0x06001AA6 RID: 6822
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __FeaturePackDir_Internal();

		// Token: 0x06001AA7 RID: 6823
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EnterprisePluginsDir_Internal();

		// Token: 0x06001AA8 RID: 6824
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EnterpriseFeaturePackDir_Internal();

		// Token: 0x06001AA9 RID: 6825
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EnterpriseDir_Internal();

		// Token: 0x06001AAA RID: 6826
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EngineVersionAgnosticUserDir_Internal();

		// Token: 0x06001AAB RID: 6827
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EngineUserDir_Internal();

		// Token: 0x06001AAC RID: 6828
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EngineSourceDir_Internal();

		// Token: 0x06001AAD RID: 6829
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EngineSavedDir_Internal();

		// Token: 0x06001AAE RID: 6830
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EnginePluginsDir_Internal();

		// Token: 0x06001AAF RID: 6831
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EngineIntermediateDir_Internal();

		// Token: 0x06001AB0 RID: 6832
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EngineDir_Internal();

		// Token: 0x06001AB1 RID: 6833
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EngineContentDir_Internal();

		// Token: 0x06001AB2 RID: 6834
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __EngineConfigDir_Internal();

		// Token: 0x06001AB3 RID: 6835
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DirectoryExists_Internal(in FString InPath);

		// Token: 0x06001AB4 RID: 6836
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __DiffDir_Internal();

		// Token: 0x06001AB5 RID: 6837
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __CreateTempFilename_Internal(in FString Path, in FString Prefix, in FString Extension);

		// Token: 0x06001AB6 RID: 6838
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ConvertToSandboxPath_Internal(in FString InPath, in FString InSandboxName);

		// Token: 0x06001AB7 RID: 6839
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ConvertRelativePathToFull_Internal(in FString InPath, in FString InBasePath);

		// Token: 0x06001AB8 RID: 6840
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ConvertFromSandboxPath_Internal(in FString InPath, in FString InSandboxName);

		// Token: 0x06001AB9 RID: 6841
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Combine_Internal(IntPtr InPaths);

		// Token: 0x06001ABA RID: 6842
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CollapseRelativeDirectories_Internal(in FString InPath, ref FString OutPath);

		// Token: 0x06001ABB RID: 6843
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __CloudDir_Internal();

		// Token: 0x06001ABC RID: 6844
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __ChangeExtension_Internal(in FString InPath, in FString InNewExtension);

		// Token: 0x06001ABD RID: 6845
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __BugItDir_Internal();

		// Token: 0x06001ABE RID: 6846
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __AutomationTransientDir_Internal();

		// Token: 0x06001ABF RID: 6847
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __AutomationLogDir_Internal();

		// Token: 0x06001AC0 RID: 6848
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __AutomationDir_Internal();

		// Token: 0x06001AC1 RID: 6849 RVA: 0x00027C33 File Offset: 0x00025E33
		static UBlueprintPathsLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlueprintPathsLibrary");
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x00027C41 File Offset: 0x00025E41
		protected UBlueprintPathsLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400086F RID: 2159
		public new const string __ObjectPath = "/Script/Engine.BlueprintPathsLibrary";

		// Token: 0x04000870 RID: 2160
		private static IntPtr _ClassPtr;

		// Token: 0x04000871 RID: 2161
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
