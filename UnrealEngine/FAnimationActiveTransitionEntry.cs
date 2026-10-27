using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007DC RID: 2012
	[UnrealObjectPath("/Script/Engine.AnimationActiveTransitionEntry")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FAnimationActiveTransitionEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006B44 RID: 27460 RVA: 0x0009A734 File Offset: 0x00098934
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimationActiveTransitionEntry._ScriptStructPtr != 0) ? FAnimationActiveTransitionEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimationActiveTransitionEntry", ref FAnimationActiveTransitionEntry._ScriptStructPtr);
		}

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x06006B45 RID: 27461 RVA: 0x0009A758 File Offset: 0x00098958
		// (set) Token: 0x06006B46 RID: 27462 RVA: 0x0009A76C File Offset: 0x0009896C
		[Nullable(2)]
		public unsafe UBlendProfile BlendProfile
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBlendProfile>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimationActiveTransitionEntry.__PropertyOffset_BlendProfile);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimationActiveTransitionEntry.__PropertyOffset_BlendProfile, value);
			}
		}

		// Token: 0x06006B47 RID: 27463 RVA: 0x0009A781 File Offset: 0x00098981
		public FAnimationActiveTransitionEntry()
		{
		}

		// Token: 0x06006B48 RID: 27464 RVA: 0x0009A789 File Offset: 0x00098989
		[NullableContext(1)]
		public FAnimationActiveTransitionEntry(UBlendProfile BlendProfile)
		{
			this.BlendProfile = BlendProfile;
		}

		// Token: 0x06006B49 RID: 27465 RVA: 0x0009A798 File Offset: 0x00098998
		protected override IntPtr GetUStructPtr()
		{
			return FAnimationActiveTransitionEntry.StaticStruct();
		}

		// Token: 0x06006B4A RID: 27466 RVA: 0x0009A7A4 File Offset: 0x000989A4
		[NullableContext(2)]
		public FAnimationActiveTransitionEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006B4B RID: 27467 RVA: 0x0009A7AE File Offset: 0x000989AE
		public FAnimationActiveTransitionEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006B4C RID: 27468 RVA: 0x0009A7B9 File Offset: 0x000989B9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimationActiveTransitionEntry(Pointer, false, true);
		}

		// Token: 0x06006B4D RID: 27469 RVA: 0x0009A7C3 File Offset: 0x000989C3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimationActiveTransitionEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04003396 RID: 13206
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimationActiveTransitionEntry";

		// Token: 0x04003397 RID: 13207
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003398 RID: 13208
		internal static int __PropertyOffset_BlendProfile;
	}
}
