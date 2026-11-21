using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200081C RID: 2076
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SlateCore.SlateFontInfo")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FSlateFontInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B5C7 RID: 46535 RVA: 0x00121322 File Offset: 0x0011F522
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSlateFontInfo._ScriptStructPtr != 0) ? FSlateFontInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.SlateFontInfo", ref FSlateFontInfo._ScriptStructPtr);
		}

		// Token: 0x17002208 RID: 8712
		// (get) Token: 0x0600B5C8 RID: 46536 RVA: 0x00121346 File Offset: 0x0011F546
		// (set) Token: 0x0600B5C9 RID: 46537 RVA: 0x0012135A File Offset: 0x0011F55A
		public unsafe UObject FontObject
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FSlateFontInfo.__PropertyOffset_FontObject);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSlateFontInfo.__PropertyOffset_FontObject, value);
			}
		}

		// Token: 0x17002209 RID: 8713
		// (get) Token: 0x0600B5CA RID: 46538 RVA: 0x0012136F File Offset: 0x0011F56F
		// (set) Token: 0x0600B5CB RID: 46539 RVA: 0x00121383 File Offset: 0x0011F583
		public unsafe UObject FontMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FSlateFontInfo.__PropertyOffset_FontMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSlateFontInfo.__PropertyOffset_FontMaterial, value);
			}
		}

		// Token: 0x1700220A RID: 8714
		// (get) Token: 0x0600B5CC RID: 46540 RVA: 0x00121398 File Offset: 0x0011F598
		// (set) Token: 0x0600B5CD RID: 46541 RVA: 0x001213AC File Offset: 0x0011F5AC
		public unsafe FName TypefaceFontName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateFontInfo.__PropertyOffset_TypefaceFontName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateFontInfo.__PropertyOffset_TypefaceFontName) = value;
			}
		}

		// Token: 0x1700220B RID: 8715
		// (get) Token: 0x0600B5CE RID: 46542 RVA: 0x001213C1 File Offset: 0x0011F5C1
		// (set) Token: 0x0600B5CF RID: 46543 RVA: 0x001213D1 File Offset: 0x0011F5D1
		public unsafe int Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateFontInfo.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateFontInfo.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x1700220C RID: 8716
		// (get) Token: 0x0600B5D0 RID: 46544 RVA: 0x001213E2 File Offset: 0x0011F5E2
		// (set) Token: 0x0600B5D1 RID: 46545 RVA: 0x001213F2 File Offset: 0x0011F5F2
		public unsafe int LetterSpacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateFontInfo.__PropertyOffset_LetterSpacing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateFontInfo.__PropertyOffset_LetterSpacing) = value;
			}
		}

		// Token: 0x0600B5D2 RID: 46546 RVA: 0x00121403 File Offset: 0x0011F603
		public FSlateFontInfo()
		{
		}

		// Token: 0x0600B5D3 RID: 46547 RVA: 0x0012140B File Offset: 0x0011F60B
		protected override IntPtr GetUStructPtr()
		{
			return FSlateFontInfo.StaticStruct();
		}

		// Token: 0x0600B5D4 RID: 46548 RVA: 0x00121417 File Offset: 0x0011F617
		public FSlateFontInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B5D5 RID: 46549 RVA: 0x00121421 File Offset: 0x0011F621
		public FSlateFontInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B5D6 RID: 46550 RVA: 0x0012142C File Offset: 0x0011F62C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSlateFontInfo(Pointer, false, true);
		}

		// Token: 0x0600B5D7 RID: 46551 RVA: 0x00121436 File Offset: 0x0011F636
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSlateFontInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400521D RID: 21021
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SlateCore.SlateFontInfo";

		// Token: 0x0400521E RID: 21022
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400521F RID: 21023
		internal static int __PropertyOffset_FontObject;

		// Token: 0x04005220 RID: 21024
		internal static int __PropertyOffset_FontMaterial;

		// Token: 0x04005221 RID: 21025
		internal static int __PropertyOffset_TypefaceFontName;

		// Token: 0x04005222 RID: 21026
		internal static int __PropertyOffset_Size;

		// Token: 0x04005223 RID: 21027
		internal static int __PropertyOffset_LetterSpacing;
	}
}
