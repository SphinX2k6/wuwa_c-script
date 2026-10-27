using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F53 RID: 3923
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleAttractorParticle")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UParticleModuleAttractorParticle : UParticleModuleAttractorBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D390 RID: 54160 RVA: 0x00136535 File Offset: 0x00134735
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleAttractorParticle._ClassPtr;
		}

		// Token: 0x0600D391 RID: 54161 RVA: 0x00136544 File Offset: 0x00134744
		public UParticleModuleAttractorParticle() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAttractorParticle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D392 RID: 54162 RVA: 0x0013656C File Offset: 0x0013476C
		public UParticleModuleAttractorParticle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleAttractorParticle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003177 RID: 12663
		// (get) Token: 0x0600D393 RID: 54163 RVA: 0x0013659F File Offset: 0x0013479F
		// (set) Token: 0x0600D394 RID: 54164 RVA: 0x001365B3 File Offset: 0x001347B3
		public unsafe FName EmitterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_EmitterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_EmitterName) = value;
			}
		}

		// Token: 0x17003178 RID: 12664
		// (get) Token: 0x0600D395 RID: 54165 RVA: 0x001365C8 File Offset: 0x001347C8
		// (set) Token: 0x0600D396 RID: 54166 RVA: 0x00136601 File Offset: 0x00134801
		public FRawDistributionFloat Range
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._Range) == null)
				{
					result = (this._Range = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_Range, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_Range, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003179 RID: 12665
		// (get) Token: 0x0600D397 RID: 54167 RVA: 0x00136622 File Offset: 0x00134822
		// (set) Token: 0x0600D398 RID: 54168 RVA: 0x0013663B File Offset: 0x0013483B
		public unsafe bool bStrengthByDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_bStrengthByDistance) & UParticleModuleAttractorParticle.__PropertyMask_bStrengthByDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_bStrengthByDistance) = ((*(base.NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_bStrengthByDistance) & ~UParticleModuleAttractorParticle.__PropertyMask_bStrengthByDistance) | (value ? UParticleModuleAttractorParticle.__PropertyMask_bStrengthByDistance : 0));
			}
		}

		// Token: 0x1700317A RID: 12666
		// (get) Token: 0x0600D399 RID: 54169 RVA: 0x0013666C File Offset: 0x0013486C
		// (set) Token: 0x0600D39A RID: 54170 RVA: 0x001366A5 File Offset: 0x001348A5
		public FRawDistributionFloat Strength
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._Strength) == null)
				{
					result = (this._Strength = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_Strength, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_Strength, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700317B RID: 12667
		// (get) Token: 0x0600D39B RID: 54171 RVA: 0x001366C6 File Offset: 0x001348C6
		// (set) Token: 0x0600D39C RID: 54172 RVA: 0x001366DF File Offset: 0x001348DF
		public unsafe bool bAffectBaseVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_bAffectBaseVelocity) & UParticleModuleAttractorParticle.__PropertyMask_bAffectBaseVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_bAffectBaseVelocity) = ((*(base.NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_bAffectBaseVelocity) & ~UParticleModuleAttractorParticle.__PropertyMask_bAffectBaseVelocity) | (value ? UParticleModuleAttractorParticle.__PropertyMask_bAffectBaseVelocity : 0));
			}
		}

		// Token: 0x1700317C RID: 12668
		// (get) Token: 0x0600D39D RID: 54173 RVA: 0x0013670F File Offset: 0x0013490F
		// (set) Token: 0x0600D39E RID: 54174 RVA: 0x00136723 File Offset: 0x00134923
		[Nullable(0)]
		public unsafe TEnumAsByte<EAttractorParticleSelectionMethod> SelectionMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_SelectionMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_SelectionMethod) = value;
			}
		}

		// Token: 0x1700317D RID: 12669
		// (get) Token: 0x0600D39F RID: 54175 RVA: 0x00136738 File Offset: 0x00134938
		// (set) Token: 0x0600D3A0 RID: 54176 RVA: 0x00136751 File Offset: 0x00134951
		public unsafe bool bRenewSource
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_bRenewSource) & UParticleModuleAttractorParticle.__PropertyMask_bRenewSource) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_bRenewSource) = ((*(base.NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_bRenewSource) & ~UParticleModuleAttractorParticle.__PropertyMask_bRenewSource) | (value ? UParticleModuleAttractorParticle.__PropertyMask_bRenewSource : 0));
			}
		}

		// Token: 0x1700317E RID: 12670
		// (get) Token: 0x0600D3A1 RID: 54177 RVA: 0x00136781 File Offset: 0x00134981
		// (set) Token: 0x0600D3A2 RID: 54178 RVA: 0x0013679A File Offset: 0x0013499A
		public unsafe bool bInheritSourceVel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_bInheritSourceVel) & UParticleModuleAttractorParticle.__PropertyMask_bInheritSourceVel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_bInheritSourceVel) = ((*(base.NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_bInheritSourceVel) & ~UParticleModuleAttractorParticle.__PropertyMask_bInheritSourceVel) | (value ? UParticleModuleAttractorParticle.__PropertyMask_bInheritSourceVel : 0));
			}
		}

		// Token: 0x1700317F RID: 12671
		// (get) Token: 0x0600D3A3 RID: 54179 RVA: 0x001367CA File Offset: 0x001349CA
		// (set) Token: 0x0600D3A4 RID: 54180 RVA: 0x001367DA File Offset: 0x001349DA
		public unsafe int LastSelIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_LastSelIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleAttractorParticle.__PropertyOffset_LastSelIndex) = value;
			}
		}

		// Token: 0x0600D3A5 RID: 54181 RVA: 0x001367EB File Offset: 0x001349EB
		static UParticleModuleAttractorParticle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleAttractorParticle");
		}

		// Token: 0x0600D3A6 RID: 54182 RVA: 0x001367F9 File Offset: 0x001349F9
		protected UParticleModuleAttractorParticle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400719E RID: 29086
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleAttractorParticle";

		// Token: 0x0400719F RID: 29087
		private static IntPtr _ClassPtr;

		// Token: 0x040071A0 RID: 29088
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040071A1 RID: 29089
		internal static int __PropertyOffset_EmitterName;

		// Token: 0x040071A2 RID: 29090
		internal static int __PropertyOffset_Range;

		// Token: 0x040071A3 RID: 29091
		[Nullable(2)]
		private FRawDistributionFloat _Range;

		// Token: 0x040071A4 RID: 29092
		internal static int __PropertyOffset_bStrengthByDistance;

		// Token: 0x040071A5 RID: 29093
		internal static byte __PropertyMask_bStrengthByDistance;

		// Token: 0x040071A6 RID: 29094
		internal static int __PropertyOffset_Strength;

		// Token: 0x040071A7 RID: 29095
		[Nullable(2)]
		private FRawDistributionFloat _Strength;

		// Token: 0x040071A8 RID: 29096
		internal static int __PropertyOffset_bAffectBaseVelocity;

		// Token: 0x040071A9 RID: 29097
		internal static byte __PropertyMask_bAffectBaseVelocity;

		// Token: 0x040071AA RID: 29098
		internal static int __PropertyOffset_SelectionMethod;

		// Token: 0x040071AB RID: 29099
		internal static int __PropertyOffset_bRenewSource;

		// Token: 0x040071AC RID: 29100
		internal static byte __PropertyMask_bRenewSource;

		// Token: 0x040071AD RID: 29101
		internal static int __PropertyOffset_bInheritSourceVel;

		// Token: 0x040071AE RID: 29102
		internal static byte __PropertyMask_bInheritSourceVel;

		// Token: 0x040071AF RID: 29103
		internal static int __PropertyOffset_LastSelIndex;
	}
}
