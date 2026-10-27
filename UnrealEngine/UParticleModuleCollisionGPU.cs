using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F5F RID: 3935
	[UnrealObjectPath("/Script/Engine.ParticleModuleCollisionGPU")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UParticleModuleCollisionGPU : UParticleModuleCollisionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D487 RID: 54407 RVA: 0x00138429 File Offset: 0x00136629
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleCollisionGPU._ClassPtr;
		}

		// Token: 0x0600D488 RID: 54408 RVA: 0x00138438 File Offset: 0x00136638
		public UParticleModuleCollisionGPU() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleCollisionGPU.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D489 RID: 54409 RVA: 0x00138460 File Offset: 0x00136660
		[NullableContext(1)]
		public UParticleModuleCollisionGPU(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleCollisionGPU.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031D6 RID: 12758
		// (get) Token: 0x0600D48A RID: 54410 RVA: 0x00138494 File Offset: 0x00136694
		// (set) Token: 0x0600D48B RID: 54411 RVA: 0x001384CD File Offset: 0x001366CD
		[Nullable(1)]
		public FRawDistributionFloat Resilience
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._Resilience) == null)
				{
					result = (this._Resilience = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleCollisionGPU.__PropertyOffset_Resilience, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleCollisionGPU.__PropertyOffset_Resilience, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031D7 RID: 12759
		// (get) Token: 0x0600D48C RID: 54412 RVA: 0x001384F0 File Offset: 0x001366F0
		// (set) Token: 0x0600D48D RID: 54413 RVA: 0x00138529 File Offset: 0x00136729
		[Nullable(1)]
		public FRawDistributionFloat ResilienceScaleOverLife
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._ResilienceScaleOverLife) == null)
				{
					result = (this._ResilienceScaleOverLife = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleCollisionGPU.__PropertyOffset_ResilienceScaleOverLife, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleCollisionGPU.__PropertyOffset_ResilienceScaleOverLife, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031D8 RID: 12760
		// (get) Token: 0x0600D48E RID: 54414 RVA: 0x0013854A File Offset: 0x0013674A
		// (set) Token: 0x0600D48F RID: 54415 RVA: 0x0013855A File Offset: 0x0013675A
		public unsafe float Friction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleCollisionGPU.__PropertyOffset_Friction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleCollisionGPU.__PropertyOffset_Friction) = value;
			}
		}

		// Token: 0x170031D9 RID: 12761
		// (get) Token: 0x0600D490 RID: 54416 RVA: 0x0013856B File Offset: 0x0013676B
		// (set) Token: 0x0600D491 RID: 54417 RVA: 0x0013857B File Offset: 0x0013677B
		public unsafe float RandomSpread
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleCollisionGPU.__PropertyOffset_RandomSpread);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleCollisionGPU.__PropertyOffset_RandomSpread) = value;
			}
		}

		// Token: 0x170031DA RID: 12762
		// (get) Token: 0x0600D492 RID: 54418 RVA: 0x0013858C File Offset: 0x0013678C
		// (set) Token: 0x0600D493 RID: 54419 RVA: 0x0013859C File Offset: 0x0013679C
		public unsafe float RandomDistribution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleCollisionGPU.__PropertyOffset_RandomDistribution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleCollisionGPU.__PropertyOffset_RandomDistribution) = value;
			}
		}

		// Token: 0x170031DB RID: 12763
		// (get) Token: 0x0600D494 RID: 54420 RVA: 0x001385AD File Offset: 0x001367AD
		// (set) Token: 0x0600D495 RID: 54421 RVA: 0x001385BD File Offset: 0x001367BD
		public unsafe float RadiusScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleCollisionGPU.__PropertyOffset_RadiusScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleCollisionGPU.__PropertyOffset_RadiusScale) = value;
			}
		}

		// Token: 0x170031DC RID: 12764
		// (get) Token: 0x0600D496 RID: 54422 RVA: 0x001385CE File Offset: 0x001367CE
		// (set) Token: 0x0600D497 RID: 54423 RVA: 0x001385DE File Offset: 0x001367DE
		public unsafe float RadiusBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleCollisionGPU.__PropertyOffset_RadiusBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleCollisionGPU.__PropertyOffset_RadiusBias) = value;
			}
		}

		// Token: 0x170031DD RID: 12765
		// (get) Token: 0x0600D498 RID: 54424 RVA: 0x001385EF File Offset: 0x001367EF
		// (set) Token: 0x0600D499 RID: 54425 RVA: 0x00138603 File Offset: 0x00136803
		public unsafe TEnumAsByte<EParticleCollisionResponse> Response
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleCollisionGPU.__PropertyOffset_Response);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleCollisionGPU.__PropertyOffset_Response) = value;
			}
		}

		// Token: 0x170031DE RID: 12766
		// (get) Token: 0x0600D49A RID: 54426 RVA: 0x00138618 File Offset: 0x00136818
		// (set) Token: 0x0600D49B RID: 54427 RVA: 0x0013862C File Offset: 0x0013682C
		public unsafe TEnumAsByte<EParticleCollisionMode> CollisionMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleCollisionGPU.__PropertyOffset_CollisionMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleCollisionGPU.__PropertyOffset_CollisionMode) = value;
			}
		}

		// Token: 0x0600D49C RID: 54428 RVA: 0x00138641 File Offset: 0x00136841
		static UParticleModuleCollisionGPU()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleCollisionGPU");
		}

		// Token: 0x0600D49D RID: 54429 RVA: 0x0013864F File Offset: 0x0013684F
		protected UParticleModuleCollisionGPU(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007266 RID: 29286
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleCollisionGPU";

		// Token: 0x04007267 RID: 29287
		private static IntPtr _ClassPtr;

		// Token: 0x04007268 RID: 29288
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007269 RID: 29289
		internal static int __PropertyOffset_Resilience;

		// Token: 0x0400726A RID: 29290
		[Nullable(2)]
		private FRawDistributionFloat _Resilience;

		// Token: 0x0400726B RID: 29291
		internal static int __PropertyOffset_ResilienceScaleOverLife;

		// Token: 0x0400726C RID: 29292
		[Nullable(2)]
		private FRawDistributionFloat _ResilienceScaleOverLife;

		// Token: 0x0400726D RID: 29293
		internal static int __PropertyOffset_Friction;

		// Token: 0x0400726E RID: 29294
		internal static int __PropertyOffset_RandomSpread;

		// Token: 0x0400726F RID: 29295
		internal static int __PropertyOffset_RandomDistribution;

		// Token: 0x04007270 RID: 29296
		internal static int __PropertyOffset_RadiusScale;

		// Token: 0x04007271 RID: 29297
		internal static int __PropertyOffset_RadiusBias;

		// Token: 0x04007272 RID: 29298
		internal static int __PropertyOffset_Response;

		// Token: 0x04007273 RID: 29299
		internal static int __PropertyOffset_CollisionMode;
	}
}
