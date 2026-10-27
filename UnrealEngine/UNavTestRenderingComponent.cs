using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024A8 RID: 9384
	[UnrealObjectPath("/Script/NavigationSystem.NavTestRenderingComponent")]
	[UnrealStructLayout(1776, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1776)]
	public class UNavTestRenderingComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060231D5 RID: 143829 RVA: 0x0033ED75 File Offset: 0x0033CF75
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavTestRenderingComponent._ClassPtr;
		}

		// Token: 0x060231D6 RID: 143830 RVA: 0x0033ED84 File Offset: 0x0033CF84
		public UNavTestRenderingComponent() : this(BuiltinUtils.AllocNativeUObject(UNavTestRenderingComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060231D7 RID: 143831 RVA: 0x0033EDAC File Offset: 0x0033CFAC
		[NullableContext(1)]
		public UNavTestRenderingComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavTestRenderingComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060231D8 RID: 143832 RVA: 0x0033EDDF File Offset: 0x0033CFDF
		static UNavTestRenderingComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavTestRenderingComponent");
		}

		// Token: 0x060231D9 RID: 143833 RVA: 0x0033EDED File Offset: 0x0033CFED
		protected UNavTestRenderingComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012BF1 RID: 76785
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavTestRenderingComponent";

		// Token: 0x04012BF2 RID: 76786
		private static IntPtr _ClassPtr;

		// Token: 0x04012BF3 RID: 76787
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
