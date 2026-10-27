using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AB8 RID: 6840
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroBPActorComponent")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UKuroBPActorComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601960D RID: 103949 RVA: 0x00258002 File Offset: 0x00256202
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBPActorComponent._ClassPtr;
		}

		// Token: 0x0601960E RID: 103950 RVA: 0x00258010 File Offset: 0x00256210
		public UKuroBPActorComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroBPActorComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601960F RID: 103951 RVA: 0x00258038 File Offset: 0x00256238
		[NullableContext(1)]
		public UKuroBPActorComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBPActorComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06019610 RID: 103952 RVA: 0x0025806B File Offset: 0x0025626B
		static UKuroBPActorComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroBPActorComponent");
		}

		// Token: 0x06019611 RID: 103953 RVA: 0x00258079 File Offset: 0x00256279
		protected UKuroBPActorComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DD44 RID: 56644
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBPActorComponent";

		// Token: 0x0400DD45 RID: 56645
		private static IntPtr _ClassPtr;

		// Token: 0x0400DD46 RID: 56646
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
