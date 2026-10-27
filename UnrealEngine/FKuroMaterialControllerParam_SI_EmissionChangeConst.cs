using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B56 RID: 6998
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_EmissionChangeConst")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroMaterialControllerParam_SI_EmissionChangeConst : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A7ED RID: 108525 RVA: 0x00271029 File Offset: 0x0026F229
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_SI_EmissionChangeConst._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_SI_EmissionChangeConst._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_EmissionChangeConst", ref FKuroMaterialControllerParam_SI_EmissionChangeConst._ScriptStructPtr);
		}

		// Token: 0x17006A82 RID: 27266
		// (get) Token: 0x0601A7EE RID: 108526 RVA: 0x0027104D File Offset: 0x0026F24D
		// (set) Token: 0x0601A7EF RID: 108527 RVA: 0x0027105D File Offset: 0x0026F25D
		public unsafe float EmissionLightColorChangeProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_EmissionChangeConst.__PropertyOffset_EmissionLightColorChangeProgress);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_EmissionChangeConst.__PropertyOffset_EmissionLightColorChangeProgress) = value;
			}
		}

		// Token: 0x17006A83 RID: 27267
		// (get) Token: 0x0601A7F0 RID: 108528 RVA: 0x0027106E File Offset: 0x0026F26E
		// (set) Token: 0x0601A7F1 RID: 108529 RVA: 0x0027107E File Offset: 0x0026F27E
		public unsafe float EmissionLightColorChangeStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_EmissionChangeConst.__PropertyOffset_EmissionLightColorChangeStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_EmissionChangeConst.__PropertyOffset_EmissionLightColorChangeStrength) = value;
			}
		}

		// Token: 0x17006A84 RID: 27268
		// (get) Token: 0x0601A7F2 RID: 108530 RVA: 0x0027108F File Offset: 0x0026F28F
		// (set) Token: 0x0601A7F3 RID: 108531 RVA: 0x002710A3 File Offset: 0x0026F2A3
		public unsafe FLinearColor EmissionLightColorChangeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_EmissionChangeConst.__PropertyOffset_EmissionLightColorChangeColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_SI_EmissionChangeConst.__PropertyOffset_EmissionLightColorChangeColor) = value;
			}
		}

		// Token: 0x0601A7F4 RID: 108532 RVA: 0x002710B8 File Offset: 0x0026F2B8
		public FKuroMaterialControllerParam_SI_EmissionChangeConst()
		{
		}

		// Token: 0x0601A7F5 RID: 108533 RVA: 0x002710C0 File Offset: 0x0026F2C0
		public FKuroMaterialControllerParam_SI_EmissionChangeConst(float EmissionLightColorChangeProgress, float EmissionLightColorChangeStrength, FLinearColor EmissionLightColorChangeColor)
		{
			this.EmissionLightColorChangeProgress = EmissionLightColorChangeProgress;
			this.EmissionLightColorChangeStrength = EmissionLightColorChangeStrength;
			this.EmissionLightColorChangeColor = EmissionLightColorChangeColor;
		}

		// Token: 0x0601A7F6 RID: 108534 RVA: 0x002710DD File Offset: 0x0026F2DD
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_SI_EmissionChangeConst.StaticStruct();
		}

		// Token: 0x0601A7F7 RID: 108535 RVA: 0x002710E9 File Offset: 0x0026F2E9
		[NullableContext(2)]
		public FKuroMaterialControllerParam_SI_EmissionChangeConst(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A7F8 RID: 108536 RVA: 0x002710F3 File Offset: 0x0026F2F3
		public FKuroMaterialControllerParam_SI_EmissionChangeConst(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A7F9 RID: 108537 RVA: 0x002710FE File Offset: 0x0026F2FE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_SI_EmissionChangeConst(Pointer, false, true);
		}

		// Token: 0x0601A7FA RID: 108538 RVA: 0x00271108 File Offset: 0x0026F308
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_SI_EmissionChangeConst(Pointer, MemoryOwner);
		}

		// Token: 0x0400E5A2 RID: 58786
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_SI_EmissionChangeConst";

		// Token: 0x0400E5A3 RID: 58787
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E5A4 RID: 58788
		internal static int __PropertyOffset_EmissionLightColorChangeProgress;

		// Token: 0x0400E5A5 RID: 58789
		internal static int __PropertyOffset_EmissionLightColorChangeStrength;

		// Token: 0x0400E5A6 RID: 58790
		internal static int __PropertyOffset_EmissionLightColorChangeColor;
	}
}
