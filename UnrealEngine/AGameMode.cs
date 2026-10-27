using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BFC RID: 3068
	[UnrealObjectPath("/Script/Engine.GameMode")]
	[UnrealStructLayout(1288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1288)]
	public class AGameMode : AGameModeBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600976F RID: 38767 RVA: 0x000D7DA5 File Offset: 0x000D5FA5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AGameMode._ClassPtr;
		}

		// Token: 0x06009770 RID: 38768 RVA: 0x000D7DB4 File Offset: 0x000D5FB4
		public AGameMode() : this(BuiltinUtils.AllocNativeUObject(AGameMode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009771 RID: 38769 RVA: 0x000D7DDC File Offset: 0x000D5FDC
		[NullableContext(1)]
		public AGameMode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AGameMode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002449 RID: 9289
		// (get) Token: 0x06009772 RID: 38770 RVA: 0x000D7E0F File Offset: 0x000D600F
		// (set) Token: 0x06009773 RID: 38771 RVA: 0x000D7E23 File Offset: 0x000D6023
		public unsafe FName MatchState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_MatchState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_MatchState) = value;
			}
		}

		// Token: 0x1700244A RID: 9290
		// (get) Token: 0x06009774 RID: 38772 RVA: 0x000D7E38 File Offset: 0x000D6038
		// (set) Token: 0x06009775 RID: 38773 RVA: 0x000D7E51 File Offset: 0x000D6051
		public unsafe bool bDelayedStart
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_bDelayedStart) & AGameMode.__PropertyMask_bDelayedStart) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AGameMode.__PropertyOffset_bDelayedStart) = ((*(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_bDelayedStart) & ~AGameMode.__PropertyMask_bDelayedStart) | (value ? AGameMode.__PropertyMask_bDelayedStart : 0));
			}
		}

		// Token: 0x1700244B RID: 9291
		// (get) Token: 0x06009776 RID: 38774 RVA: 0x000D7E81 File Offset: 0x000D6081
		// (set) Token: 0x06009777 RID: 38775 RVA: 0x000D7E91 File Offset: 0x000D6091
		public unsafe int NumSpectators
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_NumSpectators);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_NumSpectators) = value;
			}
		}

		// Token: 0x1700244C RID: 9292
		// (get) Token: 0x06009778 RID: 38776 RVA: 0x000D7EA2 File Offset: 0x000D60A2
		// (set) Token: 0x06009779 RID: 38777 RVA: 0x000D7EB2 File Offset: 0x000D60B2
		public unsafe int NumPlayers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_NumPlayers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_NumPlayers) = value;
			}
		}

		// Token: 0x1700244D RID: 9293
		// (get) Token: 0x0600977A RID: 38778 RVA: 0x000D7EC3 File Offset: 0x000D60C3
		// (set) Token: 0x0600977B RID: 38779 RVA: 0x000D7ED3 File Offset: 0x000D60D3
		public unsafe int NumBots
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_NumBots);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_NumBots) = value;
			}
		}

		// Token: 0x1700244E RID: 9294
		// (get) Token: 0x0600977C RID: 38780 RVA: 0x000D7EE4 File Offset: 0x000D60E4
		// (set) Token: 0x0600977D RID: 38781 RVA: 0x000D7EF4 File Offset: 0x000D60F4
		public unsafe float MinRespawnDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_MinRespawnDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_MinRespawnDelay) = value;
			}
		}

		// Token: 0x1700244F RID: 9295
		// (get) Token: 0x0600977E RID: 38782 RVA: 0x000D7F05 File Offset: 0x000D6105
		// (set) Token: 0x0600977F RID: 38783 RVA: 0x000D7F15 File Offset: 0x000D6115
		public unsafe int NumTravellingPlayers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_NumTravellingPlayers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_NumTravellingPlayers) = value;
			}
		}

		// Token: 0x17002450 RID: 9296
		// (get) Token: 0x06009780 RID: 38784 RVA: 0x000D7F26 File Offset: 0x000D6126
		// (set) Token: 0x06009781 RID: 38785 RVA: 0x000D7F3A File Offset: 0x000D613A
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<ULocalMessage> EngineMessageClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_EngineMessageClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_EngineMessageClass) = value;
			}
		}

		// Token: 0x17002451 RID: 9297
		// (get) Token: 0x06009782 RID: 38786 RVA: 0x000D7F50 File Offset: 0x000D6150
		// (set) Token: 0x06009783 RID: 38787 RVA: 0x000D7F89 File Offset: 0x000D6189
		[Nullable(1)]
		public TArray<APlayerState> InactivePlayerArray
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<APlayerState> result;
				if ((result = this._InactivePlayerArray) == null)
				{
					result = (this._InactivePlayerArray = new TArray<APlayerState>(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_InactivePlayerArray, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.InactivePlayerArray.CopyAssign(value);
			}
		}

		// Token: 0x17002452 RID: 9298
		// (get) Token: 0x06009784 RID: 38788 RVA: 0x000D7F97 File Offset: 0x000D6197
		// (set) Token: 0x06009785 RID: 38789 RVA: 0x000D7FA7 File Offset: 0x000D61A7
		public unsafe float InactivePlayerStateLifeSpan
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_InactivePlayerStateLifeSpan);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_InactivePlayerStateLifeSpan) = value;
			}
		}

		// Token: 0x17002453 RID: 9299
		// (get) Token: 0x06009786 RID: 38790 RVA: 0x000D7FB8 File Offset: 0x000D61B8
		// (set) Token: 0x06009787 RID: 38791 RVA: 0x000D7FC8 File Offset: 0x000D61C8
		public unsafe int MaxInactivePlayers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_MaxInactivePlayers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_MaxInactivePlayers) = value;
			}
		}

		// Token: 0x17002454 RID: 9300
		// (get) Token: 0x06009788 RID: 38792 RVA: 0x000D7FD9 File Offset: 0x000D61D9
		// (set) Token: 0x06009789 RID: 38793 RVA: 0x000D7FE9 File Offset: 0x000D61E9
		public unsafe bool bHandleDedicatedServerReplays
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_bHandleDedicatedServerReplays) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AGameMode.__PropertyOffset_bHandleDedicatedServerReplays) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600978A RID: 38794 RVA: 0x000D7FFA File Offset: 0x000D61FA
		public void StartMatch()
		{
			AGameMode.__StartMatch_Internal(base.NativePtr);
		}

		// Token: 0x0600978B RID: 38795 RVA: 0x000D8007 File Offset: 0x000D6207
		public void SetBandwidthLimit(float AsyncIOBandwidthLimit)
		{
			AGameMode.__SetBandwidthLimit_Internal(base.NativePtr, AsyncIOBandwidthLimit);
		}

		// Token: 0x0600978C RID: 38796 RVA: 0x000D8018 File Offset: 0x000D6218
		[NullableContext(1)]
		public unsafe void Say(string Msg)
		{
			FString fstring = FString.AllocTemp(Msg);
			AGameMode.__Say_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600978D RID: 38797 RVA: 0x000D8042 File Offset: 0x000D6242
		public void RestartGame()
		{
			AGameMode.__RestartGame_Internal(base.NativePtr);
		}

		// Token: 0x0600978E RID: 38798 RVA: 0x000D804F File Offset: 0x000D624F
		public virtual bool ReadyToStartMatch()
		{
			return AGameMode.__ReadyToStartMatch_Internal(base.NativePtr);
		}

		// Token: 0x0600978F RID: 38799 RVA: 0x000D805C File Offset: 0x000D625C
		protected virtual bool ReadyToStartMatch_Implementation()
		{
			return AGameMode.__ReadyToStartMatch_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x06009790 RID: 38800 RVA: 0x000D8069 File Offset: 0x000D6269
		public virtual bool ReadyToEndMatch()
		{
			return AGameMode.__ReadyToEndMatch_Internal(base.NativePtr);
		}

		// Token: 0x06009791 RID: 38801 RVA: 0x000D8076 File Offset: 0x000D6276
		protected virtual bool ReadyToEndMatch_Implementation()
		{
			return AGameMode.__ReadyToEndMatch_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x06009792 RID: 38802 RVA: 0x000D8083 File Offset: 0x000D6283
		public virtual void K2_OnSetMatchState(FName NewState)
		{
			AGameMode.__K2_OnSetMatchState_Internal(base.NativePtr, NewState);
		}

		// Token: 0x06009793 RID: 38803 RVA: 0x000D8091 File Offset: 0x000D6291
		public bool IsMatchInProgress()
		{
			return AGameMode.__IsMatchInProgress_Internal(base.NativePtr);
		}

		// Token: 0x06009794 RID: 38804 RVA: 0x000D809E File Offset: 0x000D629E
		public FName GetMatchState()
		{
			return AGameMode.__GetMatchState_Internal(base.NativePtr);
		}

		// Token: 0x06009795 RID: 38805 RVA: 0x000D80AB File Offset: 0x000D62AB
		public void EndMatch()
		{
			AGameMode.__EndMatch_Internal(base.NativePtr);
		}

		// Token: 0x06009796 RID: 38806 RVA: 0x000D80B8 File Offset: 0x000D62B8
		public void AbortMatch()
		{
			AGameMode.__AbortMatch_Internal(base.NativePtr);
		}

		// Token: 0x06009797 RID: 38807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartMatch_Internal(IntPtr @this);

		// Token: 0x06009798 RID: 38808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBandwidthLimit_Internal(IntPtr @this, float AsyncIOBandwidthLimit);

		// Token: 0x06009799 RID: 38809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Say_Internal(IntPtr @this, in FString Msg);

		// Token: 0x0600979A RID: 38810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RestartGame_Internal(IntPtr @this);

		// Token: 0x0600979B RID: 38811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ReadyToStartMatch_Internal(IntPtr @this);

		// Token: 0x0600979C RID: 38812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ReadyToStartMatch_Implementation_Internal(IntPtr @this);

		// Token: 0x0600979D RID: 38813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ReadyToEndMatch_Internal(IntPtr @this);

		// Token: 0x0600979E RID: 38814
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ReadyToEndMatch_Implementation_Internal(IntPtr @this);

		// Token: 0x0600979F RID: 38815
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnSetMatchState_Internal(IntPtr @this, FName NewState);

		// Token: 0x060097A0 RID: 38816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMatchInProgress_Internal(IntPtr @this);

		// Token: 0x060097A1 RID: 38817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetMatchState_Internal(IntPtr @this);

		// Token: 0x060097A2 RID: 38818
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EndMatch_Internal(IntPtr @this);

		// Token: 0x060097A3 RID: 38819
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AbortMatch_Internal(IntPtr @this);

		// Token: 0x060097A4 RID: 38820 RVA: 0x000D80C5 File Offset: 0x000D62C5
		static AGameMode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GameMode");
		}

		// Token: 0x060097A5 RID: 38821 RVA: 0x000D80D3 File Offset: 0x000D62D3
		protected AGameMode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040054D7 RID: 21719
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GameMode";

		// Token: 0x040054D8 RID: 21720
		private static IntPtr _ClassPtr;

		// Token: 0x040054D9 RID: 21721
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040054DA RID: 21722
		internal static int __PropertyOffset_MatchState;

		// Token: 0x040054DB RID: 21723
		internal static int __PropertyOffset_bDelayedStart;

		// Token: 0x040054DC RID: 21724
		internal static byte __PropertyMask_bDelayedStart;

		// Token: 0x040054DD RID: 21725
		internal static int __PropertyOffset_NumSpectators;

		// Token: 0x040054DE RID: 21726
		internal static int __PropertyOffset_NumPlayers;

		// Token: 0x040054DF RID: 21727
		internal static int __PropertyOffset_NumBots;

		// Token: 0x040054E0 RID: 21728
		internal static int __PropertyOffset_MinRespawnDelay;

		// Token: 0x040054E1 RID: 21729
		internal static int __PropertyOffset_NumTravellingPlayers;

		// Token: 0x040054E2 RID: 21730
		internal static int __PropertyOffset_EngineMessageClass;

		// Token: 0x040054E3 RID: 21731
		internal static int __PropertyOffset_InactivePlayerArray;

		// Token: 0x040054E4 RID: 21732
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<APlayerState> _InactivePlayerArray;

		// Token: 0x040054E5 RID: 21733
		internal static int __PropertyOffset_InactivePlayerStateLifeSpan;

		// Token: 0x040054E6 RID: 21734
		internal static int __PropertyOffset_MaxInactivePlayers;

		// Token: 0x040054E7 RID: 21735
		internal static int __PropertyOffset_bHandleDedicatedServerReplays;

		// Token: 0x02002CFE RID: 11518
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReadyToStartMatch_FunctionParams
		{
			// Token: 0x040166B8 RID: 91832
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02002CFF RID: 11519
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __ReadyToEndMatch_FunctionParams
		{
			// Token: 0x040166B9 RID: 91833
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02002D00 RID: 11520
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __K2_OnSetMatchState_FunctionParams
		{
			// Token: 0x040166BA RID: 91834
			[FieldOffset(0)]
			public FName NewState;
		}
	}
}
