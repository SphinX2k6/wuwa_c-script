using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002173 RID: 8563
	[UnrealObjectPath("/Script/LGUI.UIGeometryModifierBase")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public abstract class UUIGeometryModifierBase : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020540 RID: 132416 RVA: 0x0030024F File Offset: 0x002FE44F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIGeometryModifierBase._ClassPtr;
		}

		// Token: 0x17007EBB RID: 32443
		// (get) Token: 0x06020541 RID: 132417 RVA: 0x0030025B File Offset: 0x002FE45B
		// (set) Token: 0x06020542 RID: 132418 RVA: 0x0030026B File Offset: 0x002FE46B
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

		// Token: 0x17007EBC RID: 32444
		// (get) Token: 0x06020543 RID: 132419 RVA: 0x0030027C File Offset: 0x002FE47C
		// (set) Token: 0x06020544 RID: 132420 RVA: 0x00300290 File Offset: 0x002FE490
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

		// Token: 0x17007EBD RID: 32445
		// (get) Token: 0x06020545 RID: 132421 RVA: 0x003002A5 File Offset: 0x002FE4A5
		// (set) Token: 0x06020546 RID: 132422 RVA: 0x003002B5 File Offset: 0x002FE4B5
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

		// Token: 0x06020547 RID: 132423 RVA: 0x003002C6 File Offset: 0x002FE4C6
		public void SetModifierEnable(bool bNewEnabled)
		{
			UUIGeometryModifierBase.__SetModifierEnable_Internal(base.NativePtr, bNewEnabled);
		}

		// Token: 0x06020548 RID: 132424 RVA: 0x003002D4 File Offset: 0x002FE4D4
		public bool GetModifierEnable()
		{
			return UUIGeometryModifierBase.__GetModifierEnable_Internal(base.NativePtr);
		}

		// Token: 0x06020549 RID: 132425
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetModifierEnable_Internal(IntPtr @this, bool bNewEnabled);

		// Token: 0x0602054A RID: 132426
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetModifierEnable_Internal(IntPtr @this);

		// Token: 0x0602054B RID: 132427 RVA: 0x003002E1 File Offset: 0x002FE4E1
		static UUIGeometryModifierBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIGeometryModifierBase");
		}

		// Token: 0x0602054C RID: 132428 RVA: 0x003002F0 File Offset: 0x002FE4F0
		protected UUIGeometryModifierBase() : this(BuiltinUtils.AllocNativeUObject(UUIGeometryModifierBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602054D RID: 132429 RVA: 0x00300318 File Offset: 0x002FE518
		protected UUIGeometryModifierBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040115E3 RID: 71139
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIGeometryModifierBase";

		// Token: 0x040115E4 RID: 71140
		private static IntPtr _ClassPtr;

		// Token: 0x040115E5 RID: 71141
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040115E6 RID: 71142
		internal static int __PropertyOffset_executeOrder;

		// Token: 0x040115E7 RID: 71143
		internal static int __PropertyOffset_componentName;

		// Token: 0x040115E8 RID: 71144
		internal static int __PropertyOffset_bModifierEnabled;
	}
}
