using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000231 RID: 561
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LevelStreaming")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public abstract class ULevelStreaming : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002D59 RID: 11609 RVA: 0x00040147 File Offset: 0x0003E347
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelStreaming._ClassPtr;
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06002D5A RID: 11610 RVA: 0x00040153 File Offset: 0x0003E353
		// (set) Token: 0x06002D5B RID: 11611 RVA: 0x00040168 File Offset: 0x0003E368
		public TSoftObjectPtr<UWorld> WorldAsset
		{
			get
			{
				return new TSoftObjectPtr<UWorld>(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_WorldAsset, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_WorldAsset, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06002D5C RID: 11612 RVA: 0x0004018D File Offset: 0x0003E38D
		// (set) Token: 0x06002D5D RID: 11613 RVA: 0x0004019D File Offset: 0x0003E39D
		public unsafe int StreamingPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_StreamingPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_StreamingPriority) = value;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06002D5E RID: 11614 RVA: 0x000401AE File Offset: 0x0003E3AE
		// (set) Token: 0x06002D5F RID: 11615 RVA: 0x000401C2 File Offset: 0x0003E3C2
		public unsafe FName PackageNameToLoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_PackageNameToLoad);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_PackageNameToLoad) = value;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06002D60 RID: 11616 RVA: 0x000401D8 File Offset: 0x0003E3D8
		// (set) Token: 0x06002D61 RID: 11617 RVA: 0x00040211 File Offset: 0x0003E411
		public TArray<FName> LODPackageNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._LODPackageNames) == null)
				{
					result = (this._LODPackageNames = new TArray<FName>(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_LODPackageNames, this));
				}
				return result;
			}
			set
			{
				this.LODPackageNames.CopyAssign(value);
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06002D62 RID: 11618 RVA: 0x0004021F File Offset: 0x0003E41F
		// (set) Token: 0x06002D63 RID: 11619 RVA: 0x00040233 File Offset: 0x0003E433
		public unsafe FTransform LevelTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_LevelTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_LevelTransform) = value;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06002D64 RID: 11620 RVA: 0x00040248 File Offset: 0x0003E448
		// (set) Token: 0x06002D65 RID: 11621 RVA: 0x00040258 File Offset: 0x0003E458
		public unsafe bool bClientOnlyVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bClientOnlyVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bClientOnlyVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06002D66 RID: 11622 RVA: 0x00040269 File Offset: 0x0003E469
		// (set) Token: 0x06002D67 RID: 11623 RVA: 0x00040279 File Offset: 0x0003E479
		public unsafe int LevelLODIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_LevelLODIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_LevelLODIndex) = value;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06002D68 RID: 11624 RVA: 0x0004028A File Offset: 0x0003E48A
		// (set) Token: 0x06002D69 RID: 11625 RVA: 0x000402A3 File Offset: 0x0003E4A3
		public unsafe bool bShouldBeVisible
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBeVisible) & ULevelStreaming.__PropertyMask_bShouldBeVisible) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBeVisible) = ((*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBeVisible) & ~ULevelStreaming.__PropertyMask_bShouldBeVisible) | (value ? ULevelStreaming.__PropertyMask_bShouldBeVisible : 0));
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06002D6A RID: 11626 RVA: 0x000402D3 File Offset: 0x0003E4D3
		// (set) Token: 0x06002D6B RID: 11627 RVA: 0x000402EC File Offset: 0x0003E4EC
		public unsafe bool bShouldBeLoaded
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBeLoaded) & ULevelStreaming.__PropertyMask_bShouldBeLoaded) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBeLoaded) = ((*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBeLoaded) & ~ULevelStreaming.__PropertyMask_bShouldBeLoaded) | (value ? ULevelStreaming.__PropertyMask_bShouldBeLoaded : 0));
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06002D6C RID: 11628 RVA: 0x0004031C File Offset: 0x0003E51C
		// (set) Token: 0x06002D6D RID: 11629 RVA: 0x00040335 File Offset: 0x0003E535
		public unsafe bool bLocked
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bLocked) & ULevelStreaming.__PropertyMask_bLocked) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bLocked) = ((*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bLocked) & ~ULevelStreaming.__PropertyMask_bLocked) | (value ? ULevelStreaming.__PropertyMask_bLocked : 0));
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06002D6E RID: 11630 RVA: 0x00040365 File Offset: 0x0003E565
		// (set) Token: 0x06002D6F RID: 11631 RVA: 0x0004037E File Offset: 0x0003E57E
		public unsafe bool bIsStatic
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bIsStatic) & ULevelStreaming.__PropertyMask_bIsStatic) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bIsStatic) = ((*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bIsStatic) & ~ULevelStreaming.__PropertyMask_bIsStatic) | (value ? ULevelStreaming.__PropertyMask_bIsStatic : 0));
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06002D70 RID: 11632 RVA: 0x000403AE File Offset: 0x0003E5AE
		// (set) Token: 0x06002D71 RID: 11633 RVA: 0x000403C7 File Offset: 0x0003E5C7
		public unsafe bool bShouldBlockOnLoad
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBlockOnLoad) & ULevelStreaming.__PropertyMask_bShouldBlockOnLoad) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBlockOnLoad) = ((*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBlockOnLoad) & ~ULevelStreaming.__PropertyMask_bShouldBlockOnLoad) | (value ? ULevelStreaming.__PropertyMask_bShouldBlockOnLoad : 0));
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06002D72 RID: 11634 RVA: 0x000403F7 File Offset: 0x0003E5F7
		// (set) Token: 0x06002D73 RID: 11635 RVA: 0x00040410 File Offset: 0x0003E610
		public unsafe bool bShouldBlockOnUnload
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBlockOnUnload) & ULevelStreaming.__PropertyMask_bShouldBlockOnUnload) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBlockOnUnload) = ((*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bShouldBlockOnUnload) & ~ULevelStreaming.__PropertyMask_bShouldBlockOnUnload) | (value ? ULevelStreaming.__PropertyMask_bShouldBlockOnUnload : 0));
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06002D74 RID: 11636 RVA: 0x00040440 File Offset: 0x0003E640
		// (set) Token: 0x06002D75 RID: 11637 RVA: 0x00040459 File Offset: 0x0003E659
		public unsafe bool bDisableDistanceStreaming
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bDisableDistanceStreaming) & ULevelStreaming.__PropertyMask_bDisableDistanceStreaming) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bDisableDistanceStreaming) = ((*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bDisableDistanceStreaming) & ~ULevelStreaming.__PropertyMask_bDisableDistanceStreaming) | (value ? ULevelStreaming.__PropertyMask_bDisableDistanceStreaming : 0));
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06002D76 RID: 11638 RVA: 0x00040489 File Offset: 0x0003E689
		// (set) Token: 0x06002D77 RID: 11639 RVA: 0x000404A2 File Offset: 0x0003E6A2
		public unsafe bool bDrawOnLevelStatusMap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bDrawOnLevelStatusMap) & ULevelStreaming.__PropertyMask_bDrawOnLevelStatusMap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bDrawOnLevelStatusMap) = ((*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_bDrawOnLevelStatusMap) & ~ULevelStreaming.__PropertyMask_bDrawOnLevelStatusMap) | (value ? ULevelStreaming.__PropertyMask_bDrawOnLevelStatusMap : 0));
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06002D78 RID: 11640 RVA: 0x000404D2 File Offset: 0x0003E6D2
		// (set) Token: 0x06002D79 RID: 11641 RVA: 0x000404E6 File Offset: 0x0003E6E6
		public unsafe FLinearColor LevelColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_LevelColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_LevelColor) = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06002D7A RID: 11642 RVA: 0x000404FB File Offset: 0x0003E6FB
		// (set) Token: 0x06002D7B RID: 11643 RVA: 0x0004050B File Offset: 0x0003E70B
		public unsafe float MinTimeBetweenVolumeUnloadRequests
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_MinTimeBetweenVolumeUnloadRequests);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_MinTimeBetweenVolumeUnloadRequests) = value;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06002D7C RID: 11644 RVA: 0x0004051C File Offset: 0x0003E71C
		// (set) Token: 0x06002D7D RID: 11645 RVA: 0x00040555 File Offset: 0x0003E755
		public FLevelStreamingLoadedStatus OnLevelLoaded
		{
			get
			{
				base.FastCheckIsValid();
				FLevelStreamingLoadedStatus result;
				if ((result = this._OnLevelLoaded) == null)
				{
					result = (this._OnLevelLoaded = new FLevelStreamingLoadedStatus(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_OnLevelLoaded, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_OnLevelLoaded, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06002D7E RID: 11646 RVA: 0x00040578 File Offset: 0x0003E778
		// (set) Token: 0x06002D7F RID: 11647 RVA: 0x000405B1 File Offset: 0x0003E7B1
		public FLevelStreamingLoadedStatus OnLevelUnloaded
		{
			get
			{
				base.FastCheckIsValid();
				FLevelStreamingLoadedStatus result;
				if ((result = this._OnLevelUnloaded) == null)
				{
					result = (this._OnLevelUnloaded = new FLevelStreamingLoadedStatus(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_OnLevelUnloaded, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_OnLevelUnloaded, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06002D80 RID: 11648 RVA: 0x000405D4 File Offset: 0x0003E7D4
		// (set) Token: 0x06002D81 RID: 11649 RVA: 0x0004060D File Offset: 0x0003E80D
		public FLevelStreamingVisibilityStatus OnLevelShown
		{
			get
			{
				base.FastCheckIsValid();
				FLevelStreamingVisibilityStatus result;
				if ((result = this._OnLevelShown) == null)
				{
					result = (this._OnLevelShown = new FLevelStreamingVisibilityStatus(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_OnLevelShown, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_OnLevelShown, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06002D82 RID: 11650 RVA: 0x00040630 File Offset: 0x0003E830
		// (set) Token: 0x06002D83 RID: 11651 RVA: 0x00040669 File Offset: 0x0003E869
		public FLevelStreamingVisibilityStatus OnLevelHidden
		{
			get
			{
				base.FastCheckIsValid();
				FLevelStreamingVisibilityStatus result;
				if ((result = this._OnLevelHidden) == null)
				{
					result = (this._OnLevelHidden = new FLevelStreamingVisibilityStatus(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_OnLevelHidden, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULevelStreaming.__PropertyOffset_OnLevelHidden, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06002D84 RID: 11652 RVA: 0x0004068A File Offset: 0x0003E88A
		// (set) Token: 0x06002D85 RID: 11653 RVA: 0x0004069E File Offset: 0x0003E89E
		[Nullable(2)]
		public unsafe ULevel LoadedLevel
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevel>(base.NativePtr / (IntPtr)sizeof(void*) + ULevelStreaming.__PropertyOffset_LoadedLevel);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevelStreaming.__PropertyOffset_LoadedLevel, value);
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06002D86 RID: 11654 RVA: 0x000406B3 File Offset: 0x0003E8B3
		// (set) Token: 0x06002D87 RID: 11655 RVA: 0x000406C7 File Offset: 0x0003E8C7
		[Nullable(2)]
		public unsafe ULevel PendingUnloadLevel
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevel>(base.NativePtr / (IntPtr)sizeof(void*) + ULevelStreaming.__PropertyOffset_PendingUnloadLevel);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULevelStreaming.__PropertyOffset_PendingUnloadLevel, value);
			}
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x000406DC File Offset: 0x0003E8DC
		public bool ShouldBeLoaded()
		{
			return ULevelStreaming.__ShouldBeLoaded_Internal(base.NativePtr);
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x000406E9 File Offset: 0x0003E8E9
		public void SetShouldBeVisible(bool bInShouldBeVisible)
		{
			ULevelStreaming.__SetShouldBeVisible_Internal(base.NativePtr, bInShouldBeVisible);
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x000406F7 File Offset: 0x0003E8F7
		public void SetShouldBeLoaded(bool bInShouldBeLoaded)
		{
			ULevelStreaming.__SetShouldBeLoaded_Internal(base.NativePtr, bInShouldBeLoaded);
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x00040705 File Offset: 0x0003E905
		public void SetPriority(int NewPriority)
		{
			ULevelStreaming.__SetPriority_Internal(base.NativePtr, NewPriority);
		}

		// Token: 0x06002D8C RID: 11660 RVA: 0x00040713 File Offset: 0x0003E913
		public void SetLevelLODIndex(int LODIndex)
		{
			ULevelStreaming.__SetLevelLODIndex_Internal(base.NativePtr, LODIndex);
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x00040721 File Offset: 0x0003E921
		public void SetIsRequestingUnloadAndRemoval(bool bInIsRequestingUnloadAndRemoval)
		{
			ULevelStreaming.__SetIsRequestingUnloadAndRemoval_Internal(base.NativePtr, bInIsRequestingUnloadAndRemoval);
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x0004072F File Offset: 0x0003E92F
		public bool IsStreamingStatePending()
		{
			return ULevelStreaming.__IsStreamingStatePending_Internal(base.NativePtr);
		}

		// Token: 0x06002D8F RID: 11663 RVA: 0x0004073C File Offset: 0x0003E93C
		public bool IsLevelVisible()
		{
			return ULevelStreaming.__IsLevelVisible_Internal(base.NativePtr);
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x00040749 File Offset: 0x0003E949
		public bool IsLevelLoaded()
		{
			return ULevelStreaming.__IsLevelLoaded_Internal(base.NativePtr);
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x00040756 File Offset: 0x0003E956
		public FName GetWorldAssetPackageFName()
		{
			return ULevelStreaming.__GetWorldAssetPackageFName_Internal(base.NativePtr);
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x00040763 File Offset: 0x0003E963
		[NullableContext(2)]
		public ULevel GetLoadedLevel()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevel>(ULevelStreaming.__GetLoadedLevel_Internal(base.NativePtr));
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x00040775 File Offset: 0x0003E975
		public bool GetIsRequestingUnloadAndRemoval()
		{
			return ULevelStreaming.__GetIsRequestingUnloadAndRemoval_Internal(base.NativePtr);
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x00040784 File Offset: 0x0003E984
		[return: Nullable(2)]
		public unsafe ULevelStreaming CreateInstance(string UniqueInstanceName)
		{
			FString fstring = FString.AllocTemp(UniqueInstanceName);
			ULevelStreaming orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelStreaming>(ULevelStreaming.__CreateInstance_Internal(base.NativePtr, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06002D95 RID: 11669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldBeLoaded_Internal(IntPtr @this);

		// Token: 0x06002D96 RID: 11670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShouldBeVisible_Internal(IntPtr @this, bool bInShouldBeVisible);

		// Token: 0x06002D97 RID: 11671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShouldBeLoaded_Internal(IntPtr @this, bool bInShouldBeLoaded);

		// Token: 0x06002D98 RID: 11672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPriority_Internal(IntPtr @this, int NewPriority);

		// Token: 0x06002D99 RID: 11673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLevelLODIndex_Internal(IntPtr @this, int LODIndex);

		// Token: 0x06002D9A RID: 11674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsRequestingUnloadAndRemoval_Internal(IntPtr @this, bool bInIsRequestingUnloadAndRemoval);

		// Token: 0x06002D9B RID: 11675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStreamingStatePending_Internal(IntPtr @this);

		// Token: 0x06002D9C RID: 11676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLevelVisible_Internal(IntPtr @this);

		// Token: 0x06002D9D RID: 11677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLevelLoaded_Internal(IntPtr @this);

		// Token: 0x06002D9E RID: 11678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetWorldAssetPackageFName_Internal(IntPtr @this);

		// Token: 0x06002D9F RID: 11679
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLoadedLevel_Internal(IntPtr @this);

		// Token: 0x06002DA0 RID: 11680
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsRequestingUnloadAndRemoval_Internal(IntPtr @this);

		// Token: 0x06002DA1 RID: 11681
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateInstance_Internal(IntPtr @this, in FString UniqueInstanceName);

		// Token: 0x06002DA2 RID: 11682 RVA: 0x000407B3 File Offset: 0x0003E9B3
		static ULevelStreaming()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelStreaming");
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x000407C4 File Offset: 0x0003E9C4
		protected ULevelStreaming() : this(BuiltinUtils.AllocNativeUObject(ULevelStreaming.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x000407EC File Offset: 0x0003E9EC
		protected ULevelStreaming(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E76 RID: 3702
		public new const string __ObjectPath = "/Script/Engine.LevelStreaming";

		// Token: 0x04000E77 RID: 3703
		private static IntPtr _ClassPtr;

		// Token: 0x04000E78 RID: 3704
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000E79 RID: 3705
		internal static int __PropertyOffset_WorldAsset;

		// Token: 0x04000E7A RID: 3706
		internal static int __PropertyOffset_StreamingPriority;

		// Token: 0x04000E7B RID: 3707
		internal static int __PropertyOffset_PackageNameToLoad;

		// Token: 0x04000E7C RID: 3708
		internal static int __PropertyOffset_LODPackageNames;

		// Token: 0x04000E7D RID: 3709
		[Nullable(2)]
		private TArray<FName> _LODPackageNames;

		// Token: 0x04000E7E RID: 3710
		internal static int __PropertyOffset_LevelTransform;

		// Token: 0x04000E7F RID: 3711
		internal static int __PropertyOffset_bClientOnlyVisible;

		// Token: 0x04000E80 RID: 3712
		internal static int __PropertyOffset_LevelLODIndex;

		// Token: 0x04000E81 RID: 3713
		internal static int __PropertyOffset_bShouldBeVisible;

		// Token: 0x04000E82 RID: 3714
		internal static byte __PropertyMask_bShouldBeVisible;

		// Token: 0x04000E83 RID: 3715
		internal static int __PropertyOffset_bShouldBeLoaded;

		// Token: 0x04000E84 RID: 3716
		internal static byte __PropertyMask_bShouldBeLoaded;

		// Token: 0x04000E85 RID: 3717
		internal static int __PropertyOffset_bLocked;

		// Token: 0x04000E86 RID: 3718
		internal static byte __PropertyMask_bLocked;

		// Token: 0x04000E87 RID: 3719
		internal static int __PropertyOffset_bIsStatic;

		// Token: 0x04000E88 RID: 3720
		internal static byte __PropertyMask_bIsStatic;

		// Token: 0x04000E89 RID: 3721
		internal static int __PropertyOffset_bShouldBlockOnLoad;

		// Token: 0x04000E8A RID: 3722
		internal static byte __PropertyMask_bShouldBlockOnLoad;

		// Token: 0x04000E8B RID: 3723
		internal static int __PropertyOffset_bShouldBlockOnUnload;

		// Token: 0x04000E8C RID: 3724
		internal static byte __PropertyMask_bShouldBlockOnUnload;

		// Token: 0x04000E8D RID: 3725
		internal static int __PropertyOffset_bDisableDistanceStreaming;

		// Token: 0x04000E8E RID: 3726
		internal static byte __PropertyMask_bDisableDistanceStreaming;

		// Token: 0x04000E8F RID: 3727
		internal static int __PropertyOffset_bDrawOnLevelStatusMap;

		// Token: 0x04000E90 RID: 3728
		internal static byte __PropertyMask_bDrawOnLevelStatusMap;

		// Token: 0x04000E91 RID: 3729
		internal static int __PropertyOffset_LevelColor;

		// Token: 0x04000E92 RID: 3730
		internal static int __PropertyOffset_MinTimeBetweenVolumeUnloadRequests;

		// Token: 0x04000E93 RID: 3731
		internal static int __PropertyOffset_OnLevelLoaded;

		// Token: 0x04000E94 RID: 3732
		[Nullable(2)]
		private FLevelStreamingLoadedStatus _OnLevelLoaded;

		// Token: 0x04000E95 RID: 3733
		internal static int __PropertyOffset_OnLevelUnloaded;

		// Token: 0x04000E96 RID: 3734
		[Nullable(2)]
		private FLevelStreamingLoadedStatus _OnLevelUnloaded;

		// Token: 0x04000E97 RID: 3735
		internal static int __PropertyOffset_OnLevelShown;

		// Token: 0x04000E98 RID: 3736
		[Nullable(2)]
		private FLevelStreamingVisibilityStatus _OnLevelShown;

		// Token: 0x04000E99 RID: 3737
		internal static int __PropertyOffset_OnLevelHidden;

		// Token: 0x04000E9A RID: 3738
		[Nullable(2)]
		private FLevelStreamingVisibilityStatus _OnLevelHidden;

		// Token: 0x04000E9B RID: 3739
		internal static int __PropertyOffset_LoadedLevel;

		// Token: 0x04000E9C RID: 3740
		internal static int __PropertyOffset_PendingUnloadLevel;
	}
}
