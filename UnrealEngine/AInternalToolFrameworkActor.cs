using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001582 RID: 5506
	[UnrealObjectPath("/Script/InteractiveToolsFramework.InternalToolFrameworkActor")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AInternalToolFrameworkActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013E3C RID: 81468 RVA: 0x001D3431 File Offset: 0x001D1631
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AInternalToolFrameworkActor._ClassPtr;
		}

		// Token: 0x06013E3D RID: 81469 RVA: 0x001D3440 File Offset: 0x001D1640
		public AInternalToolFrameworkActor() : this(BuiltinUtils.AllocNativeUObject(AInternalToolFrameworkActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E3E RID: 81470 RVA: 0x001D3468 File Offset: 0x001D1668
		[NullableContext(1)]
		public AInternalToolFrameworkActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AInternalToolFrameworkActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013E3F RID: 81471 RVA: 0x001D349B File Offset: 0x001D169B
		static AInternalToolFrameworkActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.InternalToolFrameworkActor");
		}

		// Token: 0x06013E40 RID: 81472 RVA: 0x001D34A9 File Offset: 0x001D16A9
		protected AInternalToolFrameworkActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC35 RID: 44085
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.InternalToolFrameworkActor";

		// Token: 0x0400AC36 RID: 44086
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC37 RID: 44087
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
