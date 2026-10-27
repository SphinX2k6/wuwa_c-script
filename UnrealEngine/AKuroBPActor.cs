using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AB7 RID: 6839
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroBPActor")]
	[UnrealStructLayout(1432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1432)]
	public class AKuroBPActor : AKuroGameBudgetBlueprintActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019608 RID: 103944 RVA: 0x00257F82 File Offset: 0x00256182
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroBPActor._ClassPtr;
		}

		// Token: 0x06019609 RID: 103945 RVA: 0x00257F90 File Offset: 0x00256190
		public AKuroBPActor() : this(BuiltinUtils.AllocNativeUObject(AKuroBPActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601960A RID: 103946 RVA: 0x00257FB8 File Offset: 0x002561B8
		[NullableContext(1)]
		public AKuroBPActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroBPActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601960B RID: 103947 RVA: 0x00257FEB File Offset: 0x002561EB
		static AKuroBPActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroBPActor");
		}

		// Token: 0x0601960C RID: 103948 RVA: 0x00257FF9 File Offset: 0x002561F9
		protected AKuroBPActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DD41 RID: 56641
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBPActor";

		// Token: 0x0400DD42 RID: 56642
		private static IntPtr _ClassPtr;

		// Token: 0x0400DD43 RID: 56643
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
