using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DE9 RID: 3561
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionLandscapeCaptureDepthFade")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class UMaterialExpressionLandscapeCaptureDepthFade : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C0B3 RID: 49331 RVA: 0x0011512A File Offset: 0x0011332A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLandscapeCaptureDepthFade._ClassPtr;
		}

		// Token: 0x0600C0B4 RID: 49332 RVA: 0x00115138 File Offset: 0x00113338
		public UMaterialExpressionLandscapeCaptureDepthFade() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeCaptureDepthFade.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C0B5 RID: 49333 RVA: 0x00115160 File Offset: 0x00113360
		public UMaterialExpressionLandscapeCaptureDepthFade(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLandscapeCaptureDepthFade.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CB5 RID: 11445
		// (get) Token: 0x0600C0B6 RID: 49334 RVA: 0x00115193 File Offset: 0x00113393
		// (set) Token: 0x0600C0B7 RID: 49335 RVA: 0x001151A7 File Offset: 0x001133A7
		[Nullable(0)]
		public unsafe TEnumAsByte<EMaterialSceneAttributeInputMode> InputMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureDepthFade.__PropertyOffset_InputMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureDepthFade.__PropertyOffset_InputMode) = value;
			}
		}

		// Token: 0x17002CB6 RID: 11446
		// (get) Token: 0x0600C0B8 RID: 49336 RVA: 0x001151BC File Offset: 0x001133BC
		// (set) Token: 0x0600C0B9 RID: 49337 RVA: 0x001151F5 File Offset: 0x001133F5
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureDepthFade.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureDepthFade.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CB7 RID: 11447
		// (get) Token: 0x0600C0BA RID: 49338 RVA: 0x00115218 File Offset: 0x00113418
		// (set) Token: 0x0600C0BB RID: 49339 RVA: 0x00115251 File Offset: 0x00113451
		public FExpressionInput HeightBias
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._HeightBias) == null)
				{
					result = (this._HeightBias = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureDepthFade.__PropertyOffset_HeightBias, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureDepthFade.__PropertyOffset_HeightBias, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CB8 RID: 11448
		// (get) Token: 0x0600C0BC RID: 49340 RVA: 0x00115274 File Offset: 0x00113474
		// (set) Token: 0x0600C0BD RID: 49341 RVA: 0x001152AD File Offset: 0x001134AD
		public FExpressionInput FadeHeight
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._FadeHeight) == null)
				{
					result = (this._FadeHeight = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureDepthFade.__PropertyOffset_FadeHeight, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureDepthFade.__PropertyOffset_FadeHeight, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CB9 RID: 11449
		// (get) Token: 0x0600C0BE RID: 49342 RVA: 0x001152CE File Offset: 0x001134CE
		// (set) Token: 0x0600C0BF RID: 49343 RVA: 0x001152E2 File Offset: 0x001134E2
		public unsafe FVector2D ConstInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureDepthFade.__PropertyOffset_ConstInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionLandscapeCaptureDepthFade.__PropertyOffset_ConstInput) = value;
			}
		}

		// Token: 0x0600C0C0 RID: 49344 RVA: 0x001152F7 File Offset: 0x001134F7
		static UMaterialExpressionLandscapeCaptureDepthFade()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionLandscapeCaptureDepthFade");
		}

		// Token: 0x0600C0C1 RID: 49345 RVA: 0x00115305 File Offset: 0x00113505
		protected UMaterialExpressionLandscapeCaptureDepthFade(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006647 RID: 26183
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionLandscapeCaptureDepthFade";

		// Token: 0x04006648 RID: 26184
		private static IntPtr _ClassPtr;

		// Token: 0x04006649 RID: 26185
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400664A RID: 26186
		internal static int __PropertyOffset_InputMode;

		// Token: 0x0400664B RID: 26187
		internal static int __PropertyOffset_Input;

		// Token: 0x0400664C RID: 26188
		[Nullable(2)]
		private FExpressionInput _Input;

		// Token: 0x0400664D RID: 26189
		internal static int __PropertyOffset_HeightBias;

		// Token: 0x0400664E RID: 26190
		[Nullable(2)]
		private FExpressionInput _HeightBias;

		// Token: 0x0400664F RID: 26191
		internal static int __PropertyOffset_FadeHeight;

		// Token: 0x04006650 RID: 26192
		[Nullable(2)]
		private FExpressionInput _FadeHeight;

		// Token: 0x04006651 RID: 26193
		internal static int __PropertyOffset_ConstInput;
	}
}
