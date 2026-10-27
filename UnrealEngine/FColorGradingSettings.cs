using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200094A RID: 2378
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ColorGradingSettings")]
	[UnrealStructLayout(336, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 336)]
	public class FColorGradingSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060086A6 RID: 34470 RVA: 0x000BFE3C File Offset: 0x000BE03C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FColorGradingSettings._ScriptStructPtr != 0) ? FColorGradingSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ColorGradingSettings", ref FColorGradingSettings._ScriptStructPtr);
		}

		// Token: 0x17001FDA RID: 8154
		// (get) Token: 0x060086A7 RID: 34471 RVA: 0x000BFE60 File Offset: 0x000BE060
		// (set) Token: 0x060086A8 RID: 34472 RVA: 0x000BFEA3 File Offset: 0x000BE0A3
		public FColorGradePerRangeSettings Global
		{
			get
			{
				base.FastCheckIsValid();
				FColorGradePerRangeSettings result;
				if ((result = this._Global) == null)
				{
					result = (this._Global = new FColorGradePerRangeSettings(base.NativePtr + (IntPtr)FColorGradingSettings.__PropertyOffset_Global, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FColorGradePerRangeSettings.StaticStruct(), base.NativePtr + (IntPtr)FColorGradingSettings.__PropertyOffset_Global, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001FDB RID: 8155
		// (get) Token: 0x060086A9 RID: 34473 RVA: 0x000BFEC4 File Offset: 0x000BE0C4
		// (set) Token: 0x060086AA RID: 34474 RVA: 0x000BFF07 File Offset: 0x000BE107
		public FColorGradePerRangeSettings Shadows
		{
			get
			{
				base.FastCheckIsValid();
				FColorGradePerRangeSettings result;
				if ((result = this._Shadows) == null)
				{
					result = (this._Shadows = new FColorGradePerRangeSettings(base.NativePtr + (IntPtr)FColorGradingSettings.__PropertyOffset_Shadows, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FColorGradePerRangeSettings.StaticStruct(), base.NativePtr + (IntPtr)FColorGradingSettings.__PropertyOffset_Shadows, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001FDC RID: 8156
		// (get) Token: 0x060086AB RID: 34475 RVA: 0x000BFF28 File Offset: 0x000BE128
		// (set) Token: 0x060086AC RID: 34476 RVA: 0x000BFF6B File Offset: 0x000BE16B
		public FColorGradePerRangeSettings Midtones
		{
			get
			{
				base.FastCheckIsValid();
				FColorGradePerRangeSettings result;
				if ((result = this._Midtones) == null)
				{
					result = (this._Midtones = new FColorGradePerRangeSettings(base.NativePtr + (IntPtr)FColorGradingSettings.__PropertyOffset_Midtones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FColorGradePerRangeSettings.StaticStruct(), base.NativePtr + (IntPtr)FColorGradingSettings.__PropertyOffset_Midtones, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001FDD RID: 8157
		// (get) Token: 0x060086AD RID: 34477 RVA: 0x000BFF8C File Offset: 0x000BE18C
		// (set) Token: 0x060086AE RID: 34478 RVA: 0x000BFFCF File Offset: 0x000BE1CF
		public FColorGradePerRangeSettings Highlights
		{
			get
			{
				base.FastCheckIsValid();
				FColorGradePerRangeSettings result;
				if ((result = this._Highlights) == null)
				{
					result = (this._Highlights = new FColorGradePerRangeSettings(base.NativePtr + (IntPtr)FColorGradingSettings.__PropertyOffset_Highlights, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FColorGradePerRangeSettings.StaticStruct(), base.NativePtr + (IntPtr)FColorGradingSettings.__PropertyOffset_Highlights, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001FDE RID: 8158
		// (get) Token: 0x060086AF RID: 34479 RVA: 0x000BFFF0 File Offset: 0x000BE1F0
		// (set) Token: 0x060086B0 RID: 34480 RVA: 0x000C0000 File Offset: 0x000BE200
		public unsafe float ShadowsMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FColorGradingSettings.__PropertyOffset_ShadowsMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FColorGradingSettings.__PropertyOffset_ShadowsMax) = value;
			}
		}

		// Token: 0x17001FDF RID: 8159
		// (get) Token: 0x060086B1 RID: 34481 RVA: 0x000C0011 File Offset: 0x000BE211
		// (set) Token: 0x060086B2 RID: 34482 RVA: 0x000C0021 File Offset: 0x000BE221
		public unsafe float HighlightsMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FColorGradingSettings.__PropertyOffset_HighlightsMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FColorGradingSettings.__PropertyOffset_HighlightsMin) = value;
			}
		}

		// Token: 0x060086B3 RID: 34483 RVA: 0x000C0032 File Offset: 0x000BE232
		public FColorGradingSettings()
		{
		}

		// Token: 0x060086B4 RID: 34484 RVA: 0x000C003A File Offset: 0x000BE23A
		public FColorGradingSettings(FColorGradePerRangeSettings Global, FColorGradePerRangeSettings Shadows, FColorGradePerRangeSettings Midtones, FColorGradePerRangeSettings Highlights, float ShadowsMax, float HighlightsMin)
		{
			this.Global = Global;
			this.Shadows = Shadows;
			this.Midtones = Midtones;
			this.Highlights = Highlights;
			this.ShadowsMax = ShadowsMax;
			this.HighlightsMin = HighlightsMin;
		}

		// Token: 0x060086B5 RID: 34485 RVA: 0x000C006F File Offset: 0x000BE26F
		protected override IntPtr GetUStructPtr()
		{
			return FColorGradingSettings.StaticStruct();
		}

		// Token: 0x060086B6 RID: 34486 RVA: 0x000C007B File Offset: 0x000BE27B
		[NullableContext(2)]
		public FColorGradingSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060086B7 RID: 34487 RVA: 0x000C0085 File Offset: 0x000BE285
		public FColorGradingSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060086B8 RID: 34488 RVA: 0x000C0090 File Offset: 0x000BE290
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FColorGradingSettings(Pointer, false, true);
		}

		// Token: 0x060086B9 RID: 34489 RVA: 0x000C009A File Offset: 0x000BE29A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FColorGradingSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400400D RID: 16397
		public const string __ObjectPath = "/Script/Engine.ColorGradingSettings";

		// Token: 0x0400400E RID: 16398
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400400F RID: 16399
		internal static int __PropertyOffset_Global;

		// Token: 0x04004010 RID: 16400
		[Nullable(2)]
		private FColorGradePerRangeSettings _Global;

		// Token: 0x04004011 RID: 16401
		internal static int __PropertyOffset_Shadows;

		// Token: 0x04004012 RID: 16402
		[Nullable(2)]
		private FColorGradePerRangeSettings _Shadows;

		// Token: 0x04004013 RID: 16403
		internal static int __PropertyOffset_Midtones;

		// Token: 0x04004014 RID: 16404
		[Nullable(2)]
		private FColorGradePerRangeSettings _Midtones;

		// Token: 0x04004015 RID: 16405
		internal static int __PropertyOffset_Highlights;

		// Token: 0x04004016 RID: 16406
		[Nullable(2)]
		private FColorGradePerRangeSettings _Highlights;

		// Token: 0x04004017 RID: 16407
		internal static int __PropertyOffset_ShadowsMax;

		// Token: 0x04004018 RID: 16408
		internal static int __PropertyOffset_HighlightsMin;
	}
}
