using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E47 RID: 3655
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSkyAtmosphereLightDiskLuminance")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UMaterialExpressionSkyAtmosphereLightDiskLuminance : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C429 RID: 50217 RVA: 0x0011B93B File Offset: 0x00119B3B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSkyAtmosphereLightDiskLuminance._ClassPtr;
		}

		// Token: 0x0600C42A RID: 50218 RVA: 0x0011B948 File Offset: 0x00119B48
		public UMaterialExpressionSkyAtmosphereLightDiskLuminance() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSkyAtmosphereLightDiskLuminance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C42B RID: 50219 RVA: 0x0011B970 File Offset: 0x00119B70
		[NullableContext(1)]
		public UMaterialExpressionSkyAtmosphereLightDiskLuminance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSkyAtmosphereLightDiskLuminance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D86 RID: 11654
		// (get) Token: 0x0600C42C RID: 50220 RVA: 0x0011B9A3 File Offset: 0x00119BA3
		// (set) Token: 0x0600C42D RID: 50221 RVA: 0x0011B9B3 File Offset: 0x00119BB3
		public unsafe int LightIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSkyAtmosphereLightDiskLuminance.__PropertyOffset_LightIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSkyAtmosphereLightDiskLuminance.__PropertyOffset_LightIndex) = value;
			}
		}

		// Token: 0x0600C42E RID: 50222 RVA: 0x0011B9C4 File Offset: 0x00119BC4
		static UMaterialExpressionSkyAtmosphereLightDiskLuminance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSkyAtmosphereLightDiskLuminance");
		}

		// Token: 0x0600C42F RID: 50223 RVA: 0x0011B9D2 File Offset: 0x00119BD2
		protected UMaterialExpressionSkyAtmosphereLightDiskLuminance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040068B7 RID: 26807
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSkyAtmosphereLightDiskLuminance";

		// Token: 0x040068B8 RID: 26808
		private static IntPtr _ClassPtr;

		// Token: 0x040068B9 RID: 26809
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040068BA RID: 26810
		internal static int __PropertyOffset_LightIndex;
	}
}
