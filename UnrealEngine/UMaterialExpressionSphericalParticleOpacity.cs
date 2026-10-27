using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E53 RID: 3667
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSphericalParticleOpacity")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionSphericalParticleOpacity : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C4B0 RID: 50352 RVA: 0x0011C853 File Offset: 0x0011AA53
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSphericalParticleOpacity._ClassPtr;
		}

		// Token: 0x0600C4B1 RID: 50353 RVA: 0x0011C860 File Offset: 0x0011AA60
		public UMaterialExpressionSphericalParticleOpacity() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSphericalParticleOpacity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C4B2 RID: 50354 RVA: 0x0011C888 File Offset: 0x0011AA88
		public UMaterialExpressionSphericalParticleOpacity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSphericalParticleOpacity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DAC RID: 11692
		// (get) Token: 0x0600C4B3 RID: 50355 RVA: 0x0011C8BC File Offset: 0x0011AABC
		// (set) Token: 0x0600C4B4 RID: 50356 RVA: 0x0011C8F5 File Offset: 0x0011AAF5
		public FExpressionInput Density
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Density) == null)
				{
					result = (this._Density = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSphericalParticleOpacity.__PropertyOffset_Density, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSphericalParticleOpacity.__PropertyOffset_Density, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DAD RID: 11693
		// (get) Token: 0x0600C4B5 RID: 50357 RVA: 0x0011C916 File Offset: 0x0011AB16
		// (set) Token: 0x0600C4B6 RID: 50358 RVA: 0x0011C926 File Offset: 0x0011AB26
		public unsafe float ConstantDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSphericalParticleOpacity.__PropertyOffset_ConstantDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSphericalParticleOpacity.__PropertyOffset_ConstantDensity) = value;
			}
		}

		// Token: 0x0600C4B7 RID: 50359 RVA: 0x0011C937 File Offset: 0x0011AB37
		static UMaterialExpressionSphericalParticleOpacity()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSphericalParticleOpacity");
		}

		// Token: 0x0600C4B8 RID: 50360 RVA: 0x0011C945 File Offset: 0x0011AB45
		protected UMaterialExpressionSphericalParticleOpacity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006913 RID: 26899
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSphericalParticleOpacity";

		// Token: 0x04006914 RID: 26900
		private static IntPtr _ClassPtr;

		// Token: 0x04006915 RID: 26901
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006916 RID: 26902
		internal static int __PropertyOffset_Density;

		// Token: 0x04006917 RID: 26903
		[Nullable(2)]
		private FExpressionInput _Density;

		// Token: 0x04006918 RID: 26904
		internal static int __PropertyOffset_ConstantDensity;
	}
}
