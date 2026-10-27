using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001329 RID: 4905
	[UnrealObjectPath("/Script/GameplayAbilities.AttributeDefaults")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAttributeDefaults : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012106 RID: 73990 RVA: 0x001A88AC File Offset: 0x001A6AAC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAttributeDefaults._ScriptStructPtr != 0) ? FAttributeDefaults._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.AttributeDefaults", ref FAttributeDefaults._ScriptStructPtr);
		}

		// Token: 0x17004665 RID: 18021
		// (get) Token: 0x06012107 RID: 73991 RVA: 0x001A88D0 File Offset: 0x001A6AD0
		// (set) Token: 0x06012108 RID: 73992 RVA: 0x001A88E4 File Offset: 0x001A6AE4
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UAttributeSet> Attributes
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FAttributeDefaults.__PropertyOffset_Attributes);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FAttributeDefaults.__PropertyOffset_Attributes) = value;
			}
		}

		// Token: 0x17004666 RID: 18022
		// (get) Token: 0x06012109 RID: 73993 RVA: 0x001A88F9 File Offset: 0x001A6AF9
		// (set) Token: 0x0601210A RID: 73994 RVA: 0x001A890D File Offset: 0x001A6B0D
		[Nullable(2)]
		public unsafe UDataTable DefaultStartingTable
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + FAttributeDefaults.__PropertyOffset_DefaultStartingTable);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAttributeDefaults.__PropertyOffset_DefaultStartingTable, value);
			}
		}

		// Token: 0x0601210B RID: 73995 RVA: 0x001A8922 File Offset: 0x001A6B22
		public FAttributeDefaults()
		{
		}

		// Token: 0x0601210C RID: 73996 RVA: 0x001A892A File Offset: 0x001A6B2A
		[NullableContext(1)]
		public FAttributeDefaults([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAttributeSet> Attributes, UDataTable DefaultStartingTable)
		{
			this.Attributes = Attributes;
			this.DefaultStartingTable = DefaultStartingTable;
		}

		// Token: 0x0601210D RID: 73997 RVA: 0x001A8940 File Offset: 0x001A6B40
		protected override IntPtr GetUStructPtr()
		{
			return FAttributeDefaults.StaticStruct();
		}

		// Token: 0x0601210E RID: 73998 RVA: 0x001A894C File Offset: 0x001A6B4C
		[NullableContext(2)]
		public FAttributeDefaults(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601210F RID: 73999 RVA: 0x001A8956 File Offset: 0x001A6B56
		public FAttributeDefaults(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012110 RID: 74000 RVA: 0x001A8961 File Offset: 0x001A6B61
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAttributeDefaults(Pointer, false, true);
		}

		// Token: 0x06012111 RID: 74001 RVA: 0x001A896B File Offset: 0x001A6B6B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAttributeDefaults(Pointer, MemoryOwner);
		}

		// Token: 0x04009A56 RID: 39510
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.AttributeDefaults";

		// Token: 0x04009A57 RID: 39511
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009A58 RID: 39512
		internal static int __PropertyOffset_Attributes;

		// Token: 0x04009A59 RID: 39513
		internal static int __PropertyOffset_DefaultStartingTable;
	}
}
