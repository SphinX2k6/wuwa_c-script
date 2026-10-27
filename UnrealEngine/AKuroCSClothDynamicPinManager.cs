using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017A7 RID: 6055
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSClothDynamicPinManager")]
	[UnrealStructLayout(1720, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1720)]
	public class AKuroCSClothDynamicPinManager : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015E14 RID: 89620 RVA: 0x00201C9B File Offset: 0x001FFE9B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSClothDynamicPinManager._ClassPtr;
		}

		// Token: 0x06015E15 RID: 89621 RVA: 0x00201CA8 File Offset: 0x001FFEA8
		public AKuroCSClothDynamicPinManager() : this(BuiltinUtils.AllocNativeUObject(AKuroCSClothDynamicPinManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015E16 RID: 89622 RVA: 0x00201CD0 File Offset: 0x001FFED0
		public AKuroCSClothDynamicPinManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSClothDynamicPinManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170056D4 RID: 22228
		// (get) Token: 0x06015E17 RID: 89623 RVA: 0x00201D04 File Offset: 0x001FFF04
		// (set) Token: 0x06015E18 RID: 89624 RVA: 0x00201D3D File Offset: 0x001FFF3D
		public TArray<AActor> MeshActorArrayList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._MeshActorArrayList) == null)
				{
					result = (this._MeshActorArrayList = new TArray<AActor>(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_MeshActorArrayList, this));
				}
				return result;
			}
			set
			{
				this.MeshActorArrayList.CopyAssign(value);
			}
		}

		// Token: 0x170056D5 RID: 22229
		// (get) Token: 0x06015E19 RID: 89625 RVA: 0x00201D4B File Offset: 0x001FFF4B
		// (set) Token: 0x06015E1A RID: 89626 RVA: 0x00201D5B File Offset: 0x001FFF5B
		public unsafe bool bAutoBuildAndStartOnBeginPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bAutoBuildAndStartOnBeginPlay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bAutoBuildAndStartOnBeginPlay) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056D6 RID: 22230
		// (get) Token: 0x06015E1B RID: 89627 RVA: 0x00201D6C File Offset: 0x001FFF6C
		// (set) Token: 0x06015E1C RID: 89628 RVA: 0x00201DA5 File Offset: 0x001FFFA5
		public TArray<FKuroCSClothDynamicPinBinding> PinBindingList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSClothDynamicPinBinding> result;
				if ((result = this._PinBindingList) == null)
				{
					result = (this._PinBindingList = new TArray<FKuroCSClothDynamicPinBinding>(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_PinBindingList, this));
				}
				return result;
			}
			set
			{
				this.PinBindingList.CopyAssign(value);
			}
		}

		// Token: 0x170056D7 RID: 22231
		// (get) Token: 0x06015E1D RID: 89629 RVA: 0x00201DB3 File Offset: 0x001FFFB3
		// (set) Token: 0x06015E1E RID: 89630 RVA: 0x00201DC7 File Offset: 0x001FFFC7
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSClothDynamicPinManager.__PropertyOffset_RenderTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSClothDynamicPinManager.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x170056D8 RID: 22232
		// (get) Token: 0x06015E1F RID: 89631 RVA: 0x00201DDC File Offset: 0x001FFFDC
		// (set) Token: 0x06015E20 RID: 89632 RVA: 0x00201DEC File Offset: 0x001FFFEC
		public unsafe bool bAutoCreateRenderTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bAutoCreateRenderTarget) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bAutoCreateRenderTarget) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056D9 RID: 22233
		// (get) Token: 0x06015E21 RID: 89633 RVA: 0x00201DFD File Offset: 0x001FFFFD
		// (set) Token: 0x06015E22 RID: 89634 RVA: 0x00201E0D File Offset: 0x0020000D
		public unsafe int XCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_XCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_XCount) = value;
			}
		}

		// Token: 0x170056DA RID: 22234
		// (get) Token: 0x06015E23 RID: 89635 RVA: 0x00201E1E File Offset: 0x0020001E
		// (set) Token: 0x06015E24 RID: 89636 RVA: 0x00201E2E File Offset: 0x0020002E
		public unsafe int YCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_YCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_YCount) = value;
			}
		}

		// Token: 0x170056DB RID: 22235
		// (get) Token: 0x06015E25 RID: 89637 RVA: 0x00201E3F File Offset: 0x0020003F
		// (set) Token: 0x06015E26 RID: 89638 RVA: 0x00201E4F File Offset: 0x0020004F
		public unsafe float FallbackWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_FallbackWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_FallbackWidth) = value;
			}
		}

		// Token: 0x170056DC RID: 22236
		// (get) Token: 0x06015E27 RID: 89639 RVA: 0x00201E60 File Offset: 0x00200060
		// (set) Token: 0x06015E28 RID: 89640 RVA: 0x00201E70 File Offset: 0x00200070
		public unsafe float FallbackHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_FallbackHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_FallbackHeight) = value;
			}
		}

		// Token: 0x170056DD RID: 22237
		// (get) Token: 0x06015E29 RID: 89641 RVA: 0x00201E81 File Offset: 0x00200081
		// (set) Token: 0x06015E2A RID: 89642 RVA: 0x00201E91 File Offset: 0x00200091
		public unsafe bool bUseActorBoundsForPinSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bUseActorBoundsForPinSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bUseActorBoundsForPinSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056DE RID: 22238
		// (get) Token: 0x06015E2B RID: 89643 RVA: 0x00201EA2 File Offset: 0x002000A2
		// (set) Token: 0x06015E2C RID: 89644 RVA: 0x00201EB6 File Offset: 0x002000B6
		public unsafe FVector LocalRightDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_LocalRightDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_LocalRightDir) = value;
			}
		}

		// Token: 0x170056DF RID: 22239
		// (get) Token: 0x06015E2D RID: 89645 RVA: 0x00201ECB File Offset: 0x002000CB
		// (set) Token: 0x06015E2E RID: 89646 RVA: 0x00201EDF File Offset: 0x002000DF
		public unsafe FVector LocalDownDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_LocalDownDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_LocalDownDir) = value;
			}
		}

		// Token: 0x170056E0 RID: 22240
		// (get) Token: 0x06015E2F RID: 89647 RVA: 0x00201EF4 File Offset: 0x002000F4
		// (set) Token: 0x06015E30 RID: 89648 RVA: 0x00201F08 File Offset: 0x00200108
		public unsafe FVector AccelExt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_AccelExt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_AccelExt) = value;
			}
		}

		// Token: 0x170056E1 RID: 22241
		// (get) Token: 0x06015E31 RID: 89649 RVA: 0x00201F1D File Offset: 0x0020011D
		// (set) Token: 0x06015E32 RID: 89650 RVA: 0x00201F2D File Offset: 0x0020012D
		public unsafe float DeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DeltaTime) = value;
			}
		}

		// Token: 0x170056E2 RID: 22242
		// (get) Token: 0x06015E33 RID: 89651 RVA: 0x00201F3E File Offset: 0x0020013E
		// (set) Token: 0x06015E34 RID: 89652 RVA: 0x00201F4E File Offset: 0x0020014E
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DisStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DisStiffness) = value;
			}
		}

		// Token: 0x170056E3 RID: 22243
		// (get) Token: 0x06015E35 RID: 89653 RVA: 0x00201F5F File Offset: 0x0020015F
		// (set) Token: 0x06015E36 RID: 89654 RVA: 0x00201F6F File Offset: 0x0020016F
		public unsafe float VelocityDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_VelocityDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_VelocityDamping) = value;
			}
		}

		// Token: 0x170056E4 RID: 22244
		// (get) Token: 0x06015E37 RID: 89655 RVA: 0x00201F80 File Offset: 0x00200180
		// (set) Token: 0x06015E38 RID: 89656 RVA: 0x00201F90 File Offset: 0x00200190
		public unsafe int SubstepCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_SubstepCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_SubstepCount) = value;
			}
		}

		// Token: 0x170056E5 RID: 22245
		// (get) Token: 0x06015E39 RID: 89657 RVA: 0x00201FA1 File Offset: 0x002001A1
		// (set) Token: 0x06015E3A RID: 89658 RVA: 0x00201FB1 File Offset: 0x002001B1
		public unsafe bool bDebugDrawPhysicsPoints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bDebugDrawPhysicsPoints) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bDebugDrawPhysicsPoints) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056E6 RID: 22246
		// (get) Token: 0x06015E3B RID: 89659 RVA: 0x00201FC2 File Offset: 0x002001C2
		// (set) Token: 0x06015E3C RID: 89660 RVA: 0x00201FD2 File Offset: 0x002001D2
		public unsafe bool bDebugReadbackSimParticles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bDebugReadbackSimParticles) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bDebugReadbackSimParticles) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056E7 RID: 22247
		// (get) Token: 0x06015E3D RID: 89661 RVA: 0x00201FE3 File Offset: 0x002001E3
		// (set) Token: 0x06015E3E RID: 89662 RVA: 0x00201FF3 File Offset: 0x002001F3
		public unsafe int DebugReadbackInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DebugReadbackInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DebugReadbackInterval) = value;
			}
		}

		// Token: 0x170056E8 RID: 22248
		// (get) Token: 0x06015E3F RID: 89663 RVA: 0x00202004 File Offset: 0x00200204
		// (set) Token: 0x06015E40 RID: 89664 RVA: 0x00202014 File Offset: 0x00200214
		public unsafe bool bDebugDrawPhysicsLinks
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bDebugDrawPhysicsLinks) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bDebugDrawPhysicsLinks) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056E9 RID: 22249
		// (get) Token: 0x06015E41 RID: 89665 RVA: 0x00202025 File Offset: 0x00200225
		// (set) Token: 0x06015E42 RID: 89666 RVA: 0x00202035 File Offset: 0x00200235
		public unsafe float DebugPointSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DebugPointSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DebugPointSize) = value;
			}
		}

		// Token: 0x170056EA RID: 22250
		// (get) Token: 0x06015E43 RID: 89667 RVA: 0x00202046 File Offset: 0x00200246
		// (set) Token: 0x06015E44 RID: 89668 RVA: 0x00202056 File Offset: 0x00200256
		public unsafe float DebugLineThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DebugLineThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DebugLineThickness) = value;
			}
		}

		// Token: 0x170056EB RID: 22251
		// (get) Token: 0x06015E45 RID: 89669 RVA: 0x00202067 File Offset: 0x00200267
		// (set) Token: 0x06015E46 RID: 89670 RVA: 0x00202077 File Offset: 0x00200277
		public unsafe float DebugDrawDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DebugDrawDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DebugDrawDuration) = value;
			}
		}

		// Token: 0x170056EC RID: 22252
		// (get) Token: 0x06015E47 RID: 89671 RVA: 0x00202088 File Offset: 0x00200288
		// (set) Token: 0x06015E48 RID: 89672 RVA: 0x0020209C File Offset: 0x0020029C
		public unsafe FColor DebugActivePointColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DebugActivePointColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DebugActivePointColor) = value;
			}
		}

		// Token: 0x170056ED RID: 22253
		// (get) Token: 0x06015E49 RID: 89673 RVA: 0x002020B1 File Offset: 0x002002B1
		// (set) Token: 0x06015E4A RID: 89674 RVA: 0x002020C5 File Offset: 0x002002C5
		public unsafe FColor DebugInactivePointColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DebugInactivePointColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DebugInactivePointColor) = value;
			}
		}

		// Token: 0x170056EE RID: 22254
		// (get) Token: 0x06015E4B RID: 89675 RVA: 0x002020DA File Offset: 0x002002DA
		// (set) Token: 0x06015E4C RID: 89676 RVA: 0x002020EE File Offset: 0x002002EE
		public unsafe FColor DebugPinPointColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DebugPinPointColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DebugPinPointColor) = value;
			}
		}

		// Token: 0x170056EF RID: 22255
		// (get) Token: 0x06015E4D RID: 89677 RVA: 0x00202103 File Offset: 0x00200303
		// (set) Token: 0x06015E4E RID: 89678 RVA: 0x00202117 File Offset: 0x00200317
		public unsafe FColor DebugReadbackPointColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DebugReadbackPointColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DebugReadbackPointColor) = value;
			}
		}

		// Token: 0x170056F0 RID: 22256
		// (get) Token: 0x06015E4F RID: 89679 RVA: 0x0020212C File Offset: 0x0020032C
		// (set) Token: 0x06015E50 RID: 89680 RVA: 0x00202140 File Offset: 0x00200340
		public unsafe FColor DebugLinkColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DebugLinkColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_DebugLinkColor) = value;
			}
		}

		// Token: 0x170056F1 RID: 22257
		// (get) Token: 0x06015E51 RID: 89681 RVA: 0x00202155 File Offset: 0x00200355
		// (set) Token: 0x06015E52 RID: 89682 RVA: 0x00202165 File Offset: 0x00200365
		public unsafe int AtlasSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_AtlasSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_AtlasSize) = value;
			}
		}

		// Token: 0x170056F2 RID: 22258
		// (get) Token: 0x06015E53 RID: 89683 RVA: 0x00202176 File Offset: 0x00200376
		// (set) Token: 0x06015E54 RID: 89684 RVA: 0x00202186 File Offset: 0x00200386
		public unsafe int TileWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_TileWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_TileWidth) = value;
			}
		}

		// Token: 0x170056F3 RID: 22259
		// (get) Token: 0x06015E55 RID: 89685 RVA: 0x00202197 File Offset: 0x00200397
		// (set) Token: 0x06015E56 RID: 89686 RVA: 0x002021A7 File Offset: 0x002003A7
		public unsafe int TileHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_TileHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_TileHeight) = value;
			}
		}

		// Token: 0x170056F4 RID: 22260
		// (get) Token: 0x06015E57 RID: 89687 RVA: 0x002021B8 File Offset: 0x002003B8
		// (set) Token: 0x06015E58 RID: 89688 RVA: 0x002021C8 File Offset: 0x002003C8
		public unsafe bool bApplyMaterialParameters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bApplyMaterialParameters) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bApplyMaterialParameters) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056F5 RID: 22261
		// (get) Token: 0x06015E59 RID: 89689 RVA: 0x002021D9 File Offset: 0x002003D9
		// (set) Token: 0x06015E5A RID: 89690 RVA: 0x002021E9 File Offset: 0x002003E9
		public unsafe bool bApplyAtlasCustomPrimitiveData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bApplyAtlasCustomPrimitiveData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bApplyAtlasCustomPrimitiveData) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056F6 RID: 22262
		// (get) Token: 0x06015E5B RID: 89691 RVA: 0x002021FA File Offset: 0x002003FA
		// (set) Token: 0x06015E5C RID: 89692 RVA: 0x0020220A File Offset: 0x0020040A
		public unsafe bool bApplyAtlasTextureParameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bApplyAtlasTextureParameter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bApplyAtlasTextureParameter) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056F7 RID: 22263
		// (get) Token: 0x06015E5D RID: 89693 RVA: 0x0020221B File Offset: 0x0020041B
		// (set) Token: 0x06015E5E RID: 89694 RVA: 0x0020222B File Offset: 0x0020042B
		public unsafe bool bApplyClothMinAndMaxParameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bApplyClothMinAndMaxParameter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_bApplyClothMinAndMaxParameter) = (value ? 1 : 0);
			}
		}

		// Token: 0x170056F8 RID: 22264
		// (get) Token: 0x06015E5F RID: 89695 RVA: 0x0020223C File Offset: 0x0020043C
		// (set) Token: 0x06015E60 RID: 89696 RVA: 0x0020224C File Offset: 0x0020044C
		public unsafe int AtlasUVRectCustomDataStartIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_AtlasUVRectCustomDataStartIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_AtlasUVRectCustomDataStartIndex) = value;
			}
		}

		// Token: 0x170056F9 RID: 22265
		// (get) Token: 0x06015E61 RID: 89697 RVA: 0x0020225D File Offset: 0x0020045D
		// (set) Token: 0x06015E62 RID: 89698 RVA: 0x00202271 File Offset: 0x00200471
		public unsafe FName AtlasTextureParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_AtlasTextureParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_AtlasTextureParameterName) = value;
			}
		}

		// Token: 0x170056FA RID: 22266
		// (get) Token: 0x06015E63 RID: 89699 RVA: 0x00202286 File Offset: 0x00200486
		// (set) Token: 0x06015E64 RID: 89700 RVA: 0x0020229A File Offset: 0x0020049A
		public unsafe FName AtlasUVOffsetParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_AtlasUVOffsetParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_AtlasUVOffsetParameterName) = value;
			}
		}

		// Token: 0x170056FB RID: 22267
		// (get) Token: 0x06015E65 RID: 89701 RVA: 0x002022AF File Offset: 0x002004AF
		// (set) Token: 0x06015E66 RID: 89702 RVA: 0x002022C3 File Offset: 0x002004C3
		public unsafe FName AtlasUVScaleParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_AtlasUVScaleParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_AtlasUVScaleParameterName) = value;
			}
		}

		// Token: 0x170056FC RID: 22268
		// (get) Token: 0x06015E67 RID: 89703 RVA: 0x002022D8 File Offset: 0x002004D8
		// (set) Token: 0x06015E68 RID: 89704 RVA: 0x002022EC File Offset: 0x002004EC
		public unsafe FName AtlasSlotParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_AtlasSlotParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_AtlasSlotParameterName) = value;
			}
		}

		// Token: 0x170056FD RID: 22269
		// (get) Token: 0x06015E69 RID: 89705 RVA: 0x00202301 File Offset: 0x00200501
		// (set) Token: 0x06015E6A RID: 89706 RVA: 0x00202315 File Offset: 0x00200515
		public unsafe FName ClothMinAndMaxParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_ClothMinAndMaxParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSClothDynamicPinManager.__PropertyOffset_ClothMinAndMaxParameterName) = value;
			}
		}

		// Token: 0x170056FE RID: 22270
		// (get) Token: 0x06015E6B RID: 89707 RVA: 0x0020232A File Offset: 0x0020052A
		// (set) Token: 0x06015E6C RID: 89708 RVA: 0x0020233E File Offset: 0x0020053E
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D AutoCreatedRenderTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSClothDynamicPinManager.__PropertyOffset_AutoCreatedRenderTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSClothDynamicPinManager.__PropertyOffset_AutoCreatedRenderTarget, value);
			}
		}

		// Token: 0x06015E6D RID: 89709 RVA: 0x00202353 File Offset: 0x00200553
		public void TickDynamicPinManager(float InDeltaTime)
		{
			AKuroCSClothDynamicPinManager.__TickDynamicPinManager_Internal(base.NativePtr, InDeltaTime);
		}

		// Token: 0x06015E6E RID: 89710 RVA: 0x00202361 File Offset: 0x00200561
		public void StopSimulation()
		{
			AKuroCSClothDynamicPinManager.__StopSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06015E6F RID: 89711 RVA: 0x0020236E File Offset: 0x0020056E
		public void StopAndRelease()
		{
			AKuroCSClothDynamicPinManager.__StopAndRelease_Internal(base.NativePtr);
		}

		// Token: 0x06015E70 RID: 89712 RVA: 0x0020237B File Offset: 0x0020057B
		public void StartSimulation()
		{
			AKuroCSClothDynamicPinManager.__StartSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06015E71 RID: 89713 RVA: 0x00202388 File Offset: 0x00200588
		public void RebuildInstances()
		{
			AKuroCSClothDynamicPinManager.__RebuildInstances_Internal(base.NativePtr);
		}

		// Token: 0x06015E72 RID: 89714 RVA: 0x00202395 File Offset: 0x00200595
		public void InitializeDynamicPinManager()
		{
			AKuroCSClothDynamicPinManager.__InitializeDynamicPinManager_Internal(base.NativePtr);
		}

		// Token: 0x06015E73 RID: 89715 RVA: 0x002023A2 File Offset: 0x002005A2
		public FVector2D GetActorAtlasTileUVScale()
		{
			return AKuroCSClothDynamicPinManager.__GetActorAtlasTileUVScale_Internal(base.NativePtr);
		}

		// Token: 0x06015E74 RID: 89716 RVA: 0x002023AF File Offset: 0x002005AF
		[NullableContext(2)]
		public FVector2D GetActorAtlasTileUVOffset(AActor Actor)
		{
			return AKuroCSClothDynamicPinManager.__GetActorAtlasTileUVOffset_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06015E75 RID: 89717 RVA: 0x002023CC File Offset: 0x002005CC
		[NullableContext(2)]
		public int GetActorAtlasSlotIndex(AActor Actor)
		{
			return AKuroCSClothDynamicPinManager.__GetActorAtlasSlotIndex_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06015E76 RID: 89718 RVA: 0x002023E9 File Offset: 0x002005E9
		public void DrawDebugInitPhysicsPoints()
		{
			AKuroCSClothDynamicPinManager.__DrawDebugInitPhysicsPoints_Internal(base.NativePtr);
		}

		// Token: 0x06015E77 RID: 89719 RVA: 0x002023F6 File Offset: 0x002005F6
		public void BuildAndStart()
		{
			AKuroCSClothDynamicPinManager.__BuildAndStart_Internal(base.NativePtr);
		}

		// Token: 0x06015E78 RID: 89720 RVA: 0x00202403 File Offset: 0x00200603
		public void ApplyRenderTargetAndCustomDataToMeshActorArray()
		{
			AKuroCSClothDynamicPinManager.__ApplyRenderTargetAndCustomDataToMeshActorArray_Internal(base.NativePtr);
		}

		// Token: 0x06015E79 RID: 89721
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TickDynamicPinManager_Internal(IntPtr @this, float InDeltaTime);

		// Token: 0x06015E7A RID: 89722
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulation_Internal(IntPtr @this);

		// Token: 0x06015E7B RID: 89723
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAndRelease_Internal(IntPtr @this);

		// Token: 0x06015E7C RID: 89724
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSimulation_Internal(IntPtr @this);

		// Token: 0x06015E7D RID: 89725
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RebuildInstances_Internal(IntPtr @this);

		// Token: 0x06015E7E RID: 89726
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitializeDynamicPinManager_Internal(IntPtr @this);

		// Token: 0x06015E7F RID: 89727
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetActorAtlasTileUVScale_Internal(IntPtr @this);

		// Token: 0x06015E80 RID: 89728
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetActorAtlasTileUVOffset_Internal(IntPtr @this, IntPtr Actor);

		// Token: 0x06015E81 RID: 89729
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetActorAtlasSlotIndex_Internal(IntPtr @this, IntPtr Actor);

		// Token: 0x06015E82 RID: 89730
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawDebugInitPhysicsPoints_Internal(IntPtr @this);

		// Token: 0x06015E83 RID: 89731
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BuildAndStart_Internal(IntPtr @this);

		// Token: 0x06015E84 RID: 89732
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyRenderTargetAndCustomDataToMeshActorArray_Internal(IntPtr @this);

		// Token: 0x06015E85 RID: 89733 RVA: 0x00202410 File Offset: 0x00200610
		static AKuroCSClothDynamicPinManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSClothDynamicPinManager");
		}

		// Token: 0x06015E86 RID: 89734 RVA: 0x0020241E File Offset: 0x0020061E
		protected AKuroCSClothDynamicPinManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BEE0 RID: 48864
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSClothDynamicPinManager";

		// Token: 0x0400BEE1 RID: 48865
		private static IntPtr _ClassPtr;

		// Token: 0x0400BEE2 RID: 48866
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BEE3 RID: 48867
		internal static int __PropertyOffset_MeshActorArrayList;

		// Token: 0x0400BEE4 RID: 48868
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _MeshActorArrayList;

		// Token: 0x0400BEE5 RID: 48869
		internal static int __PropertyOffset_bAutoBuildAndStartOnBeginPlay;

		// Token: 0x0400BEE6 RID: 48870
		internal static int __PropertyOffset_PinBindingList;

		// Token: 0x0400BEE7 RID: 48871
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSClothDynamicPinBinding> _PinBindingList;

		// Token: 0x0400BEE8 RID: 48872
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400BEE9 RID: 48873
		internal static int __PropertyOffset_bAutoCreateRenderTarget;

		// Token: 0x0400BEEA RID: 48874
		internal static int __PropertyOffset_XCount;

		// Token: 0x0400BEEB RID: 48875
		internal static int __PropertyOffset_YCount;

		// Token: 0x0400BEEC RID: 48876
		internal static int __PropertyOffset_FallbackWidth;

		// Token: 0x0400BEED RID: 48877
		internal static int __PropertyOffset_FallbackHeight;

		// Token: 0x0400BEEE RID: 48878
		internal static int __PropertyOffset_bUseActorBoundsForPinSize;

		// Token: 0x0400BEEF RID: 48879
		internal static int __PropertyOffset_LocalRightDir;

		// Token: 0x0400BEF0 RID: 48880
		internal static int __PropertyOffset_LocalDownDir;

		// Token: 0x0400BEF1 RID: 48881
		internal static int __PropertyOffset_AccelExt;

		// Token: 0x0400BEF2 RID: 48882
		internal static int __PropertyOffset_DeltaTime;

		// Token: 0x0400BEF3 RID: 48883
		internal static int __PropertyOffset_DisStiffness;

		// Token: 0x0400BEF4 RID: 48884
		internal static int __PropertyOffset_VelocityDamping;

		// Token: 0x0400BEF5 RID: 48885
		internal static int __PropertyOffset_SubstepCount;

		// Token: 0x0400BEF6 RID: 48886
		internal static int __PropertyOffset_bDebugDrawPhysicsPoints;

		// Token: 0x0400BEF7 RID: 48887
		internal static int __PropertyOffset_bDebugReadbackSimParticles;

		// Token: 0x0400BEF8 RID: 48888
		internal static int __PropertyOffset_DebugReadbackInterval;

		// Token: 0x0400BEF9 RID: 48889
		internal static int __PropertyOffset_bDebugDrawPhysicsLinks;

		// Token: 0x0400BEFA RID: 48890
		internal static int __PropertyOffset_DebugPointSize;

		// Token: 0x0400BEFB RID: 48891
		internal static int __PropertyOffset_DebugLineThickness;

		// Token: 0x0400BEFC RID: 48892
		internal static int __PropertyOffset_DebugDrawDuration;

		// Token: 0x0400BEFD RID: 48893
		internal static int __PropertyOffset_DebugActivePointColor;

		// Token: 0x0400BEFE RID: 48894
		internal static int __PropertyOffset_DebugInactivePointColor;

		// Token: 0x0400BEFF RID: 48895
		internal static int __PropertyOffset_DebugPinPointColor;

		// Token: 0x0400BF00 RID: 48896
		internal static int __PropertyOffset_DebugReadbackPointColor;

		// Token: 0x0400BF01 RID: 48897
		internal static int __PropertyOffset_DebugLinkColor;

		// Token: 0x0400BF02 RID: 48898
		internal static int __PropertyOffset_AtlasSize;

		// Token: 0x0400BF03 RID: 48899
		internal static int __PropertyOffset_TileWidth;

		// Token: 0x0400BF04 RID: 48900
		internal static int __PropertyOffset_TileHeight;

		// Token: 0x0400BF05 RID: 48901
		internal static int __PropertyOffset_bApplyMaterialParameters;

		// Token: 0x0400BF06 RID: 48902
		internal static int __PropertyOffset_bApplyAtlasCustomPrimitiveData;

		// Token: 0x0400BF07 RID: 48903
		internal static int __PropertyOffset_bApplyAtlasTextureParameter;

		// Token: 0x0400BF08 RID: 48904
		internal static int __PropertyOffset_bApplyClothMinAndMaxParameter;

		// Token: 0x0400BF09 RID: 48905
		internal static int __PropertyOffset_AtlasUVRectCustomDataStartIndex;

		// Token: 0x0400BF0A RID: 48906
		internal static int __PropertyOffset_AtlasTextureParameterName;

		// Token: 0x0400BF0B RID: 48907
		internal static int __PropertyOffset_AtlasUVOffsetParameterName;

		// Token: 0x0400BF0C RID: 48908
		internal static int __PropertyOffset_AtlasUVScaleParameterName;

		// Token: 0x0400BF0D RID: 48909
		internal static int __PropertyOffset_AtlasSlotParameterName;

		// Token: 0x0400BF0E RID: 48910
		internal static int __PropertyOffset_ClothMinAndMaxParameterName;

		// Token: 0x0400BF0F RID: 48911
		internal static int __PropertyOffset_AutoCreatedRenderTarget;
	}
}
