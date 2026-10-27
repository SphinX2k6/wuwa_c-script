using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002611 RID: 9745
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/OHNearby.OHNearbyNotify")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UOHNearbyNotify : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060243FD RID: 148477 RVA: 0x0035AC26 File Offset: 0x00358E26
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOHNearbyNotify._ClassPtr;
		}

		// Token: 0x060243FE RID: 148478 RVA: 0x0035AC34 File Offset: 0x00358E34
		public UOHNearbyNotify() : this(BuiltinUtils.AllocNativeUObject(UOHNearbyNotify.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060243FF RID: 148479 RVA: 0x0035AC5C File Offset: 0x00358E5C
		public UOHNearbyNotify(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOHNearbyNotify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008B9A RID: 35738
		// (get) Token: 0x06024400 RID: 148480 RVA: 0x0035AC90 File Offset: 0x00358E90
		// (set) Token: 0x06024401 RID: 148481 RVA: 0x0035ACC9 File Offset: 0x00358EC9
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

		// Token: 0x06024402 RID: 148482 RVA: 0x0035ACEA File Offset: 0x00358EEA
		[NullableContext(2)]
		public void SetCompleteCallback(FKuroNearbyReceiveComplete InCb)
		{
			UOHNearbyNotify.__SetCompleteCallback_Internal(base.NativePtr, (InCb != null) ? InCb.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06024403 RID: 148483 RVA: 0x0035AD04 File Offset: 0x00358F04
		public void ResetState()
		{
			UOHNearbyNotify.__ResetState_Internal(base.NativePtr);
		}

		// Token: 0x06024404 RID: 148484 RVA: 0x0035AD11 File Offset: 0x00358F11
		public int GetLastTransferState()
		{
			return UOHNearbyNotify.__GetLastTransferState_Internal(base.NativePtr);
		}

		// Token: 0x06024405 RID: 148485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCompleteCallback_Internal(IntPtr @this, IntPtr InCb);

		// Token: 0x06024406 RID: 148486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetState_Internal(IntPtr @this);

		// Token: 0x06024407 RID: 148487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetLastTransferState_Internal(IntPtr @this);

		// Token: 0x06024408 RID: 148488 RVA: 0x0035AD1E File Offset: 0x00358F1E
		static UOHNearbyNotify()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/OHNearby.OHNearbyNotify");
		}

		// Token: 0x06024409 RID: 148489 RVA: 0x0035AD2C File Offset: 0x00358F2C
		protected UOHNearbyNotify(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401372A RID: 79658
		public new const string __ObjectPath = "/Script/OHNearby.OHNearbyNotify";

		// Token: 0x0401372B RID: 79659
		private static IntPtr _ClassPtr;

		// Token: 0x0401372C RID: 79660
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401372D RID: 79661
		internal static int __PropertyOffset_OnTransferEvent;

		// Token: 0x0401372E RID: 79662
		[Nullable(2)]
		private FKuroNearbyTransferEvent _OnTransferEvent;
	}
}
