using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200046E RID: 1134
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroMovement.KuroCustomMovementFlowerFlying")]
	[UnrealStructLayout(528, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 528)]
	public class UKuroCustomMovementFlowerFlying : UKuroCustomMovementExtension, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006BC5 RID: 27589 RVA: 0x0009CF8A File Offset: 0x0009B18A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCustomMovementFlowerFlying._ClassPtr;
		}

		// Token: 0x06006BC6 RID: 27590 RVA: 0x0009CF98 File Offset: 0x0009B198
		public UKuroCustomMovementFlowerFlying() : this(BuiltinUtils.AllocNativeUObject(UKuroCustomMovementFlowerFlying.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006BC7 RID: 27591 RVA: 0x0009CFC0 File Offset: 0x0009B1C0
		public UKuroCustomMovementFlowerFlying(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCustomMovementFlowerFlying.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x06006BC8 RID: 27592 RVA: 0x0009CFF3 File Offset: 0x0009B1F3
		// (set) Token: 0x06006BC9 RID: 27593 RVA: 0x0009D003 File Offset: 0x0009B203
		public unsafe float GravityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCustomMovementFlowerFlying.__PropertyOffset_GravityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCustomMovementFlowerFlying.__PropertyOffset_GravityScale) = value;
			}
		}

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x06006BCA RID: 27594 RVA: 0x0009D014 File Offset: 0x0009B214
		// (set) Token: 0x06006BCB RID: 27595 RVA: 0x0009D04D File Offset: 0x0009B24D
		public FKuroFlowerFlyingLocationParams LocationParams
		{
			get
			{
				base.FastCheckIsValid();
				FKuroFlowerFlyingLocationParams result;
				if ((result = this._LocationParams) == null)
				{
					result = (this._LocationParams = new FKuroFlowerFlyingLocationParams(base.NativePtr + (IntPtr)UKuroCustomMovementFlowerFlying.__PropertyOffset_LocationParams, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroFlowerFlyingLocationParams.StaticStruct(), base.NativePtr + (IntPtr)UKuroCustomMovementFlowerFlying.__PropertyOffset_LocationParams, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x06006BCC RID: 27596 RVA: 0x0009D070 File Offset: 0x0009B270
		// (set) Token: 0x06006BCD RID: 27597 RVA: 0x0009D0A9 File Offset: 0x0009B2A9
		public FKuroFlowerFlyingFocusParams FocusParams
		{
			get
			{
				base.FastCheckIsValid();
				FKuroFlowerFlyingFocusParams result;
				if ((result = this._FocusParams) == null)
				{
					result = (this._FocusParams = new FKuroFlowerFlyingFocusParams(base.NativePtr + (IntPtr)UKuroCustomMovementFlowerFlying.__PropertyOffset_FocusParams, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroFlowerFlyingFocusParams.StaticStruct(), base.NativePtr + (IntPtr)UKuroCustomMovementFlowerFlying.__PropertyOffset_FocusParams, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x06006BCE RID: 27598 RVA: 0x0009D0CA File Offset: 0x0009B2CA
		// (set) Token: 0x06006BCF RID: 27599 RVA: 0x0009D0DA File Offset: 0x0009B2DA
		public unsafe float Friction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCustomMovementFlowerFlying.__PropertyOffset_Friction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCustomMovementFlowerFlying.__PropertyOffset_Friction) = value;
			}
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x06006BD0 RID: 27600 RVA: 0x0009D0EB File Offset: 0x0009B2EB
		// (set) Token: 0x06006BD1 RID: 27601 RVA: 0x0009D0FB File Offset: 0x0009B2FB
		public unsafe float LateralFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCustomMovementFlowerFlying.__PropertyOffset_LateralFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCustomMovementFlowerFlying.__PropertyOffset_LateralFriction) = value;
			}
		}

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x06006BD2 RID: 27602 RVA: 0x0009D10C File Offset: 0x0009B30C
		// (set) Token: 0x06006BD3 RID: 27603 RVA: 0x0009D11C File Offset: 0x0009B31C
		public unsafe float LateralDriftSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCustomMovementFlowerFlying.__PropertyOffset_LateralDriftSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCustomMovementFlowerFlying.__PropertyOffset_LateralDriftSpeed) = value;
			}
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x06006BD4 RID: 27604 RVA: 0x0009D12D File Offset: 0x0009B32D
		// (set) Token: 0x06006BD5 RID: 27605 RVA: 0x0009D13D File Offset: 0x0009B33D
		public unsafe float LateralDriftAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCustomMovementFlowerFlying.__PropertyOffset_LateralDriftAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCustomMovementFlowerFlying.__PropertyOffset_LateralDriftAcceleration) = value;
			}
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x06006BD6 RID: 27606 RVA: 0x0009D14E File Offset: 0x0009B34E
		// (set) Token: 0x06006BD7 RID: 27607 RVA: 0x0009D162 File Offset: 0x0009B362
		[Nullable(2)]
		public unsafe UKuroConfigHelperNew FlowerFlyingConfigHelper
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroConfigHelperNew>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCustomMovementFlowerFlying.__PropertyOffset_FlowerFlyingConfigHelper);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCustomMovementFlowerFlying.__PropertyOffset_FlowerFlyingConfigHelper, value);
			}
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x06006BD8 RID: 27608 RVA: 0x0009D177 File Offset: 0x0009B377
		// (set) Token: 0x06006BD9 RID: 27609 RVA: 0x0009D187 File Offset: 0x0009B387
		public unsafe bool bDebugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCustomMovementFlowerFlying.__PropertyOffset_bDebugDraw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCustomMovementFlowerFlying.__PropertyOffset_bDebugDraw) = (value ? 1 : 0);
			}
		}

		// Token: 0x06006BDA RID: 27610 RVA: 0x0009D198 File Offset: 0x0009B398
		public unsafe void SetFacingInput(in FQuat InFacingInput)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InFacingInput;
			UKuroCustomMovementFlowerFlying.__SetFacingInput_Internal(base.NativePtr, ptr);
		}

		// Token: 0x06006BDB RID: 27611 RVA: 0x0009D1CD File Offset: 0x0009B3CD
		public void SetDirectionInput(in FVector InDirectionInput, bool bInFocusInput = false)
		{
			UKuroCustomMovementFlowerFlying.__SetDirectionInput_Internal(base.NativePtr, InDirectionInput, bInFocusInput);
		}

		// Token: 0x06006BDC RID: 27612 RVA: 0x0009D1DC File Offset: 0x0009B3DC
		public bool IsReturningToFloatingHeight()
		{
			return UKuroCustomMovementFlowerFlying.__IsReturningToFloatingHeight_Internal(base.NativePtr);
		}

		// Token: 0x06006BDD RID: 27613 RVA: 0x0009D1E9 File Offset: 0x0009B3E9
		public bool IsFocusInputActive()
		{
			return UKuroCustomMovementFlowerFlying.__IsFocusInputActive_Internal(base.NativePtr);
		}

		// Token: 0x06006BDE RID: 27614 RVA: 0x0009D1F6 File Offset: 0x0009B3F6
		public bool HasGroundBelow()
		{
			return UKuroCustomMovementFlowerFlying.__HasGroundBelow_Internal(base.NativePtr);
		}

		// Token: 0x06006BDF RID: 27615 RVA: 0x0009D203 File Offset: 0x0009B403
		public FVector GetWindVector()
		{
			return UKuroCustomMovementFlowerFlying.__GetWindVector_Internal(base.NativePtr);
		}

		// Token: 0x06006BE0 RID: 27616 RVA: 0x0009D210 File Offset: 0x0009B410
		public float GetTargetPitchFirst()
		{
			return UKuroCustomMovementFlowerFlying.__GetTargetPitchFirst_Internal(base.NativePtr);
		}

		// Token: 0x06006BE1 RID: 27617 RVA: 0x0009D21D File Offset: 0x0009B41D
		public float GetOffsetYawFirst()
		{
			return UKuroCustomMovementFlowerFlying.__GetOffsetYawFirst_Internal(base.NativePtr);
		}

		// Token: 0x06006BE2 RID: 27618 RVA: 0x0009D22A File Offset: 0x0009B42A
		public float GetHeightAboveGround()
		{
			return UKuroCustomMovementFlowerFlying.__GetHeightAboveGround_Internal(base.NativePtr);
		}

		// Token: 0x06006BE3 RID: 27619 RVA: 0x0009D237 File Offset: 0x0009B437
		public FQuat GetFacingInput()
		{
			return UKuroCustomMovementFlowerFlying.__GetFacingInput_Internal(base.NativePtr);
		}

		// Token: 0x06006BE4 RID: 27620 RVA: 0x0009D244 File Offset: 0x0009B444
		public FVector GetDirectionInput()
		{
			return UKuroCustomMovementFlowerFlying.__GetDirectionInput_Internal(base.NativePtr);
		}

		// Token: 0x06006BE5 RID: 27621 RVA: 0x0009D251 File Offset: 0x0009B451
		public float GetDeadZoneLow()
		{
			return UKuroCustomMovementFlowerFlying.__GetDeadZoneLow_Internal(base.NativePtr);
		}

		// Token: 0x06006BE6 RID: 27622 RVA: 0x0009D25E File Offset: 0x0009B45E
		public float GetDeadZoneHigh()
		{
			return UKuroCustomMovementFlowerFlying.__GetDeadZoneHigh_Internal(base.NativePtr);
		}

		// Token: 0x06006BE7 RID: 27623 RVA: 0x0009D26B File Offset: 0x0009B46B
		public float GetCurrentPitch()
		{
			return UKuroCustomMovementFlowerFlying.__GetCurrentPitch_Internal(base.NativePtr);
		}

		// Token: 0x06006BE8 RID: 27624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFacingInput_Internal(IntPtr @this, in FQuat InFacingInput);

		// Token: 0x06006BE9 RID: 27625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDirectionInput_Internal(IntPtr @this, in FVector InDirectionInput, bool bInFocusInput);

		// Token: 0x06006BEA RID: 27626
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsReturningToFloatingHeight_Internal(IntPtr @this);

		// Token: 0x06006BEB RID: 27627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsFocusInputActive_Internal(IntPtr @this);

		// Token: 0x06006BEC RID: 27628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasGroundBelow_Internal(IntPtr @this);

		// Token: 0x06006BED RID: 27629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetWindVector_Internal(IntPtr @this);

		// Token: 0x06006BEE RID: 27630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTargetPitchFirst_Internal(IntPtr @this);

		// Token: 0x06006BEF RID: 27631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetOffsetYawFirst_Internal(IntPtr @this);

		// Token: 0x06006BF0 RID: 27632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetHeightAboveGround_Internal(IntPtr @this);

		// Token: 0x06006BF1 RID: 27633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __GetFacingInput_Internal(IntPtr @this);

		// Token: 0x06006BF2 RID: 27634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetDirectionInput_Internal(IntPtr @this);

		// Token: 0x06006BF3 RID: 27635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDeadZoneLow_Internal(IntPtr @this);

		// Token: 0x06006BF4 RID: 27636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDeadZoneHigh_Internal(IntPtr @this);

		// Token: 0x06006BF5 RID: 27637
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurrentPitch_Internal(IntPtr @this);

		// Token: 0x06006BF6 RID: 27638 RVA: 0x0009D278 File Offset: 0x0009B478
		static UKuroCustomMovementFlowerFlying()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMovement.KuroCustomMovementFlowerFlying");
		}

		// Token: 0x06006BF7 RID: 27639 RVA: 0x0009D286 File Offset: 0x0009B486
		protected UKuroCustomMovementFlowerFlying(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002E0A RID: 11786
		public new const string __ObjectPath = "/Script/KuroMovement.KuroCustomMovementFlowerFlying";

		// Token: 0x04002E0B RID: 11787
		private static IntPtr _ClassPtr;

		// Token: 0x04002E0C RID: 11788
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002E0D RID: 11789
		internal static int __PropertyOffset_GravityScale;

		// Token: 0x04002E0E RID: 11790
		internal static int __PropertyOffset_LocationParams;

		// Token: 0x04002E0F RID: 11791
		[Nullable(2)]
		private FKuroFlowerFlyingLocationParams _LocationParams;

		// Token: 0x04002E10 RID: 11792
		internal static int __PropertyOffset_FocusParams;

		// Token: 0x04002E11 RID: 11793
		[Nullable(2)]
		private FKuroFlowerFlyingFocusParams _FocusParams;

		// Token: 0x04002E12 RID: 11794
		internal static int __PropertyOffset_Friction;

		// Token: 0x04002E13 RID: 11795
		internal static int __PropertyOffset_LateralFriction;

		// Token: 0x04002E14 RID: 11796
		internal static int __PropertyOffset_LateralDriftSpeed;

		// Token: 0x04002E15 RID: 11797
		internal static int __PropertyOffset_LateralDriftAcceleration;

		// Token: 0x04002E16 RID: 11798
		internal static int __PropertyOffset_FlowerFlyingConfigHelper;

		// Token: 0x04002E17 RID: 11799
		internal static int __PropertyOffset_bDebugDraw;
	}
}
