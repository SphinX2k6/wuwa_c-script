using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200066C RID: 1644
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class ULGUIBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008E4B RID: 36427 RVA: 0x000D622A File Offset: 0x000D442A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIBPLibrary._ClassPtr;
		}

		// Token: 0x06008E4C RID: 36428 RVA: 0x000D6238 File Offset: 0x000D4438
		public ULGUIBPLibrary() : this(BuiltinUtils.AllocNativeUObject(ULGUIBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008E4D RID: 36429 RVA: 0x000D6260 File Offset: 0x000D4460
		[NullableContext(1)]
		public ULGUIBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008E4E RID: 36430 RVA: 0x000D6293 File Offset: 0x000D4493
		public static ULTweener WidthTo(UUIItem target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__WidthTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x06008E4F RID: 36431 RVA: 0x000D62B4 File Offset: 0x000D44B4
		public static ULTweener UILocalPositionTo(UUIItem target, FVector endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__UILocalPositionTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x06008E50 RID: 36432
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void TryInitUIActorsMap();

		// Token: 0x06008E51 RID: 36433 RVA: 0x000D62D5 File Offset: 0x000D44D5
		public static ULTweener StretchTopTo(UUIItem target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__StretchTopTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x06008E52 RID: 36434 RVA: 0x000D62F6 File Offset: 0x000D44F6
		public static ULTweener StretchRightTo(UUIItem target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__StretchRightTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x06008E53 RID: 36435 RVA: 0x000D6317 File Offset: 0x000D4517
		public static ULTweener StretchLeftTo(UUIItem target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__StretchLeftTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x06008E54 RID: 36436 RVA: 0x000D6338 File Offset: 0x000D4538
		public static ULTweener StretchBottomTo(UUIItem target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__StretchBottomTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x06008E55 RID: 36437 RVA: 0x000D6359 File Offset: 0x000D4559
		public static void SortItemsWithFlattenHierarchyIndex([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UUIItem> Items, bool bUpSorted)
		{
			ULGUIBPLibrary.__SortItemsWithFlattenHierarchyIndex_Internal((Items ?? new TArray<UUIItem>()).NativePtr, bUpSorted);
		}

		// Token: 0x06008E56 RID: 36438 RVA: 0x000D6371 File Offset: 0x000D4571
		[NullableContext(1)]
		public static TArray<AActor> SortActorsWithDistance([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorList, [Nullable(2)] AController Controller)
		{
			return new TArray<AActor>(ULGUIBPLibrary.__SortActorsWithDistance_Internal((ActorList ?? new TArray<AActor>()).NativePtr, (Controller != null) ? Controller.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06008E57 RID: 36439 RVA: 0x000D639E File Offset: 0x000D459E
		public static ULGUIPointerEventData SimulationLineTraceOnCenterScreen(UObject WorldContext, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UUIItem> TraceOnlyItems)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(ULGUIBPLibrary.__SimulationLineTraceOnCenterScreen_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, (TraceOnlyItems ?? new TArray<UUIItem>()).NativePtr));
		}

		// Token: 0x06008E58 RID: 36440 RVA: 0x000D63CA File Offset: 0x000D45CA
		public static ULGUIPointerEventData SimulationLineTrace(in FVector2D Pos, UObject WorldContext, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UUIItem> TraceOnlyItems)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(ULGUIBPLibrary.__SimulationLineTrace_Internal(Pos, (WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, (TraceOnlyItems ?? new TArray<UUIItem>()).NativePtr));
		}

		// Token: 0x06008E59 RID: 36441 RVA: 0x000D63F7 File Offset: 0x000D45F7
		public void SetWorldUISceneRendering(bool Value)
		{
			ULGUIBPLibrary.__SetWorldUISceneRendering_Internal(base.NativePtr, Value);
		}

		// Token: 0x06008E5A RID: 36442 RVA: 0x000D6405 File Offset: 0x000D4605
		public static void SetUIRenderable(UUIItem UIItem, bool bNewRenderable)
		{
			ULGUIBPLibrary.__SetUIRenderable_Internal((UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bNewRenderable);
		}

		// Token: 0x06008E5B RID: 36443 RVA: 0x000D641D File Offset: 0x000D461D
		public static void SetUIHierarchyIndex(AActor Target, int index)
		{
			ULGUIBPLibrary.__SetUIHierarchyIndex_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, index);
		}

		// Token: 0x06008E5C RID: 36444 RVA: 0x000D6435 File Offset: 0x000D4635
		public static void SetUIAlpha(AActor Target, float InAlpha)
		{
			ULGUIBPLibrary.__SetUIAlpha_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, InAlpha);
		}

		// Token: 0x06008E5D RID: 36445 RVA: 0x000D644D File Offset: 0x000D464D
		public static void SetUIActive(AActor Target, bool Acitve)
		{
			ULGUIBPLibrary.__SetUIActive_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, Acitve);
		}

		// Token: 0x06008E5E RID: 36446 RVA: 0x000D6465 File Offset: 0x000D4665
		public static void SetRootActorMemoryTag(UUIItem UIItem, FName MemoryTag)
		{
			ULGUIBPLibrary.__SetRootActorMemoryTag_Internal((UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, MemoryTag);
		}

		// Token: 0x06008E5F RID: 36447 RVA: 0x000D647D File Offset: 0x000D467D
		public static void SetLGUIUISceneRendering(AActor Actor, bool IsUISceneRendering)
		{
			ULGUIBPLibrary.__SetLGUIUISceneRendering_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, IsUISceneRendering);
		}

		// Token: 0x06008E60 RID: 36448 RVA: 0x000D6495 File Offset: 0x000D4695
		public static void SetIsFullScreenUIRendering(UObject WorldContextObject, bool Value)
		{
			ULGUIBPLibrary.__SetIsFullScreenUIRendering_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Value);
		}

		// Token: 0x06008E61 RID: 36449 RVA: 0x000D64AD File Offset: 0x000D46AD
		public static void SetGlobalBlurUIItem(UUIItem UIItem, UWorld World)
		{
			ULGUIBPLibrary.__SetGlobalBlurUIItem_Internal((UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, (World != null) ? World.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008E62 RID: 36450 RVA: 0x000D64D4 File Offset: 0x000D46D4
		public static void SetAllTextFont(UObject WorldContext, ULGUIFontData_BaseObject FontData)
		{
			ULGUIBPLibrary.__SetAllTextFont_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, (FontData != null) ? FontData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008E63 RID: 36451 RVA: 0x000D64FB File Offset: 0x000D46FB
		public static void ResetGlobalBlurUIItem(UWorld World)
		{
			ULGUIBPLibrary.__ResetGlobalBlurUIItem_Internal((World != null) ? World.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008E64 RID: 36452 RVA: 0x000D6512 File Offset: 0x000D4712
		public static void RemoveInstanceComponent(AActor Actor, UActorComponent Component)
		{
			ULGUIBPLibrary.__RemoveInstanceComponent_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008E65 RID: 36453 RVA: 0x000D653C File Offset: 0x000D473C
		[NullableContext(1)]
		public unsafe static void PrintUIItemLog(string Content, [Nullable(2)] UUIItem UIItem, int LogDepth = 5)
		{
			FString fstring = FString.AllocTemp(Content);
			ULGUIBPLibrary.__PrintUIItemLog_Internal(fstring, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, LogDepth);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06008E66 RID: 36454 RVA: 0x000D6571 File Offset: 0x000D4771
		public static ULTweener PivotTo(UUIItem target, FVector2D endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__PivotTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x06008E67 RID: 36455 RVA: 0x000D6592 File Offset: 0x000D4792
		public static AActor LoadPrefabWithAsset(UObject WorldContextObject, UPrefabAsset PrefabAsset, USceneComponent InParent)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ULGUIBPLibrary.__LoadPrefabWithAsset_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (PrefabAsset != null) ? PrefabAsset.NativePtr : IntPtr.Zero, (InParent != null) ? InParent.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06008E68 RID: 36456 RVA: 0x000D65CE File Offset: 0x000D47CE
		public static void LGUIExecuteInputAxis(FKey inputKey, float value)
		{
			ULGUIBPLibrary.__LGUIExecuteInputAxis_Internal((inputKey ?? new FKey()).NativePtr, value);
		}

		// Token: 0x06008E69 RID: 36457 RVA: 0x000D65E5 File Offset: 0x000D47E5
		public static void LGUIExecuteInputAction(FKey inputKey, bool pressOrRelease)
		{
			ULGUIBPLibrary.__LGUIExecuteInputAction_Internal((inputKey ?? new FKey()).NativePtr, pressOrRelease);
		}

		// Token: 0x06008E6A RID: 36458 RVA: 0x000D65FC File Offset: 0x000D47FC
		public static void LGUIExecuteControllerInputAxis(FKey inputKey, float value)
		{
			ULGUIBPLibrary.__LGUIExecuteControllerInputAxis_Internal((inputKey ?? new FKey()).NativePtr, value);
		}

		// Token: 0x06008E6B RID: 36459 RVA: 0x000D6613 File Offset: 0x000D4813
		public static void LGUIExecuteControllerInputAction(FKey inputKey, bool pressOrRelease)
		{
			ULGUIBPLibrary.__LGUIExecuteControllerInputAction_Internal((inputKey ?? new FKey()).NativePtr, pressOrRelease);
		}

		// Token: 0x06008E6C RID: 36460
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsInAudioEditMode();

		// Token: 0x06008E6D RID: 36461 RVA: 0x000D662A File Offset: 0x000D482A
		public static ULTweener HeightTo(UUIItem target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__HeightTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x06008E6E RID: 36462 RVA: 0x000D664B File Offset: 0x000D484B
		public static bool GetWorldUISceneRendering(UObject WorldContextObject)
		{
			return ULGUIBPLibrary.__GetWorldUISceneRendering_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008E6F RID: 36463 RVA: 0x000D6662 File Offset: 0x000D4862
		public static FVector GetUIWorldPosForceUpdate(UUIItem UIItem)
		{
			return ULGUIBPLibrary.__GetUIWorldPosForceUpdate_Internal((UIItem != null) ? UIItem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008E70 RID: 36464 RVA: 0x000D667C File Offset: 0x000D487C
		public unsafe static UUIItem GetUIItemWithRelativePath(UUIItem ParentItem, [Nullable(1)] string RelativePath)
		{
			FString fstring = FString.AllocTemp(RelativePath);
			UUIItem orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(ULGUIBPLibrary.__GetUIItemWithRelativePath_Internal((ParentItem != null) ? ParentItem.NativePtr : IntPtr.Zero, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06008E71 RID: 36465 RVA: 0x000D66B8 File Offset: 0x000D48B8
		public unsafe static UUIItem GetUIItemWithPath(UObject WorldContextObject, [Nullable(1)] string FullItemPath)
		{
			FString fstring = FString.AllocTemp(FullItemPath);
			UUIItem orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(ULGUIBPLibrary.__GetUIItemWithPath_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06008E72 RID: 36466 RVA: 0x000D66F1 File Offset: 0x000D48F1
		public static FVector2D GetUIItemPositionInViewPort(UObject WorldContextObject, UUIItem Item, bool bIsScaledByBPI = false)
		{
			return ULGUIBPLibrary.__GetUIItemPositionInViewPort_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Item != null) ? Item.NativePtr : IntPtr.Zero, bIsScaledByBPI);
		}

		// Token: 0x06008E73 RID: 36467 RVA: 0x000D671C File Offset: 0x000D491C
		[NullableContext(1)]
		[return: Nullable(2)]
		public unsafe static UTexture2D GetTexture2DFromImage(string ImagePath, int ImageFormatValue)
		{
			FString fstring = FString.AllocTemp(ImagePath);
			UTexture2D orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(ULGUIBPLibrary.__GetTexture2DFromImage_Internal(fstring, ImageFormatValue));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06008E74 RID: 36468 RVA: 0x000D6748 File Offset: 0x000D4948
		[NullableContext(1)]
		public unsafe static long GetStringHashValue(string Str)
		{
			FString fstring = FString.AllocTemp(Str);
			long result = ULGUIBPLibrary.__GetStringHashValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06008E75 RID: 36469 RVA: 0x000D676C File Offset: 0x000D496C
		[NullableContext(1)]
		public static TArray<UUIItem> GetSortedItemsWithFlattenHierarchyIndex([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UUIItem> Items, bool bUpSorted)
		{
			return new TArray<UUIItem>(ULGUIBPLibrary.__GetSortedItemsWithFlattenHierarchyIndex_Internal((Items ?? new TArray<UUIItem>()).NativePtr, bUpSorted), null);
		}

		// Token: 0x06008E76 RID: 36470 RVA: 0x000D678A File Offset: 0x000D498A
		public static FName GetRootActorMemoryTag(UUIItem UIItem)
		{
			return ULGUIBPLibrary.__GetRootActorMemoryTag_Internal((UIItem != null) ? UIItem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008E77 RID: 36471 RVA: 0x000D67A1 File Offset: 0x000D49A1
		[return: Nullable(1)]
		public static string GetRelativePathWithRoot(UUIItem Target, UUIItem Root)
		{
			return FString.ToStringAndDeleteNativePtr(ULGUIBPLibrary.__GetRelativePathWithRoot_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, (Root != null) ? Root.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06008E78 RID: 36472 RVA: 0x000D67CD File Offset: 0x000D49CD
		public static UUIItem GetPrefabRoot(UUIItem InUiItem)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(ULGUIBPLibrary.__GetPrefabRoot_Internal((InUiItem != null) ? InUiItem.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06008E79 RID: 36473 RVA: 0x000D67EC File Offset: 0x000D49EC
		public unsafe static bool GetFullPathOfActor(UObject WorldContextObject, AActor Actor, [Nullable(1)] ref string PathString)
		{
			FString fstring = FString.AllocTemp(PathString);
			bool result = ULGUIBPLibrary.__GetFullPathOfActor_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, ref fstring);
			PathString = FString.ToString(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06008E7A RID: 36474 RVA: 0x000D683A File Offset: 0x000D4A3A
		public static UActorComponent GetCorrespondingEditorComponent(UActorComponent PIEComponent, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> ComponentClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(ULGUIBPLibrary.__GetCorrespondingEditorComponent_Internal((PIEComponent != null) ? PIEComponent.NativePtr : IntPtr.Zero, ComponentClass._NativePtr));
		}

		// Token: 0x06008E7B RID: 36475 RVA: 0x000D685C File Offset: 0x000D4A5C
		[NullableContext(1)]
		public static TArray<UActorComponent> GetComponentsInChildrenWithHirerarchyIndex([Nullable(2)] AUIBaseActor InActor, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> ComponentClass, bool IncludeSelf)
		{
			return new TArray<UActorComponent>(ULGUIBPLibrary.__GetComponentsInChildrenWithHirerarchyIndex_Internal((InActor != null) ? InActor.NativePtr : IntPtr.Zero, ComponentClass._NativePtr, IncludeSelf), null);
		}

		// Token: 0x06008E7C RID: 36476 RVA: 0x000D6880 File Offset: 0x000D4A80
		[NullableContext(1)]
		public static TArray<UActorComponent> GetComponentsInChildren([Nullable(2)] AActor InActor, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> ComponentClass, bool IncludeSelf)
		{
			return new TArray<UActorComponent>(ULGUIBPLibrary.__GetComponentsInChildren_Internal((InActor != null) ? InActor.NativePtr : IntPtr.Zero, ComponentClass._NativePtr, IncludeSelf), null);
		}

		// Token: 0x06008E7D RID: 36477 RVA: 0x000D68A4 File Offset: 0x000D4AA4
		public static UActorComponent GetComponentInParent(AActor InActor, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> ComponentClass, bool IncludeSelf = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(ULGUIBPLibrary.__GetComponentInParent_Internal((InActor != null) ? InActor.NativePtr : IntPtr.Zero, ComponentClass._NativePtr, IncludeSelf));
		}

		// Token: 0x06008E7E RID: 36478 RVA: 0x000D68C7 File Offset: 0x000D4AC7
		public static UActorComponent GetComponentInChildren(AActor InActor, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> ComponentClass, bool IncludeSelf)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(ULGUIBPLibrary.__GetComponentInChildren_Internal((InActor != null) ? InActor.NativePtr : IntPtr.Zero, ComponentClass._NativePtr, IncludeSelf));
		}

		// Token: 0x06008E7F RID: 36479 RVA: 0x000D68EA File Offset: 0x000D4AEA
		[NullableContext(1)]
		public static TArray<AActor> GetAllAttachChildrenOfActor([Nullable(2)] AActor Actor, bool bIncludeAllChildren = true)
		{
			return new TArray<AActor>(ULGUIBPLibrary.__GetAllAttachChildrenOfActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, bIncludeAllChildren), null);
		}

		// Token: 0x06008E80 RID: 36480
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FreeUnusedResourcesInRenderTargetPool();

		// Token: 0x06008E81 RID: 36481 RVA: 0x000D6908 File Offset: 0x000D4B08
		public static AActor DuplicateActor(AActor Target, USceneComponent Parent)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ULGUIBPLibrary.__DuplicateActor_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, (Parent != null) ? Parent.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06008E82 RID: 36482 RVA: 0x000D6934 File Offset: 0x000D4B34
		public static void DestroyActorWithHierarchy(AActor Target, bool WithHierarchy = true)
		{
			ULGUIBPLibrary.__DestroyActorWithHierarchy_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, WithHierarchy);
		}

		// Token: 0x06008E83 RID: 36483 RVA: 0x000D694C File Offset: 0x000D4B4C
		[NullableContext(1)]
		public unsafe static bool DeleteFile(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			bool result = ULGUIBPLibrary.__DeleteFile_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06008E84 RID: 36484 RVA: 0x000D6970 File Offset: 0x000D4B70
		public static void DeleteActor(AActor Target, bool WithHierarchy = true)
		{
			ULGUIBPLibrary.__DeleteActor_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, WithHierarchy);
		}

		// Token: 0x06008E85 RID: 36485 RVA: 0x000D6988 File Offset: 0x000D4B88
		public static UTexture2D CreateTextureFromScreenShot(bool bContainsUI = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(ULGUIBPLibrary.__CreateTextureFromScreenShot_Internal(bContainsUI));
		}

		// Token: 0x06008E86 RID: 36486 RVA: 0x000D6998 File Offset: 0x000D4B98
		[NullableContext(1)]
		[return: Nullable(2)]
		public unsafe static UTexture2D CreateTexture2DFromPath(string ImagePath, string TextureName, int ImageFormatValue)
		{
			FString fstring = FString.AllocTemp(ImagePath);
			FString fstring2 = FString.AllocTemp(TextureName);
			UTexture2D orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(ULGUIBPLibrary.__CreateTexture2DFromPath_Internal(fstring, fstring2, ImageFormatValue));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06008E87 RID: 36487 RVA: 0x000D69D4 File Offset: 0x000D4BD4
		public static UTexture2D CreateTexture2DFromColors(int Width, int Height, in TArray<FColor> Colors)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(ULGUIBPLibrary.__CreateTexture2DFromColors_Internal(Width, Height, (Colors ?? new TArray<FColor>()).NativePtr));
		}

		// Token: 0x06008E88 RID: 36488 RVA: 0x000D69F2 File Offset: 0x000D4BF2
		public static UTexture2D CreateTexture2DFromBuffer(int startPositionX, int endPositionX, int startPositionY, int endPositionY)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(ULGUIBPLibrary.__CreateTexture2DFromBuffer_Internal(startPositionX, endPositionX, startPositionY, endPositionY));
		}

		// Token: 0x06008E89 RID: 36489 RVA: 0x000D6A02 File Offset: 0x000D4C02
		public static void CopySequenceBindingFromParent(UUIItem Target, in FSoftObjectPath LevelSequencePath)
		{
			ULGUIBPLibrary.__CopySequenceBindingFromParent_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, (LevelSequencePath ?? new FSoftObjectPath()).NativePtr);
		}

		// Token: 0x06008E8A RID: 36490 RVA: 0x000D6A29 File Offset: 0x000D4C29
		public static FVector2D ConvertWorldPosToLGUIPos(APlayerController PlayerController, in FVectorDouble WorldPosition)
		{
			return ULGUIBPLibrary.__ConvertWorldPosToLGUIPos_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero, WorldPosition);
		}

		// Token: 0x06008E8B RID: 36491 RVA: 0x000D6A41 File Offset: 0x000D4C41
		public static ULTweener ColorTo(UUIItem target, FColor endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__ColorTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x06008E8C RID: 36492 RVA: 0x000D6A62 File Offset: 0x000D4C62
		public static ULTweener ColorFrom(UUIItem target, FColor startValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__ColorFrom_Internal((target != null) ? target.NativePtr : IntPtr.Zero, startValue, duration, delay, ease));
		}

		// Token: 0x06008E8D RID: 36493 RVA: 0x000D6A84 File Offset: 0x000D4C84
		[NullableContext(1)]
		public unsafe static void ClipBoardPaste(ref string Target)
		{
			FString fstring = FString.AllocTemp(Target);
			ULGUIBPLibrary.__ClipBoardPaste_Internal(ref fstring);
			Target = FString.ToString(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06008E8E RID: 36494 RVA: 0x000D6AB4 File Offset: 0x000D4CB4
		[NullableContext(1)]
		public unsafe static void ClipBoardCopy(string Str)
		{
			FString fstring = FString.AllocTemp(Str);
			ULGUIBPLibrary.__ClipBoardCopy_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06008E8F RID: 36495 RVA: 0x000D6AD8 File Offset: 0x000D4CD8
		public static void ClearInstanceComponents(AActor Actor, bool bDestroyComponents)
		{
			ULGUIBPLibrary.__ClearInstanceComponents_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, bDestroyComponents);
		}

		// Token: 0x06008E90 RID: 36496 RVA: 0x000D6AF0 File Offset: 0x000D4CF0
		[return: Nullable(1)]
		public static TArray<AActor> BatchDuplicateActors(AActor Src, int Num, USceneComponent Parent)
		{
			return new TArray<AActor>(ULGUIBPLibrary.__BatchDuplicateActors_Internal((Src != null) ? Src.NativePtr : IntPtr.Zero, Num, (Parent != null) ? Parent.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06008E91 RID: 36497 RVA: 0x000D6B1E File Offset: 0x000D4D1E
		public static ULTweener AnchorOffsetYTo(UUIItem target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__AnchorOffsetYTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x06008E92 RID: 36498 RVA: 0x000D6B3F File Offset: 0x000D4D3F
		public static ULTweener AnchorOffsetXTo(UUIItem target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__AnchorOffsetXTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x06008E93 RID: 36499 RVA: 0x000D6B60 File Offset: 0x000D4D60
		public static ULTweener AnchorOffsetTo(UUIItem target, FVector2D endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__AnchorOffsetTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x06008E94 RID: 36500 RVA: 0x000D6B81 File Offset: 0x000D4D81
		public static ULTweener AlphaTo(UUIItem target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__AlphaTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x06008E95 RID: 36501 RVA: 0x000D6BA2 File Offset: 0x000D4DA2
		public static ULTweener AlphaFrom(UUIItem target, float startValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__AlphaFrom_Internal((target != null) ? target.NativePtr : IntPtr.Zero, startValue, duration, delay, ease));
		}

		// Token: 0x06008E96 RID: 36502 RVA: 0x000D6BC3 File Offset: 0x000D4DC3
		public static void AddInstanceComponent(AActor Actor, UActorComponent Component)
		{
			ULGUIBPLibrary.__AddInstanceComponent_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008E97 RID: 36503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WidthTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x06008E98 RID: 36504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __UILocalPositionTo_Internal(IntPtr target, FVector endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x06008E99 RID: 36505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __StretchTopTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x06008E9A RID: 36506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __StretchRightTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x06008E9B RID: 36507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __StretchLeftTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x06008E9C RID: 36508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __StretchBottomTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x06008E9D RID: 36509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SortItemsWithFlattenHierarchyIndex_Internal(IntPtr Items, bool bUpSorted);

		// Token: 0x06008E9E RID: 36510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SortActorsWithDistance_Internal(IntPtr ActorList, IntPtr Controller);

		// Token: 0x06008E9F RID: 36511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SimulationLineTraceOnCenterScreen_Internal(IntPtr WorldContext, IntPtr TraceOnlyItems);

		// Token: 0x06008EA0 RID: 36512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SimulationLineTrace_Internal(in FVector2D Pos, IntPtr WorldContext, IntPtr TraceOnlyItems);

		// Token: 0x06008EA1 RID: 36513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldUISceneRendering_Internal(IntPtr @this, bool Value);

		// Token: 0x06008EA2 RID: 36514
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIRenderable_Internal(IntPtr UIItem, bool bNewRenderable);

		// Token: 0x06008EA3 RID: 36515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIHierarchyIndex_Internal(IntPtr Target, int index);

		// Token: 0x06008EA4 RID: 36516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIAlpha_Internal(IntPtr Target, float InAlpha);

		// Token: 0x06008EA5 RID: 36517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIActive_Internal(IntPtr Target, bool Acitve);

		// Token: 0x06008EA6 RID: 36518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRootActorMemoryTag_Internal(IntPtr UIItem, FName MemoryTag);

		// Token: 0x06008EA7 RID: 36519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUIUISceneRendering_Internal(IntPtr Actor, bool IsUISceneRendering);

		// Token: 0x06008EA8 RID: 36520
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsFullScreenUIRendering_Internal(IntPtr WorldContextObject, bool Value);

		// Token: 0x06008EA9 RID: 36521
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalBlurUIItem_Internal(IntPtr UIItem, IntPtr World);

		// Token: 0x06008EAA RID: 36522
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllTextFont_Internal(IntPtr WorldContext, IntPtr FontData);

		// Token: 0x06008EAB RID: 36523
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetGlobalBlurUIItem_Internal(IntPtr World);

		// Token: 0x06008EAC RID: 36524
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveInstanceComponent_Internal(IntPtr Actor, IntPtr Component);

		// Token: 0x06008EAD RID: 36525
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PrintUIItemLog_Internal(in FString Content, IntPtr UIItem, int LogDepth);

		// Token: 0x06008EAE RID: 36526
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PivotTo_Internal(IntPtr target, FVector2D endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x06008EAF RID: 36527
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadPrefabWithAsset_Internal(IntPtr WorldContextObject, IntPtr PrefabAsset, IntPtr InParent);

		// Token: 0x06008EB0 RID: 36528
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIExecuteInputAxis_Internal(IntPtr inputKey, float value);

		// Token: 0x06008EB1 RID: 36529
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIExecuteInputAction_Internal(IntPtr inputKey, bool pressOrRelease);

		// Token: 0x06008EB2 RID: 36530
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIExecuteControllerInputAxis_Internal(IntPtr inputKey, float value);

		// Token: 0x06008EB3 RID: 36531
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIExecuteControllerInputAction_Internal(IntPtr inputKey, bool pressOrRelease);

		// Token: 0x06008EB4 RID: 36532
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __HeightTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x06008EB5 RID: 36533
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWorldUISceneRendering_Internal(IntPtr WorldContextObject);

		// Token: 0x06008EB6 RID: 36534
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUIWorldPosForceUpdate_Internal(IntPtr UIItem);

		// Token: 0x06008EB7 RID: 36535
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetUIItemWithRelativePath_Internal(IntPtr ParentItem, in FString RelativePath);

		// Token: 0x06008EB8 RID: 36536
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetUIItemWithPath_Internal(IntPtr WorldContextObject, in FString FullItemPath);

		// Token: 0x06008EB9 RID: 36537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetUIItemPositionInViewPort_Internal(IntPtr WorldContextObject, IntPtr Item, bool bIsScaledByBPI);

		// Token: 0x06008EBA RID: 36538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTexture2DFromImage_Internal(in FString ImagePath, int ImageFormatValue);

		// Token: 0x06008EBB RID: 36539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long __GetStringHashValue_Internal(in FString Str);

		// Token: 0x06008EBC RID: 36540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSortedItemsWithFlattenHierarchyIndex_Internal(IntPtr Items, bool bUpSorted);

		// Token: 0x06008EBD RID: 36541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetRootActorMemoryTag_Internal(IntPtr UIItem);

		// Token: 0x06008EBE RID: 36542
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetRelativePathWithRoot_Internal(IntPtr Target, IntPtr Root);

		// Token: 0x06008EBF RID: 36543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPrefabRoot_Internal(IntPtr InUiItem);

		// Token: 0x06008EC0 RID: 36544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFullPathOfActor_Internal(IntPtr WorldContextObject, IntPtr Actor, ref FString PathString);

		// Token: 0x06008EC1 RID: 36545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCorrespondingEditorComponent_Internal(IntPtr PIEComponent, IntPtr ComponentClass);

		// Token: 0x06008EC2 RID: 36546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetComponentsInChildrenWithHirerarchyIndex_Internal(IntPtr InActor, IntPtr ComponentClass, bool IncludeSelf);

		// Token: 0x06008EC3 RID: 36547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetComponentsInChildren_Internal(IntPtr InActor, IntPtr ComponentClass, bool IncludeSelf);

		// Token: 0x06008EC4 RID: 36548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetComponentInParent_Internal(IntPtr InActor, IntPtr ComponentClass, bool IncludeSelf);

		// Token: 0x06008EC5 RID: 36549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetComponentInChildren_Internal(IntPtr InActor, IntPtr ComponentClass, bool IncludeSelf);

		// Token: 0x06008EC6 RID: 36550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllAttachChildrenOfActor_Internal(IntPtr Actor, bool bIncludeAllChildren);

		// Token: 0x06008EC7 RID: 36551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __DuplicateActor_Internal(IntPtr Target, IntPtr Parent);

		// Token: 0x06008EC8 RID: 36552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyActorWithHierarchy_Internal(IntPtr Target, bool WithHierarchy);

		// Token: 0x06008EC9 RID: 36553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DeleteFile_Internal(in FString Path);

		// Token: 0x06008ECA RID: 36554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeleteActor_Internal(IntPtr Target, bool WithHierarchy);

		// Token: 0x06008ECB RID: 36555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateTextureFromScreenShot_Internal(bool bContainsUI);

		// Token: 0x06008ECC RID: 36556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateTexture2DFromPath_Internal(in FString ImagePath, in FString TextureName, int ImageFormatValue);

		// Token: 0x06008ECD RID: 36557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateTexture2DFromColors_Internal(int Width, int Height, IntPtr Colors);

		// Token: 0x06008ECE RID: 36558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateTexture2DFromBuffer_Internal(int startPositionX, int endPositionX, int startPositionY, int endPositionY);

		// Token: 0x06008ECF RID: 36559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CopySequenceBindingFromParent_Internal(IntPtr Target, IntPtr LevelSequencePath);

		// Token: 0x06008ED0 RID: 36560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __ConvertWorldPosToLGUIPos_Internal(IntPtr PlayerController, in FVectorDouble WorldPosition);

		// Token: 0x06008ED1 RID: 36561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ColorTo_Internal(IntPtr target, FColor endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x06008ED2 RID: 36562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ColorFrom_Internal(IntPtr target, FColor startValue, float duration, float delay, LTweenEase ease);

		// Token: 0x06008ED3 RID: 36563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClipBoardPaste_Internal(ref FString Target);

		// Token: 0x06008ED4 RID: 36564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClipBoardCopy_Internal(in FString Str);

		// Token: 0x06008ED5 RID: 36565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearInstanceComponents_Internal(IntPtr Actor, bool bDestroyComponents);

		// Token: 0x06008ED6 RID: 36566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BatchDuplicateActors_Internal(IntPtr Src, int Num, IntPtr Parent);

		// Token: 0x06008ED7 RID: 36567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AnchorOffsetYTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x06008ED8 RID: 36568
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AnchorOffsetXTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x06008ED9 RID: 36569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AnchorOffsetTo_Internal(IntPtr target, FVector2D endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x06008EDA RID: 36570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AlphaTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x06008EDB RID: 36571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AlphaFrom_Internal(IntPtr target, float startValue, float duration, float delay, LTweenEase ease);

		// Token: 0x06008EDC RID: 36572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddInstanceComponent_Internal(IntPtr Actor, IntPtr Component);

		// Token: 0x06008EDD RID: 36573 RVA: 0x000D6BEA File Offset: 0x000D4DEA
		static ULGUIBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIBPLibrary");
		}

		// Token: 0x06008EDE RID: 36574 RVA: 0x000D6BF8 File Offset: 0x000D4DF8
		protected ULGUIBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003EA2 RID: 16034
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIBPLibrary";

		// Token: 0x04003EA3 RID: 16035
		private static IntPtr _ClassPtr;

		// Token: 0x04003EA4 RID: 16036
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
