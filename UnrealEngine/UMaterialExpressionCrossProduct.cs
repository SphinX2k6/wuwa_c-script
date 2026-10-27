using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DA7 RID: 3495
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionCrossProduct")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMaterialExpressionCrossProduct : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BE3E RID: 48702 RVA: 0x001105EA File Offset: 0x0010E7EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionCrossProduct._ClassPtr;
		}

		// Token: 0x0600BE3F RID: 48703 RVA: 0x001105F8 File Offset: 0x0010E7F8
		public UMaterialExpressionCrossProduct() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCrossProduct.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BE40 RID: 48704 RVA: 0x00110620 File Offset: 0x0010E820
		public UMaterialExpressionCrossProduct(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCrossProduct.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C1F RID: 11295
		// (get) Token: 0x0600BE41 RID: 48705 RVA: 0x00110654 File Offset: 0x0010E854
		// (set) Token: 0x0600BE42 RID: 48706 RVA: 0x0011068D File Offset: 0x0010E88D
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionCrossProduct.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionCrossProduct.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C20 RID: 11296
		// (get) Token: 0x0600BE43 RID: 48707 RVA: 0x001106B0 File Offset: 0x0010E8B0
		// (set) Token: 0x0600BE44 RID: 48708 RVA: 0x001106E9 File Offset: 0x0010E8E9
		public FExpressionInput B
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionCrossProduct.__PropertyOffset_B, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionCrossProduct.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BE45 RID: 48709 RVA: 0x0011070A File Offset: 0x0010E90A
		static UMaterialExpressionCrossProduct()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionCrossProduct");
		}

		// Token: 0x0600BE46 RID: 48710 RVA: 0x00110718 File Offset: 0x0010E918
		protected UMaterialExpressionCrossProduct(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006486 RID: 25734
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionCrossProduct";

		// Token: 0x04006487 RID: 25735
		private static IntPtr _ClassPtr;

		// Token: 0x04006488 RID: 25736
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006489 RID: 25737
		internal static int __PropertyOffset_A;

		// Token: 0x0400648A RID: 25738
		[Nullable(2)]
		private FExpressionInput _A;

		// Token: 0x0400648B RID: 25739
		internal static int __PropertyOffset_B;

		// Token: 0x0400648C RID: 25740
		[Nullable(2)]
		private FExpressionInput _B;
	}
}
