using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E65 RID: 3685
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTextureSampleParameter")]
	[UnrealStructLayout(696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 696)]
	public abstract class UMaterialExpressionTextureSampleParameter : UMaterialExpressionTextureSample, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C555 RID: 50517 RVA: 0x0011DB15 File Offset: 0x0011BD15
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTextureSampleParameter._ClassPtr;
		}

		// Token: 0x17002DD2 RID: 11730
		// (get) Token: 0x0600C556 RID: 50518 RVA: 0x0011DB21 File Offset: 0x0011BD21
		// (set) Token: 0x0600C557 RID: 50519 RVA: 0x0011DB35 File Offset: 0x0011BD35
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionTextureSampleParameter.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionTextureSampleParameter.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x17002DD3 RID: 11731
		// (get) Token: 0x0600C558 RID: 50520 RVA: 0x0011DB4A File Offset: 0x0011BD4A
		// (set) Token: 0x0600C559 RID: 50521 RVA: 0x0011DB5E File Offset: 0x0011BD5E
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionTextureSampleParameter.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionTextureSampleParameter.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x17002DD4 RID: 11732
		// (get) Token: 0x0600C55A RID: 50522 RVA: 0x0011DB73 File Offset: 0x0011BD73
		// (set) Token: 0x0600C55B RID: 50523 RVA: 0x0011DB87 File Offset: 0x0011BD87
		public unsafe FName Group
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionTextureSampleParameter.__PropertyOffset_Group);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionTextureSampleParameter.__PropertyOffset_Group) = value;
			}
		}

		// Token: 0x0600C55C RID: 50524 RVA: 0x0011DB9C File Offset: 0x0011BD9C
		static UMaterialExpressionTextureSampleParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTextureSampleParameter");
		}

		// Token: 0x0600C55D RID: 50525 RVA: 0x0011DBAC File Offset: 0x0011BDAC
		protected UMaterialExpressionTextureSampleParameter() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureSampleParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C55E RID: 50526 RVA: 0x0011DBD4 File Offset: 0x0011BDD4
		protected UMaterialExpressionTextureSampleParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006988 RID: 27016
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTextureSampleParameter";

		// Token: 0x04006989 RID: 27017
		private static IntPtr _ClassPtr;

		// Token: 0x0400698A RID: 27018
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400698B RID: 27019
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x0400698C RID: 27020
		internal static int __PropertyOffset_ExpressionGUID;

		// Token: 0x0400698D RID: 27021
		internal static int __PropertyOffset_Group;
	}
}
