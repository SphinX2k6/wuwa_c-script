using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B4D RID: 6989
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_AddEmission")]
	[UnrealStructLayout(544, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 544)]
	public class FKuroMaterialControllerParam_SI_AddEmission : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A76F RID: 108399 RVA: 0x002703E1 File Offset: 0x0026E5E1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_SI_AddEmission._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_SI_AddEmission._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_AddEmission", ref FKuroMaterialControllerParam_SI_AddEmission._ScriptStructPtr);
		}

		// Token: 0x17006A67 RID: 27239
		// (get) Token: 0x0601A770 RID: 108400 RVA: 0x00270408 File Offset: 0x0026E608
		// (set) Token: 0x0601A771 RID: 108401 RVA: 0x0027044B File Offset: 0x0026E64B
		public FKuroMaterialCurveColorGroup_SI AddEmissionColor
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveColorGroup_SI result;
				if ((result = this._AddEmissionColor) == null)
				{
					result = (this._AddEmissionColor = new FKuroMaterialCurveColorGroup_SI(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_AddEmission.__PropertyOffset_AddEmissionColor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveColorGroup_SI.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_AddEmission.__PropertyOffset_AddEmissionColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601A772 RID: 108402 RVA: 0x0027046C File Offset: 0x0026E66C
		public FKuroMaterialControllerParam_SI_AddEmission()
		{
		}

		// Token: 0x0601A773 RID: 108403 RVA: 0x00270474 File Offset: 0x0026E674
		public FKuroMaterialControllerParam_SI_AddEmission(FKuroMaterialCurveColorGroup_SI AddEmissionColor)
		{
			this.AddEmissionColor = AddEmissionColor;
		}

		// Token: 0x0601A774 RID: 108404 RVA: 0x00270483 File Offset: 0x0026E683
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_SI_AddEmission.StaticStruct();
		}

		// Token: 0x0601A775 RID: 108405 RVA: 0x0027048F File Offset: 0x0026E68F
		[NullableContext(2)]
		public FKuroMaterialControllerParam_SI_AddEmission(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A776 RID: 108406 RVA: 0x00270499 File Offset: 0x0026E699
		public FKuroMaterialControllerParam_SI_AddEmission(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A777 RID: 108407 RVA: 0x002704A4 File Offset: 0x0026E6A4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_SI_AddEmission(Pointer, false, true);
		}

		// Token: 0x0601A778 RID: 108408 RVA: 0x002704AE File Offset: 0x0026E6AE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_SI_AddEmission(Pointer, MemoryOwner);
		}

		// Token: 0x0400E564 RID: 58724
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_AddEmission";

		// Token: 0x0400E565 RID: 58725
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E566 RID: 58726
		internal static int __PropertyOffset_AddEmissionColor;

		// Token: 0x0400E567 RID: 58727
		[Nullable(2)]
		private FKuroMaterialCurveColorGroup_SI _AddEmissionColor;
	}
}
