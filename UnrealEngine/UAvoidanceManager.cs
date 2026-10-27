using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000876 RID: 2166
	[UnrealObjectPath("/Script/Engine.AvoidanceManager")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UAvoidanceManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060075CB RID: 30155 RVA: 0x000A9050 File Offset: 0x000A7250
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAvoidanceManager._ClassPtr;
		}

		// Token: 0x060075CC RID: 30156 RVA: 0x000A905C File Offset: 0x000A725C
		public UAvoidanceManager() : this(BuiltinUtils.AllocNativeUObject(UAvoidanceManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060075CD RID: 30157 RVA: 0x000A9084 File Offset: 0x000A7284
		[NullableContext(1)]
		public UAvoidanceManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAvoidanceManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001BDB RID: 7131
		// (get) Token: 0x060075CE RID: 30158 RVA: 0x000A90B7 File Offset: 0x000A72B7
		// (set) Token: 0x060075CF RID: 30159 RVA: 0x000A90C7 File Offset: 0x000A72C7
		public unsafe float DefaultTimeToLive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAvoidanceManager.__PropertyOffset_DefaultTimeToLive);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAvoidanceManager.__PropertyOffset_DefaultTimeToLive) = value;
			}
		}

		// Token: 0x17001BDC RID: 7132
		// (get) Token: 0x060075D0 RID: 30160 RVA: 0x000A90D8 File Offset: 0x000A72D8
		// (set) Token: 0x060075D1 RID: 30161 RVA: 0x000A90E8 File Offset: 0x000A72E8
		public unsafe float LockTimeAfterAvoid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAvoidanceManager.__PropertyOffset_LockTimeAfterAvoid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAvoidanceManager.__PropertyOffset_LockTimeAfterAvoid) = value;
			}
		}

		// Token: 0x17001BDD RID: 7133
		// (get) Token: 0x060075D2 RID: 30162 RVA: 0x000A90F9 File Offset: 0x000A72F9
		// (set) Token: 0x060075D3 RID: 30163 RVA: 0x000A9109 File Offset: 0x000A7309
		public unsafe float LockTimeAfterClean
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAvoidanceManager.__PropertyOffset_LockTimeAfterClean);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAvoidanceManager.__PropertyOffset_LockTimeAfterClean) = value;
			}
		}

		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x060075D4 RID: 30164 RVA: 0x000A911A File Offset: 0x000A731A
		// (set) Token: 0x060075D5 RID: 30165 RVA: 0x000A912A File Offset: 0x000A732A
		public unsafe float DeltaTimeToPredict
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAvoidanceManager.__PropertyOffset_DeltaTimeToPredict);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAvoidanceManager.__PropertyOffset_DeltaTimeToPredict) = value;
			}
		}

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x060075D6 RID: 30166 RVA: 0x000A913B File Offset: 0x000A733B
		// (set) Token: 0x060075D7 RID: 30167 RVA: 0x000A914B File Offset: 0x000A734B
		public unsafe float ArtificialRadiusExpansion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAvoidanceManager.__PropertyOffset_ArtificialRadiusExpansion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAvoidanceManager.__PropertyOffset_ArtificialRadiusExpansion) = value;
			}
		}

		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x060075D8 RID: 30168 RVA: 0x000A915C File Offset: 0x000A735C
		// (set) Token: 0x060075D9 RID: 30169 RVA: 0x000A916C File Offset: 0x000A736C
		public unsafe float TestHeightDifference_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAvoidanceManager.__PropertyOffset_TestHeightDifference_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAvoidanceManager.__PropertyOffset_TestHeightDifference_DEPRECATED) = value;
			}
		}

		// Token: 0x17001BE1 RID: 7137
		// (get) Token: 0x060075DA RID: 30170 RVA: 0x000A917D File Offset: 0x000A737D
		// (set) Token: 0x060075DB RID: 30171 RVA: 0x000A918D File Offset: 0x000A738D
		public unsafe float HeightCheckMargin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAvoidanceManager.__PropertyOffset_HeightCheckMargin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAvoidanceManager.__PropertyOffset_HeightCheckMargin) = value;
			}
		}

		// Token: 0x060075DC RID: 30172 RVA: 0x000A919E File Offset: 0x000A739E
		[NullableContext(2)]
		public bool RegisterMovementComponent(UMovementComponent MovementComp, float AvoidanceWeight = 0.5f)
		{
			return UAvoidanceManager.__RegisterMovementComponent_Internal(base.NativePtr, (MovementComp != null) ? MovementComp.NativePtr : IntPtr.Zero, AvoidanceWeight);
		}

		// Token: 0x060075DD RID: 30173 RVA: 0x000A91BC File Offset: 0x000A73BC
		public int GetObjectCount()
		{
			return UAvoidanceManager.__GetObjectCount_Internal(base.NativePtr);
		}

		// Token: 0x060075DE RID: 30174 RVA: 0x000A91C9 File Offset: 0x000A73C9
		public int GetNewAvoidanceUID()
		{
			return UAvoidanceManager.__GetNewAvoidanceUID_Internal(base.NativePtr);
		}

		// Token: 0x060075DF RID: 30175 RVA: 0x000A91D6 File Offset: 0x000A73D6
		[NullableContext(2)]
		public FVector GetAvoidanceVelocityForComponent(UMovementComponent MovementComp)
		{
			return UAvoidanceManager.__GetAvoidanceVelocityForComponent_Internal(base.NativePtr, (MovementComp != null) ? MovementComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060075E0 RID: 30176
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RegisterMovementComponent_Internal(IntPtr @this, IntPtr MovementComp, float AvoidanceWeight);

		// Token: 0x060075E1 RID: 30177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetObjectCount_Internal(IntPtr @this);

		// Token: 0x060075E2 RID: 30178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNewAvoidanceUID_Internal(IntPtr @this);

		// Token: 0x060075E3 RID: 30179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetAvoidanceVelocityForComponent_Internal(IntPtr @this, IntPtr MovementComp);

		// Token: 0x060075E4 RID: 30180 RVA: 0x000A91F3 File Offset: 0x000A73F3
		static UAvoidanceManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AvoidanceManager");
		}

		// Token: 0x060075E5 RID: 30181 RVA: 0x000A9201 File Offset: 0x000A7401
		protected UAvoidanceManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040038B9 RID: 14521
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AvoidanceManager";

		// Token: 0x040038BA RID: 14522
		private static IntPtr _ClassPtr;

		// Token: 0x040038BB RID: 14523
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040038BC RID: 14524
		internal static int __PropertyOffset_DefaultTimeToLive;

		// Token: 0x040038BD RID: 14525
		internal static int __PropertyOffset_LockTimeAfterAvoid;

		// Token: 0x040038BE RID: 14526
		internal static int __PropertyOffset_LockTimeAfterClean;

		// Token: 0x040038BF RID: 14527
		internal static int __PropertyOffset_DeltaTimeToPredict;

		// Token: 0x040038C0 RID: 14528
		internal static int __PropertyOffset_ArtificialRadiusExpansion;

		// Token: 0x040038C1 RID: 14529
		internal static int __PropertyOffset_TestHeightDifference_DEPRECATED;

		// Token: 0x040038C2 RID: 14530
		internal static int __PropertyOffset_HeightCheckMargin;
	}
}
