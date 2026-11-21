using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000247 RID: 583
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.NavigationObjectBase")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public abstract class ANavigationObjectBase : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600326C RID: 12908 RVA: 0x00047F01 File Offset: 0x00046101
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ANavigationObjectBase._ClassPtr;
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x0600326D RID: 12909 RVA: 0x00047F0D File Offset: 0x0004610D
		// (set) Token: 0x0600326E RID: 12910 RVA: 0x00047F21 File Offset: 0x00046121
		public unsafe UCapsuleComponent CapsuleComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationObjectBase.__PropertyOffset_CapsuleComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationObjectBase.__PropertyOffset_CapsuleComponent, value);
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x0600326F RID: 12911 RVA: 0x00047F36 File Offset: 0x00046136
		// (set) Token: 0x06003270 RID: 12912 RVA: 0x00047F4A File Offset: 0x0004614A
		public unsafe UBillboardComponent GoodSprite
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationObjectBase.__PropertyOffset_GoodSprite);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationObjectBase.__PropertyOffset_GoodSprite, value);
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06003271 RID: 12913 RVA: 0x00047F5F File Offset: 0x0004615F
		// (set) Token: 0x06003272 RID: 12914 RVA: 0x00047F73 File Offset: 0x00046173
		public unsafe UBillboardComponent BadSprite
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBillboardComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationObjectBase.__PropertyOffset_BadSprite);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ANavigationObjectBase.__PropertyOffset_BadSprite, value);
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06003273 RID: 12915 RVA: 0x00047F88 File Offset: 0x00046188
		// (set) Token: 0x06003274 RID: 12916 RVA: 0x00047FA1 File Offset: 0x000461A1
		public unsafe bool bIsPIEPlayerStart
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ANavigationObjectBase.__PropertyOffset_bIsPIEPlayerStart) & ANavigationObjectBase.__PropertyMask_bIsPIEPlayerStart) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ANavigationObjectBase.__PropertyOffset_bIsPIEPlayerStart) = ((*(base.NativePtr + (IntPtr)ANavigationObjectBase.__PropertyOffset_bIsPIEPlayerStart) & ~ANavigationObjectBase.__PropertyMask_bIsPIEPlayerStart) | (value ? ANavigationObjectBase.__PropertyMask_bIsPIEPlayerStart : 0));
			}
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x00047FD1 File Offset: 0x000461D1
		static ANavigationObjectBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NavigationObjectBase");
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x00047FE0 File Offset: 0x000461E0
		protected ANavigationObjectBase() : this(BuiltinUtils.AllocNativeUObject(ANavigationObjectBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x00048008 File Offset: 0x00046208
		protected ANavigationObjectBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400118F RID: 4495
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.NavigationObjectBase";

		// Token: 0x04001190 RID: 4496
		private static IntPtr _ClassPtr;

		// Token: 0x04001191 RID: 4497
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001192 RID: 4498
		internal static int __PropertyOffset_CapsuleComponent;

		// Token: 0x04001193 RID: 4499
		internal static int __PropertyOffset_GoodSprite;

		// Token: 0x04001194 RID: 4500
		internal static int __PropertyOffset_BadSprite;

		// Token: 0x04001195 RID: 4501
		internal static int __PropertyOffset_bIsPIEPlayerStart;

		// Token: 0x04001196 RID: 4502
		internal static byte __PropertyMask_bIsPIEPlayerStart;
	}
}
