using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000693 RID: 1683
	[UnrealObjectPath("/Script/LGUI.LGUIEventSystemActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class ALGUIEventSystemActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009165 RID: 37221 RVA: 0x000DAABD File Offset: 0x000D8CBD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALGUIEventSystemActor._ClassPtr;
		}

		// Token: 0x06009166 RID: 37222 RVA: 0x000DAACC File Offset: 0x000D8CCC
		public ALGUIEventSystemActor() : this(BuiltinUtils.AllocNativeUObject(ALGUIEventSystemActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009167 RID: 37223 RVA: 0x000DAAF4 File Offset: 0x000D8CF4
		[NullableContext(1)]
		public ALGUIEventSystemActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALGUIEventSystemActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x06009168 RID: 37224 RVA: 0x000DAB27 File Offset: 0x000D8D27
		// (set) Token: 0x06009169 RID: 37225 RVA: 0x000DAB3B File Offset: 0x000D8D3B
		[Nullable(2)]
		public unsafe ULGUIEventSystem EventSystem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUIEventSystem>(base.NativePtr / (IntPtr)sizeof(void*) + ALGUIEventSystemActor.__PropertyOffset_EventSystem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALGUIEventSystemActor.__PropertyOffset_EventSystem, value);
			}
		}

		// Token: 0x0600916A RID: 37226 RVA: 0x000DAB50 File Offset: 0x000D8D50
		public void PreDestroy()
		{
			ALGUIEventSystemActor.__PreDestroy_Internal(base.NativePtr);
		}

		// Token: 0x0600916B RID: 37227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PreDestroy_Internal(IntPtr @this);

		// Token: 0x0600916C RID: 37228 RVA: 0x000DAB5D File Offset: 0x000D8D5D
		static ALGUIEventSystemActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIEventSystemActor");
		}

		// Token: 0x0600916D RID: 37229 RVA: 0x000DAB6B File Offset: 0x000D8D6B
		protected ALGUIEventSystemActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003F65 RID: 16229
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIEventSystemActor";

		// Token: 0x04003F66 RID: 16230
		private static IntPtr _ClassPtr;

		// Token: 0x04003F67 RID: 16231
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003F68 RID: 16232
		internal static int __PropertyOffset_EventSystem;
	}
}
