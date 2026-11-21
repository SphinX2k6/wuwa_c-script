using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000723 RID: 1827
	[UnrealObjectPath("/Script/LGUI.UISelectableTransitionComponent")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public abstract class UUISelectableTransitionComponent : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009E54 RID: 40532 RVA: 0x000EB799 File Offset: 0x000E9999
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISelectableTransitionComponent._ClassPtr;
		}

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x06009E55 RID: 40533 RVA: 0x000EB7A8 File Offset: 0x000E99A8
		// (set) Token: 0x06009E56 RID: 40534 RVA: 0x000EB7E1 File Offset: 0x000E99E1
		[Nullable(1)]
		public TArray<ULTweener> TweenerCollection
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<ULTweener> result;
				if ((result = this._TweenerCollection) == null)
				{
					result = (this._TweenerCollection = new TArray<ULTweener>(base.NativePtr + (IntPtr)UUISelectableTransitionComponent.__PropertyOffset_TweenerCollection, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.TweenerCollection.CopyAssign(value);
			}
		}

		// Token: 0x06009E57 RID: 40535 RVA: 0x000EB7EF File Offset: 0x000E99EF
		public void StopTransition()
		{
			UUISelectableTransitionComponent.__StopTransition_Internal(base.NativePtr);
		}

		// Token: 0x06009E58 RID: 40536 RVA: 0x000EB7FC File Offset: 0x000E99FC
		public virtual void OnStartCustomTransitionBP(FName InTransitionName, bool InImmediateSet)
		{
			UUISelectableTransitionComponent.__OnStartCustomTransitionBP_Internal(base.NativePtr, InTransitionName, InImmediateSet);
		}

		// Token: 0x06009E59 RID: 40537 RVA: 0x000EB80B File Offset: 0x000E9A0B
		public virtual void OnPressedBP(bool InImmediateSet)
		{
			UUISelectableTransitionComponent.__OnPressedBP_Internal(base.NativePtr, InImmediateSet);
		}

		// Token: 0x06009E5A RID: 40538 RVA: 0x000EB819 File Offset: 0x000E9A19
		public virtual void OnNormalBP(bool InImmediateSet)
		{
			UUISelectableTransitionComponent.__OnNormalBP_Internal(base.NativePtr, InImmediateSet);
		}

		// Token: 0x06009E5B RID: 40539 RVA: 0x000EB827 File Offset: 0x000E9A27
		public virtual void OnHighlightedBP(bool InImmediateSet)
		{
			UUISelectableTransitionComponent.__OnHighlightedBP_Internal(base.NativePtr, InImmediateSet);
		}

		// Token: 0x06009E5C RID: 40540 RVA: 0x000EB835 File Offset: 0x000E9A35
		public virtual void OnDisabledBP(bool InImmediateSet)
		{
			UUISelectableTransitionComponent.__OnDisabledBP_Internal(base.NativePtr, InImmediateSet);
		}

		// Token: 0x06009E5D RID: 40541 RVA: 0x000EB843 File Offset: 0x000E9A43
		public void CollectTweeners([Nullable(new byte[]
		{
			2,
			1
		})] in TSet<ULTweener> InItems)
		{
			UUISelectableTransitionComponent.__CollectTweeners_Internal(base.NativePtr, (InItems ?? new TSet<ULTweener>()).NativeSetPtr);
		}

		// Token: 0x06009E5E RID: 40542 RVA: 0x000EB860 File Offset: 0x000E9A60
		[NullableContext(2)]
		public void CollectTweener(ULTweener InItem)
		{
			UUISelectableTransitionComponent.__CollectTweener_Internal(base.NativePtr, (InItem != null) ? InItem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009E5F RID: 40543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopTransition_Internal(IntPtr @this);

		// Token: 0x06009E60 RID: 40544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnStartCustomTransitionBP_Internal(IntPtr @this, FName InTransitionName, bool InImmediateSet);

		// Token: 0x06009E61 RID: 40545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPressedBP_Internal(IntPtr @this, bool InImmediateSet);

		// Token: 0x06009E62 RID: 40546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnNormalBP_Internal(IntPtr @this, bool InImmediateSet);

		// Token: 0x06009E63 RID: 40547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnHighlightedBP_Internal(IntPtr @this, bool InImmediateSet);

		// Token: 0x06009E64 RID: 40548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnDisabledBP_Internal(IntPtr @this, bool InImmediateSet);

		// Token: 0x06009E65 RID: 40549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CollectTweeners_Internal(IntPtr @this, IntPtr InItems);

		// Token: 0x06009E66 RID: 40550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CollectTweener_Internal(IntPtr @this, IntPtr InItem);

		// Token: 0x06009E67 RID: 40551 RVA: 0x000EB87D File Offset: 0x000E9A7D
		static UUISelectableTransitionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISelectableTransitionComponent");
		}

		// Token: 0x06009E68 RID: 40552 RVA: 0x000EB88C File Offset: 0x000E9A8C
		protected UUISelectableTransitionComponent() : this(BuiltinUtils.AllocNativeUObject(UUISelectableTransitionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009E69 RID: 40553 RVA: 0x000EB8B4 File Offset: 0x000E9AB4
		protected UUISelectableTransitionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040043FC RID: 17404
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISelectableTransitionComponent";

		// Token: 0x040043FD RID: 17405
		private static IntPtr _ClassPtr;

		// Token: 0x040043FE RID: 17406
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040043FF RID: 17407
		internal static int __PropertyOffset_TweenerCollection;

		// Token: 0x04004400 RID: 17408
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULTweener> _TweenerCollection;

		// Token: 0x02000F24 RID: 3876
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnStartCustomTransitionBP_FunctionParams
		{
			// Token: 0x040062F7 RID: 25335
			[FieldOffset(0)]
			public FName InTransitionName;

			// Token: 0x040062F8 RID: 25336
			[FieldOffset(12)]
			public bool InImmediateSet;
		}

		// Token: 0x02000F25 RID: 3877
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnPressedBP_FunctionParams
		{
			// Token: 0x040062F9 RID: 25337
			[FieldOffset(0)]
			public bool InImmediateSet;
		}

		// Token: 0x02000F26 RID: 3878
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnNormalBP_FunctionParams
		{
			// Token: 0x040062FA RID: 25338
			[FieldOffset(0)]
			public bool InImmediateSet;
		}

		// Token: 0x02000F27 RID: 3879
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnHighlightedBP_FunctionParams
		{
			// Token: 0x040062FB RID: 25339
			[FieldOffset(0)]
			public bool InImmediateSet;
		}

		// Token: 0x02000F28 RID: 3880
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnDisabledBP_FunctionParams
		{
			// Token: 0x040062FC RID: 25340
			[FieldOffset(0)]
			public bool InImmediateSet;
		}
	}
}
