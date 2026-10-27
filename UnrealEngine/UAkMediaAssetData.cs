using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000221 RID: 545
	[UnrealObjectPath("/Script/AkAudio.AkMediaAssetData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UAkMediaAssetData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002029 RID: 8233 RVA: 0x0002FAB6 File Offset: 0x0002DCB6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkMediaAssetData._ClassPtr;
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x0002FAC4 File Offset: 0x0002DCC4
		public UAkMediaAssetData() : this(BuiltinUtils.AllocNativeUObject(UAkMediaAssetData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x0002FAEC File Offset: 0x0002DCEC
		[NullableContext(1)]
		public UAkMediaAssetData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkMediaAssetData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x0002FB1F File Offset: 0x0002DD1F
		static UAkMediaAssetData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkMediaAssetData");
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x0002FB2D File Offset: 0x0002DD2D
		protected UAkMediaAssetData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000AC4 RID: 2756
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkMediaAssetData";

		// Token: 0x04000AC5 RID: 2757
		private static IntPtr _ClassPtr;

		// Token: 0x04000AC6 RID: 2758
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
