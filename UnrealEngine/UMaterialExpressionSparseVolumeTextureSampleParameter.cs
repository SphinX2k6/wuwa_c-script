using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E50 RID: 3664
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSparseVolumeTextureSampleParameter")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 424)]
	public class UMaterialExpressionSparseVolumeTextureSampleParameter : UMaterialExpressionSparseVolumeTextureSample, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C47B RID: 50299 RVA: 0x0011C25A File Offset: 0x0011A45A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSparseVolumeTextureSampleParameter._ClassPtr;
		}

		// Token: 0x0600C47C RID: 50300 RVA: 0x0011C268 File Offset: 0x0011A468
		public UMaterialExpressionSparseVolumeTextureSampleParameter() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSparseVolumeTextureSampleParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C47D RID: 50301 RVA: 0x0011C290 File Offset: 0x0011A490
		[NullableContext(1)]
		public UMaterialExpressionSparseVolumeTextureSampleParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSparseVolumeTextureSampleParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D99 RID: 11673
		// (get) Token: 0x0600C47E RID: 50302 RVA: 0x0011C2C3 File Offset: 0x0011A4C3
		// (set) Token: 0x0600C47F RID: 50303 RVA: 0x0011C2D7 File Offset: 0x0011A4D7
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSparseVolumeTextureSampleParameter.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSparseVolumeTextureSampleParameter.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17002D9A RID: 11674
		// (get) Token: 0x0600C480 RID: 50304 RVA: 0x0011C2EC File Offset: 0x0011A4EC
		// (set) Token: 0x0600C481 RID: 50305 RVA: 0x0011C300 File Offset: 0x0011A500
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSparseVolumeTextureSampleParameter.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSparseVolumeTextureSampleParameter.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x17002D9B RID: 11675
		// (get) Token: 0x0600C482 RID: 50306 RVA: 0x0011C315 File Offset: 0x0011A515
		// (set) Token: 0x0600C483 RID: 50307 RVA: 0x0011C329 File Offset: 0x0011A529
		public unsafe FName Group
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSparseVolumeTextureSampleParameter.__PropertyOffset_Group);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSparseVolumeTextureSampleParameter.__PropertyOffset_Group) = value;
			}
		}

		// Token: 0x17002D9C RID: 11676
		// (get) Token: 0x0600C484 RID: 50308 RVA: 0x0011C33E File Offset: 0x0011A53E
		// (set) Token: 0x0600C485 RID: 50309 RVA: 0x0011C34E File Offset: 0x0011A54E
		public unsafe int SortPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSparseVolumeTextureSampleParameter.__PropertyOffset_SortPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSparseVolumeTextureSampleParameter.__PropertyOffset_SortPriority) = value;
			}
		}

		// Token: 0x0600C486 RID: 50310 RVA: 0x0011C35F File Offset: 0x0011A55F
		static UMaterialExpressionSparseVolumeTextureSampleParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSparseVolumeTextureSampleParameter");
		}

		// Token: 0x0600C487 RID: 50311 RVA: 0x0011C36D File Offset: 0x0011A56D
		protected UMaterialExpressionSparseVolumeTextureSampleParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040068EF RID: 26863
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSparseVolumeTextureSampleParameter";

		// Token: 0x040068F0 RID: 26864
		private static IntPtr _ClassPtr;

		// Token: 0x040068F1 RID: 26865
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040068F2 RID: 26866
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x040068F3 RID: 26867
		internal static int __PropertyOffset_ExpressionGUID;

		// Token: 0x040068F4 RID: 26868
		internal static int __PropertyOffset_Group;

		// Token: 0x040068F5 RID: 26869
		internal static int __PropertyOffset_SortPriority;
	}
}
