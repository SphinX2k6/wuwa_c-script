using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FB5 RID: 4021
	[UnrealObjectPath("/Script/Engine.ParticleModuleVectorFieldRotation")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UParticleModuleVectorFieldRotation : UParticleModuleVectorFieldBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D897 RID: 55447 RVA: 0x0013F955 File Offset: 0x0013DB55
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleVectorFieldRotation._ClassPtr;
		}

		// Token: 0x0600D898 RID: 55448 RVA: 0x0013F964 File Offset: 0x0013DB64
		public UParticleModuleVectorFieldRotation() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVectorFieldRotation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D899 RID: 55449 RVA: 0x0013F98C File Offset: 0x0013DB8C
		[NullableContext(1)]
		public UParticleModuleVectorFieldRotation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVectorFieldRotation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003311 RID: 13073
		// (get) Token: 0x0600D89A RID: 55450 RVA: 0x0013F9BF File Offset: 0x0013DBBF
		// (set) Token: 0x0600D89B RID: 55451 RVA: 0x0013F9D3 File Offset: 0x0013DBD3
		public unsafe FVector MinInitialRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleVectorFieldRotation.__PropertyOffset_MinInitialRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldRotation.__PropertyOffset_MinInitialRotation) = value;
			}
		}

		// Token: 0x17003312 RID: 13074
		// (get) Token: 0x0600D89C RID: 55452 RVA: 0x0013F9E8 File Offset: 0x0013DBE8
		// (set) Token: 0x0600D89D RID: 55453 RVA: 0x0013F9FC File Offset: 0x0013DBFC
		public unsafe FVector MaxInitialRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleVectorFieldRotation.__PropertyOffset_MaxInitialRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldRotation.__PropertyOffset_MaxInitialRotation) = value;
			}
		}

		// Token: 0x0600D89E RID: 55454 RVA: 0x0013FA11 File Offset: 0x0013DC11
		static UParticleModuleVectorFieldRotation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleVectorFieldRotation");
		}

		// Token: 0x0600D89F RID: 55455 RVA: 0x0013FA1F File Offset: 0x0013DC1F
		protected UParticleModuleVectorFieldRotation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007565 RID: 30053
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleVectorFieldRotation";

		// Token: 0x04007566 RID: 30054
		private static IntPtr _ClassPtr;

		// Token: 0x04007567 RID: 30055
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007568 RID: 30056
		internal static int __PropertyOffset_MinInitialRotation;

		// Token: 0x04007569 RID: 30057
		internal static int __PropertyOffset_MaxInitialRotation;
	}
}
