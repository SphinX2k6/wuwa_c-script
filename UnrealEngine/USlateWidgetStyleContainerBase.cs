using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002831 RID: 10289
	[UnrealObjectPath("/Script/SlateCore.SlateWidgetStyleContainerBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class USlateWidgetStyleContainerBase : UObject, IUnrealUObject, IUnrealObject, ISlateWidgetStyleContainerInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060263B2 RID: 156594 RVA: 0x003A065F File Offset: 0x0039E85F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USlateWidgetStyleContainerBase._ClassPtr;
		}

		// Token: 0x060263B3 RID: 156595 RVA: 0x003A066B File Offset: 0x0039E86B
		int ISlateWidgetStyleContainerInterface.InterfaceOffset()
		{
			return USlateWidgetStyleContainerBase.__InterfaceOffset_ISlateWidgetStyleContainerInterface;
		}

		// Token: 0x060263B4 RID: 156596 RVA: 0x003A0674 File Offset: 0x0039E874
		public USlateWidgetStyleContainerBase() : this(BuiltinUtils.AllocNativeUObject(USlateWidgetStyleContainerBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060263B5 RID: 156597 RVA: 0x003A069C File Offset: 0x0039E89C
		[NullableContext(1)]
		public USlateWidgetStyleContainerBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USlateWidgetStyleContainerBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060263B6 RID: 156598 RVA: 0x003A06CF File Offset: 0x0039E8CF
		static USlateWidgetStyleContainerBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SlateCore.SlateWidgetStyleContainerBase");
		}

		// Token: 0x060263B7 RID: 156599 RVA: 0x003A06DD File Offset: 0x0039E8DD
		protected USlateWidgetStyleContainerBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014ECA RID: 85706
		internal static int __InterfaceOffset_ISlateWidgetStyleContainerInterface;

		// Token: 0x04014ECB RID: 85707
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SlateCore.SlateWidgetStyleContainerBase";

		// Token: 0x04014ECC RID: 85708
		private static IntPtr _ClassPtr;

		// Token: 0x04014ECD RID: 85709
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
