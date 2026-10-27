using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FA1 RID: 4001
	[UnrealObjectPath("/Script/Engine.ParticleModuleSizeScaleBySpeed")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UParticleModuleSizeScaleBySpeed : UParticleModuleSizeBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D754 RID: 55124 RVA: 0x0013D5F8 File Offset: 0x0013B7F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleSizeScaleBySpeed._ClassPtr;
		}

		// Token: 0x0600D755 RID: 55125 RVA: 0x0013D604 File Offset: 0x0013B804
		public UParticleModuleSizeScaleBySpeed() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSizeScaleBySpeed.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D756 RID: 55126 RVA: 0x0013D62C File Offset: 0x0013B82C
		[NullableContext(1)]
		public UParticleModuleSizeScaleBySpeed(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleSizeScaleBySpeed.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700329F RID: 12959
		// (get) Token: 0x0600D757 RID: 55127 RVA: 0x0013D65F File Offset: 0x0013B85F
		// (set) Token: 0x0600D758 RID: 55128 RVA: 0x0013D673 File Offset: 0x0013B873
		public unsafe FVector2D SpeedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleSizeScaleBySpeed.__PropertyOffset_SpeedScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleSizeScaleBySpeed.__PropertyOffset_SpeedScale) = value;
			}
		}

		// Token: 0x170032A0 RID: 12960
		// (get) Token: 0x0600D759 RID: 55129 RVA: 0x0013D688 File Offset: 0x0013B888
		// (set) Token: 0x0600D75A RID: 55130 RVA: 0x0013D69C File Offset: 0x0013B89C
		public unsafe FVector2D MaxScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleSizeScaleBySpeed.__PropertyOffset_MaxScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleSizeScaleBySpeed.__PropertyOffset_MaxScale) = value;
			}
		}

		// Token: 0x0600D75B RID: 55131 RVA: 0x0013D6B1 File Offset: 0x0013B8B1
		static UParticleModuleSizeScaleBySpeed()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleSizeScaleBySpeed");
		}

		// Token: 0x0600D75C RID: 55132 RVA: 0x0013D6BF File Offset: 0x0013B8BF
		protected UParticleModuleSizeScaleBySpeed(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007477 RID: 29815
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleSizeScaleBySpeed";

		// Token: 0x04007478 RID: 29816
		private static IntPtr _ClassPtr;

		// Token: 0x04007479 RID: 29817
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400747A RID: 29818
		internal static int __PropertyOffset_SpeedScale;

		// Token: 0x0400747B RID: 29819
		internal static int __PropertyOffset_MaxScale;
	}
}
