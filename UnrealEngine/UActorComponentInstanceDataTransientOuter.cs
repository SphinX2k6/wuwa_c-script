using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007B5 RID: 1973
	[UnrealObjectPath("/Script/Engine.ActorComponentInstanceDataTransientOuter")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UActorComponentInstanceDataTransientOuter : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060069A4 RID: 27044 RVA: 0x00097B64 File Offset: 0x00095D64
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActorComponentInstanceDataTransientOuter._ClassPtr;
		}

		// Token: 0x060069A5 RID: 27045 RVA: 0x00097B70 File Offset: 0x00095D70
		public UActorComponentInstanceDataTransientOuter() : this(BuiltinUtils.AllocNativeUObject(UActorComponentInstanceDataTransientOuter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060069A6 RID: 27046 RVA: 0x00097B98 File Offset: 0x00095D98
		[NullableContext(1)]
		public UActorComponentInstanceDataTransientOuter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActorComponentInstanceDataTransientOuter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060069A7 RID: 27047 RVA: 0x00097BCB File Offset: 0x00095DCB
		static UActorComponentInstanceDataTransientOuter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ActorComponentInstanceDataTransientOuter");
		}

		// Token: 0x060069A8 RID: 27048 RVA: 0x00097BD9 File Offset: 0x00095DD9
		protected UActorComponentInstanceDataTransientOuter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040032EF RID: 13039
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ActorComponentInstanceDataTransientOuter";

		// Token: 0x040032F0 RID: 13040
		private static IntPtr _ClassPtr;

		// Token: 0x040032F1 RID: 13041
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
