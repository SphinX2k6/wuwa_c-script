using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001846 RID: 6214
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroFauxPhysicsTrackTargetComponent")]
	[UnrealStructLayout(912, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 912)]
	public class UKuroFauxPhysicsTrackTargetComponent : UKuroFauxPhysicsComponentBase, IUnrealUObject, IUnrealObject, IKuroPrimitiveVisualizedInterface, IUnrealNativeInterface, IUnrealInterface, IKuroVisualizedInterface
	{
		// Token: 0x06016E85 RID: 93829 RVA: 0x00216DA9 File Offset: 0x00214FA9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFauxPhysicsTrackTargetComponent._ClassPtr;
		}

		// Token: 0x06016E86 RID: 93830 RVA: 0x00216DB5 File Offset: 0x00214FB5
		int IKuroPrimitiveVisualizedInterface.InterfaceOffset()
		{
			return UKuroFauxPhysicsTrackTargetComponent.__InterfaceOffset_IKuroPrimitiveVisualizedInterface;
		}

		// Token: 0x06016E87 RID: 93831 RVA: 0x00216DBC File Offset: 0x00214FBC
		int IKuroVisualizedInterface.InterfaceOffset()
		{
			return UKuroFauxPhysicsTrackTargetComponent.__InterfaceOffset_IKuroVisualizedInterface;
		}

		// Token: 0x06016E88 RID: 93832 RVA: 0x00216DC4 File Offset: 0x00214FC4
		public UKuroFauxPhysicsTrackTargetComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsTrackTargetComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016E89 RID: 93833 RVA: 0x00216DEC File Offset: 0x00214FEC
		[NullableContext(1)]
		public UKuroFauxPhysicsTrackTargetComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsTrackTargetComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005C65 RID: 23653
		// (get) Token: 0x06016E8A RID: 93834 RVA: 0x00216E1F File Offset: 0x0021501F
		// (set) Token: 0x06016E8B RID: 93835 RVA: 0x00216E2F File Offset: 0x0021502F
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

		// Token: 0x17005C66 RID: 23654
		// (get) Token: 0x06016E8C RID: 93836 RVA: 0x00216E40 File Offset: 0x00215040
		// (set) Token: 0x06016E8D RID: 93837 RVA: 0x00216E50 File Offset: 0x00215050
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

		// Token: 0x17005C67 RID: 23655
		// (get) Token: 0x06016E8E RID: 93838 RVA: 0x00216E61 File Offset: 0x00215061
		// (set) Token: 0x06016E8F RID: 93839 RVA: 0x00216E71 File Offset: 0x00215071
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

		// Token: 0x17005C68 RID: 23656
		// (get) Token: 0x06016E90 RID: 93840 RVA: 0x00216E84 File Offset: 0x00215084
		// (set) Token: 0x06016E91 RID: 93841 RVA: 0x00216EBD File Offset: 0x002150BD
		[Nullable(1)]
		public FOnStopTrackTarget OnStopTrackTarget
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroFauxPhysicsTrackTargetComponent.__PropertyOffset_OnStopTrackTarget, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17005C69 RID: 23657
		// (get) Token: 0x06016E92 RID: 93842 RVA: 0x00216EDE File Offset: 0x002150DE
		// (set) Token: 0x06016E93 RID: 93843 RVA: 0x00216EF2 File Offset: 0x002150F2
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

		// Token: 0x17005C6A RID: 23658
		// (get) Token: 0x06016E94 RID: 93844 RVA: 0x00216F07 File Offset: 0x00215107
		// (set) Token: 0x06016E95 RID: 93845 RVA: 0x00216F17 File Offset: 0x00215117
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

		// Token: 0x17005C6B RID: 23659
		// (get) Token: 0x06016E96 RID: 93846 RVA: 0x00216F28 File Offset: 0x00215128
		// (set) Token: 0x06016E97 RID: 93847 RVA: 0x00216F38 File Offset: 0x00215138
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

		// Token: 0x17005C6C RID: 23660
		// (get) Token: 0x06016E98 RID: 93848 RVA: 0x00216F49 File Offset: 0x00215149
		// (set) Token: 0x06016E99 RID: 93849 RVA: 0x00216F59 File Offset: 0x00215159
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

		// Token: 0x17005C6D RID: 23661
		// (get) Token: 0x06016E9A RID: 93850 RVA: 0x00216F6A File Offset: 0x0021516A
		// (set) Token: 0x06016E9B RID: 93851 RVA: 0x00216F7A File Offset: 0x0021517A
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

		// Token: 0x06016E9C RID: 93852 RVA: 0x00216F8B File Offset: 0x0021518B
		[NullableContext(2)]
		public void StartTrackTarget(APawn Target)
		{
			UKuroFauxPhysicsTrackTargetComponent.__StartTrackTarget_Internal(base.NativePtr, (Target != null) ? Target.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06016E9D RID: 93853 RVA: 0x00216FA8 File Offset: 0x002151A8
		public virtual FVector CustomGetDirection(in FVector PosA, in FVector VelA, in FVector PosB, float SpeedB)
		{
			return UKuroFauxPhysicsTrackTargetComponent.__CustomGetDirection_Internal(base.NativePtr, PosA, VelA, PosB, SpeedB);
		}

		// Token: 0x06016E9E RID: 93854 RVA: 0x00216FBA File Offset: 0x002151BA
		protected virtual FVector CustomGetDirection_Implementation(in FVector PosA, in FVector VelA, in FVector PosB, float SpeedB)
		{
			return UKuroFauxPhysicsTrackTargetComponent.__CustomGetDirection_Implementation_Internal(base.NativePtr, PosA, VelA, PosB, SpeedB);
		}

		// Token: 0x06016E9F RID: 93855
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartTrackTarget_Internal(IntPtr @this, IntPtr Target);

		// Token: 0x06016EA0 RID: 93856
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __CustomGetDirection_Internal(IntPtr @this, in FVector PosA, in FVector VelA, in FVector PosB, float SpeedB);

		// Token: 0x06016EA1 RID: 93857
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __CustomGetDirection_Implementation_Internal(IntPtr @this, in FVector PosA, in FVector VelA, in FVector PosB, float SpeedB);

		// Token: 0x06016EA2 RID: 93858 RVA: 0x00216FCC File Offset: 0x002151CC
		static UKuroFauxPhysicsTrackTargetComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFauxPhysics.KuroFauxPhysicsTrackTargetComponent");
		}

		// Token: 0x06016EA3 RID: 93859 RVA: 0x00216FDA File Offset: 0x002151DA
		protected UKuroFauxPhysicsTrackTargetComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C72D RID: 50989
		internal static int __InterfaceOffset_IKuroPrimitiveVisualizedInterface;

		// Token: 0x0400C72E RID: 50990
		internal static int __InterfaceOffset_IKuroVisualizedInterface;

		// Token: 0x0400C72F RID: 50991
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFauxPhysicsTrackTargetComponent";

		// Token: 0x0400C730 RID: 50992
		private static IntPtr _ClassPtr;

		// Token: 0x0400C731 RID: 50993
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C732 RID: 50994
		internal static int __PropertyOffset_PredictionFactor;

		// Token: 0x0400C733 RID: 50995
		internal static int __PropertyOffset_InitLinearSpeed;

		// Token: 0x0400C734 RID: 50996
		internal static int __PropertyOffset_StopTrackTargetDistance;

		// Token: 0x0400C735 RID: 50997
		internal static int __PropertyOffset_OnStopTrackTarget;

		// Token: 0x0400C736 RID: 50998
		[Nullable(2)]
		private FOnStopTrackTarget _OnStopTrackTarget;

		// Token: 0x0400C737 RID: 50999
		internal static int __PropertyOffset_CurrentLinearVelocity;

		// Token: 0x0400C738 RID: 51000
		internal static int __PropertyOffset_MinTimeToIntercept;

		// Token: 0x0400C739 RID: 51001
		internal static int __PropertyOffset_MaxTimeToIntercept;

		// Token: 0x0400C73A RID: 51002
		internal static int __PropertyOffset_ForwardOffsetRatio;

		// Token: 0x0400C73B RID: 51003
		internal static int __PropertyOffset_TrackMethod;

		// Token: 0x02002F6B RID: 12139
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 52)]
		protected ref struct __CustomGetDirection_FunctionParams
		{
			// Token: 0x04016B22 RID: 92962
			[FieldOffset(0)]
			public FVector PosA;

			// Token: 0x04016B23 RID: 92963
			[FieldOffset(12)]
			public FVector VelA;

			// Token: 0x04016B24 RID: 92964
			[FieldOffset(24)]
			public FVector PosB;

			// Token: 0x04016B25 RID: 92965
			[FieldOffset(36)]
			public float SpeedB;

			// Token: 0x04016B26 RID: 92966
			[FieldOffset(40)]
			public FVector __Result;
		}
	}
}
