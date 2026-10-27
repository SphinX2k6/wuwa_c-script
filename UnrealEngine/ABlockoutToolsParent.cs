using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200042A RID: 1066
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/BlockoutToolsPlugin.BlockoutToolsParent")]
	[UnrealStructLayout(1200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1200)]
	public class ABlockoutToolsParent : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600393E RID: 14654 RVA: 0x00056E9D File Offset: 0x0005509D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ABlockoutToolsParent._ClassPtr;
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x00056EAC File Offset: 0x000550AC
		public ABlockoutToolsParent() : this(BuiltinUtils.AllocNativeUObject(ABlockoutToolsParent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003940 RID: 14656 RVA: 0x00056ED4 File Offset: 0x000550D4
		[NullableContext(1)]
		public ABlockoutToolsParent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABlockoutToolsParent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06003941 RID: 14657 RVA: 0x00056F07 File Offset: 0x00055107
		// (set) Token: 0x06003942 RID: 14658 RVA: 0x00056F1B File Offset: 0x0005511B
		public unsafe USceneComponent Root
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABlockoutToolsParent.__PropertyOffset_Root);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABlockoutToolsParent.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06003943 RID: 14659 RVA: 0x00056F30 File Offset: 0x00055130
		// (set) Token: 0x06003944 RID: 14660 RVA: 0x00056F44 File Offset: 0x00055144
		public unsafe UBillboardComponent Billboard
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ABlockoutToolsParent.__PropertyOffset_Billboard);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABlockoutToolsParent.__PropertyOffset_Billboard, value);
			}
		}

		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06003945 RID: 14661 RVA: 0x00056F59 File Offset: 0x00055159
		// (set) Token: 0x06003946 RID: 14662 RVA: 0x00056F6D File Offset: 0x0005516D
		public unsafe UMaterialInterface BlockoutGridParent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ABlockoutToolsParent.__PropertyOffset_BlockoutGridParent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABlockoutToolsParent.__PropertyOffset_BlockoutGridParent, value);
			}
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06003947 RID: 14663 RVA: 0x00056F82 File Offset: 0x00055182
		// (set) Token: 0x06003948 RID: 14664 RVA: 0x00056F96 File Offset: 0x00055196
		public unsafe UMaterialInstanceDynamic BlockoutGridMID
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + ABlockoutToolsParent.__PropertyOffset_BlockoutGridMID);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABlockoutToolsParent.__PropertyOffset_BlockoutGridMID, value);
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06003949 RID: 14665 RVA: 0x00056FAB File Offset: 0x000551AB
		// (set) Token: 0x0600394A RID: 14666 RVA: 0x00056FBF File Offset: 0x000551BF
		public unsafe UMaterialInterface BlockoutCurrentMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ABlockoutToolsParent.__PropertyOffset_BlockoutCurrentMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABlockoutToolsParent.__PropertyOffset_BlockoutCurrentMaterial, value);
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x0600394B RID: 14667 RVA: 0x00056FD4 File Offset: 0x000551D4
		// (set) Token: 0x0600394C RID: 14668 RVA: 0x0005700D File Offset: 0x0005520D
		[Nullable(1)]
		public TArray<UStaticMeshComponent> BlockoutMeshComponents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._BlockoutMeshComponents) == null)
				{
					result = (this._BlockoutMeshComponents = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_BlockoutMeshComponents, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BlockoutMeshComponents.CopyAssign(value);
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x0600394D RID: 14669 RVA: 0x0005701B File Offset: 0x0005521B
		// (set) Token: 0x0600394E RID: 14670 RVA: 0x0005702F File Offset: 0x0005522F
		[Nullable(0)]
		public unsafe TEnumAsByte<EBlockoutMaterialType> BlockoutMaterialType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_BlockoutMaterialType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_BlockoutMaterialType) = value;
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x0600394F RID: 14671 RVA: 0x00057044 File Offset: 0x00055244
		// (set) Token: 0x06003950 RID: 14672 RVA: 0x00057058 File Offset: 0x00055258
		public unsafe FLinearColor BlockoutMaterialColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_BlockoutMaterialColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_BlockoutMaterialColor) = value;
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06003951 RID: 14673 RVA: 0x0005706D File Offset: 0x0005526D
		// (set) Token: 0x06003952 RID: 14674 RVA: 0x0005707D File Offset: 0x0005527D
		public unsafe bool bBlockoutMaterialUseGrid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_bBlockoutMaterialUseGrid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_bBlockoutMaterialUseGrid) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06003953 RID: 14675 RVA: 0x0005708E File Offset: 0x0005528E
		// (set) Token: 0x06003954 RID: 14676 RVA: 0x0005709E File Offset: 0x0005529E
		public unsafe bool bBlockoutWorldAligned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_bBlockoutWorldAligned) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_bBlockoutWorldAligned) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06003955 RID: 14677 RVA: 0x000570AF File Offset: 0x000552AF
		// (set) Token: 0x06003956 RID: 14678 RVA: 0x000570BF File Offset: 0x000552BF
		public unsafe float BlockoutMaterialGridSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_BlockoutMaterialGridSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_BlockoutMaterialGridSize) = value;
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06003957 RID: 14679 RVA: 0x000570D0 File Offset: 0x000552D0
		// (set) Token: 0x06003958 RID: 14680 RVA: 0x000570E0 File Offset: 0x000552E0
		public unsafe float BlockoutMaterialCheckerLuminance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_BlockoutMaterialCheckerLuminance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_BlockoutMaterialCheckerLuminance) = value;
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06003959 RID: 14681 RVA: 0x000570F1 File Offset: 0x000552F1
		// (set) Token: 0x0600395A RID: 14682 RVA: 0x00057101 File Offset: 0x00055301
		public unsafe float BlockoutMaterialRoughness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_BlockoutMaterialRoughness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_BlockoutMaterialRoughness) = value;
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x0600395B RID: 14683 RVA: 0x00057112 File Offset: 0x00055312
		// (set) Token: 0x0600395C RID: 14684 RVA: 0x00057122 File Offset: 0x00055322
		public unsafe bool bBlockoutMaterialUseTopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_bBlockoutMaterialUseTopColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_bBlockoutMaterialUseTopColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x0600395D RID: 14685 RVA: 0x00057133 File Offset: 0x00055333
		// (set) Token: 0x0600395E RID: 14686 RVA: 0x00057147 File Offset: 0x00055347
		public unsafe FLinearColor BlockoutMaterialTopColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_BlockoutMaterialTopColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_BlockoutMaterialTopColor) = value;
			}
		}

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x0600395F RID: 14687 RVA: 0x0005715C File Offset: 0x0005535C
		// (set) Token: 0x06003960 RID: 14688 RVA: 0x0005716C File Offset: 0x0005536C
		public unsafe bool bUseCustomMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_bUseCustomMaterial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_bUseCustomMaterial) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06003961 RID: 14689 RVA: 0x0005717D File Offset: 0x0005537D
		// (set) Token: 0x06003962 RID: 14690 RVA: 0x00057191 File Offset: 0x00055391
		public unsafe UMaterialInterface CustomMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ABlockoutToolsParent.__PropertyOffset_CustomMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABlockoutToolsParent.__PropertyOffset_CustomMaterial, value);
			}
		}

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06003963 RID: 14691 RVA: 0x000571A6 File Offset: 0x000553A6
		// (set) Token: 0x06003964 RID: 14692 RVA: 0x000571BA File Offset: 0x000553BA
		public unsafe UMaterialInterface BlockoutCustomMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ABlockoutToolsParent.__PropertyOffset_BlockoutCustomMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ABlockoutToolsParent.__PropertyOffset_BlockoutCustomMaterial, value);
			}
		}

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06003965 RID: 14693 RVA: 0x000571CF File Offset: 0x000553CF
		// (set) Token: 0x06003966 RID: 14694 RVA: 0x000571DF File Offset: 0x000553DF
		public unsafe bool bBlockoutEnableCollisions
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_bBlockoutEnableCollisions) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_bBlockoutEnableCollisions) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06003967 RID: 14695 RVA: 0x000571F0 File Offset: 0x000553F0
		// (set) Token: 0x06003968 RID: 14696 RVA: 0x00057200 File Offset: 0x00055400
		public unsafe bool bBlockoutEnableCustomCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_bBlockoutEnableCustomCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_bBlockoutEnableCustomCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06003969 RID: 14697 RVA: 0x00057211 File Offset: 0x00055411
		// (set) Token: 0x0600396A RID: 14698 RVA: 0x00057225 File Offset: 0x00055425
		public unsafe FName BlockoutCustomCollisionProfileName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_BlockoutCustomCollisionProfileName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_BlockoutCustomCollisionProfileName) = value;
			}
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x0600396B RID: 14699 RVA: 0x0005723A File Offset: 0x0005543A
		// (set) Token: 0x0600396C RID: 14700 RVA: 0x0005724A File Offset: 0x0005544A
		public unsafe bool bBlockoutCastShadows
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_bBlockoutCastShadows) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABlockoutToolsParent.__PropertyOffset_bBlockoutCastShadows) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600396D RID: 14701 RVA: 0x0005725B File Offset: 0x0005545B
		public void RerunConstructionScript()
		{
			ABlockoutToolsParent.__RerunConstructionScript_Internal(base.NativePtr);
		}

		// Token: 0x0600396E RID: 14702 RVA: 0x00057268 File Offset: 0x00055468
		public void BlockoutSetMaterial()
		{
			ABlockoutToolsParent.__BlockoutSetMaterial_Internal(base.NativePtr);
		}

		// Token: 0x0600396F RID: 14703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RerunConstructionScript_Internal(IntPtr @this);

		// Token: 0x06003970 RID: 14704
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BlockoutSetMaterial_Internal(IntPtr @this);

		// Token: 0x06003971 RID: 14705 RVA: 0x00057275 File Offset: 0x00055475
		static ABlockoutToolsParent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/BlockoutToolsPlugin.BlockoutToolsParent");
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x00057283 File Offset: 0x00055483
		protected ABlockoutToolsParent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040019FC RID: 6652
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/BlockoutToolsPlugin.BlockoutToolsParent";

		// Token: 0x040019FD RID: 6653
		private static IntPtr _ClassPtr;

		// Token: 0x040019FE RID: 6654
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040019FF RID: 6655
		internal static int __PropertyOffset_Root;

		// Token: 0x04001A00 RID: 6656
		internal static int __PropertyOffset_Billboard;

		// Token: 0x04001A01 RID: 6657
		internal static int __PropertyOffset_BlockoutGridParent;

		// Token: 0x04001A02 RID: 6658
		internal static int __PropertyOffset_BlockoutGridMID;

		// Token: 0x04001A03 RID: 6659
		internal static int __PropertyOffset_BlockoutCurrentMaterial;

		// Token: 0x04001A04 RID: 6660
		internal static int __PropertyOffset_BlockoutMeshComponents;

		// Token: 0x04001A05 RID: 6661
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _BlockoutMeshComponents;

		// Token: 0x04001A06 RID: 6662
		internal static int __PropertyOffset_BlockoutMaterialType;

		// Token: 0x04001A07 RID: 6663
		internal static int __PropertyOffset_BlockoutMaterialColor;

		// Token: 0x04001A08 RID: 6664
		internal static int __PropertyOffset_bBlockoutMaterialUseGrid;

		// Token: 0x04001A09 RID: 6665
		internal static int __PropertyOffset_bBlockoutWorldAligned;

		// Token: 0x04001A0A RID: 6666
		internal static int __PropertyOffset_BlockoutMaterialGridSize;

		// Token: 0x04001A0B RID: 6667
		internal static int __PropertyOffset_BlockoutMaterialCheckerLuminance;

		// Token: 0x04001A0C RID: 6668
		internal static int __PropertyOffset_BlockoutMaterialRoughness;

		// Token: 0x04001A0D RID: 6669
		internal static int __PropertyOffset_bBlockoutMaterialUseTopColor;

		// Token: 0x04001A0E RID: 6670
		internal static int __PropertyOffset_BlockoutMaterialTopColor;

		// Token: 0x04001A0F RID: 6671
		internal static int __PropertyOffset_bUseCustomMaterial;

		// Token: 0x04001A10 RID: 6672
		internal static int __PropertyOffset_CustomMaterial;

		// Token: 0x04001A11 RID: 6673
		internal static int __PropertyOffset_BlockoutCustomMaterial;

		// Token: 0x04001A12 RID: 6674
		internal static int __PropertyOffset_bBlockoutEnableCollisions;

		// Token: 0x04001A13 RID: 6675
		internal static int __PropertyOffset_bBlockoutEnableCustomCollision;

		// Token: 0x04001A14 RID: 6676
		internal static int __PropertyOffset_BlockoutCustomCollisionProfileName;

		// Token: 0x04001A15 RID: 6677
		internal static int __PropertyOffset_bBlockoutCastShadows;
	}
}
