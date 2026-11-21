using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000446 RID: 1094
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroHotPatch.KuroLauncherLibrary")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKuroLauncherLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006966 RID: 26982 RVA: 0x0009A112 File Offset: 0x00098312
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLauncherLibrary._ClassPtr;
		}

		// Token: 0x06006967 RID: 26983 RVA: 0x0009A120 File Offset: 0x00098320
		public UKuroLauncherLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroLauncherLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006968 RID: 26984 RVA: 0x0009A148 File Offset: 0x00098348
		public UKuroLauncherLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLauncherLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x06006969 RID: 26985 RVA: 0x0009A17C File Offset: 0x0009837C
		// (set) Token: 0x0600696A RID: 26986 RVA: 0x0009A1B5 File Offset: 0x000983B5
		public TSet<UObject> PreloadBp
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UObject> result;
				if ((result = this._PreloadBp) == null)
				{
					result = (this._PreloadBp = new TSet<UObject>(base.NativePtr + (IntPtr)UKuroLauncherLibrary.__PropertyOffset_PreloadBp, this));
				}
				return result;
			}
			set
			{
				this.PreloadBp.CopyAssign(value);
			}
		}

		// Token: 0x0600696B RID: 26987
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void WillClearPatchPaks();

		// Token: 0x0600696C RID: 26988
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetRestartApp(byte RestartType);

		// Token: 0x0600696D RID: 26989
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetPrecompileShaderBatchMode(int Mode);

		// Token: 0x0600696E RID: 26990
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResumeCompileShader();

		// Token: 0x0600696F RID: 26991 RVA: 0x0009A1C4 File Offset: 0x000983C4
		public unsafe static void RestartApplication(string ScriptContent)
		{
			FString fstring = FString.AllocTemp(ScriptContent);
			UKuroLauncherLibrary.__RestartApplication_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06006970 RID: 26992
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetLauncher();

		// Token: 0x06006971 RID: 26993
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ReloadShaderLibrary();

		// Token: 0x06006972 RID: 26994
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void PreloadRequiredBp();

		// Token: 0x06006973 RID: 26995
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte NeedRestartApp();

		// Token: 0x06006974 RID: 26996
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NeedHotPatch();

		// Token: 0x06006975 RID: 26997
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NeedClearPatchPaks();

		// Token: 0x06006976 RID: 26998 RVA: 0x0009A1E8 File Offset: 0x000983E8
		public unsafe static bool MoveFile(string DstPath, string SrcPath)
		{
			FString fstring = FString.AllocTemp(DstPath);
			FString fstring2 = FString.AllocTemp(SrcPath);
			bool result = UKuroLauncherLibrary.__MoveFile_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06006977 RID: 26999 RVA: 0x0009A220 File Offset: 0x00098420
		public unsafe static bool MakeDirectory(string DirPath)
		{
			FString fstring = FString.AllocTemp(DirPath);
			bool result = UKuroLauncherLibrary.__MakeDirectory_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06006978 RID: 27000
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LogoutToLauncher();

		// Token: 0x06006979 RID: 27001
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsStartupMountSuccess();

		// Token: 0x0600697A RID: 27002
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsSeparateVideo();

		// Token: 0x0600697B RID: 27003
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsLocalPackaging();

		// Token: 0x0600697C RID: 27004
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsFirstIntoLauncher();

		// Token: 0x0600697D RID: 27005
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsEnableOptionalPackage();

		// Token: 0x0600697E RID: 27006
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetTotalPrecompileShaders();

		// Token: 0x0600697F RID: 27007 RVA: 0x0009A244 File Offset: 0x00098444
		public unsafe static long GetTotalAndFreeSpace(string CheckPath, ref long FreeSize)
		{
			FString fstring = FString.AllocTemp(CheckPath);
			fixed (long* ptr = &FreeSize)
			{
				void* ptr2 = (void*)ptr;
				long result = UKuroLauncherLibrary.__GetTotalAndFreeSpace_Internal(fstring, ref FreeSize);
				FString.NativeDestruct(&fstring, 1);
				return result;
			}
		}

		// Token: 0x06006980 RID: 27008
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetRemainPrecompileShaders();

		// Token: 0x06006981 RID: 27009
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte GetNetworkConnectionType();

		// Token: 0x06006982 RID: 27010 RVA: 0x0009A26E File Offset: 0x0009846E
		public static void GetMountedPaks([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> OutPakFilenames)
		{
			UKuroLauncherLibrary.__GetMountedPaks_Internal((OutPakFilenames ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x06006983 RID: 27011 RVA: 0x0009A288 File Offset: 0x00098488
		public unsafe static bool GetGConfigString(string Section, string Key, ref string OutStr)
		{
			FString fstring = FString.AllocTemp(Section);
			FString fstring2 = FString.AllocTemp(Key);
			FString fstring3 = FString.AllocTemp(OutStr);
			bool result = UKuroLauncherLibrary.__GetGConfigString_Internal(fstring, fstring2, ref fstring3);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			OutStr = FString.ToString(fstring3);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x06006984 RID: 27012 RVA: 0x0009A2DC File Offset: 0x000984DC
		public unsafe static long GetFileSize(string FilePath)
		{
			FString fstring = FString.AllocTemp(FilePath);
			long result = UKuroLauncherLibrary.__GetFileSize_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06006985 RID: 27013 RVA: 0x0009A300 File Offset: 0x00098500
		public unsafe static bool GetConfig(string Key, string DefaultValue, ref string OutStr)
		{
			FString fstring = FString.AllocTemp(Key);
			FString fstring2 = FString.AllocTemp(DefaultValue);
			FString fstring3 = FString.AllocTemp(OutStr);
			bool result = UKuroLauncherLibrary.__GetConfig_Internal(fstring, fstring2, ref fstring3);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			OutStr = FString.ToString(fstring3);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x06006986 RID: 27014 RVA: 0x0009A352 File Offset: 0x00098552
		public static string GetAppVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroLauncherLibrary.__GetAppVersion_Internal());
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x0009A35E File Offset: 0x0009855E
		public static string GetAppReleaseType()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroLauncherLibrary.__GetAppReleaseType_Internal());
		}

		// Token: 0x06006988 RID: 27016 RVA: 0x0009A36A File Offset: 0x0009856A
		public static string GetAppParallel()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroLauncherLibrary.__GetAppParallel_Internal());
		}

		// Token: 0x06006989 RID: 27017 RVA: 0x0009A376 File Offset: 0x00098576
		public static string GetAppInternalUseType()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroLauncherLibrary.__GetAppInternalUseType_Internal());
		}

		// Token: 0x0600698A RID: 27018 RVA: 0x0009A382 File Offset: 0x00098582
		public static string GetAppChangeList()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroLauncherLibrary.__GetAppChangeList_Internal());
		}

		// Token: 0x0600698B RID: 27019 RVA: 0x0009A38E File Offset: 0x0009858E
		public static string GameSavedDir()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroLauncherLibrary.__GameSavedDir_Internal());
		}

		// Token: 0x0600698C RID: 27020 RVA: 0x0009A39C File Offset: 0x0009859C
		public unsafe static bool Encrypt(string InPlain, ref string OutCipher)
		{
			FString fstring = FString.AllocTemp(InPlain);
			FString fstring2 = FString.AllocTemp(OutCipher);
			bool result = UKuroLauncherLibrary.__Encrypt_Internal(fstring, ref fstring2);
			FString.NativeDestruct(&fstring, 1);
			OutCipher = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x0600698D RID: 27021 RVA: 0x0009A3DC File Offset: 0x000985DC
		public unsafe static bool DoesDiskHaveEnoughSpace(string CheckPath, long CheckSize)
		{
			FString fstring = FString.AllocTemp(CheckPath);
			bool result = UKuroLauncherLibrary.__DoesDiskHaveEnoughSpace_Internal(fstring, CheckSize);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600698E RID: 27022 RVA: 0x0009A404 File Offset: 0x00098604
		public unsafe static bool DeleteFile(string FilePath)
		{
			FString fstring = FString.AllocTemp(FilePath);
			bool result = UKuroLauncherLibrary.__DeleteFile_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600698F RID: 27023 RVA: 0x0009A428 File Offset: 0x00098628
		public unsafe static bool DeleteDirectory(string DirPath)
		{
			FString fstring = FString.AllocTemp(DirPath);
			bool result = UKuroLauncherLibrary.__DeleteDirectory_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06006990 RID: 27024 RVA: 0x0009A44C File Offset: 0x0009864C
		public unsafe static bool Decrypt(string InCipher, ref string OutPlain)
		{
			FString fstring = FString.AllocTemp(InCipher);
			FString fstring2 = FString.AllocTemp(OutPlain);
			bool result = UKuroLauncherLibrary.__Decrypt_Internal(fstring, ref fstring2);
			FString.NativeDestruct(&fstring, 1);
			OutPlain = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06006991 RID: 27025
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CreateRestartFile();

		// Token: 0x06006992 RID: 27026 RVA: 0x0009A48C File Offset: 0x0009868C
		public unsafe static bool CopyFile(string DstPath, string SrcPath)
		{
			FString fstring = FString.AllocTemp(DstPath);
			FString fstring2 = FString.AllocTemp(SrcPath);
			bool result = UKuroLauncherLibrary.__CopyFile_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06006993 RID: 27027
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CloseShaderLibrary();

		// Token: 0x06006994 RID: 27028
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearPatchPaks();

		// Token: 0x06006995 RID: 27029 RVA: 0x0009A4C4 File Offset: 0x000986C4
		public unsafe static bool CheckFileSha1(string FilePath, string CheckSha1Hash)
		{
			FString fstring = FString.AllocTemp(FilePath);
			FString fstring2 = FString.AllocTemp(CheckSha1Hash);
			bool result = UKuroLauncherLibrary.__CheckFileSha1_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06006996 RID: 27030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RestartApplication_Internal(in FString ScriptContent);

		// Token: 0x06006997 RID: 27031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MoveFile_Internal(in FString DstPath, in FString SrcPath);

		// Token: 0x06006998 RID: 27032
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MakeDirectory_Internal(in FString DirPath);

		// Token: 0x06006999 RID: 27033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long __GetTotalAndFreeSpace_Internal(in FString CheckPath, ref long FreeSize);

		// Token: 0x0600699A RID: 27034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetMountedPaks_Internal(IntPtr OutPakFilenames);

		// Token: 0x0600699B RID: 27035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetGConfigString_Internal(in FString Section, in FString Key, ref FString OutStr);

		// Token: 0x0600699C RID: 27036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long __GetFileSize_Internal(in FString FilePath);

		// Token: 0x0600699D RID: 27037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetConfig_Internal(in FString Key, in FString DefaultValue, ref FString OutStr);

		// Token: 0x0600699E RID: 27038
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAppVersion_Internal();

		// Token: 0x0600699F RID: 27039
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAppReleaseType_Internal();

		// Token: 0x060069A0 RID: 27040
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAppParallel_Internal();

		// Token: 0x060069A1 RID: 27041
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAppInternalUseType_Internal();

		// Token: 0x060069A2 RID: 27042
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAppChangeList_Internal();

		// Token: 0x060069A3 RID: 27043
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GameSavedDir_Internal();

		// Token: 0x060069A4 RID: 27044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Encrypt_Internal(in FString InPlain, ref FString OutCipher);

		// Token: 0x060069A5 RID: 27045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DoesDiskHaveEnoughSpace_Internal(in FString CheckPath, long CheckSize);

		// Token: 0x060069A6 RID: 27046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DeleteFile_Internal(in FString FilePath);

		// Token: 0x060069A7 RID: 27047
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DeleteDirectory_Internal(in FString DirPath);

		// Token: 0x060069A8 RID: 27048
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Decrypt_Internal(in FString InCipher, ref FString OutPlain);

		// Token: 0x060069A9 RID: 27049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CopyFile_Internal(in FString DstPath, in FString SrcPath);

		// Token: 0x060069AA RID: 27050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckFileSha1_Internal(in FString FilePath, in FString CheckSha1Hash);

		// Token: 0x060069AB RID: 27051 RVA: 0x0009A4FA File Offset: 0x000986FA
		static UKuroLauncherLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroHotPatch.KuroLauncherLibrary");
		}

		// Token: 0x060069AC RID: 27052 RVA: 0x0009A508 File Offset: 0x00098708
		protected UKuroLauncherLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002CEB RID: 11499
		public new const string __ObjectPath = "/Script/KuroHotPatch.KuroLauncherLibrary";

		// Token: 0x04002CEC RID: 11500
		private static IntPtr _ClassPtr;

		// Token: 0x04002CED RID: 11501
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002CEE RID: 11502
		internal static int __PropertyOffset_PreloadBp;

		// Token: 0x04002CEF RID: 11503
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UObject> _PreloadBp;
	}
}
