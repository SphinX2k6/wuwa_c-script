using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000437 RID: 1079
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CableComponent.CableComponent")]
	[UnrealStructLayout(1776, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1776)]
	public class UCableComponent : UMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003A00 RID: 14848 RVA: 0x00057E77 File Offset: 0x00056077
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCableComponent._ClassPtr;
		}

		// Token: 0x06003A01 RID: 14849 RVA: 0x00057E84 File Offset: 0x00056084
		public UCableComponent() : this(BuiltinUtils.AllocNativeUObject(UCableComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x00057EAC File Offset: 0x000560AC
		[NullableContext(1)]
		public UCableComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCableComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06003A03 RID: 14851 RVA: 0x00057EDF File Offset: 0x000560DF
		// (set) Token: 0x06003A04 RID: 14852 RVA: 0x00057EEF File Offset: 0x000560EF
		public unsafe bool bAttachStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_bAttachStart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_bAttachStart) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06003A05 RID: 14853 RVA: 0x00057F00 File Offset: 0x00056100
		// (set) Token: 0x06003A06 RID: 14854 RVA: 0x00057F10 File Offset: 0x00056110
		public unsafe bool bAttachEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_bAttachEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_bAttachEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06003A07 RID: 14855 RVA: 0x00057F21 File Offset: 0x00056121
		// (set) Token: 0x06003A08 RID: 14856 RVA: 0x00057F31 File Offset: 0x00056131
		public unsafe bool bUseLocalSpaceSimulation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_bUseLocalSpaceSimulation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_bUseLocalSpaceSimulation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06003A09 RID: 14857 RVA: 0x00057F44 File Offset: 0x00056144
		// (set) Token: 0x06003A0A RID: 14858 RVA: 0x00057F7D File Offset: 0x0005617D
		[Nullable(1)]
		public FComponentReference AttachEndTo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FComponentReference result;
				if ((result = this._AttachEndTo) == null)
				{
					result = (this._AttachEndTo = new FComponentReference(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_AttachEndTo, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FComponentReference.StaticStruct(), base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_AttachEndTo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06003A0B RID: 14859 RVA: 0x00057F9E File Offset: 0x0005619E
		// (set) Token: 0x06003A0C RID: 14860 RVA: 0x00057FB2 File Offset: 0x000561B2
		public unsafe FName AttachEndToSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_AttachEndToSocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_AttachEndToSocketName) = value;
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06003A0D RID: 14861 RVA: 0x00057FC7 File Offset: 0x000561C7
		// (set) Token: 0x06003A0E RID: 14862 RVA: 0x00057FDB File Offset: 0x000561DB
		public unsafe FVector EndLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_EndLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_EndLocation) = value;
			}
		}

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x06003A0F RID: 14863 RVA: 0x00057FF0 File Offset: 0x000561F0
		// (set) Token: 0x06003A10 RID: 14864 RVA: 0x00058000 File Offset: 0x00056200
		public unsafe float CableLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_CableLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_CableLength) = value;
			}
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06003A11 RID: 14865 RVA: 0x00058011 File Offset: 0x00056211
		// (set) Token: 0x06003A12 RID: 14866 RVA: 0x00058021 File Offset: 0x00056221
		public unsafe int NumSegments
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_NumSegments);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_NumSegments) = value;
			}
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06003A13 RID: 14867 RVA: 0x00058032 File Offset: 0x00056232
		// (set) Token: 0x06003A14 RID: 14868 RVA: 0x00058042 File Offset: 0x00056242
		public unsafe float SubstepTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_SubstepTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_SubstepTime) = value;
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06003A15 RID: 14869 RVA: 0x00058053 File Offset: 0x00056253
		// (set) Token: 0x06003A16 RID: 14870 RVA: 0x00058063 File Offset: 0x00056263
		public unsafe int SolverIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_SolverIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_SolverIterations) = value;
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06003A17 RID: 14871 RVA: 0x00058074 File Offset: 0x00056274
		// (set) Token: 0x06003A18 RID: 14872 RVA: 0x00058084 File Offset: 0x00056284
		public unsafe bool bEnableStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_bEnableStiffness) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_bEnableStiffness) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06003A19 RID: 14873 RVA: 0x00058095 File Offset: 0x00056295
		// (set) Token: 0x06003A1A RID: 14874 RVA: 0x000580A5 File Offset: 0x000562A5
		public unsafe bool bUseSubstepping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_bUseSubstepping) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_bUseSubstepping) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06003A1B RID: 14875 RVA: 0x000580B6 File Offset: 0x000562B6
		// (set) Token: 0x06003A1C RID: 14876 RVA: 0x000580C6 File Offset: 0x000562C6
		public unsafe bool bSkipCableUpdateWhenNotVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_bSkipCableUpdateWhenNotVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_bSkipCableUpdateWhenNotVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x06003A1D RID: 14877 RVA: 0x000580D7 File Offset: 0x000562D7
		// (set) Token: 0x06003A1E RID: 14878 RVA: 0x000580E7 File Offset: 0x000562E7
		public unsafe bool bSkipCableUpdateWhenNotOwnerRecentlyRendered
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_bSkipCableUpdateWhenNotOwnerRecentlyRendered) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_bSkipCableUpdateWhenNotOwnerRecentlyRendered) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06003A1F RID: 14879 RVA: 0x000580F8 File Offset: 0x000562F8
		// (set) Token: 0x06003A20 RID: 14880 RVA: 0x00058108 File Offset: 0x00056308
		public unsafe bool bEnableCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_bEnableCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_bEnableCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06003A21 RID: 14881 RVA: 0x00058119 File Offset: 0x00056319
		// (set) Token: 0x06003A22 RID: 14882 RVA: 0x00058129 File Offset: 0x00056329
		public unsafe float CollisionFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_CollisionFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_CollisionFriction) = value;
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06003A23 RID: 14883 RVA: 0x0005813A File Offset: 0x0005633A
		// (set) Token: 0x06003A24 RID: 14884 RVA: 0x0005814E File Offset: 0x0005634E
		public unsafe FVector CableForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_CableForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_CableForce) = value;
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06003A25 RID: 14885 RVA: 0x00058163 File Offset: 0x00056363
		// (set) Token: 0x06003A26 RID: 14886 RVA: 0x00058173 File Offset: 0x00056373
		public unsafe float CableGravityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_CableGravityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_CableGravityScale) = value;
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06003A27 RID: 14887 RVA: 0x00058184 File Offset: 0x00056384
		// (set) Token: 0x06003A28 RID: 14888 RVA: 0x00058194 File Offset: 0x00056394
		public unsafe float CableWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_CableWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_CableWidth) = value;
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06003A29 RID: 14889 RVA: 0x000581A5 File Offset: 0x000563A5
		// (set) Token: 0x06003A2A RID: 14890 RVA: 0x000581B5 File Offset: 0x000563B5
		public unsafe int NumSides
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_NumSides);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_NumSides) = value;
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06003A2B RID: 14891 RVA: 0x000581C6 File Offset: 0x000563C6
		// (set) Token: 0x06003A2C RID: 14892 RVA: 0x000581D6 File Offset: 0x000563D6
		public unsafe float TileMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_TileMaterial);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCableComponent.__PropertyOffset_TileMaterial) = value;
			}
		}

		// Token: 0x06003A2D RID: 14893 RVA: 0x000581E7 File Offset: 0x000563E7
		public void SetAttachEndToComponent(USceneComponent Component, FName SocketName = default(FName))
		{
			UCableComponent.__SetAttachEndToComponent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, SocketName);
		}

		// Token: 0x06003A2E RID: 14894 RVA: 0x00058205 File Offset: 0x00056405
		public void SetAttachEndTo(AActor Actor, FName ComponentProperty, FName SocketName = default(FName))
		{
			UCableComponent.__SetAttachEndTo_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, ComponentProperty, SocketName);
		}

		// Token: 0x06003A2F RID: 14895 RVA: 0x00058224 File Offset: 0x00056424
		public void ResetMiddleParticles()
		{
			UCableComponent.__ResetMiddleParticles_Internal(base.NativePtr);
		}

		// Token: 0x06003A30 RID: 14896 RVA: 0x00058231 File Offset: 0x00056431
		public void GetCableParticleLocations(ref TArray<FVector> Locations)
		{
			UCableComponent.__GetCableParticleLocations_Internal(base.NativePtr, (Locations ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x06003A31 RID: 14897 RVA: 0x0005824E File Offset: 0x0005644E
		public USceneComponent GetAttachedComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(UCableComponent.__GetAttachedComponent_Internal(base.NativePtr));
		}

		// Token: 0x06003A32 RID: 14898 RVA: 0x00058260 File Offset: 0x00056460
		public AActor GetAttachedActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UCableComponent.__GetAttachedActor_Internal(base.NativePtr));
		}

		// Token: 0x06003A33 RID: 14899 RVA: 0x00058272 File Offset: 0x00056472
		public void D_GetCableParticleLocations(ref TArray<FVectorDouble> Locations)
		{
			UCableComponent.__D_GetCableParticleLocations_Internal(base.NativePtr, (Locations ?? new TArray<FVectorDouble>()).NativePtr);
		}

		// Token: 0x06003A34 RID: 14900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAttachEndToComponent_Internal(IntPtr @this, IntPtr Component, FName SocketName);

		// Token: 0x06003A35 RID: 14901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAttachEndTo_Internal(IntPtr @this, IntPtr Actor, FName ComponentProperty, FName SocketName);

		// Token: 0x06003A36 RID: 14902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetMiddleParticles_Internal(IntPtr @this);

		// Token: 0x06003A37 RID: 14903
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetCableParticleLocations_Internal(IntPtr @this, IntPtr Locations);

		// Token: 0x06003A38 RID: 14904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAttachedComponent_Internal(IntPtr @this);

		// Token: 0x06003A39 RID: 14905
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAttachedActor_Internal(IntPtr @this);

		// Token: 0x06003A3A RID: 14906
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_GetCableParticleLocations_Internal(IntPtr @this, IntPtr Locations);

		// Token: 0x06003A3B RID: 14907 RVA: 0x0005828F File Offset: 0x0005648F
		static UCableComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CableComponent.CableComponent");
		}

		// Token: 0x06003A3C RID: 14908 RVA: 0x0005829D File Offset: 0x0005649D
		protected UCableComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001A70 RID: 6768
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CableComponent.CableComponent";

		// Token: 0x04001A71 RID: 6769
		private static IntPtr _ClassPtr;

		// Token: 0x04001A72 RID: 6770
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001A73 RID: 6771
		internal static int __PropertyOffset_bAttachStart;

		// Token: 0x04001A74 RID: 6772
		internal static int __PropertyOffset_bAttachEnd;

		// Token: 0x04001A75 RID: 6773
		internal static int __PropertyOffset_bUseLocalSpaceSimulation;

		// Token: 0x04001A76 RID: 6774
		internal static int __PropertyOffset_AttachEndTo;

		// Token: 0x04001A77 RID: 6775
		private FComponentReference _AttachEndTo;

		// Token: 0x04001A78 RID: 6776
		internal static int __PropertyOffset_AttachEndToSocketName;

		// Token: 0x04001A79 RID: 6777
		internal static int __PropertyOffset_EndLocation;

		// Token: 0x04001A7A RID: 6778
		internal static int __PropertyOffset_CableLength;

		// Token: 0x04001A7B RID: 6779
		internal static int __PropertyOffset_NumSegments;

		// Token: 0x04001A7C RID: 6780
		internal static int __PropertyOffset_SubstepTime;

		// Token: 0x04001A7D RID: 6781
		internal static int __PropertyOffset_SolverIterations;

		// Token: 0x04001A7E RID: 6782
		internal static int __PropertyOffset_bEnableStiffness;

		// Token: 0x04001A7F RID: 6783
		internal static int __PropertyOffset_bUseSubstepping;

		// Token: 0x04001A80 RID: 6784
		internal static int __PropertyOffset_bSkipCableUpdateWhenNotVisible;

		// Token: 0x04001A81 RID: 6785
		internal static int __PropertyOffset_bSkipCableUpdateWhenNotOwnerRecentlyRendered;

		// Token: 0x04001A82 RID: 6786
		internal static int __PropertyOffset_bEnableCollision;

		// Token: 0x04001A83 RID: 6787
		internal static int __PropertyOffset_CollisionFriction;

		// Token: 0x04001A84 RID: 6788
		internal static int __PropertyOffset_CableForce;

		// Token: 0x04001A85 RID: 6789
		internal static int __PropertyOffset_CableGravityScale;

		// Token: 0x04001A86 RID: 6790
		internal static int __PropertyOffset_CableWidth;

		// Token: 0x04001A87 RID: 6791
		internal static int __PropertyOffset_NumSides;

		// Token: 0x04001A88 RID: 6792
		internal static int __PropertyOffset_TileMaterial;
	}
}
