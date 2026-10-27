using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200198C RID: 6540
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroHotPatch.KuroPakMountStatic")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPakMountStatic : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060184C7 RID: 99527 RVA: 0x0023D685 File Offset: 0x0023B885
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPakMountStatic._ClassPtr;
		}

		// Token: 0x060184C8 RID: 99528 RVA: 0x0023D694 File Offset: 0x0023B894
		public UKuroPakMountStatic() : this(BuiltinUtils.AllocNativeUObject(UKuroPakMountStatic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060184C9 RID: 99529 RVA: 0x0023D6BC File Offset: 0x0023B8BC
		public UKuroPakMountStatic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPakMountStatic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060184CA RID: 99530 RVA: 0x0023D6F0 File Offset: 0x0023B8F0
		public unsafe static void UnmountPak(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			UKuroPakMountStatic.__UnmountPak_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060184CB RID: 99531 RVA: 0x0023D714 File Offset: 0x0023B914
		public unsafe static void UnmountFromManifest(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			UKuroPakMountStatic.__UnmountFromManifest_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060184CC RID: 99532
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnmountAllPaks();

		// Token: 0x060184CD RID: 99533
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopSha1Check();

		// Token: 0x060184CE RID: 99534
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StartSha1Check();

		// Token: 0x060184CF RID: 99535 RVA: 0x0023D738 File Offset: 0x0023B938
		public unsafe static void Save(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			UKuroPakMountStatic.__Save_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060184D0 RID: 99536
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetSha1CheckResult();

		// Token: 0x060184D1 RID: 99537 RVA: 0x0023D75C File Offset: 0x0023B95C
		public unsafe static void RemoveSha1Check(string FilePath)
		{
			FString fstring = FString.AllocTemp(FilePath);
			UKuroPakMountStatic.__RemoveSha1Check_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060184D2 RID: 99538
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MountStartupPaks();

		// Token: 0x060184D3 RID: 99539 RVA: 0x0023D780 File Offset: 0x0023B980
		public unsafe static void MountPak(string Path, int Order = -1)
		{
			FString fstring = FString.AllocTemp(Path);
			UKuroPakMountStatic.__MountPak_Internal(fstring, Order);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060184D4 RID: 99540
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MountMultiLangPaks();

		// Token: 0x060184D5 RID: 99541
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MountGamePaks();

		// Token: 0x060184D6 RID: 99542 RVA: 0x0023D7A8 File Offset: 0x0023B9A8
		public unsafe static void MountFromManifest(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			UKuroPakMountStatic.__MountFromManifest_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060184D7 RID: 99543 RVA: 0x0023D7CC File Offset: 0x0023B9CC
		public unsafe static bool MakePakPatch(string OldPakPath, string DiffPath, string NewPatchPath)
		{
			FString fstring = FString.AllocTemp(OldPakPath);
			FString fstring2 = FString.AllocTemp(DiffPath);
			FString fstring3 = FString.AllocTemp(NewPatchPath);
			bool result = UKuroPakMountStatic.__MakePakPatch_Internal(fstring, fstring2, fstring3);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x060184D8 RID: 99544 RVA: 0x0023D814 File Offset: 0x0023BA14
		public unsafe static bool MakePakDirPatch(string OldPakPath, string DiffPath, string NewPatchPath)
		{
			FString fstring = FString.AllocTemp(OldPakPath);
			FString fstring2 = FString.AllocTemp(DiffPath);
			FString fstring3 = FString.AllocTemp(NewPatchPath);
			bool result = UKuroPakMountStatic.__MakePakDirPatch_Internal(fstring, fstring2, fstring3);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
			return result;
		}

		// Token: 0x060184D9 RID: 99545
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsSha1CheckWorking();

		// Token: 0x060184DA RID: 99546
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetSha1CheckFailedCount();

		// Token: 0x060184DB RID: 99547
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DeleteSha1CheckFailedFiles();

		// Token: 0x060184DC RID: 99548 RVA: 0x0023D85C File Offset: 0x0023BA5C
		public unsafe static void AddSha1Check(string FilePath, string CheckSha1Hash)
		{
			FString fstring = FString.AllocTemp(FilePath);
			FString fstring2 = FString.AllocTemp(CheckSha1Hash);
			UKuroPakMountStatic.__AddSha1Check_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x060184DD RID: 99549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnmountPak_Internal(in FString Path);

		// Token: 0x060184DE RID: 99550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnmountFromManifest_Internal(in FString Path);

		// Token: 0x060184DF RID: 99551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Save_Internal(in FString Path);

		// Token: 0x060184E0 RID: 99552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveSha1Check_Internal(in FString FilePath);

		// Token: 0x060184E1 RID: 99553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MountPak_Internal(in FString Path, int Order);

		// Token: 0x060184E2 RID: 99554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MountFromManifest_Internal(in FString Path);

		// Token: 0x060184E3 RID: 99555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MakePakPatch_Internal(in FString OldPakPath, in FString DiffPath, in FString NewPatchPath);

		// Token: 0x060184E4 RID: 99556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MakePakDirPatch_Internal(in FString OldPakPath, in FString DiffPath, in FString NewPatchPath);

		// Token: 0x060184E5 RID: 99557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSha1Check_Internal(in FString FilePath, in FString CheckSha1Hash);

		// Token: 0x060184E6 RID: 99558 RVA: 0x0023D892 File Offset: 0x0023BA92
		static UKuroPakMountStatic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroHotPatch.KuroPakMountStatic");
		}

		// Token: 0x060184E7 RID: 99559 RVA: 0x0023D8A0 File Offset: 0x0023BAA0
		protected UKuroPakMountStatic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D25F RID: 53855
		public new const string __ObjectPath = "/Script/KuroHotPatch.KuroPakMountStatic";

		// Token: 0x0400D260 RID: 53856
		private static IntPtr _ClassPtr;

		// Token: 0x0400D261 RID: 53857
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
