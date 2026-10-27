using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C6F RID: 7279
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRopeEffect.ArcRopeComponent")]
	[UnrealStructLayout(2160, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2160)]
	public class UArcRopeComponent : USplineComponent, IUnrealUObject, IUnrealObject, INiagaraParticleCallbackHandler, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601C380 RID: 115584 RVA: 0x00299B92 File Offset: 0x00297D92
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UArcRopeComponent._ClassPtr;
		}

		// Token: 0x0601C381 RID: 115585 RVA: 0x00299B9E File Offset: 0x00297D9E
		int INiagaraParticleCallbackHandler.InterfaceOffset()
		{
			return UArcRopeComponent.__InterfaceOffset_INiagaraParticleCallbackHandler;
		}

		// Token: 0x0601C382 RID: 115586 RVA: 0x00299BA8 File Offset: 0x00297DA8
		public UArcRopeComponent() : this(BuiltinUtils.AllocNativeUObject(UArcRopeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C383 RID: 115587 RVA: 0x00299BD0 File Offset: 0x00297DD0
		public UArcRopeComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UArcRopeComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007200 RID: 29184
		// (get) Token: 0x0601C384 RID: 115588 RVA: 0x00299C03 File Offset: 0x00297E03
		// (set) Token: 0x0601C385 RID: 115589 RVA: 0x00299C13 File Offset: 0x00297E13
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

		// Token: 0x17007201 RID: 29185
		// (get) Token: 0x0601C386 RID: 115590 RVA: 0x00299C24 File Offset: 0x00297E24
		// (set) Token: 0x0601C387 RID: 115591 RVA: 0x00299C34 File Offset: 0x00297E34
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

		// Token: 0x17007202 RID: 29186
		// (get) Token: 0x0601C388 RID: 115592 RVA: 0x00299C45 File Offset: 0x00297E45
		// (set) Token: 0x0601C389 RID: 115593 RVA: 0x00299C55 File Offset: 0x00297E55
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

		// Token: 0x17007203 RID: 29187
		// (get) Token: 0x0601C38A RID: 115594 RVA: 0x00299C66 File Offset: 0x00297E66
		// (set) Token: 0x0601C38B RID: 115595 RVA: 0x00299C76 File Offset: 0x00297E76
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

		// Token: 0x17007204 RID: 29188
		// (get) Token: 0x0601C38C RID: 115596 RVA: 0x00299C87 File Offset: 0x00297E87
		// (set) Token: 0x0601C38D RID: 115597 RVA: 0x00299C97 File Offset: 0x00297E97
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

		// Token: 0x17007205 RID: 29189
		// (get) Token: 0x0601C38E RID: 115598 RVA: 0x00299CA8 File Offset: 0x00297EA8
		// (set) Token: 0x0601C38F RID: 115599 RVA: 0x00299CB8 File Offset: 0x00297EB8
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

		// Token: 0x17007206 RID: 29190
		// (get) Token: 0x0601C390 RID: 115600 RVA: 0x00299CC9 File Offset: 0x00297EC9
		// (set) Token: 0x0601C391 RID: 115601 RVA: 0x00299CD9 File Offset: 0x00297ED9
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

		// Token: 0x17007207 RID: 29191
		// (get) Token: 0x0601C392 RID: 115602 RVA: 0x00299CEA File Offset: 0x00297EEA
		// (set) Token: 0x0601C393 RID: 115603 RVA: 0x00299CFA File Offset: 0x00297EFA
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

		// Token: 0x17007208 RID: 29192
		// (get) Token: 0x0601C394 RID: 115604 RVA: 0x00299D0B File Offset: 0x00297F0B
		// (set) Token: 0x0601C395 RID: 115605 RVA: 0x00299D1B File Offset: 0x00297F1B
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

		// Token: 0x17007209 RID: 29193
		// (get) Token: 0x0601C396 RID: 115606 RVA: 0x00299D2C File Offset: 0x00297F2C
		// (set) Token: 0x0601C397 RID: 115607 RVA: 0x00299D3C File Offset: 0x00297F3C
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

		// Token: 0x1700720A RID: 29194
		// (get) Token: 0x0601C398 RID: 115608 RVA: 0x00299D4D File Offset: 0x00297F4D
		// (set) Token: 0x0601C399 RID: 115609 RVA: 0x00299D5D File Offset: 0x00297F5D
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

		// Token: 0x1700720B RID: 29195
		// (get) Token: 0x0601C39A RID: 115610 RVA: 0x00299D6E File Offset: 0x00297F6E
		// (set) Token: 0x0601C39B RID: 115611 RVA: 0x00299D7E File Offset: 0x00297F7E
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

		// Token: 0x1700720C RID: 29196
		// (get) Token: 0x0601C39C RID: 115612 RVA: 0x00299D8F File Offset: 0x00297F8F
		// (set) Token: 0x0601C39D RID: 115613 RVA: 0x00299D9F File Offset: 0x00297F9F
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

		// Token: 0x1700720D RID: 29197
		// (get) Token: 0x0601C39E RID: 115614 RVA: 0x00299DB0 File Offset: 0x00297FB0
		// (set) Token: 0x0601C39F RID: 115615 RVA: 0x00299DC0 File Offset: 0x00297FC0
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

		// Token: 0x1700720E RID: 29198
		// (get) Token: 0x0601C3A0 RID: 115616 RVA: 0x00299DD1 File Offset: 0x00297FD1
		// (set) Token: 0x0601C3A1 RID: 115617 RVA: 0x00299DE1 File Offset: 0x00297FE1
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

		// Token: 0x1700720F RID: 29199
		// (get) Token: 0x0601C3A2 RID: 115618 RVA: 0x00299DF2 File Offset: 0x00297FF2
		// (set) Token: 0x0601C3A3 RID: 115619 RVA: 0x00299E02 File Offset: 0x00298002
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

		// Token: 0x17007210 RID: 29200
		// (get) Token: 0x0601C3A4 RID: 115620 RVA: 0x00299E13 File Offset: 0x00298013
		// (set) Token: 0x0601C3A5 RID: 115621 RVA: 0x00299E27 File Offset: 0x00298027
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

		// Token: 0x17007211 RID: 29201
		// (get) Token: 0x0601C3A6 RID: 115622 RVA: 0x00299E3C File Offset: 0x0029803C
		// (set) Token: 0x0601C3A7 RID: 115623 RVA: 0x00299E4C File Offset: 0x0029804C
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

		// Token: 0x17007212 RID: 29202
		// (get) Token: 0x0601C3A8 RID: 115624 RVA: 0x00299E5D File Offset: 0x0029805D
		// (set) Token: 0x0601C3A9 RID: 115625 RVA: 0x00299E6D File Offset: 0x0029806D
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

		// Token: 0x17007213 RID: 29203
		// (get) Token: 0x0601C3AA RID: 115626 RVA: 0x00299E7E File Offset: 0x0029807E
		// (set) Token: 0x0601C3AB RID: 115627 RVA: 0x00299E8E File Offset: 0x0029808E
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

		// Token: 0x17007214 RID: 29204
		// (get) Token: 0x0601C3AC RID: 115628 RVA: 0x00299E9F File Offset: 0x0029809F
		// (set) Token: 0x0601C3AD RID: 115629 RVA: 0x00299EAF File Offset: 0x002980AF
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

		// Token: 0x17007215 RID: 29205
		// (get) Token: 0x0601C3AE RID: 115630 RVA: 0x00299EC0 File Offset: 0x002980C0
		// (set) Token: 0x0601C3AF RID: 115631 RVA: 0x00299ED0 File Offset: 0x002980D0
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

		// Token: 0x17007216 RID: 29206
		// (get) Token: 0x0601C3B0 RID: 115632 RVA: 0x00299EE1 File Offset: 0x002980E1
		// (set) Token: 0x0601C3B1 RID: 115633 RVA: 0x00299EF1 File Offset: 0x002980F1
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

		// Token: 0x17007217 RID: 29207
		// (get) Token: 0x0601C3B2 RID: 115634 RVA: 0x00299F02 File Offset: 0x00298102
		// (set) Token: 0x0601C3B3 RID: 115635 RVA: 0x00299F12 File Offset: 0x00298112
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

		// Token: 0x17007218 RID: 29208
		// (get) Token: 0x0601C3B4 RID: 115636 RVA: 0x00299F24 File Offset: 0x00298124
		// (set) Token: 0x0601C3B5 RID: 115637 RVA: 0x00299F5D File Offset: 0x0029815D
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

		// Token: 0x17007219 RID: 29209
		// (get) Token: 0x0601C3B6 RID: 115638 RVA: 0x00299F80 File Offset: 0x00298180
		// (set) Token: 0x0601C3B7 RID: 115639 RVA: 0x00299FB9 File Offset: 0x002981B9
		public TArray<FArcRopeParticle> Particles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FArcRopeParticle> result;
				if ((result = this._Particles) == null)
				{
					result = (this._Particles = new TArray<FArcRopeParticle>(base.NativePtr + (IntPtr)UArcRopeComponent.__PropertyOffset_Particles, this));
				}
				return result;
			}
			set
			{
				this.Particles.CopyAssign(value);
			}
		}

		// Token: 0x1700721A RID: 29210
		// (get) Token: 0x0601C3B8 RID: 115640 RVA: 0x00299FC7 File Offset: 0x002981C7
		// (set) Token: 0x0601C3B9 RID: 115641 RVA: 0x00299FDB File Offset: 0x002981DB
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

		// Token: 0x1700721B RID: 29211
		// (get) Token: 0x0601C3BA RID: 115642 RVA: 0x00299FF0 File Offset: 0x002981F0
		// (set) Token: 0x0601C3BB RID: 115643 RVA: 0x0029A029 File Offset: 0x00298229
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

		// Token: 0x1700721C RID: 29212
		// (get) Token: 0x0601C3BC RID: 115644 RVA: 0x0029A038 File Offset: 0x00298238
		// (set) Token: 0x0601C3BD RID: 115645 RVA: 0x0029A071 File Offset: 0x00298271
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

		// Token: 0x1700721D RID: 29213
		// (get) Token: 0x0601C3BE RID: 115646 RVA: 0x0029A07F File Offset: 0x0029827F
		// (set) Token: 0x0601C3BF RID: 115647 RVA: 0x0029A08F File Offset: 0x0029828F
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

		// Token: 0x0601C3C0 RID: 115648 RVA: 0x0029A0A0 File Offset: 0x002982A0
		[NullableContext(2)]
		public void SetupNiagara(UNiagaraSystem NiagaraAsset, in FVector InitStart, in FVector InitEnd)
		{
			UArcRopeComponent.__SetupNiagara_Internal(base.NativePtr, (NiagaraAsset != null) ? NiagaraAsset.NativePtr : IntPtr.Zero, InitStart, InitEnd);
		}

		// Token: 0x0601C3C1 RID: 115649 RVA: 0x0029A0BF File Offset: 0x002982BF
		public void SetStartPosition(in FVector WorldPosition)
		{
			UArcRopeComponent.__SetStartPosition_Internal(base.NativePtr, WorldPosition);
		}

		// Token: 0x0601C3C2 RID: 115650 RVA: 0x0029A0CD File Offset: 0x002982CD
		public void SetStartDirection(in FVector WorldDirection)
		{
			UArcRopeComponent.__SetStartDirection_Internal(base.NativePtr, WorldDirection);
		}

		// Token: 0x0601C3C3 RID: 115651 RVA: 0x0029A0DB File Offset: 0x002982DB
		public void SetEndPosition(in FVector WorldPosition)
		{
			UArcRopeComponent.__SetEndPosition_Internal(base.NativePtr, WorldPosition);
		}

		// Token: 0x0601C3C4 RID: 115652 RVA: 0x0029A0E9 File Offset: 0x002982E9
		public void SetEndpoints(in FVector Start, in FVector End)
		{
			UArcRopeComponent.__SetEndpoints_Internal(base.NativePtr, Start, End);
		}

		// Token: 0x0601C3C5 RID: 115653 RVA: 0x0029A0F8 File Offset: 0x002982F8
		public void SetEndDirection(in FVector WorldDirection)
		{
			UArcRopeComponent.__SetEndDirection_Internal(base.NativePtr, WorldDirection);
		}

		// Token: 0x0601C3C6 RID: 115654 RVA: 0x0029A106 File Offset: 0x00298306
		public void ResetRope()
		{
			UArcRopeComponent.__ResetRope_Internal(base.NativePtr);
		}

		// Token: 0x0601C3C7 RID: 115655 RVA: 0x0029A113 File Offset: 0x00298313
		public bool IsInitialized()
		{
			return UArcRopeComponent.__IsInitialized_Internal(base.NativePtr);
		}

		// Token: 0x0601C3C8 RID: 115656 RVA: 0x0029A120 File Offset: 0x00298320
		public int GetParticleCount()
		{
			return UArcRopeComponent.__GetParticleCount_Internal(base.NativePtr);
		}

		// Token: 0x0601C3C9 RID: 115657 RVA: 0x0029A12D File Offset: 0x0029832D
		[NullableContext(2)]
		public void ApplyParams(in FArcRopeParams InParams)
		{
			UArcRopeComponent.__ApplyParams_Internal(base.NativePtr, (InParams ?? new FArcRopeParams()).NativePtr);
		}

		// Token: 0x0601C3CA RID: 115658 RVA: 0x0029A14A File Offset: 0x0029834A
		[NullableContext(2)]
		public void ApplyDataAsset(UArcRopeDataAsset DataAsset)
		{
			UArcRopeComponent.__ApplyDataAsset_Internal(base.NativePtr, (DataAsset != null) ? DataAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601C3CB RID: 115659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetupNiagara_Internal(IntPtr @this, IntPtr NiagaraAsset, in FVector InitStart, in FVector InitEnd);

		// Token: 0x0601C3CC RID: 115660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartPosition_Internal(IntPtr @this, in FVector WorldPosition);

		// Token: 0x0601C3CD RID: 115661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartDirection_Internal(IntPtr @this, in FVector WorldDirection);

		// Token: 0x0601C3CE RID: 115662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndPosition_Internal(IntPtr @this, in FVector WorldPosition);

		// Token: 0x0601C3CF RID: 115663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndpoints_Internal(IntPtr @this, in FVector Start, in FVector End);

		// Token: 0x0601C3D0 RID: 115664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndDirection_Internal(IntPtr @this, in FVector WorldDirection);

		// Token: 0x0601C3D1 RID: 115665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetRope_Internal(IntPtr @this);

		// Token: 0x0601C3D2 RID: 115666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInitialized_Internal(IntPtr @this);

		// Token: 0x0601C3D3 RID: 115667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetParticleCount_Internal(IntPtr @this);

		// Token: 0x0601C3D4 RID: 115668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyParams_Internal(IntPtr @this, IntPtr InParams);

		// Token: 0x0601C3D5 RID: 115669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyDataAsset_Internal(IntPtr @this, IntPtr DataAsset);

		// Token: 0x0601C3D6 RID: 115670 RVA: 0x0029A167 File Offset: 0x00298367
		static UArcRopeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRopeEffect.ArcRopeComponent");
		}

		// Token: 0x0601C3D7 RID: 115671 RVA: 0x0029A175 File Offset: 0x00298375
		protected UArcRopeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F2D1 RID: 62161
		internal static int __InterfaceOffset_INiagaraParticleCallbackHandler;

		// Token: 0x0400F2D2 RID: 62162
		public new const string __ObjectPath = "/Script/KuroRopeEffect.ArcRopeComponent";

		// Token: 0x0400F2D3 RID: 62163
		private static IntPtr _ClassPtr;

		// Token: 0x0400F2D4 RID: 62164
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F2D5 RID: 62165
		internal static int __PropertyOffset_bContinuousDrive;

		// Token: 0x0400F2D6 RID: 62166
		internal static int __PropertyOffset_bResampleUniform;

		// Token: 0x0400F2D7 RID: 62167
		internal static int __PropertyOffset_ResampleSegmentCount;

		// Token: 0x0400F2D8 RID: 62168
		internal static int __PropertyOffset_bReinitOnReplay;

		// Token: 0x0400F2D9 RID: 62169
		internal static int __PropertyOffset_ReinitGapThreshold;

		// Token: 0x0400F2DA RID: 62170
		internal static int __PropertyOffset_bSimpleWhipMode;

		// Token: 0x0400F2DB RID: 62171
		internal static int __PropertyOffset_WhipStraightenStiffness;

		// Token: 0x0400F2DC RID: 62172
		internal static int __PropertyOffset_WhipSwing;

		// Token: 0x0400F2DD RID: 62173
		internal static int __PropertyOffset_WhipSmoothing;

		// Token: 0x0400F2DE RID: 62174
		internal static int __PropertyOffset_WhipSmoothingIterations;

		// Token: 0x0400F2DF RID: 62175
		internal static int __PropertyOffset_WhipSag;

		// Token: 0x0400F2E0 RID: 62176
		internal static int __PropertyOffset_WhipStartDirInfluence;

		// Token: 0x0400F2E1 RID: 62177
		internal static int __PropertyOffset_WhipEndDirInfluence;

		// Token: 0x0400F2E2 RID: 62178
		internal static int __PropertyOffset_bEnablePhysics;

		// Token: 0x0400F2E3 RID: 62179
		internal static int __PropertyOffset_bPinStart;

		// Token: 0x0400F2E4 RID: 62180
		internal static int __PropertyOffset_bPinEnd;

		// Token: 0x0400F2E5 RID: 62181
		internal static int __PropertyOffset_Gravity;

		// Token: 0x0400F2E6 RID: 62182
		internal static int __PropertyOffset_Damping;

		// Token: 0x0400F2E7 RID: 62183
		internal static int __PropertyOffset_ConstraintIterations;

		// Token: 0x0400F2E8 RID: 62184
		internal static int __PropertyOffset_Stiffness;

		// Token: 0x0400F2E9 RID: 62185
		internal static int __PropertyOffset_BendStiffness;

		// Token: 0x0400F2EA RID: 62186
		internal static int __PropertyOffset_MaxTimeStep;

		// Token: 0x0400F2EB RID: 62187
		internal static int __PropertyOffset_TensionPropagation;

		// Token: 0x0400F2EC RID: 62188
		internal static int __PropertyOffset_TensionStrength;

		// Token: 0x0400F2ED RID: 62189
		internal static int __PropertyOffset_OnRopeInitialized;

		// Token: 0x0400F2EE RID: 62190
		[Nullable(2)]
		private FOnArcRopeInitialized _OnRopeInitialized;

		// Token: 0x0400F2EF RID: 62191
		internal static int __PropertyOffset_Particles;

		// Token: 0x0400F2F0 RID: 62192
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FArcRopeParticle> _Particles;

		// Token: 0x0400F2F1 RID: 62193
		internal static int __PropertyOffset_RopeNiagaraComponent;

		// Token: 0x0400F2F2 RID: 62194
		internal static int __PropertyOffset_RestLengths;

		// Token: 0x0400F2F3 RID: 62195
		[Nullable(2)]
		private TArray<float> _RestLengths;

		// Token: 0x0400F2F4 RID: 62196
		internal static int __PropertyOffset_BendRestLengths;

		// Token: 0x0400F2F5 RID: 62197
		[Nullable(2)]
		private TArray<float> _BendRestLengths;

		// Token: 0x0400F2F6 RID: 62198
		internal static int __PropertyOffset_bInitialized;
	}
}
