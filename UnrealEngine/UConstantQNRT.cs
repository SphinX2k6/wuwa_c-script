using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200038B RID: 907
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AudioSynesthesia.ConstantQNRT")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UConstantQNRT : UAudioSynesthesiaNRT, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060031FD RID: 12797 RVA: 0x0004D33D File Offset: 0x0004B53D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UConstantQNRT._ClassPtr;
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x0004D34C File Offset: 0x0004B54C
		public UConstantQNRT() : this(BuiltinUtils.AllocNativeUObject(UConstantQNRT.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x0004D374 File Offset: 0x0004B574
		[NullableContext(1)]
		public UConstantQNRT(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UConstantQNRT.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x06003200 RID: 12800 RVA: 0x0004D3A7 File Offset: 0x0004B5A7
		// (set) Token: 0x06003201 RID: 12801 RVA: 0x0004D3BB File Offset: 0x0004B5BB
		public unsafe UConstantQNRTSettings Settings
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UConstantQNRTSettings>(base.NativePtr / (IntPtr)sizeof(void*) + UConstantQNRT.__PropertyOffset_Settings);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UConstantQNRT.__PropertyOffset_Settings, value);
			}
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x0004D3D0 File Offset: 0x0004B5D0
		public void GetNormalizedChannelConstantQAtTime(float InSeconds, int InChannel, ref TArray<float> OutConstantQ)
		{
			UConstantQNRT.__GetNormalizedChannelConstantQAtTime_Internal(base.NativePtr, InSeconds, InChannel, (OutConstantQ ?? new TArray<float>()).NativePtr);
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x0004D3EF File Offset: 0x0004B5EF
		public void GetChannelConstantQAtTime(float InSeconds, int InChannel, ref TArray<float> OutConstantQ)
		{
			UConstantQNRT.__GetChannelConstantQAtTime_Internal(base.NativePtr, InSeconds, InChannel, (OutConstantQ ?? new TArray<float>()).NativePtr);
		}

		// Token: 0x06003204 RID: 12804
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetNormalizedChannelConstantQAtTime_Internal(IntPtr @this, float InSeconds, int InChannel, IntPtr OutConstantQ);

		// Token: 0x06003205 RID: 12805
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetChannelConstantQAtTime_Internal(IntPtr @this, float InSeconds, int InChannel, IntPtr OutConstantQ);

		// Token: 0x06003206 RID: 12806 RVA: 0x0004D40E File Offset: 0x0004B60E
		static UConstantQNRT()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioSynesthesia.ConstantQNRT");
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x0004D41C File Offset: 0x0004B61C
		protected UConstantQNRT(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040015D7 RID: 5591
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioSynesthesia.ConstantQNRT";

		// Token: 0x040015D8 RID: 5592
		private static IntPtr _ClassPtr;

		// Token: 0x040015D9 RID: 5593
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040015DA RID: 5594
		internal static int __PropertyOffset_Settings;
	}
}
