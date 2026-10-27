using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E2F RID: 3631
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionRuntimeVirtualTextureSample")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class UMaterialExpressionRuntimeVirtualTextureSample : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C335 RID: 49973 RVA: 0x00119D31 File Offset: 0x00117F31
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionRuntimeVirtualTextureSample._ClassPtr;
		}

		// Token: 0x0600C336 RID: 49974 RVA: 0x00119D40 File Offset: 0x00117F40
		public UMaterialExpressionRuntimeVirtualTextureSample() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionRuntimeVirtualTextureSample.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C337 RID: 49975 RVA: 0x00119D68 File Offset: 0x00117F68
		public UMaterialExpressionRuntimeVirtualTextureSample(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionRuntimeVirtualTextureSample.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D48 RID: 11592
		// (get) Token: 0x0600C338 RID: 49976 RVA: 0x00119D9C File Offset: 0x00117F9C
		// (set) Token: 0x0600C339 RID: 49977 RVA: 0x00119DD5 File Offset: 0x00117FD5
		public FExpressionInput Coordinates
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Coordinates) == null)
				{
					result = (this._Coordinates = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSample.__PropertyOffset_Coordinates, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSample.__PropertyOffset_Coordinates, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D49 RID: 11593
		// (get) Token: 0x0600C33A RID: 49978 RVA: 0x00119DF8 File Offset: 0x00117FF8
		// (set) Token: 0x0600C33B RID: 49979 RVA: 0x00119E31 File Offset: 0x00118031
		public FExpressionInput WorldPosition
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._WorldPosition) == null)
				{
					result = (this._WorldPosition = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSample.__PropertyOffset_WorldPosition, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSample.__PropertyOffset_WorldPosition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D4A RID: 11594
		// (get) Token: 0x0600C33C RID: 49980 RVA: 0x00119E54 File Offset: 0x00118054
		// (set) Token: 0x0600C33D RID: 49981 RVA: 0x00119E8D File Offset: 0x0011808D
		public FExpressionInput MipValue
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._MipValue) == null)
				{
					result = (this._MipValue = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSample.__PropertyOffset_MipValue, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSample.__PropertyOffset_MipValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D4B RID: 11595
		// (get) Token: 0x0600C33E RID: 49982 RVA: 0x00119EAE File Offset: 0x001180AE
		// (set) Token: 0x0600C33F RID: 49983 RVA: 0x00119EC2 File Offset: 0x001180C2
		[Nullable(2)]
		public unsafe URuntimeVirtualTexture VirtualTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URuntimeVirtualTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpressionRuntimeVirtualTextureSample.__PropertyOffset_VirtualTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpressionRuntimeVirtualTextureSample.__PropertyOffset_VirtualTexture, value);
			}
		}

		// Token: 0x17002D4C RID: 11596
		// (get) Token: 0x0600C340 RID: 49984 RVA: 0x00119ED7 File Offset: 0x001180D7
		// (set) Token: 0x0600C341 RID: 49985 RVA: 0x00119EE7 File Offset: 0x001180E7
		public unsafe ERuntimeVirtualTextureMaterialType MaterialType
		{
			get
			{
				return (ERuntimeVirtualTextureMaterialType)(*(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSample.__PropertyOffset_MaterialType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSample.__PropertyOffset_MaterialType) = (byte)value;
			}
		}

		// Token: 0x17002D4D RID: 11597
		// (get) Token: 0x0600C342 RID: 49986 RVA: 0x00119EF8 File Offset: 0x001180F8
		// (set) Token: 0x0600C343 RID: 49987 RVA: 0x00119F08 File Offset: 0x00118108
		public unsafe bool bSinglePhysicalSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSample.__PropertyOffset_bSinglePhysicalSpace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSample.__PropertyOffset_bSinglePhysicalSpace) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002D4E RID: 11598
		// (get) Token: 0x0600C344 RID: 49988 RVA: 0x00119F19 File Offset: 0x00118119
		// (set) Token: 0x0600C345 RID: 49989 RVA: 0x00119F29 File Offset: 0x00118129
		public unsafe bool bAdaptive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSample.__PropertyOffset_bAdaptive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSample.__PropertyOffset_bAdaptive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002D4F RID: 11599
		// (get) Token: 0x0600C346 RID: 49990 RVA: 0x00119F3A File Offset: 0x0011813A
		// (set) Token: 0x0600C347 RID: 49991 RVA: 0x00119F4E File Offset: 0x0011814E
		[Nullable(0)]
		public unsafe TEnumAsByte<ERuntimeVirtualTextureMipValueMode> MipValueMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSample.__PropertyOffset_MipValueMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSample.__PropertyOffset_MipValueMode) = value;
			}
		}

		// Token: 0x17002D50 RID: 11600
		// (get) Token: 0x0600C348 RID: 49992 RVA: 0x00119F63 File Offset: 0x00118163
		// (set) Token: 0x0600C349 RID: 49993 RVA: 0x00119F77 File Offset: 0x00118177
		[Nullable(0)]
		public unsafe TEnumAsByte<ERuntimeVirtualTextureTextureAddressMode> TextureAddressMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSample.__PropertyOffset_TextureAddressMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionRuntimeVirtualTextureSample.__PropertyOffset_TextureAddressMode) = value;
			}
		}

		// Token: 0x0600C34A RID: 49994 RVA: 0x00119F8C File Offset: 0x0011818C
		static UMaterialExpressionRuntimeVirtualTextureSample()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionRuntimeVirtualTextureSample");
		}

		// Token: 0x0600C34B RID: 49995 RVA: 0x00119F9A File Offset: 0x0011819A
		protected UMaterialExpressionRuntimeVirtualTextureSample(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400680F RID: 26639
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionRuntimeVirtualTextureSample";

		// Token: 0x04006810 RID: 26640
		private static IntPtr _ClassPtr;

		// Token: 0x04006811 RID: 26641
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006812 RID: 26642
		internal static int __PropertyOffset_Coordinates;

		// Token: 0x04006813 RID: 26643
		[Nullable(2)]
		private FExpressionInput _Coordinates;

		// Token: 0x04006814 RID: 26644
		internal static int __PropertyOffset_WorldPosition;

		// Token: 0x04006815 RID: 26645
		[Nullable(2)]
		private FExpressionInput _WorldPosition;

		// Token: 0x04006816 RID: 26646
		internal static int __PropertyOffset_MipValue;

		// Token: 0x04006817 RID: 26647
		[Nullable(2)]
		private FExpressionInput _MipValue;

		// Token: 0x04006818 RID: 26648
		internal static int __PropertyOffset_VirtualTexture;

		// Token: 0x04006819 RID: 26649
		internal static int __PropertyOffset_MaterialType;

		// Token: 0x0400681A RID: 26650
		internal static int __PropertyOffset_bSinglePhysicalSpace;

		// Token: 0x0400681B RID: 26651
		internal static int __PropertyOffset_bAdaptive;

		// Token: 0x0400681C RID: 26652
		internal static int __PropertyOffset_MipValueMode;

		// Token: 0x0400681D RID: 26653
		internal static int __PropertyOffset_TextureAddressMode;
	}
}
