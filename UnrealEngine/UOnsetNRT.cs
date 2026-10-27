using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000392 RID: 914
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AudioSynesthesia.OnsetNRT")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UOnsetNRT : UAudioSynesthesiaNRT, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003241 RID: 12865 RVA: 0x0004D86F File Offset: 0x0004BA6F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOnsetNRT._ClassPtr;
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x0004D87C File Offset: 0x0004BA7C
		public UOnsetNRT() : this(BuiltinUtils.AllocNativeUObject(UOnsetNRT.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x0004D8A4 File Offset: 0x0004BAA4
		[NullableContext(1)]
		public UOnsetNRT(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOnsetNRT.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06003244 RID: 12868 RVA: 0x0004D8D7 File Offset: 0x0004BAD7
		// (set) Token: 0x06003245 RID: 12869 RVA: 0x0004D8EB File Offset: 0x0004BAEB
		public unsafe UOnsetNRTSettings Settings
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UOnsetNRTSettings>(base.NativePtr / (IntPtr)sizeof(void*) + UOnsetNRT.__PropertyOffset_Settings);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UOnsetNRT.__PropertyOffset_Settings, value);
			}
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x0004D900 File Offset: 0x0004BB00
		public void GetNormalizedChannelOnsetsBetweenTimes(float InStartSeconds, float InEndSeconds, int InChannel, ref TArray<float> OutOnsetTimestamps, ref TArray<float> OutOnsetStrengths)
		{
			UOnsetNRT.__GetNormalizedChannelOnsetsBetweenTimes_Internal(base.NativePtr, InStartSeconds, InEndSeconds, InChannel, (OutOnsetTimestamps ?? new TArray<float>()).NativePtr, (OutOnsetStrengths ?? new TArray<float>()).NativePtr);
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x0004D932 File Offset: 0x0004BB32
		public void GetChannelOnsetsBetweenTimes(float InStartSeconds, float InEndSeconds, int InChannel, ref TArray<float> OutOnsetTimestamps, ref TArray<float> OutOnsetStrengths)
		{
			UOnsetNRT.__GetChannelOnsetsBetweenTimes_Internal(base.NativePtr, InStartSeconds, InEndSeconds, InChannel, (OutOnsetTimestamps ?? new TArray<float>()).NativePtr, (OutOnsetStrengths ?? new TArray<float>()).NativePtr);
		}

		// Token: 0x06003248 RID: 12872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetNormalizedChannelOnsetsBetweenTimes_Internal(IntPtr @this, float InStartSeconds, float InEndSeconds, int InChannel, IntPtr OutOnsetTimestamps, IntPtr OutOnsetStrengths);

		// Token: 0x06003249 RID: 12873
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetChannelOnsetsBetweenTimes_Internal(IntPtr @this, float InStartSeconds, float InEndSeconds, int InChannel, IntPtr OutOnsetTimestamps, IntPtr OutOnsetStrengths);

		// Token: 0x0600324A RID: 12874 RVA: 0x0004D964 File Offset: 0x0004BB64
		static UOnsetNRT()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioSynesthesia.OnsetNRT");
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x0004D972 File Offset: 0x0004BB72
		protected UOnsetNRT(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400160C RID: 5644
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioSynesthesia.OnsetNRT";

		// Token: 0x0400160D RID: 5645
		private static IntPtr _ClassPtr;

		// Token: 0x0400160E RID: 5646
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400160F RID: 5647
		internal static int __PropertyOffset_Settings;
	}
}
