using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B57 RID: 6999
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_Rim")]
	[UnrealStructLayout(688, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 688)]
	public class FKuroMaterialControllerParam_SI_Rim : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A7FB RID: 108539 RVA: 0x00271111 File Offset: 0x0026F311
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_SI_Rim._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_SI_Rim._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_Rim", ref FKuroMaterialControllerParam_SI_Rim._ScriptStructPtr);
		}

		// Token: 0x17006A85 RID: 27269
		// (get) Token: 0x0601A7FC RID: 108540 RVA: 0x00271138 File Offset: 0x0026F338
		// (set) Token: 0x0601A7FD RID: 108541 RVA: 0x0027117B File Offset: 0x0026F37B
		public FKuroMaterialCurveFloatGroup_SI RimPow
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup_SI result;
				if ((result = this._RimPow) == null)
				{
					result = (this._RimPow = new FKuroMaterialCurveFloatGroup_SI(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Rim.__PropertyOffset_RimPow, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup_SI.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Rim.__PropertyOffset_RimPow, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A86 RID: 27270
		// (get) Token: 0x0601A7FE RID: 108542 RVA: 0x0027119C File Offset: 0x0026F39C
		// (set) Token: 0x0601A7FF RID: 108543 RVA: 0x002711DF File Offset: 0x0026F3DF
		public FKuroMaterialCurveColorGroup_SI RimLightColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveColorGroup_SI result;
				if ((result = this._RimLightColor) == null)
				{
					result = (this._RimLightColor = new FKuroMaterialCurveColorGroup_SI(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Rim.__PropertyOffset_RimLightColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveColorGroup_SI.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Rim.__PropertyOffset_RimLightColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601A800 RID: 108544 RVA: 0x00271200 File Offset: 0x0026F400
		public FKuroMaterialControllerParam_SI_Rim()
		{
		}

		// Token: 0x0601A801 RID: 108545 RVA: 0x00271208 File Offset: 0x0026F408
		public FKuroMaterialControllerParam_SI_Rim(FKuroMaterialCurveFloatGroup_SI RimPow, FKuroMaterialCurveColorGroup_SI RimLightColor)
		{
			this.RimPow = RimPow;
			this.RimLightColor = RimLightColor;
		}

		// Token: 0x0601A802 RID: 108546 RVA: 0x0027121E File Offset: 0x0026F41E
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_SI_Rim.StaticStruct();
		}

		// Token: 0x0601A803 RID: 108547 RVA: 0x0027122A File Offset: 0x0026F42A
		[NullableContext(2)]
		public FKuroMaterialControllerParam_SI_Rim(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A804 RID: 108548 RVA: 0x00271234 File Offset: 0x0026F434
		public FKuroMaterialControllerParam_SI_Rim(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A805 RID: 108549 RVA: 0x0027123F File Offset: 0x0026F43F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_SI_Rim(Pointer, false, true);
		}

		// Token: 0x0601A806 RID: 108550 RVA: 0x00271249 File Offset: 0x0026F449
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_SI_Rim(Pointer, MemoryOwner);
		}

		// Token: 0x0400E5A7 RID: 58791
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_Rim";

		// Token: 0x0400E5A8 RID: 58792
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E5A9 RID: 58793
		internal static int __PropertyOffset_RimPow;

		// Token: 0x0400E5AA RID: 58794
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup_SI _RimPow;

		// Token: 0x0400E5AB RID: 58795
		internal static int __PropertyOffset_RimLightColor;

		// Token: 0x0400E5AC RID: 58796
		[Nullable(2)]
		private FKuroMaterialCurveColorGroup_SI _RimLightColor;
	}
}
