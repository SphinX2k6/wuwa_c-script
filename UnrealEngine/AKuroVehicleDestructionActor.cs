using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BDC RID: 7132
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroVehicleDestructionActor")]
	[UnrealStructLayout(1808, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1808)]
	public class AKuroVehicleDestructionActor : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B607 RID: 112135 RVA: 0x002857C2 File Offset: 0x002839C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroVehicleDestructionActor._ClassPtr;
		}

		// Token: 0x0601B608 RID: 112136 RVA: 0x002857D0 File Offset: 0x002839D0
		public AKuroVehicleDestructionActor() : this(BuiltinUtils.AllocNativeUObject(AKuroVehicleDestructionActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B609 RID: 112137 RVA: 0x002857F8 File Offset: 0x002839F8
		public AKuroVehicleDestructionActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroVehicleDestructionActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006DFA RID: 28154
		// (get) Token: 0x0601B60A RID: 112138 RVA: 0x0028582C File Offset: 0x00283A2C
		// (set) Token: 0x0601B60B RID: 112139 RVA: 0x00285865 File Offset: 0x00283A65
		public TArray<FVehiclePartInfo> VehicleParts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVehiclePartInfo> result;
				if ((result = this._VehicleParts) == null)
				{
					result = (this._VehicleParts = new TArray<FVehiclePartInfo>(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_VehicleParts, this));
				}
				return result;
			}
			set
			{
				this.VehicleParts.CopyAssign(value);
			}
		}

		// Token: 0x17006DFB RID: 28155
		// (get) Token: 0x0601B60C RID: 112140 RVA: 0x00285873 File Offset: 0x00283A73
		// (set) Token: 0x0601B60D RID: 112141 RVA: 0x00285887 File Offset: 0x00283A87
		[Nullable(2)]
		public unsafe UPrimitiveComponent VehicleMainComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroVehicleDestructionActor.__PropertyOffset_VehicleMainComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroVehicleDestructionActor.__PropertyOffset_VehicleMainComponent, value);
			}
		}

		// Token: 0x17006DFC RID: 28156
		// (get) Token: 0x0601B60E RID: 112142 RVA: 0x0028589C File Offset: 0x00283A9C
		// (set) Token: 0x0601B60F RID: 112143 RVA: 0x002858B0 File Offset: 0x00283AB0
		public unsafe FVector HitPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_HitPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_HitPosition) = value;
			}
		}

		// Token: 0x17006DFD RID: 28157
		// (get) Token: 0x0601B610 RID: 112144 RVA: 0x002858C5 File Offset: 0x00283AC5
		// (set) Token: 0x0601B611 RID: 112145 RVA: 0x002858D5 File Offset: 0x00283AD5
		public unsafe float ImpactStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_ImpactStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_ImpactStrength) = value;
			}
		}

		// Token: 0x17006DFE RID: 28158
		// (get) Token: 0x0601B612 RID: 112146 RVA: 0x002858E6 File Offset: 0x00283AE6
		// (set) Token: 0x0601B613 RID: 112147 RVA: 0x002858F6 File Offset: 0x00283AF6
		public unsafe bool bHasNewImpact
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_bHasNewImpact) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_bHasNewImpact) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006DFF RID: 28159
		// (get) Token: 0x0601B614 RID: 112148 RVA: 0x00285907 File Offset: 0x00283B07
		// (set) Token: 0x0601B615 RID: 112149 RVA: 0x00285917 File Offset: 0x00283B17
		public unsafe float MinImpactSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_MinImpactSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_MinImpactSpeed) = value;
			}
		}

		// Token: 0x17006E00 RID: 28160
		// (get) Token: 0x0601B616 RID: 112150 RVA: 0x00285928 File Offset: 0x00283B28
		// (set) Token: 0x0601B617 RID: 112151 RVA: 0x00285938 File Offset: 0x00283B38
		public unsafe float SpringStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_SpringStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_SpringStiffness) = value;
			}
		}

		// Token: 0x17006E01 RID: 28161
		// (get) Token: 0x0601B618 RID: 112152 RVA: 0x00285949 File Offset: 0x00283B49
		// (set) Token: 0x0601B619 RID: 112153 RVA: 0x00285959 File Offset: 0x00283B59
		public unsafe float SpringDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_SpringDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_SpringDamping) = value;
			}
		}

		// Token: 0x17006E02 RID: 28162
		// (get) Token: 0x0601B61A RID: 112154 RVA: 0x0028596A File Offset: 0x00283B6A
		// (set) Token: 0x0601B61B RID: 112155 RVA: 0x0028597A File Offset: 0x00283B7A
		public unsafe float ImpactPitchScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_ImpactPitchScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_ImpactPitchScale) = value;
			}
		}

		// Token: 0x17006E03 RID: 28163
		// (get) Token: 0x0601B61C RID: 112156 RVA: 0x0028598B File Offset: 0x00283B8B
		// (set) Token: 0x0601B61D RID: 112157 RVA: 0x0028599B File Offset: 0x00283B9B
		public unsafe float ImpactRollScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_ImpactRollScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_ImpactRollScale) = value;
			}
		}

		// Token: 0x17006E04 RID: 28164
		// (get) Token: 0x0601B61E RID: 112158 RVA: 0x002859AC File Offset: 0x00283BAC
		// (set) Token: 0x0601B61F RID: 112159 RVA: 0x002859BC File Offset: 0x00283BBC
		public unsafe float MaxPitchSwing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_MaxPitchSwing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_MaxPitchSwing) = value;
			}
		}

		// Token: 0x17006E05 RID: 28165
		// (get) Token: 0x0601B620 RID: 112160 RVA: 0x002859CD File Offset: 0x00283BCD
		// (set) Token: 0x0601B621 RID: 112161 RVA: 0x002859DD File Offset: 0x00283BDD
		public unsafe float MaxRollSwing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_MaxRollSwing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_MaxRollSwing) = value;
			}
		}

		// Token: 0x17006E06 RID: 28166
		// (get) Token: 0x0601B622 RID: 112162 RVA: 0x002859EE File Offset: 0x00283BEE
		// (set) Token: 0x0601B623 RID: 112163 RVA: 0x00285A02 File Offset: 0x00283C02
		public unsafe FVector DamageImpactLocalAcceptHalfExtents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_DamageImpactLocalAcceptHalfExtents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_DamageImpactLocalAcceptHalfExtents) = value;
			}
		}

		// Token: 0x17006E07 RID: 28167
		// (get) Token: 0x0601B624 RID: 112164 RVA: 0x00285A18 File Offset: 0x00283C18
		// (set) Token: 0x0601B625 RID: 112165 RVA: 0x00285A51 File Offset: 0x00283C51
		public TArray<USceneComponent> WheelComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USceneComponent> result;
				if ((result = this._WheelComponents) == null)
				{
					result = (this._WheelComponents = new TArray<USceneComponent>(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_WheelComponents, this));
				}
				return result;
			}
			set
			{
				this.WheelComponents.CopyAssign(value);
			}
		}

		// Token: 0x17006E08 RID: 28168
		// (get) Token: 0x0601B626 RID: 112166 RVA: 0x00285A5F File Offset: 0x00283C5F
		// (set) Token: 0x0601B627 RID: 112167 RVA: 0x00285A6F File Offset: 0x00283C6F
		public unsafe float SelfDestructShakeDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_SelfDestructShakeDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_SelfDestructShakeDuration) = value;
			}
		}

		// Token: 0x17006E09 RID: 28169
		// (get) Token: 0x0601B628 RID: 112168 RVA: 0x00285A80 File Offset: 0x00283C80
		// (set) Token: 0x0601B629 RID: 112169 RVA: 0x00285A94 File Offset: 0x00283C94
		public unsafe FVector SelfDestructShakeRotAmplitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_SelfDestructShakeRotAmplitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_SelfDestructShakeRotAmplitude) = value;
			}
		}

		// Token: 0x17006E0A RID: 28170
		// (get) Token: 0x0601B62A RID: 112170 RVA: 0x00285AA9 File Offset: 0x00283CA9
		// (set) Token: 0x0601B62B RID: 112171 RVA: 0x00285ABD File Offset: 0x00283CBD
		public unsafe FVector SelfDestructShakeLocAmplitude
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_SelfDestructShakeLocAmplitude);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_SelfDestructShakeLocAmplitude) = value;
			}
		}

		// Token: 0x17006E0B RID: 28171
		// (get) Token: 0x0601B62C RID: 112172 RVA: 0x00285AD2 File Offset: 0x00283CD2
		// (set) Token: 0x0601B62D RID: 112173 RVA: 0x00285AE6 File Offset: 0x00283CE6
		public unsafe FVector SelfDestructShakeFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_SelfDestructShakeFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_SelfDestructShakeFrequency) = value;
			}
		}

		// Token: 0x17006E0C RID: 28172
		// (get) Token: 0x0601B62E RID: 112174 RVA: 0x00285AFB File Offset: 0x00283CFB
		// (set) Token: 0x0601B62F RID: 112175 RVA: 0x00285B0B File Offset: 0x00283D0B
		public unsafe float SelfDestructShakeDecayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_SelfDestructShakeDecayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_SelfDestructShakeDecayRate) = value;
			}
		}

		// Token: 0x17006E0D RID: 28173
		// (get) Token: 0x0601B630 RID: 112176 RVA: 0x00285B1C File Offset: 0x00283D1C
		// (set) Token: 0x0601B631 RID: 112177 RVA: 0x00285B55 File Offset: 0x00283D55
		public FKuroOnVehiclePartBroken OnVehiclePartBroken
		{
			get
			{
				base.FastCheckIsValid();
				FKuroOnVehiclePartBroken result;
				if ((result = this._OnVehiclePartBroken) == null)
				{
					result = (this._OnVehiclePartBroken = new FKuroOnVehiclePartBroken(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_OnVehiclePartBroken, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AKuroVehicleDestructionActor.__PropertyOffset_OnVehiclePartBroken, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601B632 RID: 112178 RVA: 0x00285B76 File Offset: 0x00283D76
		public void TriggerSelfDestructShake()
		{
			AKuroVehicleDestructionActor.__TriggerSelfDestructShake_Internal(base.NativePtr);
		}

		// Token: 0x0601B633 RID: 112179 RVA: 0x00285B84 File Offset: 0x00283D84
		[NullableContext(2)]
		public unsafe bool ApplyDamageToComponent(UPrimitiveComponent HitComponent, FVector HitLocation, float DamageAmount, ref int OutPartIndex)
		{
			fixed (int* ptr = &OutPartIndex)
			{
				void* ptr2 = (void*)ptr;
				return AKuroVehicleDestructionActor.__ApplyDamageToComponent_Internal(base.NativePtr, (HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero, HitLocation, DamageAmount, ref OutPartIndex);
			}
		}

		// Token: 0x0601B634 RID: 112180
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TriggerSelfDestructShake_Internal(IntPtr @this);

		// Token: 0x0601B635 RID: 112181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ApplyDamageToComponent_Internal(IntPtr @this, IntPtr HitComponent, FVector HitLocation, float DamageAmount, ref int OutPartIndex);

		// Token: 0x0601B636 RID: 112182 RVA: 0x00285BB6 File Offset: 0x00283DB6
		static AKuroVehicleDestructionActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroVehicleDestructionActor");
		}

		// Token: 0x0601B637 RID: 112183 RVA: 0x00285BC4 File Offset: 0x00283DC4
		protected AKuroVehicleDestructionActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EBCC RID: 60364
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroVehicleDestructionActor";

		// Token: 0x0400EBCD RID: 60365
		private static IntPtr _ClassPtr;

		// Token: 0x0400EBCE RID: 60366
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EBCF RID: 60367
		internal static int __PropertyOffset_VehicleParts;

		// Token: 0x0400EBD0 RID: 60368
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FVehiclePartInfo> _VehicleParts;

		// Token: 0x0400EBD1 RID: 60369
		internal static int __PropertyOffset_VehicleMainComponent;

		// Token: 0x0400EBD2 RID: 60370
		internal static int __PropertyOffset_HitPosition;

		// Token: 0x0400EBD3 RID: 60371
		internal static int __PropertyOffset_ImpactStrength;

		// Token: 0x0400EBD4 RID: 60372
		internal static int __PropertyOffset_bHasNewImpact;

		// Token: 0x0400EBD5 RID: 60373
		internal static int __PropertyOffset_MinImpactSpeed;

		// Token: 0x0400EBD6 RID: 60374
		internal static int __PropertyOffset_SpringStiffness;

		// Token: 0x0400EBD7 RID: 60375
		internal static int __PropertyOffset_SpringDamping;

		// Token: 0x0400EBD8 RID: 60376
		internal static int __PropertyOffset_ImpactPitchScale;

		// Token: 0x0400EBD9 RID: 60377
		internal static int __PropertyOffset_ImpactRollScale;

		// Token: 0x0400EBDA RID: 60378
		internal static int __PropertyOffset_MaxPitchSwing;

		// Token: 0x0400EBDB RID: 60379
		internal static int __PropertyOffset_MaxRollSwing;

		// Token: 0x0400EBDC RID: 60380
		internal static int __PropertyOffset_DamageImpactLocalAcceptHalfExtents;

		// Token: 0x0400EBDD RID: 60381
		internal static int __PropertyOffset_WheelComponents;

		// Token: 0x0400EBDE RID: 60382
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USceneComponent> _WheelComponents;

		// Token: 0x0400EBDF RID: 60383
		internal static int __PropertyOffset_SelfDestructShakeDuration;

		// Token: 0x0400EBE0 RID: 60384
		internal static int __PropertyOffset_SelfDestructShakeRotAmplitude;

		// Token: 0x0400EBE1 RID: 60385
		internal static int __PropertyOffset_SelfDestructShakeLocAmplitude;

		// Token: 0x0400EBE2 RID: 60386
		internal static int __PropertyOffset_SelfDestructShakeFrequency;

		// Token: 0x0400EBE3 RID: 60387
		internal static int __PropertyOffset_SelfDestructShakeDecayRate;

		// Token: 0x0400EBE4 RID: 60388
		internal static int __PropertyOffset_OnVehiclePartBroken;

		// Token: 0x0400EBE5 RID: 60389
		[Nullable(2)]
		private FKuroOnVehiclePartBroken _OnVehiclePartBroken;
	}
}
