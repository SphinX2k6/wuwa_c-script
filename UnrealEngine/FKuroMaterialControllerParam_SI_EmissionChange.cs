using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B55 RID: 6997
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_EmissionChange")]
	[UnrealStructLayout(832, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 832)]
	public class FKuroMaterialControllerParam_SI_EmissionChange : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A7DF RID: 108511 RVA: 0x00270E7D File Offset: 0x0026F07D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_SI_EmissionChange._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_SI_EmissionChange._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_EmissionChange", ref FKuroMaterialControllerParam_SI_EmissionChange._ScriptStructPtr);
		}

		// Token: 0x17006A7F RID: 27263
		// (get) Token: 0x0601A7E0 RID: 108512 RVA: 0x00270EA4 File Offset: 0x0026F0A4
		// (set) Token: 0x0601A7E1 RID: 108513 RVA: 0x00270EE7 File Offset: 0x0026F0E7
		public FKuroMaterialCurveFloatGroup_SI EmissionLightColorChangeProgress
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup_SI result;
				if ((result = this._EmissionLightColorChangeProgress) == null)
				{
					result = (this._EmissionLightColorChangeProgress = new FKuroMaterialCurveFloatGroup_SI(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_EmissionChange.__PropertyOffset_EmissionLightColorChangeProgress, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup_SI.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_EmissionChange.__PropertyOffset_EmissionLightColorChangeProgress, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A80 RID: 27264
		// (get) Token: 0x0601A7E2 RID: 108514 RVA: 0x00270F08 File Offset: 0x0026F108
		// (set) Token: 0x0601A7E3 RID: 108515 RVA: 0x00270F4B File Offset: 0x0026F14B
		public FKuroMaterialCurveFloatGroup_SI EmissionLightColorChangeStrength
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup_SI result;
				if ((result = this._EmissionLightColorChangeStrength) == null)
				{
					result = (this._EmissionLightColorChangeStrength = new FKuroMaterialCurveFloatGroup_SI(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_EmissionChange.__PropertyOffset_EmissionLightColorChangeStrength, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup_SI.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_EmissionChange.__PropertyOffset_EmissionLightColorChangeStrength, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A81 RID: 27265
		// (get) Token: 0x0601A7E4 RID: 108516 RVA: 0x00270F6C File Offset: 0x0026F16C
		// (set) Token: 0x0601A7E5 RID: 108517 RVA: 0x00270FAF File Offset: 0x0026F1AF
		public FKuroMaterialCurveColorGroup_SI EmissionLightColorChangeColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveColorGroup_SI result;
				if ((result = this._EmissionLightColorChangeColor) == null)
				{
					result = (this._EmissionLightColorChangeColor = new FKuroMaterialCurveColorGroup_SI(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_EmissionChange.__PropertyOffset_EmissionLightColorChangeColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveColorGroup_SI.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_EmissionChange.__PropertyOffset_EmissionLightColorChangeColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601A7E6 RID: 108518 RVA: 0x00270FD0 File Offset: 0x0026F1D0
		public FKuroMaterialControllerParam_SI_EmissionChange()
		{
		}

		// Token: 0x0601A7E7 RID: 108519 RVA: 0x00270FD8 File Offset: 0x0026F1D8
		public FKuroMaterialControllerParam_SI_EmissionChange(FKuroMaterialCurveFloatGroup_SI EmissionLightColorChangeProgress, FKuroMaterialCurveFloatGroup_SI EmissionLightColorChangeStrength, FKuroMaterialCurveColorGroup_SI EmissionLightColorChangeColor)
		{
			this.EmissionLightColorChangeProgress = EmissionLightColorChangeProgress;
			this.EmissionLightColorChangeStrength = EmissionLightColorChangeStrength;
			this.EmissionLightColorChangeColor = EmissionLightColorChangeColor;
		}

		// Token: 0x0601A7E8 RID: 108520 RVA: 0x00270FF5 File Offset: 0x0026F1F5
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_SI_EmissionChange.StaticStruct();
		}

		// Token: 0x0601A7E9 RID: 108521 RVA: 0x00271001 File Offset: 0x0026F201
		[NullableContext(2)]
		public FKuroMaterialControllerParam_SI_EmissionChange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A7EA RID: 108522 RVA: 0x0027100B File Offset: 0x0026F20B
		public FKuroMaterialControllerParam_SI_EmissionChange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A7EB RID: 108523 RVA: 0x00271016 File Offset: 0x0026F216
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_SI_EmissionChange(Pointer, false, true);
		}

		// Token: 0x0601A7EC RID: 108524 RVA: 0x00271020 File Offset: 0x0026F220
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_SI_EmissionChange(Pointer, MemoryOwner);
		}

		// Token: 0x0400E59A RID: 58778
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_EmissionChange";

		// Token: 0x0400E59B RID: 58779
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E59C RID: 58780
		internal static int __PropertyOffset_EmissionLightColorChangeProgress;

		// Token: 0x0400E59D RID: 58781
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup_SI _EmissionLightColorChangeProgress;

		// Token: 0x0400E59E RID: 58782
		internal static int __PropertyOffset_EmissionLightColorChangeStrength;

		// Token: 0x0400E59F RID: 58783
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup_SI _EmissionLightColorChangeStrength;

		// Token: 0x0400E5A0 RID: 58784
		internal static int __PropertyOffset_EmissionLightColorChangeColor;

		// Token: 0x0400E5A1 RID: 58785
		[Nullable(2)]
		private FKuroMaterialCurveColorGroup_SI _EmissionLightColorChangeColor;
	}
}
