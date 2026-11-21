using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000726 RID: 1830
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISpineRenderable")]
	[UnrealStructLayout(2768, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2768)]
	public class UUISpineRenderable : UUIBaseRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009ED8 RID: 40664 RVA: 0x000EBFF5 File Offset: 0x000EA1F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISpineRenderable._ClassPtr;
		}

		// Token: 0x06009ED9 RID: 40665 RVA: 0x000EC004 File Offset: 0x000EA204
		public UUISpineRenderable() : this(BuiltinUtils.AllocNativeUObject(UUISpineRenderable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009EDA RID: 40666 RVA: 0x000EC02C File Offset: 0x000EA22C
		public UUISpineRenderable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISpineRenderable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D7F RID: 7551
		// (get) Token: 0x06009EDB RID: 40667 RVA: 0x000EC05F File Offset: 0x000EA25F
		// (set) Token: 0x06009EDC RID: 40668 RVA: 0x000EC06F File Offset: 0x000EA26F
		public unsafe float DepthOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_DepthOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_DepthOffset) = value;
			}
		}

		// Token: 0x17001D80 RID: 7552
		// (get) Token: 0x06009EDD RID: 40669 RVA: 0x000EC080 File Offset: 0x000EA280
		// (set) Token: 0x06009EDE RID: 40670 RVA: 0x000EC094 File Offset: 0x000EA294
		public unsafe FName TextureParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_TextureParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_TextureParameterName) = value;
			}
		}

		// Token: 0x17001D81 RID: 7553
		// (get) Token: 0x06009EDF RID: 40671 RVA: 0x000EC0A9 File Offset: 0x000EA2A9
		// (set) Token: 0x06009EE0 RID: 40672 RVA: 0x000EC0B9 File Offset: 0x000EA2B9
		public unsafe bool bAdjustSizeWithAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_bAdjustSizeWithAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_bAdjustSizeWithAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D82 RID: 7554
		// (get) Token: 0x06009EE1 RID: 40673 RVA: 0x000EC0CA File Offset: 0x000EA2CA
		// (set) Token: 0x06009EE2 RID: 40674 RVA: 0x000EC0DA File Offset: 0x000EA2DA
		public unsafe bool bUseOptUpdateMeshSection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_bUseOptUpdateMeshSection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_bUseOptUpdateMeshSection) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D83 RID: 7555
		// (get) Token: 0x06009EE3 RID: 40675 RVA: 0x000EC0EB File Offset: 0x000EA2EB
		// (set) Token: 0x06009EE4 RID: 40676 RVA: 0x000EC0FB File Offset: 0x000EA2FB
		public unsafe bool bIgnoreUpdateViewportClipSpine
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_bIgnoreUpdateViewportClipSpine) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_bIgnoreUpdateViewportClipSpine) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D84 RID: 7556
		// (get) Token: 0x06009EE5 RID: 40677 RVA: 0x000EC10C File Offset: 0x000EA30C
		// (set) Token: 0x06009EE6 RID: 40678 RVA: 0x000EC11C File Offset: 0x000EA31C
		public unsafe bool bNeedParallelUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_bNeedParallelUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_bNeedParallelUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D85 RID: 7557
		// (get) Token: 0x06009EE7 RID: 40679 RVA: 0x000EC130 File Offset: 0x000EA330
		// (set) Token: 0x06009EE8 RID: 40680 RVA: 0x000EC169 File Offset: 0x000EA369
		public TArray<UMaterialInstanceDynamic> AtlasNormalBlendMaterialArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._AtlasNormalBlendMaterialArray) == null)
				{
					result = (this._AtlasNormalBlendMaterialArray = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_AtlasNormalBlendMaterialArray, this));
				}
				return result;
			}
			set
			{
				this.AtlasNormalBlendMaterialArray.CopyAssign(value);
			}
		}

		// Token: 0x17001D86 RID: 7558
		// (get) Token: 0x06009EE9 RID: 40681 RVA: 0x000EC178 File Offset: 0x000EA378
		// (set) Token: 0x06009EEA RID: 40682 RVA: 0x000EC1B1 File Offset: 0x000EA3B1
		public TArray<UMaterialInstanceDynamic> AtlasAdditiveBlendMaterialArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._AtlasAdditiveBlendMaterialArray) == null)
				{
					result = (this._AtlasAdditiveBlendMaterialArray = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_AtlasAdditiveBlendMaterialArray, this));
				}
				return result;
			}
			set
			{
				this.AtlasAdditiveBlendMaterialArray.CopyAssign(value);
			}
		}

		// Token: 0x17001D87 RID: 7559
		// (get) Token: 0x06009EEB RID: 40683 RVA: 0x000EC1C0 File Offset: 0x000EA3C0
		// (set) Token: 0x06009EEC RID: 40684 RVA: 0x000EC1F9 File Offset: 0x000EA3F9
		public TArray<UMaterialInstanceDynamic> AtlasMultiplyBlendMaterialArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._AtlasMultiplyBlendMaterialArray) == null)
				{
					result = (this._AtlasMultiplyBlendMaterialArray = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_AtlasMultiplyBlendMaterialArray, this));
				}
				return result;
			}
			set
			{
				this.AtlasMultiplyBlendMaterialArray.CopyAssign(value);
			}
		}

		// Token: 0x17001D88 RID: 7560
		// (get) Token: 0x06009EED RID: 40685 RVA: 0x000EC208 File Offset: 0x000EA408
		// (set) Token: 0x06009EEE RID: 40686 RVA: 0x000EC241 File Offset: 0x000EA441
		public TArray<UMaterialInstanceDynamic> AtlasScreenBlendMaterialArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._AtlasScreenBlendMaterialArray) == null)
				{
					result = (this._AtlasScreenBlendMaterialArray = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)UUISpineRenderable.__PropertyOffset_AtlasScreenBlendMaterialArray, this));
				}
				return result;
			}
			set
			{
				this.AtlasScreenBlendMaterialArray.CopyAssign(value);
			}
		}

		// Token: 0x17001D89 RID: 7561
		// (get) Token: 0x06009EEF RID: 40687 RVA: 0x000EC24F File Offset: 0x000EA44F
		// (set) Token: 0x06009EF0 RID: 40688 RVA: 0x000EC263 File Offset: 0x000EA463
		[Nullable(2)]
		public unsafe USpineSkeletonDataAsset CurrSkeletonData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpineSkeletonDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UUISpineRenderable.__PropertyOffset_CurrSkeletonData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISpineRenderable.__PropertyOffset_CurrSkeletonData, value);
			}
		}

		// Token: 0x06009EF1 RID: 40689 RVA: 0x000EC278 File Offset: 0x000EA478
		public void TestPlayPreviewAnimInRuntime()
		{
			UUISpineRenderable.__TestPlayPreviewAnimInRuntime_Internal(base.NativePtr);
		}

		// Token: 0x06009EF2 RID: 40690 RVA: 0x000EC285 File Offset: 0x000EA485
		[NullableContext(2)]
		public void OnSpineAnimationStart(UTrackEntry entry)
		{
			UUISpineRenderable.__OnSpineAnimationStart_Internal(base.NativePtr, (entry != null) ? entry.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009EF3 RID: 40691 RVA: 0x000EC2A2 File Offset: 0x000EA4A2
		[NullableContext(2)]
		public void OnSpineAnimationEnd(UTrackEntry entry)
		{
			UUISpineRenderable.__OnSpineAnimationEnd_Internal(base.NativePtr, (entry != null) ? entry.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009EF4 RID: 40692 RVA: 0x000EC2BF File Offset: 0x000EA4BF
		public int GetTotalVerticeNum()
		{
			return UUISpineRenderable.__GetTotalVerticeNum_Internal(base.NativePtr);
		}

		// Token: 0x06009EF5 RID: 40693 RVA: 0x000EC2CC File Offset: 0x000EA4CC
		public int GetMeshesNum()
		{
			return UUISpineRenderable.__GetMeshesNum_Internal(base.NativePtr);
		}

		// Token: 0x06009EF6 RID: 40694 RVA: 0x000EC2D9 File Offset: 0x000EA4D9
		[NullableContext(2)]
		public void AfterSkeletonUpdate(USpineSkeletonComponent SkeletonComponent)
		{
			UUISpineRenderable.__AfterSkeletonUpdate_Internal(base.NativePtr, (SkeletonComponent != null) ? SkeletonComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009EF7 RID: 40695 RVA: 0x000EC2F6 File Offset: 0x000EA4F6
		public void AdjustSize()
		{
			UUISpineRenderable.__AdjustSize_Internal(base.NativePtr);
		}

		// Token: 0x06009EF8 RID: 40696
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TestPlayPreviewAnimInRuntime_Internal(IntPtr @this);

		// Token: 0x06009EF9 RID: 40697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnSpineAnimationStart_Internal(IntPtr @this, IntPtr entry);

		// Token: 0x06009EFA RID: 40698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnSpineAnimationEnd_Internal(IntPtr @this, IntPtr entry);

		// Token: 0x06009EFB RID: 40699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetTotalVerticeNum_Internal(IntPtr @this);

		// Token: 0x06009EFC RID: 40700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMeshesNum_Internal(IntPtr @this);

		// Token: 0x06009EFD RID: 40701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AfterSkeletonUpdate_Internal(IntPtr @this, IntPtr SkeletonComponent);

		// Token: 0x06009EFE RID: 40702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AdjustSize_Internal(IntPtr @this);

		// Token: 0x06009EFF RID: 40703 RVA: 0x000EC303 File Offset: 0x000EA503
		static UUISpineRenderable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISpineRenderable");
		}

		// Token: 0x06009F00 RID: 40704 RVA: 0x000EC311 File Offset: 0x000EA511
		protected UUISpineRenderable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004428 RID: 17448
		public new const string __ObjectPath = "/Script/LGUI.UISpineRenderable";

		// Token: 0x04004429 RID: 17449
		private static IntPtr _ClassPtr;

		// Token: 0x0400442A RID: 17450
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400442B RID: 17451
		internal static int __PropertyOffset_DepthOffset;

		// Token: 0x0400442C RID: 17452
		internal static int __PropertyOffset_TextureParameterName;

		// Token: 0x0400442D RID: 17453
		internal static int __PropertyOffset_bAdjustSizeWithAnimation;

		// Token: 0x0400442E RID: 17454
		internal static int __PropertyOffset_bUseOptUpdateMeshSection;

		// Token: 0x0400442F RID: 17455
		internal static int __PropertyOffset_bIgnoreUpdateViewportClipSpine;

		// Token: 0x04004430 RID: 17456
		internal static int __PropertyOffset_bNeedParallelUpdate;

		// Token: 0x04004431 RID: 17457
		internal static int __PropertyOffset_AtlasNormalBlendMaterialArray;

		// Token: 0x04004432 RID: 17458
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _AtlasNormalBlendMaterialArray;

		// Token: 0x04004433 RID: 17459
		internal static int __PropertyOffset_AtlasAdditiveBlendMaterialArray;

		// Token: 0x04004434 RID: 17460
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _AtlasAdditiveBlendMaterialArray;

		// Token: 0x04004435 RID: 17461
		internal static int __PropertyOffset_AtlasMultiplyBlendMaterialArray;

		// Token: 0x04004436 RID: 17462
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _AtlasMultiplyBlendMaterialArray;

		// Token: 0x04004437 RID: 17463
		internal static int __PropertyOffset_AtlasScreenBlendMaterialArray;

		// Token: 0x04004438 RID: 17464
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _AtlasScreenBlendMaterialArray;

		// Token: 0x04004439 RID: 17465
		internal static int __PropertyOffset_CurrSkeletonData;
	}
}
