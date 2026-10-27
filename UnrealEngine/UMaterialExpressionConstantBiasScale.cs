using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DA5 RID: 3493
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionConstantBiasScale")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionConstantBiasScale : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BE2A RID: 48682 RVA: 0x001103D3 File Offset: 0x0010E5D3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionConstantBiasScale._ClassPtr;
		}

		// Token: 0x0600BE2B RID: 48683 RVA: 0x001103E0 File Offset: 0x0010E5E0
		public UMaterialExpressionConstantBiasScale() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionConstantBiasScale.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BE2C RID: 48684 RVA: 0x00110408 File Offset: 0x0010E608
		public UMaterialExpressionConstantBiasScale(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionConstantBiasScale.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C1A RID: 11290
		// (get) Token: 0x0600BE2D RID: 48685 RVA: 0x0011043C File Offset: 0x0010E63C
		// (set) Token: 0x0600BE2E RID: 48686 RVA: 0x00110475 File Offset: 0x0010E675
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionConstantBiasScale.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionConstantBiasScale.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C1B RID: 11291
		// (get) Token: 0x0600BE2F RID: 48687 RVA: 0x00110496 File Offset: 0x0010E696
		// (set) Token: 0x0600BE30 RID: 48688 RVA: 0x001104A6 File Offset: 0x0010E6A6
		public unsafe float Bias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionConstantBiasScale.__PropertyOffset_Bias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionConstantBiasScale.__PropertyOffset_Bias) = value;
			}
		}

		// Token: 0x17002C1C RID: 11292
		// (get) Token: 0x0600BE31 RID: 48689 RVA: 0x001104B7 File Offset: 0x0010E6B7
		// (set) Token: 0x0600BE32 RID: 48690 RVA: 0x001104C7 File Offset: 0x0010E6C7
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionConstantBiasScale.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionConstantBiasScale.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x0600BE33 RID: 48691 RVA: 0x001104D8 File Offset: 0x0010E6D8
		static UMaterialExpressionConstantBiasScale()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionConstantBiasScale");
		}

		// Token: 0x0600BE34 RID: 48692 RVA: 0x001104E6 File Offset: 0x0010E6E6
		protected UMaterialExpressionConstantBiasScale(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006479 RID: 25721
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionConstantBiasScale";

		// Token: 0x0400647A RID: 25722
		private static IntPtr _ClassPtr;

		// Token: 0x0400647B RID: 25723
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400647C RID: 25724
		internal static int __PropertyOffset_Input;

		// Token: 0x0400647D RID: 25725
		[Nullable(2)]
		private FExpressionInput _Input;

		// Token: 0x0400647E RID: 25726
		internal static int __PropertyOffset_Bias;

		// Token: 0x0400647F RID: 25727
		internal static int __PropertyOffset_Scale;
	}
}
