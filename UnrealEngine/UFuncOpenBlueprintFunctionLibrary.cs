using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001851 RID: 6225
	[UnrealObjectPath("/Script/KuroFuncOpenLibrary.FuncOpenBlueprintFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UFuncOpenBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016EED RID: 93933 RVA: 0x002176B2 File Offset: 0x002158B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFuncOpenBlueprintFunctionLibrary._ClassPtr;
		}

		// Token: 0x06016EEE RID: 93934 RVA: 0x002176C0 File Offset: 0x002158C0
		public UFuncOpenBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UFuncOpenBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016EEF RID: 93935 RVA: 0x002176E8 File Offset: 0x002158E8
		[NullableContext(1)]
		public UFuncOpenBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFuncOpenBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016EF0 RID: 93936
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void TryOpen(FArrayBuffer InArrayBuffer);

		// Token: 0x06016EF1 RID: 93937 RVA: 0x0021771C File Offset: 0x0021591C
		[NullableContext(1)]
		public unsafe static void SetIsCheckEncrypt(string Str)
		{
			FString fstring = FString.AllocTemp(Str);
			UFuncOpenBlueprintFunctionLibrary.__SetIsCheckEncrypt_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06016EF2 RID: 93938
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetFirstTimestamp(long timestamp);

		// Token: 0x06016EF3 RID: 93939
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FArrayBuffer GetEBuffer();

		// Token: 0x06016EF4 RID: 93940
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FreeArrayBuffer(FArrayBuffer InArrayBuffer);

		// Token: 0x06016EF5 RID: 93941
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsCheckEncrypt_Internal(in FString Str);

		// Token: 0x06016EF6 RID: 93942 RVA: 0x00217740 File Offset: 0x00215940
		static UFuncOpenBlueprintFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFuncOpenLibrary.FuncOpenBlueprintFunctionLibrary");
		}

		// Token: 0x06016EF7 RID: 93943 RVA: 0x0021774E File Offset: 0x0021594E
		protected UFuncOpenBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C757 RID: 51031
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFuncOpenLibrary.FuncOpenBlueprintFunctionLibrary";

		// Token: 0x0400C758 RID: 51032
		private static IntPtr _ClassPtr;

		// Token: 0x0400C759 RID: 51033
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
