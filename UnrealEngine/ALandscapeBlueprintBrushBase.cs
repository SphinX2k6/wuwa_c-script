using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F6C RID: 8044
	[UnrealObjectPath("/Script/Landscape.LandscapeBlueprintBrushBase")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public abstract class ALandscapeBlueprintBrushBase : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E811 RID: 124945 RVA: 0x002D57B2 File Offset: 0x002D39B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALandscapeBlueprintBrushBase._ClassPtr;
		}

		// Token: 0x0601E812 RID: 124946 RVA: 0x002D57BE File Offset: 0x002D39BE
		public void RequestLandscapeUpdate()
		{
			ALandscapeBlueprintBrushBase.__RequestLandscapeUpdate_Internal(base.NativePtr);
		}

		// Token: 0x0601E813 RID: 124947 RVA: 0x002D57CC File Offset: 0x002D39CC
		[NullableContext(2)]
		public unsafe virtual UTextureRenderTarget2D Render(bool InIsHeightmap, UTextureRenderTarget2D InCombinedResult, in FName InWeightmapLayerName)
		{
			fixed (FName* ptr = ref InWeightmapLayerName)
			{
				void* ptr2 = (void*)ptr;
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTextureRenderTarget2D>(ALandscapeBlueprintBrushBase.__Render_Internal(base.NativePtr, InIsHeightmap, (InCombinedResult != null) ? InCombinedResult.NativePtr : IntPtr.Zero, InWeightmapLayerName));
			}
		}

		// Token: 0x0601E814 RID: 124948 RVA: 0x002D5800 File Offset: 0x002D3A00
		[NullableContext(2)]
		protected unsafe virtual UTextureRenderTarget2D Render_Implementation(bool InIsHeightmap, UTextureRenderTarget2D InCombinedResult, in FName InWeightmapLayerName)
		{
			fixed (FName* ptr = ref InWeightmapLayerName)
			{
				void* ptr2 = (void*)ptr;
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTextureRenderTarget2D>(ALandscapeBlueprintBrushBase.__Render_Implementation_Internal(base.NativePtr, InIsHeightmap, (InCombinedResult != null) ? InCombinedResult.NativePtr : IntPtr.Zero, InWeightmapLayerName));
			}
		}

		// Token: 0x0601E815 RID: 124949 RVA: 0x002D5834 File Offset: 0x002D3A34
		public unsafe virtual void Initialize(in FTransform InLandscapeTransform, in FIntPoint InLandscapeSize, in FIntPoint InLandscapeRenderTargetSize)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InLandscapeTransform;
			ALandscapeBlueprintBrushBase.__Initialize_Internal(base.NativePtr, ptr, InLandscapeSize, InLandscapeRenderTargetSize);
		}

		// Token: 0x0601E816 RID: 124950 RVA: 0x002D586C File Offset: 0x002D3A6C
		protected unsafe virtual void Initialize_Implementation(in FTransform InLandscapeTransform, in FIntPoint InLandscapeSize, in FIntPoint InLandscapeRenderTargetSize)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InLandscapeTransform;
			ALandscapeBlueprintBrushBase.__Initialize_Implementation_Internal(base.NativePtr, ptr, InLandscapeSize, InLandscapeRenderTargetSize);
		}

		// Token: 0x0601E817 RID: 124951 RVA: 0x002D58A3 File Offset: 0x002D3AA3
		public virtual void GetBlueprintRenderDependencies([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UObject> OutStreamableAssets)
		{
			ALandscapeBlueprintBrushBase.__GetBlueprintRenderDependencies_Internal(base.NativePtr, (OutStreamableAssets ?? new TArray<UObject>()).NativePtr);
		}

		// Token: 0x0601E818 RID: 124952
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RequestLandscapeUpdate_Internal(IntPtr @this);

		// Token: 0x0601E819 RID: 124953
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Render_Internal(IntPtr @this, bool InIsHeightmap, IntPtr InCombinedResult, in FName InWeightmapLayerName);

		// Token: 0x0601E81A RID: 124954
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Render_Implementation_Internal(IntPtr @this, bool InIsHeightmap, IntPtr InCombinedResult, in FName InWeightmapLayerName);

		// Token: 0x0601E81B RID: 124955
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Initialize_Internal(IntPtr @this, in FTransform InLandscapeTransform, in FIntPoint InLandscapeSize, in FIntPoint InLandscapeRenderTargetSize);

		// Token: 0x0601E81C RID: 124956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Initialize_Implementation_Internal(IntPtr @this, in FTransform InLandscapeTransform, in FIntPoint InLandscapeSize, in FIntPoint InLandscapeRenderTargetSize);

		// Token: 0x0601E81D RID: 124957
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetBlueprintRenderDependencies_Internal(IntPtr @this, IntPtr OutStreamableAssets);

		// Token: 0x0601E81E RID: 124958 RVA: 0x002D58C0 File Offset: 0x002D3AC0
		static ALandscapeBlueprintBrushBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeBlueprintBrushBase");
		}

		// Token: 0x0601E81F RID: 124959 RVA: 0x002D58D0 File Offset: 0x002D3AD0
		protected ALandscapeBlueprintBrushBase() : this(BuiltinUtils.AllocNativeUObject(ALandscapeBlueprintBrushBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E820 RID: 124960 RVA: 0x002D58F8 File Offset: 0x002D3AF8
		protected ALandscapeBlueprintBrushBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040107C7 RID: 67527
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.LandscapeBlueprintBrushBase";

		// Token: 0x040107C8 RID: 67528
		private static IntPtr _ClassPtr;

		// Token: 0x040107C9 RID: 67529
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0200340A RID: 13322
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __Render_FunctionParams
		{
			// Token: 0x040173CF RID: 95183
			[FieldOffset(0)]
			public bool InIsHeightmap;

			// Token: 0x040173D0 RID: 95184
			[FieldOffset(8)]
			public IntPtr InCombinedResult;

			// Token: 0x040173D1 RID: 95185
			[FieldOffset(16)]
			public FName InWeightmapLayerName;

			// Token: 0x040173D2 RID: 95186
			[FieldOffset(32)]
			public IntPtr __Result;
		}

		// Token: 0x0200340B RID: 13323
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __Initialize_FunctionParams
		{
			// Token: 0x040173D3 RID: 95187
			[FieldOffset(0)]
			public FTransform InLandscapeTransform;

			// Token: 0x040173D4 RID: 95188
			[FieldOffset(48)]
			public FIntPoint InLandscapeSize;

			// Token: 0x040173D5 RID: 95189
			[FieldOffset(56)]
			public FIntPoint InLandscapeRenderTargetSize;
		}

		// Token: 0x0200340C RID: 13324
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetBlueprintRenderDependencies_FunctionParams
		{
			// Token: 0x040173D6 RID: 95190
			[FieldOffset(0)]
			public byte OutStreamableAssets;
		}
	}
}
