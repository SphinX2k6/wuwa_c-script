using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007A4 RID: 1956
	[UnrealObjectPath("/Script/Engine.ActiveForceFeedbackEffect")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FActiveForceFeedbackEffect : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060065F3 RID: 26099 RVA: 0x00092264 File Offset: 0x00090464
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActiveForceFeedbackEffect._ScriptStructPtr != 0) ? FActiveForceFeedbackEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActiveForceFeedbackEffect", ref FActiveForceFeedbackEffect._ScriptStructPtr);
		}

		// Token: 0x17001842 RID: 6210
		// (get) Token: 0x060065F4 RID: 26100 RVA: 0x00092288 File Offset: 0x00090488
		// (set) Token: 0x060065F5 RID: 26101 RVA: 0x0009229C File Offset: 0x0009049C
		[Nullable(2)]
		public unsafe UForceFeedbackEffect ForceFeedbackEffect
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UForceFeedbackEffect>(base.NativePtr / (IntPtr)sizeof(void*) + FActiveForceFeedbackEffect.__PropertyOffset_ForceFeedbackEffect);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FActiveForceFeedbackEffect.__PropertyOffset_ForceFeedbackEffect, value);
			}
		}

		// Token: 0x060065F6 RID: 26102 RVA: 0x000922B1 File Offset: 0x000904B1
		public FActiveForceFeedbackEffect()
		{
		}

		// Token: 0x060065F7 RID: 26103 RVA: 0x000922B9 File Offset: 0x000904B9
		[NullableContext(1)]
		public FActiveForceFeedbackEffect(UForceFeedbackEffect ForceFeedbackEffect)
		{
			this.ForceFeedbackEffect = ForceFeedbackEffect;
		}

		// Token: 0x060065F8 RID: 26104 RVA: 0x000922C8 File Offset: 0x000904C8
		protected override IntPtr GetUStructPtr()
		{
			return FActiveForceFeedbackEffect.StaticStruct();
		}

		// Token: 0x060065F9 RID: 26105 RVA: 0x000922D4 File Offset: 0x000904D4
		[NullableContext(2)]
		public FActiveForceFeedbackEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060065FA RID: 26106 RVA: 0x000922DE File Offset: 0x000904DE
		public FActiveForceFeedbackEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060065FB RID: 26107 RVA: 0x000922E9 File Offset: 0x000904E9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActiveForceFeedbackEffect(Pointer, false, true);
		}

		// Token: 0x060065FC RID: 26108 RVA: 0x000922F3 File Offset: 0x000904F3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActiveForceFeedbackEffect(Pointer, MemoryOwner);
		}

		// Token: 0x0400317D RID: 12669
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActiveForceFeedbackEffect";

		// Token: 0x0400317E RID: 12670
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400317F RID: 12671
		internal static int __PropertyOffset_ForceFeedbackEffect;
	}
}
