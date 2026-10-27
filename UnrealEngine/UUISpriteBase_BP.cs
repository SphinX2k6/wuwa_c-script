using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021BD RID: 8637
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISpriteBase_BP")]
	[UnrealStructLayout(2240, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2240)]
	public abstract class UUISpriteBase_BP : UUISpriteBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020DFB RID: 134651 RVA: 0x00308EA9 File Offset: 0x003070A9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISpriteBase_BP._ClassPtr;
		}

		// Token: 0x17008066 RID: 32870
		// (get) Token: 0x06020DFC RID: 134652 RVA: 0x00308EB5 File Offset: 0x003070B5
		// (set) Token: 0x06020DFD RID: 134653 RVA: 0x00308EC9 File Offset: 0x003070C9
		public unsafe ULGUICreateGeometryHelper createGeometryHelper
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUICreateGeometryHelper>(base.NativePtr / (IntPtr)sizeof(void*) + UUISpriteBase_BP.__PropertyOffset_createGeometryHelper);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISpriteBase_BP.__PropertyOffset_createGeometryHelper, value);
			}
		}

		// Token: 0x17008067 RID: 32871
		// (get) Token: 0x06020DFE RID: 134654 RVA: 0x00308EDE File Offset: 0x003070DE
		// (set) Token: 0x06020DFF RID: 134655 RVA: 0x00308EF2 File Offset: 0x003070F2
		public unsafe ULGUIUpdateGeometryHelper updateGeometryHelper
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUIUpdateGeometryHelper>(base.NativePtr / (IntPtr)sizeof(void*) + UUISpriteBase_BP.__PropertyOffset_updateGeometryHelper);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISpriteBase_BP.__PropertyOffset_updateGeometryHelper, value);
			}
		}

		// Token: 0x06020E00 RID: 134656 RVA: 0x00308F07 File Offset: 0x00307107
		public virtual void OnUpdateGeometry_BP(ULGUIUpdateGeometryHelper InUpdateGoemetryHelper, ULGUISpriteData_BaseObject InSpriteData, bool InVertexPositionChanged, bool InVertexUVChanged, bool InVertexColorChanged)
		{
			UUISpriteBase_BP.__OnUpdateGeometry_BP_Internal(base.NativePtr, (InUpdateGoemetryHelper != null) ? InUpdateGoemetryHelper.NativePtr : IntPtr.Zero, (InSpriteData != null) ? InSpriteData.NativePtr : IntPtr.Zero, InVertexPositionChanged, InVertexUVChanged, InVertexColorChanged);
		}

		// Token: 0x06020E01 RID: 134657 RVA: 0x00308F39 File Offset: 0x00307139
		public virtual void OnCreateGeometry_BP(ULGUICreateGeometryHelper InCreateGeometryHelper, ULGUISpriteData_BaseObject InSpriteData)
		{
			UUISpriteBase_BP.__OnCreateGeometry_BP_Internal(base.NativePtr, (InCreateGeometryHelper != null) ? InCreateGeometryHelper.NativePtr : IntPtr.Zero, (InSpriteData != null) ? InSpriteData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020E02 RID: 134658 RVA: 0x00308F66 File Offset: 0x00307166
		public virtual void OnBeforeCreateOrUpdateGeometry_BP()
		{
			UUISpriteBase_BP.__OnBeforeCreateOrUpdateGeometry_BP_Internal(base.NativePtr);
		}

		// Token: 0x06020E03 RID: 134659 RVA: 0x00308F73 File Offset: 0x00307173
		public void MarkVertexChanged_BP()
		{
			UUISpriteBase_BP.__MarkVertexChanged_BP_Internal(base.NativePtr);
		}

		// Token: 0x06020E04 RID: 134660 RVA: 0x00308F80 File Offset: 0x00307180
		public void MarkRebuildGeometry_BP()
		{
			UUISpriteBase_BP.__MarkRebuildGeometry_BP_Internal(base.NativePtr);
		}

		// Token: 0x06020E05 RID: 134661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUpdateGeometry_BP_Internal(IntPtr @this, IntPtr InUpdateGoemetryHelper, IntPtr InSpriteData, bool InVertexPositionChanged, bool InVertexUVChanged, bool InVertexColorChanged);

		// Token: 0x06020E06 RID: 134662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnCreateGeometry_BP_Internal(IntPtr @this, IntPtr InCreateGeometryHelper, IntPtr InSpriteData);

		// Token: 0x06020E07 RID: 134663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnBeforeCreateOrUpdateGeometry_BP_Internal(IntPtr @this);

		// Token: 0x06020E08 RID: 134664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkVertexChanged_BP_Internal(IntPtr @this);

		// Token: 0x06020E09 RID: 134665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkRebuildGeometry_BP_Internal(IntPtr @this);

		// Token: 0x06020E0A RID: 134666 RVA: 0x00308F8D File Offset: 0x0030718D
		static UUISpriteBase_BP()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISpriteBase_BP");
		}

		// Token: 0x06020E0B RID: 134667 RVA: 0x00308F9C File Offset: 0x0030719C
		protected UUISpriteBase_BP() : this(BuiltinUtils.AllocNativeUObject(UUISpriteBase_BP.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020E0C RID: 134668 RVA: 0x00308FC4 File Offset: 0x003071C4
		protected UUISpriteBase_BP(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040118DF RID: 71903
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISpriteBase_BP";

		// Token: 0x040118E0 RID: 71904
		private static IntPtr _ClassPtr;

		// Token: 0x040118E1 RID: 71905
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040118E2 RID: 71906
		internal static int __PropertyOffset_createGeometryHelper;

		// Token: 0x040118E3 RID: 71907
		internal static int __PropertyOffset_updateGeometryHelper;

		// Token: 0x02003508 RID: 13576
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnUpdateGeometry_BP_FunctionParams
		{
			// Token: 0x04017532 RID: 95538
			[FieldOffset(0)]
			public IntPtr InUpdateGoemetryHelper;

			// Token: 0x04017533 RID: 95539
			[FieldOffset(8)]
			public IntPtr InSpriteData;

			// Token: 0x04017534 RID: 95540
			[FieldOffset(16)]
			public bool InVertexPositionChanged;

			// Token: 0x04017535 RID: 95541
			[FieldOffset(17)]
			public bool InVertexUVChanged;

			// Token: 0x04017536 RID: 95542
			[FieldOffset(18)]
			public bool InVertexColorChanged;
		}

		// Token: 0x02003509 RID: 13577
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnCreateGeometry_BP_FunctionParams
		{
			// Token: 0x04017537 RID: 95543
			[FieldOffset(0)]
			public IntPtr InCreateGeometryHelper;

			// Token: 0x04017538 RID: 95544
			[FieldOffset(8)]
			public IntPtr InSpriteData;
		}
	}
}
