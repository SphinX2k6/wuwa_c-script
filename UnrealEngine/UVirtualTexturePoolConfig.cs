using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001234 RID: 4660
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.VirtualTexturePoolConfig")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UVirtualTexturePoolConfig : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011220 RID: 70176 RVA: 0x001923D0 File Offset: 0x001905D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVirtualTexturePoolConfig._ClassPtr;
		}

		// Token: 0x06011221 RID: 70177 RVA: 0x001923DC File Offset: 0x001905DC
		public UVirtualTexturePoolConfig() : this(BuiltinUtils.AllocNativeUObject(UVirtualTexturePoolConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011222 RID: 70178 RVA: 0x00192404 File Offset: 0x00190604
		public UVirtualTexturePoolConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVirtualTexturePoolConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170042D8 RID: 17112
		// (get) Token: 0x06011223 RID: 70179 RVA: 0x00192437 File Offset: 0x00190637
		// (set) Token: 0x06011224 RID: 70180 RVA: 0x00192447 File Offset: 0x00190647
		public unsafe int DefaultSizeInMegabyte
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVirtualTexturePoolConfig.__PropertyOffset_DefaultSizeInMegabyte);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVirtualTexturePoolConfig.__PropertyOffset_DefaultSizeInMegabyte) = value;
			}
		}

		// Token: 0x170042D9 RID: 17113
		// (get) Token: 0x06011225 RID: 70181 RVA: 0x00192458 File Offset: 0x00190658
		// (set) Token: 0x06011226 RID: 70182 RVA: 0x00192491 File Offset: 0x00190691
		public TArray<FVirtualTextureSpacePoolConfig> Pools
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVirtualTextureSpacePoolConfig> result;
				if ((result = this._Pools) == null)
				{
					result = (this._Pools = new TArray<FVirtualTextureSpacePoolConfig>(base.NativePtr + (IntPtr)UVirtualTexturePoolConfig.__PropertyOffset_Pools, this));
				}
				return result;
			}
			set
			{
				this.Pools.CopyAssign(value);
			}
		}

		// Token: 0x06011227 RID: 70183 RVA: 0x0019249F File Offset: 0x0019069F
		static UVirtualTexturePoolConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.VirtualTexturePoolConfig");
		}

		// Token: 0x06011228 RID: 70184 RVA: 0x001924AD File Offset: 0x001906AD
		protected UVirtualTexturePoolConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040092B4 RID: 37556
		public new const string __ObjectPath = "/Script/Engine.VirtualTexturePoolConfig";

		// Token: 0x040092B5 RID: 37557
		private static IntPtr _ClassPtr;

		// Token: 0x040092B6 RID: 37558
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040092B7 RID: 37559
		internal static int __PropertyOffset_DefaultSizeInMegabyte;

		// Token: 0x040092B8 RID: 37560
		internal static int __PropertyOffset_Pools;

		// Token: 0x040092B9 RID: 37561
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FVirtualTextureSpacePoolConfig> _Pools;
	}
}
