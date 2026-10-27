using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000751 RID: 1873
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.ObjectPoolConfig")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UObjectPoolConfig : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600630A RID: 25354 RVA: 0x0008E275 File Offset: 0x0008C475
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UObjectPoolConfig._ClassPtr;
		}

		// Token: 0x0600630B RID: 25355 RVA: 0x0008E284 File Offset: 0x0008C484
		public UObjectPoolConfig() : this(BuiltinUtils.AllocNativeUObject(UObjectPoolConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600630C RID: 25356 RVA: 0x0008E2AC File Offset: 0x0008C4AC
		public UObjectPoolConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UObjectPoolConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x0600630D RID: 25357 RVA: 0x0008E2DF File Offset: 0x0008C4DF
		// (set) Token: 0x0600630E RID: 25358 RVA: 0x0008E2EF File Offset: 0x0008C4EF
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

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x0600630F RID: 25359 RVA: 0x0008E300 File Offset: 0x0008C500
		// (set) Token: 0x06006310 RID: 25360 RVA: 0x0008E310 File Offset: 0x0008C510
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

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x06006311 RID: 25361 RVA: 0x0008E324 File Offset: 0x0008C524
		// (set) Token: 0x06006312 RID: 25362 RVA: 0x0008E35D File Offset: 0x0008C55D
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

		// Token: 0x06006313 RID: 25363 RVA: 0x0008E36B File Offset: 0x0008C56B
		static UObjectPoolConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.ObjectPoolConfig");
		}

		// Token: 0x06006314 RID: 25364 RVA: 0x0008E379 File Offset: 0x0008C579
		protected UObjectPoolConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F6B RID: 12139
		public new const string __ObjectPath = "/Script/CoreUObject.ObjectPoolConfig";

		// Token: 0x04002F6C RID: 12140
		private static IntPtr _ClassPtr;

		// Token: 0x04002F6D RID: 12141
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002F6E RID: 12142
		internal static int __PropertyOffset_ShrinkFactor;

		// Token: 0x04002F6F RID: 12143
		internal static int __PropertyOffset_ScaleFactor;

		// Token: 0x04002F70 RID: 12144
		internal static int __PropertyOffset_InstanceConfigs;

		// Token: 0x04002F71 RID: 12145
		[Nullable(2)]
		private TArray<FObjectPoolInstanceConfig> _InstanceConfigs;
	}
}
