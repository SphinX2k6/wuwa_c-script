using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000364 RID: 868
	[UnrealObjectPath("/Script/AudioAnalyzer.AudioAnalyzerNRT")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public abstract class UAudioAnalyzerNRT : UAudioAnalyzerAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003019 RID: 12313 RVA: 0x0004A8D1 File Offset: 0x00048AD1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAudioAnalyzerNRT._ClassPtr;
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x0600301A RID: 12314 RVA: 0x0004A8DD File Offset: 0x00048ADD
		// (set) Token: 0x0600301B RID: 12315 RVA: 0x0004A8F1 File Offset: 0x00048AF1
		[Nullable(2)]
		public unsafe USoundWave Sound
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundWave>(base.NativePtr / (IntPtr)sizeof(void*) + UAudioAnalyzerNRT.__PropertyOffset_Sound);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAudioAnalyzerNRT.__PropertyOffset_Sound, value);
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x0600301C RID: 12316 RVA: 0x0004A906 File Offset: 0x00048B06
		// (set) Token: 0x0600301D RID: 12317 RVA: 0x0004A916 File Offset: 0x00048B16
		public unsafe float DurationInSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioAnalyzerNRT.__PropertyOffset_DurationInSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioAnalyzerNRT.__PropertyOffset_DurationInSeconds) = value;
			}
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x0004A927 File Offset: 0x00048B27
		static UAudioAnalyzerNRT()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioAnalyzer.AudioAnalyzerNRT");
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x0004A938 File Offset: 0x00048B38
		protected UAudioAnalyzerNRT() : this(BuiltinUtils.AllocNativeUObject(UAudioAnalyzerNRT.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x0004A960 File Offset: 0x00048B60
		protected UAudioAnalyzerNRT(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040014E6 RID: 5350
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioAnalyzer.AudioAnalyzerNRT";

		// Token: 0x040014E7 RID: 5351
		private static IntPtr _ClassPtr;

		// Token: 0x040014E8 RID: 5352
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040014E9 RID: 5353
		internal static int __PropertyOffset_Sound;

		// Token: 0x040014EA RID: 5354
		internal static int __PropertyOffset_DurationInSeconds;
	}
}
