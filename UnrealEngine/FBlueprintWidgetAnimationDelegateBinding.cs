using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200293A RID: 10554
	[UnrealObjectPath("/Script/UMG.BlueprintWidgetAnimationDelegateBinding")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FBlueprintWidgetAnimationDelegateBinding : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602709D RID: 159901 RVA: 0x003B8AE1 File Offset: 0x003B6CE1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlueprintWidgetAnimationDelegateBinding._ScriptStructPtr != 0) ? FBlueprintWidgetAnimationDelegateBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.BlueprintWidgetAnimationDelegateBinding", ref FBlueprintWidgetAnimationDelegateBinding._ScriptStructPtr);
		}

		// Token: 0x17009636 RID: 38454
		// (get) Token: 0x0602709E RID: 159902 RVA: 0x003B8B05 File Offset: 0x003B6D05
		// (set) Token: 0x0602709F RID: 159903 RVA: 0x003B8B15 File Offset: 0x003B6D15
		public unsafe EWidgetAnimationEvent Action
		{
			get
			{
				return (EWidgetAnimationEvent)(*(base.NativePtr + (IntPtr)FBlueprintWidgetAnimationDelegateBinding.__PropertyOffset_Action));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintWidgetAnimationDelegateBinding.__PropertyOffset_Action) = (byte)value;
			}
		}

		// Token: 0x17009637 RID: 38455
		// (get) Token: 0x060270A0 RID: 159904 RVA: 0x003B8B26 File Offset: 0x003B6D26
		// (set) Token: 0x060270A1 RID: 159905 RVA: 0x003B8B3A File Offset: 0x003B6D3A
		public unsafe FName AnimationToBind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlueprintWidgetAnimationDelegateBinding.__PropertyOffset_AnimationToBind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintWidgetAnimationDelegateBinding.__PropertyOffset_AnimationToBind) = value;
			}
		}

		// Token: 0x17009638 RID: 38456
		// (get) Token: 0x060270A2 RID: 159906 RVA: 0x003B8B4F File Offset: 0x003B6D4F
		// (set) Token: 0x060270A3 RID: 159907 RVA: 0x003B8B63 File Offset: 0x003B6D63
		public unsafe FName FunctionNameToBind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlueprintWidgetAnimationDelegateBinding.__PropertyOffset_FunctionNameToBind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintWidgetAnimationDelegateBinding.__PropertyOffset_FunctionNameToBind) = value;
			}
		}

		// Token: 0x17009639 RID: 38457
		// (get) Token: 0x060270A4 RID: 159908 RVA: 0x003B8B78 File Offset: 0x003B6D78
		// (set) Token: 0x060270A5 RID: 159909 RVA: 0x003B8B8C File Offset: 0x003B6D8C
		public unsafe FName UserTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlueprintWidgetAnimationDelegateBinding.__PropertyOffset_UserTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlueprintWidgetAnimationDelegateBinding.__PropertyOffset_UserTag) = value;
			}
		}

		// Token: 0x060270A6 RID: 159910 RVA: 0x003B8BA1 File Offset: 0x003B6DA1
		public FBlueprintWidgetAnimationDelegateBinding()
		{
		}

		// Token: 0x060270A7 RID: 159911 RVA: 0x003B8BA9 File Offset: 0x003B6DA9
		public FBlueprintWidgetAnimationDelegateBinding(EWidgetAnimationEvent Action, FName AnimationToBind, FName FunctionNameToBind, FName UserTag)
		{
			this.Action = Action;
			this.AnimationToBind = AnimationToBind;
			this.FunctionNameToBind = FunctionNameToBind;
			this.UserTag = UserTag;
		}

		// Token: 0x060270A8 RID: 159912 RVA: 0x003B8BCE File Offset: 0x003B6DCE
		protected override IntPtr GetUStructPtr()
		{
			return FBlueprintWidgetAnimationDelegateBinding.StaticStruct();
		}

		// Token: 0x060270A9 RID: 159913 RVA: 0x003B8BDA File Offset: 0x003B6DDA
		[NullableContext(2)]
		public FBlueprintWidgetAnimationDelegateBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060270AA RID: 159914 RVA: 0x003B8BE4 File Offset: 0x003B6DE4
		public FBlueprintWidgetAnimationDelegateBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060270AB RID: 159915 RVA: 0x003B8BEF File Offset: 0x003B6DEF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlueprintWidgetAnimationDelegateBinding(Pointer, false, true);
		}

		// Token: 0x060270AC RID: 159916 RVA: 0x003B8BF9 File Offset: 0x003B6DF9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlueprintWidgetAnimationDelegateBinding(Pointer, MemoryOwner);
		}

		// Token: 0x0401573A RID: 87866
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.BlueprintWidgetAnimationDelegateBinding";

		// Token: 0x0401573B RID: 87867
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401573C RID: 87868
		internal static int __PropertyOffset_Action;

		// Token: 0x0401573D RID: 87869
		internal static int __PropertyOffset_AnimationToBind;

		// Token: 0x0401573E RID: 87870
		internal static int __PropertyOffset_FunctionNameToBind;

		// Token: 0x0401573F RID: 87871
		internal static int __PropertyOffset_UserTag;
	}
}
