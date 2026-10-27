using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F98 RID: 8088
	[UnrealObjectPath("/Script/Landscape.MaterialExpressionLandscapeKuroBlend")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UMaterialExpressionLandscapeKuroBlend : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EB46 RID: 125766 RVA: 0x002DA55E File Offset: 0x002D875E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLandscapeKuroBlend._ClassPtr;
		}

		// Token: 0x0601EB47 RID: 125767 RVA: 0x002DA56C File Offset: 0x002D876C
		public UMaterialExpressionLandscapeKuroBlend() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeKuroBlend.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EB48 RID: 125768 RVA: 0x002DA594 File Offset: 0x002D8794
		[NullableContext(1)]
		public UMaterialExpressionLandscapeKuroBlend(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeKuroBlend.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A4F RID: 31311
		// (get) Token: 0x0601EB49 RID: 125769 RVA: 0x002DA5C7 File Offset: 0x002D87C7
		// (set) Token: 0x0601EB4A RID: 125770 RVA: 0x002DA5DB File Offset: 0x002D87DB
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeKuroBlend.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeKuroBlend.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x0601EB4B RID: 125771 RVA: 0x002DA5F0 File Offset: 0x002D87F0
		static UMaterialExpressionLandscapeKuroBlend()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.MaterialExpressionLandscapeKuroBlend");
		}

		// Token: 0x0601EB4C RID: 125772 RVA: 0x002DA5FE File Offset: 0x002D87FE
		protected UMaterialExpressionLandscapeKuroBlend(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401099C RID: 67996
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.MaterialExpressionLandscapeKuroBlend";

		// Token: 0x0401099D RID: 67997
		private static IntPtr _ClassPtr;

		// Token: 0x0401099E RID: 67998
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401099F RID: 67999
		internal static int __PropertyOffset_ExpressionGUID;
	}
}
