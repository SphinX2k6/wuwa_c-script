using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006F4 RID: 1780
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIDropdownOptionData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FUIDropdownOptionData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009743 RID: 38723 RVA: 0x000E43D2 File Offset: 0x000E25D2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FUIDropdownOptionData._ScriptStructPtr != 0) ? FUIDropdownOptionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.UIDropdownOptionData", ref FUIDropdownOptionData._ScriptStructPtr);
		}

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x06009744 RID: 38724 RVA: 0x000E43F6 File Offset: 0x000E25F6
		// (set) Token: 0x06009745 RID: 38725 RVA: 0x000E440A File Offset: 0x000E260A
		public unsafe string TextOrConfigTableName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FUIDropdownOptionData.__PropertyOffset_TextOrConfigTableName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FUIDropdownOptionData.__PropertyOffset_TextOrConfigTableName)), value);
			}
		}

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x06009746 RID: 38726 RVA: 0x000E441F File Offset: 0x000E261F
		// (set) Token: 0x06009747 RID: 38727 RVA: 0x000E4433 File Offset: 0x000E2633
		[Nullable(2)]
		public unsafe ULGUISpriteData_BaseObject Sprite
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUISpriteData_BaseObject>(base.NativePtr / (IntPtr)sizeof(void*) + FUIDropdownOptionData.__PropertyOffset_Sprite);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FUIDropdownOptionData.__PropertyOffset_Sprite, value);
			}
		}

		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x06009748 RID: 38728 RVA: 0x000E4448 File Offset: 0x000E2648
		// (set) Token: 0x06009749 RID: 38729 RVA: 0x000E4458 File Offset: 0x000E2658
		public unsafe int TextId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIDropdownOptionData.__PropertyOffset_TextId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIDropdownOptionData.__PropertyOffset_TextId) = value;
			}
		}

		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x0600974A RID: 38730 RVA: 0x000E4469 File Offset: 0x000E2669
		// (set) Token: 0x0600974B RID: 38731 RVA: 0x000E447D File Offset: 0x000E267D
		public unsafe string SecondText
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FUIDropdownOptionData.__PropertyOffset_SecondText)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FUIDropdownOptionData.__PropertyOffset_SecondText)), value);
			}
		}

		// Token: 0x0600974C RID: 38732 RVA: 0x000E4492 File Offset: 0x000E2692
		public FUIDropdownOptionData()
		{
		}

		// Token: 0x0600974D RID: 38733 RVA: 0x000E449A File Offset: 0x000E269A
		protected override IntPtr GetUStructPtr()
		{
			return FUIDropdownOptionData.StaticStruct();
		}

		// Token: 0x0600974E RID: 38734 RVA: 0x000E44A6 File Offset: 0x000E26A6
		[NullableContext(2)]
		public FUIDropdownOptionData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600974F RID: 38735 RVA: 0x000E44B0 File Offset: 0x000E26B0
		public FUIDropdownOptionData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009750 RID: 38736 RVA: 0x000E44BB File Offset: 0x000E26BB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FUIDropdownOptionData(Pointer, false, true);
		}

		// Token: 0x06009751 RID: 38737 RVA: 0x000E44C5 File Offset: 0x000E26C5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FUIDropdownOptionData(Pointer, MemoryOwner);
		}

		// Token: 0x040041D0 RID: 16848
		public const string __ObjectPath = "/Script/LGUI.UIDropdownOptionData";

		// Token: 0x040041D1 RID: 16849
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040041D2 RID: 16850
		internal static int __PropertyOffset_TextOrConfigTableName;

		// Token: 0x040041D3 RID: 16851
		internal static int __PropertyOffset_Sprite;

		// Token: 0x040041D4 RID: 16852
		internal static int __PropertyOffset_TextId;

		// Token: 0x040041D5 RID: 16853
		internal static int __PropertyOffset_SecondText;
	}
}
