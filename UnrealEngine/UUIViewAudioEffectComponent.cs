using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021E0 RID: 8672
	[UnrealObjectPath("/Script/LGUI.UIViewAudioEffectComponent")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UUIViewAudioEffectComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602110C RID: 135436 RVA: 0x0030C2EB File Offset: 0x0030A4EB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIViewAudioEffectComponent._ClassPtr;
		}

		// Token: 0x0602110D RID: 135437 RVA: 0x0030C2F8 File Offset: 0x0030A4F8
		public UUIViewAudioEffectComponent() : this(BuiltinUtils.AllocNativeUObject(UUIViewAudioEffectComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602110E RID: 135438 RVA: 0x0030C320 File Offset: 0x0030A520
		[NullableContext(1)]
		public UUIViewAudioEffectComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIViewAudioEffectComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700810C RID: 33036
		// (get) Token: 0x0602110F RID: 135439 RVA: 0x0030C353 File Offset: 0x0030A553
		// (set) Token: 0x06021110 RID: 135440 RVA: 0x0030C363 File Offset: 0x0030A563
		public unsafe bool bAudioCoverEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIViewAudioEffectComponent.__PropertyOffset_bAudioCoverEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIViewAudioEffectComponent.__PropertyOffset_bAudioCoverEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700810D RID: 33037
		// (get) Token: 0x06021111 RID: 135441 RVA: 0x0030C374 File Offset: 0x0030A574
		// (set) Token: 0x06021112 RID: 135442 RVA: 0x0030C384 File Offset: 0x0030A584
		public unsafe float AudioUiAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIViewAudioEffectComponent.__PropertyOffset_AudioUiAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIViewAudioEffectComponent.__PropertyOffset_AudioUiAlpha) = value;
			}
		}

		// Token: 0x1700810E RID: 33038
		// (get) Token: 0x06021113 RID: 135443 RVA: 0x0030C395 File Offset: 0x0030A595
		// (set) Token: 0x06021114 RID: 135444 RVA: 0x0030C3A5 File Offset: 0x0030A5A5
		public unsafe float AudioUiCover
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIViewAudioEffectComponent.__PropertyOffset_AudioUiCover);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIViewAudioEffectComponent.__PropertyOffset_AudioUiCover) = value;
			}
		}

		// Token: 0x06021115 RID: 135445 RVA: 0x0030C3B6 File Offset: 0x0030A5B6
		static UUIViewAudioEffectComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIViewAudioEffectComponent");
		}

		// Token: 0x06021116 RID: 135446 RVA: 0x0030C3C4 File Offset: 0x0030A5C4
		protected UUIViewAudioEffectComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A3B RID: 72251
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIViewAudioEffectComponent";

		// Token: 0x04011A3C RID: 72252
		private static IntPtr _ClassPtr;

		// Token: 0x04011A3D RID: 72253
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A3E RID: 72254
		internal static int __PropertyOffset_bAudioCoverEnable;

		// Token: 0x04011A3F RID: 72255
		internal static int __PropertyOffset_AudioUiAlpha;

		// Token: 0x04011A40 RID: 72256
		internal static int __PropertyOffset_AudioUiCover;
	}
}
