using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000994 RID: 2452
	[UnrealObjectPath("/Script/Engine.DataLayer")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UDataLayer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008A6A RID: 35434 RVA: 0x000C6311 File Offset: 0x000C4511
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDataLayer._ClassPtr;
		}

		// Token: 0x06008A6B RID: 35435 RVA: 0x000C6320 File Offset: 0x000C4520
		public UDataLayer() : this(BuiltinUtils.AllocNativeUObject(UDataLayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008A6C RID: 35436 RVA: 0x000C6348 File Offset: 0x000C4548
		[NullableContext(1)]
		public UDataLayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDataLayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x06008A6D RID: 35437 RVA: 0x000C637B File Offset: 0x000C457B
		// (set) Token: 0x06008A6E RID: 35438 RVA: 0x000C638F File Offset: 0x000C458F
		public unsafe FName DataLayerLabel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDataLayer.__PropertyOffset_DataLayerLabel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDataLayer.__PropertyOffset_DataLayerLabel) = value;
			}
		}

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x06008A6F RID: 35439 RVA: 0x000C63A4 File Offset: 0x000C45A4
		// (set) Token: 0x06008A70 RID: 35440 RVA: 0x000C63B4 File Offset: 0x000C45B4
		public unsafe EDataLayerState InitialState
		{
			get
			{
				return (EDataLayerState)(*(base.NativePtr + (IntPtr)UDataLayer.__PropertyOffset_InitialState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDataLayer.__PropertyOffset_InitialState) = (byte)value;
			}
		}

		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x06008A71 RID: 35441 RVA: 0x000C63C5 File Offset: 0x000C45C5
		// (set) Token: 0x06008A72 RID: 35442 RVA: 0x000C63DE File Offset: 0x000C45DE
		public unsafe bool bIsDynamicallyLoaded
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDataLayer.__PropertyOffset_bIsDynamicallyLoaded) & UDataLayer.__PropertyMask_bIsDynamicallyLoaded) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDataLayer.__PropertyOffset_bIsDynamicallyLoaded) = ((*(base.NativePtr + (IntPtr)UDataLayer.__PropertyOffset_bIsDynamicallyLoaded) & ~UDataLayer.__PropertyMask_bIsDynamicallyLoaded) | (value ? UDataLayer.__PropertyMask_bIsDynamicallyLoaded : 0));
			}
		}

		// Token: 0x1700209F RID: 8351
		// (get) Token: 0x06008A73 RID: 35443 RVA: 0x000C640E File Offset: 0x000C460E
		// (set) Token: 0x06008A74 RID: 35444 RVA: 0x000C641E File Offset: 0x000C461E
		public unsafe bool bEnableLoadPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDataLayer.__PropertyOffset_bEnableLoadPriority) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDataLayer.__PropertyOffset_bEnableLoadPriority) = (value ? 1 : 0);
			}
		}

		// Token: 0x170020A0 RID: 8352
		// (get) Token: 0x06008A75 RID: 35445 RVA: 0x000C642F File Offset: 0x000C462F
		// (set) Token: 0x06008A76 RID: 35446 RVA: 0x000C643F File Offset: 0x000C463F
		public unsafe int LoadPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDataLayer.__PropertyOffset_LoadPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDataLayer.__PropertyOffset_LoadPriority) = value;
			}
		}

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x06008A77 RID: 35447 RVA: 0x000C6450 File Offset: 0x000C4650
		// (set) Token: 0x06008A78 RID: 35448 RVA: 0x000C6460 File Offset: 0x000C4660
		public unsafe bool bAlwaysPassStateCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDataLayer.__PropertyOffset_bAlwaysPassStateCheck) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDataLayer.__PropertyOffset_bAlwaysPassStateCheck) = (value ? 1 : 0);
			}
		}

		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x06008A79 RID: 35449 RVA: 0x000C6471 File Offset: 0x000C4671
		// (set) Token: 0x06008A7A RID: 35450 RVA: 0x000C648A File Offset: 0x000C468A
		public unsafe bool bExcludeStreaming
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDataLayer.__PropertyOffset_bExcludeStreaming) & UDataLayer.__PropertyMask_bExcludeStreaming) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDataLayer.__PropertyOffset_bExcludeStreaming) = ((*(base.NativePtr + (IntPtr)UDataLayer.__PropertyOffset_bExcludeStreaming) & ~UDataLayer.__PropertyMask_bExcludeStreaming) | (value ? UDataLayer.__PropertyMask_bExcludeStreaming : 0));
			}
		}

		// Token: 0x06008A7B RID: 35451 RVA: 0x000C64BA File Offset: 0x000C46BA
		public bool IsVisible()
		{
			return UDataLayer.__IsVisible_Internal(base.NativePtr);
		}

		// Token: 0x06008A7C RID: 35452 RVA: 0x000C64C7 File Offset: 0x000C46C7
		public bool IsInitiallyVisible()
		{
			return UDataLayer.__IsInitiallyVisible_Internal(base.NativePtr);
		}

		// Token: 0x06008A7D RID: 35453 RVA: 0x000C64D4 File Offset: 0x000C46D4
		public bool IsInitiallyActive()
		{
			return UDataLayer.__IsInitiallyActive_Internal(base.NativePtr);
		}

		// Token: 0x06008A7E RID: 35454 RVA: 0x000C64E1 File Offset: 0x000C46E1
		public bool IsEnableLoadPriority()
		{
			return UDataLayer.__IsEnableLoadPriority_Internal(base.NativePtr);
		}

		// Token: 0x06008A7F RID: 35455 RVA: 0x000C64EE File Offset: 0x000C46EE
		public bool IsDynamicallyLoaded()
		{
			return UDataLayer.__IsDynamicallyLoaded_Internal(base.NativePtr);
		}

		// Token: 0x06008A80 RID: 35456 RVA: 0x000C64FB File Offset: 0x000C46FB
		public bool IsAlwaysPassStateCheck()
		{
			return UDataLayer.__IsAlwaysPassStateCheck_Internal(base.NativePtr);
		}

		// Token: 0x06008A81 RID: 35457 RVA: 0x000C6508 File Offset: 0x000C4708
		public int GetLoadPriority()
		{
			return UDataLayer.__GetLoadPriority_Internal(base.NativePtr);
		}

		// Token: 0x06008A82 RID: 35458 RVA: 0x000C6515 File Offset: 0x000C4715
		public EDataLayerState GetInitialState()
		{
			return UDataLayer.__GetInitialState_Internal(base.NativePtr);
		}

		// Token: 0x06008A83 RID: 35459 RVA: 0x000C6522 File Offset: 0x000C4722
		public FName GetDataLayerLabel()
		{
			return UDataLayer.__GetDataLayerLabel_Internal(base.NativePtr);
		}

		// Token: 0x06008A84 RID: 35460 RVA: 0x000C652F File Offset: 0x000C472F
		[NullableContext(2)]
		public bool Equals(in FActorDataLayer ActorDataLayer)
		{
			return UDataLayer.__Equals_Internal(base.NativePtr, (ActorDataLayer ?? new FActorDataLayer()).NativePtr);
		}

		// Token: 0x06008A85 RID: 35461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsVisible_Internal(IntPtr @this);

		// Token: 0x06008A86 RID: 35462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInitiallyVisible_Internal(IntPtr @this);

		// Token: 0x06008A87 RID: 35463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInitiallyActive_Internal(IntPtr @this);

		// Token: 0x06008A88 RID: 35464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEnableLoadPriority_Internal(IntPtr @this);

		// Token: 0x06008A89 RID: 35465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsDynamicallyLoaded_Internal(IntPtr @this);

		// Token: 0x06008A8A RID: 35466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAlwaysPassStateCheck_Internal(IntPtr @this);

		// Token: 0x06008A8B RID: 35467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetLoadPriority_Internal(IntPtr @this);

		// Token: 0x06008A8C RID: 35468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EDataLayerState __GetInitialState_Internal(IntPtr @this);

		// Token: 0x06008A8D RID: 35469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetDataLayerLabel_Internal(IntPtr @this);

		// Token: 0x06008A8E RID: 35470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Equals_Internal(IntPtr @this, IntPtr ActorDataLayer);

		// Token: 0x06008A8F RID: 35471 RVA: 0x000C654C File Offset: 0x000C474C
		static UDataLayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DataLayer");
		}

		// Token: 0x06008A90 RID: 35472 RVA: 0x000C655A File Offset: 0x000C475A
		protected UDataLayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040041BA RID: 16826
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DataLayer";

		// Token: 0x040041BB RID: 16827
		private static IntPtr _ClassPtr;

		// Token: 0x040041BC RID: 16828
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040041BD RID: 16829
		internal static int __PropertyOffset_DataLayerLabel;

		// Token: 0x040041BE RID: 16830
		internal static int __PropertyOffset_InitialState;

		// Token: 0x040041BF RID: 16831
		internal static int __PropertyOffset_bIsDynamicallyLoaded;

		// Token: 0x040041C0 RID: 16832
		internal static byte __PropertyMask_bIsDynamicallyLoaded;

		// Token: 0x040041C1 RID: 16833
		internal static int __PropertyOffset_bEnableLoadPriority;

		// Token: 0x040041C2 RID: 16834
		internal static int __PropertyOffset_LoadPriority;

		// Token: 0x040041C3 RID: 16835
		internal static int __PropertyOffset_bAlwaysPassStateCheck;

		// Token: 0x040041C4 RID: 16836
		internal static int __PropertyOffset_bExcludeStreaming;

		// Token: 0x040041C5 RID: 16837
		internal static byte __PropertyMask_bExcludeStreaming;
	}
}
