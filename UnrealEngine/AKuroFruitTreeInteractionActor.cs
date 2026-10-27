using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B04 RID: 6916
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFruitTreeInteractionActor")]
	[UnrealStructLayout(1712, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1712)]
	public class AKuroFruitTreeInteractionActor : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019E21 RID: 106017 RVA: 0x00263601 File Offset: 0x00261801
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroFruitTreeInteractionActor._ClassPtr;
		}

		// Token: 0x06019E22 RID: 106018 RVA: 0x00263610 File Offset: 0x00261810
		public AKuroFruitTreeInteractionActor() : this(BuiltinUtils.AllocNativeUObject(AKuroFruitTreeInteractionActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019E23 RID: 106019 RVA: 0x00263638 File Offset: 0x00261838
		public AKuroFruitTreeInteractionActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroFruitTreeInteractionActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170067B5 RID: 26549
		// (get) Token: 0x06019E24 RID: 106020 RVA: 0x0026366B File Offset: 0x0026186B
		// (set) Token: 0x06019E25 RID: 106021 RVA: 0x0026367F File Offset: 0x0026187F
		[Nullable(2)]
		public unsafe USceneComponent RootScene
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFruitTreeInteractionActor.__PropertyOffset_RootScene);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFruitTreeInteractionActor.__PropertyOffset_RootScene, value);
			}
		}

		// Token: 0x170067B6 RID: 26550
		// (get) Token: 0x06019E26 RID: 106022 RVA: 0x00263694 File Offset: 0x00261894
		// (set) Token: 0x06019E27 RID: 106023 RVA: 0x002636A8 File Offset: 0x002618A8
		[Nullable(2)]
		public unsafe UStaticMeshComponent TreeMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFruitTreeInteractionActor.__PropertyOffset_TreeMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFruitTreeInteractionActor.__PropertyOffset_TreeMesh, value);
			}
		}

		// Token: 0x170067B7 RID: 26551
		// (get) Token: 0x06019E28 RID: 106024 RVA: 0x002636BD File Offset: 0x002618BD
		// (set) Token: 0x06019E29 RID: 106025 RVA: 0x002636D1 File Offset: 0x002618D1
		[Nullable(2)]
		public unsafe UBoxComponent KillBounds
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFruitTreeInteractionActor.__PropertyOffset_KillBounds);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFruitTreeInteractionActor.__PropertyOffset_KillBounds, value);
			}
		}

		// Token: 0x170067B8 RID: 26552
		// (get) Token: 0x06019E2A RID: 106026 RVA: 0x002636E6 File Offset: 0x002618E6
		// (set) Token: 0x06019E2B RID: 106027 RVA: 0x002636FA File Offset: 0x002618FA
		[Nullable(2)]
		public unsafe UInstancedStaticMeshComponent FruitISM
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFruitTreeInteractionActor.__PropertyOffset_FruitISM);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFruitTreeInteractionActor.__PropertyOffset_FruitISM, value);
			}
		}

		// Token: 0x170067B9 RID: 26553
		// (get) Token: 0x06019E2C RID: 106028 RVA: 0x0026370F File Offset: 0x0026190F
		// (set) Token: 0x06019E2D RID: 106029 RVA: 0x00263723 File Offset: 0x00261923
		[Nullable(2)]
		public unsafe UStaticMesh FruitMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFruitTreeInteractionActor.__PropertyOffset_FruitMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFruitTreeInteractionActor.__PropertyOffset_FruitMesh, value);
			}
		}

		// Token: 0x170067BA RID: 26554
		// (get) Token: 0x06019E2E RID: 106030 RVA: 0x00263738 File Offset: 0x00261938
		// (set) Token: 0x06019E2F RID: 106031 RVA: 0x00263771 File Offset: 0x00261971
		public TArray<UMaterialInterface> FruitMaterialOverrides
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._FruitMaterialOverrides) == null)
				{
					result = (this._FruitMaterialOverrides = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_FruitMaterialOverrides, this));
				}
				return result;
			}
			set
			{
				this.FruitMaterialOverrides.CopyAssign(value);
			}
		}

		// Token: 0x170067BB RID: 26555
		// (get) Token: 0x06019E30 RID: 106032 RVA: 0x00263780 File Offset: 0x00261980
		// (set) Token: 0x06019E31 RID: 106033 RVA: 0x002637B9 File Offset: 0x002619B9
		public TArray<UMaterialInterface> FallenFruitMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._FallenFruitMaterials) == null)
				{
					result = (this._FallenFruitMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_FallenFruitMaterials, this));
				}
				return result;
			}
			set
			{
				this.FallenFruitMaterials.CopyAssign(value);
			}
		}

		// Token: 0x170067BC RID: 26556
		// (get) Token: 0x06019E32 RID: 106034 RVA: 0x002637C7 File Offset: 0x002619C7
		// (set) Token: 0x06019E33 RID: 106035 RVA: 0x002637DB File Offset: 0x002619DB
		[Nullable(2)]
		public unsafe UPhysicalMaterial FruitPhysicalMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFruitTreeInteractionActor.__PropertyOffset_FruitPhysicalMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroFruitTreeInteractionActor.__PropertyOffset_FruitPhysicalMaterial, value);
			}
		}

		// Token: 0x170067BD RID: 26557
		// (get) Token: 0x06019E34 RID: 106036 RVA: 0x002637F0 File Offset: 0x002619F0
		// (set) Token: 0x06019E35 RID: 106037 RVA: 0x00263829 File Offset: 0x00261A29
		public TArray<FVector> LocalPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._LocalPoints) == null)
				{
					result = (this._LocalPoints = new TArray<FVector>(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_LocalPoints, this));
				}
				return result;
			}
			set
			{
				this.LocalPoints.CopyAssign(value);
			}
		}

		// Token: 0x170067BE RID: 26558
		// (get) Token: 0x06019E36 RID: 106038 RVA: 0x00263838 File Offset: 0x00261A38
		// (set) Token: 0x06019E37 RID: 106039 RVA: 0x00263871 File Offset: 0x00261A71
		public TArray<FVector> PivotPainterData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PivotPainterData) == null)
				{
					result = (this._PivotPainterData = new TArray<FVector>(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_PivotPainterData, this));
				}
				return result;
			}
			set
			{
				this.PivotPainterData.CopyAssign(value);
			}
		}

		// Token: 0x170067BF RID: 26559
		// (get) Token: 0x06019E38 RID: 106040 RVA: 0x0026387F File Offset: 0x00261A7F
		// (set) Token: 0x06019E39 RID: 106041 RVA: 0x0026388F File Offset: 0x00261A8F
		public unsafe int MaxFruitCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_MaxFruitCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_MaxFruitCount) = value;
			}
		}

		// Token: 0x170067C0 RID: 26560
		// (get) Token: 0x06019E3A RID: 106042 RVA: 0x002638A0 File Offset: 0x00261AA0
		// (set) Token: 0x06019E3B RID: 106043 RVA: 0x002638B4 File Offset: 0x00261AB4
		public unsafe FVector2D RandomScaleRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_RandomScaleRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_RandomScaleRange) = value;
			}
		}

		// Token: 0x170067C1 RID: 26561
		// (get) Token: 0x06019E3C RID: 106044 RVA: 0x002638C9 File Offset: 0x00261AC9
		// (set) Token: 0x06019E3D RID: 106045 RVA: 0x002638D9 File Offset: 0x00261AD9
		public unsafe int RandomSeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_RandomSeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_RandomSeed) = value;
			}
		}

		// Token: 0x170067C2 RID: 26562
		// (get) Token: 0x06019E3E RID: 106046 RVA: 0x002638EA File Offset: 0x00261AEA
		// (set) Token: 0x06019E3F RID: 106047 RVA: 0x002638FE File Offset: 0x00261AFE
		public unsafe FName CollisionProfile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_CollisionProfile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_CollisionProfile) = value;
			}
		}

		// Token: 0x170067C3 RID: 26563
		// (get) Token: 0x06019E40 RID: 106048 RVA: 0x00263913 File Offset: 0x00261B13
		// (set) Token: 0x06019E41 RID: 106049 RVA: 0x00263923 File Offset: 0x00261B23
		public unsafe float LinearDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_LinearDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_LinearDamping) = value;
			}
		}

		// Token: 0x170067C4 RID: 26564
		// (get) Token: 0x06019E42 RID: 106050 RVA: 0x00263934 File Offset: 0x00261B34
		// (set) Token: 0x06019E43 RID: 106051 RVA: 0x00263944 File Offset: 0x00261B44
		public unsafe float AngularDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_AngularDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_AngularDamping) = value;
			}
		}

		// Token: 0x170067C5 RID: 26565
		// (get) Token: 0x06019E44 RID: 106052 RVA: 0x00263955 File Offset: 0x00261B55
		// (set) Token: 0x06019E45 RID: 106053 RVA: 0x00263965 File Offset: 0x00261B65
		public unsafe float FallenDestroyDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_FallenDestroyDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_FallenDestroyDelay) = value;
			}
		}

		// Token: 0x170067C6 RID: 26566
		// (get) Token: 0x06019E46 RID: 106054 RVA: 0x00263976 File Offset: 0x00261B76
		// (set) Token: 0x06019E47 RID: 106055 RVA: 0x00263986 File Offset: 0x00261B86
		public unsafe int MaxActiveFruits
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_MaxActiveFruits);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_MaxActiveFruits) = value;
			}
		}

		// Token: 0x170067C7 RID: 26567
		// (get) Token: 0x06019E48 RID: 106056 RVA: 0x00263997 File Offset: 0x00261B97
		// (set) Token: 0x06019E49 RID: 106057 RVA: 0x002639AB File Offset: 0x00261BAB
		public unsafe FVector2D ShakeDropCountRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_ShakeDropCountRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_ShakeDropCountRange) = value;
			}
		}

		// Token: 0x170067C8 RID: 26568
		// (get) Token: 0x06019E4A RID: 106058 RVA: 0x002639C0 File Offset: 0x00261BC0
		// (set) Token: 0x06019E4B RID: 106059 RVA: 0x002639D0 File Offset: 0x00261BD0
		public unsafe float ShakeCooldown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_ShakeCooldown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_ShakeCooldown) = value;
			}
		}

		// Token: 0x170067C9 RID: 26569
		// (get) Token: 0x06019E4C RID: 106060 RVA: 0x002639E1 File Offset: 0x00261BE1
		// (set) Token: 0x06019E4D RID: 106061 RVA: 0x002639F1 File Offset: 0x00261BF1
		public unsafe float ShakeMinSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_ShakeMinSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_ShakeMinSpeed) = value;
			}
		}

		// Token: 0x170067CA RID: 26570
		// (get) Token: 0x06019E4E RID: 106062 RVA: 0x00263A02 File Offset: 0x00261C02
		// (set) Token: 0x06019E4F RID: 106063 RVA: 0x00263A12 File Offset: 0x00261C12
		public unsafe bool bAutoActivateOnSpawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_bAutoActivateOnSpawn) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_bAutoActivateOnSpawn) = (value ? 1 : 0);
			}
		}

		// Token: 0x170067CB RID: 26571
		// (get) Token: 0x06019E50 RID: 106064 RVA: 0x00263A23 File Offset: 0x00261C23
		// (set) Token: 0x06019E51 RID: 106065 RVA: 0x00263A33 File Offset: 0x00261C33
		public unsafe float OutOfBoundsCheckInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_OutOfBoundsCheckInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_OutOfBoundsCheckInterval) = value;
			}
		}

		// Token: 0x170067CC RID: 26572
		// (get) Token: 0x06019E52 RID: 106066 RVA: 0x00263A44 File Offset: 0x00261C44
		// (set) Token: 0x06019E53 RID: 106067 RVA: 0x00263A54 File Offset: 0x00261C54
		public unsafe bool bDebugDrawInteraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_bDebugDrawInteraction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_bDebugDrawInteraction) = (value ? 1 : 0);
			}
		}

		// Token: 0x170067CD RID: 26573
		// (get) Token: 0x06019E54 RID: 106068 RVA: 0x00263A68 File Offset: 0x00261C68
		// (set) Token: 0x06019E55 RID: 106069 RVA: 0x00263AA1 File Offset: 0x00261CA1
		public TArray<FFruitDormantState> DormantStates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFruitDormantState> result;
				if ((result = this._DormantStates) == null)
				{
					result = (this._DormantStates = new TArray<FFruitDormantState>(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_DormantStates, this));
				}
				return result;
			}
			set
			{
				this.DormantStates.CopyAssign(value);
			}
		}

		// Token: 0x170067CE RID: 26574
		// (get) Token: 0x06019E56 RID: 106070 RVA: 0x00263AB0 File Offset: 0x00261CB0
		// (set) Token: 0x06019E57 RID: 106071 RVA: 0x00263AE9 File Offset: 0x00261CE9
		public TArray<FFruitActiveState> ActiveFruits
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFruitActiveState> result;
				if ((result = this._ActiveFruits) == null)
				{
					result = (this._ActiveFruits = new TArray<FFruitActiveState>(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_ActiveFruits, this));
				}
				return result;
			}
			set
			{
				this.ActiveFruits.CopyAssign(value);
			}
		}

		// Token: 0x170067CF RID: 26575
		// (get) Token: 0x06019E58 RID: 106072 RVA: 0x00263AF8 File Offset: 0x00261CF8
		// (set) Token: 0x06019E59 RID: 106073 RVA: 0x00263B31 File Offset: 0x00261D31
		public TArray<UStaticMeshComponent> FruitPool
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._FruitPool) == null)
				{
					result = (this._FruitPool = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)AKuroFruitTreeInteractionActor.__PropertyOffset_FruitPool, this));
				}
				return result;
			}
			set
			{
				this.FruitPool.CopyAssign(value);
			}
		}

		// Token: 0x06019E5A RID: 106074 RVA: 0x00263B3F File Offset: 0x00261D3F
		public int TriggerWeaponInteraction(FVectorDouble OriginPoint, float WeaponRadius)
		{
			return AKuroFruitTreeInteractionActor.__TriggerWeaponInteraction_Internal(base.NativePtr, OriginPoint, WeaponRadius);
		}

		// Token: 0x06019E5B RID: 106075 RVA: 0x00263B4E File Offset: 0x00261D4E
		public int TriggerTrunkShake(FVectorDouble OriginPoint, float Radius)
		{
			return AKuroFruitTreeInteractionActor.__TriggerTrunkShake_Internal(base.NativePtr, OriginPoint, Radius);
		}

		// Token: 0x06019E5C RID: 106076 RVA: 0x00263B5D File Offset: 0x00261D5D
		public int TriggerFruitPick(FVectorDouble OriginPoint, float WeaponRadius)
		{
			return AKuroFruitTreeInteractionActor.__TriggerFruitPick_Internal(base.NativePtr, OriginPoint, WeaponRadius);
		}

		// Token: 0x06019E5D RID: 106077 RVA: 0x00263B6C File Offset: 0x00261D6C
		public void ResetFruits()
		{
			AKuroFruitTreeInteractionActor.__ResetFruits_Internal(base.NativePtr);
		}

		// Token: 0x06019E5E RID: 106078 RVA: 0x00263B79 File Offset: 0x00261D79
		public bool IsFruitActivated(int Index)
		{
			return AKuroFruitTreeInteractionActor.__IsFruitActivated_Internal(base.NativePtr, Index);
		}

		// Token: 0x06019E5F RID: 106079 RVA: 0x00263B87 File Offset: 0x00261D87
		public int GetRemainingFruitCount()
		{
			return AKuroFruitTreeInteractionActor.__GetRemainingFruitCount_Internal(base.NativePtr);
		}

		// Token: 0x06019E60 RID: 106080 RVA: 0x00263B94 File Offset: 0x00261D94
		public int GetFruitCount()
		{
			return AKuroFruitTreeInteractionActor.__GetFruitCount_Internal(base.NativePtr);
		}

		// Token: 0x06019E61 RID: 106081 RVA: 0x00263BA1 File Offset: 0x00261DA1
		public int GetActiveFruitCount()
		{
			return AKuroFruitTreeInteractionActor.__GetActiveFruitCount_Internal(base.NativePtr);
		}

		// Token: 0x06019E62 RID: 106082 RVA: 0x00263BAE File Offset: 0x00261DAE
		public void EndFruitInteraction()
		{
			AKuroFruitTreeInteractionActor.__EndFruitInteraction_Internal(base.NativePtr);
		}

		// Token: 0x06019E63 RID: 106083 RVA: 0x00263BBB File Offset: 0x00261DBB
		public void ClearFruits()
		{
			AKuroFruitTreeInteractionActor.__ClearFruits_Internal(base.NativePtr);
		}

		// Token: 0x06019E64 RID: 106084 RVA: 0x00263BC8 File Offset: 0x00261DC8
		public void BeginFruitInteraction()
		{
			AKuroFruitTreeInteractionActor.__BeginFruitInteraction_Internal(base.NativePtr);
		}

		// Token: 0x06019E65 RID: 106085 RVA: 0x00263BD5 File Offset: 0x00261DD5
		public int ActivateFruitsInRadius(FVectorDouble HitWorldLocation, float Radius, FVector ImpulseDirection, float ImpulseStrength, bool bRadialFalloff = true)
		{
			return AKuroFruitTreeInteractionActor.__ActivateFruitsInRadius_Internal(base.NativePtr, HitWorldLocation, Radius, ImpulseDirection, ImpulseStrength, bRadialFalloff);
		}

		// Token: 0x06019E66 RID: 106086 RVA: 0x00263BE9 File Offset: 0x00261DE9
		public bool ActivateFruitAtIndex(int Index, FVector WorldImpulse)
		{
			return AKuroFruitTreeInteractionActor.__ActivateFruitAtIndex_Internal(base.NativePtr, Index, WorldImpulse);
		}

		// Token: 0x06019E67 RID: 106087 RVA: 0x00263BF8 File Offset: 0x00261DF8
		public int ActivateAllFruits(FVector WorldImpulse)
		{
			return AKuroFruitTreeInteractionActor.__ActivateAllFruits_Internal(base.NativePtr, WorldImpulse);
		}

		// Token: 0x06019E68 RID: 106088
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __TriggerWeaponInteraction_Internal(IntPtr @this, FVectorDouble OriginPoint, float WeaponRadius);

		// Token: 0x06019E69 RID: 106089
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __TriggerTrunkShake_Internal(IntPtr @this, FVectorDouble OriginPoint, float Radius);

		// Token: 0x06019E6A RID: 106090
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __TriggerFruitPick_Internal(IntPtr @this, FVectorDouble OriginPoint, float WeaponRadius);

		// Token: 0x06019E6B RID: 106091
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetFruits_Internal(IntPtr @this);

		// Token: 0x06019E6C RID: 106092
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsFruitActivated_Internal(IntPtr @this, int Index);

		// Token: 0x06019E6D RID: 106093
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRemainingFruitCount_Internal(IntPtr @this);

		// Token: 0x06019E6E RID: 106094
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetFruitCount_Internal(IntPtr @this);

		// Token: 0x06019E6F RID: 106095
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetActiveFruitCount_Internal(IntPtr @this);

		// Token: 0x06019E70 RID: 106096
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndFruitInteraction_Internal(IntPtr @this);

		// Token: 0x06019E71 RID: 106097
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearFruits_Internal(IntPtr @this);

		// Token: 0x06019E72 RID: 106098
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BeginFruitInteraction_Internal(IntPtr @this);

		// Token: 0x06019E73 RID: 106099
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __ActivateFruitsInRadius_Internal(IntPtr @this, FVectorDouble HitWorldLocation, float Radius, FVector ImpulseDirection, float ImpulseStrength, bool bRadialFalloff);

		// Token: 0x06019E74 RID: 106100
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ActivateFruitAtIndex_Internal(IntPtr @this, int Index, FVector WorldImpulse);

		// Token: 0x06019E75 RID: 106101
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __ActivateAllFruits_Internal(IntPtr @this, FVector WorldImpulse);

		// Token: 0x06019E76 RID: 106102 RVA: 0x00263C06 File Offset: 0x00261E06
		static AKuroFruitTreeInteractionActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroFruitTreeInteractionActor");
		}

		// Token: 0x06019E77 RID: 106103 RVA: 0x00263C14 File Offset: 0x00261E14
		protected AKuroFruitTreeInteractionActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E122 RID: 57634
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFruitTreeInteractionActor";

		// Token: 0x0400E123 RID: 57635
		private static IntPtr _ClassPtr;

		// Token: 0x0400E124 RID: 57636
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E125 RID: 57637
		internal static int __PropertyOffset_RootScene;

		// Token: 0x0400E126 RID: 57638
		internal static int __PropertyOffset_TreeMesh;

		// Token: 0x0400E127 RID: 57639
		internal static int __PropertyOffset_KillBounds;

		// Token: 0x0400E128 RID: 57640
		internal static int __PropertyOffset_FruitISM;

		// Token: 0x0400E129 RID: 57641
		internal static int __PropertyOffset_FruitMesh;

		// Token: 0x0400E12A RID: 57642
		internal static int __PropertyOffset_FruitMaterialOverrides;

		// Token: 0x0400E12B RID: 57643
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _FruitMaterialOverrides;

		// Token: 0x0400E12C RID: 57644
		internal static int __PropertyOffset_FallenFruitMaterials;

		// Token: 0x0400E12D RID: 57645
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _FallenFruitMaterials;

		// Token: 0x0400E12E RID: 57646
		internal static int __PropertyOffset_FruitPhysicalMaterial;

		// Token: 0x0400E12F RID: 57647
		internal static int __PropertyOffset_LocalPoints;

		// Token: 0x0400E130 RID: 57648
		[Nullable(2)]
		private TArray<FVector> _LocalPoints;

		// Token: 0x0400E131 RID: 57649
		internal static int __PropertyOffset_PivotPainterData;

		// Token: 0x0400E132 RID: 57650
		[Nullable(2)]
		private TArray<FVector> _PivotPainterData;

		// Token: 0x0400E133 RID: 57651
		internal static int __PropertyOffset_MaxFruitCount;

		// Token: 0x0400E134 RID: 57652
		internal static int __PropertyOffset_RandomScaleRange;

		// Token: 0x0400E135 RID: 57653
		internal static int __PropertyOffset_RandomSeed;

		// Token: 0x0400E136 RID: 57654
		internal static int __PropertyOffset_CollisionProfile;

		// Token: 0x0400E137 RID: 57655
		internal static int __PropertyOffset_LinearDamping;

		// Token: 0x0400E138 RID: 57656
		internal static int __PropertyOffset_AngularDamping;

		// Token: 0x0400E139 RID: 57657
		internal static int __PropertyOffset_FallenDestroyDelay;

		// Token: 0x0400E13A RID: 57658
		internal static int __PropertyOffset_MaxActiveFruits;

		// Token: 0x0400E13B RID: 57659
		internal static int __PropertyOffset_ShakeDropCountRange;

		// Token: 0x0400E13C RID: 57660
		internal static int __PropertyOffset_ShakeCooldown;

		// Token: 0x0400E13D RID: 57661
		internal static int __PropertyOffset_ShakeMinSpeed;

		// Token: 0x0400E13E RID: 57662
		internal static int __PropertyOffset_bAutoActivateOnSpawn;

		// Token: 0x0400E13F RID: 57663
		internal static int __PropertyOffset_OutOfBoundsCheckInterval;

		// Token: 0x0400E140 RID: 57664
		internal static int __PropertyOffset_bDebugDrawInteraction;

		// Token: 0x0400E141 RID: 57665
		internal static int __PropertyOffset_DormantStates;

		// Token: 0x0400E142 RID: 57666
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFruitDormantState> _DormantStates;

		// Token: 0x0400E143 RID: 57667
		internal static int __PropertyOffset_ActiveFruits;

		// Token: 0x0400E144 RID: 57668
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFruitActiveState> _ActiveFruits;

		// Token: 0x0400E145 RID: 57669
		internal static int __PropertyOffset_FruitPool;

		// Token: 0x0400E146 RID: 57670
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _FruitPool;
	}
}
