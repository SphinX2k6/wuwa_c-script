using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000515 RID: 1301
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRopeEffect.ArcRopeComponent")]
	[UnrealStructLayout(2160, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2160)]
	public class UArcRopeComponent : USplineComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600797C RID: 31100 RVA: 0x000B256A File Offset: 0x000B076A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UArcRopeComponent._ClassPtr;
		}

		// Token: 0x0600797D RID: 31101 RVA: 0x000B2578 File Offset: 0x000B0778
		public UArcRopeComponent() : this(BuiltinUtils.AllocNativeUObject(UArcRopeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600797E RID: 31102 RVA: 0x000B25A0 File Offset: 0x000B07A0
		public UArcRopeComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UArcRopeComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x0600797F RID: 31103 RVA: 0x000B25D3 File Offset: 0x000B07D3
		// (set) Token: 0x06007980 RID: 31104 RVA: 0x000B25E3 File Offset: 0x000B07E3
		public unsafe bool bContinuousDrive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_bContinuousDrive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_bContinuousDrive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x06007981 RID: 31105 RVA: 0x000B25F4 File Offset: 0x000B07F4
		// (set) Token: 0x06007982 RID: 31106 RVA: 0x000B2604 File Offset: 0x000B0804
		public unsafe bool bResampleUniform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_bResampleUniform) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_bResampleUniform) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x06007983 RID: 31107 RVA: 0x000B2615 File Offset: 0x000B0815
		// (set) Token: 0x06007984 RID: 31108 RVA: 0x000B2625 File Offset: 0x000B0825
		public unsafe int ResampleSegmentCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_ResampleSegmentCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_ResampleSegmentCount) = value;
			}
		}

		// Token: 0x17001785 RID: 6021
		// (get) Token: 0x06007985 RID: 31109 RVA: 0x000B2636 File Offset: 0x000B0836
		// (set) Token: 0x06007986 RID: 31110 RVA: 0x000B2646 File Offset: 0x000B0846
		public unsafe bool bReinitOnReplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_bReinitOnReplay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_bReinitOnReplay) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x06007987 RID: 31111 RVA: 0x000B2657 File Offset: 0x000B0857
		// (set) Token: 0x06007988 RID: 31112 RVA: 0x000B2667 File Offset: 0x000B0867
		public unsafe float ReinitGapThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_ReinitGapThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_ReinitGapThreshold) = value;
			}
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x06007989 RID: 31113 RVA: 0x000B2678 File Offset: 0x000B0878
		// (set) Token: 0x0600798A RID: 31114 RVA: 0x000B2688 File Offset: 0x000B0888
		public unsafe bool bSimpleWhipMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_bSimpleWhipMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_bSimpleWhipMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x0600798B RID: 31115 RVA: 0x000B2699 File Offset: 0x000B0899
		// (set) Token: 0x0600798C RID: 31116 RVA: 0x000B26A9 File Offset: 0x000B08A9
		public unsafe float WhipStraightenStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_WhipStraightenStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_WhipStraightenStiffness) = value;
			}
		}

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x0600798D RID: 31117 RVA: 0x000B26BA File Offset: 0x000B08BA
		// (set) Token: 0x0600798E RID: 31118 RVA: 0x000B26CA File Offset: 0x000B08CA
		public unsafe float WhipSwing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_WhipSwing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_WhipSwing) = value;
			}
		}

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x0600798F RID: 31119 RVA: 0x000B26DB File Offset: 0x000B08DB
		// (set) Token: 0x06007990 RID: 31120 RVA: 0x000B26EB File Offset: 0x000B08EB
		public unsafe float WhipSmoothing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_WhipSmoothing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_WhipSmoothing) = value;
			}
		}

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x06007991 RID: 31121 RVA: 0x000B26FC File Offset: 0x000B08FC
		// (set) Token: 0x06007992 RID: 31122 RVA: 0x000B270C File Offset: 0x000B090C
		public unsafe int WhipSmoothingIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_WhipSmoothingIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_WhipSmoothingIterations) = value;
			}
		}

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x06007993 RID: 31123 RVA: 0x000B271D File Offset: 0x000B091D
		// (set) Token: 0x06007994 RID: 31124 RVA: 0x000B272D File Offset: 0x000B092D
		public unsafe float WhipSag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_WhipSag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_WhipSag) = value;
			}
		}

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x06007995 RID: 31125 RVA: 0x000B273E File Offset: 0x000B093E
		// (set) Token: 0x06007996 RID: 31126 RVA: 0x000B274E File Offset: 0x000B094E
		public unsafe float WhipStartDirInfluence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_WhipStartDirInfluence);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_WhipStartDirInfluence) = value;
			}
		}

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x06007997 RID: 31127 RVA: 0x000B275F File Offset: 0x000B095F
		// (set) Token: 0x06007998 RID: 31128 RVA: 0x000B276F File Offset: 0x000B096F
		public unsafe float WhipEndDirInfluence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_WhipEndDirInfluence);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_WhipEndDirInfluence) = value;
			}
		}

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x06007999 RID: 31129 RVA: 0x000B2780 File Offset: 0x000B0980
		// (set) Token: 0x0600799A RID: 31130 RVA: 0x000B2790 File Offset: 0x000B0990
		public unsafe bool bEnablePhysics
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_bEnablePhysics) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_bEnablePhysics) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x0600799B RID: 31131 RVA: 0x000B27A1 File Offset: 0x000B09A1
		// (set) Token: 0x0600799C RID: 31132 RVA: 0x000B27B1 File Offset: 0x000B09B1
		public unsafe bool bPinStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_bPinStart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_bPinStart) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x0600799D RID: 31133 RVA: 0x000B27C2 File Offset: 0x000B09C2
		// (set) Token: 0x0600799E RID: 31134 RVA: 0x000B27D2 File Offset: 0x000B09D2
		public unsafe bool bPinEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_bPinEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_bPinEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x0600799F RID: 31135 RVA: 0x000B27E3 File Offset: 0x000B09E3
		// (set) Token: 0x060079A0 RID: 31136 RVA: 0x000B27F7 File Offset: 0x000B09F7
		public unsafe FVector Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x060079A1 RID: 31137 RVA: 0x000B280C File Offset: 0x000B0A0C
		// (set) Token: 0x060079A2 RID: 31138 RVA: 0x000B281C File Offset: 0x000B0A1C
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_Damping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_Damping) = value;
			}
		}

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x060079A3 RID: 31139 RVA: 0x000B282D File Offset: 0x000B0A2D
		// (set) Token: 0x060079A4 RID: 31140 RVA: 0x000B283D File Offset: 0x000B0A3D
		public unsafe int ConstraintIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_ConstraintIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_ConstraintIterations) = value;
			}
		}

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x060079A5 RID: 31141 RVA: 0x000B284E File Offset: 0x000B0A4E
		// (set) Token: 0x060079A6 RID: 31142 RVA: 0x000B285E File Offset: 0x000B0A5E
		public unsafe float Stiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_Stiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_Stiffness) = value;
			}
		}

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x060079A7 RID: 31143 RVA: 0x000B286F File Offset: 0x000B0A6F
		// (set) Token: 0x060079A8 RID: 31144 RVA: 0x000B287F File Offset: 0x000B0A7F
		public unsafe float BendStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_BendStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_BendStiffness) = value;
			}
		}

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x060079A9 RID: 31145 RVA: 0x000B2890 File Offset: 0x000B0A90
		// (set) Token: 0x060079AA RID: 31146 RVA: 0x000B28A0 File Offset: 0x000B0AA0
		public unsafe float MaxTimeStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_MaxTimeStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_MaxTimeStep) = value;
			}
		}

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x060079AB RID: 31147 RVA: 0x000B28B1 File Offset: 0x000B0AB1
		// (set) Token: 0x060079AC RID: 31148 RVA: 0x000B28C1 File Offset: 0x000B0AC1
		public unsafe float TensionPropagation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_TensionPropagation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_TensionPropagation) = value;
			}
		}

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x060079AD RID: 31149 RVA: 0x000B28D2 File Offset: 0x000B0AD2
		// (set) Token: 0x060079AE RID: 31150 RVA: 0x000B28E2 File Offset: 0x000B0AE2
		public unsafe float TensionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_TensionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_TensionStrength) = value;
			}
		}

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x060079AF RID: 31151 RVA: 0x000B28F4 File Offset: 0x000B0AF4
		// (set) Token: 0x060079B0 RID: 31152 RVA: 0x000B292D File Offset: 0x000B0B2D
		public FOnArcRopeInitialized OnRopeInitialized
		{
			get
			{
				base.FastCheckIsValid();
				FOnArcRopeInitialized result;
				if ((result = this._OnRopeInitialized) == null)
				{
					result = (this._OnRopeInitialized = new FOnArcRopeInitialized(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_OnRopeInitialized, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_OnRopeInitialized, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x060079B1 RID: 31153 RVA: 0x000B294E File Offset: 0x000B0B4E
		// (set) Token: 0x060079B2 RID: 31154 RVA: 0x000B2962 File Offset: 0x000B0B62
		[Nullable(2)]
		public unsafe UNiagaraComponent RopeNiagaraComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UArcRopeComponent.__PropertyOffset_RopeNiagaraComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UArcRopeComponent.__PropertyOffset_RopeNiagaraComponent, value);
			}
		}

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x060079B3 RID: 31155 RVA: 0x000B2978 File Offset: 0x000B0B78
		// (set) Token: 0x060079B4 RID: 31156 RVA: 0x000B29B1 File Offset: 0x000B0BB1
		public TArray<float> RestLengths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._RestLengths) == null)
				{
					result = (this._RestLengths = new TArray<float>(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_RestLengths, this));
				}
				return result;
			}
			set
			{
				this.RestLengths.CopyAssign(value);
			}
		}

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x060079B5 RID: 31157 RVA: 0x000B29C0 File Offset: 0x000B0BC0
		// (set) Token: 0x060079B6 RID: 31158 RVA: 0x000B29F9 File Offset: 0x000B0BF9
		public TArray<float> BendRestLengths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._BendRestLengths) == null)
				{
					result = (this._BendRestLengths = new TArray<float>(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_BendRestLengths, this));
				}
				return result;
			}
			set
			{
				this.BendRestLengths.CopyAssign(value);
			}
		}

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x060079B7 RID: 31159 RVA: 0x000B2A07 File Offset: 0x000B0C07
		// (set) Token: 0x060079B8 RID: 31160 RVA: 0x000B2A17 File Offset: 0x000B0C17
		public unsafe bool bInitialized
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_bInitialized) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_bInitialized) = (value ? 1 : 0);
			}
		}

		// Token: 0x060079B9 RID: 31161 RVA: 0x000B2A28 File Offset: 0x000B0C28
		[NullableContext(2)]
		public void SetupNiagara(UNiagaraSystem NiagaraAsset, in FVector InitStart, in FVector InitEnd)
		{
			UArcRopeComponent.__SetupNiagara_Internal(base.NativePtr, (NiagaraAsset != null) ? NiagaraAsset.NativePtr : IntPtr.Zero, InitStart, InitEnd);
		}

		// Token: 0x060079BA RID: 31162 RVA: 0x000B2A47 File Offset: 0x000B0C47
		public void SetStartPosition(in FVector WorldPosition)
		{
			UArcRopeComponent.__SetStartPosition_Internal(base.NativePtr, WorldPosition);
		}

		// Token: 0x060079BB RID: 31163 RVA: 0x000B2A55 File Offset: 0x000B0C55
		public void SetStartDirection(in FVector WorldDirection)
		{
			UArcRopeComponent.__SetStartDirection_Internal(base.NativePtr, WorldDirection);
		}

		// Token: 0x060079BC RID: 31164 RVA: 0x000B2A63 File Offset: 0x000B0C63
		public void SetEndPosition(in FVector WorldPosition)
		{
			UArcRopeComponent.__SetEndPosition_Internal(base.NativePtr, WorldPosition);
		}

		// Token: 0x060079BD RID: 31165 RVA: 0x000B2A71 File Offset: 0x000B0C71
		public void SetEndpoints(in FVector Start, in FVector End)
		{
			UArcRopeComponent.__SetEndpoints_Internal(base.NativePtr, Start, End);
		}

		// Token: 0x060079BE RID: 31166 RVA: 0x000B2A80 File Offset: 0x000B0C80
		public void SetEndDirection(in FVector WorldDirection)
		{
			UArcRopeComponent.__SetEndDirection_Internal(base.NativePtr, WorldDirection);
		}

		// Token: 0x060079BF RID: 31167 RVA: 0x000B2A8E File Offset: 0x000B0C8E
		public void ResetRope()
		{
			UArcRopeComponent.__ResetRope_Internal(base.NativePtr);
		}

		// Token: 0x060079C0 RID: 31168 RVA: 0x000B2A9B File Offset: 0x000B0C9B
		public bool IsInitialized()
		{
			return UArcRopeComponent.__IsInitialized_Internal(base.NativePtr);
		}

		// Token: 0x060079C1 RID: 31169 RVA: 0x000B2AA8 File Offset: 0x000B0CA8
		public int GetParticleCount()
		{
			return UArcRopeComponent.__GetParticleCount_Internal(base.NativePtr);
		}

		// Token: 0x060079C2 RID: 31170 RVA: 0x000B2AB5 File Offset: 0x000B0CB5
		[NullableContext(2)]
		public void ApplyDataAsset(UArcRopeDataAsset DataAsset)
		{
			UArcRopeComponent.__ApplyDataAsset_Internal(base.NativePtr, (DataAsset != null) ? DataAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060079C3 RID: 31171
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetupNiagara_Internal(IntPtr @this, IntPtr NiagaraAsset, in FVector InitStart, in FVector InitEnd);

		// Token: 0x060079C4 RID: 31172
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartPosition_Internal(IntPtr @this, in FVector WorldPosition);

		// Token: 0x060079C5 RID: 31173
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartDirection_Internal(IntPtr @this, in FVector WorldDirection);

		// Token: 0x060079C6 RID: 31174
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndPosition_Internal(IntPtr @this, in FVector WorldPosition);

		// Token: 0x060079C7 RID: 31175
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndpoints_Internal(IntPtr @this, in FVector Start, in FVector End);

		// Token: 0x060079C8 RID: 31176
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndDirection_Internal(IntPtr @this, in FVector WorldDirection);

		// Token: 0x060079C9 RID: 31177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetRope_Internal(IntPtr @this);

		// Token: 0x060079CA RID: 31178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInitialized_Internal(IntPtr @this);

		// Token: 0x060079CB RID: 31179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetParticleCount_Internal(IntPtr @this);

		// Token: 0x060079CC RID: 31180
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyDataAsset_Internal(IntPtr @this, IntPtr DataAsset);

		// Token: 0x060079CD RID: 31181 RVA: 0x000B2AD2 File Offset: 0x000B0CD2
		static UArcRopeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRopeEffect.ArcRopeComponent");
		}

		// Token: 0x060079CE RID: 31182 RVA: 0x000B2AE0 File Offset: 0x000B0CE0
		protected UArcRopeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400339C RID: 13212
		public new const string __ObjectPath = "/Script/KuroRopeEffect.ArcRopeComponent";

		// Token: 0x0400339D RID: 13213
		private static IntPtr _ClassPtr;

		// Token: 0x0400339E RID: 13214
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400339F RID: 13215
		internal static int __PropertyOffset_bContinuousDrive;

		// Token: 0x040033A0 RID: 13216
		internal static int __PropertyOffset_bResampleUniform;

		// Token: 0x040033A1 RID: 13217
		internal static int __PropertyOffset_ResampleSegmentCount;

		// Token: 0x040033A2 RID: 13218
		internal static int __PropertyOffset_bReinitOnReplay;

		// Token: 0x040033A3 RID: 13219
		internal static int __PropertyOffset_ReinitGapThreshold;

		// Token: 0x040033A4 RID: 13220
		internal static int __PropertyOffset_bSimpleWhipMode;

		// Token: 0x040033A5 RID: 13221
		internal static int __PropertyOffset_WhipStraightenStiffness;

		// Token: 0x040033A6 RID: 13222
		internal static int __PropertyOffset_WhipSwing;

		// Token: 0x040033A7 RID: 13223
		internal static int __PropertyOffset_WhipSmoothing;

		// Token: 0x040033A8 RID: 13224
		internal static int __PropertyOffset_WhipSmoothingIterations;

		// Token: 0x040033A9 RID: 13225
		internal static int __PropertyOffset_WhipSag;

		// Token: 0x040033AA RID: 13226
		internal static int __PropertyOffset_WhipStartDirInfluence;

		// Token: 0x040033AB RID: 13227
		internal static int __PropertyOffset_WhipEndDirInfluence;

		// Token: 0x040033AC RID: 13228
		internal static int __PropertyOffset_bEnablePhysics;

		// Token: 0x040033AD RID: 13229
		internal static int __PropertyOffset_bPinStart;

		// Token: 0x040033AE RID: 13230
		internal static int __PropertyOffset_bPinEnd;

		// Token: 0x040033AF RID: 13231
		internal static int __PropertyOffset_Gravity;

		// Token: 0x040033B0 RID: 13232
		internal static int __PropertyOffset_Damping;

		// Token: 0x040033B1 RID: 13233
		internal static int __PropertyOffset_ConstraintIterations;

		// Token: 0x040033B2 RID: 13234
		internal static int __PropertyOffset_Stiffness;

		// Token: 0x040033B3 RID: 13235
		internal static int __PropertyOffset_BendStiffness;

		// Token: 0x040033B4 RID: 13236
		internal static int __PropertyOffset_MaxTimeStep;

		// Token: 0x040033B5 RID: 13237
		internal static int __PropertyOffset_TensionPropagation;

		// Token: 0x040033B6 RID: 13238
		internal static int __PropertyOffset_TensionStrength;

		// Token: 0x040033B7 RID: 13239
		internal static int __PropertyOffset_OnRopeInitialized;

		// Token: 0x040033B8 RID: 13240
		[Nullable(2)]
		private FOnArcRopeInitialized _OnRopeInitialized;

		// Token: 0x040033B9 RID: 13241
		internal static int __PropertyOffset_RopeNiagaraComponent;

		// Token: 0x040033BA RID: 13242
		internal static int __PropertyOffset_RestLengths;

		// Token: 0x040033BB RID: 13243
		[Nullable(2)]
		private TArray<float> _RestLengths;

		// Token: 0x040033BC RID: 13244
		internal static int __PropertyOffset_BendRestLengths;

		// Token: 0x040033BD RID: 13245
		[Nullable(2)]
		private TArray<float> _BendRestLengths;

		// Token: 0x040033BE RID: 13246
		internal static int __PropertyOffset_bInitialized;
	}
}
