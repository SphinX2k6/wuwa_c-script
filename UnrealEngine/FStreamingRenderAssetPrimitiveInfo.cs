using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011AC RID: 4524
	[UnrealObjectPath("/Script/Engine.StreamingRenderAssetPrimitiveInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FStreamingRenderAssetPrimitiveInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010AD8 RID: 68312 RVA: 0x00187E84 File Offset: 0x00186084
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStreamingRenderAssetPrimitiveInfo._ScriptStructPtr != 0) ? FStreamingRenderAssetPrimitiveInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StreamingRenderAssetPrimitiveInfo", ref FStreamingRenderAssetPrimitiveInfo._ScriptStructPtr);
		}

		// Token: 0x1700411E RID: 16670
		// (get) Token: 0x06010AD9 RID: 68313 RVA: 0x00187EA8 File Offset: 0x001860A8
		// (set) Token: 0x06010ADA RID: 68314 RVA: 0x00187EBC File Offset: 0x001860BC
		[Nullable(2)]
		public unsafe UStreamableRenderAsset RenderAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStreamableRenderAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FStreamingRenderAssetPrimitiveInfo.__PropertyOffset_RenderAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FStreamingRenderAssetPrimitiveInfo.__PropertyOffset_RenderAsset, value);
			}
		}

		// Token: 0x1700411F RID: 16671
		// (get) Token: 0x06010ADB RID: 68315 RVA: 0x00187ED1 File Offset: 0x001860D1
		// (set) Token: 0x06010ADC RID: 68316 RVA: 0x00187EE5 File Offset: 0x001860E5
		public unsafe FBoxSphereBounds Bounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingRenderAssetPrimitiveInfo.__PropertyOffset_Bounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingRenderAssetPrimitiveInfo.__PropertyOffset_Bounds) = value;
			}
		}

		// Token: 0x17004120 RID: 16672
		// (get) Token: 0x06010ADD RID: 68317 RVA: 0x00187EFA File Offset: 0x001860FA
		// (set) Token: 0x06010ADE RID: 68318 RVA: 0x00187F0A File Offset: 0x0018610A
		public unsafe float TexelFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingRenderAssetPrimitiveInfo.__PropertyOffset_TexelFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingRenderAssetPrimitiveInfo.__PropertyOffset_TexelFactor) = value;
			}
		}

		// Token: 0x17004121 RID: 16673
		// (get) Token: 0x06010ADF RID: 68319 RVA: 0x00187F1B File Offset: 0x0018611B
		// (set) Token: 0x06010AE0 RID: 68320 RVA: 0x00187F2B File Offset: 0x0018612B
		public unsafe uint PackedRelativeBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingRenderAssetPrimitiveInfo.__PropertyOffset_PackedRelativeBox);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingRenderAssetPrimitiveInfo.__PropertyOffset_PackedRelativeBox) = (int)value;
			}
		}

		// Token: 0x17004122 RID: 16674
		// (get) Token: 0x06010AE1 RID: 68321 RVA: 0x00187F3C File Offset: 0x0018613C
		// (set) Token: 0x06010AE2 RID: 68322 RVA: 0x00187F55 File Offset: 0x00186155
		public unsafe bool bAllowInvalidTexelFactorWhenUnregistered
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStreamingRenderAssetPrimitiveInfo.__PropertyOffset_bAllowInvalidTexelFactorWhenUnregistered) & FStreamingRenderAssetPrimitiveInfo.__PropertyMask_bAllowInvalidTexelFactorWhenUnregistered) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStreamingRenderAssetPrimitiveInfo.__PropertyOffset_bAllowInvalidTexelFactorWhenUnregistered) = ((*(base.NativePtr + (IntPtr)FStreamingRenderAssetPrimitiveInfo.__PropertyOffset_bAllowInvalidTexelFactorWhenUnregistered) & ~FStreamingRenderAssetPrimitiveInfo.__PropertyMask_bAllowInvalidTexelFactorWhenUnregistered) | (value ? FStreamingRenderAssetPrimitiveInfo.__PropertyMask_bAllowInvalidTexelFactorWhenUnregistered : 0));
			}
		}

		// Token: 0x06010AE3 RID: 68323 RVA: 0x00187F85 File Offset: 0x00186185
		public FStreamingRenderAssetPrimitiveInfo()
		{
		}

		// Token: 0x06010AE4 RID: 68324 RVA: 0x00187F8D File Offset: 0x0018618D
		[NullableContext(1)]
		public FStreamingRenderAssetPrimitiveInfo(UStreamableRenderAsset RenderAsset, FBoxSphereBounds Bounds, float TexelFactor, uint PackedRelativeBox, bool bAllowInvalidTexelFactorWhenUnregistered)
		{
			this.RenderAsset = RenderAsset;
			this.Bounds = Bounds;
			this.TexelFactor = TexelFactor;
			this.PackedRelativeBox = PackedRelativeBox;
			this.bAllowInvalidTexelFactorWhenUnregistered = bAllowInvalidTexelFactorWhenUnregistered;
		}

		// Token: 0x06010AE5 RID: 68325 RVA: 0x00187FBA File Offset: 0x001861BA
		protected override IntPtr GetUStructPtr()
		{
			return FStreamingRenderAssetPrimitiveInfo.StaticStruct();
		}

		// Token: 0x06010AE6 RID: 68326 RVA: 0x00187FC6 File Offset: 0x001861C6
		[NullableContext(2)]
		public FStreamingRenderAssetPrimitiveInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010AE7 RID: 68327 RVA: 0x00187FD0 File Offset: 0x001861D0
		public FStreamingRenderAssetPrimitiveInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010AE8 RID: 68328 RVA: 0x00187FDB File Offset: 0x001861DB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStreamingRenderAssetPrimitiveInfo(Pointer, false, true);
		}

		// Token: 0x06010AE9 RID: 68329 RVA: 0x00187FE5 File Offset: 0x001861E5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStreamingRenderAssetPrimitiveInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04008EB6 RID: 36534
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.StreamingRenderAssetPrimitiveInfo";

		// Token: 0x04008EB7 RID: 36535
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008EB8 RID: 36536
		internal static int __PropertyOffset_RenderAsset;

		// Token: 0x04008EB9 RID: 36537
		internal static int __PropertyOffset_Bounds;

		// Token: 0x04008EBA RID: 36538
		internal static int __PropertyOffset_TexelFactor;

		// Token: 0x04008EBB RID: 36539
		internal static int __PropertyOffset_PackedRelativeBox;

		// Token: 0x04008EBC RID: 36540
		internal static int __PropertyOffset_bAllowInvalidTexelFactorWhenUnregistered;

		// Token: 0x04008EBD RID: 36541
		internal static byte __PropertyMask_bAllowInvalidTexelFactorWhenUnregistered;
	}
}
