using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EA7 RID: 7847
	[UnrealObjectPath("/Script/KuroUtility.KuroActorComponent")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UKuroActorComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DCBA RID: 122042 RVA: 0x002C095C File Offset: 0x002BEB5C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroActorComponent._ClassPtr;
		}

		// Token: 0x0601DCBB RID: 122043 RVA: 0x002C0968 File Offset: 0x002BEB68
		public UKuroActorComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroActorComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DCBC RID: 122044 RVA: 0x002C0990 File Offset: 0x002BEB90
		[NullableContext(1)]
		public UKuroActorComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroActorComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DCBD RID: 122045 RVA: 0x002C09C3 File Offset: 0x002BEBC3
		public virtual void EditorTickComponent(float DeltaTime)
		{
			UKuroActorComponent.__EditorTickComponent_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x0601DCBE RID: 122046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EditorTickComponent_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x0601DCBF RID: 122047 RVA: 0x002C09D1 File Offset: 0x002BEBD1
		static UKuroActorComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroActorComponent");
		}

		// Token: 0x0601DCC0 RID: 122048 RVA: 0x002C09DF File Offset: 0x002BEBDF
		protected UKuroActorComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010248 RID: 66120
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroActorComponent";

		// Token: 0x04010249 RID: 66121
		private static IntPtr _ClassPtr;

		// Token: 0x0401024A RID: 66122
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x020032ED RID: 13037
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __EditorTickComponent_FunctionParams
		{
			// Token: 0x0401719E RID: 94622
			[FieldOffset(0)]
			public float DeltaTime;
		}
	}
}
