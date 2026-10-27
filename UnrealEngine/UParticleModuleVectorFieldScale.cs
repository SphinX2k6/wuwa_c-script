using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FB7 RID: 4023
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleVectorFieldScale")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UParticleModuleVectorFieldScale : UParticleModuleVectorFieldBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D8A7 RID: 55463 RVA: 0x0013FACF File Offset: 0x0013DCCF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleVectorFieldScale._ClassPtr;
		}

		// Token: 0x0600D8A8 RID: 55464 RVA: 0x0013FADC File Offset: 0x0013DCDC
		public UParticleModuleVectorFieldScale() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVectorFieldScale.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D8A9 RID: 55465 RVA: 0x0013FB04 File Offset: 0x0013DD04
		public UParticleModuleVectorFieldScale(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVectorFieldScale.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003314 RID: 13076
		// (get) Token: 0x0600D8AA RID: 55466 RVA: 0x0013FB37 File Offset: 0x0013DD37
		// (set) Token: 0x0600D8AB RID: 55467 RVA: 0x0013FB4B File Offset: 0x0013DD4B
		[Nullable(2)]
		public unsafe UDistributionFloat VectorFieldScale_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDistributionFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleVectorFieldScale.__PropertyOffset_VectorFieldScale_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleVectorFieldScale.__PropertyOffset_VectorFieldScale_DEPRECATED, value);
			}
		}

		// Token: 0x17003315 RID: 13077
		// (get) Token: 0x0600D8AC RID: 55468 RVA: 0x0013FB60 File Offset: 0x0013DD60
		// (set) Token: 0x0600D8AD RID: 55469 RVA: 0x0013FB99 File Offset: 0x0013DD99
		public FRawDistributionFloat VectorFieldScaleRaw
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._VectorFieldScaleRaw) == null)
				{
					result = (this._VectorFieldScaleRaw = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleVectorFieldScale.__PropertyOffset_VectorFieldScaleRaw, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleVectorFieldScale.__PropertyOffset_VectorFieldScaleRaw, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D8AE RID: 55470 RVA: 0x0013FBBA File Offset: 0x0013DDBA
		static UParticleModuleVectorFieldScale()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleVectorFieldScale");
		}

		// Token: 0x0600D8AF RID: 55471 RVA: 0x0013FBC8 File Offset: 0x0013DDC8
		protected UParticleModuleVectorFieldScale(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400756E RID: 30062
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleVectorFieldScale";

		// Token: 0x0400756F RID: 30063
		private static IntPtr _ClassPtr;

		// Token: 0x04007570 RID: 30064
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007571 RID: 30065
		internal static int __PropertyOffset_VectorFieldScale_DEPRECATED;

		// Token: 0x04007572 RID: 30066
		internal static int __PropertyOffset_VectorFieldScaleRaw;

		// Token: 0x04007573 RID: 30067
		[Nullable(2)]
		private FRawDistributionFloat _VectorFieldScaleRaw;
	}
}
