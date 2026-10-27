using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001963 RID: 6499
	[UnrealObjectPath("/Script/KuroGAS.GameplayTagHashData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FGameplayTagHashData : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018256 RID: 98902 RVA: 0x002398AE File Offset: 0x00237AAE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTagHashData._ScriptStructPtr != 0) ? FGameplayTagHashData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGAS.GameplayTagHashData", ref FGameplayTagHashData._ScriptStructPtr);
		}

		// Token: 0x170060DD RID: 24797
		// (get) Token: 0x06018257 RID: 98903 RVA: 0x002398D2 File Offset: 0x00237AD2
		// (set) Token: 0x06018258 RID: 98904 RVA: 0x002398E2 File Offset: 0x00237AE2
		public unsafe int Hash
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayTagHashData.__PropertyOffset_Hash);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTagHashData.__PropertyOffset_Hash) = value;
			}
		}

		// Token: 0x06018259 RID: 98905 RVA: 0x002398F3 File Offset: 0x00237AF3
		public FGameplayTagHashData()
		{
		}

		// Token: 0x0601825A RID: 98906 RVA: 0x002398FB File Offset: 0x00237AFB
		public FGameplayTagHashData(int Hash)
		{
			this.Hash = Hash;
		}

		// Token: 0x0601825B RID: 98907 RVA: 0x0023990A File Offset: 0x00237B0A
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayTagHashData.StaticStruct();
		}

		// Token: 0x0601825C RID: 98908 RVA: 0x00239916 File Offset: 0x00237B16
		[NullableContext(2)]
		public FGameplayTagHashData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601825D RID: 98909 RVA: 0x00239920 File Offset: 0x00237B20
		public FGameplayTagHashData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601825E RID: 98910 RVA: 0x0023992B File Offset: 0x00237B2B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayTagHashData(Pointer, false, true);
		}

		// Token: 0x0601825F RID: 98911 RVA: 0x00239935 File Offset: 0x00237B35
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayTagHashData(Pointer, MemoryOwner);
		}

		// Token: 0x0400D19A RID: 53658
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGAS.GameplayTagHashData";

		// Token: 0x0400D19B RID: 53659
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D19C RID: 53660
		internal static int __PropertyOffset_Hash;
	}
}
