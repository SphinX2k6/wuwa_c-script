using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021D6 RID: 8662
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UITextureBase_BP")]
	[UnrealStructLayout(2272, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2272)]
	public abstract class UUITextureBase_BP : UUITextureBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021031 RID: 135217 RVA: 0x0030B421 File Offset: 0x00309621
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUITextureBase_BP._ClassPtr;
		}

		// Token: 0x170080DE RID: 32990
		// (get) Token: 0x06021032 RID: 135218 RVA: 0x0030B42D File Offset: 0x0030962D
		// (set) Token: 0x06021033 RID: 135219 RVA: 0x0030B441 File Offset: 0x00309641
		public unsafe ULGUICreateGeometryHelper createGeometryHelper
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUICreateGeometryHelper>(base.NativePtr / (IntPtr)sizeof(void*) + UUITextureBase_BP.__PropertyOffset_createGeometryHelper);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUITextureBase_BP.__PropertyOffset_createGeometryHelper, value);
			}
		}

		// Token: 0x170080DF RID: 32991
		// (get) Token: 0x06021034 RID: 135220 RVA: 0x0030B456 File Offset: 0x00309656
		// (set) Token: 0x06021035 RID: 135221 RVA: 0x0030B46A File Offset: 0x0030966A
		public unsafe ULGUIUpdateGeometryHelper updateGeometryHelper
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUIUpdateGeometryHelper>(base.NativePtr / (IntPtr)sizeof(void*) + UUITextureBase_BP.__PropertyOffset_updateGeometryHelper);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUITextureBase_BP.__PropertyOffset_updateGeometryHelper, value);
			}
		}

		// Token: 0x06021036 RID: 135222 RVA: 0x0030B47F File Offset: 0x0030967F
		public virtual void OnUpdateGeometry_BP(ULGUIUpdateGeometryHelper InUpdateGoemetryHelper, bool InVertexPositionChanged, bool InVertexUVChanged, bool InVertexColorChanged)
		{
			UUITextureBase_BP.__OnUpdateGeometry_BP_Internal(base.NativePtr, (InUpdateGoemetryHelper != null) ? InUpdateGoemetryHelper.NativePtr : IntPtr.Zero, InVertexPositionChanged, InVertexUVChanged, InVertexColorChanged);
		}

		// Token: 0x06021037 RID: 135223 RVA: 0x0030B4A0 File Offset: 0x003096A0
		public virtual void OnCreateGeometry_BP(ULGUICreateGeometryHelper InCreateGeometryHelper)
		{
			UUITextureBase_BP.__OnCreateGeometry_BP_Internal(base.NativePtr, (InCreateGeometryHelper != null) ? InCreateGeometryHelper.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06021038 RID: 135224 RVA: 0x0030B4BD File Offset: 0x003096BD
		public virtual void OnBeforeCreateOrUpdateGeometry_BP()
		{
			UUITextureBase_BP.__OnBeforeCreateOrUpdateGeometry_BP_Internal(base.NativePtr);
		}

		// Token: 0x06021039 RID: 135225 RVA: 0x0030B4CA File Offset: 0x003096CA
		public void MarkVertexChanged_BP()
		{
			UUITextureBase_BP.__MarkVertexChanged_BP_Internal(base.NativePtr);
		}

		// Token: 0x0602103A RID: 135226 RVA: 0x0030B4D7 File Offset: 0x003096D7
		public void MarkRebuildGeometry_BP()
		{
			UUITextureBase_BP.__MarkRebuildGeometry_BP_Internal(base.NativePtr);
		}

		// Token: 0x0602103B RID: 135227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUpdateGeometry_BP_Internal(IntPtr @this, IntPtr InUpdateGoemetryHelper, bool InVertexPositionChanged, bool InVertexUVChanged, bool InVertexColorChanged);

		// Token: 0x0602103C RID: 135228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnCreateGeometry_BP_Internal(IntPtr @this, IntPtr InCreateGeometryHelper);

		// Token: 0x0602103D RID: 135229
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnBeforeCreateOrUpdateGeometry_BP_Internal(IntPtr @this);

		// Token: 0x0602103E RID: 135230
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkVertexChanged_BP_Internal(IntPtr @this);

		// Token: 0x0602103F RID: 135231
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkRebuildGeometry_BP_Internal(IntPtr @this);

		// Token: 0x06021040 RID: 135232 RVA: 0x0030B4E4 File Offset: 0x003096E4
		static UUITextureBase_BP()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITextureBase_BP");
		}

		// Token: 0x06021041 RID: 135233 RVA: 0x0030B4F4 File Offset: 0x003096F4
		protected UUITextureBase_BP() : this(BuiltinUtils.AllocNativeUObject(UUITextureBase_BP.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021042 RID: 135234 RVA: 0x0030B51C File Offset: 0x0030971C
		protected UUITextureBase_BP(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040119DE RID: 72158
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UITextureBase_BP";

		// Token: 0x040119DF RID: 72159
		private static IntPtr _ClassPtr;

		// Token: 0x040119E0 RID: 72160
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040119E1 RID: 72161
		internal static int __PropertyOffset_createGeometryHelper;

		// Token: 0x040119E2 RID: 72162
		internal static int __PropertyOffset_updateGeometryHelper;

		// Token: 0x0200350A RID: 13578
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnUpdateGeometry_BP_FunctionParams
		{
			// Token: 0x04017539 RID: 95545
			[FieldOffset(0)]
			public IntPtr InUpdateGoemetryHelper;

			// Token: 0x0401753A RID: 95546
			[FieldOffset(8)]
			public bool InVertexPositionChanged;

			// Token: 0x0401753B RID: 95547
			[FieldOffset(9)]
			public bool InVertexUVChanged;

			// Token: 0x0401753C RID: 95548
			[FieldOffset(10)]
			public bool InVertexColorChanged;
		}

		// Token: 0x0200350B RID: 13579
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnCreateGeometry_BP_FunctionParams
		{
			// Token: 0x0401753D RID: 95549
			[FieldOffset(0)]
			public IntPtr InCreateGeometryHelper;
		}
	}
}
