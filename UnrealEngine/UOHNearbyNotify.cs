using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007AF RID: 1967
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/OHNearby.OHNearbyNotify")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UOHNearbyNotify : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AADE RID: 43742 RVA: 0x000FC116 File Offset: 0x000FA316
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOHNearbyNotify._ClassPtr;
		}

		// Token: 0x0600AADF RID: 43743 RVA: 0x000FC124 File Offset: 0x000FA324
		public UOHNearbyNotify() : this(BuiltinUtils.AllocNativeUObject(UOHNearbyNotify.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AAE0 RID: 43744 RVA: 0x000FC14C File Offset: 0x000FA34C
		public UOHNearbyNotify(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOHNearbyNotify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001FD6 RID: 8150
		// (get) Token: 0x0600AAE1 RID: 43745 RVA: 0x000FC180 File Offset: 0x000FA380
		// (set) Token: 0x0600AAE2 RID: 43746 RVA: 0x000FC1B9 File Offset: 0x000FA3B9
		public FKuroNearbyTransferEvent OnTransferEvent
		{
			get
			{
				base.FastCheckIsValid();
				FKuroNearbyTransferEvent result;
				if ((result = this._OnTransferEvent) == null)
				{
					result = (this._OnTransferEvent = new FKuroNearbyTransferEvent(base.NativePtr + (IntPtr)UOHNearbyNotify.__PropertyOffset_OnTransferEvent, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UOHNearbyNotify.__PropertyOffset_OnTransferEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600AAE3 RID: 43747 RVA: 0x000FC1DA File Offset: 0x000FA3DA
		[NullableContext(2)]
		public void SetCompleteCallback(FKuroNearbyReceiveComplete InCb)
		{
			UOHNearbyNotify.__SetCompleteCallback_Internal(base.NativePtr, (InCb != null) ? InCb.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600AAE4 RID: 43748 RVA: 0x000FC1F4 File Offset: 0x000FA3F4
		public void ResetState()
		{
			UOHNearbyNotify.__ResetState_Internal(base.NativePtr);
		}

		// Token: 0x0600AAE5 RID: 43749 RVA: 0x000FC201 File Offset: 0x000FA401
		public int GetLastTransferState()
		{
			return UOHNearbyNotify.__GetLastTransferState_Internal(base.NativePtr);
		}

		// Token: 0x0600AAE6 RID: 43750
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCompleteCallback_Internal(IntPtr @this, IntPtr InCb);

		// Token: 0x0600AAE7 RID: 43751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetState_Internal(IntPtr @this);

		// Token: 0x0600AAE8 RID: 43752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetLastTransferState_Internal(IntPtr @this);

		// Token: 0x0600AAE9 RID: 43753 RVA: 0x000FC20E File Offset: 0x000FA40E
		static UOHNearbyNotify()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/OHNearby.OHNearbyNotify");
		}

		// Token: 0x0600AAEA RID: 43754 RVA: 0x000FC21C File Offset: 0x000FA41C
		protected UOHNearbyNotify(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004928 RID: 18728
		public new const string __ObjectPath = "/Script/OHNearby.OHNearbyNotify";

		// Token: 0x04004929 RID: 18729
		private static IntPtr _ClassPtr;

		// Token: 0x0400492A RID: 18730
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400492B RID: 18731
		internal static int __PropertyOffset_OnTransferEvent;

		// Token: 0x0400492C RID: 18732
		[Nullable(2)]
		private FKuroNearbyTransferEvent _OnTransferEvent;
	}
}
