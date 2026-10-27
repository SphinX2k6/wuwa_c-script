using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000390 RID: 912
	[UnrealObjectPath("/Script/AudioSynesthesia.LoudnessNRT")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class ULoudnessNRT : UAudioSynesthesiaNRT, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003223 RID: 12835 RVA: 0x0004D611 File Offset: 0x0004B811
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULoudnessNRT._ClassPtr;
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x0004D620 File Offset: 0x0004B820
		public ULoudnessNRT() : this(BuiltinUtils.AllocNativeUObject(ULoudnessNRT.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x0004D648 File Offset: 0x0004B848
		[NullableContext(1)]
		public ULoudnessNRT(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULoudnessNRT.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06003226 RID: 12838 RVA: 0x0004D67B File Offset: 0x0004B87B
		// (set) Token: 0x06003227 RID: 12839 RVA: 0x0004D68F File Offset: 0x0004B88F
		[Nullable(2)]
		public unsafe ULoudnessNRTSettings Settings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULoudnessNRTSettings>(base.NativePtr / (IntPtr)sizeof(void*) + ULoudnessNRT.__PropertyOffset_Settings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULoudnessNRT.__PropertyOffset_Settings, value);
			}
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x0004D6A4 File Offset: 0x0004B8A4
		public unsafe void GetNormalizedLoudnessAtTime(float InSeconds, ref float OutLoudness)
		{
			fixed (float* ptr = &OutLoudness)
			{
				void* ptr2 = (void*)ptr;
				ULoudnessNRT.__GetNormalizedLoudnessAtTime_Internal(base.NativePtr, InSeconds, ref OutLoudness);
			}
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x0004D6C8 File Offset: 0x0004B8C8
		public unsafe void GetNormalizedChannelLoudnessAtTime(float InSeconds, int InChannel, ref float OutLoudness)
		{
			fixed (float* ptr = &OutLoudness)
			{
				void* ptr2 = (void*)ptr;
				ULoudnessNRT.__GetNormalizedChannelLoudnessAtTime_Internal(base.NativePtr, InSeconds, InChannel, ref OutLoudness);
			}
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x0004D6EC File Offset: 0x0004B8EC
		public unsafe void GetLoudnessAtTime(float InSeconds, ref float OutLoudness)
		{
			fixed (float* ptr = &OutLoudness)
			{
				void* ptr2 = (void*)ptr;
				ULoudnessNRT.__GetLoudnessAtTime_Internal(base.NativePtr, InSeconds, ref OutLoudness);
			}
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x0004D710 File Offset: 0x0004B910
		public unsafe void GetChannelLoudnessAtTime(float InSeconds, int InChannel, ref float OutLoudness)
		{
			fixed (float* ptr = &OutLoudness)
			{
				void* ptr2 = (void*)ptr;
				ULoudnessNRT.__GetChannelLoudnessAtTime_Internal(base.NativePtr, InSeconds, InChannel, ref OutLoudness);
			}
		}

		// Token: 0x0600322C RID: 12844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetNormalizedLoudnessAtTime_Internal(IntPtr @this, float InSeconds, ref float OutLoudness);

		// Token: 0x0600322D RID: 12845
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetNormalizedChannelLoudnessAtTime_Internal(IntPtr @this, float InSeconds, int InChannel, ref float OutLoudness);

		// Token: 0x0600322E RID: 12846
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetLoudnessAtTime_Internal(IntPtr @this, float InSeconds, ref float OutLoudness);

		// Token: 0x0600322F RID: 12847
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetChannelLoudnessAtTime_Internal(IntPtr @this, float InSeconds, int InChannel, ref float OutLoudness);

		// Token: 0x06003230 RID: 12848 RVA: 0x0004D733 File Offset: 0x0004B933
		static ULoudnessNRT()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioSynesthesia.LoudnessNRT");
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x0004D741 File Offset: 0x0004B941
		protected ULoudnessNRT(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001600 RID: 5632
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioSynesthesia.LoudnessNRT";

		// Token: 0x04001601 RID: 5633
		private static IntPtr _ClassPtr;

		// Token: 0x04001602 RID: 5634
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001603 RID: 5635
		internal static int __PropertyOffset_Settings;
	}
}
