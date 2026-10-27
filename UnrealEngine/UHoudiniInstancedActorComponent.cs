using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014DC RID: 5340
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniInstancedActorComponent")]
	[UnrealStructLayout(592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 592)]
	public class UHoudiniInstancedActorComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601356E RID: 79214 RVA: 0x001C6F5A File Offset: 0x001C515A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniInstancedActorComponent._ClassPtr;
		}

		// Token: 0x0601356F RID: 79215 RVA: 0x001C6F68 File Offset: 0x001C5168
		public UHoudiniInstancedActorComponent() : this(BuiltinUtils.AllocNativeUObject(UHoudiniInstancedActorComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013570 RID: 79216 RVA: 0x001C6F90 File Offset: 0x001C5190
		public UHoudiniInstancedActorComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniInstancedActorComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B63 RID: 19299
		// (get) Token: 0x06013571 RID: 79217 RVA: 0x001C6FC3 File Offset: 0x001C51C3
		// (set) Token: 0x06013572 RID: 79218 RVA: 0x001C6FD7 File Offset: 0x001C51D7
		[Nullable(2)]
		public unsafe UObject InstancedObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniInstancedActorComponent.__PropertyOffset_InstancedObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniInstancedActorComponent.__PropertyOffset_InstancedObject, value);
			}
		}

		// Token: 0x17004B64 RID: 19300
		// (get) Token: 0x06013573 RID: 79219 RVA: 0x001C6FEC File Offset: 0x001C51EC
		// (set) Token: 0x06013574 RID: 79220 RVA: 0x001C7025 File Offset: 0x001C5225
		public TArray<AActor> InstancedActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AActor> result;
				if ((result = this._InstancedActors) == null)
				{
					result = (this._InstancedActors = new TArray<AActor>(base.NativePtr + (IntPtr)UHoudiniInstancedActorComponent.__PropertyOffset_InstancedActors, this));
				}
				return result;
			}
			set
			{
				this.InstancedActors.CopyAssign(value);
			}
		}

		// Token: 0x06013575 RID: 79221 RVA: 0x001C7033 File Offset: 0x001C5233
		static UHoudiniInstancedActorComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniInstancedActorComponent");
		}

		// Token: 0x06013576 RID: 79222 RVA: 0x001C7041 File Offset: 0x001C5241
		protected UHoudiniInstancedActorComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A727 RID: 42791
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniInstancedActorComponent";

		// Token: 0x0400A728 RID: 42792
		private static IntPtr _ClassPtr;

		// Token: 0x0400A729 RID: 42793
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A72A RID: 42794
		internal static int __PropertyOffset_InstancedObject;

		// Token: 0x0400A72B RID: 42795
		internal static int __PropertyOffset_InstancedActors;

		// Token: 0x0400A72C RID: 42796
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AActor> _InstancedActors;
	}
}
