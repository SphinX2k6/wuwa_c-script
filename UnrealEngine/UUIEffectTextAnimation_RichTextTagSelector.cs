using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200215B RID: 8539
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_RichTextTagSelector")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UUIEffectTextAnimation_RichTextTagSelector : UUIEffectTextAnimation_Selector, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020343 RID: 131907 RVA: 0x002FD50B File Offset: 0x002FB70B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_RichTextTagSelector._ClassPtr;
		}

		// Token: 0x06020344 RID: 131908 RVA: 0x002FD518 File Offset: 0x002FB718
		public UUIEffectTextAnimation_RichTextTagSelector() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_RichTextTagSelector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020345 RID: 131909 RVA: 0x002FD540 File Offset: 0x002FB740
		[NullableContext(1)]
		public UUIEffectTextAnimation_RichTextTagSelector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_RichTextTagSelector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E52 RID: 32338
		// (get) Token: 0x06020346 RID: 131910 RVA: 0x002FD573 File Offset: 0x002FB773
		// (set) Token: 0x06020347 RID: 131911 RVA: 0x002FD583 File Offset: 0x002FB783
		public unsafe float range
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RichTextTagSelector.__PropertyOffset_range);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RichTextTagSelector.__PropertyOffset_range) = value;
			}
		}

		// Token: 0x17007E53 RID: 32339
		// (get) Token: 0x06020348 RID: 131912 RVA: 0x002FD594 File Offset: 0x002FB794
		// (set) Token: 0x06020349 RID: 131913 RVA: 0x002FD5A8 File Offset: 0x002FB7A8
		public unsafe FName tagName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RichTextTagSelector.__PropertyOffset_tagName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RichTextTagSelector.__PropertyOffset_tagName) = value;
			}
		}

		// Token: 0x17007E54 RID: 32340
		// (get) Token: 0x0602034A RID: 131914 RVA: 0x002FD5BD File Offset: 0x002FB7BD
		// (set) Token: 0x0602034B RID: 131915 RVA: 0x002FD5CD File Offset: 0x002FB7CD
		public unsafe bool flipDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RichTextTagSelector.__PropertyOffset_flipDirection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RichTextTagSelector.__PropertyOffset_flipDirection) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602034C RID: 131916 RVA: 0x002FD5E0 File Offset: 0x002FB7E0
		public unsafe void SetTagName(in FName value)
		{
			fixed (FName* ptr = &value)
			{
				void* ptr2 = (void*)ptr;
				UUIEffectTextAnimation_RichTextTagSelector.__SetTagName_Internal(base.NativePtr, value);
			}
		}

		// Token: 0x0602034D RID: 131917 RVA: 0x002FD601 File Offset: 0x002FB801
		public void SetRange(float value)
		{
			UUIEffectTextAnimation_RichTextTagSelector.__SetRange_Internal(base.NativePtr, value);
		}

		// Token: 0x0602034E RID: 131918 RVA: 0x002FD60F File Offset: 0x002FB80F
		public void SetFlipDirection(bool value)
		{
			UUIEffectTextAnimation_RichTextTagSelector.__SetFlipDirection_Internal(base.NativePtr, value);
		}

		// Token: 0x0602034F RID: 131919 RVA: 0x002FD61D File Offset: 0x002FB81D
		public FName GetTagName()
		{
			return UUIEffectTextAnimation_RichTextTagSelector.__GetTagName_Internal(base.NativePtr);
		}

		// Token: 0x06020350 RID: 131920 RVA: 0x002FD62A File Offset: 0x002FB82A
		public float GetRange()
		{
			return UUIEffectTextAnimation_RichTextTagSelector.__GetRange_Internal(base.NativePtr);
		}

		// Token: 0x06020351 RID: 131921 RVA: 0x002FD637 File Offset: 0x002FB837
		public bool GetFlipDirection()
		{
			return UUIEffectTextAnimation_RichTextTagSelector.__GetFlipDirection_Internal(base.NativePtr);
		}

		// Token: 0x06020352 RID: 131922
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTagName_Internal(IntPtr @this, in FName value);

		// Token: 0x06020353 RID: 131923
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRange_Internal(IntPtr @this, float value);

		// Token: 0x06020354 RID: 131924
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFlipDirection_Internal(IntPtr @this, bool value);

		// Token: 0x06020355 RID: 131925
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetTagName_Internal(IntPtr @this);

		// Token: 0x06020356 RID: 131926
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRange_Internal(IntPtr @this);

		// Token: 0x06020357 RID: 131927
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFlipDirection_Internal(IntPtr @this);

		// Token: 0x06020358 RID: 131928 RVA: 0x002FD644 File Offset: 0x002FB844
		static UUIEffectTextAnimation_RichTextTagSelector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_RichTextTagSelector");
		}

		// Token: 0x06020359 RID: 131929 RVA: 0x002FD652 File Offset: 0x002FB852
		protected UUIEffectTextAnimation_RichTextTagSelector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114F1 RID: 70897
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_RichTextTagSelector";

		// Token: 0x040114F2 RID: 70898
		private static IntPtr _ClassPtr;

		// Token: 0x040114F3 RID: 70899
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114F4 RID: 70900
		internal static int __PropertyOffset_range;

		// Token: 0x040114F5 RID: 70901
		internal static int __PropertyOffset_tagName;

		// Token: 0x040114F6 RID: 70902
		internal static int __PropertyOffset_flipDirection;
	}
}
