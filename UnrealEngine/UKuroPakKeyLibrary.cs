using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000493 RID: 1171
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPakKey.KuroPakKeyLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroPakKeyLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006DB5 RID: 28085 RVA: 0x000A0B54 File Offset: 0x0009ED54
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPakKeyLibrary._ClassPtr;
		}

		// Token: 0x06006DB6 RID: 28086 RVA: 0x000A0B60 File Offset: 0x0009ED60
		public UKuroPakKeyLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroPakKeyLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006DB7 RID: 28087 RVA: 0x000A0B88 File Offset: 0x0009ED88
		public UKuroPakKeyLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPakKeyLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006DB8 RID: 28088
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnbindPakMountedCallback();

		// Token: 0x06006DB9 RID: 28089
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnbindLoadCallback();

		// Token: 0x06006DBA RID: 28090 RVA: 0x000A0BBC File Offset: 0x0009EDBC
		public unsafe static void SetRSAPublicKey(string PublicKey)
		{
			FString fstring = FString.AllocTemp(PublicKey);
			UKuroPakKeyLibrary.__SetRSAPublicKey_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06006DBB RID: 28091 RVA: 0x000A0BE0 File Offset: 0x0009EDE0
		[NullableContext(2)]
		public static void SetLoadCallback(FKuroKeysLoadComplete Callback)
		{
			UKuroPakKeyLibrary.__SetLoadCallback_Internal((Callback != null) ? Callback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06006DBC RID: 28092
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NeedExtPakKeys();

		// Token: 0x06006DBD RID: 28093 RVA: 0x000A0BF4 File Offset: 0x0009EDF4
		public unsafe static void LoadPakKeysFromFile(string FilePath)
		{
			FString fstring = FString.AllocTemp(FilePath);
			UKuroPakKeyLibrary.__LoadPakKeysFromFile_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06006DBE RID: 28094 RVA: 0x000A0C18 File Offset: 0x0009EE18
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

		// Token: 0x06006DBF RID: 28095
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool HasPendingEncryptedPaks();

		// Token: 0x06006DC0 RID: 28096
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetUpdateInterval();

		// Token: 0x06006DC1 RID: 28097 RVA: 0x000A0C60 File Offset: 0x0009EE60
		[NullableContext(2)]
		public static void BindPakMountedCallback(FKuroPakMountedCallback Callback)
		{
			UKuroPakKeyLibrary.__BindPakMountedCallback_Internal((Callback != null) ? Callback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06006DC2 RID: 28098
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRSAPublicKey_Internal(in FString PublicKey);

		// Token: 0x06006DC3 RID: 28099
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLoadCallback_Internal(IntPtr Callback);

		// Token: 0x06006DC4 RID: 28100
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadPakKeysFromFile_Internal(in FString FilePath);

		// Token: 0x06006DC5 RID: 28101
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LoadKeys_Internal(in FString RSAPubKey, in FString FilePath, in FString Tag);

		// Token: 0x06006DC6 RID: 28102
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindPakMountedCallback_Internal(IntPtr Callback);

		// Token: 0x06006DC7 RID: 28103 RVA: 0x000A0C74 File Offset: 0x0009EE74
		static UKuroPakKeyLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPakKey.KuroPakKeyLibrary");
		}

		// Token: 0x06006DC8 RID: 28104 RVA: 0x000A0C82 File Offset: 0x0009EE82
		protected UKuroPakKeyLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002ECA RID: 11978
		public new const string __ObjectPath = "/Script/KuroPakKey.KuroPakKeyLibrary";

		// Token: 0x04002ECB RID: 11979
		private static IntPtr _ClassPtr;

		// Token: 0x04002ECC RID: 11980
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
