using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F57 RID: 3927
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleBeamModifier")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UParticleModuleBeamModifier : UParticleModuleBeamBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D3D7 RID: 54231 RVA: 0x00136E09 File Offset: 0x00135009
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleBeamModifier._ClassPtr;
		}

		// Token: 0x0600D3D8 RID: 54232 RVA: 0x00136E18 File Offset: 0x00135018
		public UParticleModuleBeamModifier() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleBeamModifier.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D3D9 RID: 54233 RVA: 0x00136E40 File Offset: 0x00135040
		public UParticleModuleBeamModifier(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleBeamModifier.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003191 RID: 12689
		// (get) Token: 0x0600D3DA RID: 54234 RVA: 0x00136E73 File Offset: 0x00135073
		// (set) Token: 0x0600D3DB RID: 54235 RVA: 0x00136E87 File Offset: 0x00135087
		[Nullable(0)]
		public unsafe TEnumAsByte<BeamModifierType> ModifierType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleBeamModifier.__PropertyOffset_ModifierType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleBeamModifier.__PropertyOffset_ModifierType) = value;
			}
		}

		// Token: 0x17003192 RID: 12690
		// (get) Token: 0x0600D3DC RID: 54236 RVA: 0x00136E9C File Offset: 0x0013509C
		// (set) Token: 0x0600D3DD RID: 54237 RVA: 0x00136ED5 File Offset: 0x001350D5
		public FBeamModifierOptions PositionOptions
		{
			get
			{
				base.FastCheckIsValid();
				FBeamModifierOptions result;
				if ((result = this._PositionOptions) == null)
				{
					result = (this._PositionOptions = new FBeamModifierOptions(base.NativePtr + (IntPtr)UParticleModuleBeamModifier.__PropertyOffset_PositionOptions, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBeamModifierOptions.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleBeamModifier.__PropertyOffset_PositionOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003193 RID: 12691
		// (get) Token: 0x0600D3DE RID: 54238 RVA: 0x00136EF8 File Offset: 0x001350F8
		// (set) Token: 0x0600D3DF RID: 54239 RVA: 0x00136F31 File Offset: 0x00135131
		public FRawDistributionVector Position
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._Position) == null)
				{
					result = (this._Position = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleBeamModifier.__PropertyOffset_Position, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleBeamModifier.__PropertyOffset_Position, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003194 RID: 12692
		// (get) Token: 0x0600D3E0 RID: 54240 RVA: 0x00136F54 File Offset: 0x00135154
		// (set) Token: 0x0600D3E1 RID: 54241 RVA: 0x00136F8D File Offset: 0x0013518D
		public FBeamModifierOptions TangentOptions
		{
			get
			{
				base.FastCheckIsValid();
				FBeamModifierOptions result;
				if ((result = this._TangentOptions) == null)
				{
					result = (this._TangentOptions = new FBeamModifierOptions(base.NativePtr + (IntPtr)UParticleModuleBeamModifier.__PropertyOffset_TangentOptions, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBeamModifierOptions.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleBeamModifier.__PropertyOffset_TangentOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003195 RID: 12693
		// (get) Token: 0x0600D3E2 RID: 54242 RVA: 0x00136FB0 File Offset: 0x001351B0
		// (set) Token: 0x0600D3E3 RID: 54243 RVA: 0x00136FE9 File Offset: 0x001351E9
		public FRawDistributionVector Tangent
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._Tangent) == null)
				{
					result = (this._Tangent = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleBeamModifier.__PropertyOffset_Tangent, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleBeamModifier.__PropertyOffset_Tangent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003196 RID: 12694
		// (get) Token: 0x0600D3E4 RID: 54244 RVA: 0x0013700A File Offset: 0x0013520A
		// (set) Token: 0x0600D3E5 RID: 54245 RVA: 0x00137023 File Offset: 0x00135223
		public unsafe bool bAbsoluteTangent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleBeamModifier.__PropertyOffset_bAbsoluteTangent) & UParticleModuleBeamModifier.__PropertyMask_bAbsoluteTangent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleBeamModifier.__PropertyOffset_bAbsoluteTangent) = ((*(base.NativePtr + (IntPtr)UParticleModuleBeamModifier.__PropertyOffset_bAbsoluteTangent) & ~UParticleModuleBeamModifier.__PropertyMask_bAbsoluteTangent) | (value ? UParticleModuleBeamModifier.__PropertyMask_bAbsoluteTangent : 0));
			}
		}

		// Token: 0x17003197 RID: 12695
		// (get) Token: 0x0600D3E6 RID: 54246 RVA: 0x00137054 File Offset: 0x00135254
		// (set) Token: 0x0600D3E7 RID: 54247 RVA: 0x0013708D File Offset: 0x0013528D
		public FBeamModifierOptions StrengthOptions
		{
			get
			{
				base.FastCheckIsValid();
				FBeamModifierOptions result;
				if ((result = this._StrengthOptions) == null)
				{
					result = (this._StrengthOptions = new FBeamModifierOptions(base.NativePtr + (IntPtr)UParticleModuleBeamModifier.__PropertyOffset_StrengthOptions, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBeamModifierOptions.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleBeamModifier.__PropertyOffset_StrengthOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003198 RID: 12696
		// (get) Token: 0x0600D3E8 RID: 54248 RVA: 0x001370B0 File Offset: 0x001352B0
		// (set) Token: 0x0600D3E9 RID: 54249 RVA: 0x001370E9 File Offset: 0x001352E9
		public FRawDistributionFloat Strength
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._Strength) == null)
				{
					result = (this._Strength = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleBeamModifier.__PropertyOffset_Strength, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleBeamModifier.__PropertyOffset_Strength, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D3EA RID: 54250 RVA: 0x0013710A File Offset: 0x0013530A
		static UParticleModuleBeamModifier()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleBeamModifier");
		}

		// Token: 0x0600D3EB RID: 54251 RVA: 0x00137118 File Offset: 0x00135318
		protected UParticleModuleBeamModifier(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040071D8 RID: 29144
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleBeamModifier";

		// Token: 0x040071D9 RID: 29145
		private static IntPtr _ClassPtr;

		// Token: 0x040071DA RID: 29146
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040071DB RID: 29147
		internal static int __PropertyOffset_ModifierType;

		// Token: 0x040071DC RID: 29148
		internal static int __PropertyOffset_PositionOptions;

		// Token: 0x040071DD RID: 29149
		[Nullable(2)]
		private FBeamModifierOptions _PositionOptions;

		// Token: 0x040071DE RID: 29150
		internal static int __PropertyOffset_Position;

		// Token: 0x040071DF RID: 29151
		[Nullable(2)]
		private FRawDistributionVector _Position;

		// Token: 0x040071E0 RID: 29152
		internal static int __PropertyOffset_TangentOptions;

		// Token: 0x040071E1 RID: 29153
		[Nullable(2)]
		private FBeamModifierOptions _TangentOptions;

		// Token: 0x040071E2 RID: 29154
		internal static int __PropertyOffset_Tangent;

		// Token: 0x040071E3 RID: 29155
		[Nullable(2)]
		private FRawDistributionVector _Tangent;

		// Token: 0x040071E4 RID: 29156
		internal static int __PropertyOffset_bAbsoluteTangent;

		// Token: 0x040071E5 RID: 29157
		internal static byte __PropertyMask_bAbsoluteTangent;

		// Token: 0x040071E6 RID: 29158
		internal static int __PropertyOffset_StrengthOptions;

		// Token: 0x040071E7 RID: 29159
		[Nullable(2)]
		private FBeamModifierOptions _StrengthOptions;

		// Token: 0x040071E8 RID: 29160
		internal static int __PropertyOffset_Strength;

		// Token: 0x040071E9 RID: 29161
		[Nullable(2)]
		private FRawDistributionFloat _Strength;
	}
}
