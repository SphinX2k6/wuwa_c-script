using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FA2 RID: 8098
	[UnrealObjectPath("/Script/Landscape.MaterialExpressionLandscapeVisibilityMask")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UMaterialExpressionLandscapeVisibilityMask : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EBB6 RID: 125878 RVA: 0x002DB0D6 File Offset: 0x002D92D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLandscapeVisibilityMask._ClassPtr;
		}

		// Token: 0x0601EBB7 RID: 125879 RVA: 0x002DB0E4 File Offset: 0x002D92E4
		public UMaterialExpressionLandscapeVisibilityMask() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeVisibilityMask.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EBB8 RID: 125880 RVA: 0x002DB10C File Offset: 0x002D930C
		[NullableContext(1)]
		public UMaterialExpressionLandscapeVisibilityMask(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeVisibilityMask.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A6E RID: 31342
		// (get) Token: 0x0601EBB9 RID: 125881 RVA: 0x002DB13F File Offset: 0x002D933F
		// (set) Token: 0x0601EBBA RID: 125882 RVA: 0x002DB153 File Offset: 0x002D9353
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeVisibilityMask.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeVisibilityMask.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x0601EBBB RID: 125883 RVA: 0x002DB168 File Offset: 0x002D9368
		static UMaterialExpressionLandscapeVisibilityMask()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.MaterialExpressionLandscapeVisibilityMask");
		}

		// Token: 0x0601EBBC RID: 125884 RVA: 0x002DB176 File Offset: 0x002D9376
		protected UMaterialExpressionLandscapeVisibilityMask(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040109E3 RID: 68067
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.MaterialExpressionLandscapeVisibilityMask";

		// Token: 0x040109E4 RID: 68068
		private static IntPtr _ClassPtr;

		// Token: 0x040109E5 RID: 68069
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040109E6 RID: 68070
		internal static int __PropertyOffset_ExpressionGUID;
	}
}
