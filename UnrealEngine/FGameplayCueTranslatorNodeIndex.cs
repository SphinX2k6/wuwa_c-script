using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001379 RID: 4985
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayCueTranslatorNodeIndex")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FGameplayCueTranslatorNodeIndex : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060124AD RID: 74925 RVA: 0x001AD9B7 File Offset: 0x001ABBB7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayCueTranslatorNodeIndex._ScriptStructPtr != 0) ? FGameplayCueTranslatorNodeIndex._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayCueTranslatorNodeIndex", ref FGameplayCueTranslatorNodeIndex._ScriptStructPtr);
		}

		// Token: 0x1700473E RID: 18238
		// (get) Token: 0x060124AE RID: 74926 RVA: 0x001AD9DB File Offset: 0x001ABBDB
		// (set) Token: 0x060124AF RID: 74927 RVA: 0x001AD9EB File Offset: 0x001ABBEB
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayCueTranslatorNodeIndex.__PropertyOffset_Index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCueTranslatorNodeIndex.__PropertyOffset_Index) = value;
			}
		}

		// Token: 0x060124B0 RID: 74928 RVA: 0x001AD9FC File Offset: 0x001ABBFC
		public FGameplayCueTranslatorNodeIndex()
		{
		}

		// Token: 0x060124B1 RID: 74929 RVA: 0x001ADA04 File Offset: 0x001ABC04
		public FGameplayCueTranslatorNodeIndex(int Index)
		{
			this.Index = Index;
		}

		// Token: 0x060124B2 RID: 74930 RVA: 0x001ADA13 File Offset: 0x001ABC13
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayCueTranslatorNodeIndex.StaticStruct();
		}

		// Token: 0x060124B3 RID: 74931 RVA: 0x001ADA1F File Offset: 0x001ABC1F
		[NullableContext(2)]
		public FGameplayCueTranslatorNodeIndex(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060124B4 RID: 74932 RVA: 0x001ADA29 File Offset: 0x001ABC29
		public FGameplayCueTranslatorNodeIndex(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060124B5 RID: 74933 RVA: 0x001ADA34 File Offset: 0x001ABC34
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayCueTranslatorNodeIndex(Pointer, false, true);
		}

		// Token: 0x060124B6 RID: 74934 RVA: 0x001ADA3E File Offset: 0x001ABC3E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayCueTranslatorNodeIndex(Pointer, MemoryOwner);
		}

		// Token: 0x04009CA4 RID: 40100
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayCueTranslatorNodeIndex";

		// Token: 0x04009CA5 RID: 40101
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009CA6 RID: 40102
		internal static int __PropertyOffset_Index;
	}
}
