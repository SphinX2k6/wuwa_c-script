using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B3D RID: 6973
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_Color")]
	[UnrealStructLayout(4136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4136)]
	public class FKuroMaterialControllerParam_Color : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A667 RID: 108135 RVA: 0x0026EBBA File Offset: 0x0026CDBA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_Color._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_Color._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_Color", ref FKuroMaterialControllerParam_Color._ScriptStructPtr);
		}

		// Token: 0x17006A23 RID: 27171
		// (get) Token: 0x0601A668 RID: 108136 RVA: 0x0026EBE0 File Offset: 0x0026CDE0
		// (set) Token: 0x0601A669 RID: 108137 RVA: 0x0026EC23 File Offset: 0x0026CE23
		public FKuroMaterialCurveColorGroup BaseColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveColorGroup result;
				if ((result = this._BaseColor) == null)
				{
					result = (this._BaseColor = new FKuroMaterialCurveColorGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Color.__PropertyOffset_BaseColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveColorGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Color.__PropertyOffset_BaseColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A24 RID: 27172
		// (get) Token: 0x0601A66A RID: 108138 RVA: 0x0026EC44 File Offset: 0x0026CE44
		// (set) Token: 0x0601A66B RID: 108139 RVA: 0x0026EC87 File Offset: 0x0026CE87
		public FKuroMaterialCurveFloatGroup BaseIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup result;
				if ((result = this._BaseIntensity) == null)
				{
					result = (this._BaseIntensity = new FKuroMaterialCurveFloatGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Color.__PropertyOffset_BaseIntensity, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Color.__PropertyOffset_BaseIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A25 RID: 27173
		// (get) Token: 0x0601A66C RID: 108140 RVA: 0x0026ECA8 File Offset: 0x0026CEA8
		// (set) Token: 0x0601A66D RID: 108141 RVA: 0x0026ECEB File Offset: 0x0026CEEB
		public FKuroMaterialCurveColorGroup EmissionColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveColorGroup result;
				if ((result = this._EmissionColor) == null)
				{
					result = (this._EmissionColor = new FKuroMaterialCurveColorGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Color.__PropertyOffset_EmissionColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveColorGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Color.__PropertyOffset_EmissionColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A26 RID: 27174
		// (get) Token: 0x0601A66E RID: 108142 RVA: 0x0026ED0C File Offset: 0x0026CF0C
		// (set) Token: 0x0601A66F RID: 108143 RVA: 0x0026ED4F File Offset: 0x0026CF4F
		public FKuroMaterialCurveFloatGroup EmissionIntensity
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup result;
				if ((result = this._EmissionIntensity) == null)
				{
					result = (this._EmissionIntensity = new FKuroMaterialCurveFloatGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Color.__PropertyOffset_EmissionIntensity, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Color.__PropertyOffset_EmissionIntensity, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006A27 RID: 27175
		// (get) Token: 0x0601A670 RID: 108144 RVA: 0x0026ED70 File Offset: 0x0026CF70
		// (set) Token: 0x0601A671 RID: 108145 RVA: 0x0026ED80 File Offset: 0x0026CF80
		public unsafe bool bBaseUseTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Color.__PropertyOffset_bBaseUseTex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Color.__PropertyOffset_bBaseUseTex) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006A28 RID: 27176
		// (get) Token: 0x0601A672 RID: 108146 RVA: 0x0026ED91 File Offset: 0x0026CF91
		// (set) Token: 0x0601A673 RID: 108147 RVA: 0x0026EDA1 File Offset: 0x0026CFA1
		public unsafe bool bEmissionUseTex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Color.__PropertyOffset_bEmissionUseTex) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_Color.__PropertyOffset_bEmissionUseTex) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601A674 RID: 108148 RVA: 0x0026EDB2 File Offset: 0x0026CFB2
		public FKuroMaterialControllerParam_Color()
		{
		}

		// Token: 0x0601A675 RID: 108149 RVA: 0x0026EDBA File Offset: 0x0026CFBA
		public FKuroMaterialControllerParam_Color(FKuroMaterialCurveColorGroup BaseColor, FKuroMaterialCurveFloatGroup BaseIntensity, FKuroMaterialCurveColorGroup EmissionColor, FKuroMaterialCurveFloatGroup EmissionIntensity, bool bBaseUseTex, bool bEmissionUseTex)
		{
			this.BaseColor = BaseColor;
			this.BaseIntensity = BaseIntensity;
			this.EmissionColor = EmissionColor;
			this.EmissionIntensity = EmissionIntensity;
			this.bBaseUseTex = bBaseUseTex;
			this.bEmissionUseTex = bEmissionUseTex;
		}

		// Token: 0x0601A676 RID: 108150 RVA: 0x0026EDEF File Offset: 0x0026CFEF
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_Color.StaticStruct();
		}

		// Token: 0x0601A677 RID: 108151 RVA: 0x0026EDFB File Offset: 0x0026CFFB
		[NullableContext(2)]
		public FKuroMaterialControllerParam_Color(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A678 RID: 108152 RVA: 0x0026EE05 File Offset: 0x0026D005
		public FKuroMaterialControllerParam_Color(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A679 RID: 108153 RVA: 0x0026EE10 File Offset: 0x0026D010
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_Color(Pointer, false, true);
		}

		// Token: 0x0601A67A RID: 108154 RVA: 0x0026EE1A File Offset: 0x0026D01A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_Color(Pointer, MemoryOwner);
		}

		// Token: 0x0400E4E4 RID: 58596
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_Color";

		// Token: 0x0400E4E5 RID: 58597
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E4E6 RID: 58598
		internal static int __PropertyOffset_BaseColor;

		// Token: 0x0400E4E7 RID: 58599
		[Nullable(2)]
		private FKuroMaterialCurveColorGroup _BaseColor;

		// Token: 0x0400E4E8 RID: 58600
		internal static int __PropertyOffset_BaseIntensity;

		// Token: 0x0400E4E9 RID: 58601
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup _BaseIntensity;

		// Token: 0x0400E4EA RID: 58602
		internal static int __PropertyOffset_EmissionColor;

		// Token: 0x0400E4EB RID: 58603
		[Nullable(2)]
		private FKuroMaterialCurveColorGroup _EmissionColor;

		// Token: 0x0400E4EC RID: 58604
		internal static int __PropertyOffset_EmissionIntensity;

		// Token: 0x0400E4ED RID: 58605
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup _EmissionIntensity;

		// Token: 0x0400E4EE RID: 58606
		internal static int __PropertyOffset_bBaseUseTex;

		// Token: 0x0400E4EF RID: 58607
		internal static int __PropertyOffset_bEmissionUseTex;
	}
}
