using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B9D RID: 7069
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroRenderingDataDistortionProxyManageSystem")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKuroRenderingDataDistortionProxyManageSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AEA1 RID: 110241 RVA: 0x0027AD0E File Offset: 0x00278F0E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRenderingDataDistortionProxyManageSystem._ClassPtr;
		}

		// Token: 0x0601AEA2 RID: 110242 RVA: 0x0027AD1C File Offset: 0x00278F1C
		public UKuroRenderingDataDistortionProxyManageSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroRenderingDataDistortionProxyManageSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AEA3 RID: 110243 RVA: 0x0027AD44 File Offset: 0x00278F44
		public UKuroRenderingDataDistortionProxyManageSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRenderingDataDistortionProxyManageSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C68 RID: 27752
		// (get) Token: 0x0601AEA4 RID: 110244 RVA: 0x0027AD78 File Offset: 0x00278F78
		// (set) Token: 0x0601AEA5 RID: 110245 RVA: 0x0027ADB1 File Offset: 0x00278FB1
		public TArray<UKuroDataDistortionProxyComponent> ProxyComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroDataDistortionProxyComponent> result;
				if ((result = this._ProxyComponents) == null)
				{
					result = (this._ProxyComponents = new TArray<UKuroDataDistortionProxyComponent>(base.NativePtr + (IntPtr)UKuroRenderingDataDistortionProxyManageSystem.__PropertyOffset_ProxyComponents, this));
				}
				return result;
			}
			set
			{
				this.ProxyComponents.CopyAssign(value);
			}
		}

		// Token: 0x0601AEA6 RID: 110246 RVA: 0x0027ADC0 File Offset: 0x00278FC0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetWaveConfig(UObject WorldContextObject, FVector WaveDirection, float WaveInterval, float WaveDuration, float WavePhaseSpeed)
		{
			UKuroRenderingDataDistortionProxyManageSystem.__SetWaveConfig_FunctionParams* ptr = stackalloc UKuroRenderingDataDistortionProxyManageSystem.__SetWaveConfig_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroRenderingDataDistortionProxyManageSystem.__SetWaveConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRenderingDataDistortionProxyManageSystem.__SetWaveConfig_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldContextObject = ((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
			ptr->WaveDirection = WaveDirection;
			ptr->WaveInterval = WaveInterval;
			ptr->WaveDuration = WaveDuration;
			ptr->WavePhaseSpeed = WavePhaseSpeed;
			UnrealReflectionUtils.CallUFunction(UKuroRenderingDataDistortionProxyManageSystem._ClassDefaultObjectPtr, UKuroRenderingDataDistortionProxyManageSystem.__SetWaveConfig_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601AEA7 RID: 110247 RVA: 0x0027AE32 File Offset: 0x00279032
		static UKuroRenderingDataDistortionProxyManageSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroRenderingDataDistortionProxyManageSystem");
		}

		// Token: 0x0601AEA8 RID: 110248 RVA: 0x0027AE40 File Offset: 0x00279040
		protected UKuroRenderingDataDistortionProxyManageSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E8F5 RID: 59637
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroRenderingDataDistortionProxyManageSystem";

		// Token: 0x0400E8F6 RID: 59638
		private static IntPtr _ClassPtr;

		// Token: 0x0400E8F7 RID: 59639
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E8F8 RID: 59640
		internal static int __PropertyOffset_ProxyComponents;

		// Token: 0x0400E8F9 RID: 59641
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroDataDistortionProxyComponent> _ProxyComponents;

		// Token: 0x0400E8FA RID: 59642
		private static IntPtr __SetWaveConfig_NativeFunctionPtr;

		// Token: 0x0200316A RID: 12650
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetWaveConfig_FunctionParams
		{
			// Token: 0x04016F93 RID: 94099
			[FieldOffset(0)]
			public IntPtr WorldContextObject;

			// Token: 0x04016F94 RID: 94100
			[FieldOffset(8)]
			public FVector WaveDirection;

			// Token: 0x04016F95 RID: 94101
			[FieldOffset(20)]
			public float WaveInterval;

			// Token: 0x04016F96 RID: 94102
			[FieldOffset(24)]
			public float WaveDuration;

			// Token: 0x04016F97 RID: 94103
			[FieldOffset(28)]
			public float WavePhaseSpeed;
		}
	}
}
