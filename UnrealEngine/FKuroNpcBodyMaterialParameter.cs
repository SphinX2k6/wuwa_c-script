using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B7C RID: 7036
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroNpcBodyMaterialParameter")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FKuroNpcBodyMaterialParameter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601AB2D RID: 109357 RVA: 0x002756A2 File Offset: 0x002738A2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroNpcBodyMaterialParameter._ScriptStructPtr != 0) ? FKuroNpcBodyMaterialParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroNpcBodyMaterialParameter", ref FKuroNpcBodyMaterialParameter._ScriptStructPtr);
		}

		// Token: 0x17006B5F RID: 27487
		// (get) Token: 0x0601AB2E RID: 109358 RVA: 0x002756C6 File Offset: 0x002738C6
		// (set) Token: 0x0601AB2F RID: 109359 RVA: 0x002756D6 File Offset: 0x002738D6
		public unsafe EKuroNpcBodyType BodyType
		{
			get
			{
				return (EKuroNpcBodyType)(*(base.NativePtr + (IntPtr)FKuroNpcBodyMaterialParameter.__PropertyOffset_BodyType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroNpcBodyMaterialParameter.__PropertyOffset_BodyType) = (byte)value;
			}
		}

		// Token: 0x17006B60 RID: 27488
		// (get) Token: 0x0601AB30 RID: 109360 RVA: 0x002756E7 File Offset: 0x002738E7
		// (set) Token: 0x0601AB31 RID: 109361 RVA: 0x00275700 File Offset: 0x00273900
		public unsafe bool bOverrideDyeColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroNpcBodyMaterialParameter.__PropertyOffset_bOverrideDyeColor) & FKuroNpcBodyMaterialParameter.__PropertyMask_bOverrideDyeColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroNpcBodyMaterialParameter.__PropertyOffset_bOverrideDyeColor) = ((*(base.NativePtr + (IntPtr)FKuroNpcBodyMaterialParameter.__PropertyOffset_bOverrideDyeColor) & ~FKuroNpcBodyMaterialParameter.__PropertyMask_bOverrideDyeColor) | (value ? FKuroNpcBodyMaterialParameter.__PropertyMask_bOverrideDyeColor : 0));
			}
		}

		// Token: 0x17006B61 RID: 27489
		// (get) Token: 0x0601AB32 RID: 109362 RVA: 0x00275730 File Offset: 0x00273930
		// (set) Token: 0x0601AB33 RID: 109363 RVA: 0x00275749 File Offset: 0x00273949
		public unsafe bool bOverrideColor1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroNpcBodyMaterialParameter.__PropertyOffset_bOverrideColor1) & FKuroNpcBodyMaterialParameter.__PropertyMask_bOverrideColor1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroNpcBodyMaterialParameter.__PropertyOffset_bOverrideColor1) = ((*(base.NativePtr + (IntPtr)FKuroNpcBodyMaterialParameter.__PropertyOffset_bOverrideColor1) & ~FKuroNpcBodyMaterialParameter.__PropertyMask_bOverrideColor1) | (value ? FKuroNpcBodyMaterialParameter.__PropertyMask_bOverrideColor1 : 0));
			}
		}

		// Token: 0x17006B62 RID: 27490
		// (get) Token: 0x0601AB34 RID: 109364 RVA: 0x00275779 File Offset: 0x00273979
		// (set) Token: 0x0601AB35 RID: 109365 RVA: 0x00275792 File Offset: 0x00273992
		public unsafe bool bOverrideColor2
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroNpcBodyMaterialParameter.__PropertyOffset_bOverrideColor2) & FKuroNpcBodyMaterialParameter.__PropertyMask_bOverrideColor2) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroNpcBodyMaterialParameter.__PropertyOffset_bOverrideColor2) = ((*(base.NativePtr + (IntPtr)FKuroNpcBodyMaterialParameter.__PropertyOffset_bOverrideColor2) & ~FKuroNpcBodyMaterialParameter.__PropertyMask_bOverrideColor2) | (value ? FKuroNpcBodyMaterialParameter.__PropertyMask_bOverrideColor2 : 0));
			}
		}

		// Token: 0x17006B63 RID: 27491
		// (get) Token: 0x0601AB36 RID: 109366 RVA: 0x002757C2 File Offset: 0x002739C2
		// (set) Token: 0x0601AB37 RID: 109367 RVA: 0x002757D6 File Offset: 0x002739D6
		public unsafe FLinearColor DyeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroNpcBodyMaterialParameter.__PropertyOffset_DyeColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroNpcBodyMaterialParameter.__PropertyOffset_DyeColor) = value;
			}
		}

		// Token: 0x17006B64 RID: 27492
		// (get) Token: 0x0601AB38 RID: 109368 RVA: 0x002757EB File Offset: 0x002739EB
		// (set) Token: 0x0601AB39 RID: 109369 RVA: 0x002757FF File Offset: 0x002739FF
		public unsafe FLinearColor Color1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroNpcBodyMaterialParameter.__PropertyOffset_Color1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroNpcBodyMaterialParameter.__PropertyOffset_Color1) = value;
			}
		}

		// Token: 0x17006B65 RID: 27493
		// (get) Token: 0x0601AB3A RID: 109370 RVA: 0x00275814 File Offset: 0x00273A14
		// (set) Token: 0x0601AB3B RID: 109371 RVA: 0x00275828 File Offset: 0x00273A28
		public unsafe FLinearColor Color2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroNpcBodyMaterialParameter.__PropertyOffset_Color2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroNpcBodyMaterialParameter.__PropertyOffset_Color2) = value;
			}
		}

		// Token: 0x17006B66 RID: 27494
		// (get) Token: 0x0601AB3C RID: 109372 RVA: 0x00275840 File Offset: 0x00273A40
		// (set) Token: 0x0601AB3D RID: 109373 RVA: 0x00275883 File Offset: 0x00273A83
		public TArray<FKuroMaterialNamedFloat> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialNamedFloat> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TArray<FKuroMaterialNamedFloat>(base.NativePtr + (IntPtr)FKuroNpcBodyMaterialParameter.__PropertyOffset_FloatParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006B67 RID: 27495
		// (get) Token: 0x0601AB3E RID: 109374 RVA: 0x00275894 File Offset: 0x00273A94
		// (set) Token: 0x0601AB3F RID: 109375 RVA: 0x002758D7 File Offset: 0x00273AD7
		public TArray<FKuroMaterialNamedColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroMaterialNamedColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TArray<FKuroMaterialNamedColor>(base.NativePtr + (IntPtr)FKuroNpcBodyMaterialParameter.__PropertyOffset_ColorParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x0601AB40 RID: 109376 RVA: 0x002758E5 File Offset: 0x00273AE5
		public FKuroNpcBodyMaterialParameter()
		{
		}

		// Token: 0x0601AB41 RID: 109377 RVA: 0x002758F0 File Offset: 0x00273AF0
		public FKuroNpcBodyMaterialParameter(EKuroNpcBodyType BodyType, bool bOverrideDyeColor, bool bOverrideColor1, bool bOverrideColor2, FLinearColor DyeColor, FLinearColor Color1, FLinearColor Color2, TArray<FKuroMaterialNamedFloat> FloatParameters, TArray<FKuroMaterialNamedColor> ColorParameters)
		{
			this.BodyType = BodyType;
			this.bOverrideDyeColor = bOverrideDyeColor;
			this.bOverrideColor1 = bOverrideColor1;
			this.bOverrideColor2 = bOverrideColor2;
			this.DyeColor = DyeColor;
			this.Color1 = Color1;
			this.Color2 = Color2;
			this.FloatParameters = FloatParameters;
			this.ColorParameters = ColorParameters;
		}

		// Token: 0x0601AB42 RID: 109378 RVA: 0x00275948 File Offset: 0x00273B48
		protected override IntPtr GetUStructPtr()
		{
			return FKuroNpcBodyMaterialParameter.StaticStruct();
		}

		// Token: 0x0601AB43 RID: 109379 RVA: 0x00275954 File Offset: 0x00273B54
		[NullableContext(2)]
		public FKuroNpcBodyMaterialParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601AB44 RID: 109380 RVA: 0x0027595E File Offset: 0x00273B5E
		public FKuroNpcBodyMaterialParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601AB45 RID: 109381 RVA: 0x00275969 File Offset: 0x00273B69
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroNpcBodyMaterialParameter(Pointer, false, true);
		}

		// Token: 0x0601AB46 RID: 109382 RVA: 0x00275973 File Offset: 0x00273B73
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroNpcBodyMaterialParameter(Pointer, MemoryOwner);
		}

		// Token: 0x0400E717 RID: 59159
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroNpcBodyMaterialParameter";

		// Token: 0x0400E718 RID: 59160
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E719 RID: 59161
		internal static int __PropertyOffset_BodyType;

		// Token: 0x0400E71A RID: 59162
		internal static int __PropertyOffset_bOverrideDyeColor;

		// Token: 0x0400E71B RID: 59163
		internal static byte __PropertyMask_bOverrideDyeColor;

		// Token: 0x0400E71C RID: 59164
		internal static int __PropertyOffset_bOverrideColor1;

		// Token: 0x0400E71D RID: 59165
		internal static byte __PropertyMask_bOverrideColor1;

		// Token: 0x0400E71E RID: 59166
		internal static int __PropertyOffset_bOverrideColor2;

		// Token: 0x0400E71F RID: 59167
		internal static byte __PropertyMask_bOverrideColor2;

		// Token: 0x0400E720 RID: 59168
		internal static int __PropertyOffset_DyeColor;

		// Token: 0x0400E721 RID: 59169
		internal static int __PropertyOffset_Color1;

		// Token: 0x0400E722 RID: 59170
		internal static int __PropertyOffset_Color2;

		// Token: 0x0400E723 RID: 59171
		internal static int __PropertyOffset_FloatParameters;

		// Token: 0x0400E724 RID: 59172
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialNamedFloat> _FloatParameters;

		// Token: 0x0400E725 RID: 59173
		internal static int __PropertyOffset_ColorParameters;

		// Token: 0x0400E726 RID: 59174
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroMaterialNamedColor> _ColorParameters;
	}
}
