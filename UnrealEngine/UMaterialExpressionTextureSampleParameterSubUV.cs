using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E69 RID: 3689
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTextureSampleParameterSubUV")]
	[UnrealStructLayout(704, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 704)]
	public class UMaterialExpressionTextureSampleParameterSubUV : UMaterialExpressionTextureSampleParameter2D, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C56E RID: 50542 RVA: 0x0011DD5E File Offset: 0x0011BF5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTextureSampleParameterSubUV._ClassPtr;
		}

		// Token: 0x0600C56F RID: 50543 RVA: 0x0011DD6C File Offset: 0x0011BF6C
		public UMaterialExpressionTextureSampleParameterSubUV() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureSampleParameterSubUV.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C570 RID: 50544 RVA: 0x0011DD94 File Offset: 0x0011BF94
		[NullableContext(1)]
		public UMaterialExpressionTextureSampleParameterSubUV(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureSampleParameterSubUV.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DD5 RID: 11733
		// (get) Token: 0x0600C571 RID: 50545 RVA: 0x0011DDC7 File Offset: 0x0011BFC7
		// (set) Token: 0x0600C572 RID: 50546 RVA: 0x0011DDE0 File Offset: 0x0011BFE0
		public unsafe bool bBlend
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionTextureSampleParameterSubUV.__PropertyOffset_bBlend) & UMaterialExpressionTextureSampleParameterSubUV.__PropertyMask_bBlend) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionTextureSampleParameterSubUV.__PropertyOffset_bBlend) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionTextureSampleParameterSubUV.__PropertyOffset_bBlend) & ~UMaterialExpressionTextureSampleParameterSubUV.__PropertyMask_bBlend) | (value ? UMaterialExpressionTextureSampleParameterSubUV.__PropertyMask_bBlend : 0));
			}
		}

		// Token: 0x0600C573 RID: 50547 RVA: 0x0011DE10 File Offset: 0x0011C010
		static UMaterialExpressionTextureSampleParameterSubUV()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTextureSampleParameterSubUV");
		}

		// Token: 0x0600C574 RID: 50548 RVA: 0x0011DE1E File Offset: 0x0011C01E
		protected UMaterialExpressionTextureSampleParameterSubUV(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006997 RID: 27031
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTextureSampleParameterSubUV";

		// Token: 0x04006998 RID: 27032
		private static IntPtr _ClassPtr;

		// Token: 0x04006999 RID: 27033
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400699A RID: 27034
		internal static int __PropertyOffset_bBlend;

		// Token: 0x0400699B RID: 27035
		internal static byte __PropertyMask_bBlend;
	}
}
