using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E44 RID: 3652
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSkyAtmosphereAerialPerspective")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionSkyAtmosphereAerialPerspective : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C416 RID: 50198 RVA: 0x0011B73E File Offset: 0x0011993E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSkyAtmosphereAerialPerspective._ClassPtr;
		}

		// Token: 0x0600C417 RID: 50199 RVA: 0x0011B74C File Offset: 0x0011994C
		public UMaterialExpressionSkyAtmosphereAerialPerspective() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSkyAtmosphereAerialPerspective.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C418 RID: 50200 RVA: 0x0011B774 File Offset: 0x00119974
		public UMaterialExpressionSkyAtmosphereAerialPerspective(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSkyAtmosphereAerialPerspective.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D84 RID: 11652
		// (get) Token: 0x0600C419 RID: 50201 RVA: 0x0011B7A8 File Offset: 0x001199A8
		// (set) Token: 0x0600C41A RID: 50202 RVA: 0x0011B7E1 File Offset: 0x001199E1
		public FExpressionInput WorldPosition
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._WorldPosition) == null)
				{
					result = (this._WorldPosition = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSkyAtmosphereAerialPerspective.__PropertyOffset_WorldPosition, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSkyAtmosphereAerialPerspective.__PropertyOffset_WorldPosition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C41B RID: 50203 RVA: 0x0011B802 File Offset: 0x00119A02
		static UMaterialExpressionSkyAtmosphereAerialPerspective()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSkyAtmosphereAerialPerspective");
		}

		// Token: 0x0600C41C RID: 50204 RVA: 0x0011B810 File Offset: 0x00119A10
		protected UMaterialExpressionSkyAtmosphereAerialPerspective(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040068AB RID: 26795
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSkyAtmosphereAerialPerspective";

		// Token: 0x040068AC RID: 26796
		private static IntPtr _ClassPtr;

		// Token: 0x040068AD RID: 26797
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040068AE RID: 26798
		internal static int __PropertyOffset_WorldPosition;

		// Token: 0x040068AF RID: 26799
		[Nullable(2)]
		private FExpressionInput _WorldPosition;
	}
}
