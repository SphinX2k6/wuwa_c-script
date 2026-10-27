using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001439 RID: 5177
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCollectionEngine.SkeletalMeshSimulationComponent")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class USkeletalMeshSimulationComponent : UActorComponent, IUnrealUObject, IUnrealObject, IChaosNotifyHandlerInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06012EF9 RID: 77561 RVA: 0x001BD857 File Offset: 0x001BBA57
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USkeletalMeshSimulationComponent._ClassPtr;
		}

		// Token: 0x06012EFA RID: 77562 RVA: 0x001BD863 File Offset: 0x001BBA63
		int IChaosNotifyHandlerInterface.InterfaceOffset()
		{
			return USkeletalMeshSimulationComponent.__InterfaceOffset_IChaosNotifyHandlerInterface;
		}

		// Token: 0x06012EFB RID: 77563 RVA: 0x001BD86C File Offset: 0x001BBA6C
		public USkeletalMeshSimulationComponent() : this(BuiltinUtils.AllocNativeUObject(USkeletalMeshSimulationComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012EFC RID: 77564 RVA: 0x001BD894 File Offset: 0x001BBA94
		[NullableContext(1)]
		public USkeletalMeshSimulationComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USkeletalMeshSimulationComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004986 RID: 18822
		// (get) Token: 0x06012EFD RID: 77565 RVA: 0x001BD8C7 File Offset: 0x001BBAC7
		// (set) Token: 0x06012EFE RID: 77566 RVA: 0x001BD8DB File Offset: 0x001BBADB
		public unsafe UChaosPhysicalMaterial PhysicalMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChaosPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshSimulationComponent.__PropertyOffset_PhysicalMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshSimulationComponent.__PropertyOffset_PhysicalMaterial, value);
			}
		}

		// Token: 0x17004987 RID: 18823
		// (get) Token: 0x06012EFF RID: 77567 RVA: 0x001BD8F0 File Offset: 0x001BBAF0
		// (set) Token: 0x06012F00 RID: 77568 RVA: 0x001BD904 File Offset: 0x001BBB04
		public unsafe AChaosSolverActor ChaosSolverActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AChaosSolverActor>(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshSimulationComponent.__PropertyOffset_ChaosSolverActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshSimulationComponent.__PropertyOffset_ChaosSolverActor, value);
			}
		}

		// Token: 0x17004988 RID: 18824
		// (get) Token: 0x06012F01 RID: 77569 RVA: 0x001BD919 File Offset: 0x001BBB19
		// (set) Token: 0x06012F02 RID: 77570 RVA: 0x001BD92D File Offset: 0x001BBB2D
		public unsafe UPhysicsAsset OverridePhysicsAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsAsset>(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshSimulationComponent.__PropertyOffset_OverridePhysicsAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshSimulationComponent.__PropertyOffset_OverridePhysicsAsset, value);
			}
		}

		// Token: 0x17004989 RID: 18825
		// (get) Token: 0x06012F03 RID: 77571 RVA: 0x001BD942 File Offset: 0x001BBB42
		// (set) Token: 0x06012F04 RID: 77572 RVA: 0x001BD952 File Offset: 0x001BBB52
		public unsafe bool bSimulating
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_bSimulating) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_bSimulating) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700498A RID: 18826
		// (get) Token: 0x06012F05 RID: 77573 RVA: 0x001BD963 File Offset: 0x001BBB63
		// (set) Token: 0x06012F06 RID: 77574 RVA: 0x001BD973 File Offset: 0x001BBB73
		public unsafe bool bNotifyCollisions
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_bNotifyCollisions) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_bNotifyCollisions) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700498B RID: 18827
		// (get) Token: 0x06012F07 RID: 77575 RVA: 0x001BD984 File Offset: 0x001BBB84
		// (set) Token: 0x06012F08 RID: 77576 RVA: 0x001BD994 File Offset: 0x001BBB94
		public unsafe EObjectStateTypeEnum ObjectType
		{
			get
			{
				return (EObjectStateTypeEnum)(*(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_ObjectType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_ObjectType) = (byte)value;
			}
		}

		// Token: 0x1700498C RID: 18828
		// (get) Token: 0x06012F09 RID: 77577 RVA: 0x001BD9A5 File Offset: 0x001BBBA5
		// (set) Token: 0x06012F0A RID: 77578 RVA: 0x001BD9B5 File Offset: 0x001BBBB5
		public unsafe float Density
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_Density);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_Density) = value;
			}
		}

		// Token: 0x1700498D RID: 18829
		// (get) Token: 0x06012F0B RID: 77579 RVA: 0x001BD9C6 File Offset: 0x001BBBC6
		// (set) Token: 0x06012F0C RID: 77580 RVA: 0x001BD9D6 File Offset: 0x001BBBD6
		public unsafe float MinMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_MinMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_MinMass) = value;
			}
		}

		// Token: 0x1700498E RID: 18830
		// (get) Token: 0x06012F0D RID: 77581 RVA: 0x001BD9E7 File Offset: 0x001BBBE7
		// (set) Token: 0x06012F0E RID: 77582 RVA: 0x001BD9F7 File Offset: 0x001BBBF7
		public unsafe float MaxMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_MaxMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_MaxMass) = value;
			}
		}

		// Token: 0x1700498F RID: 18831
		// (get) Token: 0x06012F0F RID: 77583 RVA: 0x001BDA08 File Offset: 0x001BBC08
		// (set) Token: 0x06012F10 RID: 77584 RVA: 0x001BDA18 File Offset: 0x001BBC18
		public unsafe ECollisionTypeEnum CollisionType
		{
			get
			{
				return (ECollisionTypeEnum)(*(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_CollisionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_CollisionType) = (byte)value;
			}
		}

		// Token: 0x17004990 RID: 18832
		// (get) Token: 0x06012F11 RID: 77585 RVA: 0x001BDA29 File Offset: 0x001BBC29
		// (set) Token: 0x06012F12 RID: 77586 RVA: 0x001BDA39 File Offset: 0x001BBC39
		public unsafe float ImplicitShapeParticlesPerUnitArea
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_ImplicitShapeParticlesPerUnitArea);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_ImplicitShapeParticlesPerUnitArea) = value;
			}
		}

		// Token: 0x17004991 RID: 18833
		// (get) Token: 0x06012F13 RID: 77587 RVA: 0x001BDA4A File Offset: 0x001BBC4A
		// (set) Token: 0x06012F14 RID: 77588 RVA: 0x001BDA5A File Offset: 0x001BBC5A
		public unsafe int ImplicitShapeMinNumParticles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_ImplicitShapeMinNumParticles);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_ImplicitShapeMinNumParticles) = value;
			}
		}

		// Token: 0x17004992 RID: 18834
		// (get) Token: 0x06012F15 RID: 77589 RVA: 0x001BDA6B File Offset: 0x001BBC6B
		// (set) Token: 0x06012F16 RID: 77590 RVA: 0x001BDA7B File Offset: 0x001BBC7B
		public unsafe int ImplicitShapeMaxNumParticles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_ImplicitShapeMaxNumParticles);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_ImplicitShapeMaxNumParticles) = value;
			}
		}

		// Token: 0x17004993 RID: 18835
		// (get) Token: 0x06012F17 RID: 77591 RVA: 0x001BDA8C File Offset: 0x001BBC8C
		// (set) Token: 0x06012F18 RID: 77592 RVA: 0x001BDA9C File Offset: 0x001BBC9C
		public unsafe int MinLevelSetResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_MinLevelSetResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_MinLevelSetResolution) = value;
			}
		}

		// Token: 0x17004994 RID: 18836
		// (get) Token: 0x06012F19 RID: 77593 RVA: 0x001BDAAD File Offset: 0x001BBCAD
		// (set) Token: 0x06012F1A RID: 77594 RVA: 0x001BDABD File Offset: 0x001BBCBD
		public unsafe int MaxLevelSetResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_MaxLevelSetResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_MaxLevelSetResolution) = value;
			}
		}

		// Token: 0x17004995 RID: 18837
		// (get) Token: 0x06012F1B RID: 77595 RVA: 0x001BDACE File Offset: 0x001BBCCE
		// (set) Token: 0x06012F1C RID: 77596 RVA: 0x001BDADE File Offset: 0x001BBCDE
		public unsafe int CollisionGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_CollisionGroup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_CollisionGroup) = value;
			}
		}

		// Token: 0x17004996 RID: 18838
		// (get) Token: 0x06012F1D RID: 77597 RVA: 0x001BDAEF File Offset: 0x001BBCEF
		// (set) Token: 0x06012F1E RID: 77598 RVA: 0x001BDAFF File Offset: 0x001BBCFF
		public unsafe EInitialVelocityTypeEnum InitialVelocityType
		{
			get
			{
				return (EInitialVelocityTypeEnum)(*(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_InitialVelocityType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_InitialVelocityType) = (byte)value;
			}
		}

		// Token: 0x17004997 RID: 18839
		// (get) Token: 0x06012F1F RID: 77599 RVA: 0x001BDB10 File Offset: 0x001BBD10
		// (set) Token: 0x06012F20 RID: 77600 RVA: 0x001BDB24 File Offset: 0x001BBD24
		public unsafe FVector InitialLinearVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_InitialLinearVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_InitialLinearVelocity) = value;
			}
		}

		// Token: 0x17004998 RID: 18840
		// (get) Token: 0x06012F21 RID: 77601 RVA: 0x001BDB39 File Offset: 0x001BBD39
		// (set) Token: 0x06012F22 RID: 77602 RVA: 0x001BDB4D File Offset: 0x001BBD4D
		public unsafe FVector InitialAngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_InitialAngularVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_InitialAngularVelocity) = value;
			}
		}

		// Token: 0x17004999 RID: 18841
		// (get) Token: 0x06012F23 RID: 77603 RVA: 0x001BDB64 File Offset: 0x001BBD64
		// (set) Token: 0x06012F24 RID: 77604 RVA: 0x001BDB9D File Offset: 0x001BBD9D
		[Nullable(1)]
		public FOnChaosPhysicsCollision OnChaosPhysicsCollision
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnChaosPhysicsCollision result;
				if ((result = this._OnChaosPhysicsCollision) == null)
				{
					result = (this._OnChaosPhysicsCollision = new FOnChaosPhysicsCollision(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_OnChaosPhysicsCollision, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USkeletalMeshSimulationComponent.__PropertyOffset_OnChaosPhysicsCollision, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06012F25 RID: 77605 RVA: 0x001BDBBE File Offset: 0x001BBDBE
		public virtual void ReceivePhysicsCollision(in FChaosPhysicsCollisionInfo CollisionInfo)
		{
			USkeletalMeshSimulationComponent.__ReceivePhysicsCollision_Internal(base.NativePtr, (CollisionInfo ?? new FChaosPhysicsCollisionInfo()).NativePtr);
		}

		// Token: 0x06012F26 RID: 77606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceivePhysicsCollision_Internal(IntPtr @this, IntPtr CollisionInfo);

		// Token: 0x06012F27 RID: 77607 RVA: 0x001BDBDB File Offset: 0x001BBDDB
		static USkeletalMeshSimulationComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCollectionEngine.SkeletalMeshSimulationComponent");
		}

		// Token: 0x06012F28 RID: 77608 RVA: 0x001BDBE9 File Offset: 0x001BBDE9
		protected USkeletalMeshSimulationComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A1CF RID: 41423
		internal static int __InterfaceOffset_IChaosNotifyHandlerInterface;

		// Token: 0x0400A1D0 RID: 41424
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GeometryCollectionEngine.SkeletalMeshSimulationComponent";

		// Token: 0x0400A1D1 RID: 41425
		private static IntPtr _ClassPtr;

		// Token: 0x0400A1D2 RID: 41426
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A1D3 RID: 41427
		internal static int __PropertyOffset_PhysicalMaterial;

		// Token: 0x0400A1D4 RID: 41428
		internal static int __PropertyOffset_ChaosSolverActor;

		// Token: 0x0400A1D5 RID: 41429
		internal static int __PropertyOffset_OverridePhysicsAsset;

		// Token: 0x0400A1D6 RID: 41430
		internal static int __PropertyOffset_bSimulating;

		// Token: 0x0400A1D7 RID: 41431
		internal static int __PropertyOffset_bNotifyCollisions;

		// Token: 0x0400A1D8 RID: 41432
		internal static int __PropertyOffset_ObjectType;

		// Token: 0x0400A1D9 RID: 41433
		internal static int __PropertyOffset_Density;

		// Token: 0x0400A1DA RID: 41434
		internal static int __PropertyOffset_MinMass;

		// Token: 0x0400A1DB RID: 41435
		internal static int __PropertyOffset_MaxMass;

		// Token: 0x0400A1DC RID: 41436
		internal static int __PropertyOffset_CollisionType;

		// Token: 0x0400A1DD RID: 41437
		internal static int __PropertyOffset_ImplicitShapeParticlesPerUnitArea;

		// Token: 0x0400A1DE RID: 41438
		internal static int __PropertyOffset_ImplicitShapeMinNumParticles;

		// Token: 0x0400A1DF RID: 41439
		internal static int __PropertyOffset_ImplicitShapeMaxNumParticles;

		// Token: 0x0400A1E0 RID: 41440
		internal static int __PropertyOffset_MinLevelSetResolution;

		// Token: 0x0400A1E1 RID: 41441
		internal static int __PropertyOffset_MaxLevelSetResolution;

		// Token: 0x0400A1E2 RID: 41442
		internal static int __PropertyOffset_CollisionGroup;

		// Token: 0x0400A1E3 RID: 41443
		internal static int __PropertyOffset_InitialVelocityType;

		// Token: 0x0400A1E4 RID: 41444
		internal static int __PropertyOffset_InitialLinearVelocity;

		// Token: 0x0400A1E5 RID: 41445
		internal static int __PropertyOffset_InitialAngularVelocity;

		// Token: 0x0400A1E6 RID: 41446
		internal static int __PropertyOffset_OnChaosPhysicsCollision;

		// Token: 0x0400A1E7 RID: 41447
		private FOnChaosPhysicsCollision _OnChaosPhysicsCollision;

		// Token: 0x02002E8F RID: 11919
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __ReceivePhysicsCollision_FunctionParams
		{
			// Token: 0x04016960 RID: 92512
			[FieldOffset(0)]
			public byte CollisionInfo;
		}
	}
}
