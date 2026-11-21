using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200073C RID: 1852
	[UnrealObjectPath("/Script/LGUI.UIViewAudioEffectComponent")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UUIViewAudioEffectComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A183 RID: 41347 RVA: 0x000EEB07 File Offset: 0x000ECD07
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIViewAudioEffectComponent._ClassPtr;
		}

		// Token: 0x0600A184 RID: 41348 RVA: 0x000EEB14 File Offset: 0x000ECD14
		public UUIViewAudioEffectComponent() : this(BuiltinUtils.AllocNativeUObject(UUIViewAudioEffectComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A185 RID: 41349 RVA: 0x000EEB3C File Offset: 0x000ECD3C
		[NullableContext(1)]
		public UUIViewAudioEffectComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIViewAudioEffectComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x0600A186 RID: 41350 RVA: 0x000EEB6F File Offset: 0x000ECD6F
		// (set) Token: 0x0600A187 RID: 41351 RVA: 0x000EEB7F File Offset: 0x000ECD7F
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

		// Token: 0x17001E17 RID: 7703
		// (get) Token: 0x0600A188 RID: 41352 RVA: 0x000EEB90 File Offset: 0x000ECD90
		// (set) Token: 0x0600A189 RID: 41353 RVA: 0x000EEBA0 File Offset: 0x000ECDA0
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

		// Token: 0x17001E18 RID: 7704
		// (get) Token: 0x0600A18A RID: 41354 RVA: 0x000EEBB1 File Offset: 0x000ECDB1
		// (set) Token: 0x0600A18B RID: 41355 RVA: 0x000EEBC1 File Offset: 0x000ECDC1
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

		// Token: 0x0600A18C RID: 41356 RVA: 0x000EEBD2 File Offset: 0x000ECDD2
		static UUIViewAudioEffectComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIViewAudioEffectComponent");
		}

		// Token: 0x0600A18D RID: 41357 RVA: 0x000EEBE0 File Offset: 0x000ECDE0
		protected UUIViewAudioEffectComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004527 RID: 17703
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIViewAudioEffectComponent";

		// Token: 0x04004528 RID: 17704
		private static IntPtr _ClassPtr;

		// Token: 0x04004529 RID: 17705
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400452A RID: 17706
		internal static int __PropertyOffset_bAudioCoverEnable;

		// Token: 0x0400452B RID: 17707
		internal static int __PropertyOffset_AudioUiAlpha;

		// Token: 0x0400452C RID: 17708
		internal static int __PropertyOffset_AudioUiCover;
	}
}
