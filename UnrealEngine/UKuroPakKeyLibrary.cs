using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A12 RID: 6674
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPakKey.KuroPakKeyLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPakKeyLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018B78 RID: 101240 RVA: 0x00247A18 File Offset: 0x00245C18
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPakKeyLibrary._ClassPtr;
		}

		// Token: 0x06018B79 RID: 101241 RVA: 0x00247A24 File Offset: 0x00245C24
		public UKuroPakKeyLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroPakKeyLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018B7A RID: 101242 RVA: 0x00247A4C File Offset: 0x00245C4C
		public UKuroPakKeyLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPakKeyLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018B7B RID: 101243
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnbindPakMountedCallback();

		// Token: 0x06018B7C RID: 101244
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnbindLoadCallback();

		// Token: 0x06018B7D RID: 101245 RVA: 0x00247A80 File Offset: 0x00245C80
		public unsafe static void SetRSAPublicKey(string PublicKey)
		{
			FString fstring = FString.AllocTemp(PublicKey);
			UKuroPakKeyLibrary.__SetRSAPublicKey_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06018B7E RID: 101246 RVA: 0x00247AA4 File Offset: 0x00245CA4
		[NullableContext(2)]
		public static void SetLoadCallback(FKuroKeysLoadComplete Callback)
		{
			UKuroPakKeyLibrary.__SetLoadCallback_Internal((Callback != null) ? Callback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06018B7F RID: 101247
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NeedExtPakKeys();

		// Token: 0x06018B80 RID: 101248 RVA: 0x00247AB8 File Offset: 0x00245CB8
		public unsafe static void LoadPakKeysFromFile(string FilePath)
		{
			FString fstring = FString.AllocTemp(FilePath);
			UKuroPakKeyLibrary.__LoadPakKeysFromFile_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06018B81 RID: 101249 RVA: 0x00247ADC File Offset: 0x00245CDC
		public unsafe static void LoadKeys(string RSAPubKey, string FilePath, string Tag)
		{
			FString fstring = FString.AllocTemp(RSAPubKey);
			FString fstring2 = FString.AllocTemp(FilePath);
			FString fstring3 = FString.AllocTemp(Tag);
			UKuroPakKeyLibrary.__LoadKeys_Internal(fstring, fstring2, fstring3);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
		}

		// Token: 0x06018B82 RID: 101250
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasPendingEncryptedPaks();

		// Token: 0x06018B83 RID: 101251
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetUpdateInterval();

		// Token: 0x06018B84 RID: 101252 RVA: 0x00247B24 File Offset: 0x00245D24
		[NullableContext(2)]
		public static void BindPakMountedCallback(FKuroPakMountedCallback Callback)
		{
			UKuroPakKeyLibrary.__BindPakMountedCallback_Internal((Callback != null) ? Callback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06018B85 RID: 101253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRSAPublicKey_Internal(in FString PublicKey);

		// Token: 0x06018B86 RID: 101254
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLoadCallback_Internal(IntPtr Callback);

		// Token: 0x06018B87 RID: 101255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadPakKeysFromFile_Internal(in FString FilePath);

		// Token: 0x06018B88 RID: 101256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadKeys_Internal(in FString RSAPubKey, in FString FilePath, in FString Tag);

		// Token: 0x06018B89 RID: 101257
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindPakMountedCallback_Internal(IntPtr Callback);

		// Token: 0x06018B8A RID: 101258 RVA: 0x00247B38 File Offset: 0x00245D38
		static UKuroPakKeyLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPakKey.KuroPakKeyLibrary");
		}

		// Token: 0x06018B8B RID: 101259 RVA: 0x00247B46 File Offset: 0x00245D46
		protected UKuroPakKeyLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D58D RID: 54669
		public new const string __ObjectPath = "/Script/KuroPakKey.KuroPakKeyLibrary";

		// Token: 0x0400D58E RID: 54670
		private static IntPtr _ClassPtr;

		// Token: 0x0400D58F RID: 54671
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
