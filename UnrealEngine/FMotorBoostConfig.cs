using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F2E RID: 7982
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVehicle.MotorBoostConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMotorBoostConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E5CE RID: 124366 RVA: 0x002D2044 File Offset: 0x002D0244
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorBoostConfig._ScriptStructPtr != 0) ? FMotorBoostConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorBoostConfig", ref FMotorBoostConfig._ScriptStructPtr);
		}

		// Token: 0x170078B6 RID: 30902
		// (get) Token: 0x0601E5CF RID: 124367 RVA: 0x002D2068 File Offset: 0x002D0268
		// (set) Token: 0x0601E5D0 RID: 124368 RVA: 0x002D2078 File Offset: 0x002D0278
		public unsafe float BoostAccelOnAir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBoostConfig.__PropertyOffset_BoostAccelOnAir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBoostConfig.__PropertyOffset_BoostAccelOnAir) = value;
			}
		}

		// Token: 0x170078B7 RID: 30903
		// (get) Token: 0x0601E5D1 RID: 124369 RVA: 0x002D2089 File Offset: 0x002D0289
		// (set) Token: 0x0601E5D2 RID: 124370 RVA: 0x002D2099 File Offset: 0x002D0299
		public unsafe float BoostMaxSpeedOnAir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBoostConfig.__PropertyOffset_BoostMaxSpeedOnAir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBoostConfig.__PropertyOffset_BoostMaxSpeedOnAir) = value;
			}
		}

		// Token: 0x170078B8 RID: 30904
		// (get) Token: 0x0601E5D3 RID: 124371 RVA: 0x002D20AC File Offset: 0x002D02AC
		// (set) Token: 0x0601E5D4 RID: 124372 RVA: 0x002D20EF File Offset: 0x002D02EF
		public FMotorFloatRange SlowDownOnGround
		{
			get
			{
				base.FastCheckIsValid();
				FMotorFloatRange result;
				if ((result = this._SlowDownOnGround) == null)
				{
					result = (this._SlowDownOnGround = new FMotorFloatRange(base.NativePtr + (IntPtr)FMotorBoostConfig.__PropertyOffset_SlowDownOnGround, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMotorFloatRange.StaticStruct(), base.NativePtr + (IntPtr)FMotorBoostConfig.__PropertyOffset_SlowDownOnGround, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601E5D5 RID: 124373 RVA: 0x002D2110 File Offset: 0x002D0310
		public FMotorBoostConfig()
		{
		}

		// Token: 0x0601E5D6 RID: 124374 RVA: 0x002D2118 File Offset: 0x002D0318
		public FMotorBoostConfig(float BoostAccelOnAir, float BoostMaxSpeedOnAir, FMotorFloatRange SlowDownOnGround)
		{
			this.BoostAccelOnAir = BoostAccelOnAir;
			this.BoostMaxSpeedOnAir = BoostMaxSpeedOnAir;
			this.SlowDownOnGround = SlowDownOnGround;
		}

		// Token: 0x0601E5D7 RID: 124375 RVA: 0x002D2135 File Offset: 0x002D0335
		protected override IntPtr GetUStructPtr()
		{
			return FMotorBoostConfig.StaticStruct();
		}

		// Token: 0x0601E5D8 RID: 124376 RVA: 0x002D2141 File Offset: 0x002D0341
		[NullableContext(2)]
		public FMotorBoostConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E5D9 RID: 124377 RVA: 0x002D214B File Offset: 0x002D034B
		public FMotorBoostConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E5DA RID: 124378 RVA: 0x002D2156 File Offset: 0x002D0356
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorBoostConfig(Pointer, false, true);
		}

		// Token: 0x0601E5DB RID: 124379 RVA: 0x002D2160 File Offset: 0x002D0360
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorBoostConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401060B RID: 67083
		public const string __ObjectPath = "/Script/KuroVehicle.MotorBoostConfig";

		// Token: 0x0401060C RID: 67084
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401060D RID: 67085
		internal static int __PropertyOffset_BoostAccelOnAir;

		// Token: 0x0401060E RID: 67086
		internal static int __PropertyOffset_BoostMaxSpeedOnAir;

		// Token: 0x0401060F RID: 67087
		internal static int __PropertyOffset_SlowDownOnGround;

		// Token: 0x04010610 RID: 67088
		[Nullable(2)]
		private FMotorFloatRange _SlowDownOnGround;
	}
}
