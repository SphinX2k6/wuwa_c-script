using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002120 RID: 8480
	[UnrealObjectPath("/Script/LGUI.UIAndroidBackComponent")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UUIAndroidBackComponent : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FE63 RID: 130659 RVA: 0x002F7455 File Offset: 0x002F5655
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIAndroidBackComponent._ClassPtr;
		}

		// Token: 0x0601FE64 RID: 130660 RVA: 0x002F7464 File Offset: 0x002F5664
		public UUIAndroidBackComponent() : this(BuiltinUtils.AllocNativeUObject(UUIAndroidBackComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FE65 RID: 130661 RVA: 0x002F748C File Offset: 0x002F568C
		[NullableContext(1)]
		public UUIAndroidBackComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIAndroidBackComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007D70 RID: 32112
		// (get) Token: 0x0601FE66 RID: 130662 RVA: 0x002F74BF File Offset: 0x002F56BF
		// (set) Token: 0x0601FE67 RID: 130663 RVA: 0x002F74D3 File Offset: 0x002F56D3
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

		// Token: 0x0601FE68 RID: 130664 RVA: 0x002F74E8 File Offset: 0x002F56E8
		[NullableContext(2)]
		public static UUIAndroidBackComponent GetTopActiveAndroidBack()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIAndroidBackComponent>(UUIAndroidBackComponent.__GetTopActiveAndroidBack_Internal());
		}

		// Token: 0x0601FE69 RID: 130665
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetActiveAndroidBackComponentSize();

		// Token: 0x0601FE6A RID: 130666
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearAndroidBackComponent();

		// Token: 0x0601FE6B RID: 130667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTopActiveAndroidBack_Internal();

		// Token: 0x0601FE6C RID: 130668 RVA: 0x002F74F4 File Offset: 0x002F56F4
		static UUIAndroidBackComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIAndroidBackComponent");
		}

		// Token: 0x0601FE6D RID: 130669 RVA: 0x002F7502 File Offset: 0x002F5702
		protected UUIAndroidBackComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011305 RID: 70405
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIAndroidBackComponent";

		// Token: 0x04011306 RID: 70406
		private static IntPtr _ClassPtr;

		// Token: 0x04011307 RID: 70407
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011308 RID: 70408
		internal static int __PropertyOffset_ClickPivot;
	}
}
