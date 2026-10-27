using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001AEC RID: 6892
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroEffectColorGradingSettings")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroEffectColorGradingSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019B59 RID: 105305 RVA: 0x0025FA1A File Offset: 0x0025DC1A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroEffectColorGradingSettings._ScriptStructPtr != 0) ? FKuroEffectColorGradingSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroEffectColorGradingSettings", ref FKuroEffectColorGradingSettings._ScriptStructPtr);
		}

		// Token: 0x170066AE RID: 26286
		// (get) Token: 0x06019B5A RID: 105306 RVA: 0x0025FA3E File Offset: 0x0025DC3E
		// (set) Token: 0x06019B5B RID: 105307 RVA: 0x0025FA57 File Offset: 0x0025DC57
		public unsafe bool bOverride_Desaturate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectColorGradingSettings.__PropertyOffset_bOverride_Desaturate) & FKuroEffectColorGradingSettings.__PropertyMask_bOverride_Desaturate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectColorGradingSettings.__PropertyOffset_bOverride_Desaturate) = ((*(base.NativePtr + (IntPtr)FKuroEffectColorGradingSettings.__PropertyOffset_bOverride_Desaturate) & ~FKuroEffectColorGradingSettings.__PropertyMask_bOverride_Desaturate) | (value ? FKuroEffectColorGradingSettings.__PropertyMask_bOverride_Desaturate : 0));
			}
		}

		// Token: 0x170066AF RID: 26287
		// (get) Token: 0x06019B5C RID: 105308 RVA: 0x0025FA87 File Offset: 0x0025DC87
		// (set) Token: 0x06019B5D RID: 105309 RVA: 0x0025FAA0 File Offset: 0x0025DCA0
		public unsafe bool bOverride_Tint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroEffectColorGradingSettings.__PropertyOffset_bOverride_Tint) & FKuroEffectColorGradingSettings.__PropertyMask_bOverride_Tint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroEffectColorGradingSettings.__PropertyOffset_bOverride_Tint) = ((*(base.NativePtr + (IntPtr)FKuroEffectColorGradingSettings.__PropertyOffset_bOverride_Tint) & ~FKuroEffectColorGradingSettings.__PropertyMask_bOverride_Tint) | (value ? FKuroEffectColorGradingSettings.__PropertyMask_bOverride_Tint : 0));
			}
		}

		// Token: 0x170066B0 RID: 26288
		// (get) Token: 0x06019B5E RID: 105310 RVA: 0x0025FAD0 File Offset: 0x0025DCD0
		// (set) Token: 0x06019B5F RID: 105311 RVA: 0x0025FAE0 File Offset: 0x0025DCE0
		public unsafe float Desaturate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectColorGradingSettings.__PropertyOffset_Desaturate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectColorGradingSettings.__PropertyOffset_Desaturate) = value;
			}
		}

		// Token: 0x170066B1 RID: 26289
		// (get) Token: 0x06019B60 RID: 105312 RVA: 0x0025FAF1 File Offset: 0x0025DCF1
		// (set) Token: 0x06019B61 RID: 105313 RVA: 0x0025FB05 File Offset: 0x0025DD05
		public unsafe FLinearColor Tint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroEffectColorGradingSettings.__PropertyOffset_Tint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroEffectColorGradingSettings.__PropertyOffset_Tint) = value;
			}
		}

		// Token: 0x06019B62 RID: 105314 RVA: 0x0025FB1A File Offset: 0x0025DD1A
		public FKuroEffectColorGradingSettings()
		{
		}

		// Token: 0x06019B63 RID: 105315 RVA: 0x0025FB22 File Offset: 0x0025DD22
		public FKuroEffectColorGradingSettings(bool bOverride_Desaturate, bool bOverride_Tint, float Desaturate, FLinearColor Tint)
		{
			this.bOverride_Desaturate = bOverride_Desaturate;
			this.bOverride_Tint = bOverride_Tint;
			this.Desaturate = Desaturate;
			this.Tint = Tint;
		}

		// Token: 0x06019B64 RID: 105316 RVA: 0x0025FB47 File Offset: 0x0025DD47
		protected override IntPtr GetUStructPtr()
		{
			return FKuroEffectColorGradingSettings.StaticStruct();
		}

		// Token: 0x06019B65 RID: 105317 RVA: 0x0025FB53 File Offset: 0x0025DD53
		[NullableContext(2)]
		public FKuroEffectColorGradingSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019B66 RID: 105318 RVA: 0x0025FB5D File Offset: 0x0025DD5D
		public FKuroEffectColorGradingSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019B67 RID: 105319 RVA: 0x0025FB68 File Offset: 0x0025DD68
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroEffectColorGradingSettings(Pointer, false, true);
		}

		// Token: 0x06019B68 RID: 105320 RVA: 0x0025FB72 File Offset: 0x0025DD72
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroEffectColorGradingSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400DFAB RID: 57259
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroEffectColorGradingSettings";

		// Token: 0x0400DFAC RID: 57260
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DFAD RID: 57261
		internal static int __PropertyOffset_bOverride_Desaturate;

		// Token: 0x0400DFAE RID: 57262
		internal static byte __PropertyMask_bOverride_Desaturate;

		// Token: 0x0400DFAF RID: 57263
		internal static int __PropertyOffset_bOverride_Tint;

		// Token: 0x0400DFB0 RID: 57264
		internal static byte __PropertyMask_bOverride_Tint;

		// Token: 0x0400DFB1 RID: 57265
		internal static int __PropertyOffset_Desaturate;

		// Token: 0x0400DFB2 RID: 57266
		internal static int __PropertyOffset_Tint;
	}
}
