using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FBB RID: 4027
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleVelocityCone")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UParticleModuleVelocityCone : UParticleModuleVelocityBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D8CA RID: 55498 RVA: 0x0013FEED File Offset: 0x0013E0ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleVelocityCone._ClassPtr;
		}

		// Token: 0x0600D8CB RID: 55499 RVA: 0x0013FEFC File Offset: 0x0013E0FC
		public UParticleModuleVelocityCone() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVelocityCone.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D8CC RID: 55500 RVA: 0x0013FF24 File Offset: 0x0013E124
		public UParticleModuleVelocityCone(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleVelocityCone.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700331C RID: 13084
		// (get) Token: 0x0600D8CD RID: 55501 RVA: 0x0013FF58 File Offset: 0x0013E158
		// (set) Token: 0x0600D8CE RID: 55502 RVA: 0x0013FF91 File Offset: 0x0013E191
		public FRawDistributionFloat Angle
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._Angle) == null)
				{
					result = (this._Angle = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleVelocityCone.__PropertyOffset_Angle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleVelocityCone.__PropertyOffset_Angle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700331D RID: 13085
		// (get) Token: 0x0600D8CF RID: 55503 RVA: 0x0013FFB4 File Offset: 0x0013E1B4
		// (set) Token: 0x0600D8D0 RID: 55504 RVA: 0x0013FFED File Offset: 0x0013E1ED
		public FRawDistributionFloat Velocity
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._Velocity) == null)
				{
					result = (this._Velocity = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleVelocityCone.__PropertyOffset_Velocity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleVelocityCone.__PropertyOffset_Velocity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700331E RID: 13086
		// (get) Token: 0x0600D8D1 RID: 55505 RVA: 0x0014000E File Offset: 0x0013E20E
		// (set) Token: 0x0600D8D2 RID: 55506 RVA: 0x00140022 File Offset: 0x0013E222
		public unsafe FVector Direction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleVelocityCone.__PropertyOffset_Direction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleVelocityCone.__PropertyOffset_Direction) = value;
			}
		}

		// Token: 0x0600D8D3 RID: 55507 RVA: 0x00140037 File Offset: 0x0013E237
		static UParticleModuleVelocityCone()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleVelocityCone");
		}

		// Token: 0x0600D8D4 RID: 55508 RVA: 0x00140045 File Offset: 0x0013E245
		protected UParticleModuleVelocityCone(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007588 RID: 30088
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleVelocityCone";

		// Token: 0x04007589 RID: 30089
		private static IntPtr _ClassPtr;

		// Token: 0x0400758A RID: 30090
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400758B RID: 30091
		internal static int __PropertyOffset_Angle;

		// Token: 0x0400758C RID: 30092
		[Nullable(2)]
		private FRawDistributionFloat _Angle;

		// Token: 0x0400758D RID: 30093
		internal static int __PropertyOffset_Velocity;

		// Token: 0x0400758E RID: 30094
		[Nullable(2)]
		private FRawDistributionFloat _Velocity;

		// Token: 0x0400758F RID: 30095
		internal static int __PropertyOffset_Direction;
	}
}
