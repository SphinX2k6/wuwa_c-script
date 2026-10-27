using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E72 RID: 3698
	[UnrealObjectPath("/Script/Engine.MaterialExpressionVectorParameter")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class UMaterialExpressionVectorParameter : UMaterialExpressionParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C5BD RID: 50621 RVA: 0x0011E5F9 File Offset: 0x0011C7F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionVectorParameter._ClassPtr;
		}

		// Token: 0x0600C5BE RID: 50622 RVA: 0x0011E608 File Offset: 0x0011C808
		public UMaterialExpressionVectorParameter() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVectorParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C5BF RID: 50623 RVA: 0x0011E630 File Offset: 0x0011C830
		[NullableContext(1)]
		public UMaterialExpressionVectorParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVectorParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DE6 RID: 11750
		// (get) Token: 0x0600C5C0 RID: 50624 RVA: 0x0011E663 File Offset: 0x0011C863
		// (set) Token: 0x0600C5C1 RID: 50625 RVA: 0x0011E677 File Offset: 0x0011C877
		public unsafe FLinearColor DefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionVectorParameter.__PropertyOffset_DefaultValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionVectorParameter.__PropertyOffset_DefaultValue) = value;
			}
		}

		// Token: 0x17002DE7 RID: 11751
		// (get) Token: 0x0600C5C2 RID: 50626 RVA: 0x0011E68C File Offset: 0x0011C88C
		// (set) Token: 0x0600C5C3 RID: 50627 RVA: 0x0011E69C File Offset: 0x0011C89C
		public unsafe bool bUseCustomPrimitiveData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionVectorParameter.__PropertyOffset_bUseCustomPrimitiveData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionVectorParameter.__PropertyOffset_bUseCustomPrimitiveData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002DE8 RID: 11752
		// (get) Token: 0x0600C5C4 RID: 50628 RVA: 0x0011E6AD File Offset: 0x0011C8AD
		// (set) Token: 0x0600C5C5 RID: 50629 RVA: 0x0011E6BD File Offset: 0x0011C8BD
		public unsafe byte PrimitiveDataIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionVectorParameter.__PropertyOffset_PrimitiveDataIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionVectorParameter.__PropertyOffset_PrimitiveDataIndex) = value;
			}
		}

		// Token: 0x17002DE9 RID: 11753
		// (get) Token: 0x0600C5C6 RID: 50630 RVA: 0x0011E6CE File Offset: 0x0011C8CE
		// (set) Token: 0x0600C5C7 RID: 50631 RVA: 0x0011E6DE File Offset: 0x0011C8DE
		public unsafe bool bNoLerpInPP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionVectorParameter.__PropertyOffset_bNoLerpInPP) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionVectorParameter.__PropertyOffset_bNoLerpInPP) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600C5C8 RID: 50632 RVA: 0x0011E6EF File Offset: 0x0011C8EF
		static UMaterialExpressionVectorParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionVectorParameter");
		}

		// Token: 0x0600C5C9 RID: 50633 RVA: 0x0011E6FD File Offset: 0x0011C8FD
		protected UMaterialExpressionVectorParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040069CC RID: 27084
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionVectorParameter";

		// Token: 0x040069CD RID: 27085
		private static IntPtr _ClassPtr;

		// Token: 0x040069CE RID: 27086
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040069CF RID: 27087
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x040069D0 RID: 27088
		internal static int __PropertyOffset_bUseCustomPrimitiveData;

		// Token: 0x040069D1 RID: 27089
		internal static int __PropertyOffset_PrimitiveDataIndex;

		// Token: 0x040069D2 RID: 27090
		internal static int __PropertyOffset_bNoLerpInPP;
	}
}
