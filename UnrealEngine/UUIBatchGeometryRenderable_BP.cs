using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002130 RID: 8496
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIBatchGeometryRenderable_BP")]
	[UnrealStructLayout(2208, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2208)]
	public abstract class UUIBatchGeometryRenderable_BP : UUIBatchGeometryRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FFBB RID: 131003 RVA: 0x002F8E2D File Offset: 0x002F702D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIBatchGeometryRenderable_BP._ClassPtr;
		}

		// Token: 0x17007DA8 RID: 32168
		// (get) Token: 0x0601FFBC RID: 131004 RVA: 0x002F8E39 File Offset: 0x002F7039
		// (set) Token: 0x0601FFBD RID: 131005 RVA: 0x002F8E4D File Offset: 0x002F704D
		public unsafe ULGUICreateGeometryHelper createGeometryHelper
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUICreateGeometryHelper>(base.NativePtr / (IntPtr)sizeof(void*) + UUIBatchGeometryRenderable_BP.__PropertyOffset_createGeometryHelper);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIBatchGeometryRenderable_BP.__PropertyOffset_createGeometryHelper, value);
			}
		}

		// Token: 0x17007DA9 RID: 32169
		// (get) Token: 0x0601FFBE RID: 131006 RVA: 0x002F8E62 File Offset: 0x002F7062
		// (set) Token: 0x0601FFBF RID: 131007 RVA: 0x002F8E76 File Offset: 0x002F7076
		public unsafe ULGUIUpdateGeometryHelper updateGeometryHelper
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUIUpdateGeometryHelper>(base.NativePtr / (IntPtr)sizeof(void*) + UUIBatchGeometryRenderable_BP.__PropertyOffset_updateGeometryHelper);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIBatchGeometryRenderable_BP.__PropertyOffset_updateGeometryHelper, value);
			}
		}

		// Token: 0x0601FFC0 RID: 131008 RVA: 0x002F8E8B File Offset: 0x002F708B
		public virtual void OnUpdateGeometry_BP(ULGUIUpdateGeometryHelper InUpdateGoemetryHelper, bool InVertexPositionChanged, bool InVertexUVChanged, bool InVertexColorChanged)
		{
			UUIBatchGeometryRenderable_BP.__OnUpdateGeometry_BP_Internal(base.NativePtr, (InUpdateGoemetryHelper != null) ? InUpdateGoemetryHelper.NativePtr : IntPtr.Zero, InVertexPositionChanged, InVertexUVChanged, InVertexColorChanged);
		}

		// Token: 0x0601FFC1 RID: 131009 RVA: 0x002F8EAC File Offset: 0x002F70AC
		public virtual void OnCreateGeometry_BP(ULGUICreateGeometryHelper InCreateGeometryHelper)
		{
			UUIBatchGeometryRenderable_BP.__OnCreateGeometry_BP_Internal(base.NativePtr, (InCreateGeometryHelper != null) ? InCreateGeometryHelper.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601FFC2 RID: 131010 RVA: 0x002F8EC9 File Offset: 0x002F70C9
		public virtual void OnBeforeCreateOrUpdateGeometry_BP()
		{
			UUIBatchGeometryRenderable_BP.__OnBeforeCreateOrUpdateGeometry_BP_Internal(base.NativePtr);
		}

		// Token: 0x0601FFC3 RID: 131011 RVA: 0x002F8ED6 File Offset: 0x002F70D6
		public void MarkVertexChanged_BP()
		{
			UUIBatchGeometryRenderable_BP.__MarkVertexChanged_BP_Internal(base.NativePtr);
		}

		// Token: 0x0601FFC4 RID: 131012 RVA: 0x002F8EE3 File Offset: 0x002F70E3
		public void MarkRebuildGeometry_BP()
		{
			UUIBatchGeometryRenderable_BP.__MarkRebuildGeometry_BP_Internal(base.NativePtr);
		}

		// Token: 0x0601FFC5 RID: 131013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUpdateGeometry_BP_Internal(IntPtr @this, IntPtr InUpdateGoemetryHelper, bool InVertexPositionChanged, bool InVertexUVChanged, bool InVertexColorChanged);

		// Token: 0x0601FFC6 RID: 131014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnCreateGeometry_BP_Internal(IntPtr @this, IntPtr InCreateGeometryHelper);

		// Token: 0x0601FFC7 RID: 131015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnBeforeCreateOrUpdateGeometry_BP_Internal(IntPtr @this);

		// Token: 0x0601FFC8 RID: 131016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkVertexChanged_BP_Internal(IntPtr @this);

		// Token: 0x0601FFC9 RID: 131017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkRebuildGeometry_BP_Internal(IntPtr @this);

		// Token: 0x0601FFCA RID: 131018 RVA: 0x002F8EF0 File Offset: 0x002F70F0
		static UUIBatchGeometryRenderable_BP()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIBatchGeometryRenderable_BP");
		}

		// Token: 0x0601FFCB RID: 131019 RVA: 0x002F8F00 File Offset: 0x002F7100
		protected UUIBatchGeometryRenderable_BP() : this(BuiltinUtils.AllocNativeUObject(UUIBatchGeometryRenderable_BP.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FFCC RID: 131020 RVA: 0x002F8F28 File Offset: 0x002F7128
		protected UUIBatchGeometryRenderable_BP(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401137E RID: 70526
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIBatchGeometryRenderable_BP";

		// Token: 0x0401137F RID: 70527
		private static IntPtr _ClassPtr;

		// Token: 0x04011380 RID: 70528
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011381 RID: 70529
		internal static int __PropertyOffset_createGeometryHelper;

		// Token: 0x04011382 RID: 70530
		internal static int __PropertyOffset_updateGeometryHelper;

		// Token: 0x020034EF RID: 13551
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnUpdateGeometry_BP_FunctionParams
		{
			// Token: 0x0401750F RID: 95503
			[FieldOffset(0)]
			public IntPtr InUpdateGoemetryHelper;

			// Token: 0x04017510 RID: 95504
			[FieldOffset(8)]
			public bool InVertexPositionChanged;

			// Token: 0x04017511 RID: 95505
			[FieldOffset(9)]
			public bool InVertexUVChanged;

			// Token: 0x04017512 RID: 95506
			[FieldOffset(10)]
			public bool InVertexColorChanged;
		}

		// Token: 0x020034F0 RID: 13552
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnCreateGeometry_BP_FunctionParams
		{
			// Token: 0x04017513 RID: 95507
			[FieldOffset(0)]
			public IntPtr InCreateGeometryHelper;
		}
	}
}
