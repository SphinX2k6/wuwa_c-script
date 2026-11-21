using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200038D RID: 909
	[UnrealObjectPath("/Script/KuroFuncOpenLibrary.FuncOpenBlueprintFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UFuncOpenBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005B00 RID: 23296 RVA: 0x000808CA File Offset: 0x0007EACA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFuncOpenBlueprintFunctionLibrary._ClassPtr;
		}

		// Token: 0x06005B01 RID: 23297 RVA: 0x000808D8 File Offset: 0x0007EAD8
		public UFuncOpenBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UFuncOpenBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005B02 RID: 23298 RVA: 0x00080900 File Offset: 0x0007EB00
		[NullableContext(1)]
		public UFuncOpenBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFuncOpenBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06005B03 RID: 23299
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void TryOpen(FArrayBuffer InArrayBuffer);

		// Token: 0x06005B04 RID: 23300 RVA: 0x00080934 File Offset: 0x0007EB34
		[NullableContext(1)]
		public unsafe static void SetIsCheckEncrypt(string Str)
		{
			FString fstring = FString.AllocTemp(Str);
			UFuncOpenBlueprintFunctionLibrary.__SetIsCheckEncrypt_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06005B05 RID: 23301
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetFirstTimestamp(long timestamp);

		// Token: 0x06005B06 RID: 23302
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FArrayBuffer GetEBuffer();

		// Token: 0x06005B07 RID: 23303
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FreeArrayBuffer(FArrayBuffer InArrayBuffer);

		// Token: 0x06005B08 RID: 23304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsCheckEncrypt_Internal(in FString Str);

		// Token: 0x06005B09 RID: 23305 RVA: 0x00080958 File Offset: 0x0007EB58
		static UFuncOpenBlueprintFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFuncOpenLibrary.FuncOpenBlueprintFunctionLibrary");
		}

		// Token: 0x06005B0A RID: 23306 RVA: 0x00080966 File Offset: 0x0007EB66
		protected UFuncOpenBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040025D1 RID: 9681
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFuncOpenLibrary.FuncOpenBlueprintFunctionLibrary";

		// Token: 0x040025D2 RID: 9682
		private static IntPtr _ClassPtr;

		// Token: 0x040025D3 RID: 9683
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
