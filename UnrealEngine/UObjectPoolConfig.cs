using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000137 RID: 311
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.ObjectPoolConfig")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UObjectPoolConfig : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001266 RID: 4710 RVA: 0x0001D1F5 File Offset: 0x0001B3F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UObjectPoolConfig._ClassPtr;
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x0001D204 File Offset: 0x0001B404
		public UObjectPoolConfig() : this(BuiltinUtils.AllocNativeUObject(UObjectPoolConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x0001D22C File Offset: 0x0001B42C
		public UObjectPoolConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UObjectPoolConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x0001D25F File Offset: 0x0001B45F
		// (set) Token: 0x0600126A RID: 4714 RVA: 0x0001D26F File Offset: 0x0001B46F
		public unsafe float ShrinkFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UObjectPoolConfig.__PropertyOffset_ShrinkFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UObjectPoolConfig.__PropertyOffset_ShrinkFactor) = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x0001D280 File Offset: 0x0001B480
		// (set) Token: 0x0600126C RID: 4716 RVA: 0x0001D290 File Offset: 0x0001B490
		public unsafe float ScaleFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UObjectPoolConfig.__PropertyOffset_ScaleFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UObjectPoolConfig.__PropertyOffset_ScaleFactor) = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x0001D2A4 File Offset: 0x0001B4A4
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x0001D2DD File Offset: 0x0001B4DD
		public TArray<FObjectPoolInstanceConfig> InstanceConfigs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FObjectPoolInstanceConfig> result;
				if ((result = this._InstanceConfigs) == null)
				{
					result = (this._InstanceConfigs = new TArray<FObjectPoolInstanceConfig>(base.NativePtr + (IntPtr)UObjectPoolConfig.__PropertyOffset_InstanceConfigs, this));
				}
				return result;
			}
			set
			{
				this.InstanceConfigs.CopyAssign(value);
			}
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0001D2EB File Offset: 0x0001B4EB
		static UObjectPoolConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.ObjectPoolConfig");
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x0001D2F9 File Offset: 0x0001B4F9
		protected UObjectPoolConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005A1 RID: 1441
		public new const string __ObjectPath = "/Script/CoreUObject.ObjectPoolConfig";

		// Token: 0x040005A2 RID: 1442
		private static IntPtr _ClassPtr;

		// Token: 0x040005A3 RID: 1443
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040005A4 RID: 1444
		internal static int __PropertyOffset_ShrinkFactor;

		// Token: 0x040005A5 RID: 1445
		internal static int __PropertyOffset_ScaleFactor;

		// Token: 0x040005A6 RID: 1446
		internal static int __PropertyOffset_InstanceConfigs;

		// Token: 0x040005A7 RID: 1447
		[Nullable(2)]
		private TArray<FObjectPoolInstanceConfig> _InstanceConfigs;
	}
}
