using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001011 RID: 4113
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PlayerState")]
	[UnrealStructLayout(1312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1312)]
	public class APlayerState : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600E0C1 RID: 57537 RVA: 0x0014A84E File Offset: 0x00148A4E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APlayerState._ClassPtr;
		}

		// Token: 0x0600E0C2 RID: 57538 RVA: 0x0014A85C File Offset: 0x00148A5C
		public APlayerState() : this(BuiltinUtils.AllocNativeUObject(APlayerState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E0C3 RID: 57539 RVA: 0x0014A884 File Offset: 0x00148A84
		public APlayerState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APlayerState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170034C7 RID: 13511
		// (get) Token: 0x0600E0C4 RID: 57540 RVA: 0x0014A8B7 File Offset: 0x00148AB7
		// (set) Token: 0x0600E0C5 RID: 57541 RVA: 0x0014A8C7 File Offset: 0x00148AC7
		public unsafe float Score
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_Score);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_Score) = value;
			}
		}

		// Token: 0x170034C8 RID: 13512
		// (get) Token: 0x0600E0C6 RID: 57542 RVA: 0x0014A8D8 File Offset: 0x00148AD8
		// (set) Token: 0x0600E0C7 RID: 57543 RVA: 0x0014A8E8 File Offset: 0x00148AE8
		public unsafe int PlayerId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_PlayerId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_PlayerId) = value;
			}
		}

		// Token: 0x170034C9 RID: 13513
		// (get) Token: 0x0600E0C8 RID: 57544 RVA: 0x0014A8F9 File Offset: 0x00148AF9
		// (set) Token: 0x0600E0C9 RID: 57545 RVA: 0x0014A909 File Offset: 0x00148B09
		public unsafe byte Ping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_Ping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_Ping) = value;
			}
		}

		// Token: 0x170034CA RID: 13514
		// (get) Token: 0x0600E0CA RID: 57546 RVA: 0x0014A91A File Offset: 0x00148B1A
		// (set) Token: 0x0600E0CB RID: 57547 RVA: 0x0014A933 File Offset: 0x00148B33
		public unsafe bool bShouldUpdateReplicatedPing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_bShouldUpdateReplicatedPing) & APlayerState.__PropertyMask_bShouldUpdateReplicatedPing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerState.__PropertyOffset_bShouldUpdateReplicatedPing) = ((*(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_bShouldUpdateReplicatedPing) & ~APlayerState.__PropertyMask_bShouldUpdateReplicatedPing) | (value ? APlayerState.__PropertyMask_bShouldUpdateReplicatedPing : 0));
			}
		}

		// Token: 0x170034CB RID: 13515
		// (get) Token: 0x0600E0CC RID: 57548 RVA: 0x0014A963 File Offset: 0x00148B63
		// (set) Token: 0x0600E0CD RID: 57549 RVA: 0x0014A97C File Offset: 0x00148B7C
		public unsafe bool bIsSpectator
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_bIsSpectator) & APlayerState.__PropertyMask_bIsSpectator) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerState.__PropertyOffset_bIsSpectator) = ((*(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_bIsSpectator) & ~APlayerState.__PropertyMask_bIsSpectator) | (value ? APlayerState.__PropertyMask_bIsSpectator : 0));
			}
		}

		// Token: 0x170034CC RID: 13516
		// (get) Token: 0x0600E0CE RID: 57550 RVA: 0x0014A9AC File Offset: 0x00148BAC
		// (set) Token: 0x0600E0CF RID: 57551 RVA: 0x0014A9C5 File Offset: 0x00148BC5
		public unsafe bool bOnlySpectator
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_bOnlySpectator) & APlayerState.__PropertyMask_bOnlySpectator) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerState.__PropertyOffset_bOnlySpectator) = ((*(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_bOnlySpectator) & ~APlayerState.__PropertyMask_bOnlySpectator) | (value ? APlayerState.__PropertyMask_bOnlySpectator : 0));
			}
		}

		// Token: 0x170034CD RID: 13517
		// (get) Token: 0x0600E0D0 RID: 57552 RVA: 0x0014A9F5 File Offset: 0x00148BF5
		// (set) Token: 0x0600E0D1 RID: 57553 RVA: 0x0014AA0E File Offset: 0x00148C0E
		public unsafe bool bIsABot
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_bIsABot) & APlayerState.__PropertyMask_bIsABot) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerState.__PropertyOffset_bIsABot) = ((*(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_bIsABot) & ~APlayerState.__PropertyMask_bIsABot) | (value ? APlayerState.__PropertyMask_bIsABot : 0));
			}
		}

		// Token: 0x170034CE RID: 13518
		// (get) Token: 0x0600E0D2 RID: 57554 RVA: 0x0014AA3E File Offset: 0x00148C3E
		// (set) Token: 0x0600E0D3 RID: 57555 RVA: 0x0014AA57 File Offset: 0x00148C57
		public unsafe bool bIsInactive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_bIsInactive) & APlayerState.__PropertyMask_bIsInactive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerState.__PropertyOffset_bIsInactive) = ((*(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_bIsInactive) & ~APlayerState.__PropertyMask_bIsInactive) | (value ? APlayerState.__PropertyMask_bIsInactive : 0));
			}
		}

		// Token: 0x170034CF RID: 13519
		// (get) Token: 0x0600E0D4 RID: 57556 RVA: 0x0014AA87 File Offset: 0x00148C87
		// (set) Token: 0x0600E0D5 RID: 57557 RVA: 0x0014AAA0 File Offset: 0x00148CA0
		public unsafe bool bFromPreviousLevel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_bFromPreviousLevel) & APlayerState.__PropertyMask_bFromPreviousLevel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerState.__PropertyOffset_bFromPreviousLevel) = ((*(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_bFromPreviousLevel) & ~APlayerState.__PropertyMask_bFromPreviousLevel) | (value ? APlayerState.__PropertyMask_bFromPreviousLevel : 0));
			}
		}

		// Token: 0x170034D0 RID: 13520
		// (get) Token: 0x0600E0D6 RID: 57558 RVA: 0x0014AAD0 File Offset: 0x00148CD0
		// (set) Token: 0x0600E0D7 RID: 57559 RVA: 0x0014AAE0 File Offset: 0x00148CE0
		public unsafe int StartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_StartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_StartTime) = value;
			}
		}

		// Token: 0x170034D1 RID: 13521
		// (get) Token: 0x0600E0D8 RID: 57560 RVA: 0x0014AAF1 File Offset: 0x00148CF1
		// (set) Token: 0x0600E0D9 RID: 57561 RVA: 0x0014AB05 File Offset: 0x00148D05
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
				return *(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_EngineMessageClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_EngineMessageClass) = value;
			}
		}

		// Token: 0x170034D2 RID: 13522
		// (get) Token: 0x0600E0DA RID: 57562 RVA: 0x0014AB1A File Offset: 0x00148D1A
		// (set) Token: 0x0600E0DB RID: 57563 RVA: 0x0014AB2E File Offset: 0x00148D2E
		public unsafe string SavedNetworkAddress
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)APlayerState.__PropertyOffset_SavedNetworkAddress)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)APlayerState.__PropertyOffset_SavedNetworkAddress)), value);
			}
		}

		// Token: 0x170034D3 RID: 13523
		// (get) Token: 0x0600E0DC RID: 57564 RVA: 0x0014AB44 File Offset: 0x00148D44
		// (set) Token: 0x0600E0DD RID: 57565 RVA: 0x0014AB7D File Offset: 0x00148D7D
		public FUniqueNetIdRepl UniqueId
		{
			get
			{
				base.FastCheckIsValid();
				FUniqueNetIdRepl result;
				if ((result = this._UniqueId) == null)
				{
					result = (this._UniqueId = new FUniqueNetIdRepl(base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_UniqueId, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FUniqueNetIdRepl.StaticStruct(), base.NativePtr + (IntPtr)APlayerState.__PropertyOffset_UniqueId, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170034D4 RID: 13524
		// (get) Token: 0x0600E0DE RID: 57566 RVA: 0x0014AB9E File Offset: 0x00148D9E
		// (set) Token: 0x0600E0DF RID: 57567 RVA: 0x0014ABB2 File Offset: 0x00148DB2
		[Nullable(2)]
		public unsafe APawn PawnPrivate
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APawn>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerState.__PropertyOffset_PawnPrivate);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerState.__PropertyOffset_PawnPrivate, value);
			}
		}

		// Token: 0x170034D5 RID: 13525
		// (get) Token: 0x0600E0E0 RID: 57568 RVA: 0x0014ABC7 File Offset: 0x00148DC7
		// (set) Token: 0x0600E0E1 RID: 57569 RVA: 0x0014ABDB File Offset: 0x00148DDB
		public unsafe string PlayerNamePrivate
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)APlayerState.__PropertyOffset_PlayerNamePrivate)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)APlayerState.__PropertyOffset_PlayerNamePrivate)), value);
			}
		}

		// Token: 0x0600E0E2 RID: 57570 RVA: 0x0014ABF0 File Offset: 0x00148DF0
		[NullableContext(2)]
		public virtual void ReceiveOverrideWith(APlayerState OldPlayerState)
		{
			APlayerState.__ReceiveOverrideWith_Internal(base.NativePtr, (OldPlayerState != null) ? OldPlayerState.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600E0E3 RID: 57571 RVA: 0x0014AC0D File Offset: 0x00148E0D
		[NullableContext(2)]
		public virtual void ReceiveCopyProperties(APlayerState NewPlayerState)
		{
			APlayerState.__ReceiveCopyProperties_Internal(base.NativePtr, (NewPlayerState != null) ? NewPlayerState.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600E0E4 RID: 57572 RVA: 0x0014AC2A File Offset: 0x00148E2A
		public void OnRep_UniqueId()
		{
			APlayerState.__OnRep_UniqueId_Internal(base.NativePtr);
		}

		// Token: 0x0600E0E5 RID: 57573 RVA: 0x0014AC37 File Offset: 0x00148E37
		public void OnRep_Score()
		{
			APlayerState.__OnRep_Score_Internal(base.NativePtr);
		}

		// Token: 0x0600E0E6 RID: 57574 RVA: 0x0014AC44 File Offset: 0x00148E44
		public void OnRep_PlayerName()
		{
			APlayerState.__OnRep_PlayerName_Internal(base.NativePtr);
		}

		// Token: 0x0600E0E7 RID: 57575 RVA: 0x0014AC51 File Offset: 0x00148E51
		public void OnRep_PlayerId()
		{
			APlayerState.__OnRep_PlayerId_Internal(base.NativePtr);
		}

		// Token: 0x0600E0E8 RID: 57576 RVA: 0x0014AC5E File Offset: 0x00148E5E
		public void OnRep_bIsInactive()
		{
			APlayerState.__OnRep_bIsInactive_Internal(base.NativePtr);
		}

		// Token: 0x0600E0E9 RID: 57577 RVA: 0x0014AC6B File Offset: 0x00148E6B
		public string GetPlayerName()
		{
			return FString.ToStringAndDeleteNativePtr(APlayerState.__GetPlayerName_Internal(base.NativePtr));
		}

		// Token: 0x0600E0EA RID: 57578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveOverrideWith_Internal(IntPtr @this, IntPtr OldPlayerState);

		// Token: 0x0600E0EB RID: 57579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveCopyProperties_Internal(IntPtr @this, IntPtr NewPlayerState);

		// Token: 0x0600E0EC RID: 57580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_UniqueId_Internal(IntPtr @this);

		// Token: 0x0600E0ED RID: 57581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_Score_Internal(IntPtr @this);

		// Token: 0x0600E0EE RID: 57582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_PlayerName_Internal(IntPtr @this);

		// Token: 0x0600E0EF RID: 57583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_PlayerId_Internal(IntPtr @this);

		// Token: 0x0600E0F0 RID: 57584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_bIsInactive_Internal(IntPtr @this);

		// Token: 0x0600E0F1 RID: 57585
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetPlayerName_Internal(IntPtr @this);

		// Token: 0x0600E0F2 RID: 57586 RVA: 0x0014AC7D File Offset: 0x00148E7D
		static APlayerState()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlayerState");
		}

		// Token: 0x0600E0F3 RID: 57587 RVA: 0x0014AC8B File Offset: 0x00148E8B
		protected APlayerState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040078BE RID: 30910
		public new const string __ObjectPath = "/Script/Engine.PlayerState";

		// Token: 0x040078BF RID: 30911
		private static IntPtr _ClassPtr;

		// Token: 0x040078C0 RID: 30912
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040078C1 RID: 30913
		internal static int __PropertyOffset_Score;

		// Token: 0x040078C2 RID: 30914
		internal static int __PropertyOffset_PlayerId;

		// Token: 0x040078C3 RID: 30915
		internal static int __PropertyOffset_Ping;

		// Token: 0x040078C4 RID: 30916
		internal static int __PropertyOffset_bShouldUpdateReplicatedPing;

		// Token: 0x040078C5 RID: 30917
		internal static byte __PropertyMask_bShouldUpdateReplicatedPing;

		// Token: 0x040078C6 RID: 30918
		internal static int __PropertyOffset_bIsSpectator;

		// Token: 0x040078C7 RID: 30919
		internal static byte __PropertyMask_bIsSpectator;

		// Token: 0x040078C8 RID: 30920
		internal static int __PropertyOffset_bOnlySpectator;

		// Token: 0x040078C9 RID: 30921
		internal static byte __PropertyMask_bOnlySpectator;

		// Token: 0x040078CA RID: 30922
		internal static int __PropertyOffset_bIsABot;

		// Token: 0x040078CB RID: 30923
		internal static byte __PropertyMask_bIsABot;

		// Token: 0x040078CC RID: 30924
		internal static int __PropertyOffset_bIsInactive;

		// Token: 0x040078CD RID: 30925
		internal static byte __PropertyMask_bIsInactive;

		// Token: 0x040078CE RID: 30926
		internal static int __PropertyOffset_bFromPreviousLevel;

		// Token: 0x040078CF RID: 30927
		internal static byte __PropertyMask_bFromPreviousLevel;

		// Token: 0x040078D0 RID: 30928
		internal static int __PropertyOffset_StartTime;

		// Token: 0x040078D1 RID: 30929
		internal static int __PropertyOffset_EngineMessageClass;

		// Token: 0x040078D2 RID: 30930
		internal static int __PropertyOffset_SavedNetworkAddress;

		// Token: 0x040078D3 RID: 30931
		internal static int __PropertyOffset_UniqueId;

		// Token: 0x040078D4 RID: 30932
		[Nullable(2)]
		private FUniqueNetIdRepl _UniqueId;

		// Token: 0x040078D5 RID: 30933
		internal static int __PropertyOffset_PawnPrivate;

		// Token: 0x040078D6 RID: 30934
		internal static int __PropertyOffset_PlayerNamePrivate;

		// Token: 0x02002DDB RID: 11739
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveOverrideWith_FunctionParams
		{
			// Token: 0x0401681E RID: 92190
			[FieldOffset(0)]
			public IntPtr OldPlayerState;
		}

		// Token: 0x02002DDC RID: 11740
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ReceiveCopyProperties_FunctionParams
		{
			// Token: 0x0401681F RID: 92191
			[FieldOffset(0)]
			public IntPtr NewPlayerState;
		}
	}
}
