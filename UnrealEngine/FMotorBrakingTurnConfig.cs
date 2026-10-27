using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F2F RID: 7983
	[UnrealObjectPath("/Script/KuroVehicle.MotorBrakingTurnConfig")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMotorBrakingTurnConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E5DC RID: 124380 RVA: 0x002D2169 File Offset: 0x002D0369
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMotorBrakingTurnConfig._ScriptStructPtr != 0) ? FMotorBrakingTurnConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.MotorBrakingTurnConfig", ref FMotorBrakingTurnConfig._ScriptStructPtr);
		}

		// Token: 0x170078B9 RID: 30905
		// (get) Token: 0x0601E5DD RID: 124381 RVA: 0x002D218D File Offset: 0x002D038D
		// (set) Token: 0x0601E5DE RID: 124382 RVA: 0x002D219D File Offset: 0x002D039D
		public unsafe float BrakingTurnThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBrakingTurnConfig.__PropertyOffset_BrakingTurnThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBrakingTurnConfig.__PropertyOffset_BrakingTurnThreshold) = value;
			}
		}

		// Token: 0x170078BA RID: 30906
		// (get) Token: 0x0601E5DF RID: 124383 RVA: 0x002D21AE File Offset: 0x002D03AE
		// (set) Token: 0x0601E5E0 RID: 124384 RVA: 0x002D21BE File Offset: 0x002D03BE
		public unsafe float BrakingTurnAccel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBrakingTurnConfig.__PropertyOffset_BrakingTurnAccel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBrakingTurnConfig.__PropertyOffset_BrakingTurnAccel) = value;
			}
		}

		// Token: 0x170078BB RID: 30907
		// (get) Token: 0x0601E5E1 RID: 124385 RVA: 0x002D21CF File Offset: 0x002D03CF
		// (set) Token: 0x0601E5E2 RID: 124386 RVA: 0x002D21DF File Offset: 0x002D03DF
		public unsafe float BrakingTurnReduce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBrakingTurnConfig.__PropertyOffset_BrakingTurnReduce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBrakingTurnConfig.__PropertyOffset_BrakingTurnReduce) = value;
			}
		}

		// Token: 0x170078BC RID: 30908
		// (get) Token: 0x0601E5E3 RID: 124387 RVA: 0x002D21F0 File Offset: 0x002D03F0
		// (set) Token: 0x0601E5E4 RID: 124388 RVA: 0x002D2200 File Offset: 0x002D0400
		public unsafe float BrakingTurnMaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMotorBrakingTurnConfig.__PropertyOffset_BrakingTurnMaxSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMotorBrakingTurnConfig.__PropertyOffset_BrakingTurnMaxSpeed) = value;
			}
		}

		// Token: 0x0601E5E5 RID: 124389 RVA: 0x002D2211 File Offset: 0x002D0411
		public FMotorBrakingTurnConfig()
		{
		}

		// Token: 0x0601E5E6 RID: 124390 RVA: 0x002D2219 File Offset: 0x002D0419
		public FMotorBrakingTurnConfig(float BrakingTurnThreshold, float BrakingTurnAccel, float BrakingTurnReduce, float BrakingTurnMaxSpeed)
		{
			this.BrakingTurnThreshold = BrakingTurnThreshold;
			this.BrakingTurnAccel = BrakingTurnAccel;
			this.BrakingTurnReduce = BrakingTurnReduce;
			this.BrakingTurnMaxSpeed = BrakingTurnMaxSpeed;
		}

		// Token: 0x0601E5E7 RID: 124391 RVA: 0x002D223E File Offset: 0x002D043E
		protected override IntPtr GetUStructPtr()
		{
			return FMotorBrakingTurnConfig.StaticStruct();
		}

		// Token: 0x0601E5E8 RID: 124392 RVA: 0x002D224A File Offset: 0x002D044A
		[NullableContext(2)]
		public FMotorBrakingTurnConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E5E9 RID: 124393 RVA: 0x002D2254 File Offset: 0x002D0454
		public FMotorBrakingTurnConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E5EA RID: 124394 RVA: 0x002D225F File Offset: 0x002D045F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMotorBrakingTurnConfig(Pointer, false, true);
		}

		// Token: 0x0601E5EB RID: 124395 RVA: 0x002D2269 File Offset: 0x002D0469
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMotorBrakingTurnConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04010611 RID: 67089
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroVehicle.MotorBrakingTurnConfig";

		// Token: 0x04010612 RID: 67090
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010613 RID: 67091
		internal static int __PropertyOffset_BrakingTurnThreshold;

		// Token: 0x04010614 RID: 67092
		internal static int __PropertyOffset_BrakingTurnAccel;

		// Token: 0x04010615 RID: 67093
		internal static int __PropertyOffset_BrakingTurnReduce;

		// Token: 0x04010616 RID: 67094
		internal static int __PropertyOffset_BrakingTurnMaxSpeed;
	}
}
