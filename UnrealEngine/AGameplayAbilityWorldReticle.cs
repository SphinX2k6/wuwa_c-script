using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001364 RID: 4964
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityWorldReticle")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class AGameplayAbilityWorldReticle : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012347 RID: 74567 RVA: 0x001ABA0A File Offset: 0x001A9C0A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGameplayAbilityWorldReticle._ClassPtr;
		}

		// Token: 0x06012348 RID: 74568 RVA: 0x001ABA18 File Offset: 0x001A9C18
		public AGameplayAbilityWorldReticle() : this(BuiltinUtils.AllocNativeUObject(AGameplayAbilityWorldReticle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012349 RID: 74569 RVA: 0x001ABA40 File Offset: 0x001A9C40
		[NullableContext(1)]
		public AGameplayAbilityWorldReticle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGameplayAbilityWorldReticle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170046E7 RID: 18151
		// (get) Token: 0x0601234A RID: 74570 RVA: 0x001ABA74 File Offset: 0x001A9C74
		// (set) Token: 0x0601234B RID: 74571 RVA: 0x001ABAAD File Offset: 0x001A9CAD
		[Nullable(1)]
		public FWorldReticleParameters Parameters
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FWorldReticleParameters result;
				if ((result = this._Parameters) == null)
				{
					result = (this._Parameters = new FWorldReticleParameters(base.NativePtr + (IntPtr)AGameplayAbilityWorldReticle.__PropertyOffset_Parameters, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWorldReticleParameters.StaticStruct(), base.NativePtr + (IntPtr)AGameplayAbilityWorldReticle.__PropertyOffset_Parameters, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170046E8 RID: 18152
		// (get) Token: 0x0601234C RID: 74572 RVA: 0x001ABACE File Offset: 0x001A9CCE
		// (set) Token: 0x0601234D RID: 74573 RVA: 0x001ABADE File Offset: 0x001A9CDE
		public unsafe bool bFaceOwnerFlat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayAbilityWorldReticle.__PropertyOffset_bFaceOwnerFlat) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayAbilityWorldReticle.__PropertyOffset_bFaceOwnerFlat) = (value ? 1 : 0);
			}
		}

		// Token: 0x170046E9 RID: 18153
		// (get) Token: 0x0601234E RID: 74574 RVA: 0x001ABAEF File Offset: 0x001A9CEF
		// (set) Token: 0x0601234F RID: 74575 RVA: 0x001ABAFF File Offset: 0x001A9CFF
		public unsafe bool bSnapToTargetedActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayAbilityWorldReticle.__PropertyOffset_bSnapToTargetedActor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayAbilityWorldReticle.__PropertyOffset_bSnapToTargetedActor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170046EA RID: 18154
		// (get) Token: 0x06012350 RID: 74576 RVA: 0x001ABB10 File Offset: 0x001A9D10
		// (set) Token: 0x06012351 RID: 74577 RVA: 0x001ABB20 File Offset: 0x001A9D20
		public unsafe bool bIsTargetValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayAbilityWorldReticle.__PropertyOffset_bIsTargetValid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayAbilityWorldReticle.__PropertyOffset_bIsTargetValid) = (value ? 1 : 0);
			}
		}

		// Token: 0x170046EB RID: 18155
		// (get) Token: 0x06012352 RID: 74578 RVA: 0x001ABB31 File Offset: 0x001A9D31
		// (set) Token: 0x06012353 RID: 74579 RVA: 0x001ABB41 File Offset: 0x001A9D41
		public unsafe bool bIsTargetAnActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameplayAbilityWorldReticle.__PropertyOffset_bIsTargetAnActor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameplayAbilityWorldReticle.__PropertyOffset_bIsTargetAnActor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170046EC RID: 18156
		// (get) Token: 0x06012354 RID: 74580 RVA: 0x001ABB52 File Offset: 0x001A9D52
		// (set) Token: 0x06012355 RID: 74581 RVA: 0x001ABB66 File Offset: 0x001A9D66
		[Nullable(2)]
		public unsafe APlayerController MasterPC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerController>(base.NativePtr / (IntPtr)sizeof(void*) + AGameplayAbilityWorldReticle.__PropertyOffset_MasterPC);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGameplayAbilityWorldReticle.__PropertyOffset_MasterPC, value);
			}
		}

		// Token: 0x170046ED RID: 18157
		// (get) Token: 0x06012356 RID: 74582 RVA: 0x001ABB7B File Offset: 0x001A9D7B
		// (set) Token: 0x06012357 RID: 74583 RVA: 0x001ABB8F File Offset: 0x001A9D8F
		[Nullable(2)]
		public unsafe AActor TargetingActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + AGameplayAbilityWorldReticle.__PropertyOffset_TargetingActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGameplayAbilityWorldReticle.__PropertyOffset_TargetingActor, value);
			}
		}

		// Token: 0x06012358 RID: 74584 RVA: 0x001ABBA4 File Offset: 0x001A9DA4
		public virtual void SetReticleMaterialParamVector(FName ParamName, FVector value)
		{
			AGameplayAbilityWorldReticle.__SetReticleMaterialParamVector_Internal(base.NativePtr, ParamName, value);
		}

		// Token: 0x06012359 RID: 74585 RVA: 0x001ABBB3 File Offset: 0x001A9DB3
		public virtual void SetReticleMaterialParamFloat(FName ParamName, float value)
		{
			AGameplayAbilityWorldReticle.__SetReticleMaterialParamFloat_Internal(base.NativePtr, ParamName, value);
		}

		// Token: 0x0601235A RID: 74586 RVA: 0x001ABBC2 File Offset: 0x001A9DC2
		public virtual void OnValidTargetChanged(bool bNewValue)
		{
			AGameplayAbilityWorldReticle.__OnValidTargetChanged_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0601235B RID: 74587 RVA: 0x001ABBD0 File Offset: 0x001A9DD0
		public virtual void OnTargetingAnActor(bool bNewValue)
		{
			AGameplayAbilityWorldReticle.__OnTargetingAnActor_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0601235C RID: 74588 RVA: 0x001ABBDE File Offset: 0x001A9DDE
		public virtual void OnParametersInitialized()
		{
			AGameplayAbilityWorldReticle.__OnParametersInitialized_Internal(base.NativePtr);
		}

		// Token: 0x0601235D RID: 74589 RVA: 0x001ABBEB File Offset: 0x001A9DEB
		public void FaceTowardSource(bool bFaceIn2D)
		{
			AGameplayAbilityWorldReticle.__FaceTowardSource_Internal(base.NativePtr, bFaceIn2D);
		}

		// Token: 0x0601235E RID: 74590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReticleMaterialParamVector_Internal(IntPtr @this, FName ParamName, FVector value);

		// Token: 0x0601235F RID: 74591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetReticleMaterialParamFloat_Internal(IntPtr @this, FName ParamName, float value);

		// Token: 0x06012360 RID: 74592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnValidTargetChanged_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06012361 RID: 74593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnTargetingAnActor_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06012362 RID: 74594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnParametersInitialized_Internal(IntPtr @this);

		// Token: 0x06012363 RID: 74595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FaceTowardSource_Internal(IntPtr @this, bool bFaceIn2D);

		// Token: 0x06012364 RID: 74596 RVA: 0x001ABBF9 File Offset: 0x001A9DF9
		static AGameplayAbilityWorldReticle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayAbilityWorldReticle");
		}

		// Token: 0x06012365 RID: 74597 RVA: 0x001ABC07 File Offset: 0x001A9E07
		protected AGameplayAbilityWorldReticle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009C03 RID: 39939
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityWorldReticle";

		// Token: 0x04009C04 RID: 39940
		private static IntPtr _ClassPtr;

		// Token: 0x04009C05 RID: 39941
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009C06 RID: 39942
		internal static int __PropertyOffset_Parameters;

		// Token: 0x04009C07 RID: 39943
		[Nullable(2)]
		private FWorldReticleParameters _Parameters;

		// Token: 0x04009C08 RID: 39944
		internal static int __PropertyOffset_bFaceOwnerFlat;

		// Token: 0x04009C09 RID: 39945
		internal static int __PropertyOffset_bSnapToTargetedActor;

		// Token: 0x04009C0A RID: 39946
		internal static int __PropertyOffset_bIsTargetValid;

		// Token: 0x04009C0B RID: 39947
		internal static int __PropertyOffset_bIsTargetAnActor;

		// Token: 0x04009C0C RID: 39948
		internal static int __PropertyOffset_MasterPC;

		// Token: 0x04009C0D RID: 39949
		internal static int __PropertyOffset_TargetingActor;

		// Token: 0x02002E2E RID: 11822
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __SetReticleMaterialParamVector_FunctionParams
		{
			// Token: 0x040168C9 RID: 92361
			[FieldOffset(0)]
			public FName ParamName;

			// Token: 0x040168CA RID: 92362
			[FieldOffset(12)]
			public FVector value;
		}

		// Token: 0x02002E2F RID: 11823
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetReticleMaterialParamFloat_FunctionParams
		{
			// Token: 0x040168CB RID: 92363
			[FieldOffset(0)]
			public FName ParamName;

			// Token: 0x040168CC RID: 92364
			[FieldOffset(12)]
			public float value;
		}

		// Token: 0x02002E30 RID: 11824
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnValidTargetChanged_FunctionParams
		{
			// Token: 0x040168CD RID: 92365
			[FieldOffset(0)]
			public bool bNewValue;
		}

		// Token: 0x02002E31 RID: 11825
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnTargetingAnActor_FunctionParams
		{
			// Token: 0x040168CE RID: 92366
			[FieldOffset(0)]
			public bool bNewValue;
		}
	}
}
