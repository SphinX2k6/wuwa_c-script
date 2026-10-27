using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BEA RID: 7146
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainComponentCustomDataConfig")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UKuroWorldRainComponentCustomDataConfig : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B7F6 RID: 112630 RVA: 0x00287C69 File Offset: 0x00285E69
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroWorldRainComponentCustomDataConfig._ClassPtr;
		}

		// Token: 0x0601B7F7 RID: 112631 RVA: 0x00287C78 File Offset: 0x00285E78
		public UKuroWorldRainComponentCustomDataConfig() : this(BuiltinUtils.AllocNativeUObject(UKuroWorldRainComponentCustomDataConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B7F8 RID: 112632 RVA: 0x00287CA0 File Offset: 0x00285EA0
		public UKuroWorldRainComponentCustomDataConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroWorldRainComponentCustomDataConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006EA6 RID: 28326
		// (get) Token: 0x0601B7F9 RID: 112633 RVA: 0x00287CD4 File Offset: 0x00285ED4
		// (set) Token: 0x0601B7FA RID: 112634 RVA: 0x00287D0D File Offset: 0x00285F0D
		public TArray<FKuroWorldRainCustomData> CustomRandoms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroWorldRainCustomData> result;
				if ((result = this._CustomRandoms) == null)
				{
					result = (this._CustomRandoms = new TArray<FKuroWorldRainCustomData>(base.NativePtr + (IntPtr)UKuroWorldRainComponentCustomDataConfig.__PropertyOffset_CustomRandoms, this));
				}
				return result;
			}
			set
			{
				this.CustomRandoms.CopyAssign(value);
			}
		}

		// Token: 0x0601B7FB RID: 112635 RVA: 0x00287D1B File Offset: 0x00285F1B
		static UKuroWorldRainComponentCustomDataConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainComponentCustomDataConfig");
		}

		// Token: 0x0601B7FC RID: 112636 RVA: 0x00287D29 File Offset: 0x00285F29
		protected UKuroWorldRainComponentCustomDataConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ECAD RID: 60589
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainComponentCustomDataConfig";

		// Token: 0x0400ECAE RID: 60590
		private static IntPtr _ClassPtr;

		// Token: 0x0400ECAF RID: 60591
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ECB0 RID: 60592
		internal static int __PropertyOffset_CustomRandoms;

		// Token: 0x0400ECB1 RID: 60593
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroWorldRainCustomData> _CustomRandoms;
	}
}
