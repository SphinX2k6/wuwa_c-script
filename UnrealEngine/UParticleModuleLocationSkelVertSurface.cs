using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F80 RID: 3968
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleLocationSkelVertSurface")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UParticleModuleLocationSkelVertSurface : UParticleModuleLocationBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D5EA RID: 54762 RVA: 0x0013ADBD File Offset: 0x00138FBD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLocationSkelVertSurface._ClassPtr;
		}

		// Token: 0x0600D5EB RID: 54763 RVA: 0x0013ADCC File Offset: 0x00138FCC
		public UParticleModuleLocationSkelVertSurface() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationSkelVertSurface.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D5EC RID: 54764 RVA: 0x0013ADF4 File Offset: 0x00138FF4
		public UParticleModuleLocationSkelVertSurface(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationSkelVertSurface.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003239 RID: 12857
		// (get) Token: 0x0600D5ED RID: 54765 RVA: 0x0013AE27 File Offset: 0x00139027
		// (set) Token: 0x0600D5EE RID: 54766 RVA: 0x0013AE3B File Offset: 0x0013903B
		[Nullable(0)]
		public unsafe TEnumAsByte<ELocationSkelVertSurfaceSource> SourceType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_SourceType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_SourceType) = value;
			}
		}

		// Token: 0x1700323A RID: 12858
		// (get) Token: 0x0600D5EF RID: 54767 RVA: 0x0013AE50 File Offset: 0x00139050
		// (set) Token: 0x0600D5F0 RID: 54768 RVA: 0x0013AE64 File Offset: 0x00139064
		public unsafe FVector UniversalOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_UniversalOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_UniversalOffset) = value;
			}
		}

		// Token: 0x1700323B RID: 12859
		// (get) Token: 0x0600D5F1 RID: 54769 RVA: 0x0013AE79 File Offset: 0x00139079
		// (set) Token: 0x0600D5F2 RID: 54770 RVA: 0x0013AE92 File Offset: 0x00139092
		public unsafe bool bUpdatePositionEachFrame
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_bUpdatePositionEachFrame) & UParticleModuleLocationSkelVertSurface.__PropertyMask_bUpdatePositionEachFrame) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_bUpdatePositionEachFrame) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_bUpdatePositionEachFrame) & ~UParticleModuleLocationSkelVertSurface.__PropertyMask_bUpdatePositionEachFrame) | (value ? UParticleModuleLocationSkelVertSurface.__PropertyMask_bUpdatePositionEachFrame : 0));
			}
		}

		// Token: 0x1700323C RID: 12860
		// (get) Token: 0x0600D5F3 RID: 54771 RVA: 0x0013AEC2 File Offset: 0x001390C2
		// (set) Token: 0x0600D5F4 RID: 54772 RVA: 0x0013AEDB File Offset: 0x001390DB
		public unsafe bool bOrientMeshEmitters
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_bOrientMeshEmitters) & UParticleModuleLocationSkelVertSurface.__PropertyMask_bOrientMeshEmitters) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_bOrientMeshEmitters) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_bOrientMeshEmitters) & ~UParticleModuleLocationSkelVertSurface.__PropertyMask_bOrientMeshEmitters) | (value ? UParticleModuleLocationSkelVertSurface.__PropertyMask_bOrientMeshEmitters : 0));
			}
		}

		// Token: 0x1700323D RID: 12861
		// (get) Token: 0x0600D5F5 RID: 54773 RVA: 0x0013AF0B File Offset: 0x0013910B
		// (set) Token: 0x0600D5F6 RID: 54774 RVA: 0x0013AF24 File Offset: 0x00139124
		public unsafe bool bInheritBoneVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_bInheritBoneVelocity) & UParticleModuleLocationSkelVertSurface.__PropertyMask_bInheritBoneVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_bInheritBoneVelocity) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_bInheritBoneVelocity) & ~UParticleModuleLocationSkelVertSurface.__PropertyMask_bInheritBoneVelocity) | (value ? UParticleModuleLocationSkelVertSurface.__PropertyMask_bInheritBoneVelocity : 0));
			}
		}

		// Token: 0x1700323E RID: 12862
		// (get) Token: 0x0600D5F7 RID: 54775 RVA: 0x0013AF54 File Offset: 0x00139154
		// (set) Token: 0x0600D5F8 RID: 54776 RVA: 0x0013AF64 File Offset: 0x00139164
		public unsafe float InheritVelocityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_InheritVelocityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_InheritVelocityScale) = value;
			}
		}

		// Token: 0x1700323F RID: 12863
		// (get) Token: 0x0600D5F9 RID: 54777 RVA: 0x0013AF75 File Offset: 0x00139175
		// (set) Token: 0x0600D5FA RID: 54778 RVA: 0x0013AF89 File Offset: 0x00139189
		public unsafe FName SkelMeshActorParamName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_SkelMeshActorParamName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_SkelMeshActorParamName) = value;
			}
		}

		// Token: 0x17003240 RID: 12864
		// (get) Token: 0x0600D5FB RID: 54779 RVA: 0x0013AFA0 File Offset: 0x001391A0
		// (set) Token: 0x0600D5FC RID: 54780 RVA: 0x0013AFD9 File Offset: 0x001391D9
		public TArray<FName> ValidAssociatedBones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ValidAssociatedBones) == null)
				{
					result = (this._ValidAssociatedBones = new TArray<FName>(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_ValidAssociatedBones, this));
				}
				return result;
			}
			set
			{
				this.ValidAssociatedBones.CopyAssign(value);
			}
		}

		// Token: 0x17003241 RID: 12865
		// (get) Token: 0x0600D5FD RID: 54781 RVA: 0x0013AFE7 File Offset: 0x001391E7
		// (set) Token: 0x0600D5FE RID: 54782 RVA: 0x0013B000 File Offset: 0x00139200
		public unsafe bool bEnforceNormalCheck
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_bEnforceNormalCheck) & UParticleModuleLocationSkelVertSurface.__PropertyMask_bEnforceNormalCheck) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_bEnforceNormalCheck) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_bEnforceNormalCheck) & ~UParticleModuleLocationSkelVertSurface.__PropertyMask_bEnforceNormalCheck) | (value ? UParticleModuleLocationSkelVertSurface.__PropertyMask_bEnforceNormalCheck : 0));
			}
		}

		// Token: 0x17003242 RID: 12866
		// (get) Token: 0x0600D5FF RID: 54783 RVA: 0x0013B030 File Offset: 0x00139230
		// (set) Token: 0x0600D600 RID: 54784 RVA: 0x0013B044 File Offset: 0x00139244
		public unsafe FVector NormalToCompare
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_NormalToCompare);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_NormalToCompare) = value;
			}
		}

		// Token: 0x17003243 RID: 12867
		// (get) Token: 0x0600D601 RID: 54785 RVA: 0x0013B059 File Offset: 0x00139259
		// (set) Token: 0x0600D602 RID: 54786 RVA: 0x0013B069 File Offset: 0x00139269
		public unsafe float NormalCheckToleranceDegrees
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_NormalCheckToleranceDegrees);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_NormalCheckToleranceDegrees) = value;
			}
		}

		// Token: 0x17003244 RID: 12868
		// (get) Token: 0x0600D603 RID: 54787 RVA: 0x0013B07A File Offset: 0x0013927A
		// (set) Token: 0x0600D604 RID: 54788 RVA: 0x0013B08A File Offset: 0x0013928A
		public unsafe float NormalCheckTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_NormalCheckTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_NormalCheckTolerance) = value;
			}
		}

		// Token: 0x17003245 RID: 12869
		// (get) Token: 0x0600D605 RID: 54789 RVA: 0x0013B09C File Offset: 0x0013929C
		// (set) Token: 0x0600D606 RID: 54790 RVA: 0x0013B0D5 File Offset: 0x001392D5
		public TArray<int> ValidMaterialIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ValidMaterialIndices) == null)
				{
					result = (this._ValidMaterialIndices = new TArray<int>(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_ValidMaterialIndices, this));
				}
				return result;
			}
			set
			{
				this.ValidMaterialIndices.CopyAssign(value);
			}
		}

		// Token: 0x17003246 RID: 12870
		// (get) Token: 0x0600D607 RID: 54791 RVA: 0x0013B0E3 File Offset: 0x001392E3
		// (set) Token: 0x0600D608 RID: 54792 RVA: 0x0013B0FC File Offset: 0x001392FC
		public unsafe bool bInheritVertexColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_bInheritVertexColor) & UParticleModuleLocationSkelVertSurface.__PropertyMask_bInheritVertexColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_bInheritVertexColor) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_bInheritVertexColor) & ~UParticleModuleLocationSkelVertSurface.__PropertyMask_bInheritVertexColor) | (value ? UParticleModuleLocationSkelVertSurface.__PropertyMask_bInheritVertexColor : 0));
			}
		}

		// Token: 0x17003247 RID: 12871
		// (get) Token: 0x0600D609 RID: 54793 RVA: 0x0013B12C File Offset: 0x0013932C
		// (set) Token: 0x0600D60A RID: 54794 RVA: 0x0013B145 File Offset: 0x00139345
		public unsafe bool bInheritUV
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_bInheritUV) & UParticleModuleLocationSkelVertSurface.__PropertyMask_bInheritUV) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_bInheritUV) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_bInheritUV) & ~UParticleModuleLocationSkelVertSurface.__PropertyMask_bInheritUV) | (value ? UParticleModuleLocationSkelVertSurface.__PropertyMask_bInheritUV : 0));
			}
		}

		// Token: 0x17003248 RID: 12872
		// (get) Token: 0x0600D60B RID: 54795 RVA: 0x0013B175 File Offset: 0x00139375
		// (set) Token: 0x0600D60C RID: 54796 RVA: 0x0013B185 File Offset: 0x00139385
		public unsafe uint InheritUVChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_InheritUVChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationSkelVertSurface.__PropertyOffset_InheritUVChannel) = (int)value;
			}
		}

		// Token: 0x0600D60D RID: 54797 RVA: 0x0013B196 File Offset: 0x00139396
		static UParticleModuleLocationSkelVertSurface()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLocationSkelVertSurface");
		}

		// Token: 0x0600D60E RID: 54798 RVA: 0x0013B1A4 File Offset: 0x001393A4
		protected UParticleModuleLocationSkelVertSurface(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007371 RID: 29553
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLocationSkelVertSurface";

		// Token: 0x04007372 RID: 29554
		private static IntPtr _ClassPtr;

		// Token: 0x04007373 RID: 29555
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007374 RID: 29556
		internal static int __PropertyOffset_SourceType;

		// Token: 0x04007375 RID: 29557
		internal static int __PropertyOffset_UniversalOffset;

		// Token: 0x04007376 RID: 29558
		internal static int __PropertyOffset_bUpdatePositionEachFrame;

		// Token: 0x04007377 RID: 29559
		internal static byte __PropertyMask_bUpdatePositionEachFrame;

		// Token: 0x04007378 RID: 29560
		internal static int __PropertyOffset_bOrientMeshEmitters;

		// Token: 0x04007379 RID: 29561
		internal static byte __PropertyMask_bOrientMeshEmitters;

		// Token: 0x0400737A RID: 29562
		internal static int __PropertyOffset_bInheritBoneVelocity;

		// Token: 0x0400737B RID: 29563
		internal static byte __PropertyMask_bInheritBoneVelocity;

		// Token: 0x0400737C RID: 29564
		internal static int __PropertyOffset_InheritVelocityScale;

		// Token: 0x0400737D RID: 29565
		internal static int __PropertyOffset_SkelMeshActorParamName;

		// Token: 0x0400737E RID: 29566
		internal static int __PropertyOffset_ValidAssociatedBones;

		// Token: 0x0400737F RID: 29567
		[Nullable(2)]
		private TArray<FName> _ValidAssociatedBones;

		// Token: 0x04007380 RID: 29568
		internal static int __PropertyOffset_bEnforceNormalCheck;

		// Token: 0x04007381 RID: 29569
		internal static byte __PropertyMask_bEnforceNormalCheck;

		// Token: 0x04007382 RID: 29570
		internal static int __PropertyOffset_NormalToCompare;

		// Token: 0x04007383 RID: 29571
		internal static int __PropertyOffset_NormalCheckToleranceDegrees;

		// Token: 0x04007384 RID: 29572
		internal static int __PropertyOffset_NormalCheckTolerance;

		// Token: 0x04007385 RID: 29573
		internal static int __PropertyOffset_ValidMaterialIndices;

		// Token: 0x04007386 RID: 29574
		[Nullable(2)]
		private TArray<int> _ValidMaterialIndices;

		// Token: 0x04007387 RID: 29575
		internal static int __PropertyOffset_bInheritVertexColor;

		// Token: 0x04007388 RID: 29576
		internal static byte __PropertyMask_bInheritVertexColor;

		// Token: 0x04007389 RID: 29577
		internal static int __PropertyOffset_bInheritUV;

		// Token: 0x0400738A RID: 29578
		internal static byte __PropertyMask_bInheritUV;

		// Token: 0x0400738B RID: 29579
		internal static int __PropertyOffset_InheritUVChannel;
	}
}
