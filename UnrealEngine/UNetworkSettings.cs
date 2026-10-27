using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EED RID: 3821
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.NetworkSettings")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UNetworkSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CF2B RID: 53035 RVA: 0x0012E3C5 File Offset: 0x0012C5C5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNetworkSettings._ClassPtr;
		}

		// Token: 0x0600CF2C RID: 53036 RVA: 0x0012E3D4 File Offset: 0x0012C5D4
		public UNetworkSettings() : this(BuiltinUtils.AllocNativeUObject(UNetworkSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CF2D RID: 53037 RVA: 0x0012E3FC File Offset: 0x0012C5FC
		public UNetworkSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNetworkSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170030E0 RID: 12512
		// (get) Token: 0x0600CF2E RID: 53038 RVA: 0x0012E42F File Offset: 0x0012C62F
		// (set) Token: 0x0600CF2F RID: 53039 RVA: 0x0012E448 File Offset: 0x0012C648
		public unsafe bool bVerifyPeer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNetworkSettings.__PropertyOffset_bVerifyPeer) & UNetworkSettings.__PropertyMask_bVerifyPeer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNetworkSettings.__PropertyOffset_bVerifyPeer) = ((*(base.NativePtr + (IntPtr)UNetworkSettings.__PropertyOffset_bVerifyPeer) & ~UNetworkSettings.__PropertyMask_bVerifyPeer) | (value ? UNetworkSettings.__PropertyMask_bVerifyPeer : 0));
			}
		}

		// Token: 0x170030E1 RID: 12513
		// (get) Token: 0x0600CF30 RID: 53040 RVA: 0x0012E478 File Offset: 0x0012C678
		// (set) Token: 0x0600CF31 RID: 53041 RVA: 0x0012E491 File Offset: 0x0012C691
		public unsafe bool bEnableMultiplayerWorldOriginRebasing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNetworkSettings.__PropertyOffset_bEnableMultiplayerWorldOriginRebasing) & UNetworkSettings.__PropertyMask_bEnableMultiplayerWorldOriginRebasing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNetworkSettings.__PropertyOffset_bEnableMultiplayerWorldOriginRebasing) = ((*(base.NativePtr + (IntPtr)UNetworkSettings.__PropertyOffset_bEnableMultiplayerWorldOriginRebasing) & ~UNetworkSettings.__PropertyMask_bEnableMultiplayerWorldOriginRebasing) | (value ? UNetworkSettings.__PropertyMask_bEnableMultiplayerWorldOriginRebasing : 0));
			}
		}

		// Token: 0x170030E2 RID: 12514
		// (get) Token: 0x0600CF32 RID: 53042 RVA: 0x0012E4C1 File Offset: 0x0012C6C1
		// (set) Token: 0x0600CF33 RID: 53043 RVA: 0x0012E4D1 File Offset: 0x0012C6D1
		public unsafe int MaxRepArraySize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetworkSettings.__PropertyOffset_MaxRepArraySize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetworkSettings.__PropertyOffset_MaxRepArraySize) = value;
			}
		}

		// Token: 0x170030E3 RID: 12515
		// (get) Token: 0x0600CF34 RID: 53044 RVA: 0x0012E4E2 File Offset: 0x0012C6E2
		// (set) Token: 0x0600CF35 RID: 53045 RVA: 0x0012E4F2 File Offset: 0x0012C6F2
		public unsafe int MaxRepArrayMemory
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNetworkSettings.__PropertyOffset_MaxRepArrayMemory);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNetworkSettings.__PropertyOffset_MaxRepArrayMemory) = value;
			}
		}

		// Token: 0x170030E4 RID: 12516
		// (get) Token: 0x0600CF36 RID: 53046 RVA: 0x0012E504 File Offset: 0x0012C704
		// (set) Token: 0x0600CF37 RID: 53047 RVA: 0x0012E53D File Offset: 0x0012C73D
		public TArray<FNetworkEmulationProfileDescription> NetworkEmulationProfiles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNetworkEmulationProfileDescription> result;
				if ((result = this._NetworkEmulationProfiles) == null)
				{
					result = (this._NetworkEmulationProfiles = new TArray<FNetworkEmulationProfileDescription>(base.NativePtr + (IntPtr)UNetworkSettings.__PropertyOffset_NetworkEmulationProfiles, this));
				}
				return result;
			}
			set
			{
				this.NetworkEmulationProfiles.CopyAssign(value);
			}
		}

		// Token: 0x0600CF38 RID: 53048 RVA: 0x0012E54B File Offset: 0x0012C74B
		static UNetworkSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NetworkSettings");
		}

		// Token: 0x0600CF39 RID: 53049 RVA: 0x0012E559 File Offset: 0x0012C759
		protected UNetworkSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006FB8 RID: 28600
		public new const string __ObjectPath = "/Script/Engine.NetworkSettings";

		// Token: 0x04006FB9 RID: 28601
		private static IntPtr _ClassPtr;

		// Token: 0x04006FBA RID: 28602
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006FBB RID: 28603
		internal static int __PropertyOffset_bVerifyPeer;

		// Token: 0x04006FBC RID: 28604
		internal static byte __PropertyMask_bVerifyPeer;

		// Token: 0x04006FBD RID: 28605
		internal static int __PropertyOffset_bEnableMultiplayerWorldOriginRebasing;

		// Token: 0x04006FBE RID: 28606
		internal static byte __PropertyMask_bEnableMultiplayerWorldOriginRebasing;

		// Token: 0x04006FBF RID: 28607
		internal static int __PropertyOffset_MaxRepArraySize;

		// Token: 0x04006FC0 RID: 28608
		internal static int __PropertyOffset_MaxRepArrayMemory;

		// Token: 0x04006FC1 RID: 28609
		internal static int __PropertyOffset_NetworkEmulationProfiles;

		// Token: 0x04006FC2 RID: 28610
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNetworkEmulationProfileDescription> _NetworkEmulationProfiles;
	}
}
