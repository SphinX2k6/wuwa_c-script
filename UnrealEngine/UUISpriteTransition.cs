using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200072C RID: 1836
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISpriteTransition")]
	[UnrealStructLayout(944, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 944)]
	public class UUISpriteTransition : UUITransitionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009F57 RID: 40791 RVA: 0x000EC7ED File Offset: 0x000EA9ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISpriteTransition._ClassPtr;
		}

		// Token: 0x06009F58 RID: 40792 RVA: 0x000EC7FC File Offset: 0x000EA9FC
		public UUISpriteTransition() : this(BuiltinUtils.AllocNativeUObject(UUISpriteTransition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009F59 RID: 40793 RVA: 0x000EC824 File Offset: 0x000EAA24
		[NullableContext(1)]
		public UUISpriteTransition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISpriteTransition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D9B RID: 7579
		// (get) Token: 0x06009F5A RID: 40794 RVA: 0x000EC858 File Offset: 0x000EAA58
		// (set) Token: 0x06009F5B RID: 40795 RVA: 0x000EC891 File Offset: 0x000EAA91
		[Nullable(1)]
		public FSpriteTransitionInfo TransitionInfo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSpriteTransitionInfo result;
				if ((result = this._TransitionInfo) == null)
				{
					result = (this._TransitionInfo = new FSpriteTransitionInfo(base.NativePtr + (IntPtr)UUISpriteTransition.__PropertyOffset_TransitionInfo, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpriteTransitionInfo.StaticStruct(), base.NativePtr + (IntPtr)UUISpriteTransition.__PropertyOffset_TransitionInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001D9C RID: 7580
		// (get) Token: 0x06009F5C RID: 40796 RVA: 0x000EC8B2 File Offset: 0x000EAAB2
		// (set) Token: 0x06009F5D RID: 40797 RVA: 0x000EC8C6 File Offset: 0x000EAAC6
		public unsafe ULTweener ColorTweener
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULTweener>(base.NativePtr / (IntPtr)sizeof(void*) + UUISpriteTransition.__PropertyOffset_ColorTweener);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISpriteTransition.__PropertyOffset_ColorTweener, value);
			}
		}

		// Token: 0x06009F5E RID: 40798 RVA: 0x000EC8DB File Offset: 0x000EAADB
		public void SetStateSprite(EUISelectableSelectionState State, ULGUISpriteData_BaseObject NewSprite)
		{
			UUISpriteTransition.__SetStateSprite_Internal(base.NativePtr, State, (NewSprite != null) ? NewSprite.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009F5F RID: 40799 RVA: 0x000EC8F9 File Offset: 0x000EAAF9
		public void SetAllTransitionSprite(ULGUISpriteData_BaseObject NewSprite)
		{
			UUISpriteTransition.__SetAllTransitionSprite_Internal(base.NativePtr, (NewSprite != null) ? NewSprite.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009F60 RID: 40800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStateSprite_Internal(IntPtr @this, EUISelectableSelectionState State, IntPtr NewSprite);

		// Token: 0x06009F61 RID: 40801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllTransitionSprite_Internal(IntPtr @this, IntPtr NewSprite);

		// Token: 0x06009F62 RID: 40802 RVA: 0x000EC916 File Offset: 0x000EAB16
		static UUISpriteTransition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISpriteTransition");
		}

		// Token: 0x06009F63 RID: 40803 RVA: 0x000EC924 File Offset: 0x000EAB24
		protected UUISpriteTransition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004462 RID: 17506
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISpriteTransition";

		// Token: 0x04004463 RID: 17507
		private static IntPtr _ClassPtr;

		// Token: 0x04004464 RID: 17508
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004465 RID: 17509
		internal static int __PropertyOffset_TransitionInfo;

		// Token: 0x04004466 RID: 17510
		private FSpriteTransitionInfo _TransitionInfo;

		// Token: 0x04004467 RID: 17511
		internal static int __PropertyOffset_ColorTweener;
	}
}
