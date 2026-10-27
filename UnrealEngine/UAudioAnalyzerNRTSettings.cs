using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000365 RID: 869
	[UnrealObjectPath("/Script/AudioAnalyzer.AudioAnalyzerNRTSettings")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public abstract class UAudioAnalyzerNRTSettings : UAudioAnalyzerAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003021 RID: 12321 RVA: 0x0004A969 File Offset: 0x00048B69
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAudioAnalyzerNRTSettings._ClassPtr;
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x0004A975 File Offset: 0x00048B75
		static UAudioAnalyzerNRTSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioAnalyzer.AudioAnalyzerNRTSettings");
		}

		// Token: 0x06003023 RID: 12323 RVA: 0x0004A984 File Offset: 0x00048B84
		protected UAudioAnalyzerNRTSettings() : this(BuiltinUtils.AllocNativeUObject(UAudioAnalyzerNRTSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003024 RID: 12324 RVA: 0x0004A9AC File Offset: 0x00048BAC
		protected UAudioAnalyzerNRTSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040014EB RID: 5355
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioAnalyzer.AudioAnalyzerNRTSettings";

		// Token: 0x040014EC RID: 5356
		private static IntPtr _ClassPtr;

		// Token: 0x040014ED RID: 5357
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
