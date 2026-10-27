using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001AF3 RID: 6899
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFishAnimSettings")]
	[UnrealStructLayout(80, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKuroFishAnimSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019C25 RID: 105509 RVA: 0x00260EDC File Offset: 0x0025F0DC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroFishAnimSettings._ScriptStructPtr != 0) ? FKuroFishAnimSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroFishAnimSettings", ref FKuroFishAnimSettings._ScriptStructPtr);
		}

		// Token: 0x170066FF RID: 26367
		// (get) Token: 0x06019C26 RID: 105510 RVA: 0x00260F00 File Offset: 0x0025F100
		// (set) Token: 0x06019C27 RID: 105511 RVA: 0x00260F10 File Offset: 0x0025F110
		public unsafe float AnimSpeedSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_AnimSpeedSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_AnimSpeedSpeed) = value;
			}
		}

		// Token: 0x17006700 RID: 26368
		// (get) Token: 0x06019C28 RID: 105512 RVA: 0x00260F21 File Offset: 0x0025F121
		// (set) Token: 0x06019C29 RID: 105513 RVA: 0x00260F31 File Offset: 0x0025F131
		public unsafe float AnimSpeedAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_AnimSpeedAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_AnimSpeedAcceleration) = value;
			}
		}

		// Token: 0x17006701 RID: 26369
		// (get) Token: 0x06019C2A RID: 105514 RVA: 0x00260F42 File Offset: 0x0025F142
		// (set) Token: 0x06019C2B RID: 105515 RVA: 0x00260F52 File Offset: 0x0025F152
		public unsafe float AnimTimeSpeedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_AnimTimeSpeedScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_AnimTimeSpeedScale) = value;
			}
		}

		// Token: 0x17006702 RID: 26370
		// (get) Token: 0x06019C2C RID: 105516 RVA: 0x00260F63 File Offset: 0x0025F163
		// (set) Token: 0x06019C2D RID: 105517 RVA: 0x00260F73 File Offset: 0x0025F173
		public unsafe float AnimTimeAccelScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_AnimTimeAccelScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_AnimTimeAccelScale) = value;
			}
		}

		// Token: 0x17006703 RID: 26371
		// (get) Token: 0x06019C2E RID: 105518 RVA: 0x00260F84 File Offset: 0x0025F184
		// (set) Token: 0x06019C2F RID: 105519 RVA: 0x00260F94 File Offset: 0x0025F194
		public unsafe float InterpAccelerationRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_InterpAccelerationRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_InterpAccelerationRate) = value;
			}
		}

		// Token: 0x17006704 RID: 26372
		// (get) Token: 0x06019C30 RID: 105520 RVA: 0x00260FA5 File Offset: 0x0025F1A5
		// (set) Token: 0x06019C31 RID: 105521 RVA: 0x00260FB5 File Offset: 0x0025F1B5
		public unsafe float DirectionSmoothingRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_DirectionSmoothingRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_DirectionSmoothingRate) = value;
			}
		}

		// Token: 0x17006705 RID: 26373
		// (get) Token: 0x06019C32 RID: 105522 RVA: 0x00260FC6 File Offset: 0x0025F1C6
		// (set) Token: 0x06019C33 RID: 105523 RVA: 0x00260FD6 File Offset: 0x0025F1D6
		public unsafe float TurnSpeedInterpolationSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_TurnSpeedInterpolationSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_TurnSpeedInterpolationSpeed) = value;
			}
		}

		// Token: 0x17006706 RID: 26374
		// (get) Token: 0x06019C34 RID: 105524 RVA: 0x00260FE7 File Offset: 0x0025F1E7
		// (set) Token: 0x06019C35 RID: 105525 RVA: 0x00260FF7 File Offset: 0x0025F1F7
		public unsafe float TurnSpeedDeadzone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_TurnSpeedDeadzone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_TurnSpeedDeadzone) = value;
			}
		}

		// Token: 0x17006707 RID: 26375
		// (get) Token: 0x06019C36 RID: 105526 RVA: 0x00261008 File Offset: 0x0025F208
		// (set) Token: 0x06019C37 RID: 105527 RVA: 0x00261018 File Offset: 0x0025F218
		public unsafe float TurnSpeedToAngleScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_TurnSpeedToAngleScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_TurnSpeedToAngleScale) = value;
			}
		}

		// Token: 0x17006708 RID: 26376
		// (get) Token: 0x06019C38 RID: 105528 RVA: 0x00261029 File Offset: 0x0025F229
		// (set) Token: 0x06019C39 RID: 105529 RVA: 0x00261039 File Offset: 0x0025F239
		public unsafe float MaxAngleOutput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_MaxAngleOutput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_MaxAngleOutput) = value;
			}
		}

		// Token: 0x17006709 RID: 26377
		// (get) Token: 0x06019C3A RID: 105530 RVA: 0x0026104A File Offset: 0x0025F24A
		// (set) Token: 0x06019C3B RID: 105531 RVA: 0x0026105A File Offset: 0x0025F25A
		public unsafe float InterpAngularAccelerationRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_InterpAngularAccelerationRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_InterpAngularAccelerationRate) = value;
			}
		}

		// Token: 0x1700670A RID: 26378
		// (get) Token: 0x06019C3C RID: 105532 RVA: 0x0026106B File Offset: 0x0025F26B
		// (set) Token: 0x06019C3D RID: 105533 RVA: 0x0026107B File Offset: 0x0025F27B
		public unsafe float MaxAngularAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_MaxAngularAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_MaxAngularAcceleration) = value;
			}
		}

		// Token: 0x1700670B RID: 26379
		// (get) Token: 0x06019C3E RID: 105534 RVA: 0x0026108C File Offset: 0x0025F28C
		// (set) Token: 0x06019C3F RID: 105535 RVA: 0x0026109C File Offset: 0x0025F29C
		public unsafe float SpeedRangeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_SpeedRangeMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_SpeedRangeMin) = value;
			}
		}

		// Token: 0x1700670C RID: 26380
		// (get) Token: 0x06019C40 RID: 105536 RVA: 0x002610AD File Offset: 0x0025F2AD
		// (set) Token: 0x06019C41 RID: 105537 RVA: 0x002610BD File Offset: 0x0025F2BD
		public unsafe float SpeedRangeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_SpeedRangeMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_SpeedRangeMax) = value;
			}
		}

		// Token: 0x1700670D RID: 26381
		// (get) Token: 0x06019C42 RID: 105538 RVA: 0x002610CE File Offset: 0x0025F2CE
		// (set) Token: 0x06019C43 RID: 105539 RVA: 0x002610DE File Offset: 0x0025F2DE
		public unsafe float MinSpeedStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_MinSpeedStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_MinSpeedStrength) = value;
			}
		}

		// Token: 0x1700670E RID: 26382
		// (get) Token: 0x06019C44 RID: 105540 RVA: 0x002610EF File Offset: 0x0025F2EF
		// (set) Token: 0x06019C45 RID: 105541 RVA: 0x002610FF File Offset: 0x0025F2FF
		public unsafe float MaxSpeedStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_MaxSpeedStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_MaxSpeedStrength) = value;
			}
		}

		// Token: 0x1700670F RID: 26383
		// (get) Token: 0x06019C46 RID: 105542 RVA: 0x00261110 File Offset: 0x0025F310
		// (set) Token: 0x06019C47 RID: 105543 RVA: 0x00261120 File Offset: 0x0025F320
		public unsafe float AccelerationBoost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_AccelerationBoost);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_AccelerationBoost) = value;
			}
		}

		// Token: 0x17006710 RID: 26384
		// (get) Token: 0x06019C48 RID: 105544 RVA: 0x00261131 File Offset: 0x0025F331
		// (set) Token: 0x06019C49 RID: 105545 RVA: 0x00261141 File Offset: 0x0025F341
		public unsafe float MaxAccelerationBoost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_MaxAccelerationBoost);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_MaxAccelerationBoost) = value;
			}
		}

		// Token: 0x17006711 RID: 26385
		// (get) Token: 0x06019C4A RID: 105546 RVA: 0x00261152 File Offset: 0x0025F352
		// (set) Token: 0x06019C4B RID: 105547 RVA: 0x00261162 File Offset: 0x0025F362
		public unsafe float IntendedSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_IntendedSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_IntendedSpeed) = value;
			}
		}

		// Token: 0x17006712 RID: 26386
		// (get) Token: 0x06019C4C RID: 105548 RVA: 0x00261173 File Offset: 0x0025F373
		// (set) Token: 0x06019C4D RID: 105549 RVA: 0x00261183 File Offset: 0x0025F383
		public unsafe float AnimTimePhaseScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_AnimTimePhaseScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFishAnimSettings.__PropertyOffset_AnimTimePhaseScale) = value;
			}
		}

		// Token: 0x06019C4E RID: 105550 RVA: 0x00261194 File Offset: 0x0025F394
		public FKuroFishAnimSettings()
		{
		}

		// Token: 0x06019C4F RID: 105551 RVA: 0x0026119C File Offset: 0x0025F39C
		public FKuroFishAnimSettings(float AnimSpeedSpeed, float AnimSpeedAcceleration, float AnimTimeSpeedScale, float AnimTimeAccelScale, float InterpAccelerationRate, float DirectionSmoothingRate, float TurnSpeedInterpolationSpeed, float TurnSpeedDeadzone, float TurnSpeedToAngleScale, float MaxAngleOutput, float InterpAngularAccelerationRate, float MaxAngularAcceleration, float SpeedRangeMin, float SpeedRangeMax, float MinSpeedStrength, float MaxSpeedStrength, float AccelerationBoost, float MaxAccelerationBoost, float IntendedSpeed, float AnimTimePhaseScale)
		{
			this.AnimSpeedSpeed = AnimSpeedSpeed;
			this.AnimSpeedAcceleration = AnimSpeedAcceleration;
			this.AnimTimeSpeedScale = AnimTimeSpeedScale;
			this.AnimTimeAccelScale = AnimTimeAccelScale;
			this.InterpAccelerationRate = InterpAccelerationRate;
			this.DirectionSmoothingRate = DirectionSmoothingRate;
			this.TurnSpeedInterpolationSpeed = TurnSpeedInterpolationSpeed;
			this.TurnSpeedDeadzone = TurnSpeedDeadzone;
			this.TurnSpeedToAngleScale = TurnSpeedToAngleScale;
			this.MaxAngleOutput = MaxAngleOutput;
			this.InterpAngularAccelerationRate = InterpAngularAccelerationRate;
			this.MaxAngularAcceleration = MaxAngularAcceleration;
			this.SpeedRangeMin = SpeedRangeMin;
			this.SpeedRangeMax = SpeedRangeMax;
			this.MinSpeedStrength = MinSpeedStrength;
			this.MaxSpeedStrength = MaxSpeedStrength;
			this.AccelerationBoost = AccelerationBoost;
			this.MaxAccelerationBoost = MaxAccelerationBoost;
			this.IntendedSpeed = IntendedSpeed;
			this.AnimTimePhaseScale = AnimTimePhaseScale;
		}

		// Token: 0x06019C50 RID: 105552 RVA: 0x0026124C File Offset: 0x0025F44C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroFishAnimSettings.StaticStruct();
		}

		// Token: 0x06019C51 RID: 105553 RVA: 0x00261258 File Offset: 0x0025F458
		[NullableContext(2)]
		public FKuroFishAnimSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019C52 RID: 105554 RVA: 0x00261262 File Offset: 0x0025F462
		public FKuroFishAnimSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019C53 RID: 105555 RVA: 0x0026126D File Offset: 0x0025F46D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroFishAnimSettings(Pointer, false, true);
		}

		// Token: 0x06019C54 RID: 105556 RVA: 0x00261277 File Offset: 0x0025F477
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroFishAnimSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400E02F RID: 57391
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFishAnimSettings";

		// Token: 0x0400E030 RID: 57392
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E031 RID: 57393
		internal static int __PropertyOffset_AnimSpeedSpeed;

		// Token: 0x0400E032 RID: 57394
		internal static int __PropertyOffset_AnimSpeedAcceleration;

		// Token: 0x0400E033 RID: 57395
		internal static int __PropertyOffset_AnimTimeSpeedScale;

		// Token: 0x0400E034 RID: 57396
		internal static int __PropertyOffset_AnimTimeAccelScale;

		// Token: 0x0400E035 RID: 57397
		internal static int __PropertyOffset_InterpAccelerationRate;

		// Token: 0x0400E036 RID: 57398
		internal static int __PropertyOffset_DirectionSmoothingRate;

		// Token: 0x0400E037 RID: 57399
		internal static int __PropertyOffset_TurnSpeedInterpolationSpeed;

		// Token: 0x0400E038 RID: 57400
		internal static int __PropertyOffset_TurnSpeedDeadzone;

		// Token: 0x0400E039 RID: 57401
		internal static int __PropertyOffset_TurnSpeedToAngleScale;

		// Token: 0x0400E03A RID: 57402
		internal static int __PropertyOffset_MaxAngleOutput;

		// Token: 0x0400E03B RID: 57403
		internal static int __PropertyOffset_InterpAngularAccelerationRate;

		// Token: 0x0400E03C RID: 57404
		internal static int __PropertyOffset_MaxAngularAcceleration;

		// Token: 0x0400E03D RID: 57405
		internal static int __PropertyOffset_SpeedRangeMin;

		// Token: 0x0400E03E RID: 57406
		internal static int __PropertyOffset_SpeedRangeMax;

		// Token: 0x0400E03F RID: 57407
		internal static int __PropertyOffset_MinSpeedStrength;

		// Token: 0x0400E040 RID: 57408
		internal static int __PropertyOffset_MaxSpeedStrength;

		// Token: 0x0400E041 RID: 57409
		internal static int __PropertyOffset_AccelerationBoost;

		// Token: 0x0400E042 RID: 57410
		internal static int __PropertyOffset_MaxAccelerationBoost;

		// Token: 0x0400E043 RID: 57411
		internal static int __PropertyOffset_IntendedSpeed;

		// Token: 0x0400E044 RID: 57412
		internal static int __PropertyOffset_AnimTimePhaseScale;
	}
}
