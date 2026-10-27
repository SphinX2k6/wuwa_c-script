using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001F1 RID: 497
	[UnrealObjectPath("/Script/AkAudio.AkAudioInputComponent")]
	[UnrealStructLayout(1008, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1008)]
	public abstract class UAkAudioInputComponent : UAkComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001D4B RID: 7499 RVA: 0x0002BA4E File Offset: 0x00029C4E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkAudioInputComponent._ClassPtr;
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x0002BA5A File Offset: 0x00029C5A
		public int PostAssociatedAudioInputEvent()
		{
			return UAkAudioInputComponent.__PostAssociatedAudioInputEvent_Internal(base.NativePtr);
		}

		// Token: 0x06001D4D RID: 7501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostAssociatedAudioInputEvent_Internal(IntPtr @this);

		// Token: 0x06001D4E RID: 7502 RVA: 0x0002BA67 File Offset: 0x00029C67
		static UAkAudioInputComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkAudioInputComponent");
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x0002BA78 File Offset: 0x00029C78
		protected UAkAudioInputComponent() : this(BuiltinUtils.AllocNativeUObject(UAkAudioInputComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x0002BAA0 File Offset: 0x00029CA0
		protected UAkAudioInputComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040009A4 RID: 2468
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkAudioInputComponent";

		// Token: 0x040009A5 RID: 2469
		private static IntPtr _ClassPtr;

		// Token: 0x040009A6 RID: 2470
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
