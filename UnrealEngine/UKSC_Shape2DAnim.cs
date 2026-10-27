using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E2C RID: 7724
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Shape2DAnim")]
	[UnrealStructLayout(472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class UKSC_Shape2DAnim : UKSC_Anim, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D70B RID: 120587 RVA: 0x002B7C22 File Offset: 0x002B5E22
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Shape2DAnim._ClassPtr;
		}

		// Token: 0x0601D70C RID: 120588 RVA: 0x002B7C30 File Offset: 0x002B5E30
		public UKSC_Shape2DAnim() : this(BuiltinUtils.AllocNativeUObject(UKSC_Shape2DAnim.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D70D RID: 120589 RVA: 0x002B7C58 File Offset: 0x002B5E58
		[NullableContext(1)]
		public UKSC_Shape2DAnim(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Shape2DAnim.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170076AE RID: 30382
		// (get) Token: 0x0601D70E RID: 120590 RVA: 0x002B7C8B File Offset: 0x002B5E8B
		// (set) Token: 0x0601D70F RID: 120591 RVA: 0x002B7C9F File Offset: 0x002B5E9F
		public unsafe USpineSkeletonAnimationComponent SpineAnimComp_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpineSkeletonAnimationComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2DAnim.__PropertyOffset_SpineAnimComp_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2DAnim.__PropertyOffset_SpineAnimComp_, value);
			}
		}

		// Token: 0x170076AF RID: 30383
		// (get) Token: 0x0601D710 RID: 120592 RVA: 0x002B7CB4 File Offset: 0x002B5EB4
		// (set) Token: 0x0601D711 RID: 120593 RVA: 0x002B7CC8 File Offset: 0x002B5EC8
		public unsafe USpineSkeletonRendererComponent SpineRenderComp_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USpineSkeletonRendererComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2DAnim.__PropertyOffset_SpineRenderComp_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Shape2DAnim.__PropertyOffset_SpineRenderComp_, value);
			}
		}

		// Token: 0x0601D712 RID: 120594 RVA: 0x002B7CDD File Offset: 0x002B5EDD
		public void SetBaseStateAndClearOverrideStates(EKSC_Shape2D_BaseAnimState InBaseState)
		{
			UKSC_Shape2DAnim.__SetBaseStateAndClearOverrideStates_Internal(base.NativePtr, InBaseState);
		}

		// Token: 0x0601D713 RID: 120595 RVA: 0x002B7CEB File Offset: 0x002B5EEB
		public void OnSpineAnimComplete(UTrackEntry entry)
		{
			UKSC_Shape2DAnim.__OnSpineAnimComplete_Internal(base.NativePtr, (entry != null) ? entry.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601D714 RID: 120596 RVA: 0x002B7D08 File Offset: 0x002B5F08
		public void MarkAnimStateDirty()
		{
			UKSC_Shape2DAnim.__MarkAnimStateDirty_Internal(base.NativePtr);
		}

		// Token: 0x0601D715 RID: 120597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBaseStateAndClearOverrideStates_Internal(IntPtr @this, EKSC_Shape2D_BaseAnimState InBaseState);

		// Token: 0x0601D716 RID: 120598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnSpineAnimComplete_Internal(IntPtr @this, IntPtr entry);

		// Token: 0x0601D717 RID: 120599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkAnimStateDirty_Internal(IntPtr @this);

		// Token: 0x0601D718 RID: 120600 RVA: 0x002B7D15 File Offset: 0x002B5F15
		static UKSC_Shape2DAnim()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Shape2DAnim");
		}

		// Token: 0x0601D719 RID: 120601 RVA: 0x002B7D23 File Offset: 0x002B5F23
		protected UKSC_Shape2DAnim(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF6E RID: 65390
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Shape2DAnim";

		// Token: 0x0400FF6F RID: 65391
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF70 RID: 65392
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF71 RID: 65393
		internal static int __PropertyOffset_SpineAnimComp_;

		// Token: 0x0400FF72 RID: 65394
		internal static int __PropertyOffset_SpineRenderComp_;
	}
}
