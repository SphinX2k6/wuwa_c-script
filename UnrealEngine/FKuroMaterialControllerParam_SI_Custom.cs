using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B51 RID: 6993
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_Custom")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FKuroMaterialControllerParam_SI_Custom : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A79B RID: 108443 RVA: 0x0027074E File Offset: 0x0026E94E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_SI_Custom._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_SI_Custom._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_Custom", ref FKuroMaterialControllerParam_SI_Custom._ScriptStructPtr);
		}

		// Token: 0x17006A6D RID: 27245
		// (get) Token: 0x0601A79C RID: 108444 RVA: 0x00270774 File Offset: 0x0026E974
		// (set) Token: 0x0601A79D RID: 108445 RVA: 0x002707B7 File Offset: 0x0026E9B7
		public TMap<FName, FKuroMaterialCurveFloatGroup_SI> FloatParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroMaterialCurveFloatGroup_SI> result;
				if ((result = this._FloatParams) == null)
				{
					result = (this._FloatParams = new TMap<FName, FKuroMaterialCurveFloatGroup_SI>(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Custom.__PropertyOffset_FloatParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatParams.CopyAssign(value);
			}
		}

		// Token: 0x17006A6E RID: 27246
		// (get) Token: 0x0601A79E RID: 108446 RVA: 0x002707C8 File Offset: 0x0026E9C8
		// (set) Token: 0x0601A79F RID: 108447 RVA: 0x0027080B File Offset: 0x0026EA0B
		public TMap<FName, FKuroMaterialCurveColorGroup_SI> ColorParams
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroMaterialCurveColorGroup_SI> result;
				if ((result = this._ColorParams) == null)
				{
					result = (this._ColorParams = new TMap<FName, FKuroMaterialCurveColorGroup_SI>(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_Custom.__PropertyOffset_ColorParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ColorParams.CopyAssign(value);
			}
		}

		// Token: 0x0601A7A0 RID: 108448 RVA: 0x00270819 File Offset: 0x0026EA19
		public FKuroMaterialControllerParam_SI_Custom()
		{
		}

		// Token: 0x0601A7A1 RID: 108449 RVA: 0x00270821 File Offset: 0x0026EA21
		public FKuroMaterialControllerParam_SI_Custom(TMap<FName, FKuroMaterialCurveFloatGroup_SI> FloatParams, TMap<FName, FKuroMaterialCurveColorGroup_SI> ColorParams)
		{
			this.FloatParams = FloatParams;
			this.ColorParams = ColorParams;
		}

		// Token: 0x0601A7A2 RID: 108450 RVA: 0x00270837 File Offset: 0x0026EA37
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_SI_Custom.StaticStruct();
		}

		// Token: 0x0601A7A3 RID: 108451 RVA: 0x00270843 File Offset: 0x0026EA43
		[NullableContext(2)]
		public FKuroMaterialControllerParam_SI_Custom(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A7A4 RID: 108452 RVA: 0x0027084D File Offset: 0x0026EA4D
		public FKuroMaterialControllerParam_SI_Custom(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A7A5 RID: 108453 RVA: 0x00270858 File Offset: 0x0026EA58
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_SI_Custom(Pointer, false, true);
		}

		// Token: 0x0601A7A6 RID: 108454 RVA: 0x00270862 File Offset: 0x0026EA62
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_SI_Custom(Pointer, MemoryOwner);
		}

		// Token: 0x0400E575 RID: 58741
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_Custom";

		// Token: 0x0400E576 RID: 58742
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E577 RID: 58743
		internal static int __PropertyOffset_FloatParams;

		// Token: 0x0400E578 RID: 58744
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroMaterialCurveFloatGroup_SI> _FloatParams;

		// Token: 0x0400E579 RID: 58745
		internal static int __PropertyOffset_ColorParams;

		// Token: 0x0400E57A RID: 58746
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroMaterialCurveColorGroup_SI> _ColorParams;
	}
}
