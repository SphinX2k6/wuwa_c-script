using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002028 RID: 8232
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class ULGUIBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F049 RID: 127049 RVA: 0x002E1CCE File Offset: 0x002DFECE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIBPLibrary._ClassPtr;
		}

		// Token: 0x0601F04A RID: 127050 RVA: 0x002E1CDC File Offset: 0x002DFEDC
		public ULGUIBPLibrary() : this(BuiltinUtils.AllocNativeUObject(ULGUIBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F04B RID: 127051 RVA: 0x002E1D04 File Offset: 0x002DFF04
		[NullableContext(1)]
		public ULGUIBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601F04C RID: 127052 RVA: 0x002E1D37 File Offset: 0x002DFF37
		public static ULTweener WidthTo(UUIItem target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__WidthTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0601F04D RID: 127053 RVA: 0x002E1D58 File Offset: 0x002DFF58
		public static ULTweener UILocalPositionTo(UUIItem target, FVector endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__UILocalPositionTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0601F04E RID: 127054
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void TryInitUIActorsMap();

		// Token: 0x0601F04F RID: 127055 RVA: 0x002E1D79 File Offset: 0x002DFF79
		public static ULTweener StretchTopTo(UUIItem target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__StretchTopTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0601F050 RID: 127056 RVA: 0x002E1D9A File Offset: 0x002DFF9A
		public static ULTweener StretchRightTo(UUIItem target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__StretchRightTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0601F051 RID: 127057 RVA: 0x002E1DBB File Offset: 0x002DFFBB
		public static ULTweener StretchLeftTo(UUIItem target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__StretchLeftTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0601F052 RID: 127058 RVA: 0x002E1DDC File Offset: 0x002DFFDC
		public static ULTweener StretchBottomTo(UUIItem target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__StretchBottomTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0601F053 RID: 127059 RVA: 0x002E1DFD File Offset: 0x002DFFFD
		public static void SortItemsWithFlattenHierarchyIndex([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UUIItem> Items, bool bUpSorted)
		{
			ULGUIBPLibrary.__SortItemsWithFlattenHierarchyIndex_Internal((Items ?? new TArray<UUIItem>()).NativePtr, bUpSorted);
		}

		// Token: 0x0601F054 RID: 127060 RVA: 0x002E1E15 File Offset: 0x002E0015
		[NullableContext(1)]
		public static TArray<AActor> SortActorsWithDistance([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<AActor> ActorList, [Nullable(2)] AController Controller)
		{
			return new TArray<AActor>(ULGUIBPLibrary.__SortActorsWithDistance_Internal((ActorList ?? new TArray<AActor>()).NativePtr, (Controller != null) ? Controller.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0601F055 RID: 127061 RVA: 0x002E1E42 File Offset: 0x002E0042
		public static ULGUIPointerEventData SimulationLineTraceOnCenterScreen(UObject WorldContext, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UUIItem> TraceOnlyItems)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(ULGUIBPLibrary.__SimulationLineTraceOnCenterScreen_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, (TraceOnlyItems ?? new TArray<UUIItem>()).NativePtr));
		}

		// Token: 0x0601F056 RID: 127062 RVA: 0x002E1E6E File Offset: 0x002E006E
		public static ULGUIPointerEventData SimulationLineTrace(in FVector2D Pos, UObject WorldContext, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UUIItem> TraceOnlyItems)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUIPointerEventData>(ULGUIBPLibrary.__SimulationLineTrace_Internal(Pos, (WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, (TraceOnlyItems ?? new TArray<UUIItem>()).NativePtr));
		}

		// Token: 0x0601F057 RID: 127063 RVA: 0x002E1E9B File Offset: 0x002E009B
		public void SetWorldUISceneRendering(bool Value)
		{
			ULGUIBPLibrary.__SetWorldUISceneRendering_Internal(base.NativePtr, Value);
		}

		// Token: 0x0601F058 RID: 127064 RVA: 0x002E1EA9 File Offset: 0x002E00A9
		public static void SetUIRenderable(UUIItem UIItem, bool bNewRenderable)
		{
			ULGUIBPLibrary.__SetUIRenderable_Internal((UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bNewRenderable);
		}

		// Token: 0x0601F059 RID: 127065 RVA: 0x002E1EC1 File Offset: 0x002E00C1
		public static void SetUIHierarchyIndex(AActor Target, int index)
		{
			ULGUIBPLibrary.__SetUIHierarchyIndex_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, index);
		}

		// Token: 0x0601F05A RID: 127066 RVA: 0x002E1ED9 File Offset: 0x002E00D9
		public static void SetUIAlpha(AActor Target, float InAlpha)
		{
			ULGUIBPLibrary.__SetUIAlpha_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, InAlpha);
		}

		// Token: 0x0601F05B RID: 127067 RVA: 0x002E1EF1 File Offset: 0x002E00F1
		public static void SetUIActive(AActor Target, bool Acitve)
		{
			ULGUIBPLibrary.__SetUIActive_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, Acitve);
		}

		// Token: 0x0601F05C RID: 127068 RVA: 0x002E1F09 File Offset: 0x002E0109
		public static void SetRootActorMemoryTag(UUIItem UIItem, FName MemoryTag)
		{
			ULGUIBPLibrary.__SetRootActorMemoryTag_Internal((UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, MemoryTag);
		}

		// Token: 0x0601F05D RID: 127069 RVA: 0x002E1F21 File Offset: 0x002E0121
		public static void SetLGUIUISceneRendering(AActor Actor, bool IsUISceneRendering)
		{
			ULGUIBPLibrary.__SetLGUIUISceneRendering_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, IsUISceneRendering);
		}

		// Token: 0x0601F05E RID: 127070 RVA: 0x002E1F39 File Offset: 0x002E0139
		public static void SetIsFullScreenUIRendering(UObject WorldContextObject, bool Value)
		{
			ULGUIBPLibrary.__SetIsFullScreenUIRendering_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Value);
		}

		// Token: 0x0601F05F RID: 127071 RVA: 0x002E1F51 File Offset: 0x002E0151
		public static void SetGlobalBlurUIItem(UUIItem UIItem, UWorld World)
		{
			ULGUIBPLibrary.__SetGlobalBlurUIItem_Internal((UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, (World != null) ? World.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F060 RID: 127072 RVA: 0x002E1F78 File Offset: 0x002E0178
		public static void SetAllTextFont(UObject WorldContext, ULGUIFontData_BaseObject FontData)
		{
			ULGUIBPLibrary.__SetAllTextFont_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, (FontData != null) ? FontData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F061 RID: 127073 RVA: 0x002E1F9F File Offset: 0x002E019F
		public static void ResetGlobalBlurUIItem(UWorld World)
		{
			ULGUIBPLibrary.__ResetGlobalBlurUIItem_Internal((World != null) ? World.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F062 RID: 127074 RVA: 0x002E1FB6 File Offset: 0x002E01B6
		public static void RemoveInstanceComponent(AActor Actor, UActorComponent Component)
		{
			ULGUIBPLibrary.__RemoveInstanceComponent_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F063 RID: 127075 RVA: 0x002E1FE0 File Offset: 0x002E01E0
		[NullableContext(1)]
		public unsafe static void PrintUIItemLog(string Content, [Nullable(2)] UUIItem UIItem, int LogDepth = 5)
		{
			FString fstring = FString.AllocTemp(Content);
			ULGUIBPLibrary.__PrintUIItemLog_Internal(fstring, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, LogDepth);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601F064 RID: 127076 RVA: 0x002E2015 File Offset: 0x002E0215
		public static ULTweener PivotTo(UUIItem target, FVector2D endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__PivotTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0601F065 RID: 127077 RVA: 0x002E2036 File Offset: 0x002E0236
		public static AActor LoadPrefabWithAsset(UObject WorldContextObject, UPrefabAsset PrefabAsset, USceneComponent InParent)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ULGUIBPLibrary.__LoadPrefabWithAsset_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (PrefabAsset != null) ? PrefabAsset.NativePtr : IntPtr.Zero, (InParent != null) ? InParent.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601F066 RID: 127078 RVA: 0x002E2072 File Offset: 0x002E0272
		public static void LGUIExecuteInputAxis(FKey inputKey, float value)
		{
			ULGUIBPLibrary.__LGUIExecuteInputAxis_Internal((inputKey ?? new FKey()).NativePtr, value);
		}

		// Token: 0x0601F067 RID: 127079 RVA: 0x002E2089 File Offset: 0x002E0289
		public static void LGUIExecuteInputAction(FKey inputKey, bool pressOrRelease)
		{
			ULGUIBPLibrary.__LGUIExecuteInputAction_Internal((inputKey ?? new FKey()).NativePtr, pressOrRelease);
		}

		// Token: 0x0601F068 RID: 127080 RVA: 0x002E20A0 File Offset: 0x002E02A0
		public static void LGUIExecuteControllerInputAxis(FKey inputKey, float value)
		{
			ULGUIBPLibrary.__LGUIExecuteControllerInputAxis_Internal((inputKey ?? new FKey()).NativePtr, value);
		}

		// Token: 0x0601F069 RID: 127081 RVA: 0x002E20B7 File Offset: 0x002E02B7
		public static void LGUIExecuteControllerInputAction(FKey inputKey, bool pressOrRelease)
		{
			ULGUIBPLibrary.__LGUIExecuteControllerInputAction_Internal((inputKey ?? new FKey()).NativePtr, pressOrRelease);
		}

		// Token: 0x0601F06A RID: 127082 RVA: 0x002E20D0 File Offset: 0x002E02D0
		public unsafe static void LGUIDrawableEventExecuteVector4(in FLGUIDrawableEvent InEvent, in FVector4 InParameter)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InParameter;
			ULGUIBPLibrary.__LGUIDrawableEventExecuteVector4_Internal((InEvent ?? new FLGUIDrawableEvent()).NativePtr, ptr);
		}

		// Token: 0x0601F06B RID: 127083 RVA: 0x002E210F File Offset: 0x002E030F
		public static void LGUIDrawableEventExecuteVector3(in FLGUIDrawableEvent InEvent, in FVector InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEventExecuteVector3_Internal((InEvent ?? new FLGUIDrawableEvent()).NativePtr, InParameter);
		}

		// Token: 0x0601F06C RID: 127084 RVA: 0x002E2127 File Offset: 0x002E0327
		public static void LGUIDrawableEventExecuteVector2(in FLGUIDrawableEvent InEvent, in FVector2D InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEventExecuteVector2_Internal((InEvent ?? new FLGUIDrawableEvent()).NativePtr, InParameter);
		}

		// Token: 0x0601F06D RID: 127085 RVA: 0x002E2140 File Offset: 0x002E0340
		public unsafe static void LGUIDrawableEventExecuteUInt8(in FLGUIDrawableEvent InEvent, in byte InParameter)
		{
			fixed (byte* ptr = &InParameter)
			{
				void* ptr2 = (void*)ptr;
				ULGUIBPLibrary.__LGUIDrawableEventExecuteUInt8_Internal((InEvent ?? new FLGUIDrawableEvent()).NativePtr, InParameter);
			}
		}

		// Token: 0x0601F06E RID: 127086 RVA: 0x002E216C File Offset: 0x002E036C
		[NullableContext(1)]
		public unsafe static void LGUIDrawableEventExecuteString([Nullable(2)] in FLGUIDrawableEvent InEvent, string InParameter)
		{
			FString fstring = FString.AllocTemp(InParameter);
			ULGUIBPLibrary.__LGUIDrawableEventExecuteString_Internal((InEvent ?? new FLGUIDrawableEvent()).NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601F06F RID: 127087 RVA: 0x002E21A0 File Offset: 0x002E03A0
		public static void LGUIDrawableEventExecuteRotator(in FLGUIDrawableEvent InEvent, in FRotator InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEventExecuteRotator_Internal((InEvent ?? new FLGUIDrawableEvent()).NativePtr, InParameter);
		}

		// Token: 0x0601F070 RID: 127088 RVA: 0x002E21B8 File Offset: 0x002E03B8
		public unsafe static void LGUIDrawableEventExecuteQuaternion(in FLGUIDrawableEvent InEvent, in FQuat InParameter)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InParameter;
			ULGUIBPLibrary.__LGUIDrawableEventExecuteQuaternion_Internal((InEvent ?? new FLGUIDrawableEvent()).NativePtr, ptr);
		}

		// Token: 0x0601F071 RID: 127089 RVA: 0x002E21F7 File Offset: 0x002E03F7
		public static void LGUIDrawableEventExecutePointerEvent(in FLGUIDrawableEvent InEvent, ULGUIPointerEventData InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEventExecutePointerEvent_Internal((InEvent ?? new FLGUIDrawableEvent()).NativePtr, (InParameter != null) ? InParameter.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F072 RID: 127090 RVA: 0x002E221E File Offset: 0x002E041E
		public static void LGUIDrawableEventExecuteObject(in FLGUIDrawableEvent InEvent, UObject InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEventExecuteObject_Internal((InEvent ?? new FLGUIDrawableEvent()).NativePtr, (InParameter != null) ? InParameter.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F073 RID: 127091 RVA: 0x002E2245 File Offset: 0x002E0445
		public static void LGUIDrawableEventExecuteLinearColor(in FLGUIDrawableEvent InEvent, in FLinearColor InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEventExecuteLinearColor_Internal((InEvent ?? new FLGUIDrawableEvent()).NativePtr, InParameter);
		}

		// Token: 0x0601F074 RID: 127092 RVA: 0x002E2260 File Offset: 0x002E0460
		public unsafe static void LGUIDrawableEventExecuteInt32(in FLGUIDrawableEvent InEvent, in int InParameter)
		{
			fixed (int* ptr = &InParameter)
			{
				void* ptr2 = (void*)ptr;
				ULGUIBPLibrary.__LGUIDrawableEventExecuteInt32_Internal((InEvent ?? new FLGUIDrawableEvent()).NativePtr, InParameter);
			}
		}

		// Token: 0x0601F075 RID: 127093 RVA: 0x002E228C File Offset: 0x002E048C
		public unsafe static void LGUIDrawableEventExecuteFloat(in FLGUIDrawableEvent InEvent, in float InParameter)
		{
			fixed (float* ptr = &InParameter)
			{
				void* ptr2 = (void*)ptr;
				ULGUIBPLibrary.__LGUIDrawableEventExecuteFloat_Internal((InEvent ?? new FLGUIDrawableEvent()).NativePtr, InParameter);
			}
		}

		// Token: 0x0601F076 RID: 127094 RVA: 0x002E22B7 File Offset: 0x002E04B7
		public static void LGUIDrawableEventExecuteEmpty(in FLGUIDrawableEvent InEvent)
		{
			ULGUIBPLibrary.__LGUIDrawableEventExecuteEmpty_Internal((InEvent ?? new FLGUIDrawableEvent()).NativePtr);
		}

		// Token: 0x0601F077 RID: 127095 RVA: 0x002E22CE File Offset: 0x002E04CE
		public static void LGUIDrawableEventExecuteColor(in FLGUIDrawableEvent InEvent, in FColor InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEventExecuteColor_Internal((InEvent ?? new FLGUIDrawableEvent()).NativePtr, InParameter);
		}

		// Token: 0x0601F078 RID: 127096 RVA: 0x002E22E6 File Offset: 0x002E04E6
		public static void LGUIDrawableEventExecuteClass(in FLGUIDrawableEvent InEvent, UClassStackOnlyPtr InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEventExecuteClass_Internal((InEvent ?? new FLGUIDrawableEvent()).NativePtr, InParameter._NativePtr);
		}

		// Token: 0x0601F079 RID: 127097 RVA: 0x002E2304 File Offset: 0x002E0504
		public unsafe static void LGUIDrawableEventExecuteBool(in FLGUIDrawableEvent InEvent, in bool InParameter)
		{
			fixed (bool* ptr = &InParameter)
			{
				void* ptr2 = (void*)ptr;
				ULGUIBPLibrary.__LGUIDrawableEventExecuteBool_Internal((InEvent ?? new FLGUIDrawableEvent()).NativePtr, InParameter);
			}
		}

		// Token: 0x0601F07A RID: 127098 RVA: 0x002E232F File Offset: 0x002E052F
		public static void LGUIDrawableEventExecuteActor(in FLGUIDrawableEvent InEvent, AActor InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEventExecuteActor_Internal((InEvent ?? new FLGUIDrawableEvent()).NativePtr, (InParameter != null) ? InParameter.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F07B RID: 127099 RVA: 0x002E2356 File Offset: 0x002E0556
		public static void LGUIDrawableEvent_Vector4_Unregister(in FLGUIDrawableEvent_Vector4 InEvent, in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Vector4_Unregister_Internal((InEvent ?? new FLGUIDrawableEvent_Vector4()).NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F07C RID: 127100 RVA: 0x002E237D File Offset: 0x002E057D
		[return: Nullable(1)]
		public static FLGUIDelegateHandleWrapper LGUIDrawableEvent_Vector4_Register(in FLGUIDrawableEvent_Vector4 InEvent, FLGUIDrawableEvent_Vector4_DynamicDelegate InDelegate)
		{
			return new FLGUIDelegateHandleWrapper(ULGUIBPLibrary.__LGUIDrawableEvent_Vector4_Register_Internal((InEvent ?? new FLGUIDrawableEvent_Vector4()).NativePtr, (InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F07D RID: 127101 RVA: 0x002E23A8 File Offset: 0x002E05A8
		public unsafe static void LGUIDrawableEvent_Vector4_Execute(in FLGUIDrawableEvent_Vector4 InEvent, FVector4 InParameter)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InParameter;
			ULGUIBPLibrary.__LGUIDrawableEvent_Vector4_Execute_Internal((InEvent ?? new FLGUIDrawableEvent_Vector4()).NativePtr, ptr);
		}

		// Token: 0x0601F07E RID: 127102 RVA: 0x002E23E2 File Offset: 0x002E05E2
		public static void LGUIDrawableEvent_Vector3_Unregister(in FLGUIDrawableEvent_Vector3 InEvent, in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Vector3_Unregister_Internal((InEvent ?? new FLGUIDrawableEvent_Vector3()).NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F07F RID: 127103 RVA: 0x002E2409 File Offset: 0x002E0609
		[return: Nullable(1)]
		public static FLGUIDelegateHandleWrapper LGUIDrawableEvent_Vector3_Register(in FLGUIDrawableEvent_Vector3 InEvent, FLGUIDrawableEvent_Vector3_DynamicDelegate InDelegate)
		{
			return new FLGUIDelegateHandleWrapper(ULGUIBPLibrary.__LGUIDrawableEvent_Vector3_Register_Internal((InEvent ?? new FLGUIDrawableEvent_Vector3()).NativePtr, (InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F080 RID: 127104 RVA: 0x002E2433 File Offset: 0x002E0633
		public static void LGUIDrawableEvent_Vector3_Execute(in FLGUIDrawableEvent_Vector3 InEvent, FVector InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Vector3_Execute_Internal((InEvent ?? new FLGUIDrawableEvent_Vector3()).NativePtr, InParameter);
		}

		// Token: 0x0601F081 RID: 127105 RVA: 0x002E244B File Offset: 0x002E064B
		public static void LGUIDrawableEvent_Vector2_Unregister(in FLGUIDrawableEvent_Vector2 InEvent, in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Vector2_Unregister_Internal((InEvent ?? new FLGUIDrawableEvent_Vector2()).NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F082 RID: 127106 RVA: 0x002E2472 File Offset: 0x002E0672
		[return: Nullable(1)]
		public static FLGUIDelegateHandleWrapper LGUIDrawableEvent_Vector2_Register(in FLGUIDrawableEvent_Vector2 InEvent, FLGUIDrawableEvent_Vector2_DynamicDelegate InDelegate)
		{
			return new FLGUIDelegateHandleWrapper(ULGUIBPLibrary.__LGUIDrawableEvent_Vector2_Register_Internal((InEvent ?? new FLGUIDrawableEvent_Vector2()).NativePtr, (InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F083 RID: 127107 RVA: 0x002E249C File Offset: 0x002E069C
		public static void LGUIDrawableEvent_Vector2_Execute(in FLGUIDrawableEvent_Vector2 InEvent, FVector2D InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Vector2_Execute_Internal((InEvent ?? new FLGUIDrawableEvent_Vector2()).NativePtr, InParameter);
		}

		// Token: 0x0601F084 RID: 127108 RVA: 0x002E24B4 File Offset: 0x002E06B4
		public static void LGUIDrawableEvent_UInt8_Unregister(in FLGUIDrawableEvent_UInt8 InEvent, in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_UInt8_Unregister_Internal((InEvent ?? new FLGUIDrawableEvent_UInt8()).NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F085 RID: 127109 RVA: 0x002E24DB File Offset: 0x002E06DB
		[return: Nullable(1)]
		public static FLGUIDelegateHandleWrapper LGUIDrawableEvent_UInt8_Register(in FLGUIDrawableEvent_UInt8 InEvent, FLGUIDrawableEvent_UInt8_DynamicDelegate InDelegate)
		{
			return new FLGUIDelegateHandleWrapper(ULGUIBPLibrary.__LGUIDrawableEvent_UInt8_Register_Internal((InEvent ?? new FLGUIDrawableEvent_UInt8()).NativePtr, (InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F086 RID: 127110 RVA: 0x002E2505 File Offset: 0x002E0705
		public static void LGUIDrawableEvent_UInt8_Execute(in FLGUIDrawableEvent_UInt8 InEvent, byte InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_UInt8_Execute_Internal((InEvent ?? new FLGUIDrawableEvent_UInt8()).NativePtr, InParameter);
		}

		// Token: 0x0601F087 RID: 127111 RVA: 0x002E251D File Offset: 0x002E071D
		public static void LGUIDrawableEvent_String_Unregister(in FLGUIDrawableEvent_String InEvent, in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_String_Unregister_Internal((InEvent ?? new FLGUIDrawableEvent_String()).NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F088 RID: 127112 RVA: 0x002E2544 File Offset: 0x002E0744
		[return: Nullable(1)]
		public static FLGUIDelegateHandleWrapper LGUIDrawableEvent_String_Register(in FLGUIDrawableEvent_String InEvent, FLGUIDrawableEvent_String_DynamicDelegate InDelegate)
		{
			return new FLGUIDelegateHandleWrapper(ULGUIBPLibrary.__LGUIDrawableEvent_String_Register_Internal((InEvent ?? new FLGUIDrawableEvent_String()).NativePtr, (InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F089 RID: 127113 RVA: 0x002E2570 File Offset: 0x002E0770
		[NullableContext(1)]
		public unsafe static void LGUIDrawableEvent_String_Execute([Nullable(2)] in FLGUIDrawableEvent_String InEvent, string InParameter)
		{
			FString fstring = FString.AllocTemp(InParameter);
			ULGUIBPLibrary.__LGUIDrawableEvent_String_Execute_Internal((InEvent ?? new FLGUIDrawableEvent_String()).NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601F08A RID: 127114 RVA: 0x002E25A4 File Offset: 0x002E07A4
		public static void LGUIDrawableEvent_Rotator_Unregister(in FLGUIDrawableEvent_Rotator InEvent, in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Rotator_Unregister_Internal((InEvent ?? new FLGUIDrawableEvent_Rotator()).NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F08B RID: 127115 RVA: 0x002E25CB File Offset: 0x002E07CB
		[return: Nullable(1)]
		public static FLGUIDelegateHandleWrapper LGUIDrawableEvent_Rotator_Register(in FLGUIDrawableEvent_Rotator InEvent, FLGUIDrawableEvent_Rotator_DynamicDelegate InDelegate)
		{
			return new FLGUIDelegateHandleWrapper(ULGUIBPLibrary.__LGUIDrawableEvent_Rotator_Register_Internal((InEvent ?? new FLGUIDrawableEvent_Rotator()).NativePtr, (InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F08C RID: 127116 RVA: 0x002E25F5 File Offset: 0x002E07F5
		public static void LGUIDrawableEvent_Rotator_Execute(in FLGUIDrawableEvent_Rotator InEvent, FRotator InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Rotator_Execute_Internal((InEvent ?? new FLGUIDrawableEvent_Rotator()).NativePtr, InParameter);
		}

		// Token: 0x0601F08D RID: 127117 RVA: 0x002E260D File Offset: 0x002E080D
		public static void LGUIDrawableEvent_Quaternion_Unregister(in FLGUIDrawableEvent_Quaternion InEvent, in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Quaternion_Unregister_Internal((InEvent ?? new FLGUIDrawableEvent_Quaternion()).NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F08E RID: 127118 RVA: 0x002E2634 File Offset: 0x002E0834
		[return: Nullable(1)]
		public static FLGUIDelegateHandleWrapper LGUIDrawableEvent_Quaternion_Register(in FLGUIDrawableEvent_Quaternion InEvent, FLGUIDrawableEvent_Quaternion_DynamicDelegate InDelegate)
		{
			return new FLGUIDelegateHandleWrapper(ULGUIBPLibrary.__LGUIDrawableEvent_Quaternion_Register_Internal((InEvent ?? new FLGUIDrawableEvent_Quaternion()).NativePtr, (InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F08F RID: 127119 RVA: 0x002E2660 File Offset: 0x002E0860
		public unsafe static void LGUIDrawableEvent_Quaternion_Execute(in FLGUIDrawableEvent_Quaternion InEvent, FQuat InParameter)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InParameter;
			ULGUIBPLibrary.__LGUIDrawableEvent_Quaternion_Execute_Internal((InEvent ?? new FLGUIDrawableEvent_Quaternion()).NativePtr, ptr);
		}

		// Token: 0x0601F090 RID: 127120 RVA: 0x002E269A File Offset: 0x002E089A
		public static void LGUIDrawableEvent_PointerEvent_Unregister(in FLGUIDrawableEvent_PointerEvent InEvent, in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_PointerEvent_Unregister_Internal((InEvent ?? new FLGUIDrawableEvent_PointerEvent()).NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F091 RID: 127121 RVA: 0x002E26C1 File Offset: 0x002E08C1
		[return: Nullable(1)]
		public static FLGUIDelegateHandleWrapper LGUIDrawableEvent_PointerEvent_Register(in FLGUIDrawableEvent_PointerEvent InEvent, FLGUIDrawableEvent_PointerEvent_DynamicDelegate InDelegate)
		{
			return new FLGUIDelegateHandleWrapper(ULGUIBPLibrary.__LGUIDrawableEvent_PointerEvent_Register_Internal((InEvent ?? new FLGUIDrawableEvent_PointerEvent()).NativePtr, (InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F092 RID: 127122 RVA: 0x002E26EB File Offset: 0x002E08EB
		public static void LGUIDrawableEvent_PointerEvent_Execute(in FLGUIDrawableEvent_PointerEvent InEvent, ULGUIPointerEventData InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_PointerEvent_Execute_Internal((InEvent ?? new FLGUIDrawableEvent_PointerEvent()).NativePtr, (InParameter != null) ? InParameter.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F093 RID: 127123 RVA: 0x002E2712 File Offset: 0x002E0912
		public static void LGUIDrawableEvent_Object_Unregister(in FLGUIDrawableEvent_Object InEvent, in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Object_Unregister_Internal((InEvent ?? new FLGUIDrawableEvent_Object()).NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F094 RID: 127124 RVA: 0x002E2739 File Offset: 0x002E0939
		[return: Nullable(1)]
		public static FLGUIDelegateHandleWrapper LGUIDrawableEvent_Object_Register(in FLGUIDrawableEvent_Object InEvent, FLGUIDrawableEvent_Object_DynamicDelegate InDelegate)
		{
			return new FLGUIDelegateHandleWrapper(ULGUIBPLibrary.__LGUIDrawableEvent_Object_Register_Internal((InEvent ?? new FLGUIDrawableEvent_Object()).NativePtr, (InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F095 RID: 127125 RVA: 0x002E2763 File Offset: 0x002E0963
		public static void LGUIDrawableEvent_Object_Execute(in FLGUIDrawableEvent_Object InEvent, UObject InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Object_Execute_Internal((InEvent ?? new FLGUIDrawableEvent_Object()).NativePtr, (InParameter != null) ? InParameter.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F096 RID: 127126 RVA: 0x002E278A File Offset: 0x002E098A
		public static void LGUIDrawableEvent_LinearColor_Unregister(in FLGUIDrawableEvent_LinearColor InEvent, in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_LinearColor_Unregister_Internal((InEvent ?? new FLGUIDrawableEvent_LinearColor()).NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F097 RID: 127127 RVA: 0x002E27B1 File Offset: 0x002E09B1
		[return: Nullable(1)]
		public static FLGUIDelegateHandleWrapper LGUIDrawableEvent_LinearColor_Register(in FLGUIDrawableEvent_LinearColor InEvent, FLGUIDrawableEvent_LinearColor_DynamicDelegate InDelegate)
		{
			return new FLGUIDelegateHandleWrapper(ULGUIBPLibrary.__LGUIDrawableEvent_LinearColor_Register_Internal((InEvent ?? new FLGUIDrawableEvent_LinearColor()).NativePtr, (InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F098 RID: 127128 RVA: 0x002E27DB File Offset: 0x002E09DB
		public static void LGUIDrawableEvent_LinearColor_Execute(in FLGUIDrawableEvent_LinearColor InEvent, FLinearColor InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_LinearColor_Execute_Internal((InEvent ?? new FLGUIDrawableEvent_LinearColor()).NativePtr, InParameter);
		}

		// Token: 0x0601F099 RID: 127129 RVA: 0x002E27F3 File Offset: 0x002E09F3
		public static void LGUIDrawableEvent_Int64_Unregister(in FLGUIDrawableEvent_Int64 InEvent, in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Int64_Unregister_Internal((InEvent ?? new FLGUIDrawableEvent_Int64()).NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F09A RID: 127130 RVA: 0x002E281A File Offset: 0x002E0A1A
		[return: Nullable(1)]
		public static FLGUIDelegateHandleWrapper LGUIDrawableEvent_Int64_Register(in FLGUIDrawableEvent_Int64 InEvent, FLGUIDrawableEvent_Int64_DynamicDelegate InDelegate)
		{
			return new FLGUIDelegateHandleWrapper(ULGUIBPLibrary.__LGUIDrawableEvent_Int64_Register_Internal((InEvent ?? new FLGUIDrawableEvent_Int64()).NativePtr, (InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F09B RID: 127131 RVA: 0x002E2844 File Offset: 0x002E0A44
		public static void LGUIDrawableEvent_Int64_Execute(in FLGUIDrawableEvent_Int64 InEvent, long InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Int64_Execute_Internal((InEvent ?? new FLGUIDrawableEvent_Int64()).NativePtr, InParameter);
		}

		// Token: 0x0601F09C RID: 127132 RVA: 0x002E285C File Offset: 0x002E0A5C
		public static void LGUIDrawableEvent_Int32_Unregister(in FLGUIDrawableEvent_Int32 InEvent, in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Int32_Unregister_Internal((InEvent ?? new FLGUIDrawableEvent_Int32()).NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F09D RID: 127133 RVA: 0x002E2883 File Offset: 0x002E0A83
		[return: Nullable(1)]
		public static FLGUIDelegateHandleWrapper LGUIDrawableEvent_Int32_Register(in FLGUIDrawableEvent_Int32 InEvent, FLGUIDrawableEvent_Int32_DynamicDelegate InDelegate)
		{
			return new FLGUIDelegateHandleWrapper(ULGUIBPLibrary.__LGUIDrawableEvent_Int32_Register_Internal((InEvent ?? new FLGUIDrawableEvent_Int32()).NativePtr, (InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F09E RID: 127134 RVA: 0x002E28AD File Offset: 0x002E0AAD
		public static void LGUIDrawableEvent_Int32_Execute(in FLGUIDrawableEvent_Int32 InEvent, int InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Int32_Execute_Internal((InEvent ?? new FLGUIDrawableEvent_Int32()).NativePtr, InParameter);
		}

		// Token: 0x0601F09F RID: 127135 RVA: 0x002E28C5 File Offset: 0x002E0AC5
		public static void LGUIDrawableEvent_Float_Unregister(in FLGUIDrawableEvent_Float InEvent, in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Float_Unregister_Internal((InEvent ?? new FLGUIDrawableEvent_Float()).NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F0A0 RID: 127136 RVA: 0x002E28EC File Offset: 0x002E0AEC
		[return: Nullable(1)]
		public static FLGUIDelegateHandleWrapper LGUIDrawableEvent_Float_Register(in FLGUIDrawableEvent_Float InEvent, FLGUIDrawableEvent_Float_DynamicDelegate InDelegate)
		{
			return new FLGUIDelegateHandleWrapper(ULGUIBPLibrary.__LGUIDrawableEvent_Float_Register_Internal((InEvent ?? new FLGUIDrawableEvent_Float()).NativePtr, (InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F0A1 RID: 127137 RVA: 0x002E2916 File Offset: 0x002E0B16
		public static void LGUIDrawableEvent_Float_Execute(in FLGUIDrawableEvent_Float InEvent, float InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Float_Execute_Internal((InEvent ?? new FLGUIDrawableEvent_Float()).NativePtr, InParameter);
		}

		// Token: 0x0601F0A2 RID: 127138 RVA: 0x002E292E File Offset: 0x002E0B2E
		public static void LGUIDrawableEvent_Empty_Unregister(in FLGUIDrawableEvent_Empty InEvent, in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Empty_Unregister_Internal((InEvent ?? new FLGUIDrawableEvent_Empty()).NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F0A3 RID: 127139 RVA: 0x002E2955 File Offset: 0x002E0B55
		[return: Nullable(1)]
		public static FLGUIDelegateHandleWrapper LGUIDrawableEvent_Empty_Register(in FLGUIDrawableEvent_Empty InEvent, FLGUIDrawableEvent_Empty_DynamicDelegate InDelegate)
		{
			return new FLGUIDelegateHandleWrapper(ULGUIBPLibrary.__LGUIDrawableEvent_Empty_Register_Internal((InEvent ?? new FLGUIDrawableEvent_Empty()).NativePtr, (InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F0A4 RID: 127140 RVA: 0x002E297F File Offset: 0x002E0B7F
		public static void LGUIDrawableEvent_Empty_Execute(in FLGUIDrawableEvent_Empty InEvent)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Empty_Execute_Internal((InEvent ?? new FLGUIDrawableEvent_Empty()).NativePtr);
		}

		// Token: 0x0601F0A5 RID: 127141 RVA: 0x002E2996 File Offset: 0x002E0B96
		public static void LGUIDrawableEvent_Color_Unregister(in FLGUIDrawableEvent_Color InEvent, in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Color_Unregister_Internal((InEvent ?? new FLGUIDrawableEvent_Color()).NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F0A6 RID: 127142 RVA: 0x002E29BD File Offset: 0x002E0BBD
		[return: Nullable(1)]
		public static FLGUIDelegateHandleWrapper LGUIDrawableEvent_Color_Register(in FLGUIDrawableEvent_Color InEvent, FLGUIDrawableEvent_Color_DynamicDelegate InDelegate)
		{
			return new FLGUIDelegateHandleWrapper(ULGUIBPLibrary.__LGUIDrawableEvent_Color_Register_Internal((InEvent ?? new FLGUIDrawableEvent_Color()).NativePtr, (InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F0A7 RID: 127143 RVA: 0x002E29E7 File Offset: 0x002E0BE7
		public static void LGUIDrawableEvent_Color_Execute(in FLGUIDrawableEvent_Color InEvent, FColor InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Color_Execute_Internal((InEvent ?? new FLGUIDrawableEvent_Color()).NativePtr, InParameter);
		}

		// Token: 0x0601F0A8 RID: 127144 RVA: 0x002E29FF File Offset: 0x002E0BFF
		public static void LGUIDrawableEvent_Class_Unregister(in FLGUIDrawableEvent_Class InEvent, in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Class_Unregister_Internal((InEvent ?? new FLGUIDrawableEvent_Class()).NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F0A9 RID: 127145 RVA: 0x002E2A26 File Offset: 0x002E0C26
		[return: Nullable(1)]
		public static FLGUIDelegateHandleWrapper LGUIDrawableEvent_Class_Register(in FLGUIDrawableEvent_Class InEvent, FLGUIDrawableEvent_Class_DynamicDelegate InDelegate)
		{
			return new FLGUIDelegateHandleWrapper(ULGUIBPLibrary.__LGUIDrawableEvent_Class_Register_Internal((InEvent ?? new FLGUIDrawableEvent_Class()).NativePtr, (InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F0AA RID: 127146 RVA: 0x002E2A50 File Offset: 0x002E0C50
		public static void LGUIDrawableEvent_Class_Execute(in FLGUIDrawableEvent_Class InEvent, UClassStackOnlyPtr InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Class_Execute_Internal((InEvent ?? new FLGUIDrawableEvent_Class()).NativePtr, InParameter._NativePtr);
		}

		// Token: 0x0601F0AB RID: 127147 RVA: 0x002E2A6D File Offset: 0x002E0C6D
		public static void LGUIDrawableEvent_Bool_Unregister(in FLGUIDrawableEvent_Bool InEvent, in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Bool_Unregister_Internal((InEvent ?? new FLGUIDrawableEvent_Bool()).NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F0AC RID: 127148 RVA: 0x002E2A94 File Offset: 0x002E0C94
		[return: Nullable(1)]
		public static FLGUIDelegateHandleWrapper LGUIDrawableEvent_Bool_Register(in FLGUIDrawableEvent_Bool InEvent, FLGUIDrawableEvent_Bool_DynamicDelegate InDelegate)
		{
			return new FLGUIDelegateHandleWrapper(ULGUIBPLibrary.__LGUIDrawableEvent_Bool_Register_Internal((InEvent ?? new FLGUIDrawableEvent_Bool()).NativePtr, (InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F0AD RID: 127149 RVA: 0x002E2ABE File Offset: 0x002E0CBE
		public static void LGUIDrawableEvent_Bool_Execute(in FLGUIDrawableEvent_Bool InEvent, bool InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Bool_Execute_Internal((InEvent ?? new FLGUIDrawableEvent_Bool()).NativePtr, InParameter);
		}

		// Token: 0x0601F0AE RID: 127150 RVA: 0x002E2AD6 File Offset: 0x002E0CD6
		public static void LGUIDrawableEvent_Actor_Unregister(in FLGUIDrawableEvent_Actor InEvent, in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Actor_Unregister_Internal((InEvent ?? new FLGUIDrawableEvent_Actor()).NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0601F0AF RID: 127151 RVA: 0x002E2AFD File Offset: 0x002E0CFD
		[return: Nullable(1)]
		public static FLGUIDelegateHandleWrapper LGUIDrawableEvent_Actor_Register(in FLGUIDrawableEvent_Actor InEvent, FLGUIDrawableEvent_Actor_DynamicDelegate InDelegate)
		{
			return new FLGUIDelegateHandleWrapper(ULGUIBPLibrary.__LGUIDrawableEvent_Actor_Register_Internal((InEvent ?? new FLGUIDrawableEvent_Actor()).NativePtr, (InDelegate != null) ? InDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0601F0B0 RID: 127152 RVA: 0x002E2B27 File Offset: 0x002E0D27
		public static void LGUIDrawableEvent_Actor_Execute(in FLGUIDrawableEvent_Actor InEvent, AActor InParameter)
		{
			ULGUIBPLibrary.__LGUIDrawableEvent_Actor_Execute_Internal((InEvent ?? new FLGUIDrawableEvent_Actor()).NativePtr, (InParameter != null) ? InParameter.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F0B1 RID: 127153 RVA: 0x002E2B4E File Offset: 0x002E0D4E
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static TSubclassOf<UActorComponent> LGUICompRef_GetComponentClass(in FLGUIComponentReference InLGUIComponentReference)
		{
			return ULGUIBPLibrary.__LGUICompRef_GetComponentClass_Internal((InLGUIComponentReference ?? new FLGUIComponentReference()).NativePtr);
		}

		// Token: 0x0601F0B2 RID: 127154 RVA: 0x002E2B6A File Offset: 0x002E0D6A
		public static UActorComponent LGUICompRef_GetComponent(in FLGUIComponentReference InLGUIComponentReference, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> InComponentType)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(ULGUIBPLibrary.__LGUICompRef_GetComponent_Internal((InLGUIComponentReference ?? new FLGUIComponentReference()).NativePtr, InComponentType._NativePtr));
		}

		// Token: 0x0601F0B3 RID: 127155 RVA: 0x002E2B8C File Offset: 0x002E0D8C
		public static AActor LGUICompRef_GetActor(in FLGUIComponentReference InLGUIComponentReference)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ULGUIBPLibrary.__LGUICompRef_GetActor_Internal((InLGUIComponentReference ?? new FLGUIComponentReference()).NativePtr));
		}

		// Token: 0x0601F0B4 RID: 127156 RVA: 0x002E2BA8 File Offset: 0x002E0DA8
		public static void K2_LGUICompRef_GetComponent(in FLGUIComponentReference InLGUICompRef, ref UActorComponent OutResult)
		{
			UActorComponent uactorComponent = OutResult;
			IntPtr nativeObjectPtr = (uactorComponent != null) ? uactorComponent.NativePtr : IntPtr.Zero;
			ULGUIBPLibrary.__K2_LGUICompRef_GetComponent_Internal((InLGUICompRef ?? new FLGUIComponentReference()).NativePtr, ref nativeObjectPtr);
			OutResult = BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(nativeObjectPtr);
		}

		// Token: 0x0601F0B5 RID: 127157
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsInAudioEditMode();

		// Token: 0x0601F0B6 RID: 127158 RVA: 0x002E2BE7 File Offset: 0x002E0DE7
		public static ULTweener HeightTo(UUIItem target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__HeightTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0601F0B7 RID: 127159 RVA: 0x002E2C08 File Offset: 0x002E0E08
		public static bool GetWorldUISceneRendering(UObject WorldContextObject)
		{
			return ULGUIBPLibrary.__GetWorldUISceneRendering_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F0B8 RID: 127160 RVA: 0x002E2C1F File Offset: 0x002E0E1F
		public static FVector GetUIWorldPosForceUpdate(UUIItem UIItem)
		{
			return ULGUIBPLibrary.__GetUIWorldPosForceUpdate_Internal((UIItem != null) ? UIItem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F0B9 RID: 127161 RVA: 0x002E2C38 File Offset: 0x002E0E38
		public unsafe static UUIItem GetUIItemWithRelativePath(UUIItem ParentItem, [Nullable(1)] string RelativePath)
		{
			FString fstring = FString.AllocTemp(RelativePath);
			UUIItem orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(ULGUIBPLibrary.__GetUIItemWithRelativePath_Internal((ParentItem != null) ? ParentItem.NativePtr : IntPtr.Zero, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0601F0BA RID: 127162 RVA: 0x002E2C74 File Offset: 0x002E0E74
		public unsafe static UUIItem GetUIItemWithPath(UObject WorldContextObject, [Nullable(1)] string FullItemPath)
		{
			FString fstring = FString.AllocTemp(FullItemPath);
			UUIItem orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(ULGUIBPLibrary.__GetUIItemWithPath_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0601F0BB RID: 127163 RVA: 0x002E2CAD File Offset: 0x002E0EAD
		public static FVector2D GetUIItemPositionInViewPort(UObject WorldContextObject, UUIItem Item, bool bIsScaledByBPI = false)
		{
			return ULGUIBPLibrary.__GetUIItemPositionInViewPort_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Item != null) ? Item.NativePtr : IntPtr.Zero, bIsScaledByBPI);
		}

		// Token: 0x0601F0BC RID: 127164 RVA: 0x002E2CD5 File Offset: 0x002E0ED5
		public static FVector2D GetUIItemCornerPositionInViewPort(UiItemCornerType corner, UObject WorldContextObject, UUIItem Item)
		{
			return ULGUIBPLibrary.__GetUIItemCornerPositionInViewPort_Internal(corner, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Item != null) ? Item.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F0BD RID: 127165 RVA: 0x002E2D00 File Offset: 0x002E0F00
		[NullableContext(1)]
		[return: Nullable(2)]
		public unsafe static UTexture2D GetTexture2DFromImage(string ImagePath, int ImageFormatValue)
		{
			FString fstring = FString.AllocTemp(ImagePath);
			UTexture2D orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(ULGUIBPLibrary.__GetTexture2DFromImage_Internal(fstring, ImageFormatValue));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0601F0BE RID: 127166 RVA: 0x002E2D2C File Offset: 0x002E0F2C
		[NullableContext(1)]
		public unsafe static long GetStringHashValue(string Str)
		{
			FString fstring = FString.AllocTemp(Str);
			long result = ULGUIBPLibrary.__GetStringHashValue_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601F0BF RID: 127167 RVA: 0x002E2D50 File Offset: 0x002E0F50
		public unsafe static void GetSpriteUV(in FLGUISpriteInfo SpriteInfo, ref float UV0X, ref float UV0Y, ref float UV3X, ref float UV3Y)
		{
			fixed (float* ptr = &UV0X)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &UV0Y)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &UV3X)
					{
						void* ptr6 = (void*)ptr5;
						fixed (float* ptr7 = &UV3Y)
						{
							void* ptr8 = (void*)ptr7;
							ULGUIBPLibrary.__GetSpriteUV_Internal((SpriteInfo ?? new FLGUISpriteInfo()).NativePtr, ref UV0X, ref UV0Y, ref UV3X, ref UV3Y);
							ptr = null;
							ptr3 = null;
							ptr5 = null;
						}
					}
				}
			}
		}

		// Token: 0x0601F0C0 RID: 127168 RVA: 0x002E2DA4 File Offset: 0x002E0FA4
		public unsafe static void GetSpriteSize(in FLGUISpriteInfo SpriteInfo, ref int width, ref int height)
		{
			fixed (int* ptr = &width)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &height)
				{
					void* ptr4 = (void*)ptr3;
					ULGUIBPLibrary.__GetSpriteSize_Internal((SpriteInfo ?? new FLGUISpriteInfo()).NativePtr, ref width, ref height);
					ptr = null;
				}
			}
		}

		// Token: 0x0601F0C1 RID: 127169 RVA: 0x002E2DD8 File Offset: 0x002E0FD8
		public unsafe static void GetSpriteBorderUV(in FLGUISpriteInfo SpriteInfo, ref float borderUV0X, ref float borderUV0Y, ref float borderUV3X, ref float borderUV3Y)
		{
			fixed (float* ptr = &borderUV0X)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &borderUV0Y)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &borderUV3X)
					{
						void* ptr6 = (void*)ptr5;
						fixed (float* ptr7 = &borderUV3Y)
						{
							void* ptr8 = (void*)ptr7;
							ULGUIBPLibrary.__GetSpriteBorderUV_Internal((SpriteInfo ?? new FLGUISpriteInfo()).NativePtr, ref borderUV0X, ref borderUV0Y, ref borderUV3X, ref borderUV3Y);
							ptr = null;
							ptr3 = null;
							ptr5 = null;
						}
					}
				}
			}
		}

		// Token: 0x0601F0C2 RID: 127170 RVA: 0x002E2E2C File Offset: 0x002E102C
		public unsafe static void GetSpriteBorderSize(in FLGUISpriteInfo SpriteInfo, ref int borderLeft, ref int borderRight, ref int borderTop, ref int borderBottom)
		{
			fixed (int* ptr = &borderLeft)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &borderRight)
				{
					void* ptr4 = (void*)ptr3;
					fixed (int* ptr5 = &borderTop)
					{
						void* ptr6 = (void*)ptr5;
						fixed (int* ptr7 = &borderBottom)
						{
							void* ptr8 = (void*)ptr7;
							ULGUIBPLibrary.__GetSpriteBorderSize_Internal((SpriteInfo ?? new FLGUISpriteInfo()).NativePtr, ref borderLeft, ref borderRight, ref borderTop, ref borderBottom);
							ptr = null;
							ptr3 = null;
							ptr5 = null;
						}
					}
				}
			}
		}

		// Token: 0x0601F0C3 RID: 127171 RVA: 0x002E2E80 File Offset: 0x002E1080
		[NullableContext(1)]
		public static TArray<UUIItem> GetSortedItemsWithFlattenHierarchyIndex([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UUIItem> Items, bool bUpSorted)
		{
			return new TArray<UUIItem>(ULGUIBPLibrary.__GetSortedItemsWithFlattenHierarchyIndex_Internal((Items ?? new TArray<UUIItem>()).NativePtr, bUpSorted), null);
		}

		// Token: 0x0601F0C4 RID: 127172 RVA: 0x002E2E9E File Offset: 0x002E109E
		public static FName GetRootActorMemoryTag(UUIItem UIItem)
		{
			return ULGUIBPLibrary.__GetRootActorMemoryTag_Internal((UIItem != null) ? UIItem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F0C5 RID: 127173 RVA: 0x002E2EB5 File Offset: 0x002E10B5
		[return: Nullable(1)]
		public static string GetRelativePathWithRoot(UUIItem Target, UUIItem Root)
		{
			return FString.ToStringAndDeleteNativePtr(ULGUIBPLibrary.__GetRelativePathWithRoot_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, (Root != null) ? Root.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601F0C6 RID: 127174 RVA: 0x002E2EE1 File Offset: 0x002E10E1
		public static UUIItem GetPrefabRoot(UUIItem InUiItem)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(ULGUIBPLibrary.__GetPrefabRoot_Internal((InUiItem != null) ? InUiItem.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601F0C7 RID: 127175 RVA: 0x002E2F00 File Offset: 0x002E1100
		public unsafe static bool GetFullPathOfActor(UObject WorldContextObject, AActor Actor, [Nullable(1)] ref string PathString)
		{
			FString fstring = FString.AllocTemp(PathString);
			bool result = ULGUIBPLibrary.__GetFullPathOfActor_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, ref fstring);
			PathString = FString.ToString(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601F0C8 RID: 127176 RVA: 0x002E2F4E File Offset: 0x002E114E
		public static UActorComponent GetCorrespondingEditorComponent(UActorComponent PIEComponent, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> ComponentClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(ULGUIBPLibrary.__GetCorrespondingEditorComponent_Internal((PIEComponent != null) ? PIEComponent.NativePtr : IntPtr.Zero, ComponentClass._NativePtr));
		}

		// Token: 0x0601F0C9 RID: 127177 RVA: 0x002E2F70 File Offset: 0x002E1170
		[NullableContext(1)]
		public static TArray<UActorComponent> GetComponentsInChildrenWithHirerarchyIndex([Nullable(2)] AUIBaseActor InActor, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> ComponentClass, bool IncludeSelf)
		{
			return new TArray<UActorComponent>(ULGUIBPLibrary.__GetComponentsInChildrenWithHirerarchyIndex_Internal((InActor != null) ? InActor.NativePtr : IntPtr.Zero, ComponentClass._NativePtr, IncludeSelf), null);
		}

		// Token: 0x0601F0CA RID: 127178 RVA: 0x002E2F94 File Offset: 0x002E1194
		[NullableContext(1)]
		public static TArray<UActorComponent> GetComponentsInChildren([Nullable(2)] AActor InActor, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> ComponentClass, bool IncludeSelf)
		{
			return new TArray<UActorComponent>(ULGUIBPLibrary.__GetComponentsInChildren_Internal((InActor != null) ? InActor.NativePtr : IntPtr.Zero, ComponentClass._NativePtr, IncludeSelf), null);
		}

		// Token: 0x0601F0CB RID: 127179 RVA: 0x002E2FB8 File Offset: 0x002E11B8
		public static UActorComponent GetComponentInParent(AActor InActor, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> ComponentClass, bool IncludeSelf = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(ULGUIBPLibrary.__GetComponentInParent_Internal((InActor != null) ? InActor.NativePtr : IntPtr.Zero, ComponentClass._NativePtr, IncludeSelf));
		}

		// Token: 0x0601F0CC RID: 127180 RVA: 0x002E2FDB File Offset: 0x002E11DB
		public static UActorComponent GetComponentInChildren(AActor InActor, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UActorComponent> ComponentClass, bool IncludeSelf)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UActorComponent>(ULGUIBPLibrary.__GetComponentInChildren_Internal((InActor != null) ? InActor.NativePtr : IntPtr.Zero, ComponentClass._NativePtr, IncludeSelf));
		}

		// Token: 0x0601F0CD RID: 127181 RVA: 0x002E2FFE File Offset: 0x002E11FE
		[NullableContext(1)]
		public static TArray<AActor> GetAllAttachChildrenOfActor([Nullable(2)] AActor Actor, bool bIncludeAllChildren = true)
		{
			return new TArray<AActor>(ULGUIBPLibrary.__GetAllAttachChildrenOfActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, bIncludeAllChildren), null);
		}

		// Token: 0x0601F0CE RID: 127182
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FreeUnusedResourcesInRenderTargetPool();

		// Token: 0x0601F0CF RID: 127183 RVA: 0x002E301C File Offset: 0x002E121C
		public static AActor DuplicateActor(AActor Target, USceneComponent Parent)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ULGUIBPLibrary.__DuplicateActor_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, (Parent != null) ? Parent.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601F0D0 RID: 127184 RVA: 0x002E3048 File Offset: 0x002E1248
		public static void DestroyActorWithHierarchy(AActor Target, bool WithHierarchy = true)
		{
			ULGUIBPLibrary.__DestroyActorWithHierarchy_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, WithHierarchy);
		}

		// Token: 0x0601F0D1 RID: 127185 RVA: 0x002E3060 File Offset: 0x002E1260
		[NullableContext(1)]
		public unsafe static bool DeleteFile(string Path)
		{
			FString fstring = FString.AllocTemp(Path);
			bool result = ULGUIBPLibrary.__DeleteFile_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601F0D2 RID: 127186 RVA: 0x002E3084 File Offset: 0x002E1284
		public static void DeleteActor(AActor Target, bool WithHierarchy = true)
		{
			ULGUIBPLibrary.__DeleteActor_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, WithHierarchy);
		}

		// Token: 0x0601F0D3 RID: 127187 RVA: 0x002E309C File Offset: 0x002E129C
		public static UTexture2D CreateTextureFromScreenShot(bool bContainsUI = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(ULGUIBPLibrary.__CreateTextureFromScreenShot_Internal(bContainsUI));
		}

		// Token: 0x0601F0D4 RID: 127188 RVA: 0x002E30AC File Offset: 0x002E12AC
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

		// Token: 0x0601F0D5 RID: 127189 RVA: 0x002E30E8 File Offset: 0x002E12E8
		public static UTexture2D CreateTexture2DFromColors(int Width, int Height, in TArray<FColor> Colors)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(ULGUIBPLibrary.__CreateTexture2DFromColors_Internal(Width, Height, (Colors ?? new TArray<FColor>()).NativePtr));
		}

		// Token: 0x0601F0D6 RID: 127190 RVA: 0x002E3106 File Offset: 0x002E1306
		public static UTexture2D CreateTexture2DFromBuffer(int startPositionX, int endPositionX, int startPositionY, int endPositionY)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(ULGUIBPLibrary.__CreateTexture2DFromBuffer_Internal(startPositionX, endPositionX, startPositionY, endPositionY));
		}

		// Token: 0x0601F0D7 RID: 127191 RVA: 0x002E3116 File Offset: 0x002E1316
		public static void CopySequenceBindingFromParent(UUIItem Target, in FSoftObjectPath LevelSequencePath)
		{
			ULGUIBPLibrary.__CopySequenceBindingFromParent_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, (LevelSequencePath ?? new FSoftObjectPath()).NativePtr);
		}

		// Token: 0x0601F0D8 RID: 127192 RVA: 0x002E313D File Offset: 0x002E133D
		public static FVector2D ConvertWorldPosToLGUIPos(APlayerController PlayerController, in FVectorDouble WorldPosition)
		{
			return ULGUIBPLibrary.__ConvertWorldPosToLGUIPos_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero, WorldPosition);
		}

		// Token: 0x0601F0D9 RID: 127193 RVA: 0x002E3155 File Offset: 0x002E1355
		public static ULTweener ColorTo(UUIItem target, FColor endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__ColorTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0601F0DA RID: 127194 RVA: 0x002E3176 File Offset: 0x002E1376
		public static ULTweener ColorFrom(UUIItem target, FColor startValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__ColorFrom_Internal((target != null) ? target.NativePtr : IntPtr.Zero, startValue, duration, delay, ease));
		}

		// Token: 0x0601F0DB RID: 127195 RVA: 0x002E3198 File Offset: 0x002E1398
		[NullableContext(1)]
		public unsafe static void ClipBoardPaste(ref string Target)
		{
			FString fstring = FString.AllocTemp(Target);
			ULGUIBPLibrary.__ClipBoardPaste_Internal(ref fstring);
			Target = FString.ToString(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601F0DC RID: 127196 RVA: 0x002E31C8 File Offset: 0x002E13C8
		[NullableContext(1)]
		public unsafe static void ClipBoardCopy(string Str)
		{
			FString fstring = FString.AllocTemp(Str);
			ULGUIBPLibrary.__ClipBoardCopy_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601F0DD RID: 127197 RVA: 0x002E31EC File Offset: 0x002E13EC
		public static void ClearInstanceComponents(AActor Actor, bool bDestroyComponents)
		{
			ULGUIBPLibrary.__ClearInstanceComponents_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, bDestroyComponents);
		}

		// Token: 0x0601F0DE RID: 127198 RVA: 0x002E3204 File Offset: 0x002E1404
		[return: Nullable(1)]
		public static TArray<AActor> BatchDuplicateActors(AActor Src, int Num, USceneComponent Parent)
		{
			return new TArray<AActor>(ULGUIBPLibrary.__BatchDuplicateActors_Internal((Src != null) ? Src.NativePtr : IntPtr.Zero, Num, (Parent != null) ? Parent.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0601F0DF RID: 127199 RVA: 0x002E3232 File Offset: 0x002E1432
		public static ULTweener AnchorOffsetYTo(UUIItem target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__AnchorOffsetYTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0601F0E0 RID: 127200 RVA: 0x002E3253 File Offset: 0x002E1453
		public static ULTweener AnchorOffsetXTo(UUIItem target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__AnchorOffsetXTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0601F0E1 RID: 127201 RVA: 0x002E3274 File Offset: 0x002E1474
		public static ULTweener AnchorOffsetTo(UUIItem target, FVector2D endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__AnchorOffsetTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0601F0E2 RID: 127202 RVA: 0x002E3295 File Offset: 0x002E1495
		public static ULTweener AlphaTo(UUIItem target, float endValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__AlphaTo_Internal((target != null) ? target.NativePtr : IntPtr.Zero, endValue, duration, delay, ease));
		}

		// Token: 0x0601F0E3 RID: 127203 RVA: 0x002E32B6 File Offset: 0x002E14B6
		public static ULTweener AlphaFrom(UUIItem target, float startValue, float duration = 0.5f, float delay = 0f, LTweenEase ease = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(ULGUIBPLibrary.__AlphaFrom_Internal((target != null) ? target.NativePtr : IntPtr.Zero, startValue, duration, delay, ease));
		}

		// Token: 0x0601F0E4 RID: 127204 RVA: 0x002E32D7 File Offset: 0x002E14D7
		public static void AddInstanceComponent(AActor Actor, UActorComponent Component)
		{
			ULGUIBPLibrary.__AddInstanceComponent_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F0E5 RID: 127205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WidthTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0601F0E6 RID: 127206
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __UILocalPositionTo_Internal(IntPtr target, FVector endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0601F0E7 RID: 127207
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __StretchTopTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0601F0E8 RID: 127208
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __StretchRightTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0601F0E9 RID: 127209
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __StretchLeftTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0601F0EA RID: 127210
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __StretchBottomTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0601F0EB RID: 127211
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SortItemsWithFlattenHierarchyIndex_Internal(IntPtr Items, bool bUpSorted);

		// Token: 0x0601F0EC RID: 127212
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SortActorsWithDistance_Internal(IntPtr ActorList, IntPtr Controller);

		// Token: 0x0601F0ED RID: 127213
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SimulationLineTraceOnCenterScreen_Internal(IntPtr WorldContext, IntPtr TraceOnlyItems);

		// Token: 0x0601F0EE RID: 127214
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SimulationLineTrace_Internal(in FVector2D Pos, IntPtr WorldContext, IntPtr TraceOnlyItems);

		// Token: 0x0601F0EF RID: 127215
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWorldUISceneRendering_Internal(IntPtr @this, bool Value);

		// Token: 0x0601F0F0 RID: 127216
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIRenderable_Internal(IntPtr UIItem, bool bNewRenderable);

		// Token: 0x0601F0F1 RID: 127217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIHierarchyIndex_Internal(IntPtr Target, int index);

		// Token: 0x0601F0F2 RID: 127218
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIAlpha_Internal(IntPtr Target, float InAlpha);

		// Token: 0x0601F0F3 RID: 127219
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIActive_Internal(IntPtr Target, bool Acitve);

		// Token: 0x0601F0F4 RID: 127220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRootActorMemoryTag_Internal(IntPtr UIItem, FName MemoryTag);

		// Token: 0x0601F0F5 RID: 127221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUIUISceneRendering_Internal(IntPtr Actor, bool IsUISceneRendering);

		// Token: 0x0601F0F6 RID: 127222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsFullScreenUIRendering_Internal(IntPtr WorldContextObject, bool Value);

		// Token: 0x0601F0F7 RID: 127223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalBlurUIItem_Internal(IntPtr UIItem, IntPtr World);

		// Token: 0x0601F0F8 RID: 127224
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllTextFont_Internal(IntPtr WorldContext, IntPtr FontData);

		// Token: 0x0601F0F9 RID: 127225
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetGlobalBlurUIItem_Internal(IntPtr World);

		// Token: 0x0601F0FA RID: 127226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveInstanceComponent_Internal(IntPtr Actor, IntPtr Component);

		// Token: 0x0601F0FB RID: 127227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PrintUIItemLog_Internal(in FString Content, IntPtr UIItem, int LogDepth);

		// Token: 0x0601F0FC RID: 127228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PivotTo_Internal(IntPtr target, FVector2D endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0601F0FD RID: 127229
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadPrefabWithAsset_Internal(IntPtr WorldContextObject, IntPtr PrefabAsset, IntPtr InParent);

		// Token: 0x0601F0FE RID: 127230
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIExecuteInputAxis_Internal(IntPtr inputKey, float value);

		// Token: 0x0601F0FF RID: 127231
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIExecuteInputAction_Internal(IntPtr inputKey, bool pressOrRelease);

		// Token: 0x0601F100 RID: 127232
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIExecuteControllerInputAxis_Internal(IntPtr inputKey, float value);

		// Token: 0x0601F101 RID: 127233
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIExecuteControllerInputAction_Internal(IntPtr inputKey, bool pressOrRelease);

		// Token: 0x0601F102 RID: 127234
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEventExecuteVector4_Internal(IntPtr InEvent, in FVector4 InParameter);

		// Token: 0x0601F103 RID: 127235
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEventExecuteVector3_Internal(IntPtr InEvent, in FVector InParameter);

		// Token: 0x0601F104 RID: 127236
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEventExecuteVector2_Internal(IntPtr InEvent, in FVector2D InParameter);

		// Token: 0x0601F105 RID: 127237
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEventExecuteUInt8_Internal(IntPtr InEvent, in byte InParameter);

		// Token: 0x0601F106 RID: 127238
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEventExecuteString_Internal(IntPtr InEvent, in FString InParameter);

		// Token: 0x0601F107 RID: 127239
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEventExecuteRotator_Internal(IntPtr InEvent, in FRotator InParameter);

		// Token: 0x0601F108 RID: 127240
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEventExecuteQuaternion_Internal(IntPtr InEvent, in FQuat InParameter);

		// Token: 0x0601F109 RID: 127241
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEventExecutePointerEvent_Internal(IntPtr InEvent, IntPtr InParameter);

		// Token: 0x0601F10A RID: 127242
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEventExecuteObject_Internal(IntPtr InEvent, IntPtr InParameter);

		// Token: 0x0601F10B RID: 127243
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEventExecuteLinearColor_Internal(IntPtr InEvent, in FLinearColor InParameter);

		// Token: 0x0601F10C RID: 127244
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEventExecuteInt32_Internal(IntPtr InEvent, in int InParameter);

		// Token: 0x0601F10D RID: 127245
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEventExecuteFloat_Internal(IntPtr InEvent, in float InParameter);

		// Token: 0x0601F10E RID: 127246
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEventExecuteEmpty_Internal(IntPtr InEvent);

		// Token: 0x0601F10F RID: 127247
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEventExecuteColor_Internal(IntPtr InEvent, in FColor InParameter);

		// Token: 0x0601F110 RID: 127248
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEventExecuteClass_Internal(IntPtr InEvent, IntPtr InParameter);

		// Token: 0x0601F111 RID: 127249
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEventExecuteBool_Internal(IntPtr InEvent, in bool InParameter);

		// Token: 0x0601F112 RID: 127250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEventExecuteActor_Internal(IntPtr InEvent, IntPtr InParameter);

		// Token: 0x0601F113 RID: 127251
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Vector4_Unregister_Internal(IntPtr InEvent, IntPtr InDelegateHandle);

		// Token: 0x0601F114 RID: 127252
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUIDrawableEvent_Vector4_Register_Internal(IntPtr InEvent, IntPtr InDelegate);

		// Token: 0x0601F115 RID: 127253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Vector4_Execute_Internal(IntPtr InEvent, in FVector4 InParameter);

		// Token: 0x0601F116 RID: 127254
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Vector3_Unregister_Internal(IntPtr InEvent, IntPtr InDelegateHandle);

		// Token: 0x0601F117 RID: 127255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUIDrawableEvent_Vector3_Register_Internal(IntPtr InEvent, IntPtr InDelegate);

		// Token: 0x0601F118 RID: 127256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Vector3_Execute_Internal(IntPtr InEvent, FVector InParameter);

		// Token: 0x0601F119 RID: 127257
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Vector2_Unregister_Internal(IntPtr InEvent, IntPtr InDelegateHandle);

		// Token: 0x0601F11A RID: 127258
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUIDrawableEvent_Vector2_Register_Internal(IntPtr InEvent, IntPtr InDelegate);

		// Token: 0x0601F11B RID: 127259
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Vector2_Execute_Internal(IntPtr InEvent, FVector2D InParameter);

		// Token: 0x0601F11C RID: 127260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_UInt8_Unregister_Internal(IntPtr InEvent, IntPtr InDelegateHandle);

		// Token: 0x0601F11D RID: 127261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUIDrawableEvent_UInt8_Register_Internal(IntPtr InEvent, IntPtr InDelegate);

		// Token: 0x0601F11E RID: 127262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_UInt8_Execute_Internal(IntPtr InEvent, byte InParameter);

		// Token: 0x0601F11F RID: 127263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_String_Unregister_Internal(IntPtr InEvent, IntPtr InDelegateHandle);

		// Token: 0x0601F120 RID: 127264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUIDrawableEvent_String_Register_Internal(IntPtr InEvent, IntPtr InDelegate);

		// Token: 0x0601F121 RID: 127265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_String_Execute_Internal(IntPtr InEvent, in FString InParameter);

		// Token: 0x0601F122 RID: 127266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Rotator_Unregister_Internal(IntPtr InEvent, IntPtr InDelegateHandle);

		// Token: 0x0601F123 RID: 127267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUIDrawableEvent_Rotator_Register_Internal(IntPtr InEvent, IntPtr InDelegate);

		// Token: 0x0601F124 RID: 127268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Rotator_Execute_Internal(IntPtr InEvent, FRotator InParameter);

		// Token: 0x0601F125 RID: 127269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Quaternion_Unregister_Internal(IntPtr InEvent, IntPtr InDelegateHandle);

		// Token: 0x0601F126 RID: 127270
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUIDrawableEvent_Quaternion_Register_Internal(IntPtr InEvent, IntPtr InDelegate);

		// Token: 0x0601F127 RID: 127271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Quaternion_Execute_Internal(IntPtr InEvent, in FQuat InParameter);

		// Token: 0x0601F128 RID: 127272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_PointerEvent_Unregister_Internal(IntPtr InEvent, IntPtr InDelegateHandle);

		// Token: 0x0601F129 RID: 127273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUIDrawableEvent_PointerEvent_Register_Internal(IntPtr InEvent, IntPtr InDelegate);

		// Token: 0x0601F12A RID: 127274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_PointerEvent_Execute_Internal(IntPtr InEvent, IntPtr InParameter);

		// Token: 0x0601F12B RID: 127275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Object_Unregister_Internal(IntPtr InEvent, IntPtr InDelegateHandle);

		// Token: 0x0601F12C RID: 127276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUIDrawableEvent_Object_Register_Internal(IntPtr InEvent, IntPtr InDelegate);

		// Token: 0x0601F12D RID: 127277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Object_Execute_Internal(IntPtr InEvent, IntPtr InParameter);

		// Token: 0x0601F12E RID: 127278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_LinearColor_Unregister_Internal(IntPtr InEvent, IntPtr InDelegateHandle);

		// Token: 0x0601F12F RID: 127279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUIDrawableEvent_LinearColor_Register_Internal(IntPtr InEvent, IntPtr InDelegate);

		// Token: 0x0601F130 RID: 127280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_LinearColor_Execute_Internal(IntPtr InEvent, FLinearColor InParameter);

		// Token: 0x0601F131 RID: 127281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Int64_Unregister_Internal(IntPtr InEvent, IntPtr InDelegateHandle);

		// Token: 0x0601F132 RID: 127282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUIDrawableEvent_Int64_Register_Internal(IntPtr InEvent, IntPtr InDelegate);

		// Token: 0x0601F133 RID: 127283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Int64_Execute_Internal(IntPtr InEvent, long InParameter);

		// Token: 0x0601F134 RID: 127284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Int32_Unregister_Internal(IntPtr InEvent, IntPtr InDelegateHandle);

		// Token: 0x0601F135 RID: 127285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUIDrawableEvent_Int32_Register_Internal(IntPtr InEvent, IntPtr InDelegate);

		// Token: 0x0601F136 RID: 127286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Int32_Execute_Internal(IntPtr InEvent, int InParameter);

		// Token: 0x0601F137 RID: 127287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Float_Unregister_Internal(IntPtr InEvent, IntPtr InDelegateHandle);

		// Token: 0x0601F138 RID: 127288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUIDrawableEvent_Float_Register_Internal(IntPtr InEvent, IntPtr InDelegate);

		// Token: 0x0601F139 RID: 127289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Float_Execute_Internal(IntPtr InEvent, float InParameter);

		// Token: 0x0601F13A RID: 127290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Empty_Unregister_Internal(IntPtr InEvent, IntPtr InDelegateHandle);

		// Token: 0x0601F13B RID: 127291
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUIDrawableEvent_Empty_Register_Internal(IntPtr InEvent, IntPtr InDelegate);

		// Token: 0x0601F13C RID: 127292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Empty_Execute_Internal(IntPtr InEvent);

		// Token: 0x0601F13D RID: 127293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Color_Unregister_Internal(IntPtr InEvent, IntPtr InDelegateHandle);

		// Token: 0x0601F13E RID: 127294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUIDrawableEvent_Color_Register_Internal(IntPtr InEvent, IntPtr InDelegate);

		// Token: 0x0601F13F RID: 127295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Color_Execute_Internal(IntPtr InEvent, FColor InParameter);

		// Token: 0x0601F140 RID: 127296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Class_Unregister_Internal(IntPtr InEvent, IntPtr InDelegateHandle);

		// Token: 0x0601F141 RID: 127297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUIDrawableEvent_Class_Register_Internal(IntPtr InEvent, IntPtr InDelegate);

		// Token: 0x0601F142 RID: 127298
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Class_Execute_Internal(IntPtr InEvent, IntPtr InParameter);

		// Token: 0x0601F143 RID: 127299
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Bool_Unregister_Internal(IntPtr InEvent, IntPtr InDelegateHandle);

		// Token: 0x0601F144 RID: 127300
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUIDrawableEvent_Bool_Register_Internal(IntPtr InEvent, IntPtr InDelegate);

		// Token: 0x0601F145 RID: 127301
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Bool_Execute_Internal(IntPtr InEvent, bool InParameter);

		// Token: 0x0601F146 RID: 127302
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Actor_Unregister_Internal(IntPtr InEvent, IntPtr InDelegateHandle);

		// Token: 0x0601F147 RID: 127303
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUIDrawableEvent_Actor_Register_Internal(IntPtr InEvent, IntPtr InDelegate);

		// Token: 0x0601F148 RID: 127304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LGUIDrawableEvent_Actor_Execute_Internal(IntPtr InEvent, IntPtr InParameter);

		// Token: 0x0601F149 RID: 127305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUICompRef_GetComponentClass_Internal(IntPtr InLGUIComponentReference);

		// Token: 0x0601F14A RID: 127306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUICompRef_GetComponent_Internal(IntPtr InLGUIComponentReference, IntPtr InComponentType);

		// Token: 0x0601F14B RID: 127307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LGUICompRef_GetActor_Internal(IntPtr InLGUIComponentReference);

		// Token: 0x0601F14C RID: 127308
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_LGUICompRef_GetComponent_Internal(IntPtr InLGUICompRef, ref IntPtr OutResult);

		// Token: 0x0601F14D RID: 127309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __HeightTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0601F14E RID: 127310
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWorldUISceneRendering_Internal(IntPtr WorldContextObject);

		// Token: 0x0601F14F RID: 127311
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUIWorldPosForceUpdate_Internal(IntPtr UIItem);

		// Token: 0x0601F150 RID: 127312
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetUIItemWithRelativePath_Internal(IntPtr ParentItem, in FString RelativePath);

		// Token: 0x0601F151 RID: 127313
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetUIItemWithPath_Internal(IntPtr WorldContextObject, in FString FullItemPath);

		// Token: 0x0601F152 RID: 127314
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetUIItemPositionInViewPort_Internal(IntPtr WorldContextObject, IntPtr Item, bool bIsScaledByBPI);

		// Token: 0x0601F153 RID: 127315
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetUIItemCornerPositionInViewPort_Internal(UiItemCornerType corner, IntPtr WorldContextObject, IntPtr Item);

		// Token: 0x0601F154 RID: 127316
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTexture2DFromImage_Internal(in FString ImagePath, int ImageFormatValue);

		// Token: 0x0601F155 RID: 127317
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long __GetStringHashValue_Internal(in FString Str);

		// Token: 0x0601F156 RID: 127318
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSpriteUV_Internal(IntPtr SpriteInfo, ref float UV0X, ref float UV0Y, ref float UV3X, ref float UV3Y);

		// Token: 0x0601F157 RID: 127319
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSpriteSize_Internal(IntPtr SpriteInfo, ref int width, ref int height);

		// Token: 0x0601F158 RID: 127320
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSpriteBorderUV_Internal(IntPtr SpriteInfo, ref float borderUV0X, ref float borderUV0Y, ref float borderUV3X, ref float borderUV3Y);

		// Token: 0x0601F159 RID: 127321
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSpriteBorderSize_Internal(IntPtr SpriteInfo, ref int borderLeft, ref int borderRight, ref int borderTop, ref int borderBottom);

		// Token: 0x0601F15A RID: 127322
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSortedItemsWithFlattenHierarchyIndex_Internal(IntPtr Items, bool bUpSorted);

		// Token: 0x0601F15B RID: 127323
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetRootActorMemoryTag_Internal(IntPtr UIItem);

		// Token: 0x0601F15C RID: 127324
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetRelativePathWithRoot_Internal(IntPtr Target, IntPtr Root);

		// Token: 0x0601F15D RID: 127325
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPrefabRoot_Internal(IntPtr InUiItem);

		// Token: 0x0601F15E RID: 127326
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFullPathOfActor_Internal(IntPtr WorldContextObject, IntPtr Actor, ref FString PathString);

		// Token: 0x0601F15F RID: 127327
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCorrespondingEditorComponent_Internal(IntPtr PIEComponent, IntPtr ComponentClass);

		// Token: 0x0601F160 RID: 127328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetComponentsInChildrenWithHirerarchyIndex_Internal(IntPtr InActor, IntPtr ComponentClass, bool IncludeSelf);

		// Token: 0x0601F161 RID: 127329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetComponentsInChildren_Internal(IntPtr InActor, IntPtr ComponentClass, bool IncludeSelf);

		// Token: 0x0601F162 RID: 127330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetComponentInParent_Internal(IntPtr InActor, IntPtr ComponentClass, bool IncludeSelf);

		// Token: 0x0601F163 RID: 127331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetComponentInChildren_Internal(IntPtr InActor, IntPtr ComponentClass, bool IncludeSelf);

		// Token: 0x0601F164 RID: 127332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllAttachChildrenOfActor_Internal(IntPtr Actor, bool bIncludeAllChildren);

		// Token: 0x0601F165 RID: 127333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __DuplicateActor_Internal(IntPtr Target, IntPtr Parent);

		// Token: 0x0601F166 RID: 127334
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyActorWithHierarchy_Internal(IntPtr Target, bool WithHierarchy);

		// Token: 0x0601F167 RID: 127335
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DeleteFile_Internal(in FString Path);

		// Token: 0x0601F168 RID: 127336
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeleteActor_Internal(IntPtr Target, bool WithHierarchy);

		// Token: 0x0601F169 RID: 127337
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateTextureFromScreenShot_Internal(bool bContainsUI);

		// Token: 0x0601F16A RID: 127338
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateTexture2DFromPath_Internal(in FString ImagePath, in FString TextureName, int ImageFormatValue);

		// Token: 0x0601F16B RID: 127339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateTexture2DFromColors_Internal(int Width, int Height, IntPtr Colors);

		// Token: 0x0601F16C RID: 127340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateTexture2DFromBuffer_Internal(int startPositionX, int endPositionX, int startPositionY, int endPositionY);

		// Token: 0x0601F16D RID: 127341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CopySequenceBindingFromParent_Internal(IntPtr Target, IntPtr LevelSequencePath);

		// Token: 0x0601F16E RID: 127342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __ConvertWorldPosToLGUIPos_Internal(IntPtr PlayerController, in FVectorDouble WorldPosition);

		// Token: 0x0601F16F RID: 127343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ColorTo_Internal(IntPtr target, FColor endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0601F170 RID: 127344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ColorFrom_Internal(IntPtr target, FColor startValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0601F171 RID: 127345
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClipBoardPaste_Internal(ref FString Target);

		// Token: 0x0601F172 RID: 127346
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClipBoardCopy_Internal(in FString Str);

		// Token: 0x0601F173 RID: 127347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearInstanceComponents_Internal(IntPtr Actor, bool bDestroyComponents);

		// Token: 0x0601F174 RID: 127348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BatchDuplicateActors_Internal(IntPtr Src, int Num, IntPtr Parent);

		// Token: 0x0601F175 RID: 127349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AnchorOffsetYTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0601F176 RID: 127350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AnchorOffsetXTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0601F177 RID: 127351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AnchorOffsetTo_Internal(IntPtr target, FVector2D endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0601F178 RID: 127352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AlphaTo_Internal(IntPtr target, float endValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0601F179 RID: 127353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AlphaFrom_Internal(IntPtr target, float startValue, float duration, float delay, LTweenEase ease);

		// Token: 0x0601F17A RID: 127354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddInstanceComponent_Internal(IntPtr Actor, IntPtr Component);

		// Token: 0x0601F17B RID: 127355 RVA: 0x002E32FE File Offset: 0x002E14FE
		static ULGUIBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIBPLibrary");
		}

		// Token: 0x0601F17C RID: 127356 RVA: 0x002E330C File Offset: 0x002E150C
		protected ULGUIBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010DA5 RID: 69029
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIBPLibrary";

		// Token: 0x04010DA6 RID: 69030
		private static IntPtr _ClassPtr;

		// Token: 0x04010DA7 RID: 69031
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
