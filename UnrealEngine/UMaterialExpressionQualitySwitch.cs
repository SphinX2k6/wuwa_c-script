using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E22 RID: 3618
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionQualitySwitch")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class UMaterialExpressionQualitySwitch : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C2AB RID: 49835 RVA: 0x00118B32 File Offset: 0x00116D32
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionQualitySwitch._ClassPtr;
		}

		// Token: 0x0600C2AC RID: 49836 RVA: 0x00118B40 File Offset: 0x00116D40
		public UMaterialExpressionQualitySwitch() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionQualitySwitch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C2AD RID: 49837 RVA: 0x00118B68 File Offset: 0x00116D68
		public UMaterialExpressionQualitySwitch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionQualitySwitch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D23 RID: 11555
		// (get) Token: 0x0600C2AE RID: 49838 RVA: 0x00118B9C File Offset: 0x00116D9C
		// (set) Token: 0x0600C2AF RID: 49839 RVA: 0x00118BD5 File Offset: 0x00116DD5
		public FExpressionInput Default
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Default) == null)
				{
					result = (this._Default = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionQualitySwitch.__PropertyOffset_Default, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionQualitySwitch.__PropertyOffset_Default, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D24 RID: 11556
		// (get) Token: 0x0600C2B0 RID: 49840 RVA: 0x00118BF8 File Offset: 0x00116DF8
		// (set) Token: 0x0600C2B1 RID: 49841 RVA: 0x00118C32 File Offset: 0x00116E32
		public TFixedArray<FExpressionInput> Inputs
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FExpressionInput> result;
				if ((result = this._Inputs) == null)
				{
					result = (this._Inputs = new TFixedArray<FExpressionInput>(base.NativePtr + (IntPtr)UMaterialExpressionQualitySwitch.__PropertyOffset_Inputs, 4, this));
				}
				return result;
			}
			set
			{
				this.Inputs.CopyAssign(value);
			}
		}

		// Token: 0x17002D25 RID: 11557
		// (get) Token: 0x0600C2B2 RID: 49842 RVA: 0x00118C40 File Offset: 0x00116E40
		// (set) Token: 0x0600C2B3 RID: 49843 RVA: 0x00118C79 File Offset: 0x00116E79
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<ERHIFeatureLevelStrip>> StripFeatureLevels
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<ERHIFeatureLevelStrip>> result;
				if ((result = this._StripFeatureLevels) == null)
				{
					result = (this._StripFeatureLevels = new TArray<TEnumAsByte<ERHIFeatureLevelStrip>>(base.NativePtr + (IntPtr)UMaterialExpressionQualitySwitch.__PropertyOffset_StripFeatureLevels, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.StripFeatureLevels.CopyAssign(value);
			}
		}

		// Token: 0x0600C2B4 RID: 49844 RVA: 0x00118C87 File Offset: 0x00116E87
		static UMaterialExpressionQualitySwitch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionQualitySwitch");
		}

		// Token: 0x0600C2B5 RID: 49845 RVA: 0x00118C95 File Offset: 0x00116E95
		protected UMaterialExpressionQualitySwitch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040067A4 RID: 26532
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionQualitySwitch";

		// Token: 0x040067A5 RID: 26533
		private static IntPtr _ClassPtr;

		// Token: 0x040067A6 RID: 26534
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040067A7 RID: 26535
		internal static int __PropertyOffset_Default;

		// Token: 0x040067A8 RID: 26536
		[Nullable(2)]
		private FExpressionInput _Default;

		// Token: 0x040067A9 RID: 26537
		internal static int __PropertyOffset_Inputs;

		// Token: 0x040067AA RID: 26538
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FExpressionInput> _Inputs;

		// Token: 0x040067AB RID: 26539
		internal static int __PropertyOffset_StripFeatureLevels;

		// Token: 0x040067AC RID: 26540
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<ERHIFeatureLevelStrip>> _StripFeatureLevels;
	}
}
