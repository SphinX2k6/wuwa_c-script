using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F54 RID: 3924
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleAttractorPoint")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UParticleModuleAttractorPoint : UParticleModuleAttractorBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D3A7 RID: 54183 RVA: 0x00136802 File Offset: 0x00134A02
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleAttractorPoint._ClassPtr;
		}

		// Token: 0x0600D3A8 RID: 54184 RVA: 0x00136810 File Offset: 0x00134A10
		public UParticleModuleAttractorPoint() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAttractorPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D3A9 RID: 54185 RVA: 0x00136838 File Offset: 0x00134A38
		public UParticleModuleAttractorPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAttractorPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003180 RID: 12672
		// (get) Token: 0x0600D3AA RID: 54186 RVA: 0x0013686C File Offset: 0x00134A6C
		// (set) Token: 0x0600D3AB RID: 54187 RVA: 0x001368A5 File Offset: 0x00134AA5
		public FRawDistributionVector Position
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._Position) == null)
				{
					result = (this._Position = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Position, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Position, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003181 RID: 12673
		// (get) Token: 0x0600D3AC RID: 54188 RVA: 0x001368C8 File Offset: 0x00134AC8
		// (set) Token: 0x0600D3AD RID: 54189 RVA: 0x00136901 File Offset: 0x00134B01
		public FRawDistributionFloat Range
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._Range) == null)
				{
					result = (this._Range = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Range, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Range, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003182 RID: 12674
		// (get) Token: 0x0600D3AE RID: 54190 RVA: 0x00136924 File Offset: 0x00134B24
		// (set) Token: 0x0600D3AF RID: 54191 RVA: 0x0013695D File Offset: 0x00134B5D
		public FRawDistributionFloat Strength
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._Strength) == null)
				{
					result = (this._Strength = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Strength, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Strength, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003183 RID: 12675
		// (get) Token: 0x0600D3B0 RID: 54192 RVA: 0x0013697E File Offset: 0x00134B7E
		// (set) Token: 0x0600D3B1 RID: 54193 RVA: 0x00136997 File Offset: 0x00134B97
		public unsafe bool StrengthByDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_StrengthByDistance) & UParticleModuleAttractorPoint.__PropertyMask_StrengthByDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_StrengthByDistance) = ((*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_StrengthByDistance) & ~UParticleModuleAttractorPoint.__PropertyMask_StrengthByDistance) | (value ? UParticleModuleAttractorPoint.__PropertyMask_StrengthByDistance : 0));
			}
		}

		// Token: 0x17003184 RID: 12676
		// (get) Token: 0x0600D3B2 RID: 54194 RVA: 0x001369C7 File Offset: 0x00134BC7
		// (set) Token: 0x0600D3B3 RID: 54195 RVA: 0x001369E0 File Offset: 0x00134BE0
		public unsafe bool bAffectBaseVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_bAffectBaseVelocity) & UParticleModuleAttractorPoint.__PropertyMask_bAffectBaseVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_bAffectBaseVelocity) = ((*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_bAffectBaseVelocity) & ~UParticleModuleAttractorPoint.__PropertyMask_bAffectBaseVelocity) | (value ? UParticleModuleAttractorPoint.__PropertyMask_bAffectBaseVelocity : 0));
			}
		}

		// Token: 0x17003185 RID: 12677
		// (get) Token: 0x0600D3B4 RID: 54196 RVA: 0x00136A10 File Offset: 0x00134C10
		// (set) Token: 0x0600D3B5 RID: 54197 RVA: 0x00136A29 File Offset: 0x00134C29
		public unsafe bool bOverrideVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_bOverrideVelocity) & UParticleModuleAttractorPoint.__PropertyMask_bOverrideVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_bOverrideVelocity) = ((*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_bOverrideVelocity) & ~UParticleModuleAttractorPoint.__PropertyMask_bOverrideVelocity) | (value ? UParticleModuleAttractorPoint.__PropertyMask_bOverrideVelocity : 0));
			}
		}

		// Token: 0x17003186 RID: 12678
		// (get) Token: 0x0600D3B6 RID: 54198 RVA: 0x00136A59 File Offset: 0x00134C59
		// (set) Token: 0x0600D3B7 RID: 54199 RVA: 0x00136A72 File Offset: 0x00134C72
		public unsafe bool bUseWorldSpacePosition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_bUseWorldSpacePosition) & UParticleModuleAttractorPoint.__PropertyMask_bUseWorldSpacePosition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_bUseWorldSpacePosition) = ((*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_bUseWorldSpacePosition) & ~UParticleModuleAttractorPoint.__PropertyMask_bUseWorldSpacePosition) | (value ? UParticleModuleAttractorPoint.__PropertyMask_bUseWorldSpacePosition : 0));
			}
		}

		// Token: 0x17003187 RID: 12679
		// (get) Token: 0x0600D3B8 RID: 54200 RVA: 0x00136AA2 File Offset: 0x00134CA2
		// (set) Token: 0x0600D3B9 RID: 54201 RVA: 0x00136ABB File Offset: 0x00134CBB
		public unsafe bool Positive_X
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Positive_X) & UParticleModuleAttractorPoint.__PropertyMask_Positive_X) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Positive_X) = ((*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Positive_X) & ~UParticleModuleAttractorPoint.__PropertyMask_Positive_X) | (value ? UParticleModuleAttractorPoint.__PropertyMask_Positive_X : 0));
			}
		}

		// Token: 0x17003188 RID: 12680
		// (get) Token: 0x0600D3BA RID: 54202 RVA: 0x00136AEB File Offset: 0x00134CEB
		// (set) Token: 0x0600D3BB RID: 54203 RVA: 0x00136B04 File Offset: 0x00134D04
		public unsafe bool Positive_Y
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Positive_Y) & UParticleModuleAttractorPoint.__PropertyMask_Positive_Y) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Positive_Y) = ((*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Positive_Y) & ~UParticleModuleAttractorPoint.__PropertyMask_Positive_Y) | (value ? UParticleModuleAttractorPoint.__PropertyMask_Positive_Y : 0));
			}
		}

		// Token: 0x17003189 RID: 12681
		// (get) Token: 0x0600D3BC RID: 54204 RVA: 0x00136B34 File Offset: 0x00134D34
		// (set) Token: 0x0600D3BD RID: 54205 RVA: 0x00136B4D File Offset: 0x00134D4D
		public unsafe bool Positive_Z
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Positive_Z) & UParticleModuleAttractorPoint.__PropertyMask_Positive_Z) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Positive_Z) = ((*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Positive_Z) & ~UParticleModuleAttractorPoint.__PropertyMask_Positive_Z) | (value ? UParticleModuleAttractorPoint.__PropertyMask_Positive_Z : 0));
			}
		}

		// Token: 0x1700318A RID: 12682
		// (get) Token: 0x0600D3BE RID: 54206 RVA: 0x00136B7D File Offset: 0x00134D7D
		// (set) Token: 0x0600D3BF RID: 54207 RVA: 0x00136B96 File Offset: 0x00134D96
		public unsafe bool Negative_X
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Negative_X) & UParticleModuleAttractorPoint.__PropertyMask_Negative_X) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Negative_X) = ((*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Negative_X) & ~UParticleModuleAttractorPoint.__PropertyMask_Negative_X) | (value ? UParticleModuleAttractorPoint.__PropertyMask_Negative_X : 0));
			}
		}

		// Token: 0x1700318B RID: 12683
		// (get) Token: 0x0600D3C0 RID: 54208 RVA: 0x00136BC6 File Offset: 0x00134DC6
		// (set) Token: 0x0600D3C1 RID: 54209 RVA: 0x00136BDF File Offset: 0x00134DDF
		public unsafe bool Negative_Y
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Negative_Y) & UParticleModuleAttractorPoint.__PropertyMask_Negative_Y) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Negative_Y) = ((*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Negative_Y) & ~UParticleModuleAttractorPoint.__PropertyMask_Negative_Y) | (value ? UParticleModuleAttractorPoint.__PropertyMask_Negative_Y : 0));
			}
		}

		// Token: 0x1700318C RID: 12684
		// (get) Token: 0x0600D3C2 RID: 54210 RVA: 0x00136C0F File Offset: 0x00134E0F
		// (set) Token: 0x0600D3C3 RID: 54211 RVA: 0x00136C28 File Offset: 0x00134E28
		public unsafe bool Negative_Z
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Negative_Z) & UParticleModuleAttractorPoint.__PropertyMask_Negative_Z) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Negative_Z) = ((*(base.NativePtr + (IntPtr)UParticleModuleAttractorPoint.__PropertyOffset_Negative_Z) & ~UParticleModuleAttractorPoint.__PropertyMask_Negative_Z) | (value ? UParticleModuleAttractorPoint.__PropertyMask_Negative_Z : 0));
			}
		}

		// Token: 0x0600D3C4 RID: 54212 RVA: 0x00136C58 File Offset: 0x00134E58
		static UParticleModuleAttractorPoint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleAttractorPoint");
		}

		// Token: 0x0600D3C5 RID: 54213 RVA: 0x00136C66 File Offset: 0x00134E66
		protected UParticleModuleAttractorPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040071B0 RID: 29104
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleAttractorPoint";

		// Token: 0x040071B1 RID: 29105
		private static IntPtr _ClassPtr;

		// Token: 0x040071B2 RID: 29106
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040071B3 RID: 29107
		internal static int __PropertyOffset_Position;

		// Token: 0x040071B4 RID: 29108
		[Nullable(2)]
		private FRawDistributionVector _Position;

		// Token: 0x040071B5 RID: 29109
		internal static int __PropertyOffset_Range;

		// Token: 0x040071B6 RID: 29110
		[Nullable(2)]
		private FRawDistributionFloat _Range;

		// Token: 0x040071B7 RID: 29111
		internal static int __PropertyOffset_Strength;

		// Token: 0x040071B8 RID: 29112
		[Nullable(2)]
		private FRawDistributionFloat _Strength;

		// Token: 0x040071B9 RID: 29113
		internal static int __PropertyOffset_StrengthByDistance;

		// Token: 0x040071BA RID: 29114
		internal static byte __PropertyMask_StrengthByDistance;

		// Token: 0x040071BB RID: 29115
		internal static int __PropertyOffset_bAffectBaseVelocity;

		// Token: 0x040071BC RID: 29116
		internal static byte __PropertyMask_bAffectBaseVelocity;

		// Token: 0x040071BD RID: 29117
		internal static int __PropertyOffset_bOverrideVelocity;

		// Token: 0x040071BE RID: 29118
		internal static byte __PropertyMask_bOverrideVelocity;

		// Token: 0x040071BF RID: 29119
		internal static int __PropertyOffset_bUseWorldSpacePosition;

		// Token: 0x040071C0 RID: 29120
		internal static byte __PropertyMask_bUseWorldSpacePosition;

		// Token: 0x040071C1 RID: 29121
		internal static int __PropertyOffset_Positive_X;

		// Token: 0x040071C2 RID: 29122
		internal static byte __PropertyMask_Positive_X;

		// Token: 0x040071C3 RID: 29123
		internal static int __PropertyOffset_Positive_Y;

		// Token: 0x040071C4 RID: 29124
		internal static byte __PropertyMask_Positive_Y;

		// Token: 0x040071C5 RID: 29125
		internal static int __PropertyOffset_Positive_Z;

		// Token: 0x040071C6 RID: 29126
		internal static byte __PropertyMask_Positive_Z;

		// Token: 0x040071C7 RID: 29127
		internal static int __PropertyOffset_Negative_X;

		// Token: 0x040071C8 RID: 29128
		internal static byte __PropertyMask_Negative_X;

		// Token: 0x040071C9 RID: 29129
		internal static int __PropertyOffset_Negative_Y;

		// Token: 0x040071CA RID: 29130
		internal static byte __PropertyMask_Negative_Y;

		// Token: 0x040071CB RID: 29131
		internal static int __PropertyOffset_Negative_Z;

		// Token: 0x040071CC RID: 29132
		internal static byte __PropertyMask_Negative_Z;
	}
}
