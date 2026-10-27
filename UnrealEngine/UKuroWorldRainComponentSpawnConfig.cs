using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BEC RID: 7148
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainComponentSpawnConfig")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UKuroWorldRainComponentSpawnConfig : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B824 RID: 112676 RVA: 0x0028819E File Offset: 0x0028639E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroWorldRainComponentSpawnConfig._ClassPtr;
		}

		// Token: 0x0601B825 RID: 112677 RVA: 0x002881AC File Offset: 0x002863AC
		public UKuroWorldRainComponentSpawnConfig() : this(BuiltinUtils.AllocNativeUObject(UKuroWorldRainComponentSpawnConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B826 RID: 112678 RVA: 0x002881D4 File Offset: 0x002863D4
		public UKuroWorldRainComponentSpawnConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroWorldRainComponentSpawnConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006EB8 RID: 28344
		// (get) Token: 0x0601B827 RID: 112679 RVA: 0x00288208 File Offset: 0x00286408
		// (set) Token: 0x0601B828 RID: 112680 RVA: 0x00288241 File Offset: 0x00286441
		public TArray<FKuroWorldRainSpawnInfo> Spawners
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroWorldRainSpawnInfo> result;
				if ((result = this._Spawners) == null)
				{
					result = (this._Spawners = new TArray<FKuroWorldRainSpawnInfo>(base.NativePtr + (IntPtr)UKuroWorldRainComponentSpawnConfig.__PropertyOffset_Spawners, this));
				}
				return result;
			}
			set
			{
				this.Spawners.CopyAssign(value);
			}
		}

		// Token: 0x0601B829 RID: 112681 RVA: 0x0028824F File Offset: 0x0028644F
		static UKuroWorldRainComponentSpawnConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainComponentSpawnConfig");
		}

		// Token: 0x0601B82A RID: 112682 RVA: 0x0028825D File Offset: 0x0028645D
		protected UKuroWorldRainComponentSpawnConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ECCD RID: 60621
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainComponentSpawnConfig";

		// Token: 0x0400ECCE RID: 60622
		private static IntPtr _ClassPtr;

		// Token: 0x0400ECCF RID: 60623
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ECD0 RID: 60624
		internal static int __PropertyOffset_Spawners;

		// Token: 0x0400ECD1 RID: 60625
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroWorldRainSpawnInfo> _Spawners;
	}
}
