using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200038A RID: 906
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroFauxPhysicsTrackTargetComponent")]
	[UnrealStructLayout(912, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 912)]
	public class UKuroFauxPhysicsTrackTargetComponent : UKuroFauxPhysicsComponentBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005ACF RID: 23247 RVA: 0x0008040D File Offset: 0x0007E60D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFauxPhysicsTrackTargetComponent._ClassPtr;
		}

		// Token: 0x06005AD0 RID: 23248 RVA: 0x0008041C File Offset: 0x0007E61C
		public UKuroFauxPhysicsTrackTargetComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsTrackTargetComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005AD1 RID: 23249 RVA: 0x00080444 File Offset: 0x0007E644
		public UKuroFauxPhysicsTrackTargetComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsTrackTargetComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170011F8 RID: 4600
		// (get) Token: 0x06005AD2 RID: 23250 RVA: 0x00080477 File Offset: 0x0007E677
		// (set) Token: 0x06005AD3 RID: 23251 RVA: 0x00080487 File Offset: 0x0007E687
		public unsafe float PredictionFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsTrackTargetComponent.__PropertyOffset_PredictionFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsTrackTargetComponent.__PropertyOffset_PredictionFactor) = value;
			}
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x06005AD4 RID: 23252 RVA: 0x00080498 File Offset: 0x0007E698
		// (set) Token: 0x06005AD5 RID: 23253 RVA: 0x000804A8 File Offset: 0x0007E6A8
		public unsafe float InitLinearSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsTrackTargetComponent.__PropertyOffset_InitLinearSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsTrackTargetComponent.__PropertyOffset_InitLinearSpeed) = value;
			}
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x06005AD6 RID: 23254 RVA: 0x000804B9 File Offset: 0x0007E6B9
		// (set) Token: 0x06005AD7 RID: 23255 RVA: 0x000804C9 File Offset: 0x0007E6C9
		public unsafe float StopTrackTargetDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsTrackTargetComponent.__PropertyOffset_StopTrackTargetDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsTrackTargetComponent.__PropertyOffset_StopTrackTargetDistance) = value;
			}
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x06005AD8 RID: 23256 RVA: 0x000804DC File Offset: 0x0007E6DC
		// (set) Token: 0x06005AD9 RID: 23257 RVA: 0x00080515 File Offset: 0x0007E715
		public FOnStopTrackTarget OnStopTrackTarget
		{
			get
			{
				base.FastCheckIsValid();
				FOnStopTrackTarget result;
				if ((result = this._OnStopTrackTarget) == null)
				{
					result = (this._OnStopTrackTarget = new FOnStopTrackTarget(base.NativePtr + (IntPtr)UKuroFauxPhysicsTrackTargetComponent.__PropertyOffset_OnStopTrackTarget, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroFauxPhysicsTrackTargetComponent.__PropertyOffset_OnStopTrackTarget, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x06005ADA RID: 23258 RVA: 0x00080536 File Offset: 0x0007E736
		// (set) Token: 0x06005ADB RID: 23259 RVA: 0x0008054A File Offset: 0x0007E74A
		public unsafe FVector CurrentLinearVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsTrackTargetComponent.__PropertyOffset_CurrentLinearVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsTrackTargetComponent.__PropertyOffset_CurrentLinearVelocity) = value;
			}
		}

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x06005ADC RID: 23260 RVA: 0x0008055F File Offset: 0x0007E75F
		// (set) Token: 0x06005ADD RID: 23261 RVA: 0x0008056F File Offset: 0x0007E76F
		public unsafe float MinTimeToIntercept
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsTrackTargetComponent.__PropertyOffset_MinTimeToIntercept);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsTrackTargetComponent.__PropertyOffset_MinTimeToIntercept) = value;
			}
		}

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x06005ADE RID: 23262 RVA: 0x00080580 File Offset: 0x0007E780
		// (set) Token: 0x06005ADF RID: 23263 RVA: 0x00080590 File Offset: 0x0007E790
		public unsafe float MaxTimeToIntercept
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsTrackTargetComponent.__PropertyOffset_MaxTimeToIntercept);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsTrackTargetComponent.__PropertyOffset_MaxTimeToIntercept) = value;
			}
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x06005AE0 RID: 23264 RVA: 0x000805A1 File Offset: 0x0007E7A1
		// (set) Token: 0x06005AE1 RID: 23265 RVA: 0x000805B1 File Offset: 0x0007E7B1
		public unsafe float ForwardOffsetRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsTrackTargetComponent.__PropertyOffset_ForwardOffsetRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsTrackTargetComponent.__PropertyOffset_ForwardOffsetRatio) = value;
			}
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x06005AE2 RID: 23266 RVA: 0x000805C2 File Offset: 0x0007E7C2
		// (set) Token: 0x06005AE3 RID: 23267 RVA: 0x000805D2 File Offset: 0x0007E7D2
		public unsafe ETrackMethod TrackMethod
		{
			get
			{
				return (ETrackMethod)(*(base.NativePtr + (IntPtr)UKuroFauxPhysicsTrackTargetComponent.__PropertyOffset_TrackMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsTrackTargetComponent.__PropertyOffset_TrackMethod) = (byte)value;
			}
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x000805E3 File Offset: 0x0007E7E3
		[NullableContext(2)]
		public void StartTrackTarget(APawn Target)
		{
			UKuroFauxPhysicsTrackTargetComponent.__StartTrackTarget_Internal(base.NativePtr, (Target != null) ? Target.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005AE5 RID: 23269 RVA: 0x00080600 File Offset: 0x0007E800
		public virtual FVector CustomGetDirection(in FVector PosA, in FVector VelA, in FVector PosB, float SpeedB)
		{
			return UKuroFauxPhysicsTrackTargetComponent.__CustomGetDirection_Internal(base.NativePtr, PosA, VelA, PosB, SpeedB);
		}

		// Token: 0x06005AE6 RID: 23270 RVA: 0x00080612 File Offset: 0x0007E812
		protected virtual FVector CustomGetDirection_Implementation(in FVector PosA, in FVector VelA, in FVector PosB, float SpeedB)
		{
			return UKuroFauxPhysicsTrackTargetComponent.__CustomGetDirection_Implementation_Internal(base.NativePtr, PosA, VelA, PosB, SpeedB);
		}

		// Token: 0x06005AE7 RID: 23271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartTrackTarget_Internal(IntPtr @this, IntPtr Target);

		// Token: 0x06005AE8 RID: 23272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __CustomGetDirection_Internal(IntPtr @this, in FVector PosA, in FVector VelA, in FVector PosB, float SpeedB);

		// Token: 0x06005AE9 RID: 23273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __CustomGetDirection_Implementation_Internal(IntPtr @this, in FVector PosA, in FVector VelA, in FVector PosB, float SpeedB);

		// Token: 0x06005AEA RID: 23274 RVA: 0x00080624 File Offset: 0x0007E824
		static UKuroFauxPhysicsTrackTargetComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFauxPhysics.KuroFauxPhysicsTrackTargetComponent");
		}

		// Token: 0x06005AEB RID: 23275 RVA: 0x00080632 File Offset: 0x0007E832
		protected UKuroFauxPhysicsTrackTargetComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040025BE RID: 9662
		public new const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFauxPhysicsTrackTargetComponent";

		// Token: 0x040025BF RID: 9663
		private static IntPtr _ClassPtr;

		// Token: 0x040025C0 RID: 9664
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040025C1 RID: 9665
		internal static int __PropertyOffset_PredictionFactor;

		// Token: 0x040025C2 RID: 9666
		internal static int __PropertyOffset_InitLinearSpeed;

		// Token: 0x040025C3 RID: 9667
		internal static int __PropertyOffset_StopTrackTargetDistance;

		// Token: 0x040025C4 RID: 9668
		internal static int __PropertyOffset_OnStopTrackTarget;

		// Token: 0x040025C5 RID: 9669
		[Nullable(2)]
		private FOnStopTrackTarget _OnStopTrackTarget;

		// Token: 0x040025C6 RID: 9670
		internal static int __PropertyOffset_CurrentLinearVelocity;

		// Token: 0x040025C7 RID: 9671
		internal static int __PropertyOffset_MinTimeToIntercept;

		// Token: 0x040025C8 RID: 9672
		internal static int __PropertyOffset_MaxTimeToIntercept;

		// Token: 0x040025C9 RID: 9673
		internal static int __PropertyOffset_ForwardOffsetRatio;

		// Token: 0x040025CA RID: 9674
		internal static int __PropertyOffset_TrackMethod;

		// Token: 0x02000A94 RID: 2708
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 52)]
		protected ref struct __CustomGetDirection_FunctionParams
		{
			// Token: 0x04005AE4 RID: 23268
			[FieldOffset(0)]
			public FVector PosA;

			// Token: 0x04005AE5 RID: 23269
			[FieldOffset(12)]
			public FVector VelA;

			// Token: 0x04005AE6 RID: 23270
			[FieldOffset(24)]
			public FVector PosB;

			// Token: 0x04005AE7 RID: 23271
			[FieldOffset(36)]
			public float SpeedB;

			// Token: 0x04005AE8 RID: 23272
			[FieldOffset(40)]
			public FVector __Result;
		}
	}
}
