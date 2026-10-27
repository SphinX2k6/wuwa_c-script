using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B3A RID: 6970
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerComponentDebugDraw")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UKuroMaterialControllerComponentDebugDraw : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A61F RID: 108063 RVA: 0x0026E563 File Offset: 0x0026C763
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMaterialControllerComponentDebugDraw._ClassPtr;
		}

		// Token: 0x0601A620 RID: 108064 RVA: 0x0026E570 File Offset: 0x0026C770
		public UKuroMaterialControllerComponentDebugDraw() : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialControllerComponentDebugDraw.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A621 RID: 108065 RVA: 0x0026E598 File Offset: 0x0026C798
		[NullableContext(1)]
		public UKuroMaterialControllerComponentDebugDraw(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMaterialControllerComponentDebugDraw.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601A622 RID: 108066 RVA: 0x0026E5CB File Offset: 0x0026C7CB
		static UKuroMaterialControllerComponentDebugDraw()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerComponentDebugDraw");
		}

		// Token: 0x0601A623 RID: 108067 RVA: 0x0026E5D9 File Offset: 0x0026C7D9
		protected UKuroMaterialControllerComponentDebugDraw(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E4BB RID: 58555
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerComponentDebugDraw";

		// Token: 0x0400E4BC RID: 58556
		private static IntPtr _ClassPtr;

		// Token: 0x0400E4BD RID: 58557
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
