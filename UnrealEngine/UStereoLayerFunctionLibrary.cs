using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011A0 RID: 4512
	[UnrealObjectPath("/Script/Engine.StereoLayerFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UStereoLayerFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010A15 RID: 68117 RVA: 0x00186AED File Offset: 0x00184CED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStereoLayerFunctionLibrary._ClassPtr;
		}

		// Token: 0x06010A16 RID: 68118 RVA: 0x00186AFC File Offset: 0x00184CFC
		public UStereoLayerFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UStereoLayerFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010A17 RID: 68119 RVA: 0x00186B24 File Offset: 0x00184D24
		[NullableContext(1)]
		public UStereoLayerFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStereoLayerFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06010A18 RID: 68120
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ShowSplashScreen();

		// Token: 0x06010A19 RID: 68121 RVA: 0x00186B58 File Offset: 0x00184D58
		[NullableContext(2)]
		public static void SetSplashScreen(UTexture Texture, FVector2D? Scale = null, FVector? Offset = null, bool bShowLoadingMovie = false, bool bShowOnSet = false)
		{
			UStereoLayerFunctionLibrary.__SetSplashScreen_Internal((Texture != null) ? Texture.NativePtr : IntPtr.Zero, Scale ?? new FVector2D
			{
				X = 1f,
				Y = 1f
			}, Offset ?? new FVector(0f, 0f, 0f), bShowLoadingMovie, bShowOnSet);
		}

		// Token: 0x06010A1A RID: 68122
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void HideSplashScreen();

		// Token: 0x06010A1B RID: 68123
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void EnableAutoLoadingSplashScreen(bool InAutoShowEnabled);

		// Token: 0x06010A1C RID: 68124
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSplashScreen_Internal(IntPtr Texture, FVector2D Scale, FVector Offset, bool bShowLoadingMovie, bool bShowOnSet);

		// Token: 0x06010A1D RID: 68125 RVA: 0x00186BD9 File Offset: 0x00184DD9
		static UStereoLayerFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StereoLayerFunctionLibrary");
		}

		// Token: 0x06010A1E RID: 68126 RVA: 0x00186BE7 File Offset: 0x00184DE7
		protected UStereoLayerFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008E48 RID: 36424
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StereoLayerFunctionLibrary";

		// Token: 0x04008E49 RID: 36425
		private static IntPtr _ClassPtr;

		// Token: 0x04008E4A RID: 36426
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
