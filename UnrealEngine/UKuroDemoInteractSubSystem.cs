using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EB6 RID: 7862
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroDemoInteractSubSystem")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UKuroDemoInteractSubSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DD73 RID: 122227 RVA: 0x002C2474 File Offset: 0x002C0674
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDemoInteractSubSystem._ClassPtr;
		}

		// Token: 0x0601DD74 RID: 122228 RVA: 0x002C2480 File Offset: 0x002C0680
		public UKuroDemoInteractSubSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroDemoInteractSubSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DD75 RID: 122229 RVA: 0x002C24A8 File Offset: 0x002C06A8
		public UKuroDemoInteractSubSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDemoInteractSubSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700779C RID: 30620
		// (get) Token: 0x0601DD76 RID: 122230 RVA: 0x002C24DC File Offset: 0x002C06DC
		// (set) Token: 0x0601DD77 RID: 122231 RVA: 0x002C2515 File Offset: 0x002C0715
		public FDemoInteractiveActorMapUpdateDelegate OnDemoInteractiveActorAdd
		{
			get
			{
				base.FastCheckIsValid();
				FDemoInteractiveActorMapUpdateDelegate result;
				if ((result = this._OnDemoInteractiveActorAdd) == null)
				{
					result = (this._OnDemoInteractiveActorAdd = new FDemoInteractiveActorMapUpdateDelegate(base.NativePtr + (IntPtr)UKuroDemoInteractSubSystem.__PropertyOffset_OnDemoInteractiveActorAdd, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroDemoInteractSubSystem.__PropertyOffset_OnDemoInteractiveActorAdd, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700779D RID: 30621
		// (get) Token: 0x0601DD78 RID: 122232 RVA: 0x002C2538 File Offset: 0x002C0738
		// (set) Token: 0x0601DD79 RID: 122233 RVA: 0x002C2571 File Offset: 0x002C0771
		public FDemoInteractiveActorMapUpdateDelegate OnDemoInteractiveActorRemove
		{
			get
			{
				base.FastCheckIsValid();
				FDemoInteractiveActorMapUpdateDelegate result;
				if ((result = this._OnDemoInteractiveActorRemove) == null)
				{
					result = (this._OnDemoInteractiveActorRemove = new FDemoInteractiveActorMapUpdateDelegate(base.NativePtr + (IntPtr)UKuroDemoInteractSubSystem.__PropertyOffset_OnDemoInteractiveActorRemove, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroDemoInteractSubSystem.__PropertyOffset_OnDemoInteractiveActorRemove, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700779E RID: 30622
		// (get) Token: 0x0601DD7A RID: 122234 RVA: 0x002C2594 File Offset: 0x002C0794
		// (set) Token: 0x0601DD7B RID: 122235 RVA: 0x002C25CD File Offset: 0x002C07CD
		public TMap<FName, AActor> DemoInteractiveActorMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, AActor> result;
				if ((result = this._DemoInteractiveActorMap) == null)
				{
					result = (this._DemoInteractiveActorMap = new TMap<FName, AActor>(base.NativePtr + (IntPtr)UKuroDemoInteractSubSystem.__PropertyOffset_DemoInteractiveActorMap, this));
				}
				return result;
			}
			set
			{
				this.DemoInteractiveActorMap.CopyAssign(value);
			}
		}

		// Token: 0x0601DD7C RID: 122236 RVA: 0x002C25DB File Offset: 0x002C07DB
		[NullableContext(2)]
		public AActor GetDemoInteractiveActor(FName ActorKey)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroDemoInteractSubSystem.__GetDemoInteractiveActor_Internal(base.NativePtr, ActorKey));
		}

		// Token: 0x0601DD7D RID: 122237
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDemoInteractiveActor_Internal(IntPtr @this, FName ActorKey);

		// Token: 0x0601DD7E RID: 122238 RVA: 0x002C25EE File Offset: 0x002C07EE
		static UKuroDemoInteractSubSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroDemoInteractSubSystem");
		}

		// Token: 0x0601DD7F RID: 122239 RVA: 0x002C25FC File Offset: 0x002C07FC
		protected UKuroDemoInteractSubSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040102B2 RID: 66226
		public new const string __ObjectPath = "/Script/KuroUtility.KuroDemoInteractSubSystem";

		// Token: 0x040102B3 RID: 66227
		private static IntPtr _ClassPtr;

		// Token: 0x040102B4 RID: 66228
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040102B5 RID: 66229
		internal static int __PropertyOffset_OnDemoInteractiveActorAdd;

		// Token: 0x040102B6 RID: 66230
		[Nullable(2)]
		private FDemoInteractiveActorMapUpdateDelegate _OnDemoInteractiveActorAdd;

		// Token: 0x040102B7 RID: 66231
		internal static int __PropertyOffset_OnDemoInteractiveActorRemove;

		// Token: 0x040102B8 RID: 66232
		[Nullable(2)]
		private FDemoInteractiveActorMapUpdateDelegate _OnDemoInteractiveActorRemove;

		// Token: 0x040102B9 RID: 66233
		internal static int __PropertyOffset_DemoInteractiveActorMap;

		// Token: 0x040102BA RID: 66234
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, AActor> _DemoInteractiveActorMap;
	}
}
