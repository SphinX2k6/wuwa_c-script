using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002163 RID: 8547
	[UnrealObjectPath("/Script/LGUI.UIEventBlocker")]
	[UnrealStructLayout(1688, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1688)]
	public class AUIEventBlocker : AUIContainerActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060203C0 RID: 132032 RVA: 0x002FDCA1 File Offset: 0x002FBEA1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUIEventBlocker._ClassPtr;
		}

		// Token: 0x060203C1 RID: 132033 RVA: 0x002FDCB0 File Offset: 0x002FBEB0
		public AUIEventBlocker() : this(BuiltinUtils.AllocNativeUObject(AUIEventBlocker.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060203C2 RID: 132034 RVA: 0x002FDCD8 File Offset: 0x002FBED8
		[NullableContext(1)]
		public AUIEventBlocker(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUIEventBlocker.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060203C3 RID: 132035 RVA: 0x002FDD0B File Offset: 0x002FBF0B
		static AUIEventBlocker()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEventBlocker");
		}

		// Token: 0x060203C4 RID: 132036 RVA: 0x002FDD19 File Offset: 0x002FBF19
		protected AUIEventBlocker(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011518 RID: 70936
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEventBlocker";

		// Token: 0x04011519 RID: 70937
		private static IntPtr _ClassPtr;

		// Token: 0x0401151A RID: 70938
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
