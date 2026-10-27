using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E5A RID: 3674
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionStep")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMaterialExpressionStep : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C4EF RID: 50415 RVA: 0x0011D002 File Offset: 0x0011B202
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionStep._ClassPtr;
		}

		// Token: 0x0600C4F0 RID: 50416 RVA: 0x0011D010 File Offset: 0x0011B210
		public UMaterialExpressionStep() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionStep.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C4F1 RID: 50417 RVA: 0x0011D038 File Offset: 0x0011B238
		public UMaterialExpressionStep(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionStep.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DBA RID: 11706
		// (get) Token: 0x0600C4F2 RID: 50418 RVA: 0x0011D06C File Offset: 0x0011B26C
		// (set) Token: 0x0600C4F3 RID: 50419 RVA: 0x0011D0A5 File Offset: 0x0011B2A5
		public FExpressionInput Y
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Y) == null)
				{
					result = (this._Y = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionStep.__PropertyOffset_Y, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionStep.__PropertyOffset_Y, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DBB RID: 11707
		// (get) Token: 0x0600C4F4 RID: 50420 RVA: 0x0011D0C8 File Offset: 0x0011B2C8
		// (set) Token: 0x0600C4F5 RID: 50421 RVA: 0x0011D101 File Offset: 0x0011B301
		public FExpressionInput X
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._X) == null)
				{
					result = (this._X = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionStep.__PropertyOffset_X, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionStep.__PropertyOffset_X, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DBC RID: 11708
		// (get) Token: 0x0600C4F6 RID: 50422 RVA: 0x0011D122 File Offset: 0x0011B322
		// (set) Token: 0x0600C4F7 RID: 50423 RVA: 0x0011D132 File Offset: 0x0011B332
		public unsafe float ConstY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionStep.__PropertyOffset_ConstY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionStep.__PropertyOffset_ConstY) = value;
			}
		}

		// Token: 0x17002DBD RID: 11709
		// (get) Token: 0x0600C4F8 RID: 50424 RVA: 0x0011D143 File Offset: 0x0011B343
		// (set) Token: 0x0600C4F9 RID: 50425 RVA: 0x0011D153 File Offset: 0x0011B353
		public unsafe float ConstX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionStep.__PropertyOffset_ConstX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionStep.__PropertyOffset_ConstX) = value;
			}
		}

		// Token: 0x0600C4FA RID: 50426 RVA: 0x0011D164 File Offset: 0x0011B364
		static UMaterialExpressionStep()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionStep");
		}

		// Token: 0x0600C4FB RID: 50427 RVA: 0x0011D172 File Offset: 0x0011B372
		protected UMaterialExpressionStep(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006943 RID: 26947
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionStep";

		// Token: 0x04006944 RID: 26948
		private static IntPtr _ClassPtr;

		// Token: 0x04006945 RID: 26949
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006946 RID: 26950
		internal static int __PropertyOffset_Y;

		// Token: 0x04006947 RID: 26951
		[Nullable(2)]
		private FExpressionInput _Y;

		// Token: 0x04006948 RID: 26952
		internal static int __PropertyOffset_X;

		// Token: 0x04006949 RID: 26953
		[Nullable(2)]
		private FExpressionInput _X;

		// Token: 0x0400694A RID: 26954
		internal static int __PropertyOffset_ConstY;

		// Token: 0x0400694B RID: 26955
		internal static int __PropertyOffset_ConstX;
	}
}
