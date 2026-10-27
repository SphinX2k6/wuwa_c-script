using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F81 RID: 3969
	[UnrealObjectPath("/Script/Engine.ParticleModuleLocationWorldOffset")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UParticleModuleLocationWorldOffset : UParticleModuleLocation, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D60F RID: 54799 RVA: 0x0013B1AD File Offset: 0x001393AD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLocationWorldOffset._ClassPtr;
		}

		// Token: 0x0600D610 RID: 54800 RVA: 0x0013B1BC File Offset: 0x001393BC
		public UParticleModuleLocationWorldOffset() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationWorldOffset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D611 RID: 54801 RVA: 0x0013B1E4 File Offset: 0x001393E4
		[NullableContext(1)]
		public UParticleModuleLocationWorldOffset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationWorldOffset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600D612 RID: 54802 RVA: 0x0013B217 File Offset: 0x00139417
		static UParticleModuleLocationWorldOffset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLocationWorldOffset");
		}

		// Token: 0x0600D613 RID: 54803 RVA: 0x0013B225 File Offset: 0x00139425
		protected UParticleModuleLocationWorldOffset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400738C RID: 29580
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLocationWorldOffset";

		// Token: 0x0400738D RID: 29581
		private static IntPtr _ClassPtr;

		// Token: 0x0400738E RID: 29582
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
