using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021AC RID: 8620
	[UnrealObjectPath("/Script/LGUI.UISelectableTransitionComponent")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public abstract class UUISelectableTransitionComponent : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020C75 RID: 134261 RVA: 0x00307346 File Offset: 0x00305546
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISelectableTransitionComponent._ClassPtr;
		}

		// Token: 0x17008008 RID: 32776
		// (get) Token: 0x06020C76 RID: 134262 RVA: 0x00307354 File Offset: 0x00305554
		// (set) Token: 0x06020C77 RID: 134263 RVA: 0x0030738D File Offset: 0x0030558D
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

		// Token: 0x06020C78 RID: 134264 RVA: 0x0030739B File Offset: 0x0030559B
		public void StopTransition()
		{
			UUISelectableTransitionComponent.__StopTransition_Internal(base.NativePtr);
		}

		// Token: 0x06020C79 RID: 134265 RVA: 0x003073A8 File Offset: 0x003055A8
		public virtual void OnStartCustomTransitionBP(FName InTransitionName, bool InImmediateSet)
		{
			UUISelectableTransitionComponent.__OnStartCustomTransitionBP_Internal(base.NativePtr, InTransitionName, InImmediateSet);
		}

		// Token: 0x06020C7A RID: 134266 RVA: 0x003073B7 File Offset: 0x003055B7
		public virtual void OnPressedBP(bool InImmediateSet)
		{
			UUISelectableTransitionComponent.__OnPressedBP_Internal(base.NativePtr, InImmediateSet);
		}

		// Token: 0x06020C7B RID: 134267 RVA: 0x003073C5 File Offset: 0x003055C5
		public virtual void OnNormalBP(bool InImmediateSet)
		{
			UUISelectableTransitionComponent.__OnNormalBP_Internal(base.NativePtr, InImmediateSet);
		}

		// Token: 0x06020C7C RID: 134268 RVA: 0x003073D3 File Offset: 0x003055D3
		public virtual void OnHighlightedBP(bool InImmediateSet)
		{
			UUISelectableTransitionComponent.__OnHighlightedBP_Internal(base.NativePtr, InImmediateSet);
		}

		// Token: 0x06020C7D RID: 134269 RVA: 0x003073E1 File Offset: 0x003055E1
		public virtual void OnDisabledBP(bool InImmediateSet)
		{
			UUISelectableTransitionComponent.__OnDisabledBP_Internal(base.NativePtr, InImmediateSet);
		}

		// Token: 0x06020C7E RID: 134270 RVA: 0x003073EF File Offset: 0x003055EF
		public void CollectTweeners([Nullable(new byte[]
		{
			2,
			1
		})] in TSet<ULTweener> InItems)
		{
			UUISelectableTransitionComponent.__CollectTweeners_Internal(base.NativePtr, (InItems ?? new TSet<ULTweener>()).NativeSetPtr);
		}

		// Token: 0x06020C7F RID: 134271 RVA: 0x0030740C File Offset: 0x0030560C
		[NullableContext(2)]
		public void CollectTweener(ULTweener InItem)
		{
			UUISelectableTransitionComponent.__CollectTweener_Internal(base.NativePtr, (InItem != null) ? InItem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020C80 RID: 134272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopTransition_Internal(IntPtr @this);

		// Token: 0x06020C81 RID: 134273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnStartCustomTransitionBP_Internal(IntPtr @this, FName InTransitionName, bool InImmediateSet);

		// Token: 0x06020C82 RID: 134274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPressedBP_Internal(IntPtr @this, bool InImmediateSet);

		// Token: 0x06020C83 RID: 134275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnNormalBP_Internal(IntPtr @this, bool InImmediateSet);

		// Token: 0x06020C84 RID: 134276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnHighlightedBP_Internal(IntPtr @this, bool InImmediateSet);

		// Token: 0x06020C85 RID: 134277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnDisabledBP_Internal(IntPtr @this, bool InImmediateSet);

		// Token: 0x06020C86 RID: 134278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CollectTweeners_Internal(IntPtr @this, IntPtr InItems);

		// Token: 0x06020C87 RID: 134279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CollectTweener_Internal(IntPtr @this, IntPtr InItem);

		// Token: 0x06020C88 RID: 134280 RVA: 0x00307429 File Offset: 0x00305629
		static UUISelectableTransitionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISelectableTransitionComponent");
		}

		// Token: 0x06020C89 RID: 134281 RVA: 0x00307438 File Offset: 0x00305638
		protected UUISelectableTransitionComponent() : this(BuiltinUtils.AllocNativeUObject(UUISelectableTransitionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020C8A RID: 134282 RVA: 0x00307460 File Offset: 0x00305660
		protected UUISelectableTransitionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011833 RID: 71731
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISelectableTransitionComponent";

		// Token: 0x04011834 RID: 71732
		private static IntPtr _ClassPtr;

		// Token: 0x04011835 RID: 71733
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011836 RID: 71734
		internal static int __PropertyOffset_TweenerCollection;

		// Token: 0x04011837 RID: 71735
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULTweener> _TweenerCollection;

		// Token: 0x02003503 RID: 13571
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnStartCustomTransitionBP_FunctionParams
		{
			// Token: 0x0401752C RID: 95532
			[FieldOffset(0)]
			public FName InTransitionName;

			// Token: 0x0401752D RID: 95533
			[FieldOffset(12)]
			public bool InImmediateSet;
		}

		// Token: 0x02003504 RID: 13572
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnPressedBP_FunctionParams
		{
			// Token: 0x0401752E RID: 95534
			[FieldOffset(0)]
			public bool InImmediateSet;
		}

		// Token: 0x02003505 RID: 13573
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnNormalBP_FunctionParams
		{
			// Token: 0x0401752F RID: 95535
			[FieldOffset(0)]
			public bool InImmediateSet;
		}

		// Token: 0x02003506 RID: 13574
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnHighlightedBP_FunctionParams
		{
			// Token: 0x04017530 RID: 95536
			[FieldOffset(0)]
			public bool InImmediateSet;
		}

		// Token: 0x02003507 RID: 13575
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnDisabledBP_FunctionParams
		{
			// Token: 0x04017531 RID: 95537
			[FieldOffset(0)]
			public bool InImmediateSet;
		}
	}
}
