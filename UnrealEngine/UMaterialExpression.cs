using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D7E RID: 3454
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpression")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public abstract class UMaterialExpression : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BCD7 RID: 48343 RVA: 0x0010DDED File Offset: 0x0010BFED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpression._ClassPtr;
		}

		// Token: 0x17002BD1 RID: 11217
		// (get) Token: 0x0600BCD8 RID: 48344 RVA: 0x0010DDF9 File Offset: 0x0010BFF9
		// (set) Token: 0x0600BCD9 RID: 48345 RVA: 0x0010DE0D File Offset: 0x0010C00D
		public unsafe UMaterial Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpression.__PropertyOffset_Material);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpression.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x17002BD2 RID: 11218
		// (get) Token: 0x0600BCDA RID: 48346 RVA: 0x0010DE22 File Offset: 0x0010C022
		// (set) Token: 0x0600BCDB RID: 48347 RVA: 0x0010DE36 File Offset: 0x0010C036
		public unsafe UMaterialFunction Function
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialFunction>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpression.__PropertyOffset_Function);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpression.__PropertyOffset_Function, value);
			}
		}

		// Token: 0x17002BD3 RID: 11219
		// (get) Token: 0x0600BCDC RID: 48348 RVA: 0x0010DE4B File Offset: 0x0010C04B
		// (set) Token: 0x0600BCDD RID: 48349 RVA: 0x0010DE64 File Offset: 0x0010C064
		public unsafe bool bIsParameterExpression
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpression.__PropertyOffset_bIsParameterExpression) & UMaterialExpression.__PropertyMask_bIsParameterExpression) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpression.__PropertyOffset_bIsParameterExpression) = ((*(base.NativePtr + (IntPtr)UMaterialExpression.__PropertyOffset_bIsParameterExpression) & ~UMaterialExpression.__PropertyMask_bIsParameterExpression) | (value ? UMaterialExpression.__PropertyMask_bIsParameterExpression : 0));
			}
		}

		// Token: 0x0600BCDE RID: 48350 RVA: 0x0010DE94 File Offset: 0x0010C094
		static UMaterialExpression()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpression");
		}

		// Token: 0x0600BCDF RID: 48351 RVA: 0x0010DEA4 File Offset: 0x0010C0A4
		protected UMaterialExpression() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpression.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BCE0 RID: 48352 RVA: 0x0010DECC File Offset: 0x0010C0CC
		protected UMaterialExpression(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006391 RID: 25489
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpression";

		// Token: 0x04006392 RID: 25490
		private static IntPtr _ClassPtr;

		// Token: 0x04006393 RID: 25491
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006394 RID: 25492
		internal static int __PropertyOffset_Material;

		// Token: 0x04006395 RID: 25493
		internal static int __PropertyOffset_Function;

		// Token: 0x04006396 RID: 25494
		internal static int __PropertyOffset_bIsParameterExpression;

		// Token: 0x04006397 RID: 25495
		internal static byte __PropertyMask_bIsParameterExpression;
	}
}
