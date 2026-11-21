using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006A3 RID: 1699
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIManagerActor")]
	[UnrealStructLayout(1984, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1984)]
	public class ALGUIManagerActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600921F RID: 37407 RVA: 0x000DC000 File Offset: 0x000DA200
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALGUIManagerActor._ClassPtr;
		}

		// Token: 0x06009220 RID: 37408 RVA: 0x000DC00C File Offset: 0x000DA20C
		public ALGUIManagerActor() : this(BuiltinUtils.AllocNativeUObject(ALGUIManagerActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009221 RID: 37409 RVA: 0x000DC034 File Offset: 0x000DA234
		public ALGUIManagerActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALGUIManagerActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x06009222 RID: 37410 RVA: 0x000DC068 File Offset: 0x000DA268
		// (set) Token: 0x06009223 RID: 37411 RVA: 0x000DC0A1 File Offset: 0x000DA2A1
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

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x06009224 RID: 37412 RVA: 0x000DC0B0 File Offset: 0x000DA2B0
		// (set) Token: 0x06009225 RID: 37413 RVA: 0x000DC0E9 File Offset: 0x000DA2E9
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

		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x06009226 RID: 37414 RVA: 0x000DC0F8 File Offset: 0x000DA2F8
		// (set) Token: 0x06009227 RID: 37415 RVA: 0x000DC131 File Offset: 0x000DA331
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

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x06009228 RID: 37416 RVA: 0x000DC140 File Offset: 0x000DA340
		// (set) Token: 0x06009229 RID: 37417 RVA: 0x000DC179 File Offset: 0x000DA379
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

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x0600922A RID: 37418 RVA: 0x000DC187 File Offset: 0x000DA387
		// (set) Token: 0x0600922B RID: 37419 RVA: 0x000DC19B File Offset: 0x000DA39B
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

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x0600922C RID: 37420 RVA: 0x000DC1B0 File Offset: 0x000DA3B0
		// (set) Token: 0x0600922D RID: 37421 RVA: 0x000DC1E9 File Offset: 0x000DA3E9
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

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x0600922E RID: 37422 RVA: 0x000DC1F7 File Offset: 0x000DA3F7
		// (set) Token: 0x0600922F RID: 37423 RVA: 0x000DC20B File Offset: 0x000DA40B
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

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x06009230 RID: 37424 RVA: 0x000DC220 File Offset: 0x000DA420
		// (set) Token: 0x06009231 RID: 37425 RVA: 0x000DC234 File Offset: 0x000DA434
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

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x06009232 RID: 37426 RVA: 0x000DC24C File Offset: 0x000DA44C
		// (set) Token: 0x06009233 RID: 37427 RVA: 0x000DC285 File Offset: 0x000DA485
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

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x06009234 RID: 37428 RVA: 0x000DC294 File Offset: 0x000DA494
		// (set) Token: 0x06009235 RID: 37429 RVA: 0x000DC2CD File Offset: 0x000DA4CD
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

		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x06009236 RID: 37430 RVA: 0x000DC2DC File Offset: 0x000DA4DC
		// (set) Token: 0x06009237 RID: 37431 RVA: 0x000DC315 File Offset: 0x000DA515
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

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x06009238 RID: 37432 RVA: 0x000DC324 File Offset: 0x000DA524
		// (set) Token: 0x06009239 RID: 37433 RVA: 0x000DC35D File Offset: 0x000DA55D
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

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x0600923A RID: 37434 RVA: 0x000DC36B File Offset: 0x000DA56B
		// (set) Token: 0x0600923B RID: 37435 RVA: 0x000DC37F File Offset: 0x000DA57F
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

		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x0600923C RID: 37436 RVA: 0x000DC394 File Offset: 0x000DA594
		// (set) Token: 0x0600923D RID: 37437 RVA: 0x000DC3A8 File Offset: 0x000DA5A8
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

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x0600923E RID: 37438 RVA: 0x000DC3C0 File Offset: 0x000DA5C0
		// (set) Token: 0x0600923F RID: 37439 RVA: 0x000DC3F9 File Offset: 0x000DA5F9
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

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x06009240 RID: 37440 RVA: 0x000DC408 File Offset: 0x000DA608
		// (set) Token: 0x06009241 RID: 37441 RVA: 0x000DC441 File Offset: 0x000DA641
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

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x06009242 RID: 37442 RVA: 0x000DC450 File Offset: 0x000DA650
		// (set) Token: 0x06009243 RID: 37443 RVA: 0x000DC489 File Offset: 0x000DA689
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

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x06009244 RID: 37444 RVA: 0x000DC498 File Offset: 0x000DA698
		// (set) Token: 0x06009245 RID: 37445 RVA: 0x000DC4D1 File Offset: 0x000DA6D1
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

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x06009246 RID: 37446 RVA: 0x000DC4E0 File Offset: 0x000DA6E0
		// (set) Token: 0x06009247 RID: 37447 RVA: 0x000DC519 File Offset: 0x000DA719
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

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x06009248 RID: 37448 RVA: 0x000DC528 File Offset: 0x000DA728
		// (set) Token: 0x06009249 RID: 37449 RVA: 0x000DC561 File Offset: 0x000DA761
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

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x0600924A RID: 37450 RVA: 0x000DC570 File Offset: 0x000DA770
		// (set) Token: 0x0600924B RID: 37451 RVA: 0x000DC5A9 File Offset: 0x000DA7A9
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

		// Token: 0x0600924C RID: 37452 RVA: 0x000DC5B7 File Offset: 0x000DA7B7
		[NullableContext(2)]
		public static void SetGlobalPlayRate(UObject WorldContext, float PlayRate)
		{
			ALGUIManagerActor.__SetGlobalPlayRate_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, PlayRate);
		}

		// Token: 0x0600924D RID: 37453 RVA: 0x000DC5CF File Offset: 0x000DA7CF
		[NullableContext(2)]
		public static void SetDebugRootLayer(UObject WorldContextObj, UUIItem LayerItem)
		{
			ALGUIManagerActor.__SetDebugRootLayer_Internal((WorldContextObj != null) ? WorldContextObj.NativePtr : IntPtr.Zero, (LayerItem != null) ? LayerItem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600924E RID: 37454 RVA: 0x000DC5F6 File Offset: 0x000DA7F6
		[NullableContext(2)]
		public static USequencerManager GetSequencerManager(UObject WorldContext)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USequencerManager>(ALGUIManagerActor.__GetSequencerManager_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600924F RID: 37455 RVA: 0x000DC612 File Offset: 0x000DA812
		[NullableContext(2)]
		public static int GetGlobalUiBlurIndex(UObject WorldContextObject)
		{
			return ALGUIManagerActor.__GetGlobalUiBlurIndex_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009250 RID: 37456 RVA: 0x000DC629 File Offset: 0x000DA829
		[NullableContext(2)]
		public static UUIDynamicSpriteAtlasMgr GetDynamicSpriteAtlasMgr(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIDynamicSpriteAtlasMgr>(ALGUIManagerActor.__GetDynamicSpriteAtlasMgr_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06009251 RID: 37457
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ForceClearBatchDestroyUIBaseActors();

		// Token: 0x06009252 RID: 37458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalPlayRate_Internal(IntPtr WorldContext, float PlayRate);

		// Token: 0x06009253 RID: 37459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDebugRootLayer_Internal(IntPtr WorldContextObj, IntPtr LayerItem);

		// Token: 0x06009254 RID: 37460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSequencerManager_Internal(IntPtr WorldContext);

		// Token: 0x06009255 RID: 37461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetGlobalUiBlurIndex_Internal(IntPtr WorldContextObject);

		// Token: 0x06009256 RID: 37462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDynamicSpriteAtlasMgr_Internal(IntPtr WorldContextObject);

		// Token: 0x06009257 RID: 37463 RVA: 0x000DC645 File Offset: 0x000DA845
		static ALGUIManagerActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIManagerActor");
		}

		// Token: 0x06009258 RID: 37464 RVA: 0x000DC653 File Offset: 0x000DA853
		protected ALGUIManagerActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003FAB RID: 16299
		public new const string __ObjectPath = "/Script/LGUI.LGUIManagerActor";

		// Token: 0x04003FAC RID: 16300
		private static IntPtr _ClassPtr;

		// Token: 0x04003FAD RID: 16301
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003FAE RID: 16302
		internal static int __PropertyOffset_AllUIItem;

		// Token: 0x04003FAF RID: 16303
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UUIItem>> _AllUIItem;

		// Token: 0x04003FB0 RID: 16304
		internal static int __PropertyOffset_AllCanvas;

		// Token: 0x04003FB1 RID: 16305
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULGUICanvas> _AllCanvas;

		// Token: 0x04003FB2 RID: 16306
		internal static int __PropertyOffset_PostTickCanvas;

		// Token: 0x04003FB3 RID: 16307
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULGUICanvas> _PostTickCanvas;

		// Token: 0x04003FB4 RID: 16308
		internal static int __PropertyOffset_raycasterArray;

		// Token: 0x04003FB5 RID: 16309
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULGUIBaseRaycaster> _raycasterArray;

		// Token: 0x04003FB6 RID: 16310
		internal static int __PropertyOffset_currentInputModule;

		// Token: 0x04003FB7 RID: 16311
		internal static int __PropertyOffset_allSelectableArray;

		// Token: 0x04003FB8 RID: 16312
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUISelectableComponent> _allSelectableArray;

		// Token: 0x04003FB9 RID: 16313
		internal static int __PropertyOffset_SequencerManager;

		// Token: 0x04003FBA RID: 16314
		internal static int __PropertyOffset_DynamicSpriteAtlasMgr;

		// Token: 0x04003FBB RID: 16315
		internal static int __PropertyOffset_AllRaycastTarget;

		// Token: 0x04003FBC RID: 16316
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UUIItem>> _AllRaycastTarget;

		// Token: 0x04003FBD RID: 16317
		internal static int __PropertyOffset_LGUIBehavioursForUpdate;

		// Token: 0x04003FBE RID: 16318
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<ULGUIBehaviour>> _LGUIBehavioursForUpdate;

		// Token: 0x04003FBF RID: 16319
		internal static int __PropertyOffset_LGUIBehavioursUpdateAfterGeometryUp;

		// Token: 0x04003FC0 RID: 16320
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<ULGUIBehaviour>> _LGUIBehavioursUpdateAfterGeometryUp;

		// Token: 0x04003FC1 RID: 16321
		internal static int __PropertyOffset_allUINiagara;

		// Token: 0x04003FC2 RID: 16322
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUINiagara> _allUINiagara;

		// Token: 0x04003FC3 RID: 16323
		internal static int __PropertyOffset_ScreenRootPtr;

		// Token: 0x04003FC4 RID: 16324
		internal static int __PropertyOffset_DebugRootLayer;

		// Token: 0x04003FC5 RID: 16325
		internal static int __PropertyOffset_DirtyHierarchyRootSet;

		// Token: 0x04003FC6 RID: 16326
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UUIItem> _DirtyHierarchyRootSet;

		// Token: 0x04003FC7 RID: 16327
		internal static int __PropertyOffset_AutoLayoutRebuildList_ParentFirst;

		// Token: 0x04003FC8 RID: 16328
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUILayoutBase> _AutoLayoutRebuildList_ParentFirst;

		// Token: 0x04003FC9 RID: 16329
		internal static int __PropertyOffset_AutoLayoutRebuildList_ChildrenFirst;

		// Token: 0x04003FCA RID: 16330
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUILayoutBase> _AutoLayoutRebuildList_ChildrenFirst;

		// Token: 0x04003FCB RID: 16331
		internal static int __PropertyOffset_AutoLayoutPostRebuildList;

		// Token: 0x04003FCC RID: 16332
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UUILayoutBase> _AutoLayoutPostRebuildList;

		// Token: 0x04003FCD RID: 16333
		internal static int __PropertyOffset_AutoLayoutPostHasRebuildThisFrame;

		// Token: 0x04003FCE RID: 16334
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UUILayoutBase> _AutoLayoutPostHasRebuildThisFrame;

		// Token: 0x04003FCF RID: 16335
		internal static int __PropertyOffset_InternalHierarchyDirtyCanvases;

		// Token: 0x04003FD0 RID: 16336
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULGUICanvas> _InternalHierarchyDirtyCanvases;

		// Token: 0x04003FD1 RID: 16337
		internal static int __PropertyOffset_DirtyRootCanvasSet;

		// Token: 0x04003FD2 RID: 16338
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<ULGUICanvas> _DirtyRootCanvasSet;
	}
}
