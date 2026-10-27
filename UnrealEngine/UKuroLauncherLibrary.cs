using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200198B RID: 6539
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroHotPatch.KuroLauncherLibrary")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UKuroLauncherLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018480 RID: 99456 RVA: 0x0023D286 File Offset: 0x0023B486
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLauncherLibrary._ClassPtr;
		}

		// Token: 0x06018481 RID: 99457 RVA: 0x0023D294 File Offset: 0x0023B494
		public UKuroLauncherLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroLauncherLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018482 RID: 99458 RVA: 0x0023D2BC File Offset: 0x0023B4BC
		public UKuroLauncherLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLauncherLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700610F RID: 24847
		// (get) Token: 0x06018483 RID: 99459 RVA: 0x0023D2F0 File Offset: 0x0023B4F0
		// (set) Token: 0x06018484 RID: 99460 RVA: 0x0023D329 File Offset: 0x0023B529
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

		// Token: 0x06018485 RID: 99461
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void WillClearPatchPaks();

		// Token: 0x06018486 RID: 99462
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetRestartApp(byte RestartType);

		// Token: 0x06018487 RID: 99463
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetPrecompileShaderBatchMode(int Mode);

		// Token: 0x06018488 RID: 99464
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResumeCompileShader();

		// Token: 0x06018489 RID: 99465 RVA: 0x0023D338 File Offset: 0x0023B538
		public unsafe static void RestartApplication(string ScriptContent)
		{
			FString fstring = FString.AllocTemp(ScriptContent);
			UKuroLauncherLibrary.__RestartApplication_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601848A RID: 99466
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetLauncher();

		// Token: 0x0601848B RID: 99467
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ReloadShaderLibrary();

		// Token: 0x0601848C RID: 99468
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void PreloadRequiredBp();

		// Token: 0x0601848D RID: 99469
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte NeedRestartApp();

		// Token: 0x0601848E RID: 99470
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NeedHotPatch();

		// Token: 0x0601848F RID: 99471
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NeedClearPatchPaks();

		// Token: 0x06018490 RID: 99472 RVA: 0x0023D35C File Offset: 0x0023B55C
		public unsafe static bool MoveFile(string DstPath, string SrcPath)
		{
			FString fstring = FString.AllocTemp(DstPath);
			FString fstring2 = FString.AllocTemp(SrcPath);
			bool result = UKuroLauncherLibrary.__MoveFile_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06018491 RID: 99473 RVA: 0x0023D394 File Offset: 0x0023B594
		public unsafe static bool MakeDirectory(string DirPath)
		{
			FString fstring = FString.AllocTemp(DirPath);
			bool result = UKuroLauncherLibrary.__MakeDirectory_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06018492 RID: 99474
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LogoutToLauncher();

		// Token: 0x06018493 RID: 99475
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsStartupMountSuccess();

		// Token: 0x06018494 RID: 99476
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsSeparateVideo();

		// Token: 0x06018495 RID: 99477
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsLocalPackaging();

		// Token: 0x06018496 RID: 99478
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsFirstIntoLauncher();

		// Token: 0x06018497 RID: 99479
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsEnableOptionalPackage();

		// Token: 0x06018498 RID: 99480
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetTotalPrecompileShaders();

		// Token: 0x06018499 RID: 99481 RVA: 0x0023D3B8 File Offset: 0x0023B5B8
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

		// Token: 0x0601849A RID: 99482
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetRemainPrecompileShaders();

		// Token: 0x0601849B RID: 99483
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte GetNetworkConnectionType();

		// Token: 0x0601849C RID: 99484 RVA: 0x0023D3E2 File Offset: 0x0023B5E2
		public static void GetMountedPaks([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<string> OutPakFilenames)
		{
			UKuroLauncherLibrary.__GetMountedPaks_Internal((OutPakFilenames ?? new TArray<string>()).NativePtr);
		}

		// Token: 0x0601849D RID: 99485 RVA: 0x0023D3FC File Offset: 0x0023B5FC
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

		// Token: 0x0601849E RID: 99486 RVA: 0x0023D450 File Offset: 0x0023B650
		public unsafe static long GetFileSize(string FilePath)
		{
			FString fstring = FString.AllocTemp(FilePath);
			long result = UKuroLauncherLibrary.__GetFileSize_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601849F RID: 99487 RVA: 0x0023D474 File Offset: 0x0023B674
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

		// Token: 0x060184A0 RID: 99488 RVA: 0x0023D4C6 File Offset: 0x0023B6C6
		public static string GetAppVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroLauncherLibrary.__GetAppVersion_Internal());
		}

		// Token: 0x060184A1 RID: 99489 RVA: 0x0023D4D2 File Offset: 0x0023B6D2
		public static string GetAppReleaseType()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroLauncherLibrary.__GetAppReleaseType_Internal());
		}

		// Token: 0x060184A2 RID: 99490 RVA: 0x0023D4DE File Offset: 0x0023B6DE
		public static string GetAppParallel()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroLauncherLibrary.__GetAppParallel_Internal());
		}

		// Token: 0x060184A3 RID: 99491 RVA: 0x0023D4EA File Offset: 0x0023B6EA
		public static string GetAppInternalUseType()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroLauncherLibrary.__GetAppInternalUseType_Internal());
		}

		// Token: 0x060184A4 RID: 99492 RVA: 0x0023D4F6 File Offset: 0x0023B6F6
		public static string GetAppChangeList()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroLauncherLibrary.__GetAppChangeList_Internal());
		}

		// Token: 0x060184A5 RID: 99493 RVA: 0x0023D502 File Offset: 0x0023B702
		public static string GameSavedDir()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroLauncherLibrary.__GameSavedDir_Internal());
		}

		// Token: 0x060184A6 RID: 99494 RVA: 0x0023D510 File Offset: 0x0023B710
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

		// Token: 0x060184A7 RID: 99495 RVA: 0x0023D550 File Offset: 0x0023B750
		public unsafe static bool DoesDiskHaveEnoughSpace(string CheckPath, long CheckSize)
		{
			FString fstring = FString.AllocTemp(CheckPath);
			bool result = UKuroLauncherLibrary.__DoesDiskHaveEnoughSpace_Internal(fstring, CheckSize);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060184A8 RID: 99496 RVA: 0x0023D578 File Offset: 0x0023B778
		public unsafe static bool DeleteFile(string FilePath)
		{
			FString fstring = FString.AllocTemp(FilePath);
			bool result = UKuroLauncherLibrary.__DeleteFile_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060184A9 RID: 99497 RVA: 0x0023D59C File Offset: 0x0023B79C
		public unsafe static bool DeleteDirectory(string DirPath)
		{
			FString fstring = FString.AllocTemp(DirPath);
			bool result = UKuroLauncherLibrary.__DeleteDirectory_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060184AA RID: 99498 RVA: 0x0023D5C0 File Offset: 0x0023B7C0
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

		// Token: 0x060184AB RID: 99499
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CreateRestartFile();

		// Token: 0x060184AC RID: 99500 RVA: 0x0023D600 File Offset: 0x0023B800
		public unsafe static bool CopyFile(string DstPath, string SrcPath)
		{
			FString fstring = FString.AllocTemp(DstPath);
			FString fstring2 = FString.AllocTemp(SrcPath);
			bool result = UKuroLauncherLibrary.__CopyFile_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060184AD RID: 99501
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CloseShaderLibrary();

		// Token: 0x060184AE RID: 99502
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearPatchPaks();

		// Token: 0x060184AF RID: 99503 RVA: 0x0023D638 File Offset: 0x0023B838
		public unsafe static bool CheckFileSha1(string FilePath, string CheckSha1Hash)
		{
			FString fstring = FString.AllocTemp(FilePath);
			FString fstring2 = FString.AllocTemp(CheckSha1Hash);
			bool result = UKuroLauncherLibrary.__CheckFileSha1_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x060184B0 RID: 99504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RestartApplication_Internal(in FString ScriptContent);

		// Token: 0x060184B1 RID: 99505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MoveFile_Internal(in FString DstPath, in FString SrcPath);

		// Token: 0x060184B2 RID: 99506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MakeDirectory_Internal(in FString DirPath);

		// Token: 0x060184B3 RID: 99507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long __GetTotalAndFreeSpace_Internal(in FString CheckPath, ref long FreeSize);

		// Token: 0x060184B4 RID: 99508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetMountedPaks_Internal(IntPtr OutPakFilenames);

		// Token: 0x060184B5 RID: 99509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetGConfigString_Internal(in FString Section, in FString Key, ref FString OutStr);

		// Token: 0x060184B6 RID: 99510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long __GetFileSize_Internal(in FString FilePath);

		// Token: 0x060184B7 RID: 99511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetConfig_Internal(in FString Key, in FString DefaultValue, ref FString OutStr);

		// Token: 0x060184B8 RID: 99512
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAppVersion_Internal();

		// Token: 0x060184B9 RID: 99513
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAppReleaseType_Internal();

		// Token: 0x060184BA RID: 99514
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAppParallel_Internal();

		// Token: 0x060184BB RID: 99515
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAppInternalUseType_Internal();

		// Token: 0x060184BC RID: 99516
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAppChangeList_Internal();

		// Token: 0x060184BD RID: 99517
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GameSavedDir_Internal();

		// Token: 0x060184BE RID: 99518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Encrypt_Internal(in FString InPlain, ref FString OutCipher);

		// Token: 0x060184BF RID: 99519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DoesDiskHaveEnoughSpace_Internal(in FString CheckPath, long CheckSize);

		// Token: 0x060184C0 RID: 99520
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DeleteFile_Internal(in FString FilePath);

		// Token: 0x060184C1 RID: 99521
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DeleteDirectory_Internal(in FString DirPath);

		// Token: 0x060184C2 RID: 99522
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Decrypt_Internal(in FString InCipher, ref FString OutPlain);

		// Token: 0x060184C3 RID: 99523
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CopyFile_Internal(in FString DstPath, in FString SrcPath);

		// Token: 0x060184C4 RID: 99524
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckFileSha1_Internal(in FString FilePath, in FString CheckSha1Hash);

		// Token: 0x060184C5 RID: 99525 RVA: 0x0023D66E File Offset: 0x0023B86E
		static UKuroLauncherLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroHotPatch.KuroLauncherLibrary");
		}

		// Token: 0x060184C6 RID: 99526 RVA: 0x0023D67C File Offset: 0x0023B87C
		protected UKuroLauncherLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D25A RID: 53850
		public new const string __ObjectPath = "/Script/KuroHotPatch.KuroLauncherLibrary";

		// Token: 0x0400D25B RID: 53851
		private static IntPtr _ClassPtr;

		// Token: 0x0400D25C RID: 53852
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D25D RID: 53853
		internal static int __PropertyOffset_PreloadBp;

		// Token: 0x0400D25E RID: 53854
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UObject> _PreloadBp;
	}
}
