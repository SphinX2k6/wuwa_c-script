using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F6A RID: 3946
	[UnrealObjectPath("/Script/Engine.ParticleModuleEventSendToGame")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UParticleModuleEventSendToGame : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D4F7 RID: 54519 RVA: 0x0013911F File Offset: 0x0013731F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleEventSendToGame._ClassPtr;
		}

		// Token: 0x0600D4F8 RID: 54520 RVA: 0x0013912B File Offset: 0x0013732B
		static UParticleModuleEventSendToGame()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleEventSendToGame");
		}

		// Token: 0x0600D4F9 RID: 54521 RVA: 0x0013913C File Offset: 0x0013733C
		protected UParticleModuleEventSendToGame() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleEventSendToGame.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D4FA RID: 54522 RVA: 0x00139164 File Offset: 0x00137364
		protected UParticleModuleEventSendToGame(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040072BA RID: 29370
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleEventSendToGame";

		// Token: 0x040072BB RID: 29371
		private static IntPtr _ClassPtr;

		// Token: 0x040072BC RID: 29372
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
