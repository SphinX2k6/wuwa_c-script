using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002086 RID: 8326
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIManagerActor")]
	[UnrealStructLayout(1984, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1984)]
	public class ALGUIManagerActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F681 RID: 128641 RVA: 0x002EA51C File Offset: 0x002E871C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALGUIManagerActor._ClassPtr;
		}

		// Token: 0x0601F682 RID: 128642 RVA: 0x002EA528 File Offset: 0x002E8728
		public ALGUIManagerActor() : this(BuiltinUtils.AllocNativeUObject(ALGUIManagerActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F683 RID: 128643 RVA: 0x002EA550 File Offset: 0x002E8750
		public ALGUIManagerActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALGUIManagerActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007BF2 RID: 31730
		// (get) Token: 0x0601F684 RID: 128644 RVA: 0x002EA584 File Offset: 0x002E8784
		// (set) Token: 0x0601F685 RID: 128645 RVA: 0x002EA5BD File Offset: 0x002E87BD
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UUIItem>> AllUIItem
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<UUIItem>> result;
				if ((result = this._AllUIItem) == null)
				{
					result = (this._AllUIItem = new TArray<TWeakObjectPtr<UUIItem>>(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_AllUIItem, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.AllUIItem.CopyAssign(value);
			}
		}

		// Token: 0x17007BF3 RID: 31731
		// (get) Token: 0x0601F686 RID: 128646 RVA: 0x002EA5CC File Offset: 0x002E87CC
		// (set) Token: 0x0601F687 RID: 128647 RVA: 0x002EA605 File Offset: 0x002E8805
		public TArray<ULGUICanvas> AllCanvas
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULGUICanvas> result;
				if ((result = this._AllCanvas) == null)
				{
					result = (this._AllCanvas = new TArray<ULGUICanvas>(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_AllCanvas, this));
				}
				return result;
			}
			set
			{
				this.AllCanvas.CopyAssign(value);
			}
		}

		// Token: 0x17007BF4 RID: 31732
		// (get) Token: 0x0601F688 RID: 128648 RVA: 0x002EA614 File Offset: 0x002E8814
		// (set) Token: 0x0601F689 RID: 128649 RVA: 0x002EA64D File Offset: 0x002E884D
		public TArray<ULGUICanvas> PostTickCanvas
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULGUICanvas> result;
				if ((result = this._PostTickCanvas) == null)
				{
					result = (this._PostTickCanvas = new TArray<ULGUICanvas>(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_PostTickCanvas, this));
				}
				return result;
			}
			set
			{
				this.PostTickCanvas.CopyAssign(value);
			}
		}

		// Token: 0x17007BF5 RID: 31733
		// (get) Token: 0x0601F68A RID: 128650 RVA: 0x002EA65C File Offset: 0x002E885C
		// (set) Token: 0x0601F68B RID: 128651 RVA: 0x002EA695 File Offset: 0x002E8895
		public TArray<ULGUIBaseRaycaster> raycasterArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULGUIBaseRaycaster> result;
				if ((result = this._raycasterArray) == null)
				{
					result = (this._raycasterArray = new TArray<ULGUIBaseRaycaster>(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_raycasterArray, this));
				}
				return result;
			}
			set
			{
				this.raycasterArray.CopyAssign(value);
			}
		}

		// Token: 0x17007BF6 RID: 31734
		// (get) Token: 0x0601F68C RID: 128652 RVA: 0x002EA6A3 File Offset: 0x002E88A3
		// (set) Token: 0x0601F68D RID: 128653 RVA: 0x002EA6B7 File Offset: 0x002E88B7
		[Nullable(2)]
		public unsafe ULGUIBaseInputModule currentInputModule
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUIBaseInputModule>(base.NativePtr / (IntPtr)sizeof(void*) + ALGUIManagerActor.__PropertyOffset_currentInputModule);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALGUIManagerActor.__PropertyOffset_currentInputModule, value);
			}
		}

		// Token: 0x17007BF7 RID: 31735
		// (get) Token: 0x0601F68E RID: 128654 RVA: 0x002EA6CC File Offset: 0x002E88CC
		// (set) Token: 0x0601F68F RID: 128655 RVA: 0x002EA705 File Offset: 0x002E8905
		public TArray<UUISelectableComponent> allSelectableArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UUISelectableComponent> result;
				if ((result = this._allSelectableArray) == null)
				{
					result = (this._allSelectableArray = new TArray<UUISelectableComponent>(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_allSelectableArray, this));
				}
				return result;
			}
			set
			{
				this.allSelectableArray.CopyAssign(value);
			}
		}

		// Token: 0x17007BF8 RID: 31736
		// (get) Token: 0x0601F690 RID: 128656 RVA: 0x002EA713 File Offset: 0x002E8913
		// (set) Token: 0x0601F691 RID: 128657 RVA: 0x002EA727 File Offset: 0x002E8927
		[Nullable(2)]
		public unsafe USequencerManager SequencerManager
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USequencerManager>(base.NativePtr / (IntPtr)sizeof(void*) + ALGUIManagerActor.__PropertyOffset_SequencerManager);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALGUIManagerActor.__PropertyOffset_SequencerManager, value);
			}
		}

		// Token: 0x17007BF9 RID: 31737
		// (get) Token: 0x0601F692 RID: 128658 RVA: 0x002EA73C File Offset: 0x002E893C
		// (set) Token: 0x0601F693 RID: 128659 RVA: 0x002EA750 File Offset: 0x002E8950
		[Nullable(2)]
		public unsafe UUISpineManager UISpineManager
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUISpineManager>(base.NativePtr / (IntPtr)sizeof(void*) + ALGUIManagerActor.__PropertyOffset_UISpineManager);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALGUIManagerActor.__PropertyOffset_UISpineManager, value);
			}
		}

		// Token: 0x17007BFA RID: 31738
		// (get) Token: 0x0601F694 RID: 128660 RVA: 0x002EA765 File Offset: 0x002E8965
		// (set) Token: 0x0601F695 RID: 128661 RVA: 0x002EA779 File Offset: 0x002E8979
		[Nullable(2)]
		public unsafe UUIDynmaicTextureAtlasMgr DynmaicTextureAtlasMgr
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIDynmaicTextureAtlasMgr>(base.NativePtr / (IntPtr)sizeof(void*) + ALGUIManagerActor.__PropertyOffset_DynmaicTextureAtlasMgr);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALGUIManagerActor.__PropertyOffset_DynmaicTextureAtlasMgr, value);
			}
		}

		// Token: 0x17007BFB RID: 31739
		// (get) Token: 0x0601F696 RID: 128662 RVA: 0x002EA78E File Offset: 0x002E898E
		// (set) Token: 0x0601F697 RID: 128663 RVA: 0x002EA7A2 File Offset: 0x002E89A2
		[Nullable(2)]
		public unsafe UUIDynamicSpriteAtlasMgr DynamicSpriteAtlasMgr
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIDynamicSpriteAtlasMgr>(base.NativePtr / (IntPtr)sizeof(void*) + ALGUIManagerActor.__PropertyOffset_DynamicSpriteAtlasMgr);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALGUIManagerActor.__PropertyOffset_DynamicSpriteAtlasMgr, value);
			}
		}

		// Token: 0x17007BFC RID: 31740
		// (get) Token: 0x0601F698 RID: 128664 RVA: 0x002EA7B8 File Offset: 0x002E89B8
		// (set) Token: 0x0601F699 RID: 128665 RVA: 0x002EA7F1 File Offset: 0x002E89F1
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UUIItem>> AllRaycastTarget
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<UUIItem>> result;
				if ((result = this._AllRaycastTarget) == null)
				{
					result = (this._AllRaycastTarget = new TArray<TWeakObjectPtr<UUIItem>>(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_AllRaycastTarget, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.AllRaycastTarget.CopyAssign(value);
			}
		}

		// Token: 0x17007BFD RID: 31741
		// (get) Token: 0x0601F69A RID: 128666 RVA: 0x002EA800 File Offset: 0x002E8A00
		// (set) Token: 0x0601F69B RID: 128667 RVA: 0x002EA839 File Offset: 0x002E8A39
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<ULGUIBehaviour>> LGUIBehavioursForUpdate
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<ULGUIBehaviour>> result;
				if ((result = this._LGUIBehavioursForUpdate) == null)
				{
					result = (this._LGUIBehavioursForUpdate = new TArray<TWeakObjectPtr<ULGUIBehaviour>>(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_LGUIBehavioursForUpdate, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.LGUIBehavioursForUpdate.CopyAssign(value);
			}
		}

		// Token: 0x17007BFE RID: 31742
		// (get) Token: 0x0601F69C RID: 128668 RVA: 0x002EA848 File Offset: 0x002E8A48
		// (set) Token: 0x0601F69D RID: 128669 RVA: 0x002EA881 File Offset: 0x002E8A81
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<ULGUIBehaviour>> LGUIBehavioursUpdateAfterGeometryUp
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<ULGUIBehaviour>> result;
				if ((result = this._LGUIBehavioursUpdateAfterGeometryUp) == null)
				{
					result = (this._LGUIBehavioursUpdateAfterGeometryUp = new TArray<TWeakObjectPtr<ULGUIBehaviour>>(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_LGUIBehavioursUpdateAfterGeometryUp, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.LGUIBehavioursUpdateAfterGeometryUp.CopyAssign(value);
			}
		}

		// Token: 0x17007BFF RID: 31743
		// (get) Token: 0x0601F69E RID: 128670 RVA: 0x002EA890 File Offset: 0x002E8A90
		// (set) Token: 0x0601F69F RID: 128671 RVA: 0x002EA8C9 File Offset: 0x002E8AC9
		public TArray<UUINiagara> allUINiagara
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UUINiagara> result;
				if ((result = this._allUINiagara) == null)
				{
					result = (this._allUINiagara = new TArray<UUINiagara>(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_allUINiagara, this));
				}
				return result;
			}
			set
			{
				this.allUINiagara.CopyAssign(value);
			}
		}

		// Token: 0x17007C00 RID: 31744
		// (get) Token: 0x0601F6A0 RID: 128672 RVA: 0x002EA8D7 File Offset: 0x002E8AD7
		// (set) Token: 0x0601F6A1 RID: 128673 RVA: 0x002EA8EB File Offset: 0x002E8AEB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<ULGUICanvas> ScreenRootPtr
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_ScreenRootPtr);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_ScreenRootPtr) = value;
			}
		}

		// Token: 0x17007C01 RID: 31745
		// (get) Token: 0x0601F6A2 RID: 128674 RVA: 0x002EA900 File Offset: 0x002E8B00
		// (set) Token: 0x0601F6A3 RID: 128675 RVA: 0x002EA939 File Offset: 0x002E8B39
		public TArray<FLGUIBehaviourArrayContainer> LGUIBehaviours_PrefabSystemProcessing
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLGUIBehaviourArrayContainer> result;
				if ((result = this._LGUIBehaviours_PrefabSystemProcessing) == null)
				{
					result = (this._LGUIBehaviours_PrefabSystemProcessing = new TArray<FLGUIBehaviourArrayContainer>(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_LGUIBehaviours_PrefabSystemProcessing, this));
				}
				return result;
			}
			set
			{
				this.LGUIBehaviours_PrefabSystemProcessing.CopyAssign(value);
			}
		}

		// Token: 0x17007C02 RID: 31746
		// (get) Token: 0x0601F6A4 RID: 128676 RVA: 0x002EA947 File Offset: 0x002E8B47
		// (set) Token: 0x0601F6A5 RID: 128677 RVA: 0x002EA95B File Offset: 0x002E8B5B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIItem> DebugRootLayer
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_DebugRootLayer);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_DebugRootLayer) = value;
			}
		}

		// Token: 0x17007C03 RID: 31747
		// (get) Token: 0x0601F6A6 RID: 128678 RVA: 0x002EA970 File Offset: 0x002E8B70
		// (set) Token: 0x0601F6A7 RID: 128679 RVA: 0x002EA9A9 File Offset: 0x002E8BA9
		public TSet<UUIItem> DirtyHierarchyRootSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UUIItem> result;
				if ((result = this._DirtyHierarchyRootSet) == null)
				{
					result = (this._DirtyHierarchyRootSet = new TSet<UUIItem>(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_DirtyHierarchyRootSet, this));
				}
				return result;
			}
			set
			{
				this.DirtyHierarchyRootSet.CopyAssign(value);
			}
		}

		// Token: 0x17007C04 RID: 31748
		// (get) Token: 0x0601F6A8 RID: 128680 RVA: 0x002EA9B8 File Offset: 0x002E8BB8
		// (set) Token: 0x0601F6A9 RID: 128681 RVA: 0x002EA9F1 File Offset: 0x002E8BF1
		public TArray<UUILayoutBase> AutoLayoutRebuildList_ParentFirst
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UUILayoutBase> result;
				if ((result = this._AutoLayoutRebuildList_ParentFirst) == null)
				{
					result = (this._AutoLayoutRebuildList_ParentFirst = new TArray<UUILayoutBase>(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_AutoLayoutRebuildList_ParentFirst, this));
				}
				return result;
			}
			set
			{
				this.AutoLayoutRebuildList_ParentFirst.CopyAssign(value);
			}
		}

		// Token: 0x17007C05 RID: 31749
		// (get) Token: 0x0601F6AA RID: 128682 RVA: 0x002EAA00 File Offset: 0x002E8C00
		// (set) Token: 0x0601F6AB RID: 128683 RVA: 0x002EAA39 File Offset: 0x002E8C39
		public TArray<UUILayoutBase> AutoLayoutRebuildList_ChildrenFirst
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UUILayoutBase> result;
				if ((result = this._AutoLayoutRebuildList_ChildrenFirst) == null)
				{
					result = (this._AutoLayoutRebuildList_ChildrenFirst = new TArray<UUILayoutBase>(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_AutoLayoutRebuildList_ChildrenFirst, this));
				}
				return result;
			}
			set
			{
				this.AutoLayoutRebuildList_ChildrenFirst.CopyAssign(value);
			}
		}

		// Token: 0x17007C06 RID: 31750
		// (get) Token: 0x0601F6AC RID: 128684 RVA: 0x002EAA48 File Offset: 0x002E8C48
		// (set) Token: 0x0601F6AD RID: 128685 RVA: 0x002EAA81 File Offset: 0x002E8C81
		public TSet<UUILayoutBase> AutoLayoutPostRebuildList
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UUILayoutBase> result;
				if ((result = this._AutoLayoutPostRebuildList) == null)
				{
					result = (this._AutoLayoutPostRebuildList = new TSet<UUILayoutBase>(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_AutoLayoutPostRebuildList, this));
				}
				return result;
			}
			set
			{
				this.AutoLayoutPostRebuildList.CopyAssign(value);
			}
		}

		// Token: 0x17007C07 RID: 31751
		// (get) Token: 0x0601F6AE RID: 128686 RVA: 0x002EAA90 File Offset: 0x002E8C90
		// (set) Token: 0x0601F6AF RID: 128687 RVA: 0x002EAAC9 File Offset: 0x002E8CC9
		public TSet<UUILayoutBase> AutoLayoutPostHasRebuildThisFrame
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UUILayoutBase> result;
				if ((result = this._AutoLayoutPostHasRebuildThisFrame) == null)
				{
					result = (this._AutoLayoutPostHasRebuildThisFrame = new TSet<UUILayoutBase>(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_AutoLayoutPostHasRebuildThisFrame, this));
				}
				return result;
			}
			set
			{
				this.AutoLayoutPostHasRebuildThisFrame.CopyAssign(value);
			}
		}

		// Token: 0x17007C08 RID: 31752
		// (get) Token: 0x0601F6B0 RID: 128688 RVA: 0x002EAAD8 File Offset: 0x002E8CD8
		// (set) Token: 0x0601F6B1 RID: 128689 RVA: 0x002EAB11 File Offset: 0x002E8D11
		public TArray<ULGUICanvas> InternalHierarchyDirtyCanvases
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULGUICanvas> result;
				if ((result = this._InternalHierarchyDirtyCanvases) == null)
				{
					result = (this._InternalHierarchyDirtyCanvases = new TArray<ULGUICanvas>(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_InternalHierarchyDirtyCanvases, this));
				}
				return result;
			}
			set
			{
				this.InternalHierarchyDirtyCanvases.CopyAssign(value);
			}
		}

		// Token: 0x17007C09 RID: 31753
		// (get) Token: 0x0601F6B2 RID: 128690 RVA: 0x002EAB20 File Offset: 0x002E8D20
		// (set) Token: 0x0601F6B3 RID: 128691 RVA: 0x002EAB59 File Offset: 0x002E8D59
		public TSet<ULGUICanvas> DirtyRootCanvasSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<ULGUICanvas> result;
				if ((result = this._DirtyRootCanvasSet) == null)
				{
					result = (this._DirtyRootCanvasSet = new TSet<ULGUICanvas>(base.NativePtr + (IntPtr)ALGUIManagerActor.__PropertyOffset_DirtyRootCanvasSet, this));
				}
				return result;
			}
			set
			{
				this.DirtyRootCanvasSet.CopyAssign(value);
			}
		}

		// Token: 0x0601F6B4 RID: 128692 RVA: 0x002EAB67 File Offset: 0x002E8D67
		[NullableContext(2)]
		public static void SetGlobalPlayRate(UObject WorldContext, float PlayRate)
		{
			ALGUIManagerActor.__SetGlobalPlayRate_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, PlayRate);
		}

		// Token: 0x0601F6B5 RID: 128693 RVA: 0x002EAB7F File Offset: 0x002E8D7F
		[NullableContext(2)]
		public static void SetDebugRootLayer(UObject WorldContextObj, UUIItem LayerItem)
		{
			ALGUIManagerActor.__SetDebugRootLayer_Internal((WorldContextObj != null) ? WorldContextObj.NativePtr : IntPtr.Zero, (LayerItem != null) ? LayerItem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F6B6 RID: 128694 RVA: 0x002EABA6 File Offset: 0x002E8DA6
		[NullableContext(2)]
		public static UUISpineManager GetUISpineManager(UObject WorldContext)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISpineManager>(ALGUIManagerActor.__GetUISpineManager_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601F6B7 RID: 128695 RVA: 0x002EABC2 File Offset: 0x002E8DC2
		[NullableContext(2)]
		public static USequencerManager GetSequencerManager(UObject WorldContext)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USequencerManager>(ALGUIManagerActor.__GetSequencerManager_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601F6B8 RID: 128696 RVA: 0x002EABDE File Offset: 0x002E8DDE
		[NullableContext(2)]
		public static int GetGlobalUiBlurIndex(UObject WorldContextObject)
		{
			return ALGUIManagerActor.__GetGlobalUiBlurIndex_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F6B9 RID: 128697 RVA: 0x002EABF5 File Offset: 0x002E8DF5
		[NullableContext(2)]
		public static UUIDynamicSpriteAtlasMgr GetDynamicSpriteAtlasMgr(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIDynamicSpriteAtlasMgr>(ALGUIManagerActor.__GetDynamicSpriteAtlasMgr_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601F6BA RID: 128698
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ForceClearBatchDestroyUIBaseActors();

		// Token: 0x0601F6BB RID: 128699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalPlayRate_Internal(IntPtr WorldContext, float PlayRate);

		// Token: 0x0601F6BC RID: 128700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDebugRootLayer_Internal(IntPtr WorldContextObj, IntPtr LayerItem);

		// Token: 0x0601F6BD RID: 128701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetUISpineManager_Internal(IntPtr WorldContext);

		// Token: 0x0601F6BE RID: 128702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSequencerManager_Internal(IntPtr WorldContext);

		// Token: 0x0601F6BF RID: 128703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetGlobalUiBlurIndex_Internal(IntPtr WorldContextObject);

		// Token: 0x0601F6C0 RID: 128704
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDynamicSpriteAtlasMgr_Internal(IntPtr WorldContextObject);

		// Token: 0x0601F6C1 RID: 128705 RVA: 0x002EAC11 File Offset: 0x002E8E11
		static ALGUIManagerActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIManagerActor");
		}

		// Token: 0x0601F6C2 RID: 128706 RVA: 0x002EAC1F File Offset: 0x002E8E1F
		protected ALGUIManagerActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010F61 RID: 69473
		public new const string __ObjectPath = "/Script/LGUI.LGUIManagerActor";

		// Token: 0x04010F62 RID: 69474
		private static IntPtr _ClassPtr;

		// Token: 0x04010F63 RID: 69475
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010F64 RID: 69476
		internal static int __PropertyOffset_AllUIItem;

		// Token: 0x04010F65 RID: 69477
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UUIItem>> _AllUIItem;

		// Token: 0x04010F66 RID: 69478
		internal static int __PropertyOffset_AllCanvas;

		// Token: 0x04010F67 RID: 69479
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULGUICanvas> _AllCanvas;

		// Token: 0x04010F68 RID: 69480
		internal static int __PropertyOffset_PostTickCanvas;

		// Token: 0x04010F69 RID: 69481
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULGUICanvas> _PostTickCanvas;

		// Token: 0x04010F6A RID: 69482
		internal static int __PropertyOffset_raycasterArray;

		// Token: 0x04010F6B RID: 69483
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULGUIBaseRaycaster> _raycasterArray;

		// Token: 0x04010F6C RID: 69484
		internal static int __PropertyOffset_currentInputModule;

		// Token: 0x04010F6D RID: 69485
		internal static int __PropertyOffset_allSelectableArray;

		// Token: 0x04010F6E RID: 69486
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUISelectableComponent> _allSelectableArray;

		// Token: 0x04010F6F RID: 69487
		internal static int __PropertyOffset_SequencerManager;

		// Token: 0x04010F70 RID: 69488
		internal static int __PropertyOffset_UISpineManager;

		// Token: 0x04010F71 RID: 69489
		internal static int __PropertyOffset_DynmaicTextureAtlasMgr;

		// Token: 0x04010F72 RID: 69490
		internal static int __PropertyOffset_DynamicSpriteAtlasMgr;

		// Token: 0x04010F73 RID: 69491
		internal static int __PropertyOffset_AllRaycastTarget;

		// Token: 0x04010F74 RID: 69492
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UUIItem>> _AllRaycastTarget;

		// Token: 0x04010F75 RID: 69493
		internal static int __PropertyOffset_LGUIBehavioursForUpdate;

		// Token: 0x04010F76 RID: 69494
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<ULGUIBehaviour>> _LGUIBehavioursForUpdate;

		// Token: 0x04010F77 RID: 69495
		internal static int __PropertyOffset_LGUIBehavioursUpdateAfterGeometryUp;

		// Token: 0x04010F78 RID: 69496
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<ULGUIBehaviour>> _LGUIBehavioursUpdateAfterGeometryUp;

		// Token: 0x04010F79 RID: 69497
		internal static int __PropertyOffset_allUINiagara;

		// Token: 0x04010F7A RID: 69498
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUINiagara> _allUINiagara;

		// Token: 0x04010F7B RID: 69499
		internal static int __PropertyOffset_ScreenRootPtr;

		// Token: 0x04010F7C RID: 69500
		internal static int __PropertyOffset_LGUIBehaviours_PrefabSystemProcessing;

		// Token: 0x04010F7D RID: 69501
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLGUIBehaviourArrayContainer> _LGUIBehaviours_PrefabSystemProcessing;

		// Token: 0x04010F7E RID: 69502
		internal static int __PropertyOffset_DebugRootLayer;

		// Token: 0x04010F7F RID: 69503
		internal static int __PropertyOffset_DirtyHierarchyRootSet;

		// Token: 0x04010F80 RID: 69504
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UUIItem> _DirtyHierarchyRootSet;

		// Token: 0x04010F81 RID: 69505
		internal static int __PropertyOffset_AutoLayoutRebuildList_ParentFirst;

		// Token: 0x04010F82 RID: 69506
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUILayoutBase> _AutoLayoutRebuildList_ParentFirst;

		// Token: 0x04010F83 RID: 69507
		internal static int __PropertyOffset_AutoLayoutRebuildList_ChildrenFirst;

		// Token: 0x04010F84 RID: 69508
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUILayoutBase> _AutoLayoutRebuildList_ChildrenFirst;

		// Token: 0x04010F85 RID: 69509
		internal static int __PropertyOffset_AutoLayoutPostRebuildList;

		// Token: 0x04010F86 RID: 69510
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UUILayoutBase> _AutoLayoutPostRebuildList;

		// Token: 0x04010F87 RID: 69511
		internal static int __PropertyOffset_AutoLayoutPostHasRebuildThisFrame;

		// Token: 0x04010F88 RID: 69512
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UUILayoutBase> _AutoLayoutPostHasRebuildThisFrame;

		// Token: 0x04010F89 RID: 69513
		internal static int __PropertyOffset_InternalHierarchyDirtyCanvases;

		// Token: 0x04010F8A RID: 69514
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULGUICanvas> _InternalHierarchyDirtyCanvases;

		// Token: 0x04010F8B RID: 69515
		internal static int __PropertyOffset_DirtyRootCanvasSet;

		// Token: 0x04010F8C RID: 69516
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<ULGUICanvas> _DirtyRootCanvasSet;
	}
}
