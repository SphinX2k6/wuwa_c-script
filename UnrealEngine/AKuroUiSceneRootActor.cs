using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BD8 RID: 7128
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneRootActor")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AKuroUiSceneRootActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B5C3 RID: 112067 RVA: 0x00285072 File Offset: 0x00283272
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroUiSceneRootActor._ClassPtr;
		}

		// Token: 0x0601B5C4 RID: 112068 RVA: 0x00285080 File Offset: 0x00283280
		public AKuroUiSceneRootActor() : this(BuiltinUtils.AllocNativeUObject(AKuroUiSceneRootActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B5C5 RID: 112069 RVA: 0x002850A8 File Offset: 0x002832A8
		[NullableContext(1)]
		public AKuroUiSceneRootActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroUiSceneRootActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601B5C6 RID: 112070 RVA: 0x002850DB File Offset: 0x002832DB
		static AKuroUiSceneRootActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneRootActor");
		}

		// Token: 0x0601B5C7 RID: 112071 RVA: 0x002850E9 File Offset: 0x002832E9
		protected AKuroUiSceneRootActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EBB3 RID: 60339
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneRootActor";

		// Token: 0x0400EBB4 RID: 60340
		private static IntPtr _ClassPtr;

		// Token: 0x0400EBB5 RID: 60341
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
