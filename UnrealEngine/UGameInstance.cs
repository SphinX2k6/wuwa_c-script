using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BFA RID: 3066
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.GameInstance")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UGameInstance : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009752 RID: 38738 RVA: 0x000D7B69 File Offset: 0x000D5D69
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameInstance._ClassPtr;
		}

		// Token: 0x06009753 RID: 38739 RVA: 0x000D7B78 File Offset: 0x000D5D78
		public UGameInstance() : this(BuiltinUtils.AllocNativeUObject(UGameInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009754 RID: 38740 RVA: 0x000D7BA0 File Offset: 0x000D5DA0
		public UGameInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002445 RID: 9285
		// (get) Token: 0x06009755 RID: 38741 RVA: 0x000D7BD4 File Offset: 0x000D5DD4
		// (set) Token: 0x06009756 RID: 38742 RVA: 0x000D7C0D File Offset: 0x000D5E0D
		public TArray<ULocalPlayer> LocalPlayers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULocalPlayer> result;
				if ((result = this._LocalPlayers) == null)
				{
					result = (this._LocalPlayers = new TArray<ULocalPlayer>(base.NativePtr + (IntPtr)UGameInstance.__PropertyOffset_LocalPlayers, this));
				}
				return result;
			}
			set
			{
				this.LocalPlayers.CopyAssign(value);
			}
		}

		// Token: 0x17002446 RID: 9286
		// (get) Token: 0x06009757 RID: 38743 RVA: 0x000D7C1B File Offset: 0x000D5E1B
		// (set) Token: 0x06009758 RID: 38744 RVA: 0x000D7C2F File Offset: 0x000D5E2F
		[Nullable(2)]
		public unsafe UOnlineSession OnlineSession
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UOnlineSession>(base.NativePtr / (IntPtr)sizeof(void*) + UGameInstance.__PropertyOffset_OnlineSession);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGameInstance.__PropertyOffset_OnlineSession, value);
			}
		}

		// Token: 0x17002447 RID: 9287
		// (get) Token: 0x06009759 RID: 38745 RVA: 0x000D7C44 File Offset: 0x000D5E44
		// (set) Token: 0x0600975A RID: 38746 RVA: 0x000D7C7D File Offset: 0x000D5E7D
		public TArray<UObject> ReferencedObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ReferencedObjects) == null)
				{
					result = (this._ReferencedObjects = new TArray<UObject>(base.NativePtr + (IntPtr)UGameInstance.__PropertyOffset_ReferencedObjects, this));
				}
				return result;
			}
			set
			{
				this.ReferencedObjects.CopyAssign(value);
			}
		}

		// Token: 0x17002448 RID: 9288
		// (get) Token: 0x0600975B RID: 38747 RVA: 0x000D7C8C File Offset: 0x000D5E8C
		// (set) Token: 0x0600975C RID: 38748 RVA: 0x000D7CC5 File Offset: 0x000D5EC5
		public FOnPawnControllerChanged OnPawnControllerChangedDelegates
		{
			get
			{
				base.FastCheckIsValid();
				FOnPawnControllerChanged result;
				if ((result = this._OnPawnControllerChangedDelegates) == null)
				{
					result = (this._OnPawnControllerChangedDelegates = new FOnPawnControllerChanged(base.NativePtr + (IntPtr)UGameInstance.__PropertyOffset_OnPawnControllerChangedDelegates, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UGameInstance.__PropertyOffset_OnPawnControllerChangedDelegates, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600975D RID: 38749 RVA: 0x000D7CE6 File Offset: 0x000D5EE6
		public virtual void ReceiveShutdown()
		{
			UGameInstance.__ReceiveShutdown_Internal(base.NativePtr);
		}

		// Token: 0x0600975E RID: 38750 RVA: 0x000D7CF3 File Offset: 0x000D5EF3
		public virtual void ReceiveInit()
		{
			UGameInstance.__ReceiveInit_Internal(base.NativePtr);
		}

		// Token: 0x0600975F RID: 38751 RVA: 0x000D7D00 File Offset: 0x000D5F00
		public virtual void HandleTravelError(ETravelFailure FailureType)
		{
			UGameInstance.__HandleTravelError_Internal(base.NativePtr, FailureType);
		}

		// Token: 0x06009760 RID: 38752 RVA: 0x000D7D13 File Offset: 0x000D5F13
		public virtual void HandleNetworkError(ENetworkFailure FailureType, bool bIsServer)
		{
			UGameInstance.__HandleNetworkError_Internal(base.NativePtr, FailureType, bIsServer);
		}

		// Token: 0x06009761 RID: 38753 RVA: 0x000D7D27 File Offset: 0x000D5F27
		public void DebugRemovePlayer(int ControllerId)
		{
			UGameInstance.__DebugRemovePlayer_Internal(base.NativePtr, ControllerId);
		}

		// Token: 0x06009762 RID: 38754 RVA: 0x000D7D35 File Offset: 0x000D5F35
		public void DebugCreatePlayer(int ControllerId)
		{
			UGameInstance.__DebugCreatePlayer_Internal(base.NativePtr, ControllerId);
		}

		// Token: 0x06009763 RID: 38755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveShutdown_Internal(IntPtr @this);

		// Token: 0x06009764 RID: 38756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceiveInit_Internal(IntPtr @this);

		// Token: 0x06009765 RID: 38757
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleTravelError_Internal(IntPtr @this, TEnumAsByte<ETravelFailure> FailureType);

		// Token: 0x06009766 RID: 38758
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleNetworkError_Internal(IntPtr @this, TEnumAsByte<ENetworkFailure> FailureType, bool bIsServer);

		// Token: 0x06009767 RID: 38759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugRemovePlayer_Internal(IntPtr @this, int ControllerId);

		// Token: 0x06009768 RID: 38760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugCreatePlayer_Internal(IntPtr @this, int ControllerId);

		// Token: 0x06009769 RID: 38761 RVA: 0x000D7D43 File Offset: 0x000D5F43
		static UGameInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GameInstance");
		}

		// Token: 0x0600976A RID: 38762 RVA: 0x000D7D51 File Offset: 0x000D5F51
		protected UGameInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040054CA RID: 21706
		public new const string __ObjectPath = "/Script/Engine.GameInstance";

		// Token: 0x040054CB RID: 21707
		private static IntPtr _ClassPtr;

		// Token: 0x040054CC RID: 21708
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040054CD RID: 21709
		internal static int __PropertyOffset_LocalPlayers;

		// Token: 0x040054CE RID: 21710
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULocalPlayer> _LocalPlayers;

		// Token: 0x040054CF RID: 21711
		internal static int __PropertyOffset_OnlineSession;

		// Token: 0x040054D0 RID: 21712
		internal static int __PropertyOffset_ReferencedObjects;

		// Token: 0x040054D1 RID: 21713
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ReferencedObjects;

		// Token: 0x040054D2 RID: 21714
		internal static int __PropertyOffset_OnPawnControllerChangedDelegates;

		// Token: 0x040054D3 RID: 21715
		[Nullable(2)]
		private FOnPawnControllerChanged _OnPawnControllerChangedDelegates;

		// Token: 0x02002CFC RID: 11516
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __HandleTravelError_FunctionParams
		{
			// Token: 0x040166B5 RID: 91829
			[FieldOffset(0)]
			public TEnumAsByte<ETravelFailure> FailureType;
		}

		// Token: 0x02002CFD RID: 11517
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __HandleNetworkError_FunctionParams
		{
			// Token: 0x040166B6 RID: 91830
			[FieldOffset(0)]
			public TEnumAsByte<ENetworkFailure> FailureType;

			// Token: 0x040166B7 RID: 91831
			[FieldOffset(1)]
			public bool bIsServer;
		}
	}
}
