using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000FD RID: 253
	[UnrealObjectPath("/Script/AIModule.AISenseBlueprintListener")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UAISenseBlueprintListener : UUserDefinedStruct, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001373 RID: 4979 RVA: 0x0001CB52 File Offset: 0x0001AD52
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISenseBlueprintListener._ClassPtr;
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x0001CB60 File Offset: 0x0001AD60
		public UAISenseBlueprintListener() : this(BuiltinUtils.AllocNativeUObject(UAISenseBlueprintListener.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x0001CB88 File Offset: 0x0001AD88
		[NullableContext(1)]
		public UAISenseBlueprintListener(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAISenseBlueprintListener.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x0001CBBB File Offset: 0x0001ADBB
		static UAISenseBlueprintListener()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISenseBlueprintListener");
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x0001CBC9 File Offset: 0x0001ADC9
		protected UAISenseBlueprintListener(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000390 RID: 912
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AISenseBlueprintListener";

		// Token: 0x04000391 RID: 913
		private static IntPtr _ClassPtr;

		// Token: 0x04000392 RID: 914
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
