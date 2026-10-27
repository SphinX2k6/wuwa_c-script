using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020AF RID: 8367
	[UnrealObjectPath("/Script/LGUI.LGUIPrefabActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class ALGUIPrefabActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F89D RID: 129181 RVA: 0x002EE2EE File Offset: 0x002EC4EE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALGUIPrefabActor._ClassPtr;
		}

		// Token: 0x0601F89E RID: 129182 RVA: 0x002EE2FC File Offset: 0x002EC4FC
		public ALGUIPrefabActor() : this(BuiltinUtils.AllocNativeUObject(ALGUIPrefabActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F89F RID: 129183 RVA: 0x002EE324 File Offset: 0x002EC524
		[NullableContext(1)]
		public ALGUIPrefabActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALGUIPrefabActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C6A RID: 31850
		// (get) Token: 0x0601F8A0 RID: 129184 RVA: 0x002EE357 File Offset: 0x002EC557
		// (set) Token: 0x0601F8A1 RID: 129185 RVA: 0x002EE36B File Offset: 0x002EC56B
		[Nullable(2)]
		public unsafe ULGUIPrefabHelperComponent PrefabComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUIPrefabHelperComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ALGUIPrefabActor.__PropertyOffset_PrefabComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALGUIPrefabActor.__PropertyOffset_PrefabComponent, value);
			}
		}

		// Token: 0x0601F8A2 RID: 129186 RVA: 0x002EE380 File Offset: 0x002EC580
		static ALGUIPrefabActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPrefabActor");
		}

		// Token: 0x0601F8A3 RID: 129187 RVA: 0x002EE38E File Offset: 0x002EC58E
		protected ALGUIPrefabActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401106A RID: 69738
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIPrefabActor";

		// Token: 0x0401106B RID: 69739
		private static IntPtr _ClassPtr;

		// Token: 0x0401106C RID: 69740
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401106D RID: 69741
		internal static int __PropertyOffset_PrefabComponent;
	}
}
