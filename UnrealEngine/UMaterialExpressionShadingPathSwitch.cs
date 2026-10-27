using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E3E RID: 3646
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionShadingPathSwitch")]
	[UnrealStructLayout(416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UMaterialExpressionShadingPathSwitch : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C3D2 RID: 50130 RVA: 0x0011ADBB File Offset: 0x00118FBB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionShadingPathSwitch._ClassPtr;
		}

		// Token: 0x0600C3D3 RID: 50131 RVA: 0x0011ADC8 File Offset: 0x00118FC8
		public UMaterialExpressionShadingPathSwitch() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionShadingPathSwitch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C3D4 RID: 50132 RVA: 0x0011ADF0 File Offset: 0x00118FF0
		public UMaterialExpressionShadingPathSwitch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionShadingPathSwitch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D71 RID: 11633
		// (get) Token: 0x0600C3D5 RID: 50133 RVA: 0x0011AE24 File Offset: 0x00119024
		// (set) Token: 0x0600C3D6 RID: 50134 RVA: 0x0011AE5D File Offset: 0x0011905D
		public FExpressionInput Default
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Default) == null)
				{
					result = (this._Default = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionShadingPathSwitch.__PropertyOffset_Default, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionShadingPathSwitch.__PropertyOffset_Default, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D72 RID: 11634
		// (get) Token: 0x0600C3D7 RID: 50135 RVA: 0x0011AE80 File Offset: 0x00119080
		// (set) Token: 0x0600C3D8 RID: 50136 RVA: 0x0011AEBA File Offset: 0x001190BA
		public TFixedArray<FExpressionInput> Inputs
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FExpressionInput> result;
				if ((result = this._Inputs) == null)
				{
					result = (this._Inputs = new TFixedArray<FExpressionInput>(base.NativePtr + (IntPtr)UMaterialExpressionShadingPathSwitch.__PropertyOffset_Inputs, 3, this));
				}
				return result;
			}
			set
			{
				this.Inputs.CopyAssign(value);
			}
		}

		// Token: 0x0600C3D9 RID: 50137 RVA: 0x0011AEC8 File Offset: 0x001190C8
		static UMaterialExpressionShadingPathSwitch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionShadingPathSwitch");
		}

		// Token: 0x0600C3DA RID: 50138 RVA: 0x0011AED6 File Offset: 0x001190D6
		protected UMaterialExpressionShadingPathSwitch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006874 RID: 26740
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionShadingPathSwitch";

		// Token: 0x04006875 RID: 26741
		private static IntPtr _ClassPtr;

		// Token: 0x04006876 RID: 26742
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006877 RID: 26743
		internal static int __PropertyOffset_Default;

		// Token: 0x04006878 RID: 26744
		[Nullable(2)]
		private FExpressionInput _Default;

		// Token: 0x04006879 RID: 26745
		internal static int __PropertyOffset_Inputs;

		// Token: 0x0400687A RID: 26746
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FExpressionInput> _Inputs;
	}
}
