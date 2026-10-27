using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FC2 RID: 4034
	[UnrealObjectPath("/Script/Engine.ParticleSpriteEmitter")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class UParticleSpriteEmitter : UParticleEmitter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D918 RID: 55576 RVA: 0x001407B0 File Offset: 0x0013E9B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleSpriteEmitter._ClassPtr;
		}

		// Token: 0x0600D919 RID: 55577 RVA: 0x001407BC File Offset: 0x0013E9BC
		public UParticleSpriteEmitter() : this(BuiltinUtils.AllocNativeUObject(UParticleSpriteEmitter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D91A RID: 55578 RVA: 0x001407E4 File Offset: 0x0013E9E4
		[NullableContext(1)]
		public UParticleSpriteEmitter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleSpriteEmitter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600D91B RID: 55579 RVA: 0x00140817 File Offset: 0x0013EA17
		static UParticleSpriteEmitter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleSpriteEmitter");
		}

		// Token: 0x0600D91C RID: 55580 RVA: 0x00140825 File Offset: 0x0013EA25
		protected UParticleSpriteEmitter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040075B6 RID: 30134
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleSpriteEmitter";

		// Token: 0x040075B7 RID: 30135
		private static IntPtr _ClassPtr;

		// Token: 0x040075B8 RID: 30136
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
