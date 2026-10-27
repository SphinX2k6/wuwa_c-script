using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F4F RID: 3919
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleAccelerationDragScaleOverLife")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UParticleModuleAccelerationDragScaleOverLife : UParticleModuleAccelerationBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D36F RID: 54127 RVA: 0x0013617D File Offset: 0x0013437D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleAccelerationDragScaleOverLife._ClassPtr;
		}

		// Token: 0x0600D370 RID: 54128 RVA: 0x0013618C File Offset: 0x0013438C
		public UParticleModuleAccelerationDragScaleOverLife() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAccelerationDragScaleOverLife.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D371 RID: 54129 RVA: 0x001361B4 File Offset: 0x001343B4
		public UParticleModuleAccelerationDragScaleOverLife(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAccelerationDragScaleOverLife.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003170 RID: 12656
		// (get) Token: 0x0600D372 RID: 54130 RVA: 0x001361E7 File Offset: 0x001343E7
		// (set) Token: 0x0600D373 RID: 54131 RVA: 0x001361FB File Offset: 0x001343FB
		[Nullable(2)]
		public unsafe UDistributionFloat DragScale_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDistributionFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleAccelerationDragScaleOverLife.__PropertyOffset_DragScale_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UParticleModuleAccelerationDragScaleOverLife.__PropertyOffset_DragScale_DEPRECATED, value);
			}
		}

		// Token: 0x17003171 RID: 12657
		// (get) Token: 0x0600D374 RID: 54132 RVA: 0x00136210 File Offset: 0x00134410
		// (set) Token: 0x0600D375 RID: 54133 RVA: 0x00136249 File Offset: 0x00134449
		public FRawDistributionFloat DragScaleRaw
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._DragScaleRaw) == null)
				{
					result = (this._DragScaleRaw = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleAccelerationDragScaleOverLife.__PropertyOffset_DragScaleRaw, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleAccelerationDragScaleOverLife.__PropertyOffset_DragScaleRaw, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D376 RID: 54134 RVA: 0x0013626A File Offset: 0x0013446A
		static UParticleModuleAccelerationDragScaleOverLife()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleAccelerationDragScaleOverLife");
		}

		// Token: 0x0600D377 RID: 54135 RVA: 0x00136278 File Offset: 0x00134478
		protected UParticleModuleAccelerationDragScaleOverLife(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007187 RID: 29063
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleAccelerationDragScaleOverLife";

		// Token: 0x04007188 RID: 29064
		private static IntPtr _ClassPtr;

		// Token: 0x04007189 RID: 29065
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400718A RID: 29066
		internal static int __PropertyOffset_DragScale_DEPRECATED;

		// Token: 0x0400718B RID: 29067
		internal static int __PropertyOffset_DragScaleRaw;

		// Token: 0x0400718C RID: 29068
		[Nullable(2)]
		private FRawDistributionFloat _DragScaleRaw;
	}
}
