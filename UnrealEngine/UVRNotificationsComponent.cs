using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200146C RID: 5228
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HeadMountedDisplay.VRNotificationsComponent")]
	[UnrealStructLayout(344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 344)]
	public class UVRNotificationsComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013120 RID: 78112 RVA: 0x001C09E4 File Offset: 0x001BEBE4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVRNotificationsComponent._ClassPtr;
		}

		// Token: 0x06013121 RID: 78113 RVA: 0x001C09F0 File Offset: 0x001BEBF0
		public UVRNotificationsComponent() : this(BuiltinUtils.AllocNativeUObject(UVRNotificationsComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013122 RID: 78114 RVA: 0x001C0A18 File Offset: 0x001BEC18
		public UVRNotificationsComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVRNotificationsComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004A13 RID: 18963
		// (get) Token: 0x06013123 RID: 78115 RVA: 0x001C0A4C File Offset: 0x001BEC4C
		// (set) Token: 0x06013124 RID: 78116 RVA: 0x001C0A85 File Offset: 0x001BEC85
		public FVRNotificationsDelegate HMDTrackingInitializingAndNeedsHMDToBeTrackedDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FVRNotificationsDelegate result;
				if ((result = this._HMDTrackingInitializingAndNeedsHMDToBeTrackedDelegate) == null)
				{
					result = (this._HMDTrackingInitializingAndNeedsHMDToBeTrackedDelegate = new FVRNotificationsDelegate(base.NativePtr + (IntPtr)UVRNotificationsComponent.__PropertyOffset_HMDTrackingInitializingAndNeedsHMDToBeTrackedDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UVRNotificationsComponent.__PropertyOffset_HMDTrackingInitializingAndNeedsHMDToBeTrackedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004A14 RID: 18964
		// (get) Token: 0x06013125 RID: 78117 RVA: 0x001C0AA8 File Offset: 0x001BECA8
		// (set) Token: 0x06013126 RID: 78118 RVA: 0x001C0AE1 File Offset: 0x001BECE1
		public FVRNotificationsDelegate HMDTrackingInitializedDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FVRNotificationsDelegate result;
				if ((result = this._HMDTrackingInitializedDelegate) == null)
				{
					result = (this._HMDTrackingInitializedDelegate = new FVRNotificationsDelegate(base.NativePtr + (IntPtr)UVRNotificationsComponent.__PropertyOffset_HMDTrackingInitializedDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UVRNotificationsComponent.__PropertyOffset_HMDTrackingInitializedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004A15 RID: 18965
		// (get) Token: 0x06013127 RID: 78119 RVA: 0x001C0B04 File Offset: 0x001BED04
		// (set) Token: 0x06013128 RID: 78120 RVA: 0x001C0B3D File Offset: 0x001BED3D
		public FVRNotificationsDelegate HMDRecenteredDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FVRNotificationsDelegate result;
				if ((result = this._HMDRecenteredDelegate) == null)
				{
					result = (this._HMDRecenteredDelegate = new FVRNotificationsDelegate(base.NativePtr + (IntPtr)UVRNotificationsComponent.__PropertyOffset_HMDRecenteredDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UVRNotificationsComponent.__PropertyOffset_HMDRecenteredDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004A16 RID: 18966
		// (get) Token: 0x06013129 RID: 78121 RVA: 0x001C0B60 File Offset: 0x001BED60
		// (set) Token: 0x0601312A RID: 78122 RVA: 0x001C0B99 File Offset: 0x001BED99
		public FVRNotificationsDelegate HMDLostDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FVRNotificationsDelegate result;
				if ((result = this._HMDLostDelegate) == null)
				{
					result = (this._HMDLostDelegate = new FVRNotificationsDelegate(base.NativePtr + (IntPtr)UVRNotificationsComponent.__PropertyOffset_HMDLostDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UVRNotificationsComponent.__PropertyOffset_HMDLostDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004A17 RID: 18967
		// (get) Token: 0x0601312B RID: 78123 RVA: 0x001C0BBC File Offset: 0x001BEDBC
		// (set) Token: 0x0601312C RID: 78124 RVA: 0x001C0BF5 File Offset: 0x001BEDF5
		public FVRNotificationsDelegate HMDReconnectedDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FVRNotificationsDelegate result;
				if ((result = this._HMDReconnectedDelegate) == null)
				{
					result = (this._HMDReconnectedDelegate = new FVRNotificationsDelegate(base.NativePtr + (IntPtr)UVRNotificationsComponent.__PropertyOffset_HMDReconnectedDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UVRNotificationsComponent.__PropertyOffset_HMDReconnectedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004A18 RID: 18968
		// (get) Token: 0x0601312D RID: 78125 RVA: 0x001C0C18 File Offset: 0x001BEE18
		// (set) Token: 0x0601312E RID: 78126 RVA: 0x001C0C51 File Offset: 0x001BEE51
		public FVRNotificationsDelegate HMDConnectCanceledDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FVRNotificationsDelegate result;
				if ((result = this._HMDConnectCanceledDelegate) == null)
				{
					result = (this._HMDConnectCanceledDelegate = new FVRNotificationsDelegate(base.NativePtr + (IntPtr)UVRNotificationsComponent.__PropertyOffset_HMDConnectCanceledDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UVRNotificationsComponent.__PropertyOffset_HMDConnectCanceledDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004A19 RID: 18969
		// (get) Token: 0x0601312F RID: 78127 RVA: 0x001C0C74 File Offset: 0x001BEE74
		// (set) Token: 0x06013130 RID: 78128 RVA: 0x001C0CAD File Offset: 0x001BEEAD
		public FVRNotificationsDelegate HMDPutOnHeadDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FVRNotificationsDelegate result;
				if ((result = this._HMDPutOnHeadDelegate) == null)
				{
					result = (this._HMDPutOnHeadDelegate = new FVRNotificationsDelegate(base.NativePtr + (IntPtr)UVRNotificationsComponent.__PropertyOffset_HMDPutOnHeadDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UVRNotificationsComponent.__PropertyOffset_HMDPutOnHeadDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004A1A RID: 18970
		// (get) Token: 0x06013131 RID: 78129 RVA: 0x001C0CD0 File Offset: 0x001BEED0
		// (set) Token: 0x06013132 RID: 78130 RVA: 0x001C0D09 File Offset: 0x001BEF09
		public FVRNotificationsDelegate HMDRemovedFromHeadDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FVRNotificationsDelegate result;
				if ((result = this._HMDRemovedFromHeadDelegate) == null)
				{
					result = (this._HMDRemovedFromHeadDelegate = new FVRNotificationsDelegate(base.NativePtr + (IntPtr)UVRNotificationsComponent.__PropertyOffset_HMDRemovedFromHeadDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UVRNotificationsComponent.__PropertyOffset_HMDRemovedFromHeadDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004A1B RID: 18971
		// (get) Token: 0x06013133 RID: 78131 RVA: 0x001C0D2C File Offset: 0x001BEF2C
		// (set) Token: 0x06013134 RID: 78132 RVA: 0x001C0D65 File Offset: 0x001BEF65
		public FVRNotificationsDelegate VRControllerRecenteredDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FVRNotificationsDelegate result;
				if ((result = this._VRControllerRecenteredDelegate) == null)
				{
					result = (this._VRControllerRecenteredDelegate = new FVRNotificationsDelegate(base.NativePtr + (IntPtr)UVRNotificationsComponent.__PropertyOffset_VRControllerRecenteredDelegate, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UVRNotificationsComponent.__PropertyOffset_VRControllerRecenteredDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06013135 RID: 78133 RVA: 0x001C0D86 File Offset: 0x001BEF86
		static UVRNotificationsComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HeadMountedDisplay.VRNotificationsComponent");
		}

		// Token: 0x06013136 RID: 78134 RVA: 0x001C0D94 File Offset: 0x001BEF94
		protected UVRNotificationsComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A392 RID: 41874
		public new const string __ObjectPath = "/Script/HeadMountedDisplay.VRNotificationsComponent";

		// Token: 0x0400A393 RID: 41875
		private static IntPtr _ClassPtr;

		// Token: 0x0400A394 RID: 41876
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A395 RID: 41877
		public static IntPtr __VRNotificationsDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400A396 RID: 41878
		internal static int __PropertyOffset_HMDTrackingInitializingAndNeedsHMDToBeTrackedDelegate;

		// Token: 0x0400A397 RID: 41879
		[Nullable(2)]
		private FVRNotificationsDelegate _HMDTrackingInitializingAndNeedsHMDToBeTrackedDelegate;

		// Token: 0x0400A398 RID: 41880
		internal static int __PropertyOffset_HMDTrackingInitializedDelegate;

		// Token: 0x0400A399 RID: 41881
		[Nullable(2)]
		private FVRNotificationsDelegate _HMDTrackingInitializedDelegate;

		// Token: 0x0400A39A RID: 41882
		internal static int __PropertyOffset_HMDRecenteredDelegate;

		// Token: 0x0400A39B RID: 41883
		[Nullable(2)]
		private FVRNotificationsDelegate _HMDRecenteredDelegate;

		// Token: 0x0400A39C RID: 41884
		internal static int __PropertyOffset_HMDLostDelegate;

		// Token: 0x0400A39D RID: 41885
		[Nullable(2)]
		private FVRNotificationsDelegate _HMDLostDelegate;

		// Token: 0x0400A39E RID: 41886
		internal static int __PropertyOffset_HMDReconnectedDelegate;

		// Token: 0x0400A39F RID: 41887
		[Nullable(2)]
		private FVRNotificationsDelegate _HMDReconnectedDelegate;

		// Token: 0x0400A3A0 RID: 41888
		internal static int __PropertyOffset_HMDConnectCanceledDelegate;

		// Token: 0x0400A3A1 RID: 41889
		[Nullable(2)]
		private FVRNotificationsDelegate _HMDConnectCanceledDelegate;

		// Token: 0x0400A3A2 RID: 41890
		internal static int __PropertyOffset_HMDPutOnHeadDelegate;

		// Token: 0x0400A3A3 RID: 41891
		[Nullable(2)]
		private FVRNotificationsDelegate _HMDPutOnHeadDelegate;

		// Token: 0x0400A3A4 RID: 41892
		internal static int __PropertyOffset_HMDRemovedFromHeadDelegate;

		// Token: 0x0400A3A5 RID: 41893
		[Nullable(2)]
		private FVRNotificationsDelegate _HMDRemovedFromHeadDelegate;

		// Token: 0x0400A3A6 RID: 41894
		internal static int __PropertyOffset_VRControllerRecenteredDelegate;

		// Token: 0x0400A3A7 RID: 41895
		[Nullable(2)]
		private FVRNotificationsDelegate _VRControllerRecenteredDelegate;
	}
}
