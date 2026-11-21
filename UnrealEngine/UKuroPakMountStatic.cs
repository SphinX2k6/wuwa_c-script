using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000447 RID: 1095
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroHotPatch.KuroPakMountStatic")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPakMountStatic : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060069AD RID: 27053 RVA: 0x0009A511 File Offset: 0x00098711
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPakMountStatic._ClassPtr;
		}

		// Token: 0x060069AE RID: 27054 RVA: 0x0009A520 File Offset: 0x00098720
		public UKuroPakMountStatic() : this(BuiltinUtils.AllocNativeUObject(UKuroPakMountStatic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060069AF RID: 27055 RVA: 0x0009A548 File Offset: 0x00098748
		public UKuroPakMountStatic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPakMountStatic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060069B0 RID: 27056 RVA: 0x0009A57C File Offset: 0x0009877C
		public unsafe static void UnmountPak(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			UKuroPakMountStatic.__UnmountPak_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060069B1 RID: 27057 RVA: 0x0009A5A0 File Offset: 0x000987A0
		public unsafe static void UnmountFromManifest(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			UKuroPakMountStatic.__UnmountFromManifest_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060069B2 RID: 27058
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnmountAllPaks();

		// Token: 0x060069B3 RID: 27059
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopSha1Check();

		// Token: 0x060069B4 RID: 27060
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StartSha1Check();

		// Token: 0x060069B5 RID: 27061 RVA: 0x0009A5C4 File Offset: 0x000987C4
		public unsafe static void Save(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			UKuroPakMountStatic.__Save_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060069B6 RID: 27062
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetSha1CheckResult();

		// Token: 0x060069B7 RID: 27063 RVA: 0x0009A5E8 File Offset: 0x000987E8
		public unsafe static void RemoveSha1Check(string FilePath)
		{
			FString fstring = FString.AllocTemp(FilePath);
			UKuroPakMountStatic.__RemoveSha1Check_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060069B8 RID: 27064
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MountStartupPaks();

		// Token: 0x060069B9 RID: 27065 RVA: 0x0009A60C File Offset: 0x0009880C
		public unsafe static void MountPak(string Path, int Order = -1)
		{
			FString fstring = FString.AllocTemp(Path);
			UKuroPakMountStatic.__MountPak_Internal(fstring, Order);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060069BA RID: 27066
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MountMultiLangPaks();

		// Token: 0x060069BB RID: 27067
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void MountGamePaks();

		// Token: 0x060069BC RID: 27068 RVA: 0x0009A634 File Offset: 0x00098834
		public unsafe static void MountFromManifest(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			UKuroPakMountStatic.__MountFromManifest_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060069BD RID: 27069 RVA: 0x0009A658 File Offset: 0x00098858
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

		// Token: 0x060069BE RID: 27070 RVA: 0x0009A6A0 File Offset: 0x000988A0
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

		// Token: 0x060069BF RID: 27071
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsSha1CheckWorking();

		// Token: 0x060069C0 RID: 27072
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetSha1CheckFailedCount();

		// Token: 0x060069C1 RID: 27073
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DeleteSha1CheckFailedFiles();

		// Token: 0x060069C2 RID: 27074 RVA: 0x0009A6E8 File Offset: 0x000988E8
		public unsafe static void AddSha1Check(string FilePath, string CheckSha1Hash)
		{
			FString fstring = FString.AllocTemp(FilePath);
			FString fstring2 = FString.AllocTemp(CheckSha1Hash);
			UKuroPakMountStatic.__AddSha1Check_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x060069C3 RID: 27075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnmountPak_Internal(in FString Path);

		// Token: 0x060069C4 RID: 27076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnmountFromManifest_Internal(in FString Path);

		// Token: 0x060069C5 RID: 27077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Save_Internal(in FString Path);

		// Token: 0x060069C6 RID: 27078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveSha1Check_Internal(in FString FilePath);

		// Token: 0x060069C7 RID: 27079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MountPak_Internal(in FString Path, int Order);

		// Token: 0x060069C8 RID: 27080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MountFromManifest_Internal(in FString Path);

		// Token: 0x060069C9 RID: 27081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MakePakPatch_Internal(in FString OldPakPath, in FString DiffPath, in FString NewPatchPath);

		// Token: 0x060069CA RID: 27082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __MakePakDirPatch_Internal(in FString OldPakPath, in FString DiffPath, in FString NewPatchPath);

		// Token: 0x060069CB RID: 27083
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddSha1Check_Internal(in FString FilePath, in FString CheckSha1Hash);

		// Token: 0x060069CC RID: 27084 RVA: 0x0009A71E File Offset: 0x0009891E
		static UKuroPakMountStatic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroHotPatch.KuroPakMountStatic");
		}

		// Token: 0x060069CD RID: 27085 RVA: 0x0009A72C File Offset: 0x0009892C
		protected UKuroPakMountStatic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002CF0 RID: 11504
		public new const string __ObjectPath = "/Script/KuroHotPatch.KuroPakMountStatic";

		// Token: 0x04002CF1 RID: 11505
		private static IntPtr _ClassPtr;

		// Token: 0x04002CF2 RID: 11506
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
