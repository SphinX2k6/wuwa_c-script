using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020B1 RID: 8369
	[UnrealObjectPath("/Script/LGUI.LGUIPrefabHelperActor")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1088)]
	public class ALGUIPrefabHelperActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F8A5 RID: 129189 RVA: 0x002EE397 File Offset: 0x002EC597
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALGUIPrefabHelperActor._ClassPtr;
		}

		// Token: 0x0601F8A6 RID: 129190 RVA: 0x002EE3A4 File Offset: 0x002EC5A4
		public ALGUIPrefabHelperActor() : this(BuiltinUtils.AllocNativeUObject(ALGUIPrefabHelperActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F8A7 RID: 129191 RVA: 0x002EE3CC File Offset: 0x002EC5CC
		[NullableContext(1)]
		public ALGUIPrefabHelperActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALGUIPrefabHelperActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601F8A8 RID: 129192 RVA: 0x002EE3FF File Offset: 0x002EC5FF
		static ALGUIPrefabHelperActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPrefabHelperActor");
		}

		// Token: 0x0601F8A9 RID: 129193 RVA: 0x002EE40D File Offset: 0x002EC60D
		protected ALGUIPrefabHelperActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401106F RID: 69743
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIPrefabHelperActor";

		// Token: 0x04011070 RID: 69744
		private static IntPtr _ClassPtr;

		// Token: 0x04011071 RID: 69745
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
