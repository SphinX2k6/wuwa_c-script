using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200141F RID: 5151
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCollectionEngine.ChaosDestructionListener")]
	[UnrealStructLayout(1120, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class UChaosDestructionListener : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012CBA RID: 76986 RVA: 0x001BA5A9 File Offset: 0x001B87A9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UChaosDestructionListener._ClassPtr;
		}

		// Token: 0x06012CBB RID: 76987 RVA: 0x001BA5B8 File Offset: 0x001B87B8
		public UChaosDestructionListener() : this(BuiltinUtils.AllocNativeUObject(UChaosDestructionListener.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012CBC RID: 76988 RVA: 0x001BA5E0 File Offset: 0x001B87E0
		public UChaosDestructionListener(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UChaosDestructionListener.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170048CD RID: 18637
		// (get) Token: 0x06012CBD RID: 76989 RVA: 0x001BA613 File Offset: 0x001B8813
		// (set) Token: 0x06012CBE RID: 76990 RVA: 0x001BA62C File Offset: 0x001B882C
		public unsafe bool bIsCollisionEventListeningEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_bIsCollisionEventListeningEnabled) & UChaosDestructionListener.__PropertyMask_bIsCollisionEventListeningEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_bIsCollisionEventListeningEnabled) = ((*(base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_bIsCollisionEventListeningEnabled) & ~UChaosDestructionListener.__PropertyMask_bIsCollisionEventListeningEnabled) | (value ? UChaosDestructionListener.__PropertyMask_bIsCollisionEventListeningEnabled : 0));
			}
		}

		// Token: 0x170048CE RID: 18638
		// (get) Token: 0x06012CBF RID: 76991 RVA: 0x001BA65C File Offset: 0x001B885C
		// (set) Token: 0x06012CC0 RID: 76992 RVA: 0x001BA675 File Offset: 0x001B8875
		public unsafe bool bIsBreakingEventListeningEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_bIsBreakingEventListeningEnabled) & UChaosDestructionListener.__PropertyMask_bIsBreakingEventListeningEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_bIsBreakingEventListeningEnabled) = ((*(base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_bIsBreakingEventListeningEnabled) & ~UChaosDestructionListener.__PropertyMask_bIsBreakingEventListeningEnabled) | (value ? UChaosDestructionListener.__PropertyMask_bIsBreakingEventListeningEnabled : 0));
			}
		}

		// Token: 0x170048CF RID: 18639
		// (get) Token: 0x06012CC1 RID: 76993 RVA: 0x001BA6A5 File Offset: 0x001B88A5
		// (set) Token: 0x06012CC2 RID: 76994 RVA: 0x001BA6BE File Offset: 0x001B88BE
		public unsafe bool bIsTrailingEventListeningEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_bIsTrailingEventListeningEnabled) & UChaosDestructionListener.__PropertyMask_bIsTrailingEventListeningEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_bIsTrailingEventListeningEnabled) = ((*(base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_bIsTrailingEventListeningEnabled) & ~UChaosDestructionListener.__PropertyMask_bIsTrailingEventListeningEnabled) | (value ? UChaosDestructionListener.__PropertyMask_bIsTrailingEventListeningEnabled : 0));
			}
		}

		// Token: 0x170048D0 RID: 18640
		// (get) Token: 0x06012CC3 RID: 76995 RVA: 0x001BA6F0 File Offset: 0x001B88F0
		// (set) Token: 0x06012CC4 RID: 76996 RVA: 0x001BA729 File Offset: 0x001B8929
		public FChaosCollisionEventRequestSettings CollisionEventRequestSettings
		{
			get
			{
				base.FastCheckIsValid();
				FChaosCollisionEventRequestSettings result;
				if ((result = this._CollisionEventRequestSettings) == null)
				{
					result = (this._CollisionEventRequestSettings = new FChaosCollisionEventRequestSettings(base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_CollisionEventRequestSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FChaosCollisionEventRequestSettings.StaticStruct(), base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_CollisionEventRequestSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170048D1 RID: 18641
		// (get) Token: 0x06012CC5 RID: 76997 RVA: 0x001BA74C File Offset: 0x001B894C
		// (set) Token: 0x06012CC6 RID: 76998 RVA: 0x001BA785 File Offset: 0x001B8985
		public FChaosBreakingEventRequestSettings BreakingEventRequestSettings
		{
			get
			{
				base.FastCheckIsValid();
				FChaosBreakingEventRequestSettings result;
				if ((result = this._BreakingEventRequestSettings) == null)
				{
					result = (this._BreakingEventRequestSettings = new FChaosBreakingEventRequestSettings(base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_BreakingEventRequestSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FChaosBreakingEventRequestSettings.StaticStruct(), base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_BreakingEventRequestSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170048D2 RID: 18642
		// (get) Token: 0x06012CC7 RID: 76999 RVA: 0x001BA7A8 File Offset: 0x001B89A8
		// (set) Token: 0x06012CC8 RID: 77000 RVA: 0x001BA7E1 File Offset: 0x001B89E1
		public FChaosTrailingEventRequestSettings TrailingEventRequestSettings
		{
			get
			{
				base.FastCheckIsValid();
				FChaosTrailingEventRequestSettings result;
				if ((result = this._TrailingEventRequestSettings) == null)
				{
					result = (this._TrailingEventRequestSettings = new FChaosTrailingEventRequestSettings(base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_TrailingEventRequestSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FChaosTrailingEventRequestSettings.StaticStruct(), base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_TrailingEventRequestSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170048D3 RID: 18643
		// (get) Token: 0x06012CC9 RID: 77001 RVA: 0x001BA804 File Offset: 0x001B8A04
		// (set) Token: 0x06012CCA RID: 77002 RVA: 0x001BA83D File Offset: 0x001B8A3D
		public TSet<AChaosSolverActor> ChaosSolverActors
		{
			get
			{
				base.FastCheckIsValid();
				TSet<AChaosSolverActor> result;
				if ((result = this._ChaosSolverActors) == null)
				{
					result = (this._ChaosSolverActors = new TSet<AChaosSolverActor>(base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_ChaosSolverActors, this));
				}
				return result;
			}
			set
			{
				this.ChaosSolverActors.CopyAssign(value);
			}
		}

		// Token: 0x170048D4 RID: 18644
		// (get) Token: 0x06012CCB RID: 77003 RVA: 0x001BA84C File Offset: 0x001B8A4C
		// (set) Token: 0x06012CCC RID: 77004 RVA: 0x001BA885 File Offset: 0x001B8A85
		public TSet<AGeometryCollectionActor> GeometryCollectionActors
		{
			get
			{
				base.FastCheckIsValid();
				TSet<AGeometryCollectionActor> result;
				if ((result = this._GeometryCollectionActors) == null)
				{
					result = (this._GeometryCollectionActors = new TSet<AGeometryCollectionActor>(base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_GeometryCollectionActors, this));
				}
				return result;
			}
			set
			{
				this.GeometryCollectionActors.CopyAssign(value);
			}
		}

		// Token: 0x170048D5 RID: 18645
		// (get) Token: 0x06012CCD RID: 77005 RVA: 0x001BA894 File Offset: 0x001B8A94
		// (set) Token: 0x06012CCE RID: 77006 RVA: 0x001BA8CD File Offset: 0x001B8ACD
		public FOnChaosCollisionEvents OnCollisionEvents
		{
			get
			{
				base.FastCheckIsValid();
				FOnChaosCollisionEvents result;
				if ((result = this._OnCollisionEvents) == null)
				{
					result = (this._OnCollisionEvents = new FOnChaosCollisionEvents(base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_OnCollisionEvents, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_OnCollisionEvents, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170048D6 RID: 18646
		// (get) Token: 0x06012CCF RID: 77007 RVA: 0x001BA8F0 File Offset: 0x001B8AF0
		// (set) Token: 0x06012CD0 RID: 77008 RVA: 0x001BA929 File Offset: 0x001B8B29
		public FOnChaosBreakingEvents OnBreakingEvents
		{
			get
			{
				base.FastCheckIsValid();
				FOnChaosBreakingEvents result;
				if ((result = this._OnBreakingEvents) == null)
				{
					result = (this._OnBreakingEvents = new FOnChaosBreakingEvents(base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_OnBreakingEvents, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_OnBreakingEvents, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170048D7 RID: 18647
		// (get) Token: 0x06012CD1 RID: 77009 RVA: 0x001BA94C File Offset: 0x001B8B4C
		// (set) Token: 0x06012CD2 RID: 77010 RVA: 0x001BA985 File Offset: 0x001B8B85
		public FOnChaosTrailingEvents OnTrailingEvents
		{
			get
			{
				base.FastCheckIsValid();
				FOnChaosTrailingEvents result;
				if ((result = this._OnTrailingEvents) == null)
				{
					result = (this._OnTrailingEvents = new FOnChaosTrailingEvents(base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_OnTrailingEvents, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UChaosDestructionListener.__PropertyOffset_OnTrailingEvents, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06012CD3 RID: 77011 RVA: 0x001BA9A6 File Offset: 0x001B8BA6
		public void SortTrailingEvents([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FChaosTrailingEventData> TrailingEvents, EChaosTrailingSortMethod SortMethod)
		{
			UChaosDestructionListener.__SortTrailingEvents_Internal(base.NativePtr, (TrailingEvents ?? new TArray<FChaosTrailingEventData>()).NativePtr, SortMethod);
		}

		// Token: 0x06012CD4 RID: 77012 RVA: 0x001BA9C4 File Offset: 0x001B8BC4
		public void SortCollisionEvents([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FChaosCollisionEventData> CollisionEvents, EChaosCollisionSortMethod SortMethod)
		{
			UChaosDestructionListener.__SortCollisionEvents_Internal(base.NativePtr, (CollisionEvents ?? new TArray<FChaosCollisionEventData>()).NativePtr, SortMethod);
		}

		// Token: 0x06012CD5 RID: 77013 RVA: 0x001BA9E2 File Offset: 0x001B8BE2
		public void SortBreakingEvents([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FChaosBreakingEventData> BreakingEvents, EChaosBreakingSortMethod SortMethod)
		{
			UChaosDestructionListener.__SortBreakingEvents_Internal(base.NativePtr, (BreakingEvents ?? new TArray<FChaosBreakingEventData>()).NativePtr, SortMethod);
		}

		// Token: 0x06012CD6 RID: 77014 RVA: 0x001BAA00 File Offset: 0x001B8C00
		[NullableContext(2)]
		public void SetTrailingEventRequestSettings(in FChaosTrailingEventRequestSettings InSettings)
		{
			UChaosDestructionListener.__SetTrailingEventRequestSettings_Internal(base.NativePtr, (InSettings ?? new FChaosTrailingEventRequestSettings()).NativePtr);
		}

		// Token: 0x06012CD7 RID: 77015 RVA: 0x001BAA1D File Offset: 0x001B8C1D
		public void SetTrailingEventEnabled(bool bIsEnabled)
		{
			UChaosDestructionListener.__SetTrailingEventEnabled_Internal(base.NativePtr, bIsEnabled);
		}

		// Token: 0x06012CD8 RID: 77016 RVA: 0x001BAA2B File Offset: 0x001B8C2B
		[NullableContext(2)]
		public void SetCollisionEventRequestSettings(in FChaosCollisionEventRequestSettings InSettings)
		{
			UChaosDestructionListener.__SetCollisionEventRequestSettings_Internal(base.NativePtr, (InSettings ?? new FChaosCollisionEventRequestSettings()).NativePtr);
		}

		// Token: 0x06012CD9 RID: 77017 RVA: 0x001BAA48 File Offset: 0x001B8C48
		public void SetCollisionEventEnabled(bool bIsEnabled)
		{
			UChaosDestructionListener.__SetCollisionEventEnabled_Internal(base.NativePtr, bIsEnabled);
		}

		// Token: 0x06012CDA RID: 77018 RVA: 0x001BAA56 File Offset: 0x001B8C56
		[NullableContext(2)]
		public void SetBreakingEventRequestSettings(in FChaosBreakingEventRequestSettings InSettings)
		{
			UChaosDestructionListener.__SetBreakingEventRequestSettings_Internal(base.NativePtr, (InSettings ?? new FChaosBreakingEventRequestSettings()).NativePtr);
		}

		// Token: 0x06012CDB RID: 77019 RVA: 0x001BAA73 File Offset: 0x001B8C73
		public void SetBreakingEventEnabled(bool bIsEnabled)
		{
			UChaosDestructionListener.__SetBreakingEventEnabled_Internal(base.NativePtr, bIsEnabled);
		}

		// Token: 0x06012CDC RID: 77020 RVA: 0x001BAA81 File Offset: 0x001B8C81
		[NullableContext(2)]
		public void RemoveGeometryCollectionActor(AGeometryCollectionActor GeometryCollectionActor)
		{
			UChaosDestructionListener.__RemoveGeometryCollectionActor_Internal(base.NativePtr, (GeometryCollectionActor != null) ? GeometryCollectionActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06012CDD RID: 77021 RVA: 0x001BAA9E File Offset: 0x001B8C9E
		[NullableContext(2)]
		public void RemoveChaosSolverActor(AChaosSolverActor ChaosSolverActor)
		{
			UChaosDestructionListener.__RemoveChaosSolverActor_Internal(base.NativePtr, (ChaosSolverActor != null) ? ChaosSolverActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06012CDE RID: 77022 RVA: 0x001BAABB File Offset: 0x001B8CBB
		public bool IsEventListening()
		{
			return UChaosDestructionListener.__IsEventListening_Internal(base.NativePtr);
		}

		// Token: 0x06012CDF RID: 77023 RVA: 0x001BAAC8 File Offset: 0x001B8CC8
		[NullableContext(2)]
		public void AddGeometryCollectionActor(AGeometryCollectionActor GeometryCollectionActor)
		{
			UChaosDestructionListener.__AddGeometryCollectionActor_Internal(base.NativePtr, (GeometryCollectionActor != null) ? GeometryCollectionActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06012CE0 RID: 77024 RVA: 0x001BAAE5 File Offset: 0x001B8CE5
		[NullableContext(2)]
		public void AddChaosSolverActor(AChaosSolverActor ChaosSolverActor)
		{
			UChaosDestructionListener.__AddChaosSolverActor_Internal(base.NativePtr, (ChaosSolverActor != null) ? ChaosSolverActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06012CE1 RID: 77025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SortTrailingEvents_Internal(IntPtr @this, IntPtr TrailingEvents, EChaosTrailingSortMethod SortMethod);

		// Token: 0x06012CE2 RID: 77026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SortCollisionEvents_Internal(IntPtr @this, IntPtr CollisionEvents, EChaosCollisionSortMethod SortMethod);

		// Token: 0x06012CE3 RID: 77027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SortBreakingEvents_Internal(IntPtr @this, IntPtr BreakingEvents, EChaosBreakingSortMethod SortMethod);

		// Token: 0x06012CE4 RID: 77028
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTrailingEventRequestSettings_Internal(IntPtr @this, IntPtr InSettings);

		// Token: 0x06012CE5 RID: 77029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTrailingEventEnabled_Internal(IntPtr @this, bool bIsEnabled);

		// Token: 0x06012CE6 RID: 77030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCollisionEventRequestSettings_Internal(IntPtr @this, IntPtr InSettings);

		// Token: 0x06012CE7 RID: 77031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCollisionEventEnabled_Internal(IntPtr @this, bool bIsEnabled);

		// Token: 0x06012CE8 RID: 77032
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBreakingEventRequestSettings_Internal(IntPtr @this, IntPtr InSettings);

		// Token: 0x06012CE9 RID: 77033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBreakingEventEnabled_Internal(IntPtr @this, bool bIsEnabled);

		// Token: 0x06012CEA RID: 77034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveGeometryCollectionActor_Internal(IntPtr @this, IntPtr GeometryCollectionActor);

		// Token: 0x06012CEB RID: 77035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveChaosSolverActor_Internal(IntPtr @this, IntPtr ChaosSolverActor);

		// Token: 0x06012CEC RID: 77036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEventListening_Internal(IntPtr @this);

		// Token: 0x06012CED RID: 77037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddGeometryCollectionActor_Internal(IntPtr @this, IntPtr GeometryCollectionActor);

		// Token: 0x06012CEE RID: 77038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddChaosSolverActor_Internal(IntPtr @this, IntPtr ChaosSolverActor);

		// Token: 0x06012CEF RID: 77039 RVA: 0x001BAB02 File Offset: 0x001B8D02
		static UChaosDestructionListener()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCollectionEngine.ChaosDestructionListener");
		}

		// Token: 0x06012CF0 RID: 77040 RVA: 0x001BAB10 File Offset: 0x001B8D10
		protected UChaosDestructionListener(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A0A3 RID: 41123
		public new const string __ObjectPath = "/Script/GeometryCollectionEngine.ChaosDestructionListener";

		// Token: 0x0400A0A4 RID: 41124
		private static IntPtr _ClassPtr;

		// Token: 0x0400A0A5 RID: 41125
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A0A6 RID: 41126
		internal static int __PropertyOffset_bIsCollisionEventListeningEnabled;

		// Token: 0x0400A0A7 RID: 41127
		internal static byte __PropertyMask_bIsCollisionEventListeningEnabled;

		// Token: 0x0400A0A8 RID: 41128
		internal static int __PropertyOffset_bIsBreakingEventListeningEnabled;

		// Token: 0x0400A0A9 RID: 41129
		internal static byte __PropertyMask_bIsBreakingEventListeningEnabled;

		// Token: 0x0400A0AA RID: 41130
		internal static int __PropertyOffset_bIsTrailingEventListeningEnabled;

		// Token: 0x0400A0AB RID: 41131
		internal static byte __PropertyMask_bIsTrailingEventListeningEnabled;

		// Token: 0x0400A0AC RID: 41132
		internal static int __PropertyOffset_CollisionEventRequestSettings;

		// Token: 0x0400A0AD RID: 41133
		[Nullable(2)]
		private FChaosCollisionEventRequestSettings _CollisionEventRequestSettings;

		// Token: 0x0400A0AE RID: 41134
		internal static int __PropertyOffset_BreakingEventRequestSettings;

		// Token: 0x0400A0AF RID: 41135
		[Nullable(2)]
		private FChaosBreakingEventRequestSettings _BreakingEventRequestSettings;

		// Token: 0x0400A0B0 RID: 41136
		internal static int __PropertyOffset_TrailingEventRequestSettings;

		// Token: 0x0400A0B1 RID: 41137
		[Nullable(2)]
		private FChaosTrailingEventRequestSettings _TrailingEventRequestSettings;

		// Token: 0x0400A0B2 RID: 41138
		internal static int __PropertyOffset_ChaosSolverActors;

		// Token: 0x0400A0B3 RID: 41139
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<AChaosSolverActor> _ChaosSolverActors;

		// Token: 0x0400A0B4 RID: 41140
		internal static int __PropertyOffset_GeometryCollectionActors;

		// Token: 0x0400A0B5 RID: 41141
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<AGeometryCollectionActor> _GeometryCollectionActors;

		// Token: 0x0400A0B6 RID: 41142
		internal static int __PropertyOffset_OnCollisionEvents;

		// Token: 0x0400A0B7 RID: 41143
		[Nullable(2)]
		private FOnChaosCollisionEvents _OnCollisionEvents;

		// Token: 0x0400A0B8 RID: 41144
		internal static int __PropertyOffset_OnBreakingEvents;

		// Token: 0x0400A0B9 RID: 41145
		[Nullable(2)]
		private FOnChaosBreakingEvents _OnBreakingEvents;

		// Token: 0x0400A0BA RID: 41146
		internal static int __PropertyOffset_OnTrailingEvents;

		// Token: 0x0400A0BB RID: 41147
		[Nullable(2)]
		private FOnChaosTrailingEvents _OnTrailingEvents;
	}
}
