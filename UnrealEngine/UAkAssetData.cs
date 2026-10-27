using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001ED RID: 493
	[UnrealObjectPath("/Script/AkAudio.AkAssetData")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UAkAssetData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001D15 RID: 7445 RVA: 0x0002B566 File Offset: 0x00029766
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkAssetData._ClassPtr;
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x0002B574 File Offset: 0x00029774
		public UAkAssetData() : this(BuiltinUtils.AllocNativeUObject(UAkAssetData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x0002B59C File Offset: 0x0002979C
		[NullableContext(1)]
		public UAkAssetData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkAssetData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x0002B5CF File Offset: 0x000297CF
		static UAkAssetData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkAssetData");
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x0002B5DD File Offset: 0x000297DD
		protected UAkAssetData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400098F RID: 2447
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkAssetData";

		// Token: 0x04000990 RID: 2448
		private static IntPtr _ClassPtr;

		// Token: 0x04000991 RID: 2449
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
