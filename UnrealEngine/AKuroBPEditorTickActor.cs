using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ABA RID: 6842
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroBPEditorTickActor")]
	[UnrealStructLayout(1448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1448)]
	public class AKuroBPEditorTickActor : AKuroEditorTickActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019617 RID: 103959 RVA: 0x00258102 File Offset: 0x00256302
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroBPEditorTickActor._ClassPtr;
		}

		// Token: 0x06019618 RID: 103960 RVA: 0x00258110 File Offset: 0x00256310
		public AKuroBPEditorTickActor() : this(BuiltinUtils.AllocNativeUObject(AKuroBPEditorTickActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019619 RID: 103961 RVA: 0x00258138 File Offset: 0x00256338
		[NullableContext(1)]
		public AKuroBPEditorTickActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroBPEditorTickActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601961A RID: 103962 RVA: 0x0025816B File Offset: 0x0025636B
		static AKuroBPEditorTickActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroBPEditorTickActor");
		}

		// Token: 0x0601961B RID: 103963 RVA: 0x00258179 File Offset: 0x00256379
		protected AKuroBPEditorTickActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DD4A RID: 56650
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBPEditorTickActor";

		// Token: 0x0400DD4B RID: 56651
		private static IntPtr _ClassPtr;

		// Token: 0x0400DD4C RID: 56652
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
