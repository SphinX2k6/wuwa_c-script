using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001DD9 RID: 7641
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_EffectReuseData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FKSC_EffectReuseData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D319 RID: 119577 RVA: 0x002B1FCA File Offset: 0x002B01CA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_EffectReuseData._ScriptStructPtr != 0) ? FKSC_EffectReuseData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_EffectReuseData", ref FKSC_EffectReuseData._ScriptStructPtr);
		}

		// Token: 0x0601D31A RID: 119578 RVA: 0x002B1FEE File Offset: 0x002B01EE
		public FKSC_EffectReuseData()
		{
		}

		// Token: 0x0601D31B RID: 119579 RVA: 0x002B1FF6 File Offset: 0x002B01F6
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_EffectReuseData.StaticStruct();
		}

		// Token: 0x0601D31C RID: 119580 RVA: 0x002B2002 File Offset: 0x002B0202
		[NullableContext(2)]
		public FKSC_EffectReuseData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D31D RID: 119581 RVA: 0x002B200C File Offset: 0x002B020C
		public FKSC_EffectReuseData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D31E RID: 119582 RVA: 0x002B2017 File Offset: 0x002B0217
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_EffectReuseData(Pointer, false, true);
		}

		// Token: 0x0601D31F RID: 119583 RVA: 0x002B2021 File Offset: 0x002B0221
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_EffectReuseData(Pointer, MemoryOwner);
		}

		// Token: 0x0400FD94 RID: 64916
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_EffectReuseData";

		// Token: 0x0400FD95 RID: 64917
		private static IntPtr _ScriptStructPtr;
	}
}
