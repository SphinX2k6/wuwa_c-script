using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006E8 RID: 1768
	[UnrealObjectPath("/Script/LGUI.UIAndroidBackComponent")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UUIAndroidBackComponent : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060095F0 RID: 38384 RVA: 0x000E250D File Offset: 0x000E070D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIAndroidBackComponent._ClassPtr;
		}

		// Token: 0x060095F1 RID: 38385 RVA: 0x000E251C File Offset: 0x000E071C
		public UUIAndroidBackComponent() : this(BuiltinUtils.AllocNativeUObject(UUIAndroidBackComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060095F2 RID: 38386 RVA: 0x000E2544 File Offset: 0x000E0744
		[NullableContext(1)]
		public UUIAndroidBackComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIAndroidBackComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001BD4 RID: 7124
		// (get) Token: 0x060095F3 RID: 38387 RVA: 0x000E2577 File Offset: 0x000E0777
		// (set) Token: 0x060095F4 RID: 38388 RVA: 0x000E258B File Offset: 0x000E078B
		public unsafe FVector2D ClickPivot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIAndroidBackComponent.__PropertyOffset_ClickPivot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIAndroidBackComponent.__PropertyOffset_ClickPivot) = value;
			}
		}

		// Token: 0x060095F5 RID: 38389 RVA: 0x000E25A0 File Offset: 0x000E07A0
		[NullableContext(2)]
		public static UUIAndroidBackComponent GetTopActiveAndroidBack()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIAndroidBackComponent>(UUIAndroidBackComponent.__GetTopActiveAndroidBack_Internal());
		}

		// Token: 0x060095F6 RID: 38390
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetActiveAndroidBackComponentSize();

		// Token: 0x060095F7 RID: 38391
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearAndroidBackComponent();

		// Token: 0x060095F8 RID: 38392
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTopActiveAndroidBack_Internal();

		// Token: 0x060095F9 RID: 38393 RVA: 0x000E25AC File Offset: 0x000E07AC
		static UUIAndroidBackComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIAndroidBackComponent");
		}

		// Token: 0x060095FA RID: 38394 RVA: 0x000E25BA File Offset: 0x000E07BA
		protected UUIAndroidBackComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004146 RID: 16710
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIAndroidBackComponent";

		// Token: 0x04004147 RID: 16711
		private static IntPtr _ClassPtr;

		// Token: 0x04004148 RID: 16712
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004149 RID: 16713
		internal static int __PropertyOffset_ClickPivot;
	}
}
