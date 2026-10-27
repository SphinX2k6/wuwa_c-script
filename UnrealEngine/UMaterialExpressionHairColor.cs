using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DD3 RID: 3539
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionHairColor")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class UMaterialExpressionHairColor : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BFCF RID: 49103 RVA: 0x00113463 File Offset: 0x00111663
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionHairColor._ClassPtr;
		}

		// Token: 0x0600BFD0 RID: 49104 RVA: 0x00113470 File Offset: 0x00111670
		public UMaterialExpressionHairColor() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionHairColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BFD1 RID: 49105 RVA: 0x00113498 File Offset: 0x00111698
		public UMaterialExpressionHairColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionHairColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C7A RID: 11386
		// (get) Token: 0x0600BFD2 RID: 49106 RVA: 0x001134CC File Offset: 0x001116CC
		// (set) Token: 0x0600BFD3 RID: 49107 RVA: 0x00113505 File Offset: 0x00111705
		public FExpressionInput Melanin
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Melanin) == null)
				{
					result = (this._Melanin = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionHairColor.__PropertyOffset_Melanin, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionHairColor.__PropertyOffset_Melanin, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C7B RID: 11387
		// (get) Token: 0x0600BFD4 RID: 49108 RVA: 0x00113528 File Offset: 0x00111728
		// (set) Token: 0x0600BFD5 RID: 49109 RVA: 0x00113561 File Offset: 0x00111761
		public FExpressionInput Redness
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Redness) == null)
				{
					result = (this._Redness = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionHairColor.__PropertyOffset_Redness, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionHairColor.__PropertyOffset_Redness, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C7C RID: 11388
		// (get) Token: 0x0600BFD6 RID: 49110 RVA: 0x00113584 File Offset: 0x00111784
		// (set) Token: 0x0600BFD7 RID: 49111 RVA: 0x001135BD File Offset: 0x001117BD
		public FExpressionInput DyeColor
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._DyeColor) == null)
				{
					result = (this._DyeColor = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionHairColor.__PropertyOffset_DyeColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionHairColor.__PropertyOffset_DyeColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BFD8 RID: 49112 RVA: 0x001135DE File Offset: 0x001117DE
		static UMaterialExpressionHairColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionHairColor");
		}

		// Token: 0x0600BFD9 RID: 49113 RVA: 0x001135EC File Offset: 0x001117EC
		protected UMaterialExpressionHairColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400659E RID: 26014
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionHairColor";

		// Token: 0x0400659F RID: 26015
		private static IntPtr _ClassPtr;

		// Token: 0x040065A0 RID: 26016
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040065A1 RID: 26017
		internal static int __PropertyOffset_Melanin;

		// Token: 0x040065A2 RID: 26018
		[Nullable(2)]
		private FExpressionInput _Melanin;

		// Token: 0x040065A3 RID: 26019
		internal static int __PropertyOffset_Redness;

		// Token: 0x040065A4 RID: 26020
		[Nullable(2)]
		private FExpressionInput _Redness;

		// Token: 0x040065A5 RID: 26021
		internal static int __PropertyOffset_DyeColor;

		// Token: 0x040065A6 RID: 26022
		[Nullable(2)]
		private FExpressionInput _DyeColor;
	}
}
