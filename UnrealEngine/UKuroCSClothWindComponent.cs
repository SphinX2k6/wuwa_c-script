using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017AA RID: 6058
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSClothWindComponent")]
	[UnrealStructLayout(552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 552)]
	public class UKuroCSClothWindComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015E95 RID: 89749 RVA: 0x002024E7 File Offset: 0x002006E7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCSClothWindComponent._ClassPtr;
		}

		// Token: 0x06015E96 RID: 89750 RVA: 0x002024F4 File Offset: 0x002006F4
		public UKuroCSClothWindComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroCSClothWindComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015E97 RID: 89751 RVA: 0x0020251C File Offset: 0x0020071C
		public UKuroCSClothWindComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCSClothWindComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170056FF RID: 22271
		// (get) Token: 0x06015E98 RID: 89752 RVA: 0x0020254F File Offset: 0x0020074F
		// (set) Token: 0x06015E99 RID: 89753 RVA: 0x0020255F File Offset: 0x0020075F
		public unsafe int GridXCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_GridXCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_GridXCount) = value;
			}
		}

		// Token: 0x17005700 RID: 22272
		// (get) Token: 0x06015E9A RID: 89754 RVA: 0x00202570 File Offset: 0x00200770
		// (set) Token: 0x06015E9B RID: 89755 RVA: 0x00202580 File Offset: 0x00200780
		public unsafe int GridYCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_GridYCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_GridYCount) = value;
			}
		}

		// Token: 0x17005701 RID: 22273
		// (get) Token: 0x06015E9C RID: 89756 RVA: 0x00202591 File Offset: 0x00200791
		// (set) Token: 0x06015E9D RID: 89757 RVA: 0x002025A1 File Offset: 0x002007A1
		public unsafe float GridSpacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_GridSpacing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_GridSpacing) = value;
			}
		}

		// Token: 0x17005702 RID: 22274
		// (get) Token: 0x06015E9E RID: 89758 RVA: 0x002025B2 File Offset: 0x002007B2
		// (set) Token: 0x06015E9F RID: 89759 RVA: 0x002025C6 File Offset: 0x002007C6
		public unsafe FVector GridStartPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_GridStartPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_GridStartPosition) = value;
			}
		}

		// Token: 0x17005703 RID: 22275
		// (get) Token: 0x06015EA0 RID: 89760 RVA: 0x002025DB File Offset: 0x002007DB
		// (set) Token: 0x06015EA1 RID: 89761 RVA: 0x002025EF File Offset: 0x002007EF
		public unsafe FVector GridRightDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_GridRightDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_GridRightDir) = value;
			}
		}

		// Token: 0x17005704 RID: 22276
		// (get) Token: 0x06015EA2 RID: 89762 RVA: 0x00202604 File Offset: 0x00200804
		// (set) Token: 0x06015EA3 RID: 89763 RVA: 0x00202618 File Offset: 0x00200818
		public unsafe FVector GridDownDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_GridDownDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_GridDownDir) = value;
			}
		}

		// Token: 0x17005705 RID: 22277
		// (get) Token: 0x06015EA4 RID: 89764 RVA: 0x00202630 File Offset: 0x00200830
		// (set) Token: 0x06015EA5 RID: 89765 RVA: 0x00202669 File Offset: 0x00200869
		public TArray<EClothPinEdge> PinnedEdges
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EClothPinEdge> result;
				if ((result = this._PinnedEdges) == null)
				{
					result = (this._PinnedEdges = new TArray<EClothPinEdge>(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_PinnedEdges, this));
				}
				return result;
			}
			set
			{
				this.PinnedEdges.CopyAssign(value);
			}
		}

		// Token: 0x17005706 RID: 22278
		// (get) Token: 0x06015EA6 RID: 89766 RVA: 0x00202677 File Offset: 0x00200877
		// (set) Token: 0x06015EA7 RID: 89767 RVA: 0x0020268B File Offset: 0x0020088B
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D VelocityFieldRT
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCSClothWindComponent.__PropertyOffset_VelocityFieldRT);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCSClothWindComponent.__PropertyOffset_VelocityFieldRT, value);
			}
		}

		// Token: 0x17005707 RID: 22279
		// (get) Token: 0x06015EA8 RID: 89768 RVA: 0x002026A0 File Offset: 0x002008A0
		// (set) Token: 0x06015EA9 RID: 89769 RVA: 0x002026B4 File Offset: 0x002008B4
		public unsafe FVector WindFieldPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_WindFieldPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_WindFieldPosition) = value;
			}
		}

		// Token: 0x17005708 RID: 22280
		// (get) Token: 0x06015EAA RID: 89770 RVA: 0x002026C9 File Offset: 0x002008C9
		// (set) Token: 0x06015EAB RID: 89771 RVA: 0x002026D9 File Offset: 0x002008D9
		public unsafe float WindFieldSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_WindFieldSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_WindFieldSize) = value;
			}
		}

		// Token: 0x17005709 RID: 22281
		// (get) Token: 0x06015EAC RID: 89772 RVA: 0x002026EA File Offset: 0x002008EA
		// (set) Token: 0x06015EAD RID: 89773 RVA: 0x002026FA File Offset: 0x002008FA
		public unsafe float WindStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_WindStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_WindStrength) = value;
			}
		}

		// Token: 0x1700570A RID: 22282
		// (get) Token: 0x06015EAE RID: 89774 RVA: 0x0020270B File Offset: 0x0020090B
		// (set) Token: 0x06015EAF RID: 89775 RVA: 0x0020271B File Offset: 0x0020091B
		public unsafe int substepCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_substepCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_substepCount) = value;
			}
		}

		// Token: 0x1700570B RID: 22283
		// (get) Token: 0x06015EB0 RID: 89776 RVA: 0x0020272C File Offset: 0x0020092C
		// (set) Token: 0x06015EB1 RID: 89777 RVA: 0x0020273C File Offset: 0x0020093C
		public unsafe float DisStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DisStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DisStiffness) = value;
			}
		}

		// Token: 0x1700570C RID: 22284
		// (get) Token: 0x06015EB2 RID: 89778 RVA: 0x0020274D File Offset: 0x0020094D
		// (set) Token: 0x06015EB3 RID: 89779 RVA: 0x00202761 File Offset: 0x00200961
		public unsafe FVector Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x1700570D RID: 22285
		// (get) Token: 0x06015EB4 RID: 89780 RVA: 0x00202776 File Offset: 0x00200976
		// (set) Token: 0x06015EB5 RID: 89781 RVA: 0x00202786 File Offset: 0x00200986
		public unsafe float deltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_deltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_deltaTime) = value;
			}
		}

		// Token: 0x1700570E RID: 22286
		// (get) Token: 0x06015EB6 RID: 89782 RVA: 0x00202797 File Offset: 0x00200997
		// (set) Token: 0x06015EB7 RID: 89783 RVA: 0x002027AB File Offset: 0x002009AB
		public unsafe FVector playerPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_playerPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_playerPos) = value;
			}
		}

		// Token: 0x1700570F RID: 22287
		// (get) Token: 0x06015EB8 RID: 89784 RVA: 0x002027C0 File Offset: 0x002009C0
		// (set) Token: 0x06015EB9 RID: 89785 RVA: 0x002027D0 File Offset: 0x002009D0
		public unsafe float collisionR
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_collisionR);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_collisionR) = value;
			}
		}

		// Token: 0x17005710 RID: 22288
		// (get) Token: 0x06015EBA RID: 89786 RVA: 0x002027E1 File Offset: 0x002009E1
		// (set) Token: 0x06015EBB RID: 89787 RVA: 0x002027F1 File Offset: 0x002009F1
		public unsafe float pushStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_pushStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_pushStrength) = value;
			}
		}

		// Token: 0x17005711 RID: 22289
		// (get) Token: 0x06015EBC RID: 89788 RVA: 0x00202802 File Offset: 0x00200A02
		// (set) Token: 0x06015EBD RID: 89789 RVA: 0x00202812 File Offset: 0x00200A12
		public unsafe int forcePlayerCol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_forcePlayerCol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_forcePlayerCol) = value;
			}
		}

		// Token: 0x17005712 RID: 22290
		// (get) Token: 0x06015EBE RID: 89790 RVA: 0x00202824 File Offset: 0x00200A24
		// (set) Token: 0x06015EBF RID: 89791 RVA: 0x0020285D File Offset: 0x00200A5D
		public TArray<FKuroCSUnifiedCollider_genericCloth> Colliders
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSUnifiedCollider_genericCloth> result;
				if ((result = this._Colliders) == null)
				{
					result = (this._Colliders = new TArray<FKuroCSUnifiedCollider_genericCloth>(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_Colliders, this));
				}
				return result;
			}
			set
			{
				this.Colliders.CopyAssign(value);
			}
		}

		// Token: 0x17005713 RID: 22291
		// (get) Token: 0x06015EC0 RID: 89792 RVA: 0x0020286B File Offset: 0x00200A6B
		// (set) Token: 0x06015EC1 RID: 89793 RVA: 0x0020287B File Offset: 0x00200A7B
		public unsafe int useStaticCol
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_useStaticCol);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_useStaticCol) = value;
			}
		}

		// Token: 0x17005714 RID: 22292
		// (get) Token: 0x06015EC2 RID: 89794 RVA: 0x0020288C File Offset: 0x00200A8C
		// (set) Token: 0x06015EC3 RID: 89795 RVA: 0x0020289C File Offset: 0x00200A9C
		public unsafe bool bEnableCPURead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_bEnableCPURead) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_bEnableCPURead) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005715 RID: 22293
		// (get) Token: 0x06015EC4 RID: 89796 RVA: 0x002028B0 File Offset: 0x00200AB0
		// (set) Token: 0x06015EC5 RID: 89797 RVA: 0x002028E9 File Offset: 0x00200AE9
		public TArray<FKuroCSParticle_genericCloth> DebugArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCSParticle_genericCloth> result;
				if ((result = this._DebugArr) == null)
				{
					result = (this._DebugArr = new TArray<FKuroCSParticle_genericCloth>(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugArr, this));
				}
				return result;
			}
			set
			{
				this.DebugArr.CopyAssign(value);
			}
		}

		// Token: 0x17005716 RID: 22294
		// (get) Token: 0x06015EC6 RID: 89798 RVA: 0x002028F7 File Offset: 0x00200AF7
		// (set) Token: 0x06015EC7 RID: 89799 RVA: 0x00202907 File Offset: 0x00200B07
		public unsafe bool bDebugVisualize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_bDebugVisualize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_bDebugVisualize) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005717 RID: 22295
		// (get) Token: 0x06015EC8 RID: 89800 RVA: 0x00202918 File Offset: 0x00200B18
		// (set) Token: 0x06015EC9 RID: 89801 RVA: 0x00202928 File Offset: 0x00200B28
		public unsafe bool bDebugDrawParticles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_bDebugDrawParticles) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_bDebugDrawParticles) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005718 RID: 22296
		// (get) Token: 0x06015ECA RID: 89802 RVA: 0x00202939 File Offset: 0x00200B39
		// (set) Token: 0x06015ECB RID: 89803 RVA: 0x00202949 File Offset: 0x00200B49
		public unsafe float DebugParticleRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugParticleRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugParticleRadius) = value;
			}
		}

		// Token: 0x17005719 RID: 22297
		// (get) Token: 0x06015ECC RID: 89804 RVA: 0x0020295A File Offset: 0x00200B5A
		// (set) Token: 0x06015ECD RID: 89805 RVA: 0x0020296E File Offset: 0x00200B6E
		public unsafe FColor DebugColorParticleFree
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugColorParticleFree);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugColorParticleFree) = value;
			}
		}

		// Token: 0x1700571A RID: 22298
		// (get) Token: 0x06015ECE RID: 89806 RVA: 0x00202983 File Offset: 0x00200B83
		// (set) Token: 0x06015ECF RID: 89807 RVA: 0x00202997 File Offset: 0x00200B97
		public unsafe FColor DebugColorParticlePinned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugColorParticlePinned);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugColorParticlePinned) = value;
			}
		}

		// Token: 0x1700571B RID: 22299
		// (get) Token: 0x06015ED0 RID: 89808 RVA: 0x002029AC File Offset: 0x00200BAC
		// (set) Token: 0x06015ED1 RID: 89809 RVA: 0x002029BC File Offset: 0x00200BBC
		public unsafe bool bDebugDrawStructural
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_bDebugDrawStructural) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_bDebugDrawStructural) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700571C RID: 22300
		// (get) Token: 0x06015ED2 RID: 89810 RVA: 0x002029CD File Offset: 0x00200BCD
		// (set) Token: 0x06015ED3 RID: 89811 RVA: 0x002029E1 File Offset: 0x00200BE1
		public unsafe FColor DebugColorStructural
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugColorStructural);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugColorStructural) = value;
			}
		}

		// Token: 0x1700571D RID: 22301
		// (get) Token: 0x06015ED4 RID: 89812 RVA: 0x002029F6 File Offset: 0x00200BF6
		// (set) Token: 0x06015ED5 RID: 89813 RVA: 0x00202A06 File Offset: 0x00200C06
		public unsafe bool bDebugDrawShear
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_bDebugDrawShear) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_bDebugDrawShear) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700571E RID: 22302
		// (get) Token: 0x06015ED6 RID: 89814 RVA: 0x00202A17 File Offset: 0x00200C17
		// (set) Token: 0x06015ED7 RID: 89815 RVA: 0x00202A2B File Offset: 0x00200C2B
		public unsafe FColor DebugColorShear
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugColorShear);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugColorShear) = value;
			}
		}

		// Token: 0x1700571F RID: 22303
		// (get) Token: 0x06015ED8 RID: 89816 RVA: 0x00202A40 File Offset: 0x00200C40
		// (set) Token: 0x06015ED9 RID: 89817 RVA: 0x00202A50 File Offset: 0x00200C50
		public unsafe bool bDebugDrawBend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_bDebugDrawBend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_bDebugDrawBend) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005720 RID: 22304
		// (get) Token: 0x06015EDA RID: 89818 RVA: 0x00202A61 File Offset: 0x00200C61
		// (set) Token: 0x06015EDB RID: 89819 RVA: 0x00202A75 File Offset: 0x00200C75
		public unsafe FColor DebugColorBend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugColorBend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugColorBend) = value;
			}
		}

		// Token: 0x17005721 RID: 22305
		// (get) Token: 0x06015EDC RID: 89820 RVA: 0x00202A8A File Offset: 0x00200C8A
		// (set) Token: 0x06015EDD RID: 89821 RVA: 0x00202A9A File Offset: 0x00200C9A
		public unsafe bool bDebugDrawWindBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_bDebugDrawWindBounds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_bDebugDrawWindBounds) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005722 RID: 22306
		// (get) Token: 0x06015EDE RID: 89822 RVA: 0x00202AAB File Offset: 0x00200CAB
		// (set) Token: 0x06015EDF RID: 89823 RVA: 0x00202ABF File Offset: 0x00200CBF
		public unsafe FColor DebugColorWindBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugColorWindBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugColorWindBounds) = value;
			}
		}

		// Token: 0x17005723 RID: 22307
		// (get) Token: 0x06015EE0 RID: 89824 RVA: 0x00202AD4 File Offset: 0x00200CD4
		// (set) Token: 0x06015EE1 RID: 89825 RVA: 0x00202AE4 File Offset: 0x00200CE4
		public unsafe bool bDebugWriteGridCoords
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_bDebugWriteGridCoords) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_bDebugWriteGridCoords) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005724 RID: 22308
		// (get) Token: 0x06015EE2 RID: 89826 RVA: 0x00202AF5 File Offset: 0x00200CF5
		// (set) Token: 0x06015EE3 RID: 89827 RVA: 0x00202B05 File Offset: 0x00200D05
		public unsafe bool bDebugDrawWindSample
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_bDebugDrawWindSample) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_bDebugDrawWindSample) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005725 RID: 22309
		// (get) Token: 0x06015EE4 RID: 89828 RVA: 0x00202B16 File Offset: 0x00200D16
		// (set) Token: 0x06015EE5 RID: 89829 RVA: 0x00202B26 File Offset: 0x00200D26
		public unsafe int DebugWindSampleStride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugWindSampleStride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugWindSampleStride) = value;
			}
		}

		// Token: 0x17005726 RID: 22310
		// (get) Token: 0x06015EE6 RID: 89830 RVA: 0x00202B37 File Offset: 0x00200D37
		// (set) Token: 0x06015EE7 RID: 89831 RVA: 0x00202B47 File Offset: 0x00200D47
		public unsafe float DebugWindArrowScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugWindArrowScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugWindArrowScale) = value;
			}
		}

		// Token: 0x17005727 RID: 22311
		// (get) Token: 0x06015EE8 RID: 89832 RVA: 0x00202B58 File Offset: 0x00200D58
		// (set) Token: 0x06015EE9 RID: 89833 RVA: 0x00202B6C File Offset: 0x00200D6C
		public unsafe FColor DebugColorWindHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugColorWindHit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugColorWindHit) = value;
			}
		}

		// Token: 0x17005728 RID: 22312
		// (get) Token: 0x06015EEA RID: 89834 RVA: 0x00202B81 File Offset: 0x00200D81
		// (set) Token: 0x06015EEB RID: 89835 RVA: 0x00202B95 File Offset: 0x00200D95
		public unsafe FColor DebugColorWindMiss
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugColorWindMiss);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugColorWindMiss) = value;
			}
		}

		// Token: 0x17005729 RID: 22313
		// (get) Token: 0x06015EEC RID: 89836 RVA: 0x00202BAA File Offset: 0x00200DAA
		// (set) Token: 0x06015EED RID: 89837 RVA: 0x00202BBE File Offset: 0x00200DBE
		public unsafe FColor DebugColorNoField
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugColorNoField);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_DebugColorNoField) = value;
			}
		}

		// Token: 0x1700572A RID: 22314
		// (get) Token: 0x06015EEE RID: 89838 RVA: 0x00202BD3 File Offset: 0x00200DD3
		// (set) Token: 0x06015EEF RID: 89839 RVA: 0x00202BE3 File Offset: 0x00200DE3
		public unsafe float moveableDis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_moveableDis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_moveableDis) = value;
			}
		}

		// Token: 0x1700572B RID: 22315
		// (get) Token: 0x06015EF0 RID: 89840 RVA: 0x00202BF4 File Offset: 0x00200DF4
		// (set) Token: 0x06015EF1 RID: 89841 RVA: 0x00202C04 File Offset: 0x00200E04
		public unsafe float springK
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_springK);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_springK) = value;
			}
		}

		// Token: 0x1700572C RID: 22316
		// (get) Token: 0x06015EF2 RID: 89842 RVA: 0x00202C15 File Offset: 0x00200E15
		// (set) Token: 0x06015EF3 RID: 89843 RVA: 0x00202C25 File Offset: 0x00200E25
		public unsafe float springC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_springC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_springC) = value;
			}
		}

		// Token: 0x1700572D RID: 22317
		// (get) Token: 0x06015EF4 RID: 89844 RVA: 0x00202C36 File Offset: 0x00200E36
		// (set) Token: 0x06015EF5 RID: 89845 RVA: 0x00202C46 File Offset: 0x00200E46
		public unsafe int lockXYZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_lockXYZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_lockXYZ) = value;
			}
		}

		// Token: 0x1700572E RID: 22318
		// (get) Token: 0x06015EF6 RID: 89846 RVA: 0x00202C57 File Offset: 0x00200E57
		// (set) Token: 0x06015EF7 RID: 89847 RVA: 0x00202C67 File Offset: 0x00200E67
		public unsafe int attackOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_attackOrNot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_attackOrNot) = value;
			}
		}

		// Token: 0x1700572F RID: 22319
		// (get) Token: 0x06015EF8 RID: 89848 RVA: 0x00202C78 File Offset: 0x00200E78
		// (set) Token: 0x06015EF9 RID: 89849 RVA: 0x00202C88 File Offset: 0x00200E88
		public unsafe int overlapOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_overlapOrNot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_overlapOrNot) = value;
			}
		}

		// Token: 0x17005730 RID: 22320
		// (get) Token: 0x06015EFA RID: 89850 RVA: 0x00202C99 File Offset: 0x00200E99
		// (set) Token: 0x06015EFB RID: 89851 RVA: 0x00202CA9 File Offset: 0x00200EA9
		public unsafe int revertOrNot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_revertOrNot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_revertOrNot) = value;
			}
		}

		// Token: 0x17005731 RID: 22321
		// (get) Token: 0x06015EFC RID: 89852 RVA: 0x00202CBA File Offset: 0x00200EBA
		// (set) Token: 0x06015EFD RID: 89853 RVA: 0x00202CCE File Offset: 0x00200ECE
		public unsafe FVector actorPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_actorPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_actorPos) = value;
			}
		}

		// Token: 0x17005732 RID: 22322
		// (get) Token: 0x06015EFE RID: 89854 RVA: 0x00202CE3 File Offset: 0x00200EE3
		// (set) Token: 0x06015EFF RID: 89855 RVA: 0x00202CF7 File Offset: 0x00200EF7
		public unsafe FVector actorRotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_actorRotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCSClothWindComponent.__PropertyOffset_actorRotator) = value;
			}
		}

		// Token: 0x06015F00 RID: 89856 RVA: 0x00202D0C File Offset: 0x00200F0C
		public void StopAndRelease()
		{
			UKuroCSClothWindComponent.__StopAndRelease_Internal(base.NativePtr);
		}

		// Token: 0x06015F01 RID: 89857 RVA: 0x00202D19 File Offset: 0x00200F19
		[NullableContext(2)]
		public void SetAtlasOutputRT(UTextureRenderTarget2D RT)
		{
			UKuroCSClothWindComponent.__SetAtlasOutputRT_Internal(base.NativePtr, (RT != null) ? RT.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06015F02 RID: 89858 RVA: 0x00202D36 File Offset: 0x00200F36
		public bool IsUsingAtlas()
		{
			return UKuroCSClothWindComponent.__IsUsingAtlas_Internal(base.NativePtr);
		}

		// Token: 0x06015F03 RID: 89859 RVA: 0x00202D43 File Offset: 0x00200F43
		public FVector2D GetAtlasTileUVScale()
		{
			return UKuroCSClothWindComponent.__GetAtlasTileUVScale_Internal(base.NativePtr);
		}

		// Token: 0x06015F04 RID: 89860 RVA: 0x00202D50 File Offset: 0x00200F50
		public FVector2D GetAtlasTileUVOffset()
		{
			return UKuroCSClothWindComponent.__GetAtlasTileUVOffset_Internal(base.NativePtr);
		}

		// Token: 0x06015F05 RID: 89861 RVA: 0x00202D5D File Offset: 0x00200F5D
		public int GetAtlasSlotIndex()
		{
			return UKuroCSClothWindComponent.__GetAtlasSlotIndex_Internal(base.NativePtr);
		}

		// Token: 0x06015F06 RID: 89862 RVA: 0x00202D6A File Offset: 0x00200F6A
		[NullableContext(2)]
		public UTextureRenderTarget2D GetAtlasRenderTarget()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTextureRenderTarget2D>(UKuroCSClothWindComponent.__GetAtlasRenderTarget_Internal(base.NativePtr));
		}

		// Token: 0x06015F07 RID: 89863
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyAtlasManager();

		// Token: 0x06015F08 RID: 89864
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CreateAtlasManager(int InAtlasSize = 256, int InTileSize = 64);

		// Token: 0x06015F09 RID: 89865 RVA: 0x00202D7C File Offset: 0x00200F7C
		public void BuildAndStart()
		{
			UKuroCSClothWindComponent.__BuildAndStart_Internal(base.NativePtr);
		}

		// Token: 0x06015F0A RID: 89866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAndRelease_Internal(IntPtr @this);

		// Token: 0x06015F0B RID: 89867
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAtlasOutputRT_Internal(IntPtr @this, IntPtr RT);

		// Token: 0x06015F0C RID: 89868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUsingAtlas_Internal(IntPtr @this);

		// Token: 0x06015F0D RID: 89869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetAtlasTileUVScale_Internal(IntPtr @this);

		// Token: 0x06015F0E RID: 89870
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetAtlasTileUVOffset_Internal(IntPtr @this);

		// Token: 0x06015F0F RID: 89871
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetAtlasSlotIndex_Internal(IntPtr @this);

		// Token: 0x06015F10 RID: 89872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAtlasRenderTarget_Internal(IntPtr @this);

		// Token: 0x06015F11 RID: 89873
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BuildAndStart_Internal(IntPtr @this);

		// Token: 0x06015F12 RID: 89874 RVA: 0x00202D89 File Offset: 0x00200F89
		static UKuroCSClothWindComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.KuroCSClothWindComponent");
		}

		// Token: 0x06015F13 RID: 89875 RVA: 0x00202D97 File Offset: 0x00200F97
		protected UKuroCSClothWindComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BF14 RID: 48916
		public new const string __ObjectPath = "/Script/KuroComputeShader.KuroCSClothWindComponent";

		// Token: 0x0400BF15 RID: 48917
		private static IntPtr _ClassPtr;

		// Token: 0x0400BF16 RID: 48918
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BF17 RID: 48919
		internal static int __PropertyOffset_GridXCount;

		// Token: 0x0400BF18 RID: 48920
		internal static int __PropertyOffset_GridYCount;

		// Token: 0x0400BF19 RID: 48921
		internal static int __PropertyOffset_GridSpacing;

		// Token: 0x0400BF1A RID: 48922
		internal static int __PropertyOffset_GridStartPosition;

		// Token: 0x0400BF1B RID: 48923
		internal static int __PropertyOffset_GridRightDir;

		// Token: 0x0400BF1C RID: 48924
		internal static int __PropertyOffset_GridDownDir;

		// Token: 0x0400BF1D RID: 48925
		internal static int __PropertyOffset_PinnedEdges;

		// Token: 0x0400BF1E RID: 48926
		[Nullable(2)]
		private TArray<EClothPinEdge> _PinnedEdges;

		// Token: 0x0400BF1F RID: 48927
		internal static int __PropertyOffset_VelocityFieldRT;

		// Token: 0x0400BF20 RID: 48928
		internal static int __PropertyOffset_WindFieldPosition;

		// Token: 0x0400BF21 RID: 48929
		internal static int __PropertyOffset_WindFieldSize;

		// Token: 0x0400BF22 RID: 48930
		internal static int __PropertyOffset_WindStrength;

		// Token: 0x0400BF23 RID: 48931
		internal static int __PropertyOffset_substepCount;

		// Token: 0x0400BF24 RID: 48932
		internal static int __PropertyOffset_DisStiffness;

		// Token: 0x0400BF25 RID: 48933
		internal static int __PropertyOffset_Gravity;

		// Token: 0x0400BF26 RID: 48934
		internal static int __PropertyOffset_deltaTime;

		// Token: 0x0400BF27 RID: 48935
		internal static int __PropertyOffset_playerPos;

		// Token: 0x0400BF28 RID: 48936
		internal static int __PropertyOffset_collisionR;

		// Token: 0x0400BF29 RID: 48937
		internal static int __PropertyOffset_pushStrength;

		// Token: 0x0400BF2A RID: 48938
		internal static int __PropertyOffset_forcePlayerCol;

		// Token: 0x0400BF2B RID: 48939
		internal static int __PropertyOffset_Colliders;

		// Token: 0x0400BF2C RID: 48940
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSUnifiedCollider_genericCloth> _Colliders;

		// Token: 0x0400BF2D RID: 48941
		internal static int __PropertyOffset_useStaticCol;

		// Token: 0x0400BF2E RID: 48942
		internal static int __PropertyOffset_bEnableCPURead;

		// Token: 0x0400BF2F RID: 48943
		internal static int __PropertyOffset_DebugArr;

		// Token: 0x0400BF30 RID: 48944
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCSParticle_genericCloth> _DebugArr;

		// Token: 0x0400BF31 RID: 48945
		internal static int __PropertyOffset_bDebugVisualize;

		// Token: 0x0400BF32 RID: 48946
		internal static int __PropertyOffset_bDebugDrawParticles;

		// Token: 0x0400BF33 RID: 48947
		internal static int __PropertyOffset_DebugParticleRadius;

		// Token: 0x0400BF34 RID: 48948
		internal static int __PropertyOffset_DebugColorParticleFree;

		// Token: 0x0400BF35 RID: 48949
		internal static int __PropertyOffset_DebugColorParticlePinned;

		// Token: 0x0400BF36 RID: 48950
		internal static int __PropertyOffset_bDebugDrawStructural;

		// Token: 0x0400BF37 RID: 48951
		internal static int __PropertyOffset_DebugColorStructural;

		// Token: 0x0400BF38 RID: 48952
		internal static int __PropertyOffset_bDebugDrawShear;

		// Token: 0x0400BF39 RID: 48953
		internal static int __PropertyOffset_DebugColorShear;

		// Token: 0x0400BF3A RID: 48954
		internal static int __PropertyOffset_bDebugDrawBend;

		// Token: 0x0400BF3B RID: 48955
		internal static int __PropertyOffset_DebugColorBend;

		// Token: 0x0400BF3C RID: 48956
		internal static int __PropertyOffset_bDebugDrawWindBounds;

		// Token: 0x0400BF3D RID: 48957
		internal static int __PropertyOffset_DebugColorWindBounds;

		// Token: 0x0400BF3E RID: 48958
		internal static int __PropertyOffset_bDebugWriteGridCoords;

		// Token: 0x0400BF3F RID: 48959
		internal static int __PropertyOffset_bDebugDrawWindSample;

		// Token: 0x0400BF40 RID: 48960
		internal static int __PropertyOffset_DebugWindSampleStride;

		// Token: 0x0400BF41 RID: 48961
		internal static int __PropertyOffset_DebugWindArrowScale;

		// Token: 0x0400BF42 RID: 48962
		internal static int __PropertyOffset_DebugColorWindHit;

		// Token: 0x0400BF43 RID: 48963
		internal static int __PropertyOffset_DebugColorWindMiss;

		// Token: 0x0400BF44 RID: 48964
		internal static int __PropertyOffset_DebugColorNoField;

		// Token: 0x0400BF45 RID: 48965
		internal static int __PropertyOffset_moveableDis;

		// Token: 0x0400BF46 RID: 48966
		internal static int __PropertyOffset_springK;

		// Token: 0x0400BF47 RID: 48967
		internal static int __PropertyOffset_springC;

		// Token: 0x0400BF48 RID: 48968
		internal static int __PropertyOffset_lockXYZ;

		// Token: 0x0400BF49 RID: 48969
		internal static int __PropertyOffset_attackOrNot;

		// Token: 0x0400BF4A RID: 48970
		internal static int __PropertyOffset_overlapOrNot;

		// Token: 0x0400BF4B RID: 48971
		internal static int __PropertyOffset_revertOrNot;

		// Token: 0x0400BF4C RID: 48972
		internal static int __PropertyOffset_actorPos;

		// Token: 0x0400BF4D RID: 48973
		internal static int __PropertyOffset_actorRotator;
	}
}
