using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002990 RID: 10640
	[UnrealObjectPath("/Script/UMG.NamedSlotBinding")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNamedSlotBinding : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027639 RID: 161337 RVA: 0x003C0E0A File Offset: 0x003BF00A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNamedSlotBinding._ScriptStructPtr != 0) ? FNamedSlotBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.NamedSlotBinding", ref FNamedSlotBinding._ScriptStructPtr);
		}

		// Token: 0x17009764 RID: 38756
		// (get) Token: 0x0602763A RID: 161338 RVA: 0x003C0E2E File Offset: 0x003BF02E
		// (set) Token: 0x0602763B RID: 161339 RVA: 0x003C0E42 File Offset: 0x003BF042
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNamedSlotBinding.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNamedSlotBinding.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17009765 RID: 38757
		// (get) Token: 0x0602763C RID: 161340 RVA: 0x003C0E57 File Offset: 0x003BF057
		// (set) Token: 0x0602763D RID: 161341 RVA: 0x003C0E6B File Offset: 0x003BF06B
		[Nullable(2)]
		public unsafe UWidget Content
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWidget>(base.NativePtr / (IntPtr)sizeof(void*) + FNamedSlotBinding.__PropertyOffset_Content);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNamedSlotBinding.__PropertyOffset_Content, value);
			}
		}

		// Token: 0x0602763E RID: 161342 RVA: 0x003C0E80 File Offset: 0x003BF080
		public FNamedSlotBinding()
		{
		}

		// Token: 0x0602763F RID: 161343 RVA: 0x003C0E88 File Offset: 0x003BF088
		[NullableContext(1)]
		public FNamedSlotBinding(FName Name, UWidget Content)
		{
			this.Name = Name;
			this.Content = Content;
		}

		// Token: 0x06027640 RID: 161344 RVA: 0x003C0E9E File Offset: 0x003BF09E
		protected override IntPtr GetUStructPtr()
		{
			return FNamedSlotBinding.StaticStruct();
		}

		// Token: 0x06027641 RID: 161345 RVA: 0x003C0EAA File Offset: 0x003BF0AA
		[NullableContext(2)]
		public FNamedSlotBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027642 RID: 161346 RVA: 0x003C0EB4 File Offset: 0x003BF0B4
		public FNamedSlotBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027643 RID: 161347 RVA: 0x003C0EBF File Offset: 0x003BF0BF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNamedSlotBinding(Pointer, false, true);
		}

		// Token: 0x06027644 RID: 161348 RVA: 0x003C0EC9 File Offset: 0x003BF0C9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNamedSlotBinding(Pointer, MemoryOwner);
		}

		// Token: 0x04015A16 RID: 88598
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.NamedSlotBinding";

		// Token: 0x04015A17 RID: 88599
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015A18 RID: 88600
		internal static int __PropertyOffset_Name;

		// Token: 0x04015A19 RID: 88601
		internal static int __PropertyOffset_Content;
	}
}
