using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200124B RID: 4683
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldContext")]
	[UnrealStructLayout(656, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 656)]
	public class FWorldContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060113A8 RID: 70568 RVA: 0x0019462A File Offset: 0x0019282A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldContext._ScriptStructPtr != 0) ? FWorldContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WorldContext", ref FWorldContext._ScriptStructPtr);
		}

		// Token: 0x17004334 RID: 17204
		// (get) Token: 0x060113A9 RID: 70569 RVA: 0x00194650 File Offset: 0x00192850
		// (set) Token: 0x060113AA RID: 70570 RVA: 0x00194693 File Offset: 0x00192893
		public FURL LastURL
		{
			get
			{
				base.FastCheckIsValid();
				FURL result;
				if ((result = this._LastURL) == null)
				{
					result = (this._LastURL = new FURL(base.NativePtr + (IntPtr)FWorldContext.__PropertyOffset_LastURL, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FURL.StaticStruct(), base.NativePtr + (IntPtr)FWorldContext.__PropertyOffset_LastURL, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004335 RID: 17205
		// (get) Token: 0x060113AB RID: 70571 RVA: 0x001946B4 File Offset: 0x001928B4
		// (set) Token: 0x060113AC RID: 70572 RVA: 0x001946F7 File Offset: 0x001928F7
		public FURL LastRemoteURL
		{
			get
			{
				base.FastCheckIsValid();
				FURL result;
				if ((result = this._LastRemoteURL) == null)
				{
					result = (this._LastRemoteURL = new FURL(base.NativePtr + (IntPtr)FWorldContext.__PropertyOffset_LastRemoteURL, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FURL.StaticStruct(), base.NativePtr + (IntPtr)FWorldContext.__PropertyOffset_LastRemoteURL, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004336 RID: 17206
		// (get) Token: 0x060113AD RID: 70573 RVA: 0x00194718 File Offset: 0x00192918
		// (set) Token: 0x060113AE RID: 70574 RVA: 0x0019472C File Offset: 0x0019292C
		[Nullable(2)]
		public unsafe UPendingNetGame PendingNetGame
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPendingNetGame>(base.NativePtr / (IntPtr)sizeof(void*) + FWorldContext.__PropertyOffset_PendingNetGame);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FWorldContext.__PropertyOffset_PendingNetGame, value);
			}
		}

		// Token: 0x17004337 RID: 17207
		// (get) Token: 0x060113AF RID: 70575 RVA: 0x00194744 File Offset: 0x00192944
		// (set) Token: 0x060113B0 RID: 70576 RVA: 0x00194787 File Offset: 0x00192987
		public TArray<FFullyLoadedPackagesInfo> PackagesToFullyLoad
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFullyLoadedPackagesInfo> result;
				if ((result = this._PackagesToFullyLoad) == null)
				{
					result = (this._PackagesToFullyLoad = new TArray<FFullyLoadedPackagesInfo>(base.NativePtr + (IntPtr)FWorldContext.__PropertyOffset_PackagesToFullyLoad, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PackagesToFullyLoad.CopyAssign(value);
			}
		}

		// Token: 0x17004338 RID: 17208
		// (get) Token: 0x060113B1 RID: 70577 RVA: 0x00194798 File Offset: 0x00192998
		// (set) Token: 0x060113B2 RID: 70578 RVA: 0x001947DB File Offset: 0x001929DB
		public TArray<ULevel> LoadedLevelsForPendingMapChange
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULevel> result;
				if ((result = this._LoadedLevelsForPendingMapChange) == null)
				{
					result = (this._LoadedLevelsForPendingMapChange = new TArray<ULevel>(base.NativePtr + (IntPtr)FWorldContext.__PropertyOffset_LoadedLevelsForPendingMapChange, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LoadedLevelsForPendingMapChange.CopyAssign(value);
			}
		}

		// Token: 0x17004339 RID: 17209
		// (get) Token: 0x060113B3 RID: 70579 RVA: 0x001947EC File Offset: 0x001929EC
		// (set) Token: 0x060113B4 RID: 70580 RVA: 0x0019482F File Offset: 0x00192A2F
		public TArray<UObjectReferencer> ObjectReferencers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObjectReferencer> result;
				if ((result = this._ObjectReferencers) == null)
				{
					result = (this._ObjectReferencers = new TArray<UObjectReferencer>(base.NativePtr + (IntPtr)FWorldContext.__PropertyOffset_ObjectReferencers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ObjectReferencers.CopyAssign(value);
			}
		}

		// Token: 0x1700433A RID: 17210
		// (get) Token: 0x060113B5 RID: 70581 RVA: 0x00194840 File Offset: 0x00192A40
		// (set) Token: 0x060113B6 RID: 70582 RVA: 0x00194883 File Offset: 0x00192A83
		public TArray<FLevelStreamingStatus> PendingLevelStreamingStatusUpdates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLevelStreamingStatus> result;
				if ((result = this._PendingLevelStreamingStatusUpdates) == null)
				{
					result = (this._PendingLevelStreamingStatusUpdates = new TArray<FLevelStreamingStatus>(base.NativePtr + (IntPtr)FWorldContext.__PropertyOffset_PendingLevelStreamingStatusUpdates, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PendingLevelStreamingStatusUpdates.CopyAssign(value);
			}
		}

		// Token: 0x1700433B RID: 17211
		// (get) Token: 0x060113B7 RID: 70583 RVA: 0x00194891 File Offset: 0x00192A91
		// (set) Token: 0x060113B8 RID: 70584 RVA: 0x001948A5 File Offset: 0x00192AA5
		[Nullable(2)]
		public unsafe UGameViewportClient GameViewport
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameViewportClient>(base.NativePtr / (IntPtr)sizeof(void*) + FWorldContext.__PropertyOffset_GameViewport);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FWorldContext.__PropertyOffset_GameViewport, value);
			}
		}

		// Token: 0x1700433C RID: 17212
		// (get) Token: 0x060113B9 RID: 70585 RVA: 0x001948BA File Offset: 0x00192ABA
		// (set) Token: 0x060113BA RID: 70586 RVA: 0x001948CE File Offset: 0x00192ACE
		[Nullable(2)]
		public unsafe UGameInstance OwningGameInstance
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameInstance>(base.NativePtr / (IntPtr)sizeof(void*) + FWorldContext.__PropertyOffset_OwningGameInstance);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FWorldContext.__PropertyOffset_OwningGameInstance, value);
			}
		}

		// Token: 0x1700433D RID: 17213
		// (get) Token: 0x060113BB RID: 70587 RVA: 0x001948E4 File Offset: 0x00192AE4
		// (set) Token: 0x060113BC RID: 70588 RVA: 0x00194927 File Offset: 0x00192B27
		public TArray<FNamedNetDriver> ActiveNetDrivers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNamedNetDriver> result;
				if ((result = this._ActiveNetDrivers) == null)
				{
					result = (this._ActiveNetDrivers = new TArray<FNamedNetDriver>(base.NativePtr + (IntPtr)FWorldContext.__PropertyOffset_ActiveNetDrivers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ActiveNetDrivers.CopyAssign(value);
			}
		}

		// Token: 0x060113BD RID: 70589 RVA: 0x00194935 File Offset: 0x00192B35
		public FWorldContext()
		{
		}

		// Token: 0x060113BE RID: 70590 RVA: 0x00194940 File Offset: 0x00192B40
		public FWorldContext(FURL LastURL, FURL LastRemoteURL, UPendingNetGame PendingNetGame, TArray<FFullyLoadedPackagesInfo> PackagesToFullyLoad, TArray<ULevel> LoadedLevelsForPendingMapChange, TArray<UObjectReferencer> ObjectReferencers, TArray<FLevelStreamingStatus> PendingLevelStreamingStatusUpdates, UGameViewportClient GameViewport, UGameInstance OwningGameInstance, TArray<FNamedNetDriver> ActiveNetDrivers)
		{
			this.LastURL = LastURL;
			this.LastRemoteURL = LastRemoteURL;
			this.PendingNetGame = PendingNetGame;
			this.PackagesToFullyLoad = PackagesToFullyLoad;
			this.LoadedLevelsForPendingMapChange = LoadedLevelsForPendingMapChange;
			this.ObjectReferencers = ObjectReferencers;
			this.PendingLevelStreamingStatusUpdates = PendingLevelStreamingStatusUpdates;
			this.GameViewport = GameViewport;
			this.OwningGameInstance = OwningGameInstance;
			this.ActiveNetDrivers = ActiveNetDrivers;
		}

		// Token: 0x060113BF RID: 70591 RVA: 0x001949A0 File Offset: 0x00192BA0
		protected override IntPtr GetUStructPtr()
		{
			return FWorldContext.StaticStruct();
		}

		// Token: 0x060113C0 RID: 70592 RVA: 0x001949AC File Offset: 0x00192BAC
		[NullableContext(2)]
		public FWorldContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060113C1 RID: 70593 RVA: 0x001949B6 File Offset: 0x00192BB6
		public FWorldContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060113C2 RID: 70594 RVA: 0x001949C1 File Offset: 0x00192BC1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldContext(Pointer, false, true);
		}

		// Token: 0x060113C3 RID: 70595 RVA: 0x001949CB File Offset: 0x00192BCB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldContext(Pointer, MemoryOwner);
		}

		// Token: 0x04009368 RID: 37736
		public const string __ObjectPath = "/Script/Engine.WorldContext";

		// Token: 0x04009369 RID: 37737
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400936A RID: 37738
		internal static int __PropertyOffset_LastURL;

		// Token: 0x0400936B RID: 37739
		[Nullable(2)]
		private FURL _LastURL;

		// Token: 0x0400936C RID: 37740
		internal static int __PropertyOffset_LastRemoteURL;

		// Token: 0x0400936D RID: 37741
		[Nullable(2)]
		private FURL _LastRemoteURL;

		// Token: 0x0400936E RID: 37742
		internal static int __PropertyOffset_PendingNetGame;

		// Token: 0x0400936F RID: 37743
		internal static int __PropertyOffset_PackagesToFullyLoad;

		// Token: 0x04009370 RID: 37744
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFullyLoadedPackagesInfo> _PackagesToFullyLoad;

		// Token: 0x04009371 RID: 37745
		internal static int __PropertyOffset_LoadedLevelsForPendingMapChange;

		// Token: 0x04009372 RID: 37746
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULevel> _LoadedLevelsForPendingMapChange;

		// Token: 0x04009373 RID: 37747
		internal static int __PropertyOffset_ObjectReferencers;

		// Token: 0x04009374 RID: 37748
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObjectReferencer> _ObjectReferencers;

		// Token: 0x04009375 RID: 37749
		internal static int __PropertyOffset_PendingLevelStreamingStatusUpdates;

		// Token: 0x04009376 RID: 37750
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLevelStreamingStatus> _PendingLevelStreamingStatusUpdates;

		// Token: 0x04009377 RID: 37751
		internal static int __PropertyOffset_GameViewport;

		// Token: 0x04009378 RID: 37752
		internal static int __PropertyOffset_OwningGameInstance;

		// Token: 0x04009379 RID: 37753
		internal static int __PropertyOffset_ActiveNetDrivers;

		// Token: 0x0400937A RID: 37754
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNamedNetDriver> _ActiveNetDrivers;
	}
}
