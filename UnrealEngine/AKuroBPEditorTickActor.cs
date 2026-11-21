using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004B6 RID: 1206
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroBPEditorTickActor")]
	[UnrealStructLayout(1448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1448)]
	public class AKuroBPEditorTickActor : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006F30 RID: 28464 RVA: 0x000A48C6 File Offset: 0x000A2AC6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroBPEditorTickActor._ClassPtr;
		}

		// Token: 0x06006F31 RID: 28465 RVA: 0x000A48D4 File Offset: 0x000A2AD4
		public AKuroBPEditorTickActor() : this(BuiltinUtils.AllocNativeUObject(AKuroBPEditorTickActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006F32 RID: 28466 RVA: 0x000A48FC File Offset: 0x000A2AFC
		[NullableContext(1)]
		public AKuroBPEditorTickActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroBPEditorTickActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006F33 RID: 28467 RVA: 0x000A492F File Offset: 0x000A2B2F
		static AKuroBPEditorTickActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroBPEditorTickActor");
		}

		// Token: 0x06006F34 RID: 28468 RVA: 0x000A493D File Offset: 0x000A2B3D
		protected AKuroBPEditorTickActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003017 RID: 12311
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBPEditorTickActor";

		// Token: 0x04003018 RID: 12312
		private static IntPtr _ClassPtr;

		// Token: 0x04003019 RID: 12313
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
