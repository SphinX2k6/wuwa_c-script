using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003FD RID: 1021
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroResourceSystemFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroResourceSystemFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006432 RID: 25650 RVA: 0x0008F176 File Offset: 0x0008D376
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroResourceSystemFunctionLibrary._ClassPtr;
		}

		// Token: 0x06006433 RID: 25651 RVA: 0x0008F184 File Offset: 0x0008D384
		public UKuroResourceSystemFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroResourceSystemFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006434 RID: 25652 RVA: 0x0008F1AC File Offset: 0x0008D3AC
		public UKuroResourceSystemFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroResourceSystemFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006435 RID: 25653 RVA: 0x0008F1E0 File Offset: 0x0008D3E0
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

		// Token: 0x06006436 RID: 25654
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetCallbackTimeLimit(float TimeLimit);

		// Token: 0x06006437 RID: 25655 RVA: 0x0008F220 File Offset: 0x0008D420
		public static void RefreshBlockedAssetPath([Nullable(new byte[]
		{
			2,
			1
		})] ref TSet<string> OpenActivityTypes)
		{
			UKuroResourceSystemFunctionLibrary.__RefreshBlockedAssetPath_Internal((OpenActivityTypes ?? new TSet<string>()).NativeSetPtr);
		}

		// Token: 0x06006438 RID: 25656 RVA: 0x0008F238 File Offset: 0x0008D438
		public unsafe static bool IsAssetBlocked(string AssetPath)
		{
			FString fstring = FString.AllocTemp(AssetPath);
			bool result = UKuroResourceSystemFunctionLibrary.__IsAssetBlocked_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06006439 RID: 25657 RVA: 0x0008F25C File Offset: 0x0008D45C
		[NullableContext(2)]
		public static void Initialize(UWorld World, float TimeLimit)
		{
			UKuroResourceSystemFunctionLibrary.__Initialize_Internal((World != null) ? World.NativePtr : IntPtr.Zero, TimeLimit);
		}

		// Token: 0x0600643A RID: 25658
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Clear();

		// Token: 0x0600643B RID: 25659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TryGetAssetBlockInfo_Internal(in FString AssetPath, ref FString OutReason);

		// Token: 0x0600643C RID: 25660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshBlockedAssetPath_Internal(IntPtr OpenActivityTypes);

		// Token: 0x0600643D RID: 25661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAssetBlocked_Internal(in FString AssetPath);

		// Token: 0x0600643E RID: 25662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Initialize_Internal(IntPtr World, float TimeLimit);

		// Token: 0x0600643F RID: 25663 RVA: 0x0008F274 File Offset: 0x0008D474
		static UKuroResourceSystemFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroResourceSystemFunctionLibrary");
		}

		// Token: 0x06006440 RID: 25664 RVA: 0x0008F282 File Offset: 0x0008D482
		protected UKuroResourceSystemFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002A45 RID: 10821
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroResourceSystemFunctionLibrary";

		// Token: 0x04002A46 RID: 10822
		private static IntPtr _ClassPtr;

		// Token: 0x04002A47 RID: 10823
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
