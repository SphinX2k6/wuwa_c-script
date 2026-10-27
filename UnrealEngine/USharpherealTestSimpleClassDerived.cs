using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002739 RID: 10041
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestSimpleClassDerived")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class USharpherealTestSimpleClassDerived : USharpherealTestSimpleClass, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060252C4 RID: 152260 RVA: 0x0037116C File Offset: 0x0036F36C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USharpherealTestSimpleClassDerived._ClassPtr;
		}

		// Token: 0x060252C5 RID: 152261 RVA: 0x00371178 File Offset: 0x0036F378
		public USharpherealTestSimpleClassDerived() : this(BuiltinUtils.AllocNativeUObject(USharpherealTestSimpleClassDerived.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060252C6 RID: 152262 RVA: 0x003711A0 File Offset: 0x0036F3A0
		[NullableContext(1)]
		public USharpherealTestSimpleClassDerived(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USharpherealTestSimpleClassDerived.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060252C7 RID: 152263 RVA: 0x003711D3 File Offset: 0x0036F3D3
		static USharpherealTestSimpleClassDerived()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.SharpherealTestSimpleClassDerived");
		}

		// Token: 0x060252C8 RID: 152264 RVA: 0x003711E1 File Offset: 0x0036F3E1
		protected USharpherealTestSimpleClassDerived(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401408F RID: 82063
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestSimpleClassDerived";

		// Token: 0x04014090 RID: 82064
		private static IntPtr _ClassPtr;

		// Token: 0x04014091 RID: 82065
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
