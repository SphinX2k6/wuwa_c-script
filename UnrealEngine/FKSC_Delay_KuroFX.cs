using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DD4 RID: 7636
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Delay_KuroFX")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKSC_Delay_KuroFX : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D2DB RID: 119515 RVA: 0x002B1B9A File Offset: 0x002AFD9A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_Delay_KuroFX._ScriptStructPtr != 0) ? FKSC_Delay_KuroFX._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_Delay_KuroFX", ref FKSC_Delay_KuroFX._ScriptStructPtr);
		}

		// Token: 0x170075E0 RID: 30176
		// (get) Token: 0x0601D2DC RID: 119516 RVA: 0x002B1BBE File Offset: 0x002AFDBE
		// (set) Token: 0x0601D2DD RID: 119517 RVA: 0x002B1BCE File Offset: 0x002AFDCE
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Delay_KuroFX.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Delay_KuroFX.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x170075E1 RID: 30177
		// (get) Token: 0x0601D2DE RID: 119518 RVA: 0x002B1BDF File Offset: 0x002AFDDF
		// (set) Token: 0x0601D2DF RID: 119519 RVA: 0x002B1BF3 File Offset: 0x002AFDF3
		[Nullable(2)]
		public unsafe UEffectModelBase FX
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_Delay_KuroFX.__PropertyOffset_FX);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_Delay_KuroFX.__PropertyOffset_FX, value);
			}
		}

		// Token: 0x170075E2 RID: 30178
		// (get) Token: 0x0601D2E0 RID: 119520 RVA: 0x002B1C08 File Offset: 0x002AFE08
		// (set) Token: 0x0601D2E1 RID: 119521 RVA: 0x002B1C1C File Offset: 0x002AFE1C
		public unsafe FTransform FX_Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Delay_KuroFX.__PropertyOffset_FX_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Delay_KuroFX.__PropertyOffset_FX_Offset) = value;
			}
		}

		// Token: 0x0601D2E2 RID: 119522 RVA: 0x002B1C31 File Offset: 0x002AFE31
		public FKSC_Delay_KuroFX()
		{
		}

		// Token: 0x0601D2E3 RID: 119523 RVA: 0x002B1C39 File Offset: 0x002AFE39
		[NullableContext(1)]
		public FKSC_Delay_KuroFX(float Time, UEffectModelBase FX, FTransform FX_Offset)
		{
			this.Time = Time;
			this.FX = FX;
			this.FX_Offset = FX_Offset;
		}

		// Token: 0x0601D2E4 RID: 119524 RVA: 0x002B1C56 File Offset: 0x002AFE56
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_Delay_KuroFX.StaticStruct();
		}

		// Token: 0x0601D2E5 RID: 119525 RVA: 0x002B1C62 File Offset: 0x002AFE62
		[NullableContext(2)]
		public FKSC_Delay_KuroFX(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D2E6 RID: 119526 RVA: 0x002B1C6C File Offset: 0x002AFE6C
		public FKSC_Delay_KuroFX(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D2E7 RID: 119527 RVA: 0x002B1C77 File Offset: 0x002AFE77
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_Delay_KuroFX(Pointer, false, true);
		}

		// Token: 0x0601D2E8 RID: 119528 RVA: 0x002B1C81 File Offset: 0x002AFE81
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_Delay_KuroFX(Pointer, MemoryOwner);
		}

		// Token: 0x0400FD7C RID: 64892
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Delay_KuroFX";

		// Token: 0x0400FD7D RID: 64893
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FD7E RID: 64894
		internal static int __PropertyOffset_Time;

		// Token: 0x0400FD7F RID: 64895
		internal static int __PropertyOffset_FX;

		// Token: 0x0400FD80 RID: 64896
		internal static int __PropertyOffset_FX_Offset;
	}
}
