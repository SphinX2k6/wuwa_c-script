using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CD3 RID: 3283
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KismetRenderingLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetRenderingLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AAD6 RID: 43734 RVA: 0x000EFFF7 File Offset: 0x000EE1F7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetRenderingLibrary._ClassPtr;
		}

		// Token: 0x0600AAD7 RID: 43735 RVA: 0x000F0004 File Offset: 0x000EE204
		public UKismetRenderingLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetRenderingLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AAD8 RID: 43736 RVA: 0x000F002C File Offset: 0x000EE22C
		[NullableContext(1)]
		public UKismetRenderingLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetRenderingLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600AAD9 RID: 43737 RVA: 0x000F005F File Offset: 0x000EE25F
		public static void SetCastInsetShadowForAllAttachments(UPrimitiveComponent PrimitiveComponent, bool bCastInsetShadow, bool bLightAttachmentsAsGroup)
		{
			UKismetRenderingLibrary.__SetCastInsetShadowForAllAttachments_Internal((PrimitiveComponent != null) ? PrimitiveComponent.NativePtr : IntPtr.Zero, bCastInsetShadow, bLightAttachmentsAsGroup);
		}

		// Token: 0x0600AADA RID: 43738 RVA: 0x000F0078 File Offset: 0x000EE278
		public unsafe static UTexture2D RenderTargetCreateStaticTexture2DEditorOnly(UTextureRenderTarget2D RenderTarget, [Nullable(1)] string Name = "Texture", TextureCompressionSettings CompressionSettings = TextureCompressionSettings.TC_Default, TextureMipGenSettings MipSettings = TextureMipGenSettings.TMGS_FromTextureGroup)
		{
			FString fstring = FString.AllocTemp(Name);
			UTexture2D orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(UKismetRenderingLibrary.__RenderTargetCreateStaticTexture2DEditorOnly_Internal((RenderTarget != null) ? RenderTarget.NativePtr : IntPtr.Zero, fstring, CompressionSettings, MipSettings));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600AADB RID: 43739 RVA: 0x000F00BD File Offset: 0x000EE2BD
		public static void ReleaseRenderTarget2D(UTextureRenderTarget2D TextureRenderTarget)
		{
			UKismetRenderingLibrary.__ReleaseRenderTarget2D_Internal((TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600AADC RID: 43740 RVA: 0x000F00D4 File Offset: 0x000EE2D4
		public static FColor ReadRenderTargetUV(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, float U, float V)
		{
			return UKismetRenderingLibrary.__ReadRenderTargetUV_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, U, V);
		}

		// Token: 0x0600AADD RID: 43741 RVA: 0x000F00FD File Offset: 0x000EE2FD
		public static FLinearColor ReadRenderTargetRawUV(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, float U, float V)
		{
			return UKismetRenderingLibrary.__ReadRenderTargetRawUV_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, U, V);
		}

		// Token: 0x0600AADE RID: 43742 RVA: 0x000F0126 File Offset: 0x000EE326
		public static FLinearColor ReadRenderTargetRawPixel(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, int X, int Y, bool bAllowHDR = false)
		{
			return UKismetRenderingLibrary.__ReadRenderTargetRawPixel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, X, Y, bAllowHDR);
		}

		// Token: 0x0600AADF RID: 43743 RVA: 0x000F0151 File Offset: 0x000EE351
		public static FColor ReadRenderTargetPixel(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, int X, int Y)
		{
			return UKismetRenderingLibrary.__ReadRenderTargetPixel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, X, Y);
		}

		// Token: 0x0600AAE0 RID: 43744 RVA: 0x000F017A File Offset: 0x000EE37A
		[NullableContext(1)]
		public static FSkelMeshSkinWeightInfo MakeSkinWeightInfo(int Bone0, byte Weight0, int Bone1, byte Weight1, int Bone2, byte Weight2, int Bone3, byte Weight3)
		{
			return new FSkelMeshSkinWeightInfo(UKismetRenderingLibrary.__MakeSkinWeightInfo_Internal(Bone0, Weight0, Bone1, Weight1, Bone2, Weight2, Bone3, Weight3), null);
		}

		// Token: 0x0600AAE1 RID: 43745 RVA: 0x000F0193 File Offset: 0x000EE393
		public static void KuroDrawMaterialToRenderTarget(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, UMaterialInterface Material)
		{
			UKismetRenderingLibrary.__KuroDrawMaterialToRenderTarget_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, (Material != null) ? Material.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600AAE2 RID: 43746
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsSupportedAFME();

		// Token: 0x0600AAE3 RID: 43747
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsAFMEValid();

		// Token: 0x0600AAE4 RID: 43748 RVA: 0x000F01CC File Offset: 0x000EE3CC
		public unsafe static UTexture2D ImportFileAsTexture2D(UObject WorldContextObject, [Nullable(1)] string Filename)
		{
			FString fstring = FString.AllocTemp(Filename);
			UTexture2D orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(UKismetRenderingLibrary.__ImportFileAsTexture2D_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600AAE5 RID: 43749 RVA: 0x000F0205 File Offset: 0x000EE405
		public static UTexture2D ImportBufferAsTexture2D(UObject WorldContextObject, in TArray<byte> Buffer)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(UKismetRenderingLibrary.__ImportBufferAsTexture2D_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Buffer ?? new TArray<byte>()).NativePtr));
		}

		// Token: 0x0600AAE6 RID: 43750
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetNumDrawPrimitives();

		// Token: 0x0600AAE7 RID: 43751
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetNumDrawCalls();

		// Token: 0x0600AAE8 RID: 43752 RVA: 0x000F0234 File Offset: 0x000EE434
		[NullableContext(1)]
		public unsafe static void ExportTexture2D([Nullable(2)] UObject WorldContextObject, [Nullable(2)] UTexture2D Texture, string FilePath, string FileName)
		{
			FString fstring = FString.AllocTemp(FilePath);
			FString fstring2 = FString.AllocTemp(FileName);
			UKismetRenderingLibrary.__ExportTexture2D_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Texture != null) ? Texture.NativePtr : IntPtr.Zero, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0600AAE9 RID: 43753 RVA: 0x000F028C File Offset: 0x000EE48C
		[NullableContext(1)]
		public unsafe static void ExportRenderTarget([Nullable(2)] UObject WorldContextObject, [Nullable(2)] UTextureRenderTarget2D TextureRenderTarget, string FilePath, string FileName)
		{
			FString fstring = FString.AllocTemp(FilePath);
			FString fstring2 = FString.AllocTemp(FileName);
			UKismetRenderingLibrary.__ExportRenderTarget_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0600AAEA RID: 43754 RVA: 0x000F02E2 File Offset: 0x000EE4E2
		public static void EndDrawCanvasToRenderTarget(UObject WorldContextObject, in FDrawToRenderTargetContext Context)
		{
			UKismetRenderingLibrary.__EndDrawCanvasToRenderTarget_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Context ?? new FDrawToRenderTargetContext()).NativePtr);
		}

		// Token: 0x0600AAEB RID: 43755 RVA: 0x000F0309 File Offset: 0x000EE509
		public static void DrawMaterialToRenderTarget(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, UMaterialInterface Material)
		{
			UKismetRenderingLibrary.__DrawMaterialToRenderTarget_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, (Material != null) ? Material.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600AAEC RID: 43756 RVA: 0x000F0340 File Offset: 0x000EE540
		public static UTextureRenderTargetVolume CreateRenderTargetVolume(UObject WorldContextObject, int Width = 16, int Height = 16, int Depth = 16, ETextureRenderTargetFormat Format = ETextureRenderTargetFormat.RTF_RGBA16f, FLinearColor? ClearColor = null, bool bAutoGenerateMipMaps = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTextureRenderTargetVolume>(UKismetRenderingLibrary.__CreateRenderTargetVolume_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Width, Height, Depth, Format, ClearColor ?? new FLinearColor
			{
				R = 0f,
				G = 0f,
				B = 0f,
				A = 1f
			}, bAutoGenerateMipMaps));
		}

		// Token: 0x0600AAED RID: 43757 RVA: 0x000F03C0 File Offset: 0x000EE5C0
		public static UTextureRenderTarget2DArray CreateRenderTarget2DArray(UObject WorldContextObject, int Width = 256, int Height = 256, int Slices = 1, ETextureRenderTargetFormat Format = ETextureRenderTargetFormat.RTF_RGBA16f, FLinearColor? ClearColor = null, bool bAutoGenerateMipMaps = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTextureRenderTarget2DArray>(UKismetRenderingLibrary.__CreateRenderTarget2DArray_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Width, Height, Slices, Format, ClearColor ?? new FLinearColor
			{
				R = 0f,
				G = 0f,
				B = 0f,
				A = 1f
			}, bAutoGenerateMipMaps));
		}

		// Token: 0x0600AAEE RID: 43758 RVA: 0x000F0440 File Offset: 0x000EE640
		public static UTextureRenderTarget2D CreateRenderTarget2D(UObject WorldContextObject, int Width = 256, int Height = 256, ETextureRenderTargetFormat Format = ETextureRenderTargetFormat.RTF_RGBA16f, FLinearColor? ClearColor = null, bool bAutoGenerateMipMaps = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTextureRenderTarget2D>(UKismetRenderingLibrary.__CreateRenderTarget2D_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Width, Height, Format, ClearColor ?? new FLinearColor
			{
				R = 0f,
				G = 0f,
				B = 0f,
				A = 1f
			}, bAutoGenerateMipMaps));
		}

		// Token: 0x0600AAEF RID: 43759 RVA: 0x000F04BE File Offset: 0x000EE6BE
		public static void ConvertRenderTargetToTexture2DEditorOnly(UObject WorldContextObject, UTextureRenderTarget2D RenderTarget, UTexture2D Texture)
		{
			UKismetRenderingLibrary.__ConvertRenderTargetToTexture2DEditorOnly_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (RenderTarget != null) ? RenderTarget.NativePtr : IntPtr.Zero, (Texture != null) ? Texture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600AAF0 RID: 43760 RVA: 0x000F04F8 File Offset: 0x000EE6F8
		public static void ClearRenderTarget2D(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, FLinearColor? ClearColor = null)
		{
			UKismetRenderingLibrary.__ClearRenderTarget2D_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, ClearColor ?? new FLinearColor
			{
				R = 0f,
				G = 0f,
				B = 0f,
				A = 1f
			});
		}

		// Token: 0x0600AAF1 RID: 43761 RVA: 0x000F0578 File Offset: 0x000EE778
		public unsafe static void BreakSkinWeightInfo(FSkelMeshSkinWeightInfo InWeight, ref int Bone0, ref byte Weight0, ref int Bone1, ref byte Weight1, ref int Bone2, ref byte Weight2, ref int Bone3, ref byte Weight3)
		{
			fixed (int* ptr = &Bone0)
			{
				void* ptr2 = (void*)ptr;
				fixed (byte* ptr3 = &Weight0)
				{
					void* ptr4 = (void*)ptr3;
					fixed (int* ptr5 = &Bone1)
					{
						void* ptr6 = (void*)ptr5;
						fixed (byte* ptr7 = &Weight1)
						{
							void* ptr8 = (void*)ptr7;
							fixed (int* ptr9 = &Bone2)
							{
								void* ptr10 = (void*)ptr9;
								fixed (byte* ptr11 = &Weight2)
								{
									void* ptr12 = (void*)ptr11;
									fixed (int* ptr13 = &Bone3)
									{
										void* ptr14 = (void*)ptr13;
										fixed (byte* ptr15 = &Weight3)
										{
											void* ptr16 = (void*)ptr15;
											UKismetRenderingLibrary.__BreakSkinWeightInfo_Internal((InWeight ?? new FSkelMeshSkinWeightInfo()).NativePtr, ref Bone0, ref Weight0, ref Bone1, ref Weight1, ref Bone2, ref Weight2, ref Bone3, ref Weight3);
											ptr = null;
											ptr3 = null;
											ptr5 = null;
											ptr7 = null;
											ptr9 = null;
											ptr11 = null;
											ptr13 = null;
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AAF2 RID: 43762 RVA: 0x000F0608 File Offset: 0x000EE808
		public unsafe static void BeginDrawCanvasToRenderTarget(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, ref UCanvas Canvas, ref FVector2D Size, ref FDrawToRenderTargetContext Context)
		{
			UCanvas ucanvas = Canvas;
			IntPtr nativeObjectPtr = (ucanvas != null) ? ucanvas.NativePtr : IntPtr.Zero;
			fixed (FVector2D* ptr = &Size)
			{
				void* ptr2 = (void*)ptr;
				UKismetRenderingLibrary.__BeginDrawCanvasToRenderTarget_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, ref nativeObjectPtr, ref Size, (Context ?? new FDrawToRenderTargetContext()).NativePtr);
				Canvas = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCanvas>(nativeObjectPtr);
			}
		}

		// Token: 0x0600AAF3 RID: 43763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastInsetShadowForAllAttachments_Internal(IntPtr PrimitiveComponent, bool bCastInsetShadow, bool bLightAttachmentsAsGroup);

		// Token: 0x0600AAF4 RID: 43764
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RenderTargetCreateStaticTexture2DEditorOnly_Internal(IntPtr RenderTarget, in FString Name, TEnumAsByte<TextureCompressionSettings> CompressionSettings, TEnumAsByte<TextureMipGenSettings> MipSettings);

		// Token: 0x0600AAF5 RID: 43765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseRenderTarget2D_Internal(IntPtr TextureRenderTarget);

		// Token: 0x0600AAF6 RID: 43766
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __ReadRenderTargetUV_Internal(IntPtr WorldContextObject, IntPtr TextureRenderTarget, float U, float V);

		// Token: 0x0600AAF7 RID: 43767
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __ReadRenderTargetRawUV_Internal(IntPtr WorldContextObject, IntPtr TextureRenderTarget, float U, float V);

		// Token: 0x0600AAF8 RID: 43768
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __ReadRenderTargetRawPixel_Internal(IntPtr WorldContextObject, IntPtr TextureRenderTarget, int X, int Y, bool bAllowHDR);

		// Token: 0x0600AAF9 RID: 43769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __ReadRenderTargetPixel_Internal(IntPtr WorldContextObject, IntPtr TextureRenderTarget, int X, int Y);

		// Token: 0x0600AAFA RID: 43770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeSkinWeightInfo_Internal(int Bone0, byte Weight0, int Bone1, byte Weight1, int Bone2, byte Weight2, int Bone3, byte Weight3);

		// Token: 0x0600AAFB RID: 43771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroDrawMaterialToRenderTarget_Internal(IntPtr WorldContextObject, IntPtr TextureRenderTarget, IntPtr Material);

		// Token: 0x0600AAFC RID: 43772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ImportFileAsTexture2D_Internal(IntPtr WorldContextObject, in FString Filename);

		// Token: 0x0600AAFD RID: 43773
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ImportBufferAsTexture2D_Internal(IntPtr WorldContextObject, IntPtr Buffer);

		// Token: 0x0600AAFE RID: 43774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExportTexture2D_Internal(IntPtr WorldContextObject, IntPtr Texture, in FString FilePath, in FString FileName);

		// Token: 0x0600AAFF RID: 43775
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExportRenderTarget_Internal(IntPtr WorldContextObject, IntPtr TextureRenderTarget, in FString FilePath, in FString FileName);

		// Token: 0x0600AB00 RID: 43776
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndDrawCanvasToRenderTarget_Internal(IntPtr WorldContextObject, IntPtr Context);

		// Token: 0x0600AB01 RID: 43777
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawMaterialToRenderTarget_Internal(IntPtr WorldContextObject, IntPtr TextureRenderTarget, IntPtr Material);

		// Token: 0x0600AB02 RID: 43778
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateRenderTargetVolume_Internal(IntPtr WorldContextObject, int Width, int Height, int Depth, TEnumAsByte<ETextureRenderTargetFormat> Format, FLinearColor ClearColor, bool bAutoGenerateMipMaps);

		// Token: 0x0600AB03 RID: 43779
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateRenderTarget2DArray_Internal(IntPtr WorldContextObject, int Width, int Height, int Slices, TEnumAsByte<ETextureRenderTargetFormat> Format, FLinearColor ClearColor, bool bAutoGenerateMipMaps);

		// Token: 0x0600AB04 RID: 43780
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateRenderTarget2D_Internal(IntPtr WorldContextObject, int Width, int Height, TEnumAsByte<ETextureRenderTargetFormat> Format, FLinearColor ClearColor, bool bAutoGenerateMipMaps);

		// Token: 0x0600AB05 RID: 43781
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ConvertRenderTargetToTexture2DEditorOnly_Internal(IntPtr WorldContextObject, IntPtr RenderTarget, IntPtr Texture);

		// Token: 0x0600AB06 RID: 43782
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearRenderTarget2D_Internal(IntPtr WorldContextObject, IntPtr TextureRenderTarget, FLinearColor ClearColor);

		// Token: 0x0600AB07 RID: 43783
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakSkinWeightInfo_Internal(IntPtr InWeight, ref int Bone0, ref byte Weight0, ref int Bone1, ref byte Weight1, ref int Bone2, ref byte Weight2, ref int Bone3, ref byte Weight3);

		// Token: 0x0600AB08 RID: 43784
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeginDrawCanvasToRenderTarget_Internal(IntPtr WorldContextObject, IntPtr TextureRenderTarget, ref IntPtr Canvas, ref FVector2D Size, IntPtr Context);

		// Token: 0x0600AB09 RID: 43785 RVA: 0x000F0671 File Offset: 0x000EE871
		static UKismetRenderingLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetRenderingLibrary");
		}

		// Token: 0x0600AB0A RID: 43786 RVA: 0x000F067F File Offset: 0x000EE87F
		protected UKismetRenderingLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005B40 RID: 23360
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KismetRenderingLibrary";

		// Token: 0x04005B41 RID: 23361
		private static IntPtr _ClassPtr;

		// Token: 0x04005B42 RID: 23362
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
