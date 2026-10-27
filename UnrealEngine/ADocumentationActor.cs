using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009D7 RID: 2519
	[UnrealObjectPath("/Script/Engine.DocumentationActor")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class ADocumentationActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008E6D RID: 36461 RVA: 0x000CBB14 File Offset: 0x000C9D14
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ADocumentationActor._ClassPtr;
		}

		// Token: 0x06008E6E RID: 36462 RVA: 0x000CBB20 File Offset: 0x000C9D20
		public ADocumentationActor() : this(BuiltinUtils.AllocNativeUObject(ADocumentationActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008E6F RID: 36463 RVA: 0x000CBB48 File Offset: 0x000C9D48
		[NullableContext(1)]
		public ADocumentationActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ADocumentationActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008E70 RID: 36464 RVA: 0x000CBB7B File Offset: 0x000C9D7B
		static ADocumentationActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DocumentationActor");
		}

		// Token: 0x06008E71 RID: 36465 RVA: 0x000CBB89 File Offset: 0x000C9D89
		protected ADocumentationActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040043BE RID: 17342
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DocumentationActor";

		// Token: 0x040043BF RID: 17343
		private static IntPtr _ClassPtr;

		// Token: 0x040043C0 RID: 17344
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
