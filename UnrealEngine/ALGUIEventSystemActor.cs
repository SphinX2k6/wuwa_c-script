using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002071 RID: 8305
	[UnrealObjectPath("/Script/LGUI.LGUIEventSystemActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class ALGUIEventSystemActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F568 RID: 128360 RVA: 0x002E8995 File Offset: 0x002E6B95
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALGUIEventSystemActor._ClassPtr;
		}

		// Token: 0x0601F569 RID: 128361 RVA: 0x002E89A4 File Offset: 0x002E6BA4
		public ALGUIEventSystemActor() : this(BuiltinUtils.AllocNativeUObject(ALGUIEventSystemActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F56A RID: 128362 RVA: 0x002E89CC File Offset: 0x002E6BCC
		[NullableContext(1)]
		public ALGUIEventSystemActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALGUIEventSystemActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007BC9 RID: 31689
		// (get) Token: 0x0601F56B RID: 128363 RVA: 0x002E89FF File Offset: 0x002E6BFF
		// (set) Token: 0x0601F56C RID: 128364 RVA: 0x002E8A13 File Offset: 0x002E6C13
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

		// Token: 0x0601F56D RID: 128365 RVA: 0x002E8A28 File Offset: 0x002E6C28
		public void PreDestroy()
		{
			ALGUIEventSystemActor.__PreDestroy_Internal(base.NativePtr);
		}

		// Token: 0x0601F56E RID: 128366
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PreDestroy_Internal(IntPtr @this);

		// Token: 0x0601F56F RID: 128367 RVA: 0x002E8A35 File Offset: 0x002E6C35
		static ALGUIEventSystemActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIEventSystemActor");
		}

		// Token: 0x0601F570 RID: 128368 RVA: 0x002E8A43 File Offset: 0x002E6C43
		protected ALGUIEventSystemActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010EF8 RID: 69368
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIEventSystemActor";

		// Token: 0x04010EF9 RID: 69369
		private static IntPtr _ClassPtr;

		// Token: 0x04010EFA RID: 69370
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010EFB RID: 69371
		internal static int __PropertyOffset_EventSystem;
	}
}
