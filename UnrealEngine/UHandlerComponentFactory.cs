using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200262F RID: 9775
	[UnrealObjectPath("/Script/PacketHandler.HandlerComponentFactory")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UHandlerComponentFactory : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060245AC RID: 148908 RVA: 0x0035D355 File Offset: 0x0035B555
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHandlerComponentFactory._ClassPtr;
		}

		// Token: 0x060245AD RID: 148909 RVA: 0x0035D364 File Offset: 0x0035B564
		public UHandlerComponentFactory() : this(BuiltinUtils.AllocNativeUObject(UHandlerComponentFactory.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060245AE RID: 148910 RVA: 0x0035D38C File Offset: 0x0035B58C
		[NullableContext(1)]
		public UHandlerComponentFactory(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHandlerComponentFactory.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060245AF RID: 148911 RVA: 0x0035D3BF File Offset: 0x0035B5BF
		static UHandlerComponentFactory()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PacketHandler.HandlerComponentFactory");
		}

		// Token: 0x060245B0 RID: 148912 RVA: 0x0035D3CD File Offset: 0x0035B5CD
		protected UHandlerComponentFactory(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013814 RID: 79892
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/PacketHandler.HandlerComponentFactory";

		// Token: 0x04013815 RID: 79893
		private static IntPtr _ClassPtr;

		// Token: 0x04013816 RID: 79894
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
