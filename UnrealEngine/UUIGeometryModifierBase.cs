using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000706 RID: 1798
	[UnrealObjectPath("/Script/LGUI.UIGeometryModifierBase")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public abstract class UUIGeometryModifierBase : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600990B RID: 39179 RVA: 0x000E68B9 File Offset: 0x000E4AB9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIGeometryModifierBase._ClassPtr;
		}

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x0600990C RID: 39180 RVA: 0x000E68C5 File Offset: 0x000E4AC5
		// (set) Token: 0x0600990D RID: 39181 RVA: 0x000E68D5 File Offset: 0x000E4AD5
		public unsafe int executeOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGeometryModifierBase.__PropertyOffset_executeOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGeometryModifierBase.__PropertyOffset_executeOrder) = value;
			}
		}

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x0600990E RID: 39182 RVA: 0x000E68E6 File Offset: 0x000E4AE6
		// (set) Token: 0x0600990F RID: 39183 RVA: 0x000E68FA File Offset: 0x000E4AFA
		public unsafe FName componentName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGeometryModifierBase.__PropertyOffset_componentName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGeometryModifierBase.__PropertyOffset_componentName) = value;
			}
		}

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x06009910 RID: 39184 RVA: 0x000E690F File Offset: 0x000E4B0F
		// (set) Token: 0x06009911 RID: 39185 RVA: 0x000E691F File Offset: 0x000E4B1F
		public unsafe bool bModifierEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGeometryModifierBase.__PropertyOffset_bModifierEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGeometryModifierBase.__PropertyOffset_bModifierEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x06009912 RID: 39186 RVA: 0x000E6930 File Offset: 0x000E4B30
		public void SetModifierEnable(bool bNewEnabled)
		{
			UUIGeometryModifierBase.__SetModifierEnable_Internal(base.NativePtr, bNewEnabled);
		}

		// Token: 0x06009913 RID: 39187 RVA: 0x000E693E File Offset: 0x000E4B3E
		public bool GetModifierEnable()
		{
			return UUIGeometryModifierBase.__GetModifierEnable_Internal(base.NativePtr);
		}

		// Token: 0x06009914 RID: 39188
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetModifierEnable_Internal(IntPtr @this, bool bNewEnabled);

		// Token: 0x06009915 RID: 39189
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetModifierEnable_Internal(IntPtr @this);

		// Token: 0x06009916 RID: 39190 RVA: 0x000E694B File Offset: 0x000E4B4B
		static UUIGeometryModifierBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIGeometryModifierBase");
		}

		// Token: 0x06009917 RID: 39191 RVA: 0x000E695C File Offset: 0x000E4B5C
		protected UUIGeometryModifierBase() : this(BuiltinUtils.AllocNativeUObject(UUIGeometryModifierBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009918 RID: 39192 RVA: 0x000E6984 File Offset: 0x000E4B84
		protected UUIGeometryModifierBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400428D RID: 17037
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIGeometryModifierBase";

		// Token: 0x0400428E RID: 17038
		private static IntPtr _ClassPtr;

		// Token: 0x0400428F RID: 17039
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004290 RID: 17040
		internal static int __PropertyOffset_executeOrder;

		// Token: 0x04004291 RID: 17041
		internal static int __PropertyOffset_componentName;

		// Token: 0x04004292 RID: 17042
		internal static int __PropertyOffset_bModifierEnabled;
	}
}
