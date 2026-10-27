using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F47 RID: 3911
	[UnrealObjectPath("/Script/Engine.ParticleEventManager")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AParticleEventManager : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D2F2 RID: 54002 RVA: 0x0013534D File Offset: 0x0013354D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AParticleEventManager._ClassPtr;
		}

		// Token: 0x0600D2F3 RID: 54003 RVA: 0x0013535C File Offset: 0x0013355C
		public AParticleEventManager() : this(BuiltinUtils.AllocNativeUObject(AParticleEventManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D2F4 RID: 54004 RVA: 0x00135384 File Offset: 0x00133584
		[NullableContext(1)]
		public AParticleEventManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AParticleEventManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600D2F5 RID: 54005 RVA: 0x001353B7 File Offset: 0x001335B7
		static AParticleEventManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleEventManager");
		}

		// Token: 0x0600D2F6 RID: 54006 RVA: 0x001353C5 File Offset: 0x001335C5
		protected AParticleEventManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007129 RID: 28969
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleEventManager";

		// Token: 0x0400712A RID: 28970
		private static IntPtr _ClassPtr;

		// Token: 0x0400712B RID: 28971
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
