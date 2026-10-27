using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FB3 RID: 4019
	[UnrealObjectPath("/Script/Engine.ParticleModuleVectorFieldGlobal")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UParticleModuleVectorFieldGlobal : UParticleModuleVectorFieldBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D871 RID: 55409 RVA: 0x0013F575 File Offset: 0x0013D775
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleVectorFieldGlobal._ClassPtr;
		}

		// Token: 0x0600D872 RID: 55410 RVA: 0x0013F584 File Offset: 0x0013D784
		public UParticleModuleVectorFieldGlobal() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVectorFieldGlobal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D873 RID: 55411 RVA: 0x0013F5AC File Offset: 0x0013D7AC
		[NullableContext(1)]
		public UParticleModuleVectorFieldGlobal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVectorFieldGlobal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003303 RID: 13059
		// (get) Token: 0x0600D874 RID: 55412 RVA: 0x0013F5DF File Offset: 0x0013D7DF
		// (set) Token: 0x0600D875 RID: 55413 RVA: 0x0013F5F8 File Offset: 0x0013D7F8
		public unsafe bool bOverrideGlobalVectorFieldTightness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldGlobal.__PropertyOffset_bOverrideGlobalVectorFieldTightness) & UParticleModuleVectorFieldGlobal.__PropertyMask_bOverrideGlobalVectorFieldTightness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleVectorFieldGlobal.__PropertyOffset_bOverrideGlobalVectorFieldTightness) = ((*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldGlobal.__PropertyOffset_bOverrideGlobalVectorFieldTightness) & ~UParticleModuleVectorFieldGlobal.__PropertyMask_bOverrideGlobalVectorFieldTightness) | (value ? UParticleModuleVectorFieldGlobal.__PropertyMask_bOverrideGlobalVectorFieldTightness : 0));
			}
		}

		// Token: 0x17003304 RID: 13060
		// (get) Token: 0x0600D876 RID: 55414 RVA: 0x0013F628 File Offset: 0x0013D828
		// (set) Token: 0x0600D877 RID: 55415 RVA: 0x0013F638 File Offset: 0x0013D838
		public unsafe float GlobalVectorFieldScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleVectorFieldGlobal.__PropertyOffset_GlobalVectorFieldScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldGlobal.__PropertyOffset_GlobalVectorFieldScale) = value;
			}
		}

		// Token: 0x17003305 RID: 13061
		// (get) Token: 0x0600D878 RID: 55416 RVA: 0x0013F649 File Offset: 0x0013D849
		// (set) Token: 0x0600D879 RID: 55417 RVA: 0x0013F659 File Offset: 0x0013D859
		public unsafe float GlobalVectorFieldTightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleVectorFieldGlobal.__PropertyOffset_GlobalVectorFieldTightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleVectorFieldGlobal.__PropertyOffset_GlobalVectorFieldTightness) = value;
			}
		}

		// Token: 0x0600D87A RID: 55418 RVA: 0x0013F66A File Offset: 0x0013D86A
		static UParticleModuleVectorFieldGlobal()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleVectorFieldGlobal");
		}

		// Token: 0x0600D87B RID: 55419 RVA: 0x0013F678 File Offset: 0x0013D878
		protected UParticleModuleVectorFieldGlobal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400754B RID: 30027
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleVectorFieldGlobal";

		// Token: 0x0400754C RID: 30028
		private static IntPtr _ClassPtr;

		// Token: 0x0400754D RID: 30029
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400754E RID: 30030
		internal static int __PropertyOffset_bOverrideGlobalVectorFieldTightness;

		// Token: 0x0400754F RID: 30031
		internal static byte __PropertyMask_bOverrideGlobalVectorFieldTightness;

		// Token: 0x04007550 RID: 30032
		internal static int __PropertyOffset_GlobalVectorFieldScale;

		// Token: 0x04007551 RID: 30033
		internal static int __PropertyOffset_GlobalVectorFieldTightness;
	}
}
