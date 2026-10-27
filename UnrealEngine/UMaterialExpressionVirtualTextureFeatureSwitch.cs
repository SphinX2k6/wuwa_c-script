using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E7C RID: 3708
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionVirtualTextureFeatureSwitch")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMaterialExpressionVirtualTextureFeatureSwitch : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C5FB RID: 50683 RVA: 0x0011EC0A File Offset: 0x0011CE0A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionVirtualTextureFeatureSwitch._ClassPtr;
		}

		// Token: 0x0600C5FC RID: 50684 RVA: 0x0011EC18 File Offset: 0x0011CE18
		public UMaterialExpressionVirtualTextureFeatureSwitch() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVirtualTextureFeatureSwitch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C5FD RID: 50685 RVA: 0x0011EC40 File Offset: 0x0011CE40
		public UMaterialExpressionVirtualTextureFeatureSwitch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVirtualTextureFeatureSwitch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DEC RID: 11756
		// (get) Token: 0x0600C5FE RID: 50686 RVA: 0x0011EC74 File Offset: 0x0011CE74
		// (set) Token: 0x0600C5FF RID: 50687 RVA: 0x0011ECAD File Offset: 0x0011CEAD
		public FExpressionInput No
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._No) == null)
				{
					result = (this._No = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionVirtualTextureFeatureSwitch.__PropertyOffset_No, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionVirtualTextureFeatureSwitch.__PropertyOffset_No, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DED RID: 11757
		// (get) Token: 0x0600C600 RID: 50688 RVA: 0x0011ECD0 File Offset: 0x0011CED0
		// (set) Token: 0x0600C601 RID: 50689 RVA: 0x0011ED09 File Offset: 0x0011CF09
		public FExpressionInput Yes
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Yes) == null)
				{
					result = (this._Yes = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionVirtualTextureFeatureSwitch.__PropertyOffset_Yes, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionVirtualTextureFeatureSwitch.__PropertyOffset_Yes, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C602 RID: 50690 RVA: 0x0011ED2A File Offset: 0x0011CF2A
		static UMaterialExpressionVirtualTextureFeatureSwitch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionVirtualTextureFeatureSwitch");
		}

		// Token: 0x0600C603 RID: 50691 RVA: 0x0011ED38 File Offset: 0x0011CF38
		protected UMaterialExpressionVirtualTextureFeatureSwitch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040069F1 RID: 27121
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionVirtualTextureFeatureSwitch";

		// Token: 0x040069F2 RID: 27122
		private static IntPtr _ClassPtr;

		// Token: 0x040069F3 RID: 27123
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040069F4 RID: 27124
		internal static int __PropertyOffset_No;

		// Token: 0x040069F5 RID: 27125
		[Nullable(2)]
		private FExpressionInput _No;

		// Token: 0x040069F6 RID: 27126
		internal static int __PropertyOffset_Yes;

		// Token: 0x040069F7 RID: 27127
		[Nullable(2)]
		private FExpressionInput _Yes;
	}
}
