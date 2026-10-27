using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002178 RID: 8568
	[UnrealObjectPath("/Script/LGUI.UIInputAdaptZone")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UUIInputAdaptZone : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060205F9 RID: 132601 RVA: 0x00300BC7 File Offset: 0x002FEDC7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIInputAdaptZone._ClassPtr;
		}

		// Token: 0x060205FA RID: 132602 RVA: 0x00300BD4 File Offset: 0x002FEDD4
		public UUIInputAdaptZone() : this(BuiltinUtils.AllocNativeUObject(UUIInputAdaptZone.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060205FB RID: 132603 RVA: 0x00300BFC File Offset: 0x002FEDFC
		[NullableContext(1)]
		public UUIInputAdaptZone(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIInputAdaptZone.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007EDD RID: 32477
		// (get) Token: 0x060205FC RID: 132604 RVA: 0x00300C2F File Offset: 0x002FEE2F
		// (set) Token: 0x060205FD RID: 132605 RVA: 0x00300C43 File Offset: 0x002FEE43
		public unsafe FMargin AdaptMargin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIInputAdaptZone.__PropertyOffset_AdaptMargin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIInputAdaptZone.__PropertyOffset_AdaptMargin) = value;
			}
		}

		// Token: 0x17007EDE RID: 32478
		// (get) Token: 0x060205FE RID: 132606 RVA: 0x00300C58 File Offset: 0x002FEE58
		// (set) Token: 0x060205FF RID: 132607 RVA: 0x00300C68 File Offset: 0x002FEE68
		public unsafe bool bMouseKeyboardAdapt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIInputAdaptZone.__PropertyOffset_bMouseKeyboardAdapt) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIInputAdaptZone.__PropertyOffset_bMouseKeyboardAdapt) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007EDF RID: 32479
		// (get) Token: 0x06020600 RID: 132608 RVA: 0x00300C79 File Offset: 0x002FEE79
		// (set) Token: 0x06020601 RID: 132609 RVA: 0x00300C89 File Offset: 0x002FEE89
		public unsafe bool bGamepadAdapt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIInputAdaptZone.__PropertyOffset_bGamepadAdapt) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIInputAdaptZone.__PropertyOffset_bGamepadAdapt) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020602 RID: 132610 RVA: 0x00300C9A File Offset: 0x002FEE9A
		public void OnTouchBegin(ETouchIndex TouchIndex, FVector Location)
		{
			UUIInputAdaptZone.__OnTouchBegin_Internal(base.NativePtr, TouchIndex, Location);
		}

		// Token: 0x06020603 RID: 132611 RVA: 0x00300CAE File Offset: 0x002FEEAE
		[NullableContext(2)]
		public void OnPressAnyKey(in FKey Key)
		{
			UUIInputAdaptZone.__OnPressAnyKey_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x06020604 RID: 132612 RVA: 0x00300CCB File Offset: 0x002FEECB
		public void OnMouseMoved(float Value)
		{
			UUIInputAdaptZone.__OnMouseMoved_Internal(base.NativePtr, Value);
		}

		// Token: 0x06020605 RID: 132613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnTouchBegin_Internal(IntPtr @this, TEnumAsByte<ETouchIndex> TouchIndex, FVector Location);

		// Token: 0x06020606 RID: 132614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPressAnyKey_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x06020607 RID: 132615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnMouseMoved_Internal(IntPtr @this, float Value);

		// Token: 0x06020608 RID: 132616 RVA: 0x00300CD9 File Offset: 0x002FEED9
		static UUIInputAdaptZone()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIInputAdaptZone");
		}

		// Token: 0x06020609 RID: 132617 RVA: 0x00300CE7 File Offset: 0x002FEEE7
		protected UUIInputAdaptZone(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011615 RID: 71189
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIInputAdaptZone";

		// Token: 0x04011616 RID: 71190
		private static IntPtr _ClassPtr;

		// Token: 0x04011617 RID: 71191
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011618 RID: 71192
		internal static int __PropertyOffset_AdaptMargin;

		// Token: 0x04011619 RID: 71193
		internal static int __PropertyOffset_bMouseKeyboardAdapt;

		// Token: 0x0401161A RID: 71194
		internal static int __PropertyOffset_bGamepadAdapt;
	}
}
