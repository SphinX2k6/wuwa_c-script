using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001473 RID: 5235
	[UnrealObjectPath("/Script/HeadMountedDisplay.XRLoadingScreenFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UXRLoadingScreenFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013185 RID: 78213 RVA: 0x001C158C File Offset: 0x001BF78C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UXRLoadingScreenFunctionLibrary._ClassPtr;
		}

		// Token: 0x06013186 RID: 78214 RVA: 0x001C1598 File Offset: 0x001BF798
		public UXRLoadingScreenFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UXRLoadingScreenFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013187 RID: 78215 RVA: 0x001C15C0 File Offset: 0x001BF7C0
		[NullableContext(1)]
		public UXRLoadingScreenFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UXRLoadingScreenFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013188 RID: 78216
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ShowLoadingScreen();

		// Token: 0x06013189 RID: 78217 RVA: 0x001C15F4 File Offset: 0x001BF7F4
		[NullableContext(2)]
		public static void SetLoadingScreen(UTexture Texture, FVector2D? Scale = null, FVector Offset = default(FVector), bool bShowLoadingMovie = false, bool bShowOnSet = false)
		{
			UXRLoadingScreenFunctionLibrary.__SetLoadingScreen_Internal((Texture != null) ? Texture.NativePtr : IntPtr.Zero, Scale ?? new FVector2D
			{
				X = 1f,
				Y = 1f
			}, Offset, bShowLoadingMovie, bShowOnSet);
		}

		// Token: 0x0601318A RID: 78218
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void HideLoadingScreen();

		// Token: 0x0601318B RID: 78219
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearLoadingScreenSplashes();

		// Token: 0x0601318C RID: 78220 RVA: 0x001C1650 File Offset: 0x001BF850
		[NullableContext(2)]
		public static void AddLoadingScreenSplash(UTexture Texture, FVector Translation, FRotator Rotation, FVector2D? Size = null, FRotator DeltaRotation = default(FRotator), bool bClearBeforeAdd = false)
		{
			UXRLoadingScreenFunctionLibrary.__AddLoadingScreenSplash_Internal((Texture != null) ? Texture.NativePtr : IntPtr.Zero, Translation, Rotation, Size ?? new FVector2D
			{
				X = 1f,
				Y = 1f
			}, DeltaRotation, bClearBeforeAdd);
		}

		// Token: 0x0601318D RID: 78221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLoadingScreen_Internal(IntPtr Texture, FVector2D Scale, FVector Offset, bool bShowLoadingMovie, bool bShowOnSet);

		// Token: 0x0601318E RID: 78222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddLoadingScreenSplash_Internal(IntPtr Texture, FVector Translation, FRotator Rotation, FVector2D Size, FRotator DeltaRotation, bool bClearBeforeAdd);

		// Token: 0x0601318F RID: 78223 RVA: 0x001C16AC File Offset: 0x001BF8AC
		static UXRLoadingScreenFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HeadMountedDisplay.XRLoadingScreenFunctionLibrary");
		}

		// Token: 0x06013190 RID: 78224 RVA: 0x001C16BA File Offset: 0x001BF8BA
		protected UXRLoadingScreenFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A3C6 RID: 41926
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/HeadMountedDisplay.XRLoadingScreenFunctionLibrary";

		// Token: 0x0400A3C7 RID: 41927
		private static IntPtr _ClassPtr;

		// Token: 0x0400A3C8 RID: 41928
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
