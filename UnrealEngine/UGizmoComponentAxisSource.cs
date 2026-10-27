using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001552 RID: 5458
	[UnrealObjectPath("/Script/InteractiveToolsFramework.GizmoComponentAxisSource")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UGizmoComponentAxisSource : UObject, IUnrealUObject, IUnrealObject, IGizmoAxisSource, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06013CA9 RID: 81065 RVA: 0x001D102F File Offset: 0x001CF22F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGizmoComponentAxisSource._ClassPtr;
		}

		// Token: 0x06013CAA RID: 81066 RVA: 0x001D103B File Offset: 0x001CF23B
		int IGizmoAxisSource.InterfaceOffset()
		{
			return UGizmoComponentAxisSource.__InterfaceOffset_IGizmoAxisSource;
		}

		// Token: 0x06013CAB RID: 81067 RVA: 0x001D1044 File Offset: 0x001CF244
		public UGizmoComponentAxisSource() : this(BuiltinUtils.AllocNativeUObject(UGizmoComponentAxisSource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013CAC RID: 81068 RVA: 0x001D106C File Offset: 0x001CF26C
		[NullableContext(1)]
		public UGizmoComponentAxisSource(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGizmoComponentAxisSource.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D88 RID: 19848
		// (get) Token: 0x06013CAD RID: 81069 RVA: 0x001D109F File Offset: 0x001CF29F
		// (set) Token: 0x06013CAE RID: 81070 RVA: 0x001D10B3 File Offset: 0x001CF2B3
		[Nullable(2)]
		public unsafe USceneComponent Component
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UGizmoComponentAxisSource.__PropertyOffset_Component);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGizmoComponentAxisSource.__PropertyOffset_Component, value);
			}
		}

		// Token: 0x17004D89 RID: 19849
		// (get) Token: 0x06013CAF RID: 81071 RVA: 0x001D10C8 File Offset: 0x001CF2C8
		// (set) Token: 0x06013CB0 RID: 81072 RVA: 0x001D10D8 File Offset: 0x001CF2D8
		public unsafe int AxisIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoComponentAxisSource.__PropertyOffset_AxisIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoComponentAxisSource.__PropertyOffset_AxisIndex) = value;
			}
		}

		// Token: 0x17004D8A RID: 19850
		// (get) Token: 0x06013CB1 RID: 81073 RVA: 0x001D10E9 File Offset: 0x001CF2E9
		// (set) Token: 0x06013CB2 RID: 81074 RVA: 0x001D10F9 File Offset: 0x001CF2F9
		public unsafe bool bLocalAxes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGizmoComponentAxisSource.__PropertyOffset_bLocalAxes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGizmoComponentAxisSource.__PropertyOffset_bLocalAxes) = (value ? 1 : 0);
			}
		}

		// Token: 0x06013CB3 RID: 81075 RVA: 0x001D110A File Offset: 0x001CF30A
		static UGizmoComponentAxisSource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.GizmoComponentAxisSource");
		}

		// Token: 0x06013CB4 RID: 81076 RVA: 0x001D1118 File Offset: 0x001CF318
		protected UGizmoComponentAxisSource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AB4E RID: 43854
		internal static int __InterfaceOffset_IGizmoAxisSource;

		// Token: 0x0400AB4F RID: 43855
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.GizmoComponentAxisSource";

		// Token: 0x0400AB50 RID: 43856
		private static IntPtr _ClassPtr;

		// Token: 0x0400AB51 RID: 43857
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AB52 RID: 43858
		internal static int __PropertyOffset_Component;

		// Token: 0x0400AB53 RID: 43859
		internal static int __PropertyOffset_AxisIndex;

		// Token: 0x0400AB54 RID: 43860
		internal static int __PropertyOffset_bLocalAxes;
	}
}
