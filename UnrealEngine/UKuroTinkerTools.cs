using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005AB RID: 1451
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSoHotPatch.KuroTinkerTools")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroTinkerTools : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008293 RID: 33427 RVA: 0x000C120A File Offset: 0x000BF40A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTinkerTools._ClassPtr;
		}

		// Token: 0x06008294 RID: 33428 RVA: 0x000C1218 File Offset: 0x000BF418
		public UKuroTinkerTools() : this(BuiltinUtils.AllocNativeUObject(UKuroTinkerTools.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008295 RID: 33429 RVA: 0x000C1240 File Offset: 0x000BF440
		public UKuroTinkerTools(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTinkerTools.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008296 RID: 33430 RVA: 0x000C1274 File Offset: 0x000BF474
		public unsafe static void SetCurLoadingVersion(string Version)
		{
			FString fstring = FString.AllocTemp(Version);
			UKuroTinkerTools.__SetCurLoadingVersion_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06008297 RID: 33431 RVA: 0x000C1298 File Offset: 0x000BF498
		public unsafe static void LoadPatch(string PatchPath)
		{
			FString fstring = FString.AllocTemp(PatchPath);
			UKuroTinkerTools.__LoadPatch_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06008298 RID: 33432
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsTinkerPackaged();

		// Token: 0x06008299 RID: 33433 RVA: 0x000C12BC File Offset: 0x000BF4BC
		public static string GetCurUsingVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroTinkerTools.__GetCurUsingVersion_Internal());
		}

		// Token: 0x0600829A RID: 33434 RVA: 0x000C12C8 File Offset: 0x000BF4C8
		public static string GetCurLoadingVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroTinkerTools.__GetCurLoadingVersion_Internal());
		}

		// Token: 0x0600829B RID: 33435 RVA: 0x000C12D4 File Offset: 0x000BF4D4
		public static string GetCurApplyingVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroTinkerTools.__GetCurApplyingVersion_Internal());
		}

		// Token: 0x0600829C RID: 33436
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CleanPatch();

		// Token: 0x0600829D RID: 33437 RVA: 0x000C12E0 File Offset: 0x000BF4E0
		public unsafe static void CheckLib(int ObjId, string Hash)
		{
			FString fstring = FString.AllocTemp(Hash);
			UKuroTinkerTools.__CheckLib_Internal(ObjId, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600829E RID: 33438
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCurLoadingVersion_Internal(in FString Version);

		// Token: 0x0600829F RID: 33439
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadPatch_Internal(in FString PatchPath);

		// Token: 0x060082A0 RID: 33440
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurUsingVersion_Internal();

		// Token: 0x060082A1 RID: 33441
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurLoadingVersion_Internal();

		// Token: 0x060082A2 RID: 33442
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurApplyingVersion_Internal();

		// Token: 0x060082A3 RID: 33443
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CheckLib_Internal(int ObjId, in FString Hash);

		// Token: 0x060082A4 RID: 33444 RVA: 0x000C1305 File Offset: 0x000BF505
		static UKuroTinkerTools()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSoHotPatch.KuroTinkerTools");
		}

		// Token: 0x060082A5 RID: 33445 RVA: 0x000C1313 File Offset: 0x000BF513
		protected UKuroTinkerTools(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040038DE RID: 14558
		public new const string __ObjectPath = "/Script/KuroSoHotPatch.KuroTinkerTools";

		// Token: 0x040038DF RID: 14559
		private static IntPtr _ClassPtr;

		// Token: 0x040038E0 RID: 14560
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
