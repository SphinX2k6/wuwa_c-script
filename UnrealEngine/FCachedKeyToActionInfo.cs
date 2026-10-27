using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000904 RID: 2308
	[UnrealObjectPath("/Script/Engine.CachedKeyToActionInfo")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FCachedKeyToActionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007EA9 RID: 32425 RVA: 0x000B5BC8 File Offset: 0x000B3DC8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCachedKeyToActionInfo._ScriptStructPtr != 0) ? FCachedKeyToActionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CachedKeyToActionInfo", ref FCachedKeyToActionInfo._ScriptStructPtr);
		}

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x06007EAA RID: 32426 RVA: 0x000B5BEC File Offset: 0x000B3DEC
		// (set) Token: 0x06007EAB RID: 32427 RVA: 0x000B5C00 File Offset: 0x000B3E00
		[Nullable(2)]
		public unsafe UPlayerInput PlayerInput
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPlayerInput>(base.NativePtr / (IntPtr)sizeof(void*) + FCachedKeyToActionInfo.__PropertyOffset_PlayerInput);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCachedKeyToActionInfo.__PropertyOffset_PlayerInput, value);
			}
		}

		// Token: 0x06007EAC RID: 32428 RVA: 0x000B5C15 File Offset: 0x000B3E15
		public FCachedKeyToActionInfo()
		{
		}

		// Token: 0x06007EAD RID: 32429 RVA: 0x000B5C1D File Offset: 0x000B3E1D
		[NullableContext(1)]
		public FCachedKeyToActionInfo(UPlayerInput PlayerInput)
		{
			this.PlayerInput = PlayerInput;
		}

		// Token: 0x06007EAE RID: 32430 RVA: 0x000B5C2C File Offset: 0x000B3E2C
		protected override IntPtr GetUStructPtr()
		{
			return FCachedKeyToActionInfo.StaticStruct();
		}

		// Token: 0x06007EAF RID: 32431 RVA: 0x000B5C38 File Offset: 0x000B3E38
		[NullableContext(2)]
		public FCachedKeyToActionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007EB0 RID: 32432 RVA: 0x000B5C42 File Offset: 0x000B3E42
		public FCachedKeyToActionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007EB1 RID: 32433 RVA: 0x000B5C4D File Offset: 0x000B3E4D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCachedKeyToActionInfo(Pointer, false, true);
		}

		// Token: 0x06007EB2 RID: 32434 RVA: 0x000B5C57 File Offset: 0x000B3E57
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCachedKeyToActionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04003CC5 RID: 15557
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CachedKeyToActionInfo";

		// Token: 0x04003CC6 RID: 15558
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003CC7 RID: 15559
		internal static int __PropertyOffset_PlayerInput;
	}
}
