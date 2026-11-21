using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000225 RID: 549
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KismetRenderingLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetRenderingLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060029E8 RID: 10728 RVA: 0x00038DCD File Offset: 0x00036FCD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetRenderingLibrary._ClassPtr;
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x00038DDC File Offset: 0x00036FDC
		public UKismetRenderingLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetRenderingLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x00038E04 File Offset: 0x00037004
		[NullableContext(1)]
		public UKismetRenderingLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetRenderingLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x00038E37 File Offset: 0x00037037
		public static void SetCastInsetShadowForAllAttachments(UPrimitiveComponent PrimitiveComponent, bool bCastInsetShadow, bool bLightAttachmentsAsGroup)
		{
			UKismetRenderingLibrary.__SetCastInsetShadowForAllAttachments_Internal((PrimitiveComponent != null) ? PrimitiveComponent.NativePtr : IntPtr.Zero, bCastInsetShadow, bLightAttachmentsAsGroup);
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x00038E50 File Offset: 0x00037050
		public static void ReleaseRenderTarget2D(UTextureRenderTarget2D TextureRenderTarget)
		{
			UKismetRenderingLibrary.__ReleaseRenderTarget2D_Internal((TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x00038E67 File Offset: 0x00037067
		public static FColor ReadRenderTargetUV(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, float U, float V)
		{
			return UKismetRenderingLibrary.__ReadRenderTargetUV_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, U, V);
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x00038E90 File Offset: 0x00037090
		public static FLinearColor ReadRenderTargetRawUV(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, float U, float V)
		{
			return UKismetRenderingLibrary.__ReadRenderTargetRawUV_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, U, V);
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x00038EB9 File Offset: 0x000370B9
		public static FLinearColor ReadRenderTargetRawPixel(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, int X, int Y, bool bAllowHDR = false)
		{
			return UKismetRenderingLibrary.__ReadRenderTargetRawPixel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, X, Y, bAllowHDR);
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x00038EE4 File Offset: 0x000370E4
		public static FColor ReadRenderTargetPixel(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, int X, int Y)
		{
			return UKismetRenderingLibrary.__ReadRenderTargetPixel_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, X, Y);
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x00038F0D File Offset: 0x0003710D
		[NullableContext(1)]
		public static FSkelMeshSkinWeightInfo MakeSkinWeightInfo(int Bone0, byte Weight0, int Bone1, byte Weight1, int Bone2, byte Weight2, int Bone3, byte Weight3)
		{
			return new FSkelMeshSkinWeightInfo(UKismetRenderingLibrary.__MakeSkinWeightInfo_Internal(Bone0, Weight0, Bone1, Weight1, Bone2, Weight2, Bone3, Weight3), null);
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x00038F26 File Offset: 0x00037126
		public static void KuroDrawMaterialToRenderTarget(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, UMaterialInterface Material)
		{
			UKismetRenderingLibrary.__KuroDrawMaterialToRenderTarget_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, (Material != null) ? Material.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060029F3 RID: 10739
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsSupportedAFME();

		// Token: 0x060029F4 RID: 10740
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsAFMEValid();

		// Token: 0x060029F5 RID: 10741 RVA: 0x00038F60 File Offset: 0x00037160
		public unsafe static UTexture2D ImportFileAsTexture2D(UObject WorldContextObject, [Nullable(1)] string Filename)
		{
			FString fstring = FString.AllocTemp(Filename);
			UTexture2D orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(UKismetRenderingLibrary.__ImportFileAsTexture2D_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x00038F99 File Offset: 0x00037199
		public static UTexture2D ImportBufferAsTexture2D(UObject WorldContextObject, in TArray<byte> Buffer)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(UKismetRenderingLibrary.__ImportBufferAsTexture2D_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Buffer ?? new TArray<byte>()).NativePtr));
		}

		// Token: 0x060029F7 RID: 10743
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetNumDrawPrimitives();

		// Token: 0x060029F8 RID: 10744
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetNumDrawCalls();

		// Token: 0x060029F9 RID: 10745 RVA: 0x00038FC8 File Offset: 0x000371C8
		[NullableContext(1)]
		public unsafe static void ExportTexture2D([Nullable(2)] UObject WorldContextObject, [Nullable(2)] UTexture2D Texture, string FilePath, string FileName)
		{
			FString fstring = FString.AllocTemp(FilePath);
			FString fstring2 = FString.AllocTemp(FileName);
			UKismetRenderingLibrary.__ExportTexture2D_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Texture != null) ? Texture.NativePtr : IntPtr.Zero, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x00039020 File Offset: 0x00037220
		[NullableContext(1)]
		public unsafe static void ExportRenderTarget([Nullable(2)] UObject WorldContextObject, [Nullable(2)] UTextureRenderTarget2D TextureRenderTarget, string FilePath, string FileName)
		{
			FString fstring = FString.AllocTemp(FilePath);
			FString fstring2 = FString.AllocTemp(FileName);
			UKismetRenderingLibrary.__ExportRenderTarget_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x00039076 File Offset: 0x00037276
		public static void DrawMaterialToRenderTarget(UObject WorldContextObject, UTextureRenderTarget2D TextureRenderTarget, UMaterialInterface Material)
		{
			UKismetRenderingLibrary.__DrawMaterialToRenderTarget_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (TextureRenderTarget != null) ? TextureRenderTarget.NativePtr : IntPtr.Zero, (Material != null) ? Material.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x000390B0 File Offset: 0x000372B0
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

		// Token: 0x060029FD RID: 10749 RVA: 0x0003912E File Offset: 0x0003732E
		public static void ConvertRenderTargetToTexture2DEditorOnly(UObject WorldContextObject, UTextureRenderTarget2D RenderTarget, UTexture2D Texture)
		{
			UKismetRenderingLibrary.__ConvertRenderTargetToTexture2DEditorOnly_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (RenderTarget != null) ? RenderTarget.NativePtr : IntPtr.Zero, (Texture != null) ? Texture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x00039168 File Offset: 0x00037368
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

		// Token: 0x060029FF RID: 10751 RVA: 0x000391E8 File Offset: 0x000373E8
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

		// Token: 0x06002A00 RID: 10752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastInsetShadowForAllAttachments_Internal(IntPtr PrimitiveComponent, bool bCastInsetShadow, bool bLightAttachmentsAsGroup);

		// Token: 0x06002A01 RID: 10753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseRenderTarget2D_Internal(IntPtr TextureRenderTarget);

		// Token: 0x06002A02 RID: 10754
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __ReadRenderTargetUV_Internal(IntPtr WorldContextObject, IntPtr TextureRenderTarget, float U, float V);

		// Token: 0x06002A03 RID: 10755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __ReadRenderTargetRawUV_Internal(IntPtr WorldContextObject, IntPtr TextureRenderTarget, float U, float V);

		// Token: 0x06002A04 RID: 10756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __ReadRenderTargetRawPixel_Internal(IntPtr WorldContextObject, IntPtr TextureRenderTarget, int X, int Y, bool bAllowHDR);

		// Token: 0x06002A05 RID: 10757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __ReadRenderTargetPixel_Internal(IntPtr WorldContextObject, IntPtr TextureRenderTarget, int X, int Y);

		// Token: 0x06002A06 RID: 10758
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeSkinWeightInfo_Internal(int Bone0, byte Weight0, int Bone1, byte Weight1, int Bone2, byte Weight2, int Bone3, byte Weight3);

		// Token: 0x06002A07 RID: 10759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroDrawMaterialToRenderTarget_Internal(IntPtr WorldContextObject, IntPtr TextureRenderTarget, IntPtr Material);

		// Token: 0x06002A08 RID: 10760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ImportFileAsTexture2D_Internal(IntPtr WorldContextObject, in FString Filename);

		// Token: 0x06002A09 RID: 10761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ImportBufferAsTexture2D_Internal(IntPtr WorldContextObject, IntPtr Buffer);

		// Token: 0x06002A0A RID: 10762
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExportTexture2D_Internal(IntPtr WorldContextObject, IntPtr Texture, in FString FilePath, in FString FileName);

		// Token: 0x06002A0B RID: 10763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExportRenderTarget_Internal(IntPtr WorldContextObject, IntPtr TextureRenderTarget, in FString FilePath, in FString FileName);

		// Token: 0x06002A0C RID: 10764
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawMaterialToRenderTarget_Internal(IntPtr WorldContextObject, IntPtr TextureRenderTarget, IntPtr Material);

		// Token: 0x06002A0D RID: 10765
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateRenderTarget2D_Internal(IntPtr WorldContextObject, int Width, int Height, TEnumAsByte<ETextureRenderTargetFormat> Format, FLinearColor ClearColor, bool bAutoGenerateMipMaps);

		// Token: 0x06002A0E RID: 10766
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ConvertRenderTargetToTexture2DEditorOnly_Internal(IntPtr WorldContextObject, IntPtr RenderTarget, IntPtr Texture);

		// Token: 0x06002A0F RID: 10767
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearRenderTarget2D_Internal(IntPtr WorldContextObject, IntPtr TextureRenderTarget, FLinearColor ClearColor);

		// Token: 0x06002A10 RID: 10768
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakSkinWeightInfo_Internal(IntPtr InWeight, ref int Bone0, ref byte Weight0, ref int Bone1, ref byte Weight1, ref int Bone2, ref byte Weight2, ref int Bone3, ref byte Weight3);

		// Token: 0x06002A11 RID: 10769 RVA: 0x00039277 File Offset: 0x00037477
		static UKismetRenderingLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetRenderingLibrary");
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x00039285 File Offset: 0x00037485
		protected UKismetRenderingLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E17 RID: 3607
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KismetRenderingLibrary";

		// Token: 0x04000E18 RID: 3608
		private static IntPtr _ClassPtr;

		// Token: 0x04000E19 RID: 3609
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
