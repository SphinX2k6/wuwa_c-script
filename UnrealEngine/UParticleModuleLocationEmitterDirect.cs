using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F79 RID: 3961
	[UnrealObjectPath("/Script/Engine.ParticleModuleLocationEmitterDirect")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UParticleModuleLocationEmitterDirect : UParticleModuleLocationBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D59B RID: 54683 RVA: 0x0013A36C File Offset: 0x0013856C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLocationEmitterDirect._ClassPtr;
		}

		// Token: 0x0600D59C RID: 54684 RVA: 0x0013A378 File Offset: 0x00138578
		public UParticleModuleLocationEmitterDirect() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationEmitterDirect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D59D RID: 54685 RVA: 0x0013A3A0 File Offset: 0x001385A0
		[NullableContext(1)]
		public UParticleModuleLocationEmitterDirect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationEmitterDirect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003223 RID: 12835
		// (get) Token: 0x0600D59E RID: 54686 RVA: 0x0013A3D3 File Offset: 0x001385D3
		// (set) Token: 0x0600D59F RID: 54687 RVA: 0x0013A3E7 File Offset: 0x001385E7
		public unsafe FName EmitterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationEmitterDirect.__PropertyOffset_EmitterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationEmitterDirect.__PropertyOffset_EmitterName) = value;
			}
		}

		// Token: 0x0600D5A0 RID: 54688 RVA: 0x0013A3FC File Offset: 0x001385FC
		static UParticleModuleLocationEmitterDirect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLocationEmitterDirect");
		}

		// Token: 0x0600D5A1 RID: 54689 RVA: 0x0013A40A File Offset: 0x0013860A
		protected UParticleModuleLocationEmitterDirect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007332 RID: 29490
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLocationEmitterDirect";

		// Token: 0x04007333 RID: 29491
		private static IntPtr _ClassPtr;

		// Token: 0x04007334 RID: 29492
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007335 RID: 29493
		internal static int __PropertyOffset_EmitterName;
	}
}
