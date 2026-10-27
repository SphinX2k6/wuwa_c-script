using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001EE RID: 494
	[UnrealObjectPath("/Script/AkAudio.AkAssetPlatformData")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UAkAssetPlatformData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001D1A RID: 7450 RVA: 0x0002B5E6 File Offset: 0x000297E6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkAssetPlatformData._ClassPtr;
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x0002B5F4 File Offset: 0x000297F4
		public UAkAssetPlatformData() : this(BuiltinUtils.AllocNativeUObject(UAkAssetPlatformData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x0002B61C File Offset: 0x0002981C
		[NullableContext(1)]
		public UAkAssetPlatformData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkAssetPlatformData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x0002B64F File Offset: 0x0002984F
		// (set) Token: 0x06001D1E RID: 7454 RVA: 0x0002B663 File Offset: 0x00029863
		[Nullable(2)]
		public unsafe UAkAssetData CurrentAssetData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAssetData>(base.NativePtr / (IntPtr)sizeof(void*) + UAkAssetPlatformData.__PropertyOffset_CurrentAssetData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAkAssetPlatformData.__PropertyOffset_CurrentAssetData, value);
			}
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x0002B678 File Offset: 0x00029878
		static UAkAssetPlatformData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkAssetPlatformData");
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x0002B686 File Offset: 0x00029886
		protected UAkAssetPlatformData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000992 RID: 2450
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkAssetPlatformData";

		// Token: 0x04000993 RID: 2451
		private static IntPtr _ClassPtr;

		// Token: 0x04000994 RID: 2452
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000995 RID: 2453
		internal static int __PropertyOffset_CurrentAssetData;
	}
}
