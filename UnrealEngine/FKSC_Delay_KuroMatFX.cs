using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DD5 RID: 7637
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Delay_KuroMatFX")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKSC_Delay_KuroMatFX : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D2E9 RID: 119529 RVA: 0x002B1C8A File Offset: 0x002AFE8A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_Delay_KuroMatFX._ScriptStructPtr != 0) ? FKSC_Delay_KuroMatFX._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_Delay_KuroMatFX", ref FKSC_Delay_KuroMatFX._ScriptStructPtr);
		}

		// Token: 0x170075E3 RID: 30179
		// (get) Token: 0x0601D2EA RID: 119530 RVA: 0x002B1CAE File Offset: 0x002AFEAE
		// (set) Token: 0x0601D2EB RID: 119531 RVA: 0x002B1CBE File Offset: 0x002AFEBE
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Delay_KuroMatFX.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Delay_KuroMatFX.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x170075E4 RID: 30180
		// (get) Token: 0x0601D2EC RID: 119532 RVA: 0x002B1CCF File Offset: 0x002AFECF
		// (set) Token: 0x0601D2ED RID: 119533 RVA: 0x002B1CE3 File Offset: 0x002AFEE3
		[Nullable(2)]
		public unsafe UKuroMaterialControllerDataAsset KuroMatFX
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_Delay_KuroMatFX.__PropertyOffset_KuroMatFX);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_Delay_KuroMatFX.__PropertyOffset_KuroMatFX, value);
			}
		}

		// Token: 0x0601D2EE RID: 119534 RVA: 0x002B1CF8 File Offset: 0x002AFEF8
		public FKSC_Delay_KuroMatFX()
		{
		}

		// Token: 0x0601D2EF RID: 119535 RVA: 0x002B1D00 File Offset: 0x002AFF00
		[NullableContext(1)]
		public FKSC_Delay_KuroMatFX(float Time, UKuroMaterialControllerDataAsset KuroMatFX)
		{
			this.Time = Time;
			this.KuroMatFX = KuroMatFX;
		}

		// Token: 0x0601D2F0 RID: 119536 RVA: 0x002B1D16 File Offset: 0x002AFF16
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_Delay_KuroMatFX.StaticStruct();
		}

		// Token: 0x0601D2F1 RID: 119537 RVA: 0x002B1D22 File Offset: 0x002AFF22
		[NullableContext(2)]
		public FKSC_Delay_KuroMatFX(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D2F2 RID: 119538 RVA: 0x002B1D2C File Offset: 0x002AFF2C
		public FKSC_Delay_KuroMatFX(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D2F3 RID: 119539 RVA: 0x002B1D37 File Offset: 0x002AFF37
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_Delay_KuroMatFX(Pointer, false, true);
		}

		// Token: 0x0601D2F4 RID: 119540 RVA: 0x002B1D41 File Offset: 0x002AFF41
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_Delay_KuroMatFX(Pointer, MemoryOwner);
		}

		// Token: 0x0400FD81 RID: 64897
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Delay_KuroMatFX";

		// Token: 0x0400FD82 RID: 64898
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FD83 RID: 64899
		internal static int __PropertyOffset_Time;

		// Token: 0x0400FD84 RID: 64900
		internal static int __PropertyOffset_KuroMatFX;
	}
}
