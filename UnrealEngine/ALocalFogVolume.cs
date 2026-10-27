using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D5E RID: 3422
	[UnrealObjectPath("/Script/Engine.LocalFogVolume")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class ALocalFogVolume : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B8CF RID: 47311 RVA: 0x0010713A File Offset: 0x0010533A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALocalFogVolume._ClassPtr;
		}

		// Token: 0x0600B8D0 RID: 47312 RVA: 0x00107148 File Offset: 0x00105348
		public ALocalFogVolume() : this(BuiltinUtils.AllocNativeUObject(ALocalFogVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B8D1 RID: 47313 RVA: 0x00107170 File Offset: 0x00105370
		[NullableContext(1)]
		public ALocalFogVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALocalFogVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A55 RID: 10837
		// (get) Token: 0x0600B8D2 RID: 47314 RVA: 0x001071A3 File Offset: 0x001053A3
		// (set) Token: 0x0600B8D3 RID: 47315 RVA: 0x001071B7 File Offset: 0x001053B7
		[Nullable(2)]
		public unsafe ULocalFogVolumeComponent LocalFogVolumeVolume
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULocalFogVolumeComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ALocalFogVolume.__PropertyOffset_LocalFogVolumeVolume);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALocalFogVolume.__PropertyOffset_LocalFogVolumeVolume, value);
			}
		}

		// Token: 0x0600B8D4 RID: 47316 RVA: 0x001071CC File Offset: 0x001053CC
		static ALocalFogVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LocalFogVolume");
		}

		// Token: 0x0600B8D5 RID: 47317 RVA: 0x001071DA File Offset: 0x001053DA
		protected ALocalFogVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040060DB RID: 24795
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LocalFogVolume";

		// Token: 0x040060DC RID: 24796
		private static IntPtr _ClassPtr;

		// Token: 0x040060DD RID: 24797
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040060DE RID: 24798
		internal static int __PropertyOffset_LocalFogVolumeVolume;
	}
}
