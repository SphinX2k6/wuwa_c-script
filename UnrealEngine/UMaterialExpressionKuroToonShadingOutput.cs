using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DE4 RID: 3556
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionKuroToonShadingOutput")]
	[UnrealStructLayout(920, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 920)]
	public class UMaterialExpressionKuroToonShadingOutput : UMaterialExpressionCustomOutput, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C06C RID: 49260 RVA: 0x00114771 File Offset: 0x00112971
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionKuroToonShadingOutput._ClassPtr;
		}

		// Token: 0x0600C06D RID: 49261 RVA: 0x00114780 File Offset: 0x00112980
		public UMaterialExpressionKuroToonShadingOutput() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroToonShadingOutput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C06E RID: 49262 RVA: 0x001147A8 File Offset: 0x001129A8
		public UMaterialExpressionKuroToonShadingOutput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroToonShadingOutput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C9E RID: 11422
		// (get) Token: 0x0600C06F RID: 49263 RVA: 0x001147DC File Offset: 0x001129DC
		// (set) Token: 0x0600C070 RID: 49264 RVA: 0x00114815 File Offset: 0x00112A15
		public FExpressionInput ToonShadowColor
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ToonShadowColor) == null)
				{
					result = (this._ToonShadowColor = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonShadowColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonShadowColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C9F RID: 11423
		// (get) Token: 0x0600C071 RID: 49265 RVA: 0x00114838 File Offset: 0x00112A38
		// (set) Token: 0x0600C072 RID: 49266 RVA: 0x00114871 File Offset: 0x00112A71
		public FExpressionInput ToonShadowBlendFactor
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ToonShadowBlendFactor) == null)
				{
					result = (this._ToonShadowBlendFactor = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonShadowBlendFactor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonShadowBlendFactor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CA0 RID: 11424
		// (get) Token: 0x0600C073 RID: 49267 RVA: 0x00114894 File Offset: 0x00112A94
		// (set) Token: 0x0600C074 RID: 49268 RVA: 0x001148CD File Offset: 0x00112ACD
		public FExpressionInput ToonSkinMask
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ToonSkinMask) == null)
				{
					result = (this._ToonSkinMask = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonSkinMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonSkinMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CA1 RID: 11425
		// (get) Token: 0x0600C075 RID: 49269 RVA: 0x001148F0 File Offset: 0x00112AF0
		// (set) Token: 0x0600C076 RID: 49270 RVA: 0x00114929 File Offset: 0x00112B29
		public FExpressionInput ToonRimWidth
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ToonRimWidth) == null)
				{
					result = (this._ToonRimWidth = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonRimWidth, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonRimWidth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CA2 RID: 11426
		// (get) Token: 0x0600C077 RID: 49271 RVA: 0x0011494C File Offset: 0x00112B4C
		// (set) Token: 0x0600C078 RID: 49272 RVA: 0x00114985 File Offset: 0x00112B85
		public FExpressionInput ToonVariationEnableBattle
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ToonVariationEnableBattle) == null)
				{
					result = (this._ToonVariationEnableBattle = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonVariationEnableBattle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonVariationEnableBattle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CA3 RID: 11427
		// (get) Token: 0x0600C079 RID: 49273 RVA: 0x001149A8 File Offset: 0x00112BA8
		// (set) Token: 0x0600C07A RID: 49274 RVA: 0x001149E1 File Offset: 0x00112BE1
		public FExpressionInput ToonVariationEnableBattleMask
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ToonVariationEnableBattleMask) == null)
				{
					result = (this._ToonVariationEnableBattleMask = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonVariationEnableBattleMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonVariationEnableBattleMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CA4 RID: 11428
		// (get) Token: 0x0600C07B RID: 49275 RVA: 0x00114A04 File Offset: 0x00112C04
		// (set) Token: 0x0600C07C RID: 49276 RVA: 0x00114A3D File Offset: 0x00112C3D
		public FExpressionInput ToonVariationEnableDither
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ToonVariationEnableDither) == null)
				{
					result = (this._ToonVariationEnableDither = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonVariationEnableDither, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonVariationEnableDither, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CA5 RID: 11429
		// (get) Token: 0x0600C07D RID: 49277 RVA: 0x00114A60 File Offset: 0x00112C60
		// (set) Token: 0x0600C07E RID: 49278 RVA: 0x00114A99 File Offset: 0x00112C99
		public FExpressionInput ToonShadowBlendCSMMask
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ToonShadowBlendCSMMask) == null)
				{
					result = (this._ToonShadowBlendCSMMask = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonShadowBlendCSMMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonShadowBlendCSMMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CA6 RID: 11430
		// (get) Token: 0x0600C07F RID: 49279 RVA: 0x00114ABC File Offset: 0x00112CBC
		// (set) Token: 0x0600C080 RID: 49280 RVA: 0x00114AF5 File Offset: 0x00112CF5
		public FExpressionInput ToonRimColorBlendMask
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ToonRimColorBlendMask) == null)
				{
					result = (this._ToonRimColorBlendMask = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonRimColorBlendMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonRimColorBlendMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CA7 RID: 11431
		// (get) Token: 0x0600C081 RID: 49281 RVA: 0x00114B18 File Offset: 0x00112D18
		// (set) Token: 0x0600C082 RID: 49282 RVA: 0x00114B51 File Offset: 0x00112D51
		public FExpressionInput ToonLumenSkinMask
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ToonLumenSkinMask) == null)
				{
					result = (this._ToonLumenSkinMask = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonLumenSkinMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonLumenSkinMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CA8 RID: 11432
		// (get) Token: 0x0600C083 RID: 49283 RVA: 0x00114B74 File Offset: 0x00112D74
		// (set) Token: 0x0600C084 RID: 49284 RVA: 0x00114BAD File Offset: 0x00112DAD
		public FExpressionInput ToonLumenIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ToonLumenIntensity) == null)
				{
					result = (this._ToonLumenIntensity = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonLumenIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonLumenIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CA9 RID: 11433
		// (get) Token: 0x0600C085 RID: 49285 RVA: 0x00114BD0 File Offset: 0x00112DD0
		// (set) Token: 0x0600C086 RID: 49286 RVA: 0x00114C09 File Offset: 0x00112E09
		public FExpressionInput ToonClothTranslucencyMask
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ToonClothTranslucencyMask) == null)
				{
					result = (this._ToonClothTranslucencyMask = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonClothTranslucencyMask, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonClothTranslucencyMask, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CAA RID: 11434
		// (get) Token: 0x0600C087 RID: 49287 RVA: 0x00114C2C File Offset: 0x00112E2C
		// (set) Token: 0x0600C088 RID: 49288 RVA: 0x00114C65 File Offset: 0x00112E65
		public FExpressionInput ToonSSAOIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ToonSSAOIntensity) == null)
				{
					result = (this._ToonSSAOIntensity = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonSSAOIntensity, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroToonShadingOutput.__PropertyOffset_ToonSSAOIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C089 RID: 49289 RVA: 0x00114C86 File Offset: 0x00112E86
		static UMaterialExpressionKuroToonShadingOutput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionKuroToonShadingOutput");
		}

		// Token: 0x0600C08A RID: 49290 RVA: 0x00114C94 File Offset: 0x00112E94
		protected UMaterialExpressionKuroToonShadingOutput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400660F RID: 26127
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionKuroToonShadingOutput";

		// Token: 0x04006610 RID: 26128
		private static IntPtr _ClassPtr;

		// Token: 0x04006611 RID: 26129
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006612 RID: 26130
		internal static int __PropertyOffset_ToonShadowColor;

		// Token: 0x04006613 RID: 26131
		[Nullable(2)]
		private FExpressionInput _ToonShadowColor;

		// Token: 0x04006614 RID: 26132
		internal static int __PropertyOffset_ToonShadowBlendFactor;

		// Token: 0x04006615 RID: 26133
		[Nullable(2)]
		private FExpressionInput _ToonShadowBlendFactor;

		// Token: 0x04006616 RID: 26134
		internal static int __PropertyOffset_ToonSkinMask;

		// Token: 0x04006617 RID: 26135
		[Nullable(2)]
		private FExpressionInput _ToonSkinMask;

		// Token: 0x04006618 RID: 26136
		internal static int __PropertyOffset_ToonRimWidth;

		// Token: 0x04006619 RID: 26137
		[Nullable(2)]
		private FExpressionInput _ToonRimWidth;

		// Token: 0x0400661A RID: 26138
		internal static int __PropertyOffset_ToonVariationEnableBattle;

		// Token: 0x0400661B RID: 26139
		[Nullable(2)]
		private FExpressionInput _ToonVariationEnableBattle;

		// Token: 0x0400661C RID: 26140
		internal static int __PropertyOffset_ToonVariationEnableBattleMask;

		// Token: 0x0400661D RID: 26141
		[Nullable(2)]
		private FExpressionInput _ToonVariationEnableBattleMask;

		// Token: 0x0400661E RID: 26142
		internal static int __PropertyOffset_ToonVariationEnableDither;

		// Token: 0x0400661F RID: 26143
		[Nullable(2)]
		private FExpressionInput _ToonVariationEnableDither;

		// Token: 0x04006620 RID: 26144
		internal static int __PropertyOffset_ToonShadowBlendCSMMask;

		// Token: 0x04006621 RID: 26145
		[Nullable(2)]
		private FExpressionInput _ToonShadowBlendCSMMask;

		// Token: 0x04006622 RID: 26146
		internal static int __PropertyOffset_ToonRimColorBlendMask;

		// Token: 0x04006623 RID: 26147
		[Nullable(2)]
		private FExpressionInput _ToonRimColorBlendMask;

		// Token: 0x04006624 RID: 26148
		internal static int __PropertyOffset_ToonLumenSkinMask;

		// Token: 0x04006625 RID: 26149
		[Nullable(2)]
		private FExpressionInput _ToonLumenSkinMask;

		// Token: 0x04006626 RID: 26150
		internal static int __PropertyOffset_ToonLumenIntensity;

		// Token: 0x04006627 RID: 26151
		[Nullable(2)]
		private FExpressionInput _ToonLumenIntensity;

		// Token: 0x04006628 RID: 26152
		internal static int __PropertyOffset_ToonClothTranslucencyMask;

		// Token: 0x04006629 RID: 26153
		[Nullable(2)]
		private FExpressionInput _ToonClothTranslucencyMask;

		// Token: 0x0400662A RID: 26154
		internal static int __PropertyOffset_ToonSSAOIntensity;

		// Token: 0x0400662B RID: 26155
		[Nullable(2)]
		private FExpressionInput _ToonSSAOIntensity;
	}
}
