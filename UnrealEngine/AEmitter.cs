using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000AD0 RID: 2768
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Emitter")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1136)]
	public class AEmitter : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008FE9 RID: 36841 RVA: 0x000CDF70 File Offset: 0x000CC170
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AEmitter._ClassPtr;
		}

		// Token: 0x06008FEA RID: 36842 RVA: 0x000CDF7C File Offset: 0x000CC17C
		public AEmitter() : this(BuiltinUtils.AllocNativeUObject(AEmitter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008FEB RID: 36843 RVA: 0x000CDFA4 File Offset: 0x000CC1A4
		public AEmitter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AEmitter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170021F8 RID: 8696
		// (get) Token: 0x06008FEC RID: 36844 RVA: 0x000CDFD7 File Offset: 0x000CC1D7
		// (set) Token: 0x06008FED RID: 36845 RVA: 0x000CDFEB File Offset: 0x000CC1EB
		[Nullable(2)]
		public unsafe UParticleSystemComponent ParticleSystemComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UParticleSystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AEmitter.__PropertyOffset_ParticleSystemComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AEmitter.__PropertyOffset_ParticleSystemComponent, value);
			}
		}

		// Token: 0x170021F9 RID: 8697
		// (get) Token: 0x06008FEE RID: 36846 RVA: 0x000CE000 File Offset: 0x000CC200
		// (set) Token: 0x06008FEF RID: 36847 RVA: 0x000CE019 File Offset: 0x000CC219
		public unsafe bool bDestroyOnSystemFinish
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AEmitter.__PropertyOffset_bDestroyOnSystemFinish) & AEmitter.__PropertyMask_bDestroyOnSystemFinish) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AEmitter.__PropertyOffset_bDestroyOnSystemFinish) = ((*(base.NativePtr + (IntPtr)AEmitter.__PropertyOffset_bDestroyOnSystemFinish) & ~AEmitter.__PropertyMask_bDestroyOnSystemFinish) | (value ? AEmitter.__PropertyMask_bDestroyOnSystemFinish : 0));
			}
		}

		// Token: 0x170021FA RID: 8698
		// (get) Token: 0x06008FF0 RID: 36848 RVA: 0x000CE049 File Offset: 0x000CC249
		// (set) Token: 0x06008FF1 RID: 36849 RVA: 0x000CE062 File Offset: 0x000CC262
		public unsafe bool bPostUpdateTickGroup
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AEmitter.__PropertyOffset_bPostUpdateTickGroup) & AEmitter.__PropertyMask_bPostUpdateTickGroup) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AEmitter.__PropertyOffset_bPostUpdateTickGroup) = ((*(base.NativePtr + (IntPtr)AEmitter.__PropertyOffset_bPostUpdateTickGroup) & ~AEmitter.__PropertyMask_bPostUpdateTickGroup) | (value ? AEmitter.__PropertyMask_bPostUpdateTickGroup : 0));
			}
		}

		// Token: 0x170021FB RID: 8699
		// (get) Token: 0x06008FF2 RID: 36850 RVA: 0x000CE092 File Offset: 0x000CC292
		// (set) Token: 0x06008FF3 RID: 36851 RVA: 0x000CE0AB File Offset: 0x000CC2AB
		public unsafe bool bCurrentlyActive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AEmitter.__PropertyOffset_bCurrentlyActive) & AEmitter.__PropertyMask_bCurrentlyActive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AEmitter.__PropertyOffset_bCurrentlyActive) = ((*(base.NativePtr + (IntPtr)AEmitter.__PropertyOffset_bCurrentlyActive) & ~AEmitter.__PropertyMask_bCurrentlyActive) | (value ? AEmitter.__PropertyMask_bCurrentlyActive : 0));
			}
		}

		// Token: 0x170021FC RID: 8700
		// (get) Token: 0x06008FF4 RID: 36852 RVA: 0x000CE0DC File Offset: 0x000CC2DC
		// (set) Token: 0x06008FF5 RID: 36853 RVA: 0x000CE115 File Offset: 0x000CC315
		public FParticleSpawnSignature OnParticleSpawn
		{
			get
			{
				base.FastCheckIsValid();
				FParticleSpawnSignature result;
				if ((result = this._OnParticleSpawn) == null)
				{
					result = (this._OnParticleSpawn = new FParticleSpawnSignature(base.NativePtr + (IntPtr)AEmitter.__PropertyOffset_OnParticleSpawn, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AEmitter.__PropertyOffset_OnParticleSpawn, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170021FD RID: 8701
		// (get) Token: 0x06008FF6 RID: 36854 RVA: 0x000CE138 File Offset: 0x000CC338
		// (set) Token: 0x06008FF7 RID: 36855 RVA: 0x000CE171 File Offset: 0x000CC371
		public FParticleBurstSignature OnParticleBurst
		{
			get
			{
				base.FastCheckIsValid();
				FParticleBurstSignature result;
				if ((result = this._OnParticleBurst) == null)
				{
					result = (this._OnParticleBurst = new FParticleBurstSignature(base.NativePtr + (IntPtr)AEmitter.__PropertyOffset_OnParticleBurst, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AEmitter.__PropertyOffset_OnParticleBurst, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x06008FF8 RID: 36856 RVA: 0x000CE194 File Offset: 0x000CC394
		// (set) Token: 0x06008FF9 RID: 36857 RVA: 0x000CE1CD File Offset: 0x000CC3CD
		public FParticleDeathSignature OnParticleDeath
		{
			get
			{
				base.FastCheckIsValid();
				FParticleDeathSignature result;
				if ((result = this._OnParticleDeath) == null)
				{
					result = (this._OnParticleDeath = new FParticleDeathSignature(base.NativePtr + (IntPtr)AEmitter.__PropertyOffset_OnParticleDeath, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AEmitter.__PropertyOffset_OnParticleDeath, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170021FF RID: 8703
		// (get) Token: 0x06008FFA RID: 36858 RVA: 0x000CE1F0 File Offset: 0x000CC3F0
		// (set) Token: 0x06008FFB RID: 36859 RVA: 0x000CE229 File Offset: 0x000CC429
		public FParticleCollisionSignature OnParticleCollide
		{
			get
			{
				base.FastCheckIsValid();
				FParticleCollisionSignature result;
				if ((result = this._OnParticleCollide) == null)
				{
					result = (this._OnParticleCollide = new FParticleCollisionSignature(base.NativePtr + (IntPtr)AEmitter.__PropertyOffset_OnParticleCollide, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AEmitter.__PropertyOffset_OnParticleCollide, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06008FFC RID: 36860 RVA: 0x000CE24A File Offset: 0x000CC44A
		public void ToggleActive()
		{
			AEmitter.__ToggleActive_Internal(base.NativePtr);
		}

		// Token: 0x06008FFD RID: 36861 RVA: 0x000CE257 File Offset: 0x000CC457
		public void SetVectorParameter(FName ParameterName, FVector Param)
		{
			AEmitter.__SetVectorParameter_Internal(base.NativePtr, ParameterName, Param);
		}

		// Token: 0x06008FFE RID: 36862 RVA: 0x000CE266 File Offset: 0x000CC466
		[NullableContext(2)]
		public void SetTemplate(UParticleSystem NewTemplate)
		{
			AEmitter.__SetTemplate_Internal(base.NativePtr, (NewTemplate != null) ? NewTemplate.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008FFF RID: 36863 RVA: 0x000CE283 File Offset: 0x000CC483
		[NullableContext(2)]
		public void SetMaterialParameter(FName ParameterName, UMaterialInterface Param)
		{
			AEmitter.__SetMaterialParameter_Internal(base.NativePtr, ParameterName, (Param != null) ? Param.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009000 RID: 36864 RVA: 0x000CE2A1 File Offset: 0x000CC4A1
		public void SetFloatParameter(FName ParameterName, float Param)
		{
			AEmitter.__SetFloatParameter_Internal(base.NativePtr, ParameterName, Param);
		}

		// Token: 0x06009001 RID: 36865 RVA: 0x000CE2B0 File Offset: 0x000CC4B0
		public void SetColorParameter(FName ParameterName, FLinearColor Param)
		{
			AEmitter.__SetColorParameter_Internal(base.NativePtr, ParameterName, Param);
		}

		// Token: 0x06009002 RID: 36866 RVA: 0x000CE2BF File Offset: 0x000CC4BF
		[NullableContext(2)]
		public void SetActorParameter(FName ParameterName, AActor Param)
		{
			AEmitter.__SetActorParameter_Internal(base.NativePtr, ParameterName, (Param != null) ? Param.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009003 RID: 36867 RVA: 0x000CE2DD File Offset: 0x000CC4DD
		public void OnRep_bCurrentlyActive()
		{
			AEmitter.__OnRep_bCurrentlyActive_Internal(base.NativePtr);
		}

		// Token: 0x06009004 RID: 36868 RVA: 0x000CE2EA File Offset: 0x000CC4EA
		[NullableContext(2)]
		public void OnParticleSystemFinished(UParticleSystemComponent FinishedComponent)
		{
			AEmitter.__OnParticleSystemFinished_Internal(base.NativePtr, (FinishedComponent != null) ? FinishedComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009005 RID: 36869 RVA: 0x000CE307 File Offset: 0x000CC507
		public bool IsActive()
		{
			return AEmitter.__IsActive_Internal(base.NativePtr);
		}

		// Token: 0x06009006 RID: 36870 RVA: 0x000CE314 File Offset: 0x000CC514
		public void Deactivate()
		{
			AEmitter.__Deactivate_Internal(base.NativePtr);
		}

		// Token: 0x06009007 RID: 36871 RVA: 0x000CE321 File Offset: 0x000CC521
		public void Activate()
		{
			AEmitter.__Activate_Internal(base.NativePtr);
		}

		// Token: 0x06009008 RID: 36872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleActive_Internal(IntPtr @this);

		// Token: 0x06009009 RID: 36873
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorParameter_Internal(IntPtr @this, FName ParameterName, FVector Param);

		// Token: 0x0600900A RID: 36874
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTemplate_Internal(IntPtr @this, IntPtr NewTemplate);

		// Token: 0x0600900B RID: 36875
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaterialParameter_Internal(IntPtr @this, FName ParameterName, IntPtr Param);

		// Token: 0x0600900C RID: 36876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFloatParameter_Internal(IntPtr @this, FName ParameterName, float Param);

		// Token: 0x0600900D RID: 36877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColorParameter_Internal(IntPtr @this, FName ParameterName, FLinearColor Param);

		// Token: 0x0600900E RID: 36878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetActorParameter_Internal(IntPtr @this, FName ParameterName, IntPtr Param);

		// Token: 0x0600900F RID: 36879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_bCurrentlyActive_Internal(IntPtr @this);

		// Token: 0x06009010 RID: 36880
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnParticleSystemFinished_Internal(IntPtr @this, IntPtr FinishedComponent);

		// Token: 0x06009011 RID: 36881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsActive_Internal(IntPtr @this);

		// Token: 0x06009012 RID: 36882
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Deactivate_Internal(IntPtr @this);

		// Token: 0x06009013 RID: 36883
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Activate_Internal(IntPtr @this);

		// Token: 0x06009014 RID: 36884 RVA: 0x000CE32E File Offset: 0x000CC52E
		static AEmitter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Emitter");
		}

		// Token: 0x06009015 RID: 36885 RVA: 0x000CE33C File Offset: 0x000CC53C
		protected AEmitter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004AA7 RID: 19111
		public new const string __ObjectPath = "/Script/Engine.Emitter";

		// Token: 0x04004AA8 RID: 19112
		private static IntPtr _ClassPtr;

		// Token: 0x04004AA9 RID: 19113
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004AAA RID: 19114
		internal static int __PropertyOffset_ParticleSystemComponent;

		// Token: 0x04004AAB RID: 19115
		internal static int __PropertyOffset_bDestroyOnSystemFinish;

		// Token: 0x04004AAC RID: 19116
		internal static byte __PropertyMask_bDestroyOnSystemFinish;

		// Token: 0x04004AAD RID: 19117
		internal static int __PropertyOffset_bPostUpdateTickGroup;

		// Token: 0x04004AAE RID: 19118
		internal static byte __PropertyMask_bPostUpdateTickGroup;

		// Token: 0x04004AAF RID: 19119
		internal static int __PropertyOffset_bCurrentlyActive;

		// Token: 0x04004AB0 RID: 19120
		internal static byte __PropertyMask_bCurrentlyActive;

		// Token: 0x04004AB1 RID: 19121
		internal static int __PropertyOffset_OnParticleSpawn;

		// Token: 0x04004AB2 RID: 19122
		[Nullable(2)]
		private FParticleSpawnSignature _OnParticleSpawn;

		// Token: 0x04004AB3 RID: 19123
		internal static int __PropertyOffset_OnParticleBurst;

		// Token: 0x04004AB4 RID: 19124
		[Nullable(2)]
		private FParticleBurstSignature _OnParticleBurst;

		// Token: 0x04004AB5 RID: 19125
		internal static int __PropertyOffset_OnParticleDeath;

		// Token: 0x04004AB6 RID: 19126
		[Nullable(2)]
		private FParticleDeathSignature _OnParticleDeath;

		// Token: 0x04004AB7 RID: 19127
		internal static int __PropertyOffset_OnParticleCollide;

		// Token: 0x04004AB8 RID: 19128
		[Nullable(2)]
		private FParticleCollisionSignature _OnParticleCollide;
	}
}
