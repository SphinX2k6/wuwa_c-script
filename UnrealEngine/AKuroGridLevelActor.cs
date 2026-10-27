using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018D4 RID: 6356
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroGridLevelActor")]
	[UnrealStructLayout(1240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1240)]
	public class AKuroGridLevelActor : AActor, IUnrealUObject, IUnrealObject, IKuroBuildingGridPlaceholderInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060178D3 RID: 96467 RVA: 0x002279EC File Offset: 0x00225BEC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroGridLevelActor._ClassPtr;
		}

		// Token: 0x060178D4 RID: 96468 RVA: 0x002279F8 File Offset: 0x00225BF8
		int IKuroBuildingGridPlaceholderInterface.InterfaceOffset()
		{
			return AKuroGridLevelActor.__InterfaceOffset_IKuroBuildingGridPlaceholderInterface;
		}

		// Token: 0x060178D5 RID: 96469 RVA: 0x00227A00 File Offset: 0x00225C00
		public AKuroGridLevelActor() : this(BuiltinUtils.AllocNativeUObject(AKuroGridLevelActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060178D6 RID: 96470 RVA: 0x00227A28 File Offset: 0x00225C28
		public AKuroGridLevelActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroGridLevelActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005EEB RID: 24299
		// (get) Token: 0x060178D7 RID: 96471 RVA: 0x00227A5B File Offset: 0x00225C5B
		// (set) Token: 0x060178D8 RID: 96472 RVA: 0x00227A70 File Offset: 0x00225C70
		public TSoftObjectPtr<UWorld> WorldAsset
		{
			get
			{
				return new TSoftObjectPtr<UWorld>(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_WorldAsset, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_WorldAsset, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17005EEC RID: 24300
		// (get) Token: 0x060178D9 RID: 96473 RVA: 0x00227A95 File Offset: 0x00225C95
		// (set) Token: 0x060178DA RID: 96474 RVA: 0x00227AA9 File Offset: 0x00225CA9
		public unsafe FKuroBuildingGridCellVector GridSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_GridSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_GridSize) = value;
			}
		}

		// Token: 0x17005EED RID: 24301
		// (get) Token: 0x060178DB RID: 96475 RVA: 0x00227AC0 File Offset: 0x00225CC0
		// (set) Token: 0x060178DC RID: 96476 RVA: 0x00227AF9 File Offset: 0x00225CF9
		public TArray<UKuroGridLevelRotationAxisConstraints> RotatableParts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroGridLevelRotationAxisConstraints> result;
				if ((result = this._RotatableParts) == null)
				{
					result = (this._RotatableParts = new TArray<UKuroGridLevelRotationAxisConstraints>(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_RotatableParts, this));
				}
				return result;
			}
			set
			{
				this.RotatableParts.CopyAssign(value);
			}
		}

		// Token: 0x17005EEE RID: 24302
		// (get) Token: 0x060178DD RID: 96477 RVA: 0x00227B07 File Offset: 0x00225D07
		// (set) Token: 0x060178DE RID: 96478 RVA: 0x00227B1B File Offset: 0x00225D1B
		[Nullable(2)]
		public unsafe UKuroLevelStateMachineComponent LevelStateMachineComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroLevelStateMachineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGridLevelActor.__PropertyOffset_LevelStateMachineComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroGridLevelActor.__PropertyOffset_LevelStateMachineComponent, value);
			}
		}

		// Token: 0x17005EEF RID: 24303
		// (get) Token: 0x060178DF RID: 96479 RVA: 0x00227B30 File Offset: 0x00225D30
		// (set) Token: 0x060178E0 RID: 96480 RVA: 0x00227B44 File Offset: 0x00225D44
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AKuroBuildingGrid> OccupiedGrid
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_OccupiedGrid);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_OccupiedGrid) = value;
			}
		}

		// Token: 0x17005EF0 RID: 24304
		// (get) Token: 0x060178E1 RID: 96481 RVA: 0x00227B59 File Offset: 0x00225D59
		// (set) Token: 0x060178E2 RID: 96482 RVA: 0x00227B6D File Offset: 0x00225D6D
		public unsafe FKuroBuildingGridCellVector OccupiedCoords
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_OccupiedCoords);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_OccupiedCoords) = value;
			}
		}

		// Token: 0x17005EF1 RID: 24305
		// (get) Token: 0x060178E3 RID: 96483 RVA: 0x00227B82 File Offset: 0x00225D82
		// (set) Token: 0x060178E4 RID: 96484 RVA: 0x00227B92 File Offset: 0x00225D92
		public unsafe float OccupiedDegree
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_OccupiedDegree);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroGridLevelActor.__PropertyOffset_OccupiedDegree) = value;
			}
		}

		// Token: 0x060178E5 RID: 96485 RVA: 0x00227BA3 File Offset: 0x00225DA3
		public bool SetState(FName StateName, float InPlayRate = 1f)
		{
			return AKuroGridLevelActor.__SetState_Internal(base.NativePtr, StateName, InPlayRate);
		}

		// Token: 0x060178E6 RID: 96486 RVA: 0x00227BB2 File Offset: 0x00225DB2
		public bool SetLayerState(FName LayerName, FName StateName, float InPlayRate = 1f)
		{
			return AKuroGridLevelActor.__SetLayerState_Internal(base.NativePtr, LayerName, StateName, InPlayRate);
		}

		// Token: 0x060178E7 RID: 96487 RVA: 0x00227BC2 File Offset: 0x00225DC2
		public void SetDirection(FVector Direction)
		{
			AKuroGridLevelActor.__SetDirection_Internal(base.NativePtr, Direction);
		}

		// Token: 0x060178E8 RID: 96488 RVA: 0x00227BD0 File Offset: 0x00225DD0
		public virtual void OnLevelShown()
		{
			AKuroGridLevelActor.__OnLevelShown_Internal(base.NativePtr);
		}

		// Token: 0x060178E9 RID: 96489 RVA: 0x00227BDD File Offset: 0x00225DDD
		protected virtual void OnLevelShown_Implementation()
		{
			AKuroGridLevelActor.__OnLevelShown_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x060178EA RID: 96490 RVA: 0x00227BEA File Offset: 0x00225DEA
		public void OnLevelLoaded()
		{
			AKuroGridLevelActor.__OnLevelLoaded_Internal(base.NativePtr);
		}

		// Token: 0x060178EB RID: 96491 RVA: 0x00227BF7 File Offset: 0x00225DF7
		public bool IsLevelShown()
		{
			return AKuroGridLevelActor.__IsLevelShown_Internal(base.NativePtr);
		}

		// Token: 0x060178EC RID: 96492 RVA: 0x00227C04 File Offset: 0x00225E04
		public bool IsLevelLoaded()
		{
			return AKuroGridLevelActor.__IsLevelLoaded_Internal(base.NativePtr);
		}

		// Token: 0x060178ED RID: 96493 RVA: 0x00227C11 File Offset: 0x00225E11
		public void Initialize(TSoftObjectPtr<UWorld> InWorldAsset, in FKuroBuildingGridCellVector InGridSize)
		{
			AKuroGridLevelActor.__Initialize_Internal(base.NativePtr, (InWorldAsset ?? new TSoftObjectPtr<UWorld>()).NativePtr, InGridSize);
		}

		// Token: 0x060178EE RID: 96494 RVA: 0x00227C2E File Offset: 0x00225E2E
		[NullableContext(2)]
		public UKuroLevelStateMachineComponent GetLevelStateMachineComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroLevelStateMachineComponent>(AKuroGridLevelActor.__GetLevelStateMachineComponent_Internal(base.NativePtr));
		}

		// Token: 0x060178EF RID: 96495 RVA: 0x00227C40 File Offset: 0x00225E40
		public FName GetLayerState(FName LayerName)
		{
			return AKuroGridLevelActor.__GetLayerState_Internal(base.NativePtr, LayerName);
		}

		// Token: 0x060178F0 RID: 96496 RVA: 0x00227C4E File Offset: 0x00225E4E
		public FName GetCurrentState()
		{
			return AKuroGridLevelActor.__GetCurrentState_Internal(base.NativePtr);
		}

		// Token: 0x060178F1 RID: 96497
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetState_Internal(IntPtr @this, FName StateName, float InPlayRate);

		// Token: 0x060178F2 RID: 96498
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetLayerState_Internal(IntPtr @this, FName LayerName, FName StateName, float InPlayRate);

		// Token: 0x060178F3 RID: 96499
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDirection_Internal(IntPtr @this, FVector Direction);

		// Token: 0x060178F4 RID: 96500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLevelShown_Internal(IntPtr @this);

		// Token: 0x060178F5 RID: 96501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLevelShown_Implementation_Internal(IntPtr @this);

		// Token: 0x060178F6 RID: 96502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLevelLoaded_Internal(IntPtr @this);

		// Token: 0x060178F7 RID: 96503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLevelShown_Internal(IntPtr @this);

		// Token: 0x060178F8 RID: 96504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLevelLoaded_Internal(IntPtr @this);

		// Token: 0x060178F9 RID: 96505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Initialize_Internal(IntPtr @this, IntPtr InWorldAsset, in FKuroBuildingGridCellVector InGridSize);

		// Token: 0x060178FA RID: 96506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLevelStateMachineComponent_Internal(IntPtr @this);

		// Token: 0x060178FB RID: 96507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetLayerState_Internal(IntPtr @this, FName LayerName);

		// Token: 0x060178FC RID: 96508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetCurrentState_Internal(IntPtr @this);

		// Token: 0x060178FD RID: 96509 RVA: 0x00227C5B File Offset: 0x00225E5B
		static AKuroGridLevelActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroGridLevelActor");
		}

		// Token: 0x060178FE RID: 96510 RVA: 0x00227C69 File Offset: 0x00225E69
		protected AKuroGridLevelActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CC94 RID: 52372
		internal static int __InterfaceOffset_IKuroBuildingGridPlaceholderInterface;

		// Token: 0x0400CC95 RID: 52373
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroGridLevelActor";

		// Token: 0x0400CC96 RID: 52374
		private static IntPtr _ClassPtr;

		// Token: 0x0400CC97 RID: 52375
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CC98 RID: 52376
		internal static int __PropertyOffset_WorldAsset;

		// Token: 0x0400CC99 RID: 52377
		internal static int __PropertyOffset_GridSize;

		// Token: 0x0400CC9A RID: 52378
		internal static int __PropertyOffset_RotatableParts;

		// Token: 0x0400CC9B RID: 52379
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroGridLevelRotationAxisConstraints> _RotatableParts;

		// Token: 0x0400CC9C RID: 52380
		internal static int __PropertyOffset_LevelStateMachineComponent;

		// Token: 0x0400CC9D RID: 52381
		internal static int __PropertyOffset_OccupiedGrid;

		// Token: 0x0400CC9E RID: 52382
		internal static int __PropertyOffset_OccupiedCoords;

		// Token: 0x0400CC9F RID: 52383
		internal static int __PropertyOffset_OccupiedDegree;
	}
}
