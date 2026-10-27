using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021C4 RID: 8644
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISpriteTransition")]
	[UnrealStructLayout(944, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 944)]
	public class UUISpriteTransition : UUITransitionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020E2D RID: 134701 RVA: 0x0030920F File Offset: 0x0030740F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISpriteTransition._ClassPtr;
		}

		// Token: 0x06020E2E RID: 134702 RVA: 0x0030921C File Offset: 0x0030741C
		public UUISpriteTransition() : this(BuiltinUtils.AllocNativeUObject(UUISpriteTransition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020E2F RID: 134703 RVA: 0x00309244 File Offset: 0x00307444
		[NullableContext(1)]
		public UUISpriteTransition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISpriteTransition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700806D RID: 32877
		// (get) Token: 0x06020E30 RID: 134704 RVA: 0x00309278 File Offset: 0x00307478
		// (set) Token: 0x06020E31 RID: 134705 RVA: 0x003092B1 File Offset: 0x003074B1
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

		// Token: 0x1700806E RID: 32878
		// (get) Token: 0x06020E32 RID: 134706 RVA: 0x003092D2 File Offset: 0x003074D2
		// (set) Token: 0x06020E33 RID: 134707 RVA: 0x003092E6 File Offset: 0x003074E6
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

		// Token: 0x06020E34 RID: 134708 RVA: 0x003092FB File Offset: 0x003074FB
		public void SetStateSprite(EUISelectableSelectionState State, ULGUISpriteData_BaseObject NewSprite)
		{
			UUISpriteTransition.__SetStateSprite_Internal(base.NativePtr, State, (NewSprite != null) ? NewSprite.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020E35 RID: 134709 RVA: 0x00309319 File Offset: 0x00307519
		public void SetAllTransitionSprite(ULGUISpriteData_BaseObject NewSprite)
		{
			UUISpriteTransition.__SetAllTransitionSprite_Internal(base.NativePtr, (NewSprite != null) ? NewSprite.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020E36 RID: 134710
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStateSprite_Internal(IntPtr @this, EUISelectableSelectionState State, IntPtr NewSprite);

		// Token: 0x06020E37 RID: 134711
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllTransitionSprite_Internal(IntPtr @this, IntPtr NewSprite);

		// Token: 0x06020E38 RID: 134712 RVA: 0x00309336 File Offset: 0x00307536
		static UUISpriteTransition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISpriteTransition");
		}

		// Token: 0x06020E39 RID: 134713 RVA: 0x00309344 File Offset: 0x00307544
		protected UUISpriteTransition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011909 RID: 71945
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISpriteTransition";

		// Token: 0x0401190A RID: 71946
		private static IntPtr _ClassPtr;

		// Token: 0x0401190B RID: 71947
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401190C RID: 71948
		internal static int __PropertyOffset_TransitionInfo;

		// Token: 0x0401190D RID: 71949
		private FSpriteTransitionInfo _TransitionInfo;

		// Token: 0x0401190E RID: 71950
		internal static int __PropertyOffset_ColorTweener;
	}
}
