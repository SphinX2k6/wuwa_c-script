using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C03 RID: 3075
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.GameStateBase")]
	[UnrealStructLayout(1128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1128)]
	public class AGameStateBase : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060099D7 RID: 39383 RVA: 0x000DB4A7 File Offset: 0x000D96A7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGameStateBase._ClassPtr;
		}

		// Token: 0x060099D8 RID: 39384 RVA: 0x000DB4B4 File Offset: 0x000D96B4
		public AGameStateBase() : this(BuiltinUtils.AllocNativeUObject(AGameStateBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060099D9 RID: 39385 RVA: 0x000DB4DC File Offset: 0x000D96DC
		public AGameStateBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGameStateBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700249D RID: 9373
		// (get) Token: 0x060099DA RID: 39386 RVA: 0x000DB50F File Offset: 0x000D970F
		// (set) Token: 0x060099DB RID: 39387 RVA: 0x000DB523 File Offset: 0x000D9723
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AGameModeBase> GameModeClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AGameStateBase.__PropertyOffset_GameModeClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AGameStateBase.__PropertyOffset_GameModeClass) = value;
			}
		}

		// Token: 0x1700249E RID: 9374
		// (get) Token: 0x060099DC RID: 39388 RVA: 0x000DB538 File Offset: 0x000D9738
		// (set) Token: 0x060099DD RID: 39389 RVA: 0x000DB54C File Offset: 0x000D974C
		[Nullable(2)]
		public unsafe AGameModeBase AuthorityGameMode
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AGameModeBase>(base.NativePtr / (IntPtr)sizeof(void*) + AGameStateBase.__PropertyOffset_AuthorityGameMode);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AGameStateBase.__PropertyOffset_AuthorityGameMode, value);
			}
		}

		// Token: 0x1700249F RID: 9375
		// (get) Token: 0x060099DE RID: 39390 RVA: 0x000DB561 File Offset: 0x000D9761
		// (set) Token: 0x060099DF RID: 39391 RVA: 0x000DB575 File Offset: 0x000D9775
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<ASpectatorPawn> SpectatorClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AGameStateBase.__PropertyOffset_SpectatorClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AGameStateBase.__PropertyOffset_SpectatorClass) = value;
			}
		}

		// Token: 0x170024A0 RID: 9376
		// (get) Token: 0x060099E0 RID: 39392 RVA: 0x000DB58C File Offset: 0x000D978C
		// (set) Token: 0x060099E1 RID: 39393 RVA: 0x000DB5C5 File Offset: 0x000D97C5
		public TArray<APlayerState> PlayerArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<APlayerState> result;
				if ((result = this._PlayerArray) == null)
				{
					result = (this._PlayerArray = new TArray<APlayerState>(base.NativePtr + (IntPtr)AGameStateBase.__PropertyOffset_PlayerArray, this));
				}
				return result;
			}
			set
			{
				this.PlayerArray.CopyAssign(value);
			}
		}

		// Token: 0x170024A1 RID: 9377
		// (get) Token: 0x060099E2 RID: 39394 RVA: 0x000DB5D3 File Offset: 0x000D97D3
		// (set) Token: 0x060099E3 RID: 39395 RVA: 0x000DB5E3 File Offset: 0x000D97E3
		public unsafe bool bReplicatedHasBegunPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameStateBase.__PropertyOffset_bReplicatedHasBegunPlay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameStateBase.__PropertyOffset_bReplicatedHasBegunPlay) = (value ? 1 : 0);
			}
		}

		// Token: 0x170024A2 RID: 9378
		// (get) Token: 0x060099E4 RID: 39396 RVA: 0x000DB5F4 File Offset: 0x000D97F4
		// (set) Token: 0x060099E5 RID: 39397 RVA: 0x000DB604 File Offset: 0x000D9804
		public unsafe float ReplicatedWorldTimeSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameStateBase.__PropertyOffset_ReplicatedWorldTimeSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameStateBase.__PropertyOffset_ReplicatedWorldTimeSeconds) = value;
			}
		}

		// Token: 0x170024A3 RID: 9379
		// (get) Token: 0x060099E6 RID: 39398 RVA: 0x000DB615 File Offset: 0x000D9815
		// (set) Token: 0x060099E7 RID: 39399 RVA: 0x000DB625 File Offset: 0x000D9825
		public unsafe float ServerWorldTimeSecondsDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameStateBase.__PropertyOffset_ServerWorldTimeSecondsDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameStateBase.__PropertyOffset_ServerWorldTimeSecondsDelta) = value;
			}
		}

		// Token: 0x170024A4 RID: 9380
		// (get) Token: 0x060099E8 RID: 39400 RVA: 0x000DB636 File Offset: 0x000D9836
		// (set) Token: 0x060099E9 RID: 39401 RVA: 0x000DB646 File Offset: 0x000D9846
		public unsafe float ServerWorldTimeSecondsUpdateFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameStateBase.__PropertyOffset_ServerWorldTimeSecondsUpdateFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameStateBase.__PropertyOffset_ServerWorldTimeSecondsUpdateFrequency) = value;
			}
		}

		// Token: 0x060099EA RID: 39402 RVA: 0x000DB657 File Offset: 0x000D9857
		public void OnRep_SpectatorClass()
		{
			AGameStateBase.__OnRep_SpectatorClass_Internal(base.NativePtr);
		}

		// Token: 0x060099EB RID: 39403 RVA: 0x000DB664 File Offset: 0x000D9864
		public void OnRep_ReplicatedWorldTimeSeconds()
		{
			AGameStateBase.__OnRep_ReplicatedWorldTimeSeconds_Internal(base.NativePtr);
		}

		// Token: 0x060099EC RID: 39404 RVA: 0x000DB671 File Offset: 0x000D9871
		public void OnRep_ReplicatedHasBegunPlay()
		{
			AGameStateBase.__OnRep_ReplicatedHasBegunPlay_Internal(base.NativePtr);
		}

		// Token: 0x060099ED RID: 39405 RVA: 0x000DB67E File Offset: 0x000D987E
		public void OnRep_GameModeClass()
		{
			AGameStateBase.__OnRep_GameModeClass_Internal(base.NativePtr);
		}

		// Token: 0x060099EE RID: 39406 RVA: 0x000DB68B File Offset: 0x000D988B
		public bool HasMatchStarted()
		{
			return AGameStateBase.__HasMatchStarted_Internal(base.NativePtr);
		}

		// Token: 0x060099EF RID: 39407 RVA: 0x000DB698 File Offset: 0x000D9898
		public bool HasMatchEnded()
		{
			return AGameStateBase.__HasMatchEnded_Internal(base.NativePtr);
		}

		// Token: 0x060099F0 RID: 39408 RVA: 0x000DB6A5 File Offset: 0x000D98A5
		public bool HasBegunPlay()
		{
			return AGameStateBase.__HasBegunPlay_Internal(base.NativePtr);
		}

		// Token: 0x060099F1 RID: 39409 RVA: 0x000DB6B2 File Offset: 0x000D98B2
		public float GetServerWorldTimeSeconds()
		{
			return AGameStateBase.__GetServerWorldTimeSeconds_Internal(base.NativePtr);
		}

		// Token: 0x060099F2 RID: 39410 RVA: 0x000DB6BF File Offset: 0x000D98BF
		[NullableContext(2)]
		public float GetPlayerStartTime(AController Controller)
		{
			return AGameStateBase.__GetPlayerStartTime_Internal(base.NativePtr, (Controller != null) ? Controller.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060099F3 RID: 39411 RVA: 0x000DB6DC File Offset: 0x000D98DC
		[NullableContext(2)]
		public float GetPlayerRespawnDelay(AController Controller)
		{
			return AGameStateBase.__GetPlayerRespawnDelay_Internal(base.NativePtr, (Controller != null) ? Controller.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060099F4 RID: 39412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_SpectatorClass_Internal(IntPtr @this);

		// Token: 0x060099F5 RID: 39413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplicatedWorldTimeSeconds_Internal(IntPtr @this);

		// Token: 0x060099F6 RID: 39414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplicatedHasBegunPlay_Internal(IntPtr @this);

		// Token: 0x060099F7 RID: 39415
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_GameModeClass_Internal(IntPtr @this);

		// Token: 0x060099F8 RID: 39416
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasMatchStarted_Internal(IntPtr @this);

		// Token: 0x060099F9 RID: 39417
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasMatchEnded_Internal(IntPtr @this);

		// Token: 0x060099FA RID: 39418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasBegunPlay_Internal(IntPtr @this);

		// Token: 0x060099FB RID: 39419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetServerWorldTimeSeconds_Internal(IntPtr @this);

		// Token: 0x060099FC RID: 39420
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPlayerStartTime_Internal(IntPtr @this, IntPtr Controller);

		// Token: 0x060099FD RID: 39421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPlayerRespawnDelay_Internal(IntPtr @this, IntPtr Controller);

		// Token: 0x060099FE RID: 39422 RVA: 0x000DB6F9 File Offset: 0x000D98F9
		static AGameStateBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GameStateBase");
		}

		// Token: 0x060099FF RID: 39423 RVA: 0x000DB707 File Offset: 0x000D9907
		protected AGameStateBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005547 RID: 21831
		public new const string __ObjectPath = "/Script/Engine.GameStateBase";

		// Token: 0x04005548 RID: 21832
		private static IntPtr _ClassPtr;

		// Token: 0x04005549 RID: 21833
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400554A RID: 21834
		internal static int __PropertyOffset_GameModeClass;

		// Token: 0x0400554B RID: 21835
		internal static int __PropertyOffset_AuthorityGameMode;

		// Token: 0x0400554C RID: 21836
		internal static int __PropertyOffset_SpectatorClass;

		// Token: 0x0400554D RID: 21837
		internal static int __PropertyOffset_PlayerArray;

		// Token: 0x0400554E RID: 21838
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<APlayerState> _PlayerArray;

		// Token: 0x0400554F RID: 21839
		internal static int __PropertyOffset_bReplicatedHasBegunPlay;

		// Token: 0x04005550 RID: 21840
		internal static int __PropertyOffset_ReplicatedWorldTimeSeconds;

		// Token: 0x04005551 RID: 21841
		internal static int __PropertyOffset_ServerWorldTimeSecondsDelta;

		// Token: 0x04005552 RID: 21842
		internal static int __PropertyOffset_ServerWorldTimeSecondsUpdateFrequency;
	}
}
