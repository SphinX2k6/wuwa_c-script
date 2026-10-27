using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001E54 RID: 7764
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_SpineAnimItem")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKSC_SpineAnimItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601D8D7 RID: 121047 RVA: 0x002BA2C4 File Offset: 0x002B84C4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSC_SpineAnimItem._ScriptStructPtr != 0) ? FKSC_SpineAnimItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSC_SpineAnimItem", ref FKSC_SpineAnimItem._ScriptStructPtr);
		}

		// Token: 0x17007706 RID: 30470
		// (get) Token: 0x0601D8D8 RID: 121048 RVA: 0x002BA2E8 File Offset: 0x002B84E8
		// (set) Token: 0x0601D8D9 RID: 121049 RVA: 0x002BA2FC File Offset: 0x002B84FC
		public unsafe string AnimName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKSC_SpineAnimItem.__PropertyOffset_AnimName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKSC_SpineAnimItem.__PropertyOffset_AnimName)), value);
			}
		}

		// Token: 0x17007707 RID: 30471
		// (get) Token: 0x0601D8DA RID: 121050 RVA: 0x002BA311 File Offset: 0x002B8511
		// (set) Token: 0x0601D8DB RID: 121051 RVA: 0x002BA325 File Offset: 0x002B8525
		public unsafe FGameplayTag AnimTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSC_SpineAnimItem.__PropertyOffset_AnimTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSC_SpineAnimItem.__PropertyOffset_AnimTag) = value;
			}
		}

		// Token: 0x0601D8DC RID: 121052 RVA: 0x002BA33A File Offset: 0x002B853A
		public FKSC_SpineAnimItem()
		{
		}

		// Token: 0x0601D8DD RID: 121053 RVA: 0x002BA342 File Offset: 0x002B8542
		public FKSC_SpineAnimItem(string AnimName, FGameplayTag AnimTag)
		{
			this.AnimName = AnimName;
			this.AnimTag = AnimTag;
		}

		// Token: 0x0601D8DE RID: 121054 RVA: 0x002BA358 File Offset: 0x002B8558
		protected override IntPtr GetUStructPtr()
		{
			return FKSC_SpineAnimItem.StaticStruct();
		}

		// Token: 0x0601D8DF RID: 121055 RVA: 0x002BA364 File Offset: 0x002B8564
		[NullableContext(2)]
		public FKSC_SpineAnimItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601D8E0 RID: 121056 RVA: 0x002BA36E File Offset: 0x002B856E
		public FKSC_SpineAnimItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601D8E1 RID: 121057 RVA: 0x002BA379 File Offset: 0x002B8579
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSC_SpineAnimItem(Pointer, false, true);
		}

		// Token: 0x0601D8E2 RID: 121058 RVA: 0x002BA383 File Offset: 0x002B8583
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSC_SpineAnimItem(Pointer, MemoryOwner);
		}

		// Token: 0x04010053 RID: 65619
		public const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_SpineAnimItem";

		// Token: 0x04010054 RID: 65620
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010055 RID: 65621
		internal static int __PropertyOffset_AnimName;

		// Token: 0x04010056 RID: 65622
		internal static int __PropertyOffset_AnimTag;
	}
}
