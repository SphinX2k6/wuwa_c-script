using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E46 RID: 3654
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSkyAtmosphereLightDirection")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UMaterialExpressionSkyAtmosphereLightDirection : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C422 RID: 50210 RVA: 0x0011B89A File Offset: 0x00119A9A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSkyAtmosphereLightDirection._ClassPtr;
		}

		// Token: 0x0600C423 RID: 50211 RVA: 0x0011B8A8 File Offset: 0x00119AA8
		public UMaterialExpressionSkyAtmosphereLightDirection() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSkyAtmosphereLightDirection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C424 RID: 50212 RVA: 0x0011B8D0 File Offset: 0x00119AD0
		[NullableContext(1)]
		public UMaterialExpressionSkyAtmosphereLightDirection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSkyAtmosphereLightDirection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D85 RID: 11653
		// (get) Token: 0x0600C425 RID: 50213 RVA: 0x0011B903 File Offset: 0x00119B03
		// (set) Token: 0x0600C426 RID: 50214 RVA: 0x0011B913 File Offset: 0x00119B13
		public unsafe int LightIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSkyAtmosphereLightDirection.__PropertyOffset_LightIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSkyAtmosphereLightDirection.__PropertyOffset_LightIndex) = value;
			}
		}

		// Token: 0x0600C427 RID: 50215 RVA: 0x0011B924 File Offset: 0x00119B24
		static UMaterialExpressionSkyAtmosphereLightDirection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSkyAtmosphereLightDirection");
		}

		// Token: 0x0600C428 RID: 50216 RVA: 0x0011B932 File Offset: 0x00119B32
		protected UMaterialExpressionSkyAtmosphereLightDirection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040068B3 RID: 26803
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSkyAtmosphereLightDirection";

		// Token: 0x040068B4 RID: 26804
		private static IntPtr _ClassPtr;

		// Token: 0x040068B5 RID: 26805
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040068B6 RID: 26806
		internal static int __PropertyOffset_LightIndex;
	}
}
