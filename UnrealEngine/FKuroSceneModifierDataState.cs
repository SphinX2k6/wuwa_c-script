using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C81 RID: 7297
	[UnrealObjectPath("/Script/KuroSceneModifier.KuroSceneModifierDataState")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroSceneModifierDataState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C541 RID: 116033 RVA: 0x0029C030 File Offset: 0x0029A230
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSceneModifierDataState._ScriptStructPtr != 0) ? FKuroSceneModifierDataState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSceneModifier.KuroSceneModifierDataState", ref FKuroSceneModifierDataState._ScriptStructPtr);
		}

		// Token: 0x1700728A RID: 29322
		// (get) Token: 0x0601C542 RID: 116034 RVA: 0x0029C054 File Offset: 0x0029A254
		// (set) Token: 0x0601C543 RID: 116035 RVA: 0x0029C068 File Offset: 0x0029A268
		[Nullable(2)]
		public unsafe UKuroSceneMatModifyDataAsset MatDataAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroSceneMatModifyDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSceneModifierDataState.__PropertyOffset_MatDataAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSceneModifierDataState.__PropertyOffset_MatDataAsset, value);
			}
		}

		// Token: 0x0601C544 RID: 116036 RVA: 0x0029C07D File Offset: 0x0029A27D
		public FKuroSceneModifierDataState()
		{
		}

		// Token: 0x0601C545 RID: 116037 RVA: 0x0029C085 File Offset: 0x0029A285
		[NullableContext(1)]
		public FKuroSceneModifierDataState(UKuroSceneMatModifyDataAsset MatDataAsset)
		{
			this.MatDataAsset = MatDataAsset;
		}

		// Token: 0x0601C546 RID: 116038 RVA: 0x0029C094 File Offset: 0x0029A294
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSceneModifierDataState.StaticStruct();
		}

		// Token: 0x0601C547 RID: 116039 RVA: 0x0029C0A0 File Offset: 0x0029A2A0
		[NullableContext(2)]
		public FKuroSceneModifierDataState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C548 RID: 116040 RVA: 0x0029C0AA File Offset: 0x0029A2AA
		public FKuroSceneModifierDataState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C549 RID: 116041 RVA: 0x0029C0B5 File Offset: 0x0029A2B5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSceneModifierDataState(Pointer, false, true);
		}

		// Token: 0x0601C54A RID: 116042 RVA: 0x0029C0BF File Offset: 0x0029A2BF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSceneModifierDataState(Pointer, MemoryOwner);
		}

		// Token: 0x0400F3A9 RID: 62377
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroSceneModifier.KuroSceneModifierDataState";

		// Token: 0x0400F3AA RID: 62378
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F3AB RID: 62379
		internal static int __PropertyOffset_MatDataAsset;
	}
}
