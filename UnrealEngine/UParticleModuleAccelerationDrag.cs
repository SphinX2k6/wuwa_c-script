using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F4E RID: 3918
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleAccelerationDrag")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UParticleModuleAccelerationDrag : UParticleModuleAccelerationBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D366 RID: 54118 RVA: 0x0013607B File Offset: 0x0013427B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleAccelerationDrag._ClassPtr;
		}

		// Token: 0x0600D367 RID: 54119 RVA: 0x00136088 File Offset: 0x00134288
		public UParticleModuleAccelerationDrag() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAccelerationDrag.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D368 RID: 54120 RVA: 0x001360B0 File Offset: 0x001342B0
		public UParticleModuleAccelerationDrag(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAccelerationDrag.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700316E RID: 12654
		// (get) Token: 0x0600D369 RID: 54121 RVA: 0x001360E3 File Offset: 0x001342E3
		// (set) Token: 0x0600D36A RID: 54122 RVA: 0x001360F7 File Offset: 0x001342F7
		[Nullable(2)]
		public unsafe UDistributionFloat DragCoefficient_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDistributionFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleAccelerationDrag.__PropertyOffset_DragCoefficient_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleAccelerationDrag.__PropertyOffset_DragCoefficient_DEPRECATED, value);
			}
		}

		// Token: 0x1700316F RID: 12655
		// (get) Token: 0x0600D36B RID: 54123 RVA: 0x0013610C File Offset: 0x0013430C
		// (set) Token: 0x0600D36C RID: 54124 RVA: 0x00136145 File Offset: 0x00134345
		public FRawDistributionFloat DragCoefficientRaw
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._DragCoefficientRaw) == null)
				{
					result = (this._DragCoefficientRaw = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleAccelerationDrag.__PropertyOffset_DragCoefficientRaw, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleAccelerationDrag.__PropertyOffset_DragCoefficientRaw, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D36D RID: 54125 RVA: 0x00136166 File Offset: 0x00134366
		static UParticleModuleAccelerationDrag()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleAccelerationDrag");
		}

		// Token: 0x0600D36E RID: 54126 RVA: 0x00136174 File Offset: 0x00134374
		protected UParticleModuleAccelerationDrag(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007181 RID: 29057
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleAccelerationDrag";

		// Token: 0x04007182 RID: 29058
		private static IntPtr _ClassPtr;

		// Token: 0x04007183 RID: 29059
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007184 RID: 29060
		internal static int __PropertyOffset_DragCoefficient_DEPRECATED;

		// Token: 0x04007185 RID: 29061
		internal static int __PropertyOffset_DragCoefficientRaw;

		// Token: 0x04007186 RID: 29062
		[Nullable(2)]
		private FRawDistributionFloat _DragCoefficientRaw;
	}
}
