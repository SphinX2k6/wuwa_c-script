using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012F6 RID: 4854
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_ApplyRootMotionJumpForce")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UAbilityTask_ApplyRootMotionJumpForce : UAbilityTask_ApplyRootMotion_Base, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011E19 RID: 73241 RVA: 0x001A3A07 File Offset: 0x001A1C07
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_ApplyRootMotionJumpForce._ClassPtr;
		}

		// Token: 0x06011E1A RID: 73242 RVA: 0x001A3A14 File Offset: 0x001A1C14
		public UAbilityTask_ApplyRootMotionJumpForce() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_ApplyRootMotionJumpForce.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011E1B RID: 73243 RVA: 0x001A3A3C File Offset: 0x001A1C3C
		[NullableContext(1)]
		public UAbilityTask_ApplyRootMotionJumpForce(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_ApplyRootMotionJumpForce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170045D7 RID: 17879
		// (get) Token: 0x06011E1C RID: 73244 RVA: 0x001A3A70 File Offset: 0x001A1C70
		// (set) Token: 0x06011E1D RID: 73245 RVA: 0x001A3AA9 File Offset: 0x001A1CA9
		[Nullable(1)]
		public FApplyRootMotionJumpForceDelegate OnFinish
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FApplyRootMotionJumpForceDelegate result;
				if ((result = this._OnFinish) == null)
				{
					result = (this._OnFinish = new FApplyRootMotionJumpForceDelegate(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_OnFinish, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_OnFinish, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170045D8 RID: 17880
		// (get) Token: 0x06011E1E RID: 73246 RVA: 0x001A3ACC File Offset: 0x001A1CCC
		// (set) Token: 0x06011E1F RID: 73247 RVA: 0x001A3B05 File Offset: 0x001A1D05
		[Nullable(1)]
		public FApplyRootMotionJumpForceDelegate OnLanded
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FApplyRootMotionJumpForceDelegate result;
				if ((result = this._OnLanded) == null)
				{
					result = (this._OnLanded = new FApplyRootMotionJumpForceDelegate(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_OnLanded, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_OnLanded, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170045D9 RID: 17881
		// (get) Token: 0x06011E20 RID: 73248 RVA: 0x001A3B26 File Offset: 0x001A1D26
		// (set) Token: 0x06011E21 RID: 73249 RVA: 0x001A3B3A File Offset: 0x001A1D3A
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x170045DA RID: 17882
		// (get) Token: 0x06011E22 RID: 73250 RVA: 0x001A3B4F File Offset: 0x001A1D4F
		// (set) Token: 0x06011E23 RID: 73251 RVA: 0x001A3B5F File Offset: 0x001A1D5F
		public unsafe float Distance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_Distance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_Distance) = value;
			}
		}

		// Token: 0x170045DB RID: 17883
		// (get) Token: 0x06011E24 RID: 73252 RVA: 0x001A3B70 File Offset: 0x001A1D70
		// (set) Token: 0x06011E25 RID: 73253 RVA: 0x001A3B80 File Offset: 0x001A1D80
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x170045DC RID: 17884
		// (get) Token: 0x06011E26 RID: 73254 RVA: 0x001A3B91 File Offset: 0x001A1D91
		// (set) Token: 0x06011E27 RID: 73255 RVA: 0x001A3BA1 File Offset: 0x001A1DA1
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x170045DD RID: 17885
		// (get) Token: 0x06011E28 RID: 73256 RVA: 0x001A3BB2 File Offset: 0x001A1DB2
		// (set) Token: 0x06011E29 RID: 73257 RVA: 0x001A3BC2 File Offset: 0x001A1DC2
		public unsafe float MinimumLandedTriggerTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_MinimumLandedTriggerTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_MinimumLandedTriggerTime) = value;
			}
		}

		// Token: 0x170045DE RID: 17886
		// (get) Token: 0x06011E2A RID: 73258 RVA: 0x001A3BD3 File Offset: 0x001A1DD3
		// (set) Token: 0x06011E2B RID: 73259 RVA: 0x001A3BE3 File Offset: 0x001A1DE3
		public unsafe bool bFinishOnLanded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_bFinishOnLanded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_bFinishOnLanded) = (value ? 1 : 0);
			}
		}

		// Token: 0x170045DF RID: 17887
		// (get) Token: 0x06011E2C RID: 73260 RVA: 0x001A3BF4 File Offset: 0x001A1DF4
		// (set) Token: 0x06011E2D RID: 73261 RVA: 0x001A3C08 File Offset: 0x001A1E08
		public unsafe UCurveVector PathOffsetCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_PathOffsetCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_PathOffsetCurve, value);
			}
		}

		// Token: 0x170045E0 RID: 17888
		// (get) Token: 0x06011E2E RID: 73262 RVA: 0x001A3C1D File Offset: 0x001A1E1D
		// (set) Token: 0x06011E2F RID: 73263 RVA: 0x001A3C31 File Offset: 0x001A1E31
		public unsafe UCurveFloat TimeMappingCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_TimeMappingCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_ApplyRootMotionJumpForce.__PropertyOffset_TimeMappingCurve, value);
			}
		}

		// Token: 0x06011E30 RID: 73264 RVA: 0x001A3C46 File Offset: 0x001A1E46
		public void OnLandedCallback(in FHitResult Hit)
		{
			UAbilityTask_ApplyRootMotionJumpForce.__OnLandedCallback_Internal(base.NativePtr, (Hit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x06011E31 RID: 73265 RVA: 0x001A3C63 File Offset: 0x001A1E63
		public void Finish()
		{
			UAbilityTask_ApplyRootMotionJumpForce.__Finish_Internal(base.NativePtr);
		}

		// Token: 0x06011E32 RID: 73266 RVA: 0x001A3C70 File Offset: 0x001A1E70
		public static UAbilityTask_ApplyRootMotionJumpForce ApplyRootMotionJumpForce(UGameplayAbility OwningAbility, FName TaskInstanceName, FRotator Rotation, float Distance, float Height, float Duration, float MinimumLandedTriggerTime, bool bFinishOnLanded, ERootMotionFinishVelocityMode VelocityOnFinishMode, FVector SetVelocityOnFinish, float ClampVelocityOnFinish, UCurveVector PathOffsetCurve, UCurveFloat TimeMappingCurve)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_ApplyRootMotionJumpForce>(UAbilityTask_ApplyRootMotionJumpForce.__ApplyRootMotionJumpForce_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, TaskInstanceName, Rotation, Distance, Height, Duration, MinimumLandedTriggerTime, bFinishOnLanded, VelocityOnFinishMode, SetVelocityOnFinish, ClampVelocityOnFinish, (PathOffsetCurve != null) ? PathOffsetCurve.NativePtr : IntPtr.Zero, (TimeMappingCurve != null) ? TimeMappingCurve.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06011E33 RID: 73267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLandedCallback_Internal(IntPtr @this, IntPtr Hit);

		// Token: 0x06011E34 RID: 73268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Finish_Internal(IntPtr @this);

		// Token: 0x06011E35 RID: 73269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ApplyRootMotionJumpForce_Internal(IntPtr OwningAbility, FName TaskInstanceName, FRotator Rotation, float Distance, float Height, float Duration, float MinimumLandedTriggerTime, bool bFinishOnLanded, ERootMotionFinishVelocityMode VelocityOnFinishMode, FVector SetVelocityOnFinish, float ClampVelocityOnFinish, IntPtr PathOffsetCurve, IntPtr TimeMappingCurve);

		// Token: 0x06011E36 RID: 73270 RVA: 0x001A3CCC File Offset: 0x001A1ECC
		static UAbilityTask_ApplyRootMotionJumpForce()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_ApplyRootMotionJumpForce");
		}

		// Token: 0x06011E37 RID: 73271 RVA: 0x001A3CDA File Offset: 0x001A1EDA
		protected UAbilityTask_ApplyRootMotionJumpForce(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040098FA RID: 39162
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_ApplyRootMotionJumpForce";

		// Token: 0x040098FB RID: 39163
		private static IntPtr _ClassPtr;

		// Token: 0x040098FC RID: 39164
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040098FD RID: 39165
		internal static int __PropertyOffset_OnFinish;

		// Token: 0x040098FE RID: 39166
		private FApplyRootMotionJumpForceDelegate _OnFinish;

		// Token: 0x040098FF RID: 39167
		internal static int __PropertyOffset_OnLanded;

		// Token: 0x04009900 RID: 39168
		private FApplyRootMotionJumpForceDelegate _OnLanded;

		// Token: 0x04009901 RID: 39169
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04009902 RID: 39170
		internal static int __PropertyOffset_Distance;

		// Token: 0x04009903 RID: 39171
		internal static int __PropertyOffset_Height;

		// Token: 0x04009904 RID: 39172
		internal static int __PropertyOffset_Duration;

		// Token: 0x04009905 RID: 39173
		internal static int __PropertyOffset_MinimumLandedTriggerTime;

		// Token: 0x04009906 RID: 39174
		internal static int __PropertyOffset_bFinishOnLanded;

		// Token: 0x04009907 RID: 39175
		internal static int __PropertyOffset_PathOffsetCurve;

		// Token: 0x04009908 RID: 39176
		internal static int __PropertyOffset_TimeMappingCurve;
	}
}
