using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F91 RID: 3985
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleParameterDynamic")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UParticleModuleParameterDynamic : UParticleModuleParameterBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D683 RID: 54915 RVA: 0x0013BF59 File Offset: 0x0013A159
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleParameterDynamic._ClassPtr;
		}

		// Token: 0x0600D684 RID: 54916 RVA: 0x0013BF68 File Offset: 0x0013A168
		public UParticleModuleParameterDynamic() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleParameterDynamic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D685 RID: 54917 RVA: 0x0013BF90 File Offset: 0x0013A190
		public UParticleModuleParameterDynamic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleParameterDynamic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700325D RID: 12893
		// (get) Token: 0x0600D686 RID: 54918 RVA: 0x0013BFC4 File Offset: 0x0013A1C4
		// (set) Token: 0x0600D687 RID: 54919 RVA: 0x0013BFFD File Offset: 0x0013A1FD
		public TArray<FEmitterDynamicParameter> DynamicParams
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FEmitterDynamicParameter> result;
				if ((result = this._DynamicParams) == null)
				{
					result = (this._DynamicParams = new TArray<FEmitterDynamicParameter>(base.NativePtr + (IntPtr)UParticleModuleParameterDynamic.__PropertyOffset_DynamicParams, this));
				}
				return result;
			}
			set
			{
				this.DynamicParams.CopyAssign(value);
			}
		}

		// Token: 0x1700325E RID: 12894
		// (get) Token: 0x0600D688 RID: 54920 RVA: 0x0013C00B File Offset: 0x0013A20B
		// (set) Token: 0x0600D689 RID: 54921 RVA: 0x0013C01B File Offset: 0x0013A21B
		public unsafe int UpdateFlags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleParameterDynamic.__PropertyOffset_UpdateFlags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleParameterDynamic.__PropertyOffset_UpdateFlags) = value;
			}
		}

		// Token: 0x1700325F RID: 12895
		// (get) Token: 0x0600D68A RID: 54922 RVA: 0x0013C02C File Offset: 0x0013A22C
		// (set) Token: 0x0600D68B RID: 54923 RVA: 0x0013C045 File Offset: 0x0013A245
		public unsafe bool bUsesVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleParameterDynamic.__PropertyOffset_bUsesVelocity) & UParticleModuleParameterDynamic.__PropertyMask_bUsesVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleParameterDynamic.__PropertyOffset_bUsesVelocity) = ((*(base.NativePtr + (IntPtr)UParticleModuleParameterDynamic.__PropertyOffset_bUsesVelocity) & ~UParticleModuleParameterDynamic.__PropertyMask_bUsesVelocity) | (value ? UParticleModuleParameterDynamic.__PropertyMask_bUsesVelocity : 0));
			}
		}

		// Token: 0x0600D68C RID: 54924 RVA: 0x0013C075 File Offset: 0x0013A275
		static UParticleModuleParameterDynamic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleParameterDynamic");
		}

		// Token: 0x0600D68D RID: 54925 RVA: 0x0013C083 File Offset: 0x0013A283
		protected UParticleModuleParameterDynamic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040073E2 RID: 29666
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleParameterDynamic";

		// Token: 0x040073E3 RID: 29667
		private static IntPtr _ClassPtr;

		// Token: 0x040073E4 RID: 29668
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040073E5 RID: 29669
		internal static int __PropertyOffset_DynamicParams;

		// Token: 0x040073E6 RID: 29670
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FEmitterDynamicParameter> _DynamicParams;

		// Token: 0x040073E7 RID: 29671
		internal static int __PropertyOffset_UpdateFlags;

		// Token: 0x040073E8 RID: 29672
		internal static int __PropertyOffset_bUsesVelocity;

		// Token: 0x040073E9 RID: 29673
		internal static byte __PropertyMask_bUsesVelocity;
	}
}
