using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001903 RID: 6403
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroResourceSystemFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroResourceSystemFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017C3D RID: 97341 RVA: 0x0022D042 File Offset: 0x0022B242
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroResourceSystemFunctionLibrary._ClassPtr;
		}

		// Token: 0x06017C3E RID: 97342 RVA: 0x0022D050 File Offset: 0x0022B250
		public UKuroResourceSystemFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroResourceSystemFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017C3F RID: 97343 RVA: 0x0022D078 File Offset: 0x0022B278
		public UKuroResourceSystemFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroResourceSystemFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017C40 RID: 97344 RVA: 0x0022D0AC File Offset: 0x0022B2AC
		public unsafe static bool TryGetAssetBlockInfo(string AssetPath, ref string OutReason)
		{
			FString fstring = FString.AllocTemp(AssetPath);
			FString fstring2 = FString.AllocTemp(OutReason);
			bool result = UKuroResourceSystemFunctionLibrary.__TryGetAssetBlockInfo_Internal(fstring, ref fstring2);
			FString.NativeDestruct(&fstring, 1);
			OutReason = FString.ToString(fstring2);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06017C41 RID: 97345
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetCallbackTimeLimit(float TimeLimit);

		// Token: 0x06017C42 RID: 97346 RVA: 0x0022D0EC File Offset: 0x0022B2EC
		public static void RefreshBlockedAssetPath([Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<string> OpenActivityTypes)
		{
			UKuroResourceSystemFunctionLibrary.__RefreshBlockedAssetPath_Internal((OpenActivityTypes ?? new TSet<string>()).NativeSetPtr);
		}

		// Token: 0x06017C43 RID: 97347 RVA: 0x0022D104 File Offset: 0x0022B304
		public unsafe static bool IsAssetBlocked(string AssetPath)
		{
			FString fstring = FString.AllocTemp(AssetPath);
			bool result = UKuroResourceSystemFunctionLibrary.__IsAssetBlocked_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06017C44 RID: 97348 RVA: 0x0022D128 File Offset: 0x0022B328
		[NullableContext(2)]
		public static void Initialize(UWorld World, float TimeLimit)
		{
			UKuroResourceSystemFunctionLibrary.__Initialize_Internal((World != null) ? World.NativePtr : IntPtr.Zero, TimeLimit);
		}

		// Token: 0x06017C45 RID: 97349
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Clear();

		// Token: 0x06017C46 RID: 97350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TryGetAssetBlockInfo_Internal(in FString AssetPath, ref FString OutReason);

		// Token: 0x06017C47 RID: 97351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshBlockedAssetPath_Internal(IntPtr OpenActivityTypes);

		// Token: 0x06017C48 RID: 97352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAssetBlocked_Internal(in FString AssetPath);

		// Token: 0x06017C49 RID: 97353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Initialize_Internal(IntPtr World, float TimeLimit);

		// Token: 0x06017C4A RID: 97354 RVA: 0x0022D140 File Offset: 0x0022B340
		static UKuroResourceSystemFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroResourceSystemFunctionLibrary");
		}

		// Token: 0x06017C4B RID: 97355 RVA: 0x0022D14E File Offset: 0x0022B34E
		protected UKuroResourceSystemFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CE3F RID: 52799
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroResourceSystemFunctionLibrary";

		// Token: 0x0400CE40 RID: 52800
		private static IntPtr _ClassPtr;

		// Token: 0x0400CE41 RID: 52801
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
