using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017CD RID: 6093
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSStaticBatchCloth")]
	[UnrealStructLayout(2024, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2024)]
	public class AKuroCSStaticBatchCloth : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060165F3 RID: 91635 RVA: 0x0020B4EA File Offset: 0x002096EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroCSStaticBatchCloth._ClassPtr;
		}

		// Token: 0x060165F4 RID: 91636 RVA: 0x0020B4F8 File Offset: 0x002096F8
		public AKuroCSStaticBatchCloth() : this(BuiltinUtils.AllocNativeUObject(AKuroCSStaticBatchCloth.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060165F5 RID: 91637 RVA: 0x0020B520 File Offset: 0x00209720
		public AKuroCSStaticBatchCloth(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroCSStaticBatchCloth.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170059FF RID: 23039
		// (get) Token: 0x060165F6 RID: 91638 RVA: 0x0020B553 File Offset: 0x00209753
		// (set) Token: 0x060165F7 RID: 91639 RVA: 0x0020B567 File Offset: 0x00209767
		[Nullable(2)]
		public unsafe USceneComponent Root
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSStaticBatchCloth.__PropertyOffset_Root);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSStaticBatchCloth.__PropertyOffset_Root, value);
			}
		}

		// Token: 0x17005A00 RID: 23040
		// (get) Token: 0x060165F8 RID: 91640 RVA: 0x0020B57C File Offset: 0x0020977C
		// (set) Token: 0x060165F9 RID: 91641 RVA: 0x0020B58C File Offset: 0x0020978C
		public unsafe bool useExternalRT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_useExternalRT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_useExternalRT) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A01 RID: 23041
		// (get) Token: 0x060165FA RID: 91642 RVA: 0x0020B59D File Offset: 0x0020979D
		// (set) Token: 0x060165FB RID: 91643 RVA: 0x0020B5B1 File Offset: 0x002097B1
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSStaticBatchCloth.__PropertyOffset_RenderTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSStaticBatchCloth.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x17005A02 RID: 23042
		// (get) Token: 0x060165FC RID: 91644 RVA: 0x0020B5C6 File Offset: 0x002097C6
		// (set) Token: 0x060165FD RID: 91645 RVA: 0x0020B5DA File Offset: 0x002097DA
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D RenderTarget_N
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSStaticBatchCloth.__PropertyOffset_RenderTarget_N);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSStaticBatchCloth.__PropertyOffset_RenderTarget_N, value);
			}
		}

		// Token: 0x17005A03 RID: 23043
		// (get) Token: 0x060165FE RID: 91646 RVA: 0x0020B5F0 File Offset: 0x002097F0
		// (set) Token: 0x060165FF RID: 91647 RVA: 0x0020B629 File Offset: 0x00209829
		public TArray<FKuroCSParticle_staticBatchCloth> ParticlesArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_staticBatchCloth> result;
				if ((result = this._ParticlesArr) == null)
				{
					result = (this._ParticlesArr = new TArray<FKuroCSParticle_staticBatchCloth>(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_ParticlesArr, this));
				}
				return result;
			}
			set
			{
				this.ParticlesArr.CopyAssign(value);
			}
		}

		// Token: 0x17005A04 RID: 23044
		// (get) Token: 0x06016600 RID: 91648 RVA: 0x0020B638 File Offset: 0x00209838
		// (set) Token: 0x06016601 RID: 91649 RVA: 0x0020B671 File Offset: 0x00209871
		public TArray<FKuroCSParticle_staticBatchCloth> DebugArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_staticBatchCloth> result;
				if ((result = this._DebugArr) == null)
				{
					result = (this._DebugArr = new TArray<FKuroCSParticle_staticBatchCloth>(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_DebugArr, this));
				}
				return result;
			}
			set
			{
				this.DebugArr.CopyAssign(value);
			}
		}

		// Token: 0x17005A05 RID: 23045
		// (get) Token: 0x06016602 RID: 91650 RVA: 0x0020B67F File Offset: 0x0020987F
		// (set) Token: 0x06016603 RID: 91651 RVA: 0x0020B693 File Offset: 0x00209893
		public unsafe FVector playerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_playerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_playerPos) = value;
			}
		}

		// Token: 0x17005A06 RID: 23046
		// (get) Token: 0x06016604 RID: 91652 RVA: 0x0020B6A8 File Offset: 0x002098A8
		// (set) Token: 0x06016605 RID: 91653 RVA: 0x0020B6BC File Offset: 0x002098BC
		public unsafe FVector CurWeaponPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_CurWeaponPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_CurWeaponPos) = value;
			}
		}

		// Token: 0x17005A07 RID: 23047
		// (get) Token: 0x06016606 RID: 91654 RVA: 0x0020B6D1 File Offset: 0x002098D1
		// (set) Token: 0x06016607 RID: 91655 RVA: 0x0020B6E5 File Offset: 0x002098E5
		public unsafe FVector LastWeaponPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_LastWeaponPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_LastWeaponPos) = value;
			}
		}

		// Token: 0x17005A08 RID: 23048
		// (get) Token: 0x06016608 RID: 91656 RVA: 0x0020B6FA File Offset: 0x002098FA
		// (set) Token: 0x06016609 RID: 91657 RVA: 0x0020B70A File Offset: 0x0020990A
		public unsafe int ParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_ParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_ParticleCount) = value;
			}
		}

		// Token: 0x17005A09 RID: 23049
		// (get) Token: 0x0601660A RID: 91658 RVA: 0x0020B71B File Offset: 0x0020991B
		// (set) Token: 0x0601660B RID: 91659 RVA: 0x0020B72B File Offset: 0x0020992B
		public unsafe int substepCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_substepCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_substepCount) = value;
			}
		}

		// Token: 0x17005A0A RID: 23050
		// (get) Token: 0x0601660C RID: 91660 RVA: 0x0020B73C File Offset: 0x0020993C
		// (set) Token: 0x0601660D RID: 91661 RVA: 0x0020B74C File Offset: 0x0020994C
		public unsafe bool bEnableCPURead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bEnableCPURead) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bEnableCPURead) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A0B RID: 23051
		// (get) Token: 0x0601660E RID: 91662 RVA: 0x0020B75D File Offset: 0x0020995D
		// (set) Token: 0x0601660F RID: 91663 RVA: 0x0020B76D File Offset: 0x0020996D
		public unsafe bool bEnableBeginPlayLogs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bEnableBeginPlayLogs) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bEnableBeginPlayLogs) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A0C RID: 23052
		// (get) Token: 0x06016610 RID: 91664 RVA: 0x0020B77E File Offset: 0x0020997E
		// (set) Token: 0x06016611 RID: 91665 RVA: 0x0020B78E File Offset: 0x0020998E
		public unsafe bool bEnableGravityPass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bEnableGravityPass) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bEnableGravityPass) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A0D RID: 23053
		// (get) Token: 0x06016612 RID: 91666 RVA: 0x0020B79F File Offset: 0x0020999F
		// (set) Token: 0x06016613 RID: 91667 RVA: 0x0020B7AF File Offset: 0x002099AF
		public unsafe bool bEnableWeaponPass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bEnableWeaponPass) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bEnableWeaponPass) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A0E RID: 23054
		// (get) Token: 0x06016614 RID: 91668 RVA: 0x0020B7C0 File Offset: 0x002099C0
		// (set) Token: 0x06016615 RID: 91669 RVA: 0x0020B7D0 File Offset: 0x002099D0
		public unsafe bool bEnableDistancePass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bEnableDistancePass) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bEnableDistancePass) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A0F RID: 23055
		// (get) Token: 0x06016616 RID: 91670 RVA: 0x0020B7E1 File Offset: 0x002099E1
		// (set) Token: 0x06016617 RID: 91671 RVA: 0x0020B7F1 File Offset: 0x002099F1
		public unsafe bool bEnableBendingPass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bEnableBendingPass) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bEnableBendingPass) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A10 RID: 23056
		// (get) Token: 0x06016618 RID: 91672 RVA: 0x0020B802 File Offset: 0x00209A02
		// (set) Token: 0x06016619 RID: 91673 RVA: 0x0020B812 File Offset: 0x00209A12
		public unsafe bool bEnableCollisionPass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bEnableCollisionPass) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bEnableCollisionPass) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A11 RID: 23057
		// (get) Token: 0x0601661A RID: 91674 RVA: 0x0020B823 File Offset: 0x00209A23
		// (set) Token: 0x0601661B RID: 91675 RVA: 0x0020B833 File Offset: 0x00209A33
		public unsafe bool bEnableVolPass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bEnableVolPass) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bEnableVolPass) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A12 RID: 23058
		// (get) Token: 0x0601661C RID: 91676 RVA: 0x0020B844 File Offset: 0x00209A44
		// (set) Token: 0x0601661D RID: 91677 RVA: 0x0020B854 File Offset: 0x00209A54
		public unsafe int BendingConstraintCountBuilt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BendingConstraintCountBuilt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BendingConstraintCountBuilt) = value;
			}
		}

		// Token: 0x17005A13 RID: 23059
		// (get) Token: 0x0601661E RID: 91678 RVA: 0x0020B865 File Offset: 0x00209A65
		// (set) Token: 0x0601661F RID: 91679 RVA: 0x0020B875 File Offset: 0x00209A75
		public unsafe float PlayerCapsuleRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_PlayerCapsuleRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_PlayerCapsuleRadius) = value;
			}
		}

		// Token: 0x17005A14 RID: 23060
		// (get) Token: 0x06016620 RID: 91680 RVA: 0x0020B886 File Offset: 0x00209A86
		// (set) Token: 0x06016621 RID: 91681 RVA: 0x0020B896 File Offset: 0x00209A96
		public unsafe float PlayerCapsuleHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_PlayerCapsuleHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_PlayerCapsuleHeight) = value;
			}
		}

		// Token: 0x17005A15 RID: 23061
		// (get) Token: 0x06016622 RID: 91682 RVA: 0x0020B8A7 File Offset: 0x00209AA7
		// (set) Token: 0x06016623 RID: 91683 RVA: 0x0020B8B7 File Offset: 0x00209AB7
		public unsafe float PlayerCapsuleSkin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_PlayerCapsuleSkin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_PlayerCapsuleSkin) = value;
			}
		}

		// Token: 0x17005A16 RID: 23062
		// (get) Token: 0x06016624 RID: 91684 RVA: 0x0020B8C8 File Offset: 0x00209AC8
		// (set) Token: 0x06016625 RID: 91685 RVA: 0x0020B8D8 File Offset: 0x00209AD8
		public unsafe float PlayerFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_PlayerFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_PlayerFriction) = value;
			}
		}

		// Token: 0x17005A17 RID: 23063
		// (get) Token: 0x06016626 RID: 91686 RVA: 0x0020B8E9 File Offset: 0x00209AE9
		// (set) Token: 0x06016627 RID: 91687 RVA: 0x0020B8F9 File Offset: 0x00209AF9
		public unsafe int deadNodeHold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_deadNodeHold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_deadNodeHold) = value;
			}
		}

		// Token: 0x17005A18 RID: 23064
		// (get) Token: 0x06016628 RID: 91688 RVA: 0x0020B90A File Offset: 0x00209B0A
		// (set) Token: 0x06016629 RID: 91689 RVA: 0x0020B91A File Offset: 0x00209B1A
		public unsafe float deltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_deltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_deltaTime) = value;
			}
		}

		// Token: 0x17005A19 RID: 23065
		// (get) Token: 0x0601662A RID: 91690 RVA: 0x0020B92C File Offset: 0x00209B2C
		// (set) Token: 0x0601662B RID: 91691 RVA: 0x0020B965 File Offset: 0x00209B65
		public TArray<FKuroCSUnifiedCollider_staticBatchCloth> DynamicCollisionArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSUnifiedCollider_staticBatchCloth> result;
				if ((result = this._DynamicCollisionArr) == null)
				{
					result = (this._DynamicCollisionArr = new TArray<FKuroCSUnifiedCollider_staticBatchCloth>(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_DynamicCollisionArr, this));
				}
				return result;
			}
			set
			{
				this.DynamicCollisionArr.CopyAssign(value);
			}
		}

		// Token: 0x17005A1A RID: 23066
		// (get) Token: 0x0601662C RID: 91692 RVA: 0x0020B973 File Offset: 0x00209B73
		// (set) Token: 0x0601662D RID: 91693 RVA: 0x0020B983 File Offset: 0x00209B83
		public unsafe bool bWilsonWindEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bWilsonWindEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bWilsonWindEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A1B RID: 23067
		// (get) Token: 0x0601662E RID: 91694 RVA: 0x0020B994 File Offset: 0x00209B94
		// (set) Token: 0x0601662F RID: 91695 RVA: 0x0020B9A8 File Offset: 0x00209BA8
		public unsafe FVector WilsonWindDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_WilsonWindDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_WilsonWindDir) = value;
			}
		}

		// Token: 0x17005A1C RID: 23068
		// (get) Token: 0x06016630 RID: 91696 RVA: 0x0020B9BD File Offset: 0x00209BBD
		// (set) Token: 0x06016631 RID: 91697 RVA: 0x0020B9CD File Offset: 0x00209BCD
		public unsafe float WilsonWindStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_WilsonWindStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_WilsonWindStrength) = value;
			}
		}

		// Token: 0x17005A1D RID: 23069
		// (get) Token: 0x06016632 RID: 91698 RVA: 0x0020B9DE File Offset: 0x00209BDE
		// (set) Token: 0x06016633 RID: 91699 RVA: 0x0020B9EE File Offset: 0x00209BEE
		public unsafe bool bWindFieldEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bWindFieldEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bWindFieldEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A1E RID: 23070
		// (get) Token: 0x06016634 RID: 91700 RVA: 0x0020B9FF File Offset: 0x00209BFF
		// (set) Token: 0x06016635 RID: 91701 RVA: 0x0020BA13 File Offset: 0x00209C13
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D WindField
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSStaticBatchCloth.__PropertyOffset_WindField);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSStaticBatchCloth.__PropertyOffset_WindField, value);
			}
		}

		// Token: 0x17005A1F RID: 23071
		// (get) Token: 0x06016636 RID: 91702 RVA: 0x0020BA28 File Offset: 0x00209C28
		// (set) Token: 0x06016637 RID: 91703 RVA: 0x0020BA3C File Offset: 0x00209C3C
		public unsafe FVector WindFieldSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_WindFieldSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_WindFieldSize) = value;
			}
		}

		// Token: 0x17005A20 RID: 23072
		// (get) Token: 0x06016638 RID: 91704 RVA: 0x0020BA51 File Offset: 0x00209C51
		// (set) Token: 0x06016639 RID: 91705 RVA: 0x0020BA61 File Offset: 0x00209C61
		public unsafe float BottomWindStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BottomWindStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BottomWindStrength) = value;
			}
		}

		// Token: 0x17005A21 RID: 23073
		// (get) Token: 0x0601663A RID: 91706 RVA: 0x0020BA72 File Offset: 0x00209C72
		// (set) Token: 0x0601663B RID: 91707 RVA: 0x0020BA82 File Offset: 0x00209C82
		public unsafe float TopWindStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_TopWindStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_TopWindStrength) = value;
			}
		}

		// Token: 0x17005A22 RID: 23074
		// (get) Token: 0x0601663C RID: 91708 RVA: 0x0020BA93 File Offset: 0x00209C93
		// (set) Token: 0x0601663D RID: 91709 RVA: 0x0020BAA3 File Offset: 0x00209CA3
		public unsafe float WindFieldMaxStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_WindFieldMaxStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_WindFieldMaxStrength) = value;
			}
		}

		// Token: 0x17005A23 RID: 23075
		// (get) Token: 0x0601663E RID: 91710 RVA: 0x0020BAB4 File Offset: 0x00209CB4
		// (set) Token: 0x0601663F RID: 91711 RVA: 0x0020BAC4 File Offset: 0x00209CC4
		public unsafe bool bEnableSDFCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bEnableSDFCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bEnableSDFCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A24 RID: 23076
		// (get) Token: 0x06016640 RID: 91712 RVA: 0x0020BAD5 File Offset: 0x00209CD5
		// (set) Token: 0x06016641 RID: 91713 RVA: 0x0020BAE5 File Offset: 0x00209CE5
		public unsafe float SDFMinSafeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_SDFMinSafeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_SDFMinSafeDistance) = value;
			}
		}

		// Token: 0x17005A25 RID: 23077
		// (get) Token: 0x06016642 RID: 91714 RVA: 0x0020BAF6 File Offset: 0x00209CF6
		// (set) Token: 0x06016643 RID: 91715 RVA: 0x0020BB06 File Offset: 0x00209D06
		public unsafe float SDFDynamicSafeDistanceFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_SDFDynamicSafeDistanceFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_SDFDynamicSafeDistanceFactor) = value;
			}
		}

		// Token: 0x17005A26 RID: 23078
		// (get) Token: 0x06016644 RID: 91716 RVA: 0x0020BB17 File Offset: 0x00209D17
		// (set) Token: 0x06016645 RID: 91717 RVA: 0x0020BB27 File Offset: 0x00209D27
		public unsafe float SDFCorrectionStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_SDFCorrectionStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_SDFCorrectionStiffness) = value;
			}
		}

		// Token: 0x17005A27 RID: 23079
		// (get) Token: 0x06016646 RID: 91718 RVA: 0x0020BB38 File Offset: 0x00209D38
		// (set) Token: 0x06016647 RID: 91719 RVA: 0x0020BB48 File Offset: 0x00209D48
		public unsafe float SDFMaxCorrectionPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_SDFMaxCorrectionPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_SDFMaxCorrectionPerFrame) = value;
			}
		}

		// Token: 0x17005A28 RID: 23080
		// (get) Token: 0x06016648 RID: 91720 RVA: 0x0020BB59 File Offset: 0x00209D59
		// (set) Token: 0x06016649 RID: 91721 RVA: 0x0020BB69 File Offset: 0x00209D69
		public unsafe float SDFPlayerActivationDistanceMeters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_SDFPlayerActivationDistanceMeters);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_SDFPlayerActivationDistanceMeters) = value;
			}
		}

		// Token: 0x17005A29 RID: 23081
		// (get) Token: 0x0601664A RID: 91722 RVA: 0x0020BB7A File Offset: 0x00209D7A
		// (set) Token: 0x0601664B RID: 91723 RVA: 0x0020BB8A File Offset: 0x00209D8A
		public unsafe float SDFFadeDurationSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_SDFFadeDurationSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_SDFFadeDurationSeconds) = value;
			}
		}

		// Token: 0x17005A2A RID: 23082
		// (get) Token: 0x0601664C RID: 91724 RVA: 0x0020BB9C File Offset: 0x00209D9C
		// (set) Token: 0x0601664D RID: 91725 RVA: 0x0020BBD5 File Offset: 0x00209DD5
		public TArray<AStaticMeshActor> SMActorArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AStaticMeshActor> result;
				if ((result = this._SMActorArr) == null)
				{
					result = (this._SMActorArr = new TArray<AStaticMeshActor>(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_SMActorArr, this));
				}
				return result;
			}
			set
			{
				this.SMActorArr.CopyAssign(value);
			}
		}

		// Token: 0x17005A2B RID: 23083
		// (get) Token: 0x0601664E RID: 91726 RVA: 0x0020BBE4 File Offset: 0x00209DE4
		// (set) Token: 0x0601664F RID: 91727 RVA: 0x0020BC1D File Offset: 0x00209E1D
		public TArray<UMaterialInstanceDynamic> SharedClothMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._SharedClothMaterials) == null)
				{
					result = (this._SharedClothMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_SharedClothMaterials, this));
				}
				return result;
			}
			set
			{
				this.SharedClothMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17005A2C RID: 23084
		// (get) Token: 0x06016650 RID: 91728 RVA: 0x0020BC2B File Offset: 0x00209E2B
		// (set) Token: 0x06016651 RID: 91729 RVA: 0x0020BC3F File Offset: 0x00209E3F
		public unsafe FName ClothMaterialParamRTPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_ClothMaterialParamRTPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_ClothMaterialParamRTPos) = value;
			}
		}

		// Token: 0x17005A2D RID: 23085
		// (get) Token: 0x06016652 RID: 91730 RVA: 0x0020BC54 File Offset: 0x00209E54
		// (set) Token: 0x06016653 RID: 91731 RVA: 0x0020BC68 File Offset: 0x00209E68
		public unsafe FName ClothMaterialParamRTNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_ClothMaterialParamRTNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_ClothMaterialParamRTNormal) = value;
			}
		}

		// Token: 0x17005A2E RID: 23086
		// (get) Token: 0x06016654 RID: 91732 RVA: 0x0020BC80 File Offset: 0x00209E80
		// (set) Token: 0x06016655 RID: 91733 RVA: 0x0020BCB9 File Offset: 0x00209EB9
		public TMap<UStaticMesh, FKuroCSStaticBatchClothBinding> MeshToParticleDT
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UStaticMesh, FKuroCSStaticBatchClothBinding> result;
				if ((result = this._MeshToParticleDT) == null)
				{
					result = (this._MeshToParticleDT = new TMap<UStaticMesh, FKuroCSStaticBatchClothBinding>(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_MeshToParticleDT, this));
				}
				return result;
			}
			set
			{
				this.MeshToParticleDT.CopyAssign(value);
			}
		}

		// Token: 0x17005A2F RID: 23087
		// (get) Token: 0x06016656 RID: 91734 RVA: 0x0020BCC8 File Offset: 0x00209EC8
		// (set) Token: 0x06016657 RID: 91735 RVA: 0x0020BD01 File Offset: 0x00209F01
		public TArray<FKuroCSClothInstance_staticBatchCloth> ClothInstances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSClothInstance_staticBatchCloth> result;
				if ((result = this._ClothInstances) == null)
				{
					result = (this._ClothInstances = new TArray<FKuroCSClothInstance_staticBatchCloth>(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_ClothInstances, this));
				}
				return result;
			}
			set
			{
				this.ClothInstances.CopyAssign(value);
			}
		}

		// Token: 0x17005A30 RID: 23088
		// (get) Token: 0x06016658 RID: 91736 RVA: 0x0020BD0F File Offset: 0x00209F0F
		// (set) Token: 0x06016659 RID: 91737 RVA: 0x0020BD1F File Offset: 0x00209F1F
		public unsafe int AtlasUVRectCustomDataStartIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_AtlasUVRectCustomDataStartIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_AtlasUVRectCustomDataStartIndex) = value;
			}
		}

		// Token: 0x17005A31 RID: 23089
		// (get) Token: 0x0601665A RID: 91738 RVA: 0x0020BD30 File Offset: 0x00209F30
		// (set) Token: 0x0601665B RID: 91739 RVA: 0x0020BD40 File Offset: 0x00209F40
		public unsafe int AtlasCellPaddingTexels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_AtlasCellPaddingTexels);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_AtlasCellPaddingTexels) = value;
			}
		}

		// Token: 0x17005A32 RID: 23090
		// (get) Token: 0x0601665C RID: 91740 RVA: 0x0020BD51 File Offset: 0x00209F51
		// (set) Token: 0x0601665D RID: 91741 RVA: 0x0020BD65 File Offset: 0x00209F65
		public unsafe FIntPoint AtlasCellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_AtlasCellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_AtlasCellSize) = value;
			}
		}

		// Token: 0x17005A33 RID: 23091
		// (get) Token: 0x0601665E RID: 91742 RVA: 0x0020BD7A File Offset: 0x00209F7A
		// (set) Token: 0x0601665F RID: 91743 RVA: 0x0020BD8E File Offset: 0x00209F8E
		public unsafe FIntPoint AtlasRequiredSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_AtlasRequiredSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_AtlasRequiredSize) = value;
			}
		}

		// Token: 0x17005A34 RID: 23092
		// (get) Token: 0x06016660 RID: 91744 RVA: 0x0020BDA3 File Offset: 0x00209FA3
		// (set) Token: 0x06016661 RID: 91745 RVA: 0x0020BDB3 File Offset: 0x00209FB3
		public unsafe int AtlasNumCols
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_AtlasNumCols);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_AtlasNumCols) = value;
			}
		}

		// Token: 0x17005A35 RID: 23093
		// (get) Token: 0x06016662 RID: 91746 RVA: 0x0020BDC4 File Offset: 0x00209FC4
		// (set) Token: 0x06016663 RID: 91747 RVA: 0x0020BDD4 File Offset: 0x00209FD4
		public unsafe int AtlasNumRows
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_AtlasNumRows);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_AtlasNumRows) = value;
			}
		}

		// Token: 0x17005A36 RID: 23094
		// (get) Token: 0x06016664 RID: 91748 RVA: 0x0020BDE5 File Offset: 0x00209FE5
		// (set) Token: 0x06016665 RID: 91749 RVA: 0x0020BDF5 File Offset: 0x00209FF5
		public unsafe bool bAutoBuildBatchOnConstruction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bAutoBuildBatchOnConstruction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bAutoBuildBatchOnConstruction) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A37 RID: 23095
		// (get) Token: 0x06016666 RID: 91750 RVA: 0x0020BE06 File Offset: 0x0020A006
		// (set) Token: 0x06016667 RID: 91751 RVA: 0x0020BE16 File Offset: 0x0020A016
		public unsafe bool bUseEditorBakedBatch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bUseEditorBakedBatch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bUseEditorBakedBatch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A38 RID: 23096
		// (get) Token: 0x06016668 RID: 91752 RVA: 0x0020BE27 File Offset: 0x0020A027
		// (set) Token: 0x06016669 RID: 91753 RVA: 0x0020BE37 File Offset: 0x0020A037
		public unsafe bool bHasEditorBakedBatch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bHasEditorBakedBatch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bHasEditorBakedBatch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A39 RID: 23097
		// (get) Token: 0x0601666A RID: 91754 RVA: 0x0020BE48 File Offset: 0x0020A048
		// (set) Token: 0x0601666B RID: 91755 RVA: 0x0020BE58 File Offset: 0x0020A058
		public unsafe int BakedParticleCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BakedParticleCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BakedParticleCount) = value;
			}
		}

		// Token: 0x17005A3A RID: 23098
		// (get) Token: 0x0601666C RID: 91756 RVA: 0x0020BE69 File Offset: 0x0020A069
		// (set) Token: 0x0601666D RID: 91757 RVA: 0x0020BE79 File Offset: 0x0020A079
		public unsafe int BakedClothCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BakedClothCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BakedClothCount) = value;
			}
		}

		// Token: 0x17005A3B RID: 23099
		// (get) Token: 0x0601666E RID: 91758 RVA: 0x0020BE8A File Offset: 0x0020A08A
		// (set) Token: 0x0601666F RID: 91759 RVA: 0x0020BE9A File Offset: 0x0020A09A
		public unsafe int BakedBendingConstraintCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BakedBendingConstraintCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BakedBendingConstraintCount) = value;
			}
		}

		// Token: 0x17005A3C RID: 23100
		// (get) Token: 0x06016670 RID: 91760 RVA: 0x0020BEAB File Offset: 0x0020A0AB
		// (set) Token: 0x06016671 RID: 91761 RVA: 0x0020BEBF File Offset: 0x0020A0BF
		public unsafe FIntPoint BakedAtlasRequiredSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BakedAtlasRequiredSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BakedAtlasRequiredSize) = value;
			}
		}

		// Token: 0x17005A3D RID: 23101
		// (get) Token: 0x06016672 RID: 91762 RVA: 0x0020BED4 File Offset: 0x0020A0D4
		// (set) Token: 0x06016673 RID: 91763 RVA: 0x0020BF0D File Offset: 0x0020A10D
		public TArray<FKuroCSParticle_staticBatchCloth> BakedParticlesArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_staticBatchCloth> result;
				if ((result = this._BakedParticlesArr) == null)
				{
					result = (this._BakedParticlesArr = new TArray<FKuroCSParticle_staticBatchCloth>(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BakedParticlesArr, this));
				}
				return result;
			}
			set
			{
				this.BakedParticlesArr.CopyAssign(value);
			}
		}

		// Token: 0x17005A3E RID: 23102
		// (get) Token: 0x06016674 RID: 91764 RVA: 0x0020BF1C File Offset: 0x0020A11C
		// (set) Token: 0x06016675 RID: 91765 RVA: 0x0020BF55 File Offset: 0x0020A155
		public TArray<FKuroCSStaticBatchClothBakedInstance> BakedClothInstances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSStaticBatchClothBakedInstance> result;
				if ((result = this._BakedClothInstances) == null)
				{
					result = (this._BakedClothInstances = new TArray<FKuroCSStaticBatchClothBakedInstance>(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BakedClothInstances, this));
				}
				return result;
			}
			set
			{
				this.BakedClothInstances.CopyAssign(value);
			}
		}

		// Token: 0x17005A3F RID: 23103
		// (get) Token: 0x06016676 RID: 91766 RVA: 0x0020BF64 File Offset: 0x0020A164
		// (set) Token: 0x06016677 RID: 91767 RVA: 0x0020BF9D File Offset: 0x0020A19D
		public TArray<FKuroCSStaticBatchClothBakedBendingConstraint> BakedBendingConstraints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSStaticBatchClothBakedBendingConstraint> result;
				if ((result = this._BakedBendingConstraints) == null)
				{
					result = (this._BakedBendingConstraints = new TArray<FKuroCSStaticBatchClothBakedBendingConstraint>(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BakedBendingConstraints, this));
				}
				return result;
			}
			set
			{
				this.BakedBendingConstraints.CopyAssign(value);
			}
		}

		// Token: 0x17005A40 RID: 23104
		// (get) Token: 0x06016678 RID: 91768 RVA: 0x0020BFAC File Offset: 0x0020A1AC
		// (set) Token: 0x06016679 RID: 91769 RVA: 0x0020BFE5 File Offset: 0x0020A1E5
		public TArray<int> BakedBendingColorStart
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._BakedBendingColorStart) == null)
				{
					result = (this._BakedBendingColorStart = new TArray<int>(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BakedBendingColorStart, this));
				}
				return result;
			}
			set
			{
				this.BakedBendingColorStart.CopyAssign(value);
			}
		}

		// Token: 0x17005A41 RID: 23105
		// (get) Token: 0x0601667A RID: 91770 RVA: 0x0020BFF3 File Offset: 0x0020A1F3
		// (set) Token: 0x0601667B RID: 91771 RVA: 0x0020C007 File Offset: 0x0020A207
		public unsafe FIntPoint BakedAtlasCellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BakedAtlasCellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BakedAtlasCellSize) = value;
			}
		}

		// Token: 0x17005A42 RID: 23106
		// (get) Token: 0x0601667C RID: 91772 RVA: 0x0020C01C File Offset: 0x0020A21C
		// (set) Token: 0x0601667D RID: 91773 RVA: 0x0020C02C File Offset: 0x0020A22C
		public unsafe int BakedAtlasNumCols
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BakedAtlasNumCols);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BakedAtlasNumCols) = value;
			}
		}

		// Token: 0x17005A43 RID: 23107
		// (get) Token: 0x0601667E RID: 91774 RVA: 0x0020C03D File Offset: 0x0020A23D
		// (set) Token: 0x0601667F RID: 91775 RVA: 0x0020C04D File Offset: 0x0020A24D
		public unsafe int BakedAtlasNumRows
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BakedAtlasNumRows);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_BakedAtlasNumRows) = value;
			}
		}

		// Token: 0x17005A44 RID: 23108
		// (get) Token: 0x06016680 RID: 91776 RVA: 0x0020C05E File Offset: 0x0020A25E
		// (set) Token: 0x06016681 RID: 91777 RVA: 0x0020C06E File Offset: 0x0020A26E
		public unsafe bool bRefreshInstanceTransformsEveryTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bRefreshInstanceTransformsEveryTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroCSStaticBatchCloth.__PropertyOffset_bRefreshInstanceTransformsEveryTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005A45 RID: 23109
		// (get) Token: 0x06016682 RID: 91778 RVA: 0x0020C07F File Offset: 0x0020A27F
		// (set) Token: 0x06016683 RID: 91779 RVA: 0x0020C093 File Offset: 0x0020A293
		[Nullable(2)]
		public unsafe AActor ColliderSceneActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSStaticBatchCloth.__PropertyOffset_ColliderSceneActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroCSStaticBatchCloth.__PropertyOffset_ColliderSceneActor, value);
			}
		}

		// Token: 0x06016684 RID: 91780 RVA: 0x0020C0A8 File Offset: 0x0020A2A8
		public void StopSimulation()
		{
			AKuroCSStaticBatchCloth.__StopSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06016685 RID: 91781 RVA: 0x0020C0B5 File Offset: 0x0020A2B5
		public void StartSimulation()
		{
			AKuroCSStaticBatchCloth.__StartSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06016686 RID: 91782 RVA: 0x0020C0C2 File Offset: 0x0020A2C2
		public void SetColliderTransform(int Index, FVector NewCenter, FVector NewRotationEuler)
		{
			AKuroCSStaticBatchCloth.__SetColliderTransform_Internal(base.NativePtr, Index, NewCenter, NewRotationEuler);
		}

		// Token: 0x06016687 RID: 91783 RVA: 0x0020C0D2 File Offset: 0x0020A2D2
		[NullableContext(2)]
		public void SetColliderAt(int Index, in FKuroCSUnifiedCollider_staticBatchCloth NewCollider)
		{
			AKuroCSStaticBatchCloth.__SetColliderAt_Internal(base.NativePtr, Index, (NewCollider ?? new FKuroCSUnifiedCollider_staticBatchCloth()).NativePtr);
		}

		// Token: 0x06016688 RID: 91784 RVA: 0x0020C0F0 File Offset: 0x0020A2F0
		public void ReleaseShaderManager()
		{
			AKuroCSStaticBatchCloth.__ReleaseShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x06016689 RID: 91785 RVA: 0x0020C0FD File Offset: 0x0020A2FD
		public void RefreshClothInstanceTransforms()
		{
			AKuroCSStaticBatchCloth.__RefreshClothInstanceTransforms_Internal(base.NativePtr);
		}

		// Token: 0x0601668A RID: 91786 RVA: 0x0020C10A File Offset: 0x0020A30A
		[NullableContext(2)]
		public int InitSharedClothMaterials(UTextureRenderTarget2D InRTPos, UTextureRenderTarget2D InRTNormal)
		{
			return AKuroCSStaticBatchCloth.__InitSharedClothMaterials_Internal(base.NativePtr, (InRTPos != null) ? InRTPos.NativePtr : IntPtr.Zero, (InRTNormal != null) ? InRTNormal.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601668B RID: 91787 RVA: 0x0020C137 File Offset: 0x0020A337
		public void InitShaderManager()
		{
			AKuroCSStaticBatchCloth.__InitShaderManager_Internal(base.NativePtr);
		}

		// Token: 0x0601668C RID: 91788 RVA: 0x0020C144 File Offset: 0x0020A344
		public FIntPoint GetPreferredRTSize()
		{
			return AKuroCSStaticBatchCloth.__GetPreferredRTSize_Internal(base.NativePtr);
		}

		// Token: 0x0601668D RID: 91789 RVA: 0x0020C151 File Offset: 0x0020A351
		public int GetColliderCount()
		{
			return AKuroCSStaticBatchCloth.__GetColliderCount_Internal(base.NativePtr);
		}

		// Token: 0x0601668E RID: 91790 RVA: 0x0020C15E File Offset: 0x0020A35E
		public FKuroCSUnifiedCollider_staticBatchCloth GetColliderAt(int Index)
		{
			return new FKuroCSUnifiedCollider_staticBatchCloth(AKuroCSStaticBatchCloth.__GetColliderAt_Internal(base.NativePtr, Index), null);
		}

		// Token: 0x0601668F RID: 91791 RVA: 0x0020C172 File Offset: 0x0020A372
		public void ClearBakedBatchForRuntime()
		{
			AKuroCSStaticBatchCloth.__ClearBakedBatchForRuntime_Internal(base.NativePtr);
		}

		// Token: 0x06016690 RID: 91792 RVA: 0x0020C17F File Offset: 0x0020A37F
		public void ClearAllColliders()
		{
			AKuroCSStaticBatchCloth.__ClearAllColliders_Internal(base.NativePtr);
		}

		// Token: 0x06016691 RID: 91793 RVA: 0x0020C18C File Offset: 0x0020A38C
		public void BuildBatchFromActors()
		{
			AKuroCSStaticBatchCloth.__BuildBatchFromActors_Internal(base.NativePtr);
		}

		// Token: 0x06016692 RID: 91794 RVA: 0x0020C199 File Offset: 0x0020A399
		public void BakeBatchForRuntime()
		{
			AKuroCSStaticBatchCloth.__BakeBatchForRuntime_Internal(base.NativePtr);
		}

		// Token: 0x06016693 RID: 91795 RVA: 0x0020C1A6 File Offset: 0x0020A3A6
		public void AddColliderFromSceneActor()
		{
			AKuroCSStaticBatchCloth.__AddColliderFromSceneActor_Internal(base.NativePtr);
		}

		// Token: 0x06016694 RID: 91796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopSimulation_Internal(IntPtr @this);

		// Token: 0x06016695 RID: 91797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSimulation_Internal(IntPtr @this);

		// Token: 0x06016696 RID: 91798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColliderTransform_Internal(IntPtr @this, int Index, FVector NewCenter, FVector NewRotationEuler);

		// Token: 0x06016697 RID: 91799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColliderAt_Internal(IntPtr @this, int Index, IntPtr NewCollider);

		// Token: 0x06016698 RID: 91800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseShaderManager_Internal(IntPtr @this);

		// Token: 0x06016699 RID: 91801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshClothInstanceTransforms_Internal(IntPtr @this);

		// Token: 0x0601669A RID: 91802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __InitSharedClothMaterials_Internal(IntPtr @this, IntPtr InRTPos, IntPtr InRTNormal);

		// Token: 0x0601669B RID: 91803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitShaderManager_Internal(IntPtr @this);

		// Token: 0x0601669C RID: 91804
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint __GetPreferredRTSize_Internal(IntPtr @this);

		// Token: 0x0601669D RID: 91805
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetColliderCount_Internal(IntPtr @this);

		// Token: 0x0601669E RID: 91806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetColliderAt_Internal(IntPtr @this, int Index);

		// Token: 0x0601669F RID: 91807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearBakedBatchForRuntime_Internal(IntPtr @this);

		// Token: 0x060166A0 RID: 91808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAllColliders_Internal(IntPtr @this);

		// Token: 0x060166A1 RID: 91809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BuildBatchFromActors_Internal(IntPtr @this);

		// Token: 0x060166A2 RID: 91810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BakeBatchForRuntime_Internal(IntPtr @this);

		// Token: 0x060166A3 RID: 91811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddColliderFromSceneActor_Internal(IntPtr @this);

		// Token: 0x060166A4 RID: 91812 RVA: 0x0020C1B3 File Offset: 0x0020A3B3
		static AKuroCSStaticBatchCloth()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSStaticBatchCloth");
		}

		// Token: 0x060166A5 RID: 91813 RVA: 0x0020C1C1 File Offset: 0x0020A3C1
		protected AKuroCSStaticBatchCloth(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C296 RID: 49814
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSStaticBatchCloth";

		// Token: 0x0400C297 RID: 49815
		private static IntPtr _ClassPtr;

		// Token: 0x0400C298 RID: 49816
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C299 RID: 49817
		internal static int __PropertyOffset_Root;

		// Token: 0x0400C29A RID: 49818
		internal static int __PropertyOffset_useExternalRT;

		// Token: 0x0400C29B RID: 49819
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x0400C29C RID: 49820
		internal static int __PropertyOffset_RenderTarget_N;

		// Token: 0x0400C29D RID: 49821
		internal static int __PropertyOffset_ParticlesArr;

		// Token: 0x0400C29E RID: 49822
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_staticBatchCloth> _ParticlesArr;

		// Token: 0x0400C29F RID: 49823
		internal static int __PropertyOffset_DebugArr;

		// Token: 0x0400C2A0 RID: 49824
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_staticBatchCloth> _DebugArr;

		// Token: 0x0400C2A1 RID: 49825
		internal static int __PropertyOffset_playerPos;

		// Token: 0x0400C2A2 RID: 49826
		internal static int __PropertyOffset_CurWeaponPos;

		// Token: 0x0400C2A3 RID: 49827
		internal static int __PropertyOffset_LastWeaponPos;

		// Token: 0x0400C2A4 RID: 49828
		internal static int __PropertyOffset_ParticleCount;

		// Token: 0x0400C2A5 RID: 49829
		internal static int __PropertyOffset_substepCount;

		// Token: 0x0400C2A6 RID: 49830
		internal static int __PropertyOffset_bEnableCPURead;

		// Token: 0x0400C2A7 RID: 49831
		internal static int __PropertyOffset_bEnableBeginPlayLogs;

		// Token: 0x0400C2A8 RID: 49832
		internal static int __PropertyOffset_bEnableGravityPass;

		// Token: 0x0400C2A9 RID: 49833
		internal static int __PropertyOffset_bEnableWeaponPass;

		// Token: 0x0400C2AA RID: 49834
		internal static int __PropertyOffset_bEnableDistancePass;

		// Token: 0x0400C2AB RID: 49835
		internal static int __PropertyOffset_bEnableBendingPass;

		// Token: 0x0400C2AC RID: 49836
		internal static int __PropertyOffset_bEnableCollisionPass;

		// Token: 0x0400C2AD RID: 49837
		internal static int __PropertyOffset_bEnableVolPass;

		// Token: 0x0400C2AE RID: 49838
		internal static int __PropertyOffset_BendingConstraintCountBuilt;

		// Token: 0x0400C2AF RID: 49839
		internal static int __PropertyOffset_PlayerCapsuleRadius;

		// Token: 0x0400C2B0 RID: 49840
		internal static int __PropertyOffset_PlayerCapsuleHeight;

		// Token: 0x0400C2B1 RID: 49841
		internal static int __PropertyOffset_PlayerCapsuleSkin;

		// Token: 0x0400C2B2 RID: 49842
		internal static int __PropertyOffset_PlayerFriction;

		// Token: 0x0400C2B3 RID: 49843
		internal static int __PropertyOffset_deadNodeHold;

		// Token: 0x0400C2B4 RID: 49844
		internal static int __PropertyOffset_deltaTime;

		// Token: 0x0400C2B5 RID: 49845
		internal static int __PropertyOffset_DynamicCollisionArr;

		// Token: 0x0400C2B6 RID: 49846
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSUnifiedCollider_staticBatchCloth> _DynamicCollisionArr;

		// Token: 0x0400C2B7 RID: 49847
		internal static int __PropertyOffset_bWilsonWindEnabled;

		// Token: 0x0400C2B8 RID: 49848
		internal static int __PropertyOffset_WilsonWindDir;

		// Token: 0x0400C2B9 RID: 49849
		internal static int __PropertyOffset_WilsonWindStrength;

		// Token: 0x0400C2BA RID: 49850
		internal static int __PropertyOffset_bWindFieldEnabled;

		// Token: 0x0400C2BB RID: 49851
		internal static int __PropertyOffset_WindField;

		// Token: 0x0400C2BC RID: 49852
		internal static int __PropertyOffset_WindFieldSize;

		// Token: 0x0400C2BD RID: 49853
		internal static int __PropertyOffset_BottomWindStrength;

		// Token: 0x0400C2BE RID: 49854
		internal static int __PropertyOffset_TopWindStrength;

		// Token: 0x0400C2BF RID: 49855
		internal static int __PropertyOffset_WindFieldMaxStrength;

		// Token: 0x0400C2C0 RID: 49856
		internal static int __PropertyOffset_bEnableSDFCollision;

		// Token: 0x0400C2C1 RID: 49857
		internal static int __PropertyOffset_SDFMinSafeDistance;

		// Token: 0x0400C2C2 RID: 49858
		internal static int __PropertyOffset_SDFDynamicSafeDistanceFactor;

		// Token: 0x0400C2C3 RID: 49859
		internal static int __PropertyOffset_SDFCorrectionStiffness;

		// Token: 0x0400C2C4 RID: 49860
		internal static int __PropertyOffset_SDFMaxCorrectionPerFrame;

		// Token: 0x0400C2C5 RID: 49861
		internal static int __PropertyOffset_SDFPlayerActivationDistanceMeters;

		// Token: 0x0400C2C6 RID: 49862
		internal static int __PropertyOffset_SDFFadeDurationSeconds;

		// Token: 0x0400C2C7 RID: 49863
		internal static int __PropertyOffset_SMActorArr;

		// Token: 0x0400C2C8 RID: 49864
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AStaticMeshActor> _SMActorArr;

		// Token: 0x0400C2C9 RID: 49865
		internal static int __PropertyOffset_SharedClothMaterials;

		// Token: 0x0400C2CA RID: 49866
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _SharedClothMaterials;

		// Token: 0x0400C2CB RID: 49867
		internal static int __PropertyOffset_ClothMaterialParamRTPos;

		// Token: 0x0400C2CC RID: 49868
		internal static int __PropertyOffset_ClothMaterialParamRTNormal;

		// Token: 0x0400C2CD RID: 49869
		internal static int __PropertyOffset_MeshToParticleDT;

		// Token: 0x0400C2CE RID: 49870
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UStaticMesh, FKuroCSStaticBatchClothBinding> _MeshToParticleDT;

		// Token: 0x0400C2CF RID: 49871
		internal static int __PropertyOffset_ClothInstances;

		// Token: 0x0400C2D0 RID: 49872
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSClothInstance_staticBatchCloth> _ClothInstances;

		// Token: 0x0400C2D1 RID: 49873
		internal static int __PropertyOffset_AtlasUVRectCustomDataStartIndex;

		// Token: 0x0400C2D2 RID: 49874
		internal static int __PropertyOffset_AtlasCellPaddingTexels;

		// Token: 0x0400C2D3 RID: 49875
		internal static int __PropertyOffset_AtlasCellSize;

		// Token: 0x0400C2D4 RID: 49876
		internal static int __PropertyOffset_AtlasRequiredSize;

		// Token: 0x0400C2D5 RID: 49877
		internal static int __PropertyOffset_AtlasNumCols;

		// Token: 0x0400C2D6 RID: 49878
		internal static int __PropertyOffset_AtlasNumRows;

		// Token: 0x0400C2D7 RID: 49879
		internal static int __PropertyOffset_bAutoBuildBatchOnConstruction;

		// Token: 0x0400C2D8 RID: 49880
		internal static int __PropertyOffset_bUseEditorBakedBatch;

		// Token: 0x0400C2D9 RID: 49881
		internal static int __PropertyOffset_bHasEditorBakedBatch;

		// Token: 0x0400C2DA RID: 49882
		internal static int __PropertyOffset_BakedParticleCount;

		// Token: 0x0400C2DB RID: 49883
		internal static int __PropertyOffset_BakedClothCount;

		// Token: 0x0400C2DC RID: 49884
		internal static int __PropertyOffset_BakedBendingConstraintCount;

		// Token: 0x0400C2DD RID: 49885
		internal static int __PropertyOffset_BakedAtlasRequiredSize;

		// Token: 0x0400C2DE RID: 49886
		internal static int __PropertyOffset_BakedParticlesArr;

		// Token: 0x0400C2DF RID: 49887
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_staticBatchCloth> _BakedParticlesArr;

		// Token: 0x0400C2E0 RID: 49888
		internal static int __PropertyOffset_BakedClothInstances;

		// Token: 0x0400C2E1 RID: 49889
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSStaticBatchClothBakedInstance> _BakedClothInstances;

		// Token: 0x0400C2E2 RID: 49890
		internal static int __PropertyOffset_BakedBendingConstraints;

		// Token: 0x0400C2E3 RID: 49891
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSStaticBatchClothBakedBendingConstraint> _BakedBendingConstraints;

		// Token: 0x0400C2E4 RID: 49892
		internal static int __PropertyOffset_BakedBendingColorStart;

		// Token: 0x0400C2E5 RID: 49893
		[Nullable(2)]
		private TArray<int> _BakedBendingColorStart;

		// Token: 0x0400C2E6 RID: 49894
		internal static int __PropertyOffset_BakedAtlasCellSize;

		// Token: 0x0400C2E7 RID: 49895
		internal static int __PropertyOffset_BakedAtlasNumCols;

		// Token: 0x0400C2E8 RID: 49896
		internal static int __PropertyOffset_BakedAtlasNumRows;

		// Token: 0x0400C2E9 RID: 49897
		internal static int __PropertyOffset_bRefreshInstanceTransformsEveryTick;

		// Token: 0x0400C2EA RID: 49898
		internal static int __PropertyOffset_ColliderSceneActor;
	}
}
