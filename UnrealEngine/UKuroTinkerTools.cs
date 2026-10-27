using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E78 RID: 7800
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSoHotPatch.KuroTinkerTools")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroTinkerTools : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DB29 RID: 121641 RVA: 0x002BDF2E File Offset: 0x002BC12E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTinkerTools._ClassPtr;
		}

		// Token: 0x0601DB2A RID: 121642 RVA: 0x002BDF3C File Offset: 0x002BC13C
		public UKuroTinkerTools() : this(BuiltinUtils.AllocNativeUObject(UKuroTinkerTools.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DB2B RID: 121643 RVA: 0x002BDF64 File Offset: 0x002BC164
		public UKuroTinkerTools(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTinkerTools.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DB2C RID: 121644 RVA: 0x002BDF98 File Offset: 0x002BC198
		public unsafe static void SetCurLoadingVersion(string Version)
		{
			FString fstring = FString.AllocTemp(Version);
			UKuroTinkerTools.__SetCurLoadingVersion_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DB2D RID: 121645 RVA: 0x002BDFBC File Offset: 0x002BC1BC
		public unsafe static void LoadPatch(string PatchPath)
		{
			FString fstring = FString.AllocTemp(PatchPath);
			UKuroTinkerTools.__LoadPatch_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DB2E RID: 121646
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsTinkerPackaged();

		// Token: 0x0601DB2F RID: 121647 RVA: 0x002BDFE0 File Offset: 0x002BC1E0
		public static string GetCurUsingVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroTinkerTools.__GetCurUsingVersion_Internal());
		}

		// Token: 0x0601DB30 RID: 121648 RVA: 0x002BDFEC File Offset: 0x002BC1EC
		public static string GetCurLoadingVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroTinkerTools.__GetCurLoadingVersion_Internal());
		}

		// Token: 0x0601DB31 RID: 121649 RVA: 0x002BDFF8 File Offset: 0x002BC1F8
		public static string GetCurApplyingVersion()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroTinkerTools.__GetCurApplyingVersion_Internal());
		}

		// Token: 0x0601DB32 RID: 121650
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CleanPatch();

		// Token: 0x0601DB33 RID: 121651 RVA: 0x002BE004 File Offset: 0x002BC204
		public unsafe static void CheckLib(int ObjId, string Hash)
		{
			FString fstring = FString.AllocTemp(Hash);
			UKuroTinkerTools.__CheckLib_Internal(ObjId, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DB34 RID: 121652
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCurLoadingVersion_Internal(in FString Version);

		// Token: 0x0601DB35 RID: 121653
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadPatch_Internal(in FString PatchPath);

		// Token: 0x0601DB36 RID: 121654
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurUsingVersion_Internal();

		// Token: 0x0601DB37 RID: 121655
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurLoadingVersion_Internal();

		// Token: 0x0601DB38 RID: 121656
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetCurApplyingVersion_Internal();

		// Token: 0x0601DB39 RID: 121657
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CheckLib_Internal(int ObjId, in FString Hash);

		// Token: 0x0601DB3A RID: 121658 RVA: 0x002BE029 File Offset: 0x002BC229
		static UKuroTinkerTools()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSoHotPatch.KuroTinkerTools");
		}

		// Token: 0x0601DB3B RID: 121659 RVA: 0x002BE037 File Offset: 0x002BC237
		protected UKuroTinkerTools(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010149 RID: 65865
		public new const string __ObjectPath = "/Script/KuroSoHotPatch.KuroTinkerTools";

		// Token: 0x0401014A RID: 65866
		private static IntPtr _ClassPtr;

		// Token: 0x0401014B RID: 65867
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
