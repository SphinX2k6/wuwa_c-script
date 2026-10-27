using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000363 RID: 867
	[UnrealObjectPath("/Script/AudioAnalyzer.AudioAnalyzerAsset")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UAudioAnalyzerAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003015 RID: 12309 RVA: 0x0004A886 File Offset: 0x00048A86
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAudioAnalyzerAsset._ClassPtr;
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x0004A892 File Offset: 0x00048A92
		static UAudioAnalyzerAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioAnalyzer.AudioAnalyzerAsset");
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x0004A8A0 File Offset: 0x00048AA0
		protected UAudioAnalyzerAsset() : this(BuiltinUtils.AllocNativeUObject(UAudioAnalyzerAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x0004A8C8 File Offset: 0x00048AC8
		protected UAudioAnalyzerAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040014E3 RID: 5347
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioAnalyzer.AudioAnalyzerAsset";

		// Token: 0x040014E4 RID: 5348
		private static IntPtr _ClassPtr;

		// Token: 0x040014E5 RID: 5349
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
