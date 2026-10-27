using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027B8 RID: 10168
	[UnrealObjectPath("/Script/SimplygonUObjects.ImpostorFromSingleViewSettings")]
	[UnrealStructLayout(60, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 60)]
	public class FImpostorFromSingleViewSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025E7A RID: 155258 RVA: 0x00397782 File Offset: 0x00395982
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FImpostorFromSingleViewSettings._ScriptStructPtr != 0) ? FImpostorFromSingleViewSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.ImpostorFromSingleViewSettings", ref FImpostorFromSingleViewSettings._ScriptStructPtr);
		}

		// Token: 0x1700921F RID: 37407
		// (get) Token: 0x06025E7B RID: 155259 RVA: 0x003977A6 File Offset: 0x003959A6
		// (set) Token: 0x06025E7C RID: 155260 RVA: 0x003977BF File Offset: 0x003959BF
		public unsafe bool UseTightFitting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_UseTightFitting) & FImpostorFromSingleViewSettings.__PropertyMask_UseTightFitting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_UseTightFitting) = ((*(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_UseTightFitting) & ~FImpostorFromSingleViewSettings.__PropertyMask_UseTightFitting) | (value ? FImpostorFromSingleViewSettings.__PropertyMask_UseTightFitting : 0));
			}
		}

		// Token: 0x17009220 RID: 37408
		// (get) Token: 0x06025E7D RID: 155261 RVA: 0x003977EF File Offset: 0x003959EF
		// (set) Token: 0x06025E7E RID: 155262 RVA: 0x003977FF File Offset: 0x003959FF
		public unsafe float TightFittingDepthOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_TightFittingDepthOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_TightFittingDepthOffset) = value;
			}
		}

		// Token: 0x17009221 RID: 37409
		// (get) Token: 0x06025E7F RID: 155263 RVA: 0x00397810 File Offset: 0x00395A10
		// (set) Token: 0x06025E80 RID: 155264 RVA: 0x00397829 File Offset: 0x00395A29
		public unsafe bool TwoSided
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_TwoSided) & FImpostorFromSingleViewSettings.__PropertyMask_TwoSided) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_TwoSided) = ((*(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_TwoSided) & ~FImpostorFromSingleViewSettings.__PropertyMask_TwoSided) | (value ? FImpostorFromSingleViewSettings.__PropertyMask_TwoSided : 0));
			}
		}

		// Token: 0x17009222 RID: 37410
		// (get) Token: 0x06025E81 RID: 155265 RVA: 0x00397859 File Offset: 0x00395A59
		// (set) Token: 0x06025E82 RID: 155266 RVA: 0x0039786D File Offset: 0x00395A6D
		public unsafe FVector ViewDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_ViewDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_ViewDirection) = value;
			}
		}

		// Token: 0x17009223 RID: 37411
		// (get) Token: 0x06025E83 RID: 155267 RVA: 0x00397882 File Offset: 0x00395A82
		// (set) Token: 0x06025E84 RID: 155268 RVA: 0x00397892 File Offset: 0x00395A92
		public unsafe float TexCoordPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_TexCoordPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_TexCoordPadding) = value;
			}
		}

		// Token: 0x17009224 RID: 37412
		// (get) Token: 0x06025E85 RID: 155269 RVA: 0x003978A3 File Offset: 0x00395AA3
		// (set) Token: 0x06025E86 RID: 155270 RVA: 0x003978BC File Offset: 0x00395ABC
		public unsafe bool UseOverrideCenterAndRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_UseOverrideCenterAndRadius) & FImpostorFromSingleViewSettings.__PropertyMask_UseOverrideCenterAndRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_UseOverrideCenterAndRadius) = ((*(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_UseOverrideCenterAndRadius) & ~FImpostorFromSingleViewSettings.__PropertyMask_UseOverrideCenterAndRadius) | (value ? FImpostorFromSingleViewSettings.__PropertyMask_UseOverrideCenterAndRadius : 0));
			}
		}

		// Token: 0x17009225 RID: 37413
		// (get) Token: 0x06025E87 RID: 155271 RVA: 0x003978EC File Offset: 0x00395AEC
		// (set) Token: 0x06025E88 RID: 155272 RVA: 0x003978FC File Offset: 0x00395AFC
		public unsafe float OverrideRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_OverrideRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_OverrideRadius) = value;
			}
		}

		// Token: 0x17009226 RID: 37414
		// (get) Token: 0x06025E89 RID: 155273 RVA: 0x0039790D File Offset: 0x00395B0D
		// (set) Token: 0x06025E8A RID: 155274 RVA: 0x00397921 File Offset: 0x00395B21
		public unsafe FVector OverrideCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_OverrideCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_OverrideCenter) = value;
			}
		}

		// Token: 0x17009227 RID: 37415
		// (get) Token: 0x06025E8B RID: 155275 RVA: 0x00397936 File Offset: 0x00395B36
		// (set) Token: 0x06025E8C RID: 155276 RVA: 0x00397946 File Offset: 0x00395B46
		public unsafe float OverrideCenterX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_OverrideCenterX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_OverrideCenterX) = value;
			}
		}

		// Token: 0x17009228 RID: 37416
		// (get) Token: 0x06025E8D RID: 155277 RVA: 0x00397957 File Offset: 0x00395B57
		// (set) Token: 0x06025E8E RID: 155278 RVA: 0x00397967 File Offset: 0x00395B67
		public unsafe float OverrideCenterY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_OverrideCenterY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_OverrideCenterY) = value;
			}
		}

		// Token: 0x17009229 RID: 37417
		// (get) Token: 0x06025E8F RID: 155279 RVA: 0x00397978 File Offset: 0x00395B78
		// (set) Token: 0x06025E90 RID: 155280 RVA: 0x00397988 File Offset: 0x00395B88
		public unsafe float OverrideCenterZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_OverrideCenterZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FImpostorFromSingleViewSettings.__PropertyOffset_OverrideCenterZ) = value;
			}
		}

		// Token: 0x06025E91 RID: 155281 RVA: 0x00397999 File Offset: 0x00395B99
		public FImpostorFromSingleViewSettings()
		{
		}

		// Token: 0x06025E92 RID: 155282 RVA: 0x003979A4 File Offset: 0x00395BA4
		public FImpostorFromSingleViewSettings(bool UseTightFitting, float TightFittingDepthOffset, bool TwoSided, FVector ViewDirection, float TexCoordPadding, bool UseOverrideCenterAndRadius, float OverrideRadius, FVector OverrideCenter, float OverrideCenterX, float OverrideCenterY, float OverrideCenterZ)
		{
			this.UseTightFitting = UseTightFitting;
			this.TightFittingDepthOffset = TightFittingDepthOffset;
			this.TwoSided = TwoSided;
			this.ViewDirection = ViewDirection;
			this.TexCoordPadding = TexCoordPadding;
			this.UseOverrideCenterAndRadius = UseOverrideCenterAndRadius;
			this.OverrideRadius = OverrideRadius;
			this.OverrideCenter = OverrideCenter;
			this.OverrideCenterX = OverrideCenterX;
			this.OverrideCenterY = OverrideCenterY;
			this.OverrideCenterZ = OverrideCenterZ;
		}

		// Token: 0x06025E93 RID: 155283 RVA: 0x00397A0C File Offset: 0x00395C0C
		protected override IntPtr GetUStructPtr()
		{
			return FImpostorFromSingleViewSettings.StaticStruct();
		}

		// Token: 0x06025E94 RID: 155284 RVA: 0x00397A18 File Offset: 0x00395C18
		[NullableContext(2)]
		public FImpostorFromSingleViewSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025E95 RID: 155285 RVA: 0x00397A22 File Offset: 0x00395C22
		public FImpostorFromSingleViewSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06025E96 RID: 155286 RVA: 0x00397A2D File Offset: 0x00395C2D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FImpostorFromSingleViewSettings(Pointer, false, true);
		}

		// Token: 0x06025E97 RID: 155287 RVA: 0x00397A37 File Offset: 0x00395C37
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FImpostorFromSingleViewSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014B01 RID: 84737
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SimplygonUObjects.ImpostorFromSingleViewSettings";

		// Token: 0x04014B02 RID: 84738
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014B03 RID: 84739
		internal static int __PropertyOffset_UseTightFitting;

		// Token: 0x04014B04 RID: 84740
		internal static byte __PropertyMask_UseTightFitting;

		// Token: 0x04014B05 RID: 84741
		internal static int __PropertyOffset_TightFittingDepthOffset;

		// Token: 0x04014B06 RID: 84742
		internal static int __PropertyOffset_TwoSided;

		// Token: 0x04014B07 RID: 84743
		internal static byte __PropertyMask_TwoSided;

		// Token: 0x04014B08 RID: 84744
		internal static int __PropertyOffset_ViewDirection;

		// Token: 0x04014B09 RID: 84745
		internal static int __PropertyOffset_TexCoordPadding;

		// Token: 0x04014B0A RID: 84746
		internal static int __PropertyOffset_UseOverrideCenterAndRadius;

		// Token: 0x04014B0B RID: 84747
		internal static byte __PropertyMask_UseOverrideCenterAndRadius;

		// Token: 0x04014B0C RID: 84748
		internal static int __PropertyOffset_OverrideRadius;

		// Token: 0x04014B0D RID: 84749
		internal static int __PropertyOffset_OverrideCenter;

		// Token: 0x04014B0E RID: 84750
		internal static int __PropertyOffset_OverrideCenterX;

		// Token: 0x04014B0F RID: 84751
		internal static int __PropertyOffset_OverrideCenterY;

		// Token: 0x04014B10 RID: 84752
		internal static int __PropertyOffset_OverrideCenterZ;
	}
}
