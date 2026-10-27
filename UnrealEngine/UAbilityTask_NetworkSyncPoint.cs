using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012FC RID: 4860
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_NetworkSyncPoint")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UAbilityTask_NetworkSyncPoint : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011EBF RID: 73407 RVA: 0x001A49FD File Offset: 0x001A2BFD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_NetworkSyncPoint._ClassPtr;
		}

		// Token: 0x06011EC0 RID: 73408 RVA: 0x001A4A0C File Offset: 0x001A2C0C
		public UAbilityTask_NetworkSyncPoint() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_NetworkSyncPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011EC1 RID: 73409 RVA: 0x001A4A34 File Offset: 0x001A2C34
		public UAbilityTask_NetworkSyncPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_NetworkSyncPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004611 RID: 17937
		// (get) Token: 0x06011EC2 RID: 73410 RVA: 0x001A4A68 File Offset: 0x001A2C68
		// (set) Token: 0x06011EC3 RID: 73411 RVA: 0x001A4AA1 File Offset: 0x001A2CA1
		public FNetworkSyncDelegate OnSync
		{
			get
			{
				base.FastCheckIsValid();
				FNetworkSyncDelegate result;
				if ((result = this._OnSync) == null)
				{
					result = (this._OnSync = new FNetworkSyncDelegate(base.NativePtr + (IntPtr)UAbilityTask_NetworkSyncPoint.__PropertyOffset_OnSync, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_NetworkSyncPoint.__PropertyOffset_OnSync, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06011EC4 RID: 73412 RVA: 0x001A4AC2 File Offset: 0x001A2CC2
		[NullableContext(2)]
		public static UAbilityTask_NetworkSyncPoint WaitNetSync(UGameplayAbility OwningAbility, EAbilityTaskNetSyncType SyncType)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_NetworkSyncPoint>(UAbilityTask_NetworkSyncPoint.__WaitNetSync_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, SyncType));
		}

		// Token: 0x06011EC5 RID: 73413 RVA: 0x001A4ADF File Offset: 0x001A2CDF
		public void OnSignalCallback()
		{
			UAbilityTask_NetworkSyncPoint.__OnSignalCallback_Internal(base.NativePtr);
		}

		// Token: 0x06011EC6 RID: 73414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitNetSync_Internal(IntPtr OwningAbility, EAbilityTaskNetSyncType SyncType);

		// Token: 0x06011EC7 RID: 73415
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnSignalCallback_Internal(IntPtr @this);

		// Token: 0x06011EC8 RID: 73416 RVA: 0x001A4AEC File Offset: 0x001A2CEC
		static UAbilityTask_NetworkSyncPoint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_NetworkSyncPoint");
		}

		// Token: 0x06011EC9 RID: 73417 RVA: 0x001A4AFA File Offset: 0x001A2CFA
		protected UAbilityTask_NetworkSyncPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400994D RID: 39245
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_NetworkSyncPoint";

		// Token: 0x0400994E RID: 39246
		private static IntPtr _ClassPtr;

		// Token: 0x0400994F RID: 39247
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009950 RID: 39248
		internal static int __PropertyOffset_OnSync;

		// Token: 0x04009951 RID: 39249
		[Nullable(2)]
		private FNetworkSyncDelegate _OnSync;
	}
}
