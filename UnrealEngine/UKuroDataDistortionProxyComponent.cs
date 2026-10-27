using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ADC RID: 6876
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroDataDistortionProxyComponent")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UKuroDataDistortionProxyComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060199E7 RID: 104935 RVA: 0x0025DCFC File Offset: 0x0025BEFC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDataDistortionProxyComponent._ClassPtr;
		}

		// Token: 0x060199E8 RID: 104936 RVA: 0x0025DD08 File Offset: 0x0025BF08
		public UKuroDataDistortionProxyComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroDataDistortionProxyComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060199E9 RID: 104937 RVA: 0x0025DD30 File Offset: 0x0025BF30
		[NullableContext(1)]
		public UKuroDataDistortionProxyComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDataDistortionProxyComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006650 RID: 26192
		// (get) Token: 0x060199EA RID: 104938 RVA: 0x0025DD63 File Offset: 0x0025BF63
		// (set) Token: 0x060199EB RID: 104939 RVA: 0x0025DD73 File Offset: 0x0025BF73
		public unsafe float PhaseBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDataDistortionProxyComponent.__PropertyOffset_PhaseBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDataDistortionProxyComponent.__PropertyOffset_PhaseBias) = value;
			}
		}

		// Token: 0x17006651 RID: 26193
		// (get) Token: 0x060199EC RID: 104940 RVA: 0x0025DD84 File Offset: 0x0025BF84
		// (set) Token: 0x060199ED RID: 104941 RVA: 0x0025DD94 File Offset: 0x0025BF94
		public unsafe float DurationScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDataDistortionProxyComponent.__PropertyOffset_DurationScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDataDistortionProxyComponent.__PropertyOffset_DurationScale) = value;
			}
		}

		// Token: 0x060199EE RID: 104942 RVA: 0x0025DDA5 File Offset: 0x0025BFA5
		static UKuroDataDistortionProxyComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroDataDistortionProxyComponent");
		}

		// Token: 0x060199EF RID: 104943 RVA: 0x0025DDB3 File Offset: 0x0025BFB3
		protected UKuroDataDistortionProxyComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DF0D RID: 57101
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDataDistortionProxyComponent";

		// Token: 0x0400DF0E RID: 57102
		private static IntPtr _ClassPtr;

		// Token: 0x0400DF0F RID: 57103
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DF10 RID: 57104
		internal static int __PropertyOffset_PhaseBias;

		// Token: 0x0400DF11 RID: 57105
		internal static int __PropertyOffset_DurationScale;
	}
}
