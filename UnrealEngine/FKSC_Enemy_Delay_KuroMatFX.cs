using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DDB RID: 7643
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Enemy_Delay_KuroMatFX")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKSC_Enemy_Delay_KuroMatFX : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D32C RID: 119596 RVA: 0x002B2126 File Offset: 0x002B0326
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_Enemy_Delay_KuroMatFX._ScriptStructPtr != 0) ? FKSC_Enemy_Delay_KuroMatFX._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_Enemy_Delay_KuroMatFX", ref FKSC_Enemy_Delay_KuroMatFX._ScriptStructPtr);
		}

		// Token: 0x170075EE RID: 30190
		// (get) Token: 0x0601D32D RID: 119597 RVA: 0x002B214A File Offset: 0x002B034A
		// (set) Token: 0x0601D32E RID: 119598 RVA: 0x002B215A File Offset: 0x002B035A
		public unsafe float Delay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_Enemy_Delay_KuroMatFX.__PropertyOffset_Delay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_Enemy_Delay_KuroMatFX.__PropertyOffset_Delay) = value;
			}
		}

		// Token: 0x170075EF RID: 30191
		// (get) Token: 0x0601D32F RID: 119599 RVA: 0x002B216B File Offset: 0x002B036B
		// (set) Token: 0x0601D330 RID: 119600 RVA: 0x002B217F File Offset: 0x002B037F
		[Nullable(2)]
		public unsafe UKuroMaterialControllerDataAsset KuroMatFX
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_Enemy_Delay_KuroMatFX.__PropertyOffset_KuroMatFX);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKSC_Enemy_Delay_KuroMatFX.__PropertyOffset_KuroMatFX, value);
			}
		}

		// Token: 0x0601D331 RID: 119601 RVA: 0x002B2194 File Offset: 0x002B0394
		public FKSC_Enemy_Delay_KuroMatFX()
		{
		}

		// Token: 0x0601D332 RID: 119602 RVA: 0x002B219C File Offset: 0x002B039C
		[NullableContext(1)]
		public FKSC_Enemy_Delay_KuroMatFX(float Delay, UKuroMaterialControllerDataAsset KuroMatFX)
		{
			this.Delay = Delay;
			this.KuroMatFX = KuroMatFX;
		}

		// Token: 0x0601D333 RID: 119603 RVA: 0x002B21B2 File Offset: 0x002B03B2
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_Enemy_Delay_KuroMatFX.StaticStruct();
		}

		// Token: 0x0601D334 RID: 119604 RVA: 0x002B21BE File Offset: 0x002B03BE
		[NullableContext(2)]
		public FKSC_Enemy_Delay_KuroMatFX(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D335 RID: 119605 RVA: 0x002B21C8 File Offset: 0x002B03C8
		public FKSC_Enemy_Delay_KuroMatFX(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D336 RID: 119606 RVA: 0x002B21D3 File Offset: 0x002B03D3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_Enemy_Delay_KuroMatFX(Pointer, false, true);
		}

		// Token: 0x0601D337 RID: 119607 RVA: 0x002B21DD File Offset: 0x002B03DD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_Enemy_Delay_KuroMatFX(Pointer, MemoryOwner);
		}

		// Token: 0x0400FD9B RID: 64923
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Enemy_Delay_KuroMatFX";

		// Token: 0x0400FD9C RID: 64924
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400FD9D RID: 64925
		internal static int __PropertyOffset_Delay;

		// Token: 0x0400FD9E RID: 64926
		internal static int __PropertyOffset_KuroMatFX;
	}
}
