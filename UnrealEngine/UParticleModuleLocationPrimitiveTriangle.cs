using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F7F RID: 3967
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleLocationPrimitiveTriangle")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UParticleModuleLocationPrimitiveTriangle : UParticleModuleLocationBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D5DD RID: 54749 RVA: 0x0013ABCD File Offset: 0x00138DCD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLocationPrimitiveTriangle._ClassPtr;
		}

		// Token: 0x0600D5DE RID: 54750 RVA: 0x0013ABDC File Offset: 0x00138DDC
		public UParticleModuleLocationPrimitiveTriangle() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationPrimitiveTriangle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D5DF RID: 54751 RVA: 0x0013AC04 File Offset: 0x00138E04
		public UParticleModuleLocationPrimitiveTriangle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationPrimitiveTriangle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003235 RID: 12853
		// (get) Token: 0x0600D5E0 RID: 54752 RVA: 0x0013AC38 File Offset: 0x00138E38
		// (set) Token: 0x0600D5E1 RID: 54753 RVA: 0x0013AC71 File Offset: 0x00138E71
		public FRawDistributionVector StartOffset
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._StartOffset) == null)
				{
					result = (this._StartOffset = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveTriangle.__PropertyOffset_StartOffset, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveTriangle.__PropertyOffset_StartOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003236 RID: 12854
		// (get) Token: 0x0600D5E2 RID: 54754 RVA: 0x0013AC94 File Offset: 0x00138E94
		// (set) Token: 0x0600D5E3 RID: 54755 RVA: 0x0013ACCD File Offset: 0x00138ECD
		public FRawDistributionFloat Height
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._Height) == null)
				{
					result = (this._Height = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveTriangle.__PropertyOffset_Height, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveTriangle.__PropertyOffset_Height, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003237 RID: 12855
		// (get) Token: 0x0600D5E4 RID: 54756 RVA: 0x0013ACF0 File Offset: 0x00138EF0
		// (set) Token: 0x0600D5E5 RID: 54757 RVA: 0x0013AD29 File Offset: 0x00138F29
		public FRawDistributionFloat Angle
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._Angle) == null)
				{
					result = (this._Angle = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveTriangle.__PropertyOffset_Angle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveTriangle.__PropertyOffset_Angle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003238 RID: 12856
		// (get) Token: 0x0600D5E6 RID: 54758 RVA: 0x0013AD4C File Offset: 0x00138F4C
		// (set) Token: 0x0600D5E7 RID: 54759 RVA: 0x0013AD85 File Offset: 0x00138F85
		public FRawDistributionFloat Thickness
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._Thickness) == null)
				{
					result = (this._Thickness = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveTriangle.__PropertyOffset_Thickness, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleLocationPrimitiveTriangle.__PropertyOffset_Thickness, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600D5E8 RID: 54760 RVA: 0x0013ADA6 File Offset: 0x00138FA6
		static UParticleModuleLocationPrimitiveTriangle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLocationPrimitiveTriangle");
		}

		// Token: 0x0600D5E9 RID: 54761 RVA: 0x0013ADB4 File Offset: 0x00138FB4
		protected UParticleModuleLocationPrimitiveTriangle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007366 RID: 29542
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLocationPrimitiveTriangle";

		// Token: 0x04007367 RID: 29543
		private static IntPtr _ClassPtr;

		// Token: 0x04007368 RID: 29544
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007369 RID: 29545
		internal static int __PropertyOffset_StartOffset;

		// Token: 0x0400736A RID: 29546
		[Nullable(2)]
		private FRawDistributionVector _StartOffset;

		// Token: 0x0400736B RID: 29547
		internal static int __PropertyOffset_Height;

		// Token: 0x0400736C RID: 29548
		[Nullable(2)]
		private FRawDistributionFloat _Height;

		// Token: 0x0400736D RID: 29549
		internal static int __PropertyOffset_Angle;

		// Token: 0x0400736E RID: 29550
		[Nullable(2)]
		private FRawDistributionFloat _Angle;

		// Token: 0x0400736F RID: 29551
		internal static int __PropertyOffset_Thickness;

		// Token: 0x04007370 RID: 29552
		[Nullable(2)]
		private FRawDistributionFloat _Thickness;
	}
}
