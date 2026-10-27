using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DBC RID: 3516
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionDotProduct")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMaterialExpressionDotProduct : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BEF0 RID: 48880 RVA: 0x00111A67 File Offset: 0x0010FC67
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionDotProduct._ClassPtr;
		}

		// Token: 0x0600BEF1 RID: 48881 RVA: 0x00111A74 File Offset: 0x0010FC74
		public UMaterialExpressionDotProduct() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDotProduct.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BEF2 RID: 48882 RVA: 0x00111A9C File Offset: 0x0010FC9C
		public UMaterialExpressionDotProduct(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDotProduct.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C44 RID: 11332
		// (get) Token: 0x0600BEF3 RID: 48883 RVA: 0x00111AD0 File Offset: 0x0010FCD0
		// (set) Token: 0x0600BEF4 RID: 48884 RVA: 0x00111B09 File Offset: 0x0010FD09
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionDotProduct.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionDotProduct.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C45 RID: 11333
		// (get) Token: 0x0600BEF5 RID: 48885 RVA: 0x00111B2C File Offset: 0x0010FD2C
		// (set) Token: 0x0600BEF6 RID: 48886 RVA: 0x00111B65 File Offset: 0x0010FD65
		public FExpressionInput B
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionDotProduct.__PropertyOffset_B, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionDotProduct.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BEF7 RID: 48887 RVA: 0x00111B86 File Offset: 0x0010FD86
		static UMaterialExpressionDotProduct()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionDotProduct");
		}

		// Token: 0x0600BEF8 RID: 48888 RVA: 0x00111B94 File Offset: 0x0010FD94
		protected UMaterialExpressionDotProduct(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006502 RID: 25858
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionDotProduct";

		// Token: 0x04006503 RID: 25859
		private static IntPtr _ClassPtr;

		// Token: 0x04006504 RID: 25860
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006505 RID: 25861
		internal static int __PropertyOffset_A;

		// Token: 0x04006506 RID: 25862
		[Nullable(2)]
		private FExpressionInput _A;

		// Token: 0x04006507 RID: 25863
		internal static int __PropertyOffset_B;

		// Token: 0x04006508 RID: 25864
		[Nullable(2)]
		private FExpressionInput _B;
	}
}
