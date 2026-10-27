using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200102F RID: 4143
	[UnrealObjectPath("/Script/Engine.PredictProjectilePathParams")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FPredictProjectilePathParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E907 RID: 59655 RVA: 0x0015A342 File Offset: 0x00158542
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPredictProjectilePathParams._ScriptStructPtr != 0) ? FPredictProjectilePathParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PredictProjectilePathParams", ref FPredictProjectilePathParams._ScriptStructPtr);
		}

		// Token: 0x1700386A RID: 14442
		// (get) Token: 0x0600E908 RID: 59656 RVA: 0x0015A366 File Offset: 0x00158566
		// (set) Token: 0x0600E909 RID: 59657 RVA: 0x0015A37A File Offset: 0x0015857A
		public unsafe FVector StartLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_StartLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_StartLocation) = value;
			}
		}

		// Token: 0x1700386B RID: 14443
		// (get) Token: 0x0600E90A RID: 59658 RVA: 0x0015A38F File Offset: 0x0015858F
		// (set) Token: 0x0600E90B RID: 59659 RVA: 0x0015A3A3 File Offset: 0x001585A3
		public unsafe FVector LaunchVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_LaunchVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_LaunchVelocity) = value;
			}
		}

		// Token: 0x1700386C RID: 14444
		// (get) Token: 0x0600E90C RID: 59660 RVA: 0x0015A3B8 File Offset: 0x001585B8
		// (set) Token: 0x0600E90D RID: 59661 RVA: 0x0015A3C8 File Offset: 0x001585C8
		public unsafe bool bTraceWithCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_bTraceWithCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_bTraceWithCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700386D RID: 14445
		// (get) Token: 0x0600E90E RID: 59662 RVA: 0x0015A3D9 File Offset: 0x001585D9
		// (set) Token: 0x0600E90F RID: 59663 RVA: 0x0015A3E9 File Offset: 0x001585E9
		public unsafe float ProjectileRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_ProjectileRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_ProjectileRadius) = value;
			}
		}

		// Token: 0x1700386E RID: 14446
		// (get) Token: 0x0600E910 RID: 59664 RVA: 0x0015A3FA File Offset: 0x001585FA
		// (set) Token: 0x0600E911 RID: 59665 RVA: 0x0015A40A File Offset: 0x0015860A
		public unsafe float MaxSimTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_MaxSimTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_MaxSimTime) = value;
			}
		}

		// Token: 0x1700386F RID: 14447
		// (get) Token: 0x0600E912 RID: 59666 RVA: 0x0015A41B File Offset: 0x0015861B
		// (set) Token: 0x0600E913 RID: 59667 RVA: 0x0015A42B File Offset: 0x0015862B
		public unsafe bool bTraceWithChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_bTraceWithChannel) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_bTraceWithChannel) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003870 RID: 14448
		// (get) Token: 0x0600E914 RID: 59668 RVA: 0x0015A43C File Offset: 0x0015863C
		// (set) Token: 0x0600E915 RID: 59669 RVA: 0x0015A450 File Offset: 0x00158650
		public unsafe TEnumAsByte<ECollisionChannel> TraceChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_TraceChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_TraceChannel) = value;
			}
		}

		// Token: 0x17003871 RID: 14449
		// (get) Token: 0x0600E916 RID: 59670 RVA: 0x0015A468 File Offset: 0x00158668
		// (set) Token: 0x0600E917 RID: 59671 RVA: 0x0015A4AB File Offset: 0x001586AB
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EObjectTypeQuery>> result;
				if ((result = this._ObjectTypes) == null)
				{
					result = (this._ObjectTypes = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_ObjectTypes, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.ObjectTypes.CopyAssign(value);
			}
		}

		// Token: 0x17003872 RID: 14450
		// (get) Token: 0x0600E918 RID: 59672 RVA: 0x0015A4BC File Offset: 0x001586BC
		// (set) Token: 0x0600E919 RID: 59673 RVA: 0x0015A4FF File Offset: 0x001586FF
		[Nullable(1)]
		public TArray<AActor> ActorsToIgnore
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._ActorsToIgnore) == null)
				{
					result = (this._ActorsToIgnore = new TArray<AActor>(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_ActorsToIgnore, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ActorsToIgnore.CopyAssign(value);
			}
		}

		// Token: 0x17003873 RID: 14451
		// (get) Token: 0x0600E91A RID: 59674 RVA: 0x0015A50D File Offset: 0x0015870D
		// (set) Token: 0x0600E91B RID: 59675 RVA: 0x0015A51D File Offset: 0x0015871D
		public unsafe float SimFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_SimFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_SimFrequency) = value;
			}
		}

		// Token: 0x17003874 RID: 14452
		// (get) Token: 0x0600E91C RID: 59676 RVA: 0x0015A52E File Offset: 0x0015872E
		// (set) Token: 0x0600E91D RID: 59677 RVA: 0x0015A53E File Offset: 0x0015873E
		public unsafe float OverrideGravityZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_OverrideGravityZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_OverrideGravityZ) = value;
			}
		}

		// Token: 0x17003875 RID: 14453
		// (get) Token: 0x0600E91E RID: 59678 RVA: 0x0015A54F File Offset: 0x0015874F
		// (set) Token: 0x0600E91F RID: 59679 RVA: 0x0015A563 File Offset: 0x00158763
		public unsafe TEnumAsByte<EDrawDebugTrace> DrawDebugType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_DrawDebugType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_DrawDebugType) = value;
			}
		}

		// Token: 0x17003876 RID: 14454
		// (get) Token: 0x0600E920 RID: 59680 RVA: 0x0015A578 File Offset: 0x00158778
		// (set) Token: 0x0600E921 RID: 59681 RVA: 0x0015A588 File Offset: 0x00158788
		public unsafe float DrawDebugTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_DrawDebugTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_DrawDebugTime) = value;
			}
		}

		// Token: 0x17003877 RID: 14455
		// (get) Token: 0x0600E922 RID: 59682 RVA: 0x0015A599 File Offset: 0x00158799
		// (set) Token: 0x0600E923 RID: 59683 RVA: 0x0015A5A9 File Offset: 0x001587A9
		public unsafe bool bTraceComplex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_bTraceComplex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_bTraceComplex) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003878 RID: 14456
		// (get) Token: 0x0600E924 RID: 59684 RVA: 0x0015A5BA File Offset: 0x001587BA
		// (set) Token: 0x0600E925 RID: 59685 RVA: 0x0015A5CA File Offset: 0x001587CA
		public unsafe bool bOverrideGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_bOverrideGravity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_bOverrideGravity) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003879 RID: 14457
		// (get) Token: 0x0600E926 RID: 59686 RVA: 0x0015A5DB File Offset: 0x001587DB
		// (set) Token: 0x0600E927 RID: 59687 RVA: 0x0015A5EF File Offset: 0x001587EF
		public unsafe FVector OverrideGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_OverrideGravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPredictProjectilePathParams.__PropertyOffset_OverrideGravity) = value;
			}
		}

		// Token: 0x0600E928 RID: 59688 RVA: 0x0015A604 File Offset: 0x00158804
		public FPredictProjectilePathParams()
		{
		}

		// Token: 0x0600E929 RID: 59689 RVA: 0x0015A60C File Offset: 0x0015880C
		public FPredictProjectilePathParams(FVector StartLocation, FVector LaunchVelocity, bool bTraceWithCollision, float ProjectileRadius, float MaxSimTime, bool bTraceWithChannel, TEnumAsByte<ECollisionChannel> TraceChannel, [Nullable(new byte[]
		{
			1,
			0
		})] TArray<TEnumAsByte<EObjectTypeQuery>> ObjectTypes, [Nullable(1)] TArray<AActor> ActorsToIgnore, float SimFrequency, float OverrideGravityZ, TEnumAsByte<EDrawDebugTrace> DrawDebugType, float DrawDebugTime, bool bTraceComplex, bool bOverrideGravity, FVector OverrideGravity)
		{
			this.StartLocation = StartLocation;
			this.LaunchVelocity = LaunchVelocity;
			this.bTraceWithCollision = bTraceWithCollision;
			this.ProjectileRadius = ProjectileRadius;
			this.MaxSimTime = MaxSimTime;
			this.bTraceWithChannel = bTraceWithChannel;
			this.TraceChannel = TraceChannel;
			this.ObjectTypes = ObjectTypes;
			this.ActorsToIgnore = ActorsToIgnore;
			this.SimFrequency = SimFrequency;
			this.OverrideGravityZ = OverrideGravityZ;
			this.DrawDebugType = DrawDebugType;
			this.DrawDebugTime = DrawDebugTime;
			this.bTraceComplex = bTraceComplex;
			this.bOverrideGravity = bOverrideGravity;
			this.OverrideGravity = OverrideGravity;
		}

		// Token: 0x0600E92A RID: 59690 RVA: 0x0015A69C File Offset: 0x0015889C
		protected override IntPtr GetUStructPtr()
		{
			return FPredictProjectilePathParams.StaticStruct();
		}

		// Token: 0x0600E92B RID: 59691 RVA: 0x0015A6A8 File Offset: 0x001588A8
		[NullableContext(2)]
		public FPredictProjectilePathParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E92C RID: 59692 RVA: 0x0015A6B2 File Offset: 0x001588B2
		public FPredictProjectilePathParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E92D RID: 59693 RVA: 0x0015A6BD File Offset: 0x001588BD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPredictProjectilePathParams(Pointer, false, true);
		}

		// Token: 0x0600E92E RID: 59694 RVA: 0x0015A6C7 File Offset: 0x001588C7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPredictProjectilePathParams(Pointer, MemoryOwner);
		}

		// Token: 0x04007E85 RID: 32389
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PredictProjectilePathParams";

		// Token: 0x04007E86 RID: 32390
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007E87 RID: 32391
		internal static int __PropertyOffset_StartLocation;

		// Token: 0x04007E88 RID: 32392
		internal static int __PropertyOffset_LaunchVelocity;

		// Token: 0x04007E89 RID: 32393
		internal static int __PropertyOffset_bTraceWithCollision;

		// Token: 0x04007E8A RID: 32394
		internal static int __PropertyOffset_ProjectileRadius;

		// Token: 0x04007E8B RID: 32395
		internal static int __PropertyOffset_MaxSimTime;

		// Token: 0x04007E8C RID: 32396
		internal static int __PropertyOffset_bTraceWithChannel;

		// Token: 0x04007E8D RID: 32397
		internal static int __PropertyOffset_TraceChannel;

		// Token: 0x04007E8E RID: 32398
		internal static int __PropertyOffset_ObjectTypes;

		// Token: 0x04007E8F RID: 32399
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EObjectTypeQuery>> _ObjectTypes;

		// Token: 0x04007E90 RID: 32400
		internal static int __PropertyOffset_ActorsToIgnore;

		// Token: 0x04007E91 RID: 32401
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _ActorsToIgnore;

		// Token: 0x04007E92 RID: 32402
		internal static int __PropertyOffset_SimFrequency;

		// Token: 0x04007E93 RID: 32403
		internal static int __PropertyOffset_OverrideGravityZ;

		// Token: 0x04007E94 RID: 32404
		internal static int __PropertyOffset_DrawDebugType;

		// Token: 0x04007E95 RID: 32405
		internal static int __PropertyOffset_DrawDebugTime;

		// Token: 0x04007E96 RID: 32406
		internal static int __PropertyOffset_bTraceComplex;

		// Token: 0x04007E97 RID: 32407
		internal static int __PropertyOffset_bOverrideGravity;

		// Token: 0x04007E98 RID: 32408
		internal static int __PropertyOffset_OverrideGravity;
	}
}
